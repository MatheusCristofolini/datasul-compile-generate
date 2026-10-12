import fs from 'fs';
import path from 'path';
import { fileURLToPath } from 'url';

const __filename = fileURLToPath(import.meta.url);
const __dirname = path.dirname(__filename);

// Configs
const PROJECT_ROOT = path.resolve(__dirname, '../../../../');
const WORKSPACE_PRODUTO_PADRAO = path.join(PROJECT_ROOT, 'produto-padrao');
const TOTVS_REF_DIR = 'C:\\Totvs';

// Helper to recursively find files matching targetName (case-insensitive)
function findFiles(dir, targetName, excludeRegex = null) {
    const results = [];
    if (!fs.existsSync(dir)) return results;

    function traverse(currentDir) {
        let list;
        try {
            list = fs.readdirSync(currentDir);
        } catch (e) {
            return;
        }

        for (const file of list) {
            const fullPath = path.join(currentDir, file);
            let stat;
            try {
                stat = fs.statSync(fullPath);
            } catch (e) {
                continue;
            }

            if (stat.isDirectory()) {
                if (excludeRegex && excludeRegex.test(fullPath)) {
                    continue;
                }
                // Avoid scanning node_modules, .git, .agents in project
                if (file === 'node_modules' || file === '.git' || file === '.agents') {
                    continue;
                }
                traverse(fullPath);
            } else {
                if (file.toLowerCase() === targetName.toLowerCase()) {
                    results.push(fullPath);
                }
            }
        }
    }

    traverse(dir);
    return results;
}

// Maps a C:\Totvs path to the workspace produto-padrao path
function mapTotvsToWorkspace(totvsPath) {
    const relative = path.relative(TOTVS_REF_DIR, totvsPath);
    const normalized = relative.replace(/\\/g, '/');
    const parts = normalized.split('/');
    
    // Check if progress/src is in path
    const progressSrcIndex = parts.findIndex((val, idx) => {
        return val.toLowerCase() === 'progress' && parts[idx + 1] && parts[idx + 1].toLowerCase() === 'src';
    });

    let mappedParts;
    if (progressSrcIndex !== -1) {
        // Remove progress/src
        mappedParts = [
            ...parts.slice(0, progressSrcIndex),
            ...parts.slice(progressSrcIndex + 2)
        ];
    } else {
        mappedParts = parts;
    }

    const mappedRelative = mappedParts.join(path.sep);
    return path.join(WORKSPACE_PRODUTO_PADRAO, mappedRelative);
}

function compareAndCopy(totvsPath, workspacePath) {
    if (!fs.existsSync(totvsPath)) return 'NOT-FOUND';

    const totvsBuf = fs.readFileSync(totvsPath);
    
    if (fs.existsSync(workspacePath)) {
        const wsBuf = fs.readFileSync(workspacePath);
        if (Buffer.compare(totvsBuf, wsBuf) === 0) {
            return 'UP-TO-DATE';
        } else {
            fs.mkdirSync(path.dirname(workspacePath), { recursive: true });
            fs.writeFileSync(workspacePath, totvsBuf);
            return 'UPDATED';
        }
    } else {
        fs.mkdirSync(path.dirname(workspacePath), { recursive: true });
        fs.writeFileSync(workspacePath, totvsBuf);
        return 'COPIED';
    }
}

function main() {
    const fileArg = process.argv[2];
    if (!fileArg) {
        console.error("Erro: Especifique o nome do arquivo fonte (ex: ab0101.w).");
        process.exit(1);
    }

    const targetName = path.basename(fileArg);
    
    // Exclude Issues/issue folder in C:\Totvs
    const totvsExcludeRegex = /[\\/]issues?[\\/]/i;

    console.log(`Buscando por "${targetName}" em ${TOTVS_REF_DIR}...`);
    const totvsMatches = findFiles(TOTVS_REF_DIR, targetName, totvsExcludeRegex);

    console.log(`Buscando por "${targetName}" no workspace...`);
    const workspaceMatches = findFiles(PROJECT_ROOT, targetName);

    if (totvsMatches.length === 0) {
        if (workspaceMatches.length === 0) {
            console.log(`NOT-FOUND: O arquivo "${targetName}" não foi encontrado em C:\\Totvs nem no workspace.`);
            process.exit(0);
        } else {
            console.log(`LOCAL-ONLY: O arquivo "${targetName}" existe apenas no workspace.`);
            for (const wsPath of workspaceMatches) {
                console.log(`  Caminho local: ${wsPath}`);
            }
            process.exit(0);
        }
    }

    console.log(`Encontrado(s) ${totvsMatches.length} arquivo(s) em C:\\Totvs.`);

    for (const totvsPath of totvsMatches) {
        const mappedWsPath = mapTotvsToWorkspace(totvsPath);
        
        const existingMatch = workspaceMatches.find(wsPath => {
            return wsPath.toLowerCase() === mappedWsPath.toLowerCase();
        });

        const targetPath = existingMatch || mappedWsPath;
        const result = compareAndCopy(totvsPath, targetPath);

        console.log(`${result}: ${targetPath}`);
        console.log(`  Origem: ${totvsPath}`);
    }
}

main();
