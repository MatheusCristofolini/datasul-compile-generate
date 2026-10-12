import fs from "fs";
import path from "path";
import { fileURLToPath } from "url";

const __filename = fileURLToPath(import.meta.url);
const __dirname = path.dirname(__filename);

const PROJECT_ROOT = path.resolve(__dirname, "../../../../");
const TABLE_INDEX_PATH = path.join(
  PROJECT_ROOT,
  ".agents/skills/datasul-database-consultant/docs/database/TABLE_INDEX.md",
);
const OUTPUT_DIR = path.join(
  PROJECT_ROOT,
  ".agents/skills/datasul-program-field-mapping/docs",
);

if (!fs.existsSync(OUTPUT_DIR)) {
  fs.mkdirSync(OUTPUT_DIR, { recursive: true });
}

async function getDatabasesForTable(tableName) {
  if (!fs.existsSync(TABLE_INDEX_PATH)) return ["?"];
  const content = fs.readFileSync(TABLE_INDEX_PATH, "utf8");
  const regex = new RegExp(`\\| ${tableName.toUpperCase()} \\| (.*) \\|`, "i");
  const match = content.match(regex);
  if (!match) return ["?"];
  const dbMatches = match[1].matchAll(/\[(.*?)\]/g);
  return Array.from(dbMatches, (m) => m[1]);
}

function fixEncoding(text) {
  if (!text) return "";
  // Common CP850 to UTF-8 mappings seen in old Datasul/Progress code
  const cp850Map = {
    "\x87": "ç",
    "\x80": "Ç",
    "\xA0": "á",
    "\xA1": "í",
    "\xA2": "ó",
    "\xA3": "ú",
    "\x82": "é",
    "\x83": "â",
    "\x88": "ê",
    "\x89": "ë",
    "\x93": "ô",
    "\x94": "ö",
    "\x84": "ä",
    "\x85": "à",
    "\x91": "æ",
    "\x92": "ã",
    "\xA6": "ª",
    "\xA7": "º",
    "\xC3": "ã",
    "\xD5": "õ",
    "\xC2": "â",
    "\xCA": "ê",
    "\xCE": "î",
    "\xD4": "ô",
    "\xDB": "û",
    "\xC1": "Á",
    "\xCD": "Í",
    "\xD3": "Ó",
    "\xDA": "Ú",
    "\xC9": "É",
    "\xC6": "ã",
    "\xC7": "ç",
  };
  return text.replace(/[\x80-\xFF]/g, (c) => cp850Map[c] || c);
}

function analyzeProgram(filePath) {
  const content = fs.readFileSync(filePath, "latin1");
  const programName = path.basename(filePath, path.extname(filePath));

  const fields = new Map();

  const PROGRESS_KEYWORDS = new Set([
    "at",
    "column",
    "space",
    "skip",
    "with",
    "help",
    "label",
    "format",
    "view-as",
    "no-label",
    "column-label",
    "debalign",
    "align-l",
    "align-r",
    "no-undo",
    "initial",
    "as",
    "like",
    "column",
    "row",
    "integer",
    "character",
    "date",
    "logical",
    "decimal",
    "recid",
    "handle",
    "widget-handle",
    "com-handle",
    "field",
    "index",
    "primary",
    "unique",
    "no-lock",
    "no-error",
    "no-wait",
    "first",
    "last",
    "next",
    "prev",
    "each",
    "where",
    "shared",
    "new",
    "global",
    "define",
    "variable",
    "temp-table",
    "browse",
    "query",
    "frame",
    "form",
    "on",
    "all",
    "the",
    "is",
    "not",
    "available",
    "error-status",
    "return",
    "no-box",
    "separators",
    "single",
    "size",
    "by",
    "font",
    "bgcolor",
    "fgcolor",
    "tooltip",
    "image-up",
    "image-insensitive",
    "image",
    "file",
    "menubar",
    "side-label",
    "colon-aligned",
    "keep-frame-z-order",
    "three-d",
    "no-validate",
    "overlay",
    "stream-io",
    "side-labels",
    "fill-in",
    "combo-box",
    "toggle-box",
    "text-area",
    "radio-set",
    "selection-list",
    "editor",
    "slider",
    "rectangle",
    "text",
    "image",
    "button",
    "browse",
    "frame",
    "form",
    "display",
    "enable",
    "view",
    "hide",
    "assign",
    "create",
    "delete",
    "update",
    "find",
    "get",
    "for",
    "each",
    "repeat",
    "do",
    "if",
    "then",
    "else",
    "case",
    "when",
    "otherwise",
    "end",
    "width-chars",
    "height-chars",
    "width-pixels",
    "height-pixels",
    "size-chars",
    "size-pixels",
    "title",
    "color",
    "no-box",
    "no-underline",
    "no-labels",
    "use-dict-exps",
    "use-text",
    "scrolling",
    "separators",
    "single",
    "multiple",
    "row-markers",
    "no-drag-auto-column",
    "column-scrolling",
    "column-movable",
    "column-resizable",
    "no-empty-space",
    "down",
  ]);

  const UI_PREFIXES_TO_IGNORE = [
    "bt_",
    "bt-",
    "btn_",
    "btn-", // Buttons
    "mi_",
    "mi-", // Menu Items
    "rt_",
    "rt-",
    "rect_",
    "rect-", // Rectangles
    "br_",
    "br-", // Browses (widget handle)
    "m_",
    "m-", // Menus
    "qr_",
    "qr-", // Queries
    "h_",
    "h-",
    "v_h_",
    "v-h-", // Handles
    "ptr_",
    "ptr-", // Pointers
    "img_",
    "img-", // Images
    "mnu_",
    "mnu-", // Menus
  ];

  const isNoise = (name) => {
    if (!name) return true;
    const n = name.toLowerCase();
    return (
      n.length <= 2 ||
      /^[0-9\.]+$/.test(n) ||
      n.includes("-manager") ||
      PROGRESS_KEYWORDS.has(n) ||
      UI_PREFIXES_TO_IGNORE.some((prefix) => n.startsWith(prefix)) ||
      n.endsWith(".i") ||
      n.endsWith(".p") ||
      n.endsWith(".w") ||
      n.endsWith(".r") ||
      n.endsWith(".bmp") ||
      n.endsWith(".py") ||
      n.endsWith(".tmp")
    );
  };

  // 1. Find blocks: FRAME, FORM, BROWSE
  const blockRegex =
    /(?:(?:def|defin|define)\s+frame|form|(?:def|defin|define)\s+browse)\s+([a-z0-9_-]*)([\s\S]+?)(?=\.\s|procedure\s|function\s|$)/gi;
  let blockMatch;
  while ((blockMatch = blockRegex.exec(content)) !== null) {
    let blockBody = blockMatch[2];

    // Preserve quoted strings to capture labels, but handle them as tokens
    const tokens = blockBody.match(/"[^"]*"|'[^']*'|[a-z0-9_\-\.]+/gi) || [];

    for (let i = 0; i < tokens.length; i++) {
      const token = tokens[i].toLowerCase();

      // If it's a quoted string, it's not a field name
      if (token.startsWith('"') || token.startsWith("'")) continue;

      // If it's noise or a keyword, skip
      if (isNoise(token)) continue;

      // Identify if it's a potential field (table.field or variable)
      const parts = token.split(".");
      let isCandidate = false;
      let fieldName = "";
      let tableName = "";

      if (parts.length === 2) {
        tableName = parts[0];
        fieldName = parts[1];
        if (!isNoise(tableName) && !isNoise(fieldName)) {
          isCandidate = true;
        }
      } else if (parts.length === 1) {
        fieldName = parts[0];
        isCandidate = true;
      }

      if (isCandidate) {
        // Check for visibility: look ahead for VIEW-AS [TYPE] or NO-DISPLAY/HIDDEN and LABEL
        let isVisible = true;
        let label = "";

        // Look ahead up to 15 tokens for UI modifiers
        for (let j = i + 1; j < Math.min(i + 20, tokens.length); j++) {
          const nextToken = tokens[j].toLowerCase();

          if (nextToken === "view-as") {
            if (j + 1 < tokens.length) {
              const type = tokens[j + 1].toLowerCase();
              // If it's a non-data widget, it's not a "field" we want to map
              if (
                [
                  "button",
                  "rectangle",
                  "text",
                  "image",
                  "frame",
                  "form",
                  "menu",
                ].includes(type)
              ) {
                isVisible = false;
              }
            }
          } else if (nextToken === "label") {
            if (
              j + 1 < tokens.length &&
              (tokens[j + 1].startsWith('"') || tokens[j + 1].startsWith("'"))
            ) {
              label = tokens[j + 1].replace(/['"]/g, "");
            }
          } else if (
            nextToken === "no-display" ||
            nextToken === "hidden" ||
            nextToken === "no-enable"
          ) {
            if (nextToken === "no-display" || nextToken === "hidden") {
              isVisible = false;
            }
          } else if (tokens[j].startsWith('"') || tokens[j].startsWith("'")) {
            // Sometimes the label is just a quoted string after the field name
            if (
              !label &&
              !tokens[j - 1]
                .toLowerCase()
                .match(/format|help|initial|column-label/)
            ) {
              label = tokens[j].replace(/['"]/g, "");
            }
          }

          // If we hit another likely field/variable (not a keyword), we might be in next definition
          if (
            tokens[j].includes(".") ||
            (tokens[j].startsWith("v_") &&
              !PROGRESS_KEYWORDS.has(tokens[j].toLowerCase()))
          ) {
            // But wait, many keywords can follow. We only stop if we are sure.
          }
        }

        if (isVisible) {
          const key = tableName ? `${tableName}.${fieldName}` : fieldName;
          const fieldData = fields.get(key) || {};
          const fixedLabel = fixEncoding(label);
          if (tableName) {
            fields.set(key, {
              ...fieldData,
              table: tableName,
              field: fieldName,
              label: fixedLabel || fieldData.label || "",
            });
          } else {
            fields.set(key, {
              ...fieldData,
              name: fieldName,
              label: fixedLabel || fieldData.label || "",
            });
          }
        }
      }
    }
  }

  // 2. Identify updated tables (to distinguish between persistence and display fields)
  const updatedTables = new Set();
  const buffers = new Map(); // bufferName -> tableName

  const bufferRegex =
    /DEF(?:INE)?\s+BUFFER\s+([a-z0-9_\-]+)\s+FOR\s+([a-z0-9_\-]+)/gi;
  let bm;
  while ((bm = bufferRegex.exec(content)) !== null) {
    buffers.set(bm[1].toLowerCase(), bm[2].toLowerCase());
  }

  const createRegex = /CREATE\s+([a-z0-9_\-]+)/gi;
  let cm;
  while ((cm = createRegex.exec(content)) !== null) {
    const t = cm[1].toLowerCase();
    updatedTables.add(t);
    if (buffers.has(t)) updatedTables.add(buffers.get(t));
  }

  // Simplified check for tables being updated via ASSIGN
  const assignTableRegex = /ASSIGN\s+([a-z0-9_\-]+)\.[a-z0-9_\-]+\s*=/gi;
  let am;
  while ((am = assignTableRegex.exec(content)) !== null) {
    const t = am[1].toLowerCase();
    updatedTables.add(t);
    if (buffers.has(t)) updatedTables.add(buffers.get(t));
  }

    // 3. Map Variables to Table Fields via ASSIGN (Load/Save logic)
    // Find all ASSIGN blocks
    const assignBlockRegex = /ASSIGN\s+([\s\S]+?)(?=\.\s|procedure|function|&if|&endif|$)/gi;
    let ab;
    while ((ab = assignBlockRegex.exec(content)) !== null) {
        const body = ab[1];
        // Find pairs like: target = source
        // Target can be table.field or variable
        // Source can be table.field or variable (optionally with input frame or screen-value)
        const pairRegex = /([a-z0-9_\-\.]+)(?::[a-z0-9_\-]+)?(?:\s+in\s+frame\s+[a-z0-9_\-]+)?\s*=\s*(?:input\s+frame\s+[a-z0-9_\-]+\s+)?(?:screen-value\s+of\s+)?([a-z0-9_\-\.]+)/gi;
        let p;
        while ((p = pairRegex.exec(body)) !== null) {
            let target = p[1].toLowerCase();
            let source = p[2].toLowerCase();
            
            // If target is table.field and source is variable
            if (target.includes('.') && !source.includes('.')) {
                const [t, f] = target.split('.');
                if (fields.has(source)) {
                    fields.get(source).mappedTo = `${t}.${f}`;
                    updatedTables.add(t);
                    if (buffers.has(t)) updatedTables.add(buffers.get(t));
                }
            }
            // If target is variable and source is table.field
            else if (!target.includes('.') && source.includes('.')) {
                if (fields.has(target)) {
                    fields.get(target).mappedFrom = source;
                }
            }
        }
    }

  return { programName, fields, filePath, updatedTables };
}

async function generateMD(analysis) {
  const { programName, fields, filePath, updatedTables } = analysis;
  let md = `# Mapeamento de Campos: ${programName}\n\n`;
  md += `- **Arquivo**: \`${filePath}\`\n\n`;

  const sortedFields = Array.from(fields.entries());

  // Identify the primary target table(s)
  const tableFieldCounts = new Map();
  for (const [key, data] of fields.entries()) {
    const t =
      data.table || (data.mappedTo ? data.mappedTo.split(".")[0] : null);
    if (t) {
      tableFieldCounts.set(t, (tableFieldCounts.get(t) || 0) + 1);
    }
  }

  // Find the maximum field count among updated tables
  let maxFields = 0;
  for (const [t, count] of tableFieldCounts.entries()) {
    if (updatedTables.has(t) && count > maxFields) {
      maxFields = count;
    }
  }

  // A table is a "Target Table" if it's updated AND has a significant presence in the UI
  const targetTables = new Set();
  for (const [t, count] of tableFieldCounts.entries()) {
    // Must have at least 50% of the fields compared to the most prominent updated table
    if (
      updatedTables.has(t) &&
      (count === maxFields || (maxFields > 0 && count / maxFields >= 0.5))
    ) {
      targetTables.add(t);
    }
  }

  // If no target tables found via count + update, but some are updated, take the one with most fields
  if (targetTables.size === 0 && updatedTables.size > 0) {
    let maxCount = -1;
    let bestTable = "";
    for (const t of updatedTables) {
      const count = tableFieldCounts.get(t) || 0;
      if (count > maxCount) {
        maxCount = count;
        bestTable = t;
      }
    }
    if (bestTable) targetTables.add(bestTable);
  }

  const persistenceFields = [];
  const displayFields = [];
  const technicalVariables = [
    "v_recid",
    "v_handle",
    "v_rowid",
    "v_h_",
    "v_wgh_",
  ];

  for (const [key, data] of sortedFields) {
    let mapped = "Não identificado";
    let isPersistence = false;
    let currentTable =
      data.table || (data.mappedTo ? data.mappedTo.split(".")[0] : null);

    if (data.table) {
      const dbs = await getDatabasesForTable(data.table);
      mapped = `${dbs.join("/")}.${data.table}.${data.field}`;
    } else if (data.mappedTo) {
      const [t, f] = data.mappedTo.split(".");
      const dbs = await getDatabasesForTable(t);
      mapped = `${dbs.join("/")}.${t}.${f}`;
    } else if (data.mappedFrom) {
      const [t, f] = data.mappedFrom.split(".");
      const dbs = await getDatabasesForTable(t);
      mapped = `${dbs.join("/")}.${t}.${f}`;
    }

    // Field is persistence if it belongs to a Target Table AND (is direct or mappedTo)
    if (currentTable && targetTables.has(currentTable)) {
      if (data.table || data.mappedTo) {
        isPersistence = true;
      }
    }

    const isTechnical = technicalVariables.some((tv) =>
      key.toLowerCase().startsWith(tv),
    );
    if (
      (mapped !== "Não identificado" || key.startsWith("v_")) &&
      !isTechnical
    ) {
      const row = `| ${data.label || key} | ${key} | ${mapped} |`;
      if (isPersistence) {
        persistenceFields.push(row);
      } else {
        displayFields.push(row);
      }
    }
  }

  md += `## Campos de Persistência (Salvos na Tabela Alvo)\n\n`;
  if (targetTables.size > 0) {
    md += `**Tabela(s) Alvo**: \`${Array.from(targetTables).join(", ")}\`\n\n`;
  }
  md += `| Label | Campo em Tela | Mapeamento Banco (banco.tabela.campo) |\n`;
  md += `| :--- | :--- | :--- |\n`;
  if (persistenceFields.length > 0) {
    md += persistenceFields.join("\n") + "\n";
  } else {
    md += `| - | - | Nenhum campo de persistência identificado |\n`;
  }

  md += `\n## Campos de Consulta/Exibição (Apenas Visualização)\n\n`;
  md += `| Label | Campo em Tela | Mapeamento Banco (banco.tabela.campo) |\n`;
  md += `| :--- | :--- | :--- |\n`;
  if (displayFields.length > 0) {
    md += displayFields.join("\n") + "\n";
  } else {
    md += `| - | - | Nenhum campo de exibição identificado |\n`;
  }

  md += `\n**Gerado em**: ${new Date().toLocaleString("pt-BR")}\n`;
  return md;
}

async function main() {
  const filePath = process.argv[2];
  if (!filePath || !fs.existsSync(filePath)) {
    console.error("Arquivo não encontrado.");
    process.exit(1);
  }

  const programName = path.basename(filePath, path.extname(filePath));
  const outputPath = path.join(OUTPUT_DIR, `${programName}.md`);

  if (fs.existsSync(outputPath)) {
    const sourceStat = fs.statSync(filePath);
    const mdStat = fs.statSync(outputPath);
    if (sourceStat.mtime <= mdStat.mtime) {
      console.log(outputPath);
      return;
    }
  }

  const analysis = analyzeProgram(filePath);
  const md = await generateMD(analysis);
  fs.writeFileSync(outputPath, md);
  console.log(outputPath);
}

main();
