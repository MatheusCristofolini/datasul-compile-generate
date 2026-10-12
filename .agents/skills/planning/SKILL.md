---
name: planning
description: Escreve planos de implementação detalhados passo a passo, assumindo que o engenheiro não tem contexto sobre a base de código. Use quando tiver uma especificação validada ou requisitos para uma tarefa antes de escrever qualquer código.
---

# Planejamento (Planning)

## Visão Geral

Escreva planos de implementação abrangentes assumindo que o engenheiro tem zero contexto sobre nossa base de código e um gosto questionável. Documente tudo o que eles precisam saber: quais arquivos tocar em cada tarefa, código, testes, documentos que possam precisar verificar e como testar tudo. Entregue o plano completo como tarefas de tamanho reduzido seguindo os princípios DRY, YAGNI e TDD.

**Contexto:** Isso deve ser executado após o brainstorming de um design ou quando uma especificação clara de funcionalidade for fornecida.

## Granularidade de Tarefas Reduzidas

**Cada etapa é uma ação focada (2-5 minutos):**
- "Escrever o teste que falha" - etapa
- "Executar para garantir que falha" - etapa
- "Implementar o código mínimo para fazer o teste passar" - etapa
- "Executar os testes e garantir que passem" - etapa
- "Commit" - etapa

## Cabeçalho do Documento de Plano

Todo plano DEVE começar com este formato de cabeçalho:

```markdown
# Plano de Implementação: [Nome da Funcionalidade]

**Objetivo:** [Uma frase descrevendo o que isso constrói]

**Arquitetura:** [2-3 frases sobre a abordagem]

**Stack Tecnológica:** [Principais tecnologias/bibliotecas]

---
```

## Estrutura da Tarefa

```markdown
### Tarefa N: [Nome do Componente]

**Arquivos:**
- Criar: `caminho/exato/para/arquivo.ext`
- Modificar: `caminho/exato/para/existente.ext:123-145`
- Testar: `tests/caminho/exato/para/teste.ext`

**Passo 1: Escrever o teste que falha**
[Bloco de código com a implementação do teste]

**Passo 2: Executar teste para verificar que falha**
[Bloco de comando para executar o teste específico]
Esperado: FAIL com "[erro esperado]"

**Passo 3: Escrever implementação mínima**
[Bloco de código com a implementação real]

**Passo 4: Executar teste para verificar que passa**
[Bloco de comando para executar o teste específico]
Esperado: PASS

**Passo 5: Commit**
[Bloco de comando com instruções de git add/commit]
```

## Princípios Chave
- **Caminhos de arquivo exatos sempre:** Nunca use caminhos vagos.
- **Código completo no plano:** Forneça os trechos de código reais, evite frases como "adicionar lógica de validação".
- **Comandos exatos:** Forneça comandos CLI exatos com a saída esperada.
- **DRY & YAGNI:** Não exagere na engenharia. Foque estritamente no que é necessário.
