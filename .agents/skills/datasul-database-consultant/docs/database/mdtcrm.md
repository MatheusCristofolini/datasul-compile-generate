# Esquema do Banco: mdtcrm

## Tabela: crm_acao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id, log_suspenso

### Índices
- **crmacao_01**: nom_acao

---

## Tabela: crm_acao_fase
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmcfs_01**: num_id_acao, num_id_fase

---

## Tabela: crm_acao_grp_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **idx_num_id_camp_acao**: num_id_campanha_acao, num_id_grp_usuar
- **idx_num_id_grp_usuar**: num_id_grp_usuar

---

## Tabela: crm_acao_mid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmcmd_01**: num_id_campanha_acao, num_id_mid

---

## Tabela: crm_acao_objet
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmcbjt_01**: num_id_campanha_acao, num_id_objet

---

## Tabela: crm_acao_restdo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmcrstd_01**: num_id_campanha_acao, num_id_restdo

---

## Tabela: crm_acao_restdo_acao
**Label**: valor tempo duracao
**Descrição**: valor tempo duracao

### Chave Primária
- num_id

### Índices
- **crmcrsta_01**: num_id_acao_restdo, num_id_acao

---

## Tabela: crm_acao_tip_despes
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmctpds_01**: num_id_campanha_acao, num_id_tip_despes

---

## Tabela: crm_acao_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmcsr_01**: num_id_campanha_acao, num_id_usuar
- **crmcsr_id_usuar**: num_id_usuar

---

## Tabela: crm_acess_compon
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **idx_acesscompon_cod**: cod_compon

---

## Tabela: crm_acess_form_compon
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmcssfa_ix2**: num_id_acess_form_portal, cod_compon
- **crmcssfa_ix3**: num_id_acess_compon

---

## Tabela: crm_acess_form_portal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmcssfr_ix2**: cod_form

---

## Tabela: crm_acess_portal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_acess_portal_regra
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmcsspb_ix2**: num_id_acess_portal, num_id_acess_form_portal, num_id_acess_compon, idi_tip_acess

---

## Tabela: crm_acess_portal_usr_grp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmcsspa_ix2**: num_id_acess_portal, num_id_grp_usuar
- **crmcsspa_ix3**: num_id_acess_portal, num_id_usuar

---

## Tabela: crm_anexo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmanexd_ix6**: num_id_tip_anexo
- **crmanexo_ix7**: num_id_usuar_delete, dtm_delete, num_id
- **crmanexo_ix8**: dtm_delete, num_id
- **idx_crm_anexo_id_reg_id**: num_id_reg
- **idx_idi_tip_anexo**: idi_tip_anexo, num_id_reg
- **idx_num_id_reg**: num_id_reg, idi_tip_anexo

---

## Tabela: crm_assunto_ocor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **idx_nom_assuntoocor** (Unique): nom_assunto_ocor

---

## Tabela: crm_atrib
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmatrib_ix2**: idi_process, idi_sit, idi_tip_cta, idi_tip_pessoa
- **crmatrib_ix3**: idi_sit
- **crmatrib_ix4**: nom_atrib, idi_process

---

## Tabela: crm_atrib_ecm_integr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_bairro
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmbrr_01**: cod_bairro_erp
- **crmbrr_02**: nom_bairro
- **crmbrr_03**: num_id_cidad

---

## Tabela: crm_calc_prfv
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_calend_comerc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmclndc_01**: cod_calend_erp
- **crmclndc_02**: dat_calend
- **crmclndc_03**: num_id_estab

---

## Tabela: crm_campanha
**Label**: Custo Total Previsto
**Descrição**: Valor Total de Custo Previsto

### Chave Primária
- num_id

### Índices
- **crmcmpnd_ix6**: dtm_modif
- **crmcmpnh_01**: nom_campanha
- **crmcmpnh_02**: dat_inic
- **crmcmpnh_term**: dat_term
- **crmcmpnh_tip_camp**: num_id_tip_campanha

---

## Tabela: crm_campanha_acao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmcmpna_01**: num_id_campanha, num_id_acao
- **crmcmpna_id_acao**: num_id_acao

---

## Tabela: crm_campanha_cond_pagto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_campanha_despes
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmcmpnb_01**: num_id_campanha, num_id_tip_despes

---

## Tabela: crm_campanha_log_alter
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmcmpnh_ix3**: num_id_usuar, num_id
- **crmcmpnh_ix4**: num_id_campanha, num_id
- **crmcmpnh_ix5**: dtm_cadastro, num_id
- **crmcmpnh_ix6**: nom_operac, num_id

---

## Tabela: crm_campanha_tab_preco
**Label**: Percentual Desconto Pexcec Cam
**Descrição**: Valor Percentual Desconto Campanha

### Chave Primária
- num_id

### Índices
- **crmcmpnd_01**: num_id_campanha, num_id_tab_preco

---

## Tabela: crm_campanha_tab_preco_item
**Label**: Percentual Desconto Pexcec Cam
**Descrição**: Valor Percentual Desconto Campanha

### Chave Primária
- num_id

### Índices
- **crmcmpne_01**: num_id_campanha_tab_preco, num_id_tab_preco_item

---

## Tabela: crm_causa_ocor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_cep
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmcep_01**: cod_cep
- **crmcep_02**: num_id_bairro
- **crmcep_03**: num_id_cidad
- **crmcep_04**: nom_lograd_cep

---

## Tabela: crm_cfisc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmcfisc_01** (Unique): nom_classif_fisc

---

## Tabela: crm_cidad
**Label**: % Icms Zona franca manaus
**Descrição**: Valor Percentual Icms Zona franca manaus

### Chave Primária
- num_id

### Índices
- **crmcidad_01**: nom_cidade
- **crmcidad_02**: num_id_uf
- **crmcidad_03**: cod_cidad_erp

---

## Tabela: crm_clas
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmclas_01**: nom_clas_clien

---

## Tabela: crm_classif_ocor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmclssf_01**: nom_classif_ocor

---

## Tabela: crm_classif_ocor_item
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmclssa_01**: num_id_classif_ocor, num_id_produt_supor

---

## Tabela: crm_classif_ocor_item_recur
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmclssb_01**: num_id_classif_ocor_item, num_id_recur

---

## Tabela: crm_concor_produt
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmcncrp_01**: num_id_concor, num_id_produt

---

## Tabela: crm_configur_acao_ocor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **idx_confgacaoocor_idioperac**: idi_operac

---

## Tabela: crm_configur_acao_ocor_regra
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **idx_configacocrrg_id_config**: num_id_configur_acao_ocor

---

## Tabela: crm_configur_aces_campos
**Label**: Livre 1
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmcnfgr_ix2**: nom_rot, num_id
- **crmcnfgr_ix3**: nom_campo, num_id

---

## Tabela: crm_configur_pessoa_facil
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmcnfgr_01**: idi_tip_cta, idi_tip_pessoa

---

## Tabela: crm_configur_usuar
**Label**: Livre 1
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmcnfga_ix2**: cod_usuario
- **crmcnfga_ix3**: nom_configur, cod_usuario

---

## Tabela: crm_conver_tab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmcnvrt_01**: nom_tab_crm, cod_campo_pai

---

## Tabela: crm_depto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmdepto_01**: nom_departamento

---

## Tabela: crm_desenv_estrateg
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmdsnvs_01**: num_id_estrateg_vda, num_id_fase

---

## Tabela: crm_detmnto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmdtmnt_01**: nom_detmnto_restdo

---

## Tabela: crm_docto_ident
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmdctdn_01**: cod_docto_ident
- **crmdctdn_02**: num_id_pessoa
- **crmdctdn_03**: num_id_tip_docto

---

## Tabela: crm_empres
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_ender
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmended_ix6**: cod_zip_code, num_id
- **crmender_01**: num_id_pessoa
- **crmender_02**: idi_tip_ender
- **crmender_03**: num_id_cep
- **crmender_04**: nom_lograd_ender

---

## Tabela: crm_erp_cond_pagto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmrpcnd_01**: cod_cond_pagto_erp

---

## Tabela: crm_erp_cotac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmrpctc_01**: num_id_moed

---

## Tabela: crm_erp_inf_comerc
**Label**: Total Pedido Aprovado
**Descrição**: Valor Total Pedido Aprovado

### Chave Primária
- num_id

### Índices
- **crmrpnfc_01**: num_id_pessoa

---

## Tabela: crm_erp_moed
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmrpmd_01**: cod_moed_erp

---

## Tabela: crm_erp_natur_operac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmrpntr_01**: cod_cfop_erp

---

## Tabela: crm_erp_portad
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmrpprt_01**: cod_portad_erp

---

## Tabela: crm_erro_lead
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_error_conv
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmrrrcn_01**: nom_tab_crm

---

## Tabela: crm_estab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmestab_01**: cod_estab_erp

---

## Tabela: crm_estado_civil
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmstdcv_01**: nom_estado_civil

---

## Tabela: crm_estil
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmestil_01**: nom_estilo

---

## Tabela: crm_estrateg_vda
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmstrtg_01**: des_estrateg_vda

---

## Tabela: crm_etiq
**Label**: Margem Superior
**Descrição**: Valor Margem Superior

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_etiq_atrib
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmtqtrb_01**: num_id_etiq

---

## Tabela: crm_faixa
**Label**: Inicial
**Descrição**: Valor - Inteiro Inicial

### Chave Primária
- num_id

### Índices
- **crmfaixa_prfv_inicial**: num_id_prfv, vli_inicial

---

## Tabela: crm_familia
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmfml_01**: nom_familia_mater
- **crmfml_02**: cod_familia_mater_erp

---

## Tabela: crm_familia_comerc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmfmlcm_01**: nom_familia_comerc
- **crmfmlcm_02**: cod_familia_comerc_erp

---

## Tabela: crm_fase_estrateg_vda
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmfsstr_01**: des_fase

---

## Tabela: crm_fase_status_gpl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmfsstt_01**: num_id_fase, num_id_status_simul

---

## Tabela: crm_fluig_dados_erro
**Label**: TimeStamp
**Descrição**: TimeStamp

### Chave Primária
- num_id

### Índices
- **crmflgda_ix2**: num_id_reg, idi_tip_process
- **crmflgda_ix3**: idi_tip_process, vli_timestamp

---

## Tabela: crm_fluig_dados_integrad
**Label**: valor TimeStamp
**Descrição**: valor TimeStamp

### Chave Primária
- num_id

### Índices
- **crmflgdd_ix2**: nom_tab, dat_cadastro, hra_cadastro, num_id_usuar
- **crmflgdd_ix4**: nom_tab, val_timestamp, num_id_reg

---

## Tabela: crm_fluig_histor_integrad
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmflghs_ix2**: nom_dataset, dat_exec, hra_exec, idi_operac

---

## Tabela: crm_fluig_param
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_fluig_param_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmflgpa_ix2**: num_id_fluig_param, num_id_usuar
- **crmflgpa_ix3**: num_id_usuar

---

## Tabela: crm_fonte
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmfonte_01**: nom_fonte

---

## Tabela: crm_grp_clien
**Label**: Percentual Minimo Faturamento
**Descrição**: Valor Percentual Minimo Faturamento Pedido

### Chave Primária
- num_id

### Índices
- **crmgrpcl_01**: cod_grp_clien_erp

---

## Tabela: crm_grp_estil
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_grp_estoq
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmgrpst_01**: nom_grp_estoq
- **crmgrpst_02**: cod_grp_estoq_erp

---

## Tabela: crm_grp_potenc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_grp_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_grp_usuar_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_hier_cta_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **idx_cod_pessoa_erp**: idi_tip_calc, cod_pessoa_erp
- **idx_cod_usuar**: idi_tip_calc, cod_usuar, num_id_cta
- **idx_num_id_cta**: idi_tip_calc, num_id_cta, num_id_usuar
- **idx_num_id_cta_2**: idi_tip_calc, num_id_cta, cod_usuar
- **idx_num_id_usuar**: idi_tip_calc, num_id_usuar, num_id_cta

---

## Tabela: crm_histor_acao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmhstre_01**: num_id_pessoa
- **crmhstre_02**: num_id_usuar
- **crmhstre_03**: num_id_campanha, num_id_acao
- **crmhstre_04**: dat_inic, dat_fim
- **idx_crmtar_dat_cad_pess**: dat_cadastro, num_id_pessoa
- **idx_pess_ocor**: num_id_ocor, num_id_pessoa
- **idx_pess_oport**: num_id_oportun, num_id_pessoa
- **idx_pess_tar**: num_id_tar, num_id_pessoa
- **idx_usr_dat**: dat_cadastro, num_id_usuar
- **idx_usr_dat_pes**: num_id_usuar, dat_inic, num_id_pessoa

---

## Tabela: crm_histor_acao_atrib
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmhstrc_ix2**: num_id_histor_acao, num_id_atrib

---

## Tabela: crm_histor_movto_ocor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmhstrm_ix2**: num_id_histor_acao, num_id_ocor, num_id
- **crmhstrm_ix3**: num_id_ocor, num_id_status_ocor, num_id
- **crmhstrm_ix4**: num_id_ocor, num_id_status_ocor_origem, num_id

---

## Tabela: crm_histor_movto_oportun
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmhstra_ix2**: num_id_histor_acao, num_id_oportun, num_id
- **crmhstra_ix3**: num_id_oportun, num_id_fase, num_id
- **crmhstra_ix4**: num_id_oportun, num_id_fase_origem, num_id

---

## Tabela: crm_histor_nf_item
**Label**: Total Item Faturado
**Descrição**: Valor Total Item Faturado

### Chave Primária
- num_id

### Índices
- **crmhstrn_01**: cod_estab, cod_nota_fisc, cod_ser_docto_nf
- **crmhstrn_02**: cod_item_erp

---

## Tabela: crm_histor_nota_fisc
**Label**: Total Nota
**Descrição**: Valor Total da Nota

### Chave Primária
- num_id

### Índices
- **crmhstra_01**: cod_estab, cod_nota_fisc, cod_ser_docto_nf
- **crmhstra_02**: cod_cliente

---

## Tabela: crm_histor_parc_nf
**Label**: Percentual Pagamento
**Descrição**: Valor Percentual do Pagamento

### Chave Primária
- num_id

### Índices
- **crmhstrp_01**: cod_estab, cod_nota_fisc, cod_ser_docto_nf

---

## Tabela: crm_histor_parc_pdven
**Label**: Percentual Pagamento
**Descrição**: Valor Percentual do Pagamento

### Chave Primária
- num_id

### Índices
- **crmhstrb_01**: num_ped_vda

---

## Tabela: crm_histor_pdven
**Label**: Valor Seguro Pedido de venda
**Descrição**: Valor Seguro Pedido de venda

### Chave Primária
- num_id

### Índices
- **crmhstrc_01**: num_id_pessoa
- **crmhstrc_02**: cod_ped_clien

---

## Tabela: crm_histor_ped_item
**Label**: Total Item
**Descrição**: Valor total do item do pedido

### Chave Primária
- num_id

### Índices
- **crmhstrd_01**: num_id_pdven
- **crmhstrd_02**: num_id_produt

---

## Tabela: crm_histor_tit_crb
**Label**: Valor Transferido
**Descrição**: Valor Transferencias Estabelecimento

### Chave Primária
- num_id

### Índices
- **crmhstrt_01**: cod_pessoa_erp

---

## Tabela: crm_horar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_instruc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_jorn_trabdo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_layout_atrib
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmlyttr_01**: num_id_layout

---

## Tabela: crm_layout_imptdor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_legenda
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmlgnd_nom_campo**: nom_tab_atrib, num_seq, nom_tab

---

## Tabela: crm_lembret
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_log_delete
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmlgdlt_ix2**: nom_tab, num_id
- **crmlgdlt_ix3**: num_id_usuar, num_id
- **crmlgdlt_ix4**: dtm_cadastro, num_id

---

## Tabela: crm_log_erro_integr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_log_exc_proces
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **idx_logexcproces_codusua_datex**: cod_usuario, idi_proces_exc, dat_exec
- **idx_logexcproces_datexec**: dat_exec, idi_proces_exc
- **idx_logexcproces_idiproc**: idi_proces_exc

---

## Tabela: crm_log_hier
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_log_ocor_email
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_log_telef
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_log_transf
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmlgtrn_01**: num_id_pessoa
- **crmlgtrn_02**: num_id_usuar

---

## Tabela: crm_log_uniao_ctas_gpl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_log_utiliza_telef
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_meta_fase
**Label**: Meta Valor
**Descrição**: Valor Meta

### Chave Primária
- num_id

### Índices
- **crmmtfs_01**: num_id_meta, num_id_fase

---

## Tabela: crm_meta_usuar
**Label**: Meta Valor
**Descrição**: Valor Meta

### Chave Primária
- num_id

### Índices
- **crmmtsr_01**: num_id_meta, num_id_usuar

---

## Tabela: crm_meta_vda
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmmtvd_01**: num_id_estrateg_vda, dat_inic, dat_fim, num_id

---

## Tabela: crm_mid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmmid_01**: nom_mid_relacto

---

## Tabela: crm_motiv_ganho_perda
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_niv_decis
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_niv_recur
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmnvrcr_01**: nom_niv_recur

---

## Tabela: crm_objet
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id, log_suspenso

### Índices
- **crmobjet_01**: nom_objet_acao

---

## Tabela: crm_ocor
**Label**: Livre 2
**Descrição**: Indice �nico por c�digo de protocolo

### Chave Primária
- num_id

### Índices
- **crmocor_01**: num_id_pessoa
- **crmocor_02**: num_id_recur
- **crmocor_03**: dat_abert
- **crmocor_04**: num_id_tip_ocor
- **crmocor_05**: nom_ocor
- **crmocor_06**: num_id_recur, num_id_pessoa
- **crmocor_classif**: num_id_classif_ocor_item
- **crmocor_ix11**: cod_estab, cod_ser, cod_nota_fisc
- **crmocor_ix12**: cod_ped_clien
- **crmocou_ix10**: num_id_grp_usuar
- **idx_crmocor_dat_fecht**: dat_fechto
- **idx_protocolo** (Unique): cod_livre_1

---

## Tabela: crm_ocor_atrib
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmcrtrb_ix2**: num_id_ocor, num_id_atrib

---

## Tabela: crm_ocor_fluxo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmcrflx_01**: nom_ocor_fluxo
- **crmcrflx_susp**: log_suspenso

---

## Tabela: crm_ocor_fluxo_recur
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmcrfla_01**: num_id_recur, num_id_ocor_fluxo
- **crmcrfla_02**: num_id_ocor_fluxo

---

## Tabela: crm_ocor_fluxo_regra
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmcrfle_01**: num_id_ocor_fluxo

---

## Tabela: crm_ocor_fluxo_restric
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmcrflf_01**: num_id_ocor_fluxo_status, num_id_ocor_fluxo_status_restric

---

## Tabela: crm_ocor_fluxo_status
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmcrflb_01**: num_id_ocor_fluxo, num_id_status_ocor

---

## Tabela: crm_ocor_fluxo_status_recur
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmcrflc_01**: num_id_ocor_fluxo_status, num_id_ocor_fluxo_recur

---

## Tabela: crm_ocor_fluxo_status_regra
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmcrflg_01**: num_id_ocor_fluxo_status

---

## Tabela: crm_ocor_gp_ext
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **idx_ocor**: num_id_ocor, num_id

---

## Tabela: crm_ocor_model
**Label**: Livre 2
**Descrição**: indice descri��o modelo

### Chave Primária
- num_id

### Índices
- **idx-canal-atend**: num_id_orig
- **idx-categoria**: num_id_tip_ocor
- **idx-cod-modelo** (Unique): cod_modelo
- **idx-descr-modelo**: desc_modelo
- **idx-motivo**: num_id_assunto_ocor
- **idx-setor**: num_id_grp_usuar

---

## Tabela: crm_ocor_niv_service
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmcrnvs_01**: num_id_ocor
- **crmcrnvs_02**: num_id_status_ocor
- **crmcrnvs_03**: num_id_recur

---

## Tabela: crm_ocor_palavra_chave
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmcrplv_01**: num_id_ocor, num_id_palavra_chave
- **crmcrplv_wkey**: num_id_palavra_chave

---

## Tabela: crm_ocor_produt
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmcrprd_ix3**: num_id_ocor
- **crmcrprd_ix4**: num_id_classif_ocor_item

---

## Tabela: crm_ocor_relat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmcrrlt_ix2**: num_id_tip_ocor, idi_seq_acao

---

## Tabela: crm_ocor_sintom
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmcrsnt_01**: num_id_ocor, num_id_sintom
- **crmcrsnt_id_sint**: num_id_sintom

---

## Tabela: crm_ocupac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmcpc_01**: nom_ocupac

---

## Tabela: crm_oportun_concor
**Label**: Valor Oportunidade Venda
**Descrição**: Valor Oportunidade Venda

### Chave Primária
- num_id

### Índices
- **crmprtnc_01**: num_id_oportun
- **crmprtnc_02**: num_id_pessoa

---

## Tabela: crm_oportun_contat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmprtna_01**: num_id_oportun

---

## Tabela: crm_oportun_ganho_perda
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmprtng_01**: num_id_oportun
- **crmprtng_02**: num_id_motiv_ganho

---

## Tabela: crm_oportun_produt
**Label**: Total Itens
**Descrição**: Valor Total Itens

### Chave Primária
- num_id

### Índices
- **crmprtnp_01**: num_id_produt
- **crmprtnp_02**: num_id_oportun

---

## Tabela: crm_oportun_reven
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmprtnr_01**: num_id_oportun

---

## Tabela: crm_oportun_vda
**Label**: Realizado Simulacao
**Descrição**: Valor Realizado Simulacao

### Chave Primária
- num_id

### Índices
- **crmprtnv_01**: num_id_pessoa
- **crmprtnv_02**: des_oportun_vda
- **crmprtnv_03**: dat_cadastro
- **crmprtnv_04**: dat_fechto_oportun
- **crmprtnv_05**: num_id_usuar_respons
- **crmprtnv_06**: num_id_campanha
- **crmprtnv_07**: num_id_estrateg_vda, num_id_fase
- **crmprtnv_08**: dat_cadastro, num_id_pessoa

---

## Tabela: crm_oportun_vda_atrib
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmprtnv_ix2**: num_id_oportun, num_id_atrib

---

## Tabela: crm_orig_ocor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmrgcr_01**: nom_orig_ocor
- **crmrgcr_susp**: log_suspenso

---

## Tabela: crm_outlook_sincroniz
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_usuar

### Índices

---

## Tabela: crm_pais
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmpais_01**: nom_pais
- **crmpais_02**: cod_pais_erp

---

## Tabela: crm_palavra_chave
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmplvrc_01**: nom_palavra_chave

---

## Tabela: crm_param
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmparam_01**: nom_param_crm
- **crmparam_02**: nom_grp_param

---

## Tabela: crm_param_movimen_pessoa
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_param_prfv
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmprmpr_01**: num_id_public

---

## Tabela: crm_param_relat_web
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_param_relat_web_atrib
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmprmrl_ix2**: val_atrib, num_id
- **crmprmrl_ix3**: nom_atrib, num_id

---

## Tabela: crm_param_sit_financ
**Label**: Valor m�nimo
**Descrição**: Valor m�nimo

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_pessoa
**Label**: Percentual Desconto Cliente
**Descrição**: Valor Percentual Desconto Cliente

### Chave Primária
- num_id

### Índices
- **crmpss_01**: idi_tip_pessoa, idi_tip_cta
- **crmpss_02**: nom_razao_social
- **crmpss_03**: cod_pessoa_erp
- **crmpss_04**: nom_abrev
- **crmpss_05**: nom_cnpj
- **crmpss_06**: nom_cpf
- **crmpss_email**: nom_email_1, nom_email_2
- **crmpss_outlook_stamp**: num_id, log_integrad_outlook, dat_timestamp
- **crmpss_resp_outlook_stamp**: dat_timestamp, num_id_usuar_respons, log_integrad_outlook
- **idx_crmpss_data_nasc**: dat_nascimento
- **idx_crmpss_dat_cad**: dat_cadastro
- **idx_crmpss_usr_cad**: num_id_usuar_cadastro
- **idx_niv_aces**: idi_niv_aces
- **idx_pessoa_gpl**: cod_pessoa_gpl
- **idx_tip_cta**: idi_tip_cta
- **idx_usuar_resp**: num_id_usuar_respons

---

## Tabela: crm_pessoa_atrib
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmpsstr_ix2**: num_id_pessoa, num_id_atrib
- **crmpsstr_ix3**: num_id_atrib

---

## Tabela: crm_pessoa_comp
**Label**: Ultimo Compra
**Descrição**: Valor Ultimo Compra

### Chave Primária
- num_id

### Índices
- **crmpsscd_ix3**: nom_crm
- **crmpsscm_idx_pessoa**: num_id_pessoa

---

## Tabela: crm_pessoa_email
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **fk_crmpssml_pess**: num_id_pessoa

---

## Tabela: crm_pessoa_estil
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmpssst_01**: num_id_pessoa, num_id_estil

---

## Tabela: crm_pessoa_extens
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmpssxt_ix2**: num_id_pessoa
- **crmpssxt_ix3**: cod_uuid

---

## Tabela: crm_pessoa_facil
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_pessoa_potencd
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmpsspt_01**: num_id_pessoa, num_id_potencd

---

## Tabela: crm_pessoa_unif
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **idx_pessoaunif_codusuar**: cod_usuario
- **idx_pessoaunif_datcad**: dat_cadastro

---

## Tabela: crm_potencd
**Label**: Valor Potencialidade
**Descrição**: Valor Potencialidade

### Chave Primária
- num_id

### Índices
- **crmptncd_01**: nom_potencd

---

## Tabela: crm_preferenciausua
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_prfv_faixa
**Label**: Valor
**Descrição**: Valor Valor

### Chave Primária
- num_id

### Índices
- **crmprfvf_01**: num_id_pessoa

---

## Tabela: crm_prfv_faixa_cabec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_prfv_forma
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmprfva_01**: num_id_prfv

---

## Tabela: crm_prfv_ped
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmprfvp_01**: num_id_prfv

---

## Tabela: crm_priorid_ocor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmprrdc_01**: nom_priorid_ocor
- **crmprrdc_susp**: log_suspenso

---

## Tabela: crm_priorid_ocor_niv_recur
**Label**: Tempo de Resposta
**Descrição**: Tempo de Resposta

### Chave Primária
- num_id

### Índices
- **crmprrda_01**: num_id_priorid_ocor, num_id_niv_recur

---

## Tabela: crm_probab_vda
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_proces_hier
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_produt
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmprdt_01**: nom_produt
- **crmprdt_02**: cod_item_erp
- **crmprdt_03**: num_id_fc
- **crmprdt_04**: num_id_familia
- **crmprdt_05**: num_id_grp_estoq

---

## Tabela: crm_produt_clien
**Label**: Ultimo Compra
**Descrição**: Valor Ultimo Compra

### Chave Primária
- num_id

### Índices
- **crmprdtc_01**: cod_item_erp, cod_pessoa_erp
- **crmprdtc_02**: cod_item_clien
- **crmprdtd_ix4**: num_id_produt, num_id_umd, num_id_pessoa

---

## Tabela: crm_produt_compon
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmprdta_01**: num_id_produt, num_id_produt_filho

---

## Tabela: crm_produt_icms_difdor
**Label**: Percentual Reducao Icms
**Descrição**: Percentual Reducao Icms

### Chave Primária
- num_id

### Índices
- **crmprdtd_01**: num_id_uf_orig, num_id_uf_dest
- **crmprdtd_02**: num_id_produt

---

## Tabela: crm_produt_refer
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmprdtr_01**: num_id_produt
- **crmprdtr_02**: num_id_refer

---

## Tabela: crm_produt_supor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmprdts_01**: num_id_produt

---

## Tabela: crm_produt_supor_vers
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmprdtb_01**: num_id_produt_supor, num_id_vers

---

## Tabela: crm_profissao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmprfss_01**: nom_profissao

---

## Tabela: crm_propried
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmprprd_01**: nom_tab_crm

---

## Tabela: crm_pto_critic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_pto_critic_oportun
**Label**: Peso (Kg)
**Descrição**: Peso (Kg)

### Chave Primária
- num_id

### Índices
- **crmptcra_01**: num_id_oportun, num_id_pto_critic

---

## Tabela: crm_pto_fort
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_pto_fort_fraco_concor
**Label**: Peso (Kg)
**Descrição**: Peso (Kg)

### Chave Primária
- num_id

### Índices
- **crmptfra_01**: num_id_concor, num_id_pto_fort

---

## Tabela: crm_pto_fort_fraco_oportun
**Label**: Peso (Kg)
**Descrição**: Peso (Kg)

### Chave Primária
- num_id

### Índices
- **crmptfrb_01**: num_id_oportun, num_id_pto_fort

---

## Tabela: crm_public
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmpblc_01**: num_id_usuar
- **crmpblc_02**: num_id_segmtcao

---

## Tabela: crm_public_dados
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmpblcd_01**: num_id_public
- **crmpblcd_02**: num_id_pessoa

---

## Tabela: crm_public_layout
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_public_layout_campo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmpblca_01**: num_id_segmtcao_dados

---

## Tabela: crm_ramo_ativid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmrmtvd_01**: nom_ramo_ativid

---

## Tabela: crm_recur
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmrecur_01**: num_id_usuar, log_suspenso

---

## Tabela: crm_refer
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmrefer_01**: nom_refer
- **crmrefer_02**: cod_refer_erp

---

## Tabela: crm_regiao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmrg_01**: nom_regiao_atendim
- **crmrg_02**: cod_regiao_erp

---

## Tabela: crm_relat_exc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmrltxc_01**: num_id_usuar_exec
- **crmrltxc_02**: num_id_pessoa

---

## Tabela: crm_relat_web
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **idx_nom_relat**: nom_relat

---

## Tabela: crm_repres
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmrprs_01**: num_id_regiao
- **crmrprs_02**: cod_repres_erp

---

## Tabela: crm_restdo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmrstd_01**: nom_restdo

---

## Tabela: crm_restdo_detmnto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmrstdd_01**: num_id_restdo, num_id_detmnto

---

## Tabela: crm_script
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmscrpt_ix2**: idi_tip_script, val_inic_valid, val_fim_valid
- **crmscrpt_ix4**: num_id_usuar, idi_tip_script
- **crmscrpt_ix5**: nom_script

---

## Tabela: crm_script_config
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmscrpt_ix2**: idi_tip_process, num_id_process, num_id_process_2, num_id_campanha
- **crmscrpt_ix3**: num_id_script
- **crmscrpt_ix4**: num_id_campanha, log_tar
- **crmscrpt_ix5**: dat_cadastro, num_id_usuar
- **crmscrpt_ix6**: num_id_usuar

---

## Tabela: crm_script_envio
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmscrpe_ix2**: num_id_quest, idi_status, num_id_usuar, dtm_cadastro

---

## Tabela: crm_script_envio_dados
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmscrpf_ix2**: num_id_envio, nom_id_script_respos
- **crmscrpf_ix3**: nom_email

---

## Tabela: crm_script_pag
**Label**: Peso
**Descrição**: Peso

### Chave Primária
- num_id, num_id_script

### Índices
- **crmscrpt_ix2**: num_id_script, num_pag
- **crmscrpt_ix3**: nom_pag

---

## Tabela: crm_script_permis
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmscrpb_ix3**: num_id, num_id_usuar, num_id_grp_usuar
- **crmscrpb_ix4**: num_id_usuar, num_id
- **crmscrpb_ix5**: num_id_grp_usuar, num_id

---

## Tabela: crm_script_quest
**Label**: Peso
**Descrição**: Peso

### Chave Primária
- num_id, num_id_pag, idi_tip_quest

### Índices
- **crmscrpt_ix3**: num_id_pag, num_quest
- **crmscrpt_ix4**: nom_quest

---

## Tabela: crm_script_quest_atrib
**Label**: Peso
**Descrição**: Peso

### Chave Primária
- num_id, num_id_quest, num_atrib

### Índices
- **crmscrpt_ix2**: num_id_quest, num_atrib
- **crmscrpt_ix3**: nom_atrib

---

## Tabela: crm_script_respos
**Label**: Peso (Kg)
**Descrição**: Peso (Kg)

### Chave Primária
- nom_id

### Índices
- **crmscrpa_ix10**: val_dat_cadastro, idi_status
- **crmscrpa_ix11**: nom_email
- **crmscrpa_ix12**: num_id_envio
- **crmscrpa_ix6**: idi_tip_script, num_id_reg, val_peso, val_dat_atualiz
- **crmscrpa_ix7**: val_dat_atualiz, idi_status
- **crmscrpa_ix8**: val_peso
- **crmscrpa_ix9**: idi_status
- **crmscrpt_ix2**: num_id_script, num_id_usuar, num_id_pessoa
- **crmscrpt_ix3**: num_id_usuar, idi_status
- **crmscrpt_ix4**: num_id_pessoa, num_id_usuar, num_id_script

---

## Tabela: crm_script_respos_atrib
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id, num_id_respos_quest, num_id_atrib

### Índices
- **crmscrpt_ix2**: num_id_respos_quest, num_id_atrib

---

## Tabela: crm_script_respos_quest
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- nom_id, nom_id_respos, num_id_quest

### Índices
- **crmscrpt_ix2**: nom_id_respos, num_id_quest
- **crmscrpt_ix3**: num_id_quest, nom_id_respos

---

## Tabela: crm_script_usr_grp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmscrpc_ix2**: num_id_script, num_id_usuar, num_id_grp_usuar

---

## Tabela: crm_segmtcao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmsgmtc_01**: num_id_usuar
- **crmsgmtc_02**: num_id_public

---

## Tabela: crm_segmtcao_atrib
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmsgmtb_01**: num_id_segmtcao_dados
- **crmsgmtb_02**: num_seq
- **crmsgmtb_nom_apel**: nom_apel_campo

---

## Tabela: crm_segmtcao_dados
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_segmtcao_itens
**Label**: Resultado
**Descrição**: Valor Resultado

### Chave Primária
- num_id

### Índices
- **crmsgmta_01**: num_id_segmtcao
- **crmsgmta_02**: num_id_segmtcao_dados

---

## Tabela: crm_segmtcao_relacto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_segmtcao_relacto_atrib
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmsgmtf_01**: num_id_segmtcao_relacto
- **crmsgmtf_02**: num_id_segmtcao_atrib

---

## Tabela: crm_sintom
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_status_ocor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmsttsc_01**: nom_status_ocor
- **crmsttsc_susp**: log_suspenso

---

## Tabela: crm_subgrp_potencd
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_tab_preco
**Label**: Percentual Desconto
**Descrição**: Percentual Desconto

### Chave Primária
- num_id

### Índices
- **crmtbprc_01**: cod_preco_erp

---

## Tabela: crm_tab_preco_item
**Label**: Pre�o Unit�rio
**Descrição**: Valor Preco Unitario

### Chave Primária
- num_id

### Índices
- **crmtbpra_01**: num_id_tab_preco
- **crmtbpra_02**: num_id_produt

---

## Tabela: crm_tar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmtar_01**: num_id_pessoa
- **crmtar_02**: num_id_respons
- **crmtar_03**: num_id_campanha, num_id_acao
- **crmtar_04**: idi_status_tar
- **crmtar_ix14**: num_id_script_respos, num_id
- **crmtar_ix16**: dtm_modif, num_id
- **crmtar_usuar_outlook_stamp**: num_id_usuar, log_integrad_outlook, dat_timestamp
- **crmtau_ix15**: num_id_grp_usuar
- **idx_crmtar_dat_exec**: dat_exec
- **idx_crmtar_dat_ini**: dat_inic
- **idx_crmtar_pess_histor**: num_id_histor_acao, num_id_pessoa
- **idx_crmtar_pess_ocor**: num_id_ocor, num_id_pessoa
- **idx_crmtar_pess_oport**: num_id_oportun, num_id_pessoa
- **idx_crmtar_pess_tar_orig**: num_id_orig, num_id_pessoa
- **idx_crmtar_stat_datcad**: dat_cadastro, idi_status_tar

---

## Tabela: crm_tar_atrib
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmtrtrb_ix2**: num_id_tar, num_id_atrib

---

## Tabela: crm_tar_log_alter
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmtrlgl_ix2**: num_id_tar, num_id
- **crmtrlgl_ix3**: num_id_usuar, num_id_tar, num_id
- **crmtrlgl_ix4**: nom_operac, num_id_tar, num_id
- **crmtrlgl_ix5**: num_id_usuar, nom_operac, num_id

---

## Tabela: crm_tar_notif
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_telef
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmteled_ix4**: num_id_transport
- **crmtelef_01**: num_id_pessoa
- **crmtelef_02**: nom_telefone

---

## Tabela: crm_template
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_text_histor_acao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmtxths_01**: num_id_histor_acao

---

## Tabela: crm_text_pessoa
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmtxtps_01**: num_id_pessoa

---

## Tabela: crm_tip_anexo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_tip_campanha
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_tip_clien
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmtpcln_01**: nom_tip_clien

---

## Tabela: crm_tip_clien_tip_cta
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmtpcla_01**: num_id_tip_clien, idi_tip_cta

---

## Tabela: crm_tip_despes
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmtpdsp_01**: nom_tip_despes

---

## Tabela: crm_tip_docto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_tip_ocor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmtpcr_01**: nom_tip_ocor
- **crmtpcr_susp**: log_suspenso

---

## Tabela: crm_tip_ocor_assunto_ocor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmtpcrs_ix2**: num_id_tip_ocor, num_id_assunto_ocor

---

## Tabela: crm_tip_pessoa_zoom
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmtppss_01**: num_id_zoom

---

## Tabela: crm_tip_produt
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmtpprd_01**: nom_tip_produt

---

## Tabela: crm_tip_telef
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmtptlf_01**: nom_tip_telef
- **crmtptlf_02**: log_suspenso

---

## Tabela: crm_tip_vinc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmtpvnc_01**: nom_tip_vinc
- **crmtpvnc_02**: log_suspenso

---

## Tabela: crm_transf_clas
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmtrnsf_01**: num_id_clas_pessoa, num_id_prox_clas
- **crmtrnsf_02**: num_id_campanha, num_id_acao, num_id_restdo

---

## Tabela: crm_transpdor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmtrnsp_01**: nom_transpdor
- **crmtrnsp_02**: cod_transp_erp

---

## Tabela: crm_transpdor_contat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmtrnsa_01**: num_id_transport

---

## Tabela: crm_tratam
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmtrtm_01**: nom_tratam_pessoa

---

## Tabela: crm_unid_federac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmndfdr_01**: nom_unid_federac
- **crmndfdr_02**: num_id_pais
- **crmndfdr_03**: cod_uf_erp
- **crmndfdr_04**: nom_complet_uf

---

## Tabela: crm_unid_medid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmndmdd_01**: nom_sig_umd
- **crmndmdd_02**: cod_unid_medid_erp

---

## Tabela: crm_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmusuad_ix5**: num_id_grp_usuar
- **crmusuar_01**: num_id_usuar_mestre
- **crmusuar_susp**: log_suspenso
- **fk_usuar_mestre** (Unique): cod_usuario

---

## Tabela: crm_usuar_relat_web
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_vers
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices

---

## Tabela: crm_vinc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id

### Índices
- **crmvinc_01**: num_id_pessoa, num_id_contat
- **crmvinc_02**: num_id_tip_vinc
- **idx_crmvinc_contat**: num_id_contat

---

