# Tabela: cart_bcia

**Banco de Dados**: ems
**Label**: Carteira Banc ria
**Descrição**: Carteira Banc ria
**Gerado em**: 16/05/2026, 13:09:38

## Campos

| Campo | Tipo | Label | Formato | Inicial | Obrig. | Include | Help |
| :--- | :--- | :--- | :--- | :--- | :--- | :--- | :--- |
| cdd_version | decimal | VersÆo | >>>,>>>,>>>,>>9 | 0 | Não |  | C¢digo da VersÆo do Registro |
| cod_cart_bcia | character | Carteira | x(3) |  | Sim |  | Carteira Banc ria |
| cod_livre_1 | character | Livre 1 | x(100) |  | Não |  | Atributo livre para uso interno |
| cod_livre_2 | character | Livre 2 | x(100) |  | Não |  | Atributo livre para uso interno |
| dat_livre_1 | date | Livre 1 | 99/99/9999 | today | Não |  | Atributo livre para uso interno |
| dat_livre_2 | date | Livre 2 | 99/99/9999 |  | Não |  | Atributo livre para uso interno |
| des_cart_bcia | character | Desc Carteira | x(40) |  | Sim |  | DescriÆo Carteira Banc ria |
| ind_tip_cart_bcia | character | Tipo Carteira Bcia | X(15) | Desconto | Sim |  | Indicador Tipo Carteira Banc ria |
| log_atualiza_previs_cfl | logical | Atualiza Prev CFL | Sim/NÆo | yes | Sim |  | Atualiza Previsto Fluxo Caixa |
| log_atualiza_realzdo_cfl | logical | Atualiza RE CFL | Sim/NÆo | yes | Sim |  | Atualiza Realizado Fluxo Caixa |
| log_atualiz_movto_nreal_cmg | logical | Atualiza Movto Nreal | Sim/NÆo | yes | Sim |  | Atualiza Movimento NÆo Realizado Caixa Bancos |
| log_envio_bco_histor | logical | Envio Banco Historic | Sim/NÆo | no | Sim |  | L¢gico Envio Banco Historico |
| log_indcao_perda_dedut | logical | IndicaÆo Perdas | Sim/NÆo | no | Sim |  | Considera na IndicaÆo para Perdas Dedut¡veis |
| log_integr_techfin | logical | IntegraÆo TECHFIN | Sim/NÆo | no | Não |  | IntegraÆo TECHFIN |
| log_livre_1 | logical | Livre 1 | Sim/NÆo | no | Não |  | Atributo livre para uso interno |
| log_livre_2 | logical | Livre 2 | Sim/NÆo | no | Não |  | Atributo livre para uso interno |
| num_livre_1 | integer | Livre 1 | >>>>>9 | 0 | Não |  | Atributo livre para uso interno |
| num_livre_2 | integer | Livre 2 | >>>>>9 | 0 | Não |  | Atributo livre para uso interno |
| val_livre_1 | decimal | Livre 1 | >>>,>>>,>>9.9999 | 0 | Não |  | Atributo livre para uso interno |
| val_livre_2 | decimal | Livre 2 | >>>,>>>,>>9.9999 | 0 | Não |  | Atributo livre para uso interno |

## Índices

- **cartbcia_id** (Primário, Único): cod_cart_bcia
- **cartbcia_tip_cart_bcia**: ind_tip_cart_bcia
