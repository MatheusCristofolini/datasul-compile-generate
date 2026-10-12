# Tabela: pais

**Banco de Dados**: mg
**Label**: Pa¡s
**Descrição**: Cadastro de Paises

## Campos

| Campo | Tipo | Label | Formato | Inicial | Obrig. | Include | Help |
| :--- | :--- | :--- | :--- | :--- | :--- | :--- | :--- |
| char-1 | character |  | x(100) |  | Não |  |  |
| char-2 | character |  | x(100) |  | Não |  |  |
| check-sum | character | Check-sum | x(20) |  | Não |  |  |
| cod-internacional-pais | integer | Pais Impostos | >>9 | 1 | Não | [adinc/i01ad276.i](file:///C:/Projetos/Gps/V31/EMS2/12.1.31-SNAPSHOT/resources/adinc/i01ad276.i) | Pais tratamento impostos |
| cod-pais | integer | C¢digo Pais | >>,>>9 | 0 | Não |  | Informe o c¢digo do pa¡s |
| cod-pais-siscomex | character | Pa¡s Siscomex | x(10) |  | Sim |  | Pa¡s Siscomex |
| control-tax | logical | Controla Imposto | sim/nÆo | no | Não |  | Infome se vai ocorrer um controle de imposto pelo sistema |
| data-1 | date |  | 99/99/9999 |  | Não |  |  |
| data-2 | date |  | 99/99/9999 |  | Não |  |  |
| dec-1 | decimal |  | ->>>>>>>>>>>9.99999999 | 0 | Não |  |  |
| dec-2 | decimal |  | ->>>>>>>>>>>9.99999999 | 0 | Não |  |  |
| form-data | integer | Formato Data | 9 | 1 | Sim |  | 1 - MMDDAA 2 - DDMMAA 3 - AAMMDD |
| id-codigo | character | Idioma Oficial | x(12) |  | Sim |  | Idioma oficial do pais |
| int-1 | integer |  | ->>>>>>>>>9 | 0 | Não |  |  |
| int-2 | integer |  | ->>>>>>>>>9 | 0 | Não |  |  |
| loc-padrao | character | Local Padrao | x(12) |  | Não |  | Local padrao para embarque ou desembarque |
| log-1 | logical |  | Sim/NÆo | no | Não |  |  |
| log-2 | logical |  | Sim/NÆo | no | Não |  |  |
| nome-compl | character | Nome Completo | x(40) |  | Não |  | Nome completo do pais |
| nome-pais | character | Pais | x(20) |  | Sim |  | Nome abreviado do Pais |
| nr-sales-tax | integer | Nr Sales Tax | 99 | 0 | Não |  |  |
| tem-sales-tax | logical | Utiliza Impto Vendas | sim/nÆo | no | Não |  |  |
| tem-vat | logical | Utiliza IVA | sim/nÆo | yes | Não |  |  |

## Índices

- **ch-pais** (Primário): cod-pais
- **ch-nome** (Único): nome-pais
