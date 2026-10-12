---
name: datasul-docs-search
description: Consulta a documentação oficial do produto Datasul no portal TDN (TOTVS Developer Network) e na Central de Atendimento TOTVS. Realiza buscas, extrai conteúdo técnico e gera resumos estruturados. Use quando o usuário perguntar sobre processos, funcionalidades, parâmetros ou manuais do Datasul.
---

# Datasul Documentation Search

Esta skill permite consultar as fontes oficiais da TOTVS para obter informações detalhadas sobre o produto Datasul. Ela automatiza a busca no portal TDN (espaço LDT) e na Central de Atendimento, extrai o conteúdo e gera resumos úteis.

## Fontes Oficiais
*   **TDN (Linha Datasul):** Documentação de manuais, processos e releases.
*   **Central de Atendimento TOTVS:** Base de conhecimento com KCS (Knowledge-Centered Service), FAQs e soluções de problemas.
    *   Link Base: `https://centraldeatendimento.totvs.com/hc/pt-br/sections/360007008893-Linha-Datasul`

## Fluxo de Trabalho

1.  **Identificação da Query**: Determine os termos de busca principais com base na pergunta do usuário (ex: "como parametrizar o faturamento", "cadastro de fornecedor").
2.  **Busca no TDN**: Utilize a URL de busca avançada com CQL para filtrar pelo espaço Datasul (LDT):
    `https://tdn.totvs.com/dosearchsite.action?cql=siteSearch ~ "{query}" AND space = "LDT"`
3.  **Busca na Central de Atendimento (Opcional)**: Se o TDN não for suficiente ou a dúvida for sobre um erro/comportamento específico, busque na Central usando o Google ou busca interna:
    `site:centraldeatendimento.totvs.com "Datasul" {query}`
4.  **Seleção do Resultado**: Navegue pelo resultado mais relevante.
5.  **Extração e Resumo**:
    *   Leia o conteúdo da página.
    *   Gere um resumo técnico detalhado em formato Markdown.
    *   Salve este resumo em um arquivo temporário em `<appDataDir>\brain\<conversation-id>\scratch\docs-search-result.md`.
6.  **Resposta ao Usuário**:
    *   Forneça um resumo "bem resumido" (2-3 sentenças) no chat.
    *   Inclua o link direto para a documentação completa.

## Diretrizes de Resumo

*   **Arquivo .md**: Deve conter os tópicos principais, pré-requisitos, passo a passo (se houver) e campos importantes citados na documentação.
*   **Chat**: Foque na resposta direta à pergunta do usuário, de forma executiva.

## Exemplos de Uso

**Usuário**: "O que é o programa CD0606?"
**Ações**:
1.  Busca `cql=siteSearch ~ "CD0606" AND space = "LDT"`.
2.  Acessa a página "CD0606 - Cadastro de Mensagens".
3.  Resume a funcionalidade e campos principais.
4.  Cria o arquivo `scratch\docs-search-result.md`.
5.  Responde: "O programa CD0606 é utilizado para o cadastro de mensagens padronizadas que podem ser impressas em documentos do sistema, como notas fiscais e pedidos. [Link para TDN]".
