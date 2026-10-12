# Tabela: user-coml

**Banco de Dados**: mg
**Label**: Permissäes do Usu rio
**Descrição**: Arquivo de permissoes para os usuarios comerciais
**Gerado em**: 16/06/2026, 11:25:28

## Campos

| Campo | Tipo | Label | Formato | Inicial | Obrig. | Include | Help |
| :--- | :--- | :--- | :--- | :--- | :--- | :--- | :--- |
| baixa-estoque | logical | Baixa Estoque | Sim/NÆo | no | Não |  | Baixa estoque? |
| char-1 | character |  | x(100) |  | Não |  |  |
| char-2 | character |  | x(100) |  | Não |  |  |
| check-sum | character | Check-sum | x(20) |  | Não |  |  |
| cod-estabel-padrao | character | Estabelecimento PadrÆo | x(5) |  | Não |  | C¢digo do estabelecimento padrÆo do usu rio comercial |
| data-1 | date |  | 99/99/9999 |  | Não |  |  |
| data-2 | date |  | 99/99/9999 |  | Não |  |  |
| dec-1 | decimal |  | ->>>>>>>>>>>9.99999999 | 0 | Não |  |  |
| dec-2 | decimal |  | ->>>>>>>>>>>9.99999999 | 0 | Não |  |  |
| especie-pd | logical | Possui Espcie do Pedido | Sim/NÆo | no | Não |  | Pedido possui espcie? |
| gera-atp-negativo | logical | Gera ATP Negativo | Sim/NÆo | yes | Não |  | Usu rio pode gerar ATP negativo? |
| idi-aloc-item-item | logical | AlocaÆo F cil Item a Item | Sim/NÆo | yes | Não |  | Indica se a alocaÆo facilitada ser  item-item ou  final embarque |
| idi-atualiz-dat-entreg-item | integer | Atualiza Data Entrega Itens | 9 | 1 | Sim | [diinc/i03di211.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i03di211.i) | AtualizaÆo da Data Entrega nos Itens |
| idi-atualiz-local-entreg-item | integer | Atualiza Local Entrega Itens | 9 | 1 | Sim | [diinc/i02di211.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i02di211.i) | AtualizaÆo do Local Entrega nos Itens |
| idi-atualiz-natur-item | integer | Atualiza Natureza Itens | 9 | 1 | Sim | [diinc/i01di211.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i01di211.i) | AtualizaÆo da Natureza OperaÆo nos Itens |
| idi-atualiz-tab-desc-item | integer | Atualiza Tabela Desconto Itens | 9 | 1 | Sim | [diinc/i04di211.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i04di211.i) | AtualizaÆo da Tabela Desconto nos Itens |
| idi-atualiz-tab-preco-item-ped | integer | Atualiza Tabela Preo Itens | 9 | 1 | Sim | [diinc/i04di211.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i04di211.i) | AtualizaÆo da Tabela Preos nos Itens |
| idi-niv-aces | integer | Nivel Acesso | 9 | 1 | Sim | [diinc/i04di275.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i04di275.i) | Indicador de Nivel Acesso |
| ind-aliq-ipi | logical | Altera AliqIPI | Sim/NÆo | no | Não |  | Altera al¡quota de IPI dos itens com IPI diferenciado? |
| ind-alt-ipi | logical | Altera Al¡quota de IPI | Sim/NÆo | no | Não |  | Altera al¡quota de IPI dos itens com IPI diferenciado? |
| ind-alteraestcot | logical | Qt Alocada CotaÆo | Sim/NÆo | no | Não |  | Altera alocaÆo efetuada na cotaÆo com prazo expirado? |
| ind-antecip | logical | Possui AntecipaÆo | Sim/NÆo | yes | Não |  | Possui antecipaÆo? |
| ind-ar-lote-aut | logical | Arredonda Lote | Sim/NÆo | no | Não |  | Arredonda lote m£ltiplo automaticamente? |
| ind-arred-lt-mult | logical | Arredonda Lote M£ltiplo | Sim/NÆo | no | Não |  | Arredonda lote m£ltiplo? |
| ind-arredon-lote | logical | Arredonda lote M£ltiplo | Sim/NÆo | yes | Não |  | Arredonda lote m£ltiplo? |
| ind-bloq-quota-med-cli | logical | Bloqueia Quota Mdia Cliente | Sim/NÆo | yes | Não |  | Bloqueia quota mdia do cliente? |
| ind-bloqueia-quota | logical | Bloqueia Quota | Sim/NÆo | no | Não |  | Bloqueia quota? |
| ind-calc-aut | logical | C lculo de Resumos | Sim/NÆo | no | Não |  | Resumos serÆo calculados automaticamente? |
| ind-calc-pedido | logical | Calcula pedido no item | Sim/NÆo | no | Não |  | Indica se o c lculo do pedido ser  realizado item a item |
| ind-canal-cliente | logical | Canal Venda X Cliente | Sim/NÆo | no | Não |  | Consiste a relaÆo canal de vendas x clientes |
| ind-canal-item | logical | Canal Venda X Item | Sim/NÆo | no | Não |  | Consiste relaÆo canal de venda x item |
| ind-canc-saldo | logical | Percentual Cancela Saldo | Sim/NÆo | yes | Não |  | Percentual m ximo de cancelamento de saldo |
| ind-cidade-cif | logical | Cidade CIF | Sim/NÆo | yes | Não |  | Cidade CIF |
| ind-comis | logical | Informa Percentual ComissÆo | Sim/NÆo | yes | Não |  | Percentual de comissÆo do representante |
| ind-desc-icms | logical | Desconto ICMS | Sim/NÆo | yes | Não |  | Informa o desconto de ICMS? |
| ind-desc-tabpre | logical | Desconto Tabela Preos | Sim/NÆo | yes | Não |  | Informa os descontos da tabela de preos? |
| ind-desconto-nota | logical | Utiliza Tab Des Nota Fis | Sim/NÆo | no | Não |  | Utiliza tabela de desconto em notas manuais e complementares |
| ind-fat-min | logical | Considera Faturamento M¡nimo | Sim/NÆo | yes | Não |  | Faturamento m¡nimo ser  considerado? |
| ind-fat-qtfam | logical | Fatura Quantidade Fam¡lia | Sim/NÆo | no | Não |  | Fatura na quantidade da fam¡lia? |
| ind-it-codcli | logical | Item Cliente | Sim/NÆo | no | Sim |  | Item ser  informado pelo c¢digo do cliente? |
| ind-item | logical | Item Tela | Sim/NÆo | no | Não |  | C¢digo do item permanecer  na tela? |
| ind-item-cli | logical | Item Cliente Pedido | Sim/NÆo | no | Não |  | RelaÆo item x cliente ser  usada na implantaÆo de pedidos? |
| ind-lote | logical | Informa Lote | Sim/NÆo | yes | Não |  | Informa lote? |
| ind-lotemult | logical | Lote M£ltiplo de Venda | Sim/NÆo | yes | Sim |  | Haver  arredondamento pelo lote m£ltiplo de venda? |
| ind-nat-oper | logical | Natureza operaÆo | Sim/NÆo | yes | Não |  | Informa natureza de operaÆo do item? |
| ind-prob-canal-cli | logical | Alerta Canal x Cliente | Sim/NÆo | no | Não |  | Emite alerta se a relaÆo canal x cliente nÆo esteja cadastrada |
| ind-prob-canal-item | logical | Alerta Canal x Item | Sim/NÆo | no | Não |  | Emite alerta caso a relaÆo canal x item nÆo esteja cadastrada? |
| ind-qt-un-cli | logical | Quantidade Unidade Cliente | Sim/NÆo | no | Não |  | Quantidade na unidade do cliente? |
| ind-repres | logical | Representante | Sim/NÆo | yes | Não |  | Informa representante no pedido? |
| ind-saldo-estoq | logical | Verifica Saldo Estoque | Sim/NÆo | yes | Não |  | Saldo de estoque ser  verificado no pedido? |
| ind-tp-atend | logical | Tipo Atendimento | Sim/NÆo | yes | Não |  | Tipo de atendimento |
| ind-tp-cobranca | logical | Tipo Cobrana Despesa | Sim/NÆo | yes | Não |  | Tipo de cobrana das despesas |
| ind-utiliza-desconto | logical | Utiliza Tab Desconto | Sim/NÆo | no | Não |  | Informa a utilizaÆo da tabela de descontos? |
| inf-aloc-logica | logical | AlocaÆo L¢gica | Sim/NÆo | no | Sim |  | Informa alocaÆo l¢gica? |
| inf-baiest | logical | Baixa Estoque | Sim/NÆo | no | Sim |  | Atualiza CE? |
| inf-canal-venda | logical | Canal Venda | Sim/NÆo | no | Não |  | Informa canal de venda? |
| inf-cod-imp | logical | C¢digo Imposto | Sim/NÆo | no | Não |  | Informa se o usu rio informa o c¢digo do imposto |
| inf-codent | logical | C¢digo Entrega | Sim/NÆo | yes | Não |  | Informa c¢digo de entrega? |
| inf-codest | logical | Estabelecimento | Sim/NÆo | yes | Não |  | Informa c¢digo do estabelecimento? |
| inf-codmsg | logical | Mensagem | Sim/NÆo | yes | Não |  | Informa c¢digo da mensagem? |
| inf-comemis | logical | ComissÆo EmissÆo | Sim/NÆo | no | Sim |  | Informa comissÆo de emissÆo? |
| inf-condesp | logical | Cond Especial | Sim/NÆo | yes | Não |  | Informa texto de condiäes especiais? |
| inf-condpag | logical | CondiÆo Pagamento | Sim/NÆo | yes | Não |  | Informa condiÆo de pagamento? |
| inf-desc1 | logical | Desconto Cliente | Sim/NÆo | yes | Não |  | Informa o percentual de desconto do cliente no pedido? |
| inf-desc2 | logical | Desconto Inform Ped | Sim/NÆo | yes | Não |  | Informa os descontos informados do pedido? |
| inf-desc3 | logical | Desconto Item | Sim/NÆo | yes | Não |  | Informa os descontos do item do pedido? |
| inf-desmer | logical | Destino Mercadoria | Sim/NÆo | yes | Não |  | Informa destino da mercadoria? |
| inf-dtemis | logical | Data emissÆo Pedido | Sim/NÆo | yes | Não |  | Informa a data de emissÆo do pedido? |
| inf-dteno-pi | logical | Data Entrega Original Item | Sim/NÆo | yes | Não |  | Informa a data de entrega original do item do pedido? |
| inf-dtenp-pi | logical | Data Entrega Prevista Item | Sim/NÆo | yes | Não |  | Informa a data prevista do item do pedido? |
| inf-dtento | logical | Data Entrega Original | Sim/NÆo | yes | Não |  | Informa a data de entrega original? |
| inf-dtentr | logical | Data Entrega Prevista | Sim/NÆo | yes | Não |  | Informa a data de entrega prevista? |
| inf-dtimp | logical | Data ImplantaÆo | Sim/NÆo | yes | Não |  | Informa a data de implantaÆo? |
| inf-dtlimfat | logical | Data Limite Faturamento | Sim/NÆo | yes | Não |  | Informa a data limite de faturamento? |
| inf-dtminfat | logical | Data M¡nima Faturamento | Sim/NÆo | yes | Não |  | Informa a data m¡nima de faturamento? |
| inf-fatpar | logical | Fatura Parcial | Sim/NÆo | yes | Não |  | Informa aceitaÆo de faturamento parcial? |
| inf-icmsr-pi | logical | ICMS Retido Item Pedido | Sim/NÆo | yes | Não |  | Informa ICMS retido no item do pedido? |
| inf-icmsret | logical | ICMS Retido fonte | Sim/NÆo | yes | Não |  | Informa ICMS retido na fonte? |
| inf-invoice | logical | Invoice | Sim/NÆo | yes | Não |  | O n£mero da comercial invoice ser  informado? |
| inf-libnota | logical | Libera Nota | Sim/NÆo | yes | Não |  | Informa libera nota sem saldo? |
| inf-moeda | logical | Moeda Pedido | Sim/NÆo | yes | Não |  | Informa a moeda do pedido? |
| inf-moeda-fatur | logical | Moeda Faturamento | Sim/NÆo | yes | Não |  | Informa Moeda para Faturamento? |
| inf-natoper | logical | Natureza de OperaÆo | Sim/NÆo | yes | Não |  | Informa natureza de operaÆo? |
| inf-nrent | logical | N£mero Entrega Item | Sim/NÆo | yes | Sim |  | Informa n£mero da entrega do item? |
| inf-nrseq | logical | Seqncia Item Pedido | Sim/NÆo | yes | Não |  | Informa seqncia do item do pedido? |
| inf-obs | logical | Observaäes | Sim/NÆo | yes | Não |  | Informa observaäes do pedido? |
| inf-obsped | logical | Observaäes Pedido | Sim/NÆo | no | Não |  | Observaäes do pedido em tele-pedidos? |
| inf-ordcomp | logical | Ordem Compra | Sim/NÆo | yes | Não |  | Informa ordem de compra? |
| inf-pedcli | logical | Pedido Cliente | Sim/NÆo | yes | Não |  | Informa o n£mero do pedido do cliente? |
| inf-pedrep | logical | Pedido Representante | Sim/NÆo | yes | Não |  | Informa pedido do representante? |
| inf-perminf | logical | Percentual Faturamento Parcial | Sim/NÆo | yes | Não |  | Informa percentual de faturamento parcial? |
| inf-portador | logical | Portador | Sim/NÆo | no | Não |  | Informa portador? |
| inf-precoorig | logical | Preo Original | Sim/NÆo | no | Não |  | Informa preo original ? |
| inf-priori | logical | Prioridade | Sim/NÆo | yes | Não |  | Informa prioridade? |
| inf-qtalocada | logical | Qt Alocada | Sim/NÆo | no | Não |  | Informa quantidade alocada? |
| inf-qtpedida | logical | Qt Pedida | Sim/NÆo | no | Não |  | Informa quantidade pedida ? |
| inf-redesp | logical | Redespacho | Sim/NÆo | yes | Não |  | Informa endereo de redespacho? |
| inf-rota | logical | Rota | Sim/NÆo | yes | Não |  | Informa a rota do pedido? |
| inf-tabfin | logical | Tabela Financiamento | Sim/NÆo | yes | Não |  | Informa tabela de financiamento? |
| inf-tabpre | logical | Tabela Preo | Sim/NÆo | yes | Não |  | Informa tabela de preos? |
| inf-tipent | logical | Tipo Entrega | Sim/NÆo | no | Não |  | Informa tipo de entrega? |
| inf-tpped | logical | Tipo Pedido | Sim/NÆo | yes | Não |  | Informa tipo de pedido? |
| inf-tppreco | logical | Tipo Preo | Sim/NÆo | yes | Não |  | Informa tipo de preo? |
| inf-tprec | logical | Tipo Receita | Sim/NÆo | yes | Não |  | Informa tipo de receita no pedido? |
| inf-transp | logical | Transportador | Sim/NÆo | yes | Não |  | Informa transportador? |
| inf-vlemb | logical | Valor Embalagem | Sim/NÆo | yes | Não |  | Informa valor de embalagem? |
| inf-vlfrete | logical | Valor frete | Sim/NÆo | yes | Não |  | Informa valor de frete? |
| inf-vlseg | logical | Valor Seguro | Sim/NÆo | yes | Não |  | Informa valor de seguro? |
| int-1 | integer |  | ->>>>>>>>>9 | 0 | Não |  |  |
| int-2 | integer |  | ->>>>>>>>>9 | 0 | Não |  |  |
| item-cliente | logical | Item Cliente | Sim/NÆo | no | Não |  | Informa origem do c¢digo do cliente? |
| log-1 | logical |  | Sim/NÆo | no | Não |  |  |
| log-2 | logical |  | Sim/NÆo | no | Não |  |  |
| log-alt-nota | logical | Altera NF Pendente | Sim/NÆo | no | Sim |  | Indica se pode alterar notas pendentes de outros usu rios |
| log-altnf-ca | logical | Altera Dados Nota Fiscal C lculo Autom tico | Sim/NÆo | no | Sim |  | Permite alterar dados da NF no c lculo autom tico? |
| log-arredonda-lote-multiplo-ped | logical | Arredonda Lote Autom tico Ped | Sim/NÆo | no | Não |  | Arredonda Lote Automaticamente. |
| log-atualiz-consfinal-natur-ped | logical | Atualiza Consumidor Final | Sim/NÆo | no | Sim |  | Atualizar consumidor final |
| log-atualiz-desc-tab-preco-ped | logical | Atualizacao Desc Tabela Preco | Sim/NÆo | no | Sim |  | Atualizar Desconto da tabela de preos |
| log-atualiz-item-atend-parcial | logical | Atualiza Item/Entr Atend Parc | Sim/NÆo | no | Sim |  | Atualizar itens/entregas atendidos parcial |
| log-atualiz-msg-natur-item | logical | Atualiza Mensagem Natur Itens | Sim/NÆo | no | Sim |  | Atualizar c¢digo da mensagem da natureza nos itens |
| log-atualiz-tab-desc-item | logical | Atualiza Tabela Desconto Item | Sim/NÆo | no | Sim |  | Atualiza Tabela Desconto Item |
| log-bloq-ped-embarq-calcul | logical | Bloq Ped Emb j  Calc | Sim/NÆo | no | Sim |  | Bloqueia a inclusÆo de pedidos em embarques j  calculados. |
| log-emite-danfe | logical | DANFE em Contingncia | Sim/NÆo | no | Sim |  | Permite a emissÆo do DANFE em contingncia |
| log-inf-safra | logical | Safra | Sim/NÆo | no | Não |  | L¢gico InformaÆo Safra |
| log-inf-unid-med | logical | Unidade Medida Faturamento | sim/nÆo | no | Não |  | Indicar se acessa a unidade de medida do item. |
| log-informa-bonif | logical | BonificaÆo | Sim/NÆo | no | Não |  | Informa dados de bonificaÆo do item? |
| log-informa-desc-tab-desc | logical | Desconto Tabela Descontos | Sim/NÆo | no | Não |  | Informa os descontos da tabela de descontos? |
| log-informa-lote | logical | Informa Lote | Sim/NÆo | no | Sim |  | Informa Lote |
| log-informa-unid-negoc | logical | Unidade Neg¢cio | Sim/NÆo | no | Sim |  | Permite informar a unidade de neg¢cio no item do pedido |
| log-it-comp | logical | Apresenta Itens Componentes | Sim/NÆo | no | Sim |  | Apresentar itens componentes? |
| log-libera-cotas | logical | Libera Cotas | Sim/NÆo | yes | Não |  | Usu rio autorizado a liberar pedidos bloqueados por Cotas? |
| log-libera-credito | logical | Libera Crdito | Sim/NÆo | yes | Não |  | Usu rio autorizado a liberar pedidos bloqueados por crdito? |
| log-libera-desconto | logical | Libera Desconto | Sim/NÆo | yes | Não |  | Usu rio autorizado a liberar pedidos bloqueados por desconto? |
| log-libera-preco | logical | Libera Preos | Sim/NÆo | yes | Não |  | Usu rio autorizado liberar pedidos bloqueados por preo m¡nimo? |
| log-lim-cred | logical | Limite Credito | Sim/NÆo | no | Não |  | Limite Credito |
| log-mantem-item | logical | Mantm Item | Sim/NÆo | no | Sim |  | Mantm item na tela |
| log-mantem-refer | logical | Mantm Referncia | Sim/NÆo | no | Sim |  | Indicar se mantm ou nÆo a referncia. |
| log-mostra-sdo-item | logical | Mostra Saldo Item | Sim/NÆo | no | Sim |  | Mostra saldo dispon¡vel em estoque do item |
| log-negocia-preco-venda | logical | Negocia Preo Venda | yes/no | no | Não |  | Negocia preo venda item cotaÆo ou pedido? |
| log-preco-item-compon-comp | logical | Preo Item Componente Composto | Sim/NÆo | no | Sim |  | Atribui preo dos componentes ao composto |
| log-reabre-cotac-cancel-ped | logical | Reabre CotaÆo Cancel Pedido | Sim/NÆo | no | Sim |  | Reabrir cotaÆo ao cancelar pedido |
| multiplica | logical | Converte quantidade configura | Sim/NÆo | no | Não |  | Converte qt configurada pela qt componente |
| nat-incons | logical | Bloqueia Natur Inconsistente | Sim/NÆo | no | Não |  | Bloqueia natureza de operaÆo inconsistente? |
| obs-pd | logical | Pedido Possui Observaäes | Sim/NÆo | no | Não |  | Pedido possui observaäes? |
| observacao | character | ObservaÆo | x(2000) |  | Não |  | ObservaÆo |
| ref-tela | logical | Mantm Referncia tela | Sim/NÆo | no | Não |  | Referncia deve ser mantida na tela? |
| un-cliente | logical | Unidade Medida Cliente | Sim/NÆo | no | Não |  | Origem da unidade de medida a ser utilizada |
| usuario | character | Usu rio | x(12) |  | Sim |  | Usu rio |
| val-pct-desconto-max | decimal | Perc Desconto M ximo | >>9.999 | 100 | Não |  | Percentual de desconto m ximo permitido para o usu rio |

## Índices

- **ch-usuario** (Primário, Único): usuario
