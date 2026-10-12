import fs from 'fs';
import path from 'path';
import readline from 'readline';
import { fileURLToPath } from 'url';

const __filename = fileURLToPath(import.meta.url);
const __dirname = path.dirname(__filename);

// Configurações
const PROJECT_ROOT = path.resolve(__dirname, '../../../../');
const DATABASE_DIR = path.join(PROJECT_ROOT, 'produto-padrao/database');
const TABLE_INDEX_PATH = path.join(PROJECT_ROOT, '.agents/skills/datasul-database-consultant/docs/database/TABLE_INDEX.md');
const SEARCH_OUTPUT_DIR = path.join(PROJECT_ROOT, '.agents/skills/datasul-field-details/docs/searches');
const DETAIL_OUTPUT_DIR = path.join(PROJECT_ROOT, '.agents/skills/datasul-field-details/docs/details');

function fixEncoding(text) {
    if (!text) return text;
    // Map common CP850 characters (read as latin1) to UTF-8
    const map = {
        '\u0087': 'ç',
        '\u00c6': 'ã',
        '\u00e4': 'õ',
        '\u0082': 'é',
        '\u00a1': 'í',
        '\u00a2': 'ó',
        '\u00a3': 'ú',
        '\u0083': 'â',
        '\u0088': 'ê',
        '\u0093': 'ô',
        '\u0080': 'Ç',
        '\u0085': 'à',
        '\u0090': 'É'
    };
    return text.replace(/[\u0080-\u00ff]/g, match => map[match] || match);
}

async function findFilePath(includeRelative) {
    if (!includeRelative) return null;
    const parts = includeRelative.split(/[\\/]/);
    const fileName = parts.pop();
    const folderHint = parts.pop();

    function search(dir) {
        if (dir.includes('node_modules') || dir.includes('.git')) return null;
        try {
            const files = fs.readdirSync(dir);
            for (const file of files) {
                const fullPath = path.join(dir, file);
                const stat = fs.statSync(fullPath);
                if (stat.isDirectory()) {
                    const found = search(fullPath);
                    if (found) return found;
                } else if (file.toLowerCase() === fileName.toLowerCase()) {
                    if (!folderHint || path.basename(dir).toLowerCase() === folderHint.toLowerCase()) {
                        return fullPath;
                    }
                }
            }
        } catch (e) {}
        return null;
    }

    const priorityDirs = ['EMS2', 'crm', 'foundation', 'gestao-planos', 'produto-padrao'];
    for (const pDir of priorityDirs) {
        const fullPDir = path.join(PROJECT_ROOT, pDir);
        if (fs.existsSync(fullPDir)) {
            const found = search(fullPDir);
            if (found) return found;
        }
    }

    return search(PROJECT_ROOT);
}

async function getDatabasesForTable(tableName) {
    if (!fs.existsSync(TABLE_INDEX_PATH)) {
        throw new Error(`Índice de tabelas não encontrado em: ${TABLE_INDEX_PATH}`);
    }

    const content = fs.readFileSync(TABLE_INDEX_PATH, 'utf8');
    const regex = new RegExp(`\\| ${tableName.toUpperCase()} \\| (.*) \\|`, 'i');
    const match = content.match(regex);
    
    if (!match) return [];
    
    const dbMatches = match[1].matchAll(/\[(.*?)\]/g);
    return Array.from(dbMatches, m => m[1]);
}

async function searchFieldInAllDFs(fieldName) {
    const dfs = fs.readdirSync(DATABASE_DIR).filter(f => f.endsWith('.df'));
    const results = [];
    const fieldUpper = fieldName.toUpperCase();

    for (const dfFile of dfs) {
        const dbName = dfFile.replace('.df', '');
        const dfPath = path.join(DATABASE_DIR, dfFile);
        
        const fileStream = fs.createReadStream(dfPath, { encoding: 'latin1' });
        const rl = readline.createInterface({
            input: fileStream,
            crlfDelay: Infinity
        });

        for await (const line of rl) {
            const trimmed = line.trim();
            // ADD FIELD "cod-estabel" OF "item" AS character 
            if (trimmed.startsWith('ADD FIELD "')) {
                const match = trimmed.match(/ADD FIELD "([^"]*)" OF "([^"]*)"/i);
                if (match && match[1].toUpperCase() === fieldUpper) {
                    results.push({
                        database: dbName,
                        table: match[2].toLowerCase()
                    });
                }
            }
        }
    }
    return results;
}

async function getFieldDetails(dbName, tableName, fieldName) {
    const dfPath = path.join(DATABASE_DIR, `${dbName}.df`);
    const fileStream = fs.createReadStream(dfPath, { encoding: 'latin1' });
    const rl = readline.createInterface({
        input: fileStream,
        crlfDelay: Infinity
    });

    const targetTable = tableName.toLowerCase();
    const targetField = fieldName.toLowerCase();
    
    let fieldData = null;
    let currentBlock = null;

    for await (const line of rl) {
        const trimmed = line.trim();

        if (trimmed.startsWith('ADD FIELD "')) {
            const match = trimmed.match(/ADD FIELD "([^"]*)" OF "([^"]*)" AS (.*)/i);
            if (match && match[1].toLowerCase() === targetField && match[2].toLowerCase() === targetTable) {
                currentBlock = 'FIELD';
                fieldData = {
                    name: match[1],
                    table: match[2],
                    database: dbName,
                    type: match[3].trim(),
                    label: '',
                    format: '',
                    initial: '',
                    mandatory: false,
                    description: '',
                    help: '',
                    columnLabel: '',
                    decimals: null,
                    extent: null,
                    viewAs: null
                };
            } else {
                currentBlock = null;
            }
            continue;
        }

        if (currentBlock === 'FIELD' && fieldData) {
            if (trimmed.startsWith('LABEL "')) {
                const m = trimmed.match(/"([^"]*)"/);
                if (m) fieldData.label = fixEncoding(m[1]);
            } else if (trimmed.startsWith('FORMAT "')) {
                const m = trimmed.match(/"([^"]*)"/);
                if (m) fieldData.format = m[1];
            } else if (trimmed.startsWith('INITIAL "')) {
                const m = trimmed.match(/"([^"]*)"/);
                if (m) fieldData.initial = m[1];
            } else if (trimmed.startsWith('DESCRIPTION "')) {
                const m = trimmed.match(/"([^"]*)"/);
                if (m) fieldData.description = fixEncoding(m[1]);
            } else if (trimmed.startsWith('HELP "')) {
                const m = trimmed.match(/"([^"]*)"/);
                if (m) fieldData.help = fixEncoding(m[1]);
            } else if (trimmed.startsWith('COLUMN-LABEL "')) {
                const m = trimmed.match(/"([^"]*)"/);
                if (m) fieldData.columnLabel = fixEncoding(m[1]);
            } else if (trimmed.startsWith('VIEW-AS "')) {
                const m = trimmed.match(/"([^"]*)"/);
                if (m) fieldData.viewAs = m[1];
            } else if (trimmed.startsWith('DECIMALS ')) {
                fieldData.decimals = trimmed.split(/\s+/)[1];
            } else if (trimmed.startsWith('EXTENT ')) {
                fieldData.extent = trimmed.split(/\s+/)[1];
            } else if (trimmed === 'MANDATORY') {
                fieldData.mandatory = true;
            } else if (trimmed.startsWith('ADD ')) {
                // Fim do bloco de campo
                break;
            }
        }
    }

    return fieldData;
}

function generateSearchMD(fieldName, results) {
    let md = `# Busca de Campo: ${fieldName}\n\n`;
    md += `Encontrado em ${results.length} tabelas.\n\n`;
    md += `| Banco | Tabela |\n`;
    md += `| :--- | :--- |\n`;
    
    for (const res of results) {
        md += `| ${res.database} | ${res.table} |\n`;
    }
    
    md += `\n**Gerado em**: ${new Date().toLocaleString('pt-BR')}\n`;
    return md;
}

async function generateDetailMD(fieldData) {
    let md = `# Detalhes do Campo: ${fieldData.table}.${fieldData.name}\n\n`;
    md += `- **Banco**: ${fieldData.database}\n`;
    md += `- **Tabela**: ${fieldData.table}\n`;
    md += `- **Tipo**: ${fieldData.type}\n`;
    md += `- **Label**: ${fieldData.label || ''}\n`;
    md += `- **Formato**: ${fieldData.format || ''}\n`;
    md += `- **Inicial**: ${fieldData.initial || ''}\n`;
    md += `- **Obrigatório**: ${fieldData.mandatory ? 'Sim' : 'Não'}\n`;
    if (fieldData.columnLabel) md += `- **Column Label**: ${fieldData.columnLabel}\n`;
    if (fieldData.decimals) md += `- **Decimais**: ${fieldData.decimals}\n`;
    if (fieldData.extent) md += `- **Extent**: ${fieldData.extent}\n`;
    
    if (fieldData.viewAs) {
        let viewAsFormatted = fieldData.viewAs;
        // Search for files in {path/file.i} or path/file.p
        const fileMatches = fieldData.viewAs.matchAll(/\{?([^ \t\r\n,{}]+\.[piw])\}?/gi);
        for (const match of fileMatches) {
            const fileRef = match[1];
            const filePath = await findFilePath(fileRef);
            if (filePath) {
                const link = `[${fileRef}](file:///${filePath.replace(/\\/g, '/')})`;
                viewAsFormatted = viewAsFormatted.replace(fileRef, link);
            }
        }
        md += `- **View-As**: ${viewAsFormatted}\n`;
    }

    if (fieldData.description) md += `\n### Descrição\n${fieldData.description}\n`;
    if (fieldData.help) md += `\n### Help\n${fieldData.help}\n`;
    
    md += `\n**Gerado em**: ${new Date().toLocaleString('pt-BR')}\n`;
    return md;
}

async function main() {
    const input = process.argv[2];
    let dbName = process.argv[3];

    if (!input) {
        process.exit(1);
    }

    try {
        if (input.includes('.')) {
            // DETAIL MODE: table.field
            const [tableName, fieldName] = input.split('.');
            
            const dbs = await getDatabasesForTable(tableName);
            if (dbs.length === 0) {
                console.error(`ERRO: Tabela ${tableName} não encontrada no índice.`);
                process.exit(1);
            }

            if (dbs.length > 1 && !dbName) {
                console.log(`AMBIGUIDADE:${dbs.join(',')}`);
                process.exit(0);
            }

            if (!dbName) dbName = dbs[0];

            const outputPath = path.join(DETAIL_OUTPUT_DIR, `${tableName}.${fieldName}.md`);
            const dfPath = path.join(DATABASE_DIR, `${dbName}.df`);

            // Cache validation
            if (fs.existsSync(outputPath)) {
                const dfStat = fs.statSync(dfPath);
                const mdStat = fs.statSync(outputPath);
                if (dfStat.mtime <= mdStat.mtime) {
                    console.log(outputPath);
                    return;
                }
            }

            const fieldData = await getFieldDetails(dbName, tableName, fieldName);
            if (!fieldData) {
                console.error(`ERRO: Campo ${fieldName} não encontrado na tabela ${tableName}.`);
                process.exit(1);
            }

            const md = await generateDetailMD(fieldData);
            if (!fs.existsSync(DETAIL_OUTPUT_DIR)) fs.mkdirSync(DETAIL_OUTPUT_DIR, { recursive: true });
            fs.writeFileSync(outputPath, md);
            console.log(outputPath);

        } else {
            // SEARCH MODE: fieldName
            const fieldName = input;
            const outputPath = path.join(SEARCH_OUTPUT_DIR, `${fieldName}.md`);

            // Cache validation (check if any .df is newer)
            if (fs.existsSync(outputPath)) {
                const mdStat = fs.statSync(outputPath);
                const dfs = fs.readdirSync(DATABASE_DIR).filter(f => f.endsWith('.df'));
                let anyNewer = false;
                for (const dfFile of dfs) {
                    if (fs.statSync(path.join(DATABASE_DIR, dfFile)).mtime > mdStat.mtime) {
                        anyNewer = true;
                        break;
                    }
                }
                if (!anyNewer) {
                    console.log(outputPath);
                    return;
                }
            }

            const results = await searchFieldInAllDFs(fieldName);
            if (results.length === 0) {
                console.error(`ERRO: Campo ${fieldName} não encontrado em nenhuma tabela.`);
                process.exit(1);
            }

            const md = generateSearchMD(fieldName, results);
            if (!fs.existsSync(SEARCH_OUTPUT_DIR)) fs.mkdirSync(SEARCH_OUTPUT_DIR, { recursive: true });
            fs.writeFileSync(outputPath, md);
            console.log(outputPath);
        }
    } catch (err) {
        console.error(err);
        process.exit(1);
    }
}

main();
