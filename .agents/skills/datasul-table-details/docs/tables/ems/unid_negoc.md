# Tabela: unid_negoc

**Banco de Dados**: ems
**Label**: Unidade de Neg¢cio
**Descrição**: Unidades de Neg¢cio
**Gerado em**: 16/05/2026, 13:08:51

## Campos

| Campo | Tipo | Label | Formato | Inicial | Obrig. | Include | Help |
| :--- | :--- | :--- | :--- | :--- | :--- | :--- | :--- |
| cdd_version | decimal | VersÆo | >>>,>>>,>>>,>>9 | 0 | Não |  | C¢digo da VersÆo do Registro |
| cdn_unid_negoc | integer | N£mero Unidade Negoc | >>>>>>9 | 0 | Sim |  | C¢digo N£mero Unidade Neg¢cio |
| cod_livre_1 | character | Livre 1 | x(100) |  | Não |  | Atributo livre para uso interno |
| cod_livre_2 | character | Livre 2 | x(100) |  | Não |  | Atributo livre para uso interno |
| cod_unid_negoc | character | Unid Neg¢cio | x(3) |  | Sim |  | C¢digo Unidade Neg¢cio |
| dat_livre_1 | date | Livre 1 | 99/99/9999 | today | Não |  | Atributo livre para uso interno |
| dat_livre_2 | date | Livre 2 | 99/99/9999 |  | Não |  | Atributo livre para uso interno |
| des_anot_tab | character | AnotaÆo Tabela | x(2000) |  | Sim |  | DescriÆo AnotaÆo Tabela |
| des_unid_negoc | character | DescriÆo | x(40) |  | Sim |  | DescriÆo Unidade Neg¢cio |
| ind_espec_unid_negoc | character | Espcie UN | X(10) | Anal¡tica | Sim |  | Indicador Especie Unidade Neg¢cio |
| log_livre_1 | logical | Livre 1 | Sim/NÆo | no | Não |  | Atributo livre para uso interno |
| log_livre_2 | logical | Livre 2 | Sim/NÆo | no | Não |  | Atributo livre para uso interno |
| num_livre_1 | integer | Livre 1 | >>>>>9 | 0 | Não |  | Atributo livre para uso interno |
| num_livre_2 | integer | Livre 2 | >>>>>9 | 0 | Não |  | Atributo livre para uso interno |
| val_livre_1 | decimal | Livre 1 | >>>,>>>,>>9.9999 | 0 | Não |  | Atributo livre para uso interno |
| val_livre_2 | decimal | Livre 2 | >>>,>>>,>>9.9999 | 0 | Não |  | Atributo livre para uso interno |

## Índices

- **ndngc_id** (Primário, Único): cod_unid_negoc
- **ndngc_cdn** (Único): cdn_unid_negoc
