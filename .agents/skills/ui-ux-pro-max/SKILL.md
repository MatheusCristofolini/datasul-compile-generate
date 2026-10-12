---
name: ui-ux-pro-max
description: 'Inteligência de design UI/UX. 50 estilos, 21 paletas, 50 combinações de fontes, 20 gráficos, 9 stacks (React, Next.js, Vue, Svelte, SwiftUI, React Native, Flutter, Tailwind, shadcn/ui). Ações: planejar, construir, criar, projetar, implementar, revisar, corrigir, melhorar, otimizar, aprimorar, refatorar, verificar código UI/UX. Projetos: site, landing page, dashboard, painel de administração, e-commerce, SaaS, portfólio, blog, aplicativo móvel, .html, .tsx, .vue, .svelte. Elementos: botão, modal, barra de navegação, barra lateral, card, tabela, formulário, gráfico. Estilos: glassmorphism, claymorphism, minimalismo, brutalismo, neumorphism, bento grid, modo escuro, responsivo, skeuomorphism, flat design. Tópicos: paleta de cores, acessibilidade, animação, layout, tipografia, combinação de fontes, espaçamento, hover, sombra, gradiente. Integrações: shadcn/ui MCP para busca de componentes e exemplos.'
---

# UI/UX Pro Max - Inteligência de Design

Guia abrangente de design para aplicações web e móveis. Contém mais de 50 estilos, 97 paletas de cores, 57 combinações de fontes, 99 diretrizes de UX e 25 tipos de gráficos em 9 stacks tecnológicas. Banco de dados pesquisável com recomendações baseadas em prioridade.

## Quando Aplicar

Consulte estas diretrizes quando:

- Projetar novos componentes de UI ou páginas
- Escolher paletas de cores e tipografia
- Revisar código em busca de problemas de UX
- Construir landing pages ou dashboards
- Implementar requisitos de acessibilidade

## Categorias de Regras por Prioridade

| Prioridade | Categoria            | Impacto   | Domínio               |
| ---------- | -------------------- | --------- | --------------------- |
| 1          | Acessibilidade       | CRÍTICO   | `ux`                  |
| 2          | Toque e Interação    | CRÍTICO   | `ux`                  |
| 3          | Performance          | ALTO      | `ux`                  |
| 4          | Layout e Responsivo  | ALTO      | `ux`                  |
| 5          | Tipografia e Cor     | MÉDIO     | `tipografia`, `cor`   |
| 6          | Animação             | MÉDIO     | `ux`                  |
| 7          | Seleção de Estilo    | MÉDIO     | `estilo`, `produto`   |
| 8          | Gráficos e Dados     | BAIXO     | `gráfico`             |

## Referência Rápida

### 1. Acessibilidade (CRÍTICO)

- `color-contrast` - Proporção mínima de 4.5:1 para texto normal
- `focus-states` - Anéis de foco visíveis em elementos interativos
- `alt-text` - Texto alternativo descritivo para imagens significativas
- `aria-labels` - aria-label para botões que contêm apenas ícones
- `keyboard-nav` - Ordem de tabulação coincide com a ordem visual
- `form-labels` - Use label com o atributo for

### 2. Toque e Interação (CRÍTICO)

- `touch-target-size` - Alvos de toque com no mínimo 44x44px
- `hover-vs-tap` - Use clique/toque para as interações principais
- `loading-buttons` - Desabilite o botão durante operações assíncronas
- `error-feedback` - Mensagens de erro claras próximas ao local do problema
- `cursor-pointer` - Adicione cursor-pointer a elementos clicáveis

### 3. Performance (ALTO)

- `image-optimization` - Use WebP, srcset, lazy loading
- `reduced-motion` - Verifique prefers-reduced-motion
- `content-jumping` - Reserve espaço para conteúdo assíncrono

### 4. Layout e Responsividade (ALTO)

- `viewport-meta` - width=device-width initial-scale=1
- `readable-font-size` - Texto do corpo com no mínimo 16px no mobile
- `horizontal-scroll` - Garanta que o conteúdo caiba na largura da viewport
- `z-index-management` - Defina uma escala de z-index (10, 20, 30, 50)

### 5. Tipografia e Cor (MÉDIO)

- `line-height` - Use 1.5-1.75 para o texto do corpo
- `line-length` - Limite a 65-75 caracteres por linha
- `font-pairing` - Combine as personalidades das fontes de título e corpo

### 6. Animação (MÉDIO)

- `duration-timing` - Use 150-300ms para micro-interações
- `transform-performance` - Use transform/opacity, não width/height
- `loading-states` - Skeletons ou spinners de carregamento

### 7. Seleção de Estilo (MÉDIO)

- `style-match` - Combine o estilo com o tipo de produto
- `consistency` - Use o mesmo estilo em todas as páginas
- `no-emoji-icons` - Use ícones SVG, não emojis

### 8. Gráficos e Dados (BAIXO)

- `chart-type` - Combine o tipo de gráfico com o tipo de dado
- `color-guidance` - Use paletas de cores acessíveis
- `data-table` - Forneça uma tabela alternativa para acessibilidade

## Como Usar

Pesquise domínios específicos usando a ferramenta CLI abaixo.

---

## Pré-requisitos

Verifique se o Python está instalado:

```bash
python3 --version || python --version
```

Se o Python não estiver instalado, instale-o conforme o SO do usuário:

**macOS:**

```bash
brew install python3
```

**Ubuntu/Debian:**

```bash
sudo apt update && sudo apt install python3
```

**Windows:**

```powershell
winget install Python.Python.3.12
```

---

## Como Usar Esta Skill

Quando o usuário solicitar trabalho de UI/UX (projetar, construir, criar, implementar, revisar, corrigir, melhorar), siga este fluxo de trabalho:

### Passo 1: Analisar os Requisitos do Usuário

Extraia informações chave da solicitação do usuário:

- **Tipo de produto**: SaaS, e-commerce, portfólio, dashboard, landing page, etc.
- **Palavras-chave de estilo**: minimalista, divertido (playful), profissional, elegante, modo escuro, etc.
- **Setor**: saúde, fintech, jogos, educação, etc.
- **Stack**: React, Vue, Next.js ou o padrão `html-tailwind`

### Passo 2: Gerar Sistema de Design (OBRIGATÓRIO)

**Sempre comece com `--design-system`** para obter recomendações abrangentes com justificativas:

```bash
python3 .agent/skills/ui-ux-pro-max/scripts/search.py "<tipo_de_produto> <setor> <palavras_chave>" --design-system [-p "Nome do Projeto"]
```

Este comando:

1. Pesquisa 5 domínios em paralelo (produto, estilo, cor, landing, tipografia)
2. Aplica regras de raciocínio de `ui-reasoning.csv` para selecionar as melhores combinações
3. Retorna o sistema de design completo: padrão, estilo, cores, tipografia, efeitos
4. Inclui anti-padrões a serem evitados

**Exemplo:**

```bash
python3 .agent/skills/ui-ux-pro-max/scripts/search.py "serviço de beleza spa bem-estar" --design-system -p "Serenity Spa"
```

### Passo 2b: Persistir Sistema de Design (Padrão Master + Sobrescritas)

Para salvar o sistema de design para **recuperação hierárquica entre sessões**, adicione `--persist`:

```bash
python3 .agent/skills/ui-ux-pro-max/scripts/search.py "<consulta>" --design-system --persist -p "Nome do Projeto"
```

Isso cria:

- `design-system/MASTER.md` — Fonte Única de Verdade Global com todas as regras de design
- `design-system/pages/` — Pasta para sobrescritas específicas de cada página

**Com sobrescrita de página específica:**

```bash
python3 .agent/skills/ui-ux-pro-max/scripts/search.py "<consulta>" --design-system --persist -p "Nome do Projeto" --page "dashboard"
```

Isso também cria:

- `design-system/pages/dashboard.md` — Desvios específicos da página em relação ao Master

**Como funciona a recuperação hierárquica:**

1. Ao construir uma página específica (ex: "Checkout"), primeiro verifique `design-system/pages/checkout.md`
2. Se o arquivo da página existir, suas regras **sobrepõem** o arquivo Master
3. Se não, use exclusivamente o `design-system/MASTER.md`

**Prompt para recuperação consciente do contexto:**

```
Estou construindo a página [Nome da Página]. Por favor, leia design-system/MASTER.md.
Também verifique se design-system/pages/[nome-da-pagina].md existe.
Se o arquivo da página existir, dê prioridade às suas regras.
Caso contrário, use exclusivamente as regras do Master.
Agora, gere o código...
```

### Passo 3: Complementar com Pesquisas Detalhadas (conforme necessário)

Após obter o sistema de design, use buscas por domínio para obter detalhes adicionais:

```bash
python3 .agent/skills/ui-ux-pro-max/scripts/search.py "<palavra_chave>" --domain <dominio> [-n <max_resultados>]
```

**Quando usar pesquisas detalhadas:**

| Necessidade                       | Domínio      | Exemplo                                 |
| --------------------------------- | ------------ | --------------------------------------- |
| Mais opções de estilo             | `style`      | `--domain style "glassmorphism dark"`   |
| Recomendações de gráficos         | `chart`      | `--domain chart "real-time dashboard"`  |
| Melhores práticas de UX           | `ux`         | `--domain ux "animation accessibility"` |
| Fontes alternativas               | `typography` | `--domain typography "elegant luxury"`  |
| Estrutura de landing page         | `landing`    | `--domain landing "hero social-proof"`  |

### Passo 4: Diretrizes da Stack (Padrão: html-tailwind)

Obtenha as melhores práticas específicas para a implementação. Se o usuário não especificar uma stack, **defina o padrão como `html-tailwind`**.

```bash
python3 .agent/skills/ui-ux-pro-max/scripts/search.py "<palavra_chave>" --stack html-tailwind
```

Stacks disponíveis: `html-tailwind`, `react`, `nextjs`, `vue`, `svelte`, `swiftui`, `react-native`, `flutter`, `shadcn`, `jetpack-compose`

---

## Referência de Busca

### Domínios Disponíveis

| Domínio      | Use Para                              | Palavras-chave de Exemplo                                |
| ------------ | ------------------------------------- | -------------------------------------------------------- |
| `product`    | Recomendações de tipo de produto      | SaaS, e-commerce, portfólio, saúde, beleza, serviço      |
| `style`      | Estilos de UI, cores, efeitos         | glassmorphism, minimalismo, modo escuro, brutalismo      |
| `typography` | Combinações de fontes, Google Fonts   | elegante, divertido, profissional, moderno               |
| `color`      | Paletas de cores por tipo de produto  | saas, ecommerce, saude, beleza, fintech, servico         |
| `landing`    | Estrutura da página, estratégias CTA  | hero, hero-centric, depoimento, preços, prova social     |
| `chart`      | Tipos de gráficos, recomendação libs  | tendência, comparação, linha do tempo, funil, pizza      |
| `ux`         | Melhores práticas, anti-padrões       | animação, acessibilidade, z-index, carregamento          |
| `react`      | Performance React/Next.js             | waterfall, bundle, suspense, memo, rerender, cache       |
| `web`        | Diretrizes de interface web           | aria, foco, teclado, semântico, virtualize               |
| `prompt`     | Prompts de IA, palavras-chave CSS     | (nome do estilo)                                         |

### Stacks Disponíveis

| Stack             | Foco                                                 |
| ----------------- | ---------------------------------------------------- |
| `html-tailwind`   | Utilitários Tailwind, resposividade, a11y (PADRÃO)   |
| `react`           | Estado, hooks, performance, padrões                  |
| `nextjs`          | SSR, roteamento, imagens, rotas de API               |
| `vue`             | Composition API, Pinia, Vue Router                   |
| `svelte`          | Runes, stores, SvelteKit                              |
| `swiftui`         | Views, Estado, Navegação, Animação                   |
| `react-native`    | Componentes, Navegação, Listas                       |
| `flutter`         | Widgets, Estado, Layout, Temas                       |
| `shadcn`          | Componentes shadcn/ui, temas, formulários, padrões   |
| `jetpack-compose` | Composables, Modificadores, State Hoisting, Recomp.  |

---

## Exemplo de Fluxo de Trabalho

**Solicitação do usuário:** "Criar uma landing page para serviço profissional de cuidados com a pele"

### Passo 1: Analisar Requisitos

- Tipo de produto: Serviço de Beleza/Spa
- Palavras-chave de estilo: elegante, profissional, suave
- Setor: Beleza/Bem-estar
- Stack: html-tailwind (padrão)

### Passo 2: Gerar Sistema de Design (OBRIGATÓRIO)

```bash
python3 .agent/skills/ui-ux-pro-max/scripts/search.py "beauty spa wellness service elegant" --design-system -p "Serenity Spa"
```

**Resultado:** Sistema de design completo com padrão, estilo, cores, tipografia, efeitos e anti-padrões.

### Passo 3: Complementar com Pesquisas Detalhadas (conforme necessário)

```bash
# Obter diretrizes de UX para animação e acessibilidade
python3 .agent/skills/ui-ux-pro-max/scripts/search.py "animation accessibility" --domain ux

# Obter opções de tipografia alternativa, se necessário
python3 .agent/skills/ui-ux-pro-max/scripts/search.py "elegant luxury serif" --domain typography
```

### Passo 4: Diretrizes da Stack

```bash
python3 .agent/skills/ui-ux-pro-max/scripts/search.py "layout responsive form" --stack html-tailwind
```

**Em seguida:** Sintetize o sistema de design + pesquisas detalhadas e implemente o design.

---

## Formatos de Saída

A flag `--design-system` suporta dois formatos de saída:

```bash
# Caixa ASCII (padrão) - melhor para exibição no terminal
python3 .agent/skills/ui-ux-pro-max/scripts/search.py "fintech crypto" --design-system

# Markdown - melhor para documentação
python3 .agent/skills/ui-ux-pro-max/scripts/search.py "fintech crypto" --design-system -f markdown
```

---

## Dicas para Melhores Resultados

1. **Seja específico com palavras-chave** - "dashboard SaaS de saúde" > "app"
2. **Pesquise várias vezes** - Diferentes palavras-chave revelam diferentes insights
3. **Combine domínios** - Estilo + Tipografia + Cor = Sistema de design completo
4. **Sempre verifique o UX** - Pesquise "animação", "z-index", "acessibilidade" para problemas comuns
5. **Use a flag da stack** - Obtenha melhores práticas específicas para a implementação
6. **Itere** - Se a primeira busca não corresponder, tente palavras-chave diferentes

---

## Regras Comuns para uma UI Profissional

Estes são problemas frequentemente ignorados que fazem a UI parecer pouco profissional:

### Ícones e Elementos Visuais

| Regra                          | Faça                                            | Não Faça                               |
| ------------------------------ | ----------------------------------------------- | -------------------------------------- |
| **Sem ícones de emoji**        | Use ícones SVG (Heroicons, Lucide, Simple Icons)| Use emojis como 🎨 🚀 ⚙️ como ícones de UI|
| **Estados de hover estáveis**  | Use transições de cor/opacidade no hover        | Use transformações que alterem o layout|
| **Logotipos de marca corretos**| Pesquise o SVG oficial em Simple Icons          | Adivinhe ou use caminhos de logo errados|
| **Tamanho de ícone consistente**| Use viewBox fixo (24x24) com w-6 h-6            | Misture tamanhos de ícones aleatórios  |

### Interação e Cursor

| Regra                  | Faça                                                    | Não Faça                                     |
| ---------------------- | ------------------------------------------------------- | -------------------------------------------- |
| **Cursor pointer**     | Adicione `cursor-pointer` a todos os cards clicáveis    | Deixe o cursor padrão em elementos interat.  |
| **Feedback de hover**  | Forneça feedback visual (cor, sombra, borda)            | Sem indicação de que o elemento é interativo |
| **Transições suaves**  | Use `transition-colors duration-200`                    | Mudanças instantâneas ou lentas (>500ms)     |

### Contraste Modo Claro/Escuro

| Regra                         | Faça                                | Não Faça                                |
| ----------------------------- | ----------------------------------- | --------------------------------------- |
| **Card glass modo claro**     | Use `bg-white/80` ou mais opacidade | Use `bg-white/10` (muito transparente)  |
| **Contraste de texto claro**  | Use `#0F172A` (slate-900) para texto| Use `#94A3B8` (slate-400) para o corpo  |
| **Texto discreto claro**      | Use no mínimo `#475569` (slate-600) | Use gray-400 ou mais claro              |
| **Visibilidade de bordas**    | Use `border-gray-200` no modo claro | Use `border-white/10` (invisível)       |

### Layout e Espaçamento

| Regra                        | Faça                                | Não Faça                               |
| ---------------------------- | ----------------------------------- | -------------------------------------- |
| **Barra de naveg. flutuante**| Adicione espaçamento `top-4 left-4` | Grude a barra em `top-0 left-0`        |
| **Padding de conteúdo**      | Considere a altura da barra fixa    | Deixe o conteúdo sumir atrás da barra  |
| **Largura máxima consist.**  | Use o mesmo `max-w-6xl` ou `7xl`    | Misture larguras de containers         |

---

## Checklist Pré-Entrega

Antes de entregar o código da UI, verifique estes itens:

### Qualidade Visual

- [ ] Nenhum emoji usado como ícone (use SVG em vez disso)
- [ ] Todos os ícones pertencem a um conjunto consistente (Heroicons/Lucide)
- [ ] Logotipos de marcas estão corretos (verificados no Simple Icons)
- [ ] Estados de hover não causam deslocamento de layout (layout shift)
- [ ] Cores do tema usadas diretamente (bg-primary) em vez de wrapper var()

### Interação

- [ ] Todos os elementos clicáveis possuem `cursor-pointer`
- [ ] Estados de hover fornecem feedback visual claro
- [ ] Transições são suaves (150-300ms)
- [ ] Estados de foco são visíveis para navegação via teclado

### Modo Claro/Escuro

- [ ] Texto no modo claro tem contraste suficiente (mínimo de 4.5:1)
- [ ] Elementos de vidro/transparentes são visíveis no modo claro
- [ ] Bordas são visíveis em ambos os modos
- [ ] Ambos os modos foram testados antes da entrega

### Layout

- [ ] Elementos flutuantes possuem espaçamento adequado das bordas
- [ ] Nenhum conteúdo está escondido atrás de barras de navegação fixas
- [ ] Responsivo em 375px, 768px, 1024px, 1440px
- [ ] Sem rolagem horizontal no mobile

### Acessibilidade

- [ ] Todas as imagens possuem texto alternativo (alt text)
- [ ] Entradas de formulário possuem rótulos (labels)
- [ ] A cor não é o único indicador
- [ ] Opção `prefers-reduced-motion` é respeitada
