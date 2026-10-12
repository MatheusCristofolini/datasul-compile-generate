# Tabela: representante

**Banco de Dados**: ems
**Label**: Representante
**Descrição**: Representante
**Gerado em**: 15/05/2026, 17:46:09

## Campos

| Campo | Tipo | Label | Formato | Inicial | Obrig. | Include | Help |
| :--- | :--- | :--- | :--- | :--- | :--- | :--- | :--- |
| cdd_version | decimal | VersÆo | >>>,>>>,>>>,>>9 | 0 | Não |  | C¢digo da VersÆo do Registro |
| cdn_repres | integer | Representante | >>>,>>9 | 0 | Sim |  | C¢digo Representante |
| cod_empresa | character | Empresa | x(3) |  | Sim |  | C¢digo Empresa |
| cod_grp_repres | character | Grupo Repres | x(4) |  | Não |  | C¢digo Grupo Representantes |
| cod_id_feder | character | ID Federal | x(20) |  | Não |  | C¢digo ID Federal |
| cod_livre_1 | character | Livre 1 | x(100) |  | Não |  | Atributo livre para uso interno |
| cod_livre_2 | character | Livre 2 | x(100) |  | Não |  | Atributo livre para uso interno |
| cod_pais | character | Pa¡s | x(3) |  | Não |  | C¢digo Pa¡s |
| cod_tip_repres | character | Tipo Representante | x(8) |  | Sim |  | C¢digo Tipo Representante |
| dat_desligto | date | Dt Desligamento | 99/99/9999 |  | Não |  | Data Desligamento |
| dat_impl_repres | date | ImplantaÆo Repres | 99/99/9999 | today | Sim |  | Data ImplantaÆo Representante |
| dat_livre_1 | date | Livre 1 | 99/99/9999 | today | Não |  | Atributo livre para uso interno |
| dat_livre_2 | date | Livre 2 | 99/99/9999 |  | Não |  | Atributo livre para uso interno |
| ind_sit_repres | character | SituaÆo Represtante | X(10) | Ativo | Não |  | Indicador SituaÆo Representante |
| log_livre_1 | logical | Livre 1 | Sim/NÆo | no | Não |  | Atributo livre para uso interno |
| log_livre_2 | logical | Livre 2 | Sim/NÆo | no | Não |  | Atributo livre para uso interno |
| nom_abrev | character | Nome Abreviado | x(15) |  | Sim |  | Nome Abreviado |
| nom_pessoa | character | Nome | x(40) |  | Sim |  | Nome Pessoa |
| num_livre_1 | integer | Livre 1 | >>>>>9 | 0 | Não |  | Atributo livre para uso interno |
| num_livre_2 | integer | Livre 2 | >>>>>9 | 0 | Não |  | Atributo livre para uso interno |
| num_pessoa | integer | Pessoa | >>>,>>>,>>9 | 0 | Sim |  | Pessoa |
| val_livre_1 | decimal | Livre 1 | >>>,>>>,>>9.9999 | 0 | Não |  | Atributo livre para uso interno |
| val_livre_2 | decimal | Livre 2 | >>>,>>>,>>9.9999 | 0 | Não |  | Atributo livre para uso interno |

## Índices

- **rprsntnt_id** (Primário, Único): cod_empresa, cdn_repres
- **rprsntnt_grprprs**: cod_grp_repres
- **rprsntnt_nome_abrev** (Único): cod_empresa, nom_abrev
- **rprsntnt_num_pessoa**: num_pessoa
- **rprsntnt_tprprs**: cod_empresa, cod_tip_repres
