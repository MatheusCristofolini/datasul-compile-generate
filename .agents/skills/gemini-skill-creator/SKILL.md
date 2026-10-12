---
name: gemini-skill-creator
description: Siga estas melhores práticas ao criar novas skills para o agente. Use quando for solicitado a criar, arquitetar ou escrever uma nova skill ou etapa de fluxo de trabalho.
---

# Melhores Práticas para Criação de Skills

Quando solicitado a criar uma nova skill ou fluxo de trabalho para o agente, aplique os seguintes princípios fundamentais para garantir que a skill seja robusta, detectável e eficaz.

## 1. Princípios Fundamentais
*   **Conciso é essencial**: A janela de contexto é compartilhada. Adicione apenas contexto que o agente ainda não possui. Questione a necessidade de cada informação.
*   **Assunção padrão**: Assuma que o agente é altamente capaz. Evite explicar detalhadamente conceitos básicos.

## 2. Estrutura da Skill

### Convenções de Nomenclatura
*   **Formato**: Use apenas letras minúsculas, números e hífens (`[a-z0-9\-]`).
*   **Padrão**: Use a forma de gerúndio (verbo + -ando/-endo/-indo) ou frases orientadas à ação (ex: `processando-pdfs`, `processar-pdfs`).
*   **Evite**: Nomes vagos como `helper`, `utils`, `tools`, `documents`, `data`. Não use `anthropic-helper` ou `claude-tools`.

### Escrevendo Descrições Eficazes
*   A descrição é fundamental para a seleção da skill e é injetada no prompt do sistema.
*   **Ponto de vista**: Escreva sempre na terceira pessoa (ex: "Processa arquivos Excel...").
*   **Conteúdo**: Inclua o que a skill faz E gatilhos/contextos específicos para quando usá-la.
    *   *Bom*: Extrai texto e tabelas de arquivos PDF, preenche formulários, mescla documentos. Use ao trabalhar com arquivos PDF ou quando o usuário mencionar PDFs.
    *   *Ruim*: Ajuda com documentos.

### Divulgação Progressiva (Progressive Disclosure)
*   Mantenha o `SKILL.md` com menos de 500 linhas.
*   Para skills complexas, mantenha o `SKILL.md` raiz breve e divida o conteúdo detalhado em arquivos separados (ex: `scripts/`, `examples/`).

## 3. Padrões Comuns

### Padrão de Template
*   Ajuste o nível de rigor às suas necessidades.
*   Forneça uma estrutura de template exata e rigorosa se houver requisitos específicos (como dados estruturados).
*   Forneça templates de orientação flexíveis quando a adaptação baseada na situação for útil.

### Padrão de Exemplos
*   Para Skills onde a qualidade da saída depende fortemente de ver exemplos, forneça pares claros de entrada/saída diretamente nas instruções do `SKILL.md`.

## 4. Requisitos Técnicos
*   **YAML Frontmatter**: O arquivo `SKILL.md` DEVE começar com um frontmatter YAML contendo os campos `name` e `description`.
*   **Validação do campo `name`**: Máximo de 64 caracteres, apenas letras minúsculas/números/hífens.
*   **Validação do campo `description`**: Máximo de 1024 caracteres, não vazio, sem tags XML.
