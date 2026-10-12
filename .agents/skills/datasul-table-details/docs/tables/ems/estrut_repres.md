# Tabela: estrut_repres

**Banco de Dados**: ems
**Label**: Estrutura Representante
**Descrição**: Estrutura Representante
**Gerado em**: 29/06/2026, 13:38:39

## Campos

| Campo | Tipo | Label | Formato | Inicial | Obrig. | Include | Help |
| :--- | :--- | :--- | :--- | :--- | :--- | :--- | :--- |
| cdd_version | decimal | VersÆo | >>>,>>>,>>>,>>9 | 0 | Não |  | C¢digo da VersÆo do Registro |
| cdn_repres_filho | integer | Repres Filho | >>>,>>9 | 0 | Sim |  | C¢digo do Representante Filho |
| cdn_repres_pai | integer | Repres Pai | >>>,>>9 | 0 | Sim |  | C¢digo do Representante Pai |
| cod_empresa | character | Empresa | x(3) |  | Sim |  | C¢digo Empresa |
| cod_livre_1 | character | Livre 1 | x(100) |  | Não |  | Atributo livre para uso interno |
| cod_livre_2 | character | Livre 2 | x(100) |  | Não |  | Atributo livre para uso interno |
| dat_livre_1 | date | Livre 1 | 99/99/9999 | today | Não |  | Atributo livre para uso interno |
| dat_livre_2 | date | Livre 2 | 99/99/9999 |  | Não |  | Atributo livre para uso interno |
| log_livre_1 | logical | Livre 1 | Sim/NÆo | no | Não |  | Atributo livre para uso interno |
| log_livre_2 | logical | Livre 2 | Sim/NÆo | no | Não |  | Atributo livre para uso interno |
| num_livre_1 | integer | Livre 1 | >>>>>9 | 0 | Não |  | Atributo livre para uso interno |
| num_livre_2 | integer | Livre 2 | >>>>>9 | 0 | Não |  | Atributo livre para uso interno |
| num_seq_estrut_repres | integer | Sequncia | >>>>,>>9 | 0 | Sim |  | Sequncia Estrutura Representante |
| val_livre_1 | decimal | Livre 1 | >>>,>>>,>>9.9999 | 0 | Não |  | Atributo livre para uso interno |
| val_livre_2 | decimal | Livre 2 | >>>,>>>,>>9.9999 | 0 | Não |  | Atributo livre para uso interno |
| val_perc_comis_filho | decimal | Comis Filho | >>9.99 | 0 | Sim |  | Percentual de ComissÆo Filho |

## Índices

- **estrtrpr_id** (Primário, Único): cod_empresa, cdn_repres_pai, cdn_repres_filho, num_seq_estrut_repres
- **estrtrpr_repres_filho**: cod_empresa, cdn_repres_filho
