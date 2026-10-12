# Tabela: portador

**Banco de Dados**: ems
**Label**: Portador
**Descrição**: Portador
**Gerado em**: 16/05/2026, 13:09:20

## Campos

| Campo | Tipo | Label | Formato | Inicial | Obrig. | Include | Help |
| :--- | :--- | :--- | :--- | :--- | :--- | :--- | :--- |
| cdd_version | decimal | VersÆo | >>>,>>>,>>>,>>9 | 0 | Não |  | C¢digo da VersÆo do Registro |
| cod_agenc_bcia | character | Agncia Banc ria | x(10) |  | Sim |  | C¢digo Agncia Banc ria |
| cod_banco | character | Banco | x(8) |  | Sim |  | C¢digo Banco |
| cod_id_feder | character | ID Federal | x(20) |  | Sim |  | C¢digo ID Federal |
| cod_livre_1 | character | Livre 1 | x(100) |  | Não |  | Atributo livre para uso interno |
| cod_livre_2 | character | Livre 2 | x(100) |  | Não |  | Atributo livre para uso interno |
| cod_pais | character | Pa¡s | x(3) |  | Sim |  | C¢digo Pa¡s |
| cod_portador | character | Portador | x(5) |  | Sim |  | C¢digo Portador |
| dat_livre_1 | date | Livre 1 | 99/99/9999 | today | Não |  | Atributo livre para uso interno |
| dat_livre_2 | date | Livre 2 | 99/99/9999 |  | Não |  | Atributo livre para uso interno |
| ind_tip_portad | character | Tipo Portador | X(15) |  | Sim |  | Tipo Portador |
| log_agrup_tit_cobr_especial | logical | Agrupa T¡tulos | Sim/NÆo | no | Não |  | L¢gico Agrupa T¡tulo Cobrana Especial |
| log_atualiz_previs_fluxo_cx | logical | Atz PR Fluxo Caixa | Sim/NÆo | yes | Não |  | Indicar se Portador Atualiza Movimento Previsto no Fluxo Caixa |
| log_atualiz_realiz_fluxo_cx | logical | Atz RE Fluxo Caixa | Sim/NÆo | yes | Não |  | Indicar se Portador Atualiza Movimento Realizado no Fluxo Caixa |
| log_calc_dat_vencto_cobr | logical | Calcula Dat Vencto | Sim/NÆo | no | Não |  | L¢gico Calcula Data de Vencimento da Cobrana |
| log_livre_1 | logical | Livre 1 | Sim/NÆo | no | Não |  | Atributo livre para uso interno |
| log_livre_2 | logical | Livre 2 | Sim/NÆo | no | Não |  | Atributo livre para uso interno |
| nom_abrev | character | Nome Abreviado | x(15) |  | Sim |  | Nome Abreviado |
| nom_pessoa | character | Nome | x(40) |  | Sim |  | Nome Pessoa |
| num_livre_1 | integer | Livre 1 | >>>>>9 | 0 | Não |  | Atributo livre para uso interno |
| num_livre_2 | integer | Livre 2 | >>>>>9 | 0 | Não |  | Atributo livre para uso interno |
| num_pessoa_jurid | integer | Pessoa Jur¡dica | >>>,>>>,>>9 | 0 | Sim |  | N£mero Pessoa Jur¡dica |
| val_livre_1 | decimal | Livre 1 | >>>,>>>,>>9.9999 | 0 | Não |  | Atributo livre para uso interno |
| val_livre_2 | decimal | Livre 2 | >>>,>>>,>>9.9999 | 0 | Não |  | Atributo livre para uso interno |

## Índices

- **portador_id** (Primário, Único): cod_portador
- **portador_agenc_bcia**: cod_banco, cod_agenc_bcia
- **portador_pais**: cod_pais
- **portador_pessoa_juridica**: num_pessoa_jurid
