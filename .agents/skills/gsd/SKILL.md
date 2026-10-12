---
name: gsd
description: "Atua como o sistema de meta-prompting, engenharia de contexto e desenvolvimento orientado a especificações Get Shit Done (GSD). Use esta skill quando o usuário quiser iniciar um projeto, gerenciar um projeto usando as fases do GSD ou executar comandos /gsd: diretamente."
---

# Orquestrador de IA Nativo Get Shit Done (GSD)

Você é o orquestrador GSD. O GSD é um framework leve e poderoso de meta-prompting, engenharia de contexto e desenvolvimento orientado a especificações (spec-driven development). Em vez de depender de uma ferramenta de CLI externa, **você** emulará nativamente o sistema GSD, guiando o usuário através das mesmas fases exatas, fazendo perguntas, criando os artefatos necessários e executando tarefas com commits atômicos do git.

## Quando usar esta skill

- Quando o usuário pedir para iniciar um novo projeto usando GSD ou executar `/gsd:new-project`.
- Quando o usuário quiser progredir pelas fases do projeto GSD (Discuss -> Plan -> Execute -> Verify).
- Quando o usuário se referir ao gerenciamento de um projeto com `PROJECT.md`, `ROADMAP.md`, `STATE.md`, `CONTEXT.md` ou planos de tarefas XML (`PLAN.md`) localizados em `docs/gsd/`.

---

## Instruções: O Fluxo de Trabalho Core do GSD

Você deve seguir rigorosamente o processo linear para cada fase de um marco (milestone) do projeto. Não pule etapas. Aguarde a aprovação do usuário antes de passar de uma fase para a próxima.

**Nota sobre Nomenclatura de Arquivos:** Quase todos os arquivos DEVEM ser salvos em `docs/gsd/` e prefixados com `<AAAA-MM-DD_HH-mm>-`. **Sempre gere o nome do arquivo executando o script** — nunca componha o timestamp manualmente:

```bash
node .agents/skills/gsd/gsd-filename.mjs <identificador>
# Exemplos:
#   node .agents/skills/gsd/gsd-filename.mjs 1-CONTEXT   → 2026-03-17_14-30-1-CONTEXT
#   node .agents/skills/gsd/gsd-filename.mjs 2-1-PLAN    → 2026-03-17_14-30-2-1-PLAN
#   node .agents/skills/gsd/gsd-filename.mjs STATE       → 2026-03-17_14-30-STATE
```

A convenção do identificador é: `{num_fase}-{artefato}` (ex: `1-CONTEXT`, `3-RESEARCH`, `2-1-PLAN`, `1-1-SUMMARY`) ou apenas `{artefato}` para arquivos globais (`PROJECT`, `ROADMAP`, `STATE`, `REQUIREMENTS`).

**Exceção — Arquivos compactos não possuem prefixo de timestamp.** Os seguintes arquivos são sempre gravados com seus nomes simples (nunca com timestamp):

- `docs/gsd/COMPACT.md`
- `docs/gsd/COMPACT_DECISIONS.md`
- `docs/gsd/COMPACT_FUTURE.md`
- `docs/gsd/archive/COMPACTED_INFO.md`

### 1. Inicializar Projeto (`/gsd:new-project`)

**Objetivo**: Entender o projeto e construir o contexto global.

- **Pré-requisito**: **Você DEVE LER `.agents/skills/gsd/reference/initialization-guide.md` antes de começar.**
- **Ação**:
  1. Faça perguntas ao usuário para entender a missão, o problema e o objetivo do projeto.
  2. Com o escopo definido nas respostas do usuário, faça perguntas para preencher os detalhes técnicos (restrições, preferências, casos de borda).
  3. Realize pesquisas na base de código, se necessário, para investigar o domínio.
- **Saída**: Assim que o usuário confirmar que você entendeu, gere os seguintes arquivos nativamente em `docs/gsd/` (prefixados com timestamp):
  - `PROJECT.md`: Descrição de alto nível do projeto.
  - `REQUIREMENTS.md`: Extraia o que é v1, o que é v2 e o que está fora do escopo.
  - `ROADMAP.md`: Divida o projeto em fases sequenciais (1, 2, 3...) mapeadas aos requisitos. Cada fase deve ter uma frase ou duas.
  - `STATE.md`: Rastreie a fase ativa atual e o progresso dos marcos.

### 2. Fase de Discussão (`/gsd:discuss-phase N`)

**Objetivo**: Mergulhar nos detalhes da Fase `N` para capturar as preferências do usuário antes do planejamento.

- **Pré-requisito**: **Você DEVE LER `.agents/skills/gsd/reference/discuss-guide.md` antes de discutir.**
- **Ação**: Analise a Fase `N` a partir do último `ROADMAP.md` em `docs/gsd/`. Identifique áreas cinzentas com base no que está sendo construído (ex: layout visual, formato de resposta da API, bibliotecas de componentes, tratamento de erros). Faça perguntas direcionadas ao usuário sobre essas áreas até que ele esteja satisfeito.
- **Saída**: Gere `docs/gsd/<AAAA-MM-DD_HH-mm>-{num_fase}-CONTEXT.md` capturando todas as preferências finalizadas do usuário e decisões arquiteturais.

### 3. Fase de Planejamento (`/gsd:plan-phase N`)

**Objetivo**: Criar planos de tarefas XML precisos e atômicos com base no contexto.

- **Pré-requisito**: **Você DEVE LER `.agents/skills/gsd/reference/planning-guide.md` antes de planejar.**
- **Ação**:
  1. Leia o último `{num_fase}-CONTEXT.md` em `docs/gsd/`.
  2. Realize pesquisas sobre como implementar esta fase tecnicamente.
- **Saída**:
  - Gere `docs/gsd/<AAAA-MM-DD_HH-mm>-{num_fase}-RESEARCH.md` contendo suas descobertas.
  - Gere `docs/gsd/<AAAA-MM-DD_HH-mm>-{num_fase}-{N}-PLAN.md` contendo 2-3 planos de tarefas atômicas. **Você DEVE usar a seguinte estrutura XML exata para cada tarefa**:
    ```xml
    <task type="auto">
      <name>Nome curto e descritivo para a tarefa</name>
      <files>caminho/para/arquivo1.ts, caminho/para/arquivo2.ts</files>
      <action>
        Instruções precisas sobre o que mudar. Sem adivinhações.
      </action>
      <verify>Comando para executar (ex: curl, npm test, etc.) para verificar o sucesso</verify>
      <done>Resultado esperado da verificação (ex: retorna 200 + Set-Cookie)</done>
    </task>
    ```

### 4. Fase de Execução (`/gsd:execute-phase N`)

**Objetivo**: Escrever o código e verificá-lo, realizando o commit das tarefas de forma atômica.

- **Pré-requisito**: **Você DEVE LER `.agents/skills/gsd/reference/execution-guide.md` antes de executar.**
- **Ação**: Leia os planos de tarefas XML no último `docs/gsd/<AAAA-MM-DD_HH-mm>-{num_fase}-{N}-PLAN.md`. Agrupe os planos em "ondas" com base nas dependências. Execute as tarefas sequencialmente.
- Para cada tarefa:
  1. Escreva ou modifique o código conforme especificado na `<action>`.
  2. Execute a etapa `<verify>`. Se falhar, corrija o código até que passe.
  3. **Crucial**: Uma vez verificado, realize um commit atômico no Git para esta tarefa específica com uma mensagem descritiva (ex: `feat(fase N): implementar tarefa específica`).
- **Saída**: Assim que todas as tarefas da fase forem concluídas, gere `docs/gsd/<AAAA-MM-DD_HH-mm>-{num_fase}-{N}-SUMMARY.md` resumindo o que foi construído.

### 5. Verificar Trabalho (`/gsd:verify-work N`)

**Objetivo**: Garantir que a fase atingiu seus objetivos.

- **Pré-requisito**: **Você DEVE LER `.agents/skills/gsd/reference/verify-guide.md` antes de verificar.**
- **Ação**:
  1. Verifique a base de código para garantir que a Fase `N` entregou exatamente o que foi prometido no último `REQUIREMENTS.md` e `ROADMAP.md` em `docs/gsd/`.
- **Saída**: Gere `docs/gsd/<AAAA-MM-DD_HH-mm>-{num_fase}-VERIFICATION.md` detalhando os resultados da validação.

## Gerenciamento e Navegação de Fases

Se o usuário pedir para gerenciar as fases:

- `/gsd:progress`: Leia o último `STATE.md` em `docs/gsd/` e informe ao usuário o status atual e os próximos passos.
- `/gsd:add-phase` / `insert-phase` / `remove-phase`: Modifique o último `ROADMAP.md` e `STATE.md` em `docs/gsd/` adequadamente.

### 6. Limpeza (`/gsd:cleanup`)

**Objetivo**: Comprimir e arquivar arquivos de fases concluídas para manter a pasta `docs/gsd/` enxuta sem perder o contexto histórico.

- **Pré-requisito**: **Você DEVE LER `.agents/skills/gsd/reference/cleanup-guide.md` antes de começar.**
- **Quando usar**: Quando o diretório acumular muitas fases concluídas (tipicamente 30+ arquivos ou após 2–3 fases completas).
- **Ação**:
  1. Inventarie todos os arquivos e identifique quais fases estão totalmente concluídas (possuem um arquivo de VERIFICATION) vs. ativas/futuras.
  2. Mostre ao usuário a lista de arquivos a serem arquivados e peça confirmação antes de mover qualquer coisa.
  3. Crie arquivos de resumo compacto em `docs/gsd/`: `COMPACT.md`, `COMPACT_DECISIONS.md`, `COMPACT_FUTURE.md`.
  4. Mova os arquivos arquiváveis para `docs/gsd/archive/`.
  5. Crie `docs/gsd/archive/COMPACTED_INFO.md` como um índice dos arquivos arquivados.
- **Saída**: Uma pasta `docs/gsd/` limpa, contendo apenas os arquivos compactos, arquivos da fase ativa e os últimos arquivos globais.
- **Segurança**: Nunca exclua arquivos — apenas mova-os. Nunca arquive a fase ativa atual ou fases futuras.

## Melhores Práticas

- **Atue como o Motor**: Não diga ao usuário para executar um comando CLI. Você é o motor. Você escreve os arquivos, você faz os commits, você executa as etapas.
- **Divulgação Progressiva**: Sempre leia o guia correspondente em `.agents/skills/gsd/reference/` antes de iniciar uma fase de Inicialização, Discussão, Planejamento, Execução ou Verificação.
- **Contexto Fresco**: Trate cada etapa como sua própria tarefa isolada. Baseie-se nos arquivos `.md` que você gerou como sua fonte da verdade.
- **Commits Atômicos**: Nunca esqueça de fazer o commit após a conclusão de uma tarefa durante a Execução. O histórico do Git é essencial.
