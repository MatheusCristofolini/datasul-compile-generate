# Mapeamento de Campos: ufn014ca

- **Arquivo**: `produto-padrao\EMS5\prgint\ufn\ufn014ca.p`

## Campos de Persistência (Salvos na Tabela Alvo)

**Tabela(s) Alvo**: `repres_financ`

| Label | Campo em Tela | Mapeamento Banco (banco.tabela.campo) |
| :--- | :--- | :--- |
| Empresa | repres_financ.cod_empresa | ems.repres_financ.cod_empresa |
| Representante | repres_financ.cdn_repres | ems.repres_financ.cdn_repres |
| % Comissão | repres_financ.val_perc_comis_repres | ems.repres_financ.val_perc_comis_repres |
| % Comis Emissão | repres_financ.val_perc_comis_repres_emis | ems.repres_financ.val_perc_comis_repres_emis |
| % Comis Abatimento | repres_financ.val_perc_comis_abat | ems.repres_financ.val_perc_comis_abat |
| % Comis Multa | repres_financ.val_perc_comis_multa | ems.repres_financ.val_perc_comis_multa |
| Contrato Comissão | repres_financ.cod_contrat_comis | ems.repres_financ.cod_contrat_comis |
| Comis Mínima | v_val_percent_comis_min | ems.repres_financ.val_perc_comis_min |
| % Mínimo Comissão | v_val_perc_comis_min | ems.repres_financ.val_perc_comis_min |
| % Máximo Comissão | v_val_perc_comis_max | ems.repres_financ.val_perc_comis_max |
| % Comis AVA | repres_financ.val_perc_comis_acerto_val | ems.repres_financ.val_perc_comis_acerto_val |
| % Comis Desconto | repres_financ.val_perc_comis_desc | ems.repres_financ.val_perc_comis_desc |
| % Comis Juros | repres_financ.val_perc_comis_juros | ems.repres_financ.val_perc_comis_juros |
| v_cod_unid_negoc | v_cod_unid_negoc | ems.repres_financ.cod_unid_negoc |
| Portador Geração AD | v_log_bloq_pagto | ems.repres_financ.log_livre_1 |
| Portador Geração AD | v_cod_portad_gerac_avdeb | ems.repres_financ.cod_portador |
| v_cod_cart_bcia_avdeb | v_cod_cart_bcia_avdeb | ems.repres_financ.cod_cart_bcia_avdeb |
| Calendário Pagto | v_cod_calend_comis | ems.repres_financ.cod_calend_comis |
| Tipo de Comissão | v_ind_tip_comis_ext | ems.repres_financ.cod_livre_1 |
| Repres Indireto | repres_financ.cdn_repres_indir | ems.repres_financ.cdn_repres_indir |
| Comissão Indireta | repres_financ.val_perc_comis_repres_indir | ems.repres_financ.val_perc_comis_repres_indir |

## Campos de Consulta/Exibição (Apenas Visualização)

| Label | Campo em Tela | Mapeamento Banco (banco.tabela.campo) |
| :--- | :--- | :--- |
| empresa.nom_razao_social | empresa.nom_razao_social | ems/mg.empresa.nom_razao_social |
| {&emsfin_version} | representante.nom_pessoa | ems.representante.nom_pessoa |
| v_nom_pessoa | v_nom_pessoa | ?.b_representante.nom_pessoa |

**Gerado em**: 14/05/2026, 19:26:21
