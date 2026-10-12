# Design System Master: Datasul Search & Compile Generator (UI/UX Pro Max)

## 1. Identidade Visual & Estilo (`ui-ux-pro-max`)
- **Categoria do Produto:** Developer Productivity Tool & Data-Dense Dashboard (`SaaS Dashboard` + `Productivity Tool`).
- **Estilo Dominante:** **Dark Mode (Slate OLED) + Soft UI Evolution + Minimalism**.
- **Inspiração:** Linear, Raycast, Shadcn UI Dark, VS Code Modern.
- **Regras Críticas Aplicadas:**
  - **Zero Controles Win32 Legados com Bordas Brancas:** Migração completa de Windows Forms para **WPF Vetorial (DirectX)** com `ControlTemplate` customizados para botões, inputs, checkboxes, seletores segmentados (segmented controls), listas e scrollbars escuras.
  - **Zero Emojis:** Uso exclusivo de ícones vetoriais SVG (`Path` Geometry 24x24 estilo Lucide/Heroicons).
  - **Contraste WCAG AAA:** Texto primário `#F8FAFC` sobre `#090D16` / `#111827` (> 14:1) e texto secundário `#94A3B8` (> 5.5:1).
  - **Cursor & Feedback:** `Cursor="Hand"` em todos os controles interativos, estados de hover imediatos sem deslocamento de layout (no layout shift).

---

## 2. Paleta de Cores (Dark Slate & Emerald/Blue Pro)

| Token                  | Hex       | Uso                                                                 |
| ---------------------- | --------- | ------------------------------------------------------------------- |
| `BgCanvas`             | `#090D16` | Fundo global da janela principal                                    |
| `BgSurface`            | `#111827` | Cards, painéis principais, cabeçalho e containers                   |
| `BgElevated`           | `#1E293B` | Itens em hover, barra de ferramentas interna, segmented track       |
| `BgInput`              | `#0B1120` | Fundo de campos de texto e caixas de busca                          |
| `BorderSubtle`         | `#1E293B` | Divisórias suaves e bordas de cards                                 |
| `BorderDefault`        | `#334155` | Bordas de inputs e botões secundários                               |
| `BorderFocus`          | `#38BDF8` | Anel/borda de foco ativo nos campos de entrada                      |
| `PrimaryBlue`          | `#2563EB` | Botão principal de Busca e abas ativas                              |
| `PrimaryBlueHover`     | `#3B82F6` | Hover do botão de Busca                                             |
| `SuccessEmerald`       | `#059669` | CTA principal de Exportação do Script `.p`                          |
| `SuccessEmeraldHover`  | `#10B981` | Hover do CTA de Exportação `.p`                                     |
| `DangerRed`            | `#DC2626` | Botão de Cancelar busca                                             |
| `TextPrimary`          | `#F8FAFC` | Títulos, caminhos de programas, código principal                    |
| `TextSecondary`        | `#94A3B8` | Rótulos (labels), subtítulos, cadeias de include                    |
| `TextMuted`            | `#64748B` | Numeração de linhas, dicas de estado vazio                          |
| `BadgeDirectBg`        | `#064E3B` | Fundo da badge `DIRETO` (Texto `#34D399`, Borda `#059669`)          |
| `BadgeIncludeBg`       | `#0C4A6E` | Fundo da badge `VIA INCLUDE .i` (Texto `#38BDF8`, Borda `#0284C7`)  |
| `HighlightLineBg`      | `#1E3A5F` | Destaque da linha selecionada no visualizador de código             |

---

## 3. Tipografia & Hierarquia
- **Fonte de Interface:** `Segoe UI`
  - Título do App: `15pt SemiBold` (`#F8FAFC`)
  - Valores de KPI Card: `18pt Bold` (`#F8FAFC` / `#38BDF8` / `#34D399`)
  - Rótulos de Seção / Botões: `9.5pt SemiBold`
  - Rótulos de Formulário: `9pt Regular` (`#94A3B8`)
- **Fonte de Código e Caminhos Progress:** `Consolas`
  - Visualizador de Código e Script `.p`: `10pt Regular`, altura de linha confortável.
  - Caminhos de Programas (`esp/es0001.p`): `10pt SemiBold`.

---

## 4. Componentes e Layout (Bento & Split Workspace)
1. **Header Bar & Search Command Panel (Card Superior Arredondado `CornerRadius="10"`):**
   - Seletor de Diretório com ícone SVG de pasta + botão `Procurar`.
   - Barra de Busca de destaque com ícone SVG de lupa + filtro de extensões + botões `Buscar Programas` (Azul) e `Exportar Script .p` (Esmeralda).
   - Barra de filtros em *Pills* customizados (`Rastrear Includes .i`, `Ignorar Comentários`, `Palavra Inteira`, `Case Sensitive`).
2. **Faixa de KPI Cards (4 Mini-Cards de Métricas):**
   - `ARQUIVOS VARRIDOS`, `COMPILÁVEIS (.P/.W/.CLS)`, `RASTREADOS VIA .I`, `SELECIONADOS P/ .P`.
3. **Workspace Principal Dividido (`GridSplitter` Suave):**
   - **Painel Esquerdo:** Seletor Segmentado (`Programas p/ Compilar` vs `Árvore de Ocorrências`), barra de filtro instantâneo, botões `Marcar Todos` / `Desmarcar Todos`, e lista customizada com badges coloridas (`DIRETO` / `VIA INCLUDE .i` / `.p` / `.w` / `.cls`).
   - **Painel Direito:** Seletor Segmentado (`Visualizador de Código` vs `Script .p de Compilação`), seletores segmentados modernos para Modo do Script (`Com Log de Erros NO-ERROR` vs `Modo Puro COMPILE SAVE`) e Formato de Caminho (`Relativo PROPATH` vs `Caminho Absoluto`), e visualizador de código numerado com destaque de linha e termo.
