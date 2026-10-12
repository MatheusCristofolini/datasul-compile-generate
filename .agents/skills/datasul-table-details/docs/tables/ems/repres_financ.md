# Tabela: repres_financ

**Banco de Dados**: ems
**Label**: Representante Financeiro
**Descrição**: Representante Financeiro
**Gerado em**: 14/05/2026, 11:50:17

## Campos

| Campo | Tipo | Label | Formato | Inicial | Obrig. | Include | Help |
| :--- | :--- | :--- | :--- | :--- | :--- | :--- | :--- |
| cdd_version | decimal | VersÆo | >>>,>>>,>>>,>>9 | 0 | Não |  | C¢digo da VersÆo do Registro |
| cdn_repres | integer | Representante | >>>,>>9 | 0 | Sim |  | C¢digo Representante |
| cdn_repres_indir | integer | Repres Indireto | >>>,>>9 | 0 | Não |  | C¢digo Numrico Representante Indireto |
| cod_calend_comis | character | Calend rio ComissÆo | x(6) |  | Não |  | C¢digo Calend rio ComissÆo |
| cod_cart_bcia_avdeb | character | Carteira AD | x(3) |  | Não |  | C¢digo Carteira Banc ria Aviso de Dbito |
| cod_contrat_comis | character | Contrato ComissÆo | x(8) |  | Não |  | C¢digo Contrato ComissÆo |
| cod_empresa | character | Empresa | x(3) |  | Sim |  | C¢digo Empresa |
| cod_livre_1 | character | Livre 1 | x(100) |  | Não |  | Atributo livre para uso interno |
| cod_livre_2 | character | Livre 2 | x(100) |  | Não |  | Atributo livre para uso interno |
| cod_portador | character | Portador | x(5) |  | Não |  | C¢digo Portador |
| cod_tip_repres | character | Tipo Representante | x(8) |  | Sim |  | C¢digo Tipo Representante |
| cod_unid_negoc | character | Unid Neg¢cio | x(3) |  | Sim |  | C¢digo Unidade Neg¢cio |
| dat_livre_1 | date | Livre 1 | 99/99/9999 | today | Não |  | Atributo livre para uso interno |
| dat_livre_2 | date | Livre 2 | 99/99/9999 |  | Não |  | Atributo livre para uso interno |
| ind_forma_pagto_comis | character | Forma Pagamento | X(15) | Pagamento | Sim |  | Indicador Forma Pagamento ComissÆo |
| ind_sit_repres_financ | character | SituaÆo Repres | X(15) |  | Sim |  | Indicador SituaÆo Representante Financeiro |
| ind_tip_comis_ext | character | Tipo Comis Externo | X(15) | Nenhum | Não |  | Indicador Tipo Comissao Externo |
| log_ems_20_atlzdo | logical | 2.0 Atualizado | Sim/NÆo | no | Sim |  | L¢gico Ems 2.0 Atualizado |
| log_envio_bco_histor | logical | Envio Banco Historic | Sim/NÆo | no | Sim |  | L¢gico Envio Banco Historico |
| log_livre_1 | logical | Livre 1 | Sim/NÆo | no | Não |  | Atributo livre para uso interno |
| log_livre_2 | logical | Livre 2 | Sim/NÆo | no | Não |  | Atributo livre para uso interno |
| log_pagto_bloqdo | logical | Bloqueia Pagamento | Sim/NÆo | no | Sim |  | IndicaÆo Bloqueio Pagamento |
| num_livre_1 | integer | Livre 1 | >>>>>9 | 0 | Não |  | Atributo livre para uso interno |
| num_livre_2 | integer | Livre 2 | >>>>>9 | 0 | Não |  | Atributo livre para uso interno |
| val_livre_1 | decimal | Livre 1 | >>>,>>>,>>9.9999 | 0 | Não |  | Atributo livre para uso interno |
| val_livre_2 | decimal | Livre 2 | >>>,>>>,>>9.9999 | 0 | Não |  | Atributo livre para uso interno |
| val_perc_comis_abat | decimal | % Comis Abatimento | >>9.99 | 0 | Sim |  | Percentual ComissÆo no Abatimento |
| val_perc_comis_acerto_val | decimal | % Comis AVA | >>9.99 | 0 | Sim |  | Valor Percentual ComissÆo Acerto Valor |
| val_perc_comis_desc | decimal | % Comis Desconto | >>9.99 | 0 | Sim |  | Percentual ComissÆo no Desconto |
| val_perc_comis_juros | decimal | % Comis Juros | >>9.99 | 0 | Sim |  | Valor Percentual ComissÆo Juros |
| val_perc_comis_max | decimal | ComissÆo M xima | >>9.99 | 100 | Não |  | Valor Percentual Comissao Maximo |
| val_perc_comis_min | decimal | ComissÆo M¡nima | >>9.99 | 0 | Não |  | Valor Percentual Comissao Minimo |
| val_perc_comis_multa | decimal | % Comis Multa | >>9.99 | 0 | Sim |  | Valor Percentual ComissÆo Multa |
| val_perc_comis_repres | decimal | % ComissÆo | >>9.9999 | 0 | Sim |  | Percentual ComissÆo Representante |
| val_perc_comis_repres_emis | decimal | % Comis EmissÆo | >>9.99 | 0 | Sim |  | Percentual ComissÆo Representante na EmissÆo |
| val_perc_comis_repres_indir | decimal | ComissÆo Indireta | >>9.99 | 0 | Não |  | Valor Percentual Comissao Representante Indireto |

## Índices

- **rprsfnnc_id** (Primário, Único): cod_empresa, cdn_repres
- **rprsfnnc_tprprs**: cod_empresa, cod_tip_repres
