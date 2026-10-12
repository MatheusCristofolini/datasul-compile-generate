# Esquema do Banco: hcm

## Tabela: abrangen_acidte_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_abrangen_acidte_trab

### Índices

---

## Tabela: acao_salva
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_acao_salva

### Índices

---

## Tabela: acidado_acidte_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq_acidado, cdn_empresa, num_acidte_ambntal

### Índices
- **acddcdtm_acdtmbnt**: cdn_empresa, num_acidte_ambntal
- **acddcdtm_fncnr**: cdn_empres_func, cdn_estab_func, cdn_funcionario
- **acddcdtm_prstdrsr**: cdn_empres_func, cdn_prestdor_serv

---

## Tabela: acidte_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, num_acidte_ambntal

### Índices
- **acdtmbnt_lclmbntl**: cod_local_ambntal
- **acdtmbnt_ntrcdtmb**: cod_natur_acidte_ambntal
- **acdtmbnt_tpcdtmbn**: cod_tip_acidte_ambntal

---

## Tabela: acidte_ambntal_notif
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empres_acidte, num_acidte_ambntal, cdn_empresa, cdn_notif_ambntal

### Índices
- **acdtmbna_ntfmbntl**: cdn_empresa, cdn_notif_ambntal

---

## Tabela: acidte_ato_insegur
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_area_segur, num_mandat_cipa, num_reuniao_cipa, num_acidtrab, cod_ato_insegur_acidte

### Índices
- **acdttnsg_atnsgr**: cod_ato_insegur_acidte

---

## Tabela: acidte_cond_insegur
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_area_segur, num_mandat_cipa, num_reuniao_cipa, num_acidtrab, cod_cond_insegur_acidte

### Índices
- **acdtcndn_cndnsgr**: cod_cond_insegur_acidte

---

## Tabela: acidte_fator_pessoa
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_area_segur, num_mandat_cipa, num_reuniao_cipa, num_acidtrab, cod_fator_pessoa_insegur

### Índices
- **acdtftrp_ftpss**: cod_fator_pessoa_insegur

---

## Tabela: acidte_norma_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_norma_ambntal, dat_emis_norma, num_acidte_ambntal

### Índices
- **acdtnrmm_acdtmbnt**: cdn_empresa, num_acidte_ambntal

---

## Tabela: acidte_trab
**Label**: Telefone Contato Ocorr�ncia
**Descrição**: Telefone Contato Acidente de trabalho

### Chave Primária
- cdn_empresa, cdn_estab, num_acidtrab

### Índices
- **acdttrb_abrngncd**: cod_abrangen_acidte_trab
- **acdttrb_agntcdtr**: cod_agent_acidtrab
- **acdttrb_agntrsc**: cod_agent_risco
- **acdttrb_clncdttr**: cod_clien_acidte_trab
- **acdttrb_cmpnssmt**: num_compon_sesmt_respons
- **acdttrb_fncnr**: cdn_empresa, cdn_estab, cdn_func_respons_inform
- **acdttrb_ipctmbnt**: cod_ipcto_ambntal
- **acdttrb_mndtcp**: cdn_empresa, cdn_estab_mandat_cipa, num_respons_mandat_cipa
- **acdttrb_mprsc**: cdn_empresa, cdn_estab, num_mandat_cipa, num_seq_mapa_risco
- **acdttrb_nrmsgr**: cdn_empresa, cod_norma_segur
- **acdttrb_objgrdrc**: cod_obj_gerador_acidte
- **acdttrb_orgcdttr**: cod_orig_acidte_trab
- **acdttrb_plnltc**: cdn_plano_lotac, cod_unid_lotac
- **acdttrb_prdtcdtt**: cod_produt_acidte_trab
- **acdttrb_rhccusto**: cdn_empresa, cod_rh_ccusto
- **acdttrb_rsccdttr**: num_ambien_risco, num_riscacid
- **acdttrb_sstqldcd**: cod_sist_qualid_acidte_trab
- **acdttrb_undltc**: cod_unid_lotac

---

## Tabela: acidte_trab_ato_insegur
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_acidtrab, cod_ato_insegur_acidte

### Índices
- **acdttrbt_atnsgr**: cod_ato_insegur_acidte

---

## Tabela: acidte_trab_cond_insegur
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_acidtrab, cod_cond_insegur_acidte

### Índices
- **acdttrbc_cndnsgr**: cod_cond_insegur_acidte

---

## Tabela: acidte_trab_plano_acao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_acidtrab, cdn_plano_organ, cdn_objorg

### Índices
- **acdttrbp_objorg**: cdn_empresa, cdn_plano_organ, cdn_objorg

---

## Tabela: acidte_trab_reuniao_cipa
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_area_segur, num_mandat_cipa, num_reuniao_cipa, num_acidtrab

### Índices
- **acdttrbr_acdttrb**: cdn_empresa, cdn_estab, num_acidtrab

---

## Tabela: acidtrab_fator_pessoa
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_acidtrab, cod_fator_pessoa_insegur

### Índices
- **acdtrbft_ftpss**: cod_fator_pessoa_insegur

---

## Tabela: acidtrab_risco_previs
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_acidtrab, num_ambien_risco, num_riscacid

### Índices
- **acdtrbrs_rsccdttr**: num_ambien_risco, num_riscacid

---

## Tabela: acomp_visitante_aces
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_planta_edificio, cdn_local_aces, dat_entr_visitante, num_hora_entr_visitante, num_ocor_visitante, num_acomp_visitante

### Índices
- **acmpvstn_visit**: cdn_visitante, cdn_planta_edificio, cdn_local_aces, dat_entr_visitante, num_hora_entr_visitante, num_ocor_visitante

---

## Tabela: acompto_atualiz_seq_calc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- dat_atualiz, hra_atualiz

### Índices

---

## Tabela: adc_ferias_13o
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_ano_mes_adc_ferias_13o, cdn_tip_adc_ferias_13o, cdn_event_fp

### Índices
- **adcfrs13_tpdcfrs1**: cdn_tip_adc_ferias_13o

---

## Tabela: advog_proces_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_advog_proces_trab

### Índices
- **advgprcs_oab**: cod_oab
- **advgprcs_pf**: num_pessoa_fisic

---

## Tabela: afast_pacien
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_ficha_medic, dat_afast_func_acidte, cdn_sit_afast, hra_afast_func

### Índices
- **afstpcn_consulta**: num_ficha_medic, num_consmedic
- **afstpcn_lcllscdt**: cod_local_lesao_acidtrab
- **afstpcn_lclxmmdc**: cod_local_exam_medic
- **afstpcn_medicext**: cdn_conslho_medic
- **afstpcn_rhestab**: cdn_empresa, cdn_estab
- **afstpcn_sitafast**: cdn_sit_afast

---

## Tabela: afast_pacien_acidtrab
**Label**: Ficha M�dica
**Descrição**: N�mero Ficha M�dica

### Chave Primária
- num_ficha_medic, dat_afast_func_acidte, cdn_sit_afast, hra_afast_func, num_acidtrab

### Índices
- **afstpcncat_cat**: cdn_empresa, cdn_estab, num_acidtrab, num_cat_acidtrab
- **afstpcncat_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario

---

## Tabela: agenda_req_pessoal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_req_pessoal, cdn_cargo_basic, cdn_niv_cargo, cdn_candempr

### Índices
- **agndrqps_cargo**: cdn_cargo_basic, cdn_niv_cargo
- **agndrqps_cnddtxt**: cdn_candempr

---

## Tabela: agenda_visitante
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_usuar_organ_agenda, dat_prev_inic_visita, num_horar_prev_inic_visita, num_seq_agenda_visitante

### Índices

---

## Tabela: agenda_visitante_det
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_usuar_organ_agenda, dat_prev_inic_visita, num_horar_prev_inic_visita, num_seq_agenda_visitante, cdn_visitante

### Índices

---

## Tabela: agent_acidtrab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_agent_acidtrab

### Índices

---

## Tabela: agent_efeito_agent
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_agent_risco, cod_efeito_agent_risco

### Índices
- **agntftgn_eftgntrs**: cod_efeito_agent_risco

---

## Tabela: agent_risco
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_agent_risco

### Índices
- **agntrsc_grupo**: cod_grp_riscacid

---

## Tabela: agent_risco_epi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_agent_risco, cdn_empresa, cod_epi

### Índices
- **agntrscp_eqptprtc**: cdn_empresa, cod_epi

---

## Tabela: agent_risco_eqpto_risco
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_agent_risco, cod_eqpto_avaliac_risco

### Índices

---

## Tabela: agent_risco_exam
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_agent_risco, cod_exam_medic

### Índices
- **agntrscx_undmddsg**: cod_unid_medid

---

## Tabela: agrup_tip_dia_sind
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_sindicato, cod_tip_dia_agrup

### Índices
- **agrptpds_tip_dia**: cdn_empresa, cdn_sindicato, cod_tip_dia
- **agrptpds_tpdhrrtr**: cod_tip_dia

---

## Tabela: alerta_alter_diverg
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, idi_tip_ocor_origin_mpe, idi_tip_ocor_mpe_dest

### Índices

---

## Tabela: alter_jorn_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_jorn_trab, dat_inic_alter_jorn_trab

### Índices
- **altrjrnt_intrvrfj**: cdn_jorn_trab, cdn_interv_refei

---

## Tabela: alter_sit_benefic_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_beneficio, cdn_motiv_sit_func, dat_inic_sit_func

### Índices

---

## Tabela: ambien_risco
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_ambien_risco

### Índices

---

## Tabela: amostra_exam_medic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_amostra_exam_medic

### Índices

---

## Tabela: amostra_risco
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_amostra_risco

### Índices
- **amstrrsc_mtvmstr**: cod_motiv_amostra

---

## Tabela: analis_nec_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_analis_nec_trein

### Índices
- **anlsnctr_undltc**: cod_unid_lotac

---

## Tabela: analis_prob_desemp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_analis_prob_desemp

### Índices
- **anlsprbd_anlsnctr**: cdn_analis_nec_trein
- **anlsprbd_estrtrpr**: num_ident_estrut_reporte_pos

---

## Tabela: analis_prob_desemp_pessoa
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_analis_prob_desemp, num_pessoa_fisic

### Índices

---

## Tabela: anot_geral_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_anot_geral_func

### Índices

---

## Tabela: antecip_calc_ppr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_param_calc_ppr, num_seq_param_calc_ppr

### Índices

---

## Tabela: aplic_regra_atualiz_salario
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_regra, num_seq

### Índices

---

## Tabela: apont_hora_aula
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_valid, dat_fim_valid, num_seq_movto_hrs_aula

### Índices
- **apnthrl_apthrmatr**: cdn_empresa, cdn_estab, cdn_func_centrdor, cdn_tip_contrat_func
- **apnthrl_atividade**: cdn_empresa, cdn_estab, cdn_funcionario, cdn_ativid_entid_educnal
- **apnthrl_disciplina**: cdn_empresa, cdn_estab, cdn_funcionario, cod_discip_entid_educnal
- **apnthrl_tpcntrt**: cdn_tip_contrat_func
- **apnthrl_trjtprf**: cdn_trajet_prof
- **apnthrl_turma**: cdn_empresa, cdn_estab, cdn_funcionario, cod_turma_entid_educnal

---

## Tabela: apont_hora_aula_histor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_valid, dat_fim_valid, num_seq_movto_hrs_aula

### Índices
- **apnthrlh_fnc**: cdn_empresa, cdn_estab, cdn_func_centrdor, cdn_tip_contrat_func, dat_inic_valid, dat_fim_valid, num_seq_movto_hrs_aula

---

## Tabela: apont_hora_aula_mestre
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_valid, dat_fim_valid

### Índices

---

## Tabela: apont_hora_aula_retroat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_valid, dat_fim_valid, num_seq_movto_hrs_aula

### Índices
- **apnthrlr_centr**: cdn_empresa, cdn_estab, cdn_func_centrdor, cdn_tip_contrat_func, dat_inic_valid, dat_fim_valid, num_seq_movto_hrs_aula

---

## Tabela: aprvdor_substto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario, cdn_empresa, cdn_estab, cdn_funcionario

### Índices
- **aprvdrsb_func**: cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_valid, dat_term_valid
- **aprvdrsb_ix2**: cod_usuario

---

## Tabela: area_conhecto_educnal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_area_conhecto_educnal

### Índices

---

## Tabela: area_conhecto_especialid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_area_conhecto_educnal_sub, cod_especialid_conhecto_educnal

### Índices

---

## Tabela: area_conhecto_relacto_grande
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_area_conhecto_educnal_grande, cod_area_conhecto_educnal

### Índices

---

## Tabela: area_conhecto_relacto_sub
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_area_conhecto_educnal, cod_area_conhecto_educnal_sub

### Índices

---

## Tabela: area_propried_agric
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_propried_agric, cdn_tip_area_agric

### Índices
- **arprprdg_tprgrc**: cdn_tip_area_agric

---

## Tabela: area_segur
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_area_segur

### Índices
- **arsgr_tomador**: log_tomador_serv, cdn_empres_tomador, cdn_clien_rh

---

## Tabela: area_segur_compon_sesmt
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_area_segur, num_compon_sesmt

### Índices

---

## Tabela: area_segur_localid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_area_segur, cod_pais, cdn_localidade

### Índices

---

## Tabela: arq_docto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_arq_docto

### Índices

---

## Tabela: arredond_hora_categ_ptoelet
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_clas_func, cdn_empresa, cdn_estab, cdn_categ_sal, idi_arredond_horar_mpe, num_horar_inic_mpe

### Índices

---

## Tabela: aso_agent_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_aso, cod_agent_risco

### Índices
- **asgntfnc_agntrsc**: cod_agent_risco

---

## Tabela: aso_exam_pacien
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_aso, num_ficha_medic, dat_programac_exam_medic, cod_exam_medic

### Índices
- **asxmpcn_exmpcn**: num_ficha_medic, dat_programac_exam_medic, cod_exam_medic

---

## Tabela: aso_risco_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_aso, num_ambien_risco, num_riscacid

### Índices
- **asrscmbn_agntrsc**: cod_agent_risco

---

## Tabela: aspecto_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_aspecto_ambntal

### Índices

---

## Tabela: assunto_norma_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_assunto_norma_ambntal

### Índices

---

## Tabela: assunto_norma_segur
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_assunto_norma_segur

### Índices

---

## Tabela: ativid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_ativid_func

### Índices

---

## Tabela: ativid_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_ativid_ambntal

### Índices

---

## Tabela: ativid_aso_funcao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_aso, cod_ativid_aso

### Índices

---

## Tabela: ativid_candidato
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_req_pessoal, cod_ativid_candidato

### Índices

---

## Tabela: ativid_cargo_basic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_ativid_func, cdn_cargo_basic

### Índices

---

## Tabela: ativid_curso_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_ativid_func, cdn_curso_trein

### Índices
- **atvdcrst_crstrn**: cdn_curso_trein

---

## Tabela: ativid_empres
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_ativid_estab_rais

### Índices

---

## Tabela: ativid_entid_educnal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_ativid_entid_educnal

### Índices

---

## Tabela: ativid_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cod_ativid_func, dat_inic_ativid_func

### Índices
- **atvdfnc_ativid**: cod_ativid_func

---

## Tabela: ativid_perf_profis
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_pessoa_fisic, cdn_plano_lotac, cod_unid_lotac, cdn_cargo_basic, cod_ativid_func, dat_inic_ativid_func

### Índices

---

## Tabela: ativid_prefer
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_ativid_prefer

### Índices

---

## Tabela: ativid_unid_lotac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_ativid_func, cod_unid_lotac

### Índices

---

## Tabela: ato_insegur
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_ato_insegur_acidte

### Índices

---

## Tabela: atrib_livre
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_base_dados, cod_dump_name, cod_field_name, cod_field_name_dest

### Índices

---

## Tabela: atstdo_aso
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_aso

### Índices
- **atstds_cnddtxt**: cdn_candempr
- **atstds_fchmdc**: num_ficha_medic
- **atstds_func**: cdn_empresa, cdn_estab, cdn_funcionario, dat_exam_medic_func
- **atstds_pcmso**: cdn_empresa, cdn_estab, num_pcmso, num_aso
- **atstds_rhpssfsc**: num_pessoa_fisic
- **atstds_txttstdm**: num_text_atstdo_medic

---

## Tabela: atstdo_medic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_ficha_medic, num_consmedic, num_atstdo_medic

### Índices
- **atstdmdc_cnsmdc**: num_consmedic, num_ficha_medic
- **atstdmdc_lytrltmd**: num_atstdo_medic
- **atstdmdc_txttstdm**: num_text_atstdo_medic

---

## Tabela: autoriz_hora_extra_compens
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_mpe, num_horar_inic_mpe

### Índices
- **atrzhrxt_st**: cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_mpe, dat_proces_mpe, idi_status_aprov
- **atrzhrxt_tm04302**: cdn_empresa, cdn_estab, cdn_funcionario, dat_proces_mpe, num_horar_inic_proces_mpe
- **atrzhrxt_tm04303**: cdn_tip_compcao_hrs

---

## Tabela: aux_area_segur
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_area_segur

### Índices

---

## Tabela: aux_calc_dissidio_retroat
**Label**: Perc Aplicado Diss�dio
**Descrição**: Valor Percentual Aplicado Diss�dio

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_ano_pagto_fp, num_mes_pagto_fp, num_seq

### Índices

---

## Tabela: aux_calc_irf
**Label**: Dependentes IRF Anterior
**Descrição**: Imagem da informa��o anterior ao �ltimo c�lculo realizado

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario

### Índices

---

## Tabela: aux_calc_palim
**Label**: Valor Sup Pens�o
**Descrição**: Valor de suplementa��o para c�lculo de pens�o

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_bnfciar_palim, num_ano_refer_calc_palim, num_mes_refer_calc_palim, idi_tip_calc_palim, num_seq_bnfciar_mes

### Índices

---

## Tabela: aux_calc_rescis
**Label**: Dependentes IRF Anterior
**Descrição**: Imagem da informa��o anterior ao �ltimo c�lculo realizado

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_tip_calc_fp

### Índices
- **axclcrsc_py16101**: cdn_empresa, cdn_estab, dat_pagto_salario, cdn_funcionario

---

## Tabela: aux_demonst_efp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq_demonst_efp, num_niv_demonst_efp, cdn_tip_demonst_efp, cod_tip_mdo, cdn_event_demonst, cdn_empresa, cdn_estab, cod_usuario

### Índices
- **axdmnstf_evt**: cdn_empresa, cdn_estab, cod_usuario, cod_tip_mdo, cdn_event_demonst
- **axdmnstf_mdo**: cdn_empresa, cdn_estab, cod_usuario, cod_tip_mdo, cdn_efp_orig, num_niv_demonst_efp
- **axdmnstf_py01502**: cdn_event_demonst, cod_tip_mdo
- **axdmnstf_py01503**: cdn_efp_orig, cod_tip_mdo, num_seq_demonst_efp, num_niv_demonst_efp
- **axdmnstf_tipmdo**: cod_tip_mdo

---

## Tabela: aux_emis_demonst_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_unid_negoc, cdn_estab_trab, cod_rh_ccusto, cod_rh_cta_ctbl, cdn_event_fp, cod_ccusto_contra_partida, cod_cta_contra_partida, idi_tip_lancto_ctbl_fp

### Índices
- **axmsdmns_py01402**: cdn_empresa, cod_rh_cta_ctbl, cod_rh_ccusto, cdn_event_fp

---

## Tabela: aux_emis_demonst_ctbl_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_rh_ccusto, cod_rh_cta_ctbl, cdn_tip_cust_trein, cod_ccusto_contra_partida, cod_cta_contra_partida, idi_tip_lancto_ctbl_fp

### Índices

---

## Tabela: aux_emis_demonst_ctbl_un
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_unid_negoc, cod_rh_ccusto, cod_rh_cta_ctbl, cdn_event_fp, cod_ccusto_contra_partida, cod_cta_contra_partida, idi_tip_lancto_ctbl_fp

### Índices
- **axmsdmnb_ctaccusto**: cdn_empresa, cod_rh_cta_ctbl, cod_rh_ccusto, cdn_event_fp

---

## Tabela: aux_emis_guia_iapas
**Label**: Valor Sal�rio Fam�lia
**Descrição**: Valor sal�rio fam�lia

### Chave Primária
- cdn_empresa, cdn_clien_rh, cdn_fpas, cdn_estab, cdn_plano_lotac, cod_unid_lotac, idi_tip_func_emis_grps, num_ano_refer_primei_calc_fp, num_mes_refer_primei_calc_fp

### Índices

---

## Tabela: aux_emis_guia_inss
**Label**: Recolhe Sobre Faturamento
**Descrição**: Recolhe sobre faturamento

### Chave Primária
- cdn_empresa, cdn_estab, num_ano_refer_guia_inss, idi_mes_base_acordo_coletiv, cdn_encargo

### Índices

---

## Tabela: aux_exec_rat_taref
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cod_rh_ccusto

### Índices
- **axxcrttr_epcc**: cdn_empresa, cod_rh_ccusto

---

## Tabela: aux_gerac_rais_meio_magnet
**Label**: Sal�rio Diss�dio
**Descrição**: Valor Sal�rio Diss�dio

### Chave Primária
- cod_id_previd_social, cod_cgc_declar, cod_pis, dat_admis_func, num_seq

### Índices
- **axgrcrsm_funcionario**: cdn_empresa, cdn_estab, cdn_funcionario

---

## Tabela: aux_gerac_rat_taref
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_rh_ccusto, cod_rh_cta_ctbl, cdn_event_fp, cod_ccusto_contra_partida, cod_cta_contra_partida, idi_tip_lancto_ctbl_fp, cdn_estab, cdn_funcionario, num_ano_refer_fp, num_mes_refer_fp, num_seq

### Índices
- **axgrcrtt_cont**: cdn_empresa, num_mes_refer_fp, num_ano_refer_fp
- **axgrcrtt_folha**: cdn_empresa, cod_rh_ccusto, cod_rh_cta_ctbl, num_ano_refer_fp, num_mes_refer_fp

---

## Tabela: aux_integr_fp_ap
**Label**: Valor Previsto
**Descrição**: Valor previsto

### Chave Primária
- cdn_empresa, cdn_estab, num_ano_refer_calc_efetd, num_mes_refer_calc_efetd, num_seq_grp_pagto, num_seq_tip_pagto

### Índices
- **axntgrfp_py01302**: cdn_empresa, num_ano_refer_calc_efetd, num_mes_refer_calc_efetd

---

## Tabela: aux_param_slr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa

### Índices

---

## Tabela: aux_rat_encargo_ccusto
**Label**: Valor Rateio
**Descrição**: Valor rateio

### Chave Primária
- cdn_empresa, num_ano_refer_rat_encargo, num_mes_refer_rat_encargo, cdn_estab, cod_rh_ccusto, cdn_encargo

### Índices

---

## Tabela: avaliac_aspecto_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_local_ambntal, cdn_empresa, cdn_estab, cod_ativid_func, dat_avaliac_ambntal, hra_avaliac_ambntal, cod_aspecto_ambntal

### Índices
- **avlcspct_aspctmbn**: cod_aspecto_ambntal
- **avlcspct_ativid**: cdn_empresa, cdn_estab, cod_ativid_func
- **avlcspct_cndcspct**: cod_condic_aspecto

---

## Tabela: avaliac_bolsa_estudo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_avaliac_trein, cdn_bolsa_estudo

### Índices
- **avlcblss_cnvnblss**: cdn_bolsa_estudo

---

## Tabela: avaliac_bolsista
**Label**: Percentual Nota
**Descrição**: Valor Percentual de Nota

### Chave Primária
- cdn_bolsa_estudo, cdn_curso_trein, cdn_bolsista, cdn_avaliac_trein, dat_refer

### Índices
- **avlcblsa_avlcblss**: cdn_avaliac_trein, cdn_bolsa_estudo

---

## Tabela: avaliac_curso_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_curso_trein, cdn_avaliac_trein

### Índices
- **avlccrst_avlctrn**: cdn_avaliac_trein

---

## Tabela: avaliac_epi
**Label**: Valor
**Descrição**: Valor Unit�rio Equipamento Prote��o Individual

### Chave Primária
- cdn_empresa, cod_epi, cdn_fornecedor, dat_inic_avaliac_epi

### Índices
- **avlcp_fncnr**: cdn_empres_func_respons, cdn_estab_func_respons, cdn_func_respons
- **avlcp_undltcpl**: cdn_plano_lotac, cod_unid_lotac
- **avlcp_undmddsg**: cod_unid_med_epi

---

## Tabela: avaliac_epi_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_epi, cdn_fornecedor, dat_inic_avaliac_epi, cdn_estab, cdn_funcionario

### Índices
- **avlcpfnc_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario

---

## Tabela: avaliac_integr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_local_ambntal, cdn_empresa, cdn_estab, cod_unid_lotac, idi_tip_levto, dat_avaliac_analis, hra_avaliac_analis, num_seq

### Índices

---

## Tabela: avaliac_integr_acao_salva
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_local_ambntal, cdn_empresa, cdn_estab, cod_unid_lotac, idi_tip_levto, dat_avaliac_analis, hra_avaliac_analis, num_seq, cod_acao_salva

### Índices

---

## Tabela: avaliac_integr_norma
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_local_ambntal, cdn_empresa, cdn_estab, cod_unid_lotac, dat_avaliac_analis, hra_avaliac_analis, num_seq, cdn_empres_norma, cod_norma_ambntal, dat_emis_norma, cod_requis_norma_ambntal, dat_analis_requis, idi_tip_levto

### Índices

---

## Tabela: avaliac_local_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_local_ambntal, cdn_empresa, cdn_estab, cod_ativid_func, dat_avaliac_ambntal, hra_avaliac_ambntal

### Índices
- **avlclclm_ativid**: cdn_empresa, cdn_estab, cod_ativid_func

---

## Tabela: avaliac_meio_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_local_ambntal, cdn_empresa, cdn_estab, cod_ativid_func, dat_avaliac_ambntal, hra_avaliac_ambntal, cod_aspecto_ambntal, cod_meio_ambntal, cod_ipcto_ambntal

### Índices
- **avlcmmbn_aspctmbn**: cod_aspecto_ambntal
- **avlcmmbn_ativid**: cdn_empresa, cdn_estab, cod_ativid_func
- **avlcmmbn_ipctmbnt**: cod_ipcto_ambntal
- **avlcmmbn_mmbntl**: cod_meio_ambntal

---

## Tabela: avaliac_meio_norma
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_local_ambntal, cdn_empresa, cod_norma_ambntal, dat_emis_norma, cdn_estab, cod_ativid_func, dat_avaliac_ambntal, hra_avaliac_ambntal, cod_aspecto_ambntal, cod_meio_ambntal, cod_ipcto_ambntal

### Índices
- **avlcmnrm_avlcmmbn**: cod_local_ambntal, cdn_empresa, cdn_estab, cod_ativid_func, dat_avaliac_ambntal, hra_avaliac_ambntal, cod_aspecto_ambntal, cod_meio_ambntal, cod_ipcto_ambntal
- **avlcmnrm_nrmmbntl**: cdn_empresa, cod_norma_ambntal, dat_emis_norma

---

## Tabela: avaliac_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_avaliac_trein

### Índices
- **avlctrn_nvhrfncn**: cdn_niv_hier_funcnal
- **avlctrn_tpvlctrn**: cdn_tip_avaliac_trein

---

## Tabela: avaliac_treindo_turma
**Label**: Percentual Nota
**Descrição**: Valor Percentual de Nota

### Chave Primária
- cdn_curso_trein, cdn_turma_trein, cdn_treindo_normal, cdn_avaliac_trein, dat_refer

### Índices
- **avlctrna_avlccrst**: cdn_curso_trein, cdn_avaliac_trein

---

## Tabela: avpes_analis_autom
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_avpes_padr, num_avpes_analis_autom

### Índices

---

## Tabela: avpes_analis_autom_item
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_avpes_padr, num_avpes_analis_autom, cdn_item_avpes

### Índices

---

## Tabela: avpes_anexo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_avpes_padr, cdn_campo_impres_avpes

### Índices
- **avpsnx_infrmmpr**: cdn_campo_impres_avpes

---

## Tabela: avpes_colig
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_avpes_padr, cdn_avpes_colig

### Índices
- **avpsclg_avpsrgms**: cdn_avpes_colig

---

## Tabela: avpes_comparac_item
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_comparac_item_avpes, cdn_avpes_padr, cdn_item_avpes

### Índices
- **avpscmpr_avpstm**: cdn_avpes_padr, cdn_item_avpes

---

## Tabela: avpes_control_emis
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_avpes_padr, cdn_estab, dat_period_inicial_emis_avpes, num_control_emis_avpes

### Índices
- **avpscntre**: num_control_emis_avpes, cdn_empresa, cdn_avpes_padr, cdn_estab, dat_period_inicial_emis_avpes
- **avpscntr_rhestab**: cdn_empresa, cdn_estab

---

## Tabela: avpes_curso_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_avpes_padr, cdn_curso_trein

### Índices
- **avpscrst_crstrn**: cdn_curso_trein

---

## Tabela: avpes_emitid
**Label**: Pontua��o Avalia��o
**Descrição**: Pontua��o Geral da Avalia��o

### Chave Primária
- num_avpes_emitid

### Índices
- **avpsmtd_02**: cdn_avpes_padr, cdn_empresa, cdn_estab, cdn_funcionario, dat_refer_respos_avpes, num_avpes_emitid
- **avpsmtd_anlsnctr**: cdn_analis_nec_trein
- **avpsmtd_anlsprbd**: num_analis_prob_desemp
- **avpsmtd_avaldor**: cdn_avpes_padr, cdn_empres_func_respos_avpes, cdn_estab_func_respos_avpes, cdn_func_respos_avpes, num_pessoa_fisic_avaldor, dat_refer_respos_avpes, num_avpes_emitid
- **avpsmtd_avaldor_pess_ext**: cdn_empres_func_respos_avpes, cdn_estab_func_respos_avpes, cdn_func_respos_avpes, num_pessoa_fisic_avaldor, num_avpes_emitid
- **avpsmtd_avaliado_pf**: num_pessoa_fisic, num_avpes_emitid
- **avpsmtd_avpscntr**: num_control_emis_avpes
- **avpsmtd_avpstprs**: cdn_tip_restdo_avpes
- **avpsmtd_avpstpvl**: cdn_tip_avaldor
- **avpsmtd_estrtrpf**: num_ident_estrut_reporte_pos, dat_refer_respos_avpes
- **avpsmtd_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario
- **avpsmtd_objorg**: cdn_empresa, cdn_plano_organ, cdn_objorg
- **avpsmtd_pf**: num_pessoa_fisic_avaldor, num_avpes_emitid
- **avpsmtd_prdtntrr**: cdn_empresa, cdn_produt_inter_uhr

---

## Tabela: avpes_emitid_transf
**Label**: Pontua��o Destino
**Descrição**: Pontua��o Avalia��o de Pessoal Destino

### Chave Primária
- num_avpes_emitid, num_seq

### Índices

---

## Tabela: avpes_estrut_avaldor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_plano_lotac, cdn_avpes_estrut_avaldor

### Índices
- **avpsstrt_undltcpl**: cdn_plano_lotac

---

## Tabela: avpes_grp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_avpes_padr, cdn_grp_avpes

### Índices
- **avpesgrp_avpsmsta**: cdn_grp_avpes

---

## Tabela: avpes_grp_item
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_grp_avpes, cdn_item_avpes

### Índices
- **avpsgrpt_avpstm**: cdn_item_avpes

---

## Tabela: avpes_grp_parecer_restdo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_grp_avpes, num_seq_avpes_grp_restdo

### Índices
- **avpsgrpp_avpstprs**: cdn_tip_restdo_avpes

---

## Tabela: avpes_hier_avaldor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_plano_lotac, cdn_avpes_estrut_avaldor, cdn_estab, cod_unid_lotac, cdn_turno_trab, cdn_niv_hier_funcnal, cdn_estab_func_respos_avpes, cdn_func_respos_avpes

### Índices
- **avpshrvl_avpsstrt**: cdn_empresa, cdn_avpes_estrut_avaldor
- **avpshrvl_fncnr**: cdn_empresa, cdn_estab_func_respos_avpes, cdn_func_respos_avpes
- **avpshrvl_nvhrfncn**: cdn_niv_hier_funcnal
- **avpshrvl_rhestab**: cdn_empresa, cdn_estab
- **avpshrvl_trntrb**: cdn_turno_trab

---

## Tabela: avpes_indcao_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_avpes_padr, num_seq_avpes_restdo, num_seq_indcao_trein

### Índices
- **avpsndct_crstrn**: cdn_curso_trein
- **avpsndct_hbcmpprb**: cdn_aperfmto

---

## Tabela: avpes_indcao_trein_grp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_grp_avpes, num_seq_avpes_grp_restdo, num_seq_indcao_trein

### Índices
- **avpsndca_crstrn**: cdn_curso_trein
- **avpsndca_hbcmpprb**: cdn_aperfmto

---

## Tabela: avpes_item
**Label**: Resultado Correto
**Descrição**: Valor Resultado Correto

### Chave Primária
- cdn_item_avpes

### Índices

---

## Tabela: avpes_layout_relat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_avpes_layout_relat

### Índices

---

## Tabela: avpes_mestre_comparac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_comparac_item_avpes

### Índices

---

## Tabela: avpes_mestre_grp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_grp_avpes

### Índices

---

## Tabela: avpes_meta_indual
**Label**: Pontua��o
**Descrição**: Valor Pontua��o

### Chave Primária
- num_pessoa_fisic, cdn_item_avpes, num_seq_item_avpes

### Índices
- **avpsmtnd_anlsnctr**: cdn_analis_nec_trein
- **avpsmtnd_anlsprbd**: num_analis_prob_desemp
- **avpsmtnd_avpsmtd**: num_avpes_orig
- **avpsmtnd_avpstm**: cdn_item_avpes
- **avpsmtnd_avrest**: num_avpes_restdo

---

## Tabela: avpes_parecer_restdo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_avpes_padr, num_seq_avpes_restdo

### Índices
- **avpsprca_avpstprs**: cdn_tip_restdo_avpes

---

## Tabela: avpes_period
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_avpes_padr, num_seq_period_avpes

### Índices

---

## Tabela: avpes_pontuac_grp
**Label**: Pontua��o Grupo
**Descrição**: Pontua��o do Grupo para Composi��o da Pontua��o da Avalia��o

### Chave Primária
- num_avpes_emitid, cdn_grp_avpes

### Índices
- **avpspntc_avpsmsta**: cdn_grp_avpes
- **avpspntc_avpstprs**: cdn_tip_restdo_avpes

---

## Tabela: avpes_pontuac_item
**Label**: Pontua��o
**Descrição**: Pontua��o Relacionada ao Item da Avalia��o

### Chave Primária
- cdn_item_avpes, val_domin_inicial_avpes

### Índices

---

## Tabela: avpes_reg_mestre
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_avpes_padr

### Índices
- **avpsrgms_avpslytr**: cdn_avpes_layout_relat
- **avpsrgms_avpstpva**: cdn_avpes_tip_avaliac

---

## Tabela: avpes_relacdo_estrut_avaldor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_plano_lotac, cdn_avpes_estrut_avaldor, cdn_avpes_padr

### Índices
- **avpsrlcd_avpsrgms**: cdn_avpes_padr

---

## Tabela: avpes_sel_cargo_basic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_avpes_padr, cdn_cargo_basic

### Índices
- **avpsslcr_cargo**: cdn_cargo_basic, cdn_niv_cargo

---

## Tabela: avpes_sel_clas_cargo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_avpes_padr, cdn_clas_cargo

### Índices
- **avpsslcl_clscrg**: cdn_clas_cargo

---

## Tabela: avpes_sel_empres
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_avpes_padr, cdn_empresa

### Índices

---

## Tabela: avpes_sel_estab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_avpes_padr, cdn_empresa, cdn_estab

### Índices
- **avpsslst_rhestab**: cdn_empresa, cdn_estab

---

## Tabela: avpes_sel_niv_hier_funcnal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_avpes_padr, cdn_niv_hier_funcnal

### Índices
- **avpsslnv_nvhrfncn**: cdn_niv_hier_funcnal

---

## Tabela: avpes_sel_objorg
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_avpes_padr, cdn_plano_organ, cdn_objorg

### Índices
- **avpsslbj_objorg**: cdn_empresa, cdn_plano_organ, cdn_objorg

---

## Tabela: avpes_sel_time_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_avpes_padr, cdn_empresa, cdn_time_trab

### Índices
- **avpssltm_tmtrbrh**: cdn_time_trab

---

## Tabela: avpes_sel_unid_lotac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_avpes_padr, cdn_empresa, cdn_estab, cdn_plano_lotac, cod_unid_lotac

### Índices
- **avpsslnb_unddprtp**: cdn_plano_lotac, cod_unid_lotac

---

## Tabela: avpes_selec_avaldor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_empres_func_respos_avpes, cdn_estab_func_respos_avpes, cdn_func_respos_avpes

### Índices

---

## Tabela: avpes_selec_avaliac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_avpes_padr

### Índices

---

## Tabela: avpes_sub_item
**Label**: Pontua��o
**Descrição**: Pontua��o Relacionada ao Item da Avalia��o

### Chave Primária
- cdn_item_avpes, cdn_sub_item_avpes

### Índices

---

## Tabela: avpes_tip_avaldor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_avaldor

### Índices

---

## Tabela: avpes_tip_avaliac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_avpes_tip_avaliac

### Índices

---

## Tabela: avpes_tip_restdo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_restdo_avpes

### Índices

---

## Tabela: base_calc
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_base_calc

### Índices

---

## Tabela: base_calc_transp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_transpdor_rural, cdn_serv_agric

### Índices
- **bsclctrn_srvgrc**: cdn_serv_agric

---

## Tabela: base_dados_conex
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_base_dados_conex

### Índices

---

## Tabela: base_regra_emprest
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_banco, cdn_agenc_bcia, cdn_sindicato, cdn_estab, idi_tip_base_calc_emprest, cdn_event_fp

### Índices

---

## Tabela: bco_dado_magnus
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq_dir_bco_dados

### Índices

---

## Tabela: bco_hrs_compens_func
**Label**: Percentual Par Banco Horas
**Descrição**: Valor Percentual Par Banco Horas

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_tip_compcao_hrs, dat_atualiz_bco_hora, num_horar_inic_mpe

### Índices
- **bchrscmp_orig_par**: cdn_empresa, cdn_estab, cdn_funcionario, cdn_tip_compcao_hrs, dat_atualiz_bco_hora, num_orig_par_bco_hrs
- **bchrscmp_tm04502**: cdn_empresa, cdn_estab, cdn_funcionario, cod_mes_ano_refer_fp

---

## Tabela: bem_pat_proces_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_bem_pat

### Índices
- **bmptprcs_num**: num_bem_pat

---

## Tabela: benefic_calc
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_beneficio

### Índices
- **bnfcclc_grp**: cdn_grp_benefic, cod_beneficio

---

## Tabela: benefic_calc_depend
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_beneficio, cdn_regra_benefic, dat_inic_valid, cdn_grau_depend_func

### Índices

---

## Tabela: benefic_calc_func
**Label**: Padrao Benef�cio
**Descrição**: Valor Padr�o Benef�cio

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_depend_func, cod_beneficio, cdn_regra_benefic, cod_lin_vale_transp, dat_inic_valid

### Índices

---

## Tabela: benefic_calc_lin_transp
**Label**: Valor Tarifa
**Descrição**: Valor da tarifa

### Chave Primária
- cod_beneficio, cdn_regra_benefic, cod_lin_vale_transp, dat_inic_valid

### Índices

---

## Tabela: benefic_calc_movto
**Label**: Valor Recalculo Provento
**Descrição**: Valor gerado pelo recalculo como provento

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_depend_func, cod_beneficio, cdn_regra_benefic, cod_lin_vale_transp, num_ano_calc_efetd, num_mes_calc_efetd, num_seq_movto

### Índices
- **bnfcclcm_aamm**: cdn_empresa, cdn_estab, cdn_funcionario, num_ano_calc_efetd, num_mes_calc_efetd, cod_beneficio, cdn_regra_benefic

---

## Tabela: benefic_calc_regra
**Label**: Padrao Benef�cio
**Descrição**: Valor Padr�o Benef�cio

### Chave Primária
- cod_beneficio, cdn_regra_benefic, dat_inic_valid

### Índices

---

## Tabela: benefic_calc_sit
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_beneficio, cdn_regra_benefic, dat_inic_valid, cdn_sit_afast_func

### Índices

---

## Tabela: benefic_calc_tip_dia
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_beneficio, cdn_regra_benefic, dat_inic_valid, cod_tip_dia

### Índices

---

## Tabela: benefic_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_depend_func, cdn_beneficio, cdn_regra_benefic

### Índices
- **bnfcfnc_funbe**: cdn_empresa, cdn_estab, cdn_funcionario, cdn_beneficio, cdn_regra_benefic
- **bnfcfnc_py02303**: cdn_empresa, cdn_estab, cdn_beneficio, cdn_regra_benefic
- **bnfcfnc_rgrbnfc**: cdn_beneficio, cdn_regra_benefic

---

## Tabela: beneficio
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_beneficio

### Índices
- **bnfc_py02202**: cdn_grp_benefic
- **bnfc_tip_benefic**: idi_tip_benefic

---

## Tabela: bi_grp_inform
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_inform

### Índices

---

## Tabela: bi_grp_inform_funcao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_inform, cdn_inform_funcao, cod_grp_atrib_dados_bi

### Índices

---

## Tabela: bi_inform_funcao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_inform_funcao

### Índices

---

## Tabela: bloco_habcomp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_bloco_habcomp

### Índices

---

## Tabela: bnfciar_palim
**Label**: Perc Benef�cio PLR
**Descrição**: Valor Percentual Pens�o Aliment�cia PLR

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_bnfciar_palim

### Índices
- **bnfcrplm_py02402**: cdn_banco, cdn_agenc_bcia
- **bnfcrplm_pyndfdrc**: cod_pais, cod_unid_federac_rh
- **bnfcrplm_rhpssfsc**: num_pessoa_fisic

---

## Tabela: bnfciar_palim_det
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_bnfciar_palim

### Índices

---

## Tabela: bnfciar_seguro
**Label**: Perc Benefici�rio
**Descrição**: Percentual do Seguro para o Benefici�rio

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_depend_func

### Índices

---

## Tabela: bolsa_estudo_lim_pagto
**Label**: Percentual Bolsa
**Descrição**: Percentual da Parcela da Bolsa a ser reembolsado

### Chave Primária
- cdn_empresa, cdn_estab, cdn_niv_hier_funcnal, cdn_cargo_basic, cod_unid_lotac

### Índices
- **blsstdlm_cargo**: cdn_cargo_basic
- **blsstdlm_undltc**: cod_unid_lotac

---

## Tabela: bolsista
**Label**: Percentual Bolsa
**Descrição**: Percentual da Parcela da Bolsa a ser reembolsado

### Chave Primária
- cdn_bolsa_estudo, cdn_curso_trein, cdn_bolsista

### Índices
- **bolsista_crstrn**: cdn_curso_trein
- **bolsista_fncnr**: cdn_empresa, cdn_estab, cdn_treindo
- **bolsista_instttrn**: cdn_instit_trein
- **bolsista_mtvdsbtc**: cdn_motiv_desabtcao_treindo
- **bolsista_pssfsca**: num_pessoa_fisic, cdn_bolsa_estudo, cdn_curso_trein
- **bolsista_pssxttrn**: cdn_treindo

---

## Tabela: brigdsta
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_brigincen, cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_brigincen

### Índices
- **brigdsta_fncbrgds**: cod_funcao_brigincen
- **brigdsta_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario

---

## Tabela: brigincen
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_brigincen

### Índices

---

## Tabela: calc_turno
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_turno_trab, cod_seq_turno

### Índices
- **clctrn_des**: des_turno_trab

---

## Tabela: calc_turno_escal
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_turno_trab, cod_seq_turno, num_inic_escal

### Índices

---

## Tabela: calc_turno_func
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cod_turno_trab, cod_seq_turno, dat_inic_valid

### Índices

---

## Tabela: calend_event_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_event_orcto, cdn_empresa, cdn_estab

### Índices
- **clndvntr_dsclndvn**: cdn_event_orcto, cdn_estab, cdn_empresa
- **clndvntr_frtrntrb**: cod_calend
- **clndvntr_rhestab**: cdn_empresa, cdn_estab

---

## Tabela: calend_turma_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_turno_trab, cdn_turma_trab, num_ano_refer_calend_turma, num_mes_refer_calend_turma

### Índices

---

## Tabela: campo_dispon_calc
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- nom_tab_dic_dados, nom_campo_dic_dados, num_pos_inic

### Índices

---

## Tabela: campo_impres_curric_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_curric_func, cdn_campo_impres_avpes

### Índices
- **cmpmprsc_infrmmpr**: cdn_campo_impres_avpes

---

## Tabela: candidato_cipa
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_area_segur, num_mandat_cipa, cdn_funcionario

### Índices
- **cnddtcp_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario

---

## Tabela: candidato_elimda
**Label**: Sal�rio Candidato
**Descrição**: Valor Sal�rio Candidato

### Chave Primária
- cdn_candempr, dat_gerac_histor

### Índices
- **cnddtlmd_cpf_nascimento**: cod_id_feder, dat_nascimento
- **cnddtlmd_nome_nascimento**: nom_candempr, dat_nascimento

---

## Tabela: candidato_empreg
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_candempr

### Índices

---

## Tabela: candidato_etap
**Label**: Nota Etapa
**Descrição**: Valor Nota Etapa Teste Candidato Emprego

### Chave Primária
- cdn_candempr, cdn_etap_sel_candempr, cdn_cargo_basic, cdn_niv_cargo, dat_etap_sel_candempr

### Índices
- **cnddttp_cargo**: cdn_cargo_basic, cdn_niv_cargo
- **cnddttp_etpprcss**: cdn_etap_sel_candempr

---

## Tabela: candidato_ext
**Label**: Sal�rio Candidato
**Descrição**: Valor Sal�rio Candidato

### Chave Primária
- cdn_candempr

### Índices
- **cnddtxt_cpf_nascimento**: cod_id_feder, dat_nascimento
- **cnddtxt_emprscnd**: cod_candempr_agenc, cdn_agenc_recrut_pessoal, cdn_candempr
- **cnddtxt_nome_nascimento**: nom_candempr, dat_nascimento
- **cnddtxt_pessoa**: num_pessoa_fisic
- **cnddtxt_relig**: cdn_religiao

---

## Tabela: candidato_ext_area_interes
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_candempr, num_seq

### Índices

---

## Tabela: candidato_ext_conhecto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_candempr, cdn_empresa, cdn_grp_conhecto_experien, cdn_conhecto_experien

### Índices
- **cnddtxta_cnhctxpr**: cdn_empresa, cdn_grp_conhecto_experien, cdn_conhecto_experien
- **cnddtxta_prfcnc**: cdn_proficiencia

---

## Tabela: candidato_ext_curso
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_candempr, cdn_curso_trein, cdn_seq_curso_candempr

### Índices

---

## Tabela: candidato_ext_unid_federac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_candempr, cod_pais, cod_unid_federac_rh, cdn_localidade

### Índices

---

## Tabela: candidato_inter
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_candempr, cdn_req_pessoal

### Índices
- **cnddtntr_fncnr**: cdn_empres_func_candempr, cdn_estab_func_candempr, cdn_funcionario

---

## Tabela: candidato_pre_selec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_req_pessoal, cdn_candempr

### Índices

---

## Tabela: candidato_turno
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_candempr, cdn_turno_trab

### Índices
- **cnddttrn_trntrb**: cdn_turno_trab

---

## Tabela: caract_depto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_plano_lotac, cod_unid_lotac, num_niv_unid_lotac

### Índices
- **crctdpt_tpclmtzc**: cod_tip_climtzcao_depto
- **crctdpt_tpvntlcd**: cod_tip_ventlcao_depto
- **crctdpt_undltc**: cod_unid_lotac
- **crctdpt_undltcpl**: cdn_plano_lotac, cod_unid_lotac

---

## Tabela: carg_horar_mensal_turno_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_turno_trab, cdn_empresa, cdn_estab, cdn_categ_sal, num_ano_carg_turno_trab, num_mes_refer_carg_turno_trab, num_parc_relativo_carg_turno, cdn_event_fp

### Índices
- **crghrrmn_py21501**: cdn_empresa, cdn_estab, cdn_categ_sal, cdn_turno_trab, num_mes_refer_carg_turno_trab, num_ano_carg_turno_trab
- **crghrrmn_py21502**: cdn_event_fp

---

## Tabela: carg_horar_tip_dia_turno
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_turno_trab, cdn_empresa, cdn_estab, cdn_categ_sal, cod_tip_dia

### Índices

---

## Tabela: cargo
**Label**: Idade Min
**Descrição**: Limite M�nima Idade Cargo (anos)

### Chave Primária
- cdn_cargo_basic, cdn_niv_cargo

### Índices
- **cargo_cargo_niv**: cdn_niv_cargo
- **cargo_grau_instruc**: cdn_grau_instruc
- **cargo_niv_hier_cargo**: cdn_niv_hier_funcnal

---

## Tabela: cargo_avaliac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_cargo_basic, cdn_niv_cargo, cdn_fator_avaliac_cargo, dat_avaliac_cargo

### Índices
- **crgvlc_fator**: cdn_fator_avaliac_cargo

---

## Tabela: cargo_avaliac_descr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_cargo_basic, cdn_niv_cargo, dat_avaliac_cargo

### Índices

---

## Tabela: cargo_basic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_cargo_basic

### Índices
- **crgbsc_clscrg**: cdn_clas_cargo
- **crgbsc_clssfcpc**: cod_classif_ocupac
- **crgbsc_perf_cargo**: cdn_perf_cargo_basic
- **crgbsc_tip_cargo**: cdn_tip_cargo

---

## Tabela: cargo_basic_descr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_cargo_basic, cdn_tip_descr_cargo

### Índices
- **crgbscds_tpdscrcr**: cdn_tip_descr_cargo

---

## Tabela: cargo_basic_familia
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_familia_jsl, cdn_cargo_basic

### Índices
- **crgbscfm_crgbsc**: cdn_cargo_basic

---

## Tabela: cargo_bloco_habcomp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_cargo_basic, cdn_niv_cargo, cdn_bloco_qualific_habcomp

### Índices
- **crgblchb_cargo**: cdn_niv_cargo
- **crgblchb_hbcmpblc**: cdn_bloco_qualific_habcomp

---

## Tabela: cargo_conhecto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_cargo_basic, cdn_niv_cargo, cdn_empresa, cdn_grp_conhecto_experien, cdn_conhecto_experien

### Índices
- **crgcnhct_cnhctxpr**: cdn_empresa, cdn_grp_conhecto_experien, cdn_conhecto_experien
- **crgcnhct_nvrqscrg**: cdn_niv_requis_cargo

---

## Tabela: cargo_descr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_cargo_basic, cdn_niv_cargo, cdn_tip_descr_cargo, cdn_empresa, cdn_estab, cod_unid_lotac

### Índices
- **crgdscr_tip_descr**: cdn_tip_descr_cargo

---

## Tabela: cargo_func_suceder
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_cargo_basic_suceder, cdn_estab_func_suceder, cdn_func_suceder

### Índices
- **crgfncsc_crgbsc**: cdn_cargo_basic_suceder
- **crgfncsc_fncnr**: cdn_empresa, cdn_estab_func_suceder, cdn_func_suceder

---

## Tabela: cargo_habcomp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_cargo_basic, cdn_niv_cargo, cdn_plano_lotac, cod_unid_lotac, cdn_habcomp

### Índices
- **crghbcmp_habcomp**: cdn_habcomp
- **crghbcmp_nvrqscrg**: cdn_niv_requis_cargo

---

## Tabela: cargo_habcomp_avaliac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_cargo_basic, cdn_niv_cargo, cdn_habcomp

### Índices
- **crghbcma_habcomp**: cdn_habcomp
- **crghbcma_nvrqscrg**: cdn_niv_requis_cargo

---

## Tabela: cargo_habcomp_pontuac
**Label**: Valor/Percentual
**Descrição**: Valor Pontua��o Total

### Chave Primária
- cdn_cargo_basic, cdn_niv_cargo, cdn_grp_avaliac_pontuac, cdn_habcomp_lin, cdn_profncia_lin, cdn_habcomp_col, cdn_profncia_col

### Índices

---

## Tabela: cargo_indcao_recrut
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_candempr, cdn_cargo_basic, cdn_niv_cargo

### Índices
- **crgndcrc_cargo**: cdn_cargo_basic, cdn_niv_cargo

---

## Tabela: cargo_planilha_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq_planilha_orcto, cdn_vers_planilha, cdn_cargo, cdn_niv_cargo

### Índices
- **crgplnlh_cargo**: cdn_cargo, cdn_niv_cargo

---

## Tabela: cargo_pretndo_candidato
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_candempr, cdn_cargo_basic, cdn_niv_cargo

### Índices
- **crgprtnd_cargo**: cdn_cargo_basic, cdn_niv_cargo

---

## Tabela: cargo_requis_aux
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_cargo_basic, cdn_niv_cargo, num_seq

### Índices

---

## Tabela: cargo_tip_descr_cargo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_cargo_basic, cdn_niv_cargo, cdn_tip_descr_cargo

### Índices
- **crgtpdsc_tpdscrcr**: cdn_tip_descr_cargo

---

## Tabela: cargo_turno_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_cargo_basic, cdn_niv_cargo, cdn_turno_trab

### Índices

---

## Tabela: carol_3c_queue
**Label**: Tabela
**Descrição**: Nome da Tabela que Possui atualiza��es de Dados

### Chave Primária
- pk_auto

### Índices

---

## Tabela: carol_func
**Label**: Sequ�ncia
**Descrição**: N�mero de Seq��ncia

### Chave Primária
- num_seq, cdn_empresa, cdn_estab, cdn_funcionario

### Índices

---

## Tabela: carol_param
**Label**: Sequ�ncia
**Descrição**: N�mero de Seq��ncia

### Chave Primária
- num_seq

### Índices

---

## Tabela: carreira_conhecto_experien
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_plano_habcomp, cdn_unid_produt_habcomp, cdn_carreira_habcomp, cdn_bloco_habcomp, cdn_empresa, cdn_grp_conhecto_experien, cdn_conhecto_experien

### Índices
- **crrrcnhc_cnhctxpr**: cdn_empresa, cdn_grp_conhecto_experien, cdn_conhecto_experien

---

## Tabela: carreira_habcomp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_plano_habcomp, cdn_unid_produt_habcomp, cdn_carreira_habcomp, cdn_bloco_habcomp, cdn_habcomp, cdn_proficiencia

### Índices
- **crrrhbcm_hbcmpprf**: cdn_habcomp, cdn_proficiencia

---

## Tabela: carreira_plano_habcomp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_carreira_habcomp

### Índices

---

## Tabela: cart_vacina_depend
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_depend_func, cdn_vacina

### Índices
- **crtvcndp_py16001**: cdn_empresa, cdn_estab, cdn_funcionario, cdn_depend_func, dat_aplic_vacina
- **crtvcndp_py16003**: cdn_vacina

---

## Tabela: cat
**Label**: Sal�rio Contribui��o
**Descrição**: Valor Salario Contribuicao

### Chave Primária
- cdn_empresa, cdn_estab, num_acidtrab, num_cat_acidtrab

### Índices
- **cat_acdttrb**: cdn_empresa, cdn_estab, num_acidtrab, num_cat_acidtrab
- **cat_cid**: cod_clas_cid, cod_grp_cid, cod_cid
- **cat_crgbsc**: cdn_cargo_basic
- **cat_fncnr**: cdn_empres_func, cdn_estab_func, cdn_funcionario
- **cat_mtrnsp**: cod_meio_transp
- **cat_prstdrsr**: cdn_empresa, cdn_serv_medic_encam
- **cat_prtcrp**: cod_parte_corpo_atgdo
- **cat_rhccusto**: cdn_empresa, cod_ccusto
- **cat_rhpssfsc**: num_pessoa_fisic

---

## Tabela: cat_cid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cid, cod_clas_cid, cod_grp_cid, cdn_empresa, cdn_estab, num_acidtrab, num_cat_acidtrab

### Índices
- **catcid_cat**: cdn_empresa, cdn_estab, num_acidtrab, num_cat_acidtrab

---

## Tabela: cat_natur_lesao_acidte
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_natur_acidtrab, cdn_empresa, cdn_estab, num_acidtrab, num_cat_acidtrab

### Índices
- **ctntrlsc_cat**: cdn_empresa, cdn_estab, num_acidtrab, num_cat_acidtrab

---

## Tabela: cat_parte_atgdo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_acidtrab, num_cat_acidtrab, cod_parte_corpo_atgdo

### Índices
- **ctprttgd_prtcrp**: cod_parte_corpo_atgdo

---

## Tabela: cat_perf_profis
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empres_func, cdn_estab_func, cdn_funcionario, num_pessoa_fisic, num_cat_acidtrab, cdn_empresa, cdn_estab, num_acidtrab

### Índices

---

## Tabela: categ_habilit_calc_fp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_categ_sal, idi_orig_contratac_func, cdn_prestdor_serv

### Índices
- **ctghbltc_orgmdstb**: cdn_empresa, cdn_estab, idi_orig_contratac_func, cdn_prestdor_serv

---

## Tabela: categ_ptoelet
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_clas_func, cdn_empresa, cdn_estab, cdn_categ_sal

### Índices
- **ctgptlt_tm03702**: cdn_tip_compcao_hrs

---

## Tabela: categ_refei
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_categ_refei, num_horar_inic_period_refei

### Índices

---

## Tabela: categ_refei_local_marcac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_local_marcac_ptoelet, cod_categ_refei

### Índices
- **ctgrflcl_ctgrf**: cod_categ_refei

---

## Tabela: categ_sal
**Label**: Perc Adiant
**Descrição**: Percentual utilizado para c�lculo do adiantamento normal

### Chave Primária
- cdn_empresa, cdn_estab, cdn_categ_sal

### Índices
- **categsal_py02902**: cdn_empresa, cdn_bco_cheq_salario, cdn_agenc_bcia_cheq_salario
- **categsal_py02903**: cdn_empresa, cdn_categ_sal
- **categsal_py02904**: cdn_empresa, cdn_bco_fgts, cdn_agenc_bcia_fgts
- **categsal_py02905**: cdn_empresa, cdn_bco_liq, cdn_agenc_bcia_liq
- **categsal_rhgncbc**: cdn_bco_liq, cdn_agenc_bcia_liq

---

## Tabela: categ_tip_refei
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_categ_refei, cdn_tip_refei, num_seq_categ_refei

### Índices
- **ctgtprf_tm00201**: cod_categ_refei
- **ctgtprf_tm00203**: cdn_tip_refei

---

## Tabela: causa_acidte_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, num_acidte_ambntal, cod_causa_acidtrab, cod_item_quest_medic

### Índices
- **cscdtmbn_itmcscdt**: cod_causa_acidtrab, cod_item_quest_medic

---

## Tabela: causa_acidte_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_causa_acidtrab

### Índices

---

## Tabela: causa_acidtrab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_acidtrab, cod_causa_acidtrab, cod_item_quest_medic

### Índices
- **cscdtrb_acdttrb**: num_acidtrab
- **cscdtrb_itmcscdt**: cod_causa_acidtrab, cod_item_quest_medic

---

## Tabela: causa_proces_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_causa_proces_trab

### Índices

---

## Tabela: causa_rescis
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_causa_rescis

### Índices

---

## Tabela: causa_rescis_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_causa_rescis_entrev_func

### Índices

---

## Tabela: ccusto_event_cargo_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_cenar_orcto, cdn_event_orcto, cdn_empresa, cod_rh_ccusto

### Índices
- **ccstvntc_ccusto**: cdn_empresa, cod_rh_ccusto, cdn_cenar_orcto, cdn_event_orcto

---

## Tabela: ccusto_rat_encargo
**Label**: Rateio Sem V�nculo
**Descrição**: Valor sem vinculo

### Chave Primária
- cdn_empresa, num_ano_refer_grps, num_mes_refer_grps, cdn_estab, cod_unid_negoc, cdn_estab_trab, cod_rh_ccusto, idi_tip_guia_encargo_social, cdn_encargo, num_seq_guia_rat_encargo, cod_tip_mdo, idi_origem, qti_parc_rat

### Índices
- **ccstrtnc_py03002**: cdn_empresa, num_ano_refer_grps, num_mes_refer_grps, cdn_estab, cdn_encargo, idi_tip_guia_encargo_social, num_seq_guia_rat_encargo
- **ccstrtnc_rhestab**: cdn_empresa, cdn_estab

---

## Tabela: ccusto_rat_encargo_un
**Label**: Rateio Sem V�nculo
**Descrição**: Valor sem vinculo

### Chave Primária
- cdn_empresa, num_ano_refer_grps, num_mes_refer_grps, cdn_estab, cod_unid_negoc, cod_rh_ccusto, idi_tip_guia_encargo_social, cdn_encargo, num_seq_guia_rat_encargo, cod_tip_mdo, idi_origem

### Índices
- **ccstrtna_anomes**: cdn_empresa, num_ano_refer_grps, num_mes_refer_grps, cdn_estab, cod_unid_negoc, cdn_encargo, idi_tip_guia_encargo_social, num_seq_guia_rat_encargo
- **ccstrtna_rhestab**: cdn_empresa, cdn_estab, cod_unid_negoc

---

## Tabela: ccusto_respons_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_rh_ccusto, cod_usuar_respons, cdn_turno_trab, cdn_estab, cod_unid_lotac

### Índices
- **ccstrspn_trntrb**: cdn_turno_trab

---

## Tabela: cenar_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_cenar_orcto

### Índices

---

## Tabela: cenar_prh
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_plano_prh, cdn_cenar_prh

### Índices

---

## Tabela: chapa_cipa
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_chapa_cipa

### Índices

---

## Tabela: cid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_clas_cid, cod_grp_cid, cod_cid

### Índices
- **cid_log**: log_mais_utlzad, cod_clas_cid, cod_grp_cid, cod_cid

---

## Tabela: clas_cargo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_clas_cargo

### Índices

---

## Tabela: clas_cargo_event_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_cenar_orcto, cdn_event_orcto, cod_clas_cargo

### Índices
- **clscrgvn_movto**: cod_clas_cargo, cdn_cenar_orcto, cdn_event_orcto

---

## Tabela: clas_cargo_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_clas_cargo

### Índices

---

## Tabela: clas_cid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_clas_cid

### Índices

---

## Tabela: clas_eqpcol
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_clas_eqpcol

### Índices

---

## Tabela: clas_eqpcol_serv
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_clas_eqpcol

### Índices

---

## Tabela: clas_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_clas_func

### Índices

---

## Tabela: classif_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_classif_ambntal

### Índices

---

## Tabela: classif_ocupac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_classif_ocupac

### Índices

---

## Tabela: classif_residuo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_classif_residuo

### Índices

---

## Tabela: clien_acidte_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_clien_acidte_trab

### Índices

---

## Tabela: clien_depto_secao_sub_secao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_clien_rh, cdn_estab, cdn_plano_lotac, cod_unid_lotac, cdn_funcionario

### Índices
- **clndptsc_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario
- **clndptsc_undltcpl**: cdn_plano_lotac, cod_unid_lotac

---

## Tabela: coletor_dados
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_coletor_dados

### Índices

---

## Tabela: competit_regiao_sal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_cargo_basic, cdn_niv_cargo, cdn_regiao_sal

### Índices
- **cmpttrgs_rgsl**: cdn_regiao_sal
- **cmpttrgs_tbcmptt**: cdn_competit

---

## Tabela: compl_pessoa_fisic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_pessoa_fisic

### Índices

---

## Tabela: compon_cipa
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_area_segur, num_mandat_cipa, cdn_funcionario, dat_candtura_cipa, num_pessoa_fisic, cdn_empres_func_compon, cdn_estab_func_compon, cdn_funcao_cipa_sind

### Índices
- **cmpncp_fnccpsnd**: cdn_funcao_cipa_sind
- **cmpncp_fncnr**: cdn_empres_func_compon, cdn_estab_func_compon, cdn_funcionario
- **cmpncp_mtvxccp**: cod_motiv_saida_cipa
- **cmpncp_ptcrn**: cdn_empresa, cdn_estab, cod_area_segur, num_mandat_cipa, cdn_empres_func_compon, cdn_estab_func_compon, cdn_funcionario

---

## Tabela: compon_formul_calc
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_formul_calc_verba, num_seq_compon_formul_calc

### Índices

---

## Tabela: compon_sesmt
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_compon_sesmt

### Índices
- **cmpnssmt_entdcls**: cod_entid_clas_profis
- **cmpnssmt_espcldtn**: cod_especialid_atndte_ambumed
- **cmpnssmt_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario
- **cmpnssmt_prstdrsr**: cdn_empresa, cdn_prestdor_serv

---

## Tabela: compos_ambien_ativid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_ambien_risco, num_laudo_ambntal, cod_ativid_func

### Índices
- **cmpsmbnt_ativid**: cdn_empresa, cdn_estab, cod_ativid_func
- **cmpsmbnt_ldmbntl**: cdn_empresa, cdn_estab, num_laudo_ambntal

---

## Tabela: compos_ambien_cargo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_ambien_risco, num_laudo_ambntal, cdn_cargo_basic

### Índices
- **cmpsmbnc_crgbsc**: cdn_cargo_basic
- **cmpsmbnc_ldmbntl**: cdn_empresa, cdn_estab, num_laudo_ambntal

---

## Tabela: compos_ambien_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_ambien_risco, num_laudo_ambntal, cdn_empres_func, cdn_estab_func, cdn_funcionario

### Índices
- **cmpsmbnf_fncnr**: cdn_empres_func, cdn_estab_func, cdn_funcionario
- **cmpsmbnf_ldmbntl**: cdn_empresa, cdn_estab, num_laudo_ambntal

---

## Tabela: compos_ambien_risco
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_ambien_risco, cdn_plano_lotac, cod_unid_lotac, cdn_cargo_basic, cod_ativid_func, num_laudo_ambntal

### Índices
- **cmpsmbnr_ativid**: cdn_empresa, cdn_estab, cod_ativid_func
- **cmpsmbnr_crgbsc**: cdn_cargo_basic
- **cmpsmbnr_estrut**: cdn_empresa, cdn_estab, cdn_plano_lotac, cod_unid_lotac, cdn_cargo_basic, cod_ativid_func
- **cmpsmbnr_ldmbntl**: cdn_empresa, cdn_estab, num_laudo_ambntal
- **cmpsmbnr_plnltc**: cdn_plano_lotac
- **cmpsmbnr_undltc**: cod_unid_lotac

---

## Tabela: compos_grp_pagto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_grp_pagto, cdn_event_fp, idi_tip_guia_encargo_social, cdn_encargo, num_seq_guia_rat_encargo, idi_proces_orig, idi_tip_fp

### Índices
- **cmpsgrpp_encarg**: cdn_grp_pagto, idi_tip_guia_encargo_social, cdn_encargo, num_seq_guia_rat_encargo, idi_proces_orig, idi_tip_fp
- **cmpsgrpp_event**: cdn_grp_pagto, cdn_event_fp, idi_proces_orig, idi_tip_fp

---

## Tabela: compos_instruc_calc
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_formul_calc_verba, num_seq_instruc_calc, idi_tip_termo_instruc_calc, num_compos_instruc_calc

### Índices

---

## Tabela: compos_investig_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_faixa_cust_acidte, cdn_empresa, cdn_estab, cod_unid_lotac, cdn_cargo_basic

### Índices

---

## Tabela: compos_relat_rh
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- idi_tip_relat_rh, num_col_relat_rh, cdn_event_fp

### Índices

---

## Tabela: con_acidtrab_natur_lesao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_acidtrab, num_ficha_medic, num_consmedic, cod_natur_acidtrab

### Índices

---

## Tabela: cond_insegur
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cond_insegur_acidte

### Índices

---

## Tabela: condic_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_condic_ambntal

### Índices

---

## Tabela: condic_aspecto_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_condic_aspecto

### Índices

---

## Tabela: condic_licenc_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_licenc_ambntal, cod_orgao_emissor_notif, dat_emis_licenc, cod_condic_ambntal, cdn_empresa

### Índices
- **cndclcnc_cndcmbnt**: cod_condic_ambntal
- **cndclcnc_lclmbntl**: cod_local_ambntal
- **cndclcnc_lcncmbnt**: cod_licenc_ambntal, cod_orgao_emissor_notif, dat_emis_licenc, cdn_empresa

---

## Tabela: config_aprov_ferias
**Label**: dias estende ferias
**Descrição**: dias estende ferias

### Chave Primária
- cod_usuario

### Índices

---

## Tabela: config_taf_cloud
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario

### Índices

---

## Tabela: config_taf_cloud_empres
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario, cdn_empresa

### Índices

---

## Tabela: config_taf_cloud_erro
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario, num_seq

### Índices

---

## Tabela: config_taf_cloud_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario, cod_usuar_taf, idi_tip_ambien

### Índices

---

## Tabela: configur_aso
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- num_compon_sesmt

### Índices

---

## Tabela: configur_control_aces
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_configur_control_aces

### Índices

---

## Tabela: configur_docto_ppra
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_area_segur

### Índices

---

## Tabela: configur_segur_rh
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_base_dados

### Índices

---

## Tabela: conhecto_experien_pessoa
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_pessoa_fisic, cdn_empresa, cdn_grp_conhecto_experien, cdn_conhecto_experien

### Índices
- **cnhctxpa_cnhctxpr**: cdn_empresa, cdn_grp_conhecto_experien, cdn_conhecto_experien
- **cnhctxpa_prfcnc**: cdn_proficiencia

---

## Tabela: conhecto_experien_profis
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_grp_conhecto_experien, cdn_conhecto_experien

### Índices

---

## Tabela: conhecto_experien_unid_lotac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_plano_lotac, cod_unid_lotac, cdn_habcomp, cdn_empresa, cdn_grp_conhecto_experien, cdn_conhecto_experien

### Índices

---

## Tabela: consmedic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_ficha_medic, num_consmedic

### Índices
- **cnsmdc_agenda**: dat_consmedic, hra_marcac_consmedic, num_consmedic, num_ficha_medic
- **cnsmdc_agend_med**: num_atndte_medic_indcao, dat_atendim_consmedic, num_ficha_medic
- **cnsmdc_cid**: cod_clas_cid, cod_grp_cid, cod_cid
- **cnsmdc_cmpnssmt**: num_atndte_ambumed
- **cnsmdc_estab**: cdn_empresa, cdn_estab, num_consmedic
- **cnsmdc_ficha**: num_consmedic, num_ficha_medic
- **cnsmdc_mtvcnsmd**: cod_motiv_consmedic
- **cnsmdc_ntrlscdt**: cod_natur_acidtrab
- **cnsmdc_plnltc**: cdn_plano_lotac
- **cnsmdc_undltc**: cod_unid_lotac

---

## Tabela: consmedic_acidtrab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_ficha_medic, num_consmedic, num_acidtrab

### Índices
- **cnsmdccd_acidente**: num_acidtrab, num_ficha_medic, num_consmedic
- **cnsmdccd_cat**: cdn_empresa, cdn_estab, num_acidtrab, num_cat_acidtrab
- **cnsmdccd_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario

---

## Tabela: consmedic_aso_cid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_ficha_medic, num_consmedic, num_aso, cod_clas_cid, cod_grp_cid, cod_cid, idi_consmedic_aso

### Índices

---

## Tabela: contdo_programat_curso
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_curso_trein, dat_refer

### Índices

---

## Tabela: contrat_func
**Label**: Sal�rio Atual
**Descrição**: Valor do sal�rio atual

### Chave Primária
- cdn_empresa, cdn_estab, cdn_contrat_candempr, num_pessoa_fisic

### Índices
- **cntrtfnc_cnddtmpr**: cdn_candempr
- **cntrtfnc_pessoa**: cdn_empresa, cdn_estab, num_pessoa_fisic, dat_inic_contrat_candempr
- **cntrtfnc_rhestab**: cdn_empresa, cdn_estab, cdn_req_pessoal, cdn_candempr

---

## Tabela: contrat_proj_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_proj_ambntal, cod_contrat, dat_contrat

### Índices

---

## Tabela: control_cheq_salario
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_banco, cdn_agenc_bcia, num_ser_cheq, num_cheq_salario

### Índices
- **cntrlchq_py03203**: cdn_empresa, cdn_estab, num_ano_refer_emis_cheq, num_mes_refer_emis_cheq, cdn_tip_fp, num_parc_cheq_salario, cdn_funcionario
- **cntrlchq_py03204**: cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_ferias, num_parc_cheq_salario

---

## Tabela: control_marcac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_usuar_control_aces, cdn_planta_edificio, cdn_perf_aces, cdn_local_aces

### Índices

---

## Tabela: control_niv
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_usuar_control_aces, cdn_planta_edificio, cdn_perf_aces, cdn_local_aces_marcac, cdn_local_aces_orig

### Índices
- **cntrlnv_dtprcs**: cdn_usuar_control_aces, cdn_planta_edificio, cdn_perf_aces, cdn_local_aces_marcac, cdn_local_aces_orig, dat_proces_mpe
- **cntrlnv_hrprcs**: cdn_usuar_control_aces, dat_proces_mpe, num_horar_marcac_aces

---

## Tabela: control_pcmso
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_pcmso

### Índices
- **cntrlpcm_rhpssfsc**: cdn_respons_pcmso

---

## Tabela: control_proces_advog
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_proces_trab, cdn_advog_proces_trab, dat_inic_atuac_proces

### Índices
- **cntrlpra_advog**: cdn_advog_proces_trab, cod_proces_trab

---

## Tabela: control_proces_andto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_proces_trab, dat_audien_proces

### Índices
- **cntrlprg_junta**: num_pessoa_jurid

---

## Tabela: control_proces_causa
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_proces_trab, cdn_causa_proces_trab

### Índices
- **cntrlprf_cau**: cdn_causa_proces_trab, cod_proces_trab
- **cntrlprf_desf**: cdn_forma_desfecho_causa

---

## Tabela: control_proces_pagto
**Label**: Val Parcela Pagto Processo
**Descrição**: Valor Parcela Pagamento Processo

### Chave Primária
- cod_proces_trab, dat_pagto_proces, cdn_tip_pagto_proces_trab, num_seq_pagto_proces

### Índices
- **cntrlpre_data**: dat_pagto_proces
- **cntrlpre_tipo**: cdn_tip_pagto_proces_trab

---

## Tabela: control_proces_penhora
**Label**: Val Penhora Processo
**Descrição**: Valor Penhora Processo

### Chave Primária
- cod_proces_trab, num_item_penhora

### Índices
- **cntrlpri_bem**: cod_bem_pat, cod_proces_trab, num_item_penhora

---

## Tabela: control_proces_rat_empres
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_proces_trab, num_pessoa_jurid

### Índices
- **cntrlprd_pj**: num_pessoa_jurid, cod_proces_trab

---

## Tabela: control_proces_reclaman
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_proces_trab, num_pessoa_fisic

### Índices
- **cntrlprb_func**: cdn_empresa, cdn_estab, cdn_funcionario
- **cntrlprb_rhpssfsc**: num_pessoa_fisic

---

## Tabela: control_proces_testem
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_proces_trab, num_pessoa_fisic

### Índices
- **cntrlprc_rhpssfsc**: num_pessoa_fisic

---

## Tabela: control_proces_trab
**Label**: Val Total Processo
**Descrição**: Valor Total Processo

### Chave Primária
- cod_proces_trab

### Índices
- **cntrlprh_des**: cdn_forma_desfecho_proces
- **cntrlprh_emp**: cdn_empresa
- **cntrlprh_esc**: num_pessoa_jurid
- **cntrlprh_loc**: cod_pais, cdn_localidade
- **cntrlprh_rec**: dat_recebto_proces

---

## Tabela: control_seq_calc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_mes_pagto_fp, num_ano_pagto_fp, num_seq_calc_fp_mes

### Índices
- **cntrlsqc_contrsq_centraliz**: cdn_empresa, cdn_estab, cdn_func_centrdor, num_ano_pagto_fp, num_mes_pagto_fp, num_seq_calc_fp_mes

---

## Tabela: control_vacina
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_vacina

### Índices

---

## Tabela: conven_benefic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_beneficio, cdn_prestdor_serv

### Índices
- **cnvnbnfc_prstdrsr**: cdn_empresa, cdn_prestdor_serv
- **cnvnbnfc_py04101**: cdn_beneficio
- **cnvnbnfc_py04103**: cdn_empresa, cdn_estab, log_pago_pelo_sist

---

## Tabela: conven_bolsa_estudo
**Label**: M�dia Nota
**Descrição**: Valor da M�dia de Nota

### Chave Primária
- cdn_bolsa_estudo

### Índices
- **cnvnblss_grnstrc**: cdn_grau_instruc
- **cnvnblss_instttrn**: cdn_instit_trein
- **cnvnblss_nvhrfncn**: cdn_niv_hier_funcnal

---

## Tabela: conver_carg_turno_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_sit_afast_func, cdn_efp_carg_turno_trab

### Índices
- **cnvrcrgt_py06901**: cdn_efp_dias_pago_empres
- **cnvrcrgt_py06902**: cdn_efp_carg_turno_trab
- **cnvrcrgt_py06903**: cdn_efp_dias_pago_inss

---

## Tabela: convid_reuniao_cipa
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_area_segur, num_mandat_cipa, num_reuniao_cipa, num_seq_convid

### Índices

---

## Tabela: convoc_exam_medic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_pcmso, num_convoc_exam_medic, dat_exam_medic_func, hra_exam_medic_func, num_ficha_medic

### Índices
- **cnvcxmmd_datconv**: cdn_empresa, cdn_estab, cdn_funcionario, dat_exam_medic_func
- **cnvcxmmd_lotac**: cdn_empresa, num_pcmso, num_convoc_exam_medic, cdn_estab, cdn_plano_lotac, cod_unid_lotac
- **cnvcxmmd_num_ficha**: num_ficha_medic
- **cnvcxmmd_pcmso**: num_pcmso, num_convoc_exam_medic, dat_realiz_exam_medic
- **cnvcxmmd_plnltc**: cdn_plano_lotac
- **cnvcxmmd_undltc**: cod_unid_lotac

---

## Tabela: convoc_exam_param
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_pcmso, num_convoc_exam_medic

### Índices
- **cnvcxmpr_crgbsc**: cdn_cargo_basic
- **cnvcxmpr_hrrtndmm**: cdn_empresa, num_horar_turno_trab
- **cnvcxmpr_local**: cod_local_exam_medic
- **cnvcxmpr_plnltc**: cdn_plano_lotac
- **cnvcxmpr_prstdrsr**: cdn_empresa, cdn_prestdor_serv
- **cnvcxmpr_rhpssfsc**: num_compon_sesmt
- **cnvcxmpr_undltc**: cod_unid_lotac

---

## Tabela: convoc_intermte
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_convoc_intermte, cdn_empresa

### Índices
- **cnvcntrm_ix2**: cdn_jorn_trab

---

## Tabela: convoc_intermte_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_convoc_intermte, cdn_empresa, cdn_estab, cdn_funcionario

### Índices
- **cnvcntra_ix2**: cdn_empresa, cdn_estab, cdn_funcionario

---

## Tabela: coorden_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_coorden_trein

### Índices
- **crdntrn_pf** (Unique): num_pessoa_fisic

---

## Tabela: copart_func
**Label**: Valor Copart
**Descrição**: Valor Coparticipa��o

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_depend_func

### Índices

---

## Tabela: cracha_prov
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_cracha_prov

### Índices
- **crchprv_tm06002** (Unique): cdn_empresa, cdn_cracha_prov_calcul

---

## Tabela: cracha_prov_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_cracha_prov_calcul, dat_inic_sit_afast_func, num_horar_inic_sit_afast

### Índices
- **crchprvs_fncptlt**: cdn_empres_usuar_rh, cdn_estab_usuar_rh, cdn_usuar_cracha_prov
- **crchprvs_tm06202**: cdn_empresa, cdn_cracha_prov_calcul, dat_fim_sit_afast_func, num_horar_term_sit_afast
- **crchprvs_tm06203**: cdn_empresa, idi_motiv_utiliz_cracha_prov, dat_inic_sit_afast_func, num_horar_inic_sit_afast

---

## Tabela: cta_ctbl_efp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_event_fp

### Índices
- **ctctblfp_py15501**: cdn_empresa, cod_rh_ccusto_mdo_direta_cr
- **ctctblfp_py15502**: cdn_empresa, cod_rh_ccusto_mdo_direta_db
- **ctctblfp_py15503**: cdn_empresa, cod_rh_ccusto_mdo_indta_cr
- **ctctblfp_py15504**: cdn_empresa, cod_rh_ccusto_mdo_indta_db
- **ctctblfp_py15505**: cdn_empresa, cod_cta_mdo_direta_cr
- **ctctblfp_py15506**: cdn_empresa, cod_cta_mdo_direta_db
- **ctctblfp_py15507**: cdn_empresa, cod_cta_mdo_indta_cr
- **ctctblfp_py15508**: cdn_empresa, cod_cta_mdo_indta_db
- **ctctblfp_py15509**: cdn_event_fp

---

## Tabela: cta_ctbl_event_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_event_orcto, cod_tip_mdo

### Índices
- **ctctblvn_tipmdo**: cod_tip_mdo

---

## Tabela: cta_ctbl_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_rh_cta_ctbl

### Índices

---

## Tabela: cta_ctbl_tip_cust_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_tip_cust_trein

### Índices

---

## Tabela: cta_mdo_efp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_event_fp, cod_tip_mdo

### Índices

---

## Tabela: cta_mdo_encargo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_plano_lotac, cod_unid_lotac, idi_tip_guia_encargo_social, cdn_encargo, num_seq_guia_rat_encargo, cod_tip_mdo, idi_origem

### Índices

---

## Tabela: curso_arq_docto
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_curso_trein, cdn_arq_docto

### Índices

---

## Tabela: curso_bolsa_estudo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_bolsa_estudo, cdn_curso_trein

### Índices
- **crsblsst_crstrn**: cdn_curso_trein

---

## Tabela: curso_candempr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_curso_candempr

### Índices

---

## Tabela: curso_lotac_cargo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_cargo_basic, cdn_niv_cargo, cdn_plano_lotac, cod_unid_lotac, cdn_curso_trein

### Índices
- **crsltccr_crstrn**: cdn_curso_trein
- **crsltccr_equiv**: cdn_plano_lotac, cod_unid_lotac, cdn_cargo_basic, cdn_niv_cargo, num_curso_equiv
- **crsltccr_nvrqscrg**: cdn_niv_requis_cargo

---

## Tabela: curso_lotac_cargo_aux
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_cargo_basic, cdn_niv_cargo, cdn_plano_lotac, cod_unid_lotac, cdn_curso_trein

### Índices

---

## Tabela: curso_pre_requis
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_curso_trein, cdn_curso_pre_requis

### Índices
- **crsprrqs_crstrn**: cdn_curso_pre_requis

---

## Tabela: curso_prev_cust
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_curso_trein, cdn_tip_cust_trein, cdn_empresa, cdn_estab, dat_refer

### Índices
- **crsprvcs_rhestab**: cdn_empresa, cdn_estab
- **crsprvcs_tpcsttrn**: cdn_tip_cust_trein

---

## Tabela: curso_prog_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_prog_trein, cdn_curso_trein

### Índices
- **crsprgtr_nvrqscrg**: cdn_niv_requis_cargo

---

## Tabela: curso_prog_trein_aux
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_prog_trein, cdn_curso_trein

### Índices

---

## Tabela: curso_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_curso_trein

### Índices
- **crstrn_epm**: cod_curso_epm
- **crstrn_grnstrc**: cdn_grau_instruc
- **crstrn_nom**: des_curso_trein
- **crstrn_nvhrfncn**: cdn_niv_hier_funcnal
- **crstrn_sigcrs**: cod_sig_curso
- **crstrn_tpcrstrn**: cdn_tip_curso_trein

---

## Tabela: curso_trein_aux
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_curso_trein

### Índices

---

## Tabela: cust_acidte_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq_cust_acidte_ambntal, cdn_empresa, num_acidte_ambntal

### Índices
- **cstcdtmb_acdtmbnt**: cdn_empresa, num_acidte_ambntal
- **cstcdtmb_tpcsttrn**: cdn_tip_cust_trein

---

## Tabela: cust_acidte_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_acidtrab, cdn_tip_despes_acidtrab

### Índices
- **cstcdttr_tpdspscd**: cdn_tip_despes_acidtrab

---

## Tabela: cust_bolsista
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_bolsa_estudo, cdn_curso_trein, cdn_bolsista, dat_refer, num_comptcia_cust_trein, cdn_empresa, cod_rh_ccusto, cdn_tip_cust_trein

### Índices
- **cstblsst_rhccusto**: cdn_empresa, cod_rh_ccusto
- **cstblsst_tpcsttrn**: cdn_tip_cust_trein
- **cstblsst_undltcpl**: cdn_plano_lotac, cod_unid_lotac

---

## Tabela: cust_event
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cust_event

### Índices

---

## Tabela: cust_event_sipat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_sipat, cod_event_sipat, dat_event_sipat, hra_event_sipat, cod_cust_event

### Índices
- **cstvntsp_cstvnt**: cod_cust_event

---

## Tabela: cust_proj_ambntal
**Label**: Valor Ressarcimento
**Descrição**: Valor Ressarcimento Ambiental

### Chave Primária
- cdn_empresa, cod_proj_ambntal, cdn_tip_cust_trein, dat_cust_proj_ambntal

### Índices
- **cstprjmb_tpcsttrn**: cdn_tip_cust_trein

---

## Tabela: cust_req_pessoal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_req_pessoal, cdn_tip_cust_trein, cdn_seq_cust_req_pessoal, dat_refer

### Índices

---

## Tabela: cust_treindo_extra
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_curso_trein, cdn_turma_trein, cdn_treindo_normal, cdn_tip_cust_trein, dat_refer, num_ano_cust_trein, num_mes_cust_trein, cdn_empresa, cod_rh_ccusto, idi_gerac_cust_trein

### Índices
- **csttrndx_rhccusto**: cdn_empresa, cod_rh_ccusto
- **csttrndx_tpcsttrn**: cdn_tip_cust_trein

---

## Tabela: cust_turma_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_curso_trein, cdn_turma_trein, cdn_tip_cust_trein, dat_refer, num_ano_cust_trein, num_mes_cust_trein, cdn_empresa, cod_rh_ccusto

### Índices
- **csttrmtr_rhccusto**: cdn_empresa, cod_rh_ccusto
- **csttrmtr_tpcsttrn**: cdn_tip_cust_trein

---

## Tabela: cx_sugest_segur
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_sugest_segur_func

### Índices
- **cxsgstsg_fncnr**: cdn_empres_func, cdn_estab_func, cdn_funcionario

---

## Tabela: cx_sugest_segur_plano_acao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_sugest_segur_func, cdn_plano_organ, cdn_objorg

### Índices
- **cxsgstsa_objorg**: cdn_empresa, cdn_plano_organ, cdn_objorg

---

## Tabela: defcncia_fisic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_defcncia_fisic

### Índices

---

## Tabela: defcncia_pacien
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_ficha_medic, cod_defcncia_fisic, dat_inic_defcncia

### Índices
- **dfcncpcn_dfcncfsc**: cod_defcncia_fisic

---

## Tabela: demand_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_demand_ambntal

### Índices

---

## Tabela: demand_inspec_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_demand_ambntal, cod_inspec_ambntal

### Índices
- **dmndnspc_dmndmbnt**: cod_demand_ambntal
- **dmndnspc_inspcmbn**: cod_inspec_ambntal, cdn_empresa

---

## Tabela: demand_norma_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_norma_ambntal, dat_emis_norma, cod_demand_ambntal

### Índices
- **dmndnrmm_dmndmbnt**: cdn_empresa, cod_demand_ambntal

---

## Tabela: demand_proj_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_demand_ambntal, cod_proj_ambntal

### Índices
- **dmndprjm_prjmbntl**: cdn_empresa, cod_proj_ambntal

---

## Tabela: demonst_efp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_demonst_efp

### Índices

---

## Tabela: depend_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_depend_func

### Índices
- **dpndfnc_mtvstbl**: cdn_motiv_estabil_func
- **dpndfnc_rhndfdrc**: cod_pais_nasc, cod_unid_federac_nasc

---

## Tabela: desenv_habcomp_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_habcomp, cdn_proficiencia, dat_inic_valid

### Índices
- **dsnvhbcm_hbcmpprf**: cdn_habcomp, cdn_proficiencia
- **dsnvhbcm_hbcmprsp**: cdn_funcionario

---

## Tabela: despes_extra_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq_planilha_orcto, num_seq_variac_cargo_planilha, cod_clas_cargo, num_ano_refer, num_mes_refer

### Índices

---

## Tabela: despes_provis_ccusto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cod_unid_negoc, cdn_estab_trab, cod_rh_ccusto, cod_tip_mdo, cdn_event_fp, num_ano_refer_fp, num_mes_refer_fp, qti_parc_rat

### Índices

---

## Tabela: dest_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_dest_ambntal

### Índices

---

## Tabela: det_bco_compcao_turma_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_compcao_hrs, cdn_turno_trab, cdn_turma_trab, cod_pais, cdn_localidade, dat_utiliz_hrs_compcao

### Índices
- **dtbccmpa_localidade**: cod_pais, cdn_localidade, cdn_tip_compcao_hrs, cdn_turno_trab, cdn_turma_trab, dat_utiliz_hrs_compcao
- **dtbccmpa_period**: cdn_tip_compcao_hrs, cdn_turno_trab, cdn_turma_trab, cod_pais, cdn_localidade, dat_inic_period_compcao

---

## Tabela: det_calend_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_refer_calend

### Índices
- **dtclndfn_lcld**: cdn_empresa, cdn_estab, cdn_funcionario, cod_pais, cdn_localidade
- **dtclndfn_trntrb**: cdn_empresa, cdn_estab, cdn_funcionario, cdn_turno_trab, cdn_turma_trab

---

## Tabela: det_calend_turma_localid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_turno_trab, cdn_turma_trab, cod_pais, cdn_localidade, dat_refer_calend

### Índices
- **dtclndtr_dtclndta**: cdn_turno_trab, cdn_turma_trab, dat_refer_calend
- **dtclndtr_dtrfrclnd**: dat_refer_calend
- **dtclndtr_lcldd**: cod_pais, cdn_localidade

---

## Tabela: det_calend_turma_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_turno_trab, cdn_turma_trab, dat_refer_calend

### Índices
- **dtclndta_dtfimdia**: cdn_turno_trab, cdn_turma_trab, dat_term_dia_trab
- **dtclndta_dtinidia**: cdn_turno_trab, cdn_turma_trab, dat_inic_dia_trab
- **dtclndta_py22002**: cdn_jorn_trab
- **dtclndta_py22003**: num_period_escal
- **dtclndta_py22004**: cod_tip_dia

---

## Tabela: det_formul_calc_ptoelet
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_sit_mpe, num_seq_formul_ptoelet

### Índices

---

## Tabela: det_rescis
**Label**: Sal�rio Atual
**Descrição**: Valor do sal�rio atual

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_tip_calc_rescis, num_seq_det_rescis_contratual

### Índices
- **dtrscs_py05002**: cdn_empresa, cdn_estab, cdn_funcionario, num_ano_refer_fp, num_mes_refer_fp, cdn_tip_calc_rescis

---

## Tabela: det_rescis_normal
**Label**: Sal�rio Atual
**Descrição**: Valor do sal�rio atual

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_tip_calc_rescis, cdn_event_fp

### Índices

---

## Tabela: det_tab_valores_formul_calc
**Label**: Valor
**Descrição**: Valor Referencia Faixa Tabela Valores

### Chave Primária
- cod_tab_valores_formul_calc, dat_inic_vigenc, num_faixa_tab_valores

### Índices

---

## Tabela: dia_fer
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_calend_fer, dat_fer_nac_rh

### Índices
- **diafer_tpdhrrtr**: cod_tip_dia

---

## Tabela: dias_calend_event_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_event_orcto, cdn_empresa, cdn_estab, dat_lancto_event_orcto

### Índices

---

## Tabela: dias_trabdo_benefic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_ano_refer, num_mes_refer, idi_tip_dia_benefic

### Índices

---

## Tabela: dirf_anual_meio_magnet
**Label**: Valor Bruto Pessoas F�sicas
**Descrição**: Valor bruto mensal para as pessoas f�sicas

### Chave Primária
- cod_cgc_declar, cdn_retenc_irf, cdn_tip_bnfciar, cod_cpf_cgc

### Índices
- **drfnlmmg_py05202**: cdn_empresa, cdn_estab, cdn_funcionario

---

## Tabela: discip_curso_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_curso_trein, cdn_discip_trein

### Índices

---

## Tabela: discip_entid_educnal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_discip_entid_educnal

### Índices

---

## Tabela: discip_instrut_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_instrutor, cdn_discip_trein

### Índices

---

## Tabela: discip_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_discip_trein

### Índices

---

## Tabela: disposit_control_aces
**Label**: Percentual Revista
**Descrição**: Valor Percentual Amostra Revista

### Chave Primária
- cdn_planta_edificio, cdn_disposit_control_aces

### Índices
- **dspstcnt_fbrcn_dspst**: idi_fabrican_disposit_aces
- **dspstcnt_ident**: cdn_ident_disposit

---

## Tabela: docto_quiosq
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_arq_docto, cod_vers_docto

### Índices
- **dctqsq_seq** (Unique): num_seq_arq_docto

---

## Tabela: documen_candempr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_candempr

### Índices
- **dcmncndm_cpf**: cod_id_feder

---

## Tabela: efeito_agent_risco
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_efeito_agent_risco

### Índices

---

## Tabela: efet_pagto_prestdor_benefic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_beneficio, cdn_prestdor_serv

### Índices

---

## Tabela: efetivac_efp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_event_fp, dat_pagto_efet_efp

### Índices
- **eftvcfp_eventfp**: cdn_event_fp

---

## Tabela: efluente
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_efluente

### Índices

---

## Tabela: efp_benefic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_beneficio, cdn_formul_calc_benefic

### Índices
- **efpbnfc_bnfc**: cdn_beneficio

---

## Tabela: efp_corrig
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_sindicato, cdn_event_fp

### Índices

---

## Tabela: efp_emis_balan_social
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- idi_tip_grp_balan_social, idi_grp_indic_social_inter, cdn_event_fp

### Índices

---

## Tabela: efp_emis_indic_social_ext
**Label**: Tributos
**Descrição**: Valor Tributo

### Chave Primária
- num_seq

### Índices

---

## Tabela: efp_emis_inform_relev
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq

### Índices

---

## Tabela: efp_emis_inform_rendto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, idi_grp_dirf, cdn_event_fp, cdn_estab, cdn_beneficio, cdn_ans

### Índices
- **efpmsnfr_py15901**: cdn_empresa, cdn_event_fp
- **efpmsnfr_py15902**: cdn_event_fp

---

## Tabela: efp_emis_rais
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- idi_grp_rais, cdn_event_fp

### Índices
- **efpmsrs_evt**: cdn_event_fp

---

## Tabela: efp_formul_calc_variac_sal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_sindicato, cdn_event_fp

### Índices
- **efpfrmlc_eventfp**: cdn_event_fp
- **efpfrmlc_py19301**: cdn_empresa, cdn_formul_calc_variac_sal

---

## Tabela: efp_hora_extra_tip_dia_sind
**Label**: Percentual Hora Extra
**Descrição**: Percentual de hora extra para este hor�rio

### Chave Primária
- cdn_empresa, cdn_sindicato, cod_tip_dia, idi_tratam_hora, num_horar_inic_interv_refei

### Índices
- **efphrxtr_eventfp**: cdn_efp_hora_extra_diurno

---

## Tabela: efp_inform_rendto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_cpf, num_ano_refer_calc_efetd, num_mes_refer_calc_palim, num_seq_movto_calcul_fp

### Índices
- **efpnfrmr_py11302** (Unique): cod_cgc_declar, cod_cpf, num_ano_refer_calc_efetd, num_mes_refer_calc_palim, num_seq_movto_calcul_fp

---

## Tabela: efp_par_marcac_ptoelet
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_proces_mpe, num_horar_inic_proces_mpe

### Índices
- **efpprmrc_mesano**: cdn_empresa, cdn_estab, cdn_funcionario, num_ano_refer_fp, num_mes_refer_fp
- **efpprmrc_tm04402**: cdn_efp
- **efpprmrc_tm04403**: cdn_empresa, cdn_estab, cdn_funcionario, num_mes_ano_refer_fp
- **efpprmrc_tm04404**: cdn_sit_afast_func

---

## Tabela: efp_tip_dias_sind
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_sindicato, cod_tip_dia

### Índices
- **efptpdss_sndct**: cdn_sindicato
- **efptpdss_tpdhrrtr**: cod_tip_dia

---

## Tabela: efp_vale_transp
**Label**: Percentual Compl
**Descrição**: Percentual complementar

### Chave Primária
- cdn_empresa, cdn_estab, cdn_beneficio

### Índices
- **efpvltrn_py06802**: cdn_empresa, cdn_formul_calc_benefic

---

## Tabela: empdo_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empdo_ambntal

### Índices

---

## Tabela: empres_ant_candidato_ext
**Label**: �ltimo Sal�rio
**Descrição**: Valor �ltimo Sal�rio Candidato Emprego

### Chave Primária
- cdn_candempr, cdn_empres_recrut, cdn_seq_empres_candempr

### Índices
- **emprsntc_emprscna**: cdn_empres_recrut

---

## Tabela: empres_ant_pessoa_fisic
**Label**: �ltimo Sal�rio
**Descrição**: Valor �ltimo Sal�rio Candidato Emprego

### Chave Primária
- num_pessoa_fisic, num_empres_ant_pessoa_fisic

### Índices
- **emprsntp_emprscna**: cdn_empres_recrut

---

## Tabela: empres_candidato_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empres_recrut

### Índices
- **emprscna_undfdrc**: cod_pais, cod_unid_federac_rh

---

## Tabela: emprest_func_ccusto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cod_unid_negoc, cdn_estab_trab, cod_rh_ccusto, dat_inic_emprest_func_ccusto, num_horar_inic_emprest_ccusto

### Índices
- **emprstfn_rhccusto**: cdn_empresa, cod_rh_ccusto

---

## Tabela: emprest_func_localid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cod_pais, cdn_localidade, dat_inic_lotac_func

### Índices
- **emprstfa_lcldd**: cod_pais, cdn_localidade

---

## Tabela: emprest_interv_jorn
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_alter_horar_turma, dat_inic_alter_interv, cdn_jorn_trab, cdn_interv_refei

### Índices
- **emprstnt_tm06501**: cdn_empresa, cdn_estab, cdn_funcionario, cdn_turno_trab, cdn_turma_trab, cdn_jorn_trab, cdn_interv_refei

---

## Tabela: emprest_turno_turma_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_alter_horar_turma

### Índices
- **emprsttr_tm06402**: cdn_empresa, cdn_estab, cdn_funcionario, cdn_turno_trab, cdn_turma_trab

---

## Tabela: encam_ext
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_ficha_medic, num_seq_encam

### Índices
- **encamext_espcldtn**: cod_especialid_atndte
- **encamext_prestador**: cdn_empresa, cdn_prestdor_serv, cod_exam_medic, num_ficha_medic

---

## Tabela: encam_ext_exam
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- num_ficha_medic, num_consmedic, num_seq_encam, cod_exam_medic

### Índices
- **encmxtxm_encamext**: num_ficha_medic, num_seq_encam

---

## Tabela: encam_inter
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_ficha_medic, num_consmedic

### Índices

---

## Tabela: encargo_histor_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_histor_ctbl, idi_tip_guia_encargo_social, cdn_encargo, num_seq_guia_rat_encargo

### Índices
- **encrghst_enchistor**: cdn_empresa, idi_tip_guia_encargo_social, cdn_encargo, num_seq_guia_rat_encargo, cdn_histor_ctbl

---

## Tabela: encargo_social
**Label**: Percentual
**Descrição**: Percentual do encargo a calcular

### Chave Primária
- cdn_empresa, cdn_estab, cdn_plano_lotac, cod_unid_lotac, idi_tip_guia_encargo_social, cdn_encargo, num_seq_guia_rat_encargo

### Índices
- **encrgsca_undltcpl**: cdn_plano_lotac, cod_unid_lotac

---

## Tabela: encargo_social_calcula
**Label**: Percentual
**Descrição**: Percentual do encargo a calcular

### Chave Primária
- cdn_empresa, cdn_estab, cdn_encargo

### Índices
- **encrgscl_py05701**: cdn_empresa, cod_rh_ccusto_mdo_direta_cr
- **encrgscl_py05702**: cdn_empresa, cod_rh_ccusto_mdo_direta_db
- **encrgscl_py05703**: cdn_empresa, cod_rh_ccusto_mdo_indta_cr
- **encrgscl_py05704**: cdn_empresa, cod_rh_ccusto_mdo_indta_db
- **encrgscl_py05705**: cdn_empresa, cod_cta_mdo_direta_cr
- **encrgscl_py05706**: cdn_empresa, cod_cta_mdo_direta_db
- **encrgscl_py05707**: cdn_empresa, cod_cta_mdo_indta_cr
- **encrgscl_py05708**: cdn_empresa, cod_cta_mdo_indta_db

---

## Tabela: entid_clas
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_entid_clas_profis

### Índices

---

## Tabela: entid_clas_profis
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_entid_clas_profis

### Índices
- **entdclsp_undfdrc**: cod_pais, cod_unid_federac_rh

---

## Tabela: entid_emprest_financ
**Label**: Perc Parcela Soma
**Descrição**: Valor Percentual Salario Remuneracao Disponivel Soma

### Chave Primária
- cdn_empresa, cdn_banco, cdn_agenc_bcia, cdn_sindicato, cdn_estab

### Índices
- **entdmprs_rhestab**: cdn_empresa, cdn_estab
- **entdmprs_rhgncbc**: cdn_banco, cdn_agenc_bcia
- **entdmprs_sndct**: cdn_sindicato

---

## Tabela: entrev_desligto_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario

### Índices
- **entrvdsl_cargo**: cdn_cargo_basic, cdn_niv_cargo
- **entrvdsl_cpf_nascimento**: cod_id_feder, dat_nascimento
- **entrvdsl_nome_nascimento**: nom_pessoa_fisic, dat_nascimento
- **entrvdsl_sitafast**: cdn_sit_afast_func

---

## Tabela: epi_cargo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_cargo_basic, cdn_empresa, cod_epi

### Índices
- **epicargo_eqptprtc**: cdn_empresa, cod_epi

---

## Tabela: epi_cargo_transf
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_epi, cdn_cargo_basic

### Índices

---

## Tabela: epi_fonte_gerador
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_fonte_gerador_risco, cdn_empresa, cod_epi

### Índices
- **epfntgrd_eqptprtc**: cdn_empresa, cod_epi

---

## Tabela: epi_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cod_epi, cdn_fornecedor, dat_entreg_epi

### Índices
- **epifunc_epinumer**: cod_epi_numer
- **epifunc_frncp**: cdn_empresa, cdn_estab, cdn_fornecedor, cod_epi
- **epifunc_rhpssjrd**: cdn_fornecedor
- **epifunc_substit**: cdn_empresa, cod_epi, cdn_funcionario, dat_entreg_epi
- **epifunc_undmddsg**: cod_unid_med_epi

---

## Tabela: epi_liber_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_epi, cdn_estab, cdn_funcionario, num_seq

### Índices

---

## Tabela: epi_numer
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_epi_numer

### Índices

---

## Tabela: epi_risco
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_ambien_risco, num_riscacid, cod_epi

### Índices
- **epirisco_epi**: cod_epi
- **epirisco_eqptprtc**: cdn_empresa, cod_epi
- **epirisco_rsccdttr**: num_ambien_risco, num_riscacid

---

## Tabela: epi_transf
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_epi, cdn_empres_func, cdn_estab_func, cdn_funcionario

### Índices

---

## Tabela: epi_unid_lotac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_plano_lotac, cod_unid_lotac, cod_epi

### Índices
- **epndltc_eqptprtc**: cod_epi
- **epndltc_plnltc**: cdn_plano_lotac
- **epndltc_undltc**: cod_unid_lotac

---

## Tabela: eqpcol_risco
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_ambien_risco, num_riscacid, cod_eqpcol, num_seq

### Índices
- **eqpclrsc_rsccdttr**: num_ambien_risco, num_riscacid

---

## Tabela: eqpcol_solic_manut
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_solicit_manut_eqpcol, cod_eqpcol

### Índices
- **eqpclslc_mtvmntqp**: cod_motiv_manut_eqpcol

---

## Tabela: eqpto_audtvo
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_eqpto_audtvo_medid

### Índices

---

## Tabela: eqpto_avaliac_risco
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_eqpto_avaliac_risco

### Índices

---

## Tabela: eqpto_horar_dia_turma
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_instit_trein, cdn_eqpto_trein, dat_aula_turma_trein, hra_inic_period

### Índices
- **eqpthrrd_hrrdtrmt**: cdn_curso_trein, cdn_turma_trein, dat_aula_turma_trein, hra_inic_period

---

## Tabela: eqpto_irregul
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_eqpcol, num_seq, cod_irregul_eqpto, dat_irregul_eqpto, hra_irregul_eqpto

### Índices

---

## Tabela: eqpto_perf_profis
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- num_pessoa_fisic, num_seq_perf_profis, cod_eqpto_protec, idi_tip_eqpto_protec, num_seq

### Índices
- **eqptprfp_rhpssfsc**: num_pessoa_fisic
- **eqptprfp_rscprfpr**: cdn_empresa, cdn_estab, cdn_funcionario, num_pessoa_fisic, cdn_plano_lotac, cod_unid_lotac, cdn_cargo_basic, cod_ativid_func, num_riscacid, dat_medid_risco, hra_fonte_medid, cod_agent_risco

---

## Tabela: eqpto_protec_coletiv
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_eqpcol, num_seq

### Índices
- **eqptprta_clasepc**: cod_clas_eqpcol
- **eqptprta_lclmprs**: cdn_empresa, cod_local_empres
- **eqptprta_undltc**: cod_unid_lotac
- **eqptprta_undltcpl**: cdn_plano_lotac, cod_unid_lotac

---

## Tabela: eqpto_protec_indual
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_epi

### Índices

---

## Tabela: eqpto_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_instit_trein, cdn_eqpto_trein

### Índices
- **eqpttrn_tpqpttrn**: cdn_tip_eqpto_trein

---

## Tabela: equipe_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_equipe_ambntal

### Índices
- **eqpmbntl_fncmbntl**: cod_funcao_equipe_ambntal

---

## Tabela: erro_import_control_aces
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_ident_disposit, cod_cartao_aces, dat_marcac_aces, num_horar_marcac_aces, num_seq_marcac_control_aces

### Índices
- **errmprtc_bsc_ma**: dat_marcac_aces, num_horar_marcac_aces, cod_cartao_aces, cdn_planta_edificio, cdn_local_aces, num_seq_marcac_control_aces
- **errmprtc_cracha**: cod_cartao_aces, dat_marcac_aces, num_horar_marcac_aces, num_seq_marcac_control_aces, cdn_ident_disposit
- **errmprtc_disposit**: cdn_planta_edificio, cdn_disposit_control_aces, dat_marcac_aces, num_horar_marcac_aces, num_seq_marcac_control_aces, cdn_usuar_control_aces
- **errmprtc_imp**: cdn_usuar_control_aces, dat_marcac_aces, num_horar_marcac_aces, cdn_planta_edificio, cdn_disposit_control_aces, log_marcac_procesda, log_marcac_integr_ptoelet, idi_sit_import
- **errmprtc_usr_cntrl**: cdn_usuar_control_aces, dat_marcac_aces, num_horar_marcac_aces, idi_direcao_aces
- **errmprtc_usuar_dips**: cdn_usuar_control_aces, cdn_planta_edificio, cdn_disposit_control_aces, dat_marcac_aces, num_horar_marcac_aces, num_seq_marcac_control_aces
- **errmprtc_usuar_horar**: cdn_usuar_control_aces, dat_marcac_aces, num_horar_marcac_aces, num_seq_marcac_control_aces, cdn_planta_edificio, cdn_disposit_control_aces

---

## Tabela: erro_import_mpe
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, num_ident_matr_cartao_import, dat_mpe, num_hora_mpe

### Índices
- **errmprtm_cpf**: cdn_empresa, cdn_estab, cod_id_feder, dat_mpe, num_hora_mpe
- **errmprtm_data**: dat_mpe, cdn_empresa, idi_status_erro, idi_tip_erro_import_mpe
- **errmprtm_erro**: idi_status_erro, idi_tip_erro_import_mpe
- **errmprtm_func**: cdn_empresa, cdn_estab, cdn_funcionario, dat_mpe, num_hora_mpe
- **errmprtm_imp**: nom_arq_mpe_imptdo, dat_import_arq_mpe, num_hora_corren_import_mpe, num_seq_import
- **errmprtm_ix10**: num_seqcial_msa
- **errmprtm_ix11**: val_control_marcac
- **errmprtm_pis**: cdn_empresa, cdn_estab, cod_pis, dat_mpe, num_hora_mpe
- **errmprtm_relogio**: cdn_empresa, cdn_relogio_pto, dat_mpe, num_hora_mpe
- **errmprtm_status**: cdn_empresa, cdn_estab, num_ident_matr_cartao_import, idi_status_erro, idi_tip_erro_import_mpe
- **errmprtm_tm00902**: cdn_empresa, cdn_relogio_pto, cod_funcao_relogio_pto

---

## Tabela: escolarid_candempr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_candempr, num_seq_escolarid_candempr

### Índices

---

## Tabela: espec_docto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_espec_docto

### Índices

---

## Tabela: especialid_atndte
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_especialid_atndte_ambumed

### Índices

---

## Tabela: especialid_medic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_conslho_medic, cod_entid_clas_profis, cod_especialid_atndte_ambumed

### Índices
- **espcldmd_espcldtn**: cod_especialid_atndte_ambumed

---

## Tabela: estab_benefic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_beneficio

### Índices
- **estbbnfc_py06101**: cdn_beneficio

---

## Tabela: estab_localid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_pais, cdn_localidade

### Índices
- **estblcld_lcldd**: cod_pais, cdn_localidade

---

## Tabela: estab_transf_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_transf_estab

### Índices
- **estbtrns_transf**: cdn_empres_transf, cdn_estab_transf, cdn_func_transf, dat_transf_estab

---

## Tabela: estabil_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_motiv_estabil_func, dat_inic_estabil

### Índices
- **estblfnc_py06202**: cdn_motiv_estabil_func
- **estblfnc_sitafast**: cdn_empresa, cdn_estab, cdn_funcionario, cdn_sit_afast_func, dat_inic_sit_afast

---

## Tabela: estoq_benefic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_beneficio, cdn_estab

### Índices

---

## Tabela: estoq_benefic_det
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_beneficio, cdn_estab, num_seq

### Índices
- **estqbnfa_dat**: cdn_empresa, cdn_beneficio, cdn_estab, dat_refer

---

## Tabela: estrut_demonst_efp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_demonst_efp, num_seq_impres

### Índices
- **estrtdmn_py06401**: cdn_demonst_efp, cdn_event_demonst
- **estrtdmn_py06403**: cdn_event_demonst, cdn_demonst_efp, num_seq_impres

---

## Tabela: estrut_efp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_event_sint, cdn_efp_det

### Índices
- **estrtfp_py06502**: cdn_efp_det, cod_event_sint

---

## Tabela: estrut_plano_habcomp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_plano_habcomp, cdn_unid_produt_habcomp, num_seq_estrut_plano_habcomp

### Índices
- **estrtpln_undprdtp**: cdn_plano_habcomp, cdn_unid_produt_habcomp_filho

---

## Tabela: estrut_plano_lotac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_plano_lotac, cod_unid_lotac_pai, num_seq_estrut_plano_lotac

### Índices
- **estrtpln_unddprtp**: cdn_plano_lotac, cod_unid_lotac_filho

---

## Tabela: estrut_reporte_avaliac
**Label**: Pontua��o Avalia��o
**Descrição**: Pontua��o Geral da Avalia��o

### Chave Primária
- cdn_plano_estrut_reporte, dat_estrut_reporte_avaliac

### Índices

---

## Tabela: estrut_reporte_grp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_plano_estrut_reporte, cdn_estrut_reporte_grp

### Índices

---

## Tabela: estrut_reporte_grp_pos
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_ident_estrut_reporte_pos, cdn_plano_estrut_reporte, cdn_estrut_reporte_grp

### Índices
- **estrtrpc_estrtrpd**: cdn_plano_estrut_reporte, cdn_estrut_reporte_grp

---

## Tabela: estrut_reporte_plano
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_plano_estrut_reporte

### Índices

---

## Tabela: estrut_reporte_pos
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_plano_estrut_reporte, cdn_empresa, cdn_estab, cod_unid_lotac, cdn_cargo_basic, cdn_niv_cargo

### Índices
- **estrtrpr_identif** (Unique): num_ident_estrut_reporte_pos
- **estrtrpr_sec**: cdn_plano_estrut_reporte, cdn_empres_sup, cdn_estab_sup, cod_unid_lotac_sup, cdn_cargo_basic_sup, cdn_niv_cargo_sup, cdn_empresa, cdn_estab, cod_unid_lotac, cdn_cargo_basic, cdn_niv_cargo
- **estrtrpr_seq**: cdn_plano_estrut_reporte, num_seq_unid_lotac
- **estrtrpr_undltc**: cod_unid_lotac

---

## Tabela: estrut_reporte_pos_avaliac
**Label**: Pontua��o Avalia��o
**Descrição**: Pontua��o Geral da Avalia��o

### Chave Primária
- num_ident_estrut_reporte_pos, dat_refer_respos_avpes

### Índices
- **estrtrpf_etpplnrg**: cdn_etap_plano_organ

---

## Tabela: estrut_reporte_pos_clien
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_ident_estrut_reporte_pos, num_ident_estrut_reporte_clien, cdn_plano_estrut_reporte, cdn_estrut_reporte_grp, cdn_empresa, cdn_produt_inter_rh

### Índices
- **estrtrpg_estrtrpr**: num_ident_estrut_reporte_clien
- **estrtrpg_prdtntrr**: cdn_empresa, cdn_produt_inter_rh

---

## Tabela: estrut_reporte_pos_pessoa
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_ident_estrut_reporte_pos, num_pessoa_fisic, dat_inic_valid

### Índices

---

## Tabela: estrut_unid_organ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_organ_pai, num_seq_unid_organ

### Índices
- **estrtndr_nvndrgn**: num_niv_unid_organ
- **estrtndr_undrgn**: cod_unid_organ_filho

---

## Tabela: etap_integr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_etap_integr_func

### Índices

---

## Tabela: etap_plano_organ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_etap_plano_organ

### Índices

---

## Tabela: etap_proces_sel
**Label**: Peso Etapa
**Descrição**: Valor Peso Etapa Modelo Avalia��o

### Chave Primária
- cdn_etap_sel_candempr

### Índices
- **etpprcss_lcltrn**: cdn_instit_trein, cdn_local_trein
- **etpprcss_rhpssfsc**: num_pessoa_fisic_respons

---

## Tabela: etap_sel_arq
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_etap_sel_candempr, cdn_arq_docto

### Índices

---

## Tabela: etap_sel_cust
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_etap_sel_candempr, cdn_tip_cust_trein

### Índices

---

## Tabela: event_calc_retroat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_calc, cdn_event_dest, cdn_event_orig

### Índices
- **evntclcr_evorig**: cdn_empresa, cdn_calc, cdn_event_orig, cdn_event_dest

---

## Tabela: event_cargo_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_cenar_orcto, cdn_event_orcto, cdn_cargo, cdn_niv_cargo

### Índices
- **evntcrgr_cargo**: cdn_cargo, cdn_niv_cargo, cdn_cenar_orcto, cdn_event_orcto

---

## Tabela: event_dest_calc_retroat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_calc, cdn_event_dest

### Índices

---

## Tabela: event_espcif_contrat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_contrat_func, cdn_event_fp

### Índices
- **evntspcf_eventfp**: cdn_event_fp

---

## Tabela: event_excec_remun_var
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_remun_var, cdn_event_fp

### Índices

---

## Tabela: event_exclusiv_sped
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_empres_event_sped, cod_event_exclus_sped

### Índices
- **evntxcls_ix**: cod_empres_event_sped
- **evntxcls_ix2**: cod_event_exclus_sped

---

## Tabela: event_fp
**Label**: Valor Unit�rio
**Descrição**: Valor unit�rio da unidade

### Chave Primária
- cdn_empresa, cdn_event_fp

### Índices
- **eventfp_py06702**: cdn_idx_efp_funcao_espcif
- **eventfp_py06703**: log_tit_demonst_efp, cdn_event_fp
- **eventfp_py06704**: cdn_efp_falta_deduz, cdn_event_fp
- **eventfp_py06705**: cdn_efp_suplem_hrs_notur, cdn_event_fp

---

## Tabela: event_fp_valid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_event_fp

### Índices
- **evntfpvl_eventfp**: cdn_event_fp

---

## Tabela: event_grp_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_grp_event_orcto, cdn_event_orcto

### Índices

---

## Tabela: event_histor_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_histor_ctbl, cdn_event_fp

### Índices
- **evnthstr_evthistor**: cdn_empresa, cdn_event_fp, cdn_histor_ctbl

---

## Tabela: event_import_calcul
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, idi_tip_movto_import, cdn_event_ext, num_seq

### Índices

---

## Tabela: event_integr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_categ_sal, idi_tip_func, idi_orig_contratac_func

### Índices

---

## Tabela: event_liberd_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_event_fp, cod_usuario

### Índices

---

## Tabela: event_liq_neg
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_sindicato, cdn_cargo_basic, cdn_event_fp

### Índices
- **evntlqng_eventfp**: cdn_event_fp

---

## Tabela: event_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_cenar_orcto, cdn_event_orcto

### Índices

---

## Tabela: event_pagto_difer_retroat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_event_fp

### Índices

---

## Tabela: event_quadro_planilha_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq_planilha_orcto, num_seq_variac_cargo_planilha, cod_clas_cargo, cdn_event_orcto

### Índices

---

## Tabela: event_realzdo_sipat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_sipat, cod_event_sipat, dat_event_sipat, hra_event_sipat

### Índices
- **evntrlzd_fncnr**: cdn_empres_respons_event_sipat, cdn_estab_respons_event_sipat, cdn_func_respons_event_sipat

---

## Tabela: event_sint_fp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_event_sint

### Índices

---

## Tabela: event_sipat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_event_sipat

### Índices

---

## Tabela: exam_grp_pca
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_pca, cod_exam_medic

### Índices
- **exmgrppc_exam**: cod_exam_medic

---

## Tabela: exam_local_medic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_local_exam_medic, cod_exam_medic, cdn_prestdor_serv, num_compon_sesmt

### Índices
- **exmlclmd_exmmdc**: cod_exam_medic
- **exmlclmd_mdclclxm**: num_compon_sesmt, cod_local_exam_medic
- **exmlclmd_tbprccnv**: cdn_prestdor_serv

---

## Tabela: exam_medic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_exam_medic

### Índices

---

## Tabela: exam_medic_compon_sesmt
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_compon_sesmt, cod_exam_medic

### Índices

---

## Tabela: exam_medic_sub_item
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_exam_medic, cod_sub_item_exam

### Índices
- **exmmdcsb_undmddsg**: cod_unid_medid

---

## Tabela: exam_pacien
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_ficha_medic, dat_programac_exam_medic, cod_exam_medic

### Índices
- **exmpcn_aso**: num_pcmso, num_aso, cod_exam_medic, dat_programac_exam_medic
- **exmpcn_atstds**: num_aso
- **exmpcn_cntrlpcm**: cdn_empresa, cdn_estab, num_pcmso
- **exmpcn_crgbsc**: cdn_cargo_basic
- **exmpcn_datpro**: dat_programac_exam_medic, cdn_empresa, cdn_estab, cdn_funcionario, cod_exam_medic
- **exmpcn_exam**: cod_exam_medic, num_ficha_medic, dat_restdo_exam_medic
- **exmpcn_exprog**: cdn_empresa, cdn_estab, cdn_funcionario, cod_exam_medic, dat_programac_exam_medic
- **exmpcn_funcdtres**: cdn_empresa, cdn_estab, cdn_funcionario, cod_exam_medic, cod_unid_lotac, cdn_cargo_basic, idi_natur_exam_medic, dat_restdo_exam_medic
- **exmpcn_paciem**: num_ficha_medic, cod_exam_medic, dat_programac_exam_medic, num_consmedic
- **exmpcn_prestador**: cdn_empresa, cdn_prestdor_serv
- **exmpcn_realiz**: num_ficha_medic, dat_restdo_exam_medic, cod_exam_medic, dat_programac_exam_medic
- **exmpcn_tbprccnv**: cdn_prestdor_serv, cod_exam_medic

---

## Tabela: exam_perf_profis
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_pessoa_fisic, cdn_plano_lotac, cod_unid_lotac, cdn_cargo_basic, cod_ativid_func, dat_inic_func_ambien_trab, cod_exam_medic, dat_programac_exam_medic

### Índices
- **exmprfpr_exmmdc**: cod_exam_medic
- **exmprfpr_fncprfpr**: num_seq_perf_profis, num_pessoa_fisic
- **exmprfpr_rhpssfsc**: num_pessoa_fisic

---

## Tabela: excec_benefic_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_depend_func, cdn_beneficio, dat_inic_excec_benefic_func

### Índices
- **exccbnfc_bnfc**: cdn_beneficio
- **exccbnfc_estbbnfc**: cdn_empresa, cdn_estab, cdn_beneficio

---

## Tabela: excec_benefic_prestdor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_beneficio, idi_orig_contratac_func, cdn_prestdor_serv, dat_inic_valid, dat_inic_excec_benefic_func

### Índices
- **exccbnfa_orgmdstb**: cdn_empresa, cdn_estab, idi_orig_contratac_func, cdn_prestdor_serv, dat_inic_valid

---

## Tabela: excec_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, idi_excec_propost_liber, num_ano_inic_func, num_mes_inic_func

### Índices

---

## Tabela: excec_func_afastdo_ppr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_param_calc_ppr, cdn_empresa, cdn_estab, cdn_funcionario, cdn_sit_afast_func, dat_inic_sit_afast

### Índices
- **exccfncf_stfstfnc**: cdn_empresa, cdn_estab, cdn_funcionario, cdn_sit_afast_func, dat_inic_sit_afast

---

## Tabela: excec_func_motiv
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, idi_excec_propost_liber, cdn_motiv_liber_sal, num_ano_inic_func, num_mes_inic_func

### Índices
- **exccfncm_exccfnc**: cdn_empresa, cdn_estab, cdn_funcionario, idi_excec_propost_liber, num_ano_inic_func, num_mes_inic_func
- **exccfncm_mtvlbrsl**: cdn_motiv_liber_sal

---

## Tabela: faixa_cust_acidte
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_faixa_cust_acidte

### Índices

---

## Tabela: faixa_evoluc_sal
**Label**: Sal Inicial Cargo
**Descrição**: Sal�rio Inicial Cargo

### Chave Primária
- cdn_empresa, cdn_tab_sal, num_seq_tab_sal, qtd_pto_inic_cargo, num_seq_faixa_evoluc

### Índices
- **fxvlcsl_mtvlbrsl**: cdn_motiv_liber_sal

---

## Tabela: faixa_hora_aula_tab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_tab_val_hora_aula, dat_valid_inic_val_aula, dat_valid_fim_val_aula, cdn_faixa_val_hora_aula

### Índices

---

## Tabela: faixa_param_calc_ppr
**Label**: Sal�rio Inicial
**Descrição**: Valor do Sal�rio Inicial

### Chave Primária
- cdn_param_calc_ppr, num_seq_param_calc_ppr

### Índices

---

## Tabela: faixa_param_calc_ppr_contrat
**Label**: Sal�rio Inicial
**Descrição**: Valor do Sal�rio Inicial

### Chave Primária
- cdn_param_calc_ppr, cdn_empresa, cdn_tip_contrat_func, num_seq_param_calc_ppr

### Índices

---

## Tabela: faixa_param_calc_ppr_func
**Label**: Parcela Soma PLR
**Descrição**: Valor Parcela Soma PLR

### Chave Primária
- cdn_param_calc_ppr, cdn_empresa, cdn_estab, cdn_funcionario

### Índices

---

## Tabela: faixa_param_calc_ppr_lotac
**Label**: Sal�rio Inicial
**Descrição**: Valor do Sal�rio Inicial

### Chave Primária
- cdn_param_calc_ppr, idi_tip_lotac_pagto_ppr, cod_pais_localid, cdn_localidade, cod_unid_lotac, cod_rh_ccusto, cdn_cargo_basic, cdn_niv_cargo, num_seq_param_calc_ppr

### Índices

---

## Tabela: faixa_param_calc_ppr_time
**Label**: Sal�rio Inicial
**Descrição**: Valor do Sal�rio Inicial

### Chave Primária
- cdn_param_calc_ppr, cdn_empresa, cdn_time_trab, num_seq_param_calc_ppr

### Índices

---

## Tabela: faixa_renov_exam_risco
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_ambien_risco, num_riscacid, cod_exam_medic, num_faixa_etaria_func

### Índices
- **fxrnvxmr_exmmdc**: cod_exam_medic
- **fxrnvxmr_prmxmprd**: cdn_empresa, num_faixa_etaria_func
- **fxrnvxmr_rsccdttr**: num_ambien_risco, num_riscacid

---

## Tabela: faixa_sal_cargo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_categ_sal, cdn_cargo_basic, cdn_niv_cargo, cdn_tab_sal, dat_tab_sal_inic, dat_tab_sal_fim

### Índices
- **fxslcrg_cargo**: cdn_cargo_basic, cdn_niv_cargo
- **fxslcrg_py15601**: cdn_empresa, cdn_categ_sal, cdn_tab_sal, num_faixa_final_tab_sal
- **fxslcrg_py15602**: cdn_empresa, cdn_categ_sal, cdn_tab_sal, num_faixa_inicial_tab_sal
- **fxslcrg_py15603**: cdn_empresa, cdn_cargo_basic, cdn_niv_cargo, cdn_categ_sal, cdn_tab_sal

---

## Tabela: faixa_sal_tab
**Label**: Sal�rio Simulado
**Descrição**: Sal�rio simulado do funcion�rio

### Chave Primária
- cdn_empresa, cdn_categ_sal, cdn_tab_sal, dat_tab_sal_inic, dat_tab_sal_fim, num_faixa_sal

### Índices

---

## Tabela: familia_jsl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_familia_jsl

### Índices

---

## Tabela: fator_avaliac_cargo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_fator_avaliac_cargo

### Índices

---

## Tabela: fator_pessoa_insegur
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_fator_pessoa_insegur

### Índices

---

## Tabela: feedz_integration_errors
**Label**: Processo
**Descrição**: �ndice de Erros de Integra��o da Feedz by TOTVS

### Chave Primária
- process_id, integration_id

### Índices

---

## Tabela: feedz_integration_processes
**Label**: Data T�rmino
**Descrição**: �ndice de Processos de Integra��o da Feedz by TOTVS

### Chave Primária
- process_id

### Índices

---

## Tabela: fer_localid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_pais, cdn_localidade, dat_refer

### Índices

---

## Tabela: fer_turno_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_calend_fer

### Índices

---

## Tabela: ficha_acompto_func
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_ocor_ficha_func, cdn_tip_acompto_func

### Índices
- **fchcmptf_tpfchcmp**: cdn_tip_acompto_func

---

## Tabela: ficha_invent_trein
**Label**: Nr Sequencial Matr
**Descrição**: Valor Sequencia Matricula

### Chave Primária
- num_pessoa_fisic, idi_tip_trein, cdn_curso_trein, dat_inic_curso_trein

### Índices
- **fchnvntt_crsspr**: cdn_curso_trein
- **fchnvntt_epm**: val_seq_matr
- **fchnvntt_mtvdsbtc**: cdn_motiv_desabtcao_treindo
- **fchnvntt_trndcrss**: num_pessoa_fisic, cdn_curso_trein

---

## Tabela: ficha_medic
**Label**: Peso
**Descrição**: Valor - Inteiro do Peso da Pessoa

### Chave Primária
- num_ficha_medic

### Índices
- **fchmdc_candto**: cdn_candempr, num_ficha_medic
- **fchmdc_depte**: cdn_empresa, cdn_estab, cdn_funcionario, cdn_depend_func, num_ficha_medic
- **fchmdc_ficha_ant**: num_ficha_medic_ant
- **fchmdc_func**: cdn_empresa, cdn_estab, cdn_funcionario, num_ficha_medic
- **fchmdc_nome**: nom_pacien_medic, num_ficha_medic
- **fchmdc_nomempest**: nom_pacien_medic, cdn_empresa, cdn_estab
- **fchmdc_rhpssfsc**: num_pessoa_fisic
- **fchmdc_terceiros**: cdn_empresa, num_pessoa_fisic, num_ficha_medic

---

## Tabela: fisc_tar_agric
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_fisc_tar_agric, cdn_estab, cdn_funcionario

### Índices
- **fsctrgrc_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario

---

## Tabela: fluxo_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_fluxo_financ

### Índices

---

## Tabela: fonte_circuns
**Label**: Sequ�ncia
**Descrição**: N�mero de Seq?�ncia

### Chave Primária
- cdn_empresa, num_seq, num_peri

### Índices
- **fntcrcns_id2**: num_seq

---

## Tabela: fonte_gerad_passiv
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_fonte_gerad_passiv

### Índices

---

## Tabela: fonte_gerador_medid
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- num_seq

### Índices
- **fntgrdrm_acidte**: cdn_empresa, cdn_estab, num_ambien_risco, num_riscacid
- **fntgrdrm_agntrsc**: cod_agent_risco
- **fntgrdrm_gm**: cod_fonte_gerador_risco, cod_agent_risco, dat_medid_risco, hra_fonte_medid

---

## Tabela: fonte_gerador_medid_aux
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_fonte_gerador_risco, cod_agent_risco, dat_medid_risco, hra_fonte_medid, num_seq

### Índices

---

## Tabela: fonte_gerador_medid_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_fonte_gerador_risco, cod_agent_risco, dat_medid_risco, hra_fonte_medid, cdn_empresa, cdn_estab, cdn_funcionario

### Índices

---

## Tabela: fonte_gerador_risco
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_fonte_gerador_risco

### Índices

---

## Tabela: fonte_passiv_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_passiv_ambntal, cod_obj_gerador_acidte, idi_tip_pessoa, num_pessoa

### Índices
- **fntpssvm_objgrdrc**: cod_obj_gerador_acidte

---

## Tabela: fonte_risco_acidte_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_ambien_risco, num_riscacid, cod_fonte_gerador_risco

### Índices
- **fntrsccd_fnt**: cod_fonte_gerador_risco

---

## Tabela: forma_acond
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_forma_acond

### Índices

---

## Tabela: forma_desfecho_proces_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_forma_desfecho_proces

### Índices

---

## Tabela: forma_entreg_curso
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_curso_trein, cdn_forma_entreg_trein

### Índices

---

## Tabela: forma_entreg_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_forma_entreg_trein

### Índices

---

## Tabela: forma_pagto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_forma_pagto

### Índices

---

## Tabela: forma_saida_residuo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_forma_saida_residuo

### Índices

---

## Tabela: formul_benef_calc_retroat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_calc, cdn_formul_calc_benefic

### Índices

---

## Tabela: formul_calc_benefic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_formul_calc_benefic, num_seq_formul_benefic

### Índices

---

## Tabela: formul_calc_bnfciar_palim
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_bnfciar_palim, cdn_tip_calc_verba, cod_verba_calc, dat_inic_valid

### Índices

---

## Tabela: formul_calc_colab
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_tip_calc_verba, cod_verba_calc, dat_inic_valid

### Índices
- **frmlclce_vrb**: cod_verba_calc, dat_inic_valid

---

## Tabela: formul_calc_depend_func
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_depend_func, cdn_tip_calc_verba, cod_verba_calc, dat_inic_valid

### Índices

---

## Tabela: formul_calc_desatualiz
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_formul_calc_verba

### Índices

---

## Tabela: formul_calc_efp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_event_fp

### Índices
- **frmlclcf_py07701**: cdn_event_fp

---

## Tabela: formul_calc_event_sind
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_sindicato, cdn_event_fp, cdn_formul_calc_variac_sal

### Índices
- **frmlclcc_evt**: cdn_event_fp
- **frmlclcc_form**: cdn_empresa, cdn_formul_calc_variac_sal

---

## Tabela: formul_calc_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_cenar_orcto, cdn_event_orcto, num_seq_calc_geral

### Índices

---

## Tabela: formul_calc_ptoelet
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_sit_mpe

### Índices
- **frmlclcp_tm01302**: cdn_sit_mpe

---

## Tabela: formul_calc_retroat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_calc, cdn_estab, cdn_event_fp, cdn_sindicato, cdn_formul_calc_variac_sal

### Índices

---

## Tabela: formul_calc_variac_sal_efp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_formul_calc_variac_sal, num_seq_calc_fp

### Índices
- **frmlclcv_py07601**: cdn_empresa, log_formul_calc_prog_espcif

---

## Tabela: formul_calc_verba
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_formul_calc_verba

### Índices
- **frmlclcd_sqclc**: num_seq_exec_calc

---

## Tabela: fornec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_fornecedor

### Índices

---

## Tabela: fornec_epi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_epi, cdn_fornecedor

### Índices
- **frncp_fornec**: cdn_empresa, cdn_estab, cdn_fornecedor, cod_epi
- **frncp_rhpssjrd**: cdn_fornecedor

---

## Tabela: freq_treindo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_curso_trein, cdn_turma_trein, cdn_treindo_normal, dat_aula_turma_trein, hra_inic_period

### Índices
- **frqtrnd_hrrdtrmt**: cdn_curso_trein, cdn_turma_trein, dat_aula_turma_trein, hra_inic_period

---

## Tabela: func_acidte_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_acidtrab, num_cat_acidtrab

### Índices
- **fnccdttr_acidte**: num_acidtrab, cdn_empresa, cdn_estab, cdn_funcionario
- **fnccdttr_cat**: cdn_empresa, cdn_estab, num_acidtrab, num_cat_acidtrab
- **fnccdttr_fncnr**: cdn_empresa, cdn_estab, cdn_func_respons

---

## Tabela: func_aux_func
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario

### Índices

---

## Tabela: func_calc
**Label**: Sal�rio Simulado
**Descrição**: Sal�rio simulado do funcion�rio

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario

### Índices
- **funccalc_calculo**: cdn_empresa, cdn_estab, cdn_categ_sal, cdn_turno_trab, cdn_turma_trab, cod_pais_localid, cdn_localidade, cdn_sindicato, cdn_sit_calc_func, cdn_funcionario
- **funccalc_sitbene**: cdn_empresa, cdn_estab, cdn_turno_trab, cdn_turma_trab, val_salario_atual, cdn_funcionario, cod_rh_ccusto, cdn_sit_benefic, cdn_sindicato
- **funccalc_sitcalc**: cdn_empresa, cdn_estab, cdn_categ_sal, cdn_turno_trab, cdn_turma_trab, cdn_sindicato, cdn_sit_calc_func, cdn_funcionario

---

## Tabela: func_calc_compl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario

### Índices
- **fncclccm_mdo**: cdn_empresa, cdn_estab, cdn_categ_sal, idi_orig_contratac_func, cdn_prestdor_serv

---

## Tabela: func_cargo_salario
**Label**: Sal�rio Mensal
**Descrição**: Valor do sal�rio padr�o do m�s

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario

### Índices
- **fnccrgsl_cmpttrgs**: cdn_cargo_basic, cdn_niv_cargo, cdn_regiao_sal
- **fnccrgsl_nvhrfncn**: num_seq_niv_hier_funcnal
- **fnccrgsl_rgsl**: cdn_regiao_sal
- **fnccrgsl_rhccusto**: cdn_empresa, cod_rh_ccusto
- **fnccrgsl_tabsal**: cdn_empresa, cdn_tab_sal, cdn_categ_sal, cdn_regiao_sal
- **fnccrgsl_tpdmcrg**: cdn_categ_sal
- **fnccrgsl_trntrb**: cdn_turno_trab

---

## Tabela: func_categ_ptoelet
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_lotac_func

### Índices
- **fncctgpt_cls**: cdn_clas_func, cdn_empresa, cdn_estab, cdn_categ_sal, dat_inic_lotac_func

---

## Tabela: func_categ_sal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_categ_sal, cdn_funcionario, dat_inic_lotac_func

### Índices
- **fncctgsl_fimlotac**: cdn_empresa, cdn_estab, cdn_categ_sal, dat_fim_lotac_func
- **fncctgsl_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_lotac_func

---

## Tabela: func_ccusto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_rh_ccusto, cdn_estab, cdn_funcionario, dat_inic_lotac_func

### Índices
- **fncccst_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_lotac_func

---

## Tabela: func_cenar_prh
**Label**: Tempo Casa
**Descrição**: Tempo Casa

### Chave Primária
- cdn_plano_prh, cdn_cenar_prh, cdn_empresa, cdn_estab, cdn_funcionario

### Índices

---

## Tabela: func_contrat_temp_consig
**Label**: Valor Total
**Descrição**: Valor Total das Parcelas do Contrato

### Chave Primária
- cod_id_feder_estab, cod_id_feder_func, cod_contrat_emprest, cdn_entid_emprest

### Índices

---

## Tabela: func_cpromis
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_plano_prh, num_seq

### Índices

---

## Tabela: func_curso_prh
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_plano_prh, cdn_curso_trein, num_seq

### Índices

---

## Tabela: func_demit
**Label**: Peso
**Descrição**: Peso do funcion�rio em quilogramas

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario

### Índices
- **fncdmt_pyndfdrc**: cod_pais, cod_unid_federac_rh

---

## Tabela: func_desenv_prh
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_plano_prh, num_seq

### Índices

---

## Tabela: func_diverg_ptoelet
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_proces_mpe

### Índices
- **fncdvrgp_tm05102**: log_marcac_ptoelet_tratada

---

## Tabela: func_docto_quiosq
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq_arq_docto, cdn_empresa, cdn_estab, cdn_funcionario

### Índices

---

## Tabela: func_emprest_financ
**Label**: Valor Consignado
**Descrição**: Valor Total Parcelas Consideradas

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_seq_emprest_func

### Índices
- **fncmprst_contrat**: cdn_empresa, cdn_estab, cdn_funcionario, cod_contrat_emprest
- **fncmprst_rhgncbc**: cdn_banco, cdn_agenc_bcia
- **fncmprst_sit**: cdn_empresa, cdn_estab, cdn_funcionario, idi_sit_solicit_emprest
- **fncmprst_sndct**: cdn_sindicato

---

## Tabela: func_emprest_financ_det
**Label**: Valor Descontado Ant
**Descrição**: Valor Valor Descontado Empr�stimo Anterior

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_seq_emprest_func, num_ano_refer, num_mes_refer

### Índices
- **fncmprsa_parc**: cdn_empresa, cdn_estab, cdn_funcionario, num_seq_emprest_func, num_parcela

---

## Tabela: func_estab_unid_negoc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_unid_negoc, cdn_funcionario, dat_inic_lotac_func

### Índices
- **fncstbnd_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_lotac_func

---

## Tabela: func_event_liq_neg
**Label**: Saldo Devedor
**Descrição**: Valor Saldo Devedor

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_ano_refer_fp, num_mes_refer_fp, idi_tip_fp, qti_parc_habilit_calc_fp, cdn_event_fp

### Índices
- **fncvntlq_calc**: cdn_empresa, cdn_estab, cdn_funcionario, num_ano_calc_efetd, num_mes_calc_efetd
- **fncvntlq_eventfp**: cdn_event_fp
- **fncvntlq_seq**: cdn_empresa, cdn_estab, cdn_funcionario, num_seq_event_liq_neg
- **fncvntlq_sit**: cdn_empresa, cdn_estab, cdn_funcionario, idi_sit_gerac_movto

---

## Tabela: func_expos_agent_nociv
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_expos_agent_nociv, cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_lotac_func

### Índices
- **fncxpsgn_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_lotac_func

---

## Tabela: func_fpas
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_alter_fpas

### Índices
- **funcfpas_fpas**: cdn_empresa, cdn_estab, cdn_funcionario, cdn_fpas

---

## Tabela: func_habcomp
**Label**: Pontua��o Recebida
**Descrição**: Valor Pontua��o Recebida

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_habcomp

### Índices
- **fnchbcmp_hbcmpprf**: cdn_habcomp, cdn_proficiencia
- **fnchbcmp_rhpssjrd**: num_pessoa_jurid

---

## Tabela: func_habcomp_essencial
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_plano_habcomp, cdn_unid_produt_habcomp, cdn_carreira_habcomp, cdn_bloco_habcomp, dat_inic_valid

### Índices
- **fnchbcma_dat**: cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_valid
- **fnchbcma_undprdtc**: cdn_plano_habcomp, cdn_unid_produt_habcomp, cdn_carreira_habcomp, cdn_bloco_habcomp

---

## Tabela: func_item_reqdo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_item_reqdo, dat_inic_valid

### Índices
- **fnctmrqd_itmrqd**: cdn_item_reqdo

---

## Tabela: func_lin_vale_transp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_beneficio, cdn_lin_vale_transp

### Índices
- **fnclnvlt_estbbnfc**: cdn_empresa, cdn_estab, cdn_beneficio
- **fnclnvlt_py08802**: cdn_empresa, cdn_lin_vale_transp

---

## Tabela: func_localid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_pais, cdn_localidade, cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_lotac_func

### Índices
- **fnclcld_estblcld**: cdn_empresa, cdn_estab, cod_pais, cdn_localidade
- **fnclcld_fimlotac**: cod_pais, cdn_localidade, dat_fim_lotac_func
- **fnclcld_fnclocal**: cdn_empresa, cdn_estab, cdn_funcionario, cod_pais, cdn_localidade
- **fnclcld_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_lotac_func

---

## Tabela: func_lotac_interv_refei
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_lotac_func_turno_trab, dat_inic_interv_turno_trab, cdn_jorn_trab, cdn_interv_refei

### Índices
- **fncltcnt_py21901**: cdn_empresa, cdn_estab, cdn_funcionario, cdn_turno_trab, cdn_turma_trab, cdn_jorn_trab, cdn_interv_refei

---

## Tabela: func_nao_convoc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_pcmso, num_convoc_exam_medic, cdn_funcionario, cod_exam_medic

### Índices
- **fncncnvc_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario

---

## Tabela: func_neces_trein
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_pessoa_fisic, num_nec_func_avpes

### Índices
- **fncncstr_anlsnctr**: cdn_analis_nec_trein
- **fncncstr_avpsmtd**: num_avpes_emitid
- **fncncstr_cargo**: cdn_cargo_basic, cdn_niv_cargo
- **fncncstr_crstrn**: cdn_curso_trein
- **fncncstr_hbcmpprb**: cdn_aperfmto
- **fncncstr_hbcmpprf**: cdn_habcomp, cdn_proficiencia
- **fncncstr_id2**: cdn_empresa, cdn_estab, cdn_funcionario, num_nec_func_avpes
- **fncncstr_instttrn**: cdn_instit_trein
- **fncncstr_rhpssfsc**: num_pessoa_fisic
- **fncncstr_tpncsfnc**: cdn_tip_nec_func

---

## Tabela: func_pagto_pasep
**Label**: Valor Rendimento
**Descrição**: Valor Rendimento Prog Forma��o Patr Servidor Publ

### Chave Primária
- cdn_empresa, cod_cgc_atual, cod_pasep, cdn_funcionario, cdn_estab

### Índices
- **fncpgtpa_codpasep**: cod_pasep
- **fncpgtpa_func**: cdn_empresa, cdn_estab, cdn_funcionario

---

## Tabela: func_pagto_pis
**Label**: Valor Rendimento
**Descrição**: Valor dos rendimentos a serem pagos

### Chave Primária
- cdn_empresa, cod_cgc_atual, cod_pis, cdn_funcionario, cdn_estab

### Índices
- **fncpgtps_codpis**: cod_pis
- **fncpgtps_py14201**: cdn_empresa, cdn_estab, cdn_funcionario

---

## Tabela: func_pca
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_ficha_medic, cod_grp_pca, cdn_empresa, cdn_estab, cdn_funcionario

### Índices
- **funcpca_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario
- **funcpca_grp**: cod_grp_pca

---

## Tabela: func_perf_profis
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- num_seq_perf_profis, num_pessoa_fisic, dat_emis_perf

### Índices
- **fncprfpr_rhpssfsc**: num_pessoa_fisic

---

## Tabela: func_pericul_insal_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq_planilha_orcto, num_seq_variac_cargo_planilha, cod_clas_cargo, num_ano_refer, num_mes_refer

### Índices

---

## Tabela: func_perspect
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_ocor_perspect_func, hra_ocor_perspect_func

### Índices
- **fncprspc_avpsmtd**: num_avpes_emitid
- **fncprspc_avpsrgms**: cdn_avpes_padr
- **fncprspc_cargo**: cdn_cargo_basic, cdn_niv_cargo

---

## Tabela: func_plano_habcomp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_plano_habcomp, cdn_unid_produt_habcomp, cdn_carreira_habcomp, cdn_bloco_habcomp, dat_inic_valid

### Índices
- **fncplnhb_dt**: cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_valid
- **fncplnhb_undprdtc**: cdn_plano_habcomp, cdn_unid_produt_habcomp, cdn_carreira_habcomp, cdn_bloco_habcomp

---

## Tabela: func_prestdor_serv
**Label**: Sequ�ncia
**Descrição**: N�mero de Seq��ncia

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_alter_prestdor_serv, num_seq

### Índices
- **fncprstd_ix2**: cdn_empresa, cdn_prestdor_serv
- **fncprstd_ix3**: cdn_empresa, cdn_estab, cdn_funcionario, cdn_prestdor_serv

---

## Tabela: func_prev_movimen_sal
**Label**: Remunera��o Prevista
**Descrição**: Remunera��o Prevista

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_plano_prh, num_seq

### Índices

---

## Tabela: func_ptoelet
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario

### Índices
- **fncptlt_ctpto**: cdn_clas_func, cdn_empresa, cdn_estab, cdn_categ_sal
- **fncptlt_empcartao**: cdn_empresa, num_cartao_pto_func
- **fncptlt_empcateg**: cdn_empresa, cdn_estab, cdn_funcionario, cdn_categ_sal, cdn_turno_trab, cdn_turma_trab, cdn_plano_lotac, cod_unid_lotac, cod_rh_ccusto
- **fncptlt_empmatric**: cdn_empresa, cdn_funcionario
- **fncptlt_estab_carpto**: cdn_empresa, cdn_estab, num_cartao_pto_func
- **fncptlt_localidade**: cdn_empresa, cod_pais, cdn_localidade, cdn_estab, cdn_funcionario
- **fncptlt_matric**: cdn_funcionario
- **fncptlt_num_cart**: num_cartao_pto_func
- **fncptlt_tm01402**: cod_categ_refei
- **fncptlt_tm01404**: cdn_local_marcac_cartao_pto
- **fncptlt_tm01405**: cdn_empresa, cdn_estab_lotac_func_ptoelet, cdn_funcionario, idi_tip_pessoa_calc_ptoelet
- **fncptlt_tm01406**: cdn_empresa, cdn_estab, cdn_categ_sal, cdn_clas_func, cdn_turno_trab, cdn_turma_trab, cdn_funcionario

---

## Tabela: func_rat_ppr
**Label**: PLR Perdido
**Descrição**: Valor PLR Perdido

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_ano_refer_fp, num_mes_refer_fp, idi_tip_folha_pagto, qti_parc_habilit_calc_fp

### Índices

---

## Tabela: func_reinteg
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_reinteg_func_fp

### Índices

---

## Tabela: func_respons_laudo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_laudo_ambntal, num_pessoa_fisic, dat_inic_laudo_ambntal

### Índices
- **fncrspns_espcldtn**: cod_especialid_atndte_ambumed
- **fncrspns_rhpssfsc**: num_pessoa_fisic

---

## Tabela: func_respons_pcmso
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_pcmso, num_compon_sesmt, dat_inic_pcmso

### Índices

---

## Tabela: func_sat
**Label**: Percentual SAT
**Descrição**: Valor Percentual Seguro acidente trabalho

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_alter_sat

### Índices
- **funcsat_perc**: cdn_empresa, cdn_estab, cdn_funcionario, val_perc_sat
- **funcsat_sat**: cdn_empresa, cdn_estab, cdn_funcionario, cdn_sat

---

## Tabela: func_sem_ferias_coletiv
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cod_programac_ferias_coletiv

### Índices

---

## Tabela: func_sind_estab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_sindicato, dat_inic_valid, cdn_funcionario, dat_inic_lotac_func

### Índices
- **fncsndst_fimlotac**: cdn_empresa, cdn_estab, cdn_sindicato, dat_inic_valid, dat_fim_lotac_func
- **fncsndst_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_lotac_func

---

## Tabela: func_substdo_req
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_req_pessoal, cdn_funcionario

### Índices
- **fncsbstd_fncnr**: cdn_funcionario

---

## Tabela: func_sucess_potenc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_cargo_basic_suceder, cdn_estab_func_suceder, cdn_func_suceder, cdn_estab, cdn_funcionario

### Índices
- **fncscssp_cargo**: cdn_empresa, cdn_estab, cdn_funcionario, cdn_cargo_basic, cdn_niv_cargo
- **fncscssp_crgfncsc**: cdn_empresa, cdn_estab_func_suceder, cdn_func_suceder
- **fncscssp_tpstscss**: cdn_tip_sit_sucess

---

## Tabela: func_sugest_prom
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_sugest_prom_func

### Índices
- **fncsgstp_cargo**: cdn_cargo_basic, cdn_niv_cargo

---

## Tabela: func_tip_mdo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_mdo, cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_lotac_func

### Índices
- **fnctpmd_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_lotac_func

---

## Tabela: func_tomador_serv
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_alter_tomador_serv, num_seq

### Índices
- **fnctmdrs_rhclien**: cdn_empresa, cdn_clien_rh
- **fnctmdrs_tomad**: cdn_empresa, cdn_estab, cdn_funcionario, cdn_clien_rh

---

## Tabela: func_tomador_serv_ppp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_alter_tomador_serv, num_seq

### Índices

---

## Tabela: func_trab_extra_ptoelet
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_proces_mpe

### Índices
- **fnctrbxt_tm05202**: log_marcac_ptoelet_tratada

---

## Tabela: func_treindo_cipa
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_mandat_cipa, cdn_trein_cipa, dat_trein_cipa, cdn_funcionario

### Índices

---

## Tabela: func_turno_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_lotac_func_turno_trab

### Índices
- **fnctrntr_py21801**: cdn_turno_trab, cdn_turma_trab, dat_term_lotac_func
- **fnctrntr_py21803**: cdn_empresa, cdn_estab, cdn_funcionario, cdn_turno_trab, cdn_turma_trab

---

## Tabela: func_unid_lotac_plano
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_plano_lotac, cod_unid_lotac, cdn_funcionario, dat_inic_lotac_func

### Índices
- **fncndltc_fimlotac**: cdn_plano_lotac, cdn_funcionario, dat_fim_lotac_func
- **fncndltc_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_lotac_func
- **fncndltc_plndprts**: cdn_empresa, cdn_estab, cdn_plano_lotac, dat_inic_valid
- **fncndltc_undltcpl**: cdn_plano_lotac, cod_unid_lotac

---

## Tabela: func_vacina
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_vacina, num_ficha_medic, dat_programac_vacina

### Índices
- **fncvcn_fcn**: cdn_empresa, cdn_estab, cdn_funcionario

---

## Tabela: funcao_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_funcao_equipe_ambntal

### Índices

---

## Tabela: funcao_brigdsta
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_funcao_brigdsta

### Índices

---

## Tabela: funcao_cipa
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_funcao_cipa

### Índices

---

## Tabela: funcao_cipa_sind
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_funcao_cipa_sind

### Índices
- **fnccpsnd_py08702**: cdn_motiv_estabil_func

---

## Tabela: funcao_disposit_aces
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_planta_edificio, cdn_disposit_control_aces, cod_funcao_disposit_aces

### Índices

---

## Tabela: funcao_func_cipa
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_funcao_cipa_sind, dat_inic_cipa

### Índices
- **fncfnccp_py08602**: cdn_funcao_cipa_sind

---

## Tabela: funcao_func_sind
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_funcao_cipa_sind, dat_inic_func_sind

### Índices
- **fncfncsn_py08901**: cdn_funcao_cipa_sind
- **fncfncsn_py08903**: cdn_empresa, cdn_sindicato
- **fncfncsn_sndstb**: cdn_empresa, cdn_estab, cdn_sindicato

---

## Tabela: funcao_local_marcac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_local_marcac_cartao_pto, cod_funcao_relogio_pto

### Índices

---

## Tabela: funcao_marcac_ptoelet
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_funcao_relogio_pto

### Índices

---

## Tabela: funcao_perf_profis
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_funcao_perf_profis

### Índices

---

## Tabela: funcao_tip_refei
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_tip_refei, cod_funcao_relogio_pto

### Índices

---

## Tabela: funcionario
**Label**: Saldo Hrs Compensa��o
**Descrição**: NOME?

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario

### Índices
- **fncnr_calculo**: cdn_empresa, cdn_estab, cdn_categ_sal, cdn_turno_trab, cdn_turma_trab, cod_pais_localid, cdn_localidade, cdn_sindicato, idi_orig_contratac_func, cdn_prestdor_serv, cdn_sit_calc_func, cdn_funcionario
- **fncnr_catmdo**: cdn_empresa, cdn_estab, cdn_categ_sal, idi_orig_contratac_func, cdn_prestdor_serv, dat_admis_func
- **fncnr_empctpto**: cdn_empresa, num_cartao_pto
- **fncnr_empfunc**: cdn_empresa, idi_orig_contratac_func, cdn_prestdor_serv, cdn_funcionario
- **fncnr_empidfeder**: cdn_empresa, cdn_estab, cod_id_feder, dat_desligto_func
- **fncnr_empnome**: cdn_empresa, cdn_estab, nom_pessoa_fisic
- **fncnr_emppessoa**: cdn_empresa, cdn_estab, num_pessoa_fisic
- **fncnr_epm**: log_carg_epm
- **fncnr_idcontrato**: cdn_empresa, cdn_estab, cdn_sit_calc_func, cdn_func_centrdor, cdn_tip_contrat_func
- **fncnr_idfdemp**: cod_id_feder, cdn_empresa, dat_desligto_func
- **fncnr_idfederemp**: cod_id_feder, cdn_empresa, cdn_estab
- **fncnr_infpto**: cdn_empresa, cdn_sit_calc_func, cdn_clas_func
- **fncnr_lclmrccp**: cdn_empresa, cdn_local_marcac_cartao_pto
- **fncnr_localid**: cod_pais_localid, cdn_localidade
- **fncnr_matr**: idi_orig_contratac_func, cdn_prestdor_serv, cdn_funcionario
- **fncnr_matrbase**: cdn_funcionario
- **fncnr_matremp**: cdn_empresa, cdn_funcionario
- **fncnr_nivcargo**: cdn_cargo_basic, cdn_niv_cargo
- **fncnr_nome**: cdn_empresa, nom_pessoa_fisic
- **fncnr_nomnasc**: nom_pessoa_fisic, dat_nascimento
- **fncnr_orgmdstb**: cdn_empresa, cdn_estab, idi_orig_contratac_func, cdn_prestdor_serv, dat_inic_valid, cdn_funcionario
- **fncnr_orig_contr**: cdn_empresa, cdn_estab, idi_orig_contratac_func, cdn_prestdor_serv, cdn_funcionario
- **fncnr_pessoaemp**: num_pessoa_fisic, cdn_empresa, cdn_estab
- **fncnr_py08501**: cdn_empresa, cdn_bco_liq, cdn_agenc_bcia_liq
- **fncnr_py08502**: cdn_empresa, cdn_estab, cdn_categ_sal, cdn_turno_trab, cdn_turma_trab, cdn_sindicato, idi_orig_contratac_func, cdn_prestdor_serv, cdn_sit_calc_func, cdn_funcionario
- **fncnr_py08503**: cdn_empresa, cdn_estab, num_cartao_pto
- **fncnr_py08504**: cdn_empresa, cdn_estab, cdn_categ_sal, cdn_funcionario
- **fncnr_py08505**: cdn_empresa, cdn_estab, cdn_categ_sal, nom_abrev_pessoa_fisic, cdn_funcionario
- **fncnr_py08506**: cdn_clas_func, cdn_empresa, cdn_estab, cdn_categ_sal
- **fncnr_py08507**: cdn_empresa, cod_rh_ccusto, cdn_estab, nom_abrev_pessoa_fisic, cdn_funcionario
- **fncnr_py08508**: cdn_empresa, cod_rh_ccusto, cdn_estab, cdn_funcionario
- **fncnr_py08513**: cdn_empresa, nom_abrev_pessoa_fisic, cdn_funcionario
- **fncnr_py08514**: cod_unid_federac_rh
- **fncnr_py08515**: cdn_empresa, cdn_estab, nom_abrev_pessoa_fisic, cdn_funcionario
- **fncnr_py08516**: cdn_empresa, cdn_sindicato, cdn_estab, cdn_categ_sal, cdn_turno_trab, cdn_funcionario
- **fncnr_py08517**: cdn_empresa, cdn_cargo_basic, cdn_niv_cargo
- **fncnr_py08520**: cod_tip_mdo
- **fncnr_py08524**: cdn_empresa, cdn_sindicato, cdn_funcionario
- **fncnr_py08525**: cdn_empresa, cdn_estab, cdn_sit_calc_func, cdn_categ_sal, cdn_funcionario
- **fncnr_py08527**: cdn_empresa, cdn_categ_sal, cdn_tab_sal, num_faixa_sal, cdn_funcionario
- **fncnr_py08528**: cdn_turma_trab
- **fncnr_py08529**: cdn_empresa, cdn_estab, cdn_categ_sal, cdn_turno_trab, cdn_funcionario
- **fncnr_py08530**: cod_pis, num_pessoa_fisic
- **fncnr_pyndfdrc**: cod_pais, cod_unid_federac_rh
- **fncnr_regfunc**: cdn_empresa, cdn_estab, num_reg_func
- **fncnr_rhgncbc**: cdn_bco_liq, cdn_agenc_bcia_liq
- **fncnr_rhndfdrc**: cod_pais, cod_unid_federac_empres_ant
- **fncnr_sitcalcfunc**: cdn_empresa, cdn_estab, cdn_sit_calc_func, cdn_funcionario
- **fncnr_tpcntrt**: cdn_tip_contrat_func
- **fncnr_trmtrb**: cdn_turno_trab, cdn_turma_trab
- **fncnr_undep**: cdn_empresa, cdn_estab, cdn_plano_lotac, cod_unid_lotac, cdn_funcionario
- **fncnr_undepnom**: cdn_empresa, cdn_estab, cdn_plano_lotac, cod_unid_lotac, nom_abrev_pessoa_fisic, cdn_funcionario
- **fncnr_undltcpl**: cdn_plano_lotac, cod_unid_lotac
- **fncnr_usaturno**: cdn_turno_trab, cdn_empresa, cdn_estab, cdn_categ_sal, cdn_sit_calc_func, log_consid_carg_turno_trab
- **fncnr_vncmprgt**: cdn_vinc_empregat

---

## Tabela: gera_arq_export
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_arq_export

### Índices

---

## Tabela: gera_arq_export_classif
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_arq_export, nom_tab_atrib, num_seq_classif

### Índices

---

## Tabela: gera_arq_export_det
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_arq_export, idi_refer_det, nom_tab_atrib_classif, num_seq_lin_det, num_seq_compos_lin

### Índices

---

## Tabela: gera_arq_export_sel
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_arq_export, nom_atrib_base_sel

### Índices

---

## Tabela: gera_arq_export_tab_aux
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_arq_export, nom_tab_aux, nom_tab_atrib_classif, idi_refer_tab_aux, num_seq_refer_tab_aux, num_niv_refer_tab_aux, num_seq_cond

### Índices

---

## Tabela: gera_arq_export_var
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_arq_export, cod_var_trab

### Índices

---

## Tabela: grade_respos
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_grade_respos

### Índices

---

## Tabela: grade_respos_test
**Label**: Nota Inicial
**Descrição**: Valor Nota In�cio Grade Resposta

### Chave Primária
- cdn_grade_respos, val_nota_inic_grade_respos

### Índices

---

## Tabela: grau_depend_estab_benefic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_beneficio, cdn_grau_depend_func

### Índices

---

## Tabela: grau_instruc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_grau_instruc

### Índices

---

## Tabela: grp_adc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_grp_adc

### Índices

---

## Tabela: grp_adc_event
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_grp_adc, cdn_event_fp

### Índices

---

## Tabela: grp_ativid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_ativid, cdn_empresa, cdn_estab, cod_ativid_func

### Índices
- **grptvd_ativid**: cdn_empresa, cdn_estab, cod_ativid_func

---

## Tabela: grp_ativid_entid_educnal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_grp_ativid_entid_educnal

### Índices

---

## Tabela: grp_ativid_entid_relacto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_ativid_entid_educnal, cdn_grp_ativid_entid_educnal

### Índices
- **grptvdna_grptvdnt**: cdn_grp_ativid_entid_educnal

---

## Tabela: grp_atrib_dados
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_atrib_dados

### Índices

---

## Tabela: grp_avaliac_pontuac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_grp_avaliac_pontuac

### Índices
- **grpvlcpn_seq**: num_seq_calc_avaliac_pontuac

---

## Tabela: grp_avaliac_pos
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_grp_avaliac_pos

### Índices

---

## Tabela: grp_benefic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_grp_benefic

### Índices

---

## Tabela: grp_calc
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_grp_calc

### Índices

---

## Tabela: grp_calc_colab
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_grp_calc, dat_inic_valid

### Índices

---

## Tabela: grp_calc_desatualiz
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_grp_calc

### Índices

---

## Tabela: grp_calc_regra
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_grp_calc, num_grp_calc_verba

### Índices

---

## Tabela: grp_calc_verba
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, idi_utiliz_grp_calc, cdn_tip_calc_verba, cdn_grp_calc, cod_verba_calc, cod_beneficio, cdn_regra_benefic, dat_inic_valid

### Índices
- **grpclcvr_fm**: cdn_empresa, idi_utiliz_grp_calc, cod_formul_calc_verba
- **grpclcvr_vr**: cdn_empresa, idi_utiliz_grp_calc, cdn_tip_calc_verba, cdn_grp_calc, dat_inic_valid, dat_term_valid

---

## Tabela: grp_cargo_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_grp_cargo

### Índices

---

## Tabela: grp_ccusto_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_grp_ccusto_orcto

### Índices

---

## Tabela: grp_cid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_clas_cid, cod_grp_cid

### Índices

---

## Tabela: grp_conhecto_experien_profis
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_grp_conhecto_experien

### Índices

---

## Tabela: grp_descr_cargo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_cargo, cdn_tip_descr_cargo

### Índices
- **grpdscrc_tpdscrcr**: cdn_tip_descr_cargo

---

## Tabela: grp_docto_estab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_grp_docto, cdn_estab

### Índices

---

## Tabela: grp_docto_model
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_grp_docto, cdn_modelo

### Índices

---

## Tabela: grp_event
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_grp_event

### Índices

---

## Tabela: grp_event_fp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_grp_event, cdn_event_fp

### Índices

---

## Tabela: grp_event_movto
**Label**: Perc Variac M�s Ant
**Descrição**: Valor Varia��o M�s Anterior

### Chave Primária
- cdn_grp_event, cdn_empresa, cdn_estab, cdn_funcionario

### Índices
- **grpvntmv_des**: des_grp_event
- **grpvntmv_func**: cdn_empresa, cdn_estab, cdn_funcionario, cdn_grp_event

---

## Tabela: grp_event_movto_tot
**Label**: Perc Variac M�s Ant
**Descrição**: Valor Varia��o M�s Anterior

### Chave Primária
- idi_tip_tot, cdn_empresa, cdn_estab, cdn_plano_lotac, cod_unid_lotac, cod_rh_ccusto, cdn_turma_trab, cdn_turno_trab, cdn_categ_sal, cod_pais_localid, cdn_localidade, cdn_sindicato, cdn_grp_event

### Índices

---

## Tabela: grp_event_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_grp_event_orcto

### Índices

---

## Tabela: grp_exam_medic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_exam_medic

### Índices

---

## Tabela: grp_impto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_impto

### Índices

---

## Tabela: grp_inform_calc
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_grp_inform_calc

### Índices

---

## Tabela: grp_inform_calc_det
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cod_grp_inform_calc, cod_inform_calc, idi_tip_sit_afast_inform, dat_inic_valid

### Índices

---

## Tabela: grp_item_exam
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_item_exam

### Índices

---

## Tabela: grp_item_exam_medic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_item_exam, cod_item_exam_medic

### Índices
- **grptmxmm_itmxmmdc**: cod_item_exam_medic

---

## Tabela: grp_mail
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_mail

### Índices

---

## Tabela: grp_mail_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_mail, num_pessoa_fisic

### Índices

---

## Tabela: grp_meio_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_meio_ambntal

### Índices

---

## Tabela: grp_pagto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_grp_pagto

### Índices

---

## Tabela: grp_pca
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_pca

### Índices

---

## Tabela: grp_pca_curso_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_pca, cdn_curso_trein

### Índices

---

## Tabela: grp_pca_vacina
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_pca, cod_vacina

### Índices

---

## Tabela: grp_propried_agric
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_grp_propried_agric

### Índices

---

## Tabela: grp_risco
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_riscacid

### Índices

---

## Tabela: grp_sub_grp_ccusto_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_grp_ccusto_orcto, cdn_sub_grp_ccusto_orcto, cdn_empresa, cod_rh_ccusto

### Índices

---

## Tabela: grp_terc_ptoelet
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_grp_terc_ptoelet

### Índices

---

## Tabela: grp_tip_calc_verba
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_tip_calc_verba, cdn_grp_calc

### Índices

---

## Tabela: grp_turno_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_grp_turno_orcto

### Índices

---

## Tabela: grp_usuar_aces
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_usuar_aces

### Índices

---

## Tabela: grps_form_contin
**Label**: Total Recolhimento
**Descrição**: Total recolhimento

### Chave Primária
- cdn_empresa, cdn_clien_rh, cdn_fpas, cdn_estab, cdn_plano_lotac, cod_unid_lotac, cdn_tip_guia_iapas, idi_mes_base_acordo_coletiv, num_ano_refer_grps, num_seq_grps_form_contin

### Índices
- **grpsfrmc_rhestab**: cdn_empresa, cdn_estab

---

## Tabela: guia_encargo
**Label**: Recolhe Sobre Outros
**Descrição**: Valor a recolher sobre outros

### Chave Primária
- cdn_empresa, cdn_clien_rh, cdn_fpas, cdn_estab, cdn_plano_lotac, cod_unid_lotac, num_mes_ano_guia_inss, idi_tip_guia_encargo_social, cdn_encargo, num_seq_guia_rat_encargo, idi_origem

### Índices
- **gncrg_py09502**: cdn_empresa, cdn_estab, num_ano_refer_grps, num_mes_ano_guia_inss, idi_tip_guia_encargo_social, cdn_encargo, num_seq_guia_rat_encargo

---

## Tabela: guia_prestdor_serv
**Label**: Valor Recolhimento
**Descrição**: Valor do recolhimento

### Chave Primária
- cdn_empresa, cdn_estab, cdn_plano_lotac, cod_unid_lotac, cdn_orig_inform_grps, cod_cpf_cgc, cod_rh_ccusto, cod_tip_mdo

### Índices
- **gprstdrs_py16501**: cdn_empresa, cod_rh_ccusto, cdn_estab, cdn_orig_inform_grps

---

## Tabela: habcomp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_habcomp

### Índices
- **habcomp_hbcmpblc**: cdn_bloco_qualific_habcomp
- **habcomp_hbcmpcls**: cdn_habcomp_clas
- **habcomp_hbcmpntr**: cdn_habcomp_natur

---

## Tabela: habcomp_aperfmto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_aperfmto

### Índices

---

## Tabela: habcomp_bloco_qualific
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_bloco_qualific_habcomp

### Índices

---

## Tabela: habcomp_candidato
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_candempr, cdn_habcomp, cdn_proficiencia

### Índices
- **hbcmpcnd_hbcmpprf**: cdn_habcomp, cdn_proficiencia
- **hbcmpcnd_prfcnc**: cdn_proficiencia

---

## Tabela: habcomp_clas
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_habcomp_clas

### Índices

---

## Tabela: habcomp_grp_conhecto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_habcomp, cdn_proficiencia, cdn_empresa, cdn_grp_conhecto_experien

### Índices
- **hbcmpgrp_cnhctxpr**: cdn_empresa, cdn_grp_conhecto_experien

---

## Tabela: habcomp_item_reqdo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_habcomp, cdn_proficiencia, cdn_item_reqdo

### Índices
- **hbcmptmr_itmrqd**: cdn_item_reqdo

---

## Tabela: habcomp_natur
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_habcomp_natur

### Índices

---

## Tabela: habcomp_pessoa_fisic
**Label**: Pontua��o Recebida
**Descrição**: Valor Pontua��o Recebida

### Chave Primária
- num_pessoa_fisic, cdn_habcomp

### Índices
- **hbcmppss_hbcmpprf**: cdn_habcomp, cdn_proficiencia
- **hbcmppss_jurid**: num_pessoa_jurid

---

## Tabela: habcomp_profncia
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_habcomp, cdn_proficiencia

### Índices
- **hbcmpprf_prfcnc**: cdn_proficiencia

---

## Tabela: habcomp_profncia_pre_requis
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_cargo_basic, cdn_niv_cargo, cdn_plano_lotac, cod_unid_lotac, cdn_habcomp, cdn_proficiencia, num_seq_pre_requis_profncia

### Índices
- **hbcmppra_crstrn**: cdn_curso_trein
- **hbcmppra_hbcmpprb**: cdn_aperfmto

---

## Tabela: habcomp_respons
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_respons

### Índices

---

## Tabela: habilid_profis
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_habilid_profis

### Índices
- **hbldprfs_01601**: cod_entid_clas_profis

---

## Tabela: habilid_profis_candempr
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_candempr, cdn_habilid_profis

### Índices
- **hbldprfa_hbldprfs**: cdn_habilid_profis
- **hbldprfa_rhndfdrc**: cod_pais, cod_unid_federac_rh

---

## Tabela: habilid_profis_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_habilid_profis, cod_unid_federac_rh

### Índices
- **hbldpcfs_py09701**: cdn_habilid_profis
- **hbldpcfs_pyndfdrc**: cod_pais, cod_unid_federac_rh

---

## Tabela: habilit_calc_fp
**Label**: Perc Adiantamento
**Descrição**: Percentual de adiantamento a ser concedido

### Chave Primária
- cdn_empresa, cdn_estab, cdn_categ_sal, num_ano_refer_fp_calcula, num_mes_refer_fp_calcula, num_seq_calc_fp

### Índices
- **hbltclcf_empmes**: cdn_empresa, cdn_categ_sal, num_ano_refer_fp_calcula, num_mes_refer_fp_calcula
- **hbltclcf_py04001_seg**: idi_tip_fp, num_seq_calc_fp, num_mes_refer_fp_calcula, num_ano_refer_fp_calcula
- **hbltclcf_py04002**: cdn_empresa, cdn_estab, cdn_categ_sal, idi_orig_contratac_func, cdn_prestdor_serv, idi_tip_fp, num_ano_refer_fp_calcula, num_mes_refer_fp_calcula, qti_parc_habilit_calc_fp

---

## Tabela: habilit_calc_ppr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_param_calc_ppr, cdn_empresa, cdn_estab, cdn_categ_sal, num_mes_refer_calc_efetd, num_ano_refer_calc_efetd, idi_tip_folha_pagto_ppr, qti_parc_habilit_calc_fp

### Índices

---

## Tabela: habilit_ferias
**Label**: Perc Adiant 13��
**Descrição**: Percentual de adiantamento do 13�� salǭrio

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_period_aqst_ferias, dat_inic_ferias

### Índices
- **hbltfrs_dtcons**: cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_concess_ferias, dat_term_concess_ferias
- **hbltfrs_fncsmfrs**: cdn_empresa, cdn_estab, cod_programac_ferias_coletiv
- **hbltfrs_prmfrscl**: cod_programac_ferias_coletiv
- **hbltfrs_py07901**: cdn_empresa, dat_inic_ferias, cdn_estab, cdn_funcionario
- **hbltfrs_py07903**: cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_ferias
- **hbltfrs_slfncsmf**: cdn_empresa, cod_programac_ferias_coletiv

---

## Tabela: habilit_ferias_simul
**Label**: Perc Adiant 13�
**Descrição**: Percentual de adiantamento do 13� sal�rio

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_period_aqst_ferias, dat_inic_ferias

### Índices
- **hbltfrss_dtini**: cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_ferias
- **hbltfrss_empini**: cdn_empresa, dat_inic_ferias, cdn_estab, cdn_funcionario

---

## Tabela: habilit_gerac_func_pagto_pis
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cgc_atual, num_ord_digito_cgc_atual, cod_bco_agenc_bcia_pis

### Índices
- **hbltgrcf_py14301**: cod_cgc_atual, num_ord_digito_cgc_atual, cod_agenc_bcia_altern_pis

---

## Tabela: habilit_rescis
**Label**: Saldo Empr�stimo Consignado
**Descrição**: Valor Saldo Empr�stimo Consignado

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario

### Índices
- **hbltrscs_py15101**: cdn_empresa, dat_desligto_func, cdn_estab, cdn_funcionario

---

## Tabela: hext_cargo_planilha_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq_planilha_orcto, num_seq_variac_cargo_planilha, cdn_event_orcto

### Índices

---

## Tabela: histor_alter_dirf
**Label**: Vl Resto PrevPriv
**Descrição**: Valor resto previd�ncia privada

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_ano_refer_inform_dirf, idi_tip_inform_dirf, dat_alter_dirf, hra_alter_dirf, num_seq_alter_dirf

### Índices

---

## Tabela: histor_alter_efp
**Label**: Valor Unit�rio
**Descrição**: Valor unit�rio da unidade

### Chave Primária
- cdn_empresa, cdn_event_fp, dat_inic_valid, num_seq_alter_event

### Índices
- **hstrltrf_data**: cdn_empresa, cdn_event_fp, dat_inic_valid, dat_term_valid, num_seq_alter_event

---

## Tabela: histor_alter_planilha_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq_planilha_orcto, cdn_vers_planilha, dat_alter_planilha, cod_tip_motiv_alter_planilha

### Índices

---

## Tabela: histor_ambien_trab_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_plano_lotac, cod_unid_lotac, cdn_cargo_basic, cod_ativid_func, dat_inic_func_ambien_trab

### Índices
- **hstrmbnt_ativid**: cod_ativid_func
- **hstrmbnt_atvdfnc**: cdn_empresa, cdn_estab, cod_ativid_func
- **hstrmbnt_crgbsc**: cdn_cargo_basic
- **hstrmbnt_plnltc**: cdn_plano_lotac
- **hstrmbnt_undltc**: cod_unid_lotac

---

## Tabela: histor_atualiz_norma
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_norma_ambntal, dat_emis_norma, dat_nova_emis

### Índices

---

## Tabela: histor_avaliac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_avaliac_trein, dat_refer

### Índices

---

## Tabela: histor_benefic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_ano_refer_fp, num_mes_lote_movto_benefic, num_seq_movto_benefic

### Índices

---

## Tabela: histor_bloq_aces
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_usuar_control_aces, dat_inic_aces_bloqdo, num_seq

### Índices

---

## Tabela: histor_bolsa_estudo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_bolsa_estudo, dat_refer

### Índices

---

## Tabela: histor_bolsista
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_bolsa_estudo, cdn_curso_trein, cdn_bolsista, dat_refer

### Índices

---

## Tabela: histor_calcul
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_ano_refer_fp, num_mes_refer_fp, idi_tip_fp, qti_parc_habilit_calc_fp, nom_tab, num_seq

### Índices

---

## Tabela: histor_candidato_etap
**Label**: Nota Etapa
**Descrição**: Valor Nota Etapa Teste Candidato Emprego

### Chave Primária
- cdn_candempr, cdn_etap_sel_candempr, cdn_cargo_basic, cdn_niv_cargo, dat_etap_sel_candempr

### Índices

---

## Tabela: histor_candidato_inter
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empres_func_candempr, cdn_estab_func_candempr, cdn_funcionario, dat_gerac_histor

### Índices

---

## Tabela: histor_candidato_pre_selec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_req_pessoal, cdn_candempr, dat_gerac_histor

### Índices
- **hstrcnda_cnddtxt**: cdn_candempr

---

## Tabela: histor_cargo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, nom_campo_altdo, dat_alter_cargo, hra_alter_cargo

### Índices

---

## Tabela: histor_comptcia_nao_recolhid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_estab, cdn_funcionario, num_mes_refer, num_ano_refer

### Índices

---

## Tabela: histor_contrat_func_temp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_contrat_func_temp

### Índices

---

## Tabela: histor_contrib_sindic_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_ano_refer_contrib_sindic, num_mes_refer_contrib_sindic

### Índices
- **hstrcntr_py09902**: cdn_empresa, cdn_sindicato
- **hstrcntr_sndstb**: cdn_empresa, cdn_estab, cdn_sindicato

---

## Tabela: histor_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_histor_ctbl

### Índices

---

## Tabela: histor_det_remun_var_func
**Label**: Valor Rmunera��o
**Descrição**: Valor Remunera��o Vari�vel

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_liber_sal, num_seq_histor_sal, cdn_motiv_liber_sal, cdn_remun_var, num_seq

### Índices

---

## Tabela: histor_faixa_evoluc_sal
**Label**: Sal Inicial Cargo
**Descrição**: Sal�rio Inicial Cargo

### Chave Primária
- cdn_empresa, cdn_tab_sal, dat_tab_vigent, qtd_pto_inic_cargo, num_seq_faixa_evoluc

### Índices

---

## Tabela: histor_fasb_cmcac_fp
**Label**: Valor
**Descrição**: Valor

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, idi_efp_encargo_fasb, num_refer_efp_encargo_fasb, cod_rh_ccusto_cr, cod_rh_cta_ctbl_cr, cod_rh_ccusto_db, cod_rh_cta_ctbl_db, idi_tip_val_ctbl_fasb_cmcac_fp

### Índices
- **hstrfsbc_py07301**: cdn_empresa, cod_rh_ccusto_db, cod_rh_cta_ctbl_db, idi_efp_encargo_fasb, num_refer_efp_encargo_fasb, cod_rh_ccusto_cr, cod_rh_cta_ctbl_cr
- **hstrfsbc_py07302**: cdn_empresa, cod_rh_ccusto_cr, cod_rh_cta_ctbl_cr, idi_efp_encargo_fasb, num_refer_efp_encargo_fasb, cod_rh_ccusto_db, cod_rh_cta_ctbl_db
- **hstrfsbc_py07304**: cdn_empresa, cdn_estab, cdn_funcionario, num_ano_lancto_ctbl_fasb_cmcac, num_mes_lancto_fp_fasb_cmcac

---

## Tabela: histor_fgts_inss
**Label**: Percentual SAT
**Descrição**: Valor Percentual Seguro acidente trabalho

### Chave Primária
- cdn_empresa, cdn_estab, dat_inic_vigenc

### Índices

---

## Tabela: histor_func
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, idi_tip_histor, num_seq_alter_histor, dat_alter_histor, hra_alter_histor

### Índices

---

## Tabela: histor_func_habcomp
**Label**: Pontua��o Recebida
**Descrição**: Valor Pontua��o Recebida

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_habcomp, dat_alter_habcomp, cdn_proficiencia

### Índices
- **hstrfnch_hbcmpprf**: cdn_habcomp, cdn_proficiencia

---

## Tabela: histor_gps
**Label**: Valor Percentual Desonera��o D
**Descrição**: Valor Percentual Desonera��o D�cimo Terceiro

### Chave Primária
- cdn_empresa, cdn_estab, cdn_tomador_serv, num_mes_refer, num_ano_refer

### Índices

---

## Tabela: histor_instrut_turma
**Label**: Percentual Freq
**Descrição**: Valor Percentual de Freq��ncia

### Chave Primária
- cdn_curso_trein, cdn_turma_trein, cdn_instrutor, dat_refer

### Índices
- **hstrnstr_instrttr**: cdn_instrutor

---

## Tabela: histor_licenc_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_licenc_ambntal, cod_orgao_emissor_notif, dat_emis_licenc, dat_histor_licenc, cod_condic_ambntal, cdn_empresa, hra_histor_licenc

### Índices
- **hstrlcnc_cndclcnc**: cod_licenc_ambntal, cod_orgao_emissor_notif, dat_emis_licenc, cod_condic_ambntal, cdn_empresa

---

## Tabela: histor_local_turma_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_curso_trein, cdn_turma_trein, cdn_instit_trein, cdn_local_trein, dat_refer

### Índices

---

## Tabela: histor_lotac_tomador_serv
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_clien_rh, cod_unid_lotac, dat_inic_valid

### Índices

---

## Tabela: histor_lote_ctbl_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, num_mes_refer, num_ano_refer

### Índices

---

## Tabela: histor_medic_segur_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_plano_lotac, cod_unid_lotac, num_ano_estatis_medic_segur, num_mes_estatis_medic_segur

### Índices

---

## Tabela: histor_movto_agric_det
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, num_seq_movto_agric

### Índices

---

## Tabela: histor_pagto_palim
**Label**: Perc Benef�cio PLR
**Descrição**: Valor Percentual Pens�o Aliment�cia PLR

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_bnfciar_palim, num_ano_refer_histor_palim, num_mes_refer_histor_palim, idi_tip_calc_palim, num_seq_histor_mes, num_seq_movto

### Índices
- **hstrpgtp_seqmv**: cdn_empresa, cdn_estab, cdn_funcionario, cdn_bnfciar_palim, num_seq_movto

---

## Tabela: histor_pagto_palim_diss
**Label**: Valor Pens�o Alim Diferen�a RR
**Descrição**: Valor Pens�o Alim Diferen�a RRA

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_bnfciar_palim, num_ano_refer_histor_palim, num_mes_refer_histor_palim, idi_tip_calc_palim, num_ano_dif_histor_palim, num_mes_dif_histor_palim, num_seq_histor_mes, num_seq_movto

### Índices
- **hstrpgtpdiss-ix2**: cdn_empresa, cdn_estab, cdn_funcionario, cdn_bnfciar_palim, num_seq_movto

---

## Tabela: histor_proj_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_proj_ambntal, dat_movto_proj_ambntal, num_seq_histor_proj

### Índices

---

## Tabela: histor_reaj_event_orcto
**Label**: Val Reajuste
**Descrição**: Valor Reajuste Evento Orcamento

### Chave Primária
- num_seq_reaj_event_orcto

### Índices
- **hstrrjvn_evt**: cdn_empresa, idi_tip_event_orcto, cdn_vers_planilha, cdn_event_orcto
- **hstrrjvn_sndct**: cdn_sindicato
- **hstrrjvn_trntrb**: cdn_turno_trab

---

## Tabela: histor_remun_var_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_liber_sal, num_seq_histor_sal, cdn_motiv_liber_sal

### Índices

---

## Tabela: histor_reprovac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_candempr, cdn_req_pessoal, cdn_etap_sel_candempr

### Índices
- **hstrrprv_rqpssl**: cdn_empresa, cdn_estab, cdn_req_pessoal

---

## Tabela: histor_req_candidato_etap
**Label**: Nota Etapa
**Descrição**: Valor Nota Etapa Teste Candidato Emprego

### Chave Primária
- cdn_empresa, cdn_estab, cdn_req_pessoal, cdn_candempr, cdn_etap_sel_candempr, dat_gerac_histor

### Índices
- **hstrrqcn_cnddtxt**: cdn_candempr
- **hstrrqcn_etpprcss**: cdn_etap_sel_candempr
- **hstrrqcn_tptpslcn**: cdn_tip_etap_sel_candempr

---

## Tabela: histor_req_pessoal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_req_pessoal, dat_gerac_histor

### Índices

---

## Tabela: histor_ressmto_passiv
**Label**: Valor Ressarcir
**Descrição**: Valor Solicita��o Ressarcimento

### Chave Primária
- cdn_empresa, cod_passiv_ambntal, cod_obj_gerador_acidte, idi_tip_pessoa, num_pessoa, dat_solicit_ressmto

### Índices
- **hstrrssm_eqpmbntl**: cod_equipe_ambntal

---

## Tabela: histor_sal_func
**Label**: Sal�rio Mensal
**Descrição**: Valor do sal�rio padr�o do m�s

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_liber_sal, num_seq_histor_sal, cdn_motiv_liber_sal

### Índices
- **hstrslfn_cargo**: cdn_cargo_basic, cdn_niv_cargo
- **hstrslfn_py10201**: cdn_empresa, cdn_cargo_basic, cdn_niv_cargo
- **hstrslfn_py10203**: cdn_motiv_liber_sal
- **hstrslfn_tip**: cdn_empresa, cdn_estab, cdn_funcionario, idi_tip_cargo_funcao, dat_liber_sal, num_seq_histor_sal

---

## Tabela: histor_sefip
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_tomador_serv, num_mes_refer, num_ano_refer

### Índices

---

## Tabela: histor_solicit_adiant_13o
**Label**: Perc Adto 13� Concedido
**Descrição**: Valor - Inteiro Percentual Adiantamento D�cimo Terceiro Concedido

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_ano_refer_fp

### Índices

---

## Tabela: histor_tab_sal_mes
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_tab_sal, dat_tab_vigent

### Índices

---

## Tabela: histor_tab_sal_remun
**Label**: Sal Pto M�dio
**Descrição**: Valor Sal�rio Ponto M�dio

### Chave Primária
- cdn_empresa, cdn_tab_sal, dat_tab_vigent, qtd_pto_inic_cargo

### Índices

---

## Tabela: histor_tit_pagto
**Label**: Valor T�tulo
**Descrição**: Valor Titulo Pagamento

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_ano_refer, num_mes_refer, idi_proces_orig, idi_tip_fp, qtd_parcela

### Índices
- **hstrttpg_numtit**: cdn_empresa, num_tit_pagto

---

## Tabela: histor_treindo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_curso_trein, cdn_turma_trein, cdn_treindo, dat_refer

### Índices

---

## Tabela: histor_utiliz_media_adc
**Label**: Resultado Valor
**Descrição**: Valor Resultado Valor

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_grp_adc, idi_tip_calc_adc, qti_parc_calc_adc, dat_calc_adc, idi_tip_media_adc, dat_inic_period_aqst_ferias

### Índices

---

## Tabela: histor_val_calc_palim
**Label**: Valor Tot IRF Pens�o Normal
**Descrição**: Valor total de IRF para c�lculo de pens�o normal

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_bnfciar_palim, num_ano_refer_calc_palim, num_mes_refer_calc_palim

### Índices

---

## Tabela: histor_val_grps
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_clien_rh, num_mes_refer, num_ano_refer

### Índices
- **hstrvlgr_rhclien**: cdn_empresa, cdn_clien_rh

---

## Tabela: histor_variac_sal_ferias
**Label**: Varia��o Salarial
**Descrição**: Valor da varia��o salarial do evento

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_ferias, cdn_tip_calc_ferias, num_seq_histor_ferias

### Índices

---

## Tabela: histor_variac_sal_fp
**Label**: Varia��o Salarial
**Descrição**: Valor da varia��o salarial do evento

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_ano_refer_fp, num_mes_refer_fp, cdn_tip_fp, qti_parc_habilit_calc_fp, num_seq_movto_calcul_fp

### Índices

---

## Tabela: histor_variac_sal_rescis
**Label**: Varia��o Salarial
**Descrição**: Valor da varia��o salarial do evento

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_tip_calc_rescis, num_seq_movto_calcul_fp

### Índices

---

## Tabela: horar_atendim_medic
**Label**: T�rmino Segundo Per�odo
**Descrição**: T�rmino Atendimento Segundo Per�odo

### Chave Primária
- num_horar_turno_trab

### Índices

---

## Tabela: horar_dia_turma_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_curso_trein, cdn_turma_trein, dat_aula_turma_trein, hra_inic_period

### Índices

---

## Tabela: horar_jorn_trab_ptoelet
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_clas_func, cdn_empresa, cdn_estab, cdn_categ_sal, cdn_turno_trab, cdn_jorn_trab, cdn_interv_refei, cdn_funcionario, dat_alter_jorn_trab

### Índices
- **hrrjrntc_func**: cdn_empresa, cdn_estab, cdn_funcionario, dat_alter_jorn_trab
- **hrrjrntc_tm03802**: cdn_jorn_trab, cdn_interv_refei
- **hrrjrntc_turno**: cdn_turno_trab

---

## Tabela: hrs_extra_projec_sal
**Label**: Perc Hrs Extras Proj
**Descrição**: Percentual Horas Extras Proje��o

### Chave Primária
- cdn_empresa, cdn_estab, cdn_categ_sal

### Índices

---

## Tabela: ident_norma_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_ident_norma_ambntal

### Índices

---

## Tabela: ident_tip_turma_educnal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_turma_educnal

### Índices

---

## Tabela: idiom_pessoa_fisic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_pessoa_fisic, cod_idioma

### Índices
- **idmpssfs_prfcnc**: cdn_proficiencia

---

## Tabela: idx_control_biolog
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_exam_medic

### Índices

---

## Tabela: idx_efp_espcif_ferias
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_idx_efp_espcif_ferias

### Índices
- **idxfpspc_py07101**: cdn_efp_compltac
- **idxfpspc_py07102**: cdn_event_fp

---

## Tabela: idx_efp_espcif_rescis
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_idx_efp_espcif_rescis

### Índices
- **idxbpspc_py07201**: cdn_efp_idx_infor

---

## Tabela: idx_efp_funcao_espcif
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_idx_efp_funcao_espcif

### Índices
- **idxfpfnc_py07001**: cdn_event_fp

---

## Tabela: idx_exam_espirom
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seqcial_exam_espirom, cod_idx_exam_espirom

### Índices

---

## Tabela: img_acidte_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, num_acidte_ambntal, num_seq_img_acidte_ambntal

### Índices

---

## Tabela: img_acidte_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_acidtrab, num_seq_img_acidtrab

### Índices

---

## Tabela: img_dest_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_dest_ambntal, num_seq_img_dest_ambntal

### Índices

---

## Tabela: img_epi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_epi, num_seq, cod_img_epi

### Índices

---

## Tabela: img_inspec_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq_img_inspec, cod_imagem, cod_inspec_ambntal, cdn_empresa

### Índices
- **imgnspcm_inspcmbn**: cod_inspec_ambntal, cdn_empresa

---

## Tabela: img_norma_segur
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_norma_segur, num_seq_img_norma_segur

### Índices

---

## Tabela: img_notif_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_notif_ambntal, num_seq_img_notif, cod_imagem

### Índices

---

## Tabela: img_pacien
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_consmedic, num_seq_img_pacien

### Índices

---

## Tabela: img_passiv_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_passiv_ambntal, num_seq_img_passiv_ambntal, cod_imagem

### Índices

---

## Tabela: img_risco_acidte_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq_img_risco, cdn_empresa, cdn_estab, num_ambien_risco, num_riscacid

### Índices

---

## Tabela: import_coletor_dados
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_coletor_dados, dat_movto_agric, num_seq_import

### Índices
- **imprtclt_arq**: cdn_empresa, cdn_coletor_dados, nom_arq_imptdo

---

## Tabela: impto_prestdor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_prestdor_serv, cod_ser_docto_rh, num_docto, cod_impto

### Índices

---

## Tabela: indcao_carreira
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_plano_prh, num_seq

### Índices

---

## Tabela: indcao_func_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq_planilha_orcto, cdn_vers_planilha, cdn_cargo, cdn_niv_cargo, cdn_turno_trab, cod_tip_cargo, cod_clas_cargo, num_mes_orcto, num_ano_orcto, cdn_empresa, cdn_estab, cdn_funcionario

### Índices
- **indcfncr_emp**: cdn_empresa, cdn_estab, cdn_turno_trab, cdn_cargo, cdn_niv_cargo, cdn_vers_planilha, num_seq_planilha_orcto

---

## Tabela: indcao_pos_suces
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_empres_suces, cdn_estab_suces, cod_unid_lotac_suces, cdn_cargo_basic, cdn_niv_cargo_suces, num_seq, idi_tip_suces_func

### Índices

---

## Tabela: indic_mdo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_plano_lotac, cod_unid_lotac, num_ano_refer, num_mes_refer, idi_tip_idx, idi_tip_ocor_indic

### Índices

---

## Tabela: indic_mdo_mestre
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_plano_lotac, cod_unid_lotac

### Índices

---

## Tabela: indic_organ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_indic_organ

### Índices
- **indcrgn_indcrgnr**: cdn_indic_organ_orig

---

## Tabela: indic_organ_orig
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_indic_organ_orig

### Índices

---

## Tabela: info_banc_pensao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_bnfciar_palim

### Índices

---

## Tabela: inform_cadast_fgts_re
**Label**: FGTS Ou 13�
**Descrição**: Valor do FGTS ou 13�

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, idi_tip_contrat_func, cdn_tomador_serv, dat_depos_fgts, num_seq_dat_depos

### Índices
- **infrmcds_py07401**: cod_cgc_atual, cod_pis_cpf_func, num_ano_refer_calc_efetd, num_mes_refer_calc_efetd, cdn_empresa, cdn_estab
- **infrmcds_pyndfdrc**: cod_pais, cod_unid_federac_rh
- **infrmcds_rhndfdrc**: cod_pais, cod_unid_federac_cart_trab

---

## Tabela: inform_dirf
**Label**: Vl Resto PrevPriv
**Descrição**: Valor resto previd�ncia privada

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_ano_refer_inform_dirf, idi_tip_inform_dirf

### Índices

---

## Tabela: inform_geral_invent
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq

### Índices

---

## Tabela: inform_geral_invent_dados
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq, dat_refer_dados

### Índices

---

## Tabela: inform_geral_invent_respons
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq, cod_equipe_ambntal, dat_inic_respde

### Índices

---

## Tabela: inform_impres_anexo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_campo_impres_avpes

### Índices

---

## Tabela: inform_instrut_trein
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_instrutor, dat_refer

### Índices

---

## Tabela: inform_manad
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- idi_tip_reg_manad, cdn_empresa, cdn_estab, cdn_prestdor_serv, cdn_event_fp, cod_id_feder, cod_unid_lotac, cod_rh_ccusto, num_ano_refer_fp, num_mes_refer_fp

### Índices

---

## Tabela: inform_pis_envdo_serpro
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_cgc_atual, nom_arq_envdo_serpro, num_reg_arq_serpro

### Índices

---

## Tabela: inform_rais
**Label**: Sal�rio Contratual
**Descrição**: Valor do sal�rio contratual do funcion�rio

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_ano_refer_inform_dirf_rais

### Índices

---

## Tabela: inspec_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_inspec_ambntal

### Índices
- **inspcmbn_eqpmbntl**: cod_equipe_ambntal
- **inspcmbn_lclmbntl**: cod_local_ambntal
- **inspcmbn_prstdrsr**: cdn_empresa, cdn_prestdor_serv

---

## Tabela: inspec_ipcto_avaliac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_local_ambntal, cdn_empresa, cdn_estab, cod_ativid_func, dat_avaliac_ambntal, hra_avaliac_ambntal, cod_aspecto_ambntal, cod_meio_ambntal, cod_ipcto_ambntal, cod_inspec_ambntal

### Índices
- **inspcpct_inspcmbn**: cod_inspec_ambntal, cdn_empresa

---

## Tabela: inspec_licenc_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_licenc_ambntal, cod_orgao_emissor_notif, dat_emis_licenc, cod_inspec_ambntal, cod_condic_ambntal, cdn_empresa

### Índices
- **inspclcn_cndclcnc**: cod_licenc_ambntal, cod_orgao_emissor_notif, dat_emis_licenc, cod_condic_ambntal, cdn_empresa
- **inspclcn_cndcmbnt**: cod_condic_ambntal
- **inspclcn_inspcmbn**: cod_inspec_ambntal
- **inspclcn_lcncnspc**: cdn_empresa, cod_licenc_ambntal, cod_orgao_emissor_notif, dat_emis_licenc, cod_inspec_ambntal

---

## Tabela: inspec_proj_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_proj_ambntal, cod_inspec_ambntal, cod_requis_ambntal

### Índices
- **inspcprj_inspcmbn**: cdn_empresa, cod_inspec_ambntal
- **inspcprj_rqsmbntl**: cod_requis_ambntal

---

## Tabela: instit_curso_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_curso_trein, cdn_instit_trein

### Índices
- **insttcrs_instttrn**: cdn_instit_trein

---

## Tabela: instit_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_instit_trein

### Índices
- **instttrn_pessoa_jurid** (Unique): num_pessoa_jurid

---

## Tabela: instruc_calc_verba
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_formul_calc_verba, num_seq_instruc_calc

### Índices

---

## Tabela: instrut_curso_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_curso_trein, cdn_instrutor

### Índices
- **instrtca_instrtns**: cdn_instit_trein, cdn_instrutor
- **instrtca_instrttr**: cdn_instrutor
- **instrtca_insttcrs**: cdn_curso_trein, cdn_instit_trein

---

## Tabela: instrut_horar_dia_turma
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_instrutor, dat_aula_turma_trein, hra_inic_period

### Índices
- **instrthr_hrrdtrmt**: cdn_curso_trein, cdn_turma_trein, dat_aula_turma_trein, hra_inic_period
- **instrthr_instrtca**: cdn_instit_trein, cdn_instrutor, cdn_curso_trein

---

## Tabela: instrut_instit_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_instit_trein, cdn_instrutor

### Índices
- **instrtns_instrttr**: cdn_instrutor

---

## Tabela: instrut_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_instrutor

### Índices
- **instrttr_pessoa_fisic** (Unique): num_pessoa_fisic

---

## Tabela: integr_ahgora_controle
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_sit_afast_func, num_horar_sit_afast, dat_modificacao

### Índices
- **intgrahgr_uni**: cod_subunique

---

## Tabela: integr_ahgora_localizacao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_id_localizacao

### Índices

---

## Tabela: integr_ahgora_param
**Label**: Livre 2
**Descrição**: Par�mentros Integra��o Ahgora

### Chave Primária
- nom_url_acesso

### Índices

---

## Tabela: integr_cand_aprov
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_candempr, cdn_vaga, num_seq

### Índices

---

## Tabela: integr_cand_aprov_aux
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_candempr, cdn_vaga, num_seq

### Índices

---

## Tabela: integr_cargo_perf_metas
**Label**: N�mero referentes a Performance e Metas
**Descrição**: N�mero referentes a Performance e Metas

### Chave Primária
- cdn_cargo, cdn_niv_cargo

### Índices
- **cargo_niv**: cdn_niv_cargo
- **nivel_id**: cod_id_niv_hier, cod_id_niv_cargo, cod_id_cargo

---

## Tabela: integr_estab_perf_metas
**Label**: N�mero referentes a Performance e Metas
**Descrição**: N�mero referentes a Performance e Metas

### Chave Primária
- cdn_empresa, cdn_estab

### Índices
- **id_estab**: cod_id_estab

---

## Tabela: integr_func_perf_metas
**Label**: N�mero referentes a Performance e Metas
**Descrição**: N�mero referentes a Performance e Metas

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario

### Índices
- **id_fncnr**: cod_id_func

---

## Tabela: integr_lotac_perf_metas
**Label**: N�mero referentes a Performance e Metas
**Descrição**: N�mero referentes a Performance e Metas

### Chave Primária
- cod_unid_lotac

### Índices
- **id_lotac**: cod_id_lotac

---

## Tabela: integr_lote_perform_metas
**Label**: N�mero referentes a Performance e Metas
**Descrição**: N�mero referentes a Performance e Metas

### Chave Primária
- idi_tip_entidade, cod_id_lote_pm

### Índices

---

## Tabela: integr_niv_cargo_perf_metas
**Label**: N�mero referentes a Performance e Metas
**Descrição**: N�mero referentes a Performance e Metas

### Chave Primária
- cdn_niv_cargo

### Índices
- **id_nivcargo**: cod_id_niv_cargo

---

## Tabela: integr_niv_hier_perf_metas
**Label**: N�mero referentes a Performance e Metas
**Descrição**: N�mero referentes a Performance e Metas

### Chave Primária
- cdn_niv_hier_funcnal

### Índices
- **id_nvrhfunc**: cod_id_niv_hier

---

## Tabela: integr_novo_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_pessoa_fisic, cdn_etap_integr_func

### Índices

---

## Tabela: integr_pend_dados
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_integr_pend_dados

### Índices
- **intgrpnd_func**: cdn_estab, cdn_funcionario, nom_pessoa_fisic, dat_importa, num_horar_import, dat_criac_reg

---

## Tabela: integr_pend_dados_depend
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_integr_pend_dados

### Índices
- **intgrpnb_nome**: cdn_integr_pend_dados, nom_depend_func

---

## Tabela: integr_pend_dados_func
**Label**: Peso
**Descrição**: Valor - Inteiro do Peso da Pessoa

### Chave Primária
- cdn_integr_pend_dados

### Índices

---

## Tabela: integr_pend_dados_rescis
**Label**: Percent Multa FGTS
**Descrição**: Percentual para c�lculo da multa sobre o FGTS

### Chave Primária
- cdn_integr_pend_dados

### Índices
- **intgrpne_data**: cdn_integr_pend_dados, dat_desligto_func

---

## Tabela: integr_pend_dados_sit
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_integr_pend_dados

### Índices
- **intgrpnc_data**: cdn_integr_pend_dados, dat_inic_sit_afast

---

## Tabela: integr_perform_metas
**Label**: Entidade
**Descrição**: Entidade integrada

### Chave Primária
- idi_tip_entidade, cod_id_totvs, cod_id_lote_pm

### Índices
- **idxLote**: idi_tip_entidade, cod_id_lote_pm

---

## Tabela: integr_perform_metas_ret
**Label**: N�mero referentes a Performance e Metas
**Descrição**: N�mero referentes a Performance e Metas

### Chave Primária
- idi_tip_entidade, cod_id_totvs, cod_id_lote_pm, id_seq_retorno

### Índices

---

## Tabela: integr_tae_docum
**Label**: Livre 1
**Descrição**: Atributo livre para uso interno

### Chave Primária
- idi_tip_documento, num_sequencia

### Índices
- **tae_docum**: cod_id_docum
- **tae_func**: cdn_empresa, cdn_estab, cdn_funcionario
- **tae_nomdoc**: nom_documento, idi_tip_documento
- **tae_pesfisic**: num_pessoa_fisic

---

## Tabela: integr_tae_grp_email
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, idi_tip_documento, cod_grp_email

### Índices

---

## Tabela: integr_tae_grp_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, idi_tip_documento, cod_grp_usuar

### Índices

---

## Tabela: integr_tae_param
**Label**: Livre 1
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq

### Índices

---

## Tabela: integr_tae_respons
**Label**: Livre 1
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_sequencia, nom_e_mail

### Índices
- **tae_docum**: cod_id_docum
- **tae_pesfisic**: num_pessoa_fisic_respons

---

## Tabela: integr_tae_retorno
**Label**: Livre 1
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_sequencia, num_seq_retorno

### Índices

---

## Tabela: integr_tae_tip_docto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, idi_tip_documento

### Índices

---

## Tabela: integr_tip_func_perf_metas
**Label**: N�mero referentes a Performance e Metas
**Descrição**: N�mero referentes a Performance e Metas

### Chave Primária
- idi_tip_func

### Índices
- **id_codtpfunc**: cod_id_tip_func

---

## Tabela: interhrou_layout
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- idi_tip_layout, num_col_interhrou

### Índices

---

## Tabela: interhrou_param
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- log_create_ccusto

### Índices

---

## Tabela: interhrou_reg_import
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- num_reg_import, idi_tip_layout, dat_gerac_reg_interhrou, idi_tip_reg_interhrou

### Índices

---

## Tabela: interhrou_reg_import_det
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- num_reg_import, idi_tip_layout, idi_tip_reg_interhrou, dat_gerac_reg_interhrou

### Índices

---

## Tabela: interpret_exam_medic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_interpret_exam_medic

### Índices

---

## Tabela: interv_movel_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_proces_mpe

### Índices

---

## Tabela: interv_refei_jorn_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_jorn_trab, cdn_interv_refei

### Índices
- **intrvrfj_py20901**: cdn_jorn_trab, hra_inic_interv_jorn_trab

---

## Tabela: ipcto_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_ipcto_ambntal

### Índices

---

## Tabela: irf_despes_medic
**Label**: Valor Rendimentos
**Descrição**: Valor rendimentos

### Chave Primária
- cdn_empresa, cdn_estab, cod_cpf_cgc, cdn_depend_func, num_ano_refer, num_mes_refer, cdn_event_fp, idi_tip_inform_dirf, cod_cgc_declar, cdn_retenc_irf, cdn_ans

### Índices

---

## Tabela: irf_rendto
**Label**: Rendimentos N�o Tribut�veis
**Descrição**: Rendimentos N�o Tribut�veis

### Chave Primária
- cdn_empres_centrdor, cdn_estab_centrdor, num_ano_refer_fp, cod_cgc_declar, cdn_retenc_irf, cdn_tip_bnfciar, cod_cpf_cgc, idi_tip_inform_dirf, cdn_event_fp

### Índices
- **irfrndt_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario
- **irfrndt_py11401**: num_ano_refer_fp, cod_cgc_declar, cdn_retenc_irf, cdn_tip_bnfciar, cod_cpf_cgc, idi_tip_inform_dirf, cdn_event_fp
- **irfrndt_py11403**: cdn_empresa, cdn_estab, cdn_plano_lotac, cod_unid_lotac

---

## Tabela: irf_rendto_mestre
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empres_centrdor, cdn_estab_centrdor, num_ano_refer_fp, cod_cgc_declar, cdn_retenc_irf, cdn_tip_bnfciar, cod_cpf_cgc

### Índices
- **irfrndtm_anoret**: num_ano_refer_fp, cod_cgc_declar, cdn_retenc_irf, cdn_tip_bnfciar, cod_cpf_cgc
- **irfrndtm_categ**: cdn_empresa, cdn_estab, cdn_categ_sal
- **irfrndtm_fnc**: cdn_empresa, cdn_estab, cdn_funcionario
- **irfrndtm_lotac**: cdn_empresa, cdn_estab, cdn_plano_lotac, cod_unid_lotac
- **irfrndtm_tpprest**: cdn_empres_centrdor, cdn_estab_centrdor, num_ano_refer_fp, cod_cgc_declar, cdn_retenc_irf, cdn_tip_bnfciar, log_prestdor_serv, cod_cpf_cgc

---

## Tabela: irregul
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_irregul_eqpto

### Índices

---

## Tabela: item_analis_exam_medic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_ficha_medic, dat_programac_exam_medic, cod_exam_medic, cod_grp_item_exam, cod_item_exam_medic

### Índices
- **itmnlsxm_itmxmmdc**: cod_grp_item_exam, cod_item_exam_medic

---

## Tabela: item_causa_acidte
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_causa_acidtrab, cod_item_quest_medic

### Índices

---

## Tabela: item_ergonom
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_item_ergonom

### Índices

---

## Tabela: item_ergonom_risco
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq, cod_item_ergonom

### Índices
- **itmrgnmr_itmrgnm**: cod_item_ergonom

---

## Tabela: item_exam_medic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_item_exam_medic

### Índices

---

## Tabela: item_inspec_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_item_inspec

### Índices

---

## Tabela: item_remun_emprest
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_banco, cdn_agenc_bcia, cdn_sindicato, cdn_estab, cdn_remun_var

### Índices
- **itmrmnmp_remunvar**: cdn_remun_var
- **itmrmnmp_rhestab**: cdn_empresa, cdn_estab
- **itmrmnmp_rhgncbc**: cdn_banco, cdn_agenc_bcia
- **itmrmnmp_sndct**: cdn_sindicato

---

## Tabela: item_reqdo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_item_reqdo

### Índices

---

## Tabela: item_tip_restdo_exam
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_item_exam_medic, cod_tip_restdo_item_exam

### Índices
- **itmtprst_tprstdtm**: cod_tip_restdo_item_exam

---

## Tabela: jorn_altern_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_refer_calend

### Índices
- **jrnltrnf_turno_jorn**: cdn_turno_trab, cdn_jorn_trab

---

## Tabela: jorn_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_jorn_trab

### Índices
- **jorntrab_py20802**: cod_tip_dia

---

## Tabela: jorn_turno_altern
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_turno_trab, cdn_jorn_trab, cdn_jorn_altern

### Índices

---

## Tabela: jorn_turno_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_turno_trab, cdn_jorn_trab

### Índices
- **jrntrntr_jorntrab**: cdn_jorn_trab

---

## Tabela: laudo_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_laudo_ambntal

### Índices

---

## Tabela: laudo_aposent_especial
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_gerac_relat_inss, num_seq, num_laudo_tec_aposent

### Índices
- **ldpsntsp_eqptvlcr**: cod_eqpto_avaliac_risco

---

## Tabela: laudo_etap_test
**Label**: Nota M�dia Laudo
**Descrição**: Valor Nota M�dia Laudo Etapas Teste

### Chave Primária
- cdn_empresa, cdn_estab, cdn_req_pessoal, cdn_candempr

### Índices

---

## Tabela: layout_campo_integr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_tab_usuar, cod_campo_tab, cod_field_name

### Índices

---

## Tabela: layout_coletor_dados
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_coletor_dados, cdn_layout_import_agric

### Índices
- **lytcltrd_lytmprtg**: cdn_layout_import_agric

---

## Tabela: layout_export_agricola
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_layout_export_agric

### Índices

---

## Tabela: layout_import_agric
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_layout_import_agric

### Índices

---

## Tabela: layout_import_mpe
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_layout_ptoelet

### Índices

---

## Tabela: layout_relat_medic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_layout_medic_segur

### Índices

---

## Tabela: layout_relat_rh
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- idi_tip_relat_rh, num_col_relat_rh

### Índices

---

## Tabela: layout_relat_segur
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_layout_medic_segur, idi_tip_dados_relat

### Índices

---

## Tabela: layout_relat_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_relat_trein

### Índices

---

## Tabela: layout_tab_integr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_layout_tab_usuar

### Índices

---

## Tabela: liber_folha_pagto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_ano_previs_liber_sal, num_mes_previs_liber_sal, cdn_motiv_liber_sal

### Índices
- **lbrflhpg_mtvlbrsl**: cdn_motiv_liber_sal

---

## Tabela: liber_previa_salario
**Label**: Pr�mio Concedido
**Descrição**: Valor Pr�mio Concedido

### Chave Primária
- cdn_empresa, cdn_estab, num_id_liber_previa_salario, cdn_funcionario, num_ano_previs_liber_sal, num_mes_previs_liber_sal, cdn_motiv_liber_sal

### Índices
- **lbrprvsl_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario
- **lbrprvsl_mtrzmtsl**: num_id_liber_previa_salario
- **lbrprvsl_mtvlbrsl**: cdn_motiv_liber_sal

---

## Tabela: licenc_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_licenc_ambntal, cod_orgao_emissor_notif, dat_emis_licenc

### Índices
- **lcncmbnt_pssvmbnt**: cdn_empres_passiv, cod_passiv_ambntal
- **lcncmbnt_tplcncmb**: cod_tip_licenc

---

## Tabela: licenc_inspec_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_licenc_ambntal, cod_orgao_emissor_notif, dat_emis_licenc, cod_inspec_ambntal

### Índices
- **lcncnspc_inspcmbn**: cod_inspec_ambntal

---

## Tabela: licenc_norma_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_norma_ambntal, dat_emis_norma, cod_licenc_ambntal, cod_orgao_emissor_notif, dat_emis_licenc

### Índices
- **lcncnrmm_lcncmbnt**: cod_licenc_ambntal, cod_orgao_emissor_notif, dat_emis_licenc, cdn_empresa

---

## Tabela: licenc_proj_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_licenc_ambntal, cod_orgao_emissor_notif, dat_emis_licenc, cod_proj_ambntal

### Índices
- **lcncprjm_lcncmbnt**: cod_licenc_ambntal, cod_orgao_emissor_notif, dat_emis_licenc, cdn_empresa
- **lcncprjm_prjmbntl**: cdn_empresa, cod_proj_ambntal

---

## Tabela: lim_verific
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_lim_verific

### Índices

---

## Tabela: lin_aces_cargo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_cargo_basic_orig, cdn_niv_cargo_orig, cdn_cargo_basic_dest, cdn_niv_cargo_dest

### Índices
- **lncscrg_cargo**: cdn_cargo_basic_dest, cdn_niv_cargo_dest

---

## Tabela: lin_transp_rural
**Label**: Pre�o Viagem
**Descrição**: Valor Preco Pexcec Viagem

### Chave Primária
- cdn_lin_transp_rural

### Índices

---

## Tabela: lin_vale_transp
**Label**: Valor Tarifa
**Descrição**: Valor da tarifa

### Chave Primária
- cdn_empresa, cdn_lin_vale_transp

### Índices
- **lnvltrns_prstdrsr**: cdn_empresa, cdn_prestdor_serv
- **lnvltrns_py11503**: cdn_empresa, idi_tip_lin, cdn_lin_vale_transp

---

## Tabela: lista_inscr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_curso_trein, cdn_lista_inscr

### Índices
- **lstnscr_fncnr**: cdn_empresa, cdn_estab, cdn_treindo
- **lstnscr_mtvdsbtc**: cdn_motiv_desabtcao_treindo
- **lstnscr_mtvslctt**: cdn_motiv_solicit_trein
- **lstnscr_pessoa_fisic** (Unique): num_pessoa_fisic, cdn_curso_trein
- **lstnscr_trmtrn**: cdn_curso_trein, cdn_turma_trein

---

## Tabela: liter_formul_calc
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_pais, nom_liter_formul_calc

### Índices

---

## Tabela: local_aces_planta
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_planta_edificio, cdn_local_aces

### Índices

---

## Tabela: local_aces_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_usuar_control_aces, cdn_planta_edificio, cdn_local_aces, num_seq_local_aces

### Índices

---

## Tabela: local_aces_visitante
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_planta_edificio, dat_entr_visitante, num_hora_entr_visitante, num_ocor_visitante, cdn_local_aces_entr, cdn_local_aces_orig, num_seq_estrut, cdn_local_aces_dest

### Índices

---

## Tabela: local_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_local_ambntal

### Índices

---

## Tabela: local_ativid_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_local_ambntal, cdn_empresa, cdn_estab, cod_ativid_func

### Índices
- **lcltvdmb_ativid**: cdn_empresa, cdn_estab, cod_ativid_func

---

## Tabela: local_curso_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_curso_trein, cdn_instit_trein_curso, cdn_instit_trein, cdn_local_trein

### Índices
- **lclcrstr_lcltrn**: cdn_instit_trein, cdn_local_trein

---

## Tabela: local_despes
**Label**: Despesa Gera��o
**Descrição**: Valor Despesa da Gera��o Res�duo ou Efluente

### Chave Primária
- cod_local_ambntal, cdn_empresa, cdn_estab, cod_unid_lotac, idi_tip_levto, num_seq

### Índices
- **lcldsps_residuo**: cod_residuo
- **lcldsps_rhestab**: cdn_empresa, cdn_estab
- **lcldsps_undltc**: cod_unid_lotac

---

## Tabela: local_dest_residuo
**Label**: Valor Venda
**Descrição**: Valor Venda

### Chave Primária
- num_seq

### Índices
- **lcldstrs_cnfrmmvt**: cod_dest_ambntal_entr, log_saida, num_seq
- **lcldstrs_dstmbntl**: cod_dest_ambntal_entr, idi_tip_movto_ambntal, num_seq
- **lcldstrs_dtdstrsd**: cod_dest_ambntal_entr, cod_residuo, dat_dest_residuo, hra_dest_ambntal, num_seq
- **lcldstrs_lclmbn**: cod_local_ambntal, cdn_empresa, cdn_estab, cod_unid_lotac, idi_tip_levto, num_seq
- **lcldstrs_residuo**: cod_residuo
- **lcldstrs_rhestab**: cdn_empresa, cdn_estab
- **lcldstrs_sdrsdmbn**: num_saida
- **lcldstrs_tpmvt**: cod_dest_ambntal_entr, idi_tip_movto_ambntal, cod_residuo
- **lcldstrs_undltc**: cod_unid_lotac
- **lcldstrs_undmddsg**: cod_unid_medid

---

## Tabela: local_efluente_gerad
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_local_ambntal, cdn_empresa, cdn_estab, cod_unid_lotac, idi_tip_levto, cod_efluente, dat_efluente_gerad, hra_efluente_gerad

### Índices

---

## Tabela: local_empres
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_local_empres

### Índices

---

## Tabela: local_empres_medid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_local_empres, cod_agent_risco, cod_amostra_risco, dat_medid_risco, hra_medid_risco

### Índices
- **lclmprsm_agntrsc**: cod_amostra_risco, cod_agent_risco
- **lclmprsm_fncnr**: cdn_empres_medid, cdn_estab_medid, cdn_func_medid

---

## Tabela: local_estoq
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_local_estoq

### Índices

---

## Tabela: local_estoq_benefic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_local_estoq, cdn_beneficio

### Índices
- **lclstqbn_bnfc**: cdn_beneficio

---

## Tabela: local_estoq_estab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_local_estoq, cdn_estab

### Índices
- **lclstqst_rhestab**: cdn_empresa, cdn_estab

---

## Tabela: local_event_sipat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_local_event_sipat

### Índices

---

## Tabela: local_exam_medic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_local_exam_medic

### Índices

---

## Tabela: local_horar_dia_turma
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_instit_trein, cdn_local_trein, dat_aula_turma_trein, hra_inic_period

### Índices
- **lclhrrdt_hrrdtrmt**: cdn_curso_trein, cdn_turma_trein, dat_aula_turma_trein, hra_inic_period

---

## Tabela: local_inspec_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_local_ambntal, cdn_empresa, cdn_estab, cod_unid_lotac, idi_tip_levto, cod_inspec_ambntal

### Índices
- **lclnspcm_inspcmbn**: cod_inspec_ambntal, cdn_empresa

---

## Tabela: local_lesao_acidte
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_local_lesao_acidtrab

### Índices

---

## Tabela: local_lotac_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_local_ambntal, cdn_empresa, cdn_estab, cod_unid_lotac, idi_tip_levto

### Índices

---

## Tabela: local_marcac_ptoelet
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_local_marcac_cartao_pto

### Índices

---

## Tabela: local_marcac_tip_dia
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_local_marcac_cartao_pto, cod_tip_dia

### Índices

---

## Tabela: local_pagto_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- nom_local_pagto

### Índices
- **lclpgtfn_pyndfdrc**: cod_pais, cod_unid_federac_rh

---

## Tabela: local_pto_coleta
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_local_ambntal, cod_unid_lotac, cod_pto_coleta

### Índices

---

## Tabela: local_residuo_dest_proces
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_local_ambntal, cdn_empresa, cdn_estab, cod_unid_lotac, idi_tip_levto, num_seq, cod_tip_proces_gerac

### Índices

---

## Tabela: local_residuo_gerad
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_local_ambntal, cdn_empresa, cdn_estab, cod_unid_lotac, idi_tip_levto, num_seq

### Índices
- **lclrsdgr_fntgrdrr**: cod_fonte_gerador_risco
- **lclrsdgr_frmcnd**: cod_forma_acond
- **lclrsdgr_residuo**: cod_residuo
- **lclrsdgr_rhestab**: cdn_empresa, cdn_estab
- **lclrsdgr_undltc**: cod_unid_lotac
- **lclrsdgr_undmddsg**: cod_unid_medid

---

## Tabela: local_residuo_mater_prim
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_local_ambntal, cdn_empresa, cdn_estab, cod_unid_lotac, idi_tip_levto, cod_residuo, cod_mater_prim, num_ano

### Índices

---

## Tabela: local_residuo_norma
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_local_ambntal, cdn_empresa, cdn_estab, cod_unid_lotac, idi_tip_levto, cod_residuo, cod_norma_ambntal, dat_emis_norma, cod_requis_norma_ambntal, dat_analis_requis

### Índices

---

## Tabela: local_residuo_produt
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_local_ambntal, cdn_empresa, cdn_estab, cod_unid_lotac, idi_tip_levto, cod_residuo, cod_produt_acidte_trab, num_ano

### Índices

---

## Tabela: local_reuniao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_local_reuniao_segur

### Índices

---

## Tabela: local_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_instit_trein, cdn_local_trein

### Índices
- **lcltrn_rhndfdrc**: cod_pais, cod_unid_federac_rh
- **lcltrn_tplcltrn**: cdn_tip_local_trein

---

## Tabela: localid_local_exam
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_local_exam_medic, cod_pais, cdn_localidade

### Índices
- **lcldlclx_lcldd**: cod_pais, cdn_localidade

---

## Tabela: localidade
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_pais, cdn_localidade

### Índices

---

## Tabela: log_integr_serv
**Label**: Sequ�ncia Mensagem
**Descrição**: Sequ�ncia Mensagem

### Chave Primária
- val_seq_msg

### Índices
- **lgntgrsr_keyseq**: idi_tip_msg, cod_msg_key, idi_tip_operac, val_seq_msg

---

## Tabela: lotac_cargo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_cargo_basic, cdn_niv_cargo, cdn_plano_lotac, cod_unid_lotac

### Índices

---

## Tabela: lotac_pessoa_ext
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_pessoa_ext, dat_refer

### Índices
- **ltcpssxt_rhccusto**: cdn_empresa, cod_rh_ccusto
- **ltcpssxt_rhestab**: cdn_empresa, cdn_estab
- **ltcpssxt_undltcpl**: cdn_plano_lotac, cod_unid_lotac

---

## Tabela: lote_movto_infor_fp
**Label**: Soma Eventos Dif
**Descrição**: Soma eventos diferen�a

### Chave Primária
- cdn_empresa, idi_tip_movto_lote_fp, num_ano_refer_movto_lote_fp, num_mes_refer_movto_lote_fp, cdn_estab, cdn_categ_sal, idi_tip_fp, num_parc_consdo_movto_efp, num_lote_movto_fp

### Índices
- **ltmvtnfr_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario
- **ltmvtnfr_lotefunc**: cdn_empresa, cdn_estab, num_lote_movto_fp, cdn_funcionario

---

## Tabela: mandat_cipa
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_area_segur, num_mandat_cipa

### Índices

---

## Tabela: mandat_cipa_plano_acao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_area_segur, num_mandat_cipa, cdn_plano_organ, cdn_objorg

### Índices
- **mndtcppl_objorg**: cdn_empresa, cdn_plano_organ, cdn_objorg

---

## Tabela: mapa_risco
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_area_segur, num_mandat_cipa, num_seq_mapa_risco

### Índices
- **mprsc_agntrsc**: cod_agent_risco
- **mprsc_undltcpl**: cdn_plano_lotac, cod_unid_lotac
- **mprsc_utl_seq**: num_mandat_cipa, num_seq_mapa_risco

---

## Tabela: marcac_atraso_aces
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_ident_disposit, cod_cartao_aces, dat_marcac_aces, num_horar_marcac_aces, num_seq_marcac_control_aces

### Índices

---

## Tabela: marcac_control_aces
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_ident_disposit, cod_cartao_aces, dat_marcac_aces, num_horar_marcac_aces, num_seq_marcac_control_aces

### Índices
- **mrcccntr_bsc_ma**: dat_marcac_aces, num_horar_marcac_aces, cod_cartao_aces, cdn_planta_edificio, cdn_local_aces, num_seq_marcac_control_aces
- **mrcccntr_cracha**: cod_cartao_aces, dat_marcac_aces, num_horar_marcac_aces, num_seq_marcac_control_aces, cdn_ident_disposit
- **mrcccntr_disposit**: cdn_planta_edificio, cdn_disposit_control_aces, dat_marcac_aces, num_horar_marcac_aces, num_seq_marcac_control_aces, cdn_usuar_control_aces
- **mrcccntr_usr_cntrl**: cdn_usuar_control_aces, dat_marcac_aces, num_horar_marcac_aces, idi_direcao_aces
- **mrcccntr_usuar_dips**: cdn_usuar_control_aces, cdn_planta_edificio, cdn_disposit_control_aces, dat_marcac_aces, num_horar_marcac_aces, num_seq_marcac_control_aces
- **mrcccntr_usuar_horar**: cdn_usuar_control_aces, dat_marcac_aces, num_horar_marcac_aces, num_seq_marcac_control_aces, cdn_planta_edificio, cdn_disposit_control_aces

---

## Tabela: marcac_import
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- nom_arq_mpe_imptdo, dat_import_arq_mpe, num_hora_corren_import_mpe, num_seq_import

### Índices
- **mrccmprd_ix3**: num_seqcial_msa
- **mrccmprt_ix4**: val_control_marcac
- **mrccmprt_nmsq**: nom_arq_mpe_imptdo, num_seq_import

---

## Tabela: marcac_nova_integr
**Label**: Perfil Acesso
**Descrição**: Perfil Acesso

### Chave Primária
- val_control_marcac

### Índices
- **mrccnvnt_ix2**: cod_nsr, cod_rep, cod_pis_msa, dat_marcac_aces
- **mrccnvnt_ix3**: cod_pis_msa
- **mrccnvnt_ix4**: log_import_produt
- **mrccnvnt_ix5**: cod_lote
- **mrccnvnt_ix6**: cod_relogio_ext_chave, cod_nsr
- **mrccnvnt_ix7**: cod_rep, cod_nsr
- **mrccnvnt_ix8**: cod_nsr, cod_rep, cod_cpf_func, dat_marcac_aces

---

## Tabela: marcac_pto_taref
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_movto_agric

### Índices

---

## Tabela: marcac_ptoelet
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_proces_mpe, num_horar_proces_mpe

### Índices
- **mrccptld_ix4**: num_seqcial_msa
- **mrccptlt_imp**: nom_arq_mpe_imptdo, dat_import_arq_mpe, num_hora_corren_import_mpe, num_seq_import
- **mrccptlt_ix5**: val_control_marcac
- **mrccptlt_tm04002**: cdn_empresa, cdn_estab, cdn_funcionario, dat_marcac_ptoelet, num_horar_marcac_ptoelet

---

## Tabela: mater_didat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_curso_trein, cdn_mater_didat

### Índices

---

## Tabela: mater_epi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_estab, cod_localiz, cod_item_produt, cod_epi, cdn_empresa

### Índices
- **materepi_eqptprtc**: cod_epi

---

## Tabela: mater_prim
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_mater_prim

### Índices

---

## Tabela: mater_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_mater_trein

### Índices
- **mtrtrn_tpmtrtrn**: cdn_tip_mater_trein

---

## Tabela: mater_trein_curso
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_curso_trein, cdn_mater_trein

### Índices
- **mtrtrncr_mtrtrn**: cdn_mater_trein

---

## Tabela: mater_turma_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_curso_trein, cdn_turma_trein, cdn_mater_trein

### Índices
- **mtrtrmtr_mtrtrn**: cdn_mater_trein
- **mtrtrmtr_mtrtrncr**: cdn_curso_trein, cdn_mater_trein

---

## Tabela: matr_curso_assincr
**Label**: Nr Sequencial Matr
**Descrição**: Valor Sequencia Matricula

### Chave Primária
- val_seq_matr

### Índices
- **mtrcrsss_curso**: cdn_curso_trein, num_pessoa_fisic, dat_matr_curso
- **mtrcrsss_status**: idi_sit_matr

---

## Tabela: matriz_analis
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_tip_cargo, cdn_cargo_basic, cdn_niv_cargo, cod_unid_lotac, cdn_etap_plano_organ, dat_inic_matriz_avaliac

### Índices

---

## Tabela: matriz_analis_avpes
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_tip_cargo, cdn_cargo_basic, cdn_niv_cargo, cod_unid_lotac, cdn_etap_plano_organ, dat_inic_matriz_avaliac, cdn_avpes_padr, idi_tip_avaldor_avpes

### Índices
- **mtrznlsv_avpsrgms**: cdn_avpes_padr

---

## Tabela: matriz_desemp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_matriz_desemp

### Índices

---

## Tabela: matriz_desemp_avaliac
**Label**: Perc Avalia��o
**Descrição**: Percentual Avalia��o

### Chave Primária
- cdn_matriz_desemp, cdn_etap_plano_organ, cdn_avpes_padr

### Índices

---

## Tabela: matriz_fp_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- idi_obj_folha, cdn_obj_folha, idi_obj_orcto, cod_obj_orcto, cdn_empresa, cod_obj_folha

### Índices

---

## Tabela: matriz_reaj
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_matriz_reaj

### Índices

---

## Tabela: matriz_reaj_perc
**Label**: % Sal M�dio Inicial
**Descrição**: Percentual Ponto M�dio Inicial

### Chave Primária
- cdn_matriz_reaj, val_perc_pto_med_inic, val_perc_pto_med_fim, val_desemp_final

### Índices

---

## Tabela: matriz_signific
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, num_tip_probab, num_tip_severid, num_tip_abrangen

### Índices

---

## Tabela: mdcacao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_mdcacao

### Índices
- **mdcacao_undmddsg**: cod_unid_medid

---

## Tabela: mdcacao_pacien
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_ficha_medic, num_consmedic, cod_mdcacao

### Índices
- **mdccpcn_cnsmdc**: num_consmedic, num_ficha_medic
- **mdccpcn_mdcacao**: cod_mdcacao

---

## Tabela: mdw_avpes_menu
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_menu_mdw, cdn_avpes_padr

### Índices

---

## Tabela: mdw_empres_aces
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_empres_aces

### Índices

---

## Tabela: mdw_empres_grp_usuar
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cod_grp_usuar

### Índices

---

## Tabela: mdw_grp_usuar_menu
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_menu_mdw, cdn_empres_usuar_rh, cod_grp_usuar

### Índices

---

## Tabela: mdw_menu
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_menu_mdw

### Índices

---

## Tabela: mdw_respos_avpes_justif
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- num_avpes_emitid, cdn_bloco_habcomp, cdn_habcomp

### Índices

---

## Tabela: medic_atndte_period
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, num_period_atendim, num_medic_atndte

### Índices
- **mdctndtp_cmpnssmt**: num_medic_atndte
- **mdctndtp_hrrtndmm**: num_horar_turno_trab

---

## Tabela: medic_ext
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_conslho_medic, cod_entid_clas_profis

### Índices

---

## Tabela: medic_local_exam
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_compon_sesmt, cod_local_exam_medic, num_horar_turno_trab, cdn_prestdor_serv, cod_exam_medic

### Índices
- **mdclclxm_lclxmmdc**: cod_local_exam_medic

---

## Tabela: meio_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_meio_ambntal

### Índices
- **mmbntl_grpmmbnt**: cod_grp_meio_ambntal

---

## Tabela: meio_divulg
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_meio_divulg_vaga_candidato

### Índices

---

## Tabela: meio_transp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_meio_transp

### Índices

---

## Tabela: mes_ano_event_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_cenar_orcto, cdn_event_orcto, num_ano_event_orcto, num_mes_event_orcto

### Índices
- **msnvntrc_mes_ano**: num_ano_event_orcto, num_mes_event_orcto, cdn_cenar_orcto, cdn_event_orcto

---

## Tabela: min_candidato_cargo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_cargo_basic

### Índices

---

## Tabela: model_avaliac
**Label**: Peso Etapa
**Descrição**: Valor Peso Etapa Modelo Avalia��o

### Chave Primária
- cdn_tip_model_avaliac_cargo, cdn_etap_sel_candempr

### Índices

---

## Tabela: model_avaliac_cargo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_model_avaliac_cargo, cdn_cargo_basic, cdn_niv_cargo

### Índices
- **mdlvlccr_crgbsc**: cdn_cargo_basic, cdn_niv_cargo

---

## Tabela: model_avaliac_clas_cargo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_clas_cargo, cdn_fator_avaliac_cargo

### Índices
- **mdlvlccl_fator**: cdn_fator_avaliac_cargo

---

## Tabela: model_descr_cargo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_clas_cargo, cdn_tip_descr_cargo

### Índices
- **mdldscrc_tip_descr**: cdn_tip_descr_cargo

---

## Tabela: model_disposit_aces
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_fabrican_disposit, idi_tip_disposit_aces, cdn_model_disposit

### Índices

---

## Tabela: motiv_alter_planilha_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_motiv_alter_planilha

### Índices

---

## Tabela: motiv_amostra
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_motiv_amostra

### Índices

---

## Tabela: motiv_autuac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_motiv_autuac

### Índices

---

## Tabela: motiv_consmedic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_motiv_consmedic

### Índices

---

## Tabela: motiv_consmedic_compon_sesmt
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_compon_sesmt, cod_motiv_consmedic

### Índices

---

## Tabela: motiv_desabtcao_treindo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_motiv_desabtcao_treindo

### Índices

---

## Tabela: motiv_estabil
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_motiv_estabil_func

### Índices
- **mtvstbl_eventfp**: cdn_event_fp

---

## Tabela: motiv_exc_cipa
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_motiv_saida_cipa

### Índices

---

## Tabela: motiv_liber_sal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_motiv_liber_sal

### Índices
- **mtvlbrsl_evntflhp**: cdn_event_fp
- **mtvlbrsl_numseqprop**: num_seq_calc_propost_liber
- **mtvlbrsl_tmptvlbr**: cdn_tip_motiv_liber_sal

---

## Tabela: motiv_lote_benefic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_motiv_lote_benefic

### Índices

---

## Tabela: motiv_manut_eqpcol
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_motiv_manut_eqpcol

### Índices

---

## Tabela: motiv_marcac
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_motiv_marcac

### Índices

---

## Tabela: motiv_req_pessoal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_motiv_req_pessoal

### Índices

---

## Tabela: motiv_reuniao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_motiv_reuniao_segur

### Índices

---

## Tabela: motiv_solicit_inter_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_motiv_solicit_candidato

### Índices

---

## Tabela: motiv_solicit_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_motiv_solicit_trein

### Índices

---

## Tabela: motiv_subst_pessoal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_motiv_subst_func

### Índices

---

## Tabela: motoris
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_motoris

### Índices

---

## Tabela: motoris_nao_cfem
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_motoris, cod_nao_cfem, dat_inic_nao_cfem

### Índices

---

## Tabela: movimen_quadro_desligto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seqcial_movimen

### Índices
- **mvmnqdrf_des**: cdn_empresa, cdn_estab, cdn_funcionario, dat_desligto_func

---

## Tabela: movimen_quadro_orcto_orig
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seqcial_movimen, num_seq_planilha_orig, cdn_vers_planilha_orig, cdn_cargo_basic_orig, cdn_niv_cargo_orig, num_seq_variac_orig, cod_clas_cargo_orig, num_ano_refer_orig, num_mes_refer_orig

### Índices

---

## Tabela: movimen_quadro_pessoa_calend
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_ano_refer

### Índices

---

## Tabela: movimen_quadro_pessoal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_tip_movimen_quadro_pessoal, cdn_motiv_movimen

### Índices

---

## Tabela: movimen_quadro_pessoal_afast
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_tip_movimen_quadro_pessoal, cdn_sit_afast, num_seq_valid

### Índices
- **mvmnqdrj_mvmnqdri**: cdn_empresa, cdn_estab, num_tip_movimen_quadro_pessoal, num_seq_valid

---

## Tabela: movimen_quadro_pessoal_area
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_tip_movimen_quadro_pessoal, num_seq_area

### Índices
- **mvmnqdrb_area**: cdn_area_respons

---

## Tabela: movimen_quadro_pessoal_erro
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seqcial_movimen, num_seqcial_movto, num_seq_erro, cdn_erro_movimen_ems

### Índices

---

## Tabela: movimen_quadro_pessoal_mes
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_ano_refer, num_mes_refer, num_tip_movimen_quadro_pessoal

### Índices

---

## Tabela: movimen_quadro_pessoal_movto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seqcial_movimen, num_seqcial_movto

### Índices

---

## Tabela: movimen_quadro_pessoal_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seqcial_movimen

### Índices
- **mvmnqdrg_orcto**: num_seq_planilha_orcto, cdn_vers_planilha, cdn_cargo_basic, cdn_niv_cargo, cdn_turno_trab, cod_tip_cargo, cod_clas_cargo

---

## Tabela: movimen_quadro_pessoal_param
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_niv_unid_lotac

### Índices

---

## Tabela: movimen_quadro_pessoal_req
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seqcial_movimen

### Índices
- **mvmnqdrd_req**: cdn_empresa, cdn_estab, cdn_req_pessoal

---

## Tabela: movimen_quadro_pessoal_tip
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_tip_movimen_quadro_pessoal

### Índices
- **mvmnqdrn_sig** (Unique): cod_sig_tip_movimen

---

## Tabela: movimen_quadro_pessoal_trans
**Label**: Sal Inicial Cargo
**Descrição**: Sal�rio Inicial Cargo

### Chave Primária
- num_seqcial_movimen

### Índices
- **mvmnqdre_func**: cdn_empresa, cdn_estab, cdn_funcionario, dat_transf_estab

---

## Tabela: movimen_quadro_pessoal_vaga
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_rh_ccusto, cod_unid_lotac, cdn_cargo_basic, cdn_niv_cargo, dat_refer_vaga

### Índices
- **mvmnqdrm_cargo**: cdn_cargo_basic, cdn_niv_cargo
- **mvmnqdrm_rhccusto**: cdn_empresa, cod_rh_ccusto
- **mvmnqdrm_undltc**: cod_unid_lotac

---

## Tabela: movimen_quadro_pessoal_valid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_tip_movimen_quadro_pessoal, num_seq_valid

### Índices

---

## Tabela: movimen_quadro_propost
**Label**: Sal�rio Proposto
**Descrição**: Valor Sal�rio Proposto

### Chave Primária
- num_seqcial_movimen

### Índices
- **mvmnqdro_cargo**: cdn_cargo_basic, cdn_niv_cargo
- **mvmnqdro_cargo_dest**: cdn_cargo_basic_dest, cdn_niv_cargo_dest
- **mvmnqdro_mtvlbrsl**: cdn_motiv_liber_sal
- **mvmnqdro_prpstlbr**: cdn_empresa, cdn_estab, cdn_funcionario, num_ano_previs_liber_sal, num_mes_previs_liber_sal, cdn_motiv_liber_sal

---

## Tabela: movto_agric_det
**Label**: Valor Unit�rio
**Descrição**: Valor Unit�rio Servi�o Agr�cola

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_movto_agric, num_lancto_movto_agric

### Índices
- **mvtgrcdt_dig**: cdn_empresa, num_lote_movto_agric, cdn_propried_agric, cdn_produt_agric, cdn_safra_produt, dat_movto_agric, cdn_estab, cdn_funcionario, num_lancto_movto_agric
- **mvtgrcdt_func**: cdn_empresa, cdn_estab, cdn_funcionario, num_lote_movto_agric
- **mvtgrcdt_lote**: cdn_empresa, num_lote_movto_agric, num_tar_agric, cdn_estab, cdn_funcionario
- **mvtgrcdt_prvdesc**: cdn_empresa, num_lote_movto_agric, dat_movto_agric, cdn_estab, cdn_funcionario, cdn_propried_agric, cdn_produt_agric, cdn_safra_produt, cdn_serv_agric, idi_tip_serv_agric
- **mvtgrcdt_seq**: cdn_empresa, num_seq_movto_agric

---

## Tabela: movto_agric_lote
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, num_lote_movto_agric

### Índices
- **mvtgrclt_colet**: cdn_empresa, cdn_coletor_dados, dat_movto_agric
- **mvtgrclt_data**: cdn_empresa, dat_movto_agric, num_lote_movto_agric
- **mvtgrclt_transp**: cdn_empresa, cdn_transpdor_rural, cdn_turma_rural, dat_movto_agric
- **mvtgrclt_turma**: cdn_empresa, cdn_turma_rural, dat_movto_agric

---

## Tabela: movto_agric_tar
**Label**: Valor Unit�rio
**Descrição**: Valor Unit�rio Servi�o Agr�cola

### Chave Primária
- cdn_empresa, num_lote_movto_agric, num_tar_agric

### Índices

---

## Tabela: movto_benefic
**Label**: Rec Prov Prox Gera��o
**Descrição**: Valor Rec�lculo Provento Pr�xima Gera��o

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_seq_movto_benefic

### Índices
- **mvtbnfc_calc**: cdn_empresa, cdn_estab, cdn_funcionario, num_ano_refer_movto_benefic, num_mes_refer_movto_benefic, cdn_beneficio, cdn_regra_benefic, cdn_depend_func, cdn_formul_calc_benefic, cdn_prestdor_serv
- **mvtbnfc_elimina**: cdn_empresa, cdn_estab, num_ano_refer_movto_benefic, num_mes_refer_movto_benefic
- **mvtbnfc_lote**: cdn_empresa, cdn_beneficio, cdn_regra_benefic, num_ano_refer_movto_benefic, num_mes_refer_movto_benefic, num_lote_movto_benefic
- **mvtbnfc_movto**: cdn_empresa, cdn_estab, cdn_funcionario, cdn_depend_func, cdn_beneficio, cdn_regra_benefic, num_ano_refer_movto_benefic, num_mes_refer_movto_benefic
- **mvtbnfc_py13001**: cdn_beneficio, cdn_regra_benefic, cdn_empresa, cdn_estab, cdn_funcionario
- **mvtbnfc_py13004**: cdn_empresa, cdn_estab, cdn_funcionario, cdn_prestdor_serv, cdn_beneficio, cdn_regra_benefic, dat_pagto_efet_efp
- **mvtbnfc_py13006**: cdn_empresa, cdn_formul_calc_benefic
- **mvtbnfc_py13007**: cdn_empresa, num_ano_refer_movto_benefic, num_mes_refer_movto_benefic, num_lote_movto_benefic
- **mvtbnfc_py13010**: cdn_empresa, log_pago_pelo_sist, num_pagto_benefic_prestdor, dat_pagto_efet_efp, log_gerac_pagto_prestdor, cdn_estab, cdn_prestdor_serv
- **mvtbnfc_py13011**: cdn_empresa, log_pago_pelo_sist, cdn_prestdor_serv, dat_pagto_efet_efp
- **mvtbnfc_py13012**: cdn_empresa, cdn_prestdor_serv, cdn_estab, cdn_funcionario
- **mvtbnfc_py13013**: cdn_empresa, cdn_val_unit_movto_benefic, cdn_estab, cdn_funcionario
- **mvtbnfc_rfrmvtbn**: cdn_empresa, cdn_beneficio, cdn_regra_benefic, num_ano_lote_movto_benefic, num_mes_lote_movto_benefic, num_lote_movto_benefic
- **mvtbnfc_seq_pai**: num_seq_movto_benefic_orig

---

## Tabela: movto_benefic_cart
**Label**: Valor Usado
**Descrição**: Valor usado do lan�amento

### Chave Primária
- cdn_empresa, cdn_estab, cdn_beneficio, num_docto_movto_benefic_cart

### Índices
- **mvtbnfcc_calc**: cdn_empresa, cdn_estab, cdn_funcionario, num_ano_refer_fp, num_mes_refer_fp, val_usado_movto_benefic_cart, cdn_beneficio, cdn_formul_calc_benefic
- **mvtbnfcc_elimina**: cdn_empresa, cdn_estab, num_ano_refer_fp, num_mes_refer_fp
- **mvtbnfcc_lote**: cdn_empresa, cdn_beneficio, num_lote_movto_benefic_cart
- **mvtbnfcc_py13101**: cdn_beneficio, cdn_empresa, cdn_prestdor_serv, cdn_estab, cdn_funcionario, dat_valid_docto_benefic_cart
- **mvtbnfcc_py13102**: cdn_empresa, cdn_estab, cdn_funcionario, cdn_beneficio, num_docto_movto_benefic_cart
- **mvtbnfcc_py13103**: cdn_empresa, cdn_estab, cdn_funcionario, dat_pagto_efet_efp
- **mvtbnfcc_py13104**: cdn_empresa, cdn_estab, cdn_funcionario, cdn_prestdor_serv, cdn_beneficio, dat_pagto_efet_efp
- **mvtbnfcc_py13106**: cdn_empresa, cdn_formul_calc_benefic
- **mvtbnfcc_py13107**: cdn_empresa, cdn_estab, cdn_funcionario, cdn_beneficio, dat_valid_docto_benefic_cart
- **mvtbnfcc_py13110**: cdn_empresa, log_pago_pelo_sist, num_pagto_benefic_prestdor, dat_pagto_efet_efp, log_gerac_pagto_prestdor, cdn_estab, cdn_prestdor_serv
- **mvtbnfcc_py13111**: cdn_empresa, log_pago_pelo_sist, cdn_prestdor_serv, dat_pagto_efet_efp
- **mvtbnfcc_py13112**: cdn_empresa, cdn_prestdor_serv, cdn_beneficio, cdn_estab, cdn_funcionario, dat_valid_docto_benefic_cart

---

## Tabela: movto_calc_retroat_desligto
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_calc, num_seq_movto_calcul_fp

### Índices
- **mvtclcrt_prdclcrt**: cdn_empresa, cdn_calc

---

## Tabela: movto_calcul_colab
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_seq_movto

### Índices
- **mvtclclc_aamm**: cdn_empresa, cdn_estab, cdn_funcionario, num_ano_calc_efetd, num_mes_calc_efetd, cdn_tip_calc_verba, num_parc_calc_fp
- **mvtclclc_dtini**: cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_vigenc, cdn_tip_calc_verba, num_parc_calc_fp
- **mvtclclc_dtpg**: cdn_empresa, cdn_estab, cdn_funcionario, dat_pagto, cdn_tip_calc_verba, num_parc_calc_fp
- **mvtclclc_tpclc**: cdn_empresa, cdn_estab, cdn_funcionario, num_ano_calc_efetd, num_mes_calc_efetd, idi_tip_calc_atual, num_parc_calc_fp
- **mvtclclc_tpini**: cdn_empresa, cdn_estab, cdn_funcionario, cdn_tip_calc_verba, dat_inic_vigenc
- **mvtclclc_tpma**: cdn_empresa, cdn_estab, cdn_funcionario, cdn_tip_calc_verba, num_parc_calc_fp, num_ano_calc_efetd, num_mes_calc_efetd

---

## Tabela: movto_calcul_colab_det
**Label**: Valor
**Descrição**: Valor Movimento Calculo Efetuado

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_seq_movto, cod_verba_calc

### Índices
- **mvtclcla_tpclc**: cdn_empresa, cdn_estab, cdn_funcionario, cdn_tip_calc_verba, num_parc_calc_fp, num_ano_calc_efetd, num_mes_calc_efetd

---

## Tabela: movto_calcul_func
**Label**: Sal�rio Hora
**Descrição**: Sal�rio hora

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_ano_refer_fp, num_mes_refer_fp, idi_tip_fp, qti_parc_habilit_calc_fp, num_seq_movto_calcul_fp

### Índices
- **mvtclclf_ctgsal**: cdn_empresa, cdn_estab, cdn_categ_sal, num_ano_refer_fp, num_mes_refer_fp, idi_tip_fp, qti_parc_habilit_calc_fp
- **mvtclclf_hbltclcf**: cdn_empresa, cdn_estab, num_ano_refer_fp, num_mes_refer_fp, cdn_funcionario
- **mvtclclf_nvclc**: cdn_empresa, cdn_estab, cdn_funcionario, num_seq_movto
- **mvtclclf_py12401**: cdn_empresa, cod_rh_ccusto, cdn_estab, cdn_funcionario, num_ano_refer_fp, num_mes_refer_fp, idi_tip_fp, qti_parc_habilit_calc_fp

---

## Tabela: movto_calcul_func_intermte
**Label**: Sal�rio Hora
**Descrição**: Sal�rio hora

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_convoc_intermte, num_ano_refer_fp, num_mes_refer_fp, idi_tip_fp, qti_parc_habilit_calc_fp, num_seq_movto_calcul_fp

### Índices
- **mvtclclfint_hblt**: cdn_empresa, cdn_estab, num_ano_refer_fp, num_mes_refer_fp, cdn_funcionario

---

## Tabela: movto_calcul_normal
**Label**: Sal�rio Hora
**Descrição**: Sal�rio hora

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_mes_refer_fp, num_ano_refer_fp, idi_tip_fp, qti_parc_habilit_calc_fp, cdn_event_fp

### Índices

---

## Tabela: movto_colab_transito_fp
**Label**: Valor
**Descrição**: Valor Movimento Calculo Efetuado

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_vigenc, cdn_tip_calc_efetd, num_parc_calc_efetd, num_ano_transito_fp, num_mes_transito_fp, cod_verba_calc

### Índices

---

## Tabela: movto_estoq
**Label**: Valor Movimento
**Descrição**: Valor Movimento

### Chave Primária
- cod_ped_compra, cdn_empresa, cdn_grp_benefic, cdn_estab

### Índices
- **mvtstq_empest**: cdn_empresa, cdn_estab, num_ano_refer, num_mes_refer, cdn_grp_benefic
- **mvtstq_empgrp**: cdn_empresa, cdn_grp_benefic, cdn_estab_dest, num_ano_refer, num_mes_refer

---

## Tabela: movto_ferias_calcul
**Label**: Dependentes IRF Anterior
**Descrição**: Imagem da informa��o anterior ao �ltimo c�lculo realizado

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_ferias, cdn_tip_calc_ferias, dat_inic_period_aqst_ferias

### Índices
- **mvtfrscl_py08101**: cdn_empresa, cdn_estab, dat_pagto_salario, cdn_funcionario
- **mvtfrscl_py08102**: cdn_empresa, cdn_estab, cdn_funcionario, dat_pagto_salario
- **mvtfrscl_py08103**: cdn_empresa, cdn_estab, cdn_funcionario, dat_pagto_salario_segndo_mes
- **mvtfrscl_py08104**: cdn_empresa, cdn_estab, cdn_funcionario, dat_pagto_salario_terc_mes

---

## Tabela: movto_fgts
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_movimen_fgts

### Índices

---

## Tabela: movto_fp_control_parc
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_event_fp, num_seq_movto_fp_control_parc

### Índices
- **mvtfpcnt_ccusto**: cdn_empresa, cod_rh_ccusto
- **mvtfpcnt_py13301**: cdn_event_fp, cdn_empresa, cdn_estab, cdn_funcionario, num_seq_movto_fp_control_parc
- **mvtfpcnt_py13302**: cdn_empresa, num_ano_inic_parc_pagto_fp, num_mes_inic_movto_parcdo, num_gerac_movto_vale_transp, cdn_estab, cdn_funcionario
- **mvtfpcnt_py13304**: cdn_empresa, cdn_val_unit_fp, cdn_estab, cdn_funcionario

---

## Tabela: movto_func_tomador_serv
**Label**: Valor
**Descrição**: Valor Movimento Tarefista

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_movto_tomador, cdn_clien_rh, num_seq_movto_tomador

### Índices
- **mvtfnctm_rhclien**: cdn_empresa, cdn_estab, cdn_clien_rh

---

## Tabela: movto_histor_rat_ccusto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cod_unid_negoc, cdn_estab_trab, cod_rh_ccusto, cod_tip_mdo, num_ano_refer_fp, num_mes_refer_fp, qti_parc_rat, num_seq_movto_calcul_fp

### Índices
- **mvthstrr_empestab**: cdn_empresa, cdn_estab, cdn_funcionario, num_ano_refer_fp, num_mes_refer_fp, qti_parc_rat

---

## Tabela: movto_histor_rat_tomador
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_clien_rh, num_ano_refer_fp, num_mes_refer_fp, qti_efp, num_seq_movto_calcul_fp

### Índices
- **mvthstra_empestab**: cdn_empresa, cdn_estab, cdn_funcionario, num_ano_refer_fp, num_mes_refer_fp, qti_efp

---

## Tabela: movto_histor_ratdo_contrat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_func_centrdor, cdn_tip_contrat_func, cod_rh_ccusto, num_ano_refer_fp, num_mes_refer_fp, qti_parc_rat, num_seq_movto_calcul_fp

### Índices

---

## Tabela: movto_infor_fp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, idi_tip_movto_lote_fp, num_ano_refer_movto_lote_fp, num_mes_refer_movto_lote_fp, cdn_estab, cdn_categ_sal, idi_tip_fp, num_parc_consdo_movto_efp, num_lote_movto_fp, num_lancto_lote_fp

### Índices
- **mvtnfrfp_ccusto**: cdn_empresa, cod_rh_ccusto
- **mvtnfrfp_py12501**: cdn_empresa, cdn_estab, cdn_funcionario, num_ano_refer_movto_lote_fp, num_mes_refer_movto_lote_fp, idi_tip_fp, num_parc_consdo_movto_efp, cdn_event_fp
- **mvtnfrfp_py12502**: cdn_event_fp, cdn_empresa, cdn_estab, cdn_funcionario, idi_tip_movto_lote_fp, idi_tip_fp, num_parc_consdo_movto_efp, num_lote_movto_fp, num_lancto_lote_fp

---

## Tabela: movto_integr_benefic_fp
**Label**: Rec Prov Prox Gera��o
**Descrição**: Valor Rec�lculo Provento Pr�xima Gera��o

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_seq_integr_benefic_fp

### Índices
- **mvtntgrb_bnfcfnc**: cdn_empresa, cdn_estab, cdn_funcionario, cdn_depend_func, cdn_beneficio, cdn_regra_benefic
- **mvtntgrb_calc**: cdn_empresa, cdn_estab, cdn_funcionario, num_ano_refer_fp, num_mes_refer_fp, cdn_depend_func, cdn_beneficio, cdn_regra_benefic, cdn_formul_calc_benefic, idi_tip_lancto_movto_vale
- **mvtntgrb_py12901**: cdn_empresa, cdn_estab, cdn_beneficio, cdn_regra_benefic, cdn_prestdor_serv, cdn_funcionario, cdn_depend_func
- **mvtntgrb_py12903**: cdn_empresa, cdn_estab, cdn_prestdor_serv, cdn_beneficio, cdn_regra_benefic, cdn_funcionario, cdn_depend_func
- **mvtntgrb_py12904**: cdn_empresa, cdn_estab, cdn_funcionario, num_ano_refer_fp, num_mes_refer_fp, num_parc_calcula_movto_benefic, log_sit_calc_benefic

---

## Tabela: movto_integr_histor_chave
**Label**: Seq Integra��o TSA
**Descrição**: Valor Sequencia Integra��o TSA

### Chave Primária
- val_seq_integr_tsa, val_seq_chave

### Índices
- **mvtntgrg_ix2**: idi_tip_inform_integr, cod_chave_tsa
- **mvtntgrg_ix3**: val_seq_integr_tsa, num_seq_filho

---

## Tabela: movto_integr_histor_erro
**Label**: Seq Integra��o TSA
**Descrição**: Valor Sequencia Integra��o TSA

### Chave Primária
- val_seq_integr_tsa, val_seq_integr_erro

### Índices
- **mvtntgrf_ix2**: val_seq_integr_tsa, cod_chave_tsa

---

## Tabela: movto_integr_histor_msg
**Label**: Sequ�ncia Mensagem
**Descrição**: Sequ�ncia Mensagem

### Chave Primária
- val_seq_integr_tsa, val_seq_msg

### Índices

---

## Tabela: movto_integr_taref
**Label**: Valor Unit�rio
**Descrição**: Valor Unitario Movimento Tarefista

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_ano_refer_fp, num_mes_refer_fp, idi_tip_fp, qti_parc_habilit_calc_fp, cdn_event_fp

### Índices

---

## Tabela: movto_integr_tsa
**Label**: Seq Origem
**Descrição**: Sequencia Origem da Integra��o

### Chave Primária
- val_seq_integr_tsa

### Índices
- **mvtntgrt_ix2**: idi_tip_inform_integr, val_seq_integr_tsa
- **mvtntgrt_ix4**: idi_tip_inform_integr, idi_sit_movto_integr
- **mvtntgrt_ix5**: num_priorid, val_seq_integr_tsa
- **mvtntgrt_ix6**: dat_integr_tsa, idi_tip_inform_integr, idi_sit_movto_integr

---

## Tabela: movto_integr_tsa_chave
**Label**: Seq Integra��o TSA
**Descrição**: Valor Sequencia Integra��o TSA

### Chave Primária
- val_seq_integr_tsa, val_seq_chave

### Índices
- **mvtntgre_ix2**: idi_tip_inform_integr, cod_chave_tsa
- **mvtntgre_ix3**: val_seq_integr_tsa, num_seq_filho

---

## Tabela: movto_integr_tsa_erro
**Label**: Seq Integra��o TSA
**Descrição**: Valor Sequencia Integra��o TSA

### Chave Primária
- val_seq_integr_tsa, val_seq_integr_erro

### Índices
- **mvtntgrc_ix2**: val_seq_integr_tsa, cod_chave_tsa

---

## Tabela: movto_integr_tsa_histor
**Label**: Seq Origem
**Descrição**: Sequencia Origem da Integra��o

### Chave Primária
- val_seq_integr_tsa

### Índices
- **mvtntgra_ix2**: idi_tip_inform_integr, val_seq_integr_tsa
- **mvtntgra_ix4**: idi_tip_inform_integr, idi_sit_movto_integr
- **mvtntgra_ix5**: num_priorid, val_seq_integr_tsa
- **mvtntgra_ix6**: dat_integr_tsa, idi_tip_inform_integr, idi_sit_movto_integr

---

## Tabela: movto_integr_tsa_msg
**Label**: Sequ�ncia Mensagem
**Descrição**: Sequ�ncia Mensagem

### Chave Primária
- val_seq_integr_tsa, val_seq_msg

### Índices

---

## Tabela: movto_interm_fasb_cmcac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_ano_refer_calc_efetd, num_mes_refer_calc_efetd, idi_tip_fp, num_parc_movto_fasb_cmcac, cdn_event_fp, dat_pagto_efet_efp

### Índices

---

## Tabela: movto_investig_acidte
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, num_acidte_ambntal, dat_movto_investig, hra_movto_investig

### Índices

---

## Tabela: movto_mpe_refeit
**Label**: Valor Movimento
**Descrição**: Informe o valor do movimento

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_marcac_ptoelet, num_horar_marcac_ptoelet

### Índices
- **mvtmprfd_ix7**: val_control_marcac
- **mvtmprft_imp**: nom_arq_mpe_imptdo, dat_import_arq_mpe, num_hora_corren_import_mpe, num_seq_import
- **mvtmprft_integr**: dat_refer_movto_mpe_refei, cdn_empresa, cdn_estab, cdn_funcionario, dat_marcac_ptoelet
- **mvtmprft_ix8**: num_seqcial_msa
- **mvtmprft_tm05801**: cdn_empresa, cdn_estab, cdn_funcionario, cod_funcao_relogio_pto, dat_refer_movto_mpe_refei, dat_marcac_ptoelet
- **mvtmprft_tm05802**: cdn_empresa, cdn_estab, cdn_funcionario, cod_mes_ano_refer_fp, dat_refer_movto_mpe_refei
- **mvtmprft_tm05804**: cdn_empresa, cdn_estab, cdn_funcionario, dat_proces_mpe

---

## Tabela: movto_pagto_transp_rural
**Label**: Pagamento Transporte
**Descrição**: Valor Pagamento Transporte

### Chave Primária
- cdn_empresa, cdn_transpdor_rural, cdn_estab, num_ano_refer, num_mes_refer

### Índices
- **mvtpgttr_estab**: cdn_empresa, cdn_estab, cdn_transpdor_rural, num_ano_refer, num_mes_refer

---

## Tabela: movto_pendcia_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_pendcia_prestdor_serv, num_ano_refer_fp, num_mes_refer_fp

### Índices
- **mvtpndcf_pndcprst**: cdn_pendcia_prestdor_serv

---

## Tabela: movto_pendcia_prestdor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, idi_orig_contratac_func, cdn_prestdor_serv, dat_inic_valid, cdn_pendcia_prestdor_serv, num_ano_refer_fp, num_mes_refer_fp

### Índices

---

## Tabela: movto_ppr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_param_calc_ppr, cdn_empresa, cdn_estab, cdn_funcionario, num_mes_refer_calc_efetd, num_ano_refer_calc_efetd, idi_tip_folha_pagto_ppr, qti_parc_habilit_calc_fp, cdn_event_fp

### Índices
- **movtoppr_eventfp**: cdn_event_fp

---

## Tabela: movto_premio_taref
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_ano_refer, num_mes_refer

### Índices
- **mvtprmtr_transp**: cdn_empresa, cdn_transpdor_rural, num_ano_refer, num_mes_refer, cdn_estab, cdn_funcionario

---

## Tabela: movto_ptoelet
**Label**: Valor Movimento
**Descrição**: Informe o valor do movimento

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_ano_refer_fp, num_mes_refer_fp, idi_tip_fp_calcul, num_parc_calc_movto_ptoelet, cdn_efp

### Índices
- **mvtptlt_tm05002**: cdn_empresa, cdn_estab, cdn_funcionario, idi_tip_movto_ptoelet, num_ano_refer_fp, num_mes_refer_fp

---

## Tabela: movto_ptoelet_intermte
**Label**: Valor Movimento
**Descrição**: Informe o valor do movimento

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_convoc_intermte, num_ano_refer_fp, num_mes_refer_fp, idi_tip_fp_calcul, num_parc_calc_movto_ptoelet, cdn_efp

### Índices

---

## Tabela: movto_rat_prestdor_serv
**Label**: Valor Rateio
**Descrição**: Valor Movimento Rateio Prestador

### Chave Primária
- cdn_empresa, cdn_estab, cdn_prestdor_serv, dat_refer_movto_prestdor_serv, idi_tip_pessoa, cod_id_feder, cod_ser_docto_rh, cod_unid_negoc, num_docto_movto_prestdor_serv, cdn_estab_trab, cod_rh_ccusto, cod_tip_mdo

### Índices
- **mvtrtprs_esttrab**: cdn_empresa, cdn_estab_trab, cdn_prestdor_serv, cod_rh_ccusto, dat_refer_movto_prestdor_serv, idi_tip_pessoa, cod_id_feder
- **mvtrtprs_mvtsrvpr**: cdn_empresa, cdn_estab, cdn_prestdor_serv, dat_refer_movto_prestdor_serv, idi_tip_pessoa, cod_id_feder, cod_ser_docto_rh, num_docto_movto_prestdor_serv

---

## Tabela: movto_reserva_refeit
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_refer_calend, cod_funcao_relogio_pto, num_horar_marcac_ptoelet

### Índices

---

## Tabela: movto_serv_prestad_terc
**Label**: Valor Tribut�vel
**Descrição**: Valor l�quido tribut�vel para IRF

### Chave Primária
- cdn_empresa, cdn_estab, cdn_prestdor_serv, dat_refer_movto_prestdor_serv, idi_tip_pessoa, cod_id_feder, cod_ser_docto_rh, num_docto_movto_prestdor_serv

### Índices
- **mvtsrvpr_datpagto**: cdn_empresa, dat_pagto_prestdor, cdn_prestdor_serv
- **mvtsrvpr_prstdrsr**: cdn_empresa, cdn_prestdor_serv, cdn_estab, dat_refer_movto_prestdor_serv
- **mvtsrvpr_py13601**: cdn_empresa, cod_rh_ccusto, cdn_estab, dat_refer_movto_prestdor_serv, cod_id_feder
- **mvtsrvpr_py13602**: cdn_empresa, dat_pagto_efet_efp, log_pago_pelo_sist, cdn_control_gerac_movto_rescis
- **mvtsrvpr_py13603**: cdn_empresa, cdn_estab, cdn_plano_lotac, cod_unid_lotac, idi_tip_pessoa, cod_id_feder, dat_refer_movto_prestdor_serv
- **mvtsrvpr_py13605**: cdn_empresa, cdn_estab, log_pago_pelo_sist, dat_pagto_efet_efp, cdn_control_gerac_movto_rescis, cod_id_feder, cod_ser_docto_rh
- **mvtsrvpr_py13606**: cdn_empresa, idi_tip_pessoa, cod_id_feder, dat_pagto_efet_efp

---

## Tabela: movto_transpdor_rural
**Label**: Valor
**Descrição**: Valor Transporte Rural

### Chave Primária
- cdn_empresa, cdn_transpdor_rural, dat_transp_rural, cdn_lin_transp_rural

### Índices
- **mvttrnsp_lntrnspr**: cdn_lin_transp_rural

---

## Tabela: movto_turma_educnal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_ano_refer_fp, num_mes_refer_fp, idi_tip_fp, num_lote_movto_fp, num_lancto_lote_fp

### Índices
- **mvttrmdc_event_fp**: cdn_empresa, cdn_estab, cdn_funcionario, num_ano_refer_fp, cdn_tip_contrat_func, cdn_event_fp
- **mvttrmdc_rh_ccusto**: cdn_empresa, cdn_estab, cdn_funcionario, cod_rh_ccusto

---

## Tabela: movto_turma_rural
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_estab, cdn_transpdor_rural, cdn_turma_rural, dat_movto_agric

### Índices

---

## Tabela: movto_vale_transp
**Label**: Rec Prov Prox Gera��o
**Descrição**: Valor Rec�lculo Provento Pr�xima Gera��o

### Chave Primária
- cdn_empresa, cdn_estab, cdn_beneficio, cdn_funcionario, cdn_lin_vale_transp, idi_tip_lancto_movto_vale, num_ano_refer_desc_vale_fp, num_mes_refer_desc_vale_transp, num_seq_lancto_movto_vale

### Índices
- **mvtvltrn_calc**: cdn_empresa, cdn_estab, num_ano_refer_desc_vale_fp, num_mes_refer_desc_vale_transp, cdn_beneficio, cdn_funcionario, idi_tip_lancto_movto_vale
- **mvtvltrn_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario, cdn_beneficio, cdn_lin_vale_transp
- **mvtvltrn_periodo**: cdn_empresa, cdn_estab, cdn_beneficio, idi_tip_lancto_movto_vale, cdn_lin_vale_transp, dat_final_period_vale_transp
- **mvtvltrn_prdrqvlt**: cdn_empresa, cdn_estab, cdn_beneficio, num_ano_refer_desc_vale_fp, num_mes_refer_desc_vale_transp, idi_tip_lancto_movto_vale, cdn_lin_vale_transp
- **mvtvltrn_py13501**: cdn_empresa, cdn_estab, cdn_beneficio, cdn_funcionario, cdn_lin_vale_transp, dat_movto_vale_transp
- **mvtvltrn_py13502**: cdn_empresa, cdn_estab, cdn_beneficio, cdn_funcionario, num_ano_refer_desc_vale_fp, num_mes_refer_desc_vale_transp, dat_pagto_efet_efp
- **mvtvltrn_py13503**: cdn_empresa, cdn_estab, cdn_beneficio, cdn_funcionario, idi_tip_lancto_movto_vale, dat_pagto_efet_efp
- **mvtvltrn_py13505**: cdn_empresa, num_ano_refer_desc_vale_fp, num_mes_refer_desc_vale_transp, num_gerac_movto_vale_transp
- **mvtvltrn_py13506**: cdn_empresa, cdn_lin_vale_transp, cdn_estab, cdn_beneficio, cdn_funcionario, idi_tip_lancto_movto_vale

---

## Tabela: movto_visitante_aces
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_planta_edificio, cdn_local_aces, dat_entr_visitante, num_hora_entr_visitante, num_ocor_visitante

### Índices
- **mvtvstnt_autoriz**: cdn_visitante, dat_entr_visitante, idi_tip_pessoa_autoriz, cdn_empres_visit, cdn_estab_autoriz, cdn_func_autoriz, cdn_prestdor_autoriz, cdn_compon_autoriz
- **mvtvstnt_data**: cdn_visitante, dat_entr_visitante, dat_saida_visitante
- **mvtvstnt_saida**: dat_saida_visitante, num_cartao_pto_func
- **mvtvstnt_saida2**: cod_cartao_aces, dat_saida_visitante
- **mvtvstnt_saida_planta**: cdn_planta_edificio, num_cartao_pto_func, dat_saida_visitante
- **mvtvstnt_visit**: cdn_visitante, dat_entr_visitante, idi_tip_pessoa_visit, cdn_empres_visit, cdn_estab_visit, cdn_func_visit, cdn_prestdor_visit, cdn_compon_visit
- **mvtvstnt_visita**: cdn_planta_edificio, cdn_local_aces, idi_sit_visit, cdn_visitante, dat_entr_visitante, num_hora_entr_visitante, num_ocor_visitante
- **mvtvstnt_vst**: cdn_planta_edificio, cdn_local_aces, dat_entr_visitante, num_hora_entr_visitante, cdn_visitante, dat_saida_visitante, num_hora_saida_visitante, idi_sit_visit

---

## Tabela: msa_comando_exec_integr
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_comando_exec

### Índices
- **mscmndxc_rep**: cod_rep
- **mscmndxc_status**: idi_status_comando

---

## Tabela: msa_control_marcac
**Label**: Perfil Acesso
**Descrição**: Perfil Acesso

### Chave Primária
- val_control_marcac

### Índices
- **mscntrld_ix8**: cod_nsr, cod_rep, cod_pis_msa, dat_marcac_aces
- **mscntrld_ix9**: cod_nsr, cod_rep, cod_cpf_func, dat_marcac_aces
- **mscntrlm_func**: cod_pis_msa
- **mscntrlm_import**: log_import_produt
- **mscntrlm_lote**: cod_lote
- **mscntrlm_mrk1**: cod_relogio_ext_chave, cod_nsr
- **mscntrlm_mrk2**: cod_rep, cod_nsr
- **mscntrlm_rep**: cod_rep

---

## Tabela: msa_empres_aces
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_id_feder, cod_id_previd_social, cdn_cnpj_raiz, cdn_cnpj_sufixo, cdn_cnpj_digito_verfdor

### Índices

---

## Tabela: msa_event
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_nsr, cod_rep

### Índices
- **msaevent_rep**: cod_rep

---

## Tabela: msa_func_aces
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_pis_msa, dat_admis_func, cdn_cnpj_digito_verfdor, cdn_cnpj_sufixo, cdn_cnpj_raiz, cod_id_previd_social, cod_id_feder

### Índices
- **msfnccs_desligto**: cdn_cnpj_digito_verfdor, cdn_cnpj_sufixo, cdn_cnpj_raiz, cod_id_previd_social, cod_id_feder, dat_desligto_func
- **msfnccs_empresa**: cod_id_feder, cod_id_previd_social, cdn_cnpj_raiz, cdn_cnpj_sufixo, cdn_cnpj_digito_verfdor

---

## Tabela: msa_func_aces_cracha
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_cracha_aces, dat_inic_valid, num_horar_inic_valid_cracha, dat_admis_func, cod_pis_msa, cod_id_feder, cod_id_previd_social, cdn_cnpj_raiz, cdn_cnpj_sufixo, cdn_cnpj_digito_verfdor

### Índices
- **msfnccsc_func**: cod_pis_msa, dat_admis_func

---

## Tabela: msa_relogio_aces
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_rep

### Índices
- **msrlgcs_disposit**: num_disposit_control_aces
- **msrlgcs_empresa**: cod_id_feder, cod_id_previd_social, cdn_cnpj_raiz, cdn_cnpj_sufixo, cdn_cnpj_digito_verfdor
- **msrlgcs_modelo**: idi_vende, cdn_model_disposit

---

## Tabela: msa_relogio_model_aces
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- idi_vende, cdn_model_disposit

### Índices

---

## Tabela: nao_cfem_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_nao_cfem

### Índices

---

## Tabela: natur_acidte_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_natur_acidte_ambntal

### Índices

---

## Tabela: natur_estab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- idi_tip_natur_estab, cdn_natur_estab

### Índices

---

## Tabela: natur_lesao_acidte
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_natur_acidtrab

### Índices

---

## Tabela: nexo_ruido
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_nexo_ruido

### Índices

---

## Tabela: niv_aces_grp_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_grp_usuar

### Índices
- **nvcsgrps_nvhrfncn**: num_seq_niv_hier_funcnal
- **nvcsgrps_tpnddprt**: num_niv_unid_lotac

---

## Tabela: niv_cargo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_niv_cargo

### Índices

---

## Tabela: niv_hier_funcnal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_niv_hier_funcnal

### Índices
- **nvhrfncn_py09001**: num_seq_niv_hier_funcnal

---

## Tabela: niv_hier_politic_parc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_niv_hier_funcnal

### Índices

---

## Tabela: niv_requis_cargo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_niv_requis_cargo

### Índices

---

## Tabela: niv_signific
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, idi_tip_signific, num_niv_signific

### Índices
- **nvsgnfc_ds**: cdn_empresa, idi_tip_signific, des_niv_signific
- **nvsgnfc_pntc**: cdn_empresa, idi_tip_signific, num_pontuac_niv_signific

---

## Tabela: niv_unid_organ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_niv_unid_organ

### Índices
- **nvndrgn_niv**: num_niv_unid_organ

---

## Tabela: norma_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_norma_ambntal, dat_emis_norma

### Índices
- **nrmmbntl_assntnra**: cod_assunto_norma_ambntal

---

## Tabela: norma_epi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_norma_segur, cod_epi

### Índices
- **normaepi_eqptprtc**: cdn_empresa, cod_epi

---

## Tabela: norma_proj_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_norma_ambntal, dat_emis_norma, cod_proj_ambntal

### Índices
- **nrmprjmb_prjmbntl**: cdn_empresa, cod_proj_ambntal

---

## Tabela: norma_segur
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_norma_segur

### Índices
- **nrmsgr_cmpnssmt**: num_compon_sesmt
- **nrmsgr_txtrcbnr**: cdn_empresa, num_text_recibo_norma_segur

---

## Tabela: normal_exam
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_exam_medic, dat_inic_normal

### Índices

---

## Tabela: normsegur_entreg_recibo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_norma_segur, cdn_empres_func, cdn_estab_func, cdn_funcionario, dat_assin_recibo_norma_segur

### Índices
- **nrmsgrnt_fncnr**: cdn_empres_func, cdn_estab_func, cdn_funcionario

---

## Tabela: notif_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_notif_ambntal

### Índices
- **ntfmbntl_mtvtc**: cod_motiv_autuac
- **ntfmbntl_orgmssrm**: cod_orgao_emissor_notif

---

## Tabela: notif_licenc_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_licenc_ambntal, cod_orgao_emissor_notif, dat_emis_licenc, cdn_empresa, cdn_notif_ambntal

### Índices
- **ntflcncm_ntfmbntl**: cdn_empresa, cdn_notif_ambntal

---

## Tabela: notif_nao_cfem
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_notif_ambntal, num_seq_notif_nao_cfem

### Índices
- **ntfncfm_ncfmmbnt**: cod_nao_cfem

---

## Tabela: notif_norma_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_norma_ambntal, dat_emis_norma, cdn_notif_ambntal

### Índices
- **ntfnrmmb_ntfmbntl**: cdn_empresa, cdn_notif_ambntal

---

## Tabela: notif_passiv_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_notif_ambntal, cod_passiv_ambntal

### Índices
- **ntfpssvm_pssvmbnt**: cod_passiv_ambntal, cdn_empresa

---

## Tabela: obj_gerador_acidte
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_obj_gerador_acidte

### Índices

---

## Tabela: obj_inspec_ambntal
**Label**: Resultado Inspe��o
**Descrição**: Valor Resultado Inspe��o

### Chave Primária
- cod_inspec_ambntal, num_obj_inspec_ambntal, cdn_empresa, cod_item_inspec, dat_restdo_analis, hra_restdo_analis

### Índices
- **objnspcm_inspcmbn**: cod_inspec_ambntal, cdn_empresa
- **objnspcm_itmnspcm**: cod_item_inspec

---

## Tabela: obj_inspec_ambntal_nao_cfe
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_inspec_ambntal, num_obj_inspec_ambntal, cdn_empresa, cod_item_inspec, dat_restdo_analis, hra_restdo_analis, cod_nao_cfem

### Índices

---

## Tabela: obj_licenc_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_obj_licenc

### Índices

---

## Tabela: obj_visitante_aces
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_planta_edificio, cdn_local_aces, dat_entr_visitante, num_hora_entr_visitante, num_ocor_visitante, cdn_tip_obj_visitante, num_seq

### Índices

---

## Tabela: objet_unid_instruc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_curso_trein, cdn_unid_instruc, cdn_objet_trein

### Índices

---

## Tabela: objorg
**Label**: Situa��o Inicial
**Descrição**: Valor Situa��o Inicial

### Chave Primária
- cdn_empresa, cdn_plano_organ, cdn_objorg

### Índices
- **objorg_est**: cdn_plano_organ, cdn_objorg_sup, num_hier_estrut_objorg
- **objorg_estrtrpr**: num_ident_estrut_reporte_pos
- **objorg_estrut**: cdn_empresa, cdn_plano_organ, num_seq_estrut_hier_objorg
- **objorg_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario
- **objorg_indcrgn**: cdn_indic_organ
- **objorg_nivhier**: cdn_empresa, cdn_plano_organ, num_niv_hier_objorg
- **objorg_objrgvrb**: cod_objorg_verbo
- **objorg_rhpssfsc**: num_pessoa_fisic
- **objorg_sup**: cdn_empresa, cdn_plano_organ, cdn_objorg_sup

---

## Tabela: objorg_acao
**Label**: Resultado Realizado
**Descrição**: Resultado Final da A��o em Termos Quantitativos

### Chave Primária
- cdn_empresa, cdn_plano_organ, cdn_objorg, num_acao_objorg

### Índices
- **objrgc_avpstprs**: cdn_tip_restdo_avpes
- **objrgc_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario
- **objrgc_objrgndm**: cod_objorg_unid_medid
- **objrgc_objrgqlf**: cdn_qualific_acao_objorg
- **objrgc_rhpssfsc**: num_pessoa_fisic

---

## Tabela: objorg_acao_anom
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_plano_organ, cdn_objorg, num_acao_objorg, dat_objorg_acao_anom, num_objorg_acao_anom

### Índices
- **objrgcnm_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario
- **objrgcnm_rhpssfsc**: num_pessoa_fisic

---

## Tabela: objorg_depen
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_plano_organ, cdn_objorg, num_acao_objorg, cdn_plano_organ_filho, cdn_objorg_filho, num_acao_objorg_filho

### Índices
- **objrgdpn_filho**: cdn_empresa, cdn_plano_organ_filho, cdn_objorg_filho, num_acao_objorg_filho, cdn_plano_organ, cdn_objorg, num_acao_objorg

---

## Tabela: objorg_estrut_reporte_pos
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_plano_organ, cdn_objorg, num_ident_estrut_reporte_pos, cdn_estrut_reporte_grp

### Índices
- **objrgstr_estrtrpr**: num_ident_estrut_reporte_pos

---

## Tabela: objorg_item_control_acao
**Label**: Resultado Realizado
**Descrição**: Resultado Final da A��o em Termos Quantitativos

### Chave Primária
- cdn_empresa, cdn_plano_organ, cdn_objorg, num_acao_objorg, cdn_item_control_acao

### Índices
- **objrgtmc_avpstprs**: cdn_tip_restdo_avpes

---

## Tabela: objorg_item_control_relacdo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_plano_organ, cdn_objorg, num_acao_objorg, cdn_item_control_acao, cdn_plano_organ_filho, cdn_objorg_filho, num_acao_objorg_filho, cdn_item_control_acao_filho

### Índices
- **objrgtma_objrgtmc**: cdn_empresa, cdn_plano_organ_filho, cdn_objorg_filho, num_acao_objorg_filho, cdn_item_control_acao_filho

---

## Tabela: objorg_nec_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_plano_organ, cdn_objorg, num_objorg_nec_trein

### Índices
- **objrgnct_crstrn**: cdn_empresa, cdn_plano_organ, cdn_objorg, cdn_curso_trein
- **objrgnct_hbcmpprb**: cdn_aperfmto

---

## Tabela: objorg_nova_prev_acao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_plano_organ, cdn_objorg, num_acao_objorg, num_nova_prev_objet_hur

### Índices

---

## Tabela: objorg_pessoa_aces
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_plano_organ, cdn_objorg, num_acao_objorg, num_pessoa_fisic

### Índices

---

## Tabela: objorg_pontuac_qualific
**Label**: Pontua��o
**Descrição**: Pontua��o Equivalente

### Chave Primária
- cdn_qualific_acao_objorg, dat_inic_valid, val_inic_acao_objorg

### Índices

---

## Tabela: objorg_pto_control_acao
**Label**: Resultado Realizado
**Descrição**: Resultado Final da A��o em Termos Quantitativos

### Chave Primária
- cdn_empresa, cdn_plano_organ, cdn_objorg, num_acao_objorg, cdn_item_control_acao, dat_prev_control_acao

### Índices
- **objrgptc_avpstprs**: cdn_tip_restdo_avpes

---

## Tabela: objorg_qualific_acao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_qualific_acao_objorg

### Índices

---

## Tabela: objorg_respons
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_objorg_respons

### Índices

---

## Tabela: objorg_sel_avaldor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_plano_organ, cdn_objorg, cdn_estab, cdn_funcionario, dat_inic_valid

### Índices
- **objrgslv_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario

---

## Tabela: objorg_sel_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_plano_organ, cdn_objorg, cdn_estab, cdn_funcionario, dat_inic_valid

### Índices
- **objrgslf_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario

---

## Tabela: objorg_sel_time_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_plano_organ, cdn_objorg, cdn_time_trab, dat_inic_valid

### Índices
- **objrgslt_tmtrbrh**: cdn_time_trab

---

## Tabela: objorg_sel_unid_lotac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_plano_organ, cdn_objorg, cdn_plano_lotac, cod_unid_lotac, dat_inic_valid

### Índices
- **objrgsld_unddprt**: cod_unid_lotac
- **objrgsld_unddprtp**: cdn_plano_lotac, cod_unid_lotac

---

## Tabela: objorg_unid_medid_restdo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_objorg_unid_medid

### Índices

---

## Tabela: objorg_verbo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_objorg_verbo

### Índices

---

## Tabela: obs_discipl_fp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_obs_func

### Índices

---

## Tabela: obs_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_obs_func, dat_obs_func

### Índices
- **obsfunc_py15801**: cdn_empresa, cdn_obs_func

---

## Tabela: oportun_fut
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_candempr, cdn_req_pessoal

### Índices
- **oprtnft_rqpssl**: cdn_empresa, cdn_estab, cdn_req_pessoal

---

## Tabela: oportun_fut_etap
**Label**: Nota Etapa
**Descrição**: Valor Nota Etapa Teste Candidato Emprego

### Chave Primária
- cdn_empresa, cdn_estab, cdn_candempr, cdn_req_pessoal, cdn_etap_sel_candempr

### Índices

---

## Tabela: orgao_emissor_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_orgao_emissor_notif

### Índices

---

## Tabela: orig_acidte_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_orig_acidte_trab

### Índices

---

## Tabela: orig_dest_movto_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq_planilha_orig, num_seq_variac_orig, cod_clas_cargo_orig, num_seq_planilha_dest, num_seq_variac_dest, cod_clas_cargo_dest, num_ano_refer, num_mes_refer

### Índices
- **orgdstmv_1**: num_seq_planilha_dest, num_seq_variac_dest, cod_clas_cargo_dest, num_seq_planilha_orig, num_seq_variac_orig, cod_clas_cargo_orig

---

## Tabela: orig_inspec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_orig_inspec

### Índices

---

## Tabela: orig_licenc_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_orig_licenc_ambntal

### Índices

---

## Tabela: orig_mdo_estab
**Label**: Faixa Matr�cula Inicial
**Descrição**: Valor - Inteiro Faixa Matricula Inicial

### Chave Primária
- cdn_empresa, cdn_estab, idi_orig_contratac_func, cdn_prestdor_serv, dat_inic_valid

### Índices

---

## Tabela: orig_passiv_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_orig_passiv_ambntal

### Índices

---

## Tabela: pagto_padr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_pagto_padr

### Índices

---

## Tabela: pagto_prestdor_serv
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_prestdor_serv, dat_pagto_efet_efp, cdn_funcionario, num_seq_pagto_prestdor_serv

### Índices
- **pgtprstd_py13902**: cdn_empresa, cdn_prestdor_serv, dat_pagto_efet_efp, cdn_beneficio, cdn_estab

---

## Tabela: palim
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_palim

### Índices

---

## Tabela: par_marcac_ptoelet
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_proces_mpe, num_horar_inic_proces_mpe

### Índices
- **prmrccpt_tm04901**: cdn_empresa, cdn_estab, cdn_funcionario, dat_proces_mpe, idi_sit_mpe, idi_tip_ocor_mpe
- **prmrccpt_tm04903**: cdn_empresa, cdn_estab, cdn_funcionario, dat_proces_mpe, num_horar_inic_sit_afast
- **prmrccpt_tm04904**: dat_proces_mpe, idi_sit_mpe, cdn_empresa, cdn_estab, cdn_funcionario
- **prmrccpt_tm04905**: dat_proces_mpe, idi_tip_ocor_mpe, cdn_empresa, cdn_estab, cdn_funcionario
- **prmrccpt_tm04906**: dat_proces_mpe, cdn_sit_afast_func, cdn_empresa, cdn_estab, cdn_funcionario

---

## Tabela: param_adm_rh
**Label**: % M�ximo 13� F�rias
**Descrição**: Valor Percentual M�ximo 13o F�rias

### Chave Primária
- log_utiliza_visao

### Índices

---

## Tabela: param_adm_trein
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa

### Índices

---

## Tabela: param_adm_trein_aux
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa

### Índices

---

## Tabela: param_alerta_proces
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab

### Índices

---

## Tabela: param_benefic_estab
**Label**: Vl Unit�rio Benef�cio
**Descrição**: Valor Quantidade Movimento Benef�cio

### Chave Primária
- cdn_empresa, cdn_estab, cdn_beneficio, num_ano_inic_benefic_estab, num_mes_inic_benefic_estab, num_seq_niv_hier_funcnal_inic

### Índices
- **prmbnfcs_efpbnfc**: cdn_empresa, cdn_estab, cdn_beneficio, cdn_formul_benefic_padr_func
- **prmbnfcs_nvhrfncn**: num_seq_niv_hier_funcnal_inic

---

## Tabela: param_calc_categ_sal
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_categ_sal

### Índices

---

## Tabela: param_calc_empres_rh
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa

### Índices

---

## Tabela: param_calc_ppr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_param_calc_ppr

### Índices

---

## Tabela: param_calc_rh_estab
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab

### Índices

---

## Tabela: param_cenar_ativid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_plano_prh, cdn_cenar_prh, num_seq_param_cenar_prh, cdn_ativid_prefer

### Índices

---

## Tabela: param_cenar_avaliac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_plano_prh, cdn_cenar_prh, num_seq_param_cenar_prh, cdn_avpes_padr

### Índices

---

## Tabela: param_cenar_cargo_prh
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_plano_prh, cdn_cenar_prh, num_seq_param_cenar_prh, cdn_cargo_basic, cdn_niv_cargo

### Índices

---

## Tabela: param_cenar_conhecto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_plano_prh, cdn_cenar_prh, num_seq_param_cenar_prh, cdn_empresa, cdn_grp_conhecto_experien, cdn_conhecto_experien

### Índices

---

## Tabela: param_cenar_curso
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_plano_prh, cdn_cenar_prh, num_seq_param_cenar_prh, num_seq_curso, cdn_tip_curso_trein

### Índices

---

## Tabela: param_cenar_idiom_prh
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_plano_prh, cdn_cenar_prh, num_seq_param_cenar_prh, cod_idioma

### Índices

---

## Tabela: param_cenar_prh
**Label**: Tempo Casa
**Descrição**: Tempo Casa

### Chave Primária
- cdn_plano_prh, cdn_cenar_prh, num_seq_param_cenar_prh

### Índices

---

## Tabela: param_conex_base_dados
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_base_dados_conex, nom_fisic_base_dados

### Índices

---

## Tabela: param_control_aces
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa

### Índices

---

## Tabela: param_control_atraso
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_clas_func, cdn_empresa, cdn_estab, cdn_categ_sal

### Índices

---

## Tabela: param_ctbz_mdo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_tip_mdo, idi_tip_safra_agric

### Índices
- **prmctbzm_tipmdo**: cod_tip_mdo

---

## Tabela: param_ctbz_unid_negoc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_unid_negoc

### Índices

---

## Tabela: param_desenv_pessoal
**Label**: Valor Pontua��o Hab/Comp
**Descrição**: Valor de Uma Unidade de Pontua��o da Habilidade/Compet�ncia

### Chave Primária
- cdn_empresa

### Índices

---

## Tabela: param_empres_jsl
**Label**: Percentual Sal�rio M�nimo
**Descrição**: Percentual Sal�rio M�nimo

### Chave Primária
- cdn_empresa

### Índices

---

## Tabela: param_empres_rh
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa

### Índices

---

## Tabela: param_empres_tma
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa

### Índices

---

## Tabela: param_exam_periodic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, num_faixa_etaria_func

### Índices

---

## Tabela: param_ferias_coletiv
**Label**: Perc Adiant 13�
**Descrição**: Percentual de adiantamento do 13� sal�rio

### Chave Primária
- cdn_empresa, cod_programac_ferias_coletiv

### Índices

---

## Tabela: param_flexibiliz_regra_calc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_param_calc

### Índices

---

## Tabela: param_folha_educnal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa

### Índices

---

## Tabela: param_gerac_programac_period
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_pcmso, num_seq_programac_period

### Índices

---

## Tabela: param_geral_rh
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_format_unid_lotac

### Índices

---

## Tabela: param_gerencto_diretriz
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa

### Índices
- **prmgrnct_avpsrgms**: cdn_avpes_cargo
- **prmgrnct_avpsrgms2**: cdn_avpes_meta

---

## Tabela: param_gestao_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa

### Índices

---

## Tabela: param_glob_rh
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_emprsial

### Índices
- **prmglbrh_emprinc**: cdn_empres_princ

---

## Tabela: param_grp_pagto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_grp_pagto

### Índices

---

## Tabela: param_integr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa

### Índices

---

## Tabela: param_integr_ext
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa

### Índices

---

## Tabela: param_integr_serv
**Label**: Sequ�ncia
**Descrição**: N�mero de Seq��ncia

### Chave Primária
- num_seq

### Índices

---

## Tabela: param_integr_tsa
**Label**: Seq Par�metros
**Descrição**: Valor Seq Par�metros

### Chave Primária
- cdn_empresa, val_seq_param

### Índices

---

## Tabela: param_item_analis
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_obj_inspec_ambntal, cod_item_inspec, idi_tip_inspec_ambntal, cod_orgao_emissor_notif

### Índices

---

## Tabela: param_item_analis_restdo
**Label**: Resultado Inspe��o
**Descrição**: Resultado Inicial Inspe��o

### Chave Primária
- num_obj_inspec_ambntal, cod_item_inspec, idi_tip_inspec_ambntal, cod_orgao_emissor_notif, cod_restdo_coleta

### Índices

---

## Tabela: param_item_norma
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_norma_ambntal, dat_emis_norma, num_obj_inspec_ambntal, cod_item_inspec, idi_tip_inspec_ambntal, cod_orgao_emissor_notif, cod_requis_norma_ambntal, dat_analis_requis

### Índices
- **prmtmnrm_prmtmnls**: num_obj_inspec_ambntal, cod_item_inspec, idi_tip_inspec_ambntal, cod_orgao_emissor_notif

---

## Tabela: param_medic_segur
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa

### Índices
- **prmmdcsg_atvdmprs**: cdn_ativid_estab_rais
- **prmmdcsg_exmmdc**: cod_exam_medic_periodic
- **prmmdcsg_mtvcnsmd**: cod_motiv_consmedic
- **prmmdcsg_rhpssfsc**: num_medic_atndte_ambumed
- **prmmdcsg_tpcrstrn**: cdn_tip_curso_trein
- **prmmdcsg_txttstdm**: num_text_atstdo_medic

---

## Tabela: param_modul_agric
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa

### Índices

---

## Tabela: param_obj_inspec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_obj_inspec_ambntal

### Índices

---

## Tabela: param_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_cenar_orcto_corren

### Índices

---

## Tabela: param_prh
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_plano_organ_atual

### Índices

---

## Tabela: param_proces_mpe
**Label**: Gerar Arquivo Log T�cnico
**Descrição**: Hora �ltima Atualiza��o

### Chave Primária
- cdn_empresa, idi_proces

### Índices

---

## Tabela: param_proces_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab

### Índices

---

## Tabela: param_regra_ferias
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, num_dias_abono, num_dias_gozo, num_dias_sdo

### Índices

---

## Tabela: param_seq_regra
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_param_calc_ppr, idi_descr_regra_ppr

### Índices
- **prmsqrgr_seq**: num_seq_regra_ppr
- **prmsqrgr_tipo**: idi_descr_regra_ppr

---

## Tabela: param_slr
**Label**: Percentual Min Habilidad Cargo
**Descrição**: Valor Percentual M�nimo Habilidade Cargo

### Chave Primária
- cdn_empresa

### Índices

---

## Tabela: param_slr_cargo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_cargo_basic, cdn_niv_cargo

### Índices

---

## Tabela: param_slr_inf_sal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_prog_dtsul

### Índices

---

## Tabela: param_slr_tip_curso_formac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_tip_curso_formac

### Índices

---

## Tabela: param_tip_guia
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_fpas

### Índices

---

## Tabela: parc_politic_niv_hier
**Label**: Perc M�ximo
**Descrição**: Valor Percentual M�ximo Altera��o

### Chave Primária
- cdn_niv_hier_funcnal, num_parc

### Índices

---

## Tabela: parecer_avaliac_candempr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_parecer_etap_candempr

### Índices

---

## Tabela: parte_atgdo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_consmedic, num_ficha_medic, cod_parte_corpo_atgdo

### Índices
- **prttgd_prtcrp**: cod_parte_corpo_atgdo

---

## Tabela: parte_corpo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_parte_corpo_atgdo

### Índices

---

## Tabela: partic_reuniao_brigincen
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_brigincen, num_reuniao_brigincen, cdn_estab, cdn_funcionario

### Índices
- **prtcrnbr_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario

---

## Tabela: partic_reuniao_cipa
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_area_segur, num_mandat_cipa, num_reuniao_cipa, cdn_funcionario, cdn_empres_func_compon, cdn_estab_func_compon

### Índices
- **prtcrncp_cmpncp**: cdn_empresa, cdn_estab, cod_area_segur, num_mandat_cipa, cdn_empres_func_compon, cdn_estab_func_compon, cdn_funcionario
- **prtcrncp_fnccpsnd**: cdn_funcao_cipa_sind

---

## Tabela: participan_event_sipat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_sipat, cod_event_sipat, dat_event_sipat, hra_event_sipat, cdn_estab_func_participan, cdn_func_participan

### Índices
- **prtcpnvn_fncnr**: cdn_empresa, cdn_estab_func_participan, cdn_func_participan

---

## Tabela: participan_prog_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_prog_trein, num_pessoa_fisic

### Índices
- **prtcpnpr_rhpssfsc**: num_pessoa_fisic

---

## Tabela: participan_prog_trein_aux
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_prog_trein, num_pessoa_fisic

### Índices

---

## Tabela: passiv_ambntal
**Label**: Valor Ressarcir
**Descrição**: Valor Ressarcimento Passivo

### Chave Primária
- cod_passiv_ambntal, cdn_empresa

### Índices
- **pssvmbnt_lclmbntl**: cod_local_ambntal
- **pssvmbnt_ntrcdtmb**: cod_natur_acidte_ambntal
- **pssvmbnt_undmddsg**: cod_unid_medid

---

## Tabela: passiv_norma_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_norma_ambntal, dat_emis_norma, cod_passiv_ambntal

### Índices
- **pssvnrmm_pssvmbnt**: cod_passiv_ambntal, cdn_empresa

---

## Tabela: pcacid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_acidtrab, num_pcacid

### Índices
- **pcacid_fncnr**: cdn_empresa, cdn_estab, cdn_func_respons_pcacid
- **pcacid_tppccd**: cdn_tip_pcacid

---

## Tabela: pcacid_brigincen
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_brigincen, num_reuniao_brigincen, cdn_estab, num_acidtrab, num_pcacid

### Índices
- **pccdbrgn_pcacid**: num_pcacid

---

## Tabela: pcacid_qacid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_qacid, num_pcacid_qacid

### Índices
- **pccdqcd_fncnr**: cdn_empresa, cdn_estab, cdn_func_respons_pcacid
- **pccdqcd_pcacid**: num_pcacid_qacid

---

## Tabela: pendcia_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq_pendcia_ambntal, dat_pendcia_ambntal, hra_pendcia_ambntal

### Índices
- **pndcmbnt_eqpmbntl**: cod_equipe_ambntal
- **pndcmbnt_prcss**: cod_proces_ambntal

---

## Tabela: pendcia_medic_segur
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq_pendcia, dat_pendcia_medic_segur, hra_pendcia_medic_segur

### Índices

---

## Tabela: pendcia_orig_mdo_estab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, idi_orig_contratac_func, cdn_prestdor_serv, dat_inic_valid

### Índices
- **pndcrgmd_pndcprst**: cdn_pendcia_prestdor_serv

---

## Tabela: pendcia_prestdor_serv
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_pendcia_prestdor_serv

### Índices

---

## Tabela: perc_rat_ccusto
**Label**: Percentual Rateio Centro Custo
**Descrição**: Percentual de Rateio para o Centro de custo

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cod_unid_negoc, cdn_estab_trab, cod_rh_ccusto

### Índices

---

## Tabela: percur_unid_agrar
**Label**: Valor Unit�rio
**Descrição**: Valor unit�rio da unidade

### Chave Primária
- cdn_empresa, cdn_propried_agric, cdn_produt_agric, cdn_safra_produt, cod_niv_estrut_agrar_1, cod_niv_estrut_agrar_2, cod_niv_estrut_agrar_3, cod_niv_estrut_agrar_4, cdn_lin_transp_rural

### Índices

---

## Tabela: perf_aces_planta
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_planta_edificio, cdn_perf_aces

### Índices

---

## Tabela: perf_aces_planta_estrut
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_planta_edificio, cdn_perf_aces, cdn_local_aces_entr, cdn_local_aces_orig, num_seq_estrut, cdn_local_aces_dest

### Índices

---

## Tabela: perf_aces_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_usuar_control_aces, cdn_planta_edificio, cdn_perf_aces, num_seq_perf_aces

### Índices

---

## Tabela: perf_cargo_basic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_perf_cargo_basic

### Índices

---

## Tabela: perf_psicolog
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_perf_psicolog

### Índices

---

## Tabela: perf_psicolog_cargo_ativid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_cargo_basic, cdn_perf_psicolog

### Índices
- **prfpscla_prfpsclg**: cdn_perf_psicolog

---

## Tabela: perform_metas_param
**Label**: Sequ�ncia
**Descrição**: N�mero de Seq��ncia

### Chave Primária
- num_seq

### Índices

---

## Tabela: perg_avaliac_trein
**Label**: Peso Resposta
**Descrição**: Valor do Peso da Resposta

### Chave Primária
- cdn_avaliac_trein, cdn_perg_trein

### Índices
- **prgvlctr_prgtrn**: cdn_perg_trein

---

## Tabela: perg_trein
**Label**: Pontos Resposta
**Descrição**: Valor em Pontos para a Resposta da Pergunta

### Chave Primária
- cdn_perg_trein, dat_refer

### Índices

---

## Tabela: peri
**Label**: N�mero de Perigo
**Descrição**: N�mero Sequencial de Perigo

### Chave Primária
- num_peri, cdn_empresa

### Índices

---

## Tabela: period_aqst_ferias
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_period_aqst_ferias

### Índices
- **prdqstfr_py08002**: cdn_empresa, cdn_estab, cdn_funcionario, idi_sit_period_aqst_ferias, dat_inic_period_aqst_ferias

---

## Tabela: period_atendim_consmedic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, num_period_atendim

### Índices

---

## Tabela: period_calc_retroat
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_calc

### Índices

---

## Tabela: period_escal_turno_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_turno_trab, num_period_escal

### Índices
- **prdscltr_jorntrab**: cdn_jorn_trab
- **prdscltr_py20301**: cdn_turno_trab, cdn_jorn_trab
- **prdscltr_py20303**: cod_tip_dia

---

## Tabela: period_motiv_liber_sal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_motiv_liber_sal_orig, cdn_motiv_liber_sal_dest, cdn_niv_hier_funcnal

### Índices
- **prdmtvlb_dest**: cdn_motiv_liber_sal_dest

---

## Tabela: period_req_vale_transp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_beneficio, idi_tip_lancto_movto_vale, cdn_lin_vale_transp, dat_final_period_vale_transp

### Índices
- **prdrqvlt_elimina**: cdn_empresa, cdn_estab, num_ano_refer_fp_aquis_vale, num_mes_refer_fp_aquis_vale
- **prdrqvlt_lnvltrns**: cdn_empresa, cdn_lin_vale_transp
- **prdrqvlt_provento**: cdn_empresa, cdn_estab, num_ano_provent_vale_transp, num_mes_provent_vale_transp
- **prdrqvlt_py14101**: cdn_empresa, cdn_estab, cdn_beneficio, num_ano_refer_fp_aquis_vale, num_mes_refer_fp_aquis_vale, idi_tip_lancto_movto_vale, cdn_lin_vale_transp

---

## Tabela: permis_aces_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_usuar_control_aces, cdn_planta_edificio, cdn_disposit_control_aces, dat_atribuic_aces, num_seq_atribuic_aces

### Índices
- **prmscssr_hrprms**: dat_atribuic_aces, cdn_ident_disposit, cdn_usuar_control_aces, idi_direcao_aces, num_horar_inic_permis, num_horar_term_permis, idi_tip_permis_aces_usuar
- **prmscssr_permis**: cdn_ident_disposit, cod_cartao_aces, dat_atribuic_aces, idi_direcao_aces, num_horar_inic_permis, num_horar_term_permis
- **prmscssr_planta**: cdn_usuar_control_aces, dat_atribuic_aces, cdn_planta_edificio, cdn_disposit_control_aces
- **prmscssr_relog**: cdn_usuar_control_aces, cdn_disposit_control_aces, cdn_planta_edificio, dat_atribuic_aces, num_horar_inic_permis, num_horar_term_permis

---

## Tabela: permis_estab_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario, cdn_empresa, cdn_estab

### Índices
- **prmsstbs_rhestab**: cdn_empresa, cdn_estab

---

## Tabela: permis_func_area_negoc
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_usuario, idi_area_negoc, cdn_empresa, cdn_estab, cdn_funcionario, cod_area_negoc_custom

### Índices
- **prmsfncr_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario

---

## Tabela: permis_func_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario, cdn_empresa, cdn_estab, cdn_funcionario

### Índices
- **prmsfncs_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario

---

## Tabela: permis_pessoa_ext_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario, cdn_pessoa_ext

### Índices
- **prmspssx_pssxttrn**: cdn_pessoa_ext

---

## Tabela: permis_restric_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_plano_lotac, cod_unid_lotac, cod_usuario

### Índices
- **prmsrstr_srmstr**: cod_usuario

---

## Tabela: permis_tip_calc_verba
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_tip_calc_verba, cod_grp_usuar

### Índices

---

## Tabela: pesq_quest
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_pesq_quest

### Índices

---

## Tabela: pesq_quest_opc_perg
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_pesq_quest, num_pesq_quest_perg, num_seq

### Índices

---

## Tabela: pesq_quest_perg
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_pesq_quest, num_pesq_quest_perg

### Índices

---

## Tabela: pesq_quest_respos
**Label**: Resposta
**Descrição**: Resposta efetuada pelo usu�rio

### Chave Primária
- num_pesq_sal, cdn_empres_recrut, num_pesq_quest, num_pesq_quest_perg, num_seq

### Índices

---

## Tabela: pesq_sal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_pesq_sal

### Índices
- **pesqsal_psqqst**: num_pesq_quest

---

## Tabela: pesq_sal_cargo_chave
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_pesq_sal, cdn_cargo_basic, cdn_niv_cargo

### Índices

---

## Tabela: pesq_sal_empres
**Label**: �ltimo Aumento
**Descrição**: Valor Percentual �ltimo Aumento

### Chave Primária
- num_pesq_sal, cdn_empres_recrut

### Índices
- **psqslmpr_emprscna**: cdn_empres_recrut
- **psqslmpr_seq**: num_seq

---

## Tabela: pesq_sal_empres_freq
**Label**: Sal�rio Nominal
**Descrição**: Sal�rio Nominal

### Chave Primária
- num_pesq_sal, cdn_empres_recrut, cdn_cargo_basic, cdn_niv_cargo, val_salario_nominal

### Índices

---

## Tabela: pessoa_ext_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_pessoa_ext

### Índices
- **pssxttrn_epm**: log_carg_epm
- **pssxttrn_pessoa_fisic** (Unique): num_pessoa_fisic
- **pssxttrn_rhpssjrd**: num_pessoa_jurid
- **pssxttrn_tppssxtt**: cdn_tip_pessoa_ext

---

## Tabela: pessoa_fisic_docto_quiosq
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq_arq_docto, num_pessoa_fisic

### Índices

---

## Tabela: planilha_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_cenar_orcto, cod_rh_ccusto, cdn_estab, cod_unid_lotac, cdn_turno_trab

### Índices
- **plnlhrct_1** (Unique): num_seq_planilha_orcto
- **plnlhrct_rhccusto**: cdn_empresa, cod_rh_ccusto
- **plnlhrct_trntrb**: cdn_turno_trab

---

## Tabela: plano_acao_acidte_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, num_acidte_ambntal, cdn_empres_plano, cdn_plano_organ, cdn_objorg

### Índices
- **plnccdtm_plnrgn**: cdn_empres_plano, cdn_plano_organ

---

## Tabela: plano_acao_avaliac_integr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_local_ambntal, cdn_empresa, cdn_estab, cod_unid_lotac, idi_tip_levto, dat_avaliac_analis, hra_avaliac_analis, num_seq, cdn_empres_plano, cdn_plano_organ, cdn_objorg

### Índices

---

## Tabela: plano_acao_brigincen
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_brigincen, cdn_plano_organ, cdn_objorg

### Índices

---

## Tabela: plano_acao_condic_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_licenc_ambntal, cod_orgao_emissor_notif, dat_emis_licenc, cod_condic_ambntal, cdn_empresa, cdn_plano_organ, cdn_objorg

### Índices
- **plnccndc_objorg**: cdn_empresa, cdn_plano_organ, cdn_objorg
- **plnccndc_plnrgn**: cod_condic_ambntal, cdn_empresa, cdn_plano_organ

---

## Tabela: plano_acao_demand_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_demand_ambntal, cdn_empresa, cdn_plano_organ, cdn_objorg

### Índices
- **plncdmnd_objorg**: cdn_empresa, cdn_plano_organ, cdn_objorg

---

## Tabela: plano_acao_grp_pca
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_pca, cdn_empresa, cdn_plano_organ, cdn_objorg

### Índices
- **plncgrpp_objorg**: cdn_empresa, cdn_plano_organ, cdn_objorg

---

## Tabela: plano_acao_inspec_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_inspec_ambntal, num_obj_inspec_ambntal, cdn_empresa, cdn_plano_organ, cdn_objorg, cod_item_inspec, dat_restdo_analis, hra_restdo_analis

### Índices
- **plncnspc_objnspcm**: cdn_empresa, cod_inspec_ambntal, num_obj_inspec_ambntal, dat_restdo_analis, hra_restdo_analis
- **plncnspc_objorg**: cdn_empresa, cdn_plano_organ, cdn_objorg

---

## Tabela: plano_acao_ipcto_avaliac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_local_ambntal, cdn_empresa, cdn_estab, cod_ativid_func, dat_avaliac_ambntal, hra_avaliac_ambntal, cod_aspecto_ambntal, cod_meio_ambntal, cod_ipcto_ambntal, cdn_plano_organ, cdn_objorg

### Índices
- **plncpctv_mmbntl**: cod_meio_ambntal
- **plncpctv_objorg**: cdn_empresa, cdn_plano_organ, cdn_objorg

---

## Tabela: plano_acao_nao_cfem
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_notif_ambntal, num_seq_notif_nao_cfem, cdn_empres_plano, cdn_plano_organ, cdn_objorg

### Índices
- **plncncfm_objorg**: cdn_empres_plano, cdn_plano_organ, cdn_objorg

---

## Tabela: plano_acao_passiv_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_passiv_ambntal, cdn_empresa, cdn_plano_organ, cdn_objorg

### Índices
- **plncpssv_objorg**: cdn_empresa, cdn_plano_organ, cdn_objorg

---

## Tabela: plano_acao_risco
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_ambien_risco, num_riscacid, cdn_plano_organ, cdn_objorg

### Índices
- **plncrsc_objorg**: cdn_empresa, cdn_estab, cdn_plano_organ, cdn_objorg
- **plncrsc_plnrgn**: cdn_empresa, cdn_plano_organ

---

## Tabela: plano_acao_vistoria_eqpcol
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_programac_vistoria_eqpcol, cod_eqpcol, dat_inspec_eqpcol, idi_tip_serv_eqpcol, cdn_plano_organ, cdn_objorg

### Índices
- **plncvstr_plnrgn**: cdn_empresa, cdn_plano_organ, cdn_objorg

---

## Tabela: plano_habcomp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_plano_habcomp

### Índices

---

## Tabela: plano_habcomp_pessoa_fisic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_pessoa_fisic, cdn_plano_habcomp, cdn_unid_produt_habcomp, cdn_carreira_habcomp, cdn_bloco_habcomp, dat_inic_valid

### Índices

---

## Tabela: plano_lotac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_plano_lotac

### Índices

---

## Tabela: plano_lotac_estab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_plano_lotac, dat_inic_valid

### Índices
- **plnltcst_inicvalid**: cdn_empresa, cdn_estab, dat_inic_valid, cdn_plano_lotac
- **plnltcst_plndprt**: cdn_plano_lotac

---

## Tabela: plano_organ
**Label**: Perc Completo
**Descrição**: Indica o percentual completo do plano

### Chave Primária
- cdn_empresa, cdn_plano_organ

### Índices
- **plnrgn_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario

---

## Tabela: plano_organ_cronog
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_plano_organ, num_seq

### Índices
- **plnrgncr_etpplnrg**: cdn_etap_plano_organ

---

## Tabela: plano_organ_mapa
**Label**: Percentual Relac
**Descrição**: Percentual Rela��o Causa e Efeito

### Chave Primária
- cdn_empresa, cdn_plano_organ, cdn_objorg, cdn_objorg_efeito

### Índices

---

## Tabela: plano_organ_matriz_premio
**Label**: Pr�mio
**Descrição**: Valor Pr�mio

### Chave Primária
- cdn_empresa, cdn_plano_organ, cdn_estab, cdn_tip_cargo, cdn_cargo_basic, cdn_niv_cargo, cod_rh_ccusto, cod_unid_lotac

### Índices

---

## Tabela: plano_organ_niv
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_plano_organ, num_seq_plano_organ_niv

### Índices

---

## Tabela: plano_prh
**Label**: Percentual Meta
**Descrição**: Valor Percentual Meta

### Chave Primária
- cdn_plano_prh

### Índices

---

## Tabela: plano_prh_cargo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_plano_prh, cdn_cargo_basic, cdn_niv_cargo

### Índices

---

## Tabela: plano_prh_cenar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_plano_prh, cdn_empresa, cdn_estab, cod_unid_lotac, cdn_cargo_basic, cdn_niv_cargo, num_niv_unid_lotac, num_seq_unid_lotac, num_seq

### Índices

---

## Tabela: plano_prh_cronog
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_plano_prh, num_seq

### Índices

---

## Tabela: plano_prh_cronog_envol
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_plano_prh, cdn_etap_plano_prh, num_seq, cdn_empresa, cdn_estab, cod_unid_lotac, cdn_cargo_basic, cdn_niv_cargo

### Índices

---

## Tabela: plano_prh_meta_rh
**Label**: Percentual
**Descrição**: Percentual da Meta

### Chave Primária
- cdn_plano_prh, cdn_empresa, cdn_estab, cod_unid_lotac, cdn_cargo_basic, cdn_niv_cargo, num_niv_unid_lotac, num_seq_unid_lotac, num_seq

### Índices

---

## Tabela: plano_trein
**Label**: Or�amento Treinamento
**Descrição**: Valor Or�amento Treinamento

### Chave Primária
- cdn_empresa, cod_rh_ccusto, cod_vers_plano, cdn_estab

### Índices

---

## Tabela: plano_trein_curso
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cod_rh_ccusto, cod_vers_plano, cdn_curso_trein, dat_refer, cdn_estab

### Índices
- **plntrncr_instttrn**: cdn_curso_trein, cdn_motiv_solicit_trein, cdn_instit_trein

---

## Tabela: planta_edificio
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_planta_edificio

### Índices

---

## Tabela: planta_edificio_cracha
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_planta_edificio, num_cartao_pto_func

### Índices
- **plntdfcc_cartao**: num_cartao_pto_func, log_cracha_ativ, cdn_planta_edificio

---

## Tabela: planta_edificio_estrut
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_planta_edificio, num_seq_estrut

### Índices
- **plntdfcs_lcldest**: cdn_planta_edificio, cdn_local_aces_dest
- **plntdfcs_lcldstorig**: cdn_local_aces_dest, cdn_local_aces_orig, cdn_local_aces_entr
- **plntdfcs_pltdest**: cdn_planta_edificio, cdn_local_aces_entr, cdn_local_aces_orig, cdn_local_aces_dest
- **plntdfcs_pltesq_orig**: cdn_planta_edificio, num_seq_estrut, cdn_local_aces_entr, cdn_local_aces_orig, num_seq_local_orig

---

## Tabela: politic
**Label**: Perc M�ximo
**Descrição**: Valor Percentual M�ximo Altera��o

### Chave Primária
- num_seq

### Índices
- **politic_nmsq**: num_seq

---

## Tabela: politic_desemp
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_motiv_liber_sal

### Índices

---

## Tabela: politic_desemp_perc
**Label**: Percentual Minimo M�dio
**Descrição**: Valor Percentual M�nimo M�dio

### Chave Primária
- cdn_motiv_liber_sal, val_desemp_inicial

### Índices

---

## Tabela: politic_etap_avaliac
**Label**: % Sal M�dio Inicial
**Descrição**: Percentual Ponto M�dio Inicial

### Chave Primária
- num_seq, cdn_niv_tab_sal_remun_inic, val_perc_pto_med_inic, num_parcela, cdn_etap_plano_organ, cdn_avpes_padr

### Índices

---

## Tabela: politic_matriz_desemp
**Label**: % Sal M�dio Inicial
**Descrição**: Percentual Ponto M�dio Inicial

### Chave Primária
- num_seq, cdn_niv_tab_sal_remun_inic, val_perc_pto_med_inic, num_parcela, val_desemp_inicial

### Índices

---

## Tabela: politic_perc
**Label**: % Sal M�dio Inicial
**Descrição**: Percentual Ponto M�dio Inicial

### Chave Primária
- num_seq, cdn_niv_tab_sal_remun_inic, val_perc_pto_med_inic, num_parcela

### Índices

---

## Tabela: politic_perc_cargo
**Label**: % Sal M�dio Inicial
**Descrição**: Percentual Ponto M�dio Inicial

### Chave Primária
- num_seq, cdn_niv_tab_sal_remun_inic, val_perc_pto_med_inic, cdn_cargo_basic, cdn_niv_cargo, num_parcela

### Índices
- **pltcprcc_cargo**: cdn_cargo_basic, cdn_niv_cargo
- **pltcprcc_pltcprc**: num_parcela, val_perc_pto_med_inic, cdn_niv_tab_sal_remun_inic, num_seq

---

## Tabela: politic_sal
**Label**: Sal�rio Inicial
**Descrição**: Valor Sal�rio Inicial

### Chave Primária
- val_sal_inic, val_sal_fim, cdn_niv_hier_funcnal

### Índices

---

## Tabela: pontuac_habcomp
**Label**: Valor/Percentual
**Descrição**: Valor Pontua��o Total

### Chave Primária
- cdn_grp_avaliac_pontuac, cdn_habcomp_lin, cdn_profncia_lin, cdn_habcomp_col, cdn_profncia_col

### Índices

---

## Tabela: portad
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_portador

### Índices

---

## Tabela: pos_chave_indcao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_plano_prh, cdn_empresa, cdn_estab, cod_unid_lotac, cdn_cargo_basic, cdn_niv_cargo

### Índices

---

## Tabela: pos_desemp_avaliac
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_cargo_basic, cdn_niv_cargo, cod_unid_lotac, cdn_avpes_padr

### Índices

---

## Tabela: pos_desemp_matriz
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_cargo_basic, cdn_niv_cargo, cod_unid_lotac

### Índices

---

## Tabela: possiv_cargo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_candempr, cdn_cargo_basic, cdn_niv_cargo

### Índices
- **pssvcrg_cargo**: cdn_cargo_basic, cdn_niv_cargo

---

## Tabela: pre_atstdo
**Label**: Dias Situa��o
**Descrição**: qti_dias_sit_func

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_sit_afast_func, dat_inic_sit_afast, num_seq, idi_status

### Índices

---

## Tabela: pre_requis_discip_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_discip_trein, cdn_pre_requis_discip_trein

### Índices

---

## Tabela: prefer_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_seq_prefer_func

### Índices

---

## Tabela: prefer_func_ativid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_seq_prefer_func, cdn_ativid_prefer

### Índices

---

## Tabela: prefer_func_regiao_definit
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_seq_prefer_func, cod_regiao_prefer

### Índices

---

## Tabela: prefer_func_regiao_tmp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_seq_prefer_func, cod_regiao_prefer

### Índices

---

## Tabela: prestdor_contrat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_prestdor_serv, idi_contrat_prestdor, cod_contrat_prestdor

### Índices

---

## Tabela: prestdor_contrat_benefic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_prestdor_serv, idi_contrat_prestdor, cod_contrat_prestdor, cdn_beneficio, num_ano_mes_inic_valid, cdn_funcionario, cdn_depend_func

### Índices

---

## Tabela: prestdor_contrat_produt
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_prestdor_serv, idi_contrat_prestdor, cod_contrat_prestdor, cdn_beneficio

### Índices

---

## Tabela: prestdor_exam_padr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_prestdor_serv, cod_exam_medic

### Índices
- **prstdrxm_exmmdc**: cod_exam_medic
- **prstdrxm_prstdrsr**: cdn_empresa, cdn_prestdor_serv

---

## Tabela: prestdor_licenc_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_prestdor_ambntal, cod_licenc_ambntal, cod_orgao_emissor_notif, dat_emis_licenc

### Índices

---

## Tabela: prestdor_serv
**Label**: Perc Aliq ISS
**Descrição**: Valor Percentual Al�quota Iss

### Chave Primária
- cdn_empresa, cdn_prestdor_serv

### Índices
- **prstdrsr_cpfcgc**: cdn_empresa, idi_tip_prestdor_serv, cod_id_feder
- **prstdrsr_py14501**: cdn_empresa, cdn_tip_serv_ext, nom_abrev_pessoa
- **prstdrsr_py14502**: cdn_empresa, idi_tip_prestdor_serv, nom_abrev_pessoa
- **prstdrsr_py14503**: cdn_empresa, nom_abrev_pessoa
- **prstdrsr_pyndfdrc**: cod_pais, cod_unid_federac_rh
- **prstdrsr_rhpssfsc**: num_pessoa
- **prstdrsr_rtncrf**: idi_tip_prestdor_serv, cdn_retenc_irf
- **prstdrsr_tipmdo**: cod_tip_mdo
- **prstdrsr_tpnumpes**: cdn_empresa, idi_tip_prestdor_serv, num_pessoa
- **prstdrsr_tpsrvxt**: cdn_tip_serv_ext

---

## Tabela: prestdor_serv_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_prestdor_ambntal

### Índices

---

## Tabela: prestdor_serv_compon
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_prestdor_serv, cdn_prestdor_serv_compon

### Índices

---

## Tabela: prestdor_serv_motoris
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_prestdor_ambntal, cod_motoris

### Índices

---

## Tabela: prestdor_serv_veic_transp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_prestdor_ambntal, cod_veic_transp

### Índices

---

## Tabela: prev_func_dispon_funcao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_prev_saida_func

### Índices

---

## Tabela: proces_eletral_cipa
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_area_segur, num_mandat_cipa, num_seq

### Índices

---

## Tabela: proces_inss_especial
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_gerac_relat_inss, num_seq

### Índices
- **prcsnsss_agntrsc**: cod_agent_risco

---

## Tabela: proces_inss_especial_cabec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_gerac_relat_inss, num_seq

### Índices
- **prcsnssa_ldmbntl**: cdn_empresa, cdn_estab, num_laudo_ambntal

---

## Tabela: proces_req
**Label**: Hora �ltima Atualiz
**Descrição**: Hora �ltima Atualiza��o

### Chave Primária
- cdn_proces

### Índices

---

## Tabela: produt_acidte_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_produt_acidte_trab

### Índices

---

## Tabela: produt_agric
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_produt_agric

### Índices

---

## Tabela: produt_inter_avaldor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_produt_inter_rh, cdn_estab, cdn_funcionario, dat_inic_valid

### Índices
- **prdtntrv_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario

---

## Tabela: produt_inter_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_produt_inter_rh, cdn_estab, cdn_funcionario, dat_inic_valid

### Índices
- **prdtntrf_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario

---

## Tabela: produt_inter_item_analis
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_produt_inter_rh, cdn_avpes_padr, cdn_grp_avpes, cdn_item_avpes

### Índices
- **prdtntrb_avpsmsta**: cdn_grp_avpes
- **prdtntrb_avpsrgms**: cdn_avpes_padr
- **prdtntrb_avpstm**: cdn_item_avpes

---

## Tabela: produt_inter_rh
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_produt_inter_rh

### Índices
- **prdtntrr_avpsrgms**: cdn_avpes_padr

---

## Tabela: produt_inter_time
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_produt_inter_rh, cdn_time_trab, dat_inic_valid

### Índices
- **prdtntrt_tmtrbrh**: cdn_time_trab

---

## Tabela: produt_inter_unid_lotac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_produt_inter_rh, cdn_estab, cdn_plano_lotac, cod_unid_lotac, dat_inic_valid

### Índices
- **prdtntra_unddprtp**: cdn_plano_lotac, cod_unid_lotac

---

## Tabela: produtor_rural
**Label**: Valor NF
**Descrição**: Valor Nota Fiscal

### Chave Primária
- cdn_empresa, cdn_estab, cdn_produtor_rural, num_mes_refer, num_ano_refer

### Índices

---

## Tabela: proficiencia
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_proficiencia

### Índices

---

## Tabela: prog_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_prog_trein

### Índices

---

## Tabela: programac_avaliac_medic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_programac_exam_medic

### Índices
- **prgrmcvl_atstds**: cdn_empresa, cdn_estab, num_pcmso, num_aso
- **prgrmcvl_cntrlpcm**: cdn_empresa, cdn_estab, num_pcmso, num_seq_programac_period

---

## Tabela: programac_calc_ptoelet
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_turno_trab

### Índices

---

## Tabela: programac_pcmso_elimda
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_pcmso, num_seq_programac_period, num_ficha_medic, cod_exam_medic, dat_programac_exam_medic

### Índices

---

## Tabela: programac_trein_cipa
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_area_segur, num_mandat_cipa, cdn_trein_cipa, dat_trein_cipa

### Índices
- **prgrmctr_lcltrn**: cdn_local_trein
- **prgrmctr_prstdrsr**: cdn_empresa, cdn_prestdor_serv
- **prgrmctr_trncp**: cdn_trein_cipa

---

## Tabela: proj_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_proj_ambntal

### Índices
- **prjmbntl_empdmbnt**: cod_empdo_ambntal
- **prjmbntl_lclmbntl**: cod_local_ambntal
- **prjmbntl_pssvmbnt**: cod_passiv_ambntal, cdn_empresa
- **prjmbntl_tpprjmbn**: cod_tip_proj_ambntal

---

## Tabela: proj_req_pessoal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_proj_req, cdn_empresa, cdn_estab, cdn_req_pessoal

### Índices

---

## Tabela: proj_selec
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_proj_req

### Índices

---

## Tabela: projec_sal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_id_projec_sal

### Índices

---

## Tabela: propost_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_propost

### Índices

---

## Tabela: propost_func_cargo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_propost, cdn_cargo_basic, cdn_niv_cargo

### Índices
- **prpstfna_cargo**: cdn_cargo_basic, cdn_niv_cargo
- **prpstfna_rqpssl**: cdn_empres_req, cdn_estab_req, cdn_req_pessoal

---

## Tabela: propost_liber_func
**Label**: Sal�rio Proposto
**Descrição**: Valor Sal�rio Proposto

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_ano_previs_liber_sal, num_mes_previs_liber_sal, cdn_motiv_liber_sal

### Índices
- **prpstlbr_cargo**: cdn_cargo_basic, cdn_niv_cargo
- **prpstlbr_cargo_dest**: cdn_cargo_basic_dest, cdn_niv_cargo_dest
- **prpstlbr_mtvlbrsl**: cdn_motiv_liber_sal
- **prpstlbr_num_id**: num_id_propost_liber_func
- **prpstlbr_origem**: cdn_empresa, cdn_estab, num_id_propost_liber_func, idi_tip_propost_liber, cdn_funcionario, num_ano_previs_liber_sal, num_mes_previs_liber_sal, cdn_motiv_liber_sal

---

## Tabela: propost_niv_hier_funcnal
**Label**: Pct Max Proposta N�o Agrega
**Descrição**: Valor Percentual M�ximo Proposta N�o Agrega Sal�rio

### Chave Primária
- cdn_niv_hier_funcnal

### Índices

---

## Tabela: propost_projec_sal
**Label**: Pr�mio Concedido
**Descrição**: Valor Pr�mio Concedido

### Chave Primária
- num_id_projec_sal, cdn_empresa, cdn_estab, cdn_funcionario, num_ano_previs_liber_sal, num_mes_previs_liber_sal, cdn_motiv_liber_sal

### Índices
- **prpstprj_mtvlbrsl**: cdn_motiv_liber_sal
- **prpstprj_prpstlbr**: cdn_empresa, cdn_estab, cdn_funcionario, num_ano_previs_liber_sal, num_mes_previs_liber_sal, cdn_motiv_liber_sal

---

## Tabela: propost_rh_ccusto
**Label**: Pct Saldo Proposta N�o Agrega
**Descrição**: Valor Percentual Saldo Proposta N�o Agrega

### Chave Primária
- cdn_empresa, cod_rh_ccusto, num_ano_inic_valid, num_mes_inic_valid

### Índices

---

## Tabela: propost_unid_lotac
**Label**: Pct Saldo Proposta N�o Agrega
**Descrição**: Valor Percentual Saldo Proposta N�o Agrega

### Chave Primária
- cdn_empresa, cod_unid_lotac, num_ano_inic_valid, num_mes_inic_valid

### Índices
- **prpstndl_unid_lotac**: cod_unid_lotac

---

## Tabela: propried_agric
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_propried_agric

### Índices
- **prprdgrc_lcldd**: cod_pais_localid, cdn_localidade

---

## Tabela: propried_grp_propried_agric
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_grp_propried_agric, cdn_propried_agric

### Índices
- **prprdgrp_prprdgrc**: cdn_empresa, cdn_propried_agric

---

## Tabela: pto_coleta
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_pto_coleta

### Índices

---

## Tabela: ptoelet_bco_hora
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cod_bco_hora, dat_inic_valid

### Índices

---

## Tabela: ptoelet_excec_func
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_proces_mpe

### Índices

---

## Tabela: ptoelet_marcac
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_marcac_ptoelet, hra_marcac_ptoelet

### Índices
- **ptltmrcc_imp**: nom_arq_mpe_imptdo, dat_import_arq_mpe, num_hora_corren_import_mpe, num_seq_import

---

## Tabela: ptoelet_par_marcac
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_proces_mpe, dat_inic_mpe, hra_inic_mpe

### Índices

---

## Tabela: ptoelet_param
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, dat_inic_valid

### Índices

---

## Tabela: ptoelet_regra_func
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cod_ptoelet_regra, dat_inic_valid

### Índices

---

## Tabela: push_communication
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- idComunicado

### Índices

---

## Tabela: push_communication_filter
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- idComunicado, tipo_filtro

### Índices
- **idxCargo**: idComunicado, tipo_filtro, cdn_cargo_basic
- **idxFunc**: idComunicado, tipo_filtro, cdn_empresa, cdn_estab, cdn_funcionario
- **idxUnidLotac**: idComunicado, tipo_filtro, cdn_empresa, cdn_estab, cdn_plano_lotac, cod_unid_lotac

---

## Tabela: push_communication_model
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- idModelo

### Índices
- **idxTipo**: idi_tipo_comunicado

---

## Tabela: push_notifications
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- idNotification

### Índices

---

## Tabela: push_token
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, token

### Índices
- **idToken**: token

---

## Tabela: qacid_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_qacid

### Índices
- **qcdtrb_fncnr**: cdn_empresa, cdn_estab, cdn_func_respons
- **qcdtrb_plnltc**: cdn_plano_lotac
- **qcdtrb_undltc**: cod_unid_lotac

---

## Tabela: quadro_lotac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_plano_lotac, cod_unid_lotac, cdn_cargo_basic, cdn_niv_cargo, num_ano_comptcia_quadro_lotac, num_mes_comptcia_quadro_lotac, cdn_turno_trab, idi_tip_vaga

### Índices
- **qdrltc_cargo**: cdn_cargo_basic, cdn_niv_cargo
- **qdrltc_ccusto**: cdn_empresa, cod_rh_ccusto, cod_unid_lotac, cdn_cargo_basic, cdn_niv_cargo, cdn_turno_trab, idi_tip_vaga, num_ano_comptcia_quadro_lotac, num_mes_comptcia_quadro_lotac
- **qdrltc_trntrb**: cdn_turno_trab
- **qdrltc_undltc**: cdn_plano_lotac, cod_unid_lotac

---

## Tabela: quadro_lotac_ccusto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_plano_lotac, cod_unid_lotac, cdn_cargo_basic, cdn_niv_cargo, num_ano_comptcia_quadro_lotac, num_mes_comptcia_quadro_lotac, cdn_turno_trab, idi_tip_vaga, cod_rh_ccusto

### Índices
- **qdrltccc_ccusto**: cdn_empresa, cod_rh_ccusto, cod_unid_lotac, cdn_cargo_basic, cdn_niv_cargo, cdn_turno_trab, idi_tip_vaga, num_ano_comptcia_quadro_lotac, num_mes_comptcia_quadro_lotac

---

## Tabela: quadro_planilha_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq_planilha_orcto, num_seq_variac_cargo_planilha, cod_clas_cargo

### Índices

---

## Tabela: quest_medic_compon_sesmt
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_compon_sesmt, cod_quest_medic

### Índices

---

## Tabela: quest_medic_pacien
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_ficha_medic, cod_quest_medic, num_quest_quest_medic, dat_quest_medic

### Índices
- **qstmdcpc_qstqstpd**: cod_quest_medic, num_quest_quest_medic

---

## Tabela: quest_medic_padr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_quest_medic

### Índices

---

## Tabela: quest_quest_padr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_quest_medic, num_quest_quest_medic

### Índices

---

## Tabela: rais
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_rais, idi_tip_cod_legal_rh

### Índices

---

## Tabela: rais_estab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_clien_rh

### Índices

---

## Tabela: rat_arq_movto_benefic
**Label**: Valor Folha
**Descrição**: Valor folha

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_beneficio, cdn_prestdor_serv, cdn_formul_calc_benefic, idi_tip_lancto_movto_vale, cdn_lin_vale_transp, dat_pagto_efet_efp

### Índices

---

## Tabela: recesso_escolar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_tip_contrat_func, dat_inic_recesso_escolar

### Índices

---

## Tabela: recta_medic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_ficha_medic, num_consmedic, num_recta_medic

### Índices
- **rctmdc_cnsmdc**: num_consmedic

---

## Tabela: refer_candempr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_candempr, num_seq_refer

### Índices

---

## Tabela: refer_movto_benefic
**Label**: Soma Lancto
**Descrição**: Soma lan�amentos

### Chave Primária
- cdn_empresa, cdn_regra_benefic, cdn_beneficio, num_ano_lote_movto_benefic, num_mes_lote_movto_benefic, num_lote_movto_benefic

### Índices
- **rfrmvtbn_elimina**: cdn_empresa, num_ano_lote_movto_benefic, num_mes_lote_movto_benefic

---

## Tabela: refer_movto_estoq
**Label**: Valor Taxa
**Descrição**: Valor da Taxa do Pedido

### Chave Primária
- cod_ped_compra, cdn_empresa, cdn_grp_benefic

### Índices

---

## Tabela: reg_det_ferias
**Label**: Valor Total
**Descrição**: Valor total do evento

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_ferias, cdn_tip_calc_ferias, dat_inic_period_aqst_ferias, num_seq_det_ferias

### Índices
- **rgdtfrs_py04901**: cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_ferias, dat_fim_ferias, cdn_tip_calc_ferias, num_seq_det_ferias

---

## Tabela: reg_det_ferias_simul
**Label**: Valor Total
**Descrição**: Valor total do evento

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_ferias, cdn_tip_calc_ferias, num_seq_det_ferias

### Índices
- **rgdtfrss_dtfer**: cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_ferias, dat_fim_ferias, cdn_tip_calc_ferias, num_seq_det_ferias

---

## Tabela: reg_ferias_normal
**Label**: Valor Total
**Descrição**: Valor total do evento

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_tip_calc_ferias, dat_inic_ferias, cdn_event_fp

### Índices

---

## Tabela: regiao_prefer
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_regiao_prefer

### Índices

---

## Tabela: regiao_sal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_regiao_sal

### Índices

---

## Tabela: regiao_sal_estab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_regiao_sal, cdn_empresa, cdn_estab

### Índices
- **rgslstb_rhestab**: cdn_empresa, cdn_estab

---

## Tabela: regra_atualiz_salario
**Label**: Valor Parcela
**Descrição**: Valor Parcela

### Chave Primária
- cdn_empresa, cdn_regra

### Índices

---

## Tabela: regra_benefic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_beneficio, cdn_regra_benefic

### Índices

---

## Tabela: regra_benefic_cargo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_beneficio, cdn_regra_benefic, cdn_cargo_basic, cdn_niv_cargo

### Índices
- **rgrbnfcc_cargo**: cdn_cargo_basic, cdn_niv_cargo

---

## Tabela: regra_benefic_conven
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_beneficio, cdn_regra_benefic, cdn_empresa, cdn_prestdor_serv

### Índices
- **rgrbnfca_prstdrsr**: cdn_empresa, cdn_prestdor_serv

---

## Tabela: regra_benefic_efp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_beneficio, cdn_regra_benefic, cdn_formul_calc_benefic

### Índices

---

## Tabela: regra_benefic_empres_estab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_beneficio, cdn_regra_benefic, cdn_empresa, cdn_estab

### Índices
- **rgrbnfcm_rhestab**: cdn_empresa, cdn_estab

---

## Tabela: regra_benefic_grau_depend
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_beneficio, cdn_regra_benefic, cdn_grau_depend_func

### Índices

---

## Tabela: regra_benefic_lotac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_beneficio, cdn_regra_benefic, cdn_plano_lotac, cod_unid_lotac

### Índices
- **rgrbnfcl_undltcpl**: cdn_plano_lotac, cod_unid_lotac

---

## Tabela: regra_benefic_param
**Label**: Vl Unit�rio Benef�cio
**Descrição**: Valor Quantidade Movimento Benef�cio

### Chave Primária
- cdn_beneficio, cdn_regra_benefic

### Índices

---

## Tabela: regra_benefic_relac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_beneficio, cdn_cargo_basic, cdn_niv_cargo, cdn_plano_lotac, cod_unid_lotac, cdn_sindicato, cdn_empresa, cdn_estab, cdn_regra_benefic

### Índices
- **rgrbnfcr_rgrbnfcc**: cdn_beneficio, cdn_regra_benefic, cdn_cargo_basic, cdn_niv_cargo
- **rgrbnfcr_rgrbnfcl**: cdn_beneficio, cdn_regra_benefic, cdn_plano_lotac, cod_unid_lotac
- **rgrbnfcr_rgrbnfcm**: cdn_beneficio, cdn_regra_benefic, cdn_empresa, cdn_estab
- **rgrbnfcr_rgrbnfcs**: cdn_beneficio, cdn_regra_benefic, cdn_sindicato

---

## Tabela: regra_benefic_sind
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_beneficio, cdn_regra_benefic, cdn_sindicato

### Índices
- **rgrbnfcs_sndct**: cdn_sindicato

---

## Tabela: regra_benefic_tip_dia
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_beneficio, cdn_regra_benefic, cod_tip_dia

### Índices

---

## Tabela: regra_benefic_vale_transp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_beneficio, cdn_regra_benefic, idi_tip_lancto_movto_vale, cdn_lin_vale_transp, dat_final_period_vale_transp

### Índices

---

## Tabela: regra_bolsa_estudo
**Label**: Percentual Bolsa
**Descrição**: Percentual da Parcela da Bolsa a ser reembolsado

### Chave Primária
- cdn_empresa, cdn_estab, cdn_niv_hier_funcnal, cdn_cargo_basic, cdn_niv_cargo, cdn_bolsa_estudo

### Índices

---

## Tabela: regra_calc_event
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_event_fp

### Índices

---

## Tabela: regra_calc_event_lotac
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_event_fp, num_seq

### Índices

---

## Tabela: regra_estab_benefic
**Label**: Valor
**Descrição**: Valor Movimento Beneficio Pexcec Variavel

### Chave Primária
- cdn_empresa, cdn_estab, cdn_beneficio, num_seq

### Índices

---

## Tabela: regra_excec_rep
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, idi_orig_contratac_func, cdn_prestdor_serv, idi_tip_func, dat_inic_excec

### Índices

---

## Tabela: regra_liq_neg
**Label**: Perc L�quido
**Descrição**: Valor Percentual Reserva L�quido

### Chave Primária
- cdn_empresa, cdn_estab, cdn_sindicato, cdn_cargo_basic

### Índices
- **rgrlqng_crgbsc**: cdn_cargo_basic
- **rgrlqng_sndct**: cdn_sindicato

---

## Tabela: regra_permis_area_negoc
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_regra_area_negoc, cdn_empresa, cdn_estab, cdn_funcionario, idi_area_negoc, cod_area_negoc_custom

### Índices

---

## Tabela: regra_permis_estrut_reporte
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_regra_area_negoc, cdn_empresa, cdn_estab, cdn_funcionario, num_seq_lotac_area_negoc

### Índices
- **rgrprmsa_estrtrpr**: cdn_plano_estrut_reporte, cdn_empres_depto, cdn_estab_depto, cod_unid_lotac, cdn_cargo_basic, cdn_niv_cargo

---

## Tabela: regra_permis_lotac
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_regra_area_negoc, cdn_empresa, cdn_estab, cdn_funcionario, num_seq_lotac_area_negoc

### Índices
- **rgrprmsl_plnltcst**: cdn_empres_depto, cdn_estab_depto, cdn_plano_lotac
- **rgrprmsl_undltc**: cod_unid_lotac
- **rgrprmsl_undltcpl**: cdn_plano_lotac, cod_unid_lotac

---

## Tabela: regra_permis_subor
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_regra_area_negoc, cdn_empresa, cdn_estab, cdn_funcionario, cod_empres_func_subor, cod_estab_func_subor, cdn_func_subor

### Índices
- **rgrprmsb_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario
- **rgrprmsb_sbr**: cod_empres_func_subor, cod_estab_func_subor, cdn_func_subor

---

## Tabela: regra_permis_usuar
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_regra_area_negoc, cdn_empresa, cdn_estab, cdn_funcionario

### Índices
- **rgrprmss_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario

---

## Tabela: relacto_cod_retenc_estab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_retenc_irf

### Índices
- **rlctcdrt_aamm**: cdn_empres_centrdor, cdn_estab_centrdor, num_ano_inic_centraliz_dirf, num_mes_refer_fp

---

## Tabela: relacto_efp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_efp_orig, cdn_efp_dest

### Índices
- **rlctfp_py18201** (Unique): cdn_efp_dest, cdn_efp_orig

---

## Tabela: relig
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_religiao

### Índices

---

## Tabela: relogio_pto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_relogio_pto

### Índices
- **rlgpt_tm04601**: cdn_local_marcac_cartao_pto

---

## Tabela: remun_var
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_remun_var

### Índices
- **remunvar_evt**: cdn_remun_var, cdn_event_fp

---

## Tabela: remun_var_cargo_localid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_remun_var, cdn_cargo_basic, cdn_niv_cargo, cod_pais, cdn_localidade

### Índices
- **rmnvrcrg_cargo**: cdn_cargo_basic, cdn_niv_cargo
- **rmnvrcrg_lcldd**: cod_pais, cdn_localidade

---

## Tabela: remun_var_func
**Label**: Valor Rmunera��o
**Descrição**: Valor Remunera��o Vari�vel

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_remun_var, dat_remun_var_inic, dat_remun_var_fim, num_seq

### Índices
- **rmnvrfnc_remunvar**: cdn_remun_var

---

## Tabela: remun_var_sind
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_remun_var, cdn_sindicato

### Índices
- **rmnvrsnd_sndct**: cdn_sindicato

---

## Tabela: remun_var_turno
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_remun_var, cdn_turno_trab

### Índices
- **rmnvrtrn_trntrb**: cdn_turno_trab

---

## Tabela: renov_licenc_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_licenc_ambntal, cod_orgao_emissor_notif, dat_emis_licenc, dat_movto_renov, cdn_empresa

### Índices
- **rnvlcncm_lcncmbnt**: cod_licenc_ambntal, cod_orgao_emissor_notif, dat_emis_licenc, cdn_empresa

---

## Tabela: req_candidato_etap
**Label**: Nota Etapa
**Descrição**: Valor Nota Etapa Teste Candidato Emprego

### Chave Primária
- cdn_empresa, cdn_estab, cdn_req_pessoal, cdn_candempr, cdn_etap_sel_candempr

### Índices
- **rqcnddtt_cnddtmpr**: cdn_candempr
- **rqcnddtt_etapa**: cdn_etap_sel_candempr
- **rqcnddtt_lcltrn**: cdn_instit_trein, cdn_local_trein
- **rqcnddtt_rhpssfsc**: num_pessoa_fisic_respons

---

## Tabela: req_conhecto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_req_pessoal, cdn_empres_conhecto, cdn_grp_conhecto_experien, cdn_conhecto_experien

### Índices
- **rqcnhct_cnhctxpr**: cdn_empresa, cdn_grp_conhecto_experien, cdn_conhecto_experien
- **rqcnhct_nvrqscrg**: cdn_niv_requis_cargo
- **rqcnhct_prfcnc**: cdn_proficiencia

---

## Tabela: req_etap_sel
**Label**: Peso Etapa
**Descrição**: Valor Peso Etapa Modelo Avalia��o

### Chave Primária
- cdn_empresa, cdn_estab, cdn_req_pessoal, cdn_etap_sel_candempr

### Índices
- **rqtpsl_fncnr**: num_pessoa_fisic

---

## Tabela: req_ferias
**Label**: Perc Adiant 13�
**Descrição**: Percentual de adiantamento do 13� sal�rio

### Chave Primária
- cdn_proces_ferias, cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_ferias, dat_inic_period_aqst_ferias

### Índices
- **rqfrs_dtFerias**: cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_ferias, dat_fim_ferias

---

## Tabela: req_ferias_proces
**Label**: Hora �ltima Atualiz
**Descrição**: Hora �ltima Atualiza��o

### Chave Primária
- cdn_proces_ferias, cdn_empresa, cdn_estab, cdn_funcionario, cdn_proces

### Índices

---

## Tabela: req_habilid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_req_pessoal, cdn_habcomp

### Índices
- **rqhbld_nvrqscrg**: cdn_niv_requis_cargo
- **rqhbld_profis**: cdn_habcomp, cdn_proficiencia

---

## Tabela: req_habilid_adc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_req_pessoal, cdn_habcomp

### Índices
- **rqhblddc_hbcmpprf**: cdn_habcomp, cdn_proficiencia

---

## Tabela: req_marcac_ptoelet
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_marcac_ptoelet, num_horar_marcac_ptoelet, nom_arq_mpe_imptdo, dat_import_arq_mpe, num_hora_corren_import_mpe, num_seq_import

### Índices
- **rmrccptlt_tm04002**: cdn_empresa, cdn_estab, cdn_funcionario, dat_marcac_ptoelet, num_horar_marcac_ptoelet, idi_status_justif
- **rqmrccpt_ix4**: cdn_empresa, cdn_estab, cdn_funcionario, dat_proces_mpe, num_horar_proces_mpe, idi_status_justif
- **rqmrccpt_ix5**: num_pessoa_fisic_solicit, dat_marcac_ptoelet, num_horar_marcac_ptoelet, idi_status_justif

---

## Tabela: req_pessoal
**Label**: Sal Contrata��o
**Descrição**: Sal�rio Contrata��o Cargo

### Chave Primária
- cdn_empresa, cdn_estab, cdn_req_pessoal

### Índices
- **rqpssl_cargo**: cdn_cargo_basic, cdn_niv_cargo
- **rqpssl_fncnr**: cdn_empres_func_respons, cdn_estab_func_respons, cdn_func_respons_recrut_req
- **rqpssl_plnltc**: cdn_plano_lotac
- **rqpssl_requisit**: cdn_empres_func_requisit, cdn_estab_func_requisit, cdn_func_solic_req_pessoal
- **rqpssl_trntrb**: cdn_turno_trab
- **rqpssl_undltc**: cod_unid_lotac

---

## Tabela: req_rescis_func
**Label**: valor saldo empr�stimo consign
**Descrição**: valor saldo empr�stimo consignado

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_desligto_func

### Índices

---

## Tabela: requis_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_requis_norma_ambntal

### Índices

---

## Tabela: requis_norma_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_norma_ambntal, dat_emis_norma, cod_requis_norma_ambntal, dat_analis_requis

### Índices
- **rqsnrmmb_rqsmbntl**: cod_requis_norma_ambntal

---

## Tabela: requis_proj_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_proj_ambntal, cod_requis_ambntal, dat_analis_requis

### Índices
- **rqsprjmb_rqsmbntl**: cod_requis_ambntal

---

## Tabela: residuo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_residuo

### Índices

---

## Tabela: residuo_dest_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_residuo, cod_dest_ambntal

### Índices

---

## Tabela: residuo_fonte_gerador_risco
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_residuo, cod_fonte_gerador_risco, idi_tip_fonte_gerad, cdn_prestdor_ambntal

### Índices

---

## Tabela: residuo_nbr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_residuo_nbr

### Índices

---

## Tabela: residuo_norma_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_residuo, cod_norma_ambntal, dat_emis_norma, cod_requis_norma_ambntal, dat_analis_requis

### Índices

---

## Tabela: residuo_tab_conver_un_rh
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_residuo, num_seq

### Índices

---

## Tabela: residuo_tip_proces_gerac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_residuo, cod_tip_proces_gerac

### Índices

---

## Tabela: respons_analis_nec_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_analis_nec_trein, num_ident_estrut_reporte_pos

### Índices
- **rspnsnls_estrtrpr**: num_ident_estrut_reporte_pos

---

## Tabela: respons_local_aces
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_planta_edificio, cdn_local_aces, cod_usuario

### Índices

---

## Tabela: respos_avpes_func
**Label**: Resposta
**Descrição**: Resposta efetuada pelo usu�rio

### Chave Primária
- num_avpes_emitid, cdn_grp_avpes, cdn_item_avpes, cdn_sub_item_avpes, idi_compos_respos

### Índices
- **rspsvpsf_avpsmsta**: cdn_grp_avpes
- **rspsvpsf_avpssbtm**: cdn_item_avpes, cdn_sub_item_avpes

---

## Tabela: respos_avpes_gdp
**Label**: Pontua��o
**Descrição**: Pontua��o Relacionada ao Item da Avalia��o

### Chave Primária
- num_avpes_emitid, cdn_habcomp, cdn_empres_plano, cdn_plano_organ, cdn_objorg

### Índices

---

## Tabela: respos_bolsista
**Label**: Percentual Acerto
**Descrição**: Percentual de Acerto para o Resultado da Resposta

### Chave Primária
- cdn_bolsa_estudo, cdn_curso_trein, cdn_bolsista, cdn_avaliac_trein, dat_refer, cdn_perg_trein

### Índices

---

## Tabela: respos_treindo_turma
**Label**: Percentual Acerto
**Descrição**: Percentual de Acerto para o Resultado da Resposta

### Chave Primária
- cdn_curso_trein, cdn_turma_trein, cdn_treindo, cdn_avaliac_trein, dat_refer, cdn_perg_trein

### Índices

---

## Tabela: restdo_coleta
**Label**: Resultado Inspe��o
**Descrição**: Resultado Inicial Inspe��o

### Chave Primária
- cod_restdo_coleta

### Índices

---

## Tabela: restdo_coleta_nao_cfe
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_restdo_coleta, cod_nao_cfem

### Índices

---

## Tabela: restdo_exam_audtvo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_ficha_medic, dat_programac_exam_medic, cod_exam_medic, idi_tip_exam_audtvo

### Índices
- **rstdxmdt_eqptdtv**: cod_eqpto_audtvo_medid
- **rstdxmdt_exmmdc**: cod_exam_medic

---

## Tabela: restdo_exam_audtvo_aux
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- num_ficha_medic, dat_programac_exam_medic, cod_exam_medic, idi_tip_exam_audtvo

### Índices

---

## Tabela: restdo_exam_espirom
**Label**: Peso
**Descrição**: Valor - Inteiro do Peso da Pessoa

### Chave Primária
- num_ficha_medic, dat_programac_exam_medic, cod_exam_medic, idi_tip_exam_espirom, num_seqcial_exam_espirom, cod_idx_exam_espirom

### Índices
- **rstdxmsp_exmmdc**: cod_exam_medic
- **rstdxmsp_idxxmspr**: num_seqcial_exam_espirom, cod_idx_exam_espirom

---

## Tabela: restdo_exam_medic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_ficha_medic, dat_programac_exam_medic, cod_exam_medic

### Índices
- **rstdxmmd_exmmdc**: cod_exam_medic

---

## Tabela: restdo_exam_otolog
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_ficha_medic, cod_exam_medic, dat_programac_exam_medic

### Índices
- **rstdxmtl_nxrd**: cod_nexo_ruido

---

## Tabela: restdo_exam_raiox_1
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_ficha_medic, dat_programac_exam_medic, cod_exam_medic, num_raiox, dat_raiox, cdn_conslho_medic

### Índices
- **rstdxmrx_exmmdc**: cod_exam_medic
- **rstdxmrx_medicext**: cdn_conslho_medic

---

## Tabela: restdo_exam_visao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_ficha_medic, dat_programac_exam_medic, cod_exam_medic

### Índices
- **rstdxmvs_exmmdc**: cod_exam_medic

---

## Tabela: restdo_pre_test
**Label**: Nota Pr� Teste
**Descrição**: Nota Pr�-Teste Candidato Emprego

### Chave Primária
- cdn_candempr

### Índices

---

## Tabela: restdo_sub_item_exam
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_ficha_medic, dat_programac_exam_medic, cod_exam_medic, cod_sub_item_exam

### Índices
- **rstdsbtm_exmmdcsb**: cod_exam_medic, cod_sub_item_exam

---

## Tabela: restric_aces_usuar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_usuar_control_aces, cdn_planta_edificio, cdn_disposit_control_aces, dat_atribuic_aces, num_seq_atribuic_aces

### Índices
- **rstrccss_dthr**: dat_atribuic_aces, cdn_ident_disposit, cod_cartao_aces, idi_direcao_aces, num_horar_inic_restric, num_horar_term_restric
- **rstrccss_restric**: cdn_ident_disposit, cod_cartao_aces, dat_atribuic_aces, idi_direcao_aces, num_horar_inic_restric, num_horar_term_restric

---

## Tabela: restric_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_restric_trab

### Índices

---

## Tabela: restric_trab_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_ficha_medic, cod_restric_trab, dat_inic_restric_trab

### Índices
- **rstrctra_rstrctrb**: cod_restric_trab

---

## Tabela: restric_trab_func_atstdo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_aso, cod_restric_trab

### Índices
- **rstrctrc_rstrctrb**: cod_restric_trab

---

## Tabela: retenc_irf
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_retenc_irf

### Índices

---

## Tabela: retenc_tomador_serv
**Label**: Reten��o
**Descrição**: Valor Retencao Tomador Servico

### Chave Primária
- cdn_empresa, cdn_estab, cdn_clien_rh, num_ano, num_mes

### Índices
- **rtnctmdr_rhclien**: cdn_empresa, cdn_clien_rh

---

## Tabela: reuniao_brigincen
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_brigincen, num_reuniao_brigincen

### Índices
- **rnbrgncn_brgncn**: cdn_empresa, cod_brigincen

---

## Tabela: reuniao_cipa
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_area_segur, num_mandat_cipa, num_reuniao_cipa

### Índices

---

## Tabela: rh_agenc_bcia
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_banco, cdn_agenc_bcia

### Índices
- **rhgncbc_py00202**: cod_unid_federac_rh
- **rhgncbc_pyndfdrc**: cod_pais, cod_unid_federac_rh
- **rhgncbc_rhpssjrd**: num_pessoa_jurid

---

## Tabela: rh_bco
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_banco

### Índices

---

## Tabela: rh_bco_cta_corren_empres
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_banco, idi_tip_inform

### Índices

---

## Tabela: rh_ccusto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_rh_ccusto

### Índices

---

## Tabela: rh_clien
**Label**: Percentual SAT
**Descrição**: Valor Percentual Seguro acidente trabalho

### Chave Primária
- cdn_empresa, cdn_clien_rh

### Índices
- **rhclien_py03301**: cdn_empresa, cod_cgc_cpf
- **rhclien_py03303**: cdn_empresa, nom_clien_rh
- **rhclien_pyndfdrc**: cod_pais, cod_unid_federac_rh

---

## Tabela: rh_cta_corren
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_banco, cdn_agenc_bcia, cdn_cta_corren

### Índices
- **rhctcrrn_rhgncbc**: cdn_banco, cdn_agenc_bcia

---

## Tabela: rh_cta_ctbl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_rh_cta_ctbl

### Índices

---

## Tabela: rh_estab
**Label**: Percentual SAT
**Descrição**: Valor Percentual Seguro acidente trabalho 5

### Chave Primária
- cdn_empresa, cdn_estab

### Índices
- **rhestab_carga_epm**: log_carg_epm
- **rhestab_codfeder**: cod_id_feder
- **rhestab_epm**: num_seq_unid_epm
- **rhestab_psjurid**: num_pessoa_jurid
- **rhestab_py06001**: cdn_empresa, cdn_bco_alter_pis, cdn_agenc_bcia_alter_pis
- **rhestab_py06002**: cdn_empresa, cdn_bco_pis, cdn_agenc_bcia_pis
- **rhestab_py06003**: cdn_empresa, cdn_bco_rais, cdn_agenc_bcia_rais

---

## Tabela: rh_estab_compl
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab

### Índices
- **rhstbcmp_cnpj**: cod_cnpj_esp_cees
- **rhstbcmp_esp**: cod_sind_esp_cees

---

## Tabela: rh_estab_medid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_lim_verific, cod_agent_risco, cod_amostra_risco, dat_medid_risco, hra_medid_risco

### Índices
- **rhstbmdd_agntrsc**: cod_agent_risco
- **rhstbmdd_amstrrsc**: cod_amostra_risco
- **rhstbmdd_fncnr**: cdn_empres_medid, cdn_estab_medid, cdn_func_medid
- **rhstbmdd_lmvrfc**: cod_lim_verific

---

## Tabela: rh_estab_unid_negoc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_unid_negoc

### Índices
- **rhstbndn_undneg**: cod_unid_negoc

---

## Tabela: rh_munpio
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_pais, cod_unid_federac_rh, cdn_seq_munpio

### Índices
- **rhmunpio_ix2**: cdn_munpio_sped

---

## Tabela: rh_pais
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_pais

### Índices

---

## Tabela: rh_pessoa_fisic
**Label**: Peso
**Descrição**: Valor - Inteiro do Peso da Pessoa

### Chave Primária
- num_pessoa_fisic

### Índices
- **rhpssfsc_idfeder**: cod_id_feder
- **rhpssfsc_nome**: nom_pessoa_fisic
- **rhpssfsc_pyndfdrc**: cod_pais, cod_unid_federac_rh

---

## Tabela: rh_pessoa_jurid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_pessoa_jurid

### Índices
- **rhpssjrd_pyndfdrc**: cod_pais, cod_unid_federac_rh

---

## Tabela: rh_unid_federac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_pais, cod_unid_federac_rh

### Índices
- **rhndfdrc_py06302**: cod_unid_federac_rh

---

## Tabela: risco_acidte_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_ambien_risco, num_riscacid

### Índices
- **rsccdttr_agntrsc**: cod_agent_risco
- **rsccdttr_ambnldrsc**: cdn_empresa, cdn_estab, num_ambien_risco, num_laudo_ambntal, num_riscacid
- **rsccdttr_ambnrsc**: num_ambien_risco
- **rsccdttr_fntgrdrr**: cod_fonte_gerador_risco
- **rsccdttr_rscldmbn**: cdn_empresa, cdn_estab, num_laudo_ambntal, cod_agent_risco

---

## Tabela: risco_acidtrab
**Label**: Risco Acidente
**Descrição**: N�mero Risco acidente

### Chave Primária
- num_peri, num_riscacid, cdn_empresa, cdn_estab, num_laudo_ambntal, num_ambien_risco

### Índices

---

## Tabela: risco_laudo_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_laudo_ambntal, cod_agent_risco

### Índices
- **rscldmbn_agntrsc**: cod_agent_risco

---

## Tabela: risco_mapa_risco
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_area_segur, num_mandat_cipa, num_seq_mapa_risco, num_ambien_risco, num_riscacid

### Índices
- **rscmprsc_rsccdttr**: num_ambien_risco, num_riscacid

---

## Tabela: risco_perf_profis
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_pessoa_fisic, cdn_plano_lotac, cod_unid_lotac, cdn_cargo_basic, cod_ativid_func, num_ambien_risco, num_riscacid, dat_inic_func_ambien_trab, dat_medid_risco, hra_fonte_medid, cod_agent_risco

### Índices
- **rscprfpr_fncprfpr**: num_seq_perf_profis, num_pessoa_fisic
- **rscprfpr_rhpssfsc**: num_pessoa_fisic

---

## Tabela: ruido_nao_ocupac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_ruido_nao_ocupac

### Índices

---

## Tabela: ruido_nao_ocupac_exam
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_ficha_medic, cod_exam_medic, dat_programac_exam_medic, cod_ruido_nao_ocupac

### Índices
- **rdncpcxm_rdncpc**: cod_ruido_nao_ocupac

---

## Tabela: safra_produt
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_propried_agric, cdn_produt_agric, cdn_safra_produt

### Índices
- **sfrprdt_prdtgrc**: cdn_empresa, cdn_produt_agric

---

## Tabela: saida_residuo_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_saida

### Índices
- **sdrsdmbn_dstmbntl**: cod_dest_ambntal
- **sdrsdmbn_motoris**: cod_motoris
- **sdrsdmbn_prstdrsd**: cdn_prestdor_ambntal
- **sdrsdmbn_vctrnsp**: cod_veic_transp

---

## Tabela: sdo_fgts_func
**Label**: Saldo FGTS Rescis�o Empresa
**Descrição**: Valor Saldo FGTS Rescis�o Conta Empresa

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_ano_refer_fgts, num_mes_refer_fgts

### Índices

---

## Tabela: segur_estab_rh
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_grp_usuar

### Índices
- **sgrstbrh_emp**: cdn_empresa, cod_grp_usuar
- **sgrstbrh_grp_usuar**: cod_grp_usuar

---

## Tabela: segur_grp_atrib_dados
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_grp_atrib_dados, cod_grp_usuar

### Índices
- **sgrgrptr_grpsr**: cod_grp_usuar

---

## Tabela: segur_sist_rh
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- nom_razao_social_contrnte

### Índices

---

## Tabela: segur_unid_organ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario, cod_unid_organ

### Índices
- **sgrndrgn_estrtndr**: cod_unid_organ

---

## Tabela: sel_func_sem_ferias_coletiv
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_programac_ferias_coletiv, idi_sel_func_sem_ferias_coletiv

### Índices

---

## Tabela: selec_estado
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario

### Índices

---

## Tabela: seq_aux_calc_inss
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_pessoa_fisic, num_mes_refer_fp, num_ano_refer_fp, idi_tip_calc_fp, qti_parc_habilit_calc_fp, num_seq_calc_fp_mes

### Índices

---

## Tabela: seq_aux_calc_irf
**Label**: Valor Previd�ncia Privada
**Descrição**: Valor previd�ncia privada

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_pessoa_fisic, num_mes_refer_fp, num_ano_refer_fp, idi_tip_inform_dirf, idi_tip_calc_fp, qti_parc_habilit_calc_fp, num_seq_calc_fp_mes

### Índices

---

## Tabela: serv_agric
**Label**: Valor Unit�rio
**Descrição**: Valor Unit�rio Servi�o Agr�cola

### Chave Primária
- cdn_empresa, cdn_serv_agric

### Índices
- **srvgrc_eventfp**: cdn_event_fp
- **srvgrc_tpsrvgrc**: cdn_tip_serv_agric

---

## Tabela: serv_clas_eqpcol
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_clas_eqpcol

### Índices

---

## Tabela: serv_clien
**Label**: Valor Nota Fiscal/Fatura
**Descrição**: Valor da nota fiscal/fatura

### Chave Primária
- cdn_empresa, cdn_clien_rh, dat_nota_fisc, num_nota_fisc_fatur

### Índices

---

## Tabela: serv_produt_agric
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_produt_agric, cdn_serv_agric

### Índices
- **srvprdtg_srvgrc**: cdn_empresa, cdn_serv_agric

---

## Tabela: serv_sit_afast
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_sit_afast_func

### Índices
- **srvstfst_sitafast**: cdn_sit_afast_func

---

## Tabela: serv_social_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_serv_social, num_seq_serv_social

### Índices

---

## Tabela: sind_calc_retroat
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_calc, cdn_sindicato

### Índices

---

## Tabela: sind_cargo_orcto
**Label**: Valor Padr�o
**Descrição**: Valor padr�o para o cargo

### Chave Primária
- cdn_cargo_basic, cdn_niv_cargo, cdn_empresa, cdn_estab, cod_rh_ccusto, cdn_sindicato

### Índices

---

## Tabela: sind_estab
**Label**: Meses Adicional F�rias Valor
**Descrição**: Meses adicional f�rias em valor

### Chave Primária
- cdn_empresa, cdn_estab, cdn_sindicato, dat_inic_valid

### Índices
- **sndstb_snd**: cdn_sindicato

---

## Tabela: sind_estab_benefic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_beneficio, cdn_sindicato

### Índices

---

## Tabela: sind_media_grp_adc_event
**Label**: Meses Adicional F�rias Valor
**Descrição**: Meses adicional f�rias em valor

### Chave Primária
- cdn_empresa, cdn_sindicato, cdn_grp_adc

### Índices
- **sndmdgrp_grpadc**: cdn_empresa, cdn_grp_adc

---

## Tabela: sind_regra_atualiz_sal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_regra, cdn_sindicato

### Índices

---

## Tabela: sind_tab_sal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_tab_sal, cdn_sindicato

### Índices
- **sndtbsl_sndct**: cdn_sindicato

---

## Tabela: sindicato
**Label**: Meses Adicional F�rias Valor
**Descrição**: Meses adicional f�rias em valor

### Chave Primária
- cdn_sindicato

### Índices
- **sndct_motestb**: cdn_motiv_estabil_func
- **sndct_py16702**: cdn_efp_adc_insal
- **sndct_py16703**: cdn_efp_adc_notur
- **sndct_py16704**: cdn_efp_adc_pericul
- **sndct_py16705**: cdn_efp_menslid_sindic
- **sndct_py16706**: cdn_efp_revers_sindic
- **sndct_py16707**: cdn_moeda
- **sndct_pyndfdrc**: cod_pais, cod_unid_federac_rh
- **sndct_rhpssjrd**: num_pessoa_jurid

---

## Tabela: sipat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_sipat

### Índices
- **sipat_cmpnssmt**: num_compon_sesmt
- **sipat_mndtcp**: cdn_empresa, cdn_estab, cod_area_segur, num_mandat_cipa

---

## Tabela: sist_qualid_acidte_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_sist_qualid_acidte_trab

### Índices

---

## Tabela: sit_abono_reprov
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_sit_afast, num_horar_inic_sit_afast, num_hora_inic_proces

### Índices

---

## Tabela: sit_afast
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_sit_afast_func

### Índices
- **sitafast_py16902**: cdn_marcac_dias_outros
- **sitafast_py16903**: cdn_motiv_estabil_func
- **sitafast_signif**: idi_signif_sit

---

## Tabela: sit_afast_calc_ppr
**Label**: Percentual Redu��o PLR
**Descrição**: Valor Percentual Redu��o PLR

### Chave Primária
- cdn_param_calc_ppr, cdn_sit_afast_func

### Índices
- **stfstclc_sitafast**: cdn_sit_afast_func

---

## Tabela: sit_afast_compl
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_sit_afast_func

### Índices

---

## Tabela: sit_afast_control_aces
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_sit_afast_func

### Índices

---

## Tabela: sit_afast_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_sit_afast, num_horar_inic_sit_afast

### Índices
- **stfstfnc_justif**: cdn_empresa, cdn_estab, cdn_funcionario, idi_status_justif, dat_inic_sit_afast, dat_term_sit_afast
- **stfstfnc_pe04201**: cdn_empresa, cdn_estab, cdn_funcionario, num_mes_ano_refer_fp
- **stfstfnc_pe04203**: cdn_sit_afast_func
- **stfstfnc_proces** (Unique): cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_proces_sit_afast, num_hora_inic_proces_sit_afast
- **stfstfnc_py00902**: cdn_empresa, dat_inic_sit_afast, cdn_estab, cdn_funcionario
- **stfstfnc_term**: cdn_empresa, cdn_estab, cdn_funcionario, dat_term_sit_afast, num_horar_inic_sit_afast

---

## Tabela: sit_afast_medic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_sit_afast_func

### Índices
- **stfstmdc_sitafast**: cdn_sit_afast_func

---

## Tabela: sit_afast_motiv
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_sit_afast_func, cdn_motiv_liber_sal

### Índices
- **stfstmtv_mtvlbrsl**: cdn_motiv_liber_sal

---

## Tabela: sit_benefic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_beneficio, cdn_regra_benefic, cdn_sit_afast_func

### Índices
- **stbnfc_py17001**: cdn_beneficio

---

## Tabela: sit_calc_ptoelet_categ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_clas_func, cdn_empresa, cdn_estab, cdn_categ_sal, idi_orig_contratac_func, cdn_prestdor_serv, num_ano_primei_calc_ptoelet, num_mes_primei_calc_realzdo

### Índices

---

## Tabela: sit_calc_ptoelet_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_ano_primei_calc_ptoelet, num_mes_primei_calc_realzdo

### Índices
- **stclcptb_tm05602**: cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_period_apurac_pto_mes
- **stclcptb_tm05603**: cdn_clas_func, cdn_empresa, cdn_estab, cdn_categ_sal, num_ano_primei_calc_ptoelet, num_mes_primei_calc_realzdo, idi_sit_ptoelet_mes_func

---

## Tabela: sit_calc_rescis
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_tip_calc_rescis

### Índices

---

## Tabela: sit_calc_taref
**Label**: Remunera��o
**Descrição**: Valor Remuneracao Tarefista

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_ano_refer, num_mes_refer

### Índices

---

## Tabela: sit_dia_ptoelet_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_refer_calend

### Índices
- **stdptltf_06801**: cdn_turno_trab, cdn_turma_trab, dat_refer_calend
- **stdptltf_intrvrfj**: cdn_jorn_trab, cdn_interv_refei
- **stdptltf_localidade**: cdn_empresa, cod_pais, cdn_localidade, cdn_estab, cdn_funcionario, dat_refer_calend
- **stdptltf_sit**: idi_sit_ptoelet_dia, dat_refer_calend, cdn_empresa, cdn_estab, cdn_funcionario

---

## Tabela: sit_espcif_ptoelet
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_sit_marcac_ptoelet

### Índices
- **stspcfpt_tm04102**: cdn_sit_afast_func

---

## Tabela: solicit_manut_eqpcol
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_solicit_manut_eqpcol

### Índices
- **slctmntq_fncnr**: cdn_empresa, cdn_estab, cdn_func_solic
- **slctmntq_motiv**: cdn_empresa, cdn_estab, cod_motiv_manut_eqpcol
- **slctmntq_mtvmntqp**: cod_motiv_manut_eqpcol
- **slctmntq_seq**: cdn_empresa, cdn_estab, cod_eqpcol, num_seq

---

## Tabela: sped_acidte_trab
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, num_acidtrab

### Índices

---

## Tabela: sped_admis_prelim
**Label**: Sal�rio Atual
**Descrição**: Valor do sal�rio atual

### Chave Primária
- cdn_empresa, dat_admis_func, cod_id_feder

### Índices
- **spddmspr_ix2**: cdn_empresa, cdn_estab, cdn_funcionario

---

## Tabela: sped_adv_dissid_retroat
**Label**: Valor Advogado
**Descrição**: Valor da despesa com o advogado

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_ano_pagto_fp, num_mes_pagto_fp, num_seq, num_seq_adv

### Índices

---

## Tabela: sped_agendto_interv
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_admis_transf_func, cdn_jorn_trab, cdn_interv_refei

### Índices

---

## Tabela: sped_agendto_transf
**Label**: Sal�rio Fun��o
**Descrição**: val_salario_atual_funcao

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_admis_transf_func

### Índices
- **spdgndtt_ix2**: cdn_empres_dest, cdn_estab_dest, cdn_func_dest, dat_admis_transf_func

---

## Tabela: sped_agent_acidtrab
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_agent_acidtrab

### Índices

---

## Tabela: sped_agent_risco
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_agent_risco

### Índices

---

## Tabela: sped_agent_risco_func
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_empres_ambien, cdn_estab_ambien, num_ambien_risco, num_laudo_ambntal, cod_agent_risco, dat_inic_lotac_func

### Índices

---

## Tabela: sped_ambien_participan
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, idi_tip_participan_sped, cdn_participan_sped, cdn_empres_ambien, cdn_estab_ambien, num_ambien_risco, num_laudo_ambntal, dat_inic_lotac_func

### Índices

---

## Tabela: sped_ambien_risco
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, num_ambien_risco

### Índices

---

## Tabela: sped_ambien_risco_rh_clien
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_clien_rh, num_ambien_risco, idi_natur_clien

### Índices

---

## Tabela: sped_aquis_produc
**Label**: Valor SENAR
**Descrição**: Valor SENAR Produtor

### Chave Primária
- cdn_empresa, cdn_estab, cdn_produtor_rural, dat_emis_nf, cod_ser_docto_rh, num_docto

### Índices

---

## Tabela: sped_aso
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, idi_tip_participan_sped, cdn_participan_sped, dat_emis_aso, hra_emis_aso, idi_tip_aso_sped

### Índices

---

## Tabela: sped_aso_agent
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, idi_tip_participan_sped, cdn_participan_sped, dat_emis_aso, hra_emis_aso, idi_tip_aso_sped, cod_agent_sped

### Índices

---

## Tabela: sped_aso_exam
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, idi_tip_participan_sped, cdn_participan_sped, dat_emis_aso, hra_emis_aso, idi_tip_aso_sped, dat_exam_medic, cod_exam_medic

### Índices

---

## Tabela: sped_aso_exam_pacien
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- num_aso, num_ficha_medic, dat_programac_exam_medic, cod_exam_medic

### Índices

---

## Tabela: sped_ativid
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_ativid_sped, dat_inic_valid

### Índices

---

## Tabela: sped_ativid_ambien_risco
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, num_ambien_risco, num_riscacid, cod_ativid_ambien_risco

### Índices

---

## Tabela: sped_ativid_concom
**Label**: Rec Ativ Sem Subst M�s
**Descrição**: Receita Ativ Sem Subst M�s

### Chave Primária
- cdn_empresa, cdn_estab, num_ano_refer, num_mes_refer, idi_tip_folha_pagto

### Índices

---

## Tabela: sped_ativid_participan
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, idi_tip_participan_sped, cdn_participan_sped, dat_inic_lotac_func, cod_ativid_sped

### Índices

---

## Tabela: sped_ativid_prestdor_serv
**Label**: Risco Acidente
**Descrição**: N�mero Risco acidente

### Chave Primária
- cdn_empresa, cdn_prestdor_serv, num_ambien_risco, idi_tip_prestdor_serv, num_riscacid, cod_ativid_prestdor_serv

### Índices

---

## Tabela: sped_ativid_rh_clien
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_clien_rh, num_ambien_risco, idi_natur_clien, num_riscacid, cod_ativid_rh_clien

### Índices

---

## Tabela: sped_atstdo_aso
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- num_aso

### Índices

---

## Tabela: sped_bnfciar_movto_prestad
**Label**: Valor Pagamento
**Descrição**: Valor Pagamento eSocial

### Chave Primária
- cdn_empresa, cdn_estab, cdn_prestdor_serv, dat_refer_movto_prestdor_serv, idi_tip_pessoa, cod_ser_docto_rh, num_docto_movto_prestdor_serv, cdn_bnfciar_palim, dat_inic_valid

### Índices

---

## Tabela: sped_bnfciar_prestdor_serv
**Label**: Percentual Pens�o Aliment�cia
**Descrição**: Valor Percentual Pens�o Aliment�cia

### Chave Primária
- cdn_empresa, cdn_prestdor_serv, cdn_bnfciar_palim, dat_inic_valid

### Índices

---

## Tabela: sped_calc_dissid_retroat
**Label**: Valor despesas e custas
**Descrição**: Valor das despesas com custas judiciais

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_ano_pagto_fp, num_mes_pagto_fp, num_seq

### Índices

---

## Tabela: sped_cargo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_cargo_basic, cdn_niv_cargo

### Índices

---

## Tabela: sped_cargo_basic
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_cargo_basic

### Índices

---

## Tabela: sped_cat
**Label**: N�mero Logradouro
**Descrição**: N�mero Logradouro

### Chave Primária
- cdn_empresa, cdn_estab, num_acidtrab, num_cat_acidtrab

### Índices

---

## Tabela: sped_cat_agent_causa
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, idi_tip_participan_sped, cdn_participan_sped, dat_ocor_sped, hra_ocor_sped, cdn_agent_causa_sped

### Índices

---

## Tabela: sped_cat_compl
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, num_acidtrab

### Índices

---

## Tabela: sped_cat_compl_acidado
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, num_acidtrab, num_cat_acidtrab

### Índices

---

## Tabela: sped_cat_parte_atgdo
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, idi_tip_participan_sped, cdn_participan_sped, dat_ocor_sped, hra_ocor_sped, cdn_parte_corpo_atgdo_sped

### Índices

---

## Tabela: sped_cat_testem
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, idi_tip_participan_sped, cdn_participan_sped, dat_ocor_sped, hra_ocor_sped, cdn_testem_acidtrab

### Índices

---

## Tabela: sped_cno
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cod_pais, cod_id_previd_social

### Índices

---

## Tabela: sped_cno_prestdor
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cod_pais, cod_id_previd_social, cdn_prestdor_serv

### Índices

---

## Tabela: sped_comerc_produc
**Label**: Valor Retido
**Descrição**: Valor Reten��o Aquisi��o

### Chave Primária
- cdn_empresa, cdn_estab, idi_tip_inscr, cod_id_feder, idi_tip_comerc, num_ano_refer, num_mes_refer

### Índices

---

## Tabela: sped_compl_event_lotac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_ano_refer, num_mes_refer, cod_lotac_tributar

### Índices

---

## Tabela: sped_compl_event_periodic
**Label**: Valor Percentual Redu��o Contr
**Descrição**: valor percentual reducao contribuicao

### Chave Primária
- cdn_empresa, cdn_estab, num_ano_refer, num_mes_refer

### Índices

---

## Tabela: sped_cond_dif_trab
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, idi_tip_participan_sped, cdn_participan_sped, idi_tip_cond_dif_trab, dat_inic_lotac_func

### Índices

---

## Tabela: sped_cond_dif_trab_agent
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, idi_tip_participan_sped, cdn_participan_sped, idi_tip_cond_dif_trab, dat_inic_lotac_func, cod_agent_sped, dat_inic_lotac_agent

### Índices

---

## Tabela: sped_cond_dif_trab_epi
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, idi_tip_participan_sped, cdn_participan_sped, idi_tip_cond_dif_trab, dat_inic_lotac_func, cod_agent_sped, dat_inic_lotac_agent, cod_epi, dat_inic_lotac_epi

### Índices

---

## Tabela: sped_conex_esoc_fut
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab

### Índices

---

## Tabela: sped_contrib_sindic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empres_centrdor, cdn_estab_centrdor, num_ano, num_pessoa_jurid

### Índices

---

## Tabela: sped_contrib_sindic_val
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empres_centrdor, cdn_estab_centrdor, num_ano, num_pessoa_jurid, cdn_empresa, cdn_estab, idi_tip_contrib_sindic, idi_period_apurac, num_mes

### Índices

---

## Tabela: sped_curso_trein
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_curso_trein

### Índices

---

## Tabela: sped_ded_depend
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_depend_func, num_ano_refer, num_mes_refer, idi_tip_calc, num_seq_mes

### Índices

---

## Tabela: sped_ded_depend_aut
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_prestdor_serv, dat_refer_movto_prestdor_serv, idi_tip_pessoa, cod_ser_docto_rh, num_docto_movto_prestdor_serv, cdn_depend_func

### Índices

---

## Tabela: sped_dep_irf_autonomo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_prestdor_serv, cdn_depend_func

### Índices

---

## Tabela: sped_deson_folha
**Label**: Val Tributos Receita 12 Meses
**Descrição**: Valor Tributos Receita 12 Meses

### Chave Primária
- cdn_empresa, cdn_estab, num_ano_refer, num_mes_refer

### Índices

---

## Tabela: sped_despes_medic
**Label**: Valor Pago
**Descrição**: Valor Pago

### Chave Primária
- cdn_empres_centrdor, cdn_estab_centrdor, cod_id_feder, num_ano_mes_apurac, cdn_ans, cdn_depend_func

### Índices

---

## Tabela: sped_despes_reemb_medic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empres_centrdor, cdn_estab_centrdor, cdn_empresa, cdn_estab, cdn_funcionario, num_ano_mes_refer, cdn_prestdor_oper, cdn_prestdor_med, cdn_event_fp, cdn_depend_func, idi_tipo_despes_reemb_medic, num_seq_despes_reemb_medic

### Índices

---

## Tabela: sped_entid_clas
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_entid_clas_profis

### Índices

---

## Tabela: sped_epi
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_epi

### Índices
- **spedepi_certific** (Unique): cod_certific_aprovac_epi

---

## Tabela: sped_epi_func
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cod_agent_risco, dat_inic_lotac_func, cod_epi

### Índices

---

## Tabela: sped_eqpto_perf_profis
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_clien_rh, num_ambien_risco, idi_tip_local_ambien, num_riscacid, dat_inic_riscacid, cod_eqpto_protec, idi_tip_eqpto_protec, cdn_empres_func, cdn_estab_func, cdn_funcionario

### Índices

---

## Tabela: sped_eqpto_prestdor_serv
**Label**: Risco Acidente
**Descrição**: N�mero Risco acidente

### Chave Primária
- cdn_empresa, cdn_prestdor_serv, num_ambien_risco, idi_tip_prestdor_serv, num_riscacid, cod_eqpto_protec, idi_tip_eqpto_protec

### Índices

---

## Tabela: sped_eqpto_protec_coletiv
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cod_eqpcol, num_seq

### Índices

---

## Tabela: sped_eqpto_rh_clien
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_clien_rh, num_ambien_risco, idi_natur_clien, num_riscacid, cod_eqpto_protec, idi_tip_eqpto_protec

### Índices

---

## Tabela: sped_estab_entid_educnal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_pessoa_jurid_entid

### Índices

---

## Tabela: sped_estab_requis_epi
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, dat_inic_valid

### Índices

---

## Tabela: sped_event_despes
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, num_ano_refer, num_mes_refer, num_bolet, idi_tip_despes_event

### Índices

---

## Tabela: sped_event_despr
**Label**: Receita Retido Parcelamento
**Descrição**: Valor Retido Clube para Amortiza��o do Parcelamento

### Chave Primária
- cdn_empresa, cdn_estab, num_ano_refer, num_mes_refer

### Índices

---

## Tabela: sped_event_despr_bolet
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, num_ano_refer, num_mes_refer, num_bolet

### Índices

---

## Tabela: sped_event_ingresso
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, num_ano_refer, num_mes_refer, num_bolet, cod_pais, cod_id_feder_respons, idi_tip_inscr, cod_id_feder

### Índices

---

## Tabela: sped_event_mdo
**Label**: Valor Remunera��o
**Descrição**: Valor Remunera��o

### Chave Primária
- cdn_empresa, cdn_estab, num_ano_refer, num_mes_refer, num_bolet, idi_tip_despes_event

### Índices

---

## Tabela: sped_event_perdco
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empres_centrdor, cdn_estab_centrdor, idi_tip_event_perdco, idi_period_apurac, num_ano, num_mes, num_seq

### Índices

---

## Tabela: sped_event_recta
**Label**: Total Arrecadado
**Descrição**: Valor Total Arrecadado

### Chave Primária
- cdn_empresa, cdn_estab, num_ano_refer, num_mes_refer, num_bolet, idi_tip_ingresso, idi_tip_preco

### Índices

---

## Tabela: sped_event_recta_outras
**Label**: Valor Receita
**Descrição**: Valor Receita

### Chave Primária
- cdn_empresa, cdn_estab, num_ano_refer, num_mes_refer, num_bolet, idi_tip_recta

### Índices

---

## Tabela: sped_exam_func
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_lotac_func, cod_exam_medic

### Índices

---

## Tabela: sped_exam_medic
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_exam_medic

### Índices

---

## Tabela: sped_exam_pacien
**Label**: Ficha M�dica
**Descrição**: N�mero Ficha M�dica

### Chave Primária
- num_ficha_medic, dat_programac_exam_medic, cod_exam_medic

### Índices

---

## Tabela: sped_ficha_invent_instrut
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- num_pessoa_fisic, idi_tip_trein, cdn_curso_trein, dat_inic_curso_trein, cdn_instrutor

### Índices

---

## Tabela: sped_ficha_invent_trein
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- num_pessoa_fisic, idi_tip_trein, cdn_curso_trein, dat_inic_curso_trein

### Índices

---

## Tabela: sped_func_alter_cpf
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_alter_cpf

### Índices

---

## Tabela: sped_func_consig
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_seq

### Índices

---

## Tabela: sped_func_emprest_financ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_seq_emprest_func

### Índices

---

## Tabela: sped_func_reinteg
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_reinteg_func_fp

### Índices

---

## Tabela: sped_habilit_rescis_obs
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, num_seq

### Índices

---

## Tabela: sped_hist_cbo_cargo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_cargo_basic, dat_alteracao

### Índices

---

## Tabela: sped_ident_pos_func
**Label**: Sal�rio Atual
**Descrição**: Valor do sal�rio atual

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_lotac_func

### Índices

---

## Tabela: sped_infCompl_perAnt
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empres_centrdor, cdn_estab_centrdor, cod_id_feder, num_ano_mes_perAnt, num_ano_mes_apurac, dat_pagto, idi_recibo_orig, num_seq_calc_geral

### Índices

---

## Tabela: sped_infCompl_perAnt_prestdor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empres_centrdor, cdn_estab_centrdor, cdn_empresa, cdn_estab, cod_id_feder, num_ano_mes_perAnt, num_ano_mes_apurac, dat_refer_movto_prestdor_serv, cod_ser_docto_rh, num_docto_movto_prestdor_serv, dat_pagto, idi_recibo_orig, num_seq_calc_geral

### Índices

---

## Tabela: sped_inform_plano
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, num_mes_inic_valid, num_ano_inic_valid, cdn_event_fp, cdn_beneficio, cdn_ans

### Índices

---

## Tabela: sped_instrut_trein
**Label**: Hora �ltima Atualiz
**Descrição**: Hora �ltima Atualiza��o

### Chave Primária
- cdn_instrutor

### Índices

---

## Tabela: sped_local_lesao_acidte
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_local_lesao_acidtrab

### Índices

---

## Tabela: sped_lotac_tributar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_lotac_tributar

### Índices
- **spdltcta_ix**: cdn_empres_centrdor, cdn_estab_centrdor, cod_lotac_tributar
- **spdltcta_ix3**: cdn_empresa, cdn_estab, idi_orig_lotac_tributar
- **spdltctr_ix4**: cdn_empresa, cdn_clien_rh, idi_orig_lotac_tributar

---

## Tabela: sped_matr_bloqdo
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empres_centrdor, cdn_estab_centrdor, cod_matr_sped

### Índices

---

## Tabela: sped_matriz_pagto_diver
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, idi_period_apurac_sped, cdn_tip_pagto_diver, num_seq, dat_inic_valid

### Índices

---

## Tabela: sped_monitoram_biolog
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, idi_tip_participan_sped, cdn_participan_sped, cod_agent_quimico, cod_analis_mater_biolog, dat_inic_monitoram, idi_mater_biolog

### Índices

---

## Tabela: sped_monitoram_biolog_exam
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, idi_tip_participan_sped, cdn_participan_sped, cdn_agent_quimico, dat_realiz_exam_medic, idi_mater_biolog, cod_analis_mater_biolog

### Índices

---

## Tabela: sped_movto_msg
**Label**: Seq Msg SPED
**Descrição**: Sequencia Mensagem SPED

### Chave Primária
- val_seq_msg_sped

### Índices
- **spdmvtma_ix6**: cdn_empres_centrdor, cdn_estab_centrdor, idi_tip_inform_msg_sped, idi_motiv_bloq_msg, idi_tip_carg, idi_orig_msg, idi_tip_ambien, idi_tip_arq_msg_sped
- **spdmvtma_ix7**: cod_recibo_msg_corren
- **spdmvtma_ix8**: cdn_empres_centrdor, cdn_estab_centrdor, dat_refer_envio_msg, idi_tip_inform_msg_sped, idi_tip_arq_msg_sped
- **spdmvtmd_ix7**: cod_empres_func, cod_estab_func, cdn_funcionario
- **spdmvtms_inf**: val_seq_msg_sped, idi_tip_inform_msg_sped, idi_tip_arq_msg_sped, cdn_empres_centrdor, cdn_estab_centrdor, cdn_empresa, cdn_estab, idi_tip_participan_sped, cdn_participan_sped, cod_refer_inform_sped_1, cod_refer_inform_sped_2, nom_refer_inform_sped_1, dat_refer_inform_sped_1, dat_refer_inform_sped_2, cod_refer_inform_sped_3
- **spdmvtms_ix5**: cdn_empres_centrdor, cdn_estab_centrdor, idi_tip_inform_msg_sped, idi_motiv_bloq_msg
- **spdmvtms_ix6**: idi_tip_inscr, cod_id_feder, dat_refer_envio_msg, hra_refer_envio_msg, num_seq_utiliz
- **spdmvtms_ix7**: idi_tip_inform_msg_sped, idi_tip_arq_msg_sped, cdn_empres_centrdor, cdn_estab_centrdor, cdn_empresa, cdn_estab, idi_tip_participan_sped, cdn_participan_sped, cod_refer_inform_sped_1, cod_refer_inform_sped_2, cod_refer_inform_sped_3, dat_refer_inform_sped_1, dat_refer_inform_sped_2, nom_refer_inform_sped_1
- **spdmvtms_ix8**: idi_tip_inscr, dat_refer_envio_msg, hra_refer_envio_msg, num_seq_utiliz

---

## Tabela: sped_movto_msg_erro
**Label**: Seq Msg SPED
**Descrição**: Sequencia Mensagem SPED

### Chave Primária
- val_seq_msg_sped, num_seq_msg_erro

### Índices
- **spdmvtms_cod_erro**: val_seq_msg_sped, cod_erro_msg

---

## Tabela: sped_movto_msg_orig
**Label**: Seq Msg SPED
**Descrição**: Sequencia Mensagem SPED

### Chave Primária
- val_seq_msg_sped, num_seq_msg_orig

### Índices

---

## Tabela: sped_movto_msg_ret
**Label**: Seq Msg SPED
**Descrição**: Sequencia Mensagem SPED

### Chave Primária
- val_seq_msg_sped

### Índices

---

## Tabela: sped_movto_nf_tomador
**Label**: Valor Servi�os
**Descrição**: Valor dos Servi�os

### Chave Primária
- cdn_empresa, cdn_estab, cdn_clien_rh, dat_emis_nf, cod_ser_docto_rh, cod_num_docto_sped

### Índices

---

## Tabela: sped_movto_pagto_diver
**Label**: Valor Movimento
**Descrição**: Valor Movimento

### Chave Primária
- cdn_empresa, cdn_estab, idi_tip_participan_sped, cdn_participan_sped, cdn_depend_bnfciar, idi_tip_inform_dirf, dat_pagto_movto, num_ano_mes_refer, num_seqcial_movto

### Índices

---

## Tabela: sped_movto_participan
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- num_seq_sped_movto_participan

### Índices
- **spdmvtpr_orig**: idi_orig_movto_participan, idi_sit_movto_sped

---

## Tabela: sped_movto_prestad_terc
**Label**: Valor Servi�os
**Descrição**: Valor dos Servi�os

### Chave Primária
- cdn_empresa, cdn_estab, cdn_prestdor_serv, dat_refer_movto_prestdor_serv, idi_tip_pessoa, cod_ser_docto_rh, num_docto_movto_prestdor_serv

### Índices

---

## Tabela: sped_movto_prestdor_parc
**Label**: Valor Tribut�vel
**Descrição**: Valor l�quido tribut�vel para IRF

### Chave Primária
- cdn_empresa, cdn_estab, dat_refer_movto_prestdor_serv, idi_tip_pessoa, cod_ser_docto_rh, num_docto_movto_prestdor_serv, num_parc

### Índices

---

## Tabela: sped_movto_rat
**Label**: Valor
**Descrição**: Valor Movimento eSocial

### Chave Primária
- cdn_empresa, cdn_estab, cdn_participan_sped, idi_tip_participan_sped, num_ano_refer, num_mes_refer, num_ano_base, num_mes_base, idi_tip_folha_sped, cod_lotac_sped, cod_inform_rat_sped, cdn_event_fp

### Índices

---

## Tabela: sped_movto_rat_tomador
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_clien_rh, num_ano_refer_fp, num_mes_refer_fp, idi_tip_calc, qti_parc_tip_calc, num_seq_movto_rat

### Índices

---

## Tabela: sped_movto_tab
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- num_seq_sped_movto_tab

### Índices
- **spdmvttb_orig**: idi_orig_movto_tab, idi_sit_movto_sped

---

## Tabela: sped_movto_tomador_sub
**Label**: Reten��o Subempreitada
**Descrição**: Valor Reten��o Subempreitada

### Chave Primária
- cdn_empresa, cdn_estab, cdn_clien_rh, dat_emis_nf, cod_ser_docto_rh, cod_num_docto_sped, num_seq

### Índices

---

## Tabela: sped_multiplo_vinc
**Label**: Remunera��o M�ltiplos V�nculos
**Descrição**: Valor da Remunera��o de Funcion�rio com M�ltiplos V�nculos

### Chave Primária
- cdn_empresa, cdn_estab, idi_tip_participan_sped, cdn_participan_sped, num_ano_refer, num_mes_refer, idi_tip_inscr_multiplo_vinc, cod_id_feder_multiplo_vinc

### Índices

---

## Tabela: sped_natur_lesao_acidte
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_natur_lesao_acidte

### Índices

---

## Tabela: sped_obj_gerador_acidte
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_obj_gerador_acidte

### Índices

---

## Tabela: sped_pagto_inform
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empres_centrdor, cdn_estab_centrdor, cod_id_feder, num_ano_mes_apurac, dat_pagto, idi_recibo_orig, num_seq_calc_geral

### Índices
- **spdpgtnf_cpf**: cod_id_feder
- **spdpgtnf_ferias**: cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_ferias, num_seq_calc_geral, dat_inic_period_aqst_ferias
- **spdpgtnf_movto**: cdn_empresa, cdn_estab, cdn_funcionario, num_ano_mes_apurac, idi_tip_fp, qti_parc_habilit_calc_fp
- **spdpgtnf_pagto**: dat_pagto
- **spdpgtnf_rescis**: cdn_empresa, cdn_estab, cdn_funcionario, num_seq_calc_geral

---

## Tabela: sped_pagto_itens
**Label**: Valor Unit�rio
**Descrição**: Valor unit�rio da unidade

### Chave Primária
- cdn_empres_centrdor, cdn_estab_centrdor, cod_id_feder, num_ano_mes_apurac, dat_pagto, idi_recibo_orig, num_seq_calc_geral, cdn_event_fp

### Índices

---

## Tabela: sped_param_empres_rh
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_empres_centrdor

### Índices

---

## Tabela: sped_param_taf
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab

### Índices

---

## Tabela: sped_param_tss
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab

### Índices

---

## Tabela: sped_parte_corpo
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_parte_corpo_atgdo

### Índices

---

## Tabela: sped_particip_inf_mensal
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, idi_tip_participan_sped, cdn_participan_sped, num_ano_refer, num_mes_refer

### Índices

---

## Tabela: sped_participan
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, idi_tip_participan_sped, cdn_participan_sped

### Índices
- **spdprtcp_ix2**: cod_matr_sped

---

## Tabela: sped_pendcia_exp_risco
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cod_unid_lotac, prog_orig, cdn_info_alter, cdn_niv_cargo, data_alter

### Índices

---

## Tabela: sped_pendcia_xml_sst
**Label**: Seq Msg SPED
**Descrição**: Sequencia Mensagem SPED

### Chave Primária
- idi_tip_inform_msg_sped, cdn_empres_centrdor, cdn_estab_centrdor, cod_refer_inform_sped_1, cod_refer_inform_sped_2, cod_refer_inform_sped_3, dat_refer_inform_sped_1

### Índices
- **spdpndcx_ix2**: val_seq_msg_sped
- **spdpndcx_ix3**: cdn_empresa, cdn_estab, cdn_participan_sped

---

## Tabela: sped_prestdor
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_prestdor_serv

### Índices

---

## Tabela: sped_prestdor_ambien_risco
**Label**: Grupo Homog�neo
**Descrição**: N�mero Grupo Homog�neo

### Chave Primária
- cdn_empresa, cdn_prestdor_serv, cod_empres_ambien_risco, cod_estab_ambien_risco, num_ambien_risco

### Índices

---

## Tabela: sped_prestdor_inf_complem_irf
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empres_centrdor, cdn_estab_centrdor, cdn_empresa, cdn_estab, cdn_prestdor_serv, cdn_depend_func, idi_tipo_inform, idi_tipo_rend, cod_receita, num_ano_mes_refer, num_ano_mes_pagto

### Índices

---

## Tabela: sped_prestdor_pagto_inform
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empres_centrdor, cdn_estab_centrdor, cdn_empresa, cdn_estab, cod_id_feder, num_ano_mes_apurac, dat_refer_movto_prestdor_serv, cod_ser_docto_rh, num_docto_movto_prestdor_serv, dat_pagto, idi_recibo_orig, num_seq_calc_geral

### Índices

---

## Tabela: sped_prestdor_pagto_itens
**Label**: Valor Unit�rio
**Descrição**: Valor unit�rio da unidade

### Chave Primária
- cdn_empres_centrdor, cdn_estab_centrdor, cod_id_feder, num_ano_mes_apurac, dat_refer_movto_prestdor_serv, cod_ser_docto_rh, num_docto_movto_prestdor_serv, dat_pagto, idi_recibo_orig, num_seq_calc_geral, cdn_event_fp

### Índices

---

## Tabela: sped_prestdor_pagto_palim
**Label**: Valor Pens�o
**Descrição**: Valor de pens�o aliment�cia

### Chave Primária
- cdn_empres_centrdor, cdn_estab_centrdor, cod_id_feder, num_ano_mes_apurac, dat_refer_movto_prestdor_serv, cod_ser_docto_rh, num_docto_movto_prestdor_serv, dat_pagto, idi_recibo_orig, num_seq_calc_geral, cdn_event_fp, cod_ident_feder_palim

### Índices

---

## Tabela: sped_prestdor_remun_itens
**Label**: Valor Unit�rio
**Descrição**: Valor unit�rio da unidade

### Chave Primária
- cdn_empres_centrdor, cdn_estab_centrdor, cod_id_feder, num_ano_mes_apurac, dat_refer_movto_prestdor_serv, cod_ser_docto_rh, num_docto_movto_prestdor_serv, idi_indic_apurac, cod_lotac_tributar, num_ano_mes_period_ant, cdn_event_fp

### Índices

---

## Tabela: sped_prestdor_remun_recibo
**Label**: Vl Recibo Pagto
**Descrição**: Valor Recibo Pagamento

### Chave Primária
- cdn_empres_centrdor, cdn_estab_centrdor, cdn_empresa, cdn_estab, cod_id_feder, num_ano_mes_apurac, dat_refer_movto_prestdor_serv, cod_ser_docto_rh, num_docto_movto_prestdor_serv

### Índices

---

## Tabela: sped_previd_compl
**Label**: Valor
**Descrição**: Valor da previd�ncia complementar

### Chave Primária
- cdn_empres_centrdor, cdn_estab_centrdor, cdn_empresa, cdn_estab, cdn_funcionario, num_ano_mes_refer, idi_indic_apurac, cdn_event_fp, idi_tipo_prev

### Índices
- **spdprvcomp**: cdn_empres_centrdor, cdn_estab_centrdor, cdn_empresa, cdn_estab, cdn_funcionario, num_ano_mes_refer, idi_recibo_orig

---

## Tabela: sped_proced_exam_medic
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_exam_medic

### Índices

---

## Tabela: sped_proces_justic
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_proces_justic

### Índices

---

## Tabela: sped_proces_justic_det
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_proces_justic, dat_senten_proces

### Índices

---

## Tabela: sped_proces_justic_empreg
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_proces_justic, cdn_empresa, cdn_estab

### Índices

---

## Tabela: sped_proces_participan
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, idi_tip_participan_sped, cdn_participan_sped, cod_proces_justic, cdn_event_fp, dat_inic_valid

### Índices

---

## Tabela: sped_proces_relat
**Label**: Valor Percentual Conclus�o
**Descrição**: Valor Percentual Conclus�o

### Chave Primária
- cod_id_proces_relat

### Índices

---

## Tabela: sped_proces_utiliz
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_proces_justic, num_seq_utiliz

### Índices

---

## Tabela: sped_proctrab_anobase_v2
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_nrProcTrab, cod_cpfTrab, num_ideseqtrab, cdn_categ, dat_inic_contrat, cod_matricula, ano_base_abono

### Índices
- **idcpftrab**: cod_cpfTrab
- **idproc**: cdn_empresa, cod_nrProcTrab, cod_cpfTrab

---

## Tabela: sped_proctrab_benef_pen_v2
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_nrProcTrab, cod_cpfTrab, cod_per_apur_pgto, cod_receita_irrf, idi_tp_proc_ret, cod_nr_proc_ret, cod_susp, idi_ind_apuracao, idi_ind_tp_deducao, cpf_dep, num_ideseqproc

### Índices

---

## Tabela: sped_proctrab_calctrib
**Label**: Rend Trib 13o
**Descrição**: Valor do rendimento tribut�vel do Imposto de Renda referente ao 13o sal�rio - Tributa��o exclusiva

### Chave Primária
- cdn_empresa, cod_nrProcTrab, cod_cpfTrab, cod_per_apur_pgto, cod_perf_ref, num_ideseqproc

### Índices

---

## Tabela: sped_proctrab_contrato_v2
**Label**: Total Verbas Remunerat��rias
**Descrição**: Valor total das verbas remunerat��rias a serem pagas ao trabalhador

### Chave Primária
- cdn_empresa, cod_nrProcTrab, cod_cpfTrab, num_ideseqtrab, cdn_categ, dat_inic_contrat, cod_matricula

### Índices

---

## Tabela: sped_proctrab_ded_depen_v2
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_nrProcTrab, cod_cpfTrab, cod_per_apur_pgto, cod_receita_irrf, idi_tp_rend, cpf_dep, num_ideseqproc

### Índices

---

## Tabela: sped_proctrab_ded_susp_v2
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_nrProcTrab, cod_cpfTrab, cod_per_apur_pgto, cod_receita_irrf, idi_tp_proc_ret, cod_nr_proc_ret, cod_susp, idi_ind_apuracao, idi_ind_tp_deducao, num_ideseqproc

### Índices

---

## Tabela: sped_proctrab_dependente
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_nrProcTrab, cod_cpfTrab, num_ideseqtrab, cod_cpf_dep

### Índices

---

## Tabela: sped_proctrab_idePeriodos
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_nrProcTrab, cod_cpfTrab, num_ideseqtrab, cdn_categ, dat_inic_contrat, cod_matricula, cod_per_ref

### Índices

---

## Tabela: sped_proctrab_ideTrab_v2
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_nrProcTrab, cod_per_apur_pgto, cod_cpfTrab, num_ideseqproc

### Índices

---

## Tabela: sped_proctrab_ide_adv_v2
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_nrProcTrab, cod_cpfTrab, cod_per_apur_pgto, cod_receita_irrf, idi_tp_insc, cod_nr_insc, num_ideseqproc

### Índices

---

## Tabela: sped_proctrab_ideproc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_nrProcTrab, cod_per_apur_pgto, num_ideseqproc

### Índices

---

## Tabela: sped_proctrab_infoCrContr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_nrProcTrab, cod_cpfTrab, cod_per_apur_pgto, cod_perf_ref, cod_receita_contrib, num_ideseqproc

### Índices

---

## Tabela: sped_proctrab_infoInterm
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_nrProcTrab, cod_cpfTrab, num_ideseqtrab, cdn_categ, dat_inic_contrat, cod_matricula, cod_per_ref, idi_dia_trab_interm

### Índices

---

## Tabela: sped_proctrab_infoProcRet
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_nrProcTrab, cod_cpfTrab, cod_per_apur_pgto, cod_receita_irrf, idi_tp_proc_ret, cod_nr_proc_ret, cod_susp, num_ideseqproc

### Índices

---

## Tabela: sped_proctrab_info_dep_v2
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_nrProcTrab, cod_per_apur_pgto, cod_cpfTrab, cpf_dep, num_ideseqproc

### Índices

---

## Tabela: sped_proctrab_info_valor
**Label**: Valor Rend. Exig. Susp.
**Descrição**: Valor do rendimento com exigibilidade suspensa

### Chave Primária
- cdn_empresa, cod_nrProcTrab, cod_cpfTrab, cod_per_apur_pgto, cod_receita_irrf, idi_tp_proc_ret, cod_nr_proc_ret, cod_susp, num_ideseqproc

### Índices

---

## Tabela: sped_proctrab_inforCrIrrf
**Label**: Val. Rend. Trib. IR 13
**Descrição**: Valor do rendimento tribut�vel do Imposto de Renda referente ao 13� sal�rio - Tributa��o exclusiva.

### Chave Primária
- cdn_empresa, cod_nrProcTrab, cod_cpfTrab, cod_per_apur_pgto, cod_receita_irrf, num_ideseqproc

### Índices

---

## Tabela: sped_proctrab_mudCategAtiv
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_nrProcTrab, cod_cpfTrab, num_ideseqtrab, cdn_categ, dat_inic_contrat, cod_matricula, dat_mud_categ_ativ

### Índices

---

## Tabela: sped_proctrab_observacoes
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_nrProcTrab, cod_cpfTrab, num_ideseqtrab, cdn_categ, dat_inic_contrat, cod_matricula, cdn_observacao

### Índices

---

## Tabela: sped_proctrab_pen_alim_v2
**Label**: Valor Pens�o Alimenticia
**Descrição**: Valor relativo � dedu��o do rendimento tribut�vel correspondente a pagamento de pens�o aliment�cia.

### Chave Primária
- cdn_empresa, cod_nrProcTrab, cod_cpfTrab, cod_per_apur_pgto, cod_receita_irrf, idi_tp_rend, cpf_dep, num_ideseqproc

### Índices

---

## Tabela: sped_proctrab_processo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_nrProcTrab, cod_cpfTrab, num_ideseqtrab

### Índices

---

## Tabela: sped_proctrab_remuneracao
**Label**: Salǭrio Fixo
**Descrição**: Salǭrio base do trabalhador, correspondente �� parte fixa da remunera��ǜo na competǦncia final

### Chave Primária
- cdn_empresa, cod_nrProcTrab, cod_cpfTrab, num_ideseqtrab, cdn_categ, dat_inic_contrat, cod_matricula, dat_remun

### Índices

---

## Tabela: sped_proctrab_unicContr
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_nrProcTrab, cod_cpfTrab, num_ideseqtrab, cdn_categ, dat_inic_contrat, cod_matricula, cod_chave_unicContr

### Índices

---

## Tabela: sped_rat_prestdor_parc
**Label**: Valor Rateio
**Descrição**: Valor Movimento Rateio Prestador

### Chave Primária
- cdn_empresa, cdn_estab, cdn_prestdor_serv, dat_refer_movto_prestdor_serv, idi_tip_pessoa, cod_id_feder, cod_ser_docto_rh, cod_unid_negoc, num_docto_movto_prestdor_serv, num_parc, cdn_estab_trab, cod_rh_ccusto, cod_tip_mdo

### Índices

---

## Tabela: sped_relacto_event
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_event_fp, cod_empres_event_sped, cod_event_exclus_sped, idi_tip_event, dat_inic_valid

### Índices
- **spdrlctv_ix**: cdn_empresa, cdn_event_fp
- **spdrlctv_ix2**: cod_empres_event_sped, cod_event_exclus_sped, idi_tip_event, num_seq

---

## Tabela: sped_relacto_exclus
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_event_fp, cod_empres_relacto, dat_inic_valid

### Índices

---

## Tabela: sped_relat_fgts
**Label**: Valor C�lculo Governo
**Descrição**: Valor C�lculo Governo

### Chave Primária
- cdn_empres_centrdor, cdn_estab_centrdor, cod_id_feder, idi_indic_apurac, num_ano_mes_apurac, idi_tip_inscr, cod_inscr, cod_lotac_tributar, cdn_categ_sped, cod_matr_sped, idi_tip_val, num_ano_mes_period_ant

### Índices

---

## Tabela: sped_relat_inss
**Label**: Valor C�lculo Governo
**Descrição**: Valor C�lculo Governo

### Chave Primária
- cdn_empres_centrdor, cdn_estab_centrdor, cod_id_feder, idi_indic_apurac, num_ano_mes_apurac, idi_tip_inscr, cod_inscr, cod_lotac_tributar, cdn_categ_sped, cod_matr_sped, idi_tip_val

### Índices

---

## Tabela: sped_relat_inss_base_calc
**Label**: M�s
**Descrição**: M�s

### Chave Primária
- idi_indic_apurac, cdn_empres_centrdor, cdn_estab_centrdor, cod_lotac_tributar, cdn_categ_trab_sped, num_mes_inss_emp, num_ano_inss_emp, cdn_empresa, cdn_estab

### Índices

---

## Tabela: sped_relat_inss_dissidio
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empres_centrdor, cdn_estab_centrdor, cod_id_feder, idi_indic_apurac, cod_inscr, cod_lotac_tributar, cdn_categ_sped, cod_matr_sped, num_ano_mes_apurac, num_ano_mes_period_ant, idi_tip_val

### Índices

---

## Tabela: sped_relat_inss_emp
**Label**: Vlr Total Contrib Descontada
**Descrição**: Valor Total Contrib Descontada

### Chave Primária
- idi_indic_apurac, cdn_empres_centrdor, cdn_estab_centrdor, num_mes_inss_emp, num_ano_inss_emp, idi_tip_inscr

### Índices

---

## Tabela: sped_relat_inss_estab
**Label**: M�s
**Descrição**: M�s

### Chave Primária
- idi_indic_apurac, cdn_empres_centrdor, cdn_estab_centrdor, num_mes_inss_emp, num_ano_inss_emp, idi_tip_inscr, cod_inscr_cno, cdn_empresa, cdn_estab

### Índices

---

## Tabela: sped_relat_inss_lot_tribut
**Label**: M�s
**Descrição**: M�s

### Chave Primária
- idi_indic_apurac, cdn_empres_centrdor, cdn_estab_centrdor, cod_lotac_tributar, num_mes_inss_emp, num_ano_inss_emp, cdn_empresa, cdn_estab

### Índices

---

## Tabela: sped_relat_inss_valor
**Label**: Valor Governo
**Descrição**: Valor Governo

### Chave Primária
- idi_indic_apurac, cdn_empres_centrdor, cdn_estab_centrdor, cod_lotac_tributar, cdn_categ_trab_sped, num_mes_inss_emp, num_ano_inss_emp, idi_tip_val, cdn_empresa, cdn_estab

### Índices

---

## Tabela: sped_relat_inss_valor_cr
**Label**: Valor Suspenso Ret
**Descrição**: Valor Suspenso Ret

### Chave Primária
- idi_indic_apurac, cdn_empres_centrdor, cdn_estab_centrdor, num_mes_inss_emp, num_ano_inss_emp, cod_receita, cdn_empresa, cdn_estab

### Índices

---

## Tabela: sped_relat_irf_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empres_centrdor, cdn_estab_centrdor, cod_id_feder, cod_perf_ref, cod_identif_demonst, idi_tip_pagto, cod_per_apur_pgto, cdn_tip_pagto

### Índices

---

## Tabela: sped_remun_cpf
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empres_centrdor, cdn_estab_centrdor, cod_id_feder, num_ano_mes_apurac

### Índices

---

## Tabela: sped_remun_itens
**Label**: Valor Unit�rio
**Descrição**: Valor unit�rio da unidade

### Chave Primária
- cdn_empres_centrdor, cdn_estab_centrdor, cod_id_feder, num_ano_mes_apurac, num_recibo_pagto, idi_indic_apurac, cod_lotac_tributar, num_ano_mes_period_ant, cdn_event_fp

### Índices

---

## Tabela: sped_remun_multiplo_vinc
**Label**: Remunera��o M�ltiplos V�nculos
**Descrição**: Valor da Remunera��o de Funcion�rio com M�ltiplos V�nculos

### Chave Primária
- cdn_empres_centrdor, cdn_estab_centrdor, cod_id_feder, num_ano_mes_apurac, idi_tip_inscr_multiplo_vinc, cod_id_feder_multiplo_vinc, num_seq_multiplo_vinc

### Índices
- **spdrmnml_ix2**: cdn_empresa, cdn_estab, cdn_funcionario, cdn_event_fp, num_seq_movto_fp_control_parc

---

## Tabela: sped_remun_recibo
**Label**: Vl Recibo Pagto
**Descrição**: Valor Recibo Pagamento

### Chave Primária
- cdn_empres_centrdor, cdn_estab_centrdor, cod_id_feder, num_ano_mes_apurac, num_recibo_pagto, idi_indic_apurac

### Índices
- **spdrmnrc_ix2**: cdn_empresa, cdn_estab, cdn_funcionario, num_ano_mes_apurac, idi_tip_fp, qti_parc_habilit_calc_fp
- **spdrmnrc_ix3**: cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_ferias, dat_inic_period_aqst_ferias, cdn_tip_calc_ferias
- **spdrmnrc_ix4**: cdn_empresa, cdn_estab, cdn_funcionario, cdn_tip_calc_rescis

---

## Tabela: sped_repas
**Label**: Valor Repasse
**Descrição**: Valor Repasse

### Chave Primária
- cdn_empresa, cdn_estab, idi_tip_repas_proces, dat_repas

### Índices

---

## Tabela: sped_rh_clien_ambien_risco
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_clien_rh, cod_empres_ambien_risco, cod_estab_ambien_risco, num_ambien_risco

### Índices

---

## Tabela: sped_rh_estab
**Label**: Valor Subteto
**Descrição**: valor Subteto

### Chave Primária
- cdn_empresa, cdn_estab

### Índices

---

## Tabela: sped_rh_estab_program_doc
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cod_program_doc, dat_inic_program

### Índices

---

## Tabela: sped_rh_pessoa_jurid
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- num_pessoa_jurid

### Índices

---

## Tabela: sped_risco_acidte_trab
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, num_ambien_risco, num_riscacid

### Índices

---

## Tabela: sped_risco_perf_profis
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_clien_rh, num_ambien_risco, idi_tip_local_ambien, num_riscacid, cod_agent_risco, dat_inic_riscacid, cdn_empres_func, cdn_estab_func, cdn_funcionario

### Índices

---

## Tabela: sped_risco_prestdor_serv
**Label**: Intensidade
**Descrição**: Intensidade da Exposi��o

### Chave Primária
- cdn_empresa, cdn_prestdor_serv, num_ambien_risco, idi_tip_prestdor_serv, num_riscacid

### Índices

---

## Tabela: sped_risco_rh_clien
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_clien_rh, num_ambien_risco, idi_natur_clien, num_riscacid

### Índices

---

## Tabela: sped_segur_grp_atrib_arq
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_grp_atrib_dados, cod_grp_usuar

### Índices

---

## Tabela: sped_segur_grp_atrib_sit
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_grp_atrib_dados, cod_grp_usuar

### Índices

---

## Tabela: sped_sit_afast
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_sit_afast_func

### Índices

---

## Tabela: sped_sit_afast_func
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_sit_afast, num_horar_inic_sit_afast

### Índices

---

## Tabela: sped_soft_arq
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, num_pj_soft_house, cod_arq_msg_sped, cod_orig_arq, dat_inic_valid

### Índices

---

## Tabela: sped_soft_config_arq
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, num_pj_soft_house, cod_arq_msg_sped, cod_orig_arq, dat_inic_valid, cod_bloco_xml_pai, cod_bloco_xml

### Índices

---

## Tabela: sped_soft_house
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, num_pj_soft_house

### Índices

---

## Tabela: sped_ticket_code
**Label**: Seq Ticket Code
**Descrição**: Valor Sequencia Ticket Code

### Chave Primária
- val_seq_ticket_code

### Índices
- **spdtcktc_ix2**: val_seq_msg_sped, val_seq_ticket_code
- **spdtcktc_ix3**: cod_ticket_code, val_seq_msg_sped

---

## Tabela: sped_tomador_entid_educnal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_clien_rh, num_pessoa_jurid

### Índices

---

## Tabela: sped_trabdor_avulso
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empres_centrdor, cdn_estab_centrdor, idi_period_apurac, idi_tip_inscr, cod_cgc_inscr_estad, num_ano, num_mes, cod_lotac_sped

### Índices

---

## Tabela: sped_trabdor_substdo
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cod_id_feder_substdo, idi_tip_participan_sped, cdn_participan_sped

### Índices

---

## Tabela: sped_trein_capacit_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_participan_sped, cdn_trein_capacit, dat_emis_certif

### Índices
- **spdtrncp_ix3**: cdn_trein_capacit

---

## Tabela: sped_turno_trab
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_turno_trab

### Índices

---

## Tabela: sped_unid_lotac_estab
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, cdn_plano_lotac, cod_unid_lotac, dat_inic_valid

### Índices

---

## Tabela: sped_unid_medid_segur
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_unid_medid

### Índices

---

## Tabela: sped_valid_tab
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- idi_tip_inform_msg_sped, cdn_empres_centrdor, cdn_estab_centrdor, cod_refer_inform_sped_1, cod_refer_inform_sped_2, cod_refer_inform_sped_3, dat_inic_valid

### Índices

---

## Tabela: sped_vers_layout
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, cdn_estab, dat_inic_valid

### Índices

---

## Tabela: sub_grp_ccusto_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_grp_ccusto_orcto, cdn_sub_grp_ccusto_orcto

### Índices

---

## Tabela: sugest_matr_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, idi_sugest_cod_func, cod_unid_federac

### Índices
- **sgstmtrf_1**: cdn_empresa, cdn_estab, cdn_func_centrdor, idi_sugest_cod_func, cod_unid_federac

---

## Tabela: suplen_cipa
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_mandat_cipa, cdn_funcionario, num_seq_suplen_cipa

### Índices

---

## Tabela: tab_cenar_calc_retroat
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_empresa, num_ano_refer_fp, num_mes_refer_fp, nom_tab, num_seq

### Índices

---

## Tabela: tab_competit
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_competit

### Índices

---

## Tabela: tab_conver_unid_rh
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq

### Índices

---

## Tabela: tab_dias_aviso
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, dat_alter, qti_anos_ate, qti_meses_ate

### Índices

---

## Tabela: tab_dias_aviso_mestre
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, dat_alter

### Índices

---

## Tabela: tab_dispon_calc
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- nom_tab_dic_dados

### Índices

---

## Tabela: tab_irf_inss
**Label**: UFIR M�s
**Descrição**: Valor da UFIR do m�s

### Chave Primária
- num_ano_refer_tab_irf_inss, num_mes_refer_tab_irf_inss

### Índices

---

## Tabela: tab_irf_inss_particip_lucro
**Label**: T�rmino Faixa
**Descrição**: Valor final da faixa (se ultima faixa preencher com 9`s)

### Chave Primária
- num_ano_refer_tab_irf_inss, num_mes_refer_tab_irf_inss, cdn_sindicato

### Índices

---

## Tabela: tab_irf_sind
**Label**: T�rmino Faixa
**Descrição**: Valor final da faixa (se ultima faixa preencher com 9`s)

### Chave Primária
- cdn_sindicato, num_ano_refer_tab_irf_inss, num_mes_refer_tab_irf_inss

### Índices

---

## Tabela: tab_preco_conven
**Label**: Valor Unit Coeficiente
**Descrição**: Valor Unitario Coeficiente

### Chave Primária
- cdn_empresa, cdn_prestdor_serv, cod_exam_medic, dat_inic_valid_preco_exam

### Índices
- **tbprccnv_exam**: cod_exam_medic, cdn_empresa, cdn_prestdor_serv, dat_term_valid_preco_exam

---

## Tabela: tab_preco_vacina_aplic
**Label**: Valor
**Descrição**: Valor Servico Tabela Preco Vacina

### Chave Primária
- cdn_empresa, cdn_prestdor_serv, cod_vacina_aplic, dat_inic_tab_preco_vacina_aplic

### Índices
- **tbprcvcn_vcnplcds**: cod_vacina_aplic

---

## Tabela: tab_sal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_tab_sal

### Índices
- **tabsal_clscrg**: cdn_clas_cargo
- **tabsal_rgsl**: cdn_regiao_sal
- **tabsal_tbcmptt**: cdn_competit

---

## Tabela: tab_sal_mes
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_tab_sal, num_seq_tab_sal

### Índices

---

## Tabela: tab_sal_mestre
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_categ_sal, cdn_tab_sal, dat_tab_sal_inic, dat_tab_sal_fim

### Índices

---

## Tabela: tab_sal_remun
**Label**: Sal Pto M�dio
**Descrição**: Valor Sal�rio Ponto M�dio

### Chave Primária
- cdn_empresa, cdn_tab_sal, num_seq_tab_sal, qtd_pto_inic_cargo

### Índices
- **tbslrmn_mtvlbrsl**: cdn_motiv_liber_sal

---

## Tabela: tab_serv_agric
**Label**: Valor Unit�rio
**Descrição**: Valor Unit�rio Servi�o Agr�cola

### Chave Primária
- cdn_empresa, cdn_propried_agric, cdn_produt_agric, cdn_safra_produt, dat_movto_agric, cdn_tab_serv_agric

### Índices
- **tbsrvgrc_undgrr**: cdn_empresa, cdn_propried_agric, cdn_produt_agric, cod_niv_estrut_agrar_1, cod_niv_estrut_agrar_2, cod_niv_estrut_agrar_3, cod_niv_estrut_agrar_4

---

## Tabela: tab_val_formul_calc_fp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_tab_valores_fp, num_seq_tab_valores_fp

### Índices

---

## Tabela: tab_val_hora_aula_mestre
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_tab_val_hora_aula, dat_valid_inic_val_aula, dat_valid_fim_val_aula

### Índices

---

## Tabela: tab_val_percent
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tab_val_percent

### Índices

---

## Tabela: tab_val_percent_faixa
**Label**: Valor Percentual
**Descrição**: Valor Percentual Faixa Tabela Valores ou Percentuais

### Chave Primária
- cdn_tab_val_percent, num_faixa_tab_val_percent

### Índices

---

## Tabela: tab_valores_formul_calc
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_tab_valores_formul_calc, dat_inic_vigenc

### Índices

---

## Tabela: tar_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tar_ambntal

### Índices

---

## Tabela: tar_concdo_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_plano_prh, num_seq_cronog, cdn_empresa, cdn_estab, cdn_funcionario

### Índices

---

## Tabela: terc_acidte_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_prestdor_serv, cdn_ter_prestdor_serv, num_acidtrab, num_consmedic

### Índices
- **trccdttr_acdttrb**: num_acidtrab
- **trccdttr_cat**: cdn_empresa, cdn_estab, num_acidtrab, num_cat_acidtrab
- **trccdttr_cnsmdc**: cdn_empresa, cdn_estab, num_consmedic

---

## Tabela: terc_cartao_pto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_terc_ptoelet

### Índices
- **trccrtpt_carg**: cdn_empresa, cdn_estab, cdn_cargo_basic, cdn_niv_cargo, cdn_terc_ptoelet
- **trccrtpt_localidade**: cdn_empresa, cod_pais, cdn_localidade, cdn_terc_ptoelet
- **trccrtpt_prstdrsr**: cdn_empresa, cdn_prestdor_serv
- **trccrtpt_rhpssfsc**: num_pessoa_fisic
- **trccrtpt_tm02701**: cdn_empresa, num_cartao_pto_func
- **trccrtpt_tm02702**: cod_categ_refei
- **trccrtpt_tm02703**: cdn_empresa, cod_rh_ccusto, cdn_estab, cdn_terc_ptoelet
- **trccrtpt_tm02706**: cdn_empresa, cdn_estab, cdn_terc_ptoelet
- **trccrtpt_tm02709**: cdn_turno_trab, cdn_turma_trab, cdn_terc_ptoelet
- **trccrtpt_undep**: cdn_empresa, cdn_estab, cdn_plano_lotac, cod_unid_lotac, cdn_terc_ptoelet

---

## Tabela: termo_legal_cartao_pto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_termo_legal_cartao_pto

### Índices

---

## Tabela: test_psicolog_candidato
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_candempr, dat_atualiz

### Índices

---

## Tabela: test_psicolog_pessoa
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- num_pessoa_fisic, dat_atualiz

### Índices

---

## Tabela: text_atstdo_medic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_text_atstdo_medic

### Índices

---

## Tabela: text_contrat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_modelo, idi_tip_model

### Índices

---

## Tabela: text_recibo_norma_segur
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, num_text_recibo_norma_segur

### Índices

---

## Tabela: time_trab_compon
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_time_trab, cdn_empresa, cdn_estab, cdn_funcionario, dat_inic_valid

### Índices
- **tmtrbcmp_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario
- **tmtrbcmp_tmtrbtpp**: cdn_time_trab_tip_particip

---

## Tabela: time_trab_rh
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_time_trab

### Índices

---

## Tabela: time_trab_tip_particip
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_time_trab_tip_particip

### Índices

---

## Tabela: tip_acidte_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_acidte_ambntal

### Índices

---

## Tabela: tip_acidte_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_acidtrab

### Índices

---

## Tabela: tip_adc_ferias_13o
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_tip_adc_ferias_13o

### Índices

---

## Tabela: tip_area_agric
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_area_agric

### Índices

---

## Tabela: tip_arq_docto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_arq

### Índices

---

## Tabela: tip_avaliac_cargo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_model_avaliac_cargo

### Índices

---

## Tabela: tip_avaliac_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_avaliac_trein

### Índices

---

## Tabela: tip_calc_verba
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_tip_calc_verba

### Índices
- **tpclcvrb_tipatu**: idi_tip_calc_atual
- **tpclcvrb_tipclc**: idi_tip_calc_verba

---

## Tabela: tip_caract_exam_medic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_caract_exam

### Índices

---

## Tabela: tip_cargo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_cargo

### Índices

---

## Tabela: tip_cargo_event_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_cenar_orcto, cdn_event_orcto, cod_tip_cargo

### Índices
- **tpcrgvnt_variac**: cod_tip_cargo, cdn_cenar_orcto, cdn_event_orcto

---

## Tabela: tip_cargo_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_cargo

### Índices

---

## Tabela: tip_climtzcao_ambien
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_climtzcao_depto

### Índices

---

## Tabela: tip_contrat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_contrat_func

### Índices

---

## Tabela: tip_cor_exam
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_cor_exam

### Índices

---

## Tabela: tip_curric
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_curric_func

### Índices
- **tpcrrc_avpslytr**: cdn_avpes_layout_relat

---

## Tabela: tip_curso_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_curso_trein

### Índices

---

## Tabela: tip_cust_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_cust_trein

### Índices

---

## Tabela: tip_descr_cargo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_descr_cargo

### Índices

---

## Tabela: tip_despes_acidtrab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_despes_acidtrab

### Índices

---

## Tabela: tip_dest_final
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_dest_final

### Índices

---

## Tabela: tip_dia_benefic
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_beneficio, cdn_regra_benefic, cod_tip_dia

### Índices
- **tpdbnfc_py17701**: cod_tip_dia

---

## Tabela: tip_dia_horar_turno_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_dia, idi_sit_dia_trab

### Índices
- **tpdhrrtr_py17801**: idi_sit_dia_trab, cod_tip_dia

---

## Tabela: tip_eqpto_curso_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_eqpto_trein, cdn_curso_trein

### Índices
- **tpqptcrs_crstrn**: cdn_curso_trein

---

## Tabela: tip_eqpto_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_eqpto_trein

### Índices

---

## Tabela: tip_etap_sel_candidato
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_etap_sel_candempr

### Índices

---

## Tabela: tip_ficha_acompto_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_acompto_func

### Índices

---

## Tabela: tip_formul
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- idi_tip_formul, cod_formul_rh

### Índices

---

## Tabela: tip_formul_event_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- idi_tip_formul, cod_formul_rh

### Índices

---

## Tabela: tip_grp_docto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_grp_docto

### Índices

---

## Tabela: tip_hora_compens
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_compcao_hrs

### Índices
- **tphrcmpn_compcao**: cdn_tip_compcao_hrs, idi_tip_hrs_compens

---

## Tabela: tip_horar_contrat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_contrat_func, cdn_tip_hora_contrat

### Índices

---

## Tabela: tip_ident_aces
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_ident_aces

### Índices

---

## Tabela: tip_ilumcao_depto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_ilumcao_depto

### Índices

---

## Tabela: tip_indcao
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_indcao

### Índices

---

## Tabela: tip_inspec_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_inspec

### Índices

---

## Tabela: tip_licenc_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_licenc

### Índices

---

## Tabela: tip_local_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_local_trein

### Índices

---

## Tabela: tip_mater_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_mater_trein

### Índices

---

## Tabela: tip_mdo
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_mdo

### Índices

---

## Tabela: tip_mdo_despes
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_tip_mdo

### Índices

---

## Tabela: tip_motiv_liber_sal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_motiv_liber_sal

### Índices

---

## Tabela: tip_neces_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_nec_func

### Índices

---

## Tabela: tip_obj_visitante
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_obj_visitante

### Índices

---

## Tabela: tip_ocor_aces
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_ocor_aces, idi_fabrican_disposit_aces

### Índices

---

## Tabela: tip_pagto_proces_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_pagto_proces_trab

### Índices

---

## Tabela: tip_pcacid
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_pcacid

### Índices

---

## Tabela: tip_pessoa_ext_trein
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_pessoa_ext

### Índices

---

## Tabela: tip_prestdor_serv_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_prestdor_serv_ambntal

### Índices

---

## Tabela: tip_proces
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_proces

### Índices

---

## Tabela: tip_proces_gerac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_proces_gerac

### Índices

---

## Tabela: tip_proj_ambntal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_proj_ambntal

### Índices

---

## Tabela: tip_refei
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_tip_refei

### Índices

---

## Tabela: tip_restdo_item_exam
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_restdo_item_exam

### Índices

---

## Tabela: tip_serv_agric
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_serv_agric

### Índices

---

## Tabela: tip_serv_ext
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_serv_ext

### Índices

---

## Tabela: tip_sit_sucess
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_sit_sucess

### Índices

---

## Tabela: tip_unid_lotac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_unid_lotac

### Índices

---

## Tabela: tip_unid_lotac_plano
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_plano_lotac, cod_tip_unid_lotac

### Índices
- **tpndltcp_niv**: num_niv_unid_lotac
- **tpndltcp_tpnddprt**: cod_tip_unid_lotac

---

## Tabela: tip_unid_plano_habcomp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_plano_habcomp, cod_tip_unid_plano_habcomp

### Índices
- **tpndplnh_seq**: cdn_plano_habcomp, num_tip_unid_plano_habcomp

---

## Tabela: tip_ventlcao_depto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_tip_ventlcao_depto

### Índices

---

## Tabela: tip_visitante_aces
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_visitante_aces

### Índices

---

## Tabela: tit_pagto
**Label**: Valor T�tulo
**Descrição**: Valor Titulo Pagamento

### Chave Primária
- cdn_empresa, num_tit_pagto

### Índices
- **titpagto_dtpagto**: cdn_empresa, dat_pagto_tit, num_tit_pagto
- **titpagto_grpdat**: cdn_empresa, cdn_grp_pagto, dat_pagto_tit, num_tit_pagto
- **titpagto_grppagto**: cdn_empresa, cdn_grp_pagto, num_tit_pagto
- **titpagto_seqpro**: cdn_empresa, num_seqcial_process, num_tit_pagto

---

## Tabela: tit_pagto_prestdor
**Label**: Valor T�tulo
**Descrição**: Valor Titulo Pagamento

### Chave Primária
- cdn_prestdor_serv, cod_ser_docto_rh, num_docto

### Índices
- **ttpgtprs_cgccpf**: cdn_empresa, cod_id_feder, idi_tip_prestdor_serv
- **ttpgtprs_dtpagprest**: cdn_empresa, dat_pagto_tit, cdn_prestdor_serv, cod_ser_docto_rh, num_docto
- **ttpgtprs_numseqpro**: cdn_empresa, num_seqcial_process
- **ttpgtprs_prest**: cdn_empresa, cdn_estab, cdn_prestdor_serv, cod_ser_docto_rh, num_docto
- **ttpgtprs_prestdocto**: cdn_empresa, cdn_prestdor_serv, cod_ser_docto_rh, num_docto
- **ttpgtprs_prestdtpag**: cdn_empresa, cdn_prestdor_serv, dat_pagto_tit, cod_ser_docto_rh, num_docto

---

## Tabela: trab_cargo
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_tab_aux, cdd_seq_reg

### Índices

---

## Tabela: trab_recrut
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_tab_aux, cdd_seq_reg

### Índices

---

## Tabela: trab_trein
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_tab_aux, cdd_seq_reg

### Índices

---

## Tabela: trajet_prof
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_trajet_prof

### Índices
- **trjtprf_valunit**: cdn_empresa, cdn_val_unit_fp

---

## Tabela: trajet_prof_entid_educnal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_trajet_prof, num_mes_refer_fp, num_ano_refer_fp, cod_rh_ccusto

### Índices

---

## Tabela: trans_sist_rh
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cod_trans_sist_rh

### Índices

---

## Tabela: transpdor_rural
**Label**: Comiss�o
**Descrição**: Valor Percentual Comissao Transportador

### Chave Primária
- cdn_empresa, cdn_transpdor_rural

### Índices
- **trnspdrr_fncnr**: cdn_empresa, cdn_estab, cdn_funcionario
- **trnspdrr_prstdrsr**: cdn_empresa, cdn_prestdor_serv

---

## Tabela: transpdor_rural_lotac
**Label**: Comiss�o
**Descrição**: Valor Percentual Comissao Transportador

### Chave Primária
- cdn_empresa, cdn_transpdor_rural, cdn_turma_rural

### Índices
- **trnspdra_undltcpl**: cdn_plano_lotac, cod_unid_lotac

---

## Tabela: transpdor_rural_pagto
**Label**: Pagamento Transporte
**Descrição**: Valor Pagamento Transporte

### Chave Primária
- cdn_empresa, num_proces_pagto_prestdor, cod_ser_docto_rh, num_docto_movto_prestdor_serv

### Índices
- **trnspdrc_trnspdrr**: cdn_empresa, cdn_transpdor_rural

---

## Tabela: transpdor_rural_pagto_cont
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, num_proces_pagto_prestdor

### Índices

---

## Tabela: trein_cipa
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_trein_cipa

### Índices

---

## Tabela: trein_cipa_func
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_funcionario, cdn_trein_cipa, dat_trein_cipa

### Índices
- **trncpfnc_py18401**: cdn_trein_cipa

---

## Tabela: treindo_turma_trein
**Label**: M�dia Nota
**Descrição**: Valor da M�dia de Nota

### Chave Primária
- cdn_curso_trein, cdn_turma_trein, cdn_treindo_normal

### Índices
- **trndtrmt_fncnr**: cdn_empresa, cdn_estab, cdn_treindo
- **trndtrmt_lstnscr**: cdn_curso_trein, cdn_lista_inscr
- **trndtrmt_mtvdsbtc**: cdn_motiv_desabtcao_treindo
- **trndtrmt_pssxttrn**: cdn_treindo
- **trndtrmt_rhpssfsc**: num_pessoa_fisic

---

## Tabela: turma_carg_horar
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_curso_trein, cdn_turma_trein, num_mes_ano_turma

### Índices

---

## Tabela: turma_curso_agreg
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_curso_trein, cdn_turma_trein, cdn_curso_agreg

### Índices

---

## Tabela: turma_folha_educnal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cod_turma_entid_educnal

### Índices
- **trmflhdc_tipo_turma**: cdn_tip_turma_educnal

---

## Tabela: turma_rural
**Label**: Comiss�o
**Descrição**: Valor Percentual Comissao Transportador

### Chave Primária
- cdn_empresa, cdn_turma_rural_empres

### Índices
- **trmrrl_cltrdds**: cdn_empresa, cdn_coletor_dados
- **trmrrl_lntrnspr**: cdn_lin_transp_rural

---

## Tabela: turma_rural_diaria_min
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_turma_rural_empres, dat_inic_lotac_func

### Índices

---

## Tabela: turma_rural_fisc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_turma_rural_empres, cdn_fisc_tar_agric, dat_inic_lotac_func

### Índices
- **trmrrlfs_fsctrgrc**: cdn_fisc_tar_agric

---

## Tabela: turma_rural_lotac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_turma_rural_empres, cdn_plano_lotac, cod_unid_lotac, dat_inic_lotac_func

### Índices
- **trmrrllt_undltcpl**: cdn_plano_lotac, cod_unid_lotac

---

## Tabela: turma_rural_transpdor
**Label**: Tonelada M�nima
**Descrição**: Tonelada M�nima

### Chave Primária
- cdn_empresa, cdn_transpdor_rural, cdn_turma_rural_empres, dat_inic_lotac_func

### Índices
- **trmrrltr_lntrnspr**: cdn_lin_transp_rural
- **trmrrltr_tbvlprcn**: cdn_tab_val_percent
- **trmrrltr_trmrrl**: cdn_empresa, cdn_turma_rural_empres

---

## Tabela: turma_rural_transpdor_subst
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_turma_rural_empres, cdn_transpdor_rural_subst, dat_inic_lotac_func

### Índices
- **trmrrlta_trnspdrr**: cdn_empresa, cdn_transpdor_rural_subst

---

## Tabela: turma_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_turno_trab, cdn_turma_trab

### Índices

---

## Tabela: turma_trein
**Label**: M�dia Nota
**Descrição**: Valor da M�dia de Nota

### Chave Primária
- cdn_curso_trein, cdn_turma_trein

### Índices
- **trmtrn_crdntrn**: cdn_coorden_trein
- **trmtrn_frmntrgc**: cdn_curso_trein, cdn_forma_entreg_trein
- **trmtrn_insttcrs**: cdn_curso_trein, cdn_instit_trein
- **trmtrn_instttrn**: cdn_instit_trein

---

## Tabela: turno_grp_turno_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_grp_turno_orcto, cdn_turno_trab

### Índices

---

## Tabela: turno_matriz_aces
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_turno_trab, cdn_turma_trab, cdn_jorn_trab, cdn_interv_refei, num_seq_turno

### Índices
- **trnmtrzc_turnoseq**: cdn_turno_trab, num_seq_turno

---

## Tabela: turno_trab
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_turno_trab

### Índices

---

## Tabela: turno_trab_categ_sal
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_turno_trab, cdn_empresa, cdn_estab, cdn_categ_sal

### Índices
- **trntrbct_empturno**: cdn_empresa, cdn_estab, cdn_categ_sal, cdn_turno_trab

---

## Tabela: turno_trab_compl
**Label**: Livre 2
**Descrição**: �ndice prim�rio e �nico da tabela turno_trab_compl

### Chave Primária
- cdn_turno_trab

### Índices

---

## Tabela: turno_trab_event_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_cenar_orcto, cdn_event_orcto, cdn_turno_trab

### Índices
- **trntrbvn_turno**: cdn_turno_trab, cdn_cenar_orcto, cdn_event_orcto

---

## Tabela: unid_agrar
**Label**: Produ��o Realizada
**Descrição**: Valor Producao Realizado

### Chave Primária
- cdn_empresa, cdn_propried_agric, cdn_produt_agric, cdn_safra_produt, cod_niv_estrut_agrar_1, cod_niv_estrut_agrar_2, cod_niv_estrut_agrar_3, cod_niv_estrut_agrar_4

### Índices
- **undgrr_arprprdg**: cdn_empresa, cdn_propried_agric, cdn_tip_area_agric
- **undgrr_tprgrc**: cdn_tip_area_agric
- **undgrr_transp**: cdn_empresa, cdn_propried_agric, cdn_produt_agric, cdn_safra_produt, dat_transp_produt, cod_niv_estrut_agrar_1, cod_niv_estrut_agrar_2, cod_niv_estrut_agrar_3, cod_niv_estrut_agrar_4

---

## Tabela: unid_instruc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_curso_trein, cdn_unid_instruc

### Índices

---

## Tabela: unid_lotac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_lotac

### Índices

---

## Tabela: unid_lotac_event_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_cenar_orcto, cdn_event_orcto, cdn_estab, cod_unid_lotac

### Índices
- **undltcvn_unid_lotac**: cdn_estab, cod_unid_lotac, cdn_cenar_orcto, cdn_event_orcto

---

## Tabela: unid_lotac_plano
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_plano_lotac, cod_unid_lotac

### Índices
- **undltcpl_nivudpl**: num_niv_unid_lotac
- **undltcpl_sequnddpt**: cdn_plano_lotac, num_seq_unid_lotac
- **undltcpl_tpnddprt**: cod_tip_unid_lotac
- **undltcpl_tpndltcp**: cdn_plano_lotac, cod_tip_unid_lotac
- **undltcpl_undltc**: cod_unid_lotac

---

## Tabela: unid_medid_epi
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_medid

### Índices

---

## Tabela: unid_medid_segur
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_medid

### Índices

---

## Tabela: unid_negoc
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_negoc

### Índices

---

## Tabela: unid_organ
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_unid_organ

### Índices
- **undrgn_rhestab**: cdn_empresa, cdn_estab

---

## Tabela: unid_produt_carreira
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_plano_habcomp, cdn_unid_produt_habcomp, cdn_carreira_habcomp, cdn_bloco_habcomp

### Índices
- **undprdtc_blchbcmp**: cdn_bloco_habcomp
- **undprdtc_crrrplnh**: cdn_carreira_habcomp

---

## Tabela: unid_produt_faixa_remun
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_plano_habcomp, cdn_unid_produt_habcomp, cdn_carreira_habcomp, cdn_bloco_habcomp, dat_inic_valid

### Índices
- **undprdtf_blchbcmp**: cdn_carreira_habcomp, cdn_bloco_habcomp

---

## Tabela: unid_produt_habcomp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_unid_produt_habcomp

### Índices

---

## Tabela: unid_produt_objorg
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_plano_habcomp, cdn_unid_produt_habcomp, cdn_empresa, cdn_plano_organ, cdn_objorg

### Índices
- **undprdtb_objorg**: cdn_empresa, cdn_plano_organ, cdn_objorg
- **undprdtb_undprdth**: cdn_unid_produt_habcomp

---

## Tabela: unid_produt_plano_habcomp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_plano_habcomp, cdn_unid_produt_habcomp

### Índices
- **undprdtp_tpndplnh**: cdn_plano_habcomp, cod_tip_unid_plano_habcomp
- **undprdtp_undprdth**: cdn_unid_produt_habcomp

---

## Tabela: usuar_aces_cracha
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq_ident_aces, cdn_usuar_control_aces, dat_inic_valid_cracha, num_horar_inic_valid_cracha

### Índices
- **usrcscrc_dthr**: cod_cartao_aces, dat_inic_valid_cracha, dat_term_valid_cracha, num_horar_inic_valid_cracha, num_horar_term_valid_cracha
- **usrcscrc_dthr2**: cdn_usuar_control_aces, dat_inic_valid_cracha, num_horar_inic_valid_cracha, dat_term_valid_cracha, num_horar_term_valid_cracha
- **usrcscrc_nm_sq**: num_seq_ident_aces, cdn_usuar_control_aces, dat_inic_valid_cracha, num_horar_inic_valid_cracha

---

## Tabela: usuar_aplicat_rh
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuario

### Índices
- **usrplctr_func**: cdn_empresa, cdn_estab, cdn_funcionario

---

## Tabela: usuar_control_aces
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_usuar_control_aces

### Índices
- **usrcntrl_crt_acss**: cod_cartao_aces
- **usrcntrl_func**: cdn_empresa, cdn_estab, cdn_funcionario
- **usrcntrl_nom**: nom_usuar_control_aces
- **usrcntrl_tipusr**: cdn_usuar_control_aces, idi_tip_usuar_control_aces, cdn_empresa, cdn_estab, cdn_funcionario, cdn_prestdor_serv, cdn_visitante, log_consid_dupl_marcac, log_control_niv, idi_tip_aces_usuar
- **usrcntrl_usufx**: cdn_usuar_control_aces, cdn_empresa, cdn_estab, cdn_funcionario, cdn_prestdor_serv, cdn_visitante
- **usrcntrl_visit**: cdn_visitante

---

## Tabela: usuar_rh
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_usuar_rh

### Índices

---

## Tabela: vacina
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_vacina

### Índices
- **vacina_py19101**: qti_meses_lim_aplic_vacina, cdn_vacina

---

## Tabela: vacina_aplic
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_vacina_aplic

### Índices

---

## Tabela: vacina_aplic_dose
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cod_vacina_aplic, cdn_dose_vacina_aplic

### Índices

---

## Tabela: vacina_aplic_func
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- num_ficha_medic, cod_vacina_aplic, cdn_dose_vacina_aplic, dat_programac_vacina

### Índices
- **vcnplcfn_vcnplcds**: cod_vacina_aplic, cdn_dose_vacina_aplic

---

## Tabela: val_event_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq_planilha_orcto, num_seq_variac_cargo_planilha, cod_clas_cargo, cdn_event_orcto, num_seq_reaj_event_orcto

### Índices

---

## Tabela: val_unit_form_fp
**Label**: Valor Unit�rio
**Descrição**: Valor Unitario Formula Evento Folha de Pagamento

### Chave Primária
- cdn_empresa, cdn_val_unit_fp

### Índices

---

## Tabela: vale_transp_ant
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_beneficio, cdn_funcionario, num_ano_refer_desc_vale_fp, num_mes_refer_desc_vale_transp, cdn_lin_vale_transp, idi_tip_lancto_movto_vale, num_seq_lancto_movto_vale

### Índices

---

## Tabela: variac_cargo_planilha_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq_planilha_orcto, cdn_vers_planilha, cdn_cargo, cdn_niv_cargo, cdn_turno_trab, cod_tip_cargo

### Índices
- **vrccrgpa_1** (Unique): num_seq_planilha_orcto, num_seq_variac_cargo_planilha
- **vrccrgpa_cargo**: cdn_cargo, cdn_niv_cargo
- **vrccrgpa_trntrb**: cdn_turno_trab

---

## Tabela: veic_transp
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_veic_transp

### Índices

---

## Tabela: veic_transp_nao_cfe
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_veic_transp, cod_nao_cfem, dat_inic_nao_cfem

### Índices

---

## Tabela: verba_base_calc
**Label**: Livre 4
**Descrição**: Valor Livre 4

### Chave Primária
- cdn_base_calc, cod_verba_calc, dat_inic_valid

### Índices
- **vrbbsclc_fmvalid**: cod_verba_calc, dat_term_valid

---

## Tabela: verba_calc
**Label**: Taxa Multiplica��o
**Descrição**: Valor Taxa de Multiplica��o do Evento

### Chave Primária
- cod_verba_calc

### Índices

---

## Tabela: vers_planilha_orcto
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- num_seq_planilha_orcto, cdn_vers_planilha

### Índices

---

## Tabela: vinc_empregat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_vinc_empregat

### Índices

---

## Tabela: visitante
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cod_visitante

### Índices

---

## Tabela: visitante_aces
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_visitante

### Índices
- **vstntcs_fdr**: cod_id_feder

---

## Tabela: visitante_event_sipat
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_sipat, cod_event_sipat, dat_event_sipat, hra_event_sipat, cod_visitante

### Índices
- **vstntvnt_vstnt**: cod_visitante

---

## Tabela: vistoria_eqpcol
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_programac_vistoria_eqpcol, cod_eqpcol, dat_inspec_eqpcol, idi_tip_serv_eqpcol

### Índices
- **vstrqpcl_eqpcol**: cdn_empresa, cdn_estab, cod_eqpcol, idi_tip_serv_eqpcol, dat_inspec_eqpcol
- **vstrqpcl_fncnr**: cdn_empresa, cdn_estab, cdn_func_respons
- **vstrqpcl_slctmntq**: cdn_empresa, cdn_estab, num_solicit_manut_eqpcol

---

## Tabela: vistoria_eqpcol_param
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_programac_vistoria_eqpcol

### Índices

---

## Tabela: workflow_histor
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_tip_docto_workflow, cod_docto_workflow, num_seqcial_process

### Índices

---

## Tabela: workflow_job_sched
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- nom_job

### Índices

---

## Tabela: workflow_niv_aprovac
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, num_tip_movimen_quadro_pessoal, cdn_motiv_movimen, num_niv_aprovac

### Índices

---

## Tabela: workflow_objorg
**Label**: Situa��o Inicial
**Descrição**: Valor Situa��o Inicial

### Chave Primária
- cdn_empresa, cdn_plano_organ, cdn_objorg, num_seqcial_movimen

### Índices
- **wrkflwbj_wk**: num_seqcial_movimen

---

## Tabela: workflow_objorg_acao
**Label**: Resultado Realizado
**Descrição**: Resultado Final da A��o em Termos Quantitativos

### Chave Primária
- cdn_empresa, cdn_plano_organ, cdn_objorg, num_acao_objorg, num_seqcial_movimen

### Índices
- **wrkflwba_wk**: num_seqcial_movimen

---

## Tabela: workflow_param
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- nom_servid_e_mail

### Índices

---

## Tabela: workflow_respons_area
**Label**: Livre 2
**Descrição**: Atributo livre para uso interno

### Chave Primária
- cdn_empresa, cdn_estab, cdn_area_respons

### Índices

---

