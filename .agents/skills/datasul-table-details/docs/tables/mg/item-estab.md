# Tabela: item-estab

**Banco de Dados**: mg
**Label**: Itens do Estabelecimento
**Descrição**: Arquivo de Itens do Estabelecimento
**Gerado em**: 20/07/2026, 16:19:00

## Campos

| Campo | Tipo | Label | Formato | Inicial | Obrig. | Include | Help |
| :--- | :--- | :--- | :--- | :--- | :--- | :--- | :--- |
| atualizado | logical | Registro Atualizado | Sim/NÆo | no | Sim |  |  |
| char-1 | character |  | x(100) |  | Não |  |  |
| char-2 | character |  | x(100) |  | Não |  |  |
| check-sum | character | Check-sum | x(20) |  | Não |  |  |
| ciclo-contag | integer | Ciclo Contagem | >>9 | 0 | Não |  |  |
| cod-estabel | character | Estabelecimento | x(5) |  | Sim |  |  |
| consumo-aad | decimal | Consumo ate a Data | ->>>>,>>9.9999 | 0 | Não |  |  |
| data-1 | date |  | 99/99/9999 |  | Não |  |  |
| data-2 | date |  | 99/99/9999 |  | Não |  |  |
| data-ult-con | date | Data Ultima Contagem | 99/99/9999 |  | Não |  |  |
| data-ult-sai | date | Data éltima Sa¡da | 99/99/9999 |  | Não |  |  |
| dec-1 | decimal |  | ->>>>>>>>>>>9.99999999 | 0 | Não |  |  |
| dec-2 | decimal |  | ->>>>>>>>>>>9.99999999 | 0 | Não |  |  |
| deposito-pad | character | Dep¢sito | x(3) |  | Sim |  |  |
| fase-medio | integer | Fase C lculo Mdio | >9 | 1 | Sim | [ininc/i09in287.i](file:///C:/Projetos/Macritec/examples-progress/produto-padrao/EMS2/ininc/i09in287.i) | Fase calculada do preo mdio |
| int-1 | integer |  | ->>>>>>>>>9 | 0 | Não |  |  |
| int-2 | integer |  | ->>>>>>>>>9 | 0 | Não |  |  |
| it-codigo | character | Item | x(16) |  | Sim |  |  |
| log-1 | logical |  | Sim/NÆo | no | Não |  |  |
| log-2 | logical |  | Sim/NÆo | no | Não |  |  |
| mensal-ate | date | Data Mdio Batch | 99/99/9999 | today | Não |  | Data do mdio batch |
| niv-mais-bai | integer | N¡vel Mais Baixo | >9 | 0 | Não |  |  |
| niv-rest-dentro | character | Nivel Restituicao Dentro | x(1) |  | Não |  | Nivel de Restituicao do item fora do Estado |
| niv-rest-fora | character | N¡vel RestituiÆo Fora UF | x(1) |  | Não |  | N¡vel de RestituiÆo do Item fora do Estado |
| num-id-item-estab | integer | ID Item-estab | >>>,>>>,>>9 | 0 | Sim |  | Identificador da tabela item-estabelecimento |
| on-line-ate | date | Data Mdio On-line | 99/99/9999 | today | Não |  | Data do mdio on-line |
| padrao-ate | date | Data PadrÆo | 99/99/9999 | today | Não |  | Data do padrÆo |
| per-rest-dentro | decimal | % Rest Dentro | >>9.99 | 0 | Não |  | Percentual de RestituiÆo do item dentro do Estado |
| per-rest-fora | decimal | % Rest Fora | >>9.99 | 0 | Não |  | Percentual de RestituiÆo do Item fora do Estado |
| pm-ja-calc | logical | Preo Mdio Calculado | Sim/NÆo | no | Sim |  | Indica se o preo mdio j  foi calculado no per¡odo |
| qtidade-atu | decimal | Qtde Atual | ->>>,>>>,>>9.9999 | 0 | Não |  |  |
| sald-atu-ggf-m | decimal | Saldo Atual GGF Batch | ->>>,>>>,>>>,>>9.99 | 0 | Não |  | Saldo Atual GGF Batch |
| sald-atu-ggf-o | decimal | Saldo Atual GGF On-line | ->>>,>>>,>>>,>>9.99 | 0 | Não |  | Saldo Atual GGF On-line |
| sald-atu-ggf-p | decimal | Saldo Atual GGF PadrÆo | ->>>,>>>,>>>,>>9.99 | 0 | Não |  | Saldo Atual GGF PadrÆo |
| sald-atu-mat-m | decimal | Saldo Atual Mat Batch | ->>>,>>>,>>>,>>9.99 | 0 | Não |  | Saldo Atual Material Batch |
| sald-atu-mat-o | decimal | Saldo Atual Mat On-line | ->>>,>>>,>>>,>>9.99 | 0 | Não |  | Saldo Atual Mat On-line |
| sald-atu-mat-p | decimal | Saldo Atual Mat PadrÆo | ->>>,>>>,>>>,>>9.99 | 0 | Não |  | Saldo Atual Mat PadrÆo |
| sald-atu-mob-m | decimal | Saldo Atual Mob Batch | ->>>,>>>,>>>,>>9.99 | 0 | Não |  | Saldo Atual Mob Batch |
| sald-atu-mob-o | decimal | Saldo Atual Mob On-line | ->>>,>>>,>>>,>>9.99 | 0 | Não |  | Saldo Atual Mob On-line |
| sald-atu-mob-p | decimal | Saldo Atual Mob PadrÆo | ->>>,>>>,>>>,>>9.99 | 0 | Não |  | Saldo Atual Mob PadrÆo |
| sald-ini-ggf-m | decimal | Saldo Inicial GGF Batch | ->>>,>>>,>>>,>>9.99 | 0 | Não |  | Saldo Inicial GGF Batch |
| sald-ini-ggf-o | decimal | Saldo Inicial GGF On-line | ->>>,>>>,>>>,>>9.99 | 0 | Não |  | Saldo Inicial GGF On-line |
| sald-ini-ggf-p | decimal | Saldo Inicial GGF PadrÆo | ->>>,>>>,>>>,>>9.99 | 0 | Não |  | Saldo Inicial GGF PadrÆo |
| sald-ini-mat-m | decimal | Saldo Inicial Mat Batch | ->>>,>>>,>>>,>>9.99 | 0 | Não |  | Saldo Inicial Mat Batch |
| sald-ini-mat-o | decimal | Saldo Inicial Mat On-line | ->>>,>>>,>>>,>>9.99 | 0 | Não |  | Saldo Inicial Mat On-line |
| sald-ini-mat-p | decimal | Saldo Inicial Mat PadrÆo | ->>>,>>>,>>>,>>9.99 | 0 | Não |  | Saldo Inicial Mat PadrÆo |
| sald-ini-mob-m | decimal | Saldo Inicial Mob Batch | ->>>,>>>,>>>,>>9.99 | 0 | Não |  | Saldo Inicial Mob Batch |
| sald-ini-mob-o | decimal | Saldo Inicial Mob On-line | ->>>,>>>,>>>,>>9.99 | 0 | Não |  | Saldo Inicial Mob On-line |
| sald-ini-mob-p | decimal | Saldo Inicial Mob PadrÆo | ->>>,>>>,>>>,>>9.99 | 0 | Não |  | Saldo Inicial Mob PadrÆo |
| saldo-mensal-ggf | decimal | Saldo Ini Batch GGF | ->>>,>>>,>>>,>>9.99 | 0 | Não |  | Saldo Inicial GGF Batch At |
| saldo-mensal-mat | decimal | Saldo Ini Batch Mat | ->>>,>>>,>>>,>>9.99 | 0 | Não |  |  |
| saldo-mensal-mob | decimal | Saldo Ini Batch Mob | ->>>,>>>,>>>,>>9.99 | 0 | Não |  | Saldo Inicial MOB Batch At |
| tx-importacao | decimal | Taxa Import | >>9.999 | 0 | Não |  | Taxa de ImportaÆo p/ Zona Franca |
| val-unit-ggf-m | decimal | Valor Unit GGF Batch | >>>>,>>>,>>9.9999 | 0 | Não |  | Valor Unit GGF Batch |
| val-unit-ggf-o | decimal | Valor Unit GGF On-line | >>>>,>>>,>>9.9999 | 0 | Não |  | Valor Unit GGF On-line |
| val-unit-ggf-p | decimal | Valor Unit GGF PadrÆo | >>>>,>>>,>>9.9999 | 0 | Não |  | Valor Unit GGF PadrÆo |
| val-unit-mat-m | decimal | Valor Unit Mat Batch | >>>>,>>>,>>9.9999 | 0 | Não |  | Valor Unit Mat Batch |
| val-unit-mat-o | decimal | Valor Unit Mat On-line | >>>>,>>>,>>9.9999 | 0 | Não |  | Valor Unit Mat On-line |
| val-unit-mat-p | decimal | Valor Unit Mat PadrÆo | >>>>,>>>,>>9.9999 | 0 | Não |  | Valor Unit Mat PadrÆo |
| val-unit-mob-m | decimal | Valor Unit Mob Batch | >>>>,>>>,>>9.9999 | 0 | Não |  | Valor Unit Mob Batch |
| val-unit-mob-o | decimal | Valor Unit Mob On-line | >>>>,>>>,>>9.9999 | 0 | Não |  | Valor Unit Mob On-line |
| val-unit-mob-p | decimal | Valor Unit Mob PadrÆo | >>>>,>>>,>>9.9999 | 0 | Não |  | Valor Unit Mob PadrÆo |
| varia-acum | decimal | Variac Acumul | ->>>,>>>,>>9.9999 | 0 | Sim |  |  |

## Índices

- **item** (Primário, Único): it-codigo, cod-estabel
- **estabel**: cod-estabel, it-codigo
- **nmb**: cod-estabel, pm-ja-calc, niv-mais-bai
- **pm-ja-calc**: cod-estabel, pm-ja-calc, it-codigo
