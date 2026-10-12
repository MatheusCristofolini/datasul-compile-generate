# Tabela: repres

**Banco de Dados**: mg
**Label**: Representante
**Descrição**: Representantes
**Gerado em**: 16/05/2026, 18:18:40

## Campos

| Campo | Tipo | Label | Formato | Inicial | Obrig. | Include | Help |
| :--- | :--- | :--- | :--- | :--- | :--- | :--- | :--- |
| bairro | character | Bairro | x(030) |  | Sim |  | Nome do bairro |
| bloqueado-pagto | logical | Bloqueado Para Pagam | Sim/NÆo | no | Não |  |  |
| caixa-postal | character | Caixa Postal | X(10) |  | Sim |  | N£mero da caixa postal |
| calendario-pagto | character | Calend rio Para Paga | X(3) |  | Não |  | Calend rio Para Pagamento no Contas a Pagar |
| cep | character | CEP | x(12) |  | Sim |  | C¢digo de endereamento postal |
| cgc | character | CGC/CPF | x(18) |  | Não |  | N£mero do CGC no ministrio da fazenda |
| char-1 | character |  | x(100) |  | Não |  |  |
| char-2 | character |  | x(100) |  | Não |  |  |
| check-sum | character | Check-sum | x(20) |  | Não |  |  |
| cidade | character | Cidade | x(50) |  | Sim |  | Nome da cidade |
| cod-emitente | integer | C¢digo Fornecedor | >>>>>>>>9 | 0 | Não |  | C¢digo do Fornecedor |
| cod-formula | character | F¢rmula | x(12) |  | Sim |  | C¢digo F¢rmula |
| cod-portador-geracao-ad | integer | C¢digo Portador Gera | >>>>9 | 0 | Sim |  | C¢digo do Portador para GeraÆo AD |
| cod-rep | integer | Representante | >>>>9 | 0 | Sim |  | C¢digo do representante direto |
| cod-retenc-indeniz | integer | Cod RetenÆo IndenizaÆo | >>>>9 | 0 | Não |  | C¢digo de RetenÆo do Imposto de IndenizaÆo |
| cod-retencao | integer | Cod RetenÆo | >>>>9 | 0 | Não |  | C¢digo de retenÆo do imposto de renda |
| cod-tax | integer | C¢digo Imposto | >>>9 | 0 | Não |  | C¢digo do Imposto |
| cod-tax-indeniz | integer | Cod Imposto IndenizaÆo | >>>9 | 0 | Não |  | C¢digo do Imposto de IndenizaÆo |
| comis-direta | decimal | Percentual ComissÆo | >>9.99 | 0 | Sim |  | Informe o percentual de comissÆo do representante |
| comis-emis | decimal | ComissÆo EmissÆo | >>9.99 | 0 | Não |  | Informe o percentual de comissÆo na emissÆo do t¡tulo |
| comis-indir | decimal | ComissÆo Indireta | >>9.99 | 0 | Sim |  | Informe o percentual de comissÆo do representante indireto |
| comis-max | decimal | ComissÆo M xima | >>9.99 | 0 | Sim |  | Percentual m ximo de comissÆo direta do representante |
| comis-min | decimal | ComissÆo M¡nima | >>9.99 | 0 | Sim |  | Percentual m¡nimo de comissÆo direta do representante |
| comis-propor | logical | ComissÆo Proporcional | Sim/NÆo | yes | Não |  | ComissÆo Proporcional ao Pagamento do T¡tulo |
| complemento | character | Complemento | x(40) |  | Não |  | Complemento do endereo |
| data-1 | date |  | 99/99/9999 |  | Não |  |  |
| data-2 | date |  | 99/99/9999 |  | Não |  |  |
| dec-1 | decimal |  | ->>>>>>>>>>>9.99999999 | 0 | Não |  |  |
| dec-2 | decimal |  | ->>>>>>>>>>>9.99999999 | 0 | Não |  |  |
| dt-deslig | date | Data Desligamento | 99/99/9999 |  | Não |  | Validade Final do Representante |
| e-mail | character | E-mail | x(80) |  | Não |  |  |
| endereco | character | Endereo | x(40) |  | Sim |  | Informe o endereo |
| endereco_text | character | Endereo Completo | X(2000) |  | Não |  | Endereo Completo |
| estado | character | UF | x(004) |  | Sim |  | Unidade da FederaÆo |
| fc-codigo | integer | Matricula Funcionario | 99999999 | 0 | Não |  | Matricula do Funcionario |
| home-page | character | Home Page | x(40) |  | Não |  | Endereo Word Wide Web na Internet |
| idi-liber-pagto-comis-agent | integer | LiberaÆo Pagto ComissÆo | 9 | 1 | Sim | [adinc/i05ad229.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i05ad229.i) | LiberaÆo Pagamento ComissÆo Agente |
| idi-tip-base-comis-agent | integer | Tipo Base ComissÆo Agente | 9 | 1 | Sim | [adinc/i04ad229.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i04ad229.i) | Tipo Base ComissÆo Agente |
| idi-tip-comis-agent | integer | Tipo ComissÆo Agente | 9 | 1 | Sim | [adinc/i03ad229.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i03ad229.i) | Tipo ComissÆo Agente |
| ind-situacao | integer | SituaÆo Representante | >9 | 1 | Não | [adinc/i02ad242.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i02ad242.i) | Indicador da situaÆo do representante |
| ins-municipal | character | InscriÆo Municipal | X(19) |  | Sim |  | InscriÆo Municipal |
| inscr-est | character | InscriÆo Estadual | x(19) |  | Sim |  | InscriÆo Estadual |
| int-1 | integer |  | ->>>>>>>>>9 | 0 | Não |  |  |
| int-2 | integer |  | ->>>>>>>>>9 | 0 | Não |  |  |
| log-1 | logical |  | Sim/NÆo | no | Não |  |  |
| log-2 | logical |  | Sim/NÆo | no | Não |  |  |
| log-consid-repres-cotas | logical | Considera Representante Cotas | Sim/NÆo | yes | Não |  | Considera representante Cotas |
| log-interm | logical | Intermediador da venda | Sim/NÆo | no | Não |  | Intermediador da venda |
| mo-codigo | integer | Moeda | >9 | 0 | Não |  | Moeda do valor m¡nimo de comissÆo a pagar |
| natureza | integer | Natureza | >9 | 1 | Sim | [adinc/i03ad098.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i03ad098.i) | Indicador da natureza de operaÆo |
| nom-usuar-interm | character | Nome do intermediador | x(60) |  | Não |  | Nome do intermediador |
| nome | character | Nome | x(80) |  | Sim |  | Nome do Representante |
| nome-ab-reg | character | RegiÆo Abreviado | x(12) |  | Sim |  | RegiÆo de atuaÆo do representante |
| nome-abrev | character | Nome Abreviado | x(12) |  | Sim |  | Nome abreviado do representante |
| pais | character | Pa¡s | x(20) |  | Sim |  | Nome do Pa¡s |
| perc-abatimento | decimal | Perc ComissÆo Abatimento | >>9.99 | 0 | Não |  | Informe o percentual de ComissÆo sobre o Abatimento |
| perc-aire | decimal | % Adicional  IR | >9.99 | 0 | Sim |  | Percentual adicional de imposto de renda estadual |
| perc-ava | decimal | Perc ComissÆo AlteraÆo Valor | >>9.99 | 0 | Não |  | Informe o percentual de ComissÆo sobre AlteraÆo de Valor |
| perc-desconto | decimal | Perc  ComissÆo Desconto | >>9.99 | 0 | Não |  | Informe o percentual de ComissÆo sobre o Desconto |
| perc-juros | decimal | Perc ComissÆo Juros | >>9.99 | 0 | Não |  | Informe o percentual de ComissÆo sobre os Juros |
| perc-multa | decimal | Perc ComissÆo Multa | >>9.99 | 0 | Não |  | Informe o percentual de ComissÆo sobre a Multa |
| permissao | character | PermissÆo | x(72) | * | Sim |  | Usu rios do representante com permissÆo de visualizaÆo |
| rep-indireto | integer | Repres Indireto | >>>>9 | 0 | Sim |  | C¢digo do representante indireto |
| telef-modem | character | Telefone Modem | x(15) |  | Não |  | N£mero do telefone para conexÆo via modem |
| telefax | character | Telefax | x(15) |  | Sim |  | N£mero do fax do representante |
| telefone | character | Telefone | x(15) |  | Sim |  | N£mero do telefone para contato |
| telex | character | Telex | x(15) |  | Sim |  | N£mero do telex do representante |
| tipo-comis | integer | Tipo ComissÆo | 9 | 1 | Não | [adinc/i02ad229.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i02ad229.i) | ComissÆo sobre o L¡quido ou Bruto |
| tipo-repres | integer | Tipo Representantant | 9 | 1 | Não | [adinc/i01ad229.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/adinc/i01ad229.i) | Funcion rio ou Autnomo |
| vl-minimo-comis | decimal | Vl M¡n ComissÆo a Pagar | >>>,>>>,>>9.99 | 0 | Não |  | Valor m¡nimo de comissÆo a pagar |
| zip-code | character | Zip Code | x(12) |  | Não |  |  |

## Índices

- **codigo** (Primário, Único): cod-rep
- **abrev** (Único): nome-abrev
- **ch-regiao**: nome-ab-reg
- **indireto**: rep-indireto
- **nome**: nome
