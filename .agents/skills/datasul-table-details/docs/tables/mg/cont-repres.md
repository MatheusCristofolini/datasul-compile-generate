# Tabela: cont-repres

**Banco de Dados**: mg
**Label**: Contatos
**Descrição**: Contatos do Representante
**Gerado em**: 11/05/2026, 15:00:17

## Campos

| Campo      | Tipo      | Label         | Formato                | Inicial | Obrig. | Include | Help                               |
| :--------- | :-------- | :------------ | :--------------------- | :------ | :----- | :------ | :--------------------------------- |
| area       | character | µrea Contato  | x(18)                  |         | Não    |         | µrea do contato                    |
| cargo      | character | Cargo         | x(20)                  |         | Não    |         | Cargo do contato                   |
| char-1     | character |               | x(100)                 |         | Não    |         |                                    |
| char-2     | character |               | x(100)                 |         | Não    |         |                                    |
| check-sum  | character | Check-sum     | x(20)                  |         | Não    |         |                                    |
| cod-repres | integer   | Representante | >>>>9                  | 0       | Sim    |         | Codigo do representante do contato |
| data-1     | date      |               | 99/99/9999             |         | Não    |         |                                    |
| data-2     | date      |               | 99/99/9999             |         | Não    |         |                                    |
| dec-1      | decimal   |               | ->>>>>>>>>>>9.99999999 | 0       | Não    |         |                                    |
| dec-2      | decimal   |               | ->>>>>>>>>>>9.99999999 | 0       | Não    |         |                                    |
| fax        | character | Fax           | x(15)                  |         | Não    |         | Fax do contato                     |
| int-1      | integer   |               | ->>>>>>>>>9            | 0       | Não    |         |                                    |
| int-2      | integer   |               | ->>>>>>>>>9            | 0       | Não    |         |                                    |
| log-1      | logical   |               | Sim/NÆo                | no      | Não    |         |                                    |
| log-2      | logical   |               | Sim/NÆo                | no      | Não    |         |                                    |
| nome       | character | Nome          | x(40)                  |         | Sim    |         | Nome do contato                    |
| observacao | character | ObservaÆo     | x(26)                  |         | Não    |         | Informaäes adicionais              |
| ramal      | character | Ramal         | x(5)                   |         | Não    |         | Ramal do contato                   |
| ramal-fax  | character | Ramal Fax     | x(5)                   |         | Não    |         |                                    |
| sequencia  | integer   | Sequencia     | >>9                    | 0       | Sim    |         |                                    |
| telefone   | character | Telefone      | x(15)                  |         | Não    |         | Telefone do contato                |

## Índices

- **codigo** (Primário, Único): cod-repres, sequencia
