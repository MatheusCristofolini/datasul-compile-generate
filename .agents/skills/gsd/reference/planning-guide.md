# Guia de Planejamento GSD (Emulação de IA Nativa)

Quando o usuário pedir para planejar uma fase (ex: `/gsd:plan-phase N`), você DEVE ler este guia para entender como escrever as tarefas do `PLAN.md` no formato XML.

## A Metodologia do Objetivo para Trás (Goal-Backward)

Não planeje "para frente" (Quais tarefas eu construo?). Planeje "para trás" a partir do objetivo (O que deve ser VERDADE para que o objetivo seja alcançado?).

1. **Derivar Verdades Observáveis**: O que deve ser verdade da perspectiva do usuário?
2. **Derivar Artefatos Necessários**: Quais arquivos/componentes devem EXISTIR para que essas verdades se sustentem?
3. **Derivar Conexões Necessárias**: Como esses artefatos devem se conectar para funcionar?

## Decomposição e Dimensionamento de Tarefas

- **Orçamento de Contexto**: Os planos devem ser concluídos dentro de ~50% do contexto. Sem ansiedade de contexto, mantendo a qualidade do início ao fim.
- **Regra de Ouro**: Máximo de 2-3 tarefas por Plano de Fase.
- **Tamanho**: Cada tarefa deve representar de 15 a 60 minutos de tempo de execução equivalente ao humano. Se modificar mais de 5 arquivos, é muito complexa e deve ser dividida.
- **Fatias Verticais (PREFERENCIAL)**: ex: "Funcionalidade do Usuário (model + API + UI)" rodando em uma única onda.
- **Camadas Horizontais**: Evite separar por camada (ex: todos os models, depois todas as APIs, depois todas as UIs), a menos que haja uma dependência real de tipos ou infraestrutura.

## Anatomia da Tarefa (Formato XML)

Você DEVE estruturar cada plano (`docs/gsd/<AAAA-MM-DD_HH-mm>-{num_fase}-{N}-PLAN.md`) usando tarefas XML estritas e executáveis.

```xml
<task type="auto">
  <name>Criar endpoint de login</name>
  <files>src/app/api/auth/login/route.ts</files>
  <action>
    Instruções precisas aqui. Exemplo: Use jose para JWT (não jsonwebtoken). Valide as credenciais contra a tabela de usuários. Retorne um cookie httpOnly em caso de sucesso. SEM ADIVINHAÇÕES.
  </action>
  <verify>curl -X POST localhost:3000/api/auth/login retorna 200 + Set-Cookie</verify>
  <done>Credenciais válidas retornam cookie, inválidas retornam 401</done>
</task>
```

### Campos Obrigatórios da Tarefa

- `<files>`: Caminhos exatos dos arquivos criados ou modificados (ex: `src/components/Button.tsx`). Sem descrições vagas.
- `<action>`: Instruções específicas de implementação, incluindo o que evitar e POR QUÊ.
- `<verify>`: Como provar que a tarefa está concluída. DEVE ser um comando automatizado e executável via script (ex: `npm test` ou `curl`). "Parece bom" não é aceitável. **Regra de Nyquist:** Se não existir nenhum teste, escreva uma Tarefa 0 para criar o arquivo de teste.
- `<done>`: Critérios de aceitação - o estado mensurável de conclusão.

### Tipos de Tarefa

- `auto`: Execução totalmente autônoma. A IA cuida de tudo. (Use em 99% das vezes).
- `checkpoint:human-verify`: Pausa a execução para o usuário verificar visualmente algo. (Use com moderação).
- `checkpoint:decision`: Pausa para o usuário fazer uma escolha arquitetural.

## Grafo de Dependência e Ondas de Execução

Para cada plano, determine suas dependências. Agrupe os planos em **Ondas (Waves)**.

- **Onda 1 (Wave 1)**: Raízes independentes (rodar em paralelo).
- **Onda 2 (Wave 2)**: Dependem apenas da Onda 1 (rodar apenas após a conclusão da Onda 1).
- **Onda 3 (Wave 3)**: Dependem da Onda 2, etc.
