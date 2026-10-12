# Tabela: docum-est

**Banco de Dados**: mg
**Label**: Doc Movimentados Estoque
**Descrição**: Arquivo de Documentos Movimentados pelo Estoque
**Gerado em**: 18/05/2026, 14:47:40

## Campos

| Campo | Tipo | Label | Formato | Inicial | Obrig. | Include | Help |
| :--- | :--- | :--- | :--- | :--- | :--- | :--- | :--- |
| acresc-financ | logical | Possui Acrscimo Financeiro | Sim/NÆo | no | Não |  |  |
| aliq-irf | decimal | Al¡quota Imposto de Renda | >>9.99 | 0 | Sim |  |  |
| aliquota-icm | decimal | Aliquota ICMS | >>9.99 | 0 | Sim |  |  |
| aliquota-iss | decimal | Aliquota ISS | >>9.99 | 0 | Sim |  |  |
| ap-atual | logical | AP Atualizado | Sim/NÆo | no | Sim |  | Indica se as datas para Contas a Pagar j  foram atualizadas |
| atual-ft | logical | Atualiza FT | Sim/NÆo | no | Não |  |  |
| atualiza-cr | logical | Atualiza Contas Receber | Sim/NÆo | yes | Não |  |  |
| bairro | character | Bairro | X(30) |  | Não |  | Bairro do Estabelecimento |
| base-cofins-subs | decimal | Base COFINS Subs | >>>>,>>>,>>9.99 | 0 | Sim |  | Base COFINS Substituto |
| base-icm | decimal | Base C lculo ICMS | >>>>>,>>>,>>9.99 | 0 | Sim |  |  |
| base-icm-fas | decimal | Base C lculo ICMS | >>>>>,>>>,>>9.99 | 0 | Sim |  |  |
| base-ipi | decimal | Base C lculo IPI | >>>>>,>>>,>>9.99 | 0 | Sim |  |  |
| base-ipi-fas | decimal | Base C lculo IPI | >>>>>,>>>,>>9.99 | 0 | Sim |  |  |
| base-iss | decimal | Base C lculo ISS | >>>>>,>>>,>>9.99 | 0 | Sim |  |  |
| base-iss-fas | decimal | Base C lculo ISS | >>>>>,>>>,>>9.99 | 0 | Sim |  |  |
| base-pis-subs | decimal | Base PIS Subs | >>>>,>>>,>>9.99 | 0 | Sim |  | Base PIS Substituto |
| base-subs | decimal | Base SubstituiÆo Tribut ria | >>>>>,>>>,>>9.99 | 0 | Não |  |  |
| base-subs-fasb | decimal | Base Subs Trib FASB | >>>>>,>>>,>>>.99 | 0 | Não |  | Base para substituiÆo tribut ria em FASB |
| c-nr-invoice | character | N£mero Invoice | x(10) |  | Não |  |  |
| cc-atual | logical | Atualiza Compras | Sim/NÆo | no | Não |  | Indica se a nota j  foi atualizada em Compras |
| cdn-depositante | integer | Depositante | >>>>>>>>9 | 0 | Não |  | C¢digo do Depositante |
| cdn-modalid-transp | integer | Modalidade Transporte | 9 | 0 | Não | [adinc/i01ad268.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i01ad268.i) | Modal de transporte |
| cdn-sit-nfe | integer | SituaÆo Nota Fiscal Entrada | 9 | 0 | Não | [ininc/i09in090.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i09in090.i) | Situacao Nota Fiscal Entrada |
| ce-atual | logical | CE Atualizado | Sim/NÆo | no | Sim |  | Indica se o documento j  foi atualizado |
| cep | character | CEP | x(12) |  | Não |  | C¢digo de endereamento postal |
| char-1 | character |  | x(100) |  | Não |  |  |
| char-2 | character |  | x(100) |  | Não |  |  |
| check-sum | character | Check-sum | x(20) |  | Não |  |  |
| cidade | character | Cidade | x(50) |  | Não |  | Nome da cidade |
| cod-chave-aces-nf-eletro | character | Chave Acesso NF-e | x(60) |  | Sim |  | C¢digo Chave Acesso Nota fiscal Eletrnica |
| cod-emitente | integer | Emitente | >>>>>>>>9 | 0 | Sim |  |  |
| cod-entrega | character | Cod Entrega | x(12) |  | Não |  | C¢digo do endereo de entrega |
| cod-estabel | character | Estabelecimento | x(5) |  | Sim |  |  |
| cod-ibge | integer | C¢digo IBGE | 9 | 1 | Não |  |  |
| cod-imp-embal | integer | C¢d. Imposto Embalagem | >>9 | 0 | Não |  | Informe o C¢digo do Imposto da Embalagem |
| cod-imp-frete | integer | C¢d. Imposto Frete | >>9 | 0 | Não |  | Informe o C¢digo do Imposto Frete |
| cod-imp-irf | character | Imposto | x(4) |  | Sim |  |  |
| cod-imp-outras | integer | C¢d. Imposto Outras | >>9 | 0 | Não |  | Informe o C¢digo de Imposto Outras Despesas |
| cod-imp-seguro | integer | C¢d. Imposto Seguro | >>9 | 0 | Não |  | Informe o C¢digo de Imposto do Seguro |
| cod-natur-vincul | character | Natureza Vinculada | x(06) |  | Não |  | Natureza de OperaÆo Vinculada |
| cod-observa | integer | ObservaÆo | 9 | 1 | Sim | [ininc/i03in090.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i03in090.i) | C¢digo de observaÆo da nota fiscal |
| cod-placa | character | Placa | x(12) |  | Não |  | Placa |
| cod-ret-irf | integer | C¢digo RetenÆo Imposto | >>>>9 | 0 | Sim |  |  |
| cod-rma | character | Nr RMA | X(16) |  | Não |  | N£mero da RMA |
| cod-servico | integer | Cod Servio | >>>>9 | 0 | Não |  | C¢digo de servio definido pela legislaÆo municipal |
| cod-tax-div | integer | Imposto s/Diversos | >>9 | 0 | Não |  | C¢digo do imposto sobre diversos |
| cod-tax-fre | integer | Imposto s/Frete | >>9 | 0 | Não |  | C¢digo do imposto sobre frete |
| cod-tipo-nf-cred-deb | character | Tipo Nota Crdito/Dbito | x(02) |  | Não |  | Tipo Nota Crdito/Dbito |
| cod-uf-placa | character | UF | !! |  | Não |  | Estado da placa do ve¡culo que tranportar  mercadoria |
| conta-transit | character | Conta Transit | x(20) |  | Não |  | Conta Transitoria |
| cotacao-dia | decimal | CotaÆo Dia | >>>,>9.99999999 | 1 | Não |  | CotaÆo do Dia |
| cotacao-fasb | decimal | CotaÆo Moeda FASB | >>>,>>9.99999999 | 0 | Sim |  |  |
| cp-atual | logical | CP Atualizado | Sim/NÆo | no | Sim |  | M¢dulo de ProduÆo Atualizado |
| cr-atual | logical | Contas Receber Atualizado | Sim/NÆo | no | Sim |  |  |
| ct-transit | character | Conta Transit¢ria | x(20) |  | Sim |  |  |
| dat-aprovacao | date | Data AprovaÆo | 99/99/9999 |  | Não |  | Data de aprovaÆo do documento |
| dat-validade | date | Data Validade | 99/99/9999 |  | Não |  | Data de validade do documento |
| data-1 | date |  | 99/99/9999 |  | Não |  |  |
| data-2 | date |  | 99/99/9999 |  | Não |  |  |
| dec-1 | decimal |  | ->>>>>>>>>>>9.99999999 | 0 | Não |  |  |
| dec-2 | decimal |  | ->>>>>>>>>>>9.99999999 | 0 | Não |  |  |
| declaracao-import | character | DeclaraÆo ImportaÆo | X(20) |  | Sim |  | DeclaraÆo de ImportaÆo |
| desc-motivo-aprov | character | Motivo AprovaÆo | X(2000) |  | Não |  | Motivo da aprovaÆo |
| desp-fasb | decimal | Despesas Nota | >>>>>,>>>,>>9.99 | 0 | Sim |  |  |
| despesa-nota | decimal | Despesas Nota | >>>>>,>>>,>>9.99 | 0 | Sim |  |  |
| despesa-nota-me | decimal | Vl Despesa ME | >>>,>>>,>>9.99 | 0 | Não |  |  |
| dia-util-irf | integer | Dia étil para Imposto | >>9 | 0 | Não |  |  |
| dt-atualiza | date | Data AtualizaÆo | 99/99/9999 | today | Sim |  | Data de atualizaÆo da movimentaÆo |
| dt-emissao | date | Data EmissÆo | 99/99/9999 | today | Sim |  |  |
| dt-entr-merc | date | Data Entrada Mercadoria | 99/99/9999 |  | Não |  |  |
| dt-trans | date | Data TransaÆo | 99/99/9999 | 01/01/1800 | Sim |  |  |
| dt-venc-icm | date | Data Vcto ICMS | 99/99/9999 |  | Não |  | Data para vencimento do ICM |
| dt-venc-ipi | date | Data Vcto IPI | 99/99/9999 |  | Não |  | Data para vencimento de IPI |
| dt-venc-iss | date | Data Vcto ISS | 99/99/9999 |  | Não |  | Permite informar a data de vencimento para ISS |
| embalagem | character | Embalagem | x(10) |  | Não |  |  |
| embarque | character | Embarque | X(16) |  | Não |  | N£mero do Embarque |
| endereco | character | Endereo | X(40) |  | Não |  | Informar o endereo do fornecedor |
| esp-docto | integer | Espcie Documento | >9 | 1 | Sim | [ininc/i03in218.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i03in218.i) | Espcie do documento |
| esp-fiscal | character | Espcie Fiscal | X(3) |  | Sim |  | Informe a espcie fiscal |
| esp-irf | character | Espcie IRF | !! |  | Sim |  |  |
| estab-de-or | character | Est Origem/Destino | x(5) |  | Sim |  | Estabelecimento de Origem ou Destino |
| estab-fisc | character | Estabel Fiscal | x(5) |  | Sim |  | Estabelecimento para geraÆo dos documentos fiscais |
| estado | integer | SituaÆo Nota | >9 | 1 | Sim | [ininc/i02in090.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i02in090.i) | Estado do documento com relaÆo ao controle de Qualidade |
| estorn-comis | logical | Estorna ComissÆo | Sim/NÆo | no | Sim |  |  |
| fat-despesa | logical | Fatura Despesa | Sim/NÆo | no | Não |  | Indica se a fatura  de outras despesas |
| ft-atual | logical | Atualiza Faturamento | Sim/NÆo | no | Não |  | Indica se a nota j  foi atualizada no faturamento |
| hr-atualiza | character | Hora AtualizaÆo | x(8) |  | Sim |  |  |
| i-sequencia | integer | Seqncia | 999 | 0 | Não |  |  |
| icm-complem | decimal | ICMS Complementar | >>>>>,>>>,>>9.99 | 0 | Sim |  |  |
| icm-cpl-fasb | decimal | ICMS Complementar | >>>>>,>>>,>>9.99 | 0 | Sim |  |  |
| icm-dc-fasb | decimal | Valor ICMS | >>>>>,>>>,>>9.99 | 0 | Sim |  |  |
| icm-deb-cre | decimal | Valor ICMS | >>>>>,>>>,>>9.99 | 0 | Sim |  |  |
| icm-fnt-fasb | decimal | ICMS Fonte FASB | >>>>>,>>>,>>9.99 | 0 | Sim |  | ICMS Recolhido na Fonte |
| icm-fonte | decimal | ICMS Fonte | >>>>>,>>>,>>9.99 | 0 | Sim |  |  |
| icm-nao-trib | decimal | ICMS NÆo Tributado | >>>>>,>>>,>>9.99 | 0 | Sim |  |  |
| icm-ntr-fasb | decimal | ICMS NÆo Tributado | >>>>>,>>>,>>9.99 | 0 | Sim |  |  |
| icm-out-fasb | decimal | ICMS Outras | >>>>>,>>>,>>9.99 | 0 | Sim |  |  |
| icm-outras | decimal | ICMS outras | >>>>>,>>>,>>9.99 | 0 | Sim |  |  |
| idi-bxa-devol | integer | Baixa Devolucao | 9 | 1 | Não | [ininc/i10in090.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i10in090.i) | Tipo de baixa utilizada nos titulos na devoluÆo de exportaÆo! |
| idi-nf-simples-remes | integer | NF Simples Remessa | 99 | 3 | Não | [ininc/i08in090.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i08in090.i) | Nota fiscal Simples Remessa |
| idi-sit-nf-eletro | integer | SituaÆo NF-e | >9 | 0 | Não |  | Indica a SituaÆo da Nota fiscal Eletrnica |
| idi-tip-operac | integer | Tipo OperaÆo | >>9 | 0 | Não |  | Tipo de operaÆo |
| imp-import | decimal | Imposto ImportaÆo | ->>,>>9.99 | 0 | Não |  |  |
| ind-extrac | logical | Indicador ExtraÆo | Sim/NÆo | no | Não |  | Indicador de ExtraÆo (Sim/NÆo) |
| ind-orig-entrada | integer | Origem Entrada | >9 | 1 | Não | [diinc/i07di159.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i07di159.i) | Informe a origem da entrada da cotaÆo |
| ind-rateio | logical | Nota Rateio | Sim/NÆo | no | Não |  | Indica se a nota fiscal  de rateio |
| ind-sit-wms-ext | integer | SituaÆo WMS Externo | >9 | 0 | Não | `ininc/i03in089.i` (ñ enc.) | Indicador da situaÆo do WMS Externo. |
| ind-tipo-rateio | logical | Rateio por Peso ? | Sim/NÆo | yes | Não |  | Indica se o rateio  feito por peso ou valor |
| ind-via-envio | integer | Via Envio | >9 | 1 | Não | [diinc/i07di159.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i07di159.i) | Via de envio da cotaÆo |
| int-1 | integer |  | ->>>>>>>>>9 | 0 | Não |  |  |
| int-2 | integer |  | ->>>>>>>>>9 | 0 | Não |  |  |
| ipi-dc-fasb | decimal | Valor IPI | >>>>>,>>>,>>9.99 | 0 | Sim |  |  |
| ipi-deb-cre | decimal | Valor IPI | >>>>>,>>>,>>9.99 | 0 | Sim |  | Valor IPI |
| ipi-despesa | decimal | IPI Sobre Despesas | >>>>>,>>>,>>9.99 | 0 | Sim |  |  |
| ipi-nao-trib | decimal | IPI NÆo Tributado | >>>>>,>>>,>>9.99 | 0 | Sim |  |  |
| ipi-ntr-fasb | decimal | IPI NÆo Tributado | >>>>>,>>>,>>9.99 | 0 | Sim |  |  |
| ipi-out-fasb | decimal | IPI Outras | >>>>>,>>>,>>9.99 | 0 | Sim |  |  |
| ipi-outras | decimal | IPI Outras | >>>>>,>>>,>>9.99 | 0 | Sim |  |  |
| iss-dc-fasb | decimal | Valor ISS | >>>>>,>>>,>>9.99 | 0 | Sim |  |  |
| iss-deb-cre | decimal | Valor ISS | >>>>>,>>>,>>9.99 | 0 | Sim |  |  |
| iss-nao-trib | decimal | ISS NÆo Tributado | >>>>>,>>>,>>9.99 | 0 | Sim |  |  |
| iss-ntr-fasb | decimal | ISS NÆo Tributado | >>>>>,>>>,>>9.99 | 0 | Sim |  |  |
| iss-out-fasb | decimal | ISS Outras | >>>>>,>>>,>>9.99 | 0 | Sim |  |  |
| iss-outras | decimal | ISS Outras | >>>>>,>>>,>>9.99 | 0 | Sim |  |  |
| log-1 | logical |  | Sim/NÆo | no | Não |  |  |
| log-2 | logical |  | Sim/NÆo | no | Não |  |  |
| log-atualiz-proces-export | logical | AtualizaÆo Processo ExportaÆ | Sim/NÆo | no | Sim |  | AtualizaÆo Processo ExportaÆo |
| log-cc-atual | logical | Compras Atualizado | Sim/NÆo | no | Sim |  | Nota j  atualizada no Compras? |
| log-consid-ender-nf-saida | logical | Consid End NF Venda/Remessa | Sim/NÆo | no | Sim |  | Considera Endereco Nota fiscal Venda/Remessa |
| log-draw-atlzdo | logical | Drawback Atualizado | Sim/NÆo | no | Sim |  | Indica se os movimentos para Drawback j  foram atualizados. |
| log-entreg-fut | logical | Entrega Futura | Sim/NÆo | no | Não |  | Nota de Entrega Futura? |
| log-ft-atual | logical | Faturamento Atualizado | Sim/NÆo | no | Sim |  | Nota j  atualizada no Faturamento? |
| log-memorando | logical | Memorando de ExportaÆo | Sim/NÆo | no | Sim |  | Memorando de ExportaÆo |
| log-pt-atual | logical | Patrimnio Atualizado | Sim/NÆo | no | Sim |  | Nota j  atualizada no Patrimnio? |
| log-recuper-impto-atlzdo | logical | RI Atualizado | Sim/NÆo | no | Sim |  | RecuperaÆo de Impostos Atualizado |
| log-tax-siscomex | logical | Usa Taxa Siscomex? | Sim/NÆo | no | Sim |  | Utiliza Taxa Sistema de comercio exterior |
| log-wms-atual | logical | WMS Atualizado | Sim/NÆo | no | Não |  | Indica se o WMS est  atualizado |
| mo-codigo | integer | Moeda | >9 | 0 | Não |  | Moeda |
| mod-atual | integer | AtualizaÆo M¢dulos | >>>>9 | 0 | Sim |  |  |
| mod-frete | integer | Modalidade Frete | >9 | 1 | Sim | [diinc/i01di037.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i01di037.i) | Modalidade de frete: CIF ou FOB |
| nat-operacao | character | Nat OperaÆo | x(06) |  | Sim |  |  |
| nf-emitida-est | logical | NF Emitida Estab | Sim/NÆo | no | Não |  | Nota fiscal emitida pelo pr¢prio estabelecimento |
| nff | logical | Nota Fiscal Fatura | Sim/NÆo | no | Sim |  | Sim  ou  Nao |
| nome-transp | character | Transportador | x(12) |  | Não |  | Nome do transportador |
| nro-docto | character | Documento | x(16) |  | Sim |  |  |
| nro-proc-entrada | integer | Processo Entrada | >>>>>>>>9 | 0 | Não |  | Informe o n£mero do processo de entrada do pedido de cotaÆo |
| nro-proc-saida | integer | Processo Sa¡da | >>>>>>>>9 | 0 | Não |  | Informe o n§ do processo de sa¡da da resposta da cotaÆo |
| num-seq-cont-emit | integer | Seq Contato | >>9 | 0 | Não |  | Seqncia do contato do fornecedor |
| obs-infadfisco | character | ObservaÆo Inf. Adic. Fisco | x(1000) |  | Não |  |  |
| obs-infcpl | character | ObservaÆo Inf Complementar | x(1000) |  | Não |  |  |
| observacao | character | ObservaÆo | x(2000) |  | Sim |  |  |
| of-atual | logical | OF Atualizado | Sim/NÆo | no | Sim |  | Indica se os dados para OF j  foram gerados |
| ok-data | date | Data Ok | 99/99/9999 |  | Não |  | Data do acordo da nota com o fornecedor |
| ok-fornec | integer | Ok Fornecedor | >9 | 1 | Sim |  | 0 = OK  /  1 = Dif Preco/Qtd  /  2 = Dif Imposto  /  3 = Ambos |
| ok-observ | character | ObservaÆo do Ok | x(2000) |  | Não |  |  |
| ok-user | character | Usuario Ok | x(12) |  | Sim |  | Usuario que acertou a nota com o fornecedor |
| origem | character | Origem | ! |  | Não |  |  |
| pais | character | Pa¡s | X(20) |  | Não |  | C¢digo Pa¡s |
| pais-origem | character | Pais Origem | x(20) |  | Sim |  | Pais de origem do Documento |
| perc-tax-div | decimal | Al¡quota de Diversos | >>9.99 | 0 | Não |  | Al¡quota de diversos |
| perc-tax-emb | decimal | Al¡quota Embalagem | >>9.99 | 0 | Não |  | Informe a Al¡quota de Imposto da Embalagem |
| perc-tax-fre | decimal | Al¡quota de Frete | >>9.99 | 0 | Não |  | Al¡quota de frete |
| perc-tax-seg | decimal | Al¡quota Seguro | >>9.99 | 0 | Não |  | Informe a Al¡quota de Imposto do Seguro |
| peso-bruto-tot | decimal | Peso Bruto Total | >>>,>>>,>>9.999 | 0 | Não |  | Peso bruto total |
| peso-liquido-tot | decimal | Peso L¡quido Total | >>>,>>>,>>9.999 | 0 | Não |  | Peso l¡quido total |
| pt-atual | logical | Atualiza Patrimnio | Sim/NÆo | no | Não |  | Indica se a nota j  foi atualizada no Patrimnio |
| qt-tot-imp | decimal | Qtde Total Import | ->>,>>9.99 | 0 | Não |  |  |
| rateia-frete | integer | Rateia Frete | >9 | 1 | Sim | [ininc/i04in292.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i04in292.i) | Permite informar se o rateio do frete sera pelo Peso ou Valor |
| rec-fisico | logical | Receb F¡sico | Sim/NÆo | no | Não |  |  |
| sc-transit | character | Sub-Conta Transit | x(20) |  | Sim |  |  |
| serie-docto | character | Srie | x(5) |  | Sim |  |  |
| sit-atual | integer | SituaÆo Atual | >9 | 1 | Não | [ininc/i07in090.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i07in090.i) | SituaÆo do documento quanto  conciliaÆo |
| sit-docum | integer | SituaÆo Documento | >9 | 1 | Não | [ininc/i06in090.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i06in090.i) | SituaÆo documento em relaÆo  fatura no contas a pagar |
| sit-edi | integer | SituaÆo EDI | >9 | 1 | Não | [ininc/i01in090.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i01in090.i) | SituaÆo do documento em relaÆo ao EDI |
| taxa-conv-imp | decimal | Taxa ConversÆo | 9.9999999999 | 0 | Não |  |  |
| tipo-docto | integer | Tipo | >9 | 1 | Sim |  | Tipo do documento |
| tipo-nota | integer | Tipo Nota | >9 | 1 | Sim | [ininc/i01in089.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i01in089.i) | Tipo de Nota Fiscal |
| tot-des-fasb | decimal | Total Descto | >>>>>,>>>,>>9.99 | 0 | Sim |  |  |
| tot-desconto | decimal | Total Descto | >>>>>,>>>,>>9.99 | 0 | Sim |  | Valor do desconto total |
| tot-desconto-me | decimal | Tot Desconto ME | >>>,>>>,>>9.99 | 0 | Não |  |  |
| tot-peso | decimal | Peso Total | >>>>,>>>,>>9.9999 | 0 | Sim |  |  |
| tot-taxa | decimal | Total Impostos | >>>,>>>,>>9.99 | 0 | Não |  |  |
| tot-taxa-me | decimal | Vl Imposto ME | >>>,>>>,>>9.99 | 0 | Não |  |  |
| tot-valor | decimal | Valor Total | >>>>,>>>,>>>,>>9.99 | 0 | Sim |  |  |
| tot-valor-me | decimal | Tot Valor ME | >>>,>>>,>>9.99 | 0 | Não |  |  |
| tot-vl-fasb | decimal | Valor Total | >>>>,>>>,>>>,>>9.99 | 0 | Sim |  |  |
| tp-rat-fret | integer | Tp Rateio Frete | 9 | 0 | Não |  |  |
| ts-disp-integr | datetime | Dispon¡vel IntegraÆo | 99/99/9999 HH:MM:SS.SSS |  | Não |  | Dispon¡vel para integraÆo sistema externo |
| ts-processamento | datetime | Timestamp Processamento | 99/99/9999 HH:MM:SS.SSS |  | Não |  | Timestamp Processamento |
| uf | character | Unid FederaÆo | x(4) |  | Sim |  |  |
| usuario | character | Usuar | x(12) |  | Sim |  | Usu rio respons vel pela atualizacao do documento |
| val-perc-restocagem | decimal | Perc Restocagem | >9.99 | 0 | Não |  | Percentual de restocagem praticado pelo fornecedor |
| val-restocagem | decimal | Val Restocagem | >>>,>>9.9999 | 0 | Não |  | Valor de restocagem praticado pelo fornecedor |
| valor-embal | decimal | Embalagem | >>>>>,>>>,>>9.99 | 0 | Sim |  | Despesas com Embalagem |
| valor-embal-me | decimal | Vl Embal ME | >>>,>>>,>>9.99 | 0 | Não |  |  |
| valor-frete | decimal | Valor Frete | >>>>>,>>>,>>9.99 | 0 | Sim |  |  |
| valor-frete-me | decimal | Vl Frete ME | >>>,>>>,>>9.99 | 0 | Não |  |  |
| valor-irf | decimal | Valor IRF | >>>>>,>>>,>>9.99 | 0 | Sim |  |  |
| valor-mercad | decimal | Valor Total Merc | >>>>>,>>>,>>9.99 | 0 | Sim |  |  |
| valor-mercad-me | decimal | Vl Mercado ME | >>>,>>>,>>9.99 | 0 | Não |  |  |
| valor-outras | decimal | Outras | >>>>>,>>>,>>9.99 | 0 | Sim |  | Outras despesas, alem de Frete, Seguro ou Embalagem |
| valor-outras-me | decimal | Vl Outras ME | >>>,>>>,>>9.99 | 0 | Não |  |  |
| valor-seguro | decimal | Seguro | >>>>>,>>>,>>9.99 | 0 | Sim |  |  |
| valor-seguro-me | decimal | Vl Seguro ME | >>>,>>>,>>9.99 | 0 | Não |  |  |
| via-transp | integer | Via Transporte | 9 | 1 | Sim | [adinc/i01ad268.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i01ad268.i) |  |
| vl-cofins-subs | decimal | Valor COFINS Subs | >>>>,>>>,>>9.99 | 0 | Sim |  | Valor COFINS Substituto |
| vl-emb-fasb | decimal | Embalagem | >>>>>,>>>,>>9.99 | 0 | Sim |  | Despesas com embalagem, constantes na nota |
| vl-fre-fasb | decimal | Frete | >>>>>,>>>,>>9.99 | 0 | Sim |  | Despesas com frete, constantes na nota |
| vl-imp-embalagem | decimal | Valor Imposto Embalagem | >>>,>>>,>>>,>>9.99 | 0 | Não |  | Informe o Valor do Imposto da Embalagem |
| vl-imp-embalagem-me | decimal | Valor Imposto Embal ME | >>>,>>>,>>>,>>9.99 | 0 | Não |  | Informe o Valor do Imposto da Embalagem em Moeda Estrangeira |
| vl-imp-frete | decimal | Valor Imposto Frete | >>>,>>>,>>>,>>9.99 | 0 | Não |  | Informe o Valor do Imposto do Frete |
| vl-imp-frete-me | decimal | Valor Imposto Frete ME | >>>,>>>,>>>,>>9.99 | 0 | Não |  | Informe o Valor do Imposto do Frete em Moeda Estrangeira |
| vl-imp-impor | decimal | Imposto Import | >>>>,>>>,>>9.99 | 0 | Sim |  | Valor dos impostos de importaÆo |
| vl-imp-outras | decimal | Valor Imposto Outras | >>>,>>>,>>>,>>9.99 | 0 | Não |  | Informe o Valor do Imposto Outras Despesas |
| vl-imp-outras-me | decimal | Valor Imposto Outras ME | >>>,>>>,>>>,>>9.99 | 0 | Não |  | Informe o Valor do Imposto Outras Despesas ME |
| vl-imp-seguro | decimal | Valor Imposto Seguro | >>>,>>>,>>>,>>9.99 | 0 | Não |  | Informe o Valor do Imposto do Seguro |
| vl-imp-seguro-me | decimal | Valor Imposto Seguro ME | >>>,>>>,>>>,>>9.99 | 0 | Não |  | Informe o Valor do Imposto do Seguro em Moeda Estrangeira |
| vl-merc-fasb | decimal | Valor Total Merc | >>>>>,>>>,>>9.99 | 0 | Sim |  | Valor total das mercadorias, sem desconto e sem IPI |
| vl-out-fasb | decimal | Outras | >>>>>,>>>,>>9.99 | 0 | Sim |  | Outras despesas, alem de frete, seguro ou embalagem |
| vl-pis-subs | decimal | Valor PIS Subs | >>>>,>>>,>>9.99 | 0 | Sim |  | Valor PIS Substituto |
| vl-seg-fasb | decimal | Seguro | >>>>>,>>>,>>9.99 | 0 | Sim |  | Despesas com Seguro, constantes na nota |
| vl-subs | decimal | Valor Subst Trib | >>>>>,>>>,>>9.99 | 0 | Não |  | Valor substituiÆo tributaria |
| vl-subs-fasb | decimal | Valor Subst Trib FASB | >>>>>,>>>,>>9.99 | 0 | Não |  | Valor para substituicao tributaria FASB |
| vl-tax-diversos | decimal | Valor Imposto Diversos | >>>,>>>,>>9.99 | 0 | Não |  | Valor do imposto sobre despesas diversas |
| vl-tax-frete | decimal | Valor Imposto Frete | >>>,>>>,>>9.99 | 0 | Não |  | Valor do imposto sobre despesas de frete |

## Triggers

| Evento | Procedure | Link |
| :--- | :--- | :--- |
| Delete | database/tgin/tdp/tdin090.p | [Abrir Fonte](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/database/tgin/tdp/tdin090.p) |

## Índices

- **documento** (Primário, Único): serie-docto, nro-docto, cod-emitente, nat-operacao
- **atual**: ce-atual, nro-docto
- **ch-di**: declaracao-import
- **chave-aces-nf**: cod-chave-aces-nf-eletro
- **dctstt_ix10**: cod-estabel, ce-atual, nro-docto
- **disp-integr**: ts-disp-integr
- **dt-tp-estab**: dt-trans, cod-estabel
- **emitente**: cod-emitente, nro-docto, nff, ce-atual, sit-docum
- **est-origem**: cod-estabel, dt-trans
- **estab-dtemissao**: cod-estabel, dt-emissao
- **natoper**: nat-operacao
- **processamento**: ts-processamento
- **rma**: cod-rma
- **sit-wms-ext**: ind-sit-wms-ext
