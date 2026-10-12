# Guia de Discussão GSD (Emulação de IA Nativa)

Quando o usuário pedir para discutir uma fase (ex: `/gsd:discuss-phase N`), você DEVE ler este guia para entender como moldar o contexto de implementação antes de iniciar a fase de Planejamento.

## O Objetivo da Fase de Discussão

O `ROADMAP.md` possui apenas uma frase ou duas por fase. Isso NÃO é contexto suficiente para construir algo exatamente da maneira que o usuário imagina.

Seu trabalho na Fase de Discussão é **capturar as preferências do usuário** antes que qualquer coisa seja pesquisada ou planejada. Você atua como a ponte entre os requisitos de alto nível e o planejamento técnico.

## Etapa 1: Analisar a Fase

Leia a última entrada do `ROADMAP.md` para a Fase N em `docs/gsd/`. Identifique as "áreas cinzentas" com base no que está sendo construído:

- **Recursos Visuais**: Layout, densidade, interações, estados vazios (empty states), animações.
- **APIs/CLIs**: Formato de resposta, flags, tratamento de erros, verbosidade.
- **Sistemas de Conteúdo**: Estrutura, tom, profundidade, fluxo.
- **Tarefas de Organização**: Critérios de agrupamento, convenções de nomenclatura, duplicatas, exceções.
- **Escolhas Técnicas**: Gerenciamento de estado, bibliotecas de componentes, algoritmos específicos.

## Etapa 2: A Entrevista

Não planeje imediatamente. Apresente ao usuário perguntas direcionadas sobre as áreas cinzentas que você identificou.

- Dê opções a ele (ex: "Você prefere um layout de cards ou um layout de lista?").
- Pergunte até que você tenha clareza suficiente para escrever instruções inequívocas para a fase de Planejamento.
- **Importante**: Se o usuário pular a entrevista ou fornecer respostas mínimas, você deve inventar padrões (defaults) razoáveis.

## Etapa 3: Gerar a Saída (`docs/gsd/<AAAA-MM-DD_HH-mm>-{num_fase}-CONTEXT.md`)

Assim que o usuário estiver satisfeito, você deve gerar nativamente `docs/gsd/<AAAA-MM-DD_HH-mm>-{num_fase}-CONTEXT.md`. Este arquivo alimenta diretamente o Planejador.

Formate o arquivo estritamente como segue:

```markdown
# Contexto da Fase N: [Nome da Fase]

## Decisões

_Estas são decisões BLOQUEADAS._ O Planejador DEVE respeitá-las.

- A interface (UI) DEVE usar um layout de cards.
- DEVEMOS usar a biblioteca `jose`, não `jsonwebtoken`.
- Os tokens de autenticação (Auth tokens) DEVEM ser armazenados em cookies `httpOnly`.

## Ideias Adiadas

_Estas coisas explicitamente NÃO acontecerão nesta fase._ O Planejador NÃO DEVE incluir tarefas para elas.

- Sem modo escuro (dark mode).
- Sem funcionalidade de busca.

## Discrição da IA

_Áreas onde o usuário não forneceu preferência e autorizou a IA a fazer escolhas técnicas._

- Biblioteca de toasts de erro (sonner vs react-hot-toast).
- Estratégia de indexação do banco de dados.
```

## Etapa 4: Transição para o Planejamento

Assim que o `{num_fase}-CONTEXT.md` for gerado e salvo em `docs/gsd/`, notifique o usuário que o contexto foi capturado e sugira prosseguir para `/gsd:plan-phase N`.
