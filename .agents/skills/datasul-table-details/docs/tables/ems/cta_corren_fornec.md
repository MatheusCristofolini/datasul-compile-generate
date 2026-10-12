# Tabela: cta_corren_fornec

**Banco de Dados**: ems
**Label**: Contas Correntes Fornecedor
**Descrição**: Contas Correntes Fornecedor
**Gerado em**: 10/05/2026, 20:17:47

## Campos

| Campo | Tipo | Label | Formato | Inicial | Obrig. | Include | Help |
| :--- | :--- | :--- | :--- | :--- | :--- | :--- | :--- |
| cdn_fornecedor | integer | Fornecedor | >>>,>>>,>>9 | 0 | Sim |  | C¢digo Fornecedor |
| cod_agenc_bcia | character | Agncia Banc ria | x(10) |  | Sim |  | C¢digo Agncia Banc ria |
| cod_banco | character | Banco | x(8) |  | Sim |  | C¢digo Banco |
| cod_cta_corren_bco | character | Conta Corrente Banco | x(20) |  | Sim |  | C¢digo Conta Corrente no Banco |
| cod_digito_agenc_bcia | character | D¡gito Ag Bcia | x(2) |  | Sim |  | C¢digo do D¡gito da Agncia Banc ria |
| cod_digito_cta_corren | character | D¡gito Cta Corrente | x(2) |  | Sim |  | D¡gito Verificador da Conta Corrente |
| cod_empresa | character | Empresa | x(3) |  | Sim |  | C¢digo Empresa |
| cod_livre_1 | character | Livre 1 | x(100) |  | Não |  | Atributo livre para uso interno |
| cod_livre_2 | character | Livre 2 | x(100) |  | Não |  | Atributo livre para uso interno |
| dat_livre_1 | date | Livre 1 | 99/99/9999 |  | Não |  | Atributo livre para uso interno |
| dat_livre_2 | date | Livre 2 | 99/99/9999 |  | Não |  | Atributo livre para uso interno |
| des_cta_corren | character | DescriÆo | x(30) |  | Não |  | DescriÆo da Conta Corrente |
| ind_tip_cta_pix | character | Tipo Conta PIX | x(30) |  | Não |  | Tipo Conta PIX |
| log_cta_corren_prefer | logical | Preferencial | Sim/NÆo | no | Sim |  | Conta Corrente Preferencial |
| log_livre_1 | logical | Livre 1 | Sim/NÆo | no | Não |  | Atributo livre para uso interno |
| log_livre_2 | logical | Livre 2 | Sim/NÆo | no | Não |  | Atributo livre para uso interno |
| num_livre_1 | integer | Livre 1 | >>>>>9 | 0 | Não |  | Atributo livre para uso interno |
| num_livre_2 | integer | Livre 2 | >>>>>9 | 0 | Não |  | Atributo livre para uso interno |
| val_livre_1 | decimal | Livre 1 | >>>,>>>,>>9.9999 | 0 | Não |  | Atributo livre para uso interno |
| val_livre_2 | decimal | Livre 2 | >>>,>>>,>>9.9999 | 0 | Não |  | Atributo livre para uso interno |

## Índices

- **ctcrrnfr_id** (Primário, Único): cod_empresa, cdn_fornecedor, cod_banco, cod_agenc_bcia, cod_digito_agenc_bcia, cod_cta_corren_bco, cod_digito_cta_corren
