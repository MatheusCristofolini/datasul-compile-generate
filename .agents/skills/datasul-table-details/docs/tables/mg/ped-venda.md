# Tabela: ped-venda

**Banco de Dados**: mg
**Label**: Pedido de Venda
**Descrição**: Pedidos de Venda
**Gerado em**: 24/09/2026, 17:35:17

## Campos

| Campo | Tipo | Label | Formato | Inicial | Obrig. | Include | Help |
| :--- | :--- | :--- | :--- | :--- | :--- | :--- | :--- |
| aprov-forcado | character | Aprovador Forado | x(12) |  | Não |  | Nome do aprovador de crditos forados |
| atendido | logical | Atendido Total | Sim/NÆo | no | Não |  | Todos os itens do pedido foram solicitados |
| bairro | character | Bairro | x(30) |  | Não |  | Bairro |
| caixa-postal | character | Caixa Postal | x(10) |  | Não |  | Caixa Postal |
| cd-cancela | integer | Cod Motivo | >>9 | 0 | Não |  | Motivo |
| cd-jurisdicao-ent | character | C¢digo JurisdiÆo | X(20) |  | Não |  | C¢digo de jurisdicao do endereo de entrega |
| cd-origem | integer | Origem | 99 | 1 | Sim | [diinc/i02di152.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i02di152.i) | Origem |
| cdn-motiv-reprovac-cr | integer | Motivo ReprovaÆo | >>9 | 0 | Não |  | C¢digo do Motivo de ReprovaÆo de Crdito |
| cep | character | CEP | x(12) |  | Não |  | CEP |
| cgc | character | CGCMF | x(19) |  | Não |  | CGCMF |
| char-1 | character |  | x(100) |  | Não |  |  |
| char-2 | character |  | x(100) |  | Não |  |  |
| check-sum | character | Check-sum | x(20) |  | Não |  |  |
| cidade | character | Cidade | x(50) |  | Não |  | Cidade para a Entrega do Pedido |
| cidade-cif | character | Cidade CIF | x(50) |  | Não |  | At que cidade o frete corre por conta do emitente |
| cod-canal-venda | integer | Canal Venda | >>9 | 0 | Não |  | C¢digo do canal de venda |
| cod-cond-pag | integer | Cond Pagto | >>>9 | 0 | Não |  | C¢digo da condiÆo de pagamento |
| cod-des-merc | integer | Destino Mercadoria | 99 | 1 | Não | [diinc/i02di159.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i02di159.i) | Destino da mercadoria |
| cod-emitente | integer | Cliente | >>>>>>>>9 | 0 | Sim |  | C¢digo do cliente |
| cod-entrega | character | Entrega | x(12) |  | Sim |  | C¢digo do endereo de entrega |
| cod-entrega-tri | character | Cod Entrega Remessa Triang | X(12) |  | Não |  | C¢digo de entrega da nota de remessa da oper triangular |
| cod-estabel | character | Estabelecimento | x(5) |  | Sim |  | C¢digo do estabelecimento |
| cod-gr-cli | integer | Grupo Cliente | >>>9 | 0 | Sim |  | C¢digo do grupo de cliente |
| cod-id-prosp | character | Id Prospect | x(12) |  | Sim |  | C¢digo Id Prospect |
| cod-imagem | character | Imagem | x(30) |  | Não |  | C¢digo da imagem |
| cod-mensagem | integer | Mensagem | >>>>9 | 0 | Não |  | C¢digo da mensagem que dever  sair na nota fiscal |
| cod-message-alerta | integer | Mensagem Alerta | >,>>9 | 0 | Não |  | C¢digo da mensagem de alerta |
| cod-mot-canc-cot | integer | Cod Mot Cancelamento | >>9 | 0 | Não |  | C¢digo do motivo do cancelamento da cotaÆo |
| cod-ped-clien-mp | character | Pedido Cliente Multiplanta | x(12) |  | Sim |  | Nr Pedido cliente Multplanta |
| cod-portador | integer | Portador | >>>>9 | 0 | Não |  | C¢digo do portador |
| cod-priori | integer | Prioridade | 99 | 0 | Não |  | C¢digo de Prioridade para fornecimento do pedido |
| cod-rma | character | Nr RMA | X(16) |  | Não |  | C¢digo da RMA |
| cod-rota | character | Rota | x(12) |  | Sim |  | Rota de atendimento a que este pedido pertence |
| cod-safra | character | Safra | 9999/9999 | 00000000 | Não |  | Safra |
| cod-sit-aval | integer | SituaÆo AvaliaÆo Crdito | 99 | 1 | Sim | [diinc/i03di159.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i03di159.i) | SituaÆo de avaliaÆo de crdito |
| cod-sit-com | integer | SituaÆo AvaliaÆo Comercial | 99 | 1 | Não | [diinc/i05di154.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i05di154.i) | C¢digo da situaÆo da avaliaÆo comercial |
| cod-sit-ped | integer | SituaÆo Pedido | 99 | 1 | Não | [diinc/i03di149.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i03di149.i) | SituaÆo do pedido |
| cod-sit-pre | integer | SituaÆo AlocaÆo | 99 | 1 | Não | [diinc/i04di149.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i04di149.i) | SituaÆo da alocaÆo do estoque |
| cod-sit-preco | integer | SituaÆo AvaliaÆo Preo | 99 | 1 | Sim | [diinc/i05di154.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i05di154.i) | C¢digo da situaÆo da avaliaÆo Preos |
| cod-tax | integer | Vl Imp | >>>9 | 0 | Não |  | Valor do imposto |
| cod-unid-negoc | character | Unidade Neg¢cio | X(3) |  | Não |  | C¢digo Unidade Neg¢cio |
| cod-usu-alt-sit | character | Usu rio AlteraÆo SituaÆo | x(12) |  | Não |  | Usu rio de alteraÆo da situaÆo |
| cod-usu-lib-desconto | character | Usu rio LiberaÆo Desconto | x(12) |  | Não |  | Usu rio de liberaÆo de desconto do pedido |
| cod-workflow | character | C¢digo Workflow | x(100) |  | Sim |  | C¢digo Workflow |
| completo | logical | Completo | Sim/NÆo | no | Não |  | O pedido est  completo? |
| cond-espec | character | Condiäes Especiais | x(2000) |  | Sim |  | Anotaäes importantes |
| cond-redespa | character | Condiäes Redespacho | x(2000) |  | Sim |  | Coment rios importantes |
| cons-mrp | logical | Considera MRP | Sim/NÆo | yes | Não |  | Considera pedido no MRP? |
| cons-pmp | logical | Considera  PV | Sim/NÆo | yes | Não |  | Considera pedido na previsÆo de vendas? |
| contato | character | Contato | x(25) |  | Sim |  | Contato no cliente |
| dat-alter-sit | date | AlteraÆo SituaÆo | 99/99/9999 | today | Não |  | Data da alteraÆo da situaÆo |
| dat-aprov-preco | date | Aprov Preos | 99/99/9999 | today | Não |  | Data de aprovaÆo dos Preos |
| dat-base-preco | date | Dt Base Preco | 99/99/9999 | today | Não |  | Data Base Preco |
| dat-sit-desconto | date | Dt Sit Desconto | 99/99/9999 |  | Não |  | Data da situaÆo do desconto do pedido |
| data-1 | date |  | 99/99/9999 |  | Não |  |  |
| data-2 | date |  | 99/99/9999 |  | Não |  |  |
| dec-1 | decimal |  | ->>>>>>>>>>>9.99999999 | 0 | Não |  |  |
| dec-2 | decimal |  | ->>>>>>>>>>>9.99999999 | 0 | Não |  |  |
| des-pct-desconto-inform | character | Perc Desc Informado | x(50) |  | Não |  | Percentuais de desconto informados por pedido |
| desc-bloq-cr | character | Motivo Bloqueio Crdito | x(500) |  | Sim |  | Motivo da nÆo liberaÆo de crdito para o pedido |
| desc-cancela | character | Motivo Cancelamento | x(2000) |  | Sim |  | DescriÆo do motivo do cancelamento |
| desc-forc-cr | character | Motivo LiberaÆo Crdito Fora | x(76) |  | Sim |  | Motivo da liberaÆo de crdito forado para o pedido |
| desc-lib-desconto | character | Motivo LiberaÆo Desconto | x(76) |  | Sim |  | Motivo da liberaÆo forada do desconto para o pedido |
| desc-lib-preco | character | Motivo LiberaÆo Preos | x(76) |  | Sim |  | Motivo da liberaÆo forada dos preos para o pedido |
| desc-reativa | character | Motivo ReativaÆo | x(2000) |  | Não |  | Informe o motivo da reativaÆo do pedido. |
| desc-suspend | character | Motivo SuspensÆo | x(2000) |  | Sim |  | Motivo da suspensÆo do pedido |
| desc-txt | character | Desconto | x(50) |  | Não |  | DescriÆo dos descontos a n¡vel de pedido |
| desc-valor-ped | decimal | Desconto por Valor | >>,>>>,>>9.99999 | 0 | Não |  | Desconto por valor concedido a n¡vel de nota |
| distancia | decimal | Distncia | >>>,>>9.9 | 0 | Sim |  | Distncia em km |
| dsp-pre-fat | logical | Pr-Faturamento | Sim/NÆo | yes | Sim |  | Pedido est  dispon¡vel para o pr-faturamento? |
| dt-apr-cred | date | Dt Aprov Crdito | 99/99/9999 |  | Não |  | Data de aprovaÆo de crdito |
| dt-aprov-cot | date | Data Aprov CotaÆo | 99/99/9999 |  | Não |  | Data da aprovaÆo da cotaÆo |
| dt-base-ft | date | Dt Base Faturamento | 99/99/9999 |  | Não |  | Data base para faturamento |
| dt-cancela | date | Dt Cancelamento | 99/99/9999 |  | Não |  | Data do Cancelamento do Pedido |
| dt-devolucao | date | Dt DevoluÆo | 99/99/9999 |  | Não |  | Data de devoluÆo do pedido |
| dt-emissao | date | Dt EmissÆo | 99/99/9999 | today | Sim |  | Data em que o pedido foi emitido pelo representante/cliente |
| dt-entorig | date | Dt Entrega Orig | 99/99/9999 | today | Não |  | Data de entrega solicitada pelo cliente |
| dt-entrega | date | Dt Entrega | 99/99/9999 | today | Sim |  | Data prevista para entrega do Pedido |
| dt-entrega-prim | date | Primeira Data Entrega | 99/99/9999 | today | Não |  |  |
| dt-fimvig | date | Dt Trmino Vigncia | 99/99/9999 |  | Não |  | Data final de vigncia do contrato de fornecimento |
| dt-implant | date | Dt ImplantaÆo | 99/99/9999 | today | Sim |  | Data em que o Pedido foi implantado no sistema |
| dt-inivig | date | Dt In¡cio Vigncia | 99/99/9999 |  | Não |  | Data inicial de vigncia do contrato de fornecimento |
| dt-lim-fat | date | Dt Limite Atendimento | 99/99/9999 |  | Não |  | Data Limite para atendimento do Pedido |
| dt-mensagem | date | Dt Mensagem | 99/99/9999 | today | Não |  | Data na qual foi gerada a mensagem de alerta |
| dt-minfat | date | Dt M¡nimo Atendimento | 99/99/9999 |  | Não |  | Data M¡nima para atendimento do Pedido |
| dt-prev-vend | date | Dt Prev Vendor | 99/99/9999 |  | Não |  | Data Prevista para a operaÆo vendor |
| dt-reativ | date | Dt ReativaÆo | 99/99/9999 |  | Não |  | Data de reativaÆo |
| dt-suspensao | date | Dt SuspensÆo | 99/99/9999 |  | Não |  | Data de suspensÆo |
| dt-useralt | date | Dt éltima AlteraÆo | 99/99/9999 |  | Não |  | Data em que foi efetuada a £ltima alteraÆo no Pedido |
| dt-usercan | date | Dt Cancelamento | 99/99/9999 |  | Não |  | Data em que o Pedido foi cancelado |
| dt-userimp | date | Dt ImplantaÆo | 99/99/9999 |  | Não |  | Data em que o pedido foi implantado |
| dt-userrea | date | Dt ReativaÆo | 99/99/9999 |  | Não |  | Data de reativaÆo |
| dt-usersusp | date | Dt SuspensÆo | 99/99/9999 |  | Não |  | Data de suspensÆo |
| dt-validade-cot | date | Data Validade CotaÆo | 99/99/9999 |  | Não |  | Data de validade da cotaÆo |
| e-mail | character | E-mail | x(40) |  | Não |  | Endereo eletrnico na Internet |
| endereco_text | character | Endereo Completo | X(2000) |  | Não |  |  |
| esp-ped | integer | Espcie de Pedido | 99 | 1 | Sim | [diinc/i04di154.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i04di154.i) | Espcie do pedido |
| estab-atend | character | Estabelecimento Atendimento | x(5) |  | Sim |  | Estabelecimento que atender  o pedido |
| estab-central | character | Estabelecimento Controle | x(5) |  | Sim |  | Estabelecimento que controla a central de vendas |
| estab-destino | character | Estabelecimento Destino | x(5) |  | Sim |  | Estabelecimento destino |
| estado | character | UF | x(04) |  | Não |  | Unidade da federaÆo para entrega |
| hra-atualiz | character | Hora AtualizaÆo | 99:99:99 | 00:00:00 | Não |  | Hora |
| hra-emis-ped | character | Hr EmissÆo Pedido | 99:99:99 |  | Não |  | Hora EmissÆo Pedido Venda |
| inc-desc-txt | logical | Desconto Extra | Sim/NÆo | yes | Sim |  | Desconto extra incidir  sobre o preo de venda? |
| ind-antecip | logical | AntecipaÆo | Sim/NÆo | no | Não |  | Existe valor antecipado para o pedido? |
| ind-aprov | logical | AprovaÆo | Sim/NÆo | no | Sim |  | Pedido foi aprovado? |
| ind-ender-fatur | logical | Usa Endereo no Faturamento | Yes/No | yes | Não |  | Indica se o endereo ser  usado no faturamento do pedido. |
| ind-ent-completa | logical | Entrada completa | Sim/NÆo | no | Não |  | Todos os itens do pedido foram informados? |
| ind-fat-par | logical | Faturamento Parcial | Sim/NÆo | yes | Sim |  | Aceita faturamento parcial? |
| ind-imp-ped | integer | Forma ImplantaÆo | 99 | 1 | Não | [diinc/i01di159.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i01di159.i) | Forma de implantaÆo do pedido |
| ind-lib-nota | logical | Libera NF | Sim/NÆo | no | Sim |  | Libera nota fiscal sem saldo em estoque? |
| ind-orig-entrada | integer | Origem Entrada | >9 | 1 | Não | [diinc/i07di159.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i07di159.i) | Informe a origem da entrada da cotaÆo |
| ind-sit-desconto | integer | SituaÆo AvaliaÆo Desconto | 99 | 1 | Sim | [diinc/i10di159.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i10di159.i) | SituaÆo de avaliaÆo de desconto do pedido |
| ind-tp-frete | integer | Tipo Frete | 9 | 1 | Não | [diinc/i01di315.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i01di315.i) | Tipo de frete do pedido. |
| ind-via-envio | integer | Via Envio | >9 | 1 | Não | [diinc/i07di159.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i07di159.i) | Via de envio da cotaÆo |
| ins-estadual | character | InscriÆo Estadual | x(19) |  | Não |  | InscriÆo estadual |
| int-1 | integer |  | ->>>>>>>>9 | 0 | Não |  |  |
| int-2 | integer |  | ->>>>>>>>9 | 0 | Não |  |  |
| invoice-id | character | VersÆo | x(1) |  | Não |  | Identificador da versÆo do processo de exportaÆo |
| local-entreg | character | Local Entrega | x(40) |  | Não |  | Endereo de entrega do cliente |
| log-1 | logical |  | Sim/NÆo | no | Não |  |  |
| log-2 | logical |  | Sim/NÆo | no | Não |  |  |
| log-aprov-workflow | logical | Aprovado Workflow | Sim/NÆo | no | Sim |  | Aprovado Workflow |
| log-atual-cotas | logical | Atual Cotas | Sim/NÆo | no | Não |  | Atualiza Cotas? |
| log-cot-impressa | logical | CotaÆo Impressa | Sim/NÆo | no | Não |  | Indicador se a cotaÆo j  foi impressa |
| log-cotacao | logical | CotaÆo | Sim/NÆo | no | Sim |  | Indica se  uma cotaÆo |
| log-juros-prorate | logical | Juros Pro Rata | Sim/NÆo | no | Sim |  | Juros Pro Rata |
| log-ped-bonif-pendente | logical | GeraÆo Bonif Pendente | Sim/NÆo | no | Não |  | GeraÆo do pedido de bonificaÆo est  pendente? |
| log-pedido-alterado | logical | Bonif Atualizada | Sim/NÆo | no | Não |  | Pedido de bonificaÆo foi atualizado manualmente? |
| log-pedido-mp | logical | Pedido MP | Sim/NÆo | no | Não |  | Pedido pertence  central de vendas? |
| log-usa-tabela-desconto | logical | Usa Tabela Descontos | Sim/NÆo | yes | Sim |  | Usa a tabela de descontos no tratamento deste pedido? |
| mo-codigo | integer | Moeda | >9 | 0 | Sim |  | C¢digo da moeda de referncia dos valores |
| mo-fatur | integer | Moeda Faturamento | >9 | 0 | Sim |  | C¢digo da moeda do Faturamento |
| modalidade | integer | Modalidade Cobrana | 9 | 0 | Não |  | Modalidade de cobrana referente ao portador |
| motivo-alt-sit-quota | character | Motivo Alter SituaÆo Quota | x(2000) |  | Não |  | DescriÆo do motivo da alteraÆo da situaÆo da quota |
| nat-operacao | character | Natureza OperaÆo | x(06) |  | Não |  | Natureza de operaÆo |
| no-ab-reppri | character | Representante Principal | x(12) |  | Sim |  | Nome abreviado do representante principal |
| nome-abrev | character | Cliente | x(12) |  | Sim |  | Nome abreviado do cliente |
| nome-abrev-tri | character | Cliente Remessa Triang | X(12) |  | Não |  | Nome abreviado do cliente da nota de remessa da oper triangular |
| nome-prog | character | Nome Programa | X(20) |  | Não |  | Nome do programa que gerou a mensagem de alerta |
| nome-tr-red | character | Trans Redespa | x(12) |  | Não |  | Nome da transportadora de redespacho |
| nome-transp | character | Transportador | x(12) |  | Não |  | Nome do transportador |
| nr-anexo | character | Anexo | X(12) |  | Sim |  | N£mero do Anexo. |
| nr-contrato | integer | Nr Contrato | >>>,>>>,>>9 | 0 | Não |  | Nro Sequencial do Contrato |
| nr-cotacao | integer | Nr CotaÆo | >>>>>>>>9 | 0 | Não |  | N£mero da cotaÆo que deu origem ao pedido de venda |
| nr-ind-finan | integer | Nr Öndice Financto | >9 | 0 | Sim |  | N£mero do ¡ndice de financiamento |
| nr-invoice | character | Invoice | X(16) |  | Sim |  | N£mero da comercial invoice |
| nr-ped-cot-orig | character | Nr CotaÆo | x(12) |  | Não |  | N£mero da cotaÆo |
| nr-pedcli | character | Pedido Cliente | x(12) |  | Sim |  | N£mero do pedido do cliente |
| nr-pedido | integer | Nr Pedido | >>>,>>>,>>9 | 0 | Sim |  | N£mero do pedido |
| nr-pedido-crm | integer | Nr Pedido CRM | >>>,>>>,>>9 | 0 | Não |  | N£mero do pedido no sistema de CRM. |
| nr-pedrep | character | Pedido Representante | x(12) |  | Não |  | N£mero do pedido do representante |
| nr-proc-exp | character | Processo ExportaÆo | x(12) |  | Não |  | N£mero do processo de exportaÆo |
| nr-proforma | character | Proforma | x(12) |  | Não |  | Proforma de exportaÆo |
| nr-tab-finan | integer | Tab Financ | >>9 | 0 | Não |  | N£mero da tabela de financiamento |
| nr-tabpre | character | Tab Preos | x(8) |  | Sim |  | Tabela de preos |
| nr-versao | character | VersÆo Ped Cli | x(12) |  | Não |  | N£mero da versÆo do pedido do cliente |
| nro-proc-alteracao | integer | Processo AlteraÆo | >>>>>>>>9 | 0 | Não |  | Informe o n£mero do processo que alterou os dados |
| nro-proc-entrada | integer | Processo Entrada | >>>>>>>>9 | 0 | Não |  | Informe o n£mero do processo de entrada do pedido de cotaÆo |
| nro-proc-saida | integer | Processo Sa¡da | >>>>>>>>9 | 0 | Não |  | Informe o n§ do processo de sa¡da da resposta da cotaÆo |
| num-dias-praz-med-cond-esp | integer | Prazo Medio Cond Esp | >>9 | 0 | Não |  | N£mero Dias Prazo Medio Condicao Especial |
| num-id-campanha-crm | integer | Campanha Crm | >>>>,>>9 | 0 | Sim |  | N£mero Id Campanha Crm |
| num-id-oportun-vda | integer | Oportunidade Venda | >>>>,>>9 | 0 | Sim |  | N£mero Id Oportunidade Venda |
| num-pedido-bonif | character | Pedido BonificaÆo | X(12) |  | Não |  | N£mero do Pedido de BonificaÆo do Cliente |
| num-pedido-origem | character | Pedido Origem | X(12) |  | Não |  | N£mero do pedido de origem do cliente |
| observacoes | character | ObservaÆo | x(2000) |  | Não |  | ObservaÆo |
| origem | integer | Origem | 99 | 1 | Não | [diinc/i07di159.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i07di159.i) | Origem do pedido |
| pais | character | Pa¡s | x(20) | Brasil | Não |  | Pa¡s de Entrega do Pedido |
| pct-min-rentab | decimal | Pct Min Rentab | >>9.99 | 0 | Não |  | Percentual m¡nimo de rentabilidade exigido para o pedido |
| pedido-mp | logical | Pedido MP | Sim/NÆo | no | Não |  | Indicar se o pedido pertence a central de vendas ou nÆo |
| per-des-icms | decimal | Perc Desc ICMS | ->>9.999 | 0 | Sim |  | Percentual de desconto por ICMS |
| per-max-canc | decimal | % Max Cancel Saldo | >9.99 | 0 | Sim |  | Percentual m ximo p/ cancelamento de quantidades em aberto |
| perc-desco1 | decimal | Desconto Cliente | ->9.999 | 0 | Não |  | Percentual de desconto do cliente a ser aplicado sobre a nota |
| perc-desco2 | decimal | Desconto-2 | ->9.999 | 0 | Não |  | Segundo percentual de desconto sobre a nota |
| permissao | character | PermissÆo | x(72) | * | Sim |  | Permissäes de acesso ao pedido |
| placa | character | Placa | x(10) |  | Não |  | Placa do ve¡culo de transporte |
| proc-edi | integer | Processo EDI ImplantaÆo | >>>>9 |  | Não |  | N£mero do processo EDI que implantou o pedido |
| quem-aprovou | character | Aprovador Crdito | x(12) |  | Não |  | Usu rio que aprovou o crdito |
| replica-pd | logical | Replica Pedido Multiplanta | Sim/NÆo | no | Não |  | Replica pedido |
| tab-ind-fin | decimal | Öndice | >9.99999 | 1 | Não |  | Öndice de financiamento respectivo a cada prazo |
| taxa-orig | decimal | Taxa Financeira Original | >>9.99999 | 0 | Sim |  | Taxa de financiamento original |
| taxa-real | decimal | Taxa Financeira Real | >>9.99999 | 0 | Sim |  | Taxa de financiamento real |
| tip-cob-desp | integer | Tipo Cobrana Despesas | 99 | 1 | Sim | [diinc/i04di072.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i04di072.i) | Tipo de cobrana das despesas |
| tp-faturam | integer | Tipo Faturamento | 99 | 1 | Não | [diinc/i09di159.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i09di159.i) | Tipo de faturamento |
| tp-pedido | character | Tipo Pedido | x(2) |  | Não |  | Dispon¡vel para classificaÆo/indicaÆo pr¢pria do usu rio |
| tp-preco | integer | Tipo Preo | 99 | 1 | Sim | [diinc/i01di145.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i01di145.i) | Tipo de preo |
| tp-receita | integer | Tipo Receita | >>9 | 0 | Não |  | Tipo de receita |
| uf-placa | character | UF | !! |  | Não |  | Estado da placa do ve¡culo que tranportar  mercadoria |
| user-alte | character | Usu rio Ult Alt | x(12) |  | Não |  | Usu rio que efetuou a £ltima alteraÆo |
| user-aprov | character | Usu rio AprovaÆo | x(12) |  | Não |  | Usu rio que aprovou o pedido |
| user-aprov-cot | character | Usu rio Aprov CotaÆo | X(12) |  | Não |  | C¢digo do usu rio aprovador da cotaÆo |
| user-canc | character | Usu rio Cancelamento | x(12) |  | Não |  | Usu rio que efetuou o cancelamento |
| user-impl | character | Usu rio ImplantaÆo | x(12) |  | Não |  | Usu rio que implantou o pedido |
| user-preco | character | Usu rio AprovaÆo | x(12) |  | Não |  | Usu rio que aprovou o pedido |
| user-reat | character | Usu rio ReativaÆo | x(12) |  | Não |  | Usu rio que efetuou a reativaÆo do pedido |
| user-suspen | character | Usu rio SuspensÆo | x(12) |  | Não |  | Usu rio que suspendeu o pedido |
| val-desconto-total | decimal | Valor Desconto Total | >>>,>>>,>>9.99 | 0 | Não |  | Valor do desconto total |
| val-embal | decimal | Valor Embalagem | >>>,>>>,>>>,>>9.99 | 0 | Não |  | Informe o valor da embalagem |
| val-frete | decimal | Valor Frete | >>>,>>>,>>>,>>9.99 | 0 | Não |  | Informe o valor do frete |
| val-pct-desc-politic-bonifi | decimal | Perc Total Desconto Pol¡tic De | >>9.99 | 0 | Não |  | Valor Percentual Total Desconto Pol¡tica Descontos |
| val-pct-desconto-tab-preco | decimal | Perc Desc Tabela Preos | ->>9.99 | 0 | Sim |  | Percentual de descontos referente  tabela de preos |
| val-pct-desconto-total | decimal | Perc Desc Total | ->>9.9999 | 0 | Sim |  | Percentual de desconto total do pedido |
| val-pct-desconto-valor | decimal | Perc Desc Valor | ->>9.9999 | 0 | Sim |  | Percentual de desconto por valor do pedido |
| val-perc-embal | decimal | Perc Embalagem | >>9.99 | 0 | Não |  | Percentual de Embalagem |
| val-perc-frete | decimal | Perc Frete | >>9.99 | 0 | Não |  | Percentual de Frete |
| val-perc-seguro | decimal | Perc Seguro | >>9.99 | 0 | Não |  | Percentual de Seguro |
| val-seguro | decimal | Valor Seguro | >>>,>>>,>>>,>>9.99 | 0 | Não |  | Informe o valor do seguro |
| vl-cred-lib | decimal | Valor Crdito Liberado | >>>>,>>>,>>9.99 | 0 | Não |  | Valor do crdito liberado |
| vl-desconto | decimal | Vl Desconto | >>,>>9.99 | 0 | Não |  | Valor do desconto |
| vl-liq-abe | decimal | Valor Total Aberto | >,>>>,>>>,>>9.99 | 0 | Sim |  | Valor da mercadoria em aberto + IPI do saldo aberto |
| vl-liq-ped | decimal | Valor L¡quido Pedido | >,>>>,>>>,>>9.99 | 0 | Não |  | Valor l¡quido da mercadoria pedida |
| vl-mer-abe | decimal | Valor Mercadoria Aberto | >>,>>>,>>>,>>9.99 | 0 | Sim |  | Valor da mercadoria em aberto sem IPI |
| vl-tot-ped | decimal | Vl Total Pedido | >,>>>,>>>,>>9.99 | 0 | Sim |  | Valor total da mercadoria pedida adicionada do IPI |
| zip-code | character | CEP | x(12) |  | Não |  | CEP |

## Triggers

| Evento | Procedure | Link |
| :--- | :--- | :--- |
| create | database/tgdi/tcp/tcdi159.p | [Abrir Fonte](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/database/tgdi/tcp/tcdi159.p) |
| delete | database/tgdi/tdp/tddi159.p | [Abrir Fonte](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/database/tgdi/tdp/tddi159.p) |
| write | database/tgdi/twp/twdi159.p | [Abrir Fonte](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/database/tgdi/twp/twdi159.p) |

## Índices

- **ch-pedseq** (Primário, Único): nr-pedido
- **ch-avalia**: cod-sit-aval, nome-abrev
- **ch-canal**: dsp-pre-fat, cod-canal-venda, dt-entrega, nome-abrev, nr-pedcli
- **ch-cli-ped-ent**: dsp-pre-fat, nome-abrev, nr-pedcli, dt-entrega
- **ch-condpag**: cod-cond-pag
- **ch-contrato-venda**: nr-contrato, nr-anexo, nome-abrev, nr-pedcli
- **ch-credito**: nome-abrev, cod-sit-ped, cod-sit-aval
- **ch-ent-pr-cli**: dsp-pre-fat, dt-entrega, cod-priori, nome-abrev
- **ch-estcli**: cod-estabel, nome-abrev
- **ch-implant**: dt-implant, cod-sit-ped
- **ch-natoper**: nat-operacao
- **ch-nr-pedcli**: nr-pedcli, nome-abrev
- **ch-ped-origem**: nome-abrev, num-pedido-origem
- **ch-pedido** (Único): nome-abrev, nr-pedcli
- **ch-portador**: cod-portador, modalidade
- **ch-pr-ent-cli**: dsp-pre-fat, cod-priori, dt-entrega, nome-abrev
- **ch-pre-fat**: dt-entrega, cod-priori, cod-sit-ped, cod-estabel, nome-abrev, nr-pedcli
- **ch-rep-cli**: no-ab-reppri, nome-abrev, cod-sit-ped
- **ch-rep-cli-ent**: dsp-pre-fat, no-ab-reppri, nome-abrev, dt-entrega
- **ch-rota**: cod-rota, nome-abrev, nr-pedcli
- **ch-situ-pre**: cod-sit-preco, cod-sit-ped, log-cotacao
- **ch-tabfin**: cod-sit-ped, nr-tab-finan
- **ch-tabpre**: nr-tabpre, cod-sit-ped, tp-preco
- **ch-transp**: nome-transp
- **estab-sit-com**: cod-estabel, cod-sit-com, dt-entrega
- **pedvda-28**: log-cotacao, nome-abrev, nr-pedcli
- **pedvda-29**: nome-tr-red
- **pedvda-30**: log-cotacao, cod-sit-com, nome-abrev, nr-pedcli
- **pedvda-31**: dt-useralt, hra-atualiz
- **pedvda-32**: log-cotacao, dt-implant, nome-abrev
- **pedvda-cotac**: log-cotacao, nr-ped-cot-orig
