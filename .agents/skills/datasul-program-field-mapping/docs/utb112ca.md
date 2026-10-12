# Mapeamento de Campos: utb112ca

- **Arquivo**: `C:\Projetos\Macritec\examples-progress\produto-padrao\EMS5\prgint\utb\utb112ca.p`

## Campos de Persistência (Salvos na Tabela Alvo)

**Tabela(s) Alvo**: `representante`

| Label | Campo em Tela | Mapeamento Banco (banco.tabela.campo) |
| :--- | :--- | :--- |
| Empresa | representante.cod_empresa | ems.representante.cod_empresa |
| Representante | representante.cdn_repres | ems.representante.cdn_repres |
| Tipo Representante | representante.cod_tip_repres | ems.representante.cod_tip_repres |
| Pessoa | v_num_pessoa_fis | ems.representante.num_pessoa |
| Pessoa | v_num_pessoa_jur | ems.representante.num_pessoa |
| Nome | representante.nom_pessoa | ems.representante.nom_pessoa |
| País | representante.cod_pais | ems.representante.cod_pais |
| ID Federal | representante.cod_id_feder | ems.representante.cod_id_feder |
| Nome Abreviado | representante.nom_abrev | ems.representante.nom_abrev |
| Grupo Repres | representante.cod_grp_repres | ems.representante.cod_grp_repres |
| Implantação Repres | representante.dat_impl_repres | ems.representante.dat_impl_repres |

## Campos de Consulta/Exibição (Apenas Visualização)

| Label | Campo em Tela | Mapeamento Banco (banco.tabela.campo) |
| :--- | :--- | :--- |
| empresa.nom_razao_social | empresa.nom_razao_social | ems/mg.empresa.nom_razao_social |
| tip_repres.des_tip_repres | tip_repres.des_tip_repres | ems.tip_repres.des_tip_repres |
| Tipo Pessoa | v_ind_pessoa | Não identificado |
| pais.nom_pais | pais.nom_pais | ems/mg.pais.nom_pais |
| grp_repres.des_grp_repres | grp_repres.des_grp_repres | ems.grp_repres.des_grp_repres |

**Gerado em**: 14/05/2026, 15:28:47
