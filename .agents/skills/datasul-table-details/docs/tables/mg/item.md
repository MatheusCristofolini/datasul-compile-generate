# Tabela: item

**Banco de Dados**: mg
**Label**: Item
**Descrição**: Arquivo de Itens
**Gerado em**: 24/09/2026, 16:17:34

## Campos

| Campo | Tipo | Label | Formato | Inicial | Obrig. | Include | Help |
| :--- | :--- | :--- | :--- | :--- | :--- | :--- | :--- |
| aliquota-ii | decimal | Al¡quota II | >>9.99 | 0 | Não |  | Informar a al¡quota do Imposto de ImportaÆo |
| aliquota-ipi | decimal | Al¡quota IPI | >>9.99 | 0 | Sim |  |  |
| aliquota-iss | decimal | Al¡quota ISS | >>9.99 | 0 | Sim |  |  |
| alt-refer | logical | Alterar Referncia Ordem | Sim/NÆo | yes | Não |  | Alterar referncia da ordem de compra/produÆo |
| altura | decimal | Altura | >>>,>>9.99999999 | 0 | Sim |  | Altura da pea/item em cent¡metros |
| atu-conf | logical | Atualiza Configurador | Sim/NÆo | yes | Não |  | Indica se atualiza o configurador do sistema |
| baixa-estoq | logical | Baixa Estoque | Sim/NÆo | yes | Sim |  | Indica se o item dever  ser baixado do estoque |
| calc-cons-prev | integer | C lculo Consumo Previsto | >9 | 1 | Sim | [ininc/i09in172.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i09in172.i) | Forma de c lculo do consumo previsto |
| calc-lead-time | integer | C lculo Lead-Time | >9 | 1 | Não | [ininc/i16in172.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i16in172.i) | Forma de c lculo do Lead-Time |
| cap-est-fabr | decimal | Capacidade Estoque F brica | >>>>,>>9.9999 | 0 | Sim |  |  |
| capac-recip-beb | integer | Capacidade Recipiente | >9 | 1 | Não | [ininc/i22in172.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i22in172.i) | Capacidade do recipiente da bebida |
| cd-folh-item | character | Folha EspecificaÆo | x(8) |  | Não |  |  |
| cd-folh-lote | character | Folha EspecificaÆo Lote | x(8) |  | Não |  | Folha de especificaÆo do item/lote |
| cd-formula | integer | F¢rmula | >9 | 1 | Não | [ininc/i24in172.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i24in172.i) | F¢rmula utilizada na previsÆo de vendas autom tica |
| cd-origem | integer | Origem | >9 | 1 | Não | [ininc/i14in122.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i14in122.i) |  |
| cd-planejado | character | Planejador | x(12) |  | Sim |  |  |
| cd-referencia | character | Referncia | x(4) |  | Não |  | Referncia do item grade |
| cd-tag | character | TAG | x(16) |  | Não |  | TAG que mais utiliza o Item |
| cd-trib-icm | integer | C¢digo TributaÆo ICMS | >9 | 1 | Sim | [ininc/i01in245.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i01in245.i) |  |
| cd-trib-ipi | integer | C¢digo TributaÆo IPI | >9 | 1 | Sim | [ininc/i10in172.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i10in172.i) |  |
| cd-trib-iss | integer | C¢digo TributaÆo ISS | >9 | 1 | Sim | [ininc/i11in172.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i11in172.i) |  |
| cdn-emit-benef | integer | Emitente Beneficiamento | >>>>>>>>9 | 0 | Não |  | Emitente Beneficiamento |
| char-1 | character |  | x(200) |  | Não |  |  |
| char-2 | character |  | x(200) |  | Não |  |  |
| check-sum | character | Check-sum | x(20) |  | Não |  |  |
| ciclo-contag | integer | Ciclo Contagem | >>9 | 0 | Sim |  |  |
| class-fiscal | character | ClassificaÆo Fiscal | 9999.99.99 |  | Sim |  |  |
| classe-repro | integer | Classe ReprogramaÆo | >9 | 1 | Sim | [ininc/i06in122.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i06in122.i) |  |
| classif-abc | integer | ClassificaÆo ABC | >9 | 3 | Sim | [ininc/i03in172.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i03in172.i) |  |
| cod-auxiliar | character | Auxiliar | x(40) |  | Não |  | C¢digo auxiliar de acesso. Exemplo: c¢digo senha. |
| cod-comprado | character | Comprador | x(12) |  | Sim |  |  |
| cod-dcr-item | character | Nr DCR Item | x(12) |  | Não |  | N£mero DCR Item |
| cod-destaq | integer | C¢digo Destaque | 99999 | 0 | Sim |  | C¢digo do Destaque na NCM |
| cod-estabel | character | Estabelecimento PadrÆo | x(5) |  | Sim |  | Estabelecimento padrÆo do item |
| cod-imagem | character | Imagem | x(30) |  | Não |  |  |
| cod-item-refugo | character | Item Refugo | x(16) |  | Não |  | C¢digo Item Refugo |
| cod-lista-destino | character | Lista Destino Multiplanta | x(8) |  | Não |  | Informe a lista de destino de atualizaÆo via multiplanta |
| cod-localiz | character | LocalizaÆo | x(20) |  | Não |  |  |
| cod-malha | character | Malha | X(5) | 0 | Não |  | Malha Produtiva |
| cod-obsoleto | integer | SituaÆo | >9 | 1 | Sim | [ininc/i17in172.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i17in172.i) |  |
| cod-produto | character | Produto | x(16) |  | Sim |  |  |
| cod-pulmao | character | PulmÆo | X(5) |  | Não |  | C¢digo do PulmÆo |
| cod-pulmao-proces | character | PulmÆo Processo | x(8) |  | Sim |  | C¢digo do PulmÆo Processo |
| cod-refer | character | Referncia | x(8) |  | Não |  |  |
| cod-servico | integer | Servio | >>>>9 | 0 | Sim |  | C¢digo de servio definido pela legislaÆo municipal |
| cod-tab-preco-aps | character | Tab Preos APS | x(8) |  | Não |  | C¢digo da tabela de preos para o APS |
| cod-tax | integer | C¢digo Imposto | >>>9 | 0 | Não |  |  |
| cod-tax-serv | integer | C¢digo Imposto Servio | >>>9 | 0 | Não |  |  |
| cod-trib-ii | integer | TributaÆo II | >9 | 1 | Não | [ininc/i10in172.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i10in172.i) | Informar a TributaÆo do Imposto de ImportaÆo |
| cod-unid-negoc | character | Unidade Neg¢cio | X(3) |  | Não |  | C¢digo da Unidade de Neg¢cio |
| cod-workflow | character | C¢digo Workflow | x(100) |  | Não |  | C¢digo Workflow |
| codigo-orig | integer | Origem | >9 | 1 | Sim | [ininc/i18in122.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i18in122.i) |  |
| codigo-refer | character | C¢digo Complementar | x(20) |  | Sim |  | Outra codificaÆo para identificaÆo do item |
| compr-fabric | integer | Forma ObtenÆo | >9 | 1 | Sim | [ininc/i01in172.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i01in172.i) |  |
| comprim | decimal | Comprimento | >>>,>>9.99999999 | 0 | Sim |  | Comprimento da pea/item em cent¡metros |
| concentracao | decimal | ConcentraÆo | >>>9,9999 | 0 | Sim |  |  |
| cons-consumo | logical | Considera Consumo | Sim/NÆo | no | Não |  | Considera Consumo de PrevisÆo |
| cons-produto | logical | Considera Item Como | Sim/NÆo | no | Não |  | Considera Item Como Produto |
| cons-saldo | logical | Considera Saldo Estoque | Sim/NÆo | yes | Não |  | Considera Saldo Estoque |
| consumo-aad | decimal | Consumo At a Data | ->>>>,>>9.9999 | 0 | Sim |  |  |
| consumo-prev | decimal | Consumo Previsto | >>>>,>>9.9999 | 0 | Sim |  |  |
| conta-aplicacao | character | Conta AplicaÆo | x(17) |  | Não |  |  |
| contr-plan | integer | Controle Planejamento | >9 | 1 | Sim | [ininc/i15in172.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i15in172.i) | Indica onde ser  calculada a Necessidade do Item |
| contr-qualid | logical | Controle Qualidade | Sim/NÆo | no | Sim |  | Indica se item sofre CQ |
| conv-tempo-seg | logical | Converte Tempo Seg | Sim/NÆo | no | Não |  | Converte Tempo de Segurana em Quantidade ? |
| criticidade | integer | Criticidade | >9 | 1 | Sim | [ininc/i23in172.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i23in172.i) |  |
| ct-codigo | character | Conta AplicaÆo | x(20) |  | Sim |  | Conta de aplicaÆo padrÆo do item |
| curva-abc | logical | EmissÆo Curva ABC | Sim/NÆo | no | Sim |  |  |
| data-1 | date |  | 99/99/9999 |  | Não |  |  |
| data-2 | date |  | 99/99/9999 |  | Não |  |  |
| data-base | date | Data Base | 99/99/9999 |  | Não |  |  |
| data-implant | date | Data ImplantaÆo | 99/99/9999 | today | Sim |  |  |
| data-liberac | date | Data LiberaÆo | 99/99/9999 | today | Sim |  | Data de liberaÆo do item para utilizaÆo |
| data-obsol | date | Data Obsolescncia | 99/99/9999 |  | Não |  | Data em que o item se tornou obsoleto |
| data-ult-con | date | Data éltima Contagem | 99/99/9999 | 01/01/1800 | Não |  |  |
| data-ult-ent | date | Data éltima Entrada | 99/99/9999 |  | Não |  |  |
| data-ult-rep | date | Data éltima ReposiÆo | 99/99/9999 |  | Não |  |  |
| data-ult-sai | date | Data éltima Sa¡da | 99/99/9999 |  | Não |  |  |
| de-codigo-prin | character | Desenho Principal | x(16) |  | Sim |  | C¢digo do desenho principal |
| dec-1 | decimal |  | ->>>>>>>>>>>9.99999999 | 0 | Não |  |  |
| dec-2 | decimal |  | ->>>>>>>>>>>9.99999999 | 0 | Não |  |  |
| dec-conv-fmcoml | integer | Dec FT Conv Fm Com | 9 | 0 | Sim |  | N£mero de decimais do fator de conversÆo da fam¡lia comercial |
| dec-ftcon | integer | Decimais | 9 | 0 | Sim |  | N£mero de decimais do fator de conversÆo da fam¡lia industrial |
| demanda | integer | Tipo Demanda | >9 | 1 | Sim | [ininc/i02in122.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i02in122.i) |  |
| deposito-pad | character | Dep¢sito PadrÆo | x(03) |  | Sim |  |  |
| desc-inter | character | DescriÆo Internacional | x(36) |  | Não |  |  |
| desc-item | character | DescriÆo | x(60) |  | Não |  |  |
| desc-nacional | character | DescriÆo Nacional | x(36) |  | Não |  |  |
| descricao-1 | character | DescriÆo | x(18) |  | Sim |  |  |
| descricao-2 | character | DescriÆo-2 | x(18) |  | Sim |  |  |
| dias-estoq-aloc | character | Nr Dias Estoque | X(8) |  | Não |  | At quantos dias ser  permitida a alocaÆo do item no estoque. |
| div-ordem | integer | DivisÆo Ordens | >9 | 1 | Sim | [ininc/i12in122.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i12in122.i) | Forma de divisÆo das ordens planejadas ao confirm -las |
| dsl-destaq | character | DescriÆo Destaque | x(2000) |  | Sim |  | DescriÆo Destaque |
| dt-pr-fisc | date | Data Preo Fiscal | 99/99/9999 |  | Não |  |  |
| dt-ult-ben | date | Data éltimo Beneficiamento | 99/99/9999 |  | Não |  |  |
| emissao-ord | integer | EmissÆo Ordens | >9 | 1 | Sim | [ininc/i03in122.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i03in122.i) | Tipo de EmissÆo de Ordens |
| enquad-beb | integer | Enquadramento Bebida | >9 | 0 | Não |  | Enquadramento da bebida |
| esp-beb | integer | Espcie Bebida | 99 | 0 | Não |  | Espcie de Bebida |
| fase-medio | integer | Fase C lculo Mdio | >9 | 1 | Não | [ininc/i09in287.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i09in287.i) | Fase de c lculo do preo mdio |
| fator-conver | decimal | Fator ConversÆo | >,>>9.99999 | 1 | Sim |  | Fator de conversÆo |
| fator-reaj-icms | decimal | Fator Reajuste ICMS | >>>>>>,>>>,>>9.99999999 | 0 | Não |  | Fator de Reajuste de ICMS |
| fator-refugo | decimal | Fator Refugo | >9.99 | 0 | Sim |  | Percentual de refugo observado para o item |
| fm-cod-com | character | Fam¡lia Comercial | x(8) |  | Não |  | Fam¡lia comercial a qual pertence o item |
| fm-codigo | character | Fam¡lia | x(8) |  | Sim |  | Fam¡lia de material a que pertence o item |
| fraciona | logical | Quantidade Fracionada | Sim/NÆo | yes | Sim |  | Indica se o item permite ou nÆo quantidade fracionada |
| ft-conv-fmcoml | decimal | Ft Conv Fam¡lia Coml | >>>>>>>>>9 | 0 | Sim |  | Fator de conversÆo para a Unidade PadrÆo da Fam¡lia Comercial |
| ft-conversao | decimal | Ft Conv Fam¡lia Ind | >>>>>>>>>9 | 0 | Sim |  | Fator de conversÆo para unidade de medida padrÆo da fam¡lia |
| ge-codigo | integer | Grupo Estoque | >9 | 0 | Sim |  | Grupo de estoque a que pertence o item |
| geracao-ordem | integer | GeraÆo Ordem | 9 | 0 | Não | [ininc/i01in521.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i01in521.i) | GeraÆo da ordem na Semana |
| horiz-fixo | integer | Horizonte Fixo | >>9 | 0 | Sim |  | Horizonte Fixo de Planejamento |
| id-grade | logical | Item Grade | Sim/NÆo | no | Não |  | Informe se o item possui grade |
| idi-classif-item | integer | ClassificaÆo Item | >9 | 1 | Não |  | Classifica o item em genrico, produto ou insumo |
| incentivado | logical | Incentivado PE | Sim/NÆo | no | Não |  | Incentivado pelo estado de Pernambuco? |
| ind-backorder | logical | Backorder | Sim/NÆo | no | Não |  | Indica se o item gera backorder ou nÆo |
| ind-calc-meta | integer | Critrio C lculo Meta ProduÆo | >9 | 1 | Sim |  | Indica o mtodo para c lculo de metas de produÆo entre estabel |
| ind-confprodcom | logical | Confirma ComposiÆo? | Sim/NÆo | no | Não |  | Confirma composiÆo do produto? |
| ind-especifico | logical | Espec¡fico | Sim/NÆo | no | Não |  | Indica se o item  produzido especificamente para um cliente |
| ind-imp-desc | integer | Forma DescriÆo Item | >9 | 1 | Sim | [ininc/i10in122.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i10in122.i) | Forma de descriÆo do item |
| ind-inf-qtf | logical | Fatura Qtd Fam¡lia | Sim/NÆo | no | Não |  | Item ser  faturado na unidade da fam¡lia |
| ind-ipi-dife | logical | Possui IPI Diferenciado | Sim/NÆo | no | Sim |  | Indica se o item pode ter mais de uma al¡quota de IPI |
| ind-item-fat | logical | Item Fatur vel | Sim/NÆo | yes | Sim |  | Indica se o item pode ser faturado |
| ind-prev-demanda | integer | PrevisÆo Demanda | >9 | 1 | Sim |  | Indica a forma de utilizaÆo da previsÆo de demanda no MPS |
| ind-quotas | logical | Considera P/ Quotas | Sim/NÆo | no | Não |  | Considera p/ quotas |
| ind-refugo | integer | Tratamento Refugo | >9 | 1 | Sim | [ininc/i01in180.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i01in180.i) | Forma de tratamento do refugo |
| ind-serv-mat | integer | AplicaÆo | >9 | 2 | Não | [ininc/i08in172.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i08in172.i) | Informe se o item de dbito direto  de servio ou material |
| inform-compl | character | Inf Complementar | x(16) |  | Sim |  |  |
| int-1 | integer |  | ->>>>>>>>>9 | 0 | Não |  |  |
| int-2 | integer |  | ->>>>>>>>>9 | 0 | Não |  |  |
| isencao-import | integer | Isenta Imposto ImportaÆo | >9 | 1 | Não | [ininc/i14in172.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i14in172.i) |  |
| it-codigo | character | Item | x(16) |  | Sim |  | C¢digo do Item |
| it-demanda | character | Item Para C lculo Demanda | x(16) |  | Não |  |  |
| largura | decimal | Largura | >>>,>>9.99999999 | 0 | Sim |  | Largura da pea/item em cent¡metros |
| loc-unica | logical | LocalizaÆo énica | Sim/NÆo | yes | Sim |  | Indica se  LocalizaÆo F¡sica  £nica |
| log-1 | logical |  | Sim/NÆo | no | Não |  |  |
| log-2 | logical |  | Sim/NÆo | no | Não |  |  |
| log-altera-valid-lote | logical | Altera Valid Lote CQ | Sim/NÆo | no | Não |  | Altera Data de Validade Lote no CQ |
| log-atualiz-via-mmp | logical | Atualizado Via Multiplanta | Sim/NÆo | no | Não |  |  |
| log-benef | logical | Item Beneficiamento | Sim/NÆo | no | Não |  | log beneficiamento |
| log-carac-tec | logical | Caracter¡sticas Atualizadas | Sim/NÆo | yes | Sim |  |  |
| log-consid-aloc-ativid | logical | Considera AlocaÆo Atividade | Sim/NÆo | yes | Sim |  | Considera AlocaÆo Atividade |
| log-control-estoq-refugo | logical | Contr Est Refugo | Sim/NÆo | no | Não |  | Controlar estoque dos refugos? |
| log-inspec-lote | logical | InspeÆo Por N£mero do Lote | Sim/NÆo | no | Não |  | InspeÆo por N£mero do Lote |
| log-multi-malha | logical | Multi Malha | Sim/NÆo | no | Não |  | Indica se o item  utilizado em mais de uma malha |
| log-necessita-li | logical | Necessita LI | Sim/NÆo | yes | Não |  | Necessita Licena de ImportaÆo? |
| log-orig-ext | logical | Origem Externo | Sim/NÆo | no | Não |  | L¢gico Origem Externo |
| log-programac-sfc | logical | Programa Aloc. Ativ. | Sim/NÆo | yes | Não |  | Programa AlocaÆo de Atividades |
| log-recalc-sdo-terc | logical | Recalcula Saldo Terceiro | Sim/NÆo | no | Não |  | Efetua recomposiao do saldo em poder de terceiros |
| log-refugo-preco-fisc | logical | Refugo Preo Fiscal | Sim/NÆo | no | Não |  | Sim: Refugo a preo fiscal. NÆo: Refugo ao custo de produÆo |
| log-tax-produc | logical | Considera Taxa de ProduÆo | Sim/NÆo | no | Sim |  | Considera taxa de produÆo para o item? |
| log-utiliza-batch-padrao | logical | Utiliza Batch PadrÆo | Sim/NÆo | no | Sim |  | Utiliza sempre batch padrÆo para definiäes de engenharia |
| lote-economi | decimal | Lote Econmico | >>>>,>>9.9999 | 1 | Sim |  |  |
| lote-minimo | decimal | Lote M¡nimo | >>>>,>>9.9999 | 1 | Sim |  | Lote m¡nimo para compra |
| lote-multipl | decimal | Lote M£ltiplo | >>>>,>>9.9999 | 1 | Sim |  |  |
| lote-mulven | decimal | Lote M£ltiplo Venda | >>>>,>>9.9999 | 1 | Sim |  | Lote m£ltiplo de venda do item |
| lote-repos | decimal | Lote ReposiÆo | >>,>>>,>>9.99 | 0 | Não |  | Lote ReposiÆo |
| moeda-padrao | integer | Moeda PadrÆo VariaÆo | >9 | 0 | Sim |  |  |
| mp-restrit | logical | Matria Prima Restritiva | Sim/NÆo | no | Não |  | Matria Prima Restritiva |
| narrativa | character | Narrativa | x(2000) |  | Não |  |  |
| nat-despesa | integer | Natureza  Despesa | >>>9 | 0 | Não |  | C¢digo da Natureza de Despesa |
| niv-mais-bai | integer | N¡vel Mais Baixo | >9 | 0 | Sim |  |  |
| niv-mps | integer | N¡vel Mais Baixo | >9 | 0 | Não |  | N¡vel mais baixo para o MPS |
| niv-rest-fora | character | N¡vel RestituiÆo Fora UF | x(1) |  | Não |  | N¡vel de RestituiÆo do Item fora do Estado |
| niv-rest-icms | character | N¡vel Rest ICMS | x(1) |  | Não |  | Qual o n¡vel de restituiÆo de ICMS |
| nivel | integer | N¡vel | 9 | 0 | Sim |  | N¡vel de InspeÆo a ser utilizado |
| nivel-apr-compra | integer | N¡vel Aprov Compra | >>9 | 0 | Não |  | C¢digo n¡vel aprovaÆo eletrnica Ordens/Pedidos |
| nivel-apr-manut | integer | N¡vel Aprov ManutenÆo | >>9 | 0 | Não |  | C¢digo n¡vel aprovaÆo eletrnica manutenÆo |
| nivel-apr-requis | integer | N¡vel Aprov RequisiÆo | >>9 | 0 | Não |  | C¢digo n¡vel aprovaÆo eletrnica para requisiäes |
| nivel-apr-solic | integer | N¡vel Aprov SolicitaÆo | >>9 | 0 | Não |  | C¢digo n¡vel aprovaÆo eletrnica para solicitaäes |
| nr-item-dcr | integer | N£mero Item DCR | >>>>>9 | 0 | Não |  | N£mero do Item no DCR para  Zona Franca |
| nr-linha | integer | Linha ProduÆo | >>9 | 0 | Sim |  |  |
| nr-pontos-quotas | integer | Nr Pontos Quotas | ->,>>>,>>9 | 0 | Não |  | N£mero de pontos p/ quotas |
| nr-ult-peca | integer | Ult Pea | 99999 | 0 | Não |  | éltimo n£mero de Pea Gerado |
| num-id-item | integer | ID Item | >,>>>,>>9 | 0 | Sim |  |  |
| path | character | Caminho CAD | x(40) |  | Não |  |  |
| per-min-luc | decimal | % Min Lucro | >>9.99 | 0 | Não |  | Percentual m¡nimo de lucro em relaÆo ao custo mdio do item |
| per-ppm | decimal |  | >>>>,>>9.9999 | 0 | Não |  |  |
| per-rest-fora | decimal | % Rest Fora | >>9.99 | 0 | Não |  | Percentual de RestituiÆo do Item fora do Estado |
| per-rest-icms | decimal | % Rest ICMS | >>9.99 | 0 | Sim |  | Percentual de restituiÆo de ICMS |
| perc-demanda | decimal | % Demanda | >>9.99 | 100 | Não |  |  |
| perc-nqa | decimal | NQA | >>>9.999 | 0 | Não |  | N¡vel de Qualidade Aceit vel |
| periodo-fixo | integer | Per¡odo Fixo | >>9 | 1 | Sim |  |  |
| perm-saldo-neg | integer | Saldo Neg | >9 | 1 | Sim | [ininc/i11in122.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i11in122.i) | Permite parametrizar o Tipo de Saldo |
| peso-bruto | decimal | Peso Bruto | >>>,>>9.99999 | 0 | Sim |  | Peso Bruto Unit rio do Item |
| peso-liquido | decimal | Peso Liq | >>>,>>9.99999 | 0 | Sim |  | Peso l¡quido do item |
| pm-ja-calc | logical | Preo Mdio Calculado | Sim/NÆo | no | Sim |  | Indica se o Preo mdio j  foi calculado no per¡odo |
| politica | integer | Pol¡tica | >9 | 1 | Sim | [ininc/i04in122.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i04in122.i) | Pol¡tica do item |
| politica-aps | integer | Pol¡tica - APS | >9 | 0 | Não | [ininc/i21in122.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i21in122.i) | Pol¡tica - APS |
| pr-sem-tx | decimal | Preo Repos Sem Taxa | >>>>,>>>,>>9.9999 | 0 | Sim |  | Preo de reposiÆo sem taxa financeira |
| preco-base | decimal | Preo Base | >>>>>,>>>,>>9.9999 | 0 | Sim |  |  |
| preco-fiscal | decimal | Preo Fiscal | >>>>,>>>,>>9.9999 | 0 | Sim |  |  |
| preco-repos | decimal | Preo ReposiÆo | >>>>>,>>>,>>9.9999 | 0 | Sim |  |  |
| preco-ul-ent | decimal | Preo Ult Entr | >>>>>,>>>,>>9.9999 | 0 | Sim |  |  |
| prefixo-lote | character | Prefixo Lote | x(5) |  | Não |  | Prefixo do lote para controle de itens por pea |
| prioridade | integer | Prioridade | 999 | 0 | Sim |  | Zero  a maior prioridade |
| pto-repos | decimal | Ponto ReposiÆo | >>>>,>>9.9999 | 0 | Não |  | Quantidade para atender Ponto de ReposiÆo |
| qt-max-ordem | decimal | Qtde Max Ord | >>>>,>>9.9999 |  | Não |  |  |
| qt-var-max | decimal | Qtd Max VariaÆo | ->>>,>>>,>>9.99 | 0 | Não |  | Quantidade m xima de variaÆo |
| qt-var-min | decimal | Qtd Min VariaÆo | ->>>,>>>,>>9.99 | 0 | Não |  |  |
| qtd-batch-padrao | decimal | Tamanho Lote PadrÆo | ->>>>,>>9.9999 | 1 | Sim |  | Tamanho do lote padrÆo para engenharia |
| qtd-refer-custo-dis | decimal | Quantidade Referncia | >>>,>>9.99 | 1 | Não |  | Quantidade referncia para fator custo distribuiÆo |
| qtde-fixa | decimal | Quantidade Fixa | >>>>,>>9.9999 | 0 | Não |  | Quantidade Fixa |
| qtde-max | decimal | Quantidade M xima | >>>>,>>9.9999 | 0 | Não |  | Quantidade M xima |
| quant-pacote | decimal | Qtde Pacote | >>>>,>>9.9999 | 0 | Não |  | Quantidade do pacote |
| quant-perda | decimal | Qtde Perda | >>>>,>>9.9999 | 0 | Sim |  |  |
| quant-segur | decimal | Qtde Segur | >>>>,>>9.9999 | 0 | Sim |  |  |
| rendimento | decimal | Rendimento | >>>9,9999 | 0 | Sim |  |  |
| rep-prod | integer | Reporta Prod | >9 | 1 | Sim | [ininc/i12in172.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i12in172.i) | Tipo de Reporte de ProduÆo utilizado para o Item |
| reporte-ggf | integer | Reporta GGF | >9 | 1 | Sim | [ininc/i06in172.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i06in172.i) |  |
| reporte-mob | integer | Reporta MOB | >9 | 1 | Sim | [ininc/i06in172.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i06in172.i) | Tipo do Reporte de mÆo-de-obra |
| res-cq-comp | integer | Ressupr CQ | >>>9 | 0 | Sim |  |  |
| res-cq-fabri | integer | Ressupr CQ Fabric | >>>9 | 0 | Sim |  |  |
| res-for-comp | integer | Ressupr Fornec | >>>9 | 0 | Sim |  |  |
| res-int-comp | integer | Ressupr Compras | >>>9 | 0 | Sim |  |  |
| responsavel | character | Respons vel | x(12) |  | Sim |  | Respons vel pelo item na Engenharia |
| ressup-fabri | integer | Ressupr Fabric | >>>9 | 0 | Sim |  |  |
| resumo-mp | integer | Resumo Multi-Planta | >9 | 1 | Sim | [ininc/i07in172.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i07in172.i) | SituaÆo do resumo do Item |
| rot-quant | logical | Roteiros Qtde | Sim/NÆo | no | Não |  |  |
| rot-refer | logical | Roteiros Referncia | Sim/NÆo | no | Não |  |  |
| rot-revis | logical | Roteiros RevisÆo | Sim/NÆo | no | Não |  |  |
| sc-codigo | character | C.Custo AplicaÆo | x(20) |  | Sim |  | Centro Custo de AplicaÆo padrÆo do item |
| sit-aloc | integer | Tipo Aloc | >9 | 1 | Não | [ininc/i18in172.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i18in172.i) |  |
| tempo-segur | integer | Tempo Segur | >>9 | 7 | Sim |  |  |
| tipo-atp | integer | Tipo ATP | >9 | 1 | Não | [ininc/i19in172.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i19in172.i) | Tipo de ATP |
| tipo-con-est | integer | Tipo Controle Estq | >9 | 1 | Sim | [ininc/i01in122.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i01in122.i) | Tipo de Controle de Estoque do Item |
| tipo-contr | integer | Tipo Controle | >9 | 2 | Sim | [ininc/i09in122.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i09in122.i) | Tipo de controle do item |
| tipo-desc-nt | integer | Tipo Descr Nota | >9 | 1 | Sim | [ininc/i05in172.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i05in172.i) | Tipo de DescriÆo na Nota |
| tipo-est-seg | integer | Tipo Estq Segur | >9 | 1 | Não | [ininc/i05in122.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i05in122.i) | Tipo de Controle de Estoque de Segurana |
| tipo-formula | integer | Componente Para Form | >9 | 1 | Sim | [ininc/i25in172.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i25in172.i) | Componente para formulaÆo |
| tipo-insp | integer | Tipo Inspec | >9 | 1 | Sim | [ininc/i17in122.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i17in122.i) | Tipo de InspeÆo do Item |
| tipo-lote-ec | integer | Tipo Lote | >9 | 1 | Sim | [ininc/i04in172.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i04in172.i) | Tipo de Lote Econmico |
| tipo-recip-beb | integer | Tipo Recipiente | 99 | 1 | Não | [ininc/i21in172.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i21in172.i) | Tipo do Recipiente da Bebida |
| tipo-requis | integer | Tipo RequisiÆo | >9 | 1 | Sim | [ininc/i08in122.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i08in122.i) | Tipo de RequisiÆo do Item |
| tipo-sched | integer | ProgramaÆo | >9 | 1 | Sim | [ininc/i16in122.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i16in122.i) | Tipo de programaÆo do item |
| tp-adm-lote | integer | Pol¡tica Adm Lote | >9 | 1 | Não | [ininc/i15in122.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i15in122.i) | Tipo de pol¡tica de administraÆo de lote |
| tp-aloc-lote | integer | Tipo Aloc Lote | >9 | 1 | Não | [ininc/i13in172.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i13in172.i) | Tipo de AlocaÆo do Lote |
| tp-cons-prev | decimal | Tipo Consumo Prev | 9 | 0 | Não |  | Tipo de Consumo para a PrevisÆo de Vendas |
| tp-desp-padrao | integer | Tipo Despesa | >>9 | 0 | Não |  |  |
| tp-lote-econom | logical | Tipo Lote Econmico | Ponto da grade/Referncia | yes | Não |  | Tipo de lote econmico: Ponto da grade/Referncia. |
| tp-lote-minimo | logical | Tipo Lote Min | Ponto da grade/Grade padrÆo | yes | Não |  | Tipo de lote m¡nimo: Ponto da grade / Grade PadrÆo |
| tp-lote-multiplo | logical | Tipo Lote M£ltiplo | Ponto da grade/Grade padrÆo | yes | Não |  | Lote m£ltiplo: Ponto da grade / Grade padrÆo |
| tx-importacao | decimal | Taxa Import | >>9.999 | 0 | Não |  | Taxa de ImportaÆo p/ Zona Franca |
| un | character | Unid Medid | xx |  | Sim |  | Unidade de medida do item |
| usuario-alt | character | Usuar Ult Alt | x(12) |  | Não |  | Usu rio que fez a ultima alteraÆo do item |
| usuario-obsol | character | Usuar Que Tornou Obs | x(12) |  | Não |  | Nome do usu rio que tornou o item obsoleto |
| val-fator-custo-dis | decimal | Fator Custo DistribuiÆo | >>>,>>9.99 | 0 | Sim |  | Fator de custo para avaliar facilidade de distribuiÆo |
| val-overlap | decimal | Overlap | >>9.99 | 0 | Não |  | Tempo de Overlap entre a Tarefa e sua Predecessora |
| val-relac-refugo-item | decimal | RelaÆo Refugo Item | >,>>9.99999 | 0 | Não |  | RelaÆo entre refugo e o item-pai (fator de conversÆo) |
| valor-ipi-beb | decimal | Valor IPI Bebida | >>>,>>>,>>9.99999 | 0 | Não |  | Valor de IPI para Bebidas (DIPI) |
| var-mob-maior | decimal | Var MOB (Maior) | >>9.99 | 0 | Não |  | VariaÆo da mÆo-de-obra (a maior) |
| var-mob-menor | decimal | Var MOB (Menor) | >>9.99 | 0 | Não |  | VariaÆo da mÆo-de-obra (a menor) |
| var-rep | decimal | Variac Qtde Report | >>9.99 | 0 | Sim |  |  |
| var-req-maior | decimal | Var Qtde Req (Maior) | >>9.99 | 0 | Não |  | VariaÆo da Quantidade Requisitada (a maior) |
| var-req-menor | decimal | Var Qtde Req (Menor) | >>9.99 | 0 | Não |  | VariaÆo da Quantidade Requisitada (a menor) |
| var-transf | decimal | Variac Qtde Transferida | >>9.99 | 0 | Sim |  |  |
| variac-acum | decimal | Variac Acumul | ->>>>,>>9.9999 | 0 | Sim |  |  |
| vl-mat-ant | decimal | Valor Mat Anterior | >>>>,>>>,>>9.9999 | 0 | Sim |  | Valor unit rio de material do per¡odo anterior |
| vl-mob-ant | decimal | Valor MOB Anterior | >>>>,>>>,>>9.9999 | 0 | Sim |  | Valor unit rio da mÆo-de-obra do per¡odo anterior |
| vl-var-max | decimal | Valor Max VariaÆo | ->>>,>>>,>>9.99 | 0 | Não |  | Valor m ximo de VariaÆo |
| vl-var-min | decimal | Valor Min VariaÆo | ->>>,>>>,>>9.99 | 0 | Não |  | Valor m¡nimo de variaÆo |
| volume | decimal | Volume | >>>,>>>,>>9.99999 | 0 | Sim |  | Volume do item |

## Triggers

| Evento | Procedure | Link |
| :--- | :--- | :--- |
| Create | database/tgin/tcp/tcin172.p | [Abrir Fonte](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/database/tgin/tcp/tcin172.p) |
| Delete | database/tgin/tdp/tdin172.p | [Abrir Fonte](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/database/tgin/tdp/tdin172.p) |
| Write | database/tgin/twp/twin172.p | [Abrir Fonte](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/database/tgin/twp/twin172.p) |

## Índices

- **codigo** (Primário, Único): it-codigo
- **ch-auxiliar**: cod-auxiliar
- **ch-codser**: cod-servico
- **ch-fm-coml**: fm-cod-com, it-codigo
- **ch-localiz**: cod-estabel, deposito-pad, cod-localiz
- **ch-malha**: cod-malha
- **class-fiscal**: class-fiscal, it-codigo
- **cod-obsoleto**: cod-obsoleto
- **complementar**: codigo-refer
- **compr-fabric**: compr-fabric
- **comprador**: cod-comprado, it-codigo
- **demanda**: demanda
- **descricao**: desc-item
- **fam-ge**: fm-codigo, ge-codigo, compr-fabric, contr-plan, demanda
- **familia**: fm-codigo, it-codigo
- **folh-item**: cd-folh-item
- **grupo**: ge-codigo, it-codigo
- **item-refugo**: cod-item-refugo
- **item-workflow**: cod-workflow
- **linha**: nr-linha, it-codigo
- **natur-item**: nat-despesa, it-codigo
- **nmb**: niv-mais-bai
- **planejador**: cd-planejado, it-codigo, tipo-contr, tipo-requis
- **politica**: politica, it-codigo
- **token**: num-id-item
- **un**: un, it-codigo
- **unid-neg**: cod-unid-negoc
