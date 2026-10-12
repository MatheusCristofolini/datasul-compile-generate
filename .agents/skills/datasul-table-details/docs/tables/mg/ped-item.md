# Tabela: ped-item

**Banco de Dados**: mg
**Label**: Item do Pedido
**Descrição**: Arquivo de Itens do Pedido de Venda
**Gerado em**: 09/07/2026, 10:08:21

## Campos

| Campo | Tipo | Label | Formato | Inicial | Obrig. | Include | Help |
| :--- | :--- | :--- | :--- | :--- | :--- | :--- | :--- |
| aliquota-ipi | decimal | Al¡quota IPI | >>9.99 | 0 | Sim |  | Al¡quota de IPI |
| aliquota-iva | decimal | Al¡quota IVA | >>9.99 | 0 | Não |  | Al¡quota IVA |
| aliquota-tax | decimal | Percent Imposto | >>9.99 | 0 | Não |  | Percentual do imposto |
| aloca-canc-saldo | logical | Aloca CE e Cancela Saldo | Sim/NÆo | no | Não |  | Aloca estoque com cancelamento de saldo |
| cd-freq | integer | Freq Fornec | >>9 | 0 | Sim |  | C¢digo da freq?ncia de fornecimento do item |
| cd-jurisdicao-ent | character | C¢digo JurisdiÆo | X(20) |  | Não |  | C¢digo da JurisdiÆo do endereco de entrega |
| cd-origem | integer | Origem | 99 | 1 | Sim | [diinc/i02di152.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i02di152.i) | Origem |
| char-1 | character |  | x(100) |  | Não |  |  |
| char-2 | character |  | x(100) |  | Não |  |  |
| check-sum | character | Check-sum | x(20) |  | Não |  |  |
| cod-class-fis | character | ClassificaÆo Fiscal | X(8) |  | Não |  |  |
| cod-cond-esp | integer | Cond Pgto Especial | >>>9 | 0 | Não |  | CondiÆo de pagamento promocional |
| cod-cta-contab | character | Conta Cont bil | x(17) |  | Não |  |  |
| cod-cust-contab | character | Custo Cont bil | x(12) |  | Não |  |  |
| cod-entrega | character | Entrega | x(12) |  | Sim |  | C¢digo do endereo de entrega |
| cod-estab-ctr | character | Estab Ctr | x(5) |  | Não |  | C¢digo do Estabelecimento do Contrato |
| cod-familia-mater | character | Fam¡lia | x(8) |  | Não |  | C¢digo da Fam¡lia de Materiais |
| cod-isencao | integer | Cod IsenÆo | >>9 | 0 | Não |  | C¢digo de isenÆo |
| cod-mot-canc-cot | integer | Cod Mot Cancelamento | >>9 | 0 | Não |  | C¢digo do motivo do cancelamento do item da cotaÆo |
| cod-ord-compra | character | N£mero Ordem Compra | x(15) |  | Não |  | N£mero da ordem de compra do item, origin rio do pedido compra. |
| cod-refer | character | Referncia | x(8) |  | Sim |  | C¢digo de referncia do item |
| cod-sit-com | integer | SituaÆo AvaliaÆo Comercial | 99 | 1 | Não | [diinc/i05di154.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i05di154.i) | C¢digo da situaÆo da avaliaÆo comercial |
| cod-sit-item | integer | SituaÆo | 99 | 1 | Não | [diinc/i03di149.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i03di149.i) | SituaÆo do item |
| cod-sit-pre | integer | SituaÆo AlocaÆo | 99 | 1 | Não | [diinc/i04di149.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i04di149.i) | SituaÆo da alocaÆo do estoque |
| cod-sit-preco | integer | SituaÆo AvaliaÆo Preo | 99 | 1 | Sim | [diinc/i05di154.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i05di154.i) | C¢digo da situaÆo da avaliaÆo de preos |
| cod-tax | integer | Cod Imp | >>>9 | 0 | Não |  | C¢digo do imposto |
| cod-un | character | Unidade Medida | x(2) |  | Não |  |  |
| cod-unid-negoc | character | Unidade Neg¢cio | X(3) |  | Sim |  | C¢digo Unidade Neg¢cio |
| cod-usu-alt-sit | character | Usu rio AlteraÆo SituaÆo | x(12) |  | Não |  | Usu rio de alteraÆo da situaÆo |
| cod-vat | integer | Cod Imp | >>>9 | 0 | Não |  | C¢digo do imposto |
| config-alter | logical | Altera ConfiguraÆo | Sim/NÆo | no | Não |  | Altera configuraÆo do item? |
| cons-mrp | logical | Considera MRP | Sim/NÆo | yes | Não |  | Considera pedido no MRP? |
| cons-pmp | logical | Considera  PV | Sim/NÆo | yes | Não |  | Considera pedido na previsÆo de vendas? |
| ct-codigo | character | Conta | x(20) |  | Não |  | C¢digo Conta |
| dat-alter-sit | date | AlteraÆo SituaÆo | 99/99/9999 | today | Não |  | Data da alteraÆo da situaÆo |
| dat-aprov-preco | date | Aprov Preos | 99/99/9999 | today | Não |  | Data de aprovaÆo dos preos |
| data-1 | date |  | 99/99/9999 |  | Não |  |  |
| data-2 | date |  | 99/99/9999 |  | Não |  |  |
| dec-1 | decimal |  | ->>>>>>>>>>>9.99999999 | 0 | Não |  |  |
| dec-2 | decimal |  | ->>>>>>>>>>>9.99999999 | 0 | Não |  |  |
| dec-ftconv-unest | decimal | Ft Conv Unid Estoque | >>>>>>>>>>>>>>>>>>>>>>>>>>>>>9 | 0 | Não |  | Fator de conversÆo da qtde pedida para a UM do estoque. |
| des-pct-desconto-inform | character | Perc Desc Informado | x(50) |  | Não |  | Percentuais de desconto informados por item do pedido |
| des-un-medida | character | Unidade Medida | xx |  | Sim |  | Unidade de medida do item do pedido. |
| desc-cancela | character | Motivo Cancelamento | x(2000) |  | Sim |  | DescriÆo do motivo do Cancelamento |
| desc-devol | character | Motivo DevoluÆo | x(2000) |  | Sim |  | Motivo da devoluÆo |
| desc-lib-preco | character | Motivo LiberaÆo Preos | x(76) |  | Não |  | Motivo da liberaÆo forada dos preos para o item do pedido |
| desc-txt | character | Desconto | x(50) |  | Não |  | DescriÆo dos descontos a n¡vel de item de pedido |
| dt-aprov-cot | date | Data Aprov CotaÆo | 99/99/9999 |  | Não |  | Data da aprovaÆo do item da cotaÆo |
| dt-canseq | date | Dt Cancelamento | 99/99/9999 |  | Não |  | Data de Cancelamento da seq?ncia do pedido |
| dt-devolucao | date | Dt DevoluÆo | 99/99/9999 |  | Não |  | Data de devoluÆo |
| dt-entorig | date | Dt Entrega Orig | 99/99/9999 | today | Não |  | Data de entrega solicitada pelo cliente |
| dt-entrega | date | Dt Entrega | 99/99/9999 | today | Sim |  | Data de entrega do item do Pedido |
| dt-lib-cot | date | Data Lib CotaÆo | 99/99/9999 |  | Não |  | Data da liberaÆo da cotaÆo |
| dt-max-fat | date | Dt M xima Fat | 99/99/9999 |  | Não |  | Data m xima para faturamento do item |
| dt-min-fat | date | Dt M¡nima Fat | 99/99/9999 | today | Sim |  | Data m¡nima para faturamento do item |
| dt-reativ | date | Dt ReativaÆo | 99/99/9999 |  | Não |  | Data de reativaÆo |
| dt-suspensao | date | Dt SuspensÆo | 99/99/9999 |  | Não |  | Data de suspensÆo |
| dt-useralt | date | Dt éltima AlteraÆo | 99/99/9999 |  | Não |  | Data da £ltima alteraÆo do item |
| dt-usercan | date | Dt Cancelamento | 99/99/9999 |  | Não |  | Data em que o Item foi cancelado |
| dt-userdev | date | Data DevoluÆo | 99/99/9999 |  | Não |  | Data em que ocorreu a devoluÆo |
| dt-userimp | date | Dt ImplantaÆo | 99/99/9999 |  | Não |  | Data de implantaÆo do item no pedido |
| dt-userrea | date | Dt ReativaÆo | 99/99/9999 |  | Não |  | Data de reativaÆo |
| dt-usersusp | date | Dt SuspensÆo | 99/99/9999 |  | Não |  | Data de suspensÆo |
| endereco_text | character | Endereo Completo | X(2000) |  | Não |  |  |
| esp-ped | integer | Espcie Pedido | 99 | 1 | Sim | [diinc/i04di154.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i04di154.i) | Espcie do pedido |
| ind-componen | integer | Tipo Componente | 99 | 1 | Sim | [diinc/i02di087.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i02di087.i) | Tipo de componente |
| ind-drop-shipment | logical | Usa Drop Shipment | yes/no | no | Não |  | Indica o uso de Drop Shipment para o item. |
| ind-fat-qtfam | logical | Fatura Quantidade Fam¡lia | sim/nÆo | no | Não |  | Fatura na quantidade da fam¡lia? |
| ind-icm-ret | logical | Retm ICMS Fonte | Sim/NÆo | no | Não |  | Haver  retenÆo de ICMS na fonte? |
| ind-orig-entrada | integer | Origem Entrada | >9 | 1 | Não | [diinc/i07di159.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i07di159.i) | Informe a origem da entrada da cotaÆo |
| ind-origem-fator | integer | Origem Fator ConversÆo | 9 | 2 | Não | [diinc/i06di154.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i06di154.i) | Origem do fator de conversÆo para a unidade medida estoque. |
| int-1 | integer |  | ->>>>>>>>9 | 0 | Não |  |  |
| int-2 | integer |  | ->>>>>>>>9 | 0 | Não |  |  |
| it-codigo | character | Item | x(16) |  | Sim |  | C¢digo do item |
| log-1 | logical |  | Sim/NÆo | no | Não |  |  |
| log-2 | logical |  | Sim/NÆo | no | Não |  |  |
| log-canc-saldo | logical | Cancela Saldo | Sim/NÆo | yes | Não |  |  |
| log-concede-bonif-qtd | logical | Concede Bonif Qtd | Sim/NÆo | no | Não |  | Concede bonificaÆo em quantidade? |
| log-desc-item-cli | logical | Desconto Item Cliente | Sim/NÆo | yes | Não |  |  |
| log-ordens-emitidas | logical | Ordens Emitidas | Sim/NÆo | no | Não |  | Houve geraÆo de ordens de produÆo? |
| log-preco-unid-medid-estoq | logical | Preo Unidade Medida Estoque | Sim/NÆo | yes | Sim |  | Preo na unidade de medida do estoque? |
| log-usa-tabela-desconto | logical | Usa Tabela Descontos | Sim/NÆo | yes | Sim |  | Usa a tabela de descontos no tratamento deste item do pedido? |
| motivo-alt-sit-quota | character | Motivo Alter SituaÆo Quota | x(2000) |  | Não |  | DescriÆo do motivo da alteraÆo da situaÆo da quota |
| nat-operacao | character | Natureza operaÆo | x(06) |  | Sim |  | Natureza de operaÆo |
| nome-abrev | character | Cliente | x(12) |  | Sim |  | Nome abreviado do cliente |
| nr-anexo | character | Anexo | X(12) |  | Sim |  | N£mero do Anexo. |
| nr-config | integer | Nr ConfiguraÆo | >>>,>>>,>>9 | 0 | Não |  | N£mero da configuraÆo |
| nr-contrato | integer | Nr Contrato | >>>,>>>,>>9 | 0 | Não |  | Nro Sequencial do Contrato |
| nr-ord-produ | integer | Nr Ordem ProduÆo | >>>,>>>,>>9 | 0 | Não |  | N£mero da Ordem de ProduÆo |
| nr-ordem | integer | Ordem Compra Cliente | zzzzz9,99 | 0 | Não |  | N£mero da ordem de compra do item, emitida pelo cliente |
| nr-pedcli | character | Pedido Cliente | x(12) |  | Sim |  | N£mero do pedido do cliente |
| nr-progcli | character | Programa Cliente | x(35) |  | Não |  | IdentificaÆo do programa atribu¡da pelo cliente |
| nr-programa | integer | Programa | >>>,>>>,>>9 | 0 | Não |  | N£mero do programa envidado pelo cliente |
| nr-seq-contr-it | integer | Sequncia Item Contr | >>,>>9 | 0 | Não |  | Informar o Nro da Sequncia do Item no Contrato. |
| nr-sequencia | integer | Seq?ncia | >>,>>9 | 0 | Sim |  | N£mero de seq?ncia do item no pedido |
| nr-tabpre | character | Tab Preos | x(8) |  | Sim |  | Tabela de preos |
| nr-versao | integer | VersÆo | >>9 | 0 | Não |  | N£mero de seq?ncia da versÆo do programa do cliente |
| num-casa-dec-unest | integer | N£mero Casas Decimais | >9 | 0 | Não |  | N£mero de casas decimais do fator de conversÆo. |
| num-id-campanha-crm | integer | Campanha Crm | >>>>,>>9 | 0 | Sim |  | N£mero Id Campanha Crm |
| num-sequencia-bonif | integer | Seq?ncia Bonif | >>,>>9 | 0 | Sim |  | N£mero da seq?ncia do item de venda quando for bonificaÆo |
| observacao | character | ObservaÆo | x(2000) |  | Não |  | ObservaÆo do item do pedido |
| parcela | integer | Parcela | >>>>>9 | 0 | Não |  | Parcela referente a ordem |
| per-des-icms | decimal | Perc Desc ICMS | ->>9.99999 | 0 | Não |  | Percentual de desconto por ICMS |
| per-des-item | decimal | Perc Desconto | ->>9.99999 | 0 | Não |  | Percentual de desconto sobre o preo unit rio |
| per-minfat | decimal | % Min Fat Parcial | >9.99 | 0 | Sim |  | Informe o percentual m¡nimo para faturamento parcial |
| perc-fornec | decimal | % Fornecimento | >>9.99 | 0 | Sim |  | Percentual de fornecimento do item informado pelo cliente |
| qt-alocada | decimal | Qt Alocada | >>,>>>,>>9.9999 | 0 | Não |  | Quantidade alocada do item do pedido |
| qt-atendida | decimal | Qt Atendida | >>,>>>,>>9.9999 | 0 | Não |  | Quantidade faturada para o item no pedido |
| qt-devolvida | decimal | Qt Devolvida | >>,>>>,>>9.9999 | 0 | Não |  | Quantidade devolvida do Item do pedido |
| qt-fatenf | decimal | Qt Ent Futura | >>,>>>,>>9.9999 | 0 | Sim |  | Quantidade faturada para entrega futura |
| qt-log-aloca | decimal | Qt Alocada | >>,>>>,>>9.9999 | 0 | Não |  | Quantidade alocada para o pedido |
| qt-lote-min | decimal | Qt Lote M¡nimo | >>>,>>>,>>9.9999 | 0 | Sim |  | Quantidade do lote m¡nimo a ser entregue por vez ao cliente |
| qt-ordens | decimal | Qtd em Ordens | >>,>>>,>>9.9999 | 0 | Não |  |  |
| qt-pedida | decimal | Quantidade Pedida | >>,>>>,>>9.9999 | 0 | Sim |  | Quantidade solicitada do Item no pedido de compra ou venda |
| qt-pendente | decimal | Quantidade Pendente | >>,>>>,>>9.9999 | 0 | Não |  | Quantidade faturada a ser atualizada como atendida |
| qt-trans-mp | decimal | Quantidade Transferida(MP) | >>,>>>,>>9.9999 | 0 | Não |  | Quantidade transferida para outras plantas |
| qt-transfer | decimal | Quantidade Transferida | >>,>>>,>>9.9999 | 0 | Não |  | Quantidade transferida para outro dep¢sito |
| qt-un-fat | decimal | Qtdade UM Fatur | >>,>>>,>>9.9999 | 0 | Não |  | Quantidade na UM utilizada para Faturamento do Item |
| qtd-alocar | decimal | Quantidade Alocar | ->>,>>9.99 | 0 | Não |  |  |
| qti-dias-carenc | integer | Qt.dias carencia | 9999 | 0 | Não |  | Quantidade de dias de carencia a cumprir |
| sc-codigo | character | Centro de custo Contabil | x(20) |  | Não |  | C¢digo Centro de custo Contabil |
| tipo-atend | integer | Tipo Atendimento | 99 | 1 | Não | [diinc/i05di149.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i05di149.i) | Tipo de atendimento |
| tp-adm-lote | integer | Pol¡tica AdministraÆo Lote | 99 | 1 | Não | [ininc/i15in122.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i15in122.i) | Pol¡tica de administraÆo do lote |
| tp-aloc-lote | integer | Tipo AlocaÆo Lote | 99 | 1 | Não | [diinc/i08di154.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i08di154.i) | Tipo de alocaÆo do lote |
| tp-preco | integer | Tipo Preo | 99 | 1 | Sim | [diinc/i01di145.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i01di145.i) | Tipo de preo |
| user-alte | character | Usu rio Ult Alt | x(12) |  | Não |  | C¢digo do £ltimo usu rio a alterar o item do pedido |
| user-aprov-cot | character | Usu rio Aprov CotaÆo | X(12) |  | Não |  | C¢digo do usu rio aprovador do item da cotaÆo |
| user-canc | character | Usu rio Cancelamento | x(12) |  | Não |  | C¢digo do usu rio que cancelou o item |
| user-devol | character | Usu rio DevoluÆo | x(12) |  | Sim |  | Usu rio que efetuou a devoluÆo |
| user-impl | character | Usu rio ImplantaÆo | x(12) |  | Não |  | Usu rio que implantou o item no pedido |
| user-lib-cot | character | Usu rio Lib CotaÆo | X(12) |  | Não |  | Usu rio de liberaÆo da cotaÆo |
| user-preco | character | Usu rio AprovaÆo | x(12) |  | Não |  | Usu rio que aprovou o item do pedido para preos |
| user-reat | character | Usu rio ReativaÆo | x(12) |  | Não |  | Usu rio que reativou o item no pedido |
| user-susp | character | Usu rio SuspensÆo | x(12) |  | Não |  | Usu rio que efetuou a suspensÆo do item no pedido |
| val-aliq-iss | decimal | Al¡quota ISS | ->>,>>9.99 | 0 | Não |  |  |
| val-desconto | decimal | Desconto | ->>>,>>>,>>9.99999 | 0 | Não |  | Descontos parametrizados (de 1 a 5) da tabela de descontos |
| val-desconto-bonif | decimal | Valor Desconto Bonif | >>>,>>>,>>9.99 | 0 | Sim |  | Valor do desconto referente  bonificaÆo |
| val-desconto-inform | decimal | Valor Desconto Informado | >>>,>>>,>>9.99 | 0 | Sim |  | Valor do desconto informado |
| val-desconto-total | decimal | Valor Desconto Total | >>>,>>>,>>9.99 | 0 | Não |  | Valor do desconto total |
| val-embal | decimal | Valor Embalagem | >>>,>>>,>>>,>>9.99 | 0 | Não |  | Informe o valor da embalagem |
| val-frete | decimal | Valor Frete | >>>,>>>,>>>,>>9.99 | 0 | Não |  | Informe o valor do frete |
| val-ipi | decimal | Valor IPI | >>>>,>>>,>>9.9999 | 0 | Não |  | Valor de IPI |
| val-pct-bonif | decimal | Perc BonificaÆo | ->9.999 | 0 | Não |  | Percentual de bonificaÆo do item do pedido |
| val-pct-desconto-periodo | decimal | Perc Desc Per¡odo | ->9.999 | 0 | Não |  | Percentual de desconto referente ao per¡odo controlado |
| val-pct-desconto-prazo | decimal | Perc Desc Prazo | ->9.999 | 0 | Não |  | Percentual de desconto referente ao prazo de pagamento |
| val-pct-desconto-tab-preco | decimal | Perc Desc Tabela Preos | ->9.99999 | 0 | Sim |  | Percentual de descontos em quantidade da tabela de preos |
| val-pct-desconto-total | decimal | Perc Desc Total | ->>9.9999 | 0 | Sim |  | Percentual de desconto total do item do pedido |
| val-preco-suger | decimal | Preco Sugerido | >>>,>>>,>>9.99999 | 0 | Não |  | Valor Preco Sugerido |
| val-seguro | decimal | Valor Seguro | >>>,>>>,>>>,>>9.99 | 0 | Não |  | Informe o valor do seguro |
| val-tax-apldo | decimal | Taxa Aplicada | >>9.99 | 0 | Não |  | Valor Taxa Aplicada |
| val-tax-ptlidad | decimal | Taxa Pontualidade | >>9.99 | 0 | Não |  | Valor Taxa Pontualidade |
| vl-desconto | decimal | Vl Desconto | >>,>>9.99999 | 0 | Não |  | Valor do desconto |
| vl-liq-abe | decimal | Valor Total Aberto | >>>>,>>>,>>9.99 | 0 | Sim |  | Valor total em aberto do item de pedido |
| vl-liq-it | decimal | Valor L¡quido | >>>>,>>>,>>9.99 | 0 | Sim |  | Valor l¡quido da mercadoria |
| vl-merc-abe | decimal | Valor L¡quido Aberto | >>>>,>>>,>>9.99 | 0 | Sim |  | Valor l¡quido da mercadoria em aberto |
| vl-pauta | decimal | Valor Pauta | >>>>,>>>,>>9.99 | 0 | Não |  | Valor do preo de pauta |
| vl-preori | decimal | Preo Original | >>>,>>>,>>9.99999 | 0 | Sim |  | Preo informado ou de tabela multiplicado pelo ¡ndice de financ |
| vl-preori-un-fat | decimal | Preo Original UM Fatur | >>>,>>>,>>9.99999 | 0 | Não |  | Preo Original na Unidade de Medida de Faturamento |
| vl-pretab | decimal | Preo Tabela | >>>,>>>,>>9.99999 | 0 | Sim |  | Preo de tabela ou informado caso nÆo exista tabela de preos |
| vl-preuni | decimal | Preo L¡quido | >>>,>>>,>>9.99999 | 0 | Sim |  | Preo unit rio l¡quido (preo original - descontos) |
| vl-tot-it | decimal | Valor Total Item | >>>>,>>>,>>9.99 | 0 | Sim |  | Valor total do item de pedido |

## Índices

- **ch-item-ped** (Primário, Único): nome-abrev, nr-pedcli, nr-sequencia, it-codigo, cod-refer
- **ch-cli-ped**: nome-abrev, nr-pedcli, it-codigo, cod-refer, cod-entrega
- **ch-componen**: nome-abrev, nr-pedcli, ind-componen, cod-sit-item
- **ch-config**: nr-config
- **ch-contrato-venda**: nr-contrato, nr-anexo, nr-seq-contr-it, nome-abrev, nr-pedcli, nr-sequencia
- **ch-correcao**: it-codigo, cod-refer, cod-sit-item, nr-tabpre, tp-preco
- **contrato**: it-codigo, esp-ped
- **peditem-08**: nr-tabpre, cod-sit-item
- **peditem-09**: dt-entrega, cod-sit-item
- **peditem-10**: cod-ord-compra
- **planejamento**: it-codigo, cod-sit-item, dt-entrega
