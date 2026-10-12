# Guia de Limpeza GSD (`/gsd:cleanup`)

## Propósito

Comprimir e arquivar o diretório `docs/gsd/` para mantê-lo enxuto sem perder o contexto histórico. Execute este comando quando o diretório ficar lotado (tipicamente após 2 ou mais fases concluídas ou quando a contagem de arquivos exceder ~30).

---

## Etapa 0 — Inventário e Verificação de Segurança

1. Liste **todos** os arquivos em `docs/gsd/` (excluindo `docs/gsd/archive/`).
2. Leia o **último** `STATE.md` para identificar:
   - A **fase ativa atual** (fases que ainda estão em progresso — sem arquivo de VERIFICATION ainda).
   - O **número da última fase concluída**.
3. Leia o **último** `ROADMAP.md` para entender quais fases estão planejadas vs. concluídas.
4. **NUNCA arquive arquivos pertencentes à fase ativa atual ou a quaisquer fases futuras.** Arquive apenas fases que tenham um arquivo de VERIFICATION correspondente (ou seja, totalmente concluídas).

**Arquivos que devem sempre permanecer em `docs/gsd/` (nunca arquive a versão mais recente):**
- Último `STATE.md`
- Último `ROADMAP.md`
- Último `PROJECT.md`
- Último `REQUIREMENTS.md`
- Quaisquer arquivos COMPACT*.md que você esteja prestes a criar

---

## Etapa 1 — Determinar o que Arquivar

Um arquivo é **arquivável** se pertencer a uma **fase totalmente concluída** (a fase N tem um arquivo de VERIFICATION) e não for o arquivo global mais recente.

Conjuntos típicos de arquivos arquiváveis por fase N concluída:
- `*-N-CONTEXT.md`
- `*-N-RESEARCH.md`
- `*-N-*-PLAN.md`
- `*-N-*-SUMMARY.md`
- `*-N-VERIFICATION.md`

Também arquive **arquivos globais antigos/substituídos** (versões anteriores de PROJECT, ROADMAP, STATE, REQUIREMENTS — que não tenham o timestamp mais recente).

Liste os arquivos arquiváveis explicitamente antes de prosseguir para que o usuário possa confirmar.

---

## Etapa 2 — Criar Arquivos Compactos

Crie três arquivos compactos em `docs/gsd/` antes de mover qualquer coisa. **Estes arquivos NÃO usam prefixo de timestamp** — grave-os com nomes simples: `COMPACT.md`, `COMPACT_DECISIONS.md`, `COMPACT_FUTURE.md`. Eles são sempre sobrescritos em cada execução de limpeza.

### 2a. `COMPACT.md`

Sintetiza o **conhecimento duradouro** de todos os arquivos arquiváveis. Este é o documento único que um agente futuro deve ler para entender todo o histórico do projeto sem precisar ler os arquivos arquivados.

Estrutura:
```markdown
# GSD Compact — <nome do projeto>

_Gerado em: <data>. Cobre as fases <de>–<até>._

## Visão Geral do Projeto
<2-3 parágrafos de resumo sobre o que foi construído, por que e para quem>

## Decisões Arquiteturais (Ainda Relevantes)
<Lista de itens das escolhas arquiteturais que ainda são fundamentais hoje:
  - Seleções de tecnologia (ex: "Usando Prisma ORM — escolhido na fase 3 pela segurança de tipos")
  - Escolhas de design de API
  - Decisões de modelo de dados
  - Escolhas de autenticação/segurança
  Inclua apenas decisões que afetam o trabalho contínuo ou futuro.>

## Resumo Fase a Fase
<Para cada fase N arquivada:
  ### Fase N — <nome>
  - **Objetivo**: <uma frase>
  - **Principais mudanças**: <lista de itens do que foi construído>
  - **Resultado**: <sucesso/falha, quaisquer problemas encontrados na verificação>>

## Restrições Conhecidas e Problemas (Gotchas)
<Coisas que atrapalharam o desenvolvimento, soluções alternativas (workarounds) implementadas, dívida técnica assumida conscientemente>

## Estado Atual (conforme esta compactação)
<O que o sistema pode fazer agora, o que está implantado/funcionando>
```

### 2b. `COMPACT_DECISIONS.md`

Um **log de decisões** — lista curada de decisões importantes tomadas em todas as fases arquivadas. Inclua apenas decisões ainda relevantes para o projeto. Remova decisões que foram substituídas.

Estrutura:
```markdown
# Log de Decisões GSD — <nome do projeto>

_Gerado em: <data>. Cobre as fases <de>–<até>._

## Decisões Ativas

| # | Decisão | Fase | Justificativa | Ainda se Aplica? |
|---|---------|------|---------------|------------------|
| 1 | Usar JWT para auth | 2 | Sem estado, escala horizontalmente | Sim |
| 2 | PostgreSQL em vez de MongoDB | 1 | Dados relacionais, consistência forte | Sim |

## Decisões Substituídas
_Estas decisões foram revertidas ou substituídas — mantidas para contexto histórico._

| # | Decisão Original | Substituída Por | Fase | Por que |
|---|------------------|-----------------|------|---------|
| 1 | API apenas REST | Adicionado endpoint GraphQL | 6 | Frontend precisava de consultas flexíveis |
```

### 2c. `COMPACT_FUTURE.md`

Um **roadmap vivo de intenções futuras** — o que vem a seguir, perguntas em aberto e visão de longo prazo. Atualize este arquivo toda vez que uma nova fase for planejada.

Estrutura:
```markdown
# Planos Futuros GSD — <nome do projeto>

_Última atualização: <data>._

## Próximos Passos (Fases Planejadas)
<Liste as fases do ROADMAP.md que ainda não foram iniciadas, com descrições de uma linha>

## Perguntas em Aberto
<Decisões de design não resolvidas ou incógnitas que afetarão fases futuras>

## Visão de Longo Prazo
<Para onde o projeto está indo além do ROADMAP atual — direção do produto, objetivos de escalabilidade, integrações>

## Funcionalidades Adiadas (Fora de Escopo por Enquanto)
<Funcionalidades explicitamente adiadas do REQUIREMENTS.md — por que foram adiadas e quando revisitar>
```

---

## Etapa 3 — Criar o Diretório de Arquivo e Mover Arquivos

```bash
mkdir -p docs/gsd/archive
```

Mova todos os arquivos arquiváveis (da Etapa 1) para `docs/gsd/archive/`. Mantenha seus nomes de arquivo originais — não os renomeie.

---

## Etapa 4 — Criar `docs/gsd/archive/COMPACTED_INFO.md`

Este é um **índice** de tudo o que está no arquivo, para que agentes futuros possam encontrar contexto sem ler cada arquivo arquivado.

Estrutura:
```markdown
# Índice de Arquivo

_Última atualização: <data>._

## Como usar este índice
Se precisar de contexto sobre uma fase passada, encontre a fase abaixo e leia o arquivo vinculado.
O arquivo COMPACT.md no diretório pai já sintetiza as informações mais importantes.

## Arquivos Arquivados

### Arquivos Globais (substituídos)
| Arquivo | Era | Substituído Por |
|---------|-----|-----------------|
| `2026-03-12_10-00-STATE.md` | STATE Inicial | `2026-03-13_18-30-STATE.md` |

### Arquivos de Fase
| Arquivo | Fase | Tipo | Resumo |
|---------|------|------|--------|
| `2026-03-12_10-15-1-CONTEXT.md` | 1 | CONTEXT | Decisões de auth de usuário: JWT, bcrypt, apenas e-mail+senha |
| `2026-03-12_10-25-1-RESEARCH.md` | 1 | RESEARCH | Avaliado Passport.js vs JWT customizado — escolhido customizado pela simplicidade |
| ... | ... | ... | ... |
```

Preencha uma linha por arquivo arquivado com um resumo significativo de uma linha.

---

## Etapa 5 — Confirmar Estado Final

Após a limpeza, `docs/gsd/` deve conter apenas:
- Últimos arquivos globais: `STATE.md`, `ROADMAP.md`, `PROJECT.md`, `REQUIREMENTS.md`
- Arquivos compactos: `COMPACT.md`, `COMPACT_DECISIONS.md`, `COMPACT_FUTURE.md`
- Arquivos da **fase ativa atual** e quaisquer **fases futuras** ainda não iniciadas
- Subdiretório `archive/`

Imprima um resumo de:
- Quantos arquivos foram arquivados
- Quais arquivos compactos foram criados
- Quais fases permanecem ativas

---

## Quando Executar a Limpeza

- Após cada 2–3 fases concluídas (cadência recomendada)
- Quando `docs/gsd/` tiver mais de ~30 arquivos
- Antes de iniciar um novo marco importante ou readequação de escopo do projeto
- **Não** no meio da execução de uma fase ativa

## Regras de Segurança (Nunca Violar)

1. **Nunca exclua** — apenas mova para `archive/`. Se algo foi arquivado incorretamente, pode ser recuperado.
2. **Nunca arquive** a fase ativa atual ou fases futuras.
3. **Sempre preserve** decisões que ainda sejam arquiteturalmente relevantes, mesmo que antigas.
4. **Peça confirmação do usuário** antes de mover qualquer arquivo — mostre a lista de arquivos a serem arquivados primeiro.
5. **Mantenha a versão mais recente** de todos os arquivos globais (PROJECT, STATE, ROADMAP, REQUIREMENTS) em `docs/gsd/`.
