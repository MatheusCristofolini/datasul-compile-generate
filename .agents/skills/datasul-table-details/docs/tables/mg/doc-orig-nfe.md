# Tabela: doc-orig-nfe

**Banco de Dados**: mg
**Label**: Documento Origem Nota Entrada
**Descrição**: Documento de Origem Nota Entrada
**Gerado em**: 21/07/2026, 15:01:10

## Campos

| Campo | Tipo | Label | Formato | Inicial | Obrig. | Include | Help |
| :--- | :--- | :--- | :--- | :--- | :--- | :--- | :--- |
| aliq-icms-ret | decimal | Al¡quota ICMS RetenÆo | >>9.99 | 0 | Não |  | Al¡quota ICMS RetenÆo |
| bairro | character | Bairro | x(60) |  | Não |  | Bairro |
| bairro-dest | character | Bairro Destino | x(60) |  | Não |  | Bairro Destino |
| bairro-ent | character | Bairro Entrega | x(60) |  | Não |  | Bairro Entrega |
| bairro-ret | character | Bairro Retirada | x(60) |  | Não |  | Bairro Retirada |
| balsa | character |  | x(20) |  | Não |  |  |
| base-icms | decimal | Base ICMS | >>>,>>>,>>>,>>>,>>9.99 | 0 | Não |  | Base ICMS |
| base-icms-ret | decimal | Base ICMS Retido | >>>,>>>,>>>,>>>,>>9.99 | 0 | Não |  | Base ICMS Retido |
| base-icms-subs | decimal | Base ICMS Substituto | >>>,>>>,>>>,>>>,>>9.99 | 0 | Não |  | Base ICMS Substituto |
| base-irrf | decimal | Base ICMS | >>>,>>>,>>>,>>>,>>9.99 | 0 | Não |  | Base ICMS |
| base-iss | decimal | Base ISS | >>>,>>>,>>>,>>>,>>9.99 | 0 | Não |  | Base ISS |
| base-prev-ret | decimal | Base RetenÆo Previdncia Social | >>>,>>>,>>>,>>>,>>9.99 | 0 | Não |  | Base RetenÆo Previdncia Social |
| cana-mes-ano-ref | character |  | x(6) |  | Não |  |  |
| cana-qtd-tot-ant | decimal |  | ->.9999999999 | 0 | Não |  |  |
| cana-qtd-tot-geral | decimal |  | ->.9999999999 | 0 | Não |  |  |
| cana-qtd-tot-mes | decimal |  | ->.9999999999 | 0 | Não |  |  |
| cana-safra | character |  | x(9) |  | Não |  |  |
| cana-vl-fornecimentos | decimal |  | ->,>>>,>>>,>>>,>>9.99 | 0 | Não |  |  |
| cana-vl-liq-fornecimentos | decimal |  | ->,>>>,>>>,>>>,>>9.99 | 0 | Não |  |  |
| cana-vl-tot-ded | decimal |  | ->,>>>,>>>,>>>,>>9.99 | 0 | Não |  |  |
| cep | character | CEP | x(15) |  | Não |  | CEP |
| cep-destino | character | CEP Destino | x(15) |  | Não |  | CEP Destino |
| cfop-ret | character | CFOP | x(4) |  | Não |  | CFOP |
| ch-acesso-comp-nfe | character | Chave Acesso | x(60) |  | Sim |  | Chave Acesso Completa |
| ch-acesso-nfe | integer | Chave Acesso | 999999999 | 0 | Não |  | Chave Acesso |
| char-1 | character |  | x(100) |  | Não |  |  |
| char-2 | character |  | x(100) |  | Não |  |  |
| cidade-fato-gerador | character | Cidade fato gerador CBS/IBS | x(50) |  | Não |  |  |
| cnae-fiscal | character | CNAE | x(12) |  | Não |  | CNAE |
| cnpj | character | CNPJ | x(14) |  | Não |  |  |
| cnpj-destino | character | CNPJ Destino | x(14) |  | Não |  | CNPJ Destino |
| cnpj-emissor | character | CNPJ Emissor | x(14) |  | Não |  | CNPJ Emissor |
| cnpj-entrega | character | CNPJ Entrega | x(14) |  | Não |  | CNPJ Entrega |
| cnpj-intermediador | character | CNPJ Intermediador | x(14) |  | Não |  |  |
| cnpj-retirada | character | CNPJ Retirada | x(14) |  | Não |  | CNPJ Retirada |
| cnpj-transp | character | CNPJ Transportadora | x(14) |  | Não |  | CNPJ Transportadora |
| cod-cond-pag | character | CondiÆo de Pagamento | x(1) |  | Não |  | CondiÆo de Pagamento |
| cod-dv | character | Digito verificador | x(1) |  | Não |  | Digito verificador |
| cod-emitente | integer | Emitente | >>>>>>>>9 | 0 | Sim |  | C¢digo do Emitente |
| cod-estabel | character | Estabelecimento | x(5) |  | Não |  | C¢digo do estabelecimento. |
| cod-fatura | character | N£mero da Fatura | x(60) |  | Não |  | N£mero da Fatura |
| cod-finalidade | character | C¢digo Finalidade | x(1) |  | Não |  | C¢digo Finalidade |
| cod-munic-fato-ger | integer | Fato gerador CBS/IBS | >>>>>>9 | 0 | Não |  |  |
| cod-municipio | integer | Munic¡pio | 9999999 | 0 | Não |  | Munic¡pio |
| cod-municipio-dest | integer | C¢digo Municipio Destino | 9999999 | 0 | Não |  | C¢digo Municipio Destino |
| cod-municipio-end | integer | C¢digo Municipio | 9999999 | 0 | Não |  | C¢digo Municipio |
| cod-municipio-ent | integer | Munic¡pio Entrega | 9999999 | 0 | Não |  | C¢digo Munic¡pio de Entrega |
| cod-municipio-fg | integer | C¢digo Municipio Fato Gerador | 9999999 | 0 | Não |  | C¢digo Municipio Fato Gerador |
| cod-municipio-ret | integer | C¢digo Municipio Retirada | 9999999 | 0 | Não |  | C¢digo Municipio Retirada |
| cod-municipio-transp | integer | C¢digo Municipio Transportadora | 9999999 | 0 | Não |  | C¢digo Municipio Transportadora |
| cod-natur-operac | character | Natureza OperaÆo | x(06) |  | Não |  | Natureza da operaÆo |
| cod-observa | integer | ObservaÆo | 9 | 1 | Não | [ininc/i03in090.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i03in090.i) | C¢digo da ObservaÆo da Nota Fiscal |
| cod-pais | integer | C¢digo Pa¡s | >>>9 | 0 | Não |  | C¢digo Pa¡s |
| cod-pais-dest | integer | C¢digo Pa¡s Destino | >>>9 | 0 | Não |  | C¢digo Pa¡s Destino |
| cod-reg-trib | character | Cod Regime Trib | x(1) |  | Não |  |  |
| cod-rntc | character | Registro Nacional de Transportador de Carga | x(20) |  | Não |  | Registro Nacional de Transportador de Carga |
| cod-rntc-reboque | character | Registro Nacional de Transportador de Carga | x(20) |  | Não |  | Registro Nacional de Transportador de Carga |
| cod-tipo-nf-cred-deb | character | Tipo Nota Crdito/Dbito | x(02) |  | Não |  | Tipo Nota Crdito/Dbito |
| cod-usuar-proces | character | Usu rio GeraÆo | x(12) |  | Não |  | Usu rio £ltimo processamento |
| complemento | character | Complemento | x(60) |  | Não |  | Complemento |
| complemento-dest | character | Complemento Destino | x(60) |  | Não |  | Complemento Destino |
| complemento-ent | character | Complemento Entrega | x(60) |  | Não |  | Complemento Entrega |
| complemento-ret | character | Complemento Retirada | x(60) |  | Não |  | Complemento Retirada |
| cpf | character | CPF | x(11) |  | Não |  | CPF |
| cpf-destino | character | CPF Destino | x(11) |  | Não |  | CPF Destino |
| cpf-retirada | character |  | x(11) |  | Não |  |  |
| cpf-transp | character | CPF Transportadora | x(11) |  | Não |  | CPF Transportadora |
| dat-process | date | Data Processamento | 99/99/9999 |  | Não |  | Data Processamento |
| data-1 | date |  | 99/99/9999 |  | Não |  |  |
| data-2 | date |  | 99/99/9999 |  | Não |  |  |
| data-hr-cont | character | Data Hora Contigencia | x(19) |  | Não |  |  |
| dec-1 | decimal | Livre 1 | ->>>>>>>>>>>9.99999999 | 0 | Não |  | Valor Livre 1 |
| dec-2 | decimal | Livre 2 | ->>>>>>>>>>>9.99999999 | 0 | Não |  | Valor Livre 2 |
| dt-emissao | date | Data EmissÆo | 99/99/9999 |  | Não |  | Data EmissÆo |
| dt-emissao-dar | date | Data EmissÆo DAR | 99/99/9999 |  | Não |  | Data EmissÆo DAR |
| dt-entrada | date | Data Entrada | 99/99/9999 |  | Não |  | Data Entrada |
| dt-pag-dar | date | Data Pag. DAR | 99/99/9999 |  | Não |  | Data Pag. DAR |
| dt-prev-entrega | date | Data PrevisÆo Entrega | 99/99/9999 |  | Não |  |  |
| dt-transacao | date | Data TransaÆo | 99/99/9999 |  | Não |  | Data TransaÆo |
| email-dest | character |  | x(60) |  | Não |  |  |
| end-transp | character | Endereo Transportadora | x(60) |  | Não |  | Endereo Transportadora |
| fone | character | Telefone | x(15) |  | Não |  | Telefone Emitente |
| fone-destino | character | Telefone Destino | x(15) |  | Não |  | Telefone Destino |
| fone-emit | character | Telefone Emitente | x(15) |  | Não |  | Telefone Emitente |
| forma-emissao | character | Forma de EmissÆo | x(1) |  | Não |  | Forma de EmissÆo |
| forma-imp | character | Formato de impressÆo | x(1) |  | Não |  | Formato de impressÆo |
| hr-entrada | character | Hora Entrada | x(8) |  | Não |  |  |
| hra-proces | character | Hora Processamento | 99:99:99 |  | Não |  | Hora de Processamento |
| id-cad-intermediador | character | Identificador cadastro no Intermediador | x(60) |  | Não |  |  |
| idi-orig-trad | integer | Origem Documento | 9 | 0 | Sim |  | Origem Documento |
| idi-presenca | integer | Indicador Presena | >9 | 0 | Não |  |  |
| idi-sit-diverg | integer | SItuaÆo das divergncias | >9 | 0 | Não |  | SItuaÆo divergncias:  0-Desativada; 1-Pendentes; 2-Sem divergncias; 3-Resolvidas; 4-NÆo se aplica |
| idi-situacao | integer | SituaÆo NF-e | 9 | 0 | Não | [ininc/i01in847.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i01in847.i) | SituaÆo NF-e |
| idi-tip-operac | integer | Tipo OperaÆo | >9 | 0 | Não |  | Tipo de operaÆo |
| inf-adicionais | character | Informaäes Adicionais | x(2000) |  | Não |  | Informaäes Adicionais |
| inf-complement | character | Informaäes Complementares | x(5000) |  | Não |  | Informaäes Complementares |
| inf-contrato | character | InformaÆo do Contrato | x(60) |  | Não |  | InformaÆo do Contrato |
| inf-pedido | character | InformaÆo do Pedido | x(60) |  | Não |  | InformaÆo do Pedido |
| insc-estad-subs-dest | character | InscriÆo Estadual Destino | x(14) |  | Não |  | InscriÆo Estadual Destino |
| insc-estadual | character | InscriÆo Estadual | x(14) |  | Não |  | InscriÆo Estadual |
| insc-estadual-dest | character | InscriÆo Estadual Destino | x(14) |  | Não |  | InscriÆo Estadual Destino |
| insc-estadual-subs | character | InscriÆo Estadual | x(14) |  | Não |  | InscriÆo Estadual |
| insc-estadual-transp | character | InscriÆo Estadual Transportadora | x(14) |  | Não |  | InscriÆo Estadual Transportadora |
| insc-municipal | character | InscriÆo Municipal | x(15) |  | Não |  | InscriÆo Municipal |
| int-1 | integer |  | ->>>>>>>9 | 0 | Não |  |  |
| int-2 | integer |  | ->>>>>>>9 | 0 | Não |  |  |
| localiz-embarque | character | LocalizaÆo Embarque | x(60) |  | Não |  | LocalizaÆo Embarque |
| log-1 | logical | Livre 1 | Sim/NÆo | no | Não |  | L¢gico Livre 1 |
| log-2 | logical | Livre 2 | Sim/NÆo | no | Não |  | L¢gico Livre 2 |
| log-confer | logical | Conferido | Sim/NÆo | no | Não |  | Conferido |
| log-consid-ender-nf-saida | logical | Consid End NF Sa¡da | Sim/NÆo | no | Não |  | Considera Endereco Nota fiscal Sa¡da |
| log-intermediador | logical | Indicador Intermediador | yes/no | no | Não |  |  |
| log-metric-env-ls | logical | Mtricas enviadas LS | Sim/Nao | Nao | Não |  | As mtricas foram enviadas para o LS |
| log-multi-cfop | logical | M£ltiplas CFOPs | yes/no | no | Não |  | M£ltiplas CFOPs |
| log-procmto | logical | Em processamento | Sim/NÆo | no | Não |  | Em processamento |
| logradouro | character | Logradouro | x(60) |  | Não |  | Logradouro |
| logradouro-dest | character | Logradouro Destino | x(60) | no | Não |  | Logradouro Destino |
| logradouro-ent | character | Logradouro Entrega | x(60) | no | Não |  | Logradouro Entrega |
| logradouro-ret | character | Logradouro Retirada | x(60) | no | Não |  | Logradouro Retirada |
| matr-agente | character | matr-agente | x(60) |  | Não |  | matr-agente |
| mod-doc-fisc | character | Modelo Documento Fiscal | x(2) |  | Não |  | Modelo Documento Fiscal |
| mod-frete | character | Modalidade Frete | x(1) |  | Não |  | Modalidade Frete |
| nat-oper-comp | character | Nat Complementar | x(6) |  | Não |  | Nat Complementar |
| nom-agente | character | Nome Agente | x(60) |  | Não |  | Nome agente |
| nom-municipio-dest | character | Nome Munic¡pio Destino | x(60) |  | Não |  | Nome Munic¡pio Destino |
| nom-municipio-end | character | Nome Munic¡pio | x(60) |  | Não |  | Nome Munic¡pio |
| nom-municipio-ent | character | Nome Munic¡pio Entrega | x(60) |  | Não |  | Nome Munic¡pio Entrega3 |
| nom-municipio-ret | character | Nome Munic¡pio Retirada | x(60) |  | Não |  | Nome Munic¡pio Retirada |
| nom-municipio-transp | character | Nome Munic¡pio | x(60) |  | Não |  | Nome Munic¡pio |
| nom-pais | character | Nome Pa¡s | x(60) |  | Não |  | Nome Pa¡s |
| nom-pais-dest | character | Nome Pa¡s Destino | x(60) |  | Não |  | Nome Pa¡s Destino |
| nome-fantasia | character | Nome Fantasia | x(60) |  | Não |  | Nome Fantasia |
| nota-empenho | character | Nota de Empenho | x(17) |  | Não |  | Nota de Empenho |
| nro-docto | character | Documento | x(16) |  | Sim |  | N£mero do Documento de Entrada |
| num-dar | character | N£mero Doc. ArrecadaÆo Receita | x(60) |  | Não |  | N£mero Doc. ArrecadaÆo Receita |
| num-end-dest | character | N£mero Endereo Destino | x(60) |  | Não |  | N£mero endereo destino |
| num-end-emit | character | N£mero endereo emitente | x(60) |  | Não |  | N£mero endereo emitente |
| num-end-ent | character | N£mero endereo entrega | x(60) |  | Não |  | N£mero endereo entrega |
| num-end-ret | character | N£mero endereo retirada | x(60) |  | Não |  | N£mero endereo retirada |
| obs-cont | character | ObservaÆo Contribuinte | x(20) |  | Não |  | ObservaÆo Contribuinte |
| obs-cont-txt | character | Texto ObservaÆo Contribuinte | x(60) |  | Não |  | Texto  ObservaÆo Contribuinte |
| obs-fisco | character | ObservaÆo Fisco | x(20) |  | Não |  | ObservaÆo Fisco |
| obs-fisco-txt | character | Texto ObservaÆo Fisco | x(60) |  | Não |  | Texto ObservaÆo Fisco |
| observ-compar | character | Observaäes comparativo | x(1000) |  | Não |  |  |
| org-emissor | character | OrgÆo Emissor | x(60) |  | Não |  | OrgÆo Emissor |
| placa | character | Placa | x(8) |  | Não |  | Placa |
| placa-reboque | character | Placa | x(8) |  | Não |  | Placa |
| proc-emissao | character | Processo EmissÆo | x(1) |  | Não |  | Processo EmissÆo |
| razao-social | character | RazÆo Social | x(60) |  | Não |  | RazÆo Social |
| razao-social-dest | character | RazÆo Social Destino | x(60) |  | Não |  | RazÆo Social Destino |
| razao-social-transp | character | RazÆo Social Transportadora | x(60) |  | Não |  | RazÆo Social Transportadora |
| repemit | character | RepartiÆo Fiscal Emitente | x(60) |  | Não |  | RepartiÆo Fiscal Emitente |
| serie-docto | character | Srie | x(5) |  | Sim |  | Srie do documento |
| tipo-amb | character | IdentificaÆo Ambiente | x(1) |  | Não |  | IdentificaÆo Ambiente |
| tp-nf | character | Tipo Nota Fiscal Entrada | x(1) |  | Não |  | C¢digo Tipo Nota Fiscal Entrada |
| uf | character | UF | x(2) |  | Não |  | UF |
| uf-avulsa | character | UF Avulsa | x(8) |  | Não |  | UF Avulsa |
| uf-destino | character | UF Destino | x(2) |  | Não |  | UF Destino |
| uf-embarque | character | UF Embaque | x(2) |  | Não |  | UF Embaque |
| uf-end | character | UF Emitente | x(02) |  | Não |  | UF Emitente |
| uf-entrega | character | UF Entrega | x(2) |  | Não |  | UF Entrega |
| uf-fato-gerador | character | UF fato gerador CBS/IBS | x(04) |  | Não |  |  |
| uf-placa | character | UF Placa | x(2) |  | Não |  | UF Placa |
| uf-reboque | character | UF Reboque | x(2) |  | Não |  | UF Reboque |
| uf-retirada | character | UF Retirada | x(2) |  | Não |  | UF Retirada |
| uf-transp | character | UF Transportadora | x(2) |  | Não |  | UF Transportadora |
| vagao | character |  | x(20) |  | Não |  |  |
| val-fcp | decimal | Valor do FCP | ->>,>>>,>>>,>>9.99 | 0 | Não |  | Valor do FCP |
| val-fcp-st | decimal | Valor do FCP ST | ->>,>>>,>>>,>>9.99 | 0 | Não |  | Valor do FCP ST |
| val-fcp-st-antecip | decimal | Valor do FCP ST Antecipado | ->>,>>>,>>>,>>9.99 | 0 | Não |  | Valor do FCP ST Antecipado |
| valor-cofins | decimal | Valor Total do COFINS | >>>,>>>,>>>,>>>,>>9.99 | 0 | Não |  | Valor Total do COFINS |
| valor-cofins-iss | decimal | Valor COFINS Servios | >>>,>>>,>>>,>>>,>>9.99 | 0 | Não |  | Valor COFINS Servios |
| valor-cofins-ret | decimal | Valor COFINS Retido | >>>,>>>,>>>,>>>,>>9.99 | 0 | Não |  | Valor COFINS Retido |
| valor-csll-ret | decimal | Valor CSLL Retido | >>>,>>>,>>>,>>>,>>9.99 | 0 | Não |  | Valor CSLL Retido |
| valor-dar | decimal | Valor DAR | >>>>>>>>>>>9,99 | 0 | Não |  | Valor DAR |
| valor-desc-fatura | decimal | Valor Desconto Fatura | >>>,>>>,>>>,>>>,>>9.99 | 0 | Não |  | Valor Desconto Fatura |
| valor-desconto | decimal | Valor Desconto | >>>,>>>,>>>,>>>,>>9.99 | 0 | Não |  | Valor Desconto |
| valor-frete | decimal | Valor Frete | >>>,>>>,>>>,>>>,>>9.99 | 0 | Não |  | Valor Frete |
| valor-icms | decimal | Valor ICMS | >>>,>>>,>>>,>>>,>>9.99 | 0 | Não |  | Valor ICMS |
| valor-icms-ret | decimal | Valor ICMS Retido | >>>,>>>,>>>,>>>,>>9.99 | 0 | Não |  | Valor ICMS Retido |
| valor-icms-subs | decimal | Valor ICMS Substituto | >>>,>>>,>>>,>>>,>>9.99 | 0 | Não |  | Valor ICMS Substituto |
| valor-ii | decimal | Valor Total do II | >>>,>>>,>>>,>>>,>>9.99 | 0 | Não |  | Valor Total do II |
| valor-ipi | decimal | Valor Total do IPI | >>>,>>>,>>>,>>>,>>9.99 | 0 | Não |  | Valor Total do IPI |
| valor-irrf | decimal | Valor IRRF | >>>,>>>,>>>,>>>,>>9.99 | 0 | Não |  | Valor IRRF |
| valor-iss | decimal | Valor ISS | >>>,>>>,>>>,>>>,>>9.99 | 0 | Não |  | Valor ISS |
| valor-liq-fatura | decimal | Valor L¡quido Fatura | >>>,>>>,>>>,>>>,>>9.99 | 0 | Não |  | Valor L¡quido Fatura |
| valor-orig-fatura | decimal | Valor Original Fatura | >>>,>>>,>>>,>>>,>>9.99 | 0 | Não |  | Valor Original Fatura |
| valor-outros | decimal | Valor Outros | >>>,>>>,>>>,>>>,>>9.99 | 0 | Não |  | Valor Outros |
| valor-pis | decimal | Valor Total do PIS | >>>,>>>,>>>,>>>,>>9.99 | 0 | Não |  | Valor Total do PIS |
| valor-pis-iss | decimal | Valor PIS Servios | >>>,>>>,>>>,>>>,>>9.99 | 0 | Não |  | Valor PIS Servios |
| valor-pis-ret | decimal | Valor PIS Retido | >>>,>>>,>>>,>>>,>>9.99 | 0 | Não |  | Valor PIS Retido |
| valor-prev-ret | decimal | Valor RetenÆo Previdncia Social | >>>,>>>,>>>,>>>,>>9.99 | 0 | Não |  | Valor RetenÆo Previdncia Social |
| valor-produto | decimal | Valor Total Produtos | >>>,>>>,>>>,>>>,>>9.99 | 0 | Não |  | Valor Total Produtos |
| valor-seguro | decimal | Valor Seguro | >>>,>>>,>>>,>>>,>>9.99 | 0 | Não |  | Valor Seguro |
| valor-serv-ret-trans | decimal | Valor Servio | >>>,>>>,>>>,>>>,>>9.99 | 0 | Não |  | Valor Servio |
| valor-tot-iss | decimal | Valor Total ISS | >>>,>>>,>>>,>>>,>>9.99 | 0 | Não |  | Valor Total ISS |
| valor-tot-nf-rt | decimal | Valor Total NF com CBS/IBS/IS | ->>>,>>>,>>>,>>>,>>9.99 | 0 | Não |  |  |
| valor-total | decimal | Valor Total | >>>,>>>,>>>,>>>,>>9.99 | 0 | Não |  | Valor Total |
| versao-proc | character | VersÆo processo emissÆo | x(20) |  | Não |  | VersÆo processo emissÆo |
| x-justif | character | Justificativa Contigencia | x(256) |  | Não |  |  |

## Triggers

| Evento | Procedure | Link |
| :--- | :--- | :--- |
| Create | database/tgin/tcp/tcin847.p | [Abrir Fonte](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/database/tgin/tcp/tcin847.p) |
| Delete | database/tgin/tdp/tdin847.p | [Abrir Fonte](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/database/tgin/tdp/tdin847.p) |
| Write | database/tgin/twp/twin847.p | [Abrir Fonte](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/database/tgin/twp/twin847.p) |

## Índices

- **unico** (Primário, Único): ch-acesso-comp-nfe, idi-orig-trad
- **dctrgnf_ix4**: log-procmto
- **dctrgnf_ix5**: log-confer
- **doc-orig-nfe-compar**: idi-sit-diverg
- **monitor-nfe**: idi-situacao, idi-orig-trad, cod-emitente, cod-estabel, serie-docto, nro-docto, dt-emissao, dt-transacao
- **relat**: cod-emitente, cod-estabel, serie-docto, nro-docto, dt-emissao, dt-transacao, idi-orig-trad
