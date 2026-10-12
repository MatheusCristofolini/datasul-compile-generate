# Guia de Verificação GSD (Emulação de IA Nativa)

Quando o usuário pedir para verificar uma fase (ex: `/gsd:verify-work N`), você DEVE ler este guia para entender como garantir que a fase entregou o que foi prometido.

## O Objetivo da Fase de Verificação

O propósito da fase de verificação é garantir que a base de código realmente atingiu os objetivos implicitamente prometidos nos requisitos originais. Ela valida a entrega como uma funcionalidade holística, não apenas como uma série de testes unitários.

## Etapa 1: Reunir o Contexto

Você está verificando a Fase `N`. Antes de olhar para o código, você deve saber o que foi prometido.

1. Leia o último `ROADMAP.md` em `docs/gsd/` para entender o objetivo de alto nível.
2. Leia o último `REQUIREMENTS.md` em `docs/gsd/` para entender as regras específicas, restrições e itens essenciais para este projeto.
3. Leia o último `{num_fase}-{N}-SUMMARY.md` em `docs/gsd/` para ver o que o executor afirma ter construído.

## Etapa 2: A Auditoria

Você deve verificar o código contra os requisitos, não apenas contra o resumo de execução.

- **Executar Testes**: Se houver testes unitários ou E2E (ponta a ponta) para a funcionalidade, execute-os.
- **Verificar Estrutura de Arquivos**: Verifique se os componentes, APIs e modelos necessários realmente existem na base de código.
- **Verificar Conexões**: Garanta que a Interface (UI) realmente chame as APIs corretamente e que as APIs realmente falem com o Banco de Dados corretamente.
- **Verificar Restrições**: Se o `REQUIREMENTS.md` exigiu `jose` em vez de `jsonwebtoken`, verifique o `package.json` e as importações para garantir que essa restrição foi respeitada.

## Etapa 3: Detecção de Lacunas (Gaps)

Se o código NÃO atender aos requisitos, ou se os testes falharem, ou se uma funcionalidade específica do roadmap da Fase `N` foi pulada durante a Execução, você deve documentar isso como **Lacunas (Gaps)**.

## Etapa 4: Gerar a Saída (`docs/gsd/<AAAA-MM-DD_HH-mm>-{num_fase}-VERIFICATION.md`)

Você deve gerar um relatório de verificação estruturado nativamente em `docs/gsd/`.

```markdown
# Relatório de Verificação da Fase N: [Nome da Fase]

## Status

[ PASSOU | FALHOU ]

## Resultados da Auditoria

- [x] Todos os componentes necessários estão presentes.
- [x] Os endpoints da API retornam os formatos esperados.
- [x] Os testes de integração passaram.
- [ ] (Falhou) A Interface (UI) ainda está usando uma resposta mockada em vez da API real.

## Lacunas Identificadas

_Liste problemas específicos que devem ser corrigidos._

1. A chamada `fetch` em `Dashboard.tsx` usa uma string `localhost` fixa em vez de uma variável de ambiente.
2. O endpoint `POST` lida com requisições válidas, mas não retorna 400 em caso de campos ausentes.

## Próximos Passos

Se o status for FALHOU, o usuário deve executar uma fase de planejamento de Fechamento de Lacunas (ex: `/gsd:plan-phase N --gaps`) para gerar tarefas para corrigir essas lacunas específicas antes de passar para a próxima fase.
```

Se a verificação passar completamente, notifique o usuário que a Fase `N` está verificada e que ele pode prosseguir para a próxima fase no `ROADMAP.md`.
