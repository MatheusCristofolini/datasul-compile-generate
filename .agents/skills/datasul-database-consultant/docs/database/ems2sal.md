# Esquema do Banco: ems2sal

## Tabela: AREA
### Chave Primária
- ARE_DESCRICAO

### Índices

---

## Tabela: ATIVIDADE
### Chave Primária
- ATI_DESCRICAO

### Índices

---

## Tabela: BKPROG
### Índices

---

## Tabela: BKPROGRAMA
### Índices

---

## Tabela: CAMPOS
### Índices

---

## Tabela: CLIENTES
### Índices

---

## Tabela: CLI_DIST_GEOG
### Índices

---

## Tabela: CLI_EMAIL
### Chave Primária
- COD_CLIENTE

### Índices

---

## Tabela: CLI_X_ESPEC
### Chave Primária
- COD_CLIENTE, ESP_COD

### Índices

---

## Tabela: COMPOSICAO_SA
### Chave Primária
- COM_COD

### Índices
- **IX_COMP_SA_2** (Unique): COM_NBATCH, COM_COD

---

## Tabela: COMP_MIX
### Chave Primária
- MIX_COD

### Índices

---

## Tabela: CONJUNTO
### Chave Primária
- COD_CONJ

### Índices

---

## Tabela: CONJ_X_EQUIP
### Chave Primária
- COD_CONJ, COD_EQUIP

### Índices

---

## Tabela: DAY-1
### Índices

---

## Tabela: DROP_ORPHAN_TABLES
### Índices

---

## Tabela: DROP_REGISTERED_TABLES
### Índices

---

## Tabela: DROP_SESSION_TABLES
### Índices

---

## Tabela: EQUIPAMENTO
### Chave Primária
- COD_EQUIP

### Índices

---

## Tabela: EQUIP_ITEM
### Chave Primária
- ITE_COD, COD_EQUIP

### Índices

---

## Tabela: EQUIP_X_TIPO
### Chave Primária
- EXT_EQU_COD, EXT_TIP_COD

### Índices

---

## Tabela: ESPECIFICACAO
### Chave Primária
- PON_COD, ITE_COD

### Índices
- **IX140_1** (Unique): ESP_COD

---

## Tabela: ESP_REC
### Chave Primária
- REC_COD, ITE_COD, SEQUENCIA

### Índices

---

## Tabela: ES_RASTREAMENTO
### Chave Primária
- ID_EMBARQUE

### Índices

---

## Tabela: ETAPAS
### Chave Primária
- ETA_COD, ARE_COD

### Índices

---

## Tabela: FORNECEDOR
### Índices

---

## Tabela: GET_LAST_SERIAL
### Índices

---

## Tabela: GET_REAL_NAME
### Índices

---

## Tabela: GRR_ITEM
### Chave Primária
- GRI_SEQUENCIA

### Índices

---

## Tabela: GRUPO_EQUIPAMENTO
### Índices

---

## Tabela: GRUPO_RESULT
### Índices

---

## Tabela: GRUPO_X_USUARIO
### Índices

---

## Tabela: IDIOMA
### Chave Primária
- IDI_DESCRICAO

### Índices

---

## Tabela: ITEM_EMBALAGEM
### Índices

---

## Tabela: ITENS
### Chave Primária
- ITE_COD

### Índices
- **IX_3411_2**: ITE_DESCRICAO

---

## Tabela: ITENS_ANALISE
### Chave Primária
- SA_COD, ESP_COD

### Índices
- **IX_IT_ANAL** (Unique): SA_COD, ITA_COD
- **IX_IT_ANAL_2** (Unique): ITA_COD
- **IX_IT_ANAL_3**: SA_COD, ITA_SITUACAO, ESP_COD

---

## Tabela: ITENS_INSPECAO
### Chave Primária
- ITI_COD

### Índices
- **IX_ITENS_INSP2**: MOD_COD

---

## Tabela: LOCAL
### Chave Primária
- LOC_DESCRICAO

### Índices

---

## Tabela: MATERIA_PRIMA
### Índices

---

## Tabela: MDY-1
### Índices

---

## Tabela: METODO
### Chave Primária
- MET_COD

### Índices

---

## Tabela: METODO_REF
### Chave Primária
- ITE_COD, COD_ITEM

### Índices

---

## Tabela: MODELO_INSPECAO
### Chave Primária
- MOD_COD

### Índices

---

## Tabela: MONTH-1
### Índices

---

## Tabela: NAVIO
### Chave Primária
- NAV_DESCRICAO

### Índices

---

## Tabela: NF_CARGA
### Índices

---

## Tabela: NF_ITEM
### Índices

---

## Tabela: NITRO_ETIQUETA
### Índices

---

## Tabela: OM
### Índices

---

## Tabela: OM_X_BATCH
### Chave Primária
- NR_EMBARQUE, NR_RESUMO, SA_COD

### Índices
- **IX_OM_X_BATCH2** (Unique): NR_EMBARQUE, NR_RESUMO, COM_NBATCH

---

## Tabela: ORDEM_MONTAG_ITEM
### Índices

---

## Tabela: ORDEM_SERVICO
### Índices

---

## Tabela: PARAMETROS
### Índices

---

## Tabela: PAR_EMS
### Chave Primária
- LOTE, IT_CODIGO

### Índices
- **IX_PAR_EMS1**: LIDO

---

## Tabela: PBCATCOL
### Chave Primária
- PBC_TNAM, PBC_OWNR, PBC_CNAM

### Índices

---

## Tabela: PBCATEDT
### Chave Primária
- PBE_NAME, PBE_SEQN

### Índices

---

## Tabela: PBCATFMT
### Chave Primária
- PBF_NAME

### Índices

---

## Tabela: PBCATTBL
### Chave Primária
- PBT_TNAM, PBT_OWNR

### Índices

---

## Tabela: PBCATVLD
### Chave Primária
- PBV_NAME

### Índices

---

## Tabela: PEDIDOS
### Índices

---

## Tabela: PONTO_AMOST
### Chave Primária
- PON_COD

### Índices

---

## Tabela: PON_CONJ
### Chave Primária
- PON_COD

### Índices

---

## Tabela: POW-1
### Índices

---

## Tabela: PROCESSO
### Índices

---

## Tabela: PROD_ALCOOL
### Chave Primária
- COD_PRODUTO

### Índices

---

## Tabela: PROD_ESPEC
### Chave Primária
- COD_ITEM, ITE_COD

### Índices

---

## Tabela: PROGRAMA
### Índices

---

## Tabela: RECLAS
### Índices

---

## Tabela: REGISTER_TABLE
### Índices

---

## Tabela: REL_RASTREIO
### Índices

---

## Tabela: RESPONSAVEL
### Chave Primária
- RES_NOME

### Índices

---

## Tabela: RETAMOCCH
### Chave Primária
- RET_NUM_BATCH, RET_DIG

### Índices

---

## Tabela: RNC
### Índices

---

## Tabela: SA
### Chave Primária
- SA_COD

### Índices
- **IX_SA_2**: SA_DAT_CADASTRO
- **IX_SA_3**: SA_DAT_FINAL
- **IX_SA_4**: SA_NUM_BATCH
- **IX_SA_5**: SA_SITUACAO, SA_COD
- **IX_SA_6**: SA_DAT_RECEBIMENTO

---

## Tabela: SA_X_EQUIP
### Chave Primária
- COD_SA, COD_EQUIP

### Índices

---

## Tabela: SET_LAST_SERIAL
### Índices

---

## Tabela: SISTEMAS
### Índices

---

## Tabela: SIS_X_TAB
### Índices

---

## Tabela: SUB_GRUPO_EQUIP
### Chave Primária
- SUB_DESCRICAO

### Índices

---

## Tabela: TABELAS
### Chave Primária
- TAB_SIGLA

### Índices

---

## Tabela: TAB_ABRANGE
### Índices

---

## Tabela: TAB_ABRANGE_LIB
### Índices

---

## Tabela: TAB_ABRANGE_OC
### Chave Primária
- NR_RESUMO, NR_EMBARQUE, NR_SEQUENCIA, IT_CODIGO, NR_LOTE

### Índices

---

## Tabela: TAREFAS_OS
### Índices

---

## Tabela: TEMPTABREG
### Chave Primária
- TTR_IDENT

### Índices

---

## Tabela: TEORES
### Chave Primária
- SA_COD

### Índices

---

## Tabela: TEOR_X_PROD
### Chave Primária
- COD_ITEM

### Índices

---

## Tabela: TEXTO_ITEM
### Índices

---

## Tabela: TEXTO_PROD
### Chave Primária
- IDI_COD, COD_ITEM

### Índices

---

## Tabela: TIPO_PROD
### Índices

---

## Tabela: TIPO_SERVICO
### Índices

---

## Tabela: TIPO_X_ATIVIDADE
### Chave Primária
- TXA_COD_TIP, TXA_COD_ATI

### Índices

---

## Tabela: UNREGISTER_SESSION_TABLES
### Índices

---

## Tabela: UNREGISTER_TABLE
### Índices

---

## Tabela: USUARIO
### Chave Primária
- LOGIN

### Índices

---

## Tabela: USUARIO_X_PROGRAMA
### Índices

---

## Tabela: WEEKDAY-1
### Índices

---

## Tabela: YEAR-1
### Índices

---

