# Guia de Execução GSD (Emulação de IA Nativa)

Quando o usuário pedir para executar uma fase (ex: `/gsd:execute-phase N`), você DEVE ler este guia para entender como executar os planos de tarefas XML com precisão.

## Filosofia de Execução: "Planos são Blueprints"

Você é o executor. Você não re-planeja. Você não "fica criativo". Você executa o plano XML EXATAMENTE como escrito. A tag `<action>` é o seu blueprint (projeto).

## O Loop de Execução

Para cada tarefa na Onda de Execução (Execution Wave) atual:

1. **Entender Contratos**: Se o plano fornecer um bloco `<interfaces>`, use esses tipos/exports exatos. Não saia em uma caça ao tesouro pela base de código.
2. **Executar `<action>`**: Escreva ou modifique os arquivos especificados em `<files>`, seguindo as instruções com precisão.
3. **Verificar via `<verify>`**: Execute o comando de verificação automatizada.
   - Se passar, prossiga para a Etapa 4.
   - Se falhar, leia a saída, corrija o código e tente novamente. Não desista imediatamente. Crie um loop apertado de `Código -> Teste -> Correção` dentro do seu próprio contexto.
4. **Commit Atômico do Git**: Isso é CRÍTICO. No momento em que uma tarefa for verificada e concluída, você DEVE fazer o commit no controle de versão usando uma mensagem de commit estruturada.

### Formato do Commit

```bash
git add [arquivos da tarefa]
git commit -m "feat(fase-N): [nome da tarefa]"
```

_Por quê? O Git bisect encontra as tarefas exatas que falharam. Cada tarefa é independentemente reversível._

## Execução Paralela (Ondas)

O Planejador terá definido os planos de tarefas em Ondas de Execução (Execution Waves) (frontmatter `wave`).

- Execute as tarefas sequencialmente se estiver agindo nativamente.
- Você DEVE terminar TODAS as tarefas da Onda 1 antes de passar para a Onda 2. Se a Onda 1 falhar, você não poderá prosseguir para a Onda 2.

## Protocolo de Checkpoint

Se você encontrar um tipo de tarefa `checkpoint:human-verify` ou `checkpoint:decision`:

1. Pare a execução.
2. Apresente o checkpoint ao usuário.
3. Aguarde a aprovação ou decisão explícita antes de retomar a próxima tarefa ou onda.

## Fechamento de Lacunas (Gap Closure)

Se a verificação falhar e não puder ser corrigida de forma simples, você deve escalar de volta para a **Fase de Planejamento** para criar um plano de Fechamento de Lacunas para resolver a falha.

Ao final da fase de execução, gere `docs/gsd/<AAAA-MM-DD_HH-mm>-{num_fase}-{N}-SUMMARY.md` documentando o estado finalizado e verificado do trabalho.
