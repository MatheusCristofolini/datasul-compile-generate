# Tabela: preco-item

**Banco de Dados**: mg
**Label**: Tabela Preos do Item
**Descrição**: Tabelas de Preo por Item
**Gerado em**: 20/07/2026, 15:40:15

## Campos

| Campo | Tipo | Label | Formato | Inicial | Obrig. | Include | Help |
| :--- | :--- | :--- | :--- | :--- | :--- | :--- | :--- |
| char-1 | character |  | x(100) |  | Não |  |  |
| char-2 | character |  | x(100) |  | Não |  |  |
| check-sum | character | Check-sum | x(20) |  | Não |  |  |
| cod-markup | integer | Cod Markup | >>>>>>9 | 0 | Sim |  | C¢digo do Markup |
| cod-refer | character | Referncia | x(8) |  | Sim |  | C¢digo de referncia do item |
| cod-unid-med | character | Unid Med | xx |  | Sim |  | Unidade de Medida em que foi definido o preo do Item na tabela |
| data-1 | date |  | 99/99/9999 |  | Não |  |  |
| data-2 | date |  | 99/99/9999 |  | Não |  |  |
| dec-1 | decimal |  | ->>>>>>>>>>>9.99999999 | 0 | Não |  |  |
| dec-2 | decimal |  | ->>>>>>>>>>>9.99999999 | 0 | Não |  |  |
| desco-quant | decimal | Desconto Quantidade | ->9.99999 | 0 | Sim |  | Desconto por quantidade |
| dt-inival | date | In¡cio Validade | 99/99/9999 | today | Sim |  | Data de in¡co da validade do preo dentro da tabela |
| dt-useralt | date | Dt éltima AlteraÆo | 99/99/9999 | today | Não |  | Data da £ltima alteraÆo |
| int-1 | integer |  | ->>>>>>>>>9 | 0 | Não |  |  |
| int-2 | integer |  | ->>>>>>>>>9 | 0 | Não |  |  |
| it-codigo | character | Item/Produto | x(16) |  | Sim |  | C¢digo do item ou produto |
| log-1 | logical |  | Sim/NÆo | no | Não |  |  |
| log-2 | logical |  | Sim/NÆo | no | Não |  |  |
| log-preco-informado | logical | Preo Informado | Sim/NÆo | no | Não |  | O preo de venda foi informado na sua geraÆo? |
| nr-tabpre | character | Tab Preos | x(08) |  | Sim |  | Tabela de preos |
| pre-un-fam | logical | Preo UM Fam¡lia | yes/no | no | Não |  | Indica se o preo do  item diz respeito a UM da fam¡lia |
| preco-fob | decimal | Preo FOB | >>>,>>>,>>9.99999 | 0 | Sim |  | Preo de venda do item FOB |
| preco-lucro-zero | decimal | Preo Lucro Zero | >>>,>>>,>>9.99999 | 0 | Sim |  | Preo de venda do item (Lucro Zero) |
| preco-min-cif | decimal | Preo Min CIF | >>>,>>>,>>9.99999 | 0 | Sim |  | Preo de venda m¡nimo CIF |
| preco-min-fob | decimal | Preo Min FOB | >>>,>>>,>>9.99999 | 0 | Sim |  | Preo de venda m¡nimo FOB |
| preco-venda | decimal | Preo CIF | >>>,>>>,>>9.99999 | 0 | Sim |  | Preo de venda do item CIF |
| quant-min | decimal | Quantidade M¡nima | >>>>,>>9.9999 | 0 | Sim |  | Quantidade m¡nima para venda |
| situacao | integer | SituaÆo | 99 | 1 | Não | [diinc/i01di014.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i01di014.i) | SituaÆo do Item na Tabela da Preos |
| user-alter | character | Usu rio Ult Alt | x(12) |  | Não |  | Usu rio da £ltima atualizaÆo |
| val-encargo-financ | decimal | Encargo Financeiro | >>9.99 | 0 | Não |  | Valor Encargo Financeiro |
| val-pct-lucro | decimal | Perc Lucro | ->>9.999 | 0 | Não |  | Percentual de lucro calculado na geraÆo do preo de venda |
| val-tax-antecip | decimal | Taxa Antecipacao | >>9.99 | 0 | Não |  | Valor Taxa Antecipacao |

## Índices

- **ch-itemtab** (Primário): it-codigo, cod-refer, cod-unid-med, nr-tabpre, dt-inival, quant-min
- **bnbbb**: user-alter
- **ch-markup**: nr-tabpre, it-codigo, cod-refer, cod-markup
- **ch-tabitem** (Único): nr-tabpre, it-codigo, cod-refer, cod-unid-med, dt-inival, quant-min
