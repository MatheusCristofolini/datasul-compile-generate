---
name: datasul-table-details
description: Retorna a definição técnica detalhada (.df) de uma tabela do Datasul, incluindo campos, tipos, labels, formatos e índices, formatados em um arquivo Markdown de fácil leitura. Use quando o usuário pedir a definição, campos, df ou estrutura de uma tabela.
---

# Datasul Table Details

Esta skill fornece acesso completo à definição de dados (Data Definitions - .df) de uma tabela específica do Datasul. Ao contrário do consultor de banco de dados (que foca em relacionamentos), esta skill detalha todos os atributos de cada campo.

## Gatilhos
- "Qual a definição da tabela {tabela}?"
- "Me traga o df da {tabela}."
- "Quais campos existem na tabela {tabela}?"
- "Qual o formato/tipo do campo X na tabela Y?"

## Protocolo de Execução

1.  **Verificar Ambiguidade**:
    - Antes de gerar, verifique se a tabela existe em múltiplos bancos consultando o script `get-details.mjs` apenas com o nome da tabela.
    - Se o script retornar `AMBIGUIDADE:banco1,banco2`, você **DEVE** perguntar ao usuário: *"Esta tabela existe nos bancos **banco1** e **banco2**. De qual deles você deseja os detalhes?"*.

2.  **Executar a Extração**:
    Execute o script passando o nome da tabela e o banco (se houver ambiguidade já resolvida ou se souber o banco).
    ```bash
    node .agents/skills/datasul-table-details/scripts/get-details.mjs {tabela} {banco_opcional}
    ```

3.  **Resposta ao Usuário**:
    - O script retornará o caminho absoluto do arquivo `.md` dentro de uma subpasta com o nome do banco.
    - **Sua resposta no chat deve conter APENAS o link para abertura do arquivo.** 
    - Exemplo de resposta: `[item.md](file:///c:/path/to/mg/item.md)`
    - **NÃO adicione saudações, tabelas ou resumos.** 

## Requisitos
- A skill depende do `TABLE_INDEX.md` localizado em `.agents/skills/datasul-database-consultant/docs/database/TABLE_INDEX.md` para localizar em qual banco a tabela reside.
- Se o índice não estiver atualizado, peça ao usuário para rodar o script de manutenção do consultor de banco de dados.
