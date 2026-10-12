---
name: datasul-last-version
description: "Garante que os fontes Datasul analisados estejam sempre sincronizados com a versão mais recente em C:\\Totvs. Use sempre que o usuário solicitar leitura, análise ou modificação de arquivos de código fonte Datasul."
---

# Datasul Last Version

Esta skill garante a integridade e atualização dos arquivos fontes do Datasul utilizados no workspace. Sempre que o usuário interagir com um arquivo de código fonte (.p, .w, .i, .cls), o agente deve garantir que a versão mais recente do diretório de referência `C:\Totvs` está sendo utilizada.

## Gatilhos
- "Analise o programa {programa}"
- "O que faz o fonte {fonte}?"
- "Mapeie os campos do arquivo {fonte}"
- Qualquer comando ou solicitação direta sobre arquivos de código fonte do Datasul.

## Protocolo de Execução

1. **Sincronizar Fonte antes da Análise**:
   Antes de ler, analisar ou editar qualquer arquivo fonte do Datasul solicitado pelo usuário, execute o script de sincronização passando o nome base do arquivo (com extensão):
   ```bash
   node .agents/skills/datasul-last-version/scripts/sync-source.mjs {nome_do_arquivo}
   ```

2. **Interpretar o Retorno**:
   - **COPIED / UPDATED**: O script copiou ou atualizou o arquivo no workspace. Use o caminho de destino retornado pelo script para realizar sua leitura e análise.
   - **UP-TO-DATE**: O arquivo no workspace já está idêntico ao de `C:\Totvs`. Prossiga com a análise do arquivo local no workspace.
   - **LOCAL-ONLY**: O arquivo não existe no diretório `C:\Totvs`. Utilize o arquivo do workspace como base e prossiga.
   - **NOT-FOUND**: O arquivo não foi encontrado em nenhum local. Informe o usuário.

3. **Restrições**:
   - A pasta `C:\Totvs\Issues` (ou qualquer subpasta `Issues`/`issue`) **deve ser totalmente ignorada** durante a busca no diretório de referência.
