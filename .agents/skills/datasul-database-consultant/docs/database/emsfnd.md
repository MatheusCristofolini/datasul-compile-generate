# Esquema do Banco: emsfnd

## Tabela: HIBERNATE_UNIQUE_KEY
### Índices

---

## Tabela: PROCEDURE_CLIENT_INFO_LOGIN
### Índices

---

## Tabela: agenda_rpw
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_modul_refer, cdn_operac, cdn_maq_dest, cod_trans_mp, cod_trans_cld, cdn_trans_edi, num_parcei_edi, cod_unico_identif

### Índices
- **agndrpw_ix2**: cod_unico_identif
- **agndrpw_ix3**: cod_prog_dtsul, cod_empresa

---

## Tabela: api
**Label**: UPC
**Descrição**: Nome do programa UPC, deverǭ ser preenchido somente se houver UPC para a API em questǜo

### Chave Primária
- id_api

### Índices
- **ix_api** (Unique): api
- **ix_nom_api_ext** (Unique): nom_api_ext

---

## Tabela: api_endpoint
**Label**: ID endpoint
**Descrição**: Campo identificador

### Chave Primária
- id_endpoint

### Índices
- **ix_endpoint** (Unique): id_api, endpoint

---

## Tabela: api_segur
**Label**: Verbo
**Descrição**: Verbo relacionado ao endpoint, previamente cadastrado na tabela api_verbo, caso a permissǜo seja para todos os verbos este campo deverǭ ser preenchido com 

### Chave Primária
- id_seguranca

### Índices
- **ix_seguranca** (Unique): api, endpoint, verbo, cod_grp_usuar

---

## Tabela: api_segur_hist
**Label**: Verbo
**Descrição**: Irǭ salvar o valor anterior da tabela api_segur

### Chave Primária
- id_historico

### Índices

---

## Tabela: api_verbo
**Label**: Verbo
**Descrição**: Nome do verbo/a��ǜo do endpoint (GET/POST/PUT/PATCH/DELETE)

### Chave Primária
- id_verbo

### Índices
- **ix_verbo** (Unique): id_endpoint, verbo

---

## Tabela: aplicat_disposit_mov
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **idx_nom_aplicat**: nom_aplicat

---

## Tabela: aplicat_disposit_mov_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **idx_cod_usuario**: cod_usuario
- **idx_num_id_aplicat**: num_id_aplicat_mov

---

## Tabela: aplicat_dtsul
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_aplicat_dtsul

### Índices
- **aplctdts_01**: cod_produt_dtsul
- **aplctdts_02**: cod_grp_aplicat_dtsul
- **aplctdts_frwk** (Unique): idi_dtsul
- **aplctdts_seq**: num_seq

---

## Tabela: aplicat_dtsul_segur
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_aplicat_dtsul, cod_grp_usuar

### Índices
- **aplctdtb_01**: cod_grp_usuar

---

## Tabela: bco_empres
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_bco_dados

### Índices
- **bcmprs_ord_visualiz**: cod_empresa, cod_ord_visualiz

---

## Tabela: bco_histor_conex
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_conex

### Índices

---

## Tabela: bco_histor_seq_conex
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, cod_conex, cod_bco_dados, num_seq

### Índices

---

## Tabela: bco_timeout
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_bco_fisic, cod_empresa

### Índices

---

## Tabela: cadast_liter
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- nom_liter, cod_modul_dtsul

### Índices

---

## Tabela: cadast_msg
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_msg

### Índices
- **cdstmsg_01**: cdn_msg_substdo

---

## Tabela: cadastro_appserver
**Label**: Observa��o Broker
**Descrição**: Peso Appserver

### Chave Primária
- num_id

### Índices
- **cdstrpps_ix2**: cod_empresa, cod_aplicat, des_appserver_alias
- **cdstrpps_ix3**: cod_broker

---

## Tabela: catal_docto_anexo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_catal_docto_anexo

### Índices
- **ctldctnx_01**: cod_aplicat_dtsul
- **ctldctnx_02**: des_catal_docto_anexo

---

## Tabela: catal_img
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_catal_img

### Índices
- **catalimg_01**: cod_aplicat_dtsul
- **catalimg_02**: des_catal_img

---

## Tabela: catal_som
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_catal_som

### Índices
- **catalsom_01**: cod_aplicat_dtsul
- **catalsom_02**: des_catal_som

---

## Tabela: catal_video
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_catal_video

### Índices
- **ctlvd_01**: cod_aplicat_dtsul
- **ctlvd_02**: des_catal_video

---

## Tabela: configur
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- idi_dtsul

### Índices
- **configur_user**: idi_dtsul_usuar_mestre

---

## Tabela: configur_layout_impres
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_layout_impres, cod_funcao_imprsor

### Índices
- **cnfgrlyt_01**: cod_funcao_imprsor, cod_opc_funcao_imprsor, cod_tip_imprsor

---

## Tabela: configur_propried
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_propried, cod_agrpdor

### Índices
- **cnfgrprp_ctx**: cod_contexto_propried

---

## Tabela: configur_tip_imprsor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_funcao_imprsor, cod_opc_funcao_imprsor, cod_tip_imprsor

### Índices
- **cnfgrtpm_01**: cod_tip_imprsor

---

## Tabela: contexto_sessao_fnd
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- des_token, des_inform

### Índices
- **cntxtssa_data**: dat_contexto_sessao

---

## Tabela: contexto_trans_fnd
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- des_token, nom_tabela, num_seq, nom_campo_tab

### Índices
- **cntxttrn_01**: dat_contexto_trans

---

## Tabela: criter
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- idi_dtsul

### Índices
- **criter_user**: idi_dtsul_usuar_mestre

---

## Tabela: dados_integr
**Label**: Nome L�gico
**Descrição**: nom_logic_base

### Chave Primária
- idi_dados_sincroniz_plataf, cod_empresa, nom_logic_base, cod_tabela, cod_operac, dtz_criac, idi_seq_dado

### Índices

---

## Tabela: dados_proteg_campo
**Label**: Tipo do dado
**Descrição**: Tipo do dado

### Chave Primária
- num_id

### Índices
- **dptgcmp_ix2** (Unique): nom_bco, nom_tab, nom_campo

---

## Tabela: dados_proteg_campo_classif
**Label**: Tempo
**Descrição**: Tempo de guarda do dado

### Chave Primária
- num_id_campo, num_id_classif_campo, log_reg_padr

### Índices

---

## Tabela: dados_proteg_campo_cond
**Label**: N�mero Identificador da Classi
**Descrição**: N�mero Identificador da Classifica��o do Campo

### Chave Primária
- num_id

### Índices
- **ddsprtga_ix2** (Unique): num_id_campo_papel, num_id_classif_campo

---

## Tabela: dados_proteg_campo_papel
**Label**: N�mero de identifica��o do pap
**Descrição**: N�mero de identifica��o do papel

### Chave Primária
- num_id

### Índices
- **ddsprtgc_ix2** (Unique): num_id_papel, nom_bco, nom_tab, nom_campo

---

## Tabela: dados_proteg_classif_campo
**Label**: Identificador de chave prim�ri
**Descrição**: Index para consulta por cod_classif_campo

### Chave Primária
- num_id

### Índices
- **dptgclsa_ix2**: cod_classif_campo

---

## Tabela: dados_proteg_exec_cmdo
**Label**: Pedido Execu��o
**Descrição**: Chave primaria

### Chave Primária
- num_id

### Índices

---

## Tabela: dados_proteg_exec_cmdo_consulta
**Label**: Valor do atributo
**Descrição**: ��ndice unico.

### Chave Primária
- num_id

### Índices
- **dptgexcmdo_consulta_ix2**: num_id_exec_cmdo
- **dptgexcmdo_consulta_ix3** (Unique): num_id_exec_cmdo, row_id, modelo, atributo

---

## Tabela: dados_proteg_exec_cmdo_erro
**Label**: Identificador da Execu��o de comando
**Descrição**: Index para consulta

### Chave Primária
- num_id

### Índices
- **dptgexcmdoe_ix2**: num_id_exec_cmdo

---

## Tabela: dados_proteg_exec_cmdo_log
**Label**: Identificador do processamento
**Descrição**: Index de consulta

### Chave Primária
- num_id

### Índices
- **dptgexcmdol_ix2**: num_id_exec_cmdo
- **dptgexcmdol_ix3**: tip_proces

---

## Tabela: dados_proteg_exec_identif_param
**Label**: Valor do par�metro
**Descrição**: Index Unique

### Chave Primária
- num_id

### Índices
- **dptgexidp_ix2** (Unique): num_id_exec_req, num_id_tip_docto

---

## Tabela: dados_proteg_exec_param
**Label**: Valor do par�metro
**Descrição**: Index Unique

### Chave Primária
- num_id

### Índices
- **dptgexp_ix2** (Unique): num_id_exec_req, cod_param

---

## Tabela: dados_proteg_exec_req
**Label**: Tenant
**Descrição**: Index para consultar por Data

### Chave Primária
- num_id

### Índices
- **dptgexr_ix2** (Unique): request_id, tenant_id
- **dptgexr_ix3**: dtm_registro

---

## Tabela: dados_proteg_exec_vinc_param
**Label**: Identificador do papel
**Descrição**: Index Unique

### Chave Primária
- num_id

### Índices
- **dptgexvp_ix2** (Unique): num_id_exec_req, num_id_papel

---

## Tabela: dados_proteg_papel
**Label**: Identificador de chave prim�ri
**Descrição**: N�mero Identificador de chave prim�ria

### Chave Primária
- num_id

### Índices

---

## Tabela: dados_proteg_rot_campo
**Label**: N�mero Identificador da Tabela
**Descrição**: N�mero Identificador da Tabela dados_proteg_campo

### Chave Primária
- cod_prog_dtsul, num_id_campo

### Índices

---

## Tabela: dados_proteg_segur_campo
**Label**: N�mero Identificador da Tabela
**Descrição**: N�mero Identificador da Tabela dados_proteg_campo

### Chave Primária
- num_id_campo, cod_grp_usuar

### Índices

---

## Tabela: dados_proteg_tip_cmdo
**Label**: Identificador
**Descrição**: Index Unique

### Chave Primária
- num_id

### Índices
- **dptgcmdo_ix2** (Unique): cod_cmdo

---

## Tabela: dados_proteg_tip_docto
**Label**: Identificador de chave prim�ri
**Descrição**: N�mero Identificador de chave prim�ria

### Chave Primária
- num_id

### Índices

---

## Tabela: dados_sincroniz_plataf
**Label**: Nome L�gico
**Descrição**: nom_logic_base

### Chave Primária
- idi_dado, cod_empresa, nom_logic_base, cod_tabela, ind_row_id_reg, dtm_criac, cod_operac

### Índices

---

## Tabela: depto_fnd
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_depto

### Índices

---

## Tabela: depto_servid_exec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_depto, cod_servid_exec

### Índices

---

## Tabela: dialet_idiom
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_dialet

### Índices
- **dltdm_01** (Unique): cod_dialet_pai, cod_dialet, log_dialet_padr
- **dltdm_frwk**: idi_dtsul

---

## Tabela: docto_anexo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_docto_anexo

### Índices
- **dctnx_01**: cod_catal_docto_anexo

---

## Tabela: docto_ged_relac_rec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa, nom_banco, nom_tabela, num_id_docto, nom_chave_reg

### Índices

---

## Tabela: dta_assunto
**Label**: Cod Metodo
**Descrição**: Par�metros Json

### Chave Primária
- cod_assunto

### Índices

---

## Tabela: dta_assunto_acao
**Label**: A��o Relacionada
### Chave Primária
- cod_assunto, des_acao

### Índices

---

## Tabela: dta_assunto_glossario
**Label**: Sufixo
### Chave Primária
- cod_assunto, cod_propried

### Índices

---

## Tabela: dta_assunto_pergunta
**Label**: Pergunta
**Descrição**: Embeddings

### Chave Primária
- cod_assunto, des_pergunta

### Índices

---

## Tabela: dta_assunto_rotina
**Label**: C�digo da rotina
### Chave Primária
- cod_assunto, cod_rotina

### Índices
- **idx_dta_rot_assunto**: cod_rotina, cod_assunto

---

## Tabela: dta_contexto
**Label**: Nome
### Chave Primária
- cod_contexto

### Índices

---

## Tabela: dta_contexto_modulo
**Label**: Cod Modulo
### Chave Primária
- cod_contexto, cod_modul_dtsul

### Índices

---

## Tabela: dwb_rpt_param
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_dwb_program, cod_dwb_user

### Índices

---

## Tabela: dwb_rpt_select
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_dwb_program, cod_dwb_user, log_dwb_rule, num_dwb_order

### Índices

---

## Tabela: dwb_set_list
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_dwb_program, cod_dwb_user, num_dwb_order

### Índices

---

## Tabela: dwb_set_list_param
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_dwb_program, cod_dwb_user

### Índices

---

## Tabela: dwb_set_list_param_aux
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_dwb_program, cod_dwb_user, num_dwb_order

### Índices

---

## Tabela: efeito_impres
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_imprsor, ind_efeito_impres, ind_sit_efeito_impres

### Índices
- **eftmprs_01**: cod_funcao_imprsor, cod_opc_funcao_imprsor, cod_tip_imprsor

---

## Tabela: exec_ret_chamada
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_log_execution

### Índices
- **excrtchm_usuario**: cod_usuario

---

## Tabela: extrat_vers
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq

### Índices
- **idx_dataini**: dat_inic, log_ativ
- **idx_usrativ**: cod_usuario, log_ativ

---

## Tabela: faixa_rpw
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_modul_refer, cdn_operac, cdn_maq_dest, cod_trans_mp, cod_trans_cld, cdn_trans_edi, num_parcei_edi, num_dia_inic_faixa, num_dia_fim_faixa, hra_inicial_faixa, hra_fim_faixa, cod_unico_identif_agenda

### Índices

---

## Tabela: favorito
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- idi_dtsul

### Índices
- **favorito_folder**: idi_dtsul_pasta
- **favorito_prgdtsl**: idi_dtsul_prog_dtsul

---

## Tabela: fluig_indic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- idi_fluig_indic

### Índices

---

## Tabela: fnd_empres
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empresa

### Índices

---

## Tabela: fnd_usuar_univ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario

### Índices
- **fndsrnv_01**: cod_empresa, cod_conex_bco_histor

---

## Tabela: funcao_configur_imprsor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_funcao_imprsor

### Índices

---

## Tabela: gerenc_aces_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario, dat_aces_usuar, num_aces_usuar, num_seq_sessao

### Índices
- **idx_exp**: dat_expirac_sessao, num_expirac_sessao, cod_usuario

---

## Tabela: grp_aplicat_dtsul
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- idi_dtsul

### Índices
- **grpplctd_id** (Unique): idi_dtsul_instan, cod_grp_aplicat_dtsul
- **grpplctd_seq**: num_seq

---

## Tabela: grp_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- idi_dtsul

### Índices
- **grpsr_id** (Unique): idi_dtsul_instan, cod_grp_usuar
- **grpusuar_grp**: cod_grp_usuar
- **grpusuar_papel**: log_papel_sist, cod_grp_usuar

---

## Tabela: histor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- idi_dtsul_usuar_mestre

### Índices

---

## Tabela: histor_impres
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- dat_inicial, nom_impressora, nom_arq, cod_prog_dtsul, cod_usuar_exec, dat_efetivac_impres, hra_exec

### Índices
- **hstrmprs_data_efetiva**: dat_efetivac_impres
- **hstrmprs_gr_arquivo**: nom_arq

---

## Tabela: histor_login
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario, dat_aces_usuar, hra_aces_usuar

### Índices

---

## Tabela: histor_senha
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario, dat_incl

### Índices

---

## Tabela: horar_rpw
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_modul_refer, cdn_operac, cdn_maq_dest, cod_trans_mp, cod_trans_cld, cdn_trans_edi, num_parcei_edi, num_dia_exec, hra_exec, cod_unico_identif_agenda

### Índices

---

## Tabela: identif_ext_recur
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_ident_ext, idi_tip_recur_erp, cod_recur_erp

### Índices
- **idntfxtr_tprec** (Unique): idi_tip_recur_erp, cod_recur_erp

---

## Tabela: idiom_trad
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_idiom_trad

### Índices

---

## Tabela: idioma
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_idioma

### Índices

---

## Tabela: imagem
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_imagem

### Índices
- **imagem_01**: cod_catal_img
- **imagem_02**: des_imagem

---

## Tabela: impressora
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- nom_impressora

### Índices
- **imprssr_01**: cod_tip_imprsor

---

## Tabela: imprsor_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- nom_impressora, cod_usuario

### Índices
- **imprsrsr_01**: cod_usuario

---

## Tabela: instan
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- idi_dtsul

### Índices

---

## Tabela: job_exec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_job_exec

### Índices

---

## Tabela: job_exec_agrup_histor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_disparo_job_exec, cod_agrup_job

### Índices

---

## Tabela: job_exec_histor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_disparo_job_exec

### Índices
- **jbxchsta_filtro**: cod_job_exec, cod_servid_exec, log_disparad
- **jbxchsta_log**: log_disparad, cod_job_exec, cod_servid_exec

---

## Tabela: job_exec_prog_digita
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_prog_dtsul, num_seq_campo

### Índices

---

## Tabela: job_exec_prog_digita_reg
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_prog_dtsul, num_seq_campo, num_reg_campo

### Índices
- **jbxcprgd_seq**: cod_prog_dtsul, num_reg_campo, num_seq_campo

---

## Tabela: job_exec_prog_histor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_disparo_job_exec, num_job_exec_seq

### Índices

---

## Tabela: job_exec_prog_param
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_prog_dtsul, num_seq_campo

### Índices

---

## Tabela: job_exec_seq_digita
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_job_exec, num_job_exec_seq, num_seq_campo

### Índices

---

## Tabela: job_exec_seq_digita_reg
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_job_exec, num_job_exec_seq, num_seq_campo, num_reg_campo

### Índices

---

## Tabela: job_exec_seq_param
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_job_exec, num_job_exec_seq, num_seq_campo

### Índices

---

## Tabela: job_exec_seq_prog
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_job_exec, num_job_exec_seq

### Índices
- **jbxcsqpr_job**: cod_prog_dtsul, cod_job_exec, num_job_exec_seq

---

## Tabela: layout_impres
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- nom_impressora, cod_layout_impres

### Índices
- **lytmprs_01** (Unique): num_id_layout_impres
- **lytmprs_02**: cod_tip_imprsor

---

## Tabela: layout_impres_padr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario, cod_proced

### Índices
- **lytmprsp_01**: nom_impressora, cod_usuario
- **lytmprsp_02**: nom_impressora, cod_layout_impres
- **lytmprsp_03**: cod_proced

---

## Tabela: log_exec_api
**Label**: Identificador
**Descrição**: Index utilizado para consulta por empresa.

### Chave Primária
- num_id

### Índices
- **lgxcp_cod_empresa**: cod_empresa

---

## Tabela: log_exec_prog_aux
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_log_exec_prog_aux

### Índices
- **lgxcprgx_id_prog_dtsul**: num_id_log_exec_prog_dtsul

---

## Tabela: log_exec_prog_dtsul
**Label**: Livre 2
**Descrição**: Index utilizado para consulta por empresa.

### Chave Primária
- dat_inic_exec_prog_dtsul, num_id_log_exec_prog_dtsul

### Índices
- **lgxcprgd_01**: cod_prog_dtsul
- **lgxcprgd_02**: cod_usuario
- **lgxcprgd_03**: cod_empresa

---

## Tabela: log_exec_prog_monit
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- dat_inic_exec_prog_dtsul, num_id_log_exec_prog_monit

### Índices
- **lgxcprgm_01**: cod_usuario
- **lgxcprgm_02**: cod_prog_dtsul
- **lgxcprgm_03**: cod_servid_instan

---

## Tabela: log_execution
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_log_execution, num_order

### Índices
- **lgxctn_idi_parent**: cod_log_execution, idi_parent

---

## Tabela: log_tab_estatis
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_log_tab_estatis

### Índices

---

## Tabela: log_uso_metric
**Label**: Quantidade Acumulada
### Chave Primária
- idi_log_uso

### Índices
- **loguso_acum**: cod_metrica, cod_refer, dat_period_acum, des_valor
- **loguso_ult_alt**: dat_ult_alteracao
- **loguso_ult_sinc**: dat_ult_sincroniz

---

## Tabela: login_integr_so
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- log_habtdo_login_integr

### Índices

---

## Tabela: menu_usuar
**Label**: Data de alteracao
**Descrição**: Data de alteracao

### Chave Primária
- cod_usuario

### Índices

---

## Tabela: metadata_biz_schema
**Label**: Vers�o
**Descrição**: �ndice �nico por identifier

### Chave Primária
- id_biz_schema

### Índices
- **idx_md_schema_identif_lang** (Unique): identifier, language

---

## Tabela: metadata_model
**Label**: Vers�o
**Descrição**: �ndice �nico por identifier

### Chave Primária
- id_model

### Índices
- **idx_md_model_identif** (Unique): identifier

---

## Tabela: metadata_object
**Label**: Vers�o
**Descrição**: �ndice �nico por identifier

### Chave Primária
- id_object

### Índices
- **idx_md_object_identif** (Unique): identifier

---

## Tabela: metadata_ui
**Label**: Vers�o
**Descrição**: �ndice �nico por identifier e language

### Chave Primária
- id_ui

### Índices
- **idx_md_ui_identif_lang** (Unique): identifier, language

---

## Tabela: modul_dtsul
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_modul_dtsul

### Índices
- **mdldtsl_01**: cod_sist_dtsul
- **mdldtsl_frwk** (Unique): idi_dtsul

---

## Tabela: noticia
**Label**: ID Not�cia
### Chave Primária
- idi_noticia

### Índices
- **not_apreset**: idi_noticia, dat_ini_apres, dat_fim_apres
- **not_ult_alter**: dat_ult_alteracao, idi_noticia

---

## Tabela: noticia_idioma
**Label**: ID Not�cia
**Descrição**: Portugu�s (pt), Ingl�s (en), Espanhol (es)

### Chave Primária
- idi_noticia, cod_idioma

### Índices
- **idiom**: cod_idioma, idi_noticia

---

## Tabela: noticia_imagem
**Label**: Principal?
### Chave Primária
- idi_noticia, idi_imagem

### Índices

---

## Tabela: noticia_link
**Label**: ID Not�cia
### Chave Primária
- idi_noticia, des_link

### Índices

---

## Tabela: noticia_pais
**Label**: ID Not�cia
**Descrição**: Sigla do pa�s

### Chave Primária
- idi_noticia, cod_sigla

### Índices
- **notpais_sigla**: cod_sigla, idi_noticia

---

## Tabela: noticia_rotina
**Label**: ID Not�cia
### Chave Primária
- idi_noticia, cod_rotina

### Índices
- **notrot_rot**: cod_rotina, idi_noticia

---

## Tabela: oauth2_registered_client
**Descrição**: Indice pelo nome do App

### Chave Primária
- id

### Índices
- **oargcl_agt**: authorization_grant_types
- **oargcl_clid**: client_id
- **oargcl_cn**: client_name

---

## Tabela: oauth2_tokens
### Chave Primária
- uuid

### Índices
- **idx_expiration**: token_exp
- **idx_valid**: is_valid

---

## Tabela: opc_funcao_imprsor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_funcao_imprsor, cod_opc_funcao_imprsor

### Índices

---

## Tabela: ord_configur_imprsor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_funcao_imprsor, cod_tip_imprsor

### Índices
- **ordcnfgr_01** (Unique): cod_tip_imprsor, num_ord_funcao_imprsor

---

## Tabela: param_basic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- dat_ult_atualiz, hra_ult_atualiz

### Índices
- **prmbsc_01**: cod_usuar_ult_atualiz

---

## Tabela: param_email
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_servid_e_mail

### Índices

---

## Tabela: param_extens_ems
**Label**: Parametro Ems
**Descrição**: Valor Parametro Ems

### Chave Primária
- cod_entid_param_ems, cod_chave_param_ems, cod_param_ems

### Índices

---

## Tabela: param_geral_btb
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- dat_ult_atualiz, hra_ult_atualiz

### Índices
- **prmgrlbt_usuario**: cod_usuar_ult_atualiz

---

## Tabela: param_geral_sec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- dat_ult_atualiz, hra_ult_atualiz

### Índices
- **prmgrlsc_usuar**: cod_usuar_ult_atualiz

---

## Tabela: param_sist
**Label**: Valor do par�metro
**Descrição**: Valor do par�metro

### Chave Primária
- cod_param

### Índices
- **prmsst_ix2**: cod_modul_dtsul

---

## Tabela: pasta_favorito
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- idi_dtsul

### Índices

---

## Tabela: ped_exec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario, dat_exec_ped_exec, hra_criac_ped_exec

### Índices
- **pedexec_01**: dat_criac_ped_exec
- **pedexec_02**: ind_motiv_sit_ped_exec
- **pedexec_03**: cod_orig_ped_exec
- **pedexec_04**: num_ped_exec_pai
- **pedexec_05** (Unique): num_ped_exec
- **pedexec_06**: cod_prog_dtsul
- **pedexec_07**: ind_sit_ped_exec
- **pedexec_08**: cod_servid_exec
- **pedexec_10**: cod_usuario, cod_prog_dtsul, dat_exec_ped_exec, hra_exec_ped_exec
- **pedexec_dat_hra_exec**: cod_usuario, dat_exec_ped_exec, hra_exec_ped_exec
- **pedexec_num_ip**: num_pid
- **ped_exec_sv_token**: sv_uuid_token, ind_sit_ped_exec

---

## Tabela: ped_exec_param
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_ped_exec

### Índices
- **pdxcprm_01**: cod_empresa, cod_plano_ccusto

---

## Tabela: ped_exec_param_aux
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_ped_exec, num_dwb_order

### Índices

---

## Tabela: ped_exec_sel
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_ped_exec, num_dwb_order

### Índices

---

## Tabela: perzdo_meta
**Label**: nome campo personalizado
**Descrição**: nome campo personalizado

### Chave Primária
- cod_prog_dtsul, cod_campo_perzdo

### Índices
- **przdmt_ix3**: cod_prog_dtsul

---

## Tabela: perzdo_meta_atrib
**Label**: nome atributo
**Descrição**: nome atributo

### Chave Primária
- cod_prog_dtsul, cod_campo_perzdo, nom_atrib

### Índices

---

## Tabela: prefer_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_prefer_usuar, ind_seq, cod_usuario

### Índices

---

## Tabela: prefer_usuar_prog
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario, cod_prog_dtsul

### Índices

---

## Tabela: proced_consult_proced
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_proced, num_seq

### Índices
- **prcdcnsl_01** (Unique): cod_proced_con, cod_proced

---

## Tabela: proced_relat_proced
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_proced, num_seq

### Índices
- **prcdrltp_01** (Unique): cod_proced_relat, cod_proced

---

## Tabela: procedimento
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_proced

### Índices
- **prcdmnt_01**: cod_modul_dtsul
- **prcdmnt_02**: cod_prog_dtsul_base
- **prcdmnt_03**: cod_modul_dtsul, cod_proced

---

## Tabela: proces_menu
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- idi_proces

### Índices

---

## Tabela: proces_personaliza_usuar
**Label**: Visualiza Menu
**Descrição**: Visualizacao Menu Item

### Chave Primária
- idi_proces, cod_usuario

### Índices
- **prcspsnlusr_02** (Unique): idi_proces_personaliza_usuar

---

## Tabela: proces_prog
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- idi_proces, cod_prog_dtsul, num_seq

### Índices

---

## Tabela: proces_segur
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- idi_proces, cod_grp_usuar

### Índices

---

## Tabela: proces_segur_usuar
**Label**: Tipo permiss�o
**Descrição**: Identifica o tipo de compartilhamento desse processo/pasta

### Chave Primária
- idi_proces, cod_usuario

### Índices
- **prcssgrusr_02** (Unique): idi_proces_segur_usuar

---

## Tabela: produt_dtsul
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_produt_dtsul

### Índices

---

## Tabela: produt_dtsul_segur
**Label**: Produto
**Descrição**: C�digo do Produto

### Chave Primária
- cod_produt_dtsul, cod_grp_usuar

### Índices

---

## Tabela: prog_dtsul
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_prog_dtsul

### Índices
- **prgdtsl_01**: cod_proced
- **prgdtsl_02**: nom_prog_ext
- **prgdtsl_03**: idi_interfac
- **prgdtsl_04**: log_visualiz_menu, idi_tip_prog_dtsul, cod_proced, cod_prog_dtsul
- **prgdtsl_frwk** (Unique): idi_dtsul
- **prgdtsl_frwk_01**: idi_categ_prog_dtsul
- **prgdtsl_frwk_02**: idi_dtsul_modul_dtsul

---

## Tabela: prog_dtsul_dpc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_prog_dtsul, cdn_internac_pais

### Índices
- **prgdtsld_02** (Unique): idi_dtsul, cdn_internac_pais

---

## Tabela: prog_dtsul_ext
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_prog_dtsul, cod_param_extens

### Índices

---

## Tabela: prog_dtsul_localid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_prog_dtsul, cdn_internac_pais

### Índices
- **prgdtsll_02** (Unique): idi_dtsul, cdn_internac_pais

---

## Tabela: prog_dtsul_segur
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_prog_dtsul, cod_grp_usuar

### Índices
- **prgdtsls_01**: cod_grp_usuar
- **prgdtsls_02**: cod_prog_dtsul
- **prgdtsls_frwk** (Unique): idi_dtsul
- **prgdtsls_frwk_01** (Unique): idi_dtsul_prog_dtsul, idi_dtsul_grp_usuar

---

## Tabela: prog_dtsul_vers
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_prog_dtsul

### Índices

---

## Tabela: prog_servid_exec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_prog_dtsul, cod_servid_exec

### Índices
- **prgsrvdx_prog**: cod_prog_dtsul
- **prgsrvdx_servid**: cod_servid_exec

---

## Tabela: propried
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- idi_dtsul

### Índices

---

## Tabela: reg_sessao_web
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- des_token_fnd, cod_tab_folha_des, des_val_idx

### Índices
- **rgssswb_01**: dat_reg_sessao, num_segndo_hora_criac
- **rgssswb_02**: des_token_fnd, cod_tab_folha_des, des_val_idx

---

## Tabela: report_request
**Label**: Publicado?
**Descrição**: Publicado?

### Chave Primária
- cod_unico_identif, cod_unico_identif_request

### Índices
- **rprtrqst_ix3**: cod_usuario
- **rprtrqst_ix4**: cod_relat

---

## Tabela: request_inform
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_request

### Índices

---

## Tabela: segur_empres_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario, cod_empresa

### Índices

---

## Tabela: segur_produt
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_aplicat_dtsul, cod_aplicat_dtsul, cod_sist_dtsul, cod_modul_dtsul, num_rot_dtsul, cod_proced, cod_prog_dtsul

### Índices

---

## Tabela: servid_exec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_servid_exec, cdn_empres_servid

### Índices
- **srvdxc_01**: cod_usuar_superv_servid

---

## Tabela: servid_exec_imprsor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_servid_exec, nom_impressora, cdn_empres_servid

### Índices
- **srvdxcmp_01**: nom_impressora

---

## Tabela: servid_exec_log
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_servid_exec, dat_acao_servid_exec, hra_acao_servid_exec, num_seq, cdn_empres_servid

### Índices
- **srvdxclg_01**: cod_usuario

---

## Tabela: servid_licenc_dat
**Label**: Dados
**Descrição**: dados

### Chave Primária
- cod_tip_servid, cod_servid

### Índices

---

## Tabela: servid_rpc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_servid_rpc

### Índices

---

## Tabela: sist_dtsul
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_sist_dtsul

### Índices
- **sstdtsl_01**: cod_aplicat_dtsul

---

## Tabela: smt_msg
**Label**: ID Mensagem
**Descrição**: �ndice �nico por uuid

### Chave Primária
- num_id_msg

### Índices
- **uq_smt_msg_uuid** (Unique): cod_uuid

---

## Tabela: smt_msg_atributo
**Label**: Valor
**Descrição**: �ndice �nico para atributo.

### Chave Primária
- num_id_msg_atributo

### Índices
- **uq_smt_msg_atributo** (Unique): num_id_msg, cod_atributo

---

## Tabela: smt_msg_audiencia
**Label**: Descri��o
**Descrição**: Chave prim�ria e �nica.

### Chave Primária
- cod_msg_audiencia

### Índices

---

## Tabela: smt_msg_conteudo
**Label**: ID Conte�do
**Descrição**: Chave prim�ria e �nica.

### Chave Primária
- num_id_msg_conteudo

### Índices

---

## Tabela: smt_msg_envio
**Label**: ID Envio
**Descrição**: �ndice de consulta por mensagem.

### Chave Primária
- num_id_msg_envio

### Índices
- **idx_smt_msg_envio_num_id_msg**: num_id_msg

---

## Tabela: smt_msg_historico
**Label**: ID Hist�rico
**Descrição**: �ndice de consulta por mensagem.

### Chave Primária
- num_id_msg_historico

### Índices
- **idx_smt_msg_historico_num_id_msg**: num_id_msg

---

## Tabela: smt_msg_log
**Label**: ID Log
**Descrição**: �ndice de consulta por mensagem.

### Chave Primária
- num_id_msg_log

### Índices
- **idx_smt_msg_log_num_id_msg**: num_id_msg

---

## Tabela: smt_msg_param
**Label**: Valor
**Descrição**: �ndice de consulta por mensagem e param.

### Chave Primária
- num_id_msg_param

### Índices
- **uq_smt_msg_param_num_cod** (Unique): num_id_msg, cod_param

---

## Tabela: smt_msg_proc
**Label**: ID Processamento
**Descrição**: �ndice de consulta por mensagem.

### Chave Primária
- num_id_msg_proc

### Índices
- **idx_smt_msg_proc_num_id_msg**: num_id_msg

---

## Tabela: smt_msg_relac_conteudo
**Label**: ID Relac Conte�do
**Descrição**: Chave composta �nica - Mensagem e Conte�do.

### Chave Primária
- num_id_msg_relac_conteudo

### Índices
- **uq_smt_msg_relac_conteudo** (Unique): num_id_msg, num_id_msg_conteudo

---

## Tabela: smt_msg_relac_proc_envio
**Label**: ID Relac Proc Envio
**Descrição**: Chave composta �nica - Processamento e Envio.

### Chave Primária
- num_id_relac_proc_envio

### Índices
- **uq_smt_msg_relac_proc_envio** (Unique): num_id_msg_proc, num_id_msg_envio

---

## Tabela: smt_msg_tipo
**Label**: Descri��o
**Descrição**: Chave prim�ria e �nica.

### Chave Primária
- cod_msg_tipo

### Índices

---

## Tabela: som
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_som

### Índices
- **som_01**: cod_catal_som
- **som_02**: des_som

---

## Tabela: string_ext_produt
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- idi_string_orig, cod_dialet, cod_string_orig, cod_contexto

### Índices
- **strngxtp_01**: cod_string_orig
- **strngxtp_02**: des_string_trad

---

## Tabela: tab_dic_dtsul
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tab_dic_dtsul

### Índices

---

## Tabela: tab_livre_conver
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_conver

### Índices
- **tblvrcnv_1**: cod_conver_1, cod_conver
- **tblvrcnv_2**: cod_conver_2, cod_conver
- **tblvrcnv_dat_1**: dat_conver_1, cod_conver
- **tblvrcnv_dat_2**: dat_conver_2, cod_conver
- **tblvrcnv_int_1**: cdn_conver_1, cod_conver
- **tblvrcnv_int_2**: cdn_conver_2, cod_conver

---

## Tabela: tab_sincroniz_plataf
**Label**: Nome L�gico
**Descrição**: Nome l�gico da base de dados

### Chave Primária
- idi_tab

### Índices
- **tbsncrnz_ix2**: cod_tabela, cod_empresa, nom_logic_base

---

## Tabela: tip_imprsor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_imprsor

### Índices

---

## Tabela: treport_layout
### Chave Primária
- cod_layout_erp

### Índices
- **idx_hash**: hash
- **idx_layout_name**: layout_name

---

## Tabela: treport_layout_grp_usuar
### Chave Primária
- cod_layout_erp, cod_grp_usuar

### Índices
- **idx_layout**: cod_layout_erp

---

## Tabela: troca_servid_exec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_prog_dtsul

### Índices

---

## Tabela: ui_resource
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- idi_dtsul

### Índices
- **ursrc_mdl**: idi_dtsul_modul_dtsul
- **ursrc_tip**: idi_tip_resource

---

## Tabela: ui_resource_grp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- idi_dtsul

### Índices
- **ursrcgrp_uig** (Unique): idi_dtsul_ui_resource, idi_dtsul_grp_usuar

---

## Tabela: user_access_error
### Chave Primária
- cod_usuario, dat_access

### Índices
- **idx_user**: cod_usuario

---

## Tabela: usuar_basic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario

### Índices

---

## Tabela: usuar_fav
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_produto, cod_usuar_produt, cod_function

### Índices
- **usuarfav_funcao**: cod_function, cod_usuar_produt

---

## Tabela: usuar_grp_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_usuar, cod_usuario

### Índices
- **srgrpsr_usuario**: cod_usuario

---

## Tabela: usuar_menu
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario, cod_prog_dtsul

### Índices
- **idx_cod_modul_dtsul**: cod_modul_dtsul, cod_usuario
- **idx_grp_aplicat_dtsul**: cod_usuario, cod_grp_aplicat_dtsul, idi_tip_prog_dtsul, cod_modul_dtsul
- **idx_modulo**: cod_modul_dtsul
- **idx_nom_prog_ext**: nom_prog_ext
- **idx_pesquisa**: cod_usuario, idi_tip_prog_dtsul, cod_grp_aplicat_dtsul
- **idx_programa**: cod_prog_dtsul, cod_modul_dtsul

---

## Tabela: usuar_menu_estrut
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario, cod_estrut_pai, cod_estrut, num_seq

### Índices
- **usrmnstr_seq**: cod_usuario, cod_estrut, cod_estrut_pai

---

## Tabela: usuar_mestre
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- idi_dtsul

### Índices
- **srmstr_id** (Unique): cod_usuario
- **srmstr_pessoa_fisic**: num_pessoa
- **usrmstr_01**: cod_servid_exec
- **usrmstr_email**: cod_e_mail_local

---

## Tabela: usuar_mestre_aux
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario

### Índices
- **usrmstra_ix** (Unique): cod_unico_identif

---

## Tabela: usuar_mestre_ext
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_domin_so, cod_usuar_so

### Índices
- **usrmstrx_01**: cod_domin_so
- **usrmstrx_srmstr**: cod_usuario

---

## Tabela: usuar_mestre_histor_senha
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario, cod_senha, num_seq

### Índices

---

## Tabela: usuar_noticia
**Label**: Ver depois?
**Descrição**: C�digo Usu�rio

### Chave Primária
- cod_usuario, idi_noticia

### Índices
- **usrnot_favor**: cod_usuario, log_favorita
- **usrnot_lida**: cod_usuario, log_lida
- **usrnot_verdep**: cod_usuario, log_ver_depois

---

## Tabela: usuar_prefer
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq

### Índices
- **usrprfr_01** (Unique): cod_usuario, cod_prog_dtsul, cod_prefer

---

## Tabela: usuar_prefer_campo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq, cod_temp_table, num_reg, cod_field

### Índices

---

## Tabela: usuar_prefer_frame
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq, cod_frame, cod_var

### Índices

---

## Tabela: usuar_prefer_var
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq, cod_var

### Índices

---

## Tabela: usuar_rec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_produto, cod_usuar_produt, cod_function

### Índices
- **idx_date**: dat_atualiz, hra_atualiz
- **usuarrec_funcao**: cod_function, cod_usuar_produt

---

## Tabela: usuar_servid_exec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario, cod_servid_exec

### Índices

---

## Tabela: video
**Label**: Arquivo V�deo
**Descrição**: Arquivo V�deo

### Chave Primária
- cod_video

### Índices
- **video_01**: cod_catal_video
- **video_02**: des_video

---

