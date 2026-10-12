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
const OUTPUT_DIR = path.join(PROJECT_ROOT, '.agents/skills/datasul-table-details/docs/tables');

async function getDatabasesForTable(tableName) {
    if (!fs.existsSync(TABLE_INDEX_PATH)) {
        throw new Error(`Índice de tabelas não encontrado em: ${TABLE_INDEX_PATH}`);
    }

    const content = fs.readFileSync(TABLE_INDEX_PATH, 'utf8');
    // Pattern: | Tabela | [mg](./mg.md), [ems](./ems.md) |
    const regex = new RegExp(`\\| ${tableName.toUpperCase()} \\| (.*) \\|`, 'i');
    const match = content.match(regex);
    
    if (!match) return [];
    
    // Extrai nomes dos bancos dos links
    const dbMatches = match[1].matchAll(/\[(.*?)\]/g);
    return Array.from(dbMatches, m => m[1]);
}

async function parseTableFromDF(dfPath, targetTable) {
    const fileStream = fs.createReadStream(dfPath, { encoding: 'latin1' });
    const rl = readline.createInterface({
        input: fileStream,
        crlfDelay: Infinity
    });

    let tableData = {
        name: targetTable,
        label: '',
        description: '',
        fields: [],
        indices: [],
        triggers: []
    };

    let currentBlock = null; 
    let currentObject = null;
    let foundTable = false;

    const targetUpper = targetTable.toLowerCase();

    for await (const line of rl) {
        const trimmed = line.trim();

        if (trimmed.startsWith('ADD TABLE "')) {
            const match = trimmed.match(/"([^"]*)"/);
            if (match) {
                const name = match[1];
                if (name.toLowerCase() === targetUpper) {
                    currentBlock = 'TABLE';
                    currentObject = tableData;
                    foundTable = true;
                } else {
                    currentBlock = null;
                }
            }
            continue;
        }

        if (trimmed.startsWith('ADD FIELD "')) {
            const fieldMatch = trimmed.match(/ADD FIELD "([^"]*)" OF "([^"]*)" AS (.*)/i);
            if (fieldMatch && fieldMatch[2].toLowerCase() === targetUpper) {
                currentBlock = 'FIELD';
                currentObject = {
                    name: fieldMatch[1],
                    type: fieldMatch[3].trim(),
                    label: '',
                    format: '',
                    initial: '',
                    help: '',
                    mandatory: false,
                    description: '',
                    columnLabel: '',
                    decimals: null,
                    extent: null,
                    viewAs: null,
                    include: null,
                    includePath: null
                };
                tableData.fields.push(currentObject);
            } else {
                currentBlock = null;
            }
            continue;
        }

        if (trimmed.startsWith('ADD INDEX "')) {
            const indexMatch = trimmed.match(/ADD INDEX "([^"]*)" ON "([^"]*)"/i);
            if (indexMatch && indexMatch[2].toLowerCase() === targetUpper) {
                currentBlock = 'INDEX';
                currentObject = {
                    name: indexMatch[1],
                    unique: false,
                    primary: false,
                    fields: []
                };
                tableData.indices.push(currentObject);
            } else {
                currentBlock = null;
            }
            continue;
        }

        if (!currentBlock || !currentObject) continue;

        if (currentBlock === 'TABLE') {
            if (trimmed.startsWith('LABEL "')) {
                const m = trimmed.match(/"([^"]*)"/);
                if (m) currentObject.label = m[1];
            }
            if (trimmed.startsWith('DESCRIPTION "')) {
                const m = trimmed.match(/"([^"]*)"/);
                if (m) currentObject.description = m[1];
            }
            if (trimmed.startsWith('TABLE-TRIGGER "')) {
                const m = trimmed.match(/TABLE-TRIGGER "([^"]*)"(?: OVERRIDE)? PROCEDURE "([^"]*)"/i);
                if (m) {
                    currentObject.triggers = currentObject.triggers || [];
                    currentObject.triggers.push({
                        event: m[1],
                        procedure: m[2],
                        path: null
                    });
                }
            }
        } else if (currentBlock === 'FIELD') {
            if (trimmed.startsWith('LABEL "')) {
                const m = trimmed.match(/"([^"]*)"/);
                if (m) currentObject.label = m[1];
            }
            if (trimmed.startsWith('FORMAT "')) {
                const m = trimmed.match(/"([^"]*)"/);
                if (m) currentObject.format = m[1];
            }
            if (trimmed.startsWith('INITIAL "')) {
                const m = trimmed.match(/"([^"]*)"/);
                if (m) currentObject.initial = m[1];
            }
            if (trimmed.startsWith('HELP "')) {
                const m = trimmed.match(/"([^"]*)"/);
                if (m) currentObject.help = m[1];
            }
            if (trimmed.startsWith('DESCRIPTION "')) {
                const m = trimmed.match(/"([^"]*)"/);
                if (m) currentObject.description = m[1];
            }
            if (trimmed.startsWith('COLUMN-LABEL "')) {
                const m = trimmed.match(/"([^"]*)"/);
                if (m) currentObject.columnLabel = m[1];
            }
            if (trimmed.startsWith('VIEW-AS "')) {
                const m = trimmed.match(/"([^"]*)"/);
                if (m) {
                    currentObject.viewAs = m[1];
                    const incMatch = m[1].match(/\{([^ \t\r\n]+\.i)/);
                    if (incMatch) {
                        currentObject.include = incMatch[1];
                    }
                }
            }
            if (trimmed.startsWith('DECIMALS ')) {
                currentObject.decimals = trimmed.split(/\s+/)[1];
            }
            if (trimmed.startsWith('EXTENT ')) {
                currentObject.extent = trimmed.split(/\s+/)[1];
            }
            if (trimmed === 'MANDATORY') currentObject.mandatory = true;
        } else if (currentBlock === 'INDEX') {
            if (trimmed === 'UNIQUE') currentObject.unique = true;
            if (trimmed === 'PRIMARY') currentObject.primary = true;
            if (trimmed.startsWith('INDEX-FIELD "')) {
                const m = trimmed.match(/"([^"]*)"/);
                if (m) currentObject.fields.push(m[1]);
            }
        }
    }

    // Resolve include paths
    console.log("Resolvendo caminhos de includes e triggers...");
    for (const f of tableData.fields) {
        if (f.include) {
            f.includePath = await findIncludePath(f.include);
        }
    }

    if (tableData.triggers && tableData.triggers.length > 0) {
        for (const t of tableData.triggers) {
            t.path = await findIncludePath(t.procedure);
        }
    }

    return foundTable ? tableData : null;
}

let fileCache = null;

async function buildFileCache() {
    if (fileCache) return;
    fileCache = new Map();
    
    function walk(dir) {
        if (dir.includes('node_modules') || dir.includes('.git')) return;
        try {
            const files = fs.readdirSync(dir);
            for (const file of files) {
                const fullPath = path.join(dir, file);
                const stat = fs.statSync(fullPath);
                if (stat.isDirectory()) {
                    walk(fullPath);
                } else {
                    const lowerName = file.toLowerCase();
                    if (!fileCache.has(lowerName)) {
                        fileCache.set(lowerName, []);
                    }
                    fileCache.get(lowerName).push(fullPath);
                }
            }
        } catch (e) {}
    }
    
    // Walk priority dirs inside produto-padrao first
    const priorityDirs = ['EMS2', 'crm', 'foundation', 'gestao-planos'];
    for (const pDir of priorityDirs) {
        const fullPDir = path.join(PROJECT_ROOT, 'produto-padrao', pDir);
        if (fs.existsSync(fullPDir)) {
            walk(fullPDir);
        }
    }
    
    // Walk the rest of the project
    walk(PROJECT_ROOT);
}

async function findIncludePath(includeRelative) {
    await buildFileCache();
    
    const parts = includeRelative.split(/[\\/]/);
    const fileName = parts.pop().toLowerCase();
    const folderHint = parts.pop()?.toLowerCase();
    
    const paths = fileCache.get(fileName);
    if (!paths || paths.length === 0) return null;
    
    if (folderHint) {
        for (const p of paths) {
            const dirName = path.basename(path.dirname(p)).toLowerCase();
            if (dirName === folderHint) {
                return p;
            }
        }
    }
    
    return paths[0];
}

function generateMarkdown(tableData, dbName) {
    let md = `# Tabela: ${tableData.name}\n\n`;
    md += `**Banco de Dados**: ${dbName}\n`;
    if (tableData.label) md += `**Label**: ${tableData.label}\n`;
    if (tableData.description) md += `**Descrição**: ${tableData.description}\n`;
    md += `**Gerado em**: ${new Date().toLocaleString('pt-BR')}\n\n`;

    md += `## Campos\n\n`;
    md += `| Campo | Tipo | Label | Formato | Inicial | Obrig. | Include | Help |\n`;
    md += `| :--- | :--- | :--- | :--- | :--- | :--- | :--- | :--- |\n`;

    for (const f of tableData.fields) {
        let includeLink = '';
        if (f.include) {
            if (f.includePath) {
                includeLink = `[${f.include}](file:///${f.includePath.replace(/\\/g, '/')})`;
            } else {
                includeLink = `\`${f.include}\` (ñ enc.)`;
            }
        }
        md += `| ${f.name} | ${f.type} | ${f.label || ''} | ${f.format || ''} | ${f.initial || ''} | ${f.mandatory ? 'Sim' : 'Não'} | ${includeLink} | ${f.help || ''} |\n`;
    }

    if (tableData.triggers && tableData.triggers.length > 0) {
        md += `\n## Triggers\n\n`;
        md += `| Evento | Procedure | Link |\n`;
        md += `| :--- | :--- | :--- |\n`;
        for (const t of tableData.triggers) {
            let procLink = `\`${t.procedure}\` (ñ enc.)`;
            if (t.path) {
                procLink = `[Abrir Fonte](file:///${t.path.replace(/\\/g, '/')})`;
            }
            md += `| ${t.event} | ${t.procedure} | ${procLink} |\n`;
        }
    }

    md += `\n## Índices\n\n`;
    for (const idx of tableData.indices) {
        let tags = [];
        if (idx.primary) tags.push('Primário');
        if (idx.unique) tags.push('Único');
        const tagStr = tags.length > 0 ? ` (${tags.join(', ')})` : '';
        md += `- **${idx.name}**${tagStr}: ${idx.fields.join(', ')}\n`;
    }

    return md;
}

async function main() {
    const tableName = process.argv[2];
    let dbName = process.argv[3];
    
    if (!tableName) {
        process.exit(1);
    }

    try {
        const dbs = await getDatabasesForTable(tableName);
        
        if (dbs.length === 0) {
            process.exit(1);
        }

        if (dbs.length > 1 && !dbName) {
            console.log(`AMBIGUIDADE:${dbs.join(',')}`);
            process.exit(0);
        }

        if (!dbName) {
            dbName = dbs[0];
        }

        const dfPath = path.join(DATABASE_DIR, `${dbName}.df`);
        if (!fs.existsSync(dfPath)) {
            process.exit(1);
        }

        const tableOutputDir = path.join(OUTPUT_DIR, dbName);
        const outputPath = path.join(tableOutputDir, `${tableName.toLowerCase()}.md`);

        // CACHE INVALIDATION LOGIC
        if (fs.existsSync(outputPath)) {
            const dfStat = fs.statSync(dfPath);
            const mdStat = fs.statSync(outputPath);

            if (dfStat.mtime <= mdStat.mtime) {
                console.log(outputPath);
                return;
            }
            console.log(`- Atualizando cache: ${dbName}.df é mais recente que o arquivo gerado.`);
        }

        const tableData = await parseTableFromDF(dfPath, tableName);

        if (!tableData) {
            process.exit(1);
        }

        const md = generateMarkdown(tableData, dbName);
        
        if (!fs.existsSync(tableOutputDir)) {
            fs.mkdirSync(tableOutputDir, { recursive: true });
        }

        fs.writeFileSync(outputPath, md);
        console.log(outputPath); 
    } catch (err) {
        process.exit(1);
    }
}

main();
