# Esquema do Banco: dthresp

## Tabela: DE_PARA_BANCO
### Índices

---

## Tabela: DE_PARA_BENEFICIO
### Índices

---

## Tabela: DE_PARA_CARGO
### Índices

---

## Tabela: DE_PARA_CARGO_NIV
### Índices

---

## Tabela: DE_PARA_EMP_ESTAB
### Índices

---

## Tabela: DE_PARA_EVENTO
### Índices

---

## Tabela: DE_PARA_FISIC
### Índices

---

## Tabela: DE_PARA_GRAU
### Índices

---

## Tabela: DE_PARA_JURID
### Índices

---

## Tabela: DE_PARA_LOTACAO
### Índices

---

## Tabela: DE_PARA_MOTIVO
### Índices

---

## Tabela: DE_PARA_NIVEL
### Índices

---

## Tabela: DE_PARA_PLANO
### Índices

---

## Tabela: DE_PARA_SINDICATO
### Índices

---

## Tabela: DE_PARA_SITUACAO
### Índices

---

## Tabela: DE_PARA_TURNO
### Índices

---

## Tabela: ES_DEPEND_FUNC
### Índices

---

## Tabela: ES_FUNCIONARIO
**Label**: Tipo Trabalho
### Chave Primária
- CDN_EMPRESA, CDN_ESTAB, CDN_FUNCIONARIO

### Índices

---

## Tabela: ES_MOVTO_APRO
### Chave Primária
- CDN_ESTAB, CDN_EMPRESA, CDN_FUNCIONARIO, DT_TRANS, HR_INI, HR_FIM

### Índices

---

## Tabela: ES_PLANO_ODONTO
### Chave Primária
- CDN_EMPRESA

### Índices

---

## Tabela: ES_RH_PESSOA_FISIC
**Label**: Orienta��o Sexual
### Chave Primária
- NUM_PESSOA_FISIC

### Índices

---

## Tabela: FUNSEJEM
### Chave Primária
- CDN_EMPRESA, CDN_ESTAB, CDN_FUNCIONARIO

### Índices

---

## Tabela: INTEG_HCM_ORACLE
### Chave Primária
- EMPRESA, MATRICULA, TIPO_EVENTO

### Índices

---

## Tabela: LIM_SITUACAO
### Chave Primária
- CDN_EMPRESA, CND_ESTAB, CDN_FUNCIONARIO, CDN_SITUACAO, DT_MOVTO, HR_INI

### Índices

---

## Tabela: adiciona
**Label**: Livre
### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_ano_mes_adc, cdn_tip_adc

### Índices

---

## Tabela: compl_func
**Label**: Livre
### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario

### Índices

---

## Tabela: det_tabsal_cargo
**Label**: Mensal Enquadramento
**Descrição**: Codigo Nivel Cargo

### Chave Primária
- cdn_tabsal_cargo, num_niv_tabsal

### Índices
- **cargo**: cdn_tabsal_cargo, cdn_cargo_basic, cdn_niv_cargo

---

## Tabela: es-log-aprovacao
**Label**: Usu�rio
**Descrição**: Key secundario

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_proces_mpe, sequencia

### Índices
- **ch-aprov**: cdn_empresa_aprov, cdn_estab_aprov, cdn_funcionario, dat_proces_mpe
- **ch-aprovador**: cdn_empresa, cdn_estab, cdn_aprovado, dat_proces_mpe
- **ch-data**: cdn_empresa, cdn_estab, dat_proces_mpe, cdn_funcionario, cdn_aprovado
- **ch-tipo**: cdn_empresa, cdn_estab, cdn_aprovado, cdn_funcionario, tipo, cod_ocor

---

## Tabela: es_ext_clas_func
**Label**: Classe Funcion�rio
**Descrição**: Classe Funcion�rio

### Chave Primária
- cdn_clas_func

### Índices

---

## Tabela: es_genero
**Label**: Descri��o
### Índices

---

## Tabela: es_ident_genero
**Label**: Descri��o
### Índices

---

## Tabela: es_orientacao_sexual
**Label**: Descri��o
### Índices

---

## Tabela: es_tipo_atuacao
**Label**: Descri��o
### Índices

---

## Tabela: es_tipo_negocio
**Label**: Descri��o
### Índices

---

## Tabela: es_tipo_remuneracao
**Label**: Descri��o
### Índices

---

## Tabela: es_tipo_trabalho
**Label**: Descri��o
### Índices

---

## Tabela: ext_func_ptoelet
**Label**: Contr Sobreaviso?
**Descrição**: Contrato de Sobreaviso ?

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario

### Índices

---

## Tabela: ext_funcionario
**Label**: Ativo ?
**Descrição**: Permitir ao Funcion�rio fazer Horas Extras

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario

### Índices

---

## Tabela: ext_par_marcac_ptoelet
**Label**: In�cio C�lculo
**Descrição**: N�mero da matr�cula do funcion�rio

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_proces_mpe, num_horar_inic_proces_mpe

### Índices

---

## Tabela: ext_rh_estab
**Label**: Pontua��o
**Descrição**: C�digo N�mero Estabelecimento

### Chave Primária
- cdn_empresa, cdn_estab

### Índices

---

## Tabela: movto_ferias
**Label**: Valor Total
**Descrição**: Valor total do evento

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_ferias, cdn_tip_calc_ferias, cdn_event_fp

### Índices

---

## Tabela: movto_folha
**Label**: Sal�rio Hora
**Descrição**: Sal�rio hora

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_mes_refer_fp, num_ano_refer_fp, idi_tip_fp, qti_parc_habilit_calc_fp, cdn_event_fp

### Índices

---

## Tabela: movto_rescis
**Label**: Sal�rio Atual
**Descrição**: Valor do sal�rio atual

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_tip_calc_rescis, cdn_event_fp

### Índices

---

## Tabela: obs_discipl_fp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_obs_func

### Índices

---

## Tabela: tabsal_cargo
**Label**: Livre
### Chave Primária
- cdn_tabsal_cargo

### Índices

---

## Tabela: tip_adc
**Label**: Livre
### Chave Primária
- cdn_tip_adc

### Índices

---

## Tabela: unlotac_cargo
**Label**: Percentual Adic Pericul
**Descrição**: Percentual de periculosidade

### Chave Primária
- cdn_plano_lotac, cod_unid_lotac, cdn_cargo_basic, cdn_niv_cargo

### Índices

---

## Tabela: w_ccusto
**Label**: CCusto
**Descrição**: N�mero da matr�cula do funcion�rio

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_empresa_cc, cod_rh_ccusto

### Índices

---

## Tabela: w_feriado_local
**Label**: Tipo Dia
**Descrição**: Primary Key

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dt_sa

### Índices

---

## Tabela: w_justificativa
**Label**: Quantidade de Horas
**Descrição**: Quantidade de Horas

### Chave Primária
- cod_justificativa

### Índices

---

## Tabela: w_noticias
**Label**: T�tulo
**Descrição**: Tabela de Not�cias 

### Chave Primária
- cod_noticia

### Índices

---

## Tabela: w_param_data
**Label**: Data Limite. Resp
**Descrição**: Parametros Datas Web

### Índices

---

## Tabela: w_sobre_aviso
**Label**: Tipo Dia
**Descrição**: Tabela para verificar as datas de sobre-aviso dos funcionarios

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, periodo, dt_sa

### Índices

---

## Tabela: w_status_per
**Label**: Status Sobre-Aviso
**Descrição**: Tabela utilizada na Web para tratativa do status do per�odo.

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dt_ini_per, dt_fim_per

### Índices
- **id_st_func**: cdn_empresa, cdn_estab, cdn_funcionario, dt_ini_per, dt_fim_per, status_func
- **id_st_resp**: cdn_empresa, cdn_estab, cdn_funcionario, dt_ini_per, dt_fim_per, status_resp

---

