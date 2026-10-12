---
name: progress-docs-search
description: Fornece soluções para erros Progress ABL e responde dúvidas técnicas, gerando resumos concisos no chat e documentação completa em arquivos Markdown. Use ao reportar erros de runtime, dúvidas de sintaxe ou necessidade de exemplos de código Progress.
---

# Progress Docs Search

Esta skill é especializada em diagnosticar erros do Progress OpenEdge (ABL/4GL) e fornecer orientações técnicas detalhadas, seguindo as melhores práticas e a documentação oficial.

## Fluxo de Trabalho

Quando o usuário reportar um erro ou fizer uma pergunta técnica sobre Progress ABL:

1.  **Diagnóstico**: Identifique o código do erro (ex: 72, 138) ou o conceito técnico (ex: `CAN-FIND`, `FOR EACH`).
2.  **Pesquisa**: Utilize o link oficial como base de referência: [ABL Syntax Reference](https://docs.progress.com/pt-BR/bundle/abl-reference/page/ABL-Syntax-Reference.html).
3.  **Resposta em Duas Camadas**:
    *   **No Chat**: Forneça um resumo extremamente objetivo (máximo 3-4 frases) da solução e o link oficial.
    *   **No Arquivo**: Crie um arquivo Markdown temporário no diretório de artefatos da conversa com a explicação completa.

## Padrão de Arquivo de Saída

O arquivo gerado deve seguir esta estrutura:

```markdown
# Solução Progress ABL: [Título do Erro/Dúvida]

## Descrição
Breve explicação do que causa o problema ou como funciona o recurso.

## Solução / Exemplo de Código
Instruções passo a passo e blocos de código formatados.

```progress
/* Exemplo de código */
FOR EACH tabela NO-LOCK:
    DISPLAY tabela.campo.
END.
```

## Referência Oficial
[Link para a documentação da Progress]
```

## Diretrizes de Resposta

*   **Prioridade**: Sempre priorize o uso de `NO-LOCK` em leituras para evitar bloqueios de banco de dados, a menos que uma transação de escrita seja explicitamente necessária.
*   **Contexto Datasul**: Como este workspace é voltado para o Datasul, considere as convenções de desenvolvimento TOTVS (ex: uso de `include` files, padrões de nomenclatura) se aplicável.
*   **Localização dos Arquivos**: Salve os arquivos em `.gemini/antigravity/artifacts/progress-solutions/solucao-[timestamp].md`.

## Exemplos

### Entrada: "Erro 138 no Progress"
**Chat**: "O erro 138 ocorre quando o registro que você está tentando acessar está bloqueado por outro usuário ou processo. **Solução**: Utilize a cláusula `NO-LOCK` se for apenas leitura ou trate o bloqueio com `EXCLUSIVE-LOCK` dentro de um bloco de transação curto. [Ref. Oficial](https://docs.progress.com/pt-BR/bundle/abl-reference/page/ABL-Syntax-Reference.html)"
**Ação**: Criar arquivo `solucao-erro-138.md` com detalhes sobre `NO-WAIT` e `LOCKED`.
