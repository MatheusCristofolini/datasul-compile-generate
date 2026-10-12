# Esquema do Banco: mgadt

## Tabela: atrib_alerta
**Label**: Seq
**Descrição**: Envia E-mail Celular

### Chave Primária
- cod_base_dados, cod_tabela, cod_atributo, cod_evento, num_seq

### Índices

---

## Tabela: atrib_monitor
**Label**: Livre 5
**Descrição**: Atributo Monitorado

### Chave Primária
- cod_base_dados, cod_tabela, cod_atributo

### Índices

---

## Tabela: atrib_vrf_monitor
**Label**: Tipo Dado
**Descrição**: Descri��o Atributo

### Chave Primária
- num_seq_evento, cod_atributo

### Índices

---

## Tabela: atrib_vrf_monitor_spool
**Label**: Tipo Dado
**Descrição**: Descri��o Atributo

### Chave Primária
- num_seq_evento, cod_atributo

### Índices

---

## Tabela: atributo_versao_raw
**Label**: Livre 2
**Descrição**: Nome Label

### Chave Primária
- cod-tabela, num-vers, cod-atributo

### Índices

---

## Tabela: base_dados
**Label**: Nome L�gico
**Descrição**: Conter� o nome logico do base de dados.

### Chave Primária
- cod_base_dados

### Índices

---

## Tabela: bco-histor-audtr
**Label**: Livre 2
**Descrição**: Servi�o

### Chave Primária
- cod-base-dados

### Índices

---

## Tabela: bh-period-audtr
**Label**: Livre 2
**Descrição**: Sequencia

### Chave Primária
- idi-seq-audtr

### Índices

---

## Tabela: param_audit
**Label**: Porta Servidor Mail
**Descrição**: Lista pilha de execu��o

### Chave Primária
- dat_ult_atualiz, hra_ult_atualiz

### Índices

---

## Tabela: param_audit_extens
**Label**: Livre 2
**Descrição**: L�gico Livre 2

### Chave Primária
- cdn_sequencia

### Índices
- **prmdtxtn_ix3** (Unique): cod_chave_param_ext

---

## Tabela: tab_vers_monit_extens
**Label**: Livre 2
**Descrição**: Valor Livre 2

### Chave Primária
- num_seq_evento

### Índices

---

## Tabela: tabela_monitor
**Label**: Write
**Descrição**: Monitora Tabela Completa

### Chave Primária
- cod_tabela, cod_base_dados

### Índices
- **tabmonit-banco** (Unique): cod_base_dados, cod_tabela

---

## Tabela: tabela_monitor_exc
**Label**: Seq
**Descrição**: Exce��o Tabela Monitorada

### Chave Primária
- cod_base_dados, cod_tabela, cod_evento, num_seq

### Índices

---

## Tabela: tabela_raw_ant
**Label**: Raw Antes
**Descrição**: Resultado Raw Anterior

### Chave Primária
- num_seq_evento

### Índices

---

## Tabela: tabela_raw_ant_spool
**Label**: Raw Antes
**Descrição**: Spool Raw Anterior

### Chave Primária
- num_seq_evento

### Índices

---

## Tabela: tabela_raw_new
**Label**: Raw Depois
**Descrição**: Resultado Raw Posterior

### Chave Primária
- num_seq_evento

### Índices

---

## Tabela: tabela_raw_new_spool
**Label**: Raw Depois
**Descrição**: Spool Raw Posterior

### Chave Primária
- num_seq_evento

### Índices

---

## Tabela: tabela_versao_raw
**Label**: Livre 2
**Descrição**: Tabela Versao Raw

### Chave Primária
- cod-tabela, num-vers

### Índices

---

## Tabela: tabela_vrf_monitor
**Label**: Transaction
**Descrição**: Index C��digo Empresa

### Chave Primária
- num_seq_evento

### Índices
- **log_proc**: log_processado
- **tabela_data**: cod_tabela, dat_atualiz
- **tab_vrf**: cod_base_dados, cod_tabela, cod_chave, cod_evento, dat_atualiz, hra_atualiz
- **tab_vrf_cod_empresa**: cod_empresa
- **tbrstdmn-04**: dat_atualiz, cod_base_dados, cod_tabela
- **user_data**: cod_usuario, dat_atualiz

---

## Tabela: tabela_vrf_monitor_spool
**Label**: Transaction
**Descrição**: Monitora Tabela Completa

### Chave Primária
- num_seq_evento

### Índices

---

