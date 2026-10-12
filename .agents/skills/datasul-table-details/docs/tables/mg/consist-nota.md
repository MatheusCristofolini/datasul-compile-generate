# Tabela: consist-nota

**Banco de Dados**: mg
**Label**: Mensagem Consist Doc Pendente
**Descrição**: Arquivo de Mensagens de Consistencia do Arquivo de Documentos Pendentes
**Gerado em**: 20/07/2026, 16:55:46

## Campos

| Campo | Tipo | Label | Formato | Inicial | Obrig. | Include | Help |
| :--- | :--- | :--- | :--- | :--- | :--- | :--- | :--- |
| calculado | decimal | Valor Calculado | ->>>,>>>,>>>,>>9.9999 | 0 | Não |  |  |
| char-1 | character |  | x(100) |  | Não |  |  |
| char-2 | character |  | x(100) |  | Não |  |  |
| check-sum | character | Check-sum | x(20) |  | Não |  |  |
| cod-emitente | integer | Fornecedor | >>>>>>>>9 | 0 | Sim |  | Fornecedor/Cliente/Transportador/Seguradora |
| data-1 | date |  | 99/99/9999 |  | Não |  |  |
| data-2 | date |  | 99/99/9999 |  | Não |  |  |
| dec-1 | decimal |  | ->>>>>>>>>>>9.99999999 | 0 | Não |  |  |
| dec-2 | decimal |  | ->>>>>>>>>>>9.99999999 | 0 | Não |  |  |
| informado | decimal | Valor Informado | ->>>,>>>,>>>,>>9.9999 | 0 | Não |  |  |
| int-1 | integer |  | ->>>>>>>>9 | 0 | Não |  |  |
| int-2 | integer |  | ->>>>>>>>9 | 0 | Não |  |  |
| log-1 | logical |  | Sim/NÆo | no | Não |  |  |
| log-2 | logical |  | Sim/NÆo | no | Não |  |  |
| mensagem | integer | Mensagem | >>>,>>9 | 0 | Não |  |  |
| nat-operacao | character | Nat OperaÆo | x(06) |  | Não |  |  |
| nro-docto | character | Documento | x(16) |  | Sim |  |  |
| sequencia | integer | Seq | >>>>9 | 0 | Sim |  | Permite informar a seqncia do componente |
| serie-docto | character | Srie Documento | x(5) |  | Sim |  |  |
| situacao | integer | SituaÆo | >9 | 1 | Sim |  | SituaÆo das Consistncias da Nota |
| tipo | integer | Tipo | >9 | 1 | Sim |  |  |
| tipo-nota | integer | Tipo Nota | >9 | 0 | Não |  |  |

## Índices

- **documento** (Primário): serie-docto, nro-docto, cod-emitente, nat-operacao, tipo
