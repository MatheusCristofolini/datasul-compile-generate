# Esquema do Banco: ems

## Tabela: abat_antecip_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab_refer, cod_refer, num_seq_refer, cod_estab, cod_espec_docto, cod_ser_docto, cod_tit_acr, cod_parcela

### Índices
- **abtntcpc_tit_acr**: cod_estab, cod_espec_docto, cod_ser_docto, cod_tit_acr, cod_parcela

---

## Tabela: abat_antecip_vouch
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab_refer, cod_refer, cod_portador, num_bord_ap, num_seq_refer, cod_estab, cod_espec_docto, cod_ser_docto, cdn_fornecedor, cod_tit_ap, cod_parcela

### Índices
- **abtntcpb_tit_ap**: cod_estab, cod_espec_docto, cod_ser_docto, cdn_fornecedor, cod_tit_ap, cod_parcela

---

## Tabela: abat_prev_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab_refer, cod_refer, num_seq_refer, cod_estab, cod_ser_docto, cod_espec_docto, cod_tit_acr, cod_parcela

### Índices
- **abtprvcr_titacr**: cod_estab, cod_espec_docto, cod_ser_docto, cod_tit_acr, cod_parcela

---

## Tabela: abat_prev_provis_ap
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab_refer, cod_refer, cod_portador, num_bord_ap, num_seq_refer, cod_estab, cod_espec_docto, cod_ser_docto, cdn_fornecedor, cod_tit_ap, cod_parcela

### Índices
- **abtprvpa_bordero**: cod_estab_refer, cod_portador, num_bord_ap, num_seq_refer, cod_estab, cod_espec_docto, cod_ser_docto, cdn_fornecedor, cod_tit_ap, cod_parcela
- **abtprvpa_referencia**: cod_estab_refer, cod_refer, num_seq_refer, cod_estab, cod_espec_docto, cod_ser_docto, cdn_fornecedor, cod_tit_ap, cod_parcela
- **abtprvpa_tit_ap**: cod_estab, cod_espec_docto, cod_ser_docto, cdn_fornecedor, cod_tit_ap, cod_parcela

---

## Tabela: acaocap
**Label**: Mercado
**Descrição**: Valor Mercado A��o

### Chave Primária
- cod_empresa, cdd_acionista, cdd_acaocap_inicial, log_conflito_renum_acaocap

### Índices
- **acaocap_acaocap_saldo_acion**: cod_empresa, cdd_acionista, cod_clas_acaocap
- **acaocap_acionista**: cdd_acionista
- **acaocap_cdd_movto_acionista**: cdd_movto_acaocap, cdd_acionista
- **acaocap_clsccp**: cod_clas_acaocap
- **acaocap_corretor**: cdd_corretor
- **acaocap_emp_dat_ato**: cod_empresa, dat_atoadm_shc, ind_movto_acaocap
- **acaocap_orgccp**: cod_orig_acaocap
- **acaocap_qtd_acaocap**: qtd_acaocap
- **acaocap_reg**: cod_empresa, num_livro_reg_acaocap, num_folha_reg_acaocap, num_lin_reg_acaocap
- **acaocap_residuo**: cod_empresa, cod_clas_acaocap, cdd_acionista
- **acaocap_transf**: cod_empresa, num_livro_transf_acaocap, num_folha_transf_acaocap

---

## Tabela: acerto_cta_eec
**Label**: Total Acerto Conta
**Descrição**: Valor Total Acerto Conta Viagem

### Chave Primária
- num_id_proces_prestac_cta, cod_parcela

### Índices
- **acrtctc_token** (Unique): num_id_acerto_cta

---

## Tabela: acion_contrat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdd_acionista, cod_imagem

### Índices
- **acncntrt_imagem**: cod_imagem

---

## Tabela: acionista
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdd_acionista

### Índices
- **acnst_cpftitlar**: cod_id_feder, log_titlar
- **acnst_nom_pessoa**: nom_pessoa
- **acnst_orgpblc**: cod_orgao_public

---

## Tabela: acompto_sit_proces_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_proces_edi, cdn_seq_control_edi

### Índices
- **acmptstp_etpprcsd**: cdn_etap_proces_edi
- **acmptstp_sttpprcs**: cdn_sit_etap_proces_edi

---

## Tabela: acum_impto_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_estab, cdn_cliente, dat_refer

### Índices
- **acmmptcr_data**: dat_refer
- **acmmptcr_emp_cli**: cod_empresa, cdn_cliente
- **acmmptcr_estab**: cod_estab

---

## Tabela: acum_impto_pagto
**Label**: Rendto Tribut�vel
**Descrição**: Valor Rendimento Tribut�vel

### Chave Primária
- cod_empresa, cod_estab, cdn_fornecedor, dat_refer, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto

### Índices

---

## Tabela: acum_pagto_pessoa
**Label**: Rendto Tribut�vel
**Descrição**: Valor Rendimento Tribut�vel

### Chave Primária
- cod_estab, num_pessoa, dat_refer, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto

### Índices
- **acmpgtpd_dat_refer**: num_pessoa, dat_refer
- **acmpgtps_imposto**: cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto
- **acmpgtps_num_pessoa**: num_pessoa

---

## Tabela: acum_pagto_pessoa_depend
**Label**: Dedu��o Dependente
**Descrição**: acmpgtpb_id

### Chave Primária
- cod_estab, num_pessoa, dat_refer, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto, cod_id_feder

### Índices

---

## Tabela: acum_pagto_pessoa_pensao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_pessoa, dat_refer, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto, nom_pensao

### Índices

---

## Tabela: acum_pagto_usuar_cx
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuar, ind_tip_acum, num_dia_refer, num_mes_refer, num_ano_refer

### Índices

---

## Tabela: acum_trans_1099
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_estab, cdn_fornecedor, ind_tip_trans_1099, num_exerc_trans_1099

### Índices
- **acmtrns1_exec**: cod_empresa, num_exerc_trans_1099
- **acmtrns1_tip**: ind_tip_trans_1099

---

## Tabela: acumul_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_acumul_ctbl

### Índices
- **cmlctbla_tit_ctbl**: des_tit_ctbl

---

## Tabela: acumul_demonst_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_demonst_ctbl, num_seq_demonst_ctbl, cod_acumul_ctbl

### Índices
- **cmldmnsc_acumul_ctbl**: cod_acumul_ctbl

---

## Tabela: adiant_emprest_produt
**Label**: Taxa Juros
**Descrição**: Valor Taxa Juros

### Chave Primária
- num_id_adiant_emprest

### Índices
- **adntmprs_data**: cod_estab, dat_adiant_emprest
- **adntmprs_prop**: cod_empresa, cdn_fornecedor, cod_prop_rural
- **adntmprs_refer** (Unique): cod_estab, cod_refer
- **adntmprs_tit** (Unique): cod_estab, cdn_fornecedor, cod_espec_docto, cod_ser_docto, cod_tit_ap, cod_parcela

---

## Tabela: adiant_prestac_cta_eec
**Label**: Total Adiantamento
**Descrição**: Valor Total Adiantamento Viagem

### Chave Primária
- num_id_proces_prestac_cta, cod_parcela

### Índices
- **adntprst_estab**: cod_estab, cod_refer
- **adntprst_token** (Unique): num_id_adiant_eec

---

## Tabela: admdra_cartao_cr
**Label**: Perc Remunera��o
**Descrição**: Valor Percentual Remunera��o do Portador

### Chave Primária
- cod_admdra_cartao_cr, cod_band

### Índices
- **admdrcrt_pssjrda**: num_pessoa_jurid

---

## Tabela: admdra_operdra_cartao_cr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_operdra_cartao_cr, cod_admdra_cartao_cr, cod_band

### Índices
- **admdrprd_opab**: cod_operdra_cartao_cr, cod_admdra_operdra, cod_band_operdra

---

## Tabela: adoc_inicial
**Label**: Valor saldo  ado��o inicial
**Descrição**: Valor saldo  ado��o inicial

### Chave Primária
- cod_empresa, cod_cta_pat, num_bem_pat, num_seq_bem_pat, num_seq_incorp_bem_pat, cod_exerc_ctbl, num_period_ctbl, cod_cenar_ctbl, cod_finalid_econ, ind_movto_adoc_inicial, num_seq_movto_bem_pat

### Índices
- **adcncl_aprop_cr**: num_id_aprop_lancto_cr
- **adcncl_aprop_db**: num_id_aprop_lancto_db
- **adcncl_ix2**: cod_exerc_ctbl, num_period_ctbl, cod_cenar_ctbl, cod_finalid_econ, cod_empresa, cod_cta_pat, num_bem_pat, num_seq_bem_pat
- **adcncl_ix3**: cod_exerc_ctbl, num_period_ctbl, cod_empresa, cod_cenar_ctbl, cod_finalid_econ, ind_movto_adoc_inicial
- **adcncl_ix4**: cod_empresa, cod_cta_pat, num_bem_pat, num_seq_bem_pat, num_seq_incorp_bem_pat, cod_cenar_ctbl, cod_finalid_econ, ind_movto_adoc_inicial

---

## Tabela: agenc_bcia
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_banco, cod_agenc_bcia

### Índices
- **agncbnc_id_feder_jurid**: cod_id_feder
- **agncbnc_pais**: cod_pais
- **agncbnc_pessoa_juridica**: num_pessoa_jurid

---

## Tabela: agenda_ausen_eec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cdn_func_financ, num_seq_ausen_func

### Índices
- **agndsnc_prcsprst**: cod_estab, cdn_func_financ, dat_inic_ausen_eec, dat_fim_ausen_eec

---

## Tabela: agenda_inadimp
**Label**: Val Agenda Realizado
**Descrição**: Valor Total Agenda Realizado

### Chave Primária
- cod_usuario, dat_agenda

### Índices

---

## Tabela: aloc_bem
**Label**: Perc Apropria��o
**Descrição**: Valor Percentual de Apropria��o

### Chave Primária
- num_id_bem_pat, cod_empresa, cod_plano_ccusto, cod_ccusto, cod_unid_negoc, dat_inic_valid, dat_fim_valid

### Índices
- **alocbem_ccusto_unid_negoc**: cod_empresa, cod_plano_ccusto, cod_ccusto, cod_unid_negoc
- **alocbem_ndngc**: cod_unid_negoc

---

## Tabela: analis_period_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cenar_ctbl, cod_exerc_ctbl, num_period_ctbl, cod_analis_period_ctbl

### Índices
- **anlsprdc_usuario**: cod_usuario

---

## Tabela: anexo_msg_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_id_msg, num_seq

### Índices
- **anxmsgd_ind_tip_msg**: ind_tip_msg

---

## Tabela: antecip_movto_event
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_movto_event, cod_estab_antecip, num_id_tit_ap_antecip

### Índices
- **antcpmvt_fechto**: num_id_fechto_event_financ
- **antcpmvt_prop**: cod_empresa, cdn_fornecedor, cod_prop_rural, num_id_fechto_event_financ

---

## Tabela: antecip_pef_pend
**Label**: Valor T�tulo
**Descrição**: Valor T�tulo Contas a Pagar

### Chave Primária
- cod_estab, cod_refer

### Índices
- **antcppfp_pessoa_tit**: num_pessoa, cod_espec_docto, cod_ser_docto, cod_tit_ap, cod_parcela
- **antcppfp_portad_finalid_econ**: cod_estab, cod_portador, cod_cart_bcia, cod_finalid_econ
- **antcppfp_safra**: cdn_fornecedor
- **antcppfp_tip_refer**: cod_empresa, ind_tip_refer, cod_estab, cod_refer

---

## Tabela: antecip_planilha_vendor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab_refer, num_id_antecip_planilha

### Índices
- **antcppln_planilha_vdr**: cod_estab_planilha_antecip, num_planilha_vendor_antecip
- **antcppln_refer**: cod_estab_refer, cod_refer, num_seq_refer
- **antcppln_tit_acr**: cod_estab_tit_acr, num_id_tit_acr, num_id_antecip_planilha
- **antcppln_ult_correc**: cod_estab_tit_acr, dat_ult_correc_antecip

---

## Tabela: apol_seguro
**Label**: Pr�mio Seguro
**Descrição**: Valor  Pr�mio  Efeitos  Seguro

### Chave Primária
- cod_seguradora, cod_apol_seguro

### Índices
- **aplsgr_indic_econ**: cod_indic_econ
- **aplsgr_tip_calc**: cod_tip_calc

---

## Tabela: apol_seguro_bem_pat
**Label**: Valor Segurado
**Descrição**: Valor Segurado  Bem Patrimonial

### Chave Primária
- cod_seguradora, cod_apol_seguro, num_id_bem_pat, dat_inic_valid

### Índices
- **aplsgrba_bem_pat**: num_id_bem_pat

---

## Tabela: aprop_apol_seguro
**Label**: Valor Pagamento
**Descrição**: Valor Pagamento

### Chave Primária
- cod_seguradora, cod_apol_seguro, cod_cenar_ctbl, dat_pagto, log_amort, dat_ctbz, hra_ctbz

### Índices
- **aprpplsg_mvtttp**: cod_estab, num_id_movto_tit_ap

---

## Tabela: aprop_contrat_leas
**Label**: Valor Pagamento
**Descrição**: Valor Pagamento

### Chave Primária
- cod_arrendador, cod_contrat_leas, num_seq_incorp_bem_pat, cod_cenar_ctbl, dat_pagto, log_amort, dat_ctbz, hra_ctbz

### Índices
- **aprpcntr_mvtttp**: cod_estab, num_id_movto_tit_ap

---

## Tabela: aprop_ctbl_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_id_movto_tit_acr, cod_estab_aprop_ctbl, cod_plano_cta_ctbl, cod_cta_ctbl, cod_unid_negoc, cod_plano_ccusto, cod_ccusto, ind_natur_lancto_ctbl, num_id_aprop_ctbl_acr

### Índices
- **aprpctbd_estab_cta_ctbl_data**: cod_estab, cod_plano_cta_ctbl, cod_cta_ctbl, dat_transacao, log_aprop_ctbl_ctbzda
- **aprpctbd_token** (Unique): cod_estab, num_id_aprop_ctbl_acr

---

## Tabela: aprop_ctbl_acr_avp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_aprop_ctbl_acr_avp

### Índices
- **aprpctbp_ctbl**: num_id_aprop_lancto_ctbl
- **aprpctbp_dat**: cod_empresa, dat_transacao
- **aprpctbp_emp**: cod_empresa, log_aprop_ctbl_ctbzda, dat_transacao
- **aprpctbp_movto**: num_id_movto_tit_acr_avp

---

## Tabela: aprop_ctbl_ap
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_id_aprop_ctbl_ap

### Índices
- **aprpctbl_aprop**: cod_estab, num_id_movto_tit_ap, cod_estab_aprop_ctbl, cod_plano_cta_ctbl, cod_cta_ctbl, cod_unid_negoc, cod_plano_ccusto, cod_ccusto, ind_natur_lancto_ctbl
- **aprpctbl_estab_cta_ctbl_data**: cod_estab, cod_plano_cta_ctbl, cod_cta_ctbl, dat_transacao

---

## Tabela: aprop_ctbl_ap_avp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_aprop_ctbl_ap_avp

### Índices
- **aprpctbq_ctbl**: num_id_aprop_lancto_ctbl
- **aprpctbq_dat**: cod_empresa, dat_transacao
- **aprpctbq_emp**: cod_empresa, log_aprop_ctbl_ctbzda, dat_transacao
- **aprpctbq_movto**: num_id_movto_tit_ap_avp

---

## Tabela: aprop_ctbl_apl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_movto_operac_financ, num_seq_aprop_ctbl_apl

### Índices
- **aprpctbe_demo_ctbl**: cod_empresa, dat_transacao, cod_plano_cta_ctbl, cod_cta_ctbl

---

## Tabela: aprop_ctbl_cmg
**Label**: Valor Movimento
**Descrição**: Valor do Movimento de Conta Corrente

### Chave Primária
- num_id_movto_cta_corren, num_seq_aprop_ctbl_cmg

### Índices
- **aprpctbk_ctbz_cta**: cod_estab, cod_plano_cta_ctbl, cod_cta_ctbl, dat_transacao, log_ctbz_movto_cta_corren
- **aprpctbk_ctbz_data**: cod_estab, dat_transacao, cod_plano_cta_ctbl, cod_cta_ctbl, log_ctbz_movto_cta_corren

---

## Tabela: aprop_ctbl_cta_pat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_cta_pat, cod_plano_cta_ctbl, cod_cta_ctbl_db, cod_cta_ctbl_cr, cod_plano_ccusto, cod_ccusto_db, cod_ccusto_cr, cod_unid_negoc_db, cod_unid_negoc_cr, dat_aprop_ctbl_cta_pat

### Índices
- **aprpctbn_aprplntctb_cr**: num_id_aprop_lancto_ctbl_cr
- **aprpctbn_aprplntctb_db**: num_id_aprop_lancto_ctbl_db
- **aprpctbn_token** (Unique): num_id_aprop_ctbl_cta_pat

---

## Tabela: aprop_ctbl_dat_inconsist
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_modul_dtsul, cod_estab, num_id_aprop_ctbl, num_id_movto, num_seq_aprop_ctbl

### Índices
- **aprpctbr_emp**: cod_empresa, cod_estab, dat_transacao

---

## Tabela: aprop_ctbl_mutuo_ap
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_refer, num_seq_refer, cod_plano_cta_ctbl, cod_cta_ctbl, cod_unid_negoc, cod_plano_ccusto, cod_ccusto, cod_tip_fluxo_financ

### Índices
- **aprpctbm_data**: cod_estab, dat_transacao, cod_plano_cta_ctbl, cod_cta_ctbl

---

## Tabela: aprop_ctbl_pat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq_reg_calc_bem_pat, cod_plano_cta_ctbl_db, cod_cta_ctbl_db, cod_plano_ccusto_db, cod_ccusto_db, cod_unid_negoc_db, cod_plano_cta_ctbl_cr, cod_cta_ctbl_cr, cod_plano_ccusto_cr, cod_ccusto_cr, cod_unid_negoc_cr

### Índices
- **aprpctbb_aprplnca_cr**: num_id_aprop_lancto_ctbl_cr
- **aprpctbb_aprplnca_db**: num_id_aprop_lancto_ctbl_db

---

## Tabela: aprop_ctbl_pend_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_refer, num_seq_refer, cod_estab_aprop_ctbl, cod_plano_cta_ctbl, cod_cta_ctbl, cod_unid_negoc, cod_ccusto, cod_plano_ccusto, cod_tip_fluxo_financ, num_seq_aprop_ctbl_pend_acr

### Índices
- **aprpctbc_tit**: cod_estab_tit_acr, num_id_tit_acr, num_seq_aprop_ctbl_pend_acr

---

## Tabela: aprop_ctbl_pend_ap
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_refer, num_seq_refer, cod_estab_aprop_ctbl, cod_plano_cta_ctbl, cod_cta_ctbl, cod_unid_negoc, cod_plano_ccusto, cod_ccusto, cod_tip_fluxo_financ

### Índices
- **aprpctba_unid_negoc**: cod_estab, cod_refer, num_seq_refer, cod_unid_negoc

---

## Tabela: aprop_ctbl_planilha_vdr
**Label**: Perc Rateio
**Descrição**: Percentual Rateado

### Chave Primária
- cod_estab, num_planilha_vendor, cod_plano_cta_ctbl, cod_cta_ctbl, cod_unid_negoc, cod_plano_ccusto, cod_ccusto

### Índices

---

## Tabela: aprop_ctbl_shc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_ctbz_acaocap, num_seq_aprop_ctbl_shc

### Índices
- **aprpctbh_empresa**: cod_empresa

---

## Tabela: aprop_despes_recta_acr
**Label**: Perc Rateio
**Descrição**: Percentual Rateio Contabiliza��o

### Chave Primária
- cod_estab, num_id_tit_acr, cod_plano_cta_ctbl, cod_cta_ctbl, cod_unid_negoc, cod_tip_fluxo_financ, num_id_aprop_despes_recta

### Índices
- **aprpdspa_movto**: cod_estab, num_id_movto_tit_acr
- **aprpdspa_token** (Unique): cod_estab, num_id_aprop_despes_recta

---

## Tabela: aprop_despes_recta_pend
**Label**: Perc Rateio
**Descrição**: Percentual Rateio Contabiliza��o

### Chave Primária
- cod_estab, cod_refer, num_seq_refer, num_id_tit_acr, cod_plano_cta_ctbl, cod_cta_ctbl, cod_unid_negoc, cod_tip_fluxo_financ, num_seq_aprop_ctbl_pend_acr, ind_tip_aprop_recta_despes

### Índices

---

## Tabela: aprop_lancto_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_lote_ctbl, num_lancto_ctbl, num_seq_lancto_ctbl, cod_finalid_econ

### Índices
- **aprplnca_finalid_econ**: cod_finalid_econ
- **aprplnca_token** (Unique): num_id_aprop_lancto_ctbl

---

## Tabela: aprop_liquidac_antecip
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab_refer, cod_refer, num_seq_refer, cod_estab, cod_espec_docto, cod_ser_docto, cod_tit_acr, cod_parcela, num_seq_aprop_liquidac

### Índices

---

## Tabela: aprop_parc_pis_cofins
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_calc_parc, cod_cenar_ctbl, cod_finalid_econ, ind_finalid_ctbl

### Índices
- **aprpprcd_db**: num_id_aprop_lancto_db
- **aprpprcp_cr**: num_id_aprop_lancto_cr

---

## Tabela: aprop_relacto_pend_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_refer, num_seq_refer, cod_estab_tit_acr_pai, num_id_tit_acr_pai, cod_plano_cta_ctbl, cod_cta_ctbl

### Índices

---

## Tabela: aprop_relacto_pend_acr_2
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_refer, num_seq_refer, cod_estab_tit_acr_pai, num_id_tit_acr_pai, num_seq_aprop_relacto_pend

### Índices

---

## Tabela: aprop_relacto_pend_ap
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_refer, num_seq_refer, cod_estab_tit_ap_pai, num_id_tit_ap_pai, cod_plano_cta_ctbl, cod_cta_ctbl, cod_ccusto, cod_plano_ccusto, cod_tip_fluxo_financ, cod_unid_negoc

### Índices

---

## Tabela: aprop_variac_cambial_fas
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_variac_cambial, ind_finalid_ctbl

### Índices
- **aprpvrcc_cr**: num_id_aprop_lancto_cr
- **aprpvrcc_db**: num_id_aprop_lancto_db

---

## Tabela: aprov_invent_patrim
**Label**: Unidade de Neg�cio
**Descrição**: C�digo Estabelecimento

### Chave Primária
- cod_empresa, cod_estab, cod_unid_negoc, cod_plano_ccusto, cod_ccusto, cod_aprvdor

### Índices

---

## Tabela: aprvdor_substto_eec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_estab, cod_plano_aprovac_eec, cod_unid_aprovac, num_seq_substto_eec

### Índices
- **aprvdrsb_funceec**: cod_empresa, cod_estab_func_financ, cdn_func_financ

---

## Tabela: area_risco
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_area_risco

### Índices
- **rrsc_apol_segur**: cod_seguradora, cod_apol_seguro
- **rrsc_imagem**: cod_imagem
- **rrsc_localiz**: cod_estab, cod_localiz

---

## Tabela: arq_regra_extrat_bcio
**Label**: Tamanho
**Descrição**: Tamanho do Arquivo

### Chave Primária
- cod_usuario, num_id_regra_extrat, num_seq_arq_regra

### Índices

---

## Tabela: arq_tit_em_bco
**Label**: Percentual
**Descrição**: Percentual de Varia��o do Valor do Titulo APB

### Chave Primária
- dat_refer_arq_tit_em_bco, cod_sist_nac_bcio, cod_agenc_bcia, cod_vers_arq_tit_em_bco

### Índices

---

## Tabela: arrendador
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_arrendador

### Índices
- **rrnddra_pais**: cod_pais
- **rrnddra_pessoa_jurid** (Unique): num_pessoa_jurid

---

## Tabela: arrendatario
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_arrendatario

### Índices
- **rrndtra_pais**: cod_pais
- **rrndtra_pessoa_jurid**: num_pessoa_jurid

---

## Tabela: ativid_pessoa_fisic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_ativid_pessoa_fisic

### Índices

---

## Tabela: ativid_pessoa_jurid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_ativid_pessoa_jurid

### Índices

---

## Tabela: atoadm_acion
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, dat_atoadm_shc, cod_clas_acaocap, cdd_acionista, cdd_cautela, cdd_acaocap_inicial

### Índices
- **atdmcn_acnst**: cdd_acionista
- **atdmcn_clsccp**: cod_clas_acaocap
- **atdmcn_empresa**: cod_empresa, cod_empres_incorpda_shc
- **atdmcn_incorpda**: cod_empresa, dat_atoadm_shc, cod_empres_incorpda_shc, cod_clas_acaocap

---

## Tabela: atoadm_clas_acaocap
**Label**: Ult Valor Patrimon
**Descrição**: �ltimo Valor Patrimonial A��o

### Chave Primária
- cod_empresa, dat_atoadm_shc, cod_clas_acaocap

### Índices
- **atdmclsc_clsccp**: cod_clas_acaocap

---

## Tabela: atoadm_shc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, dat_atoadm_shc

### Índices
- **atdmshc_docto**: cod_docto_anexo
- **atdmshc_img**: cod_imagem

---

## Tabela: autoriz_solicit_viagem
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, num_id_ped_reserve, cdn_autoriz

### Índices

---

## Tabela: banco
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_banco

### Índices
- **banco_lytblt**: cod_layout_boleto
- **banco_lytxtrt**: cod_layout_extrat
- **banco_tpclcmpt**: cod_tip_calc_impto_cmg

---

## Tabela: bco_histor_period
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_modul_dtsul

### Índices

---

## Tabela: bco_tip_cheq
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_banco, cod_tip_cheq

### Índices
- **bctpchq_layout**: cod_layout_cheq
- **bctpchq_tip_cheq**: cod_tip_cheq

---

## Tabela: bco_trans_online
**Label**: Livre 2
**Descrição**: C�digo Estabelecimento

### Chave Primária
- cod_banco, cod_empresa, cod_estab, ind_trans_online

### Índices
- **bctrnsnl_conex**: cod_conex_online

---

## Tabela: bem_docto_faturam
**Label**: Percentual Movimento
**Descrição**: Valor Percentual Movimento Bem Patrimonial

### Chave Primária
- num_id_bem_pat, num_seq_incorp_bem_pat, num_seq_movto_bem_pat, cod_estab_nf, cod_ser_nf, cod_nota_fisc, num_seq_item, cod_item_nf

### Índices
- **bmdctftr_nota**: cod_estab_nf, cod_ser_nf, cod_nota_fisc, num_seq_item, cod_item_nf

---

## Tabela: bem_pat
**Label**: Perc Baixado
**Descrição**: Valor Percentual Baixado

### Chave Primária
- cod_empresa, cod_cta_pat, num_bem_pat, num_seq_bem_pat

### Índices
- **bempat_bem**: num_bem_pat, num_seq_bem_pat
- **bempat_ccusto**: cod_empresa, cod_plano_ccusto, cod_ccusto_respons
- **bempat_dat_aquis**: cod_empresa, cod_cta_pat, cod_estab, dat_aquis_bem_pat
- **bempat_emp**: cod_empresa, num_bem_pat, num_seq_bem_pat
- **bempat_estab**: cod_estab, num_bem_pat, num_seq_bem_pat
- **bempat_fornecedor**: cod_empresa, cdn_fornecedor
- **bempat_grp_calc**: cod_grp_calc
- **bempat_ident_visu**: cod_empresa, cb3_ident_visual
- **bempat_leasing**: cod_arrendador, cod_contrat_leas
- **bempat_localiz**: cod_estab, cod_localiz
- **bempat_marca**: cod_marca
- **bempat_modelo**: cod_espec_bem, cod_marca, cod_modelo
- **bempat_orig_bem**: cod_empresa, ind_orig_bem, cod_cta_pat, num_bem_pat, num_seq_bem_pat
- **bempat_seq** (Unique): num_id_bem_pat
- **bempat_tmdctntr**: cod_estab, cod_empresa, cdn_fornecedor, cod_docto_entr, cod_ser_nota, num_item_docto_entr, cod_natur_operac
- **bempat_usuario**: cod_usuario

---

## Tabela: bem_pat_event_trib_dfe
**Label**: Sequ�ncia Item XML
**Descrição**: N�mero Sequ�ncia Item XML

### Chave Primária
- num_id_bem_pat, num_seq_incorp_bem_pat, cod_estab, cod_empresa, cdn_fornecedor, cod_docto_entr, cod_ser_nota, cod_natur_operac, num_item_docto_entr, cod_chave_aces_docto_fisc, cod_evento, num_seq_event, num_seq_item_xml

### Índices
- **bmptvntt_bmpt**: num_id_bem_pat, num_seq_incorp_bem_pat
- **bmptvntt_data**: dat_gerac_event
- **bmptvntt_evento**: cod_evento, cod_chave_aces_docto_fisc, num_seq_event, num_seq_item_xml
- **bmptvntt_fornecedor**: cod_empresa, cdn_fornecedor, dat_gerac_event
- **bmptvntt_tmdctntr**: cod_estab, cod_empresa, cdn_fornecedor, cod_docto_entr, cod_ser_nota, cod_natur_operac, num_item_docto_entr

---

## Tabela: bem_pat_ext
**Label**: Ufir Reavalia��o Bem
**Descrição**: Valor Ufir Reavalia��o Bem Patrimonial

### Chave Primária
- cod_empresa, cod_cta_pat, num_bem_pat, num_seq_bem_pat

### Índices
- **bmptxt_apol_seguro**: cod_seguradora, cod_apol_seguro
- **bmptxt_area_risco**: cod_estab, cod_area_risco
- **bmptxt_ccusto**: cod_empresa, cod_plano_ccusto, cod_ccusto_respons
- **bmptxt_contrat_leas**: cod_arrendador, cod_contrat_leas
- **bmptxt_cta_ctbl**: cod_plano_cta_ctbl, cod_cta_ctbl
- **bmptxt_especif_tec**: cod_espec_bem, cod_marca, cod_modelo, cod_especif_tec
- **bmptxt_estado_fisic**: cod_estado_fisic_bem_pat
- **bmptxt_ext**: cdn_empresa, num_bem_pat, num_seq_bem_pat
- **bmptxt_fornecedor**: cod_empresa, cdn_fornecedor
- **bmptxt_grp_calc**: cod_grp_calc
- **bmptxt_incent_fisc**: cod_incent_fisc
- **bmptxt_licenc_uso**: cod_espec_bem, cod_marca, cod_modelo, cod_licenc_uso
- **bmptxt_localizacao**: cod_estab, cod_localiz
- **bmptxt_marca**: cod_marca
- **bmptxt_seq** (Unique): num_id_bem_pat
- **bmptxt_unid_negoc**: cod_unid_negoc
- **bmptxt_usuar_financ**: cod_usuario

---

## Tabela: bem_pat_gartia
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_cta_pat, num_bem_pat, num_seq_bem_pat, num_seq_bem_pat_gartia

### Índices
- **bmptgrt_pj**: num_pessoa_jurid_gartia

---

## Tabela: bem_pat_img
**Label**: Sequencia
**Descrição**: Sequencia

### Chave Primária
- num_id_bem_pat, num_seq_img

### Índices

---

## Tabela: bem_pat_item_docto_entr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_bem_pat, num_seq_incorp_bem_pat, cod_estab, cod_empresa, cdn_fornecedor, cod_docto_entr, cod_ser_nota, num_item_docto_entr, cod_natur_operac

### Índices
- **bmpttmdc_chave_aces**: cod_chave_aces_docto_fisc, num_seq_item_xml
- **bmpttmdc_doc**: cod_estab, cod_empresa, cdn_fornecedor, cod_docto_entr, cod_ser_nota, num_item_docto_entr, cod_natur_operac
- **bmpttmdc_fornecedor**: cod_empresa, cdn_fornecedor, ind_gera_event_imob_item
- **bmpttmdc_gera_evento**: ind_gera_event_imob_item, cod_empresa, cdn_fornecedor

---

## Tabela: bloq_acaocap
**Label**: Percentual Bloqueio
**Descrição**: Valor Percentual Bloqueio A��o Capital

### Chave Primária
- cod_empresa, cdd_acionista, cdd_acaocap_inicial, log_conflito_renum_acaocap, cod_motiv_sit_acaocap

### Índices
- **blqccp_mtvstccp**: cod_motiv_sit_acaocap

---

## Tabela: bolet_protec_cartao_cr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_admdra_cartao_cr, cod_cartcred

### Índices

---

## Tabela: bord_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab_bord, num_bord_acr

### Índices
- **bordacr_msgfnnc**: cod_empresa, cod_msg_inic
- **bordacr_msg_fim**: cod_empresa, cod_msg_fim
- **bordacr_portador**: cod_estab_bord, cod_portador, cod_cart_bcia, cod_finalid_econ
- **bordacr_srfnnca**: cod_usuario

---

## Tabela: bord_ap
**Label**: Total Informado
**Descrição**: Total Pagamento J� Informado

### Chave Primária
- cod_estab_bord, cod_portador, num_bord_ap

### Índices
- **brdrp_empres_apb**: cod_empresa
- **brdrp_estab_sit**: cod_estab_bord, ind_sit_bord_ap
- **brdrp_est_dt_portad**: cod_estab_bord, dat_transacao, cod_portador
- **brdrp_portad_finalid_econ**: cod_estab_bord, cod_portador, cod_cart_bcia, cod_finalid_econ

---

## Tabela: calc_encargo_cta_corren
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_calc_encargo_cta_corren

### Índices

---

## Tabela: calc_parc_pis_cofins
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_cta_pat, num_bem_pat, num_seq_bem_pat, num_seq_incorp_bem_pat, cod_exerc_ctbl, num_period_ctbl

### Índices
- **clcprcps_period**: cod_exerc_ctbl, num_period_ctbl, cod_empresa, cod_cta_pat, num_bem_pat, num_seq_bem_pat
- **clcprcps_token** (Unique): num_id_calc_parc

---

## Tabela: calend_comis
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_calend_comis

### Índices

---

## Tabela: calend_glob
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_calend

### Índices
- **clndglbl_descricao**: des_calend

---

## Tabela: campo_layout_aviso_db
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_aviso_db, ind_campo_layout_aviso_db

### Índices

---

## Tabela: campo_layout_fisc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_fisc, cod_reg_layout_fisc, num_campo_layout_fisc

### Índices

---

## Tabela: cancel_parc_mais_negoc
**Label**: Taxa Original Estornada
**Descrição**: Taxa Original Estornada

### Chave Primária
- cod_empresa, cod_id_identif

### Índices
- **cnclprcm_cd_erp**: cod_empresa, cod_erp
- **cnclprcm_cod_trans** (Unique): cod_trans_canc_mais_negoc, num_parcela, cod_estab, num_id_tit_acr
- **cnclprcm_dt_mvt**: cod_empresa, dat_cancel_parcei
- **cnclprcm_tterp**: cod_estab, num_id_tit_acr

---

## Tabela: capac_produc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_cta_pat, cod_plano_ccusto, cod_ccusto_respons, cod_exerc_ctbl

### Índices

---

## Tabela: caract_bem_pat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_bem_pat, cod_caract_bem_pat

### Índices
- **crctbmpt_caract_pat**: cod_caract_bem_pat

---

## Tabela: caract_espec_pat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_espec_bem, cod_caract_pat

### Índices
- **crctspcp_caract_pat**: cod_caract_pat

---

## Tabela: caract_pat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_caract_pat

### Índices

---

## Tabela: cargo_eec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cargo

### Índices

---

## Tabela: cargo_niv_cargo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cargo, cod_niv_cargo

### Índices

---

## Tabela: cart_bcia
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cart_bcia

### Índices
- **cartbcia_tip_cart_bcia**: ind_tip_cart_bcia

---

## Tabela: cart_bcia_cta_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cart_bcia, ind_finalid_ctbl_cart_bcia, cod_finalid_econ, num_seq_cart_bcia_cta_ctbl

### Índices
- **crtbcctc_conta**: cod_plano_cta_ctbl, cod_cta_ctbl

---

## Tabela: cart_bcia_impto
**Label**: Taxa Carteira Bancar
**Descrição**: Taxa Carteira Banc�ria

### Chave Primária
- cod_cart_bcia, cod_imposto, cod_pais, cod_unid_federac

### Índices
- **crtbcmpt_imposto**: cod_pais, cod_unid_federac, cod_imposto, cod_cart_bcia

---

## Tabela: cart_tpi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_id_cart_techfin, cod_cart_integr_techfin, nom_banco_techfin

### Índices

---

## Tabela: carta_anuencia_inadimp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cdn_cliente, num_carta_anuencia_clien

### Índices

---

## Tabela: cartao_cr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_admdra_cartao_cr, cod_cartao_cr

### Índices

---

## Tabela: categ_hotel
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_categ_hotel

### Índices

---

## Tabela: ccusto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_plano_ccusto, cod_ccusto

### Índices
- **ccusto_tit_ctbl**: des_tit_ctbl

---

## Tabela: ccusto_solicit_viagem
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, num_id_ped_reserve, cod_ccusto

### Índices

---

## Tabela: ccusto_unid_negoc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_plano_ccusto, cod_ccusto, cod_unid_negoc

### Índices
- **ccstndno_unid_negoc**: cod_unid_negoc

---

## Tabela: cenar_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cenar_ctbl

### Índices

---

## Tabela: cenar_orctario
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_organ, cod_cenar_orctario

### Índices
- **tprctctl_plano_cta_unid_organ**: cod_plano_cta_ctbl, cod_unid_organ
- **tprctctl_utiliz_cenar_ctbl**: cod_cenar_ctbl, cod_unid_organ

---

## Tabela: cenar_orctario_bgc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cenar_orctario

### Índices

---

## Tabela: cep_agenc_bcia
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_banco, cod_agenc_bcia, cod_cep_inicial

### Índices
- **cpgncbc_cep**: cod_banco, cod_cep_final, cod_cep_inicial

---

## Tabela: chave_pix_fornec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cdn_fornecedor, cod_chave_pix

### Índices

---

## Tabela: chave_regra_concil_cta
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_regra_concil_cta_corren, num_seq_chave_regra_concil

### Índices

---

## Tabela: cheq_acr
**Label**: Total j�  Vinculado
**Descrição**: Valor Total j�  Vinculado do  Cheque ACR

### Chave Primária
- cod_banco, cod_agenc_bcia, cod_cta_corren_bco, num_cheque

### Índices
- **cheqacr_agrup**: cod_estab, num_agrup_cheq_acr
- **cheqacr_clien_dt_trans**: cod_empresa, cdn_cliente, dat_transacao
- **cheqacr_estab_trans**: cod_estab, dat_transacao, cdn_cliente
- **cheqacr_tit_acr**: cod_estab, num_id_tit_acr
- **cheqacr_token** (Unique): num_id_cheq_acr

---

## Tabela: cheq_ap
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab_cheq, cod_estab_refer, cod_portador, cod_cart_bcia, cod_finalid_econ, dat_emis_cheq, nom_favorec_cheq, num_seq_cheq

### Índices
- **cheqap_bord**: cod_estab_bord, cod_portad_bord, num_bord_ap
- **cheqap_confdo**: cod_estab_cheq, log_cheq_confdo, log_cheq_parcte_atlzdo, dat_emis_cheq
- **cheqap_cta_corren**: cod_cta_corren, num_talon_cheq, num_cheque
- **cheqap_dat_emis**: cod_estab_cheq, dat_emis_cheq
- **cheqap_favorec**: cod_estab_cheq, nom_favorec_cheq
- **cheqap_num_cheque**: cod_banco, cod_agenc_bcia, cod_cta_corren_bco, num_talon_cheq, num_cheque
- **cheqap_num_port_cheq**: cod_estab_cheq, cod_portador, cod_cart_bcia, cod_finalid_econ, num_talon_cheq, num_cheque
- **cheqap_token** (Unique): cod_estab_cheq, num_id_cheq_ap

---

## Tabela: cheque
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cta_corren, num_talon_cheq, num_cheque

### Índices
- **cheque_empresa**: cod_empresa, cod_cta_corren, dat_emis_cheq
- **cheque_token** (Unique): num_id_cheq

---

## Tabela: cidade
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cidade

### Índices

---

## Tabela: clas_acaocap
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_clas_acaocap

### Índices

---

## Tabela: clas_contat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_clas_contat

### Índices

---

## Tabela: clas_dia_calend
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_clas_dia_calend

### Índices

---

## Tabela: clas_risco_clien
**Label**: Taxa Inadimpl�ncia
**Descrição**: Taxa Inadimpl�ncia Classe Risco

### Chave Primária
- cod_clas_risco_clien

### Índices

---

## Tabela: classif_impto
**Label**: Valor M�nimo Imposto
**Descrição**: Valor M�nimo Imposto

### Chave Primária
- cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto

### Índices
- **clssfmpt_tbprgssv**: cod_tab_prgssiv_impto_retid

---

## Tabela: classif_msg_cobr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_classif_msg_cobr

### Índices

---

## Tabela: clien_analis_cr
**Label**: Valor Ultimo Tit
**Descrição**: Valor Ultimo Implantacao Titulo ACR

### Chave Primária
- cod_empresa, cdn_cliente

### Índices
- **clnnlscr_clsrsccl**: cod_clas_risco_clien
- **clnnlscr_spc**: cod_empresa, log_neces_acompto_spc

---

## Tabela: clien_cobr_ativ
**Label**: Total Vencido
**Descrição**: Valor Total Vencido

### Chave Primária
- cod_empresa, cdn_cliente, cod_estab

### Índices
- **clncbrtv_ordem1**: cod_empresa, log_ligac_telef_efetd, ind_tip_cobr_ativ, num_ord_cobr_ativ, log_novo_vencto_quebrado, val_maior_atraso_aber, qtd_dias_maior_atraso

---

## Tabela: clien_financ
**Label**: Percentual Verba de
**Descrição**: Valor Percentual Verba de Publicidade

### Chave Primária
- cod_empresa, cdn_cliente

### Índices
- **clnfnnc_classif_msg**: cod_classif_msg_cobr, cod_empresa, cdn_cliente
- **clnfnnc_portador**: cod_portador
- **clnfnnc_rprsntnt**: cod_empresa, cdn_repres

---

## Tabela: clien_inadimp
**Label**: Vencido
**Descrição**: Valor Vencido

### Chave Primária
- cod_empresa, cdn_cliente

### Índices
- **clnndmp_control_inadimp**: log_control_inadimp

---

## Tabela: clien_portad
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cdn_cliente, cod_portador

### Índices

---

## Tabela: clien_terc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_id_feder

### Índices

---

## Tabela: clien_video
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_clien_video

### Índices

---

## Tabela: cliente
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cdn_cliente

### Índices
- **cliente_codcli**: cdn_cliente
- **cliente_empresa_dat_impl**: cod_empresa, dat_impl_clien
- **cliente_empr_pessoa**: cod_empresa, num_pessoa
- **cliente_grp_clien**: cod_grp_clien
- **cliente_idfedercli**: cod_pais, cod_id_feder
- **cliente_id_feder**: cod_empresa, cod_pais, cod_id_feder
- **cliente_nomabrevcli**: nom_abrev
- **cliente_nomcli**: nom_pessoa
- **cliente_nom_abrev** (Unique): cod_empresa, nom_abrev
- **cliente_nom_pessoa**: cod_empresa, nom_pessoa
- **cliente_num_pessoa**: num_pessoa
- **cliente_tipo_clien**: cod_empresa, cod_tip_clien

---

## Tabela: cobert_apol
**Label**: Participa��o Obrigat
**Descrição**: Valor  Participa��o Obrigat�ria  Sinistro

### Chave Primária
- cod_seguradora, cod_apol_seguro, cod_cobert_apol

### Índices
- **cbrtpl_sinist**: cod_cobert_apol

---

## Tabela: cobert_sinist
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cobert_apol

### Índices

---

## Tabela: cobr_ativ_ped_vda
**Label**: Total Pedido Venda
**Descrição**: Valor Total Pedido Venda

### Chave Primária
- cod_empresa, cdn_cliente, cod_ped_vda

### Índices
- **cbrtvpdv_val**: cod_empresa, val_tot_ped_vda

---

## Tabela: cobr_especial_acr
**Label**: Vl Retorno Cobr
**Descrição**: Valor de Retorno da Cobran�a Especial

### Chave Primária
- cod_estab, cod_refer, cod_portador

### Índices
- **cbrspclc_portad**: cod_portador
- **cbrspclc_token** (Unique): num_id_cobr_especial_acr

---

## Tabela: coef_cm_pat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_cenar_ctbl, cod_finalid_econ, cod_exerc_ctbl, num_period_ctbl, cod_exerc_ctbl_aquis

### Índices
- **cfcmpt_fnldcn**: cod_finalid_econ
- **cfcmpt_prdctbl**: cod_cenar_ctbl, cod_exerc_ctbl, num_period_ctbl
- **cfcmpt_xrcctbl**: cod_cenar_ctbl, cod_exerc_ctbl_aquis

---

## Tabela: coef_reaval_bem_internac
**Label**: Valor Coeficiente Reavalia��o
**Descrição**: Valor Coeficiente Reavalia��o

### Chave Primária
- num_ano, num_mes, ind_operac_calc, ind_tip_coef

### Índices

---

## Tabela: col_balanct
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_padr_col_balanct, cod_col_balanct

### Índices
- **clblnct_tip_col**: cod_padr_col_balanct, num_tip_col_balanct
- **clblnct_tit**: des_tit_ctbl
- **clblnct_uo_orig**: cod_unid_organ

---

## Tabela: col_demonst_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_padr_col_demonst_ctbl, cod_col_demonst_ctbl

### Índices
- **cldmnstc_cldmnstc**: cod_padr_col_demonst_ctbl, cod_col_base_analis_vert
- **cldmnstc_soma**: cod_padr_col_demonst_ctbl, num_soma_ascii_cod_col

---

## Tabela: col_fluxo_cx
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_col_fluxo_cx, num_seq_col_fluxo_cx

### Índices

---

## Tabela: col_layout_fisc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_fisc, cod_reg_layout_fisc, num_campo_layout_fisc, num_col_layout_fisc

### Índices

---

## Tabela: col_prefer_demonst_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario, cod_demonst_ctbl, cod_padr_col_demonst_ctbl, num_seq

### Índices

---

## Tabela: coment_usuar_hotel
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_hotel_eec, num_pessoa_jurid, num_seq_reg_usuar_hotel

### Índices
- **cmntsrht_seq** (Unique): num_seq_reg_usuar_hotel

---

## Tabela: compl_cargo_eec
**Label**: Perc Adc Valor Desp
**Descrição**: Valor Percentual Adicionado � Despesa

### Chave Primária
- num_seq_compl_cargo, cod_cargo, cod_niv_cargo

### Índices
- **cmplcrgc_ctghtl**: cod_categ_hotel
- **cmplcrgc_data**: cod_cargo, cod_niv_cargo, dat_inic_valid, dat_fim_valid

---

## Tabela: compl_cond_cobr_acr
**Label**: Perc Multa
**Descrição**: Valor Percentual Multa Condi��o Cobran�a

### Chave Primária
- cod_estab, cod_cond_cobr, num_seq_cond_cobr_acr, qtd_dias_vencto_tit_acr

### Índices

---

## Tabela: compl_histor_padr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_histor_padr, cod_compl_padr, ind_tip_compl_padr

### Índices
- **cmplhstr_compl_padr**: cod_compl_padr

---

## Tabela: compl_hotel_eec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq_hotel_eec, cod_hotel_eec, cod_tip_diaria_hotel

### Índices
- **cmplhtlc_validade**: cod_hotel_eec, cod_tip_diaria_hotel, dat_fim_valid

---

## Tabela: compl_impto_retid_ap
**Label**: Val Transp Ded INSS
**Descrição**: Valor Transporte Dedu��o INSS

### Chave Primária
- cod_estab, num_id_tit_ap

### Índices
- **cmplmptr_class_impto**: cod_pais, cod_unid_federac, cod_imposto, cod_empresa, cod_classif_impto, dat_vencto_tit_ap, cod_indic_econ_impto
- **cmplmptr_movto_pai**: cod_estab, num_id_movto_tit_ap_pai

---

## Tabela: compl_movto_pagto
**Label**: Valor Multa
**Descrição**: Multa T�tulo AP

### Chave Primária
- cod_estab, num_id_movto_tit_ap

### Índices
- **cmplmvtp_agrup_baixa**: cod_estab_pagto, num_id_cheq_ap, num_id_agrup_item_bord_ap
- **cmplmvtp_data**: cod_estab, dat_pagto, ind_modo_pagto, cdn_fornecedor
- **cmplmvtp_item_cheq_ap**: cod_estab_cheq, num_id_cheq_ap, num_seq_item_cheq
- **cmplmvtp_itmbrdp**: cod_estab_pagto, cod_portador, num_bord_ap, num_seq_bord

---

## Tabela: compl_movto_tit_acr
**Label**: Vl Multa
**Descrição**: Valor da Multa do T�tulo

### Chave Primária
- cod_estab, num_id_movto_tit_acr

### Índices
- **cmplmvtt_estab_data**: cod_estab, dat_liquidac_movto_tit_acr, ind_ptlidad_dat_cr_acr, cod_portador, cod_cart_bcia
- **cmplmvtt_estab_dat_gerac_avdeb**: cod_estab_avdeb, dat_gerac_avdeb, cod_portador, cod_cart_bcia, num_id_tit_acr_avdeb
- **cmplmvtt_id_ndebito**: cod_estab, num_id_tit_acr_avdeb

---

## Tabela: compl_padr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_compl_padr

### Índices

---

## Tabela: compl_pagto_cartcred
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_id_tit_ap

### Índices
- **cmplpgtc_data**: cod_estab, dat_transacao
- **cmplpgtc_mvtttp**: cod_estab, num_id_movto_tit_ap_pai
- **cmplpgtc_prtdcrtc**: cod_empresa, cod_contrat_cartcred, cod_portad_cartcred

---

## Tabela: compl_retenc_impto_pagto
**Label**: Val Transp Ded INSS
**Descrição**: Valor Transporte Dedu��o INSS

### Chave Primária
- cod_estab, num_id_tit_ap, cod_unid_federac, cod_pais, cod_imposto, cod_classif_impto

### Índices

---

## Tabela: compon_documen
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_compon_estil

### Índices

---

## Tabela: compon_documen_idiom
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_compon_estil, cod_idioma

### Índices
- **cmpndcmi_nom**: nom_tit_compon_documen

---

## Tabela: compon_formul_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_formul_edi, num_seq_compon_formul_edi

### Índices

---

## Tabela: compos_cta_ctbl_ext
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_matriz_trad_org_ext, cod_tip_unid_organ, cod_unid_organ_ext, ind_contdo_compos_cta

### Índices
- **cmpsctct_plnccst**: cod_empresa, cod_plano_ccusto
- **cmpsctct_plnctctbl**: cod_plano_cta_ctbl
- **cmpsctct_posicao**: num_pos_contdo_compos_cta

---

## Tabela: compos_cta_pat_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_cta_pat_usuar, cod_usuario, cod_cta_pat

### Índices

---

## Tabela: compos_demonst_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_demonst_ctbl, num_seq_demonst_ctbl, num_seq_compos_demonst

### Índices
- **cmpsdmnt_ndrgnplo**: cod_plano_cta_ctbl, cod_unid_organ
- **cmpsdmnt_plnccst**: cod_unid_organ, cod_plano_ccusto

---

## Tabela: compos_finalid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_finalid_econ, dat_inic_valid_finalid, cod_indic_econ_base, cod_indic_econ_idx, dat_inic_valid

### Índices
- **cmpsfnld_datfim**: cod_finalid_econ, dat_fim_valid
- **cmpsfnld_indic_econ_idx**: cod_indic_econ_idx
- **cmpsfnld_parid_indic_econ**: cod_indic_econ_base, cod_indic_econ_idx

---

## Tabela: compos_finalid_cmcmm
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_finalid_econ, dat_inic_valid_finalid, cod_indic_econ_base, cod_indic_econ_idx, dat_inic_valid_compos, dat_inic_valid

### Índices
- **cmpsfnlb_ndccn**: cod_indic_econ_juros_idx
- **cmpsfnlb_parid_base**: cod_indic_econ_base, cod_indic_econ_idx
- **cmpsfnlb_parid_idx**: cod_indic_econ_idx, cod_indic_econ_base

---

## Tabela: compos_grp_calc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_calc, cod_tip_calc, cod_cenar_ctbl, cod_finalid_econ

### Índices
- **cmpsgrpa_cenar_ctbl**: cod_cenar_ctbl
- **cmpsgrpa_finalid_econ**: cod_finalid_econ
- **cmpsgrpa_tip_calc**: cod_tip_calc

---

## Tabela: compos_padr_fluxo_cx
**Label**: Percentual Previsto
**Descrição**: Valor Percentual Previsto

### Chave Primária
- cod_padr_fluxo_cx, num_seq

### Índices

---

## Tabela: compos_produt_financ
**Label**: % Composi��o
**Descrição**: Valor Percentual Composi��o Lastro

### Chave Primária
- cod_produt_financ, cod_lastro_financ

### Índices

---

## Tabela: compos_tip_fluxo_tot
**Label**: % Considerado
**Descrição**: Valor Percentual Considerado para Composi��o

### Chave Primária
- cod_tip_fluxo_financ, num_seq

### Índices

---

## Tabela: compos_unid_control
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_control_financ, cod_estab, cod_unid_negoc

### Índices
- **cmpsndcn_estab**: cod_estab, cod_unid_negoc
- **cmpsndcn_un**: cod_unid_negoc

---

## Tabela: conces_telef
**Label**: Perc Remunera��o
**Descrição**: Valor Percentual Remunera��o do Portador

### Chave Primária
- cod_conces_telef

### Índices
- **cncstlf_pssjrda**: num_pessoa_jurid

---

## Tabela: concil_cartao_cr
**Label**: Total Taxa Servi�o
**Descrição**: Valor Total da Taxa de Servi�o

### Chave Primária
- num_id_concil_cartao_cr

### Índices
- **cnclcrtc_data_diverg**: cod_empresa, dat_concil, ind_diverg_concil_cartao_cr, cod_operdra_cartao_cr
- **cnclcrtc_data_sit**: cod_empresa, dat_concil, ind_sit_concil_cartao_cr, cod_operdra_cartao_cr
- **cnclcrtc_nom_arq**: cod_empresa, des_nom_arq
- **cnclcrtc_operdra**: cod_empresa, cod_operdra_cartao_cr, dat_concil, ind_sit_concil_cartao_cr, ind_diverg_concil_cartao_cr
- **cnclcrtc_sit_concil**: cod_empresa, ind_sit_concil_cartao_cr, ind_tip_concil_cartao_cr, cod_operdra_cartao_cr
- **cnclcrtc_sit_diverg**: cod_empresa, ind_diverg_concil_cartao_cr, ind_tip_concil_cartao_cr, cod_operdra_cartao_cr

---

## Tabela: concil_cta_corren
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cta_corren, num_concil_cta_corren

### Índices
- **cnclctcr_cta_data**: cod_cta_corren, dat_ult_atualiz, hra_ult_atualiz

---

## Tabela: concil_mais_negoc
**Label**: Vl Tot Liq Pagto
**Descrição**: Valor total l�quido pagamento

### Chave Primária
- cod_empresa, cod_id_concil, cod_id_cta_concil

### Índices
- **cnclmsng_data**: cod_empresa, dat_lancto_concil
- **cnclmsng_status**: cod_empresa, ind_status_concil

---

## Tabela: concil_mktplace_arq
**Label**: Total Saldo ACR
**Descrição**: Total Repasse L�quido

### Chave Primária
- num_id_concil_mktplace

### Índices
- **cnclmkta_data**: dat_concil
- **cnclmkta_mkt_data**: cod_empresa, cdn_mktplace, dat_concil
- **cnclmkta_status_data**: ind_status_concil_mktplace, dat_concil

---

## Tabela: concil_tpi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, dat_concil, ind_tip_concil

### Índices

---

## Tabela: concor_finalid_econ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_concorrente, cod_finalid_econ

### Índices
- **cncrfnle_finalid_econ**: cod_finalid_econ

---

## Tabela: concorrente
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_concorrente

### Índices
- **cncrrnta_pessoa_jurid**: num_pessoa_jurid

---

## Tabela: cond_cobr_acr
**Label**: Perc Multa
**Descrição**: Valor Percentual Multa Condi��o Cobran�a

### Chave Primária
- cod_estab, cod_cond_cobr, num_seq_cond_cobr_acr

### Índices

---

## Tabela: cond_pagto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_cond_pagto, num_seq_cond_pagto

### Índices
- **cndpgt_tab_financ**: cod_tab_financ

---

## Tabela: confer_invent_patrim
**Label**: Unid Neg�cio
**Descrição**: C�digo Unidade Neg�cio

### Chave Primária
- cod_empresa, cod_estab, cod_unid_negoc, cod_plano_ccusto, cod_ccusto, cod_confer

### Índices

---

## Tabela: conferen_serv
**Label**: Vl Total Confer�ncia
**Descrição**: Valor Total Confer�ncia

### Chave Primária
- cod_empresa, cod_estab, cod_conferen

### Índices

---

## Tabela: configur_conex_online
**Label**: Livre 2
### Chave Primária
- cod_conex_online

### Índices

---

## Tabela: conjto_prefer_demonst
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario, cod_demonst_ctbl, cod_padr_col_demonst_ctbl, num_conjto_param_ctbl

### Índices
- **cnjtprfa_cncrrnta**: cod_concorrente
- **cnjtprfa_finalid_prefer**: cod_finalid_econ_apres
- **cnjtprfa_fnldcn**: cod_finalid_econ
- **cnjtprfa_ndrgn**: cod_unid_organ_orig
- **cnjtprfa_tpxrcctb**: cod_cenar_ctbl

---

## Tabela: contat_clas
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_pessoa_jurid, nom_abrev_contat, cod_clas_contat

### Índices
- **cnttclsa_clas_contat**: cod_clas_contat
- **cnttclsa_pessoa_classe**: num_pessoa_jurid, cod_clas_contat

---

## Tabela: contato
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_pessoa_jurid, nom_abrev_contat

### Índices
- **contato_pssfsca**: num_pessoa_fisic

---

## Tabela: contdo_reg_import_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_trans_edi, cdn_mapa_edi, cdn_segment_edi, cdn_seq_indic_reg

### Índices
- **cntdrgmp_mpsgmntd**: cdn_mapa_edi, cdn_segment_edi

---

## Tabela: contrat_cartcred
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_contrat_cartcred

### Índices

---

## Tabela: contrat_leas
**Label**: Valor Residual
**Descrição**: Valor Residual do Contrato

### Chave Primária
- cod_arrendador, cod_contrat_leas

### Índices
- **cntrtls_arrendatario**: cod_arrendatario
- **cntrtls_indic_econ**: cod_indic_econ
- **cntrtls_tip_calc**: cod_tip_calc

---

## Tabela: contrat_leas_atualiz
**Label**: Valor Total Incorporacao
**Descrição**: Valor Total Incorporacao

### Chave Primária
- cod_arrendador, cod_contrat_leas, cod_cenar_ctbl, dat_revis_leas, num_seq_incorp_bem_pat

### Índices

---

## Tabela: contrat_mutuo
**Label**: Total Juros
**Descrição**: Soma do Valor de todos os Movimentos de Juros

### Chave Primária
- cod_refer_contrat

### Índices
- **cntrtmt_data**: dat_inic_valid, dat_fim_valid
- **cntrtmt_emp_cred**: cod_empres_credora, cod_refer_contrat
- **cntrtmt_emp_dev**: cod_empres_devedora, cod_refer_contrat

---

## Tabela: contrat_vendor
**Label**: Taxa M�nima
**Descrição**: Valor da Taxa Minima para Opera��es Vendor

### Chave Primária
- cod_empresa, cdn_cliente, dat_inic_valid

### Índices

---

## Tabela: control_demonst_ctbl_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_control_demonst_ctbl

### Índices
- **cntrldma_dat_hra_ctbz**: cod_usuar_gerac_ctbz, dat_gerac_ctbz, hra_gerac_ctbz

---

## Tabela: control_demonst_ctbl_apb
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_control_demonst_ctbl

### Índices
- **cntrldmn_dat_hra_ctbz**: cod_usuar_gerac_ctbz, dat_gerac_ctbz, hra_gerac_ctbz

---

## Tabela: control_id_clien_fornec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_clien_fornec

### Índices
- **cntrldcl_aplic**: cod_aplicat_orig, cdn_clien_fornec
- **cntrldcl_ident**: cod_id_feder, cod_id_estad, cdn_clien_fornec

---

## Tabela: control_id_esoc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout, cod_empresa, cod_period_apurac, num_seq

### Índices
- **cntrldsc_id_xml**: cod_id_xml

---

## Tabela: control_imprsor_slip
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_imprsor, ind_control_imprsor_slip

### Índices

---

## Tabela: control_proces_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_proces_edi, cdn_etap_proces_edi, cdn_seq_control_edi

### Índices
- **cntrlprc_etpprcsd**: cdn_etap_proces_edi
- **cntrlprc_sttpprcs**: cdn_sit_etap_proces_edi

---

## Tabela: control_tar_execdo_shc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, dat_atoadm_shc, ind_movto_acaocap

### Índices
- **cntrltrx_seq_exec**: cod_empresa, cdd_tar_execdo_shc

---

## Tabela: control_xml_e_social
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_layout, cdn_fornecedor, cod_period_apurac, num_seq_histor

### Índices
- **cntrlxml_ix2**: cod_id_control_xml

---

## Tabela: conven_cart_bcia
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_portador

### Índices

---

## Tabela: conven_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_conven_financ

### Índices

---

## Tabela: conven_vendor
**Label**: Saldo Conv�nio
**Descrição**: Valor Saldo do Conv�nio de Vendor

### Chave Primária
- cod_estab, cod_portador, cod_cart_bcia, cod_finalid_econ

### Índices
- **cnvnvndr_mtdclcvn**: cod_metod_calc_vendor
- **cnvnvndr_portad_db**: cod_estab, cod_portad_db_vendor, cod_cart_bcia_db_vendor, cod_finalid_econ
- **cnvnvndr_token** (Unique): cod_estab, num_id_conven_vendor

---

## Tabela: conver_unid_medid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_medid_base, cod_unid_medid_dest

### Índices
- **cnvrndmd_destino**: cod_unid_medid_dest

---

## Tabela: correio_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_msg_edi

### Índices
- **crrd_2**: cod_emis_edi
- **crrd_3**: dat_msg_edi
- **crrd_4**: des_assunto_edi

---

## Tabela: corretor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdd_corretor

### Índices
- **corretor_pessoa**: cod_pais, cod_id_feder, nom_pessoa
- **corretor_pssfsca**: num_pessoa, cod_pais, cod_id_feder

---

## Tabela: cotac_lote_pagto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab_refer, cod_refer, cod_indic_econ

### Índices

---

## Tabela: cotac_operac_financ
**Label**: Valor Opera��o
**Descrição**: Valor Opera��o Financeira

### Chave Primária
- cod_usuar_cotac_operac, dat_cotac_operac_financ, hra_cotac_operac_financ

### Índices
- **ctcprcfn_token** (Unique): num_id_cotac_operac_financ

---

## Tabela: cotac_parid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_indic_econ_base, cod_indic_econ_idx, ind_tip_cotac_parid, dat_cotac_indic_econ

### Índices
- **ctcprd_indic_econ_idx**: cod_indic_econ_idx

---

## Tabela: criter_calc_empres_pat
**Label**: Perc Aplic Dpr
**Descrição**: Valor Percentual Aplicado Deprecia��o

### Chave Primária
- cod_empresa, cod_cenar_ctbl, cod_finalid_econ, dat_inic_valid

### Índices
- **crtrclcm_fnldcn**: cod_finalid_econ
- **crtrclcm_tpxrcctb**: cod_cenar_ctbl

---

## Tabela: criter_distrib_cta_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_plano_cta_ctbl, cod_cta_ctbl, cod_estab, num_seq_criter_distrib_ctbl

### Índices
- **crtrdsta_criter_distrib_ccusto**: cod_estab, cod_mapa_distrib_ccusto
- **crtrdsta_empresa**: cod_empresa
- **crtrdsta_num_seq_criter**: cod_plano_cta_ctbl, cod_cta_ctbl, num_seq_criter_distrib_ctbl

---

## Tabela: critic_sdo_cta_ctbl
**Label**: Toler�ncia
**Descrição**: Valor Toler�ncia

### Chave Primária
- num_critic_sdo_cta_ctbl

### Índices
- **crtcsdct_fnldcn**: cod_finalid_econ
- **crtcsdct_plnctctl**: cod_plano_cta_ctbl
- **crtcsdct_tpxrcctb**: cod_cenar_ctbl

---

## Tabela: cronog_calc_pat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_bem_pat, cod_tip_calc, cod_cenar_ctbl, dat_inic_parada

### Índices
- **crngclcp_fim_parada**: num_id_bem_pat, cod_tip_calc, cod_cenar_ctbl, dat_fim_parada
- **crngclcp_tip_calc**: cod_tip_calc

---

## Tabela: cta_corren
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cta_corren

### Índices
- **ctcrrn_agenc_bcia**: cod_banco, cod_agenc_bcia, cod_cta_corren_bco
- **ctcrrn_cta_corren_mutuo**: cod_cta_corren_mutuo
- **ctcrrn_dest_mut**: num_pessoa_jurid_dest_mutuo
- **ctcrrn_emit_mut**: num_pessoa_jurid_emit_mutuo
- **ctcrrn_empresa**: cod_empresa
- **ctcrrn_estab**: cod_estab
- **ctcrrn_finalid_econ**: cod_finalid_econ
- **ctcrrn_imagem**: cod_imagem
- **ctcrrn_pssjrda**: num_pessoa_jurid_favorec
- **ctcrrn_unid_negoc**: cod_unid_negoc

---

## Tabela: cta_corren_clien
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cdn_cliente, cod_banco, cod_agenc_bcia, cod_digito_agenc_bcia, cod_cta_corren_bco, cod_digito_cta_corren

### Índices

---

## Tabela: cta_corren_compos_mutuo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cta_corren_mutuo, cod_cenar_ctbl, cod_empres_orig, cod_unid_negoc_orig, cod_empres_dest, cod_unid_negoc_dest

### Índices
- **ctcrrncm_empres_dest**: cod_empres_dest
- **ctcrrncm_empres_orig**: cod_empres_orig
- **ctcrrncm_mutuo** (Unique): cod_cenar_ctbl, cod_empres_orig, cod_unid_negoc_orig, cod_empres_dest, cod_unid_negoc_dest
- **ctcrrncm_un_dest**: cod_unid_negoc_dest
- **ctcrrncm_un_orig**: cod_unid_negoc_orig

---

## Tabela: cta_corren_cta_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cta_corren, ind_finalid_ctbl_cta_corren, num_seq_cta_corren_cta_ctbl

### Índices
- **ctcrrnct_cta_ctbl**: cod_plano_cta_ctbl, cod_cta_ctbl

---

## Tabela: cta_corren_fornec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cdn_fornecedor, cod_banco, cod_agenc_bcia, cod_digito_agenc_bcia, cod_cta_corren_bco, cod_digito_cta_corren

### Índices

---

## Tabela: cta_corren_onera
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cta_corren, ind_tip_onera_cta_corren, cod_cenar_ctbl

### Índices
- **ctcrrnnr_cenar**: cod_cenar_ctbl
- **ctcrrnnr_produt**: cod_tip_calc_encargo_cta

---

## Tabela: cta_corren_pix
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cta_corren, cod_chave_pix

### Índices
- **ctcrrnpx_ix2**: cod_chave_pix

---

## Tabela: cta_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_plano_cta_ctbl, cod_cta_ctbl

### Índices
- **ctactbl_altern** (Unique): cod_plano_cta_ctbl, cod_altern_cta_ctbl
- **ctactbl_cenar_ctbl**: cod_cenar_ctbl_exclus
- **ctactbl_espec**: ind_espec_cta_ctbl, cod_plano_cta_ctbl, cod_cta_ctbl
- **ctactbl_finalid_econ**: cod_finalid_econ
- **ctactbl_grpctctb**: cod_tip_grp_cta_ctbl, cod_grp_cta_ctbl
- **ctactbl_tit_ctbl**: des_tit_ctbl
- **ctactbl_unid_medid**: cod_unid_medid

---

## Tabela: cta_ctbl_cmcmm
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_plano_cta_ctbl, cod_cta_ctbl, cod_indic_econ_base, cod_indic_econ_idx

### Índices
- **ctctblca_acerto**: cod_plano_cta_ctbl, cod_cta_ctbl_acerto
- **ctctblca_despes_varcamb**: cod_plano_cta_ctbl, cod_cta_ctbl_despes_varcamb
- **ctctblca_despes_vc_real**: cod_plano_cta_ctbl, cod_cta_ctbl_despes_vc_cx
- **ctctblca_ie**: cod_indic_econ_base, cod_indic_econ_idx
- **ctctblca_recta_varcamb**: cod_plano_cta_ctbl, cod_cta_ctbl_recta_varcamb
- **ctctblca_recta_vc_real**: cod_plano_cta_ctbl, cod_cta_ctbl_recta_vc_cx
- **ctctblca_trad**: cod_plano_cta_ctbl, cod_cta_ctbl_trad
- **ctctblca_trad_projec**: cod_plano_cta_ctbl, cod_cta_ctbl_trad_projec
- **ctctblca_transit_mmoed**: cod_plano_cta_ctbl, cod_cta_ctbl_transit_mmoed

---

## Tabela: cta_ctbl_integr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_modul_dtsul, cod_plano_cta_ctbl, cod_cta_ctbl, ind_finalid_ctbl

### Índices
- **ctctblne_cod_cta**: cod_cta_ctbl
- **ctctblne_cta_ctbl**: cod_plano_cta_ctbl, cod_cta_ctbl

---

## Tabela: cta_ctbl_intracompany
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_negoc

### Índices

---

## Tabela: cta_ctbl_tip_abat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_abat, cod_estab, num_seq_cta_tip_abat

### Índices

---

## Tabela: cta_ctbl_tip_fluxo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_plano_cta_ctbl, cod_cta_ctbl, cod_plano_ccusto, cod_ccusto

### Índices
- **tipo_fluxo** (Unique): cod_tip_fluxo_financ

---

## Tabela: cta_grp_clien
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, ind_tip_espec_docto, cod_espec_docto, cod_grp_clien, cod_finalid_econ, ind_finalid_ctbl, num_seq_cta_grp_clien

### Índices
- **ctgrpcln_cta_ctbl_integr**: cod_plano_cta_ctbl, cod_cta_ctbl
- **ctgrpcln_espec_docto**: cod_espec_docto
- **ctgrpcln_finalid_ctbl**: cod_empresa, ind_finalid_ctbl
- **ctgrpcln_finalid_econ**: cod_finalid_econ
- **ctgrpcln_gr_clien**: cod_grp_clien
- **ctgrpcln_inicio_validade**: cod_empresa, cod_espec_docto, ind_tip_espec_docto, cod_grp_clien, cod_finalid_econ, ind_finalid_ctbl, dat_inic_valid

---

## Tabela: cta_grp_clien_perddedut
**Label**: Saldo Inicial
**Descrição**: Valor Saldo Faixa Inicio

### Chave Primária
- cod_empresa, ind_tip_espec_docto, cod_espec_docto, cod_grp_clien, cod_finalid_econ, ind_finalid_ctbl, num_seq_cta_grp_clien, num_seq_faixa_valores

### Índices
- **ctgrpcla_valor**: cod_empresa, ind_tip_espec_docto, cod_espec_docto, cod_grp_clien, cod_finalid_econ, ind_finalid_ctbl, num_seq_cta_grp_clien, val_sdo_faixa_inic

---

## Tabela: cta_grp_fornec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, ind_tip_espec_docto, cod_espec_docto, cod_grp_fornec, cod_finalid_econ, ind_finalid_ctbl, num_seq_cta_grp_fornec

### Índices
- **ctgrpfrn_cta_ctbl_integr**: cod_plano_cta_ctbl, cod_cta_ctbl
- **ctgrpfrn_espec_docto**: cod_espec_docto
- **ctgrpfrn_finalid_econ**: cod_finalid_econ
- **ctgrpfrn_finalid_unid_organ**: cod_empresa, cod_finalid_econ
- **ctgrpfrn_gr_fornec**: cod_grp_fornec
- **ctgrpfrn_inicio_validade**: cod_empresa, cod_espec_docto, ind_tip_espec_docto, cod_grp_fornec, cod_finalid_econ, ind_finalid_ctbl, dat_inic_valid

---

## Tabela: cta_grp_repres
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_grp_repres, ind_control_ctbl, num_seq_cta_grp_repres

### Índices

---

## Tabela: cta_pat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_cta_pat

### Índices
- **ctapat_grp_calc**: cod_grp_calc
- **ctapat_grp_cta_pat**: cod_grp_cta_pat

---

## Tabela: cta_produt_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_banco, cod_produt_financ, ind_finalid_ctbl, num_seq_cta_produt_financ

### Índices

---

## Tabela: cta_repres
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_estab, cdn_repres, cod_funcao, cod_unid_negoc, cod_plano_cta_ctbl, cod_cta_ctbl, cod_plano_ccusto, cod_ccusto

### Índices

---

## Tabela: cta_restric_estab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_organ, cod_plano_cta_ctbl, cod_cta_ctbl, cod_estab

### Índices
- **ctrstrcs_ctactbl**: cod_plano_cta_ctbl, cod_cta_ctbl

---

## Tabela: cta_restric_unid_negoc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_organ, cod_plano_cta_ctbl, cod_cta_ctbl, cod_unid_negoc

### Índices
- **ctrstrcn_ctactbl**: cod_plano_cta_ctbl, cod_cta_ctbl
- **ctrstrcn_ndngc**: cod_unid_negoc

---

## Tabela: ctral_integr_ap
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_prop

### Índices
- **ctrlntgr_ctx**: cod_empresa, cod_content_prop

---

## Tabela: curva_abc_acr
**Label**: Total Curva ABC
**Descrição**: Valor Total Curva ABC Accounts Receivable

### Chave Primária
- cod_empresa, num_seq_curva_abc

### Índices
- **crvbccr_empresa_data**: cod_empresa, dat_criac_ped_exec, hra_criac_ped_exec

---

## Tabela: cust_devol_cheq
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_motiv_devol_cheq, cod_banco, cod_finalid_econ

### Índices
- **cstdvlch_banco**: cod_banco
- **cstdvlch_finalid_econ**: cod_finalid_econ

---

## Tabela: cx_financ
**Label**: Valor Saldo Total
**Descrição**: Valor de Saldo Total

### Chave Primária
- num_cx_financ

### Índices

---

## Tabela: darf_ap
**Label**: Valor Principal
**Descrição**: Valor do Principal

### Chave Primária
- cod_estab, cod_darf_ap

### Índices
- **darfap_cod**: cod_darf_ap
- **dat_trans**: cod_empresa, dat_transacao

---

## Tabela: demonst_concor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_concorrente, cod_cenar_ctbl, cod_exerc_ctbl, cod_plano_cta_ctbl

### Índices
- **dmnstcno_concor_finalid_econ**: cod_concorrente, cod_finalid_econ
- **dmnstcno_exerc_ctbl**: cod_cenar_ctbl, cod_exerc_ctbl
- **dmnstcno_finalid_econ**: cod_finalid_econ
- **dmnstcno_plano_cta**: cod_plano_cta_ctbl

---

## Tabela: demonst_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_demonst_ctbl

### Índices
- **dmnstctl_plano_cta**: cod_plano_cta_ctbl
- **dmnstctl_tit_ctbl**: des_tit_ctbl
- **dmnstctl_unid_organ**: cod_unid_organ

---

## Tabela: demonst_ctbl_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_control_demonst_ctbl, num_seq_control_demonst

### Índices
- **dmnstcta_aprpctbd**: cod_estab, num_id_aprop_ctbl_acr
- **dmnstcta_cta_ctbl**: cod_plano_cta_ctbl, cod_cta_ctbl
- **dmnstcta_detalhado_data**: num_id_control_demonst_ctbl, cod_estab, cod_plano_cta_ctbl, cod_cta_ctbl, cod_unid_negoc, cod_plano_ccusto, cod_ccusto, dat_transacao, ind_natur_lancto_ctbl
- **dmnstcta_detalhado_referencia**: num_id_control_demonst_ctbl, cod_estab, cod_plano_cta_ctbl, cod_cta_ctbl, cod_unid_negoc, cod_plano_ccusto, cod_ccusto, cod_refer, ind_natur_lancto_ctbl
- **dmnstcta_sumariado**: num_id_control_demonst_ctbl, cod_estab, dat_transacao, cod_plano_cta_ctbl, cod_cta_ctbl, cod_unid_negoc, cod_plano_ccusto, cod_ccusto, ind_natur_lancto_ctbl

---

## Tabela: demonst_ctbl_apb
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_control_demonst_ctbl, num_seq_control_demonst

### Índices
- **dmnstctb_detalhado_data**: num_id_control_demonst_ctbl, cod_estab, cod_plano_cta_ctbl, cod_cta_ctbl, cod_unid_negoc, cod_plano_ccusto, cod_ccusto, dat_transacao, ind_natur_lancto_ctbl
- **dmnstctb_detalhado_referencia**: num_id_control_demonst_ctbl, cod_estab, cod_plano_cta_ctbl, cod_cta_ctbl, cod_unid_negoc, cod_plano_ccusto, cod_ccusto, cod_refer, ind_natur_lancto_ctbl
- **dmnstctb_sumariado**: num_id_control_demonst_ctbl, cod_estab, dat_transacao, cod_plano_cta_ctbl, cod_cta_ctbl, cod_unid_negoc, cod_plano_ccusto, cod_ccusto, ind_natur_lancto_ctbl

---

## Tabela: demonst_ctbl_public
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_demonst_ctbl_public

### Índices

---

## Tabela: despes_operac_financ
**Label**: Perc Despesa
**Descrição**: Valor Percentual Despesa Opera��o

### Chave Primária
- num_id_operac_financ, num_seq

### Índices

---

## Tabela: despes_proces_eec
**Label**: Valor Despesa
**Descrição**: Valor Total Apropria��o Despesa

### Chave Primária
- num_id_proces_prestac_cta, cod_parcela, num_seq_despes_eec, num_id_tip_proces_despes, cod_despes_eec

### Índices
- **dspsprcs_acrtctc**: num_id_acerto_cta, num_id_proces_prestac_cta, cod_parcela, cod_despes_eec, num_id_tip_proces_despes
- **dspsprcs_adntprst**: num_id_proces_prestac_cta, cod_parcela, cod_despes_eec, num_id_tip_proces_despes, num_id_adiant_eec
- **dspsprcs_dspscrgc**: cod_despes_eec
- **dspsprcs_ndccn**: cod_indic_econ
- **dspsprcs_tpprcsds**: num_id_tip_proces_despes

---

## Tabela: destinac_cobr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_destinac_cobr, num_seq_destinac_cobr

### Índices
- **dstnccbr_cod_fim_valid**: cod_destinac_cobr, dat_fim_valid
- **dstnccbr_estab**: cod_estab, cod_finalid_econ, dat_fim_valid

---

## Tabela: det_despes_proces_eec
**Label**: Valor Nota Fiscal
**Descrição**: Valor Nota Fiscal Despesa

### Chave Primária
- num_seq_det_despes, num_id_despes_eec

### Índices
- **dtdspspr_nota**: num_nota_fisc

---

## Tabela: det_lancto_fp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_estab, cod_unid_negoc, cod_refer, cdn_funcionario, cdn_event, ind_natur_lancto_ctbl

### Índices
- **dtlnctfp_ccusto**: cod_empresa, cod_estab, cod_unid_negoc, cod_refer, cod_plano_cta_ctbl, cod_cta_ctbl, cod_plano_ccusto, cod_ccusto, ind_natur_lancto_ctbl
- **dtlnctfp_id_lancto**: num_id_aprop_lancto_ctbl
- **dtlnctfp_refer**: cod_empresa, cod_refer

---

## Tabela: dia_calend_glob
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_calend, dat_calend

### Índices
- **dclndglb_clas_dia_calend_glob**: cod_clas_dia_calend

---

## Tabela: dirf_apb
**Label**: Rendto Tribut�vel
**Descrição**: Valor Rendimento Tribut�vel

### Chave Primária
- cod_estab, num_pessoa, dat_refer, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto, cod_espec_docto, cod_ser_docto, cod_tit_ap, cod_parcela

### Índices
- **dirfapb_num_pessoa**: num_pessoa

---

## Tabela: dirf_apb_pensao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_pessoa, dat_refer, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto, cod_espec_docto, cod_ser_docto, cod_tit_ap, cod_parcela, nom_pensao

### Índices

---

## Tabela: distrib_cta_classif
**Label**: Percent Distribui��o
**Descrição**: Valor Percentual Distribui��o Conta Classifica��o

### Chave Primária
- cod_empresa, cod_banco, cod_produt_financ, ind_finalid_ctbl, num_seq_cta_produt_financ, num_seq_distrib_cta_classif

### Índices

---

## Tabela: diverg_lancto_cartao_cr
**Label**: Valor Operadora
**Descrição**: Valor Operadora. Para diverg�ncia de Valor e Taxa Comiss�o

### Chave Primária
- num_id_lancto_cartao_cr

### Índices
- **dvrglnct_nin**: num_id_lancto_cartao_cr, ind_tip_diverg, num_seq_diverg
- **dvrglnct_tip_diverg**: ind_tip_diverg

---

## Tabela: diverg_mktplace
**Label**: Valor Marketplace
**Descrição**: Valor Marketplace

### Chave Primária
- num_movto_mktplace, num_diverg_mktplace

### Índices
- **dvrgmktp_dat**: dat_diverg, ind_tip_diverg
- **dvrgmktp_dat_stat**: dat_diverg, ind_status_diverg
- **dvrgmktp_status**: ind_status_diverg, dat_diverg
- **dvrgmktp_tip**: ind_tip_diverg, dat_diverg

---

## Tabela: docto_entr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_empresa, cdn_fornecedor, cod_docto_entr, cod_ser_nota, cod_natur_operac

### Índices
- **dctntr_chave_aces**: cod_chave_aces_docto_fisc
- **dctntr_fornecedor**: cod_empresa, cdn_fornecedor
- **dctntr_gera_evento**: ind_gera_event_imob_item, dat_docto

---

## Tabela: docto_estoq_esoc
**Label**: Valor Total Retido
**Descrição**: Valor Total Retido

### Chave Primária
- cdd_num_docto_esoc

### Índices
- **dctstqsc_ix2**: cod_ser_docto, cod_docto, cdn_fornecedor, cod_natur_operac
- **dctstqsc_ix3**: cod_estab, cod_espec_docto, cod_ser_docto, cdn_fornecedor, cod_tit_ap, cod_parcela, cod_empresa
- **dctstqsc_ix4**: cod_estab, num_roman, num_seq
- **dctstqsc_ix5**: cod_estab, num_contrat_gfe
- **dctstqsc_ix6**: num_tip_orig, cod_layout, dat_transacao, cod_estab
- **dctstqsc_ix7**: dat_transacao, cod_estab
- **dctstqsc_ix8**: num_tip_orig, dat_transacao, cod_estab
- **dctstqsc_ix9**: cod_estab, dat_transacao, num_tip_orig

---

## Tabela: docto_recibo
**Label**: Taxa Encargo
**Descrição**: Valor Taxa Encargo

### Chave Primária
- num_recibo, cod_refer, cod_estab, cod_espec_docto, cod_ser_docto, cod_tit_acr, cod_parcela, ind_tip_docto

### Índices
- **dctrcb_data**: dat_gerac_docto, cod_refer, ind_tip_docto
- **dctrcb_recibo**: num_recibo, ind_tip_docto
- **dctrcb_refer**: cod_refer, dat_gerac_docto

---

## Tabela: docto_transp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- ind_tip_docto_transp, cod_estab_docto_transp, cod_docto_transp, cod_parcela

### Índices
- **dcttrnsp_docto**: cod_estab_docto_transp, cod_docto_transp
- **dcttrnsp_favorec**: cod_estab_tit, cdn_fornec_favorec, cod_espec_docto, cod_ser_docto, cod_tit_ap, cod_parcela
- **dcttrnsp_impl**: dat_impl, ind_tip_docto_transp
- **dcttrnsp_tit_ap**: cod_estab_tit, cdn_fornecedor, cod_espec_docto, cod_ser_docto, cod_tit_ap, cod_parcela

---

## Tabela: documen_operac_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_operac_financ, num_seq_documen_operac

### Índices
- **dcmnprcf_data_apresentacao**: dat_apres_documen_apl, dat_lim_apres_documen_apl

---

## Tabela: domin_caract
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_caract_pat, num_seq_valid_domin

### Índices

---

## Tabela: dupl_vendor
**Label**: Valor Original
**Descrição**: Valor Original Duplicata Vendor

### Chave Primária
- cod_estab_refer, num_id_dupl_vendor

### Índices
- **dplvndr_cliente**: cod_estab, num_planilha_vendor, cod_cond_pagto_vendor, dat_base_fechto_vendor, num_id_tit_acr, cdn_cliente, cdn_clien_matriz
- **dplvndr_cond_pagto**: cod_cond_pagto_vendor
- **dplvndr_emissao**: cod_estab_tit_acr, log_compon_planilha, dat_emis_docto, dat_base_fechto_vendor
- **dplvndr_planilha**: cod_estab, num_planilha_vendor, cod_cond_pagto_vendor, dat_base_fechto_vendor, cdn_cliente, cdn_repres, val_cotac_tax_vendor_clien
- **dplvndr_refer**: cod_estab_refer, cod_refer, num_seq_refer
- **dplvndr_tit_acr**: cod_estab_tit_acr, num_id_tit_acr, num_id_dupl_vendor

---

## Tabela: edifact_compon
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_compon_edifact

### Índices
- **edfctcmp_alfa**: des_compon_edifact

---

## Tabela: edifact_element
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_element_edifact

### Índices
- **edfctlmn_alfa**: des_element_edifact

---

## Tabela: edifact_estrut_compon
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_vers_edifact, cod_compon_edifact, num_pos_layout

### Índices
- **edfctsta_compon**: cod_compon_edifact
- **edfctsta_edfctstr**: cod_vers_edifact, cod_compon_edifact, cdn_element_edifact
- **edfctsta_element**: cdn_element_edifact

---

## Tabela: edifact_estrut_msg
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_vers_edifact, cod_msg_edifact, num_pos_layout

### Índices
- **edfctstb_edfctmsg**: cod_msg_edifact
- **edfctstb_segment**: cod_vers_edifact, cod_segment_edifact, cod_msg_edifact
- **edfctstb_segment_pai**: cod_segment_edifact_pai, cod_msg_edifact

---

## Tabela: edifact_estrut_segment
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_vers_edifact, cod_segment_edifact, num_pos_layout

### Índices
- **edfctstr_componente**: cod_compon_edifact
- **edfctstr_edfctsta**: cod_vers_edifact, cod_compon_edifact
- **edfctstr_element**: cdn_element_edifact
- **edfctstr_segment**: cod_segment_edifact

---

## Tabela: edifact_msg_padr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_vers_edifact, cod_msg_edifact

### Índices
- **edfctmsg_alfa**: des_msg_edifact
- **edfctmsg_msg**: cod_msg_edifact

---

## Tabela: edifact_qualific_element
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_element_edifact, cod_qualific_element

### Índices
- **edfctqlf_alfa**: des_qualific_element

---

## Tabela: edifact_segment
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_segment_edifact

### Índices
- **edfctsgm_alfa**: des_segment_edifact

---

## Tabela: edifact_vers_dic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_vers_edifact

### Índices
- **edfctvrs_alfa**: des_vers_edifact

---

## Tabela: element_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_element_edi

### Índices
- **elmntd_descricao**: des_element_edi
- **elmntd_format**: des_format_element_edi
- **elmntd_label**: des_label_element_edi

---

## Tabela: emissor_solicit_viagem
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, num_id_ped_reserve, nom_emissor_passag

### Índices

---

## Tabela: empres_clas_acaocap
**Label**: Ult Valor Patrimon
**Descrição**: �ltimo Valor Patrimonial A��o

### Chave Primária
- cod_empresa, cod_clas_acaocap

### Índices
- **emprscls_clsccp**: cod_clas_acaocap

---

## Tabela: empres_parcei_spc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_parcei_spc

### Índices
- **emprsprc_parceiro**: cod_parcei_spc

---

## Tabela: empres_parcei_tip_movto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_parcei_spc, cod_tip_movto_spc

### Índices

---

## Tabela: empres_scp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empres_scp

### Índices
- **emprsscp_cod_empresa**: cod_empresa

---

## Tabela: empresa
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa

### Índices
- **empresa_nom_abrev**: nom_abrev
- **empresa_razao_social**: nom_razao_social

---

## Tabela: enctro_cta
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_refer

### Índices
- **enctrct_cliente**: cod_empresa, cdn_cliente
- **enctrct_dat_transac**: cod_estab, dat_transacao
- **enctrct_fornec**: cod_empresa, cdn_fornecedor

---

## Tabela: ender_entreg
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_pessoa_jurid, cod_ender_entreg

### Índices
- **ndrntrga_pais**: cod_pais_entreg, cod_unid_federac_entreg

---

## Tabela: equaliz_operac_financ
**Label**: Taxa Pr� Passiva
**Descrição**: Valor Taxa Pr� Passivo

### Chave Primária
- num_id_operac_financ, num_id_movto_operac_financ

### Índices
- **eqlzprcf_dat**: dat_transacao
- **eqlzprcf_movto**: num_id_movto_operac_financ

---

## Tabela: espec_admdra_cartao_cr
**Label**: Vl Remunera��o
**Descrição**: Valor Remunera��o do Portador

### Chave Primária
- cod_espec_docto, cod_admdra_cartao_cr

### Índices

---

## Tabela: espec_bco
**Label**: Vl Remunera��o
**Descrição**: Valor Remunera��o do Portador

### Chave Primária
- cod_espec_docto, cod_banco

### Índices

---

## Tabela: espec_bem
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_espec_bem

### Índices
- **spcbm_descricao**: des_espec_bem

---

## Tabela: espec_conces_telef
**Label**: Vl Remunera��o
**Descrição**: Valor Remunera��o do Portador

### Chave Primária
- cod_espec_docto, cod_conces_telef

### Índices

---

## Tabela: espec_docto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_espec_docto

### Índices

---

## Tabela: espec_docto_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_espec_docto

### Índices
- **spcdctfa_especie_ligacao**: cod_espec_docto_ligac

---

## Tabela: espec_docto_financ_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_espec_docto

### Índices
- **espcdctf_espcdctf**: cod_espec_docto_antecip
- **espcdctf_especie_ligacao**: cod_espec_docto_ligac
- **espcdctf_espec_cheq**: cod_espec_docto_cheq_acr

---

## Tabela: espec_docto_financ_apf
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_espec_docto, cod_empresa

### Índices

---

## Tabela: espec_manual
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_espec_manual

### Índices

---

## Tabela: espec_manual_estil
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_espec_manual, num_tip_topic

### Índices
- **spcmnlst_estilo**: num_estilo
- **spcmnlst_tip_topic**: num_tip_topic

---

## Tabela: espec_manual_idiom
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_espec_manual, cod_idioma

### Índices
- **spcmnldm_nom**: nom_tit_espec_manual

---

## Tabela: espec_regra_perda_dedut
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_regra_perda_dedut, cod_espec_docto, dat_valid_regra_perda_inic

### Índices
- **espcrgrp_rgrprddd**: cod_espec_docto, dat_valid_regra_perda_inic

---

## Tabela: espec_vdr_db
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_espec_docto

### Índices

---

## Tabela: especif_tec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_espec_bem, cod_modelo, cod_marca, cod_especif_tec

### Índices
- **spcftc_imagem**: cod_imagem
- **spcftc_marca**: cod_marca

---

## Tabela: estab_estorn_pis_cofins
**Label**: Perc Estorn PIS
**Descrição**: Valor Percentual Estorno de PIS sobre o ativo imobilizado - IN 1911/2019 Artigo 501, �3�

### Chave Primária
- cod_estab, dat_inic_valid

### Índices

---

## Tabela: estab_operdra_cartao_cr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_operdra_cartao_cr, cod_estab_operdra, cod_estab

### Índices

---

## Tabela: estab_proces_esoc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_process_judic, cod_estab

### Índices

---

## Tabela: estab_unid_negoc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_unid_negoc

### Índices
- **estbndng_unid_negoc**: cod_unid_negoc

---

## Tabela: estabelecimento
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab

### Índices
- **stblcmnt_calend_glob_financ**: cod_calend_financ
- **stblcmnt_calend_glob_manuf**: cod_calend_manuf
- **stblcmnt_calend_glob_mater**: cod_calend_mater
- **stblcmnt_calend_glob_rh**: cod_calend_rh
- **stblcmnt_cdn** (Unique): cdn_estab
- **stblcmnt_clndglbl**: cod_calend_distrib
- **stblcmnt_empresa**: cod_empresa
- **stblcmnt_id_feder**: cod_pais, cod_id_feder
- **stblcmnt_id_previd_social**: cod_pais, cod_id_previd_social
- **stblcmnt_nom_abrev** (Unique): nom_abrev
- **stblcmnt_pessoa** (Unique): num_pessoa_jurid

---

## Tabela: estado_fisic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estado_fisic_bem_pat

### Índices
- **stdfsc_motiv_desmob**: cod_motiv_desmob

---

## Tabela: estatis_clien
**Label**: Vendas
**Descrição**: Valor Vendas

### Chave Primária
- cod_empresa, cdn_cliente, dat_estatis_clien

### Índices
- **esttscln_grp**: cod_grp_clien, dat_estatis_clien

---

## Tabela: estil_compon_documen
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_estilo, num_seq

### Índices
- **stlcmpnd_unico** (Unique): num_compon_estil, num_estilo

---

## Tabela: estil_idiom
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_estilo, cod_idioma

### Índices
- **stldm_des**: des_estilo

---

## Tabela: estilo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_estilo

### Índices

---

## Tabela: estorn_cobr_especial
**Label**: Valor Estornado
**Descrição**: Valor Titulo Contas a Receber Estornado

### Chave Primária
- cod_estab, num_id_tit_acr, num_seq_tit_acr, num_seq_lote_estorn

### Índices
- **estrncbr_env**: log_envdo_edi, cod_estab, cod_portador, dat_transacao
- **estrncbr_seq**: num_seq_lote_estorn

---

## Tabela: estrut_ccusto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_plano_ccusto, cod_ccusto_pai, num_seq_estrut_ccusto

### Índices
- **strtccst_filho_ccusto**: cod_empresa, cod_plano_ccusto, cod_ccusto_filho

---

## Tabela: estrut_clien
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cdn_clien_pai, cdn_clien_filho, num_seq_estrut_clien

### Índices
- **estrtcln_clien_filho**: cod_empresa, cdn_clien_filho

---

## Tabela: estrut_cta_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_plano_cta_ctbl, cod_cta_ctbl_pai, num_seq_estrut_cta_ctbl

### Índices
- **strtctcb_cta_ctbl_filho**: cod_plano_cta_ctbl, cod_cta_ctbl_filho

---

## Tabela: estrut_ctbl_movto_analit
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_plano_cta_ctbl, cod_cta_ctbl, cod_plano_ccusto, cod_ccusto, cod_proj_financ, cod_estab, cod_unid_negoc

### Índices
- **estrtctb_ccusto**: cod_empresa, cod_plano_ccusto, cod_ccusto, cod_plano_cta_ctbl, cod_cta_ctbl, cod_estab, cod_unid_negoc, cod_proj_financ
- **estrtctb_estab**: cod_empresa, cod_estab, cod_plano_cta_ctbl, cod_cta_ctbl, cod_plano_ccusto, cod_ccusto, cod_unid_negoc, cod_proj_financ
- **estrtctb_proj_financ**: cod_empresa, cod_proj_financ, cod_plano_cta_ctbl, cod_cta_ctbl, cod_plano_ccusto, cod_ccusto, cod_estab, cod_unid_negoc
- **estrtctb_unid_negoc**: cod_empresa, cod_unid_negoc, cod_plano_cta_ctbl, cod_cta_ctbl, cod_plano_ccusto, cod_ccusto, cod_estab, cod_proj_financ

---

## Tabela: estrut_ctbl_movto_sint
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_plano_cta_ctbl, cod_cta_ctbl, cod_plano_ccusto, cod_ccusto

### Índices

---

## Tabela: estrut_demonst_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario, cod_demonst_ctbl, cod_padr_col_demonst_ctbl, num_seq_demonst_ctbl, cod_col_demonst_ctbl

### Índices
- **estrtdmn_atualizacao**: cod_demonst_ctbl, cod_padr_col_demonst_ctbl, num_seq_demonst_ctbl, cod_col_demonst_ctbl

---

## Tabela: estrut_fornec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cdn_fornec_pai, cdn_fornec_filho, num_seq_estrut_fornec

### Índices
- **strtfrn_fornec_filho**: cod_empresa, cdn_fornec_filho

---

## Tabela: estrut_hier_pat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_hier_pat_pai, cod_hier_pat_filho

### Índices
- **strthrp_filho**: cod_hier_pat_filho, cod_hier_pat_pai

---

## Tabela: estrut_proj_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_proj_financ_pai, num_seq_estrut_proj_financ

### Índices
- **estrtprj_filho**: cod_proj_financ_filho

---

## Tabela: estrut_repres
**Label**: Comis Filho
**Descrição**: Percentual de Comiss�o Filho

### Chave Primária
- cod_empresa, cdn_repres_pai, cdn_repres_filho, num_seq_estrut_repres

### Índices
- **estrtrpr_repres_filho**: cod_empresa, cdn_repres_filho

---

## Tabela: estrut_tip_fluxo_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_clas_tip_fluxo_financ, cod_tip_fluxo_financ_pai, num_seq_estrut_tip_fluxo

### Índices
- **estrttpf_filho**: cod_tip_fluxo_financ_filho

---

## Tabela: estrut_unid_aprov
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_estab, cod_plano_aprovac_eec, cod_unid_aprovac_pai, num_seq_estrut_unid_aprov

### Índices
- **estrtnda_seq** (Unique): num_seq_estrut_unid_aprov

---

## Tabela: estrut_unid_control
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_control_pai, num_seq_estrut_unid_control

### Índices
- **estrtndc_filho**: cod_unid_control_filho

---

## Tabela: estrut_unid_negoc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_negoc_pai, num_seq_estrut_unid_negoc

### Índices
- **estrtndn_filho**: cod_unid_negoc_filho

---

## Tabela: estrut_unid_orctaria
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_orctaria_pai, num_seq_estrut_unid_orcto

### Índices
- **estrtndb_filho**: cod_unid_orctaria_filho

---

## Tabela: estrut_unid_organ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_organ_pai, num_seq_estrut_unid_organ, cdn_seq_estrut_organ

### Índices
- **estrtndr_seq_estr**: cdn_seq_estrut_organ, cod_unid_organ_pai, num_seq_estrut_unid_organ
- **estrtndr_seq_est_fil**: cdn_seq_estrut_organ, cod_unid_organ_filho
- **estrtndr_unid_organ_filho**: cod_unid_organ_filho, cdn_seq_estrut_organ

---

## Tabela: estrut_visualiz_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_demonst_ctbl, num_seq_demonst_ctbl, num_seq_estrut_visualiz

### Índices

---

## Tabela: etap_proces_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_etap_proces_edi

### Índices

---

## Tabela: event_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_event_financ

### Índices

---

## Tabela: event_modul_dtsul
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_modul_dtsul, cod_event_correio

### Índices

---

## Tabela: exc_calc_var_ccusto
**Label**: Perc Var CCusto Neg
**Descrição**: Percentual Varia��o Centro Custo (-)

### Chave Primária
- cod_regra, dat_inic_valid, dat_fim_valid, cod_plano_ccusto, cod_ccusto

### Índices

---

## Tabela: exc_calc_var_cta_ctbl
**Label**: Perc Var CtaCtbl Neg
**Descrição**: Percentual Varia��o Conta Cont�bil (-)

### Chave Primária
- cod_regra, dat_inic_valid, dat_fim_valid, cod_plano_cta_ctbl, cod_cta_ctbl

### Índices

---

## Tabela: exc_justif_grp_ccusto
**Label**: Perc Var CtaCtbl Pos
**Descrição**: Percentual Varia��o Conta Cont�bil (+)

### Chave Primária
- cod_grp_ccusto, dat_inic_valid, dat_fim_valid, cod_plano_cta_ctbl, cod_cta_ctbl

### Índices

---

## Tabela: exerc_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cenar_ctbl, cod_exerc_ctbl

### Índices

---

## Tabela: ext_item_lote_impl_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_refer, num_seq_refer

### Índices

---

## Tabela: ext_movto_ocor_bcia
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_id_tit_acr, num_seq_movto_ocor_bcia, num_seq_ext_movto_ocor

### Índices
- **extmvtcr_pix_link**: dsl_pix_link

---

## Tabela: ext_proces_pagto
**Label**: Valor Pagamento
**Descrição**: Valor Pagamento

### Chave Primária
- ind_tip_aprov, cod_estab, cod_espec_docto, cod_ser_docto, cdn_fornecedor, cod_tit_ap, cod_parcela, cod_refer_antecip_pef, num_seq_pagto_tit_ap

### Índices
- **extprcsp_sit**: ind_sit_proces_pagto

---

## Tabela: ext_relacto_ctbl
**Label**: Val Relacionamento
**Descrição**: Valor Relacionamento

### Chave Primária
- num_id_relacto_ctbl

### Índices
- **extrlctc_id_movto**: num_id_aprop_ctbl
- **extrlctc_id_orig**: cod_modul_dtsul, num_id_movto_orig
- **extrlctc_lancto**: cod_empresa, cod_estab, cod_refer, num_seq

---

## Tabela: ext_tit_acr
**Label**: Valor n�o Retido
**Descrição**: Valor n�o Retido

### Chave Primária
- cod_estab, num_id_tit_acr

### Índices
- **extttcr_pix_link**: dsl_pix_link

---

## Tabela: ext_tit_acr_cart_cr_pend
**Label**: Valor Total Pagto Cart�o de Cr�dito
**Descrição**: Valor Total Pagto Cart�o de Cr�dito

### Chave Primária
- cod_estab, cod_refer, num_seq_refer

### Índices

---

## Tabela: ext_tit_acr_cartcred
**Label**: Valor Total Pagto Cart�o de Cr�dito
**Descrição**: Valor Total Pagto Cart�o de Cr�dito

### Chave Primária
- cod_estab, num_id_tit_acr, num_seq_tit_acr

### Índices
- **extttcrb_opco**: cod_operdra_cartao_cr, cod_comprov_vda_antecip, cod_autoriz_antecip, num_parc_cartcred_antecip
- **extttcrb_oper**: cod_operdra_cartao_cr, cod_autoriz_antecip, cod_comprov_vda_antecip, num_parc_cartcred_antecip
- **extttcrb_tip**: ind_tip_espec_docto, cod_autoriz_antecip, cod_comprov_vda_antecip, num_parc_cartcred_antecip
- **extttcrb_tipes**: ind_tip_espec_docto, cod_comprov_vda_antecip, cod_autoriz_antecip, num_parc_cartcred_antecip

---

## Tabela: ext_tit_acr_ecom
**Label**: Percentual Frete
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_id_tit_acr, cod_ped_vda

### Índices
- **extttcrc_estab_ped**: cod_estab, cod_ped_vda_ecom
- **ext_tit_emp_id**: cod_empresa, cdn_mktplace
- **ext_tit_ped**: cod_ped_vda_ecom

---

## Tabela: ext_tit_acr_ecom_pend
**Label**: Percentual Frete
**Descrição**: Percentual Frete

### Chave Primária
- cod_estab, cod_refer, num_seq_refer, cod_ped_vda

### Índices

---

## Tabela: ext_tit_ap
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_id_tit_ap

### Índices

---

## Tabela: extnam_antecip_pef_pend
**Label**: Vl. Transacao 1099
**Descrição**: Valor Transacao 1099

### Chave Primária
- cod_estab, cod_refer

### Índices

---

## Tabela: extnam_aprop_ctbl_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_id_movto_tit_acr, cod_estab_aprop_ctbl, cod_plano_cta_ctbl, cod_cta_ctbl, cod_unid_negoc, cod_plano_ccusto, cod_ccusto, ind_natur_lancto_ctbl, num_id_aprop_ctbl_acr

### Índices

---

## Tabela: extnam_aprop_ctbl_ap
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_id_aprop_ctbl_ap

### Índices

---

## Tabela: extnam_contat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_pessoa_jurid, nom_abrev_contat

### Índices

---

## Tabela: extnam_empres
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa

### Índices

---

## Tabela: extnam_fornec_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cdn_fornecedor

### Índices

---

## Tabela: extnam_impto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_pais, cod_unid_federac, cod_imposto

### Índices

---

## Tabela: extnam_impto_iva_acr
**Label**: Percentual Imposto
**Descrição**: Percentual Imposto

### Chave Primária
- cod_estab, num_id_movto_tit_acr, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto

### Índices
- **extnmmpa_impto**: cod_pais, cod_unid_federac, cod_imposto

---

## Tabela: extnam_impto_iva_ap
**Label**: Percentual Imposto
**Descrição**: Percentual Imposto

### Chave Primária
- cod_estab, num_id_movto_tit_ap, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto

### Índices
- **extnmmpc_impto**: cod_pais, cod_unid_federac, cod_imposto

---

## Tabela: extnam_impto_pend_acr
**Label**: Percentual Imposto
**Descrição**: Percentual Imposto

### Chave Primária
- cod_estab, cod_refer, num_seq_refer, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto, num_seq

### Índices
- **extnmmpb_classif**: cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto

---

## Tabela: extnam_impto_pend_ap
**Label**: Percentual Imposto
**Descrição**: Percentual Imposto

### Chave Primária
- cod_estab_refer, cod_refer, cod_portador, num_bord_ap, num_seq_refer, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto, num_seq

### Índices
- **extnmmpd_classif**: cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto

---

## Tabela: extnam_item_bord_ap
**Label**: Vl. Transacao 1099
**Descrição**: Valor Transacao 1099

### Chave Primária
- cod_estab, cod_portador, num_bord_ap, num_seq_bord

### Índices

---

## Tabela: extnam_item_impl_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_refer, num_seq_refer

### Índices

---

## Tabela: extnam_item_lote_impl_ap
**Label**: Vl. Transacao 1099
**Descrição**: Valor Transacao 1099

### Chave Primária
- cod_estab, cod_refer, num_seq_refer

### Índices

---

## Tabela: extnam_item_lote_pagto
**Label**: Vl. Transacao 1099
**Descrição**: Valor Transacao 1099

### Chave Primária
- cod_estab, cod_refer, num_seq_refer

### Índices

---

## Tabela: extnam_movto_tit_ap
**Label**: Vl. Transacao 1099
**Descrição**: Valor Transacao 1099

### Chave Primária
- cod_estab, num_id_tit_ap, num_id_movto_tit_ap

### Índices

---

## Tabela: extnam_pessoa_fisic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_pessoa_fisic

### Índices

---

## Tabela: extnam_pessoa_jurid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_pessoa_jurid

### Índices

---

## Tabela: extnam_tit_ap
**Label**: Vl. Transacao 1099
**Descrição**: Valor Transacao 1099

### Chave Primária
- cod_estab, num_id_tit_ap

### Índices
- **extnmttp_acr**: cod_estab, num_id_tit_acr_orig

---

## Tabela: extrat_cta_corren
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cta_corren, num_extrat_cta_corren

### Índices
- **extrtctc_cta_corren_dat**: cod_cta_corren, dat_extrat_cta_corren_inic

---

## Tabela: fatur_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_fatur_acr

### Índices
- **faturacr_clnfnnc**: cod_empresa, cdn_cliente
- **faturacr_cond_pagto**: cod_estab, cod_cond_pagto

---

## Tabela: fatur_acr_integr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab_fatur, cod_fatur, cod_parcela

### Índices
- **ftrcrntg_tit_acr**: cod_estab_tit, cod_espec_docto, cod_ser_docto, cod_tit_acr, cod_parcela

---

## Tabela: fatur_ap
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cdn_fornecedor, num_fatur_ap

### Índices
- **faturap_estab_dat**: cod_estab, dat_transacao
- **faturap_fornec_financ**: cod_empresa, cdn_fornecedor
- **faturap_pess_fatur** (Unique): num_pessoa, num_fatur_ap

---

## Tabela: fechto_event_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_fechto_event_financ

### Índices
- **fchtvntf_data**: dat_fechto_event_financ
- **fchtvntf_usuar**: cod_usuar_fechto, cod_estab, dat_fechto_event_financ

---

## Tabela: fechto_event_tit
**Label**: Valor Vinculado
**Descrição**: Valor Vinculado da Antecipa��o

### Chave Primária
- num_id_fechto_event_financ, cod_empresa, cdn_fornecedor, cod_estab, num_id_tit_ap_antecip, num_id_tit_ap

### Índices
- **fchtvntt_antecip**: cod_estab, num_id_tit_ap_antecip
- **fchtvntt_sdo_an**: cod_empresa, cdn_fornecedor, cod_prop_rural, num_id_fechto_event_financ, num_id_tit_ap_antecip, val_sdo_vincul_antecip
- **fchtvntt_tit_ap**: cod_estab, num_id_tit_ap

---

## Tabela: fechto_event_vincul_tit
**Label**: Valor Vinculado
**Descrição**: Valor Vinculado ao Titulo

### Chave Primária
- num_id_fechto_event_financ, cod_estab_tit_ap, num_id_tit_ap, cod_estab_antecip, num_id_tit_ap_antecip

### Índices
- **fchtvntv_prop**: cod_empresa, cdn_fornecedor, cod_prop_rural, num_id_fechto_event_financ

---

## Tabela: fer_nac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_pais, dat_fer_nac

### Índices
- **fernac_clas_dia_calend**: cod_clas_dia_calend
- **fernac_descricao**: des_fer_nac

---

## Tabela: fgl_integr_ccusto_merc
**Label**: Tipo Integra��o
**Descrição**: Tipo de integra��o/a��o a ser realizada no registro.

### Chave Primária
- cod_empresa, cod_plano_ccusto, cod_ccusto, cod_integr_ccusto_merc

### Índices
- **fglntgrc_acao**: num_tip_integr, num_sit_integr, cod_empresa, cod_plano_ccusto, cod_ccusto
- **fglntgrc_sit**: num_sit_integr, num_tip_integr, cod_empresa, cod_plano_ccusto, cod_ccusto
- **fglntgrc_tip**: num_tip_integr, cod_integr_ccusto_merc

---

## Tabela: fiador
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_fiador

### Índices

---

## Tabela: fiador_bco
**Label**: Total Avalisado
**Descrição**: Valor Total Avalisado Fiador

### Chave Primária
- cod_fiador, cod_banco, num_seq_fiador_bco

### Índices

---

## Tabela: fiador_clien_inadimp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cdn_cliente, num_pessoa

### Índices

---

## Tabela: fiador_operac_financ
**Label**: Percentual Garantia
**Descrição**: Valor Percentual Garantia Fiador

### Chave Primária
- num_id_operac_financ, cod_fiador

### Índices

---

## Tabela: fiador_renegoc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_renegoc_cobr_acr, num_seq

### Índices
- **fdrrngc_pessoa**: num_pessoa

---

## Tabela: fiador_renegoc_inadimp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_refer, num_pessoa

### Índices

---

## Tabela: filtro_param_geral
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_identif_filtro, cod_usuar, cod_filtro

### Índices
- **fltrprmg_desc**: des_filtro

---

## Tabela: finalid_econ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_finalid_econ

### Índices

---

## Tabela: finalid_econ_bco
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_finalid_econ, cod_banco, num_seq_finalid_econ

### Índices
- **fnldcnbc_bco**: cod_banco, cod_indic_econ_bco
- **fnldcnbc_bco_dat**: cod_finalid_econ, cod_banco, dat_inic_valid

---

## Tabela: finalid_econ_moed_func
**Label**: Moeda Funcional da ECD
**Descrição**: Moeda Funcional da ECD

### Chave Primária
- cod_finalid_econ

### Índices

---

## Tabela: finalid_econ_tip_proces
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_proces_eec, cod_finalid_econ

### Índices

---

## Tabela: finalid_pat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_finalid_econ, cod_unid_organ

### Índices
- **fnldpt_unid_organ**: cod_unid_organ

---

## Tabela: finalid_unid_organ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_organ, cod_finalid_econ, dat_inic_valid

### Índices
- **fnldndrg_finalid_unid_organ**: cod_finalid_econ

---

## Tabela: finalid_utiliz_cenar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cenar_ctbl, cod_empresa, cod_finalid_econ

### Índices
- **fnldtlzc_fnldcn**: cod_finalid_econ
- **fnldtlzc_fnldndrg**: cod_empresa, cod_finalid_econ

---

## Tabela: financ_docto_fisc
**Label**: Valor Total Sem Tributos
**Descrição**: Documentos Fiscais Financeiro

### Chave Primária
- num_id_docto_fisc

### Índices
- **fnncdcta_chv**: cod_chave_aces_docto_fisc
- **fnncdcta_dfe**: cod_dfe
- **fnncdcta_dfeorig**: cod_dfe_orig
- **fnncdcta_estab_emis**: cod_estab, dat_emis_docto, dat_transacao
- **fnncdcta_estab_trans**: cod_estab, dat_transacao, dat_emis_docto
- **fnncdcta_ext**: cod_estab_ext, cod_ser_docto, cod_docto_fisc
- **fnncdcta_pessoa**: num_pessoa, cod_estab, dat_emis_docto, dat_transacao

---

## Tabela: financ_docto_fisc_pend
**Label**: Valor Totam Sem Tributos
**Descrição**: Documentos Fiscais Pendentes

### Chave Primária
- cod_estab, cod_refer, num_seq_refer, cod_dfe, ind_tip_trib, ind_tip_campo_trib

### Índices
- **fnncdctf_itmltmpl**: cod_estab, cod_refer, num_seq_refer

---

## Tabela: financ_docto_fisc_trib
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_docto_fisc, ind_tip_trib, ind_tip_campo_trib

### Índices

---

## Tabela: fixac_dpr
**Label**: Perc Distrib
**Descrição**: Valor Percentual Distribui��o Deprecia��o

### Chave Primária
- cod_metod_calc_dpr, qtd_mes_vida_util

### Índices

---

## Tabela: fluxo_cx
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_fluxo_cx

### Índices
- **fluxocx_fluxo_orig**: num_fluxo_cx_orig
- **fluxocx_ucf**: cod_unid_control_financ
- **fluxocx_ufc**: cod_unid_fechto_cx

---

## Tabela: forma_pagto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_forma_pagto

### Índices

---

## Tabela: forma_pagto_bco
**Label**: % Abatimento
**Descrição**: Percentual de Abatimento Calculado sobre a Despesa Banc�ria

### Chave Primária
- cod_empresa, cod_banco, cod_forma_pagto, dat_inic_valid

### Índices
- **frmpgtbc_forma_pagto**: cod_forma_pagto

---

## Tabela: format_dat_element_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_element_edi

### Índices

---

## Tabela: format_dat_geral_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- des_format_dat_edi

### Índices

---

## Tabela: format_dec_element_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_element_edi

### Índices

---

## Tabela: format_dec_geral_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- des_format_dec_edi

### Índices

---

## Tabela: format_int_element_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_element_edi

### Índices

---

## Tabela: format_int_geral_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- des_format_int_edi

### Índices

---

## Tabela: formul_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_formul_edi

### Índices
- **frmld_element** (Unique): cdn_trans_edi, cdn_mapa_edi, cdn_segment_edi, cdn_element_edi, cdn_mapa_orig_edi

---

## Tabela: fornec_desc_conven
**Label**: Perc Rateio
**Descrição**: Percentual Rateado

### Chave Primária
- num_id_movto_conven, cod_empresa, cdn_fornecedor

### Índices

---

## Tabela: fornec_financ
**Label**: Vl Ult Implanta��o
**Descrição**: Valor �ltima Implanta��o de T�tulo no Contas a Pagar

### Chave Primária
- cod_empresa, cdn_fornecedor

### Índices
- **frncfnnc_correntista**: cod_empresa, cdn_correntista
- **frncfnnc_entid_reten**: cod_empresa, ind_tip_entid_retenc
- **frncfnnc_forma_pagto**: cod_forma_pagto
- **frncfnnc_portador**: cod_portador
- **frncfnnc_tip_fornec**: cod_empresa, cod_tip_fornec, cdn_fornecedor

---

## Tabela: fornecedor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cdn_fornecedor

### Índices
- **frncdr_empresa_dat_impl**: cod_empresa, dat_impl_fornec
- **frncdr_empr_pessoa**: cod_empresa, num_pessoa
- **frncdr_fornecedor_ems2**: cdn_fornecedor
- **frncdr_grp_fornec**: cod_grp_fornec
- **frncdr_id_feder**: cod_empresa, cod_pais, cod_id_feder
- **frncdr_nom_abrev** (Unique): cod_empresa, nom_abrev
- **frncdr_nom_abrev_ems2**: nom_abrev
- **frncdr_nom_pessoa**: cod_empresa, nom_pessoa
- **frncdr_nom_pessoa_ems2**: nom_pessoa
- **frncdr_num_pessoa**: num_pessoa
- **frncdr_pais_id_feder_ems2**: cod_pais, cod_id_feder
- **frncdr_tipo_fornec**: cod_empresa, cod_tip_fornec, cdn_fornecedor

---

## Tabela: func_eec_grp_viagem
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_viagem_eec, num_seq_grp_viagem, cod_estab, cdn_func_financ

### Índices
- **fnccgrpv_funceec**: cod_estab, cdn_func_financ

---

## Tabela: func_emit_proces_eec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_estab, cod_plano_aprovac_eec, cod_unid_aprovac, num_seq_emit_proces_eec

### Índices
- **fncmtprc_func**: cod_empresa, cod_estab_func_financ, cdn_func_emit_proces_eec
- **fncmtprc_seq** (Unique): num_seq_emit_proces_eec

---

## Tabela: func_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cdn_func_financ

### Índices
- **fncfnnc_ccusto**: cod_empresa, cod_plano_ccusto, cod_ccusto
- **fncfnnc_crgnvcrg**: cod_cargo, cod_niv_cargo

---

## Tabela: func_financ_aprvdor_eec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq_func_financ_aprvdor, cod_empresa, cod_estab, cod_plano_aprovac_eec, cod_unid_aprovac, cod_estab_func_financ, cdn_func_financ

### Índices
- **fncfnncp_func**: cod_empresa, cod_estab_func_financ, cdn_func_financ

---

## Tabela: func_unid_aprovac_eec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_estab, cod_plano_aprovac_eec, cod_unid_aprovac, cod_estab_func_financ, cdn_func_financ

### Índices
- **fncndprv_func**: cod_empresa, cod_estab_func_financ, cdn_func_financ

---

## Tabela: funcao_negoc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_funcao_negoc

### Índices
- **fncngca_descricao**: des_funcao_negoc

---

## Tabela: gartia_contrat_financ
**Label**: Saldo Garantia
**Descrição**: Valor Saldo Garantia Produto Financeiro

### Chave Primária
- cod_empresa, cod_gartia_apl

### Índices

---

## Tabela: gartia_operac_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_operac_financ, cod_gartia_apl

### Índices

---

## Tabela: gerac_antecip
**Label**: Valor Original
**Descrição**: Valor Original Bem Patrimonial

### Chave Primária
- cod_estab, cod_espec_docto, cod_ser_docto, cod_tit_acr, cod_parcela, num_recibo, cod_refer

### Índices
- **grcntcp_data**: dat_gerac_docto
- **grcntcp_recibo**: num_recibo, dat_gerac_docto, cod_usuario

---

## Tabela: grp_calc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_calc

### Índices

---

## Tabela: grp_ccusto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_ccusto, dat_inic_valid, dat_fim_valid

### Índices

---

## Tabela: grp_clien
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_clien

### Índices
- **grpclien_classif_msg**: cod_classif_msg_cobr

---

## Tabela: grp_cta_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_grp_cta_ctbl, cod_grp_cta_ctbl

### Índices
- **grpctctb_inic** (Unique): cod_tip_grp_cta_ctbl, cod_inic_cta_ctbl

---

## Tabela: grp_cta_pat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_cta_pat

### Índices

---

## Tabela: grp_cta_pat_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_cta_pat_usuar, cod_usuario

### Índices

---

## Tabela: grp_event_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_event_financ

### Índices

---

## Tabela: grp_exc_cta_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_plano_ccusto, cod_ccusto

### Índices

---

## Tabela: grp_fornec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_fornec

### Índices

---

## Tabela: grp_repres
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_repres

### Índices

---

## Tabela: grp_segur_det_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_estab, cod_plano_ccusto, cod_ccusto, cod_plano_cta_ctbl, cod_cta_ctbl

### Índices

---

## Tabela: grp_usuar_regra_cx
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_regra, cod_grp_usuar

### Índices

---

## Tabela: grp_viagem_eec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_viagem_eec, num_seq_grp_viagem

### Índices
- **grpvgmc_seq** (Unique): num_seq_grp_viagem

---

## Tabela: hier_bem_pat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_bem_pat, cod_hier_pat

### Índices
- **hrbmpta_hier_pat**: cod_hier_pat

---

## Tabela: hier_pat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_hier_pat

### Índices
- **hierpat_tip_hier_pat**: cod_tip_hier_pat

---

## Tabela: his_bem_pat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_cta_pat, num_bem_pat, num_seq_bem_pat

### Índices
- **hsbmpt_seq** (Unique): num_id_bem_pat

---

## Tabela: his_bord_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab_bord, num_bord_acr

### Índices

---

## Tabela: his_bord_ap
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab_bord, cod_portador, num_bord_ap

### Índices

---

## Tabela: his_cheq
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cta_corren, num_talon_cheq, num_cheque

### Índices

---

## Tabela: his_cheq_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_banco, cod_agenc_bcia, cod_cta_corren_bco, num_cheque

### Índices

---

## Tabela: his_concil_cta_corren
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cta_corren, num_concil_cta_corren

### Índices

---

## Tabela: his_docto_entr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_empresa, cdn_fornecedor, cod_docto_entr, cod_ser_nota

### Índices

---

## Tabela: his_enctro_cta
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_refer

### Índices

---

## Tabela: his_extrat_cta_corren
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cta_corren, num_extrat_cta_corren

### Índices

---

## Tabela: his_fatur_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_fatur_acr

### Índices

---

## Tabela: his_fatur_ap
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cdn_fornecedor, num_fatur_ap

### Índices
- **hsftrp_pess_fatur** (Unique): num_pessoa, num_fatur_ap

---

## Tabela: his_fluxo_cx
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_fluxo_cx

### Índices

---

## Tabela: his_lote_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_lote_ctbl

### Índices

---

## Tabela: his_mapa_movto_bem_pat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_mapa_movto

### Índices

---

## Tabela: his_movto_cta_corren
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cta_corren, dat_movto_cta_corren, num_seq_movto_cta_corren

### Índices

---

## Tabela: his_movto_tit_acr_histor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_refer

### Índices

---

## Tabela: his_movto_tit_ap_histor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_refer

### Índices

---

## Tabela: his_nota_devol_tit_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_espec_docto, cod_ser_docto, cod_tit_acr, cod_parcela

### Índices

---

## Tabela: his_nota_devol_tit_ap
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab_ems5, cod_espec_docto, cod_ser_docto, cod_tit_ap, cod_parcela, cdn_fornecedor

### Índices

---

## Tabela: his_operac_financ_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_movto_operac_financ

### Índices

---

## Tabela: his_orcto_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_organ, cod_cenar_orctario, cod_cenar_ctbl, cod_exerc_ctbl

### Índices

---

## Tabela: his_renegoc_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_renegoc_cobr_acr

### Índices

---

## Tabela: his_tit_acr_cobr_esp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_id_tit_acr, num_seq_tit_acr

### Índices
- **hsttcrcb_tit_acr** (Unique): cod_estab, cod_espec_docto, cod_ser_docto, cod_tit_acr, cod_parcela

---

## Tabela: his_tit_acr_histor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_espec_docto, cod_ser_docto, cod_tit_acr, cod_parcela

### Índices
- **hsttcrhs_tit_acr_bco**: cod_empresa, cod_portador, cod_tit_acr_bco

---

## Tabela: his_tit_ap_transf_histor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cdn_fornecedor, cod_espec_docto, cod_ser_docto, cod_tit_ap, cod_parcela

### Índices
- **hsttptrn_fornec**: cdn_fornecedor, cod_espec_docto, cod_ser_docto, cod_tit_ap, cod_parcela

---

## Tabela: histor_acum_fornec
**Label**: Tt Tit AP Implantado
**Descrição**: Total dos T�tulos do Contas a Pagar Implantados

### Chave Primária
- cod_empresa, cdn_fornecedor

### Índices

---

## Tabela: histor_acum_impto_pagto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_estab, cdn_fornecedor, dat_refer, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto, num_seq_histor_acum

### Índices

---

## Tabela: histor_acum_repres
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cdn_repres

### Índices

---

## Tabela: histor_bco
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_banco, dat_gerac_histor, num_seq_histor_bco

### Índices

---

## Tabela: histor_cad_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_prog_dtsul_ext, cod_tabela, cod_reg_tab_filho, num_seq

### Índices
- **hstrcdfn_data**: dat_transacao, cod_prog_dtsul_ext, cod_tabela, cod_reg_tab_filho, num_seq
- **hstrcdfn_filho**: cod_tabela, cod_reg_tab_filho, cod_reg_tab_pai
- **hstrcdfn_orig**: ind_orig_histor, cod_prog_dtsul_ext, cod_tabela, cod_reg_tab_filho, num_seq
- **hstrcdfn_pai**: cod_tabela, cod_reg_tab_pai, cod_reg_tab_filho

---

## Tabela: histor_cheq
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cta_corren, num_talon_cheq, num_cheque, dat_gerac_movto, hra_gerac_movto

### Índices
- **hstrchq_mtvdvlch**: cod_motiv_devol_cheq

---

## Tabela: histor_clien
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cdn_cliente, num_seq_histor_clien

### Índices
- **hstrcln_abrev**: des_abrev_histor_clien

---

## Tabela: histor_cobr_escrit
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_id_tit_acr, num_seq_histor

### Índices

---

## Tabela: histor_cta_ctbl_integr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_modul_dtsul, cod_plano_cta_ctbl, cod_cta_ctbl, ind_finalid_ctbl, dat_gerac_movto, hra_gerac_movto

### Índices

---

## Tabela: histor_despes_recta
**Label**: Perc Rateio
**Descrição**: Percentual Rateio Contabiliza��o

### Chave Primária
- cod_estab, num_id_tit_acr, num_id_movto_tit_acr, num_seq_histor_despes_recta

### Índices
- **hstrdsps_dat**: cod_estab, num_id_tit_acr, dat_gerac_histor

---

## Tabela: histor_equaliz_fluxo_ter
**Label**: Tarifa Cobran�a Sdo
**Descrição**: Valor Tarifa Cobran�a Saldo

### Chave Primária
- cod_estab, num_renegoc_terc, num_seq

### Índices

---

## Tabela: histor_exec_especial
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_modul_dtsul, cod_prog_dtsul, cod_vers_prog, dat_gerac_movto, hra_gerac_movto

### Índices

---

## Tabela: histor_finalid_econ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_finalid_econ, dat_inic_valid_finalid

### Índices
- **hstrfnld_indic_econ**: cod_indic_econ

---

## Tabela: histor_fornec
**Label**: Sal�rio Contribui��o
**Descrição**: Valor Sal�rio Contribui��o

### Chave Primária
- cod_empresa, cdn_fornecedor, num_seq_histor_fornec

### Índices
- **hstrfrna_abrev**: des_abrev_histor_fornec

---

## Tabela: histor_gener
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tabela, cod_chave_tab, dat_alter_tab, hra_alter_tab

### Índices

---

## Tabela: histor_impto_empres
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_pais, cod_unid_federac, cod_imposto, cod_empresa, num_seq_histor_impto

### Índices
- **hstrmptm_empresa**: cod_empresa

---

## Tabela: histor_item_distrib_gerc
**Label**: Percentual
**Descrição**: Valor Percentual Crit�rio Distribui��o

### Chave Primária
- cod_unid_organ_orig, cod_plano_cta_ctbl_orig, cod_mapa_distrib_gerc_ctbl, cod_cta_ctbl_orig, num_seq_distrib_gerc_ctbl, cod_cta_ctbl_dest, dat_gerac_histor, hra_gerac_histor, cod_usuario, ind_tip_alter

### Índices
- **hstrtmds_dest**: cod_unid_organ_orig, cod_unid_organ_dest, cod_plano_cta_ctbl_dest, cod_cta_ctbl_dest
- **hstrtmds_orig**: cod_unid_organ_orig, cod_plano_cta_ctbl_orig, cod_cta_ctbl_orig, cod_cenar_ctbl, cod_estab, cod_unid_negoc, cod_plano_ccusto, cod_ccusto

---

## Tabela: histor_localiz_lancto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_lote_ctbl, num_lancto_ctbl, num_maq_envio, num_seq_histor_localiz

### Índices

---

## Tabela: histor_lote_ctbl_plant
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_lote_ctbl, cod_servid_rpc, dat_remes_lote_ctbl, hra_remes_lote_ctbl

### Índices

---

## Tabela: histor_mapa_distrib_gerc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_organ_orig, cod_plano_cta_ctbl_orig, cod_mapa_distrib_gerc_ctbl, dat_ult_atualiz, hra_ult_atualiz, cod_usuar_ult_atualiz

### Índices

---

## Tabela: histor_matriz_trad
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_organ, cod_matriz_trad_cta_ext, num_seq_histor_matriz

### Índices
- **hstrmtrz_dat**: cod_unid_organ, cod_matriz_trad_cta_ext, num_seq_histor_matriz, dat_gerac_histor
- **hstrmtrz_user**: cod_usuario, dat_gerac_histor, hra_gerac_histor

---

## Tabela: histor_movto_tit_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_id_tit_acr, num_id_movto_tit_acr, num_seq_histor_movto_acr

### Índices

---

## Tabela: histor_operac_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_operac_financ, dat_gerac_histor_apl, num_seq_histor_apl

### Índices

---

## Tabela: histor_orcto_ctbl_bgc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cenar_orctario, cod_unid_orctaria, num_seq_orcto_ctbl, cod_vers_orcto_ctbl, nom_arq_planilha

### Índices
- **hstrrctc_gerad**: log_planilha_gerad

---

## Tabela: histor_orig_movto_empenh
**Label**: Movto Empenhado
**Descrição**: Valor Movimento Empenhado

### Chave Primária
- cod_empresa, cod_plano_cta_ctbl, cod_cta_ctbl, cod_estab, cod_unid_negoc, cod_plano_ccusto, cod_ccusto, cod_proj_financ, dat_movto_ctbl, cod_finalid_econ, num_orig_movto_empenh, des_contdo_movto, num_erro, dat_gerac_histor, num_seq_histor

### Índices
- **hstrrgmv_ccusto**: cod_empresa, cod_plano_ccusto, cod_ccusto
- **hstrrgmv_ctbl**: cod_plano_cta_ctbl, cod_cta_ctbl
- **hstrrgmv_dat_ger**: dat_gerac_histor, hra_gerac_histor
- **hstrrgmv_estab**: cod_estab
- **hstrrgmv_id_orig**: des_contdo_movto
- **hstrrgmv_orig**: num_orig_movto_empenh, dat_movto_ctbl
- **hstrrgmv_proj**: cod_proj_financ
- **hstrrgmv_un**: cod_unid_negoc
- **hstrrgmv_user**: cod_usuar_histor, dat_gerac_histor, hra_gerac_histor
- **hstrrgmv_val**: val_movto_empenh

---

## Tabela: histor_padr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_histor_padr

### Índices
- **hstrpdr_mdldtsl**: cod_modul_dtsul

---

## Tabela: histor_param_ctbz
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_modul_dtsul, dat_gerac_movto, hra_gerac_movto

### Índices
- **hstrprmc_usuar_mestre**: cod_usuar_gerac_movto

---

## Tabela: histor_param_integr_ems
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- ind_param_integr_ems, dat_ult_atualiz, hra_ult_atualiz

### Índices

---

## Tabela: histor_param_inter_div
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, dat_inic_valid, cod_usuar_gerac_movto, dat_gerac_movto, hra_gerac_movto

### Índices

---

## Tabela: histor_perc_partic_acion
**Label**: Perc Particip Acion
**Descrição**: Valor Percentual da Participa��o Acion�ria

### Chave Primária
- cod_unid_organ_orig, cod_plano_cta_ctbl_orig, cod_mapa_distrib_gerc_ctbl, num_seq_particip, dat_gerac_histor, hra_gerac_histor

### Índices
- **hstrprcp_alt**: ind_tip_alter, dat_gerac_histor, hra_gerac_histor, cod_usuario
- **hstrprcp_dat**: dat_gerac_histor, hra_gerac_histor, cod_usuario, ind_tip_alter
- **hstrprcp_user**: cod_usuario, dat_gerac_histor, hra_gerac_histor, ind_tip_alter

---

## Tabela: histor_period_clien
**Label**: Tot Impl Per
**Descrição**: Valor Total de T�tulos Implantados no Per�odo

### Chave Primária
- cod_empresa, cdn_cliente, dat_gerac_histor

### Índices

---

## Tabela: histor_period_fornec
**Label**: Tot Pagtos Per�odo
**Descrição**: Total T�tulos de Contas a Pagar Pagos no Per�odo

### Chave Primária
- cod_empresa, cdn_fornecedor, dat_gerac_histor

### Índices

---

## Tabela: histor_pessoa_fisic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_pessoa_fisic, dat_ult_atualiz, hra_ult_atualiz

### Índices

---

## Tabela: histor_pessoa_jurid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_pessoa_jurid, dat_ult_atualiz, hra_ult_atualiz

### Índices

---

## Tabela: histor_ranking_bcio
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_regra_ranking_bcio, dat_ranking_bcio, num_seq

### Índices

---

## Tabela: histor_sdo_cta_ctbl_mod
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_usuario, dat_fim_period_ctbl, dat_atualiz_reg, cod_estab, cod_finalid_econ, cod_modul_dtsul, cod_plano_cta_ctbl, cod_cta_ctbl, cod_plano_ccusto, cod_ccusto, cod_proj_financ, cod_cenar_ctbl, cod_unid_negoc, hra_atualiz_reg

### Índices

---

## Tabela: histor_sit_movimen_dtsul
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_modul_dtsul, cod_unid_organ, ind_sit_movimen, dat_inic_sit_movimen, dat_fim_sit_movimen, dat_gerac_movto, hra_gerac_movto

### Índices
- **hstrstma_usuar_mestre**: cod_usuar_gerac_movto

---

## Tabela: histor_sit_period_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_modul_dtsul, cod_unid_organ, cod_cenar_ctbl, cod_exerc_ctbl, num_period_ctbl, dat_gerac_movto, hra_gerac_movto

### Índices
- **hstrstpr_usuar_mestre**: cod_usuar_gerac_movto

---

## Tabela: histor_tit_cobr_especial
**Label**: Vl Movimento
**Descrição**: Valor Movimento

### Chave Primária
- cod_estab, num_id_tit_acr, num_seq_tit_acr, num_seq_histor_tit_acr_cobr

### Índices

---

## Tabela: histor_tit_movto_ap
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_id_tit_ap, num_id_movto_tit_ap, num_seq_histor_movto_ap

### Índices

---

## Tabela: histor_topic_compon
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_topico, num_compon_estil, cod_idioma, dat_ult_atualiz, hra_ult_atualiz

### Índices

---

## Tabela: horar_passag
**Label**: Valor Passagem
**Descrição**: Valor Passagem Transporte

### Chave Primária
- num_seq_horar_passag, cod_rota_viagem, cod_tip_transp

### Índices
- **hrrpssg_tptrnspc**: cod_rota_viagem, num_pessoa_jurid

---

## Tabela: hosped_eec
**Label**: Valor Di�ria
**Descrição**: Valor Servi�o Contratado Hospedagem

### Chave Primária
- num_id_proces_prestac_cta, num_seq_hosped_eec

### Índices
- **hspdc_cmplhtlc**: num_seq_hotel_eec, cod_hotel_eec
- **hspdc_fnldcn**: cod_finalid_econ
- **hspdc_hoteleec**: cod_hotel_eec

---

## Tabela: hotel_eec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_hotel_eec

### Índices
- **hoteleec_cidade**: cod_hotel_eec, nom_cidade
- **hoteleec_ctghtl**: cod_categ_hotel
- **hoteleec_jurid** (Unique): num_pessoa_jurid

---

## Tabela: ident_bem_pat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_estab, cod_grp_calc, cod_cta_pat, num_bem_pat, num_seq_bem_pat, dat_inic_valid

### Índices

---

## Tabela: ident_cr_ret_fonte
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_estab, cod_grp_clien, cdn_cliente, dat_inic_valid

### Índices

---

## Tabela: identif_flat_file_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_identif_flat_file

### Índices

---

## Tabela: identif_flat_file_reg
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_identif_flat_file, num_seq

### Índices

---

## Tabela: idiom_basic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_idioma

### Índices

---

## Tabela: idiom_contat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_pessoa_jurid, nom_abrev_contat, cod_idioma

### Índices
- **dmcntta_idioma**: cod_idioma

---

## Tabela: idiom_pais
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_pais, cod_idioma

### Índices
- **dmpsa_idioma**: cod_idioma

---

## Tabela: idiom_pessoa_fisic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_pessoa_fisic, cod_idioma

### Índices
- **dmpssfs_idioma**: cod_idioma

---

## Tabela: imposto
**Label**: Lim Max Ret INSS
**Descrição**: Limite M�ximo de Reten��o de INSS

### Chave Primária
- cod_pais, cod_unid_federac, cod_imposto

### Índices

---

## Tabela: imprsor_slip_cod_bcia
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_imprsor, cod_banco

### Índices
- **imprsrsl_banco**: cod_banco

---

## Tabela: impto_advog
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab_refer, cod_refer, cod_portador, num_bord_ap, num_seq_refer, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto, num_seq_impto, num_pessoa, nom_advog

### Índices

---

## Tabela: impto_depend
**Label**: Dedu��o Dependente
**Descrição**: imptdpnd_pfdep

### Chave Primária
- cod_estab_refer, cod_refer, cod_portador, num_bord_ap, num_seq_refer, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto, num_seq_impto, num_pessoa, cod_id_feder

### Índices
- **imptdpnd_pfdep**: num_pessoa, cod_id_feder

---

## Tabela: impto_impl_pend_acr
**Label**: Rendto Tribut�vel
**Descrição**: Valor Rendimento Tribut�vel

### Chave Primária
- cod_estab, cod_refer, num_seq_refer, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto, num_seq

### Índices
- **imptmpla_clssfmpt**: cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto

---

## Tabela: impto_impl_pend_ap
**Label**: Val Transp Ded INSS
**Descrição**: Valor Transporte Dedu��o INSS

### Chave Primária
- cod_estab_refer, cod_refer, cod_portador, num_bord_ap, num_seq_refer, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto, num_seq

### Índices
- **imptmplp_imposto**: cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto
- **imptmplp_itmbrdp**: cod_estab_refer, cod_portador, num_bord_ap, num_seq_refer
- **imptmplp_lote**: cod_estab_refer, cod_refer, num_seq_refer
- **imptmplp_tit_ap**: num_pessoa_impto, cod_espec_docto, cod_ser_docto, cod_tit_ap, cod_parcela

---

## Tabela: impto_liquidac_tit_acr
**Label**: Vl Retido IE T�tulo
**Descrição**: Valor Retido no Indicador Econ. do Titulo ACR

### Chave Primária
- cod_estab_refer, cod_refer, num_seq_refer, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto

### Índices
- **imptlqdc_imptvncd**: cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto

---

## Tabela: impto_lote_mktplace
**Label**: Rendto Tribut�vel
**Descrição**: Valor Rendimento Tribut�vel

### Chave Primária
- cod_empresa, num_lote_mktplace, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto

### Índices

---

## Tabela: impto_nao_retid_ap
**Label**: Rendto Tribut�vel
**Descrição**: Valor Rendimento Tribut�vel

### Chave Primária
- cod_estab, num_id_tit_ap, num_id_movto_tit_ap, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto

### Índices
- **imptnrtd_imposto**: cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto
- **imptnrtd_refer**: cod_estab_refer, cod_refer
- **imptnrtd_titulo**: cod_estab, num_id_tit_ap

---

## Tabela: impto_pagto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_estab_refer, cod_refer, cod_portador, num_bord_ap, num_seq_refer, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto, num_seq

### Índices
- **imptpgt_data**: cod_empresa, dat_refer, cod_estab_refer
- **imptpgt_mvto**: cod_estab, num_id_movto_tit_ap

---

## Tabela: impto_pagto_padr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_pagto_padr, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto

### Índices
- **imptpgtp_clas_imp**: cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto, cod_empresa

---

## Tabela: impto_pend_operac_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_operac_financ, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto

### Índices

---

## Tabela: impto_pensao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab_refer, cod_refer, cod_portador, num_bord_ap, num_seq_refer, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto, num_seq_impto, num_pessoa, nom_pensao

### Índices

---

## Tabela: impto_process_comis
**Label**: valor processo
**Descrição**: valor processo

### Chave Primária
- cod_empresa, cdn_repres, cod_indic_econ, num_proces_integr_comis, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto, cod_indic_econ_orig, ind_natur_lancto_ctbl

### Índices
- **imptprcs_ix2**: cod_empresa, cdn_repres, cod_indic_econ, num_proces_integr_comis
- **imptprcs_ix3**: cod_pais, cod_unid_federac, cod_imposto

---

## Tabela: impto_produt_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_produt_financ, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto, num_seq_impto_produt_financ

### Índices

---

## Tabela: impto_tip_trans_cx
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_trans_cx, cod_pais, cod_unid_federac, ind_tip_impto_movto_financ, num_seq_impto_tip_trans_cx

### Índices
- **impttptr_classif_impto**: cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto

---

## Tabela: impto_val_agreg_acr
**Label**: Rendto Tribut�vel
**Descrição**: Valor Rendimento Tribut�vel

### Chave Primária
- cod_estab, num_id_movto_tit_acr, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto

### Índices
- **imptvlgr_imposto**: cod_pais, cod_unid_federac, cod_imposto

---

## Tabela: impto_val_agreg_movto_ap
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_id_movto_tit_ap, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto

### Índices

---

## Tabela: impto_vincul_clien
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cdn_cliente, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto

### Índices

---

## Tabela: impto_vincul_empres
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_pais, cod_unid_federac, cod_imposto, cod_empresa

### Índices
- **imptvnca_empresa**: cod_empresa

---

## Tabela: impto_vincul_estab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_pais, cod_unid_federac, cod_imposto

### Índices
- **imptvncb_imposto**: cod_pais, cod_unid_federac, cod_imposto

---

## Tabela: impto_vincul_fornec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cdn_fornecedor, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto

### Índices
- **imptvncl_classif_impto**: cod_pais, cod_unid_federac, cod_imposto, cod_empresa, cod_classif_impto

---

## Tabela: impto_vincul_tit_acr
**Label**: Vl Retido IE T�tulo
**Descrição**: Valor Total ja Retido no Indicador do Titulo

### Chave Primária
- cod_estab, num_id_tit_acr, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto, num_impto_refer_tit_acr

### Índices
- **imptvncd_impto_seq_refer_impl**: cod_estab_refer, cod_refer, num_seq_refer, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto, num_impto_refer_tit_acr

---

## Tabela: incent_fisc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_incent_fisc

### Índices

---

## Tabela: incorp_bem_pat
**Label**: Perc Redu��o Saldo
**Descrição**: Percentual Deprecia��o Anual Reducao Saldo

### Chave Primária
- num_id_bem_pat, num_seq_incorp_bem_pat, cod_cenar_ctbl, dat_incorp_bem_pat, ind_incorp_bem_pat

### Índices
- **incrpbmp_cenar_ctbl**: cod_cenar_ctbl
- **incrpbmp_incent_fisc**: cod_incent_fisc
- **incrpbmp_indic_econ**: cod_indic_econ
- **incrpbmp_tipcalc**: cod_tip_calc_reaval
- **incrpbmp_tmdctntr**: cod_estab, cod_empresa, cdn_fornecedor, cod_docto_entr, cod_ser_nota, num_item_docto_entr, cod_natur_operac

---

## Tabela: increm_dpr_ccusto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_plano_ccusto, cod_ccusto, cod_tip_calc_dpr

### Índices
- **ncrmdprc_tip_calc_dpr**: cod_tip_calc_dpr

---

## Tabela: indeniz_indexad
**Label**: Percentual Indexador
**Descrição**: Valor Percentual Indexador

### Chave Primária
- cod_empresa, cod_period_indexad

### Índices

---

## Tabela: indeniz_repres
**Label**: Vendas Original
**Descrição**: Valor Vendas Original

### Chave Primária
- cod_empresa, cdn_repres, cod_indic_econ, cod_period_indeniz

### Índices
- **indnzrpr_per**: cod_period_indeniz, cdn_repres, cod_indic_econ

---

## Tabela: indic_apl
**Label**: % Garantia Taxa
**Descrição**: Valor Percentual Garantia Taxa Aplica��o

### Chave Primária
- cod_banco, cod_produt_financ, num_seq_indic_apl

### Índices

---

## Tabela: indic_econ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_indic_econ

### Índices

---

## Tabela: indic_econ_operac_financ
**Label**: Taxa Juros
**Descrição**: Valor Taxa Juros Opera��o Financeira

### Chave Primária
- num_id_operac_financ, num_seq

### Índices

---

## Tabela: instruc_bcia
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_modul_dtsul, cod_instruc_bcia

### Índices

---

## Tabela: instruc_bcia_bco
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_banco, cod_instruc_bcia, cod_modul_dtsul, cdn_parcei_edi

### Índices

---

## Tabela: int_sdo_consolid_param
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa

### Índices

---

## Tabela: integr_apl_modul_funcao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_modul_integr, ind_funcao_integr_apl

### Índices

---

## Tabela: integr_apl_param_funcao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_modul_integr, ind_funcao_integr_apl, ind_param_integr_apl

### Índices

---

## Tabela: integr_cfl_modul_funcao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_estab, cod_modul_integr, ind_funcao_integr_cfl

### Índices

---

## Tabela: integr_cfl_param_funcao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_estab, cod_modul_integr, ind_funcao_integr_eec, ind_param_cfl_integr

### Índices

---

## Tabela: integr_eec_modul_funcao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_estab, cod_modul_integr, ind_funcao_integr_eec

### Índices

---

## Tabela: integr_eec_param_funcao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_estab, cod_modul_integr, ind_funcao_integr_eec, ind_param_integr_eec

### Índices

---

## Tabela: integr_sdo_consolid_his
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_integr_sdo_his

### Índices
- **intgrsdc_status**: cod_empresa, dat_gerac_trans, ind_tip_trans_sdo, ind_status_integr_sdo

---

## Tabela: integr_sdo_consolid_msg
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_integr_sdo_his, num_id_integr_sdo_msg

### Índices

---

## Tabela: invent_bem_pat_hist
**Label**: Vers�o do Hist�rico
**Descrição**: num id inventario

### Chave Primária
- num_id_invent, num_id_bem_pat, num_versao

### Índices

---

## Tabela: invent_patrim
**Label**: Pedido Importação
**Descrição**: Número do Pedido de Execução da Importação

### Chave Primária
- num_id_invent

### Índices
- **invntptr_ix2**: ind_sit_invent, cod_usuar_respons, dat_inic_valid, dat_fim_valid
- **invntptr_ix3**: dat_inic_valid, dat_fim_valid

---

## Tabela: invent_patrim_bem
**Label**: Valor Original F¡sico
**Descrição**: Valor Original F¡sico

### Chave Primária
- num_id_invent, num_seq_invent_bem

### Índices
- **invntptb_ix2**: cod_estab_fisic, cod_unid_negoc_fisic, cod_plano_ccusto_fisic, cod_ccusto_fisic, cod_cta_pat_fisic, cod_localiz_fisic
- **invntptb_ix3**: num_id_bem_pat
- **invntptb_ix4**: num_id_invent, ind_sit_bem_invent, log_confer
- **invntptb_ix5**: num_id_invent, cod_usuar_invent
- **invntptb_ix6**: num_id_invent, num_seq_relacto, num_id_bem_pat, num_seq_invent_bem

---

## Tabela: invent_patrim_bem_status
**Label**: Seq Bem Invent�rio
**Descrição**: N�mero Sequ�ncia do Bem no Invent�rio

### Chave Primária
- num_id_invent, num_seq_invent_bem

### Índices

---

## Tabela: invent_patrim_relacto
**Label**: Sequ�ncia
**Descrição**: Sequ�ncia

### Chave Primária
- num_id_invent, num_seq_relacto

### Índices
- **invntpta_ix3**: cod_empresa, cod_estab, cod_unid_negoc, cod_plano_ccusto, cod_ccusto, cod_cta_pat, cod_localiz

---

## Tabela: invent_patrim_status_confer
**Label**: ID Invent�rio
**Descrição**: ID Invent�rio

### Chave Primária
- cod_empresa, num_id_invent, cod_confer

### Índices

---

## Tabela: item_agenda_inadimp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario, dat_agenda, cod_estab, cod_espec_docto, cod_ser_docto, cod_tit_acr, cod_parcela

### Índices
- **itmgndnd_atz**: log_refer_atlzdo
- **itmgndnd_refer**: cod_refer
- **itmgndnd_sit**: ind_sit_item_agenda_inadimp
- **itmgndnd_titulo**: cod_estab, cod_espec_docto, cod_ser_docto, cod_tit_acr, cod_parcela

---

## Tabela: item_bord_acr
**Label**: Saldo T�tulo
**Descrição**: Valor Saldo Contas a Receber

### Chave Primária
- cod_estab_bord, num_bord_acr, num_seq_bord

### Índices
- **itmbrdcr_tit_acr**: cod_estab, cod_espec_docto, cod_ser_docto, cod_tit_acr, cod_parcela

---

## Tabela: item_bord_ap
**Label**: Vl Pagto Orig Inic
**Descrição**: Valor Pagamento no IE de  Origem, inicial

### Chave Primária
- cod_estab_bord, cod_portador, num_bord_ap, num_seq_bord

### Índices
- **itmbrdp_agrup**: cod_estab_bord, num_id_agrup_item_bord_ap
- **itmbrdp_antecip_pef_pend**: cod_estab, cod_refer_antecip_pef
- **itmbrdp_proces**: cdn_proces_edi
- **itmbrdp_tit_ap**: cod_estab, cod_espec_docto, cod_ser_docto, cdn_fornecedor, cod_tit_ap, cod_parcela
- **itmbrdp_token** (Unique): cod_estab_bord, num_id_item_bord_ap

---

## Tabela: item_bord_ap_agrup
**Label**: Total Agrupamento
**Descrição**: Valor Total Agrupamento Item Bordero Contas a pagar

### Chave Primária
- cod_estab_bord, num_id_agrup_item_bord_ap

### Índices
- **itmbrdpg_cheqap**: cod_estab_cheq, num_id_cheq_ap

---

## Tabela: item_cheq_ap
**Label**: Valor Pagamento
**Descrição**: Valor Pagamento

### Chave Primária
- cod_estab_cheq, num_id_cheq_ap, num_seq_item_cheq

### Índices
- **itmchqp_antcppfp**: cod_refer_antecip_pef, cod_estab_refer
- **itmchqp_lote**: cod_estab_refer, cod_refer, num_seq_refer

---

## Tabela: item_conferen_serv
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_estab, cod_conferen, num_id_ped_reserve, num_id_reserva

### Índices
- **itmcnfrn_rsrv**: cod_empresa, num_id_ped_reserve, num_id_reserva

---

## Tabela: item_cotac_operac_financ
**Label**: Taxa Pr�-Fixada
**Descrição**: Valor Taxa Juros Pre Fixada

### Chave Primária
- num_id_cotac_operac_financ, num_seq

### Índices
- **itmctcpr_token** (Unique): num_id_item_cotac_operac

---

## Tabela: item_critic_sdo_cta_ctbl
**Label**: Margem Aceit�vel
**Descrição**: Valor Margem Aceit�vel

### Chave Primária
- num_critic_sdo_cta_ctbl, num_seq_item_critic, cod_plano_cta_ctbl, cod_cta_ctbl_orig, cod_plano_cta_ctbl_dest, cod_cta_ctbl_dest

### Índices
- **itmcrtcs_cta_dest**: cod_plano_cta_ctbl, cod_cta_ctbl_dest
- **itmcrtcs_cta_orig**: cod_plano_cta_ctbl, cod_cta_ctbl_orig
- **itmcrtcs_plano**: num_critic_sdo_cta_ctbl, cod_plano_cta_ctbl, cod_cta_ctbl_orig, cod_cta_ctbl_dest
- **itmcrtcs_pln_dest**: cod_plano_cta_ctbl_dest, cod_cta_ctbl_dest
- **itmcrtcs_uo_dest**: num_critic_sdo_cta_ctbl, cod_unid_organ_dest
- **itmcrtcs_uo_orig**: num_critic_sdo_cta_ctbl, cod_unid_organ_orig

---

## Tabela: item_curva_abc_acr
**Label**: Perc Curva ABC Valor
**Descrição**: Valor Percentual Curva ABC ACR Valor

### Chave Primária
- cod_empresa, num_seq_curva_abc, num_seq_item_curva_abc

### Índices

---

## Tabela: item_demonst_concor
**Label**: Saldo Final
**Descrição**: Valor Saldo Concorrente Final

### Chave Primária
- cod_concorrente, cod_cenar_ctbl, cod_exerc_ctbl, cod_plano_cta_ctbl, cod_cta_ctbl, num_period_ctbl, cod_finalid_econ

### Índices
- **tmdmnstn_cta_ctbl**: cod_plano_cta_ctbl, cod_cta_ctbl
- **tmdmnstn_finalid_econ**: cod_finalid_econ
- **tmdmnstn_finalid_econ_concor**: cod_concorrente, cod_finalid_econ
- **tmdmnstn_period_ctbl**: cod_cenar_ctbl, cod_exerc_ctbl, num_period_ctbl

---

## Tabela: item_demonst_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_demonst_ctbl, num_seq_demonst_ctbl

### Índices
- **tmdmnstt_tit_ctbl**: des_tit_ctbl

---

## Tabela: item_destinac_cobr
**Label**: Perc N�vel Cobr
**Descrição**: Valor Percentual N�vel Cobranca

### Chave Primária
- cod_empresa, num_seq_destinac_cobr, cod_destinac_cobr, num_ord_destinac, cod_portador, cod_cart_bcia

### Índices
- **itmdstnc_portad**: cod_portador, cod_cart_bcia

---

## Tabela: item_distrib_ccusto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_mapa_distrib_ccusto, cod_unid_negoc, cod_plano_ccusto, cod_ccusto

### Índices
- **itmdstra_ccusto**: cod_empresa, cod_plano_ccusto, cod_ccusto
- **itmdstra_unid_negoc**: cod_unid_negoc

---

## Tabela: item_distrib_gerc_ctbl
**Label**: Percentual
**Descrição**: Valor Percentual Crit�rio Distribui��o

### Chave Primária
- cod_unid_organ_orig, cod_plano_cta_ctbl_orig, cod_mapa_distrib_gerc_ctbl, cod_cta_ctbl_orig, num_seq_distrib_gerc_ctbl

### Índices
- **itmdstrb_cta_ctbl_dest**: cod_plano_cta_ctbl_dest, cod_cta_ctbl_dest
- **itmdstrb_cta_ctbl_orig**: cod_plano_cta_ctbl_orig, cod_cta_ctbl_orig
- **itmdstrb_estabelecimento**: cod_estab

---

## Tabela: item_docto_entr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_empresa, cdn_fornecedor, cod_docto_entr, cod_ser_nota, num_item_docto_entr, cod_natur_operac

### Índices
- **tmdctntr_classif**: log_classif_item_docto_entr, cod_estab, cod_empresa
- **tmdctntr_indic_econ**: cod_indic_econ
- **tmdctntr_marca**: cod_marca
- **tmdctntr_modelo**: cod_espec_bem, cod_marca, cod_modelo

---

## Tabela: item_docto_estoq_esoc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdd_num_docto_esoc, num_seq_item

### Índices

---

## Tabela: item_grp_exc_cta_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_plano_ccusto, cod_ccusto, cod_plano_cta_ctbl, cod_cta_ctbl_inic, cod_cta_ctbl_fim

### Índices
- **itmgrpxc_ccusto**: cod_empresa, cod_ccusto, cod_plano_ccusto
- **itmgrpxc_conta**: cod_empresa, cod_cta_ctbl_inic, cod_plano_cta_ctbl

---

## Tabela: item_grp_segur_det_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_estab, cod_plano_ccusto, cod_ccusto, cod_plano_cta_ctbl, cod_cta_ctbl, cod_usuar

### Índices

---

## Tabela: item_histor_ranking_bcio
**Label**: Nota Banco Ranking
**Descrição**: Valor Nota Banco Ranking Bancario

### Chave Primária
- cod_regra_ranking_bcio, dat_ranking_bcio, num_seq, num_pos_bco_ranking_bcio

### Índices

---

## Tabela: item_integr_ctbl_ext
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_integr_ctbl_ext, num_seq_integr_ctbl_ext, ind_tip_layout_integr_ctbl

### Índices
- **itmntgrc_contdo**: cod_layout_integr_ctbl_ext, cod_contdo_integr_ctbl_ext, ind_tip_layout_integr_ctbl, num_seq_integr_ctbl_ext

---

## Tabela: item_lancto_ctbl
**Label**: Entry Number
**Descrição**: Seq. Entry Number

### Chave Primária
- num_lote_ctbl, num_lancto_ctbl, num_seq_lancto_ctbl

### Índices
- **tmlnctcb_ccusto**: cod_empresa, cod_plano_ccusto, cod_ccusto
- **tmlnctcb_cta_ctbl**: cod_plano_cta_ctbl, cod_cta_ctbl
- **tmlnctcb_data_lancto**: cod_empresa, dat_lancto_ctbl
- **tmlnctcb_entry_number**: val_seq_entry_number
- **tmlnctcb_espec_docto**: cod_espec_docto
- **tmlnctcb_estab**: cod_estab, cod_plano_cta_ctbl, cod_cta_ctbl, ind_sit_lancto_ctbl, dat_lancto_ctbl
- **tmlnctcb_histor_padr**: cod_histor_padr
- **tmlnctcb_imagem**: cod_imagem
- **tmlnctcb_indic_econ**: cod_indic_econ
- **tmlnctcb_movto_ctbl**: cod_empresa, cod_plano_cta_ctbl, cod_cta_ctbl, cod_plano_ccusto, cod_ccusto, cod_estab, cod_unid_negoc, cod_proj_financ, dat_lancto_ctbl
- **tmlnctcb_pessoa**: cod_empresa
- **tmlnctcb_proj_financ**: cod_proj_financ
- **tmlnctcb_tplnctct**: cod_tip_lancto_ctbl
- **tmlnctcb_unid_negoc**: cod_unid_negoc
- **tmlnctcb_valor**: cod_empresa, val_lancto_ctbl

---

## Tabela: item_lancto_ctbl_padr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_lancto_ctbl_padr, num_seq_lancto_ctbl_padr

### Índices
- **itmlnctc_ccusto**: cod_empresa, cod_plano_ccusto, cod_ccusto
- **itmlnctc_cta_ctbl**: cod_plano_cta_ctbl, cod_cta_ctbl
- **itmlnctc_espec_docto**: cod_espec_docto
- **itmlnctc_estab**: cod_estab
- **itmlnctc_histor_padr**: cod_histor_padr
- **itmlnctc_imagem**: cod_imagem
- **itmlnctc_prjfnnc**: cod_proj_financ
- **itmlnctc_tplnctct**: cod_tip_lancto_ctbl
- **itmlnctc_unid_negoc**: cod_unid_negoc

---

## Tabela: item_layout_trans
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_trans, num_seq_tip_reg_layout, cod_campo

### Índices
- **itmlyttr_campo** (Unique): cod_layout_trans, cod_campo

---

## Tabela: item_liquidac_vendor
**Label**: Saldo T�tulo
**Descrição**: Valor Saldo Contas a Receber

### Chave Primária
- cod_estab_refer, cod_refer_liquidac, num_seq_refer

### Índices
- **itmlqdcv_parc_vdrf**: cod_estab_parc_vendor, num_id_parc_vendor

---

## Tabela: item_lista_ccusto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_mapa_distrib_ccusto, cod_empresa, cod_plano_ccusto, cod_ccusto

### Índices
- **itmlstcc_ccusto**: cod_empresa, cod_plano_ccusto, cod_ccusto

---

## Tabela: item_lote_impl_ap
**Label**: Valor T�tulo
**Descrição**: Valor T�tulo Contas a Pagar

### Chave Primária
- cod_estab, cod_refer, num_seq_refer

### Índices
- **itmltmpl_apol_segur**: cod_seguradora, cod_apol_seguro
- **itmltmpl_contrat_leas**: cod_arrendador, cod_contrat_leas
- **itmltmpl_estab_tit**: cod_estab_tit_ap, cod_refer
- **itmltmpl_fornec_financ**: cod_empresa, cdn_fornecedor
- **itmltmpl_histor_padr**: cod_histor_padr
- **itmltmpl_pagto_padr**: cod_empresa, cod_pagto_padr
- **itmltmpl_pagto_provis_repet**: cod_empresa, cod_pagto_provis_repet
- **itmltmpl_pesso_tit**: num_pessoa, cod_espec_docto, cod_ser_docto, cod_tit_ap, cod_parcela
- **itmltmpl_portad_estab**: cod_estab, cod_portador

---

## Tabela: item_lote_impl_tit_acr
**Label**: Valor
**Descrição**: Valor T�tulo

### Chave Primária
- cod_estab, cod_refer, num_seq_refer

### Índices
- **itmltmpa_clien_financ**: cod_empresa, cdn_cliente
- **itmltmpa_espcdctf**: cod_espec_docto
- **itmltmpa_mtvmvttt**: cod_estab, cod_motiv_movto_tit_acr
- **itmltmpa_renegoc**: cod_estab, num_renegoc_cobr_acr
- **itmltmpa_srfscnt**: cod_ser_docto
- **itmltmpa_titulo**: cod_estab, cod_espec_docto, cod_ser_docto, cod_tit_acr, cod_parcela

---

## Tabela: item_lote_liquidac_acr
**Label**: Valor PIS
**Descrição**: Valor do PIS retido na liquida��o

### Chave Primária
- cod_estab_refer, cod_refer, num_seq_refer

### Índices
- **itmltlqd_agrup_cheq**: cod_estab_refer, num_agrup_cheq_acr
- **itmltlqd_tit_acr**: cod_estab, cod_espec_docto, cod_ser_docto, cod_tit_acr, cod_parcela

---

## Tabela: item_lote_mktplace
**Label**: Saldo T�tulo
**Descrição**: Valor Saldo Contas a Receber

### Chave Primária
- cod_empresa, num_lote_mktplace, num_seq_lote_mktplace

### Índices
- **itmltmkt_movto**: num_movto_mktplace
- **itmltmkt_movto_cmg**: num_id_movto_cta_corren
- **itmltmkt_movto_lot**: cod_empresa, num_lote_mktplace, num_movto_mktplace
- **itmltmkt_ped_vda**: cod_ped_vda
- **itmltmkt_refer_liq**: cod_estab, num_id_tit_acr, cod_refer_liquidac
- **itmltmkt_ref_avmn**: cod_estab, num_id_tit_acr, cod_refer_val_menor_comis
- **itmltmkt_tit_movto**: cod_empresa, num_lote_mktplace, cod_estab, num_id_tit_acr, num_movto_mktplace

---

## Tabela: item_lote_pagto
**Label**: Vl Varic Cambial
**Descrição**: Valor da Varia��o Cambial

### Chave Primária
- cod_estab_refer, cod_refer, num_seq_refer

### Índices
- **itmltpgt_antecip_pef_pend**: cod_estab, cod_refer_antecip_pef
- **itmltpgt_portad_finalid_econ**: cod_estab_refer, cod_portador, cod_cart_bcia, cod_finalid_econ, num_talon_cheq, num_cheque
- **itmltpgt_tit_ap**: cod_estab, cod_espec_docto, cod_ser_docto, cdn_fornecedor, cod_tit_ap, cod_parcela

---

## Tabela: item_lote_tpi
**Label**: Saldo T�tulo
**Descrição**: Valor Saldo T�tulo

### Chave Primária
- cod_empresa, num_lote_tpi, num_seq_lote_tpi

### Índices
- **it_lot_tpi_sit**: cod_empresa, num_lote_tpi, cod_estab, ind_sit_item_lote_tpi

---

## Tabela: item_mapa_movto_bem_pat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_mapa_movto, num_item_mapa_movto

### Índices

---

## Tabela: item_mapa_movto_pat_orig
**Label**: Percentual Movimento
**Descrição**: Valor Percentual Movimento Bem Patrimonial

### Chave Primária
- cod_empresa, cod_mapa_movto, num_item_mapa_movto, ind_orig_dest, num_sub_item_mapa_movto

### Índices

---

## Tabela: item_movto_destinac_cobr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, dat_movto_destinac_cobr, hra_movto_destinac_cobr, cod_portador, cod_cart_bcia

### Índices
- **itmmvtds_estab**: cod_estab, cod_portador, cod_cart_bcia
- **itmmvtds_portad**: cod_finalid_econ, cod_portador, cod_cart_bcia

---

## Tabela: item_movto_orcto
**Label**: Valor Mov Orctaria
**Descrição**: Valor Movimento Orcamento

### Chave Primária
- num_seq_movto_orcto, num_tip_item_movto_orcto, cod_cenar_ctbl, cod_exerc_ctbl, num_period_ctbl, cod_empresa, cod_plano_cta_ctbl, cod_cta_ctbl, cod_plano_ccusto, cod_ccusto, cod_estab, cod_unid_negoc, cod_proj_financ

### Índices
- **itmmvtrc_ccusto**: cod_empresa, cod_plano_ccusto, cod_ccusto
- **itmmvtrc_cta_ctbl**: cod_plano_cta_ctbl, cod_cta_ctbl
- **itmmvtrc_period_ctbl**: cod_cenar_ctbl, cod_exerc_ctbl, num_period_ctbl

---

## Tabela: item_operac_techfin
**Label**: Taxa Supplier
**Descrição**: valor taxa Supplier

### Chave Primária
- cod_estab_operac, cod_movto_operac_financ, cod_estab, cod_espec_docto, cod_ser_docto, cod_tit_acr, cod_parcela

### Índices
- **itmprctc_ix2**: cod_estab, cod_espec_docto, cod_ser_docto, cod_tit_acr, cod_parcela

---

## Tabela: item_orcto_ctbl
**Label**: Valor Or�ado
**Descrição**: Valor Or�ado

### Chave Primária
- cod_unid_organ, cod_usuario, dat_gerac_movto, hra_gerac_movto, num_period_ctbl, cod_cta_ctbl, cod_plano_ccusto, cod_ccusto

### Índices
- **itmrctct_cta_ctbl**: cod_plano_cta_ctbl, cod_cta_ctbl
- **itmrctct_period_ctbl**: cod_cenar_ctbl, cod_exerc_ctbl, num_period_ctbl

---

## Tabela: item_orcto_fluxo
**Label**: Valor Or�ado
**Descrição**: Valor Or�ado

### Chave Primária
- num_id_item_orcto_fluxo

### Índices
- **itmrctfl_prmrctfl**: num_id_param_orcto_fluxo

---

## Tabela: item_pagto_online
**Label**: Valor Transac Bco
**Descrição**: Valor Transa��o Banco

### Chave Primária
- cod_estab_bord, cod_portador, num_bord_ap, num_seq_bord, num_seq_pagto_online

### Índices
- **itmpgtnl_bco_identif_pagto**: cod_banco, cod_identif_pagto_bco
- **itmpgtnl_bco_sit_pagto**: cod_banco, cod_sit_pagto_online
- **itmpgtnl_lote_pagto_bco**: num_lote_pagto_bco

---

## Tabela: item_pcte
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_pcte_cta_ctbl, cod_plano_cta_ctbl, cod_cta_ctbl

### Índices
- **itempcte_conta**: cod_plano_cta_ctbl, cod_cta_ctbl

---

## Tabela: item_pend_tpi
**Label**: Perc Jur Dia Atraso
**Descrição**: Percentual Juros Dia Atraso

### Chave Primária
- cod_empresa, cod_usuario, num_seq, cod_estab_tit, num_id_tit_acr

### Índices

---

## Tabela: item_planilha_orctaria
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_planilha_orcto, num_inform_orcto

### Índices

---

## Tabela: item_rat_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_rat_ctbl, num_seq_rat_ctbl

### Índices
- **itmrtctb_hstrpdr**: cod_histor_padr
- **itmrtctb_tplnctct**: cod_tip_lancto_ctbl

---

## Tabela: item_regra_ranking_bcio
**Label**: Peso Item
**Descrição**: Valor Peso Item Regra Ranking

### Chave Primária
- cod_regra_ranking_bcio, num_seq_item_regra_ranking

### Índices

---

## Tabela: item_renegoc_acr
**Label**: Valor Multa
**Descrição**: Valor Multa Renegociacao Titulo Accounts Receivable

### Chave Primária
- cod_estab, num_renegoc_cobr_acr, num_seq_item_renegoc_acr

### Índices
- **itmrngcc_tit_acr**: cod_estab_tit_acr, num_id_tit_acr

---

## Tabela: item_renegoc_inadimp
**Label**: Saldo T�tulo
**Descrição**: Valor Saldo Contas a Receber

### Chave Primária
- cod_refer, num_seq_item_renegoc

### Índices
- **itmrngcn_itmgndnd**: cod_estab, cod_espec_docto, cod_ser_docto, cod_tit_acr, cod_parcela

---

## Tabela: item_renegoc_terc
**Label**: Valor T�tulo Atual
**Descrição**: Valor T�tulo Atual

### Chave Primária
- cod_estab, num_renegoc_terc, num_seq

### Índices
- **itmrngct_data_vencto**: cod_estab, num_renegoc_terc, ind_tip_item_renegoc_terc, dat_vencto_tit_atual
- **itmrngct_ind_tip_sit**: cod_estab, num_renegoc_terc, ind_tip_item_renegoc_terc, ind_sit_item_renegoc_terc
- **itmrngct_item_lote**: cod_estab, cod_refer, num_seq_refer_item_lote
- **itmrngct_tit_acr**: cod_estab_tit_acr, num_id_tit_acr

---

## Tabela: item_reserva_solicit
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, num_id_ped_reserve, num_id_reserva, num_id_item_reserva

### Índices

---

## Tabela: item_simul_operac_financ
**Label**: Taxa Pr�-Fixada
**Descrição**: Valor Taxa Juros Pre Fixada

### Chave Primária
- cod_simul_operac_financ, num_seq

### Índices

---

## Tabela: item_tab_prgssiv_impto
**Label**: Valor M�nimo Imposto
**Descrição**: Valor M�nimo Imposto

### Chave Primária
- cod_tab_prgssiv_impto_retid, num_seq_valid_tab_prgssiv, num_faixa_impto_retid

### Índices

---

## Tabela: jurisd_isencao_clien
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_jurisd_sales_tax, cod_empresa, cdn_cliente, num_seq

### Índices
- **jrsdsncc_validade**: cod_jurisd_sales_tax, cod_empresa, cdn_cliente, dat_inic_valid

---

## Tabela: jurisd_sales_tax
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_jurisd_sales_tax

### Índices
- **jrsdslst_jurisd_pai**: cod_jurisd_pai

---

## Tabela: jurisd_sales_tax_empres
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_jurisd_sales_tax, cod_empresa, num_seq

### Índices
- **jrsdslsa_validade**: cod_jurisd_sales_tax, cod_empresa, dat_inic_valid

---

## Tabela: justif_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cenar_orctario, cod_unid_orctaria, num_seq_orcto_ctbl, cod_vers_orcto_ctbl, cod_cenar_ctbl, cod_exerc_ctbl, num_period_ctbl, cod_plano_cta_ctbl, cod_cta_ctbl, cod_plano_ccusto, cod_ccusto, cod_regra, ind_tip_justif_orcto

### Índices
- **jstfrct_histor**: cod_justif, cod_exerc_ctbl, num_period_ctbl

---

## Tabela: lancto_atoadm_shc
**Label**: Percent Contabil
**Descrição**: Valor Percentual Contabiliza��o Controle Acion�rio

### Chave Primária
- cod_empresa, ind_movto_acaocap, cod_orig_acaocap, cod_cta_ctbl, dat_atoadm_shc, ind_empres_incorpda_shc

### Índices
- **lncttdms_atdmshc**: cod_empresa, dat_atoadm_shc
- **lncttdms_orgccp**: cod_orig_acaocap

---

## Tabela: lancto_concil_cartao_cr
**Label**: Valor Total Venda
**Descrição**: Valor Total Venda

### Chave Primária
- num_id_lancto_cartao_cr

### Índices
- **ilnctcnca_dat_sit**: dat_lancto, ind_sit_lancto_cartao_cr, ind_diverg_lancto_cartao_cr, ind_tip_lancto_cartao_cr
- **inctcnca_admdra**: cod_admdra_cartao_cr, cod_band, ind_sit_lancto_cartao_cr, ind_diverg_lancto_cartao_cr, ind_tip_lancto_cartao_cr, dat_lancto
- **inctcnca_admdra_band**: cod_admdra_cartao_cr, cod_band, ind_tip_lancto_cartao_cr, ind_sit_lancto_cartao_cr, ind_diverg_lancto_cartao_cr, dat_lancto
- **inctcnca_dat_div**: dat_lancto, ind_diverg_lancto_cartao_cr, ind_sit_lancto_cartao_cr, ind_tip_lancto_cartao_cr
- **inctcnca_dat_tip**: dat_lancto, ind_tip_lancto_cartao_cr, ind_sit_lancto_cartao_cr, ind_diverg_lancto_cartao_cr
- **inctcnca_diverg_lancto**: num_id_concil_cartao_cr, ind_diverg_lancto_cartao_cr, ind_sit_lancto_cartao_cr, ind_tip_lancto_cartao_cr
- **inctcnca_sit_lan**: ind_sit_lancto_cartao_cr, dat_lancto, ind_diverg_lancto_cartao_cr, ind_tip_lancto_cartao_cr, cod_admdra_cartao_cr, cod_band
- **lancto_concil_cartao_cr**: cod_estab, cod_refer_liquidac_proces
- **lnctcnca_empres_nsu**: cod_empresa, cod_nsu, cod_autoriz, cod_comprov
- **lnctcnca_estab_dat_tip**: cod_estab, dat_lancto, ind_tip_lancto_cartao_cr, ind_sit_lancto_cartao_cr
- **lnctcnca_estab_id_tit**: cod_estab, num_id_tit_acr
- **lnctcnca_estab_oper_nsu**: num_id_concil_cartao_cr, cod_estab_operdra, cod_nsu, cod_autoriz, cod_comprov
- **lnctcnca_estab_refer_an**: cod_estab, cod_refer_antecip_proces
- **lnctcnca_nsu**: num_id_concil_cartao_cr, cod_nsu, cod_autoriz, cod_comprov
- **lnctcnca_ped**: num_ped_exec
- **lnctcnca_refer_alter**: cod_estab, cod_refer_alter_proces
- **lnctcnca_ro**: num_id_concil_cartao_cr, cod_resum
- **lnctcnca_sit_lancto**: num_id_concil_cartao_cr, ind_sit_lancto_cartao_cr, ind_diverg_lancto_cartao_cr, ind_tip_lancto_cartao_cr
- **lnctcnca_tip_lancto**: num_id_concil_cartao_cr, ind_tip_lancto_cartao_cr, ind_sit_lancto_cartao_cr, ind_diverg_lancto_cartao_cr
- **lnctcnca_tip_nsu_dat**: ind_tip_lancto_cartao_cr, cod_nsu, dat_vda, cod_admdra_cartao_cr, cod_band, cod_autoriz, num_parcela
- **lnctcnca_tit_acr_lancto**: num_id_concil_cartao_cr, cod_estab, cod_espec_docto, cod_tit_acr
- **nctcnca_diverg_dat**: ind_diverg_lancto_cartao_cr, dat_lancto, ind_sit_lancto_cartao_cr, ind_tip_lancto_cartao_cr, cod_admdra_cartao_cr, cod_band

---

## Tabela: lancto_concil_mais_negoc
**Label**: Valor Taxa Estorno
**Descrição**: Valor Taxa Estorno

### Chave Primária
- cod_empresa, cod_id_concil, cod_id_cta_concil, cod_id_lancto_concil

### Índices
- **lnctcncl_cta_bco**: num_id_movto_cta_bco
- **lnctcncl_cta_control**: num_id_movto_cta_control
- **lnctcncl_modalid**: cod_empresa, ind_tip_modalid
- **lnctcncl_status**: cod_empresa, ind_status_lancto, cod_tip_event_lancto

---

## Tabela: lancto_concil_tpi
**Label**: Valor Transa��o TPI
**Descrição**: Valor Transa��o TPI

### Chave Primária
- cod_empresa, dat_concil, ind_tip_concil, cod_trans_tpi

### Índices
- **lnctcncb_conc**: cod_empresa, log_conciliado
- **lnctcncb_lt**: cod_empresa, num_lote_tpi
- **lnctcncb_tr**: cod_empresa, cod_trans_tpi, log_conciliado

---

## Tabela: lancto_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_lote_ctbl, num_lancto_ctbl

### Índices
- **lnctctb_cenar_ctbl**: cod_cenar_ctbl
- **lnctctb_ctbz**: num_lote_ctbl, ind_sit_lancto_ctbl, num_lancto_ctbl
- **lnctctb_hstrpdr**: cod_histor_padr_estorn
- **lnctctb_lancto_padr**: cod_empresa, cod_lancto_ctbl_padr
- **lnctctb_orig_cop**: num_lote_ctbl_orig_cop, num_lancto_ctbl_orig_cop
- **lnctctb_rat_ctbl**: cod_empresa, cod_rat_ctbl
- **lnctctb_sdo_batch**: cod_empresa, log_sdo_batch_atlzdo, dat_lancto_ctbl
- **lnctctb_situacao**: cod_empresa, ind_sit_lancto_ctbl, num_lote_ctbl, num_lancto_ctbl
- **lnctctb_sit_data**: ind_sit_lancto_ctbl, cod_empresa, dat_lancto_ctbl

---

## Tabela: lancto_ctbl_padr
**Label**: Valor Total
**Descrição**: Valor Total Lan�amento Cont�bil Padr�o

### Chave Primária
- cod_empresa, cod_lancto_ctbl_padr

### Índices
- **lnctctbl_cenar_ctbl**: cod_cenar_ctbl
- **lnctctbl_indic_econ**: cod_indic_econ

---

## Tabela: lancto_padr_empres_shc
**Label**: Percent Contabil
**Descrição**: Valor Percentual Contabiliza��o Controle Acion�rio

### Chave Primária
- cod_empresa, ind_movto_acaocap, cod_orig_acaocap, cod_cta_ctbl, ind_empres_incorpda_shc

### Índices
- **lnctpdrm_orgccp**: cod_orig_acaocap

---

## Tabela: lancto_tit_acr_cobr_esp
**Label**: Valor Saldo T�tulo
**Descrição**: Valor Saldo T�tulo

### Chave Primária
- num_id_lancto_cartao_cr, cod_estab, num_id_tit_acr, num_seq_tit_acr

### Índices
- **lnctttcr_ens**: cod_estab, num_id_tit_acr, num_seq_tit_acr
- **lnctttcr_refer_alter**: cod_estab, cod_refer_alter_proces
- **lnctttcr_refer_antecip**: cod_estab, cod_refer_antecip_proces
- **lnctttcr_refer_liquidac**: cod_estab, cod_refer_liquidac_proces

---

## Tabela: lastro_produt_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_lastro_financ

### Índices

---

## Tabela: layout
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout

### Índices
- **layout_tipo**: ind_tip_layout

---

## Tabela: layout_admdra_cartao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_admdra_cartao

### Índices

---

## Tabela: layout_aviso_db
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_aviso_db

### Índices

---

## Tabela: layout_boleto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_boleto

### Índices

---

## Tabela: layout_ccusto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_ccusto

### Índices

---

## Tabela: layout_cheq
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_cheq

### Índices

---

## Tabela: layout_col_fluxo_cx
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_col_fluxo_cx

### Índices

---

## Tabela: layout_conces_telef
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_conces_telef

### Índices

---

## Tabela: layout_cta_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_cta_ctbl

### Índices

---

## Tabela: layout_dupl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_dupl

### Índices

---

## Tabela: layout_extrat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_extrat

### Índices

---

## Tabela: layout_fisc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_fisc

### Índices

---

## Tabela: layout_integr_ctbl_ext
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_integr_ctbl_ext

### Índices

---

## Tabela: layout_invent
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_invent

### Índices

---

## Tabela: layout_mapa_distrib
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_mapa_distrib

### Índices

---

## Tabela: layout_movto_cta_corren
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_movto_cta_corren

### Índices

---

## Tabela: layout_movto_fluxo_cx
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_movto_fluxo_cx

### Índices

---

## Tabela: layout_orcto_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_orcto_ctbl

### Índices

---

## Tabela: layout_planilha_orctaria
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_planilha_orcto

### Índices

---

## Tabela: layout_planilha_vendor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_id_conven_vendor, num_seq

### Índices
- **lytplnla_msg**: cod_mensagem

---

## Tabela: layout_trans
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_trans

### Índices

---

## Tabela: lcdpr_cparte_imov
**Label**: % CParte
**Descrição**: % Contraparte

### Chave Primária
- num_seq_imov, cod_estab, cod_cpf_cparte, ind_tip_cparte

### Índices

---

## Tabela: lcdpr_cta_corren_imov
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq_imov, cod_estab, num_seq_cta_corren

### Índices

---

## Tabela: lcdpr_imov_rural
**Label**: % Participa��o
**Descrição**: Velor Percentual Participa��o

### Chave Primária
- num_seq_imov, cod_estab

### Índices
- **lcdprmvr_prod_rural**: num_produt_rural

---

## Tabela: licenc_uso
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_espec_bem, cod_modelo, cod_marca, cod_licenc_uso

### Índices
- **lcncs_marca**: cod_marca

---

## Tabela: lim_justif
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_exerc_ctbl, num_period_ctbl, cod_niv_usuar

### Índices

---

## Tabela: lin_extrat_cta_corren
**Label**: Pendente Conciliacao
**Descrição**: Valor Pendente Conciliacao Conta Corrente

### Chave Primária
- cod_cta_corren, num_extrat_cta_corren, dat_movto_cta_corren, num_seq_extrat_cta_corren

### Índices
- **lnxtrtct_cta_data**: cod_cta_corren, log_concil_cta_corren, ind_fluxo_movto_cta_corren, dat_movto_cta_corren
- **lnxtrtct_data**: cod_cta_corren, dat_movto_cta_corren
- **lnxtrtct_docto**: cod_cta_corren, log_concil_cta_corren, ind_fluxo_movto_cta_corren, cod_docto_movto_cta_bco, dat_movto_cta_corren
- **lnxtrtct_token** (Unique): num_id_lin_extrat_cta

---

## Tabela: lin_layout_admdra_cartao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_admdra_cartao, num_seq_lin_layout_admdra

### Índices
- **lnlytdmd_contdo** (Unique): cod_layout_admdra_cartao, ind_contdo_lin_admdra

---

## Tabela: lin_layout_boleto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_boleto, ind_campo_layout_boleto

### Índices

---

## Tabela: lin_layout_ccusto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_ccusto, num_seq_layout_ccusto

### Índices

---

## Tabela: lin_layout_cheq
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_cheq, ind_campo_layout_cheq

### Índices
- **lnlytchq_emissao**: cod_layout_cheq, num_lin_inic, num_pos_campo_layout_cheq

---

## Tabela: lin_layout_conces_telef
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_conces_telef, num_seq_lin_layout_conces

### Índices
- **lnlytcnc_contdo** (Unique): cod_layout_conces_telef, ind_contdo_lin_conces

---

## Tabela: lin_layout_cta_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_cta_ctbl, num_seq_layout_cta_ctbl

### Índices

---

## Tabela: lin_layout_dupl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_dupl, ind_campo_layout_dupl

### Índices

---

## Tabela: lin_layout_invent
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_invent, num_seq_layout_invent

### Índices
- **lnlytnvn_campo** (Unique): cod_layout_invent, des_campo_layout_invent

---

## Tabela: lin_layout_mapa_distrib
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_mapa_distrib, num_seq_layout_mapa_distrib

### Índices

---

## Tabela: lin_layout_movto_cta
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_movto_cta_corren, num_seq_lin_layout_movto

### Índices
- **lnlytmvt_contdo** (Unique): cod_layout_movto_cta_corren, ind_contdo_layout_movto_cta

---

## Tabela: lin_layout_movto_fluxo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_movto_fluxo_cx, num_seq_lin_layout_movto

### Índices

---

## Tabela: lin_layout_orcto_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_orcto_ctbl, num_seq_layout_orcto_ctbl

### Índices

---

## Tabela: lista_aces_demonst
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_demonst_ctbl_public, cod_grp_usuar, cod_usuario

### Índices

---

## Tabela: lista_invent_bem_pat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- dat_invent_bem_pat, cod_empresa, cb3_ident_visual

### Índices
- **lstnvntb_bempat**: num_id_bem_pat
- **lstnvntb_ccusto**: cod_empresa, cod_plano_ccusto, cod_ccusto
- **lstnvntb_lclzc**: cod_estab, cod_localiz
- **lstnvntb_ndngc**: cod_unid_negoc

---

## Tabela: lista_trab_invent
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq_lista_trab_invent

### Índices
- **lsttrbnv_aloc_bem**: num_id_bem_pat, cod_empresa, cod_plano_ccusto, cod_ccusto, cod_unid_negoc

---

## Tabela: livro_fisc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_organ, cod_modul_dtsul, ind_tip_livro_fisc

### Índices
- **lvrfsca_modul**: cod_modul_dtsul

---

## Tabela: livro_fisc_movto_tit_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_modul_dtsul, ind_tip_livro_fisc, num_id_movto_tit_acr, num_id_aprop_ctbl_acr

### Índices
- **lvrfscmv_aprpctbd**: cod_estab, num_id_aprop_ctbl_acr
- **lvrfscmv_lvrfsca**: cod_unid_organ, cod_modul_dtsul, ind_tip_livro_fisc, dat_inic_emis
- **lvrfscmv_mvtttcr**: cod_estab, num_id_movto_tit_acr

---

## Tabela: local_embarq_viagem_eec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_local_embarq_viagem_eec

### Índices

---

## Tabela: localid_conces
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_ddd_localid_conces, num_prefix_localid_conces, num_milhar_inicial, num_milhar_final

### Índices
- **lcldcncs_conces**: cod_conces_telef
- **lcldcncs_localid**: cdn_localid_telebras

---

## Tabela: localid_telebras
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_localid_telebras

### Índices

---

## Tabela: localiz_arq_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_parcei_edi, cdn_trans_edi, ind_finalid_localiz_arq_edi

### Índices

---

## Tabela: localiz_lancto_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_lote_ctbl, num_lancto_ctbl, num_maq_envio

### Índices
- **lclzlnct_dest**: num_lote_ctbl_localiz, num_lancto_ctbl_localiz, num_maq_dest

---

## Tabela: localizacao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_localiz

### Índices
- **lclzc_imagem**: cod_imagem
- **lclzc_localiz_sup**: cod_estab, cod_localiz_sup

---

## Tabela: log_bco_histor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, num_seq

### Índices

---

## Tabela: log_bco_histor_movto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, num_seq, num_seq_movto

### Índices

---

## Tabela: log_msg_envda_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq, cod_id_msg

### Índices
- **lgmsgnvd_dat_hra**: dat_recbdo, hra_recbdo
- **lgmsgnvd_msgnvdd**: cod_id_msg

---

## Tabela: lote_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_lote_ctbl

### Índices
- **ltctbla_dat_atz**: dat_ult_atualiz, hra_ult_atualiz
- **ltctbla_modul_dtsul**: cod_modul_dtsul
- **ltctbla_sit_dat_lote**: cod_empresa, ind_sit_lote_ctbl, dat_lote_ctbl
- **ltctbla_sit_des_lote**: cod_empresa, ind_sit_lote_ctbl, des_lote_ctbl
- **ltctbla_sit_num_lote**: cod_empresa, ind_sit_lote_ctbl, num_lote_ctbl

---

## Tabela: lote_ctbl_plant
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_lote_ctbl, cod_servid_rpc

### Índices
- **ltctblpl_plant**: num_lote_ctbl_plant

---

## Tabela: lote_impl_tit_acr
**Label**: Total Informado
**Descrição**: Valor Total do Lote j� Informado na Implanta��o de T�tulos

### Chave Primária
- cod_estab, cod_refer

### Índices
- **ltmplttc_empresa_tip_espec**: cod_empresa, ind_tip_espec_docto
- **ltmplttc_espec_docto**: cod_espec_docto

---

## Tabela: lote_impl_tit_ap
**Label**: Total Informado
**Descrição**: Total Lote Informado T�tulo Contas a Pagar

### Chave Primária
- cod_estab, cod_refer

### Índices
- **ltmplttp_empresa_tip_espec**: cod_empresa, ind_tip_espec_docto
- **ltmplttp_fatura**: cod_estab, cdn_fornecedor, num_fatur_ap

---

## Tabela: lote_liquidac_acr
**Label**: Total Informado
**Descrição**: Valor Total do Lote de Liquida��o Informado

### Chave Primária
- cod_estab_refer, cod_refer

### Índices

---

## Tabela: lote_liquidac_vendor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab_refer, cod_refer_liquidac

### Índices

---

## Tabela: lote_mktplace
**Label**: Total Repasse Bruto
**Descrição**: Total Repasse Bruto

### Chave Primária
- cod_empresa, num_lote_mktplace

### Índices
- **ltmktplc_emp_dt_tran**: cod_empresa, dat_transacao
- **ltmktplc_est_dt_tran**: cod_estab, dat_transacao
- **ltmktplc_est_ref_ant**: cod_estab, cod_refer_antecip_apb
- **ltmktplc_est_ref_liq**: cod_estab, cod_refer_liquidac
- **ltmktplc_mktp_dt_tr**: cod_empresa, cdn_mktplace, dat_transacao

---

## Tabela: lote_orcto_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_organ, cod_usuario, dat_gerac_movto, hra_gerac_movto

### Índices
- **ltrctctb_ccusto**: cod_unid_organ, cod_plano_ccusto, cod_ccusto
- **ltrctctb_estab**: cod_estab
- **ltrctctb_finalid_econ**: cod_finalid_econ
- **ltrctctb_sit_ccusto**: ind_sit_lote_orcto_ctbl, cod_unid_organ, cod_plano_ccusto, cod_ccusto
- **ltrctctb_sit_dat**: ind_sit_lote_orcto_ctbl, cod_unid_organ, cod_usuario, dat_gerac_movto, hra_gerac_movto
- **ltrctctb_unid_negoc**: cod_unid_negoc
- **ltrctctb_vers_orcto_ctbl**: cod_unid_organ, cod_cenar_orctario, cod_cenar_ctbl, cod_exerc_ctbl, cod_vers_orcto_ctbl

---

## Tabela: lote_pagto
**Label**: Total Informado
**Descrição**: Total Pagamento J� Informado

### Chave Primária
- cod_estab_refer, cod_refer

### Índices
- **ltpgt_cliente**: cod_empresa, cdn_cliente
- **ltpgt_frncdr**: cod_empresa, cdn_fornecedor
- **ltpgt_ndccn**: cod_indic_econ
- **ltpgt_usuar_pagto**: cod_usuar_pagto

---

## Tabela: lote_pend_tpi
**Label**: Livre 2
**Descrição**: Valor Livre 2

### Chave Primária
- cod_empresa, cod_usuario, num_seq, ind_sit_proces

### Índices
- **ltpndtp_sit**: cod_empresa, ind_sit_proces

---

## Tabela: lote_techfin_process
**Label**: Saldo Lote
**Descrição**: Valor de Saldo do Lote

### Chave Primária
- cod_empresa, num_id_lote

### Índices
- **lttchfnp_dt**: cod_empresa, dat_lancto
- **lttchfnp_dtprc**: cod_empresa, dat_lancto, num_operac

---

## Tabela: lote_tpi
**Label**: Total Lote TPI
**Descrição**: Valor Total do Lote Cobran�a TPI

### Chave Primária
- cod_empresa, num_lote_tpi

### Índices
- **ltpi_emp_dt_tran**: cod_empresa, dat_transacao
- **ltpi_est_dt_tran**: cod_estab, dat_transacao
- **ltpi_est_ref_liq**: cod_estab, cod_refer_liquidac
- **ltpi_modalid**: cod_empresa, cod_estab, dat_transacao, ind_modalid_techfin
- **ltpi_st**: cod_empresa, ind_status_lote_tpi

---

## Tabela: manual_documen
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_manual_documen

### Índices
- **mnldcmn_espec**: num_espec_manual

---

## Tabela: manual_documen_idiom
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_manual_documen, cod_idioma

### Índices
- **mnldcmnd_nom**: nom_tit_manual_documen

---

## Tabela: manual_topic_estil
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_manual_documen, num_topic_pai, num_seq

### Índices
- **mnltpcst_id** (Unique): num_topico, num_manual_documen, num_topic_pai, num_manual_documen_dest
- **mnltpcst_mnltpcst**: num_manual_documen_dest
- **mnltpcst_tpcdm**: num_topic_pai

---

## Tabela: manual_topic_estil_idiom
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_manual_documen, num_topico, cod_idioma, num_seq

### Índices
- **mnltpcsa_stlcmpnd**: num_estilo
- **mnltpcsa_tpccmpnd**: num_topico, cod_idioma

---

## Tabela: mapa_distrib_ccusto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_mapa_distrib_ccusto

### Índices
- **mpdstrbc_plano_ccusto**: cod_empresa, cod_plano_ccusto

---

## Tabela: mapa_distrib_gerc_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_organ_orig, cod_plano_cta_ctbl_orig, cod_mapa_distrib_gerc_ctbl

### Índices
- **mpdstrbb_ccusto**: cod_unid_organ_orig, cod_plano_ccusto, cod_ccusto
- **mpdstrbb_estabelecimento**: cod_estab
- **mpdstrbb_ndrgn**: cod_unid_organ_dest
- **mpdstrbb_plano_cta_uo_dest**: cod_plano_cta_ctbl_dest, cod_unid_organ_dest
- **mpdstrbb_plano_cta_uo_orig**: cod_plano_cta_ctbl_orig, cod_unid_organ_orig
- **mpdstrbb_unid_negoc**: cod_unid_negoc

---

## Tabela: mapa_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_trans_edi, cdn_mapa_edi

### Índices
- **mapaedi_edfctstb**: cod_vers_edifact, cod_msg_edifact
- **mapaedi_finalid**: cdn_trans_edi, cdn_mapa_edi, ind_finalid_mapa_edi
- **mapaedi_map_des**: cdn_trans_edi, cdn_mapa_orig_edi, cdn_parcei_edi, dat_inic_valid_mapa_edi
- **mapaedi_prctrnsd**: cdn_trans_edi, cdn_parcei_edi, ind_finalid_mapa_edi
- **mapaedi_transedi**: cod_modul_dtsul, cdn_trans_edi
- **mapaedi_trans_finalid**: cdn_trans_edi, ind_finalid_mapa_edi

---

## Tabela: mapa_movto_bem_pat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_mapa_movto

### Índices

---

## Tabela: mapa_segment_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_trans_edi, cdn_mapa_edi, cdn_segment_edi

### Índices
- **mpsgmntd**: cdn_trans_edi, cdn_mapa_edi, cdn_identif_segment_edi
- **mpsgmntd_desegment**: des_segment_edi
- **mpsgmntd_identif**: cdn_trans_edi, cdn_mapa_edi, cdn_identif_depend_edi
- **mpsgmntd_trnssgmn**: cdn_trans_edi, cdn_segment_edi

---

## Tabela: mapa_segment_element_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_trans_edi, cdn_mapa_edi, cdn_segment_edi, cdn_element_edi

### Índices
- **mpsgmntl_edifact_pos**: cdn_trans_edi, cdn_mapa_edi, cdn_segment_edi, num_pos_layout
- **mpsgmntl_edifact_seg**: cdn_trans_edi, cdn_mapa_edi, cdn_segment_edi, cod_segment_edifact
- **mpsgmntl_elemento**: cdn_element_edi
- **mpsgmntl_label**: cdn_trans_edi, cdn_mapa_edi, des_label_utiliz_formul_edi
- **mpsgmntl_pos**: cdn_trans_edi, cdn_mapa_edi, cdn_segment_edi, num_pos_inicial_element_edi
- **mpsgmntl_segto_elem**: cdn_segment_edi, cdn_element_edi
- **mpsgmntl_seq**: cdn_trans_edi, cdn_mapa_edi, cdn_segment_edi, num_seq_element_edi

---

## Tabela: mapa_segment_equiv_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_trans_edi, cdn_mapa_edi, cdn_segment_edi, cdn_mapa_equiv_edi, cdn_segment_equiv_edi

### Índices
- **mpsgmntq_mapa**: cdn_mapa_edi
- **mpsgmntq_mapa_equiv**: cdn_mapa_equiv_edi
- **mpsgmntq_seg**: cdn_segment_edi

---

## Tabela: mapa_tip_reg_extrat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_extrat, num_seq_reg_layout_extrat, num_seq_mapa_tip_reg_extrat

### Índices
- **mptprgxt_contdo** (Unique): cod_layout_extrat, num_seq_reg_layout_extrat, ind_contdo_layout_extrat

---

## Tabela: mapa_tip_reg_layout
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout, num_seq_reg_layout, num_seq_mapa_tip_reg_layout

### Índices

---

## Tabela: marca
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_marca

### Índices
- **marca_descricao**: des_marca
- **marca_pessoa_jurid**: num_pessoa_jurid

---

## Tabela: matriz_trad_ccusto_ext
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_matriz_trad_ccusto_ext

### Índices
- **mtrztrda_plano_ccusto**: cod_empresa, cod_plano_ccusto

---

## Tabela: matriz_trad_cta_corren
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_matriz_trad_cta_corren

### Índices

---

## Tabela: matriz_trad_cta_ctbl_ext
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_organ, cod_matriz_trad_cta_ext

### Índices
- **mtrztrdc_cod_plano_cta_ctbl**: cod_unid_organ, cod_plano_cta_ctbl
- **mtrztrdc_matriz_trad_ccusto**: cod_unid_organ, cod_matriz_trad_ccusto_ext
- **mtrztrdc_matriz_trad_finalid**: cod_matriz_trad_finalid_ext
- **mtrztrdc_plano_ccusto**: cod_unid_organ, cod_plano_ccusto

---

## Tabela: matriz_trad_cta_pat_ext
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_matriz_trad_cta_pat_ext

### Índices

---

## Tabela: matriz_trad_finalid_ext
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_matriz_trad_finalid_ext

### Índices

---

## Tabela: matriz_trad_fluxo_ext
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_matriz_trad_fluxo_ext

### Índices

---

## Tabela: matriz_trad_org_ext
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_matriz_trad_org_ext

### Índices

---

## Tabela: matriz_trad_pais_ext
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_matriz_trad_pais_ext

### Índices

---

## Tabela: matriz_trad_portad_ext
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_matriz_trad_portad_ext

### Índices

---

## Tabela: medid_item_regra_ranking
**Label**: Nota Item Medida
**Descrição**: Valor Nota Item Medida Regra

### Chave Primária
- cod_regra_ranking_bcio, num_seq_item_regra_ranking, num_seq_medid_item_regra

### Índices

---

## Tabela: metod_calc_dpr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_metod_calc_dpr

### Índices

---

## Tabela: metod_calc_vendor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_metod_calc_vendor

### Índices

---

## Tabela: modelo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_espec_bem, cod_marca, cod_modelo

### Índices
- **modelo_descricao**: des_modelo
- **modelo_marca**: cod_marca

---

## Tabela: modul_grp_usuar_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_modul_dtsul, cdn_trans_edi, cod_grp_usuar

### Índices
- **mdlgrpsr_grpsr**: cod_grp_usuar
- **mdlgrpsr_mdldtsls**: cod_modul_dtsul, cod_grp_usuar

---

## Tabela: modul_usuar_mestre_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_modul_dtsul, cdn_trans_edi, cod_usuario

### Índices
- **mdlsrmst_srmstr**: cod_usuario

---

## Tabela: motiv_alter_verba
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_motiv_alter_verba

### Índices

---

## Tabela: motiv_cancel_cartcred
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_admdra_cartao_cr, cod_motiv_cancel_cartcred

### Índices

---

## Tabela: motiv_desmob
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_motiv_desmob

### Índices

---

## Tabela: motiv_devol_cheq
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_motiv_devol_cheq

### Índices

---

## Tabela: motiv_movto_comis
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_motiv_movto_comis

### Índices

---

## Tabela: motiv_movto_inadimp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_motiv_movto_tit_acr

### Índices

---

## Tabela: motiv_movto_tit_acr
**Label**: Vl Custo Motivo
**Descrição**: Valor Motivo Movimento ACR

### Chave Primária
- cod_estab, cod_motiv_movto_tit_acr

### Índices
- **mtvmvttt_estab_motiv_fim_valid**: cod_estab, cod_motiv_movto_tit_acr, dat_fim_valid

---

## Tabela: motiv_rej_admdra_cartao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_admdra_cartao_cr, cdn_motiv_rej_cobr_especial

### Índices
- **mtvrjdmd_motiv** (Unique): cod_admdra_cartao_cr, cod_motiv_rej_admdra
- **mtvrjdmd_trans**: cod_admdra_cartao_cr, cod_motiv_rej_admdra, ind_tip_trans_cartcred

---

## Tabela: motiv_rej_bco
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_banco, cdn_motiv_rej_cobr_especial

### Índices
- **mtvrjbc_motiv** (Unique): cod_banco, cod_motiv_rej_bco

---

## Tabela: motiv_rej_cobr_especial
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_motiv_rej_cobr_especial

### Índices

---

## Tabela: motiv_rej_conces_telef
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_conces_telef, cdn_motiv_rej_cobr_especial

### Índices
- **mtvrjcnc_motiv** (Unique): cod_conces_telef, cod_motiv_rej_conces

---

## Tabela: motiv_rej_espec_docto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_espec_docto, cdn_motiv_rej_cobr_especial

### Índices

---

## Tabela: motiv_sit_acaocap
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_motiv_sit_acaocap

### Índices

---

## Tabela: movto_acaocap
**Label**: Patrimonial
**Descrição**: Valor Patrimonial A��o

### Chave Primária
- cod_empresa, cdd_acionista, cdd_acaocap_inicial, dat_movto_shc, num_seq_shc

### Índices
- **mvtccp_acion**: cdd_acionista, dat_movto_shc
- **mvtccp_acion_movto_data**: cod_empresa, cdd_acionista, ind_movto_acaocap, dat_movto_shc
- **mvtccp_corretor**: cdd_corretor
- **mvtccp_emp_dat_ato**: cod_empresa, dat_atoadm_shc, ind_movto_acaocap
- **mvtccp_movto**: cdd_movto_acaocap
- **mvtccp_movto_anter**: cdd_movto_ant_acaocap
- **mvtccp_transf**: cod_empresa, num_livro_reg_acaocap, num_folha_reg_acaocap

---

## Tabela: movto_acr_gesplan
**Label**: Livre 2
**Descrição**: M�dulo

### Chave Primária
- cod_estab, num_id_acr_gesplan, ind_orig_rat

### Índices
- **mvtcrgsp_extid**: num_id_movto_tit_acr, ind_orig_rat

---

## Tabela: movto_adiant_emprest
**Label**: Taxa Juros Ponderada
**Descrição**: Valor Taxa Juros Ponderada

### Chave Primária
- num_id_adiant_emprest, num_parcela

### Índices
- **mvtdntmp_an**: cod_estab, num_id_tit_ap_ant_juros
- **mvtdntmp_even** (Unique): num_id_movto_event

---

## Tabela: movto_apb_gesplan
**Label**: Livre 1
**Descrição**: Movimentos do APB enviados para a Gesplan - Cash.

### Chave Primária
- cod_estab, num_id_ap_gesplan, ind_orig_rat

### Índices
- **mvtpbgsp_ext**: num_id_movto_tit_ap, ind_orig_rat

---

## Tabela: movto_bem_pat
**Label**: Percentual Movimento
**Descrição**: Valor Percentual Movimento Bem Patrimonial

### Chave Primária
- num_id_bem_pat, num_seq_incorp_bem_pat, num_seq_movto_bem_pat, dat_movto_bem_pat, dat_transacao, hra_transacao

### Índices
- **mvtbmpt_calculo**: num_id_bem_pat, num_seq_incorp_bem_pat, log_calc_pat, dat_movto_bem_pat
- **mvtbmpt_ccusto**: cod_empresa, cod_plano_ccusto, cod_ccusto_respons
- **mvtbmpt_destino**: num_id_bem_pat, num_seq_movto_bem_pat
- **mvtbmpt_estab**: cod_estab
- **mvtbmpt_estorn**: num_id_bem_pat, num_seq_incorp_bem_pat, log_estorn_movto_bem_pat, dat_movto_bem_pat
- **mvtbmpt_motiv_desmob**: cod_motiv_desmob
- **mvtbmpt_origem**: num_id_bem_pat_orig, num_seq_movto_bem_pat_orig
- **mvtbmpt_transf_estab**: cod_empresa, ind_orig_calc_bem_pat, num_seq_incorp_bem_pat_orig, dat_movto_bem_pat, cod_estab

---

## Tabela: movto_bem_pat_item_docto
**Label**: Valor Item
**Descrição**: Valor Item Documento Entrada

### Chave Primária
- num_id_bem_pat, num_seq_incorp_bem_pat, num_seq_movto_bem_pat, dat_movto_bem_pat, dat_transacao, hra_transacao, cod_estab, cod_empresa, cdn_fornecedor, cod_docto_entr, cod_ser_nota, cod_natur_operac, num_item_docto_entr

### Índices
- **mvtbmptt_bmpttmdc**: num_id_bem_pat, num_seq_incorp_bem_pat, cod_estab, cod_empresa, cdn_fornecedor, cod_docto_entr, cod_ser_nota, cod_natur_operac, num_item_docto_entr
- **mvtbmptt_doc**: cod_estab, cod_empresa, cdn_fornecedor, cod_docto_entr, cod_ser_nota, cod_natur_operac, num_item_docto_entr

---

## Tabela: movto_bem_viagem_eec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq_movto_bem_pat, num_id_proces_prestac_cta, num_id_bem_pat

### Índices

---

## Tabela: movto_bloq_acaocap
**Label**: Percentual Bloqueio
**Descrição**: Valor Percentual Bloqueio A��o Capital

### Chave Primária
- cod_empresa, cdd_acionista, cdd_acaocap_inicial, dat_movto_shc, num_seq_shc, cod_motiv_sit_acaocap

### Índices
- **mvtblqcc_mtvstccp**: cod_motiv_sit_acaocap

---

## Tabela: movto_cenar_bem_pat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_bem_pat, num_seq_incorp_bem_pat, num_seq_movto_bem_pat, cod_cenar_ctbl

### Índices

---

## Tabela: movto_cobr_especial_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_cobr_especial_acr, cod_estab, num_id_tit_acr, num_seq_tit_acr

### Índices
- **mvtcbrsp_niv**: cod_estab, num_id_tit_acr, num_seq_tit_acr, num_niv_cobr_especial_acr

---

## Tabela: movto_cobr_tit_acr
**Label**: Perc Juros
**Descrição**: Percentual de Juros

### Chave Primária
- cod_empresa, cdn_cliente, num_seq_movto_cobr_tit_acr

### Índices
- **mvtcbrtt_cliente**: cod_empresa, cdn_cliente, dat_movto_cobr_tit_acr
- **mvtcbrtt_contat**: cod_empresa, dat_prox_contat
- **mvtcbrtt_data**: dat_movto_cobr_tit_acr, hra_movto_cobr_tit_acr
- **mvtcbrtt_hist**: cod_empresa, dat_movto_cobr_tit_acr, cod_histor_padr
- **mvtcbrtt_proc_seq**: cdn_process_msg_cobr, num_seq_carta_proces
- **mvtcbrtt_titulo**: cod_estab, num_id_tit_acr

---

## Tabela: movto_cobr_tit_inadimp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cdn_cliente, num_seq_movto_cobr_tit_acr

### Índices

---

## Tabela: movto_comis_repres
**Label**: Valor Movimento
**Descrição**: Valor Movimento Comiss�o

### Chave Primária
- cod_empresa, cdn_repres, num_seq_movto_comis

### Índices
- **mvtcmsrp_apb**: cod_estab_tit_ap, num_id_tit_ap
- **mvtcmsrp_dat_emis**: cod_estab, dat_emis_docto, cdn_repres
- **mvtcmsrp_estabrep**: cod_estab, cdn_repres, log_movto_comis_envdo, dat_transacao
- **mvtcmsrp_integrmovto**: cod_estab, num_id_tit_acr, cdn_repres, ind_trans_acr, log_movto_comis_envdo, ind_tip_movto
- **mvtcmsrp_movtoacr**: cod_estab, num_id_movto_tit_acr
- **mvtcmsrp_prev**: cod_estab_tit_ap, num_id_tit_ap_prev
- **mvtcmsrp_proces**: cod_empresa, cdn_repres, cod_indic_econ, num_proces_integr_comis
- **mvtcmsrp_repres**: cod_empresa, cdn_repres, log_movto_comis_envdo, dat_transacao
- **mvtcmsrp_tipmovto**: cod_estab, num_id_tit_acr, num_id_movto_tit_acr, cdn_repres, ind_tip_movto, ind_trans_acr, ind_natur_lancto_ctbl, ind_trans_comis
- **mvtcmsrp_titacr**: cod_estab, num_id_tit_acr

---

## Tabela: movto_concil_cta_corren
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cta_corren, num_id_lin_extrat_cta, num_id_movto_cta_corren

### Índices
- **mvtcnclc_cnclctcr**: cod_cta_corren, num_concil_cta_corren
- **mvtcnclc_lin_extrat**: num_id_lin_extrat_cta
- **mvtcnclc_movto_cta**: num_id_movto_cta_corren

---

## Tabela: movto_contrat_mutuo
**Label**: Vl Principal Movto
**Descrição**: Valor de Principal do Movimento Contrato

### Chave Primária
- num_id_movto_contrat

### Índices
- **mvtcntrt_data**: dat_transacao, num_id_movto_contrat
- **mvtcntrt_mov_cta**: num_id_movto_cta_corren
- **mvtcntrt_refer_contr**: cod_refer_contrat, dat_transacao, num_id_movto_contrat
- **mvtcntrt_refer_mov**: cod_refer_movto_contrat, dat_transacao

---

## Tabela: movto_conven_financ
**Label**: Valor Movimento
**Descrição**: Valor Movimento Conv�nio

### Chave Primária
- num_id_movto_conven

### Índices
- **mvtcnvnf_conven**: cod_empresa, cod_conven_financ
- **mvtcnvnf_conv_forn**: cod_empresa, cod_estab, cod_conven_financ, cdn_fornecedor, dat_movto_conven
- **mvtcnvnf_fornec**: cod_empresa, cdn_fornecedor, cod_prop_rural, dat_movto_conven
- **mvtcnvnf_mov_evn**: num_id_movto_event
- **mvtcnvnf_pto_col**: cod_pto_coleta, dat_movto_conven

---

## Tabela: movto_conven_rat_coleta
**Label**: Vl Rateio Coleta
**Descrição**: Valor do Rateio da Coleta

### Chave Primária
- num_id_movto_conven, cdn_fornecedor, cod_prop_rural

### Índices

---

## Tabela: movto_cta_corren
**Label**: Pendente Conciliacao
**Descrição**: Valor Pendente Conciliacao Conta Corrente

### Chave Primária
- cod_cta_corren, dat_movto_cta_corren, num_seq_movto_cta_corren

### Índices
- **mvtctcrr_calc_encargo**: num_calc_encargo_cta_corren
- **mvtctcrr_cheque**: num_id_cheq
- **mvtctcrr_cod_docto**: cod_docto_movto_cta_bco
- **mvtctcrr_concil_bcia**: cod_cta_corren, ind_tip_movto_cta_corren, log_concil_cta_corren, dat_movto_cta_corren
- **mvtctcrr_ctbz**: dat_movto_cta_corren, log_ctbz_movto_cta_corren
- **mvtctcrr_movto_estorn**: num_id_movto_cta_estorn
- **mvtctcrr_movto_impto**: num_id_movto_cta_impto
- **mvtctcrr_tip_trans_cx**: cod_tip_trans_cx, cod_cta_corren, dat_movto_cta_corren
- **mvtctcrr_token** (Unique): num_id_movto_cta_corren
- **mvtctcrr_token_orig_mutuo**: num_id_movto_orig_mutuo
- **mvtctcrr_tranf_cta**: num_id_movto_cta_transf

---

## Tabela: movto_cta_corren_gesplan
**Label**: Livre 2
**Descrição**: Movimentos do CMG enviados para a Gesplan

### Chave Primária
- cod_estab, num_id_cta_corren_gesplan, ind_orig_rat, num_seq_aprop_ctbl_cmg

### Índices

---

## Tabela: movto_cta_corren_sint
**Label**: Sa�das Realizadas
**Descrição**: Sa�das Realizadas de Conta Corrente

### Chave Primária
- cod_cta_corren, cod_cenar_ctbl, cod_tip_trans_cx, dat_sdo_cta_corren

### Índices
- **mvtctcra_cenar**: cod_cenar_ctbl
- **mvtctcra_tip_trans_cx**: cod_tip_trans_cx

---

## Tabela: movto_cx_financ
**Label**: Valor Movimento
**Descrição**: Valor Movimento

### Chave Primária
- num_cx_financ, num_movto_cx

### Índices
- **mvtcxfnn_cheq**: num_cx_financ, cod_bco_cheq, cod_agenc_bcia_cheq, cod_cta_corren, num_cheque
- **mvtcxfnn_pai**: num_cx_financ_pai, num_movto_cx_pai
- **mvtcxfnn_process**: num_cx_financ, num_process_negoc, num_seq_forma_pagto_cx
- **mvtcxfnn_refer**: cod_refer
- **mvtcxfnn_tip**: num_cx_financ, ind_tip_trans, log_movto_estordo
- **mvtcxfnn_usuar**: cod_usuar, ind_tip_trans, log_movto_estordo

---

## Tabela: movto_destinac_cobr
**Label**: Total Movto
**Descrição**: Valor Total Movimento Destina��o Cobran�a

### Chave Primária
- cod_empresa, cod_destinac_cobr, num_seq_destinac_cobr, dat_movto_destinac_cobr, hra_movto_destinac_cobr

### Índices
- **mvtdstnc_dstnccbr**: cod_empresa, dat_movto_destinac_cobr, hra_movto_destinac_cobr

---

## Tabela: movto_devol_cheq_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_cheq_acr, num_seq_devol_cheq_acr

### Índices

---

## Tabela: movto_divndo_acion
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cdd_acionista, cod_clas_acaocap, dat_atoadm_shc

### Índices
- **mvtdvndc_acionista**: cdd_acionista
- **mvtdvndc_clsccp**: cod_clas_acaocap
- **mvtdvndc_dtpagto**: dat_pagto_divndo
- **mvtdvndc_emp_cla_dat**: cod_empresa, dat_atoadm_shc
- **mvtdvndc_valid**: dat_valid_divndo

---

## Tabela: movto_event_financ
**Label**: Valor Movto
**Descrição**: Valor Movimento Evento

### Chave Primária
- cod_empresa, cdn_fornecedor, cod_prop_rural, cod_event_financ, dat_movto_event, num_seq_movto_event

### Índices
- **mvtvntfn_conv**: num_id_movto_conven
- **mvtvntfn_fechto**: num_id_fechto_event_financ
- **mvtvntfn_forn_fechto**: cod_empresa, cdn_fornecedor, cod_prop_rural, num_id_fechto_event_financ, dat_movto_event
- **mvtvntfn_num** (Unique): num_id_movto_event
- **mvtvntfn_operac**: num_id_operac_financ, num_parc_operac_financ, ind_tip_parc_emprest
- **mvtvntfn_pendcia**: num_seq_pendcia
- **mvtvntfn_refer**: cod_refer

---

## Tabela: movto_event_tit
**Label**: Valor Movto
**Descrição**: Valor Movimento Evento

### Chave Primária
- num_id_movto_event, cod_estab, num_id_tit_ap, num_id_tit_ap_antecip

### Índices
- **mvtvnttt_ant**: cod_estab, num_id_tit_ap_antecip
- **mvtvnttt_fech**: num_id_fechto_event_financ
- **mvtvnttt_prop**: cod_empresa, cdn_fornecedor, cod_prop_rural, num_id_fechto_event_financ
- **mvtvnttt_tit**: cod_estab, num_id_tit_ap

---

## Tabela: movto_fisc
**Label**: Valor Movimento
**Descrição**: Valor Movimento

### Chave Primária
- cod_empresa, cod_modul_dtsul, cod_finalid_econ, cod_plano_cta_ctbl, cod_estab, cod_cta_ctbl, cod_plano_ccusto, cod_ccusto, cod_unid_negoc, dat_trans_diario

### Índices
- **mvtfsc_data**: cod_empresa, cod_finalid_econ, dat_trans_diario, cod_estab
- **mvtfsc_est_dat**: cod_empresa, cod_modul_dtsul, cod_estab, dat_trans_diario
- **mvtfsc_modul**: cod_empresa, cod_estab, cod_finalid_econ, cod_modul_dtsul, dat_trans_diario
- **mvtfsc_mod_dat**: cod_empresa, cod_modul_dtsul, dat_trans_diario

---

## Tabela: movto_fluxo_cx
**Label**: Perc Copia Fluxo
**Descrição**: Valor Percentual Copia Fluxo Caixa

### Chave Primária
- num_fluxo_cx, dat_movto_fluxo_cx, num_seq_movto_fluxo_cx

### Índices
- **mvtflxcx_estab_unid_negoc**: num_fluxo_cx, cod_estab, cod_unid_negoc
- **mvtflxcx_hstrpdr**: cod_histor_padr
- **mvtflxcx_modul**: num_fluxo_cx, cod_modul_dtsul, dat_movto_fluxo_cx, num_seq_movto_fluxo_cx
- **mvtflxcx_num_simul_flux_cx**: num_seq_simul_fluxo_cx
- **mvtflxcx_tip_fluxo**: cod_tip_fluxo_financ, dat_movto_fluxo_cx, cod_unid_negoc, cod_estab, num_fluxo_cx
- **mvtflxcx_tip_movto**: num_fluxo_cx, ind_tip_movto_fluxo_cx, dat_movto_fluxo_cx
- **mvtflxcx_token** (Unique): num_id_movto_fluxo_cx

---

## Tabela: movto_fluxo_cx_pend
**Label**: Perc Copia Fluxo
**Descrição**: Valor Percentual Copia Fluxo Caixa

### Chave Primária
- num_fluxo_cx, dat_movto_fluxo_cx, num_seq_movto_fluxo_cx

### Índices
- **mvtflxcxpd_estab_unid_neg**: num_fluxo_cx, cod_estab, cod_unid_negoc
- **mvtflxcxpd_modul**: num_fluxo_cx, cod_modul_dtsul, dat_movto_fluxo_cx, num_seq_movto_fluxo_cx
- **mvtflxcxpd_num_simul_flux_cx**: num_seq_simul_fluxo_cx
- **mvtflxcxpd_tip_fluxo**: cod_tip_fluxo_financ, dat_movto_fluxo_cx, cod_unid_negoc, cod_estab, num_fluxo_cx
- **mvtflxcxpd_tip_movto**: num_fluxo_cx, ind_tip_movto_fluxo_cx, dat_movto_fluxo_cx

---

## Tabela: movto_fluxo_unid_control
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_movto_fluxo_cx, cod_unid_control_financ

### Índices
- **mvtflxnd_unid_control_financ**: cod_unid_control_financ, dat_movto_fluxo_cx

---

## Tabela: movto_impto_tit_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_id_movto_tit_acr, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto

### Índices
- **mvtmpttt_clssfmpt**: cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto

---

## Tabela: movto_item_destinac
**Label**: Perc Destinado
**Descrição**: Percentual Destinado

### Chave Primária
- cod_estab, cod_destinac_cobr, cod_portador, cod_cart_bcia, cod_finalid_econ, dat_movto_item_destinac, hra_movto_item_destinac

### Índices
- **mvttmdst_data**: dat_movto_item_destinac, hra_movto_item_destinac
- **mvttmdst_portad**: cod_portador, cod_cart_bcia

---

## Tabela: movto_lancto_concil_cart
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_lancto_cartao_cr

### Índices
- **mvtlnctc_cta_corren**: num_id_movto_cta_corren
- **mvtlnctc_tit_movto**: cod_estab, num_id_tit_acr, num_id_movto_tit_acr

---

## Tabela: movto_mapa_movto_bem_pat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_mapa_movto, num_item_mapa_movto, num_seq_movto_bem_pat, dat_transacao, hra_transacao

### Índices

---

## Tabela: movto_mktplace
**Label**: Valor Saldo T�tulo
**Descrição**: Vl Repasse L�quido

### Chave Primária
- num_movto_mktplace

### Índices
- **mvtmktpl_dat_comp**: cod_empresa, cdn_mktplace, dat_compra, ind_sit_movto_mktplace
- **mvtmktpl_dat_estorn**: cod_empresa, cdn_mktplace, dat_estorn_movto, ind_sit_movto_mktplace
- **mvtmktpl_div**: ind_status_diverg
- **mvtmktpl_dt_prev_pag**: cod_empresa, cdn_mktplace, dat_prev_pagto, ind_sit_movto_mktplace
- **mvtmktpl_empcdn**: cod_empresa, cdn_mktplace, ind_sit_movto_mktplace, dat_pagto
- **mvtmktpl_empdt**: cod_empresa, dat_pagto, ind_sit_movto_mktplace, cdn_mktplace
- **mvtmktpl_empres**: cod_empresa, ind_sit_movto_mktplace
- **mvtmktpl_ped**: num_ped_exec
- **mvtmktpl_ped_vda**: cod_empresa, cod_ped_vda, ind_sit_movto_mktplace
- **mvtmktpl_proc_trans**: cdn_proces_trans
- **mvtmktpl_sitdt**: cod_empresa, ind_sit_movto_mktplace, dat_pagto, cdn_mktplace
- **mvtmktpl_trans_mkt**: cod_empresa, cdn_mktplace, cod_trans_mktplace
- **mvt_concil_movto**: num_id_concil_mktplace, ind_movto_concil
- **mvt_concil_status**: num_id_concil_mktplace, ind_sit_movto_mktplace

---

## Tabela: movto_mktplace_tit_acr
**Label**: Saldo Pedido Venda
**Descrição**: Saldo Pedido Venda

### Chave Primária
- num_movto_mktplace, cod_estab, num_id_tit_acr

### Índices
- **mvtmktpa_tit_acr**: cod_estab, num_id_tit_acr, cod_ped_vda

---

## Tabela: movto_msg_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_modul_dtsul, cod_grp_usuar, ind_trans_msg_usuar, cod_msg_usuar, num_seq_msg_usuar, dat_movto_msg_usuar, hra_movto_msg_usuar

### Índices

---

## Tabela: movto_ocor_bcia
**Label**: Vl Movto Ocor Bcia
**Descrição**: Valor Movimento Ocorr�ncia Banc�ria

### Chave Primária
- cod_estab, num_id_tit_acr, num_seq_movto_ocor_bcia

### Índices
- **mvtcrbc_contdo_agrup**: cod_empresa, cdn_cliente, des_contdo_agrup
- **mvtcrbc_dat_gerac**: cod_estab, ind_ocor_bcia_remes_ret, ind_tip_ocor_bcia, dat_gerac_movto_ocor_bcia
- **mvtcrbc_movto**: cod_estab, num_id_movto_tit_acr
- **mvtcrbc_num_agrup**: num_agrup_movto_ocor_bcia
- **mvtcrbc_ocor**: cod_estab, ind_ocor_bcia_remes_ret, ind_tip_ocor_bcia, dat_movto_ocor_bcia
- **mvtcrbc_oprcfnna**: cod_estab, cod_movto_operac_financ
- **mvtcrbc_token** (Unique): cod_estab, num_id_movto_ocor_bcia

---

## Tabela: movto_operac_financ
**Label**: Vl Desconto Moeda
**Descrição**: Valor Desconto na Moeda do Movimento

### Chave Primária
- num_id_operac_financ, num_seq_movto_operac_financ

### Índices
- **mvtprcfd_tit_antecip**: cod_estab_antecip, num_id_tit_ap_antecip
- **mvtprcfn_an_juros**: cod_estab_antecip_juros, num_id_tit_antecip_juros
- **mvtprcfn_data_transacao**: num_id_operac_financ, dat_transacao, ind_tip_trans_apl
- **mvtprcfn_dat_juros_real**: num_id_operac_financ, dat_juros_real
- **mvtprcfn_empresa_data**: cod_empresa, dat_transacao
- **mvtprcfn_imposto**: num_id_operac_financ, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto, dat_transacao
- **mvtprcfn_pai**: num_id_movto_operac_pai
- **mvtprcfn_pef**: cod_estab_pef, cod_refer_pef
- **mvtprcfn_token** (Unique): num_id_movto_operac_financ

---

## Tabela: movto_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq_movto_orcto

### Índices
- **mvtrct_mtvltrvr**: cod_motiv_alter_verba
- **mvtrct_vers_orcto_ctbl**: cod_cenar_orctario, cod_unid_orctaria, num_seq_orcto_ctbl, cod_vers_orcto_ctbl

---

## Tabela: movto_prev_operac_financ
**Label**: Valor Movimento
**Descrição**: Valor Movimento Aplica��o Empr�stimos

### Chave Primária
- num_id_movto_prev_operac

### Índices
- **mvtprvpr_operac_financ**: num_id_operac_financ

---

## Tabela: movto_residuo_acaocap
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_clas_acaocap, cdd_acionista, cdd_movto_residuo

### Índices

---

## Tabela: movto_spc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, num_id_movto_spc

### Índices

---

## Tabela: movto_spool_acr_vendor
**Label**: Vl Movimento
**Descrição**: Valor do Movimento

### Chave Primária
- dat_transacao, ind_trans_integr_vendor, num_id_tit_acr

### Índices
- **mvtsplcr_num_id_tit_acr**: cod_estab, num_id_tit_acr
- **mvtsplcr_tip_fluxo**: cod_tip_fluxo_financ
- **mvtsplcr_tptrnscx**: cod_tip_trans_cx

---

## Tabela: movto_tit_acr
**Label**: Saldo T�tulo
**Descrição**: Valor Saldo Contas a Receber

### Chave Primária
- cod_estab, num_id_tit_acr, num_id_movto_tit_acr

### Índices
- **mvtttcr_ctbz**: cod_estab, dat_transacao, log_ctbz_aprop_ctbl, log_aprop_ctbl_ctbzda
- **mvtttcr_estab_dat_trans**: cod_estab, dat_transacao, cod_espec_docto, ind_trans_acr_abrev
- **mvtttcr_estab_trans_dtfluxo**: cod_estab, ind_trans_acr_abrev, dat_fluxo_cx_movto
- **mvtttcr_gerac_movto**: dat_gerac_movto, hra_gerac_movto
- **mvtttcr_id_movto_cta_corren**: num_id_movto_cta_corren
- **mvtttcr_integr_cfl**: cod_estab, log_integr_cfl_atlzdo, log_movto_estordo, dat_transacao
- **mvtttcr_motivo_movto**: cod_estab, cod_motiv_movto_tit_acr, dat_transacao
- **mvtttcr_movto_pai**: cod_estab_tit_acr_pai, num_id_movto_tit_acr_pai
- **mvtttcr_razao**: cod_estab, cdn_cliente, dat_transacao
- **mvtttcr_refer**: cod_estab, cod_refer, ind_trans_acr_abrev
- **mvtttcr_token** (Unique): cod_estab, num_id_movto_tit_acr

---

## Tabela: movto_tit_acr_avp
**Label**: Valor Presente
**Descrição**: Valor Presente

### Chave Primária
- num_id_movto_tit_acr_avp

### Índices
- **mvtttcra_dat**: cod_empresa, dat_calc_movto
- **mvtttcra_tit**: cod_estab, num_id_tit_acr

---

## Tabela: movto_tit_acr_fechado
**Label**: Variacao Correcao mo
**Descrição**: Valor Variacao Correcao monetaria Antecipacao

### Chave Primária
- cod_empresa, cod_estab, cod_espec_docto, cod_ser_docto, cod_tit_acr, cod_parcela, dat_transacao

### Índices
- **mvtttcrf_cli_trans**: cod_empresa, cod_estab, cdn_cliente, dat_transacao
- **mvtttcrf_emis**: cod_empresa, dat_emis, cod_estab, cod_espec_docto, cod_ser_docto, cod_tit_acr, cod_parcela
- **mvtttcrf_id_movto** (Unique): num_id_movto_tit_acr
- **mvtttcrf_port**: cod_empresa, cod_portador, dat_transacao, idi_transacao, cod_estab, cod_espec_docto, cod_ser_docto, cod_tit_acr, cod_parcela
- **mvtttcrf_trans**: cod_empresa, cod_estab, dat_transacao, idi_transacao

---

## Tabela: movto_tit_acr_vendor
**Label**: Vl Movimento
**Descrição**: Valor do Movimento

### Chave Primária
- cod_estab_tit_acr, num_id_tit_acr, num_id_movto_tit_acr

### Índices
- **mvtttcrv_antecip**: cod_estab_antecip, num_id_tit_acr_antecip

---

## Tabela: movto_tit_ap
**Label**: Vl Sdo Apos Movto
**Descrição**: Valor Saldo Ap�s Movimento

### Chave Primária
- cod_estab, num_id_tit_ap, num_id_movto_tit_ap

### Índices
- **mvtttp_estab_dat_trans**: cod_estab, dat_transacao, log_ctbz_aprop_ctbl, log_aprop_ctbl_ctbzda
- **mvtttp_gerac_movto**: dat_gerac_movto, hra_gerac_movto
- **mvtttp_id_movto_cta_corren**: num_id_movto_cta_corren
- **mvtttp_ind_trans_abrev**: cod_estab, ind_trans_ap_abrev, dat_transacao
- **mvtttp_log_integr_cfl**: cod_estab, cod_espec_docto, log_integr_cfl_atlzdo, dat_transacao
- **mvtttp_movto_pai**: cod_estab_tit_ap_pai, num_id_movto_tit_ap_pai
- **mvtttp_razao**: cod_empresa, cdn_fornecedor, dat_transacao, cod_estab, cod_espec_docto
- **mvtttp_refer**: cod_estab, cod_refer, ind_trans_ap_abrev
- **mvtttp_token** (Unique): cod_estab, num_id_movto_tit_ap

---

## Tabela: movto_tit_ap_avp
**Label**: Valor Presente
**Descrição**: Valor Presente

### Chave Primária
- num_id_movto_tit_ap_avp

### Índices
- **mvtttpvp_dat**: cod_empresa, dat_calc_movto
- **mvtttpvp_tit**: cod_estab, num_id_tit_ap

---

## Tabela: movto_tit_ap_bcio
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_sist_nac_bcio, cod_tit_ap_bco, num_seq_tit_bco, num_seq_movto_bco

### Índices

---

## Tabela: movto_tit_ap_fechado
**Label**: Variacao Correcao mo
**Descrição**: Valor Variacao Correcao monetaria Antecipacao

### Chave Primária
- cod_empresa, cdn_fornecedor, cod_estab, cod_espec_docto, cod_ser_docto, cod_tit_ap, cod_parcela, dat_transacao

### Índices
- **mvtttpfc_bord**: cod_empresa, num_bord_ap
- **mvtttpfc_cheq**: cod_estab, cod_portador, num_cheque
- **mvtttpfc_cta**: cod_empresa, cod_estab, cod_cta_ctbl, cod_ccusto
- **mvtttpfc_id_movto** (Unique): num_id_movto
- **mvtttpfc_portador**: cod_estab, cod_portador, cod_cart_bcia, cdn_fornecedor
- **mvtttpfc_trans**: cod_empresa, cod_estab, dat_transacao, idi_transacao

---

## Tabela: movto_tit_envio_serasa
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_id_tit_acr, num_id_movto_tit_acr

### Índices
- **mvtttnvs_estordo**: log_movto_estordo, dat_envio_estordo_serasa, log_movto_zera_sdo

---

## Tabela: movto_usuar_cheq_terc
**Label**: Total Cheques
**Descrição**: Valor Total Cheque Terceiro M�s

### Chave Primária
- cod_estab, cod_usuar_cheq_acr_terc, dat_movto_usuar_cheq_terc

### Índices
- **mvtsrchq_data**: cod_estab, dat_movto_usuar_cheq_terc

---

## Tabela: movto_usuar_financ
**Label**: Pagto Pendente
**Descrição**: Total Pagamento Pendente no M�s

### Chave Primária
- cod_usuario, cod_estab, dat_movto_usuar_ap

### Índices
- **mvtsrfnn_estab_financ**: cod_estab

---

## Tabela: msg_envda_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_id_msg

### Índices
- **msgnvdd_dat_entreg**: dat_entreg, hra_entreg
- **msgnvdd_destinatario**: des_ender_para
- **msgnvdd_envio**: dat_envio, hra_envio
- **msgnvdd_leitura**: dat_leitura, hra_leitura
- **msgnvdd_prcd**: cdn_parcei_edi
- **msgnvdd_remetente**: des_ender_orig
- **msgnvdd_trans**: cdn_trans_edi

---

## Tabela: msg_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_estab, cod_mensagem

### Índices
- **msgfnnc_empres_msg**: cod_empresa, cod_mensagem
- **msgfnnc_estab_msg**: cod_estab, cod_mensagem
- **msgfnnc_msg**: cod_mensagem

---

## Tabela: msg_recbda_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_id_x400

### Índices
- **msgrcbdd_arq**: cod_arq_cabec
- **msgrcbdd_destinatario**: des_ender_para
- **msgrcbdd_prcd**: cdn_parcei_edi
- **msgrcbdd_recbdo**: dat_recbdo, hra_recbdo
- **msgrcbdd_remetente**: des_ender_orig
- **msgrcbdd_trans**: cdn_trans_edi

---

## Tabela: msg_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_msg_usuar

### Índices

---

## Tabela: narrat_demonst_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_demonst_ctbl, cod_idioma

### Índices
- **nrrtdmns_idioma**: cod_idioma

---

## Tabela: natur_rendto_impto
**Label**: Percentual Natureza Rendimento
**Descrição**: Data Referencia.

### Chave Primária
- cod_estab, num_id_tit_ap, num_id_movto_tit_ap, cod_pais, cod_unid_federac, cod_imposto, cod_classif, num_seq_natur_rendto

### Índices
- **ntrrndtm_data_refer**: cod_estab, dat_refer

---

## Tabela: natur_rendto_impto_pend
**Label**: Percentual Natureza Rendimento
**Descrição**: Percentual Natureza Rendimento  Pis/Cofins/CSLL  ou agregado

### Chave Primária
- cod_estab, cod_refer, num_seq_refer, cod_pais, cod_unid_federac, cod_imposto, cod_classif, num_seq_natur_rendto

### Índices

---

## Tabela: ncredito_pos_faturam
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_id_identif, cod_erp_id_antecip

### Índices
- **ncrdtpsa_id_antecip**: cod_empresa, cod_erp_id_antecip

---

## Tabela: niv_cargo_eec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_niv_cargo

### Índices

---

## Tabela: niv_hier_funcnal_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_niv_hier_funcnal

### Índices
- **nvhrfnca_py09001**: num_seq_niv_hier_funcnal

---

## Tabela: niv_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_niv_usuar

### Índices

---

## Tabela: nota_devol_tit_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_espec_docto, cod_ser_docto, cod_tit_acr, cod_parcela

### Índices
- **ntdvlttc_nota**: cdn_cliente, cod_ser_nota_devol, cod_nota_devol, cod_natur_operac_devol

---

## Tabela: nota_devol_tit_ap
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab_ems5, cod_espec_docto, cod_ser_docto, cod_tit_ap, cod_parcela, cdn_fornecedor

### Índices
- **ntdvlttp_fornec**: cdn_fornecedor, cod_ser_nota_devol, cod_nota_devol, cod_estab

---

## Tabela: nota_pend_cartcred
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_refer, num_seq_refer, cod_contrat_cartcred, cod_portad_cartcred

### Índices
- **ntpndcrt_titulo**: num_pessoa, cod_espec_docto, cod_ser_docto, cod_tit_ap, cod_parcela

---

## Tabela: ocor_bcia_bco
**Label**: Valor Ocor Bcia Bco
**Descrição**: Valor Ocorr�ncia Banc�ria Banco

### Chave Primária
- cod_banco, cod_modul_dtsul, ind_ocor_bcia_remes_ret, ind_tip_ocor_bcia, cod_ocor_bcia_bco, dat_inic_valid

### Índices
- **ocrbcbc_fnldcn**: cod_finalid_econ
- **ocrbcbc_retorno**: cod_banco, cod_modul_dtsul, ind_ocor_bcia_remes_ret, cod_ocor_bcia_bco, dat_inic_valid, dat_fim_valid
- **ocrbcbc_tip_ocor**: cod_modul_dtsul, ind_ocor_bcia_remes_ret, ind_tip_ocor_bcia

---

## Tabela: ocor_item_bord_ap
**Label**: Valor Pagamento
**Descrição**: Valor Pagamento

### Chave Primária
- cod_estab_bord, num_id_item_bord_ap, num_seq_ocor_bcia, ind_tip_ocor_bcia

### Índices
- **ocrtmbrd_bord**: cod_estab_bord, cod_portador, num_bord_ap, log_ocor_bcia_envda
- **ocrtmbrd_mvtttp**: cod_estab, num_id_movto_tit_ap
- **ocrtmbrd_proces**: cdn_proces_edi

---

## Tabela: ocor_proces_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_proces_edi, cdn_etap_proces_edi, cdn_seq_ocor_edi

### Índices
- **ocrprcsd_desc**: cdn_proces_edi, cdn_etap_proces_edi, des_ocor_proces_edi

---

## Tabela: operac_financ
**Label**: Saldo Principal
**Descrição**: Valor Saldo Principal Opera��o Financeira

### Chave Primária
- cod_banco, cod_produt_financ, cod_operac_financ

### Índices
- **oprcfnnc_prox_aniv**: ind_operac_financ, ind_sit_operac_financ_apl, dat_prox_aniver_aplic, cod_empresa
- **oprcfnnc_term_carenc**: ind_operac_financ, ind_sit_operac_financ_apl, dat_term_carenc_aplic, cod_empresa
- **oprcfnnc_token** (Unique): num_id_operac_financ
- **oprcfnnc_ult_apurac_impto**: ind_operac_financ, ind_sit_operac_financ_apl, dat_ult_apurac_impto
- **oprcfnnc_vencto**: ind_operac_financ, ind_sit_operac_financ_apl, dat_vencto_operac_financ, cod_empresa

---

## Tabela: operac_financ_acr
**Label**: Total Desp Financ
**Descrição**: Valor Total Despesa Financeira

### Chave Primária
- cod_estab, cod_movto_operac_financ

### Índices
- **oprcfnna_bordero**: cod_estab, num_bord_acr
- **oprcfnna_carteira**: cod_estab, cod_cart_bcia, cod_portador
- **oprcfnna_data**: cod_estab, dat_operac_financ
- **oprcfnna_portador**: cod_estab, cod_portador, cod_cart_bcia

---

## Tabela: operdra_cartao_cr
**Label**: Valor M�nimo Antecipa��o
**Descrição**: Valor M�nimo Antecipa��o

### Chave Primária
- cod_operdra_cartao_cr

### Índices

---

## Tabela: orcto_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_organ, cod_cenar_orctario, cod_cenar_ctbl, cod_exerc_ctbl

### Índices
- **rctctbla_exerc_ctbl**: cod_cenar_ctbl, cod_exerc_ctbl
- **rctctbla_finalid_unid_organ**: cod_unid_organ, cod_finalid_econ

---

## Tabela: orcto_ctbl_bgc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cenar_orctario, cod_unid_orctaria, num_seq_orcto_ctbl

### Índices
- **orctctbl_data**: cod_cenar_orctario, cod_unid_orctaria, dat_inic_valid, dat_fim_valid
- **orctctbl_finalid_econ**: cod_finalid_econ
- **orctctbl_unid_orctaria**: cod_unid_orctaria

---

## Tabela: ord_busca_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa

### Índices

---

## Tabela: ord_compra_tit_ap
**Label**: Saldo Ordem Compra
**Descrição**: Valor Saldo Ordem Compra

### Chave Primária
- cod_estab, num_id_tit_ap, cod_ord_compra

### Índices
- **ordcmprt_fornec**: cod_empresa, cdn_fornecedor

---

## Tabela: ord_compra_tit_ap_pend
**Label**: Saldo Ordem Compra
**Descrição**: Valor Saldo Ordem Compra

### Chave Primária
- cod_estab, cod_refer, num_seq_refer, cod_ord_compra

### Índices

---

## Tabela: orgao_public
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_orgao_public

### Índices

---

## Tabela: orig_acaocap
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_orig_acaocap

### Índices

---

## Tabela: orig_movto_cmg_ems_2
**Label**: Origem Movimento Cas
**Descrição**: Valor Origem Movimento Cash Management Ems 2

### Chave Primária
- num_id_movto_cta_corren, num_id_orig_movto_cmg_ems_2, ind_orig_movto, cod_modul_dtsul

### Índices
- **orgmvtcm_orig**: num_id_orig_movto_cmg_ems_2

---

## Tabela: orig_movto_empenh
**Label**: Movto Empenhado
**Descrição**: Valor Movimento Empenhado

### Chave Primária
- cod_empresa, cod_plano_cta_ctbl, cod_cta_ctbl, cod_estab, cod_unid_negoc, cod_plano_ccusto, cod_ccusto, cod_proj_financ, dat_sdo_ctbl, cod_finalid_econ, num_seq_orig_movto

### Índices
- **orgmvtmp_ccusto**: cod_empresa, cod_plano_ccusto, cod_ccusto
- **orgmvtmp_cta_ctbl**: cod_plano_cta_ctbl, cod_cta_ctbl
- **orgmvtmp_dat_sdo**: cod_empresa, cod_estab, dat_sdo_ctbl, num_orig_movto_empenh
- **orgmvtmp_estab**: cod_estab
- **orgmvtmp_funcao**: log_atualiz_empenh, num_ult_funcao
- **orgmvtmp_movto** (Unique): cod_empresa, cod_plano_cta_ctbl, cod_cta_ctbl, cod_estab, cod_unid_negoc, cod_plano_ccusto, cod_ccusto, cod_proj_financ, dat_sdo_ctbl, cod_finalid_econ, num_orig_movto_empenh, des_contdo_movto
- **orgmvtmp_proj_financ**: cod_proj_financ
- **orgmvtmp_unid_negoc**: cod_unid_negoc

---

## Tabela: orig_movto_fluxo_cx
**Label**: Perc Consid Origem
**Descrição**: Valor Percentual Considerado Origem

### Chave Primária
- num_id_movto_fluxo_cx, num_id_orig_movto_fluxo_cx, ind_orig_movto_fluxo_cx, cod_modul_dtsul

### Índices
- **orgmvtfl_gerac**: num_id_movto_fluxo_cx, dat_gerac_movto, hra_gerac_movto
- **orgmvtfl_mvtflx**: cod_modul_dtsul, num_id_movto_fluxo_cx
- **orgmvtfl_orig**: num_fluxo_cx, cod_modul_dtsul, ind_orig_movto_fluxo_cx, num_id_orig_movto_fluxo_cx

---

## Tabela: orig_sales_tax_item_apb
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_refer, num_seq_refer, cod_jurisd_pagto_sales_tax, cod_jurisd_dest_sales_tax

### Índices

---

## Tabela: orig_sales_tax_tit_ap
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_id_tit_ap, cod_jurisd_pagto_sales_tax, cod_jurisd_dest_sales_tax

### Índices
- **orgslsta_origem**: cod_estab, num_id_tit_acr

---

## Tabela: padr_col_balanct
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_padr_col_balanct

### Índices

---

## Tabela: padr_col_demonst_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_padr_col_demonst_ctbl

### Índices

---

## Tabela: padr_fluxo_cx
**Label**: Sdo Prev  Informado
**Descrição**: Valor Previs�o In�cio Informada

### Chave Primária
- cod_padr_fluxo_cx

### Índices

---

## Tabela: pag_livro_fisc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_organ, cod_modul_dtsul, ind_tip_livro_fisc, num_livro_fisc, dat_fim_emis

### Índices
- **pglvrfs_dat_inic**: cod_unid_organ, cod_modul_dtsul, ind_tip_livro_fisc, dat_inic_emis

---

## Tabela: pagto_padr
**Label**: Perc Multa Atraso
**Descrição**: Percentual Multa Atraso

### Chave Primária
- cod_empresa, cod_pagto_padr

### Índices
- **pgtpdr_espec_docto_financ**: cod_espec_docto
- **pgtpdr_finalid_econ**: cod_finalid_econ
- **pgtpdr_fornecedor**: cdn_fornecedor
- **pgtpdr_fornec_financ**: cod_empresa, cdn_fornecedor
- **pgtpdr_portador**: cod_portador
- **pgtpdr_portad_finalid_econ**: cod_estab, cod_portador, cod_cart_bcia, cod_finalid_econ

---

## Tabela: pagto_pend
**Label**: Valor Pagamento
**Descrição**: Valor Pagamento

### Chave Primária
- num_seq_pagto_pend

### Índices
- **pgtpnd_clien**: num_cx_financ, cdn_cliente, dat_pagto
- **pgtpnd_refer**: cod_refer, cdn_cliente

---

## Tabela: pagto_provis_repet
**Label**: Valor T�tulo
**Descrição**: Valor T�tulo Contas a Pagar

### Chave Primária
- cod_empresa, cod_pagto_provis_repet

### Índices
- **pgtprvsr_pagto_padr**: cod_empresa, cod_pagto_padr

---

## Tabela: pais
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_pais

### Índices
- **pais_finalid_econ**: cod_finalid_econ_pais

---

## Tabela: palavra_chave
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_palavra_chave

### Índices

---

## Tabela: palavra_chave_idiom
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_palavra_chave, cod_idioma

### Índices
- **plvrchvd_des**: nom_palavra_chave

---

## Tabela: palavra_chave_topic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_topico, num_palavra_chave

### Índices
- **plvrchvt_palavra**: num_palavra_chave

---

## Tabela: param_adiant_emprest
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, dat_ult_atualiz, hra_ult_atualiz

### Índices

---

## Tabela: param_apb_apf
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, dat_ult_atualiz, hra_ult_atualiz

### Índices

---

## Tabela: param_bloq_exec_orctaria
**Label**: Percent Estouro
**Descrição**: Percentual Estouro Permitido

### Chave Primária
- num_tip_inform_organ, cod_inform_organ

### Índices

---

## Tabela: param_calc_bem_pat
**Label**: Residual M�nimo
**Descrição**: Valor Residual M�nimo

### Chave Primária
- num_id_bem_pat, cod_tip_calc, cod_cenar_ctbl, cod_finalid_econ

### Índices
- **prmclcbm_finalid_econ**: cod_finalid_econ
- **prmclcbm_seq**: num_id_bem_pat, cod_cenar_ctbl, cod_finalid_econ, num_seq_tip_calc

---

## Tabela: param_calc_cta
**Label**: Residual M�nimo
**Descrição**: Valor Residual M�nimo

### Chave Primária
- cod_empresa, cod_cta_pat, cod_tip_calc, cod_cenar_ctbl, cod_finalid_econ

### Índices
- **prmclcct_cenar_ctbl**: cod_cenar_ctbl
- **prmclcct_compos_calc**: cod_tip_calc, cod_grp_calc, cod_cenar_ctbl, cod_finalid_econ
- **prmclcct_finalid_econ**: cod_finalid_econ
- **prmclcct_grp_calc**: cod_grp_calc

---

## Tabela: param_calc_incorp_pat
**Label**: Residual M�nimo
**Descrição**: Valor Residual M�nimo

### Chave Primária
- num_id_bem_pat, num_seq_incorp_bem_pat, cod_tip_calc, cod_cenar_ctbl, cod_finalid_econ

### Índices
- **prmclcnc_seq**: num_id_bem_pat, num_seq_incorp_bem_pat, cod_cenar_ctbl, cod_finalid_econ, num_seq_tip_calc

---

## Tabela: param_calc_risco_cobr
**Label**: Pontua��o Cobran�a A
**Descrição**: Valor Pontua��o para Cobran�a Ativa

### Chave Primária
- cod_empresa, ind_param_risco_cobr_ativ, num_seq

### Índices

---

## Tabela: param_cash_gesplan
**Label**: Integra Movimentos CMG
### Chave Primária
- cod_empresa, dat_ult_atualiz, hra_ult_atualiz

### Índices

---

## Tabela: param_cenar_ctbl_apl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cenar_ctbl

### Índices

---

## Tabela: param_cobr_ativ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa

### Índices

---

## Tabela: param_conex_bco_histor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_bco_dados

### Índices
- **prmcnxbc_grpsr**: cod_grp_usuar_bco_histor

---

## Tabela: param_control_cx
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, dat_inic_valid, dat_fim_valid

### Índices

---

## Tabela: param_control_terc
**Label**: Tarifa Cobran�a
**Descrição**: Valor Tarifa Cobran�a

### Chave Primária
- cod_estab, num_seq_param_control_terc, dat_ult_atualiz, hra_ult_atualiz

### Índices
- **prmcntrl_data**: cod_estab, dat_inic_valid
- **prmcntrl_empresa**: cod_empresa

---

## Tabela: param_conven_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_param_conven

### Índices

---

## Tabela: param_cta_ctbl_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_finalid_econ, ind_finalid_ctbl

### Índices

---

## Tabela: param_ctbz
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_modul_dtsul, cod_empresa

### Índices
- **prmctbz_uo**: cod_empresa, cod_modul_dtsul

---

## Tabela: param_ctbz_avp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, ind_modul_dtsul_avp, dat_ult_atualiz, hra_ult_atualiz

### Índices
- **prmctbzv_mod**: ind_modul_dtsul_avp, cod_empresa

---

## Tabela: param_ctbz_comis
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_comis_vda_estab, num_seq_param_comis_vda, ind_tip_movto_ctbl, cdn_motiv_movto_comis

### Índices
- **prmctbzc_emp_cod_seq_motiv**: cod_empresa, cod_comis_vda_estab, num_seq_param_comis_vda, cdn_motiv_movto_comis
- **prmctbzc_emp_numid** (Unique): cod_empresa, num_id_param_ctbz_comis

---

## Tabela: param_ctbz_cta_pat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_cta_pat, cod_cenar_ctbl, cod_finalid_econ, ind_finalid_ctbl, dat_inic_valid

### Índices
- **ctbzctpt_cta_ctbl_integr_alter**: cod_modul_dtsul, cod_plano_cta_ctbl, cod_cta_ctbl_alter, ind_tip_cta_ctbl
- **ctbzctpt_cta_ctbl_integr_cr**: cod_modul_dtsul, cod_plano_cta_ctbl, cod_cta_ctbl_cr, ind_finalid_ctbl
- **ctbzctpt_cta_ctbl_integr_db**: cod_modul_dtsul, cod_plano_cta_ctbl, cod_cta_ctbl_db, ind_finalid_ctbl

---

## Tabela: param_darf_ap
**Label**: % Multa Limite
**Descrição**: Percentual de Multa Limite

### Chave Primária
- dat_ult_atualiz, hra_ult_atualiz

### Índices

---

## Tabela: param_demonst_public
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_demonst_ctbl_public

### Índices
- **prmdmnst_demonst**: cod_demonst_ctbl
- **prmdmnst_padr_col**: cod_padr_col_demonst_ctbl

---

## Tabela: param_emis_msg_cobr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_process_msg_cobr

### Índices

---

## Tabela: param_empres_acr
**Label**: Val Min Retenc Impto
**Descrição**: Valor Minimo Retencao Imposto

### Chave Primária
- cod_empresa, dat_ult_atualiz, hra_ult_atualiz

### Índices
- **prmmprsc_usuario**: cod_usuar_ult_atualiz

---

## Tabela: param_empres_apb
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, dat_ult_atualiz, hra_ult_atualiz

### Índices
- **prmmprsp_finalid_econ**: cod_finalid_histor_fornec
- **prmmprsp_finecon_val**: cod_finalid_econ_val_usuar
- **prmmprsp_usuario**: cod_usuar_ult_atualiz

---

## Tabela: param_empres_aprovac_val
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_tip_proces_eec, num_seq_param_aprovac_tot, dat_ult_atualiz, hra_ult_atualiz

### Índices
- **prmmprsd_aprovac**: cod_empresa, cod_plano_aprovac_eec, cod_unid_aprovac
- **prmmprsd_tpprcspr**: cod_tip_proces_eec

---

## Tabela: param_empres_eec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, dat_ult_atualiz, hra_ult_atualiz

### Índices
- **prmmprse_ctactbl**: cod_plano_cta_ctbl, cod_cta_ctbl
- **prmmprse_frncdr**: cod_empresa, cdn_fornecedor

---

## Tabela: param_empres_pat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, dat_ult_atualiz, hra_ult_atualiz

### Índices
- **prmmprsa_finalid_cm**: cod_finalid_econ_base_cm
- **prmmprsa_usuar**: cod_usuar_ult_atualiz

---

## Tabela: param_empres_shc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa

### Índices

---

## Tabela: param_emvia_ftp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_param_emvia_ftp

### Índices

---

## Tabela: param_enctro_cta_apb
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, ind_modul_enctro_cta

### Índices

---

## Tabela: param_estab_acr
**Label**: Multa
**Descrição**: Valor Percentual Multa ACR

### Chave Primária
- cod_estab, num_seq_param_estab_acr, dat_ult_atualiz, hra_ult_atualiz

### Índices
- **prmstbcr_cndcbrcr**: cod_estab, cod_cond_cobr_acr_padr
- **prmstbcr_data**: cod_estab, dat_inic_valid
- **prmstbcr_usuario**: cod_usuar_ult_atualiz

---

## Tabela: param_estab_apb
**Label**: Val Min Liber Pagto
**Descrição**: Valor M�nimo para Libera��o Pagamento

### Chave Primária
- cod_estab, dat_ult_atualiz, hra_ult_atualiz

### Índices
- **prmstbpb_msg_fim_bord**: cod_estab, cod_msg_fim_bord
- **prmstbpb_msg_ini_bord**: cod_estab, cod_msg_inic_bord
- **prmstbpb_usuario**: cod_usuar_ult_atualiz

---

## Tabela: param_estab_aprovac_val
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_despes_eec, num_seq_param_val_despes, dat_ult_atualiz, hra_ult_atualiz

### Índices

---

## Tabela: param_estab_cart_bcia
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, dat_ult_atualiz, hra_ult_atualiz

### Índices
- **prmstbca_imposto**: cod_pais, cod_unid_federac, cod_imposto

---

## Tabela: param_estab_cmg
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, dat_ult_atualiz, hra_ult_atualiz

### Índices
- **prmstbcb_tpxrcctb**: cod_cenar_ctbl_fluxo_cx

---

## Tabela: param_estab_comis
**Label**: Max Comiss�o
**Descrição**: Percentual M�ximo Comiss�o

### Chave Primária
- cod_empresa, cod_comis_vda_estab, num_seq_param_comis_vda

### Índices

---

## Tabela: param_estab_inadimp
**Label**: Percentual Multa
**Descrição**: Valor Percentual Multa

### Chave Primária
- cod_estab, dat_ult_atualiz, hra_ult_atualiz

### Índices

---

## Tabela: param_estab_vendor
**Label**: % Integr CFL
**Descrição**: Valor Percentual Integra��o da Parcela c/ Fluxo Caixa

### Chave Primária
- cod_estab, dat_inic_valid

### Índices
- **prmstbvn_pessoa1**: num_pessoa_fisic_vendor_1
- **prmstbvn_pessoa2**: num_pessoa_fisic_vendor_2

---

## Tabela: param_event_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_param_event

### Índices

---

## Tabela: param_extrat_cria_autom
**Label**: Maximo Liberado
**Descrição**: Valor Maximo Liberado

### Chave Primária
- cod_layout_extrat, num_seq_reg_layout_extrat, cod_tip_lancto_extrat

### Índices

---

## Tabela: param_geral_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- dat_ult_atualiz, hra_ult_atualiz

### Índices
- **prmgrlcr_usuario**: cod_usuar_ult_atualiz

---

## Tabela: param_geral_apb
**Label**: Valor Minimo GPS
**Descrição**: Valor Minimo GPS

### Chave Primária
- dat_ult_atualiz, hra_ult_atualiz

### Índices
- **prmgrlpb_usuario**: cod_usuar_ult_atualiz

---

## Tabela: param_geral_apl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- dat_ult_atualiz, hra_ult_atualiz

### Índices

---

## Tabela: param_geral_bgc
**Label**: % de Encerrmto Orcto
**Descrição**: Percentual de Encerramento de Orcamento

### Chave Primária
- dat_ult_atualiz, hra_ult_atualiz

### Índices

---

## Tabela: param_geral_bgc_modul
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_modul_dtsul, dat_ult_atualiz, hra_ult_atualiz

### Índices

---

## Tabela: param_geral_cfl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- dat_ult_atualiz, hra_ult_atualiz

### Índices
- **prmgrlcf_finalid**: cod_finalid_econ

---

## Tabela: param_geral_cmg
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- dat_ult_atualiz, hra_ult_atualiz

### Índices

---

## Tabela: param_geral_eec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- dat_ult_atualiz, hra_ult_atualiz

### Índices
- **prmgrlc_atvdpssj**: cod_ativid_pessoa_transp, cod_ativid_pessoa_hotel
- **prmgrlc_espcdct**: cod_espec_acerto_cta, cod_espec_adiant
- **prmgrlc_fnldcn**: cod_finalid_econ

---

## Tabela: param_geral_ems
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- dat_ult_atualiz, hra_ult_atualiz

### Índices
- **prmgrlms_idioma**: cod_idiom_princ

---

## Tabela: param_geral_event_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_usuar_ult_atualiz, dat_ult_atualiz, hra_ult_atualiz

### Índices

---

## Tabela: param_geral_gld
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- dat_ult_atualiz, hra_ult_atualiz

### Índices
- **prmgrlgl_usuario**: cod_usuar_ult_atualiz

---

## Tabela: param_geral_pat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- dat_ult_atualiz, hra_ult_atualiz

### Índices
- **prmgrlpt_usuario**: cod_usuar_ult_atualiz

---

## Tabela: param_geral_sco
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- dat_ult_atualiz, hra_ult_atualiz

### Índices
- **prmgrlsb_ctactbl_comis**: cod_plano_cta_ctbl_comis, cod_cta_ctbl_comis
- **prmgrlsb_ctactbl_estorn**: cod_plano_cta_ctbl_estorn, cod_cta_ctbl_estorn
- **prmgrlsb_espcdctf**: cod_espec_docto_antecip
- **prmgrlsb_usuario**: cod_usuar_ult_atualiz

---

## Tabela: param_integr_cfl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_modul_dtsul, ind_param_integr_cfl

### Índices

---

## Tabela: param_integr_ems
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- ind_param_integr_ems

### Índices

---

## Tabela: param_integr_mais_negoc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, dat_ult_atualiz, hra_ult_atualiz

### Índices

---

## Tabela: param_integr_techfin
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, dat_ult_atualiz, hra_ult_atualiz

### Índices

---

## Tabela: param_integr_tpi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, dat_ult_atualiz, hra_ult_atualiz

### Índices

---

## Tabela: param_inter_div
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, dat_inic_valid

### Índices

---

## Tabela: param_mktplace
**Label**: Percentual Comiss�o
**Descrição**: Percentual Comiss�o

### Chave Primária
- cod_empresa, cdn_mktplace

### Índices

---

## Tabela: param_monit_ativ
**Label**: Usu�rio
**Descrição**: C�digo Usu�rio

### Chave Primária
- cod_empresa, cod_usuario

### Índices

---

## Tabela: param_msg_cobr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_mensagem, num_seq_param_msg_cobr

### Índices
- **prmmsgcb_clssfmsg**: cod_classif_msg_cobr
- **prmmsgcb_data**: cod_estab, cod_mensagem, dat_fim_valid

---

## Tabela: param_orcto_fluxo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cenar_orctario, cod_unid_orctaria, num_seq_orcto_ctbl, cod_vers_orcto_ctbl, cod_cenar_ctbl, cod_exerc_ctbl, num_period_ctbl, cod_empresa, cod_plano_cta_ctbl, cod_cta_ctbl, cod_plano_ccusto, cod_ccusto, cod_estab, cod_unid_negoc, cod_proj_financ

### Índices
- **prmrctfl_token** (Unique): num_id_param_orcto_fluxo

---

## Tabela: param_pat_internac
**Label**: Representante Legal
**Descrição**: N�mero Pessoa Representante Legal

### Chave Primária
- cod_empresa

### Índices

---

## Tabela: param_rat_adiant_emprest
**Label**: Perc Rateio
**Descrição**: Percentual Rateado

### Chave Primária
- cod_empresa, ind_tip_rat_adiant_emprest, num_seq_rat

### Índices

---

## Tabela: param_regra_perda_dedut
**Label**: Saldo Vencido
**Descrição**: Valor Saldo Vencido Titulo ACR Inicial

### Chave Primária
- cod_regra_perda_dedut, qti_dias_atraso_perda_dedut

### Índices

---

## Tabela: param_tef
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, dat_inic_valid, dat_fim_valid

### Índices

---

## Tabela: param_utiliz_produt
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_modul_dtsul, cod_funcao_negoc

### Índices
- **prmtlzcm_func_negoc**: cod_funcao_negoc
- **prmtlzcm_modulo**: cod_modul_dtsul

---

## Tabela: parc_cond_pagto
**Label**: Percentual Pagamento
**Descrição**: Valor Percentual do Pagamento

### Chave Primária
- cod_estab, cod_cond_pagto, num_seq_cond_pagto, cod_parcela

### Índices

---

## Tabela: parc_desc_conven
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_movto_conven, num_seq_parc

### Índices
- **prcdsccn_event**: num_id_movto_event
- **prcdsccn_fornec**: cod_empresa, cdn_fornecedor

---

## Tabela: parc_operac_financ
**Label**: Valor Principal
**Descrição**: Valor Principal Parcela Pagamento

### Chave Primária
- num_id_operac_financ, num_parcela, ind_tip_parc_emprest

### Índices
- **prcprcfn_situacao**: ind_sit_parc_pagto, dat_vencto_parc, cod_empresa

---

## Tabela: parc_pagto_conven
**Label**: Parcela
**Descrição**: Valor Parcela

### Chave Primária
- num_id_movto_conven, num_seq_parc

### Índices
- **prcpgtcn_tit**: cod_estab, num_id_tit_ap

---

## Tabela: parc_process_negoc_cx
**Label**: Parcela
**Descrição**: Valor Parcela

### Chave Primária
- num_cx_financ, num_process_negoc, num_seq_forma_pagto_cx, num_seq_parc

### Índices

---

## Tabela: parc_tab_financ
**Label**: Perc Financiamento
**Descrição**: Valor Percentual de Financiamento

### Chave Primária
- cod_tab_financ, cod_parcela

### Índices

---

## Tabela: parc_vendor
**Label**: Saldo Original
**Descrição**: Valor Saldo Original

### Chave Primária
- cod_estab, num_planilha_vendor, num_seq_parc_vendor

### Índices
- **prcvndr_id_parc_vendor** (Unique): cod_estab, num_id_parc_vendor
- **prcvndr_situacao**: cod_estab, ind_sit_parc_vendor, num_id_parc_vendor
- **prcvndr_tit_acr** (Unique): cod_estab_tit_acr, num_id_tit_acr

---

## Tabela: parcei_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_parcei_edi

### Índices
- **prcd_prmmvftp**: cdn_param_emvia_ftp

---

## Tabela: parcei_mapa_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_trans_edi, ind_finalid_mapa_edi, cdn_parcei_edi, cdn_mapa_orig_edi, cdn_mapa_edi

### Índices
- **prcmpd_prcd**: cdn_parcei_edi
- **prcmpd_validade**: cdn_trans_edi, dat_inic_valid_mapa_edi

---

## Tabela: parcei_prvdor_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_parcei_edi, cdn_prvdor_edi

### Índices
- **prcprvdr_prvdrd**: cdn_prvdor_edi

---

## Tabela: parcei_spc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_parcei_spc

### Índices
- **prcspc_pessoa_jurid** (Unique): num_pessoa_jurid

---

## Tabela: parcei_spc_tip_movto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_parcei_spc, cod_tip_movto_spc

### Índices
- **prcspcta_tip_movto_parcei** (Unique): cod_parcei_spc, cod_tip_movto_parcei_spc

---

## Tabela: parcei_trans_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_parcei_edi, cdn_trans_edi

### Índices
- **prctrnsd_transedi**: cdn_trans_edi

---

## Tabela: parid_indic_econ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_indic_econ_base, cod_indic_econ_idx

### Índices
- **prdndccn_finalid_orig**: cod_finalid_econ_orig_cotac
- **prdndccn_indic_econ_idx**: cod_indic_econ_idx

---

## Tabela: passag_eec
**Label**: Valor Passagem
**Descrição**: Valor Servi�o Contratado Passagem

### Chave Primária
- num_id_proces_prestac_cta, num_seq_rotei_viagem_eec

### Índices
- **pssgc_fnldcn**: cod_finalid_econ
- **pssgc_lclmbrqv**: cod_local_saida_viagem_eec, cod_local_chegad_viagem_eec

---

## Tabela: passag_solicit_viagem
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, num_id_ped_reserve, num_id_passageiro

### Índices
- **pssgslct_emis**: cdn_passageiro, dat_emis

---

## Tabela: pcte_cta_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_pcte_cta_ctbl

### Índices

---

## Tabela: ped_vda_tit_acr
**Label**: Saldo Pedido Venda
**Descrição**: Valor Saldo Pedido Venda

### Chave Primária
- cod_estab, num_id_tit_acr, cod_ped_vda

### Índices
- **pdvdttcr_cliente**: cod_empresa, cdn_cliente, cod_ped_vda
- **pdvdttcr_ped_repres**: cod_estab, cod_ped_vda_repres
- **pdvdttcr_ped_vda**: cod_estab, cod_ped_vda
- **pdvdttcr_repres**: cod_empresa, cdn_repres, cod_ped_vda_repres

---

## Tabela: ped_vda_tit_acr_pend
**Label**: Particip Ped Vda
**Descrição**: Percentual de Participa��o do Pedido de  Venda

### Chave Primária
- cod_estab, cod_refer, num_seq_refer, cod_ped_vda

### Índices

---

## Tabela: pend_diverg_mktplace
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_movto_mktplace, num_diverg_mktplace

### Índices
- **pnddvrgm_dat**: dat_pend, ind_status_pend
- **pnddvrgm_orig**: ind_tip_orig_pend, dat_pend
- **pnddvrgm_orig_dat**: dat_pend, ind_tip_orig_pend
- **pnddvrgm_status**: ind_status_pend, dat_pend

---

## Tabela: perc_particip_acion
**Label**: Perc Particip Acion
**Descrição**: Valor Percentual da Participa��o Acion�ria

### Chave Primária
- cod_unid_organ_orig, cod_plano_cta_ctbl_orig, cod_mapa_distrib_gerc_ctbl, num_seq_particip

### Índices
- **prcprtcp_dat**: cod_unid_organ_orig, cod_plano_cta_ctbl_orig, cod_mapa_distrib_gerc_ctbl, dat_inic_particip

---

## Tabela: perf_cobr_ativ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_perf_cobr_ativ, num_seq

### Índices

---

## Tabela: perf_cobr_ativ_base
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_perf_cobr_ativ

### Índices

---

## Tabela: perf_usuar_cobr_ativ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario, cod_perf_cobr_ativ

### Índices
- **prfsrcbr_prfcbrta**: cod_perf_cobr_ativ

---

## Tabela: perf_usuar_inadimp
**Label**: % Limite Desconto
**Descrição**: Valor Percentual Limite para Desconto

### Chave Primária
- cod_usuario

### Índices

---

## Tabela: period_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cenar_ctbl, cod_exerc_ctbl, num_period_ctbl

### Índices
- **prdctbl_fim**: cod_cenar_ctbl, dat_fim_period_ctbl, dat_inic_period_ctbl
- **prdctbl_ini**: cod_cenar_ctbl, dat_inic_period_ctbl, dat_fim_period_ctbl

---

## Tabela: perm_usuar_cx
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuar

### Índices

---

## Tabela: permis_grp_ccusto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_ccusto, dat_inic_valid, dat_fim_valid, cod_estab, cod_plano_ccusto, cod_ccusto

### Índices

---

## Tabela: pessoa_fisic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_pessoa_fisic

### Índices
- **pssfsca_ident**: cod_id_feder, cod_id_estad_fisic
- **pssfsca_identpes**: nom_pessoa, cod_id_estad_fisic, cod_unid_federac_emis_estad, dat_nasc_pessoa_fisic, nom_mae_pessoa
- **pssfsca_id_feder_fisic**: cod_pais, cod_id_feder
- **pssfsca_matriz**: num_pessoa_fisic_matriz
- **pssfsca_unid_federac**: cod_pais, cod_unid_federac

---

## Tabela: pessoa_fisic_ativid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_pessoa_fisic, cod_ativid_pessoa_fisic

### Índices
- **pssfsctv_ativid**: cod_ativid_pessoa_fisic

---

## Tabela: pessoa_fisic_compl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_pessoa_fisic

### Índices

---

## Tabela: pessoa_fisic_depend
**Label**: Pessoa F�sica
**Descrição**: N�mero Pessoa F�sica

### Chave Primária
- num_pessoa_fisic, cod_id_feder

### Índices

---

## Tabela: pessoa_fisic_pensao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_pessoa_fisic, nom_pensao

### Índices

---

## Tabela: pessoa_jurid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_pessoa_jurid

### Índices
- **pssjrda_cobranca**: num_pessoa_jurid_cobr
- **pssjrda_ident**: cod_id_feder, cod_id_estad_jurid
- **pssjrda_id_feder_jurid**: cod_pais, cod_id_feder
- **pssjrda_id_previd_social**: cod_pais, cod_id_previd_social
- **pssjrda_matriz**: num_pessoa_jurid_matriz
- **pssjrda_pagto**: num_pessoa_jurid_pagto
- **pssjrda_razao_social**: nom_pessoa
- **pssjrda_unid_federac**: cod_pais, cod_unid_federac
- **pssjrda_unid_feder_cobr**: cod_pais_cobr, cod_unid_federac_cobr
- **pssjrda_unid_feder_pagto**: cod_pais_pagto, cod_unid_federac_pagto

---

## Tabela: pessoa_jurid_ativid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_pessoa_jurid, cod_ativid_pessoa_jurid

### Índices
- **pssjrdtv_atividade**: cod_ativid_pessoa_jurid

---

## Tabela: pessoa_jurid_ramo_negoc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_pessoa_jurid, cod_ramo_negoc

### Índices
- **pssjrdrm_ramo_negoc**: cod_ramo_negoc

---

## Tabela: planilha_vendor
**Label**: Valor Total
**Descrição**: Valor Total do Contrato Vendor

### Chave Primária
- cod_estab, num_planilha_vendor

### Índices
- **plnlhvnd_cliente**: cod_empresa, cdn_cliente, dat_fechto_vendor
- **plnlhvnd_codigo_banco**: cod_estab, cod_portador, cod_cart_bcia, cod_planilha_vendor_bco, cod_digito_planilha_bco
- **plnlhvnd_dat_fecham**: cod_estab, dat_fechto_vendor, cod_portador, cod_cart_bcia, cod_finalid_econ
- **plnlhvnd_ind_sit_planilha** (Unique): ind_sit_planilha_vendor, log_vendor_confdo, cod_estab, num_planilha_vendor
- **plnlhvnd_metod_calc**: cod_metod_calc_vendor
- **plnlhvnd_pessoa1**: num_pessoa_fisic_vendor_1
- **plnlhvnd_pessoa2**: num_pessoa_fisic_vendor_2
- **plnlhvnd_portador**: cod_estab, cod_portador, cod_cart_bcia, cod_finalid_econ, dat_fechto_vendor
- **plnlhvnd_repres**: cod_empresa, cdn_repres

---

## Tabela: plano_acao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cenar_orctario, cod_unid_orctaria, num_seq_orcto_ctbl, cod_vers_orcto_ctbl, cod_cenar_ctbl, cod_exerc_ctbl, num_period_ctbl, cod_plano_cta_ctbl, cod_cta_ctbl, cod_plano_ccusto, cod_ccusto, cod_regra, ind_tip_justif_orcto, num_seq_acao

### Índices

---

## Tabela: plano_aprovac_despes_eec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_estab, cod_plano_aprovac_eec

### Índices

---

## Tabela: plano_ccusto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_plano_ccusto

### Índices
- **plnccst_tit_ctbl**: des_tit_ctbl

---

## Tabela: plano_cta_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_plano_cta_ctbl

### Índices
- **plnctctl_tit_ctbl**: des_tit_ctbl
- **plnctctl_tpgrpctc**: cod_tip_grp_cta_ctbl

---

## Tabela: plano_cta_unid_organ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_plano_cta_ctbl, cod_unid_organ, ind_tip_plano_cta_ctbl

### Índices
- **ndrgnplo_unid_organ**: cod_unid_organ, ind_tip_plano_cta_ctbl, dat_inic_valid, dat_fim_valid

---

## Tabela: portad_bco
**Label**: Perc Cr�dito Imed
**Descrição**: Valor Percentual Cr�dito Imediato

### Chave Primária
- cod_modul_dtsul, cod_estab, cod_portador, cod_cart_bcia, cod_finalid_econ

### Índices
- **prtdbc_cart**: cod_cart_bcia
- **prtdbc_portad**: cod_portador

---

## Tabela: portad_cartcred
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_contrat_cartcred, cod_portad_cartcred

### Índices

---

## Tabela: portad_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_modul_dtsul, cod_estab, cod_portador, cod_cart_bcia, cod_finalid_econ

### Índices
- **prtdd_cartbcia**: cod_cart_bcia
- **prtdd_fnldcn**: cod_finalid_econ
- **prtdd_portador**: cod_portador
- **prtdd_prtdbc**: cod_estab, cod_portador, cod_cart_bcia, cod_finalid_econ

---

## Tabela: portad_estab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_portador

### Índices
- **prtdstb_portad**: cod_portador

---

## Tabela: portad_finalid_econ
**Label**: Saldo Cobran�a
**Descrição**: Valor Saldo Cobran�a

### Chave Primária
- cod_estab, cod_portador, cod_cart_bcia, cod_finalid_econ

### Índices
- **prtdfnld_cartbcia**: cod_cart_bcia
- **prtdfnld_cta_corren**: cod_cta_corren
- **prtdfnld_finalid_econ**: cod_finalid_econ
- **prtdfnld_portador**: cod_portador

---

## Tabela: portad_inadimp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_portador, cod_cart_bcia, cod_finalid_econ

### Índices
- **prtdndmp_control_inad**: log_control_inadimp

---

## Tabela: portad_tit_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_id_tit_acr, num_seq

### Índices
- **prtdttcr_portad_dat**: cod_portador, dat_alter_portad

---

## Tabela: portador
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_portador

### Índices
- **portador_agenc_bcia**: cod_banco, cod_agenc_bcia
- **portador_pais**: cod_pais
- **portador_pessoa_juridica**: num_pessoa_jurid

---

## Tabela: porte_pessoa_jurid
**Label**: Vendas Funcion�rio
**Descrição**: Valor Vendas Funcion�rio

### Chave Primária
- num_pessoa_jurid, dat_porte_pessoa_jurid

### Índices
- **prtpssjr_indic_econ**: cod_indic_econ

---

## Tabela: pos_cod_barra
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_banco, cod_tip_inform, num_seq_inform_cod_barra

### Índices

---

## Tabela: pos_faturam_techfin
**Label**: Vl Total Geral Bonif
**Descrição**: Valor Total Geral Bonifica��o

### Chave Primária
- cod_empresa, cod_id_identif

### Índices
- **psftrmtc_dat_debito**: cod_empresa, ind_tip_techfin, dat_db
- **psftrmtc_entreg**: cod_empresa, log_dat_entreg, cod_trans_entreg
- **psftrmtc_erp**: cod_empresa, cod_erp, ind_tip_techfin
- **psftrmtc_modalid**: cod_empresa, cod_erp, ind_tip_modalid, ind_tip_techfin
- **psftrmtc_movto**: cod_empresa, ind_tip_techfin, dat_movto
- **psftrmtc_ret_proces**: cod_empresa, ind_tip_techfin, cod_ret_proces

---

## Tabela: pre_acaocap
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, dat_atoadm_shc, cod_clas_acaocap, cdd_acionista, num_seq_pre_acaocap

### Índices
- **prccp_acnst**: cdd_acionista
- **prccp_corretor**: cdd_corretor
- **prccp_emp_dat_ac_cl**: cod_empresa, dat_atoadm_shc, cdd_acionista, cod_clas_acaocap
- **prccp_orgccp**: cod_orig_acaocap

---

## Tabela: pre_movto_divndo_acion
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cdd_acionista, cod_clas_acaocap, cdd_cautela

### Índices
- **prmvtdvn_exec_distrib**: cod_empresa, log_transf_divndo, cdd_movto_acaocap

---

## Tabela: prefer_demonst_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario, cod_demonst_ctbl, cod_padr_col_demonst_ctbl

### Índices
- **prfrdmns_dmnstctl**: cod_demonst_ctbl
- **prfrdmns_pdrcldmn**: cod_padr_col_demonst_ctbl

---

## Tabela: prefer_usuar_cfl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario

### Índices

---

## Tabela: prefer_usuar_cmg
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario

### Índices
- **prfrsrcm_ctcrrn**: cod_cta_corren
- **prfrsrcm_tpxrcctb**: cod_cenar_ctbl
- **prfrsrcm_undfchtc**: cod_unid_fechto_cx

---

## Tabela: prefix_cartao_cr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_admdra_cartao_cr, cod_cartao_cr, num_prefix_cartao_cr

### Índices
- **prfxcrtc_prefix**: num_prefix_cartao_cr

---

## Tabela: prefix_rejtdo_cartao_cr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_admdra_cartao_cr, cod_cartao_cr, num_prefix_rejtdo_cartao_cr

### Índices

---

## Tabela: prefix_serv_public
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_conces_telef, num_prefix_serv_public

### Índices

---

## Tabela: proces_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_proces_edi

### Índices
- **prcsd_dat**: cdn_trans_edi, dat_gerac_proces_edi
- **prcsd_dest**: cdn_trans_edi, cdn_mapa_dest_edi
- **prcsd_mapaedi**: cdn_trans_edi, cdn_mapa_orig_edi

---

## Tabela: proces_esoc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_process_judic

### Índices

---

## Tabela: proces_pagto
**Label**: Valor saldo liberado
**Descrição**: Valor saldo liberado

### Chave Primária
- cod_estab, cod_espec_docto, cod_ser_docto, cdn_fornecedor, cod_tit_ap, cod_parcela, cod_refer_antecip_pef, num_seq_pagto_tit_ap

### Índices
- **prcspgt_antec_pef**: cod_estab, cod_refer_antecip_pef
- **prcspgt_desconto**: cod_estab, cod_espec_docto, ind_sit_proces_pagto, dat_desconto
- **prcspgt_estab_fornec_sit**: cod_estab, cdn_fornecedor, ind_sit_proces_pagto
- **prcspgt_previs_pagto**: cod_estab, cod_espec_docto, ind_sit_proces_pagto, dat_prev_pagto
- **prcspgt_usuar_libe_pagto**: cod_usuar_liber_pagto, ind_sit_proces_pagto
- **prcspgt_usuar_pagto**: cod_usuar_pagto, ind_sit_proces_pagto
- **prcspgt_usuar_prep_pagto**: cod_usuar_prepar_pagto, ind_sit_proces_pagto

---

## Tabela: proces_prestac_cta_eec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cdn_func_financ, cdn_prestac_cta

### Índices
- **prcsprst_grpvgmc**: cod_estab, cdn_prestac_cta, cod_grp_viagem_eec, cdn_func_financ
- **prcsprst_plan_aprov**: cod_estab, cdn_func_financ, cod_unid_aprovac, cod_plano_aprovac_eec, cod_empresa
- **prcsprst_solic_viag**: cod_empresa, num_id_ped_reserve
- **prcsprst_token** (Unique): num_id_proces_prestac_cta
- **prcsprst_tpprcspr**: cod_tip_proces_eec

---

## Tabela: proces_trans
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_trans, cdn_proces_trans

### Índices

---

## Tabela: process_forma_pagto_cx
**Label**: Val Multa
**Descrição**: Valor da Multa aplicado no Processo de Pagamento

### Chave Primária
- num_cx_financ, num_process_negoc, num_seq_forma_pagto_cx

### Índices

---

## Tabela: process_integr_comis
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cdn_repres, cod_indic_econ, num_proces_integr_comis

### Índices
- **prcssntg_dt**: cod_empresa, dat_gerac_proces, hra_gerac_proces

---

## Tabela: process_negoc_cx
**Label**: Valor Processo
**Descrição**: Valor do Processo

### Chave Primária
- num_cx_financ, num_process_negoc

### Índices
- **prcssngc_clien**: cdn_cliente, ind_tip_process, ind_sit_process
- **prcssngc_dt_proc**: num_cx_financ, dat_process_negoc, cdn_cliente, cod_refer
- **prcssngc_refer**: cod_refer, cdn_cliente

---

## Tabela: process_negoc_cx_abat
**Label**: Vl Vinc Abatiment AN
**Descrição**: Valor Vinculado Abatimento Antecipa��o

### Chave Primária
- num_seq

### Índices
- **prcssngd_antecip**: num_cx_financ_antecip, num_process_negoc_antecip
- **prcssngd_pagto**: num_cx_financ_pagto, num_process_negoc_pagto

---

## Tabela: process_negoc_cx_cartao
**Label**: Valor Pagto Cart�o
**Descrição**: Valor Pagamento Cart�o

### Chave Primária
- num_cx_financ, num_process_negoc, num_seq_forma_pagto_cx, num_seq_parc

### Índices

---

## Tabela: process_negoc_cx_cheq
**Label**: Valor Vinculado
**Descrição**: Valor Vinculado ao Titulo

### Chave Primária
- num_cx_financ, num_process_negoc, num_seq_forma_pagto_cx, num_seq_process_cheq

### Índices
- **prcssnga_cheq**: cod_banco, cod_agenc_bcia, cod_cta_corren, num_cheq

---

## Tabela: produc_period
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_cta_pat, cod_plano_ccusto, cod_ccusto_respons, cod_exerc_ctbl, num_period_ctbl

### Índices

---

## Tabela: produt_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_produt_financ

### Índices

---

## Tabela: produt_financ_bco
**Label**: Taxa Del credere
**Descrição**: Valor Taxa Del credere

### Chave Primária
- cod_banco, cod_produt_financ, num_seq_produt_financ

### Índices

---

## Tabela: programac_sched_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_trans_edi, num_programac_edi

### Índices
- **prgrmcsc_pedido** (Unique): num_ped_exec_edi
- **prgrmcsc_prcd**: cdn_parcei_edi
- **prgrmcsc_srvdxc**: cod_servid_exec_edi
- **prgrmcsc_transped** (Unique): cdn_trans_edi, num_ped_exec_edi

---

## Tabela: proj_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_proj_financ

### Índices
- **prjfnnc_proj_ext**: cod_proj_ext

---

## Tabela: proj_financ_estab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_proj_financ, cod_estab

### Índices
- **prjfnncs_estab**: cod_estab, dat_inic_valid, dat_fim_valid

---

## Tabela: proj_operac_financ
**Label**: Percentual Projeto
**Descrição**: Valor Percentual Projeto Investimento

### Chave Primária
- num_id_operac_financ, cod_estab, cod_proj_invest

### Índices

---

## Tabela: prvdor_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_prvdor_edi

### Índices

---

## Tabela: quant_produz
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_bem_pat, cod_unid_negoc, cod_empresa, cod_plano_ccusto, cod_ccusto, dat_refer

### Índices
- **qntprdz_unid_negoc**: cod_unid_negoc

---

## Tabela: ramo_negoc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_ramo_negoc

### Índices

---

## Tabela: rastreab_cash_gesplan
**Label**: Pedido Execu��o
### Chave Primária
- cod_empresa, cod_modul_dtsul, cod_tabela, dat_ult_exec

### Índices

---

## Tabela: rastreab_movto_mktplace
**Label**: Valor do Movimento
**Descrição**: Valor do Movimento

### Chave Primária
- num_movto_mktplace

### Índices
- **rstrbmvt_acr**: cod_estab, num_id_tit_acr, num_id_movto_tit_acr
- **rstrbmvt_cmg**: num_id_movto_cta_corren
- **rstrbmvt_item**: cod_empresa, num_lote_mktplace, num_seq_lote_mktplace
- **rstrbmvt_refer**: cod_refer

---

## Tabela: rat_adiant_emprest
**Label**: Valor Rateio
**Descrição**: Valor do Rateio

### Chave Primária
- num_id_adiant_emprest, num_seq_rat

### Índices

---

## Tabela: rat_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_rat_ctbl

### Índices
- **ratctbl_cenar_ctbl**: cod_cenar_ctbl

---

## Tabela: rat_ctbl_control_cx
**Label**: Percentual Rateio
**Descrição**: Valor Percentual Rateio Cont�bil

### Chave Primária
- cod_empresa, dat_inic_valid, dat_fim_valid, ind_tip_rat_ctbl, num_seq_rat_ctbl, cod_tip_fluxo_financ

### Índices

---

## Tabela: rat_ctbl_dest
**Label**: Percentual Rateio
**Descrição**: Valor Percentual Rateio Cont�bil

### Chave Primária
- cod_empresa, cod_rat_ctbl, num_seq_rat_ctbl, num_ord_seq_rat_ctbl

### Índices
- **rtctbldt_ccusto**: cod_empresa, cod_plano_ccusto, cod_ccusto
- **rtctbldt_cta_ctbl**: cod_plano_cta_ctbl, cod_cta_ctbl
- **rtctbldt_estab**: cod_estab
- **rtctbldt_histor_padr**: cod_histor_padr
- **rtctbldt_unid_negoc**: cod_unid_negoc

---

## Tabela: rat_ctbl_dest_mapa
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_rat_ctbl, num_seq_rat_ctbl, num_ord_seq_rat_ctbl, cod_estab, cod_mapa_distrib_ccusto

### Índices
- **rtctblds_mpdstrbc**: cod_estab, cod_mapa_distrib_ccusto

---

## Tabela: rat_ctbl_orig
**Label**: Percentual Rateio
**Descrição**: Valor Percentual Rateio Cont�bil

### Chave Primária
- cod_empresa, cod_rat_ctbl, num_seq_rat_ctbl, num_ord_seq_rat_ctbl

### Índices
- **rtctblr_ccusto_fim**: cod_empresa, cod_plano_ccusto, cod_ccusto_fim
- **rtctblr_ccusto_inic**: cod_empresa, cod_plano_ccusto, cod_ccusto_inic
- **rtctblr_cta_ctbl_fim**: cod_plano_cta_ctbl, cod_cta_ctbl_fim
- **rtctblr_cta_ctbl_inic**: cod_plano_cta_ctbl, cod_cta_ctbl_inic
- **rtctblr_estab_fim**: cod_estab_fim
- **rtctblr_estab_inic**: cod_estab_inic
- **rtctblr_unid_negoc_fim**: cod_unid_negoc_fim
- **rtctblr_unid_negoc_inic**: cod_unid_negoc_inic

---

## Tabela: rat_despes
**Label**: Rateio Despesa
**Descrição**: Valor Rateio Despesa Presta��o Conta

### Chave Primária
- num_seq_rat_eec, num_id_despes_eec

### Índices

---

## Tabela: rat_financ_cmg
**Label**: Valor Movimento
**Descrição**: Valor do Movimento de Conta Corrente

### Chave Primária
- num_id_movto_cta_corren, cod_estab, cod_unid_negoc, cod_tip_fluxo_financ

### Índices
- **rtfnnccm_token** (Unique): num_id_rat_financ_cmg
- **rtfnnccm_tpflxfnn**: cod_tip_fluxo_financ, dat_movto_cta_corren

---

## Tabela: rat_motiv_movto_tit_acr
**Label**: Perc Rateio
**Descrição**: Percentual Rateio Contabiliza��o

### Chave Primária
- cod_estab, cod_motiv_movto_tit_acr, cod_plano_cta_ctbl, cod_cta_ctbl, cod_unid_negoc, cod_plano_ccusto, cod_ccusto, cod_tip_fluxo_financ

### Índices
- **rtmtvmvt_plnctctl**: cod_plano_cta_ctbl
- **rtmtvmvt_rec_des**: cod_tip_fluxo_financ

---

## Tabela: rat_movto_tit_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_id_movto_tit_acr, num_seq

### Índices
- **rtmvtttc_rat** (Unique): cod_estab, num_id_movto_tit_acr, cod_unid_negoc, cod_plano_cta_ctbl, cod_cta_ctbl, cod_plano_ccusto, cod_ccusto, cod_tip_fluxo_financ

---

## Tabela: rat_movto_tit_ap
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_id_movto_tit_ap, num_seq

### Índices
- **rtmvtttp_rat** (Unique): cod_estab, num_id_movto_tit_ap, cod_unid_negoc, cod_plano_cta_ctbl, cod_cta_ctbl, cod_plano_ccusto, cod_ccusto, cod_tip_fluxo_financ

---

## Tabela: rat_operac_financ
**Label**: Perc Rateio
**Descrição**: Percentual Rateio Contabiliza��o

### Chave Primária
- num_id_operac_financ, cod_unid_negoc, cod_estab

### Índices

---

## Tabela: rat_padr_apl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_rat_padr_apl

### Índices

---

## Tabela: rat_padr_apl_un_estab
**Label**: Perc Rateio
**Descrição**: Percentual Rateio Contabiliza��o

### Chave Primária
- cod_rat_padr_apl, cod_unid_negoc, cod_estab

### Índices

---

## Tabela: rat_padr_pagto
**Label**: Perc Rateio
**Descrição**: Percentual Rateio Contabiliza��o

### Chave Primária
- cod_empresa, cod_pagto_padr, cod_plano_cta_ctbl, cod_cta_ctbl, cod_unid_negoc, cod_plano_ccusto, cod_ccusto, cod_tip_fluxo_financ

### Índices
- **rtpdrpgt_ccusto**: cod_empresa, cod_plano_ccusto, cod_ccusto
- **rtpdrpgt_cta_ctbl_integr**: cod_plano_cta_ctbl, cod_cta_ctbl
- **rtpdrpgt_recta_despes**: cod_empresa, cod_tip_fluxo_financ
- **rtpdrpgt_tip_recta_despes**: cod_tip_fluxo_financ
- **rtpdrpgt_unid_negoc**: cod_unid_negoc

---

## Tabela: rat_param_conven_financ
**Label**: Perc Rateio
**Descrição**: Percentual Rateado

### Chave Primária
- cod_param_conven, num_seq_rat

### Índices

---

## Tabela: rat_param_ctbz
**Label**: Perc Rateio
**Descrição**: Percentual Rateio Contabiliza��o

### Chave Primária
- cod_empresa, num_id_rat_param_ctbz, num_id_param_ctbz_comis

### Índices
- **rtprmctb_emp_param_ctbz_comis**: cod_empresa, num_id_param_ctbz_comis

---

## Tabela: rat_param_event_financ
**Label**: Perc Rateio
**Descrição**: Percentual Rateado

### Chave Primária
- cod_param_event, ind_natur_rat, num_seq_rat

### Índices

---

## Tabela: rat_recebto_padr
**Label**: Perc Rateio
**Descrição**: Percentual Rateio Contabiliza��o

### Chave Primária
- cod_empresa, cod_recebto_padr, cod_plano_cta_ctbl, cod_cta_ctbl, cod_unid_negoc, cod_plano_ccusto, cod_ccusto, cod_tip_fluxo_financ

### Índices

---

## Tabela: reaval_bem_pat_internac
**Label**: Saldo L�quido Ano
**Descrição**: Valor Saldo L�quido Ano

### Chave Primária
- num_id_bem_pat, num_seq_incorp_bem_pat, cod_cenar_ctbl, cod_finalid_econ, num_ano, num_mes

### Índices
- **rvlbmptn_data**: num_id_bem_pat, num_seq_incorp_bem_pat, num_ano, num_mes

---

## Tabela: recebto_padr
**Label**: Perc Multa Atraso
**Descrição**: Percentual Multa Atraso

### Chave Primária
- cod_empresa, cod_recebto_padr

### Índices

---

## Tabela: recep_msg_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_msg_edi, cod_recep_edi

### Índices
- **rcpmsgd_srmstr**: cod_recep_edi

---

## Tabela: recibo
**Label**: Valor Recibo
**Descrição**: Valor do Recibo

### Chave Primária
- num_recibo

### Índices
- **recibo_data**: dat_recibo, cod_refer, cdn_cliente

---

## Tabela: recolhto_recta
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_recolhto_recta, cod_variac

### Índices

---

## Tabela: refer_integr_cmg
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cta_corren, dat_movto_cta_corren, cod_tip_trans_cx

### Índices

---

## Tabela: reg_calc_bem_pat
**Label**: Vl Transf Custo Atr
**Descrição**: Valor Transfer�ncia do Custo Atribu�do

### Chave Primária
- num_id_bem_pat, num_seq_incorp_bem_pat, cod_tip_calc, cod_cenar_ctbl, cod_finalid_econ, dat_calc_pat, num_seq_reg_calc_bem_pat

### Índices
- **rgclcbmp_aprop_ctbl** (Unique): num_seq_reg_calc_bem_pat
- **rgclcbmp_aprpctb**: num_id_aprop_ctbl_cta_pat
- **rgclcbmp_calculo**: num_id_bem_pat, num_seq_incorp_bem_pat, cod_tip_calc, cod_cenar_ctbl, cod_finalid_econ, dat_calc_pat, ind_orig_calc_bem_pat
- **rgclcbmp_ctbz**: num_id_bem_pat, num_seq_incorp_bem_pat, log_ctbz_bem_pat, dat_calc_pat
- **rgclcbmp_dat_calc_pat**: cod_tip_calc, cod_cenar_ctbl, cod_finalid_econ, dat_calc_pat
- **rgclcbmp_estab**: cod_estab
- **rgclcbmp_ind_trans**: ind_trans_calc_bem_pat
- **rgclcbmp_movto**: num_id_bem_pat, num_seq_incorp_bem_pat, cod_cenar_ctbl, cod_finalid_econ, num_seq_movto_bem_pat, dat_calc_pat
- **rgclcbmp_prmclcbm**: num_id_bem_pat, cod_tip_calc, cod_cenar_ctbl, cod_finalid_econ
- **rgclcbmp_sdo**: num_id_bem_pat, num_seq_incorp_bem_pat, cod_cenar_ctbl, cod_finalid_econ, dat_calc_pat

---

## Tabela: reg_layout_fisc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_fisc, cod_reg_layout_fisc

### Índices

---

## Tabela: reg_movto_aloc_bem_pat
**Label**: Perc Apropria��o
**Descrição**: Valor Percentual de Apropria��o

### Chave Primária
- num_id_bem_pat, cod_unid_negoc, cod_empresa, cod_plano_ccusto, cod_ccusto, dat_fim_valid, dat_transacao, hra_transacao

### Índices

---

## Tabela: reg_movto_bem_pat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_bem_pat, dat_refer, dat_transacao, hra_transacao

### Índices
- **rgmvtbmp_ctrrspns**: cod_empresa, cod_plano_ccusto, cod_ccusto_respons, dat_inic_valid

---

## Tabela: reg_movto_incorp_bem
**Label**: Perc Anual Dpr Incen
**Descrição**: Valor Percentual Anual Deprecia��o Incentivada

### Chave Primária
- num_id_bem_pat, num_seq_incorp_bem_pat, cod_cenar_ctbl, dat_incorp_bem_pat, ind_incorp_bem_pat, dat_transacao, hra_transacao

### Índices
- **rgmvtncr_ncntfsc**: cod_incent_fisc
- **rgmvtncr_ndccn**: cod_indic_econ
- **rgmvtncr_tipcalc**: cod_tip_calc_reaval
- **rgmvtncr_tpxrcctb**: cod_cenar_ctbl

---

## Tabela: reg_movto_param_calc
**Label**: Residual M�nimo
**Descrição**: Valor Residual M�nimo

### Chave Primária
- num_id_bem_pat, cod_tip_calc, cod_cenar_ctbl, cod_finalid_econ, dat_transacao, hra_transacao

### Índices
- **rgmvtprm_prmclcbm**: num_id_bem_pat, cod_tip_calc, cod_cenar_ctbl, cod_finalid_econ, dat_inic_calc

---

## Tabela: reg_planilha_orctaria
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_reg_planilha

### Índices
- **rgplnlhr_layout**: cod_layout_planilha_orcto

---

## Tabela: reg_proces_entr_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_proces_edi, cdn_seq_reg_proces_edi

### Índices

---

## Tabela: reg_proces_saida_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_proces_edi, cdn_seq_reg_proces_edi

### Índices

---

## Tabela: regra_calc_var_orcto
**Label**: Perc Var CtaCtbl Neg
**Descrição**: Percentual Varia��o Conta Cont�bil (-)

### Chave Primária
- cod_regra, dat_inic_valid, dat_fim_valid

### Índices

---

## Tabela: regra_concil_cta_corren
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_regra_concil_cta_corren

### Índices

---

## Tabela: regra_extrat_bcio
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario, num_id_regra_extrat

### Índices

---

## Tabela: regra_msg_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_modul_dtsul, cod_grp_usuar, ind_trans_msg_usuar, cod_msg_usuar, num_seq_regra_msg_usuar

### Índices

---

## Tabela: regra_pagto_cx
**Label**: Valor Regra
**Descrição**: Valor Regra

### Chave Primária
- num_regra

### Índices
- **rgrpgtcx_fluxo**: ind_fluxo_regra

---

## Tabela: regra_perda_dedut
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_regra_perda_dedut

### Índices

---

## Tabela: regra_ranking_bcio
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_regra_ranking_bcio

### Índices

---

## Tabela: regra_usuar_inadimp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario, num_seq_regra

### Índices
- **rgrsrndm_regra**: ind_tip_regra_usuar_inadimp

---

## Tabela: relac_aprop_leas_incorp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_arrendador, cod_contrat_leas, cod_cenar_ctbl, dat_pagto, log_amort, dat_ctbz, hra_ctbz, num_id_bem_pat, num_seq_incorp_bem_pat

### Índices

---

## Tabela: relac_lancto_concil_tpi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, dat_concil, cod_trans_tpi, num_seq

### Índices
- **rlclnctc_crrn**: num_id_movto_cta_corren
- **rlclnctc_lt**: cod_empresa, num_lote_tpi

---

## Tabela: relac_movto_cobr_inadimp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cdn_cliente, num_seq_movto_cobr_tit_acr, num_seq

### Índices
- **rlcmvtca_ttndmp**: cod_estab, num_id_tit_acr

---

## Tabela: relac_movto_cobr_tit_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cdn_cliente, num_seq_movto_cobr_tit_acr, num_seq

### Índices
- **rlcmvtcb_tit_acr**: cod_estab, num_id_tit_acr

---

## Tabela: relac_movto_tit_acr_avp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_id_tit_acr, num_id_movto_tit_acr

### Índices
- **rlcmvttt_movto**: num_id_movto_tit_acr, num_id_tit_acr

---

## Tabela: relac_movto_tit_ap_avp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_id_tit_ap, num_id_movto_tit_ap

### Índices
- **rlcmvtta_movto**: num_id_movto_tit_ap, num_id_tit_ap

---

## Tabela: relac_parc_cartcred
**Label**: Valor Total Parcelas
**Descrição**: Valor Total Parcelas Cart�o de Cr�dito

### Chave Primária
- cod_estab, num_id_tit_acr_pai, num_id_tit_acr

### Índices
- **rlcprccr_tit_acr** (Unique): cod_estab, num_id_tit_acr

---

## Tabela: relacto_acum_pagto
**Label**: Rendto Tribut�vel
**Descrição**: Valor Rendimento Tribut�vel

### Chave Primária
- cod_estab, num_id_movto_tit_ap, num_pessoa, dat_refer, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto

### Índices
- **rlctcmpg_acum_pagto_pessoa**: cod_estab, num_pessoa, dat_refer, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto

---

## Tabela: relacto_cancel_mais_neg
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_relac_cancel_parc

### Índices
- **rlctcnca_can**: cod_empresa, cod_id_identif
- **rlctcnca_mvt**: cod_estab, num_id_tit_acr, num_id_movto_tit_acr
- **rlctcnca_mvt_cta_tx**: num_id_movto_cta_corren

---

## Tabela: relacto_cheq_acr
**Label**: Valor Vinculado
**Descrição**: Valor Vinculado do Cheque ACR

### Chave Primária
- cod_estab, num_id_movto_tit_acr, cod_banco, cod_agenc_bcia, cod_cta_corren_bco, num_cheque

### Índices
- **rlctchqc_cheq**: cod_banco, cod_agenc_bcia, cod_cta_corren_bco, num_cheque

---

## Tabela: relacto_cheq_acr_ap
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_id_movto_tit_ap, cod_banco, cod_agenc_bcia, cod_cta_corren, num_cheque

### Índices
- **rlctchqa_cheq**: cod_banco, cod_agenc_bcia, cod_cta_corren, num_cheque

---

## Tabela: relacto_clien_terc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_id_feder, cod_empresa, cdn_cliente

### Índices
- **rlctclnt_clien**: cod_empresa, cdn_cliente

---

## Tabela: relacto_devol_tit_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab_tit_acr, num_id_movto_tit_acr, cod_estab_ncredito_antecip, num_id_movto_ncredito_ant

### Índices
- **rlctdvlt_nc_an**: cod_estab_ncredito_antecip, num_id_movto_ncredito_ant

---

## Tabela: relacto_item_lote_tpi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, num_lote_tpi, num_seq_lote_tpi, cod_tabela, cod_estab, num_id_tit_acr, num_id_movto_tit_acr, num_id_movto_cta_corren

### Índices
- **rlcttmlt_movto_cta_corren**: num_id_movto_cta_corren
- **rlcttmlt_movto_tit_acr**: cod_estab, num_id_tit_acr, num_id_movto_tit_acr

---

## Tabela: relacto_iva_cheq_acr
**Label**: Rendto Tribut�vel
**Descrição**: Valor Rendimento Tribut�vel

### Chave Primária
- num_id_cheq_acr, cod_pais, cod_unid_federac, cod_imposto, cod_classif_impto

### Índices

---

## Tabela: relacto_lancto_particip
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_aprop_lancto_ctbl

### Índices
- **rlctlnct_dat**: dat_trans_lancto, cod_modul_dtsul
- **rlctlnct_part**: num_pessoa_particip

---

## Tabela: relacto_movto_comis
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cdn_repres, num_seq_movto_comis, cod_estab_tit_acr, num_id_movto_tit_acr, cod_estab_tit_ap, num_id_movto_tit_ap

### Índices
- **rlctmvtc_acr**: cod_estab_tit_acr, num_id_movto_tit_acr
- **rlctmvtc_ap**: cod_estab_tit_ap, num_id_movto_tit_ap

---

## Tabela: relacto_parc_mais_negoc
**Label**: Valor Taxa Parcela
**Descrição**: Valor Taxa Parcela

### Chave Primária
- cod_trans_mais_negoc, num_parcela, cod_estab, num_id_tit_acr

### Índices
- **rlctprcm_tit**: cod_estab, num_id_tit_acr

---

## Tabela: relacto_particip
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_estab, cod_relacto_particip

### Índices
- **rlctprtc_part**: cod_empresa, cod_relacto_particip

---

## Tabela: relacto_particip_pessoa
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_estab, cod_relacto_particip, num_pessoa_particip, dat_inic_valid

### Índices
- **rlctprta_part**: cod_empresa, cod_relacto_particip, dat_inic_valid, dat_fim_valid
- **rlctprta_pessoa**: num_pessoa_particip, dat_inic_valid, dat_fim_valid

---

## Tabela: relacto_pend_cheq_acr
**Label**: Valor Vinculado
**Descrição**: Valor Vinculado do Cheque ACR

### Chave Primária
- cod_estab, cod_refer, num_seq_refer, cod_banco, cod_agenc_bcia, cod_cta_corren_bco, num_cheque

### Índices
- **rlctpndc_cheque**: cod_banco, cod_agenc_bcia, cod_cta_corren_bco, num_cheque

---

## Tabela: relacto_pend_tit_acr
**Label**: Vl Relacto
**Descrição**: Valor do Relacionamento dos T�tulos

### Chave Primária
- cod_estab, cod_refer, num_seq_refer, cod_estab_tit_acr_pai, num_id_tit_acr_pai, num_id_movto_tit_acr_pai

### Índices
- **rlctpnda_empresa**: cod_empresa
- **rlctpnda_tit_acr**: cod_estab_tit_acr_pai, num_id_tit_acr_pai

---

## Tabela: relacto_pend_tit_ap
**Label**: Valor
**Descrição**: Relacionamento T�tulo Contas a Pagar

### Chave Primária
- cod_estab, cod_refer, num_seq_refer, cod_estab_tit_ap_pai, num_id_tit_ap_pai

### Índices
- **rlctpndt_empresa**: cod_empresa
- **rlctpndt_tit_ap**: cod_estab_tit_ap_pai, num_id_tit_ap_pai

---

## Tabela: relacto_pos_faturam
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_relacto_pos_faturam

### Índices
- **rlctpsft_event**: cod_empresa, cod_id_identif, cod_tabela
- **rlctpsft_lancto_conc**: cod_empresa, cod_id_concil, cod_id_cta_concil, cod_id_lancto_concil
- **rlctpsft_mov_cta_cor**: num_id_movto_cta_corren
- **rlctpsft_mov_tit_acr**: cod_estab, num_id_tit_acr, num_id_movto_tit_acr

---

## Tabela: relacto_process_integr
**Label**: Vl Subtotal sem IR
**Descrição**: Valor Sub Total sem IR

### Chave Primária
- cod_empresa, cdn_repres, cod_indic_econ, num_proces_integr_comis, cod_estab, num_id_tit_ap, num_id_movto_tit_ap, num_seq_movto_comis

### Índices
- **rlctprcs_comis**: cod_empresa, cdn_repres, num_seq_movto_comis
- **rlctprcs_proc**: num_proces_integr_comis
- **rlctprcs_tit**: cod_estab, num_id_tit_ap, num_id_movto_tit_ap

---

## Tabela: relacto_reg_planilha
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_reg_planilha, cod_cenar_orctario, cod_unid_orctaria, num_seq_orcto_ctbl, cod_vers_orcto_ctbl

### Índices
- **rlctrgpl_vers**: cod_cenar_orctario, cod_unid_orctaria, num_seq_orcto_ctbl, cod_vers_orcto_ctbl

---

## Tabela: relacto_tit_acr
**Label**: Vl Relacto
**Descrição**: Valor do Relacionamento dos T�tulos

### Chave Primária
- cod_estab, num_id_tit_acr, cod_estab_tit_acr_pai, num_id_tit_acr_pai, num_id_movto_tit_acr_pai

### Índices
- **rlctttcr_fatura**: num_fatur_acr
- **rlctttcr_faturacr**: cod_estab, num_fatur_acr
- **rlctttcr_movto_pai**: cod_estab_tit_acr_pai, num_id_movto_tit_acr_pai
- **rlctttcr_tit_pai**: cod_estab_tit_acr_pai, num_id_tit_acr_pai

---

## Tabela: relacto_tit_ap
**Label**: Valor
**Descrição**: Relacionamento T�tulo Contas a Pagar

### Chave Primária
- cod_estab, num_id_tit_ap, cod_estab_tit_ap_pai, num_id_movto_tit_ap_pai

### Índices
- **rlctttp_movto_pai**: cod_estab_tit_ap_pai, num_id_movto_tit_ap_pai

---

## Tabela: relacto_tit_em_bco
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- dat_refer_arq_tit_em_bco, cod_sist_nac_bcio, cod_agenc_bcia, cod_vers_arq_tit_em_bco, num_seq, num_seq_tit_contra_empres

### Índices
- **rlctttmb_titap**: cod_estab, num_id_tit_ap

---

## Tabela: relacto_unid_orctaria
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_orctaria, num_tip_inform_organ, cod_inform_organ

### Índices

---

## Tabela: remun_admdra_cartao_cr
**Label**: Perc Remunera��o
**Descrição**: Valor Percentual Remunera��o do Portador

### Chave Primária
- cod_admdra_cartao_cr, num_seq

### Índices

---

## Tabela: remun_outras_empres
**Label**: Sal�rio Contribui��o
**Descrição**: Valor Sal�rio Contribui��o

### Chave Primária
- cod_empresa, cdn_fornecedor, num_seq_remun_outras

### Índices

---

## Tabela: remun_parc_cartao_cr
**Label**: Perc Remun Parc
**Descrição**: Percentual de Remunera��o Venda Parcelada

### Chave Primária
- cod_admdra_cartao_cr, cod_band, num_parc_cartcred

### Índices

---

## Tabela: renegoc_acr
**Label**: Total Reajuste
**Descrição**: Valor Total Reajuste Renegociacao

### Chave Primária
- cod_estab, num_renegoc_cobr_acr

### Índices
- **rngccr_cli_dest**: cod_empresa, cdn_clien_dest
- **rngccr_clnfnnc**: cod_empresa, cdn_cliente
- **rngccr_estab_refer**: cod_estab, cod_refer
- **rngccr_tip_sit**: cod_empresa, ind_tip_renegoc_acr, ind_sit_renegoc_acr, num_renegoc_cobr_acr

---

## Tabela: renegoc_adiant_emprest
**Label**: Taxa Juros
**Descrição**: Valor Taxa Juros

### Chave Primária
- num_id_adiant_emprest, num_seq_renegoc

### Índices

---

## Tabela: renegoc_inadimp
**Label**: Percentual Multa
**Descrição**: Valor Percentual Multa

### Chave Primária
- cod_refer

### Índices
- **rngcndmp_atz**: log_refer_atlzdo
- **rngcndmp_cliente**: cod_empresa, cdn_cliente
- **rngcndmp_dt_trans**: dat_transacao

---

## Tabela: renegoc_inadimp_vencto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_refer, num_parcela

### Índices

---

## Tabela: renegoc_terc
**Label**: Tarifa Cobran�a
**Descrição**: Valor Tarifa Cobran�a

### Chave Primária
- cod_estab, num_renegoc_terc

### Índices
- **rngctrc_cliente**: cod_empresa, cdn_cliente
- **rngctrc_data**: cod_estab, dat_transacao
- **rngctrc_empresa**: cod_empresa, log_simul, num_renegoc_terc
- **rngctrc_emp_consulta**: cod_empresa, num_renegoc_terc

---

## Tabela: repas_conces_telef
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_conces_telef, num_dia_vencto_conces_telef

### Índices
- **rpscncst_dia_arrecadac**: cod_conces_telef, num_dia_arrecadac_conces

---

## Tabela: repas_pend_apl
**Label**: Valor Repas Pend
**Descrição**: Valor Repasse Pendente

### Chave Primária
- num_id_operac_financ, num_seq_repas_pend

### Índices
- **rpspndpl_dat**: num_id_operac_financ, dat_repas_pend, ind_tip_repas_pend
- **rpspndpl_sit**: num_id_operac_financ, ind_sit_repas_pend

---

## Tabela: repres_financ
**Label**: Comiss�o Indireta
**Descrição**: Valor Percentual Comissao Representante Indireto

### Chave Primária
- cod_empresa, cdn_repres

### Índices
- **rprsfnnc_tprprs**: cod_empresa, cod_tip_repres

---

## Tabela: repres_tit_acr
**Label**: % Comis Emiss�o
**Descrição**: Percentual Comiss�o Representante na Emiss�o

### Chave Primária
- cod_estab, num_id_tit_acr, cdn_repres

### Índices
- **rprsttcr_prmstbcm**: cod_empresa, cod_comis_vda_estab
- **rprsttcr_repres**: cod_empresa, cdn_repres, cdn_cliente, num_id_tit_acr
- **rprsttcr_sdotit**: cod_empresa, cdn_repres, log_sdo_tit_acr, cdn_cliente
- **rprsttcr_ultliquidaq**: cod_empresa, cdn_repres, dat_ult_liquidac_tit_acr

---

## Tabela: repres_tit_acr_fechado
**Label**: Valor Vinculado
**Descrição**: Valor Vinculado ao Titulo

### Chave Primária
- cod_empresa, cod_estab, cod_espec_docto, cod_ser_docto, cod_tit_acr, cod_parcela, cdn_repres, cod_classif

### Índices

---

## Tabela: repres_tit_acr_pend
**Label**: % Comis Emiss�o
**Descrição**: Percentual Comiss�o Representante na Emiss�o

### Chave Primária
- cod_estab, cod_refer, num_seq_refer, cdn_repres

### Índices

---

## Tabela: repres_tit_cancdo_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_estab, cod_espec_docto, cod_ser_docto, cod_tit_acr, cod_parcela, num_id_tit_acr, cdn_repres

### Índices

---

## Tabela: representante
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cdn_repres

### Índices
- **rprsntnt_grprprs**: cod_grp_repres
- **rprsntnt_nome_abrev** (Unique): cod_empresa, nom_abrev
- **rprsntnt_num_pessoa**: num_pessoa
- **rprsntnt_tprprs**: cod_empresa, cod_tip_repres

---

## Tabela: reserva_solicit_viagem
**Label**: Total Reserva
**Descrição**: Valor Total Reserva

### Chave Primária
- cod_empresa, num_id_ped_reserve, num_id_reserva

### Índices

---

## Tabela: residuo_acaocap
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_clas_acaocap, cdd_acionista, cdd_movto_residuo

### Índices
- **rsdccp_acnst**: cdd_acionista
- **rsdccp_clsccp**: cod_clas_acaocap

---

## Tabela: restric_ccusto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_plano_ccusto, cod_ccusto, cod_estab

### Índices
- **rstrccct_estabelecimento**: cod_estab

---

## Tabela: restric_clas_risco_cmg
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_clas_risco_clien

### Índices
- **rstrccls_clas_risco**: cod_clas_risco_clien

---

## Tabela: risco_cobr_ativ
**Label**: Pontua��o M�nima
**Descrição**: Valor Pontua��o M�nima

### Chave Primária
- cod_risco_cobr_ativ

### Índices

---

## Tabela: rota_eec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_rota_viagem

### Índices

---

## Tabela: rota_empres_transp_eec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_rota_viagem, num_pessoa_jurid

### Índices

---

## Tabela: rotei_viagem_eec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_proces_prestac_cta, num_seq_rotei_viagem_eec

### Índices
- **rtvgmc_hrrpssg**: cod_rota_viagem, num_seq_horar_passag, cod_tip_transp
- **rtvgmc_tptrnspc**: cod_tip_transp

---

## Tabela: sales_tax_item_impl_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_refer, num_seq_refer, cod_jurisd_sales_tax

### Índices

---

## Tabela: sales_tax_item_impl_apb
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_refer, num_seq_refer, cod_jurisd_sales_tax

### Índices

---

## Tabela: sales_tax_tit_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_id_tit_acr, cod_jurisd_sales_tax

### Índices

---

## Tabela: sales_tax_tit_ap
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_id_tit_ap, num_id_movto_tit_ap, cod_jurisd_sales_tax

### Índices

---

## Tabela: sdo_acr
**Label**: Sdo Variac Cambial
**Descrição**: Saldo Varia��o Cambial

### Chave Primária
- cod_estab, cod_unid_negoc, cod_grp_clien, cdn_cliente, ind_tip_espec_docto, cod_espec_docto, cod_tip_fluxo_financ, cod_finalid_econ

### Índices
- **sdoacr_clien_financ**: cod_empresa, cdn_cliente
- **sdoacr_espec_docto**: cod_espec_docto
- **sdoacr_finalid_econ**: cod_finalid_econ
- **sdoacr_recta_depes**: cod_tip_fluxo_financ
- **sdoacr_unid_negoc**: cod_unid_negoc

---

## Tabela: sdo_ap
**Label**: Sdo Variac Cambial
**Descrição**: Saldo Varia��o Cambial

### Chave Primária
- cod_estab, cod_unid_negoc, cod_grp_fornec, cdn_fornecedor, ind_tip_espec_docto, cod_espec_docto, cod_tip_fluxo_financ, cod_finalid_econ, dat_sdo_tit_ap

### Índices
- **sdoap_espec_docto**: cod_espec_docto
- **sdoap_finalid_econ**: cod_finalid_econ
- **sdoap_fornec_financ**: cod_empresa, cdn_fornecedor
- **sdoap_recta_despes**: cod_empresa, cod_tip_fluxo_financ
- **sdoap_unid_negoc**: cod_unid_negoc

---

## Tabela: sdo_bem_pat
**Label**: Vl Saldo Custo Atrib
**Descrição**: Valor do Saldo do Custo Atribu�do

### Chave Primária
- num_id_bem_pat, num_seq_incorp_bem_pat, cod_cenar_ctbl, cod_finalid_econ, dat_sdo_bem_pat, num_seq_movto_bem_pat

### Índices
- **sdbmpt_data**: num_id_bem_pat, num_seq_incorp_bem_pat, cod_cenar_ctbl, dat_sdo_bem_pat

---

## Tabela: sdo_cta_corren
**Label**: Sdo Inicial Realiz
**Descrição**: Saldo Inicial Realizado em Conta Corrente

### Chave Primária
- cod_cta_corren, cod_cenar_ctbl, dat_sdo_cta_corren

### Índices

---

## Tabela: sdo_cta_corren_painel
**Label**: Sdo Inicial Realiz
**Descrição**: Saldo Inicial Realizado em Conta Corrente

### Chave Primária
- cod_cta_corren, cod_cenar_ctbl, dat_sdo_cta_corren

### Índices
- **sdctcrrb_ctcrrn**: cod_cta_corren
- **sdctcrrb_tpxrcctb**: cod_cenar_ctbl

---

## Tabela: sdo_cta_corren_spool
**Label**: Valor Movimento
**Descrição**: Valor do Movimento de Conta Corrente

### Chave Primária
- cod_cta_corren, cod_cenar_ctbl, dat_sdo_cta_corren, num_seq_sdo_cta_corren

### Índices
- **sdctcrra_gerac**: dat_gerac_sdo_cta_corren, hra_gerac_sdo_cta_corren

---

## Tabela: sdo_cta_ctbl
**Label**: Saldo Cont�bil Final
**Descrição**: Valor Saldo Cont�bil Final

### Chave Primária
- cod_empresa, cod_finalid_econ, cod_plano_cta_ctbl, cod_cta_ctbl, cod_cenar_ctbl, cod_estab, cod_unid_negoc, dat_sdo_ctbl

### Índices
- **sdctctb_cenar_ctbl_dat**: cod_cenar_ctbl, dat_sdo_ctbl
- **sdctctb_cta_ctbl**: cod_plano_cta_ctbl, cod_cta_ctbl
- **sdctctb_estab**: cod_estab
- **sdctctb_finalid_econ**: cod_finalid_econ

---

## Tabela: sdo_cta_ctbl_ccusto
**Label**: Saldo Sint�tico
**Descrição**: Valor Saldo Contabil Fim Sintetico

### Chave Primária
- cod_empresa, cod_finalid_econ, cod_plano_cta_ctbl, cod_cta_ctbl, cod_cenar_ctbl, cod_estab, cod_unid_negoc, cod_plano_ccusto, cod_ccusto, dat_sdo_ctbl

### Índices
- **sdctctbl_ccusto**: cod_empresa, cod_plano_ccusto, cod_ccusto
- **sdctctbl_cenar_ctbl_dat**: cod_cenar_ctbl, dat_sdo_ctbl
- **sdctctbl_consulta**: cod_empresa, cod_finalid_econ, cod_cenar_ctbl, cod_plano_cta_ctbl, cod_cta_ctbl, cod_plano_ccusto, cod_ccusto
- **sdctctbl_cta_ctbl**: cod_plano_cta_ctbl, cod_cta_ctbl
- **sdctctbl_estab**: cod_estab
- **sdctctbl_finalid_econ**: cod_finalid_econ
- **sdctctbl_unid_negoc**: cod_unid_negoc

---

## Tabela: sdo_cta_ctbl_consolid
**Label**: Saldo Cont�bil Final
**Descrição**: Valor Saldo Cont�bil Final

### Chave Primária
- cod_unid_organ, cod_unid_organ_orig, cod_finalid_econ, cod_plano_cta_ctbl, cod_cta_ctbl, cod_cenar_ctbl, cod_unid_negoc, log_elimina_intercomp, dat_sdo_ctbl

### Índices
- **sdctctba_ctactbl**: cod_plano_cta_ctbl, cod_cta_ctbl
- **sdctctba_fnldcn**: cod_unid_organ, cod_finalid_econ
- **sdctctba_ndngc**: cod_unid_negoc
- **sdctctba_tpxrcctb**: cod_cenar_ctbl

---

## Tabela: sdo_cta_ctbl_modul
**Label**: Saldo
**Descrição**: Saldo

### Chave Primária
- cod_empresa, cod_finalid_econ, cod_modul_dtsul, cod_plano_cta_ctbl, cod_cta_ctbl, cod_plano_ccusto, cod_ccusto, cod_proj_financ, cod_cenar_ctbl, cod_estab, cod_unid_negoc, dat_fim_period_ctbl

### Índices
- **sdctctbb_est_dat**: cod_empresa, cod_modul_dtsul, cod_estab, dat_fim_period_ctbl
- **sdctctbb_modul**: cod_empresa, cod_estab, cod_finalid_econ, cod_modul_dtsul, dat_fim_period_ctbl
- **sdctctbb_mod_dat**: cod_empresa, cod_modul_dtsul, dat_fim_period_ctbl
- **sdctctbb_period**: cod_empresa, cod_cenar_ctbl, cod_finalid_econ, dat_fim_period_ctbl, cod_estab

---

## Tabela: sdo_ctbl
**Label**: Saldo Sint�tico
**Descrição**: Valor Saldo Contabil Fim Sintetico

### Chave Primária
- cod_empresa, cod_finalid_econ, cod_plano_cta_ctbl, cod_cta_ctbl, cod_plano_ccusto, cod_ccusto, cod_proj_financ, cod_cenar_ctbl, cod_estab, cod_unid_negoc, dat_sdo_ctbl

### Índices
- **sdoctbl_ccusto**: cod_empresa, cod_plano_ccusto, cod_ccusto
- **sdoctbl_cenar_ctbl**: cod_cenar_ctbl, dat_sdo_ctbl
- **sdoctbl_consulta_ccusto**: cod_empresa, cod_finalid_econ, cod_cenar_ctbl, cod_plano_ccusto, cod_ccusto, cod_plano_cta_ctbl, cod_cta_ctbl, cod_proj_financ
- **sdoctbl_consulta_proj_financ**: cod_empresa, cod_finalid_econ, cod_cenar_ctbl, cod_proj_financ, cod_plano_cta_ctbl, cod_cta_ctbl, cod_plano_ccusto, cod_ccusto
- **sdoctbl_cta_ctbl**: cod_plano_cta_ctbl, cod_cta_ctbl
- **sdoctbl_estab**: cod_estab
- **sdoctbl_finalid_econ**: cod_finalid_econ
- **sdoctbl_proj_financ**: cod_proj_financ
- **sdoctbl_sped**: cod_empresa, cod_finalid_econ, cod_plano_cta_ctbl, cod_cenar_ctbl, dat_sdo_ctbl, cod_plano_ccusto
- **sdoctbl_unid_negoc**: cod_unid_negoc

---

## Tabela: sdo_fluxo_cx
**Label**: Valor Realizado
**Descrição**: Valor Realizado de Fluxo de Caixa

### Chave Primária
- num_fluxo_cx, cod_unid_control_financ, cod_tip_fluxo_financ, dat_sdo_fluxo_cx

### Índices
- **sdflxcx_ucf_dat**: num_fluxo_cx, cod_unid_control_financ, dat_sdo_fluxo_cx

---

## Tabela: sdo_fluxo_cx_spool
**Label**: Valor Movto
**Descrição**: Valor do Movimento de Fluxo Caixa

### Chave Primária
- num_fluxo_cx, cod_unid_control_financ, cod_tip_fluxo_financ, dat_sdo_fluxo_cx, num_seq_sdo_fluxo_cx

### Índices
- **sdflxcxs_gerac**: dat_gerac_sdo_fluxo_cx, hra_gerac_sdo_fluxo_cx

---

## Tabela: sdo_iof_pend
**Label**: Valor Movto Sdo IOF
**Descrição**: Valor Movimento Saldo IOF Pendente

### Chave Primária
- num_id_operac_financ, num_seq_sdo_iof_pend

### Índices
- **sdfpnd_movto** (Unique): num_id_operac_financ, num_id_movto_operac_financ

---

## Tabela: sdo_orcto_cta_ccusto
**Label**: Or�ado Sint�tico
**Descrição**: Valor Or�ado Sint�tico

### Chave Primária
- cod_unid_organ, cod_cenar_orctario, cod_cenar_ctbl, cod_exerc_ctbl, cod_vers_orcto_ctbl, num_period_ctbl, cod_plano_cta_ctbl, cod_cta_ctbl, cod_estab, cod_unid_negoc, cod_plano_ccusto, cod_ccusto

### Índices
- **sdrctcta_ccusto**: cod_unid_organ, cod_plano_ccusto, cod_ccusto
- **sdrctcta_period_ctbl**: cod_cenar_ctbl, cod_exerc_ctbl, num_period_ctbl

---

## Tabela: sdo_orcto_cta_ctbl
**Label**: Saldo Or�ado
**Descrição**: Valor Saldo do Valor Or�ado

### Chave Primária
- cod_unid_organ, cod_cenar_orctario, cod_cenar_ctbl, cod_exerc_ctbl, cod_vers_orcto_ctbl, num_period_ctbl, cod_plano_cta_ctbl, cod_cta_ctbl, cod_estab, cod_unid_negoc

### Índices
- **sdrctctt_cta_ctbl**: cod_plano_cta_ctbl, cod_cta_ctbl

---

## Tabela: sdo_orcto_ctbl_bgc
**Label**: Saldo Or�ado
**Descrição**: Valor Saldo do Valor Or�ado

### Chave Primária
- cod_cenar_orctario, cod_unid_orctaria, num_seq_orcto_ctbl, cod_vers_orcto_ctbl, cod_cenar_ctbl, cod_exerc_ctbl, num_period_ctbl, cod_empresa, cod_plano_cta_ctbl, cod_cta_ctbl, cod_plano_ccusto, cod_ccusto, cod_estab, cod_unid_negoc, cod_proj_financ

### Índices
- **sdrctctb_ccusto**: cod_empresa, cod_plano_ccusto, cod_ccusto
- **sdrctctb_cta_ctbl**: cod_plano_cta_ctbl, cod_cta_ctbl
- **sdrctctb_estab**: cod_estab
- **sdrctctb_period_ctbl**: cod_cenar_ctbl, cod_exerc_ctbl, num_period_ctbl
- **sdrctctb_proj_financ**: cod_proj_financ
- **sdrctctb_reg_planilha**: cod_reg_planilha
- **sdrctctb_unid_negoc**: cod_unid_negoc

---

## Tabela: segment_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_segment_edi

### Índices

---

## Tabela: segment_element_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_segment_edi, cdn_element_edi

### Índices
- **sgmntlmn_elmntd**: cdn_element_edi
- **sgmntlmn_num_pos_inicial**: num_pos_inicial_element_edi
- **sgmntlmn_num_seq_element_edi**: num_seq_element_edi

---

## Tabela: segur_aces_tab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, nom_tab_shc

### Índices

---

## Tabela: segur_ajust_sit_period
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cenar_ctbl, cod_empresa, cod_modul_dtsul, ind_sit_period_ctbl, cod_grp_usuar

### Índices
- **sgrjstst_grpsr**: cod_grp_usuar
- **sgrjstst_modul_dtsul**: cod_modul_dtsul

---

## Tabela: segur_ccusto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_plano_ccusto, cod_ccusto, cod_grp_usuar

### Índices
- **sgrccsta_grp_usuar**: cod_grp_usuar

---

## Tabela: segur_cenar_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_cenar_ctbl, cod_grp_usuar

### Índices
- **sgrcnrct_grpsr**: cod_grp_usuar

---

## Tabela: segur_cta_corren
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cta_corren, cod_grp_usuar

### Índices
- **sgrctcrr_grp_usuar**: cod_grp_usuar

---

## Tabela: segur_demonst_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_demonst_ctbl, cod_grp_usuar

### Índices
- **sgrdmnst_grp_usuar**: cod_grp_usuar

---

## Tabela: segur_padr_bco_tip_cheq
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_banco, cod_tip_cheq, cod_grp_usuar

### Índices
- **sgrpdrbc_grp_usuar**: cod_grp_usuar

---

## Tabela: segur_padr_fluxo_cx
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_padr_fluxo_cx, cod_grp_usuar

### Índices
- **sgrpdrfl_grpsr**: cod_grp_usuar

---

## Tabela: segur_plano_cta_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_plano_cta_ctbl, cod_unid_organ, cod_grp_usuar

### Índices
- **sgrplnca_grp_usuar**: cod_grp_usuar

---

## Tabela: segur_proces_prestac_cta
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_proces_eec, cod_grp_usuar

### Índices

---

## Tabela: segur_proj_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_proj_financ, cod_grp_usuar

### Índices
- **sgrprjfn_grp_usuar**: cod_grp_usuar

---

## Tabela: segur_restric_cta_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_organ, cod_plano_cta_ctbl, cod_cta_ctbl, cod_grp_usuar

### Índices
- **sgrrstrc_ctactbl**: cod_plano_cta_ctbl, cod_cta_ctbl
- **sgrrstrc_grpsr**: cod_grp_usuar

---

## Tabela: segur_rh_grp_ccusto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_ccusto, dat_inic_valid, dat_fim_valid, cod_plano_cta_ctbl, cod_cta_ctbl, cod_usuar

### Índices

---

## Tabela: segur_talon_cheq
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cta_corren, num_talon_cheq, cod_grp_usuar

### Índices
- **sgrtlnch_grp_usuar**: cod_grp_usuar

---

## Tabela: segur_tip_trans_cx
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_trans_cx, cod_grp_usuar

### Índices
- **sgrtptrn_grp_usuar**: cod_grp_usuar

---

## Tabela: segur_unid_control
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_control_financ, cod_grp_usuar

### Índices
- **sgrndcnt_grp_usuar**: cod_grp_usuar

---

## Tabela: segur_unid_fechto_cx
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_fechto_cx, cod_grp_usuar

### Índices
- **sgrndfch_grp_usuar**: cod_grp_usuar

---

## Tabela: segur_unid_negoc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_negoc, cod_grp_usuar

### Índices
- **sgrndngc_grp_usuar**: cod_grp_usuar

---

## Tabela: segur_unid_organ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_organ, cod_grp_usuar

### Índices
- **sgrndrgn_grp_usuar**: cod_grp_usuar

---

## Tabela: segur_vers_orcto_bgc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cenar_orctario, cod_unid_orctaria, num_seq_orcto_ctbl, cod_vers_orcto_ctbl, cod_grp_usuar

### Índices
- **sgrvrsra_grp_usuar**: cod_grp_usuar

---

## Tabela: segur_vers_orcto_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_organ, cod_cenar_orctario, cod_cenar_ctbl, cod_exerc_ctbl, cod_vers_orcto_ctbl, cod_grp_usuar

### Índices
- **sgrvrsrc_grpsr**: cod_grp_usuar

---

## Tabela: seguradora
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_seguradora

### Índices
- **sgrdr_pais**: cod_pais
- **sgrdr_pessoa_jurid** (Unique): num_pessoa_jurid

---

## Tabela: selec_pagto_padr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, ind_trans_pagto_padr, cod_trans_pagto_padr, cod_estab, cdn_fornecedor

### Índices
- **slcpgtpd_forn**: cod_empresa, cdn_fornecedor
- **slcpgtpd_pagto**: cod_empresa, cod_pagto_padr

---

## Tabela: selec_recebto_padr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, ind_trans_recebto_padr, cod_trans_recebto_padr, cod_estab, cdn_cliente

### Índices
- **slcrcbtp_cli**: cod_empresa, cdn_cliente
- **slcrcbtp_receb**: cod_empresa, cod_recebto_padr

---

## Tabela: seq_estrut_unid_organ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_seq_estrut_organ

### Índices

---

## Tabela: ser_fisc_nota
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_ser_fisc_nota

### Índices

---

## Tabela: simul_operac_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_simul_operac_financ

### Índices

---

## Tabela: sit_etap_proces_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_sit_etap_proces_edi

### Índices

---

## Tabela: sit_movimen_modul
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_modul_dtsul, cod_unid_organ, ind_sit_movimen

### Índices
- **stmvmnmd_datas**: cod_modul_dtsul, cod_unid_organ, dat_inic_sit_movimen, dat_fim_sit_movimen
- **stmvmnmd_unid_organ**: cod_unid_organ

---

## Tabela: sit_period_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_modul_dtsul, cod_empresa, cod_cenar_ctbl, cod_exerc_ctbl, num_period_ctbl

### Índices
- **stprdctl_empresa**: cod_empresa
- **stprdctl_period_ctbl**: cod_cenar_ctbl, cod_exerc_ctbl, num_period_ctbl
- **stprdctl_unid_organ**: cod_modul_dtsul, cod_unid_organ, cod_cenar_ctbl, cod_exerc_ctbl, num_period_ctbl

---

## Tabela: sit_ret_cobr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_sit_ret_cobr

### Índices

---

## Tabela: sit_ret_cobr_conces
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_conces_telef, cdn_sit_ret_cobr

### Índices
- **strtcbrc_conces**: cod_conces_telef, cod_sit_ret_conces

---

## Tabela: sit_ret_cobr_espec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_espec_docto, cdn_sit_ret_cobr

### Índices

---

## Tabela: solic_solicit_viagem
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, num_id_ped_reserve, num_id_solic

### Índices

---

## Tabela: solicit_aplic_ativ
**Label**: Valor Solicita��o
**Descrição**: Valor Solicita��o

### Chave Primária
- cod_empresa, num_seq_solicit, cod_estab_solicit, cod_plano_ccusto_solicit, cod_ccusto_solicit, cod_cta_pat, num_bem_pat, num_seq_bem_pat, num_seq_incorp_bem_pat, dat_solicit

### Índices
- **slctplct_empbemdat**: cod_empresa, cod_cta_pat, num_bem_pat, num_seq_bem_pat, dat_solicit
- **slctplct_empccdat**: cod_empresa, cod_plano_ccusto_solicit, cod_ccusto_solicit, dat_solicit
- **slctplct_empdat**: cod_empresa, dat_solicit
- **slctplct_emperrdat**: cod_empresa, log_erro_solicit, dat_solicit
- **slctplct_empestabdat**: cod_empresa, cod_estab_solicit, dat_solicit
- **slctplct_empopstadat**: cod_empresa, ind_operac_solicit, ind_status_solicit, dat_solicit
- **slctplct_empstatdat**: cod_empresa, ind_status_solicit, dat_solicit
- **slctplct_empundat**: cod_empresa, cod_unid_negoc_solicit, dat_solicit
- **slctplct_empusu**: cod_empresa, cod_usuar, ind_operac_solicit, ind_status_solicit, cod_estab_solicit, cod_plano_ccusto_solicit, cod_ccusto_solicit, dat_solicit
- **slctplct_idunique** (Unique): num_id_solicit_aplic_ativ
- **slctplct_invent**: cod_empresa, num_id_invent, dat_solicit
- **slctplct_ix12**: num_ped_exec

---

## Tabela: solicit_aplic_ativ_aprov
**Label**: ID Solicita��o
**Descrição**: ID Solicita��o

### Chave Primária
- num_id_invent, cod_usuar

### Índices
- **slctplca_ix2**: cod_usuar, ind_sit_aprov, dat_atualiz

---

## Tabela: solicit_viagem
**Label**: Total Fee Control
**Descrição**: Valor Total Fee Control

### Chave Primária
- cod_empresa, num_id_ped_reserve

### Índices
- **slctvgm_emis**: dat_emis, hra_emis

---

## Tabela: subst_tit_correntista
**Label**: Valor T�tulo
**Descrição**: Valor T�tulo Contas a Pagar

### Chave Primária
- cod_estab, cdn_fornecedor, cod_espec_docto, cod_ser_docto, cod_tit_ap, cod_parcela, cdn_correntista, cod_tit_ap_subst, cod_parcela_subst

### Índices
- **sbstttcr_fechto**: num_id_fechto_event_financ
- **sbstttcr_id_titulo**: cod_estab, num_id_tit_ap
- **sbstttcr_id_tit_novo**: cod_estab, num_id_tit_ap_subst
- **sbstttcr_tit_subst** (Unique): cod_estab, cdn_correntista, cod_espec_docto, cod_ser_docto, cod_tit_ap_subst, cod_parcela_subst

---

## Tabela: swap_emprest
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_aplic, num_id_emprest

### Índices
- **swpmprst_empr**: num_id_emprest

---

## Tabela: tab_coef_cm_pat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_cenar_ctbl, cod_finalid_econ, cod_exerc_ctbl, num_period_ctbl

### Índices
- **tbcfcmpt_fnldcn**: cod_finalid_econ
- **tbcfcmpt_prdctbl**: cod_cenar_ctbl, cod_exerc_ctbl, num_period_ctbl

---

## Tabela: tab_espec_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_modul_dtsul, cod_tabela, cod_reg_tab, num_seq, ind_event

### Índices
- **tbspcfnn_data**: dat_transacao, ind_tip_alter, cod_modul_dtsul
- **tbspcfnn_modul**: cod_modul_dtsul, cod_tabela, dat_transacao
- **tbspcfnn_tab**: cod_tabela, dat_transacao

---

## Tabela: tab_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tab_financ

### Índices

---

## Tabela: tab_geral_conver_det_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tab_conver_edi, cod_geral_orig_edi

### Índices
- **tbgrlcna_dest1**: cdn_tab_conver_edi, cod_geral_dest_1_edi
- **tbgrlcna_dest2**: cdn_tab_conver_edi, cod_geral_dest_2_edi
- **tbgrlcna_dest3**: cdn_tab_conver_edi, cod_geral_dest_3_edi
- **tbgrlcna_dest4**: cdn_tab_conver_edi, cod_geral_dest_4_edi
- **tbgrlcna_dest5**: cdn_tab_conver_edi, cod_geral_dest_5_edi

---

## Tabela: tab_geral_conver_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tab_conver_edi

### Índices
- **tbgrlcnv_alfa**: des_tab_conver_edi

---

## Tabela: tab_livre_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_modul_dtsul, cod_tab_dic_dtsul, num_seq

### Índices
- **tblvrd_carac_1**: cod_carac_idx_1
- **tblvrd_carac_2**: cod_carac_idx_2
- **tblvrd_carac_3**: cod_carac_idx_3
- **tblvrd_data_1**: dat_date_idx_1
- **tblvrd_data_2**: dat_date_idx_2
- **tblvrd_data_3**: dat_date_idx_3
- **tblvrd_int_1**: num_int_idx_1
- **tblvrd_int_2**: num_int_idx_2
- **tblvrd_int_3**: num_int_idx_3
- **tblvrd_utiliz**: cdn_indic_utiliz

---

## Tabela: tab_livre_emsbas
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_modul_dtsul, cod_tab_dic_dtsul, cod_compon_1_idx_tab, cod_compon_2_idx_tab

### Índices

---

## Tabela: tab_livre_emsfin
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_modul_dtsul, cod_tab_dic_dtsul, cod_compon_1_idx_tab, cod_compon_2_idx_tab

### Índices

---

## Tabela: tab_livre_emsuni
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_modul_dtsul, cod_tab_dic_dtsul, cod_compon_1_idx_tab, cod_compon_2_idx_tab

### Índices

---

## Tabela: tab_livre_extnam
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_modul_dtsul, cod_tab_dic_dtsul, cod_compon_1_idx_tab, cod_compon_2_idx_tab

### Índices

---

## Tabela: tab_livre_extnam_1
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_modul_dtsul, cod_tab_dic_dtsul, cod_compon_1_idx_tab, cod_compon_2_idx_tab

### Índices

---

## Tabela: tab_livre_extnam_2
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_modul_dtsul, cod_tab_dic_dtsul, cod_compon_1_idx_tab, cod_compon_2_idx_tab

### Índices

---

## Tabela: tab_livre_extnam_3
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_modul_dtsul, cod_tab_dic_dtsul, cod_compon_1_idx_tab, cod_compon_2_idx_tab

### Índices

---

## Tabela: tab_livre_extnam_4
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_modul_dtsul, cod_tab_dic_dtsul, cod_compon_1_idx_tab, cod_compon_2_idx_tab

### Índices

---

## Tabela: tab_prgssiv_impto_retid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tab_prgssiv_impto_retid

### Índices

---

## Tabela: tab_serv_inss
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_serv_inss

### Índices

---

## Tabela: talon_cheq
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cta_corren, num_talon_cheq

### Índices
- **tlnchq_bctpchq**: cod_banco, cod_tip_cheq

---

## Tabela: tar_workflow
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_usuario, cod_modul_dtsul, num_seq_tar_workflow

### Índices
- **trwrkflw_mdldtsl**: cod_modul_dtsul
- **trwrkflw_prgdtsl**: cod_prog_dtsul
- **trwrkflw_srmstr**: cod_usuario

---

## Tabela: tax_cobr
**Label**: Taxa Transa��o
**Descrição**: Taxa Transa��o Produto

### Chave Primária
- cod_empresa, ind_tip_produt, num_seq_tax

### Índices
- **taxcobr_bco**: cod_empresa, ind_tip_produt, cod_banco, dat_tax_inic, dat_tax_fim
- **taxcobr_estab**: cod_empresa, ind_tip_produt, cod_estab, dat_tax_inic, dat_tax_fim
- **taxcobr_finalid**: cod_empresa, ind_tip_produt, cod_finalid_econ

---

## Tabela: tax_movto_operac_financ
**Label**: Taxa Pr�-Fixada
**Descrição**: Valor Taxa Juros Pre Fixada

### Chave Primária
- num_id_movto_operac_financ

### Índices

---

## Tabela: tax_vendor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_portador, cod_cart_bcia, cod_finalid_econ, cod_cond_pagto_vendor, dat_tax_vendor_bco

### Índices
- **txvndr_cond_pagto**: cod_cond_pagto_vendor, cod_estab, cod_portador, dat_tax_vendor_bco
- **txvndr_dat_estab_cond_pagto**: dat_tax_vendor_bco, cod_estab, cod_cond_pagto_vendor, cod_cart_bcia, cod_finalid_econ
- **txvndr_dat_estab_portad**: dat_tax_vendor_bco, cod_estab, cod_portador, cod_cart_bcia, cod_finalid_econ

---

## Tabela: techfin_configur
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, dat_ult_atualiz, hra_ult_atualiz

### Índices

---

## Tabela: techfin_process
**Label**: Tentativas
**Descrição**: N�mero de Tentativas de Integra�ao

### Chave Primária
- idi_process

### Índices
- **tchfnprc_cmgbco**: num_id_movto_cta_bco
- **tchfnprc_cmgdesc**: num_id_movto_cta_desc
- **tchfnprc_ix2**: cod_plataf, cod_tenant, cod_erp
- **tchfnprc_lt**: num_id_lote
- **tchfnprc_movtotit**: cod_estab, num_id_movto_tit_acr
- **tchfnprc_status**: ind_tip_status

---

## Tabela: techfin_process_event
**Label**: Seq Evento
**Descrição**: Seq Evento

### Chave Primária
- idi_process_event

### Índices

---

## Tabela: telef
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_telef_sem_edic

### Índices

---

## Tabela: telef_pessoa
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_telef_sem_edic, num_pessoa

### Índices
- **tlfpss_pessoa** (Unique): num_pessoa, cod_telef_sem_edic

---

## Tabela: termo_documen
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_topico, num_termo_ligac

### Índices
- **trmdcmn_dest**: num_topic_dest

---

## Tabela: termo_documen_idiom
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_topico, num_termo_ligac, cod_idioma

### Índices
- **trmdcmnd_nom**: nom_termo_ligac, cod_idioma, num_topico

---

## Tabela: termo_respde_bem_pat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_termo_respde_bem_pat

### Índices

---

## Tabela: text_padr_documen
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_text_padr

### Índices

---

## Tabela: text_padr_documen_idiom
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_text_padr, cod_idioma

### Índices
- **txtpdrda_idmbsc**: cod_idioma

---

## Tabela: time_connection
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_proces_oracle, cod_device

### Índices
- **tmcnnctn_primario_id** (Unique): cod_proces_oracle

---

## Tabela: tip_abat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_abat

### Índices

---

## Tabela: tip_calc
**Label**: Perc Aplicado
**Descrição**: Valor Percentual Aplicado

### Chave Primária
- cod_tip_calc

### Índices
- **tipcalc_finalid_econ_base**: cod_finalid_econ_base_cm
- **tipcalc_incent_fisc**: cod_incent_fisc
- **tipcalc_metod_calc_dpr**: cod_metod_calc_dpr
- **tipcalc_tip_calc_dpr**: cod_tip_calc_cm_dpr

---

## Tabela: tip_calc_encargo_cta
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_calc_encargo_cta

### Índices

---

## Tabela: tip_calc_encargo_taxac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_calc_encargo_cta, ind_tip_encargo_cta_corren, ind_tip_sdo_cta_corren

### Índices
- **tpclcnca_hstrpdr**: cod_histor_padr
- **tpclcnca_moeda**: cod_indic_econ_base, cod_indic_econ_idx
- **tpclcnca_moeda_cm**: cod_indic_econ_cm_base, cod_indic_econ_cm_idx
- **tpclcnca_tip_trans_cx**: cod_tip_trans_cx

---

## Tabela: tip_calc_impto_cmg
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_calc_impto_cmg

### Índices

---

## Tabela: tip_cheq
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_cheq

### Índices

---

## Tabela: tip_clien
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_tip_clien

### Índices
- **tipclien_tp_clien_filh**: cod_empresa, cod_tip_clien_filho

---

## Tabela: tip_col_balanct
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_padr_col_balanct, num_tip_col_balanct

### Índices

---

## Tabela: tip_despes_viagem_eec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_estab, cod_despes_eec, num_seq_tip_despes_viagem

### Índices
- **tpdspsvg_plnctctl**: cod_plano_cta_ctbl, cod_cta_ctbl

---

## Tabela: tip_fluxo_cta_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_fluxo_financ, cod_empresa, num_seq_tip_fluxo_cta_ctbl

### Índices
- **tpflxctc_cta_ctbl**: cod_plano_cta_ctbl, cod_cta_ctbl
- **tpflxctc_empresa**: cod_empresa

---

## Tabela: tip_fluxo_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_fluxo_financ

### Índices

---

## Tabela: tip_fornec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_tip_fornec

### Índices
- **tpfrnca_tp_forn_filh**: cod_empresa, cod_tip_fornec_filho

---

## Tabela: tip_grp_cta_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_grp_cta_ctbl

### Índices

---

## Tabela: tip_hier_pat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_hier_pat

### Índices
- **tphrpta_filho**: cod_tip_hier_pat_filho

---

## Tabela: tip_lancto_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_lancto_ctbl

### Índices

---

## Tabela: tip_movto_spc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_movto_spc

### Índices

---

## Tabela: tip_proces_despes
**Label**: Valor Padrao Despesa
**Descrição**: Valor Padr�o Despesa Viagem

### Chave Primária
- cod_cargo, cod_niv_cargo, cod_empresa, cod_estab, cod_despes_eec, num_seq_tip_despes_viagem, cod_tip_proces_eec, num_seq_tip_proces_despes, cod_finalid_econ

### Índices
- **tpprcsds_token** (Unique): num_id_tip_proces_despes

---

## Tabela: tip_proces_prestac_cta
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_proces_eec

### Índices
- **tpprcspr_fnldcn**: cod_finalid_econ_reembol
- **tpprcspr_tpflxfnn**: cod_tip_fluxo_financ_entr, cod_tip_fluxo_financ_saida

---

## Tabela: tip_produt_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_produt_financ

### Índices

---

## Tabela: tip_reg_extrat_excec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_extrat, num_seq_reg_layout_extrat, cod_tip_lancto_extrat

### Índices

---

## Tabela: tip_reg_layout
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout, num_seq_reg_layout

### Índices

---

## Tabela: tip_reg_layout_excec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout, num_seq_reg_layout

### Índices

---

## Tabela: tip_reg_layout_extrat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_extrat, num_seq_reg_layout_extrat

### Índices
- **tprglytx_tip_reg** (Unique): cod_layout_extrat, ind_tip_reg_layout_extrat

---

## Tabela: tip_reg_layout_trans
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_trans, num_seq_tip_reg_layout

### Índices

---

## Tabela: tip_repres
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_tip_repres

### Índices
- **tprprs_tprprs**: cod_empresa, cod_tip_repres_filho

---

## Tabela: tip_serv_mdo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_serv_mdo

### Índices

---

## Tabela: tip_topic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_tip_topic

### Índices

---

## Tabela: tip_topic_idiom
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_tip_topic, cod_idioma

### Índices

---

## Tabela: tip_trans_1099
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_trans_1099

### Índices

---

## Tabela: tip_trans_cx
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_trans_cx

### Índices
- **tptrnscx_histor**: cod_histor_padr
- **tptrnscx_impto**: cod_tip_trans_cx_impto
- **tptrnscx_tip_fluxo_entr**: cod_tip_fluxo_financ_entr
- **tptrnscx_tip_fluxo_saida**: cod_tip_fluxo_financ_saida

---

## Tabela: tip_trans_cx_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_trans_cx, ind_tip_movto_cta_corren, cod_cart_bcia

### Índices
- **tptrnscg_cart**: cod_cart_bcia, ind_tip_movto_cta_corren

---

## Tabela: tip_trans_cx_apl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_banco, cod_produt_financ, ind_tip_trans_apl

### Índices

---

## Tabela: tip_trans_cx_cta_ctbl
**Label**: Perc Rateio
**Descrição**: Percentual Rateado

### Chave Primária
- cod_empresa, cod_tip_trans_cx, cod_cta_corren, ind_finalid_ctbl_tip_trans, cod_plano_cta_ctbl, cod_cta_ctbl, cod_estab, cod_unid_negoc, cod_plano_ccusto, cod_ccusto

### Índices
- **tptrnsca_cta_corren**: cod_cta_corren
- **tptrnsca_cta_ctbl**: cod_plano_cta_ctbl, cod_cta_ctbl

---

## Tabela: tip_trans_cx_nreal_apb
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_espec_docto

### Índices
- **tptrnsce_trans_cx**: cod_tip_trans_cx

---

## Tabela: tip_trans_cx_padr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cta_corren, ind_finalid_trans_cx

### Índices
- **tptrnscb_tip_trans**: cod_tip_trans_cx

---

## Tabela: tip_trans_cx_real_apb
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_trans_cx, ind_modo_pagto

### Índices

---

## Tabela: tip_transp_eec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_transp

### Índices

---

## Tabela: tip_transp_empres_transp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_transp, num_pessoa_jurid

### Índices

---

## Tabela: tip_transp_rota_eec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_rota_viagem, cod_tip_transp

### Índices

---

## Tabela: tip_unid_organ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_unid_organ

### Índices
- **tpndrgn_descricao**: des_tip_unid_organ
- **tpndrgn_nivel** (Unique): num_niv_unid_organ

---

## Tabela: tit_acr
**Label**: Saida Transf Estab
**Descrição**: Valor Transferencias Estabelecimento

### Chave Primária
- cod_estab, cod_espec_docto, cod_ser_docto, cod_tit_acr, cod_parcela

### Índices
- **titacr_cliente**: cod_estab, cdn_cliente, dat_emis_docto, log_sdo_tit_acr
- **titacr_clien_datas**: cod_estab, cdn_cliente, dat_liquidac_tit_acr, dat_transacao
- **titacr_clien_prev_liq**: cod_empresa, cdn_cliente, dat_prev_liquidac
- **titacr_cond_cob**: cod_estab, cod_cond_cobr, dat_emis_docto
- **titacr_emis**: cod_estab, dat_emis_docto
- **titacr_espec_pessoa_emis**: cod_estab, ind_tip_espec_docto, num_pessoa, dat_emis_docto
- **titacr_espec_vencto**: cod_estab, cod_espec_docto, log_sdo_tit_acr, dat_vencto_tit_acr
- **titacr_estab_bord**: cod_estab_bord, num_bord_acr
- **titacr_estab_portad_espec**: cod_estab, cod_portador, cod_espec_docto, dat_emis_docto
- **titacr_id_movto_cta_corren**: num_id_movto_cta_corren
- **titacr_integr_cfl**: cod_estab, cod_espec_docto, log_integr_cfl_atlzdo, dat_fluxo_tit_acr
- **titacr_liquidac**: cod_estab, dat_liquidac_tit_acr, cod_espec_docto, dat_transacao, cod_cond_cobr
- **titacr_nom_abrev**: cod_empresa, nom_abrev
- **titacr_oprcfnna**: cod_estab_bord, cod_movto_operac_financ
- **titacr_portad**: cod_portador, cod_tit_acr_bco
- **titacr_proces_export**: cod_proces_export
- **titacr_repres**: cod_estab, cdn_repres, log_sdo_tit_acr, cod_espec_docto
- **titacr_sdo_perdas**: cod_estab, log_sdo_tit_acr, dat_indcao_perda_dedut
- **titacr_token** (Unique): cod_estab, num_id_tit_acr
- **titacr_vencto**: cod_estab, dat_vencto_tit_acr

---

## Tabela: tit_acr_avp
**Label**: Taxa Desconto
**Descrição**: Valor Taxa de Desconto

### Chave Primária
- cod_estab, num_id_tit_acr

### Índices
- **ttcrvp_cli**: cdn_cliente, cod_espec_docto, cod_ser_docto, cod_estab, cod_tit_acr, cod_parcela
- **ttcrvp_log**: cod_estab, log_tit_acr_estordo, log_sdo_tit_acr, log_tit_acr_cancel, log_tit_acr_vencid

---

## Tabela: tit_acr_cobr_ativ
**Label**: Saldo T�tulo
**Descrição**: Valor Saldo Contas a Receber

### Chave Primária
- cod_estab, num_id_tit_acr

### Índices
- **ttcrcbrt_clien**: cod_empresa, cdn_cliente
- **ttcrcbrt_contat**: cod_estab, dat_prox_contat

---

## Tabela: tit_acr_cobr_especial
**Label**: Valor Estornado
**Descrição**: Valor Titulo Contas a Receber Estornado

### Chave Primária
- cod_estab, num_id_tit_acr, num_seq_tit_acr

### Índices
- **ttcrcbrs_cartcred**: cod_empresa, cod_portador, cod_cartcred, dat_emis_docto
- **ttcrcbrs_cliente**: cod_empresa, cdn_cliente, cod_portador, dat_emis_docto
- **ttcrcbrs_compr_aut**: cod_empresa, cod_comprov_vda, cod_autoriz_bco_emissor, cod_admdra_cartao_cr, cod_band
- **ttcrcbrs_contrat**: cod_empresa, cod_portador, cod_contrat, dat_emis_docto
- **ttcrcbrs_cta_corren**: cod_empresa, cod_portador, cod_cta_corren_bco, dat_emis_docto
- **ttcrcbrs_emp**: cod_empresa, ind_sit_tit_cobr_especial, dat_emis_docto, dat_compra_cartao_cr
- **ttcrcbrs_empadm**: cod_empresa, cod_admdra_cartao_cr, cod_band, ind_sit_tit_cobr_especial, dat_compra_cartao_cr
- **ttcrcbrs_empco**: cod_empresa, dat_compra_cartao_cr, ind_sit_tit_cobr_especial, dat_emis_docto
- **ttcrcbrs_empdat**: cod_empresa, dat_emis_docto, ind_sit_tit_cobr_especial, dat_compra_cartao_cr
- **ttcrcbrs_empres_autoriz**: cod_empresa, cod_autoriz_bco_emissor, cod_comprov_vda, cod_admdra_cartao_cr, cod_band
- **ttcrcbrs_lote_cobr**: num_id_cobr_especial_acr, num_seq_cobr_especial_acr
- **ttcrcbrs_tit_acr** (Unique): cod_estab, cod_espec_docto, cod_ser_docto, cod_tit_acr, cod_parcela
- **ttcrcbrs_vda_dat**: cod_empresa, cod_comprov_vda, dat_compra_cartao_cr, cod_admdra_cartao_cr, cod_band

---

## Tabela: tit_acr_envio_serasa
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_id_tit_acr

### Índices
- **ttcrnvsr_cancel**: log_tit_cancel, dat_envio_serasa_cancel
- **ttcrnvsr_tit_acr**: cod_estab, cod_espec_docto, cod_ser_docto, cod_tit_acr, cod_parcela

---

## Tabela: tit_acr_fechado
**Label**: Saldo T�tulo
**Descrição**: Valor Saldo Contas a Receber

### Chave Primária
- cod_empresa, cod_estab, cdn_cliente, cod_espec_docto, cod_ser_docto, cod_tit_acr, cod_parcela

### Índices
- **ttcrfchd_bord**: cod_estab, num_bord_acr
- **ttcrfchd_cliente_emis**: cod_estab, cdn_cliente, dat_emis_docto
- **ttcrfchd_cliente_orig**: cod_empres_orig, cod_estab_orig, cdn_clien_orig, dat_emis_docto
- **ttcrfchd_id_orig**: cod_empres_orig, cod_estab_orig, cod_espec_docto_orig, cod_ser_docto_orig, cod_tit_acr, cod_parcela
- **ttcrfchd_portad**: cod_estab, cod_portador, cod_espec_docto, dat_emis_docto
- **ttcrfchd_prev_liq**: cod_empresa, cod_estab, cdn_cliente, dat_prev_pagto
- **ttcrfchd_repres**: cod_estab, cod_repres_vendas, cod_espec_docto
- **ttcrfchd_tip_espec**: cod_estab, ind_tip_espec_docto, dat_vencto
- **ttcrfchd_tit_bco**: cod_estab, cod_tit_acr_bco
- **ttcrfchd_vencto**: cod_estab, dat_vencto, cdn_cliente
- **ttcrfchd_vencto_orig**: cod_empres_orig, cod_estab_orig, dat_vencto, cdn_clien_orig

---

## Tabela: tit_acr_msg_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_id_tit_acr, cod_mensagem

### Índices
- **ttcrmsgf_msgfnnc**: cod_estab, cod_mensagem

---

## Tabela: tit_acr_terc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_refer, num_seq_refer_item_lote

### Índices
- **ttcrtrc_titulo_clien**: cod_estab, num_id_tit_acr

---

## Tabela: tit_acr_trib
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_id_tit_acr, num_id_movto_tit_acr, num_id_docto_fisc, ind_tip_trib, ind_tip_campo_trib

### Índices
- **ttcrtrb_id_docto_fisc**: num_id_docto_fisc
- **ttcrtrb_id_docto_fisc_presmdo**: num_id_docto_fisc, log_cr_presmdo
- **ttcrtrb_id_movto**: cod_estab, num_id_movto_tit_acr, num_id_docto_fisc, ind_tip_trib, ind_tip_campo_trib
- **ttcrtrb_id_tit_presmdo**: cod_estab, num_id_tit_acr, log_cr_presmdo

---

## Tabela: tit_ap
**Label**: Saida Transf Estab
**Descrição**: Valor Transferencias Estabelecimento

### Chave Primária
- cod_estab, cdn_fornecedor, cod_espec_docto, cod_ser_docto, cod_tit_ap, cod_parcela

### Índices
- **titap_dat_desconto**: cod_estab, dat_liquidac_tit_ap, cod_espec_docto, dat_desconto
- **titap_dat_prev_pagto**: cod_estab, dat_liquidac_tit_ap, cod_espec_docto, dat_prev_pagto
- **titap_emis**: cod_estab, dat_emis_docto
- **titap_estab_fornec_liquidac**: cod_estab, cdn_fornecedor, dat_liquidac_tit_ap, dat_transacao
- **titap_estab_liq_espec_trans**: cod_estab, dat_liquidac_tit_ap, cod_espec_docto, dat_transacao
- **titap_estab_trans_espec**: cod_estab, dat_transacao, cod_espec_docto
- **titap_fornec_emis**: cod_estab, cdn_fornecedor, dat_emis_docto, cod_espec_docto
- **titap_fornec_financ**: cod_empresa, cdn_fornecedor, dat_prev_pagto
- **titap_id_movto_cta_corren**: num_id_movto_cta_corren
- **titap_log_integr_clf**: cod_estab, cod_espec_docto, log_integr_cfl_atlzdo, dat_prev_pagto
- **titap_pessoa**: num_pessoa, cod_espec_docto, cod_ser_docto, cod_tit_ap, cod_parcela
- **titap_portador_cod_bco_pagto**: cod_portador, cod_tit_ap_bco
- **titap_proces_import**: cod_proces_import
- **titap_safra**: cdn_fornecedor, ind_tip_espec_docto
- **titap_sdo_tit_ap**: cod_estab, cod_espec_docto, log_sdo_tit_ap, cdn_fornecedor
- **titap_sist_bcio_cod_bco_cobr**: cod_sist_nac_bcio_cobdor, cod_tit_ap_bco_cobdor
- **titap_tip_espec_pessoa_trans**: cod_estab, ind_tip_espec_docto, num_pessoa, dat_transacao
- **titap_titulo**: cod_estab, cod_tit_ap, cod_parcela
- **titap_token** (Unique): cod_estab, num_id_tit_ap

---

## Tabela: tit_ap_avp
**Label**: Taxa Desconto
**Descrição**: Valor Taxa de Desconto

### Chave Primária
- cod_estab, num_id_tit_ap

### Índices
- **titapavp_for**: cdn_fornecedor, cod_espec_docto, cod_ser_docto, cod_estab, cod_tit_ap, cod_parcela
- **titapavp_log**: cod_estab, log_tit_ap_estordo, log_sdo_tit_ap, log_tit_ap_cancel, log_tit_ap_vencid

---

## Tabela: tit_ap_bcio
**Label**: Valor T�tulo Bcio
**Descrição**: Valor T�tulo Banc�rio

### Chave Primária
- cod_estab, cod_sist_nac_bcio, cod_tit_ap_bco, num_seq_tit_bco

### Índices
- **ttpbc_barras**: cod_barra
- **ttpbc_estab_concil_confer**: cod_estab, log_concil, log_confer, dat_entr_sist, cod_sist_nac_bcio
- **ttpbc_estab_concil_fornec**: cod_estab, log_concil, cdn_fornecedor
- **ttpbc_fornec**: cod_estab, cod_sist_nac_bcio, cdn_fornecedor, dat_vencto
- **ttpbc_tit_ap**: cod_estab, num_id_tit_ap

---

## Tabela: tit_ap_fechado
**Label**: Taxa Moeda Estrangei
**Descrição**: Valor Taxa Moeda Estrangeiro

### Chave Primária
- cod_empresa, cod_estab, cdn_fornecedor, cod_espec_docto, cod_ser_docto, cod_tit_ap, cod_parcela

### Índices
- **ttpfchd_emis**: cod_estab, dat_emis_docto
- **ttpfchd_emp_orig**: cod_empres_orig, cod_estab_orig, cod_portad_orig
- **ttpfchd_fornec_liq**: cod_estab, cdn_fornecedor, dat_liquidac_tit_ap, dat_transacao
- **ttpfchd_id_orig**: cod_empres_orig, cod_estab_orig, cdn_fornec_orig, cod_espec_docto_orig, cod_ser_docto_orig, cod_tit_ap, cod_parcela
- **ttpfchd_liq**: cod_estab, dat_liquidac_tit_ap, cod_espec_docto
- **ttpfchd_port**: cod_portador, cod_tit_ap
- **ttpfchd_prev_orig**: cod_empres_orig, cod_estab_orig, dat_prev_pagto
- **ttpfchd_trans**: cod_estab, dat_transacao, cod_espec_docto

---

## Tabela: tit_ap_integr_merc
**Label**: Valor Imposto
**Descrição**: Valor Total Imposto

### Chave Primária
- cod_estab, num_id_tit_ap

### Índices
- **ttpntgrm_dat_emis**: dat_emis_docto
- **ttpntgrm_dat_pagto**: dat_pagto
- **ttpntgrm_fornec**: cod_empresa, cdn_fornecedor
- **ttpntgrm_hub_impl**: log_atlzdo_hub_impl
- **ttpntgrm_hub_pagto**: log_atlzdo_hub_pagto
- **ttpntgrm_id_me**: cdn_fornecedor, cod_tit_ap, cod_refer_merc
- **ttpntgrm_id_tit_me**: cod_correlacao_id

---

## Tabela: tit_ap_liber
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_tit_ap_liber

### Índices
- **ttplbr_refer**: cod_estab, cod_refer_antecip_pef
- **ttplbr_tit_ap**: cod_estab, num_id_tit_ap

---

## Tabela: tit_ap_liber_sec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_tit_ap_liber, num_seq

### Índices

---

## Tabela: tit_ap_trib
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_id_tit_ap, num_id_movto_tit_ap, num_id_docto_fisc, ind_tip_trib, ind_tip_campo_trib

### Índices
- **ttptrb_id_docto_fisc**: num_id_docto_fisc
- **ttptrb_id_docto_fisc_presmdo**: num_id_docto_fisc, log_cr_presmdo
- **ttptrb_id_movto**: cod_estab, num_id_movto_tit_ap, num_id_docto_fisc, ind_tip_trib, ind_tip_campo_trib
- **ttptrb_id_tit_presmdo**: cod_estab, num_id_tit_ap, log_cr_presmdo

---

## Tabela: tit_calc_renegoc_inadimp
**Label**: Valor Parcela
**Descrição**: Valor Parcela

### Chave Primária
- cod_refer, num_seq_tit_calc_renegoc

### Índices
- **ttclcrng_tit**: cod_estab, cod_espec_docto, cod_ser_docto, cod_tit_acr, cod_parcela

---

## Tabela: tit_cancdo_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_estab, cod_espec_docto, cod_ser_docto, cod_tit_acr, cod_parcela, num_id_tit_acr

### Índices
- **ttcncdcr_mov**: dat_gerac_movto, hra_gerac_movto

---

## Tabela: tit_cancdo_apb
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_estab, cdn_fornecedor, cod_espec_docto, cod_ser_docto, cod_tit_ap, cod_parcela, num_id_tit_ap

### Índices
- **ttcncdpb_mov**: dat_gerac_movto, hra_gerac_movto

---

## Tabela: tit_carta_anuencia
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cdn_cliente, num_carta_anuencia_clien, cod_estab, cod_espec_docto, cod_ser_docto, cod_tit_acr, cod_parcela

### Índices

---

## Tabela: tit_contra_empres_em_bco
**Label**: Valor Saldo
**Descrição**: Valor Saldo T�tulo

### Chave Primária
- dat_refer_arq_tit_em_bco, cod_sist_nac_bcio, cod_agenc_bcia, cod_vers_arq_tit_em_bco, num_seq

### Índices

---

## Tabela: tit_control_xml_e_social
**Label**: Valor Presta��o Servi�o
**Descrição**: Valor Presta��o de Servi�o

### Chave Primária
- cod_empresa, cod_layout, cdn_fornecedor, cod_period_apurac, cod_id_control_xml, num_seq_histor, cod_estab, num_id_tit_ap

### Índices
- **ttcntrlx_id_tit**: cod_estab, num_id_tit_ap
- **ttcntrlx_ix2**: cod_id_control_xml

---

## Tabela: tit_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_tit_ctbl

### Índices
- **titctbl_descricao** (Unique): des_tit_ctbl

---

## Tabela: tit_darf_ap
**Label**: Valor Multa
**Descrição**: Valor Multa

### Chave Primária
- cod_estab, cod_darf_ap, cod_estab_tit, num_id_tit_ap

### Índices
- **ttdrfp_tit**: cod_estab_tit, num_id_tit_ap

---

## Tabela: tit_inadimp
**Label**: Saldo T�tulo
**Descrição**: Valor Saldo Contas a Receber

### Chave Primária
- cod_estab, cod_espec_docto, cod_ser_docto, cod_tit_acr, cod_parcela

### Índices
- **ttndmp_cliente**: cod_empresa, cdn_cliente
- **ttndmp_dt_agenda**: dat_agenda
- **ttndmp_esp_vencto**: cod_estab, cod_espec_docto, dat_vencto_tit_acr
- **ttndmp_token**: cod_estab, num_id_tit_acr

---

## Tabela: tit_relac_enctro_cta
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab_refer, cod_refer, cod_estab, num_id_tit

### Índices
- **ttrlcnct_tit**: cod_estab, num_id_tit

---

## Tabela: topic_compon_documen
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_topico, num_compon_estil, cod_idioma

### Índices

---

## Tabela: topic_estil
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_topico, num_estilo

### Índices
- **tpcstl_estilo**: num_estilo

---

## Tabela: topic_grp_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_topico, cod_grp_usuar

### Índices
- **tpcgrpsr_grpsr**: cod_grp_usuar

---

## Tabela: topic_idiom
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_topico, cod_idioma

### Índices
- **tpcdm_tit**: nom_tit_topic

---

## Tabela: topico
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_topico

### Índices
- **topico_tip_topic**: num_tip_topic

---

## Tabela: tot_avp_period_acr
**Label**: Total Revers�o
**Descrição**: Valor Total Revers�o

### Chave Primária
- cod_empresa, dat_refer_tot_avp

### Índices

---

## Tabela: tot_avp_period_ap
**Label**: Total Revers�o
**Descrição**: Valor Total Revers�o

### Chave Primária
- cod_empresa, dat_refer_tot_avp

### Índices

---

## Tabela: tot_lancto_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_lote_ctbl, num_lancto_ctbl, cod_finalid_econ

### Índices

---

## Tabela: trad_ccusto_ext
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_matriz_trad_ccusto_ext, cod_ccusto_ext

### Índices
- **trdccstx_ccusto**: cod_empresa, cod_plano_ccusto, cod_ccusto
- **trdccstx_trdmprsh**: cod_matriz_trad_ccusto_ext

---

## Tabela: trad_cta_corren
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_matriz_trad_cta_corren, cod_bco_ext, cod_agenc_bcia_ext, cod_cta_corren_ext

### Índices
- **trdctcrr_cta_interna**: cod_cta_corren

---

## Tabela: trad_cta_ctbl_ext
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_organ, cod_matriz_trad_cta_ext, cod_cta_ctbl_ext, cod_sub_cta_ctbl_ext, cod_ccusto_ext, cod_estab_ext, cod_unid_negoc_ext, num_seq_trad_cta_ctbl_ext

### Índices
- **trdctctb_ccusto**: cod_unid_organ, cod_plano_ccusto, cod_ccusto
- **trdctctb_ctaext**: cod_unid_organ, cod_matriz_trad_cta_ext, cod_plano_cta_ctbl, cod_cta_ctbl
- **trdctctb_cta_ctbl**: cod_plano_cta_ctbl, cod_cta_ctbl
- **trdctctb_estab**: cod_estab
- **trdctctb_ix10**: cod_unid_organ, cod_matriz_trad_cta_ext, cod_unid_negoc
- **trdctctb_ix9**: cod_unid_organ, cod_matriz_trad_cta_ext, cod_cta_ctbl
- **trdctctb_trdmprsh**: cod_matriz_trad_cta_ext
- **trdctctb_unid_negoc**: cod_unid_negoc
- **trdctctd_ix8**: cod_unid_organ, cod_matriz_trad_cta_ext, cod_ccusto

---

## Tabela: trad_cta_pat_ext
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_matriz_trad_cta_pat_ext, cod_cta_pat_ext

### Índices
- **trdctptx_cta_pat_int**: cod_matriz_trad_cta_pat_ext, cod_empresa, cod_cta_pat

---

## Tabela: trad_demonst_concor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_concorrente, cod_cenar_ctbl, cod_exerc_ctbl, cod_plano_cta_ctbl, cod_idioma

### Índices
- **trddmnso_exerc_ctbl**: cod_cenar_ctbl, cod_exerc_ctbl
- **trddmnso_idioma**: cod_idioma
- **trddmnso_plano_cta**: cod_plano_cta_ctbl

---

## Tabela: trad_element_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_formul_edi, num_seq_trad_formul_edi

### Índices
- **trdlmntd_formula** (Unique): cdn_formul_edi, des_contdo_orig_element_edi

---

## Tabela: trad_finalid_econ_ext
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_matriz_trad_finalid_ext, cod_finalid_econ_ext

### Índices
- **trdfnldc_fnldcn**: cod_finalid_econ
- **trdfnldc_ndccn**: cod_indic_econ

---

## Tabela: trad_fluxo_ext
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_matriz_trad_fluxo_ext, cod_fluxo_financ_ext

### Índices
- **trdflxxt_tip_fluxo**: cod_tip_fluxo_financ

---

## Tabela: trad_indic_econ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_indic_econ, cod_idioma

### Índices
- **trdndcc_idioma**: cod_idioma, cod_indic_econ

---

## Tabela: trad_item_layout_trans
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_trans, cod_campo, des_contdo_orig

### Índices

---

## Tabela: trad_org_ext
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_matriz_trad_org_ext, cod_tip_unid_organ, cod_unid_organ_ext

### Índices
- **trdrgxt_matriz_trad_ccusto**: cod_unid_organ, cod_matriz_trad_ccusto_ext
- **trdrgxt_matriz_trad_cta_ctbl**: cod_unid_organ, cod_matriz_trad_cta_ext
- **trdrgxt_matriz_trad_finalid**: cod_matriz_trad_finalid_ext
- **trdrgxt_mtrztrdd**: cod_matriz_trad_pais_ext
- **trdrgxt_mtrztrdp**: cod_matriz_trad_portad_ext
- **trdrgxt_ndrgn**: cod_unid_organ, cod_tip_unid_organ
- **trdrgxt_tip_uo**: cod_tip_unid_organ

---

## Tabela: trad_pais_ext
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_matriz_trad_pais_ext, cod_pais_ext

### Índices

---

## Tabela: trad_portad_ext
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_matriz_trad_portad_ext, cod_portad_ext, cod_modalid_ext

### Índices
- **trdprtdx_portad_int**: cod_matriz_trad_portad_ext, cod_portador, cod_cart_bcia

---

## Tabela: trad_tip_fluxo_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_fluxo_financ, cod_idioma

### Índices
- **trdtpflx_idioma**: cod_idioma

---

## Tabela: trad_tit_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_tit_ctbl, cod_idioma

### Índices
- **trdttctb_idioma**: cod_idioma

---

## Tabela: trans_1099
**Label**: Vl. Transacao 1099
**Descrição**: Valor Transacao 1099

### Chave Primária
- cod_empresa, cod_estab, cdn_fornecedor, cod_tax_ident_number, ind_tip_trans_1099, dat_transacao, num_id_movto_tit_ap

### Índices
- **trns1099_dat**: cod_empresa, cod_estab, dat_transacao, cdn_fornecedor, cod_tax_ident_number, ind_tip_trans_1099
- **trns1099_tip**: ind_tip_trans_1099

---

## Tabela: trans_bcia_bco
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_banco, cod_trans_bcia

### Índices

---

## Tabela: trans_cartao_cr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, ind_orig_trans_cart_cr, cod_trans_cartao_cr, dat_inic_valid

### Índices
- **trnscrtc_admra_band**: cod_empresa, cod_trans_cartao_cr, cod_operdra_cartao_cr, cod_admdra_cartao_cr, cod_band
- **trnscrtc_ajuste**: cod_empresa, cod_admdra_cartao_cr, cod_band, cod_motiv_ajust_cartao_cr
- **trnscrtc_orig_admdra**: cod_empresa, ind_orig_trans_cart_cr, cod_admdra_cartao_cr, cod_band, cod_operdra_cartao_cr, dat_inic_valid
- **trnscrtc_orig_operdra**: cod_empresa, ind_orig_trans_cart_cr, cod_operdra_cartao_cr, cod_admdra_cartao_cr, cod_band, dat_inic_valid
- **trnscrtc_valid**: cod_empresa, ind_orig_trans_cart_cr, cod_motiv_ajust_cartao_cr, ind_tip_trans_cart_cr, cod_operdra_cartao_cr, cod_admdra_cartao_cr, cod_band, dat_inic_valid

---

## Tabela: trans_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_trans_edi

### Índices

---

## Tabela: trans_lote_tpi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, num_lote_tpi, num_seq_trans

### Índices
- **tr_lot_tpi_dat**: cod_empresa, num_lote_tpi, dat_trans_tpi

---

## Tabela: trans_mktplace
**Label**: Livre2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cdn_mktplace, cod_trans_mktplace, dat_inic_valid

### Índices

---

## Tabela: trans_segment_edi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_trans_edi, cdn_segment_edi

### Índices
- **trnssgmn_mpsgmntd**: cdn_segment_edi

---

## Tabela: tx_intracompany
**Label**: Taxa Juros
**Descrição**: Valor Percentual Taxa Juros

### Chave Primária
- cod_unid_negoc, dat_tx

### Índices

---

## Tabela: unid_aprovac_eec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_estab, cod_plano_aprovac_eec, cod_unid_aprovac

### Índices
- **undprvcc_funceec**: cod_empresa, cod_estab_func_financ, cdn_func_respons_eec

---

## Tabela: unid_control_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_control_financ

### Índices

---

## Tabela: unid_fechto_cta_corren
**Label**: Saldo Ideal Conta
**Descrição**: Valor Ideal do Saldo de Conta Corrente

### Chave Primária
- cod_unid_fechto_cx, cod_cta_corren

### Índices
- **undfchta_cta_corren**: cod_cta_corren
- **undfchta_prvdor**: cod_cta_corren_prvdor

---

## Tabela: unid_fechto_cx
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_fechto_cx

### Índices
- **undfchtc_cta_centraliz**: cod_cta_corren_centraliz

---

## Tabela: unid_fechto_produt
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_fechto_cx, cod_tip_produt_financ, cod_produt_financ

### Índices
- **undfchtp_produt_financ**: cod_tip_produt_financ, cod_produt_financ

---

## Tabela: unid_federac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_pais, cod_unid_federac

### Índices

---

## Tabela: unid_medid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_medid

### Índices
- **ndmdd_descricao**: des_unid_medid

---

## Tabela: unid_negoc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_negoc

### Índices
- **ndngc_cdn** (Unique): cdn_unid_negoc

---

## Tabela: unid_negoc_scp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empres_scp, cod_unid_negoc

### Índices
- **undngcsc_unid_negoc**: cod_unid_negoc

---

## Tabela: unid_orctaria
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_orctaria

### Índices

---

## Tabela: unid_organ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_organ

### Índices
- **ndrgn_descricao**: des_unid_organ
- **ndrgn_nom_abrev**: nom_abrev
- **ndrgn_tip_unid_organ**: cod_tip_unid_organ

---

## Tabela: usuar_apb_modul_permis
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario, cod_modul_dtsul

### Índices
- **usrpbmdl_modul**: cod_modul_dtsul

---

## Tabela: usuar_apl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_usuario

### Índices

---

## Tabela: usuar_cheq_acr_terc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_usuar_cheq_acr_terc

### Índices

---

## Tabela: usuar_event_correio
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_modul_dtsul, cod_event_correio, cod_empresa, cod_estab, cod_unid_negoc, cod_usuario, cod_grp_usuar

### Índices
- **usrvntcr_empresa**: cod_empresa
- **usrvntcr_estab**: cod_estab
- **usrvntcr_grp_usuario**: cod_grp_usuar
- **usrvntcr_unid_negoc**: cod_unid_negoc
- **usrvntcr_usuario**: cod_usuario

---

## Tabela: usuar_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario

### Índices

---

## Tabela: usuar_financ_esp_online
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario, cod_modul_dtsul, cod_estab, cod_espec_docto

### Índices

---

## Tabela: usuar_financ_estab_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, cod_usuario

### Índices

---

## Tabela: usuar_financ_estab_apb
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario, cod_estab

### Índices
- **usrfnnca_estab**: cod_estab

---

## Tabela: usuar_inadimp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario

### Índices
- **usrndmp_adm**: log_usuar_admdr

---

## Tabela: usuar_liber
**Label**: Minimo Aprovacao
**Descrição**: Valor Minimo Aprovacao

### Chave Primária
- cod_usuar_liber_pagto

### Índices

---

## Tabela: usuar_liber_ccusto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuar_liber_pagto, num_seq

### Índices
- **usrlbrcc_sec**: cod_plano_ccusto, cod_ccusto_inic

---

## Tabela: usuar_liber_impl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuar_liber_pagto, cod_usuar_impl

### Índices
- **usrlbrmp_sec**: cod_usuar_impl

---

## Tabela: usuar_liber_sec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuar_liber_pagto, cod_usuar_sec

### Índices
- **usrlbrsc_sec**: cod_usuar_sec

---

## Tabela: usuar_liber_subst
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuar_liber_pagto, cod_usuar_substto

### Índices
- **usrlbrsb_sec**: cod_usuar_substto

---

## Tabela: usuar_liber_unid_negoc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuar_liber_pagto, cod_unid_negoc

### Índices
- **usrlbrnd_sec**: cod_unid_negoc

---

## Tabela: usuar_niv_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_niv_usuar, cod_usuar

### Índices

---

## Tabela: usuar_portad_bco_online
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario, cod_modul_dtsul, cod_estab, cod_portador, cod_cart_bcia, cod_finalid_econ

### Índices
- **usrprtdb_portad_bco**: cod_modul_dtsul, cod_estab, cod_portador, cod_cart_bcia, cod_finalid_econ

---

## Tabela: usuar_univ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario, cod_empresa

### Índices
- **usrnv_ccusto**: cod_empresa, cod_plano_ccusto, cod_ccusto
- **usrnv_estab**: cod_estab
- **usrnv_unid_negoc**: cod_unid_negoc

---

## Tabela: utiliz_cenar_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cenar_ctbl, cod_empresa

### Índices
- **utlzcnrc_unid_organ**: cod_empresa, cod_cenar_ctbl

---

## Tabela: val_aprop_cmg_cambial
**Label**: Sdo Inicial Original
**Descrição**: Valor Saldo Inicial Original

### Chave Primária
- num_id_movto_cta_corren, num_seq_aprop_ctbl_cmg, cod_finalid_econ

### Índices

---

## Tabela: val_aprop_ctbl_acr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_id_aprop_ctbl_acr, cod_finalid_econ

### Índices
- **vlprpcta_aprplnca**: num_id_aprop_lancto_ctbl

---

## Tabela: val_aprop_ctbl_ap
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_estab, num_id_aprop_ctbl_ap, cod_finalid_econ

### Índices
- **vlprpctb_aprplnca**: num_id_aprop_lancto_ctbl

---

## Tabela: val_aprop_ctbl_apl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_movto_operac_financ, num_seq_aprop_ctbl_apl, cod_finalid_econ

### Índices
- **vlprpcte_finalid**: cod_finalid_econ
- **vlprpcte_lancto**: num_id_aprop_lancto_ctbl

---

## Tabela: val_aprop_ctbl_cmg
**Label**: Valor Movimento
**Descrição**: Valor do Movimento de Conta Corrente

### Chave Primária
- num_id_movto_cta_corren, num_seq_aprop_ctbl_cmg, cod_finalid_econ

### Índices
- **vlprpctc_aprop_ctbl**: num_id_aprop_lancto_ctbl
- **vlprpctc_finalid_econ**: cod_finalid_econ

---

## Tabela: val_aprop_ctbl_shc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_ctbz_acaocap, num_seq_aprop_ctbl_shc, cod_finalid_econ

### Índices

---

## Tabela: val_fasb_fatur
**Label**: Valor
**Descrição**: Relacionamento T�tulo Contas a Pagar

### Chave Primária
- ind_tip_orig_inform, cod_estab, cod_refer, num_seq_refer, cod_estab_tit_ap_pai, num_id_tit_ap_pai, cod_unid_negoc, cod_tip_fluxo_financ, cod_finalid_econ, cod_plano_cta_ctbl, cod_cta_ctbl

### Índices
- **vlfsbftr_ltmplttp**: cod_estab, cod_refer

---

## Tabela: val_merc_operac_financ
**Label**: Valor Mercado Operac
**Descrição**: Valor Mercado Opera��o Financeiro

### Chave Primária
- num_id_operac_financ, dat_avaliac_operac_financ, cod_categ_operac_financ

### Índices
- **vlmrcprc_categ**: num_id_operac_financ, cod_categ_operac_financ
- **vlmrcprc_token** (Unique): num_id_val_merc_operac

---

## Tabela: val_movto_acr_correc_val
**Label**: Vl Varic Cambial
**Descrição**: Valor da Varia��o Cambial

### Chave Primária
- cod_estab, num_id_movto_tit_acr, cod_finalid_econ

### Índices

---

## Tabela: val_movto_ap
**Label**: Vl Varic Cambial
**Descrição**: Valor da Varia��o Cambial

### Chave Primária
- cod_estab, num_id_movto_tit_ap, cod_finalid_econ, cod_unid_negoc, cod_tip_fluxo_financ

### Índices
- **vlmvtp_token** (Unique): num_id_val_movto_ap

---

## Tabela: val_movto_ap_correc_val
**Label**: Vl Varic Cambial
**Descrição**: Valor da Varia��o Cambial

### Chave Primária
- cod_estab, num_id_movto_tit_ap, cod_finalid_econ

### Índices

---

## Tabela: val_movto_tit_acr
**Label**: Vl Varic Cambial
**Descrição**: Valor da Varia��o Cambial

### Chave Primária
- cod_estab, num_id_movto_tit_acr, cod_finalid_econ, cod_unid_negoc, cod_tip_fluxo_financ

### Índices
- **vlmvtttc_token** (Unique): cod_estab, num_id_val_movto_tit_acr

---

## Tabela: val_origin_bem_pat
**Label**: Valor Original
**Descrição**: Valor Original Bem Patrimonial

### Chave Primária
- num_id_bem_pat, num_seq_incorp_bem_pat, cod_cenar_ctbl, cod_finalid_econ, dat_calc_pat, dat_transacao, hra_transacao

### Índices

---

## Tabela: val_tit_acr
**Label**: Vl Varic Cambial
**Descrição**: Valor da Varia��o Cambial

### Chave Primária
- cod_estab, num_id_tit_acr, cod_finalid_econ, cod_unid_negoc, cod_tip_fluxo_financ

### Índices
- **vlttcr_num_id**: cod_estab, num_id_val_tit_acr

---

## Tabela: val_tit_ap
**Label**: Vl Varic Cambial
**Descrição**: Valor da Varia��o Cambial

### Chave Primária
- cod_estab, num_id_tit_ap, num_id_movto_tit_ap, cod_finalid_econ, cod_unid_negoc, cod_tip_fluxo_financ

### Índices
- **valtitap_token** (Unique): num_id_val_tit_ap

---

## Tabela: valid_tab_prgssiv_impto
**Label**: M�ximo Redu��o Parcial
**Descrição**: M�ximo Redu��o Parcial

### Chave Primária
- cod_tab_prgssiv_impto_retid, num_seq_valid_tab_prgssiv

### Índices

---

## Tabela: valid_val_min_trans_1099
**Label**: Minimo Transacao 109
**Descrição**: Valor Minimo Transacao 1099

### Chave Primária
- ind_tip_trans_1099, num_seq_val_min_1099

### Índices
- **vldvlmnt_data**: dat_inic_valid, dat_fim_valid

---

## Tabela: variac_cambial_fas
**Label**: Valor varia��o cambial PIS
**Descrição**: Valor varia��o cambial PIS

### Chave Primária
- cod_empresa, cod_cenar_ctbl, cod_finalid_econ, cod_cta_pat, num_bem_pat, num_seq_bem_pat, num_seq_incorp_bem_pat, dat_calc_variac_cambial, ind_trans_variac_cambial

### Índices
- **vrccmblf_ix3**: cod_empresa, log_aprop_ctbl_ctbzda, dat_calc_variac_cambial
- **vrccmblf_ix4**: cod_empresa, cod_cta_pat, num_bem_pat, num_seq_bem_pat, num_seq_incorp_bem_pat, dat_calc_variac_cambial
- **vrccmblf_num_id** (Unique): num_id_variac_cambial

---

## Tabela: veic_eec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq_veic_eec, cod_estab, cdn_func_financ

### Índices
- **veiceec_seq** (Unique): num_seq_veic_eec

---

## Tabela: veja_tambem
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_topico, num_seq

### Índices
- **vjtmbm_unico** (Unique): num_topic_dest, num_topico

---

## Tabela: vencto_calend_comis
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_calend_comis, num_dia_inic, num_dia_fim

### Índices

---

## Tabela: vers_orcto_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_organ, cod_cenar_orctario, cod_cenar_ctbl, cod_exerc_ctbl, cod_vers_orcto_ctbl

### Índices
- **vrsrctcb_exerc_ctbl**: cod_cenar_ctbl, cod_exerc_ctbl

---

## Tabela: vers_orcto_ctbl_bgc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cenar_orctario, cod_unid_orctaria, num_seq_orcto_ctbl, cod_vers_orcto_ctbl

### Índices

---

## Tabela: vers_orcto_unid_orctaria
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cenar_orctario, cod_unid_orctaria, num_seq_orcto_ctbl, cod_vers_orcto_ctbl, cod_unid_orctaria_filho

### Índices
- **vrsrctnd_filho**: cod_unid_orctaria_filho

---

## Tabela: vers_orcto_valido
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_organ, cod_cenar_orctario, cod_vers_orcto_ctbl, cod_cenar_ctbl, cod_exerc_ctbl, cod_plano_ccusto, cod_regra

### Índices

---

## Tabela: wt_process_negoc_cx_cart
**Label**: Valor Pagto Cart�o
**Descrição**: Valor Pagamento Cart�o

### Chave Primária
- num_seq_trans_tef, nom_estacao_tef

### Índices
- **wtprcssn_estac**: nom_estacao_tef, num_seq_trans_tef

---

