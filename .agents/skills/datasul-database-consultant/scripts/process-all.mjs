import fs from 'fs';
import path from 'path';
import { execSync } from 'child_process';

const databaseDir = 'produto-padrao/database';
const outputDir = path.join(path.dirname(import.meta.url.replace('file:///', '')), '../docs/database');

async function main() {
    const files = fs.readdirSync(databaseDir).filter(f => f.endsWith('.df'));
    const tableIndex = {};
    let indexNeeded = false;

    for (const file of files) {
        const dfPath = path.join(databaseDir, file);
        const dbName = path.basename(file, '.df');
        const mdPath = path.join(outputDir, `${dbName}.md`);
        
        let processNeeded = true;
        if (fs.existsSync(mdPath)) {
            const dfStat = fs.statSync(dfPath);
            const mdStat = fs.statSync(mdPath);
            if (dfStat.mtime <= mdStat.mtime) {
                processNeeded = false;
            }
        }

        if (processNeeded) {
            console.log(`--- Processando ${file} (modificado ou novo) ---`);
            try {
                const scriptPath = path.join(path.dirname(import.meta.url.replace('file:///', '')), 'parse-df.mjs');
                execSync(`node "${scriptPath}" "${dfPath}" "${outputDir}"`, { stdio: 'inherit' });
                indexNeeded = true;
            } catch (err) {
                console.error(`Erro ao processar ${file}:`, err.message);
            }
        } else {
            console.log(`--- ${file} está atualizado (cache) ---`);
        }

        // Independentemente de ter processado agora, precisamos carregar os nomes para o índice global
        if (fs.existsSync(mdPath)) {
            const mdContent = fs.readFileSync(mdPath, 'utf8');
            const tableMatches = mdContent.matchAll(/## Tabela: ([^\n\r]+)/g);
            for (const match of tableMatches) {
                const tableName = match[1].trim();
                if (!tableIndex[tableName]) tableIndex[tableName] = [];
                tableIndex[tableName].push(dbName);
            }
        }
    }

    const tableIndexPath = path.join(outputDir, 'TABLE_INDEX.md');
    if (!fs.existsSync(tableIndexPath)) indexNeeded = true;

    // Generate Global Index
    if (indexNeeded) {
        console.log("Gerando TABLE_INDEX.md...");
        let indexMd = "# Índice Global de Tabelas\n\n";
        indexMd += "Este documento mapeia cada tabela ao seu respectivo banco de dados (arquivo de esquema).\n\n";
        indexMd += "| Tabela | Bancos |\n";
        indexMd += "| :--- | :--- |\n";
    
        const sortedTables = Object.keys(tableIndex).sort();
        for (const tableName of sortedTables) {
            const dbs = tableIndex[tableName].map(db => `[${db}](./${db}.md)`).join(', ');
            indexMd += `| ${tableName} | ${dbs} |\n`;
        }
    
        fs.writeFileSync(tableIndexPath, indexMd);
        console.log("Índice gerado com sucesso em docs/database/TABLE_INDEX.md");
    } else {
        console.log("TABLE_INDEX.md já está atualizado.");
    }
}

main().catch(err => console.error(err));
