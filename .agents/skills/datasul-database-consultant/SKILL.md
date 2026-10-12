---
name: datasul-database-consultant
description: Analisa e interpreta relacionamentos entre tabelas dos bancos de dados Progress 4GL do produto Datasul. Use quando o usuário precisar traçar caminhos (rotas) entre tabelas ou entender a estrutura de índices e chaves primárias dos bancos mg, ems, hcm, etc.
---

# Datasul Database Consultant

Esta skill fornece acesso rápido aos esquemas de banco de dados do Datasul (Progress 4GL) e ferramentas para traçar relacionamentos entre tabelas.

## Recursos
- **Busca Rápida (Cache)**: Localizado em `.agents/skills/datasul-database-consultant/docs/relationships/`. Contém arquivos `.md` com caminhos já mapeados no formato `{banco}.{tabela_origem}--{banco}.{tabela_destino}.md` (ex: `mg.emitente--mg.item.md`).
- **Índice Global**: Localizado em `docs/database/TABLE_INDEX.md`. Mapeia ~8.500 tabelas para seus bancos correspondentes.
- **Esquemas Detalhados**: Arquivos Markdown em `docs/database/` contendo Tabelas, PKs e Índices.
- **Scripts de Manutenção**: Scripts em `scripts/` para regenerar a documentação a partir de arquivos `.df`.

## Como realizar uma consulta de relacionamento
Sempre que o usuário perguntar "como chegar da tabela A na tabela Z", siga este protocolo:

0.  **Verificar Busca Rápida**: Verifique se existe um arquivo em `.agents/skills/datasul-database-consultant/docs/relationships/` nomeado como `{banco_A}.{tabela_A}--{banco_Z}.{tabela_Z}.md` ou invertido. Se encontrar, utilize o conteúdo deste arquivo para responder ao usuário e pule os passos seguintes.
1.  **Localizar os Bancos**: Consulte `docs/database/TABLE_INDEX.md` para encontrar em quais arquivos de esquema as tabelas A e Z estão definidas.
    - **Verificar Duplicidade**: Se o `TABLE_INDEX.md` indicar que uma tabela pertence a múltiplos bancos (ex: `| banco | [ems](./ems.md), [mg](./mg.md) |`), você **DEVE** parar a execução e perguntar ao usuário qual dos bancos deve ser utilizado antes de prosseguir.
2.  **Analisar Chaves e Índices**:
    - Abra os arquivos de esquema correspondentes ao banco identificado (ex: `docs/database/mg.md`).
    - Identifique a Chave Primária (PK) de ambas as tabelas.
    - Liste todos os índices e campos que os compõem.
3.  **Identificar Correspondências**:
    - Procure por campos com nomes idênticos que participem de índices em ambas as tabelas.
    - Verifique se a PK de uma tabela faz parte de um índice na outra (Foreign Key implícita).
    - Se não houver ligação direta, procure por tabelas intermediárias comuns (ex: `emitente`, `item`, `estabelecimento`).
4.  **Apresentar o Caminho**:
    - Explique quais campos devem ser igualados.
    - Mencione quais índices facilitam a busca.
    - Se for um relacionamento complexo (entre módulos), explique a lógica de negócio (ex: Transferência entre estabelecimentos).
5.  **Salvar na Busca Rápida**: Se o caminho foi descoberto manualmente (passos 1 a 4), salve a resposta final em um novo arquivo em `.agents/skills/datasul-database-consultant/docs/relationships/` com o nome `{banco_origem}.{tabela_origem}--{banco_destino}.{tabela_destino}.md`.

## Manutenção
Se os arquivos `.df` na pasta `database/` do projeto forem atualizados, a documentação pode ser regenerada executando:
```bash
node .agents/skills/datasul-database-consultant/scripts/process-all.mjs
```

## Exemplos
- **De `emitente` para `ped-item`**: `emitente.nome-abrev` -> `ped-item.nome-abrev`.
- **De `nota-fiscal` para `it-doc-fisc`**: `nota-fiscal.nr-nota-fis` -> `it-doc-fisc.nr-doc-fis` (considerando Transferências).
