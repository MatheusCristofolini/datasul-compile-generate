---
name: datasul-field-details
description: Busca campos em tabelas do Datasul e retorna detalhes técnicos como tipo, formato e label. Use ao procurar onde um campo é usado ou detalhes de um campo específico.
---

# Datasul Field Details

Esta skill permite localizar campos em todas as tabelas do Datasul ou obter detalhes técnicos de um campo específico em uma tabela.

## Gatilhos
- "Onde existe o campo {campo}?"
- "Em quais tabelas tem o campo {campo}?"
- "Me traga os detalhes do campo {tabela}.{campo}."
- "Quais as propriedades do campo {campo} na tabela {tabela}?"

## Protocolo de Execução

1.  **Identificar o Formato**:
    - Se o usuário informar apenas o nome de um campo (ex: `cod-estabel`), a skill buscará todas as tabelas que o contêm.
    - Se o usuário informar `tabela.campo` (ex: `item.desc-item`), a skill trará os detalhes completos daquele campo.

2.  **Verificar Ambiguidade (para tabela.campo)**:
    - Se o formato for `tabela.campo`, o script verificará se a tabela existe em múltiplos bancos.
    - Se houver ambiguidade, você **DEVE** perguntar ao usuário: *"Esta tabela existe nos bancos **banco1** e **banco2**. De qual deles você deseja os detalhes?"*.

3.  **Executar a Extração**:
    Execute o script passando o campo ou `tabela.campo`.
    ```bash
    node .agents/skills/datasul-field-details/scripts/get-field-info.mjs "{input}" "{banco_opcional}"
    ```

4.  **Resposta ao Usuário**:
    - O script retornará o caminho absoluto do arquivo `.md` gerado.
    - **Sua resposta no chat deve conter APENAS o link para abertura do arquivo.** 
    - Exemplo de resposta: `[cod-estabel.md](file:///c:/path/to/docs/searches/cod-estabel.md)`
    - **NÃO adicione saudações, tabelas ou resumos.** 

## Requisitos
- A skill utiliza os arquivos `.df` localizados em `produto-padrao/database/`.
- Para `tabela.campo`, depende do `TABLE_INDEX.md` localizado em `.agents/skills/datasul-database-consultant/docs/database/TABLE_INDEX.md`.
