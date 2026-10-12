# Tabela: param-re

**Banco de Dados**: mg
**Label**: Parmetros do Recebimento
**Descrição**: Parametros do Recebimento
**Gerado em**: 21/07/2026, 09:38:57

## Campos

| Campo | Tipo | Label | Formato | Inicial | Obrig. | Include | Help |
| :--- | :--- | :--- | :--- | :--- | :--- | :--- | :--- |
| aceita-var | logical | Recebe com VariaÆo | Sim/NÆo | yes | Sim |  | Permite receber o item se houver variaÆo de quantidade/valor |
| ajusta-vl | logical | Ajusta Valores | Sim/NÆo | no | Não |  | Permite ajuste de valores no recebimento |
| alt-uf | logical | Atualiza UF | Sim/NÆo | no | Não |  | Permite atualizar unidade da federaÆo |
| ap-on-line | logical | Atualiza AP Automaticamente | Sim/NÆo | no | Sim |  | Os t¡tulos de AP serÆo gerados durante a atualizaÆo da nota |
| at-sem-ped | logical | Atualiza Nota sem Pedido | Sim/NÆo | no | Sim |  | Indica se atualiza notas que nÆo baixem pedidos de compra |
| atu-advert | logical | Atualiza com Advertncia | Sim/NÆo | yes | Sim |  | Atualiza nota com advertncia |
| atu-erro | logical | Atualiza com Erro | Sim/NÆo | yes | Sim |  | Atualiza nota com erro |
| atualiza-cr | logical | Atualiza Contas Receber | Sim/NÆo | no | Não |  | Atualiza contas a receber |
| baixa-estoq | logical | Baixa Estoque Autom tico | Sim/NÆo | no | Sim |  | Indica se o item dever  ser baixado do estoque |
| baixa-pedido | logical | Baixa Pedidos Compra | Sim/NÆo | no | Sim |  | Indica se o usu rio tem permissÆo para baixar pedidos de compra |
| bloqueia-pc-estab | logical | Bloqueia pedido outro estab | Sim/NÆo | no | Não |  |  |
| char-1 | character |  | x(100) |  | Não |  |  |
| char-2 | character |  | x(100) |  | Não |  |  |
| check-sum | character | Check-sum | x(20) |  | Não |  |  |
| cod-ent-item | integer | C¢digo Entrada Item | >9 | 1 | Sim | [ininc/i01in292.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i01in292.i) | C¢digo de entrada do item, Nosso ou Fornecedor |
| cod-espec-antecip | character | Espcie AntecipaÆo | !! |  | Não |  | C¢digo da espcie da antecipaÆo |
| cod-livre-1 | character |  | X(2000) |  | Não |  |  |
| cod-livre-2 | character |  | X(2000) |  | Não |  |  |
| codigo-rejei | integer | C¢digo DevoluÆo | >>9 | 0 | Não |  | Motivo padrÆo de devoluÆo do cliente |
| compara-item | logical | Baixa Item Dif do Comprado | Sim/NÆo | no | Sim |  | Indica se baixa item diferente do comprado |
| controla-estab | logical | Controla Estabel Usu rio | Sim/NÆo | no | Não |  | Indica se permite controlar estabelecimento do usu rio |
| dat-livre-1 | date |  | 99/99/9999 |  | Não |  |  |
| dat-livre-2 | date |  | 99/99/9999 |  | Não |  |  |
| data-1 | date |  | 99/99/9999 |  | Não |  |  |
| data-2 | date |  | 99/99/9999 |  | Não |  |  |
| dec-1 | decimal |  | ->>>>>>>>>>>9.99999999 | 0 | Não |  |  |
| dec-2 | decimal |  | ->>>>>>>>>>>9.99999999 | 0 | Não |  |  |
| dias-receb | integer | Per¡odo Recebimento | >>9 | 999 | Sim |  |  |
| encerra-cc | logical | Encerra Parcelas Compras | Sim/NÆo | no | Sim |  | Indica se o usu rio pode encerrar parcelas de ordens de compra |
| erro-dupli | logical | Atualiza NF Erros Duplicatas | Sim/NÆo | no | Não |  | Permite atualizar notas com erro de duplicata |
| esp-def-dac | character | Espcie para Despesas | !! | DA | Sim |  | Informe o c¢digo default para a espcie das Despesas Acess¢rias |
| esp-def-dup | character | Espcie  Duplicatas NF | !! |  | Sim |  | Espcie padrÆo para duplicatas de notas normais |
| esp-def-nff | character | Espcie Duplicatas NFF | !! |  | Sim |  | Espcie padrÆo para duplicatas de notas fiscais fatura |
| estab-usuario | character | Estabel Usu rio | x(5) |  | Não |  | Estabelecimento do usu rio |
| flag-atu | integer | Indicador AtualizaÆo | 9 | 2 | Não |  | Indicador de AtualizaÆo |
| gera-adv | logical | Gera Advertncias | Sim/NÆo | yes | Sim |  | Indica se gera ou nÆo arquivo com advertncias |
| gera-ce-fatura | logical | Atualiza Estoque ConciliaÆo Faturas | yes/no | no | Não |  | Atualiza Estoque ConciliaÆo Faturas |
| gera-item-ret | integer | Gera Itens Retorno | >9 | 1 | Sim | [ininc/i05in292.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i05in292.i) | Item ou Nota |
| gera-msg | logical | Gera Mensagens de Erro | Sim/NÆo | yes | Sim |  | Gera ou nÆo arquivo com as mensagens de erro da nota |
| inc-seq | integer | Incremento Seqncia | >>9 | 10 | Sim |  | Informe o incremento da seqncia dos itens da nota |
| inclui-icms | logical | Inclui ICMS | Sim/NÆo | no | Não |  |  |
| informa-dp | logical | Informa Duplicatas | Sim/NÆo | no | Sim |  | Indica se o usu rio informa duplicatas sem AP integrado |
| int-1 | integer |  | ->>>>>>>>9 | 0 | Não |  |  |
| int-2 | integer |  | ->>>>>>>>9 | 0 | Não |  |  |
| ipi-outras-tot-nota | logical | IPI Outras Total Nota | Sim/NÆo | no | Sim |  | Soma valor de IPI Outras no Total da Nota |
| log-1 | logical |  | Sim/NÆo | no | Não |  |  |
| log-2 | logical |  | Sim/NÆo | no | Não |  |  |
| log-atual-nfe-danfe-invldo | logical | Atz NF-e Danfe Inv | Sim/NÆo | no | Sim |  | L¢gico Atualiza NF-e com mensagem de DANFE inv lido |
| log-atualiza-nfe-auto | logical | Atualiza Nota Fiscal Eletronic | Sim/NÆo | no | Não |  | Indica se atualiza Nota Fiscal Eletronica automaticamente |
| log-atualiza-nfe-of | logical | Atualiza Nota Fiscal Eletrnic | Sim/NÆo | no | Sim |  | Permite atualizar o OF mesmo com chave de acesso nÆo autenticada |
| log-atualiza-quant-rma | logical | Atualizar Quantidades | Sim/NÆo | no | Não |  | Usu rio tem permissÆo para atualizar quant credit e devol RMA |
| log-atualiza-rma | logical | Atualizar RMA | Sim/NÆo | no | Não |  | Usu rio tem permissÆo para atualizar RMAs gerando documentos |
| log-atualiza-rpw-orig-eai | logical | Atual via RPW Orig EAI | Sim/NÆo | no | Não |  | Atualiza via RPW documento com origem EAI |
| log-comp-env-email | logical | Enviar e-mail Comparativo | Sim/NÆo | yes | Não |  |  |
| log-comp-liberar | logical | Liberar Comparativo | Sim/NÆo | yes | Não |  |  |
| log-comp-observ | logical | Observaäes Comparativo | Sim/NÆo | yes | Não |  |  |
| log-comp-reproces | logical | Reprocessar Comparativo | Sim/NÆo | yes | Não |  |  |
| log-cte-alterar | logical | Alterar CT-e | Sim/NÆo | yes | Não |  |  |
| log-cte-apl-regras | logical | Aplicar regras CT-e | Sim/NÆo | yes | Não |  |  |
| log-cte-cancelar | logical | Cancelar CT-e | Sim/NÆo | yes | Não |  |  |
| log-cte-excluir | logical | Excluir CT-e | Sim/NÆo | yes | Não |  |  |
| log-cte-ger-fiscal | logical | Gerar fiscal CT-e | Sim/NÆo | yes | Não |  |  |
| log-diverg-dupl-cond-pagto | logical | Verifica Duplicatas x Cond Pag | Sim/NÆo | no | Sim |  | Verifica Divergncia Duplicata x CondiÆo Pagamento |
| log-docto-fornec-restric | logical | Docto Fornec Com RestriÆo | Sim/NÆo | no | Não |  | Recebe Docto de Fornecedor com Restriäes. |
| log-fifo-oc | logical | FIFO Ordem Compra | Sim/NÆo | no | Sim |  | FIFO Ordem de Compra |
| log-geracao-ncr-ap | logical | GeraÆo Nota Crdito AP | Sim/NÆo | no | Não |  | Indica a geraÆo de nota de crdito no Contas a Pagar |
| log-livre-1 | logical |  | yes/no | no | Não |  |  |
| log-livre-2 | logical |  | yes/no | no | Não |  |  |
| log-nf-geren | logical | NFE Geren Fech | Sim/NÆo | no | Não |  | Permite inserir NFE per¡do gerencial fechado e fiscal aberto |
| log-nfe-alterar | logical | Alterar NF-e | Sim/NÆo | yes | Não |  |  |
| log-nfe-apl-regras | logical | Aplicar regras NF-e | Sim/NÆo | yes | Não |  |  |
| log-nfe-cancelar | logical | Cancelar NF-e | Sim/NÆo | yes | Não |  |  |
| log-nfe-excluir | logical | Excluir NF-e | Sim/NÆo | yes | Não |  |  |
| log-nfe-ger-fiscal | logical | Gerar fiscal NF-e | Sim/NÆo | yes | Não |  |  |
| log-nfe-ger-fisico | logical | Gerar f¡sico NF-e | Sim/NÆo | yes | Não |  |  |
| log-nfse-alterar | logical | Alterar NFS-e | Sim/NÆo | yes | Não |  |  |
| log-nfse-apl-regras | logical | Aplicar regras NFS-e | Sim/NÆo | yes | Não |  |  |
| log-nfse-cancelar | logical | Cancelar NFS-e | Sim/NÆo | yes | Não |  |  |
| log-nfse-excluir | logical | Excluir NFS-e | Sim/NÆo | yes | Não |  |  |
| log-nfse-ger-fiscal | logical | Gerar fiscal NFS-e | Sim/NÆo | yes | Não |  |  |
| log-ped-mesma-matriz | logical | Pedido mesma Matriz Fornec | Sim/NÆo | no | Não |  | Recebe pedido de fornecedor com mesma matriz do fornecedor da NF |
| log-ped-perc-rec-icms | logical | % ReduÆo ICMS | Sim/NÆo | no | Sim |  | Informa % de ReduÆo de ICMS? |
| log-ped-perc-rec-ipi | logical | % ReduÆo IPI | Sim/NÆo | no | Sim |  | Informa % de ReduÆo de IPI? |
| log-pedir-dupl-autom | logical | Pede Duplicata Autom tico | Sim/NÆo | no | Sim |  | Pedir Duplicata Autom tico |
| log-pedir-unid-negoc | logical | Pede Unidade Neg¢cio | Sim/NÆo | no | Sim |  | Pede Unidade Neg¢cio |
| log-permis-comis-repres | logical | Permis Comis Repres | Sim/NÆo | no | Sim |  | PermissÆo ComissÆo Representante |
| log-rat-difer-quant-fifo | logical | Rateio Diferena Quant FIFO | Sim/NÆo | no | Não |  | Rateio Diferena Quantidade FIFO |
| log-recuper-impto-online | logical | RI On-line | Sim/NÆo | no | Sim |  | RecuperaÆo de Impostos On-line |
| log-validac-cta | logical | V lida Contas Cont beis | Sim/NÆo | no | Não |  | Ativa validaÆo contas cont beis |
| nome | character | Nome | X(30) |  | Sim |  | Informe o Nome do Usuario |
| num-livre-1 | integer |  | ->>>,>>>,>>9 | 0 | Não |  |  |
| num-livre-2 | integer |  | ->>>,>>>,>>9 | 0 | Não |  |  |
| num-valoriz-consig | integer | Valorizacao Consignacao | >>>>,>>9 | 0 | Não |  | N£mero Valorizacao Consignacao |
| of-on-line | logical | Atualiza OF Automaticamente | Sim/NÆo | no | Sim |  | Os dados para OF serÆo gerados durante a atualizaÆo da nota |
| orig-aliq-ip | integer | Origem Aliquota IPI | >9 | 1 | Sim | [ininc/i02in292.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i02in292.i) | Origem da Al¡quota IPI, ClassificaÆo Fiscal ou Item |
| pd-aliq-icms | logical | Aliq ICMS | Sim/NÆo | no | Não |  | Solicita Aliquota de ICMS |
| pd-aliq-ipi | logical | Pede Aliq IPI | Sim/NÆo | no | Sim |  | Pede Al¡quota de IPI |
| pd-cd-icms | logical | Cod Trib ICMS | Sim/NÆo | no | Sim |  | Pede ou NÆo os C¢digos de TributaÆo do ICMS dos Itens |
| pd-cd-ipi | logical | Cod Trib IPI | Sim/NÆo | no | Sim |  | Pede ou nÆo os C¢digos de TributaÆo de IPI dos Itens |
| pd-cf-item | logical | Classif Fiscal | Sim/NÆo | no | Sim |  | Pede ou nÆo a ClassificaÆo Fiscal dos Itens |
| pd-despesas | logical | Desp Nota | Sim/NÆo | yes | Sim |  | Pede ou nÆo as Despesas Constantes na Nota |
| pd-esp-fiscal | logical | Pede Esp Fiscal | Sim/NÆo | no | Não |  | Informa se usu rio pode informar espcie fiscal da nota |
| pd-seq | logical | Seq | Sim/NÆo | yes | Sim |  | Pede ou nÆo a seqncia dos itens da nota |
| ped-imp-nota | logical | Total Impostos | Sim/NÆo | yes | Sim |  | O programa deve ou nÆo pedir os impostos no corpo da nota |
| pede-aca-ord | integer | Acabado/Ordens Compra | >9 | 1 | Sim | [ininc/i06in292.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i06in292.i) | Momento em que o programa deve pedir o Acabado/Ordem |
| pede-desc-it | logical | Descto Item | Sim/NÆo | yes | Sim |  | Pede ou nÆo o desconto dos itens |
| pede-it-agreg | logical | Item Agregado | Sim/NÆo | no | Sim |  | Pede c¢digo do Item na Entrada dos Agregados do Beneficiamento |
| pede-quant | logical | Converte Qtde Emitente | Sim/NÆo | no | Não |  | Converte para a quantidade do emitente |
| pedido-it | logical | Recebe Sem Pedido | Sim/NÆo | no | Não |  | Recebe o item sem pedido de compras |
| perc-vat | decimal | Perc Taxa | >>9.99 | 0 | Não |  | Percentual da Taxa |
| preco-nft | integer | Preo NFT | >9 | 0 | Não | [ininc/i10in292.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i10in292.i) | Preo da Nota Fiscal de Transferncia |
| preco-unit | logical | Consiste Preo Unit | Sim/NÆo | no | Não |  |  |
| rateia-desc | logical | Rateia Descto Total | Sim/NÆo | yes | Sim |  | Rateia Desconto Total entre os Itens |
| rateia-frete | integer | Rateia Frete FunÆo | >9 | 1 | Sim | [ininc/i04in292.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i04in292.i) | Rateia Frete entre os Itens em FunÆo do Peso ou do Valor |
| rateio-nfrateio | integer | NF Rateio em FunÆo | 9 | 2 | Não |  |  |
| reabre-cc | logical | Reabre Parc Compras | Sim/NÆo | no | Sim |  | Indica se o usu rio pode reabrir parcelas de ordens de compra |
| reabre-pd | logical | Reabre Ped Clientes | Sim/NÆo | no | Sim |  | O usu rio tem permissÆo para reabrir pedidos de clientes |
| rec-fatura | logical | Recebe Fatura | Sim/NÆo | yes | Não |  | Recebe Fatura |
| rec-nota-credito | logical | Recebe Nota Crdito | Sim/NÆo | yes | Não |  | Recebe Nota Crdito |
| rec-out-for | logical | Ped Outro Fornec | Sim/NÆo | yes | Sim |  | O usu rio pode receber pedidos de um outro fornecedor? |
| rec-remito | logical | Recebe Remito | Sim/NÆo | yes | Não |  | Recebe Remito |
| sem-pedido | logical | Rec Nota Sem Baixar Ped | Sim/NÆo | no | Sim |  | Informe se pode ou nÆo receber notas sem baixar Pedido de compra |
| seq-item-um | integer | Seq Primeiro Item | >>>>9 | 10 | Sim |  | Seqncia do primeiro item da nota |
| tipo-arredonda | integer | Arredonda Preo Unit | >9 | 1 | Não | [ininc/i07in292.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i07in292.i) | N£mero de decimais para arredondar o preo unit rio |
| tp-atual-cr | integer | Tipo Atual CR | >9 | 1 | Não | [ininc/i09in292.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i09in292.i) | Tipo de atualizaÆo do contas a receber |
| tp-doc-perm | integer | Tipo Doc | >9 | 0 | Não | [ininc/i11in292.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i11in292.i) | Tipo de documento permitido |
| usuario | character | Usuar | x(12) |  | Sim |  |  |
| val-livre-1 | decimal |  | ->>>,>>>,>>9.99 | 0 | Não |  |  |
| val-livre-2 | decimal |  | ->>>,>>>,>>9.99 | 0 | Não |  |  |
| val-variacao | decimal | Variacao Permitida | 9.99 | 0 | Não |  | VariaÆo permitida no c lculo da duplicata |
| var-atual | integer | Variac Atualiz | 999 | 0 | Não |  | VariaÆo m xima permitida para data de atualizacao |
| var-emis | integer | Variac EmissÆo | 999 | 0 | Não |  | VariaÆo m xima permitida para a data de emissÆo |
| variacao | integer | Variac Perm Dt Entrega | >>9 | 0 | Sim |  | VariaÆo m xima permitida para a data de entrega do documento |
| vl-base-icm | integer | Valor Base ICMS | >9 | 1 | Sim | [ininc/i03in292.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i03in292.i) | Valor Base, L¡quido ou Bruto |
| vl-base-ipi | integer | Valor Base IPI | >9 | 1 | Sim | [ininc/i03in292.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i03in292.i) | Valor Base, Bruto ou Liquido |
| vl-base-iss | integer | Valor Base ISS | >9 | 1 | Sim | [ininc/i03in292.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i03in292.i) | Valor Base, Bruto ou L¡quido |
| vl-rec-fis | logical | Valor Rec F¡sico | Sim/NÆo | no | Não |  |  |

## Índices

- **ind-usu** (Primário, Único): usuario
