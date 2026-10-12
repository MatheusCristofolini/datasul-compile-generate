# Tabela: calend_comis

**Banco de Dados**: ems
**Label**: Calend rio Pagamento ComissÆo
**Descrição**: Calend rio Pagamento ComissÆo
**Gerado em**: 16/05/2026, 13:09:57

## Campos

| Campo | Tipo | Label | Formato | Inicial | Obrig. | Include | Help |
| :--- | :--- | :--- | :--- | :--- | :--- | :--- | :--- |
| cod_calend_comis | character | Calend rio ComissÆo | x(6) |  | Sim |  | C¢digo Calend rio ComissÆo |
| cod_empresa | character | Empresa | x(3) |  | Sim |  | C¢digo Empresa |
| cod_livre_1 | character | Livre 1 | x(100) |  | Não |  | Atributo livre para uso interno |
| cod_livre_2 | character | Livre 2 | x(100) |  | Não |  | Atributo livre para uso interno |
| dat_livre_1 | date | Livre 1 | 99/99/9999 |  | Não |  | Atributo livre para uso interno |
| dat_livre_2 | date | Livre 2 | 99/99/9999 |  | Não |  | Atributo livre para uso interno |
| des_calend_comis | character | DescriÆo Calend rio | x(40) |  | Sim |  | DescriÆo Calend rio ComissÆo |
| log_ajust_vencto | logical | Ajusta Venctos Menores que Emi | Sim/NÆo | no | Não |  | Ajusta Vencimentos Menores que EmissÆo ? |
| log_dia_fix | logical | Dia Fixo | Sim/NÆo | no | Sim |  | Dia Fixo |
| log_livre_1 | logical | Livre 1 | Sim/NÆo | no | Não |  | Atributo livre para uso interno |
| log_livre_2 | logical | Livre 2 | Sim/NÆo | no | Não |  | Atributo livre para uso interno |
| num_livre_1 | integer | Livre 1 | >>>>>9 | 0 | Não |  | Atributo livre para uso interno |
| num_livre_2 | integer | Livre 2 | >>>>>9 | 0 | Não |  | Atributo livre para uso interno |
| val_livre_1 | decimal | Livre 1 | >>>,>>>,>>9.9999 | 0 | Não |  | Atributo livre para uso interno |
| val_livre_2 | decimal | Livre 2 | >>>,>>>,>>9.9999 | 0 | Não |  | Atributo livre para uso interno |

## Índices

- **clndcms_id** (Primário, Único): cod_empresa, cod_calend_comis
