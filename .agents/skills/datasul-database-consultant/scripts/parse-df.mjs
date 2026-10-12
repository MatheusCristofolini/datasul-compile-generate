import fs from 'fs';
import path from 'path';
import readline from 'readline';

async function parseDF(filePath) {
    const fileStream = fs.createReadStream(filePath);
    const rl = readline.createInterface({
        input: fileStream,
        crlfDelay: Infinity
    });

    const tables = {};
    let currentTable = null;
    let currentIndex = null;

    for await (const line of rl) {
        const trimmedLine = line.trim();

        // New Table
        if (trimmedLine.startsWith('ADD TABLE "')) {
            const match = trimmedLine.match(/"([^"]*)"/);
            if (!match) continue;
            const tableName = match[1];
            currentTable = {
                name: tableName,
                label: '',
                description: '',
                fields: {},
                indices: []
            };
            tables[tableName] = currentTable;
            currentIndex = null;
            continue;
        }

        if (!currentTable) continue;

        // Table metadata
        if (trimmedLine.startsWith('LABEL "')) {
            const match = trimmedLine.match(/"([^"]*)"/);
            if (match) currentTable.label = match[1];
        } else if (trimmedLine.startsWith('DESCRIPTION "')) {
            const match = trimmedLine.match(/"([^"]*)"/);
            if (match) currentTable.description = match[1];
        }

        // Field definition (we only care if it's referenced in an index, but we might need all if we don't know the indices yet)
        // Actually, we'll collect all fields for now but filter them out in the final output if they are not in indices.
        if (trimmedLine.startsWith('ADD FIELD "')) {
            const match = trimmedLine.match(/"([^"]*)"/);
            if (match) {
                const fieldName = match[1];
                currentTable.fields[fieldName] = { name: fieldName, inIndex: false };
            }
            currentIndex = null; // Field definition stops index definition
        }

        // Index definition
        if (trimmedLine.startsWith('ADD INDEX "')) {
            const match = trimmedLine.match(/"([^"]*)"/);
            if (match) {
                const indexName = match[1];
                currentIndex = {
                    name: indexName,
                    unique: false,
                    primary: false,
                    fields: []
                };
                currentTable.indices.push(currentIndex);
            }
        }

        if (currentIndex) {
            if (trimmedLine === 'UNIQUE') currentIndex.unique = true;
            if (trimmedLine === 'PRIMARY') currentIndex.primary = true;
            if (trimmedLine.startsWith('INDEX-FIELD "')) {
                const match = trimmedLine.match(/"([^"]*)"/);
                if (match) {
                    const fieldName = match[1];
                    currentIndex.fields.push(fieldName);
                    if (currentTable.fields[fieldName]) {
                        currentTable.fields[fieldName].inIndex = true;
                    }
                }
            }
        }
    }

    return tables;
}

function generateMarkdown(dbName, tables) {
    let md = `# Esquema do Banco: ${dbName}\n\n`;
    
    const sortedTables = Object.keys(tables).sort();

    for (const tableName of sortedTables) {
        const table = tables[tableName];
        md += `## Tabela: ${tableName}\n`;
        if (table.label) md += `**Label**: ${table.label}\n`;
        if (table.description) md += `**Descrição**: ${table.description}\n\n`;

        const primaryIndex = table.indices.find(idx => idx.primary);
        if (primaryIndex) {
            md += `### Chave Primária\n- ${primaryIndex.fields.join(', ')}\n\n`;
        }

        md += `### Índices\n`;
        table.indices.forEach(idx => {
            if (!idx.primary) {
                md += `- **${idx.name}**${idx.unique ? ' (Unique)' : ''}: ${idx.fields.join(', ')}\n`;
            }
        });
        
        md += `\n---\n\n`;
    }

    return md;
}

async function main() {
    const args = process.argv.slice(2);
    if (args.length === 0) {
        console.log("Uso: node parse-df.mjs <arquivo.df> [diretorio_saida]");
        return;
    }

    const dfPath = args[0];
    const outputDir = args[1] || 'docs/database';
    const dbName = path.basename(dfPath, '.df');

    if (!fs.existsSync(outputDir)) {
        fs.mkdirSync(outputDir, { recursive: true });
    }

    console.log(`Processando ${dfPath}...`);
    const tables = await parseDF(dfPath);
    const md = generateMarkdown(dbName, tables);
    
    const outputPath = path.join(outputDir, `${dbName}.md`);
    fs.writeFileSync(outputPath, md);
    console.log(`Documentação gerada em: ${outputPath}`);

    // Return table list for global index
    return { dbName, tableNames: Object.keys(tables) };
}

// Check if running as main
if (import.meta.url.startsWith('file:')) {
    const modulePath = new URL(import.meta.url).pathname;
    // On Windows, the path might start with /C:/, which can confuse comparison if not handled
    // But since we are using ESM and process.argv[1], let's just run it.
    main().catch(err => console.error(err));
}
