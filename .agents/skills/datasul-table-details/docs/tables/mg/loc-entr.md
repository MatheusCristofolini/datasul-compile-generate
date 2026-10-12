# Tabela: loc-entr

**Banco de Dados**: mg
**Label**: Local de Entrega
**Descrição**: Arquivo de Endereos de Entrega por Cliente
**Gerado em**: 21/05/2026, 11:47:32

## Campos

| Campo | Tipo | Label | Formato | Inicial | Obrig. | Include | Help |
| :--- | :--- | :--- | :--- | :--- | :--- | :--- | :--- |
| bairro | character | Bairro | x(30) |  | Não |  | Bairro para entrega |
| caixa-postal | character | Caixa Postal | x(10) |  | Não |  | Caixa Postal |
| cd-jurisdicao | character | C¢digo Jurisdicao | X(20) |  | Não |  | C¢digo da JurisdiÆo |
| cdn-ext | integer | ID Externo | >>>>>>>>9 | 0 | Não |  | ID Externo do local de entrega do TMS/WMS |
| cep | character | CEP | x(12) |  | Não |  | CEP |
| cgc | character | CGCMF | x(19) |  | Não |  | CGCMF |
| char-1 | character |  | x(100) |  | Não |  |  |
| char-2 | character |  | x(100) |  | Não |  |  |
| check-sum | character | Check-sum | x(20) |  | Não |  |  |
| cidade | character | Cidade | x(50) |  | Não |  | Cidade para a entrega do pedido |
| cod-emite-entr | integer | Emitente Entrega | >>>>>>>>9 | 0 | Não |  | Emitente de entrega |
| cod-entrega | character | Entrega | x(12) |  | Sim |  | C¢digo do endereo de entrega |
| cod-rota | character | Rota | x(12) |  | Não |  | C¢digo da rota |
| cod-tax | integer | Cod Imposto | >>>9 | 0 | Não |  | C¢digo do imposto |
| cod-telefone | character | Telefone | x(20) |  | Não |  | Telefone |
| cod-tip-ent | integer | Tp Entrega | >>9 | 0 | Não |  | C¢digo do tipo de entrega |
| data-1 | date |  | 99/99/9999 |  | Não |  |  |
| data-2 | date |  | 99/99/9999 |  | Não |  |  |
| dec-1 | decimal |  | ->>>>>>>>>>>9.99999999 | 0 | Não |  |  |
| dec-2 | decimal |  | ->>>>>>>>>>>9.99999999 | 0 | Não |  |  |
| e-mail | character | Internet E-Mail | x(40) |  | Não |  | Endereo eletrnico do endereo de entrega |
| endereco | character | Endereo | x(40) |  | Não |  | Endereo |
| endereco_text | character | Endereo Completo | x(2000) |  | Não |  |  |
| estado | character | UF | x(4) |  | Não |  | Unidade da federaÆo |
| ins-estadual | character | InscriÆo Estadual | x(19) |  | Não |  | InscriÆo estadual |
| int-1 | integer |  | ->>>>>>>>9 | 0 | Não |  |  |
| int-2 | integer |  | ->>>>>>>>9 | 0 | Não |  |  |
| log-1 | logical |  | Sim/NÆo | no | Não |  |  |
| log-2 | logical |  | Sim/NÆo | no | Não |  |  |
| nom-cidad-cif | character | Cidade CIF | x(50) |  | Não |  | At que cidade o frete corre por conta do emitente |
| nom-razao-social | character | Nome/RazÆo Social | X(100) |  | Não |  | Nome/RazÆo Social |
| nome-abrev | character | Cliente | x(12) |  | Sim |  | Nome abreviado do cliente |
| nome-transp | character | Transportador | x(12) |  | Não |  | Nome do transportador |
| obs-entrega | character | ObservaÆo | x(2000) |  | Não |  | ObservaÆo |
| pais | character | Pa¡s | x(20) | Brasil | Não |  | Pa¡s |
| zip-code | character | CEP | x(12) |  | Não |  | CEP |

## Índices

- **ch-entrega** (Primário, Único): nome-abrev, cod-entrega
- **locentr_ix2**: cod-rota
- **locentr_ix3**: cdn-ext, nome-abrev
