# Tabela: msg-ret-nfe

**Banco de Dados**: mg
**Label**: Mensagem Retorno NFe
**Descrição**: Mensagens de retorno Conversor NFe
**Gerado em**: 21/07/2026, 15:49:09

## Campos

| Campo | Tipo | Label | Formato | Inicial | Obrig. | Include | Help |
| :--- | :--- | :--- | :--- | :--- | :--- | :--- | :--- |
| cd-msg | integer | Mensagem | >>>>9 | 0 | Não |  | C¢digo Mensagem |
| ch-acesso-comp-nfe | character | Chave Acesso | x(60) |  | Sim |  | Chave Acesso Completa |
| char-1 | character |  | x(100) |  | Não |  |  |
| char-2 | character |  | x(100) |  | Não |  |  |
| data-1 | date |  | 99/99/9999 |  | Não |  |  |
| data-2 | date |  | 99/99/9999 |  | Não |  |  |
| dec-1 | decimal | Livre 1 | ->>>>>>>>>>>9.99999999 | 0 | Não |  | Valor Livre 1 |
| dec-2 | decimal | Livre 2 | ->>>>>>>>>>>9.99999999 | 0 | Não |  | Valor Livre 2 |
| dt-msg | date | Data Mensagem | 99/99/9999 |  | Não |  | Data da Mensagem |
| hr-msg | character | Hora Mensagem | x(08) |  | Não |  | Hora Mensagem |
| idi-orig-trad | integer | Origem Documento | 9 | 0 | Sim |  | Origem Documento |
| int-1 | integer |  | ->>>>>>>>>9 | 0 | Não |  |  |
| int-2 | integer |  | ->>>>>>>>>9 | 0 | Não |  |  |
| log-1 | logical |  | yes/no | no | Não |  |  |
| log-2 | logical |  | yes/no | no | Não |  |  |
| log-ativo | logical | Ativo | yes/no | no | Não |  | Ativo |
| seq-msg | integer | Seq MSG | >>>>>>9 | 0 | Sim |  | Seq MSG |
| texto-msg | character | Texto Mensagem | x(600) |  | Não |  | Texto Mensagem |
| tipo-msg | integer | Tipo | >>>>>>9 | 0 | Não |  |  |
| usuario | character | Usu rio | x(12) |  | Não |  | Usu rio relacionado a mensagem |

## Triggers

| Evento | Procedure | Link |
| :--- | :--- | :--- |
| Create | database/tgin/tcp/tcin860.p | [Abrir Fonte](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/database/tgin/tcp/tcin860.p) |
| Delete | database/tgin/tdp/tdin860.p | [Abrir Fonte](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/database/tgin/tdp/tdin860.p) |
| Write | database/tgin/twp/twin860.p | [Abrir Fonte](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/database/tgin/twp/twin860.p) |

## Índices

- **unico** (Primário, Único): seq-msg
- **chave**: ch-acesso-comp-nfe, idi-orig-trad, log-ativo, seq-msg
