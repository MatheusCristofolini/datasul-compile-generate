# Relacionamento: nota-fiscal para it-doc-fisc

Este relacionamento descreve como conectar uma Nota Fiscal de saída (Faturamento) aos seus itens correspondentes em um Documento Fiscal de entrada (Recebimento), cenário comum em transferências entre estabelecimentos.

## Caminho de Ligação

Para chegar da `nota-fiscal` (Cabeçalho de Faturamento) até a `it-doc-fisc` (Itens de Documento Fiscal de Recebimento), utilize a seguinte lógica:

1.  **Igualdade de Documento**:
    *   `nota-fiscal.nr-nota-fis` == `it-doc-fisc.nr-doc-fis`
    *   `nota-fiscal.serie` == `it-doc-fisc.serie`

2.  **Identificação do Emitente (Vínculo de Transferência)**:
    *   O `it-doc-fisc.cod-emitente` deve corresponder ao código de emitente do estabelecimento que emitiu a nota (`nota-fiscal.cod-estabel`).
    *   **Nota**: Em transferências, o estabelecimento de origem é cadastrado como um `emitente` para o estabelecimento de destino.

3.  **Estabelecimento de Destino**:
    *   `it-doc-fisc.cod-estabel` representa o estabelecimento que está recebendo a mercadoria.

## Tabelas Envolvidas

| Tabela | Banco | Papel |
| :--- | :--- | :--- |
| [nota-fiscal](file:///c:/Projetos/Gps/V31/.agents/skills/datasul-database-consultant/docs/database/mg.md) | mg | Cabeçalho da Nota Fiscal (Faturamento) |
| [it-doc-fisc](file:///c:/Projetos/Gps/V31/.agents/skills/datasul-database-consultant/docs/database/mg.md) | mg | Itens do Documento Fiscal (Recebimento) |
| [estabelec](file:///c:/Projetos/Gps/V31/.agents/skills/datasul-database-consultant/docs/database/mg.md) | mg | (Opcional) Para traduzir `cod-estabel` em `cod-emitente` |

## Chaves Primárias e Índices Úteis

### nota-fiscal
- **PK**: `cod-estabel`, `serie`, `nr-nota-fis`
- **Índice**: `ch-fatura` (cod-estabel, serie, nr-fatura)

### it-doc-fisc
- **PK**: `cod-estabel`, `serie`, `nr-doc-fis`, `cod-emitente`, `nat-operacao`, `nr-seq-doc`
- **Índice**: `itmdctfs-06` (cod-estabel, it-codigo, dt-ent-doc, nr-doc-fis)
