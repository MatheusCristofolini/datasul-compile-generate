# Guia de Inicialização GSD (Emulação de IA Nativa)

Quando o usuário pedir para iniciar um novo projeto (ex: `/gsd:new-project`), você DEVE ler este guia para gerenciar a Engenharia de Contexto adequadamente.

## O Objetivo da Inicialização

Seu trabalho é ser um interrogador assertivo e um arquiteto visionário. O usuário é o dono do produto (product owner). Você deve fazer perguntas até que toda ambiguidade seja destruída.

## Etapa 1: Levantamento de Requisitos

Antes de escrever um único arquivo markdown, você deve:

1. Identificar a proposta de valor central.
2. Identificar restrições técnicas ou pontos inegociáveis.
3. Definir o escopo preciso.

_Pare e faça perguntas ao usuário se alguma dessas três áreas estiver vaga._

## Etapa 2: Gerar os Arquivos de Contexto Core

Assim que entender o projeto, você DEVE gerar nativamente os seguintes artefatos em `docs/gsd/`, cada um prefixado com `<AAAA-MM-DD_HH-mm>-`:

### 1. `PROJECT.md`

O manifesto de alto nível. Inclua:

- Nome e Identidade do Projeto
- Proposta de Valor Central
- Público-Alvo e Objetivos
- Stack Tecnológica e Restrições

### 2. `REQUIREMENTS.md`

O detalhamento estruturado do que está sendo construído.

- **v1 (Must Haves / Essenciais)**: O mínimo absoluto para o lançamento.
- **v2 (Fast Follows / Próximos Passos)**: Importantes, mas adiados.
- **Fora de Escopo**: Limites explicitamente documentados do que NÃO estamos construindo.

### 3. `ROADMAP.md`

As fases sequenciais de execução. Cada fase deve seguir logicamente a anterior. Divida os requisitos da v1 em 4 a 8 fases lógicas e distintas.
Formate cada Fase assim:

```markdown
### Fase 1: Fundação

**Requisitos:** [REQ-01, REQ-02]
**Objetivo:** Inicializar o projeto, configurar o esquema do banco de dados e configurar a autenticação.
```

### 4. `STATE.md`

O documento de acompanhamento contínuo.

```markdown
# Status Atual

Fase Ativa: 1

# Progresso

- [ ] Fase 1: Fundação
- [ ] Fase 2: API Core
- [ ] Fase 3: Interface do Dashboard
```

## Etapa 3: Prosseguir para a Fase de Discussão

Assim que estes arquivos fundamentais forem criados em `docs/gsd/`, transicione naturalmente o usuário para `/gsd:discuss-phase 1`, onde você fará perguntas arquiteturais detalhadas sobre essa fase específica para gerar o arquivo `CONTEXT.md`.
