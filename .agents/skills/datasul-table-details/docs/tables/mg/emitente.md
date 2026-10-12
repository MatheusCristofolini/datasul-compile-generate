# Tabela: emitente

**Banco de Dados**: mg
**Label**: Cliente/Fornecedor
**Descrição**: Emitentes
**Gerado em**: 11/05/2026, 15:58:18

## Campos

| Campo | Tipo | Label | Formato | Inicial | Obrig. | Include | Help |
| :--- | :--- | :--- | :--- | :--- | :--- | :--- | :--- |
| agencia | character | Agncia | x(8) |  | Sim |  | Agncia banc ria para efetuar os pagamentos |
| agente-retencao | logical | Agente RetenÆo | Sim/NÆo | no | Não |  | O emitente  agente de retenÆo ? |
| atividade | character | Ramo Atividade | X(12) |  | Sim |  | Ramo de atividade |
| bairro | character | Bairro | X(30) |  | Sim |  | Bairro do endereo do Emitente |
| bairro-cob | character | Bairro | x(30) |  | Sim |  | Bairro de cobrana/pagamento do emitente |
| bonificacao | decimal | Perc Desconto | >>9.999 | 0 | Sim |  | Percentual de desconto padrÆo do cliente |
| bx-acatada | integer | Baixa NÆo Acatada | >>9 | 0 | Sim |  | Prazo p/ emissÆo do relat¢rio p/ baixas nÆo acatadas |
| caixa-postal | character | Caixa Postal | x(10) |  | Não |  | Informe a caixa postal para correspondncia |
| calcula-multa | logical | Calcula Multa | Sim/NÆo | yes | Sim |  |  |
| categoria | character | Categoria | X(03) |  | Sim |  |  |
| cdn-atraso-max | integer | Atraso M ximo Dias | >>>9 | 0 | Não |  | Informe o atraso m ximo em dias |
| cep | character | CEP | x(12) |  | Sim |  | C¢digo de endereamento postal |
| cep-cob | character | CEP | x(12) |  | Não |  | CEP do endereo de cobrana/pagamento |
| cgc | character | CGC/CPF | x(19) |  | Não |  | CGC ou CIC do cliente/fornecedor |
| cgc-cob | character | CGC | x(19) |  | Sim |  | CGC do endereo de cobrana |
| char-1 | character |  | x(2000) |  | Não |  |  |
| char-2 | character |  | x(100) |  | Não |  |  |
| check-sum | character | Check-sum | x(20) |  | Não |  |  |
| cidade | character | Cidade | x(50) |  | Sim |  | Nome da cidade |
| cidade-cob | character | Cidade | x(50) |  | Sim |  | Cidade de cobrana/pagamento do emitente |
| cn-codigo | character | Condado | x(20) |  | Não |  | Condado |
| cod-banco | integer | Banco | 999 | 0 | Sim |  | C¢digo do banco junto a FEBRABAN |
| cod-cacex | character | CACEX | x(20) |  | Sim |  | C¢digo CACEX |
| cod-canal-venda | integer | Canal Venda | >>9 | 0 | Não |  | C¢digo do canal de venda |
| cod-classif-cliente | integer | Classif Cliente | >9 | 0 | Não | [adinc/i29ad098.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i29ad098.i) | C¢digo do n¡vel de classificaÆo do cliente |
| cod-classif-fornec | integer | Classif Fornec | >9 | 0 | Não | [adinc/i29ad098.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i29ad098.i) | C¢digo do n¡vel de classificaÆo do fornecedor |
| cod-cond-pag | integer | CondiÆo Pagamento | >>>9 | 0 | Não |  | CondiÆo de pagamento |
| cod-email-nfe | character | E-mail Nota Eletrnica | x(500) |  | Não |  | C¢digo E-mail Nota Eletrnica |
| cod-emitente | integer | C¢digo | >>>>>>>>9 | 0 | Sim |  |  |
| cod-entrega | character | Entrega | x(12) |  | Não |  | C¢digo do endereo de entrega |
| cod-gr-cli | integer | Grupo | >>>9 | 0 | Sim |  | C¢digo do grupo de cliente |
| cod-gr-forn | integer | Grupo | >9 | 0 | Não |  | C¢digo do grupo de fornecedores |
| cod-inscr-inss | character | Inscricao INSS | x(20) |  | Não |  | Indica N£mero da Inscricao no INSS |
| cod-isencao | integer | Cod IsenÆo | >>9 | 0 | Não |  | C¢digo de isenÆo do imposto |
| cod-mensagem | integer | Mensagem PadrÆo | >>>>9 | 0 | Sim |  | C¢digo da mensagem padrÆo |
| cod-parceiro-edi | integer | Parceiro EDI | >>>>>>>>9 | 0 | Não |  | Informe um c¢digo que identifique o emitente como parceiro EDI |
| cod-pulmao | character | PulmÆo | X(5) |  | Não |  | C¢digo do PulmÆo |
| cod-rep | integer | Representante | >>>>9 | 0 | Sim |  | Informe o representante que atende o cliente |
| cod-repres-imp | integer | Representante ImportaÆo | >>>>>>>>9 | 0 | Não |  | Informe Representante |
| cod-suframa | character | Cod SUFRAMA | x(20) |  | Sim |  | C¢digo SUFRAMA |
| cod-tax | integer | C¢digo Imposto | >>9 | 0 | Não |  | C¢digo do imposto |
| cod-tip-ent | integer | Entrega | >>9 | 0 | Não |  | C¢digo do tipo de entrega |
| cod-transp | integer | Transportador PadrÆo | >>,>>9 | 0 | Sim |  | C¢digo do transportador padrÆo |
| compr-period | decimal | Compras Per¡odo | >>>>,>>>,>>>,>>9.99 | 0 | Não |  | Valor das compras do per¡odo |
| conta-corren | character | Conta Corrente | x(20) |  | Sim |  | Conta corrente do emitente |
| contato | character | Contato | X(12) |  | Sim |  | Nome do contato no cliente/fornecedor |
| contrib-icms | logical | Contribuinte ICMS | Sim/NÆo | yes | Não |  | Contribuinte ICMS |
| cx-post-cob | character | Cx Postal | x(10) |  | Não |  | Caixa postal do endereo de cobrana/pagamento do emitente |
| dat-nasc | date | Data Nascimento | 99/99/9999 |  | Não |  | Data de Nascimento |
| dat-valid-suframa | date | Dt Validade Suframa | 99/99/9999 |  | Não |  | Data de Validade Suframa |
| data-1 | date |  | 99/99/9999 |  | Não |  |  |
| data-2 | date |  | 99/99/9999 |  | Não |  |  |
| data-implant | date | Data ImplantaÆo | 99/99/9999 | today | Sim |  | Data da implantaÆo |
| data-taxa | date | Data Taxa Financeira | 99/99/9999 | today | Não |  | Data da taxa financeira |
| dec-1 | decimal |  | ->>>>>>>>>>>9.99999999 | 0 | Não |  |  |
| dec-2 | decimal |  | ->>>>>>>>>>>9.99999999 | 0 | Não |  |  |
| dias-comp | integer | Dias CompensaÆo | >>9 | 0 | Não |  | Dias CompensaÆo |
| dt-atualiza | date | Data AtualizaÆo | 99/99/9999 |  | Não |  | Data da atualizaÆo. |
| dt-fim-cred | date | Fim Limite Crdito Adicional | 99/99/9999 |  | Não |  | Data final de validade do limite de crdito adicional |
| dt-lim-cred | date | Dt Lim Cred | 99/99/9999 |  | Não |  | Informe a data final de validade do limite de crdito |
| dt-ult-venda | date | Data éltima Venda | 99/99/9999 |  | Não |  | Data da £ltima nota fiscal emitida para o cliente |
| e-mail | character | E-mail | x(40) |  | Não |  | Endereo eletrnico na Internet |
| emissao-ped | integer | EmissÆo Pedido | >9 | 1 | Não | [adinc/i01ad098.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i01ad098.i) | Tipo de m¡dia na qual ser  gerada emissÆo pedido de compra |
| emite-bloq | logical | Emite Bloqueto | Sim/NÆo | no | Não |  | Determina se emite bloqueto para o t¡tulo |
| emite-etiq | logical | Emite Etiqueta | Sim/NÆo | no | Sim |  | Informa se deve ser emitida etiqueta para correspondncia |
| end-cobranca | integer | Cliente Cobrana | >>>>>>>>9 | 0 | Sim |  | C¢digo do cliente que ser  usado para cobrana |
| endereco | character | Endereo | X(40) |  | Sim |  | Endereo do cliente/fornecedor |
| endereco-cob | character | Endereo Cobrana | X(40) |  | Sim |  | Endereo de cobrana/pagamento do emitente |
| endereco-cob-text | character | Endereo Cobrana Completo | X(2000) |  | Não |  | Endereo Cobrana Completo |
| endereco2 | character | Endereo 2 | x(40) |  | Não |  | Segundo endereo |
| endereco_text | character | Endereo Completo | X(2000) |  | Não |  | Endereo Completo |
| esp-pd-venda | integer | Esp PadrÆo Ped Venda | 99 | 0 | Sim | [adinc/i06ad098.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i06ad098.i) | C¢digo da Espcie padrÆo de pedido de venda |
| estado | character | UF | x(4) |  | Sim |  | Unidade da FederaÆo |
| estado-cob | character | UF | x(04) |  | Sim |  | Unidade da FederaÆo de Cobrana/Pagamento do Emitente |
| estoque | integer | Estoque | 9 | 1 | Não | [adinc/i25ad098.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i25ad098.i) | Aloca / NÆo Aloca |
| flag-pag | integer | Pagamentos | 9 | 1 | Não | [adinc/i26ad098.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i26ad098.i) | SituaÆo para pagamentos |
| forn-exp | logical | Atende ExportaÆo | Sim/NÆo | no | Sim |  | Fornece servios para ExportaÆo? |
| gera-ad | logical | Gera Aviso Dbito | Sim/NÆo | no | Sim |  | Gera Aviso de Dbito para o cliente? |
| gera-difer | integer | Gera Difer Preo | 9 | 0 | Sim |  | Gera diferena de preo? |
| home-page | character | Home Page | x(40) |  | Não |  | Endereo Word Wide Web na Internet |
| hora-fim | integer | Hora Final Entrega | 99 | 0 | Não |  | Hora de trmino |
| hora-ini | integer | Hora Inicial Entrega | 99 | 0 | Não |  | Hora de in¡cio |
| hra-atualiz | character | Hora AtualizaÆo | 99:99:99 | 00:00:00 | Não |  | Hora |
| identific | integer | IdentificaÆo | >9 | 1 | Sim | [adinc/i02ad098.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i02ad098.i) | Tipo do emitente |
| idi-tributac-cofins | integer | Cod TributaÆo COFINS | 9 | 2 | Sim | [ininc/i04in176.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i04in176.i) | C¢digo de TributaÆo COFINS |
| idi-tributac-pis | integer | Cod TributaÆo PIS | 9 | 2 | Sim | [ininc/i04in176.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i04in176.i) | C¢digo de TributaÆo PIS |
| ind-abrange-aval | integer | Abrangncia AvaliaÆo | >9 | 1 | Não | [adinc/i24ad098.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i24ad098.i) | Abrangncia da avaliaÆo de crdito |
| ind-apr-cred | logical | Aprova Crdito | Sim/NÆo | no | Sim |  | Haver  AvaliaÆo de Crdito para aprovaÆo dos pedidos? |
| ind-atraso | integer | Indicador Atraso | 9 | 1 | Sim | [adinc/i18ad098.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i18ad098.i) | Indicador de Atraso |
| ind-aval | integer | AvaliaÆo | 9 | 1 | Sim | [adinc/i09ad098.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i09ad098.i) | M¢dulo onde ser  efetuada avaliaÆo de crdito |
| ind-aval-embarque | integer | Avalia Crdito Embarque | 9 | 1 | Não | [adinc/i09ad098.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i09ad098.i) | Critrio para avaliaÆo de crdito no embarque |
| ind-cre-cli | integer | Crdito | 9 | 1 | Sim | [adinc/i10ad098.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i10ad098.i) | Indicador de crdito |
| ind-cred-abat | logical | Crditos Abatimento | Sim/NÆo | no | Não |  | Utiliza crditos do contas a receber como abatimentos? |
| ind-dif-atrs-1 | integer | Atraso Infor Maior Calcul | 9 | 1 | Sim | [adinc/i19ad098.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i19ad098.i) | AÆo a tomar qdo atraso informado for maior que o calculado |
| ind-dif-atrs-2 | integer | Atraso Infor Menor Calcul | 9 | 1 | Sim | [adinc/i20ad098.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i20ad098.i) | AÆo a tomar qdo atraso informado for menor que o calculado |
| ind-div-atraso | integer | Divergncia Entregas Atraso | 9 | 1 | Sim | [adinc/i21ad098.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i21ad098.i) | AÆo a ser tomada em caso de divergncia |
| ind-emit-retencao | integer | Respons vel RetenÆo | >9 | 2 | Não | [adinc/i28ad098.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i28ad098.i) |  |
| ind-fat-par | logical | Faturamento Parcial | Sim/NÆo | yes | Sim |  | Pode haver atendimento parcial dos pedidos do cliente? |
| ind-lib-estoque | logical | Libera Estoque Sem AvaliaÆo | Sim/NÆo | no | Não |  | Libera estoque para alocar no pedido sem avaliar crdito? |
| ind-licenciador | logical | Licenciador | Sim/NÆo | no | Não |  | Indicador do licenciador |
| ind-moeda-tit | integer | Moeda | >9 | 0 | Não |  | Moeda para o t¡tulo |
| ind-rendiment | logical | Rendimento | Sim/NÆo | no | Não |  | C¢digo do rendimento na implantaÆo de documento |
| ind-sit-emitente | integer | SituaÆo Emitente | >9 | 1 | Não | [adinc/i27ad098.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i27ad098.i) |  |
| inf-complementar | character | InformaÆo Complementar | x(12) |  | Não |  | Permite registrar informaÆo complementar ao emitente |
| ins-banc | integer | InstruÆo Banc ria | >>9 | 0 | Não |  | InstruÆo banc ria a ser enviada na Cobrana Escritural |
| ins-est-cob | character | InscriÆo Estadual | x(19) |  | Sim |  | InscriÆo Estadual do endereo de Cobrana/Pagamento |
| ins-estadual | character | InscriÆo Estadual | X(19) |  | Sim |  | InscriÆo Estadual |
| ins-municipal | character | InscriÆo Municipal | X(19) |  | Sim |  | InscriÆo Municipal |
| insc-subs-trib | character | Inscr Aux Subst Tribut ria | x(19) |  | Não |  | InscriÆo auxiliar para substituiÆo tribut ria |
| int-1 | integer |  | ->>>>>>>>>9 | 0 | Não |  |  |
| int-2 | integer |  | ->>>>>>>>>9 | 0 | Não |  |  |
| istr | integer | Cod ISTR | 9 | 0 | Sim |  | C¢digo do Imposto Sobre Transportes |
| item-cli | logical | Item X Cliente | Sim/NÆo | no | Não |  | Criar relaÆo Item X Cliente automaticamente ? |
| lim-adicional | decimal | Lim Crdito Adicional | >>>,>>>,>>9.99 | 0 | Não |  | Limite de crdito adicional |
| lim-credito | decimal | Limite Crdito | >>>,>>>,>>9.99 | 0 | Sim |  | Crdito m ximo  disposiÆo do cliente |
| linha-produt | character | Linha Produto | X(08) |  | Sim |  | Linha de produto |
| log-1 | logical |  | Sim/NÆo | no | Não |  |  |
| log-2 | logical |  | Sim/NÆo | no | Não |  |  |
| log-beneficiario | logical | Integra Benef. AP | Sim/NÆo | no | Não |  | Integrar com o Contas a Pagar os dados do benefici rio (CPF) |
| log-calcula-pis-cofins-unid | logical | Calcula PIS / Cofins Por Unida | Sim/NÆo | no | Sim |  | Calcula PIS / Cofins Por Unidade |
| log-contribt-subst-interm | logical | Contribuinte Subst Intermed | Sim/NÆo | no | Sim |  | Indica se o fornecedor  um contribuinte substituto intermedi rio |
| log-controla-val-max-inss | logical | Controla Valor Maximo Inss | Sim/NÆo | no | Não |  | Indica se Controla Vl Max Inss |
| log-integr-totvs-colab-vendas | logical | IntegraÆo Totvs Colab Vendas | Sim/NÆo | no | Não |  | Habilita integraÆo com Totvs ColaboraÆo Vendas? |
| log-isenta-anexo | logical | Isenta obrigatoriedade de anexo no pedido | yes/no | no | Não |  |  |
| log-nf-eletro | logical | Recebe NF-e | Sim/NÆo | no | Não |  | Indica se o Cliente Recebe Nota Fiscal Eletrnica |
| log-optan-cr-presmdo-subst | logical | Optante Crd Presum Subs Trib | Sim/NÆo | no | Sim |  | Optante Crdito Presumido SubstituiÆo Tribut ria |
| log-optan-suspens-ipi | logical | Optante SuspensÆo IPI | Sim/NÆo | no | Sim |  | Optante SuspensÆo IPI |
| log-possui-nf-eletro | logical | Possui Nota Fiscal Eletrnica | Sim/NÆo | no | Sim |  | Indica se o fornecedor emite nota fiscal eletrnica |
| mod-prefer | integer | Modalidade | 9 | 1 | Sim | [adinc/i03ad209.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i03ad209.i) | Modalidade do Portador Preferencial |
| modalidade | integer | Modalidade Cobrana | 9 | 0 | Sim | [adinc/i03ad209.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i03ad209.i) | Informe a modalidade de cobrana |
| modalidade-ap | integer | Modalidade AP | 9 | 1 | Sim | [adinc/i03ad209.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i03ad209.i) | Modalidade Contas a pagar |
| moeda-libcre | integer | Moeda Limite Crdito | >9 | 0 | Não |  | Moeda limite de crdito |
| nat-ope-ext | character | Natureza Interestadual | x(06) |  | Não |  | Natureza de OperaÆo Interestadual |
| nat-operacao | character | Natureza OperaÆo | x(06) |  | Sim |  | C¢digo da natureza de operaÆo |
| natureza | integer | Natureza | >9 | 1 | Sim | [adinc/i03ad098.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i03ad098.i) | Indicador da natureza de operaÆo |
| nom-fantasia | character | Nome Fantasia | x(60) |  | Não |  | Nome Fantasia |
| nome-abrev | character | Nome Abreviado | X(12) |  | Sim |  | Nome abreviado do cliente/fornecedor |
| nome-emit | character | Nome | x(80) |  | Sim |  | Nome Completo do Emitente |
| nome-matriz | character | Matriz | x(12) |  | Sim |  | Nome Abreviado da Matriz a que Pertence o Cliente |
| nome-mic-reg | character | MicrorregiÆo | x(12) |  | Não |  | MicrorregiÆo de atuaÆo do representante |
| nome-tr-red | character | Transp Redespacho | x(12) |  | Não |  | Transportadora de Redespacho |
| nr-cheque-devol | integer | Nr Max Cheque Devol | >>9 | 0 | Não |  | N£mero m ximo de cheque devolvido |
| nr-copias-ped | integer | C¢pias Pedido Compra | >9 | 1 | Sim |  | N£mero de c¢pias do pedido de compra que deve ser impresso |
| nr-dias | integer | Num Dias | >>>>>>>9 | 0 | Não |  | N£mero de dias |
| nr-dias-atraso | integer | Dias Atraso | 9999 | 0 | Não |  | N£mero dias de atraso |
| nr-dias-taxa | integer | Dias Taxa Financeira | >>9 | 0 | Não |  | N£mero de dias da taxa financeira |
| nr-mesina | integer | Meses Inativo | >9 | 0 | Sim |  | N£mero m ximo de meses a ser aceito sem compras do cliente |
| nr-peratr | integer | Per¡odos Atraso | >9 | 0 | Sim |  | Durante quantos per¡odos nÆo deve haver atraso nos pagtos |
| nr-tab-progr | integer | Tab Progr | >>9 | 0 | Não |  | C¢digo da tabela progressiva imposto retido |
| nr-tabpre | character | Tabela Preos | x(8) |  | Sim |  | C¢digo da tabela de preos |
| nr-titulo | integer | N£mero T¡tulos | >>>>>>>9 | 0 | Não |  | N£mero de t¡tulos |
| obs-entrega | character | ObservaÆo | x(2000) |  | Não |  | Informaäes adicionais |
| observacoes | character | ObservaÆo | x(2000) |  | Sim |  | Informaäes adicionais |
| pais | character | Pa¡s | x(20) |  | Sim |  | Pa¡s |
| pais-cob | character | Pa¡s | x(20) |  | Não |  | Pa¡s de Cobrana |
| per-max-canc | decimal | % Max Cancel Saldo | >9.99 | 0 | Sim |  | Percentual que poder  ser faturado a mais nas seq dos pedidos |
| per-minfat | decimal | % Min Fat Parcial | >9.99 | 0 | Não |  | Percentual m¡nimo aceito para faturamento parcial |
| perc-fat-ped | integer | % Max Fat Pedido | >>9 | 0 | Sim |  | Percentual a ser faturado a mais nas seqncias do pedido |
| percent-verba | decimal | % Verba Publicidade | >>>9.99 | 0 | Sim |  | Percentual de verba de publicidade |
| percepcao | logical | PercepÆo | Sim/NÆo | no | Não |  | O emitente tem percepÆo ? |
| periodo-devol | integer | Per¡odo Cheque Devol | >,>>9 | 0 | Não |  | Per¡odo em dias |
| port-prefer | integer | Port Preferencial | >>>>9 | 0 | Não |  | Portador preferencial |
| portador | integer | Portador | >>>>9 | 0 | Sim |  | Portador para o qual ser  enviado o border ou cheque |
| portador-ap | integer | Portador AP | >>>>9 | 0 | Sim |  | Portador Contas a Pagar |
| prog-emit | logical | Prog | Sim/NÆo | no | Não |  |  |
| prox-ad | integer | Prox Aviso Dbito | >>>>>9 | 0 | Sim |  | Numero  do pr¢ximo aviso de debito a ser gerado |
| ramal | character | Ramal | x(05) |  | Sim |  | Ramal do contato |
| ramal-fac | character | Ramal | x(05) |  | Não |  |  |
| ramal-fax | character | Ramal | x(05) |  | Não |  | Ramal do telefax |
| ramal-modem | character | Ramal | x(07) |  | Não |  |  |
| recebe-inf-sci | logical | Recebe Informaäes SCI | Sim/NÆo | no | Não |  |  |
| rend-tribut | decimal | Rend Tribut vel | >>9.99 | 0 | Não |  |  |
| resumo-mp | integer | Resumo Multi-Planta | >9 | 2 | Sim | [adinc/i04ad098.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i04ad098.i) | SituaÆo do resumo do emitente |
| retem-pagto | logical | Retm Pagamento? | Sim/NÆo | no | Sim |  | RetenÆo de pis/cofins/csll ser  na implantaÆo ou no pagamento |
| short-name | character | Nome Abreviado | x(16) |  | Não |  | Nome abreviado emitente |
| taxa-financ | decimal | Taxa Financeira | >>9.99 | 0 | Sim |  | Taxa Financeira |
| telef-fac | character | Telefax | x(15) |  | Não |  | N£mero de telefone da pessoa de contato do emitente |
| telef-modem | character | Telefone Modem | x(15) |  | Não |  | N£mero de telefone do emitente |
| telefax | character | Telefax | x(15) |  | Sim |  | N£mero do telefone para fax |
| telefone | character | Telefone | x(15) |  | Sim |  | N£mero do Telefone |
| telex | character | Telex | x(15) |  | Sim |  | N£mero do telex |
| tip-cob-desp | integer | Cobrana Desp | 9 | 1 | Não | [diinc/i04di072.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/diinc/i04di072.i) | Como serÆo cobradas as despesas |
| tp-desp-padrao | integer | Tp Desp PadrÆo | >>9 | 0 | Não |  | Tipo de despesa utilizada como padrÆo para o Contas a Pagar |
| tp-inspecao | integer | Tp InspeÆo | 9 | 2 | Não | [adinc/i14ad098.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i14ad098.i) | Tipo de inspeÆo |
| tp-pagto | integer | Forma Pgto | 99 | 1 | Não | [adinc/i22ad098.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i22ad098.i) |  |
| tp-qt-prg | integer | Tipo Qtd | 9 | 1 | Sim | [adinc/i23ad098.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i23ad098.i) | Tipo de quantidade |
| tp-rec-padrao | integer | Receita PadrÆo | >>9 | 0 | Não |  | Tipo de receita utilizada como padrÆo para o Contas a Receber |
| tr-ar-valor | integer | Notas Entrada | >9 | 1 | Sim | [adinc/i05ad098.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i05ad098.i) | Trunca ou arredonda valores das NF de entrada calculados no recebimento? |
| user-libcre | character | Usu rio Lib Cred | x(12) |  | Sim |  | Usu rio autorizado a efetuar liberaÆo de crdito |
| utiliza-verba | logical | Utiliza Verba Public | Sim/NÆo | no | Sim |  | Se cliente utiliza verba de publicidade |
| val-quota-media | decimal | Valor Quota Mdia | >>>,>>>,>>9.9999 | 0 | Não |  | Valor da quota mdia mensal |
| valor-minimo | decimal | Valor Minimo | >>,>>>,>>>,>>9.99 | 0 | Não |  |  |
| ven-domingo | integer | Vencto Domingo | 9 | 1 | Sim | [adinc/i17ad098.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i17ad098.i) | Vencimento Domingo |
| ven-feriado | integer | Vencto Feriado | 9 | 1 | Sim | [adinc/i17ad098.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i17ad098.i) | Vencimento Feriado |
| ven-sabado | integer | Vencto S bado | 9 | 1 | Sim | [adinc/i17ad098.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i17ad098.i) | Vencimento S bado |
| vencto-dia-nao-util | logical | Vencimento Igual Data Fluxo | Sim/NÆo | yes | Sim |  | Vencimento  igual a Data de Fluxo |
| vl-max-devol | decimal | Vl Max Ch Devol | >>>,>>>,>>9.99 | 0 | Não |  | Valor m ximo a ser aceito para cheque devolvido |
| vl-min-ad | decimal | Vl Min GeraÆo AD | >>,>>>,>>>,>>9.99 | 0 | Não |  | Valor m¡nimo para geraÆo de Aviso de Dbito |
| zip-cob-code | character | Zip Code | x(12) |  | Não |  | Zip Code do endereo de cobrana |
| zip-code | character | Zip Code | x(12) |  | Não |  |  |

## Índices

- **codigo** (Primário, Único): cod-emitente
- **cgc**: cgc
- **ch-cobranca**: end-cobranca, nome-abrev
- **ch-conpag**: cod-cond-pag
- **ch-matriz**: nome-matriz
- **ch-natope**: nat-operacao
- **ch-pais**: pais
- **ch-portador**: portador, modalidade
- **ch-prog-emit**: prog-emit, cod-emitente
- **ch-short-name**: short-name
- **emtclnfr-19**: cidade, cod-emitente
- **emtclnfr-20**: nome-tr-red
- **emtclnfr-21**: dt-atualiza, hra-atualiz
- **gr-mic-cli**: cod-gr-cli, nome-mic-reg, cod-emitente
- **grupo-cli**: cod-gr-cli, cod-emitente
- **grupo-fornec**: cod-gr-forn, cod-emitente
- **micro-reg**: nome-mic-reg, cod-emitente
- **nome** (Único): nome-abrev
- **repres**: cod-rep, cod-emitente
- **transporte**: cod-transp, cod-emitente
