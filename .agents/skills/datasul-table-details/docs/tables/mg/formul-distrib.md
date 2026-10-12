# Tabela: formul-distrib

**Banco de Dados**: mg
**Label**: Formula Distribuicao
**Descrição**: Formula Distribuicao
**Gerado em**: 16/05/2026, 18:35:10

## Campos

| Campo | Tipo | Label | Formato | Inicial | Obrig. | Include | Help |
| :--- | :--- | :--- | :--- | :--- | :--- | :--- | :--- |
| cod-formula | character | F¢rmula | x(12) |  | Sim |  | C¢digo F¢rmula |
| cod-livre-1 | character | Livre 1 | x(100) |  | Não |  | Atributo livre para uso interno |
| cod-livre-2 | character | Livre 2 | x(100) |  | Não |  | Atributo livre para uso interno |
| dat-livre-1 | date | Livre 1 | 99/99/9999 |  | Não |  | Atributo livre para uso interno |
| dat-livre-2 | date | Livre 2 | 99/99/9999 |  | Não |  | Atributo livre para uso interno |
| des-formula | character | DescriÆo | x(60) |  | Sim |  | DescriÆo  da F¢rmula |
| idi-aplic | integer | AplicaÆo | 9 | 0 | Sim | [diinc/i01di389.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i01di389.i) | AplicaÆo |
| log-livre-1 | logical | Livre 1 | Sim/NÆo | no | Não |  | Atributo livre para uso interno |
| log-livre-2 | logical | Livre 2 | Sim/NÆo | no | Não |  | Atributo livre para uso interno |
| num-livre-1 | integer | Livre 1 | ->>>>>>>>9 | 0 | Não |  | Atributo livre para uso interno |
| num-livre-2 | integer | Livre 2 | ->>>>>>>>9 | 0 | Não |  | Atributo livre para uso interno |
| val-livre-1 | decimal | Livre 1 | ->>>>>>>>>>>9.9999 | 0 | Não |  | Atributo livre para uso interno |
| val-livre-2 | decimal | Livre 2 | ->>>>>>>>>>>9.9999 | 0 | Não |  | Atributo livre para uso interno |

## Índices

- **frmldstr-id** (Primário, Único): idi-aplic, cod-formula
