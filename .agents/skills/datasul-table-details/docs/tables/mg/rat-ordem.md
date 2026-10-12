# Tabela: rat-ordem

**Banco de Dados**: mg
**Label**: Rateio do Receb entre Div. Ord
**Descrição**: Rateio do Recebimento entre diversas Ordens
**Gerado em**: 20/07/2026, 10:00:57

## Campos

| Campo | Tipo | Label | Formato | Inicial | Obrig. | Include | Help |
| :--- | :--- | :--- | :--- | :--- | :--- | :--- | :--- |
| char-1 | character |  | x(100) |  | Não |  |  |
| char-2 | character |  | x(100) |  | Não |  |  |
| check-sum | character | Check-sum | x(20) |  | Não |  |  |
| cod-emitente | integer | Emitente | >>>>>>>>9 | 0 | Sim |  |  |
| data-1 | date |  | 99/99/9999 |  | Não |  |  |
| data-2 | date |  | 99/99/9999 |  | Não |  |  |
| dec-1 | decimal |  | ->>>>>>>>>>>9.99999999 | 0 | Não |  |  |
| dec-2 | decimal |  | ->>>>>>>>>>>9.99999999 | 0 | Não |  |  |
| encerrada | logical | Encerrada | Sim/NÆo | no | Não |  | Ordem encerrada |
| int-1 | integer |  | ->>>>>>>>>9 | 0 | Não |  |  |
| int-2 | integer |  | ->>>>>>>>>9 | 0 | Não |  |  |
| log-1 | logical |  | Sim/NÆo | no | Não |  |  |
| log-2 | logical |  | Sim/NÆo | no | Não |  |  |
| nat-operacao | character | Nat OperaÆo | x(06) |  | Sim |  |  |
| nr-contrato | integer | Nr Contrato | >>>>>>>>9 | 0 | Não |  | Permite informar o n£mero do contrato do aditivo. |
| nro-docto | character | Documento | x(16) |  | Sim |  |  |
| num-pedido | integer | Pedido | >>>>>,>>9 | 0 | Sim |  |  |
| num-seq-event | integer | Seq Event | >,>>9 | 0 | Não |  | Seqncia do evento |
| num-seq-item | integer | Seq Item | >>,>>9 | 0 | Não |  | Sequncia do item do contrato |
| num-seq-medicao | integer | Seq MediÆo | >,>>9 | 0 | Não |  | N£mero da seqncia da mediÆo |
| numero-ordem | integer | Ordem Compra | zzzzz9,99 | 0 | Sim |  |  |
| parcela | integer | Parcela | >>>>9 | 0 | Sim |  |  |
| qtd-devol | decimal | Qt Devol | ->>>>,>>9.9999 | 0 | Sim |  | Quantidade Devolucao |
| qtd-devolver | decimal | Qtde Devolver | >>>>,>>9.9999 | 0 | Não |  | Quantidade a ser devolvida ao cliente |
| qtidade-forn | decimal | Qtde Fornec | >>>>,>>9.9999 | 0 | Sim |  |  |
| quantidade | decimal | Qtde | >>>>,>>9.9999 | 0 | Sim |  |  |
| sequencia | integer | Seq | >>>>9 | 0 | Sim |  |  |
| serie-docto | character | Srie | x(5) |  | Sim |  |  |
| tipo-nota | integer | Tipo Nota | >9 | 1 | Sim | [ininc/i01in089.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i01in089.i) | Tipo de Nota Fiscal |
| val-medicao | decimal | Vl MediÆo | >>>>>,>>>,>>9.99 | 0 | Não |  | Valor a ser recebido da mediÆo. |

## Triggers

| Evento | Procedure | Link |
| :--- | :--- | :--- |
| Delete | database/tgin/tdp/tdin368.p | [Abrir Fonte](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/database/tgin/tdp/tdin368.p) |

## Índices

- **documento** (Primário): serie-docto, nro-docto, cod-emitente, nat-operacao, sequencia
- **ratorg-ix2**: numero-ordem, parcela
