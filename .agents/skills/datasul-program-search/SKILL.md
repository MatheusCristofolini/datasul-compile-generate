---
name: datasul-program-search
description: Busca programas no menu Datasul por nome, descrição ou código. Use quando o usuário perguntar por "Cadastro de...", "Relatório de...", ou quiser saber o código/caminho de uma funcionalidade do Datasul.
---

# Datasul Program Search

Esta skill permite localizar programas do ERP Datasul de forma eficiente, utilizando índices extraídos da tabela `prog_dtsul` e organizados por módulos funcionais.

## Como utilizar

Quando o usuário solicitar uma pesquisa de programa (ex: "Onde faço a implantação de títulos no contas a pagar?"):

1.  **Identifique o Módulo Funcional**: Determine a qual área a pergunta se refere. Exemplos:
    -   **Financeiro**: Contas a Pagar (APB), Receber (ACR), Caixa (CMG), Fluxo de Caixa (CFL), Ativo Fixo (FAS).
    -   **Vendas e Faturamento**: Pedidos (PDP), Notas Fiscais (FAP), Vendas (VDP).
    -   **Materiais e Logística**: Estoque (CE), Compras (CC), Recebimento (RE).
    -   **Produção**: Engenharia (EN), PCP, Chão de Fábrica (SFC).
    -   **Recursos Humanos**: Folha (FPP), HCM, Ponto.
    -   **Cadastros e Fundação**: Cadastros Básicos (CDP), Menu, Parâmetros.
    -   **Saúde**: Gestão de Planos de Saúde.

2.  **Direcione a Busca**: Use a ferramenta `grep_search` priorizando os arquivos no diretório `indices\funcionais\`.
    -   *Estratégia*: Pesquise primeiro no arquivo `mod-{modulo}.md` correspondente. 
    -   *Exemplo*: Para "títulos pagar", busque em `mod-financeiro.md`.
    -   *Fallback*: Se não encontrar no módulo, ou se o módulo for incerto, pesquise nos arquivos globais `indices\index-*.md`.

3.  **Salvar resultados completos (OBRIGATÓRIO)**: Use a ferramenta `write_to_file` para criar um arquivo `datasul_program_search_results.md` no diretório de artefatos da conversa contendo a tabela completa de resultados (Código, Nome/Descrição, Caminho). Se o arquivo já existir, sobrescreva-o com os novos resultados.

4.  **Apresentar resposta no chat**: A resposta deve ser EXTREMAMENTE RESUMIDA. Use exatamente este formato:
    "O programa mais provável é o **{Código}** ({Caminho}).
    Confira a lista completa no arquivo: [datasul_program_search_results.md](file:///c:/Projetos/Gps/V31/.agents/artifacts/datasul_program_search_results.md)"

## Estrutura dos Índices

- **Índices Funcionais** (`indices\funcionais\mod-*.md`): Agrupados por processos de negócio (Recomendado).
- **Índices Alfabéticos** (`indices\index-*.md`): Fallback ou para quando o código do programa já é conhecido.

Se o resultado for ambíguo ou nenhum programa for encontrado, informe brevemente e peça clarificação.

