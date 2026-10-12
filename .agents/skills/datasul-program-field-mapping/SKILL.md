---
name: datasul-program-field-mapping
description: Analisa o código fonte de um programa Progress/Datasul e lista todos os campos existentes em tela, mapeando-os para o respectivo banco.tabela.campo onde os dados são salvos.
---

# Datasul Program Field Mapping

Esta skill permite analisar um programa Progress (especialmente do produto Datasul) para identificar quais campos são exibidos ao usuário e como eles se relacionam com as tabelas do banco de dados.

## Gatilhos
- "Quais campos existem na tela do programa {programa}?"
- "Analise o fonte do programa {programa} e me diga onde os dados são salvos."
- "Mapeie os campos de tela do programa {programa} para o banco de dados."

## Protocolo de Execução

1.  **Localizar o Programa**:
    - O usuário pode informar o código (ex: `bas_representante`) ou o caminho (ex: `utb112aa.p`).
    - Use a skill `datasul-program-search` ou `grep_search` para encontrar o caminho físico do arquivo `.p` ou `.w`.
    - Priorize arquivos em `produto-padrao/`.

2.  **Executar a Análise**:
    - Chame o script de extração passando o caminho do arquivo encontrado.
    ```bash
    node .agents/skills/datasul-program-field-mapping/scripts/analyze-program-fields.mjs "{caminho_do_arquivo}"
    ```

3.  **Inteligência de Cache**:
    - O script verifica se já existe um mapeamento gerado em `.agents/skills/datasul-program-field-mapping/docs/{programa}.md`.
    - Se o arquivo de documentação for mais recente que o arquivo fonte do programa, o script retornará o cache.

4.  **Resposta ao Usuário**:
    - O script retornará o caminho absoluto do arquivo `.md` gerado.
    - Sua resposta no chat deve conter APENAS o link para abertura do arquivo.
    - Exemplo: `[utb112aa.md](file:///c:/path/to/docs/utb112aa.md)`
    - **NÃO adicione saudações ou resumos.**

## Lógica de Análise (Interna do Script)
- Identifica blocos `DEFINE FRAME`, `FORM`, `BROWSE`.
- Mapeia variáveis (`v_...`) para campos de tabelas através de comandos `ASSIGN`, `BUFFER-COPY`, `FIND` e `CREATE`.
- Identifica campos diretos de tabela (`tabela.campo`).
- Consulta o `TABLE_INDEX.md` para resolver o banco de dados de cada tabela encontrada.
