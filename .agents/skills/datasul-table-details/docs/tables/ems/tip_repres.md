# Tabela: tip_repres

**Banco de Dados**: ems
**Label**: Tipo Representante
**Descrição**: Tipo de Representante
**Gerado em**: 30/06/2026, 11:12:12

## Campos

| Campo | Tipo | Label | Formato | Inicial | Obrig. | Include | Help |
| :--- | :--- | :--- | :--- | :--- | :--- | :--- | :--- |
| cdd_version | decimal | VersÆo | >>>,>>>,>>>,>>9 | 0 | Não |  | C¢digo da VersÆo do Registro |
| cod_empresa | character | Empresa | x(3) |  | Sim |  | C¢digo Empresa |
| cod_livre_1 | character | Livre 1 | x(100) |  | Não |  | Atributo livre para uso interno |
| cod_livre_2 | character | Livre 2 | x(100) |  | Não |  | Atributo livre para uso interno |
| cod_tip_repres | character | Tipo Representante | x(8) |  | Sim |  | C¢digo Tipo Representante |
| cod_tip_repres_filho | character | Tipo Repres Filho | x(8) |  | Sim |  | C¢digo Tipo Representante Filho |
| dat_livre_1 | date | Livre 1 | 99/99/9999 | today | Não |  | Atributo livre para uso interno |
| dat_livre_2 | date | Livre 2 | 99/99/9999 |  | Não |  | Atributo livre para uso interno |
| des_tip_repres | character | DescriÆo | x(32) |  | Sim |  | DescriÆo Tipo Representante |
| log_dados_financ | logical | Dados Financeiros | Sim/NÆo | no | Sim |  | Dados Aplicativo Financeiro |
| log_livre_1 | logical | Livre 1 | Sim/NÆo | no | Não |  | Atributo livre para uso interno |
| log_livre_2 | logical | Livre 2 | Sim/NÆo | no | Não |  | Atributo livre para uso interno |
| log_topo_estrut_tip_repres | logical | Topo Estrutura | Sim/NÆo | no | Sim |  | Topo Estrutura Tipo Representante ? |
| num_livre_1 | integer | Livre 1 | >>>>>9 | 0 | Não |  | Atributo livre para uso interno |
| num_livre_2 | integer | Livre 2 | >>>>>9 | 0 | Não |  | Atributo livre para uso interno |
| val_livre_1 | decimal | Livre 1 | >>>,>>>,>>9.9999 | 0 | Não |  | Atributo livre para uso interno |
| val_livre_2 | decimal | Livre 2 | >>>,>>>,>>9.9999 | 0 | Não |  | Atributo livre para uso interno |

## Índices

- **tprprs_id** (Primário, Único): cod_empresa, cod_tip_repres
- **tprprs_tprprs**: cod_empresa, cod_tip_repres_filho
