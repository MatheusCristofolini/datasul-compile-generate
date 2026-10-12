# Datasul Search & Compile Script Generator (`DatasulCompileGen.exe`)

Utilitário desktop **portátil (`.exe` único)** para Windows que realiza varreduras rápidas em diretórios de fontes **Progress 4GL / OpenEdge ABL (TOTVS Datasul)** — no estilo da busca do VS Code — e gera automaticamente o script `.p` de compilação (`COMPILE <programa> SAVE.`).

Ideal para momentos em que uma tabela do dicionário Progress (ex: `es-teste-123`) sofre alterações e todos os programas afetados (diretamente ou via arquivos de include `.i`) precisam ser recompilados para atualizar o CRC/r-code.

---

## Principais Funcionalidades

1. **Executável 100% Portátil (`DatasulCompileGen.exe`)**:
   - Arquivo único nativo do Windows (`.NET Framework 4.8`), sem necessidade de instalador ou dependências externas.
2. **Busca Estilo VS Code + Filtro de Comentários Progress**:
   - Pesquisa em `.p`, `.w`, `.i` e `.cls` (customizável na tela).
   - Opção para **ignorar ocorrências dentro de comentários** (`/* ... */` inclusive comentários aninhados do Progress, e `//`).
   - Suporte a codificações `UTF-8` e `Windows-1252` (`ANSI`) típicas de ambientes Datasul.
   - Painel de visualização de código-fonte com numeração de linhas, destaque da linha clicada e realce do termo buscado.
3. **Rastreamento Reverso Multinível de Includes (`.i` -> `.p`, `.w`, `.cls`)**:
   - Se a palavra buscada estiver dentro de uma include (`.i`), a ferramenta rastreia recursivamente quais programas compiláveis (`.p`, `.w`, `.cls`) chamam essa include (mesmo que haja includes dentro de outras includes, com proteção automática contra referências circulares).
4. **Gerador Flexível de Script de Compilação (`.p`)**:
   - **Seleção Individual:** Marque ou desmarque na lista quais programas devem entrar no script `.p`.
   - **Formato do Caminho:** Escolha entre **Caminho Relativo à Raiz (Padrão PROPATH, ex: `esp/es0001.p`)** ou **Caminho Absoluto (`C:/.../esp/es0001.p`)**.
   - **Dois Modos de Geração do `.p`:**
     - **Com Log de Erros (`NO-ERROR` - Recomendado):** Compila com `COMPILE VALUE(p-cod-prog) SAVE NO-ERROR.` para que o Procedure Editor **não trave** a cada erro de compilação. Salva um arquivo `.log` **sempre no mesmo diretório do script `.p`** contendo **exclusivamente os programas que falharem na compilação** (com linha, coluna e mensagens do `ERROR-STATUS`), e exibe um `MESSAGE` ao final **apenas se houver erros**.
     - **Modo Puro:** Gera apenas as linhas `COMPILE <programa> SAVE.`.

---

## Como Usar

1. Execute diretamente o arquivo portátil **`DatasulCompileGen.exe`** (localizado na raiz do projeto ou em `dist\DatasulCompileGen.exe`).
2. Clique em **Procurar...** e selecione o diretório raiz dos seus programas Progress.
3. Digite a palavra ou nome da tabela (ex: `es-teste-123`) e clique em **Buscar Programas** (ou pressione `Enter`).
4. Inspecione os programas compiláveis na aba **Programas p/ Compilar** (ou veja todas as linhas e includes na aba **Ocorrências Estilo VS Code**).
5. Na aba **Script .p de Compilação (Preview)** (ou pelo botão verde **Salvar Script .p...** no topo), escolha o modo desejado e salve o seu arquivo `.p`!

---

## Como Recompilar o `.exe`

Caso realize alterações no código-fonte em `src/`, basta executar no PowerShell:

```powershell
powershell -ExecutionPolicy Bypass -File .\build.ps1
```
