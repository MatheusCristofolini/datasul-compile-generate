---
name: progress-review
description: Analisa código fonte Progress ABL com base em regras de indentação, boas práticas e qualidade de fontes. Use para revisar, validar ou formatar código Progress ABL.
---

# Revisão de Código Progress ABL (`progress-review`)

Esta skill define as regras de estilo, formatação, indentação e boas práticas para o desenvolvimento de códigos em Progress ABL. Utilize estas regras ao ler, escrever, revisar ou refatorar qualquer código Progress ABL.

## Regras de Formatação e Boas Práticas

### 1. Atribuição de Valores com `ASSIGN`
Toda atribuição de valor deve ser feita dentro de um bloco `ASSIGN`. Evite atribuições diretas sem a palavra-chave.
A palavra `ASSIGN` deve estar em sua própria linha (ou início de bloco), e as atribuições indentadas no bloco, terminando com um ponto final (`.`) em uma linha exclusiva e alinhado com o comando `ASSIGN` (ou o nível de indentação do bloco).

*   **Correto:**
    ```progress
    ASSIGN
        teste = TRUE
    .
    ```
*   **Incorreto:**
    ```progress
    ASSIGN
        teste = TRUE.
    ```
    *(ou atribuição sem ASSIGN)*
    ```progress
    teste = TRUE.
    ```

### 2. Blocos `IF` obrigatoriamente com `THEN DO:`
Todo bloco `IF` deve conter `THEN DO:`, mesmo que possua apenas uma única instrução dentro de sua lógica. Não utilize instruções de linha única sem `DO: ... END.`.

*   **Correto:**
    ```progress
    IF condicao THEN DO:
        /* Logica aqui */
    END.
    ```
*   **Incorreto:**
    ```progress
    IF condicao THEN
        teste = ''.
    ```

### 3. Linha em Branco Após Abertura de Blocos
Todo bloco (`DO`, `FOR`, `REPEAT`, etc.) deve ter exatamente uma linha em branco logo após a sua linha de abertura, antes do início da lógica interna.

*   **Correto:**
    ```progress
    DO TRANSACTION:

        /* aqui começa a logica... */
    END.
    ```
*   **Incorreto:**
    ```progress
    DO TRANSACTION:
        /* aqui começa a logica... */
    END.
    ```

### 4. Caixa Alta para Palavras Reservadas e Comandos Progress
Todas as palavras reservadas, comandos, tipos de dados e funções internas do Progress ABL devem ser escritos em caixa alta (UPPERCASE). Exemplos: `ASSIGN`, `IF`, `THEN`, `DO`, `END`, `FOR`, `EACH`, `FIRST`, `NO-LOCK`, `RUN`, `INPUT`, `OUTPUT`, `DEFINE`, `VARIABLE`, `CHARACTER`, `INTEGER`.

*   **Correto:**
    ```progress
    DEFINE VARIABLE c-teste AS CHARACTER NO-UNDO.
    ```
*   **Incorreto:**
    ```progress
    define variable c-teste as character no-undo.
    ```

### 5. Chamada de Blocos `RUN` (Procedimentos Internos/Externos)
As chamadas de procedures externas ou internas utilizando `RUN` devem seguir a seguinte estrutura de indentação e parênteses, com cada parâmetro em sua própria linha:

*   **Correto:**
    ```progress
    RUN pi-calcula-data IN h-api (
        INPUT DATE(fi-dt-entrcli:SCREEN-VALUE IN FRAME f-main),
        INPUT es_ped_venda.cod_tipo_carga,
        INPUT IF ped-venda.cidade-cif <> "" THEN 1 ELSE 2,
        INPUT fn-cidade(),
        INPUT loc-entr.estado,
        INPUT loc-entr.pais,
        INPUT ped-venda.cod-canal-venda,
        INPUT i-prazo-entrega,
        OUTPUT p-lead-cidade,
        OUTPUT p-lead-tipo-carga,
        OUTPUT p-data
    ).
    ```

### 6. Preferência de `FOR` sobre `FIND`
Priorize sempre a utilização de `FOR` (normalmente `FOR FIRST` ou `FOR EACH` com `NO-LOCK`) ao invés do comando `FIND`. Isso evita erros comuns de registro não encontrado (`FIND` gera erro se não tratado ou se não achar e não usar `AMBIGUOUS`/`AVAILABLE`), além de ser uma prática mais segura no Progress ABL.

*   **Correto:**
    ```progress
    FOR FIRST cliente NO-LOCK WHERE cliente.cod-cli = 10:
        /* logic */
    END.
    ```
*   **Incorreto:**
    ```progress
    FIND FIRST cliente NO-LOCK WHERE cliente.cod-cli = 10 NO-ERROR.
    IF AVAILABLE cliente THEN DO:
        /* logic */
    END.
    ```

### 7. Remoção de Código Morto e Elementos Não Utilizados
Remova todo código que não seja efetivamente executado. Isso inclui variáveis declaradas mas não utilizadas, parâmetros não utilizados, e procedures/functions internas que não são invocadas por nenhum ponto do código.

*   **Correto:**
    ```progress
    DEFINE VARIABLE i-contador AS INTEGER NO-UNDO.
    ASSIGN i-contador = 1.
    ```
*   **Incorreto:**
    ```progress
    DEFINE VARIABLE i-contador AS INTEGER NO-UNDO.
    DEFINE VARIABLE c-inutilizado AS CHARACTER NO-UNDO. /* Sem uso */
    ASSIGN i-contador = 1.
    ```

### 8. Parâmetros Explícitos nas Chamadas `RUN`
Toda chamada de procedure via comando `RUN` deve conter explicitamente a direção de cada parâmetro passado (`INPUT`, `OUTPUT` ou `INPUT-OUTPUT`). Nunca omita esses modificadores.

*   **Correto:**
    ```progress
    RUN pi-calcula-data (
        INPUT  i-codigo,
        OUTPUT c-nome
    ).
    ```
*   **Incorreto:**
    ```progress
    RUN pi-calcula-data (
        i-codigo,
        OUTPUT c-nome
    ).
    ```

### 9. Gerenciamento Correto de Locks (`NO-LOCK`/`EXCLUSIVE-LOCK`)
- Ao ler registros de tabelas de banco de dados, certifique-se de utilizar explicitamente `NO-LOCK` ou `EXCLUSIVE-LOCK`.
- Ao ler ou manipular registros de tabelas temporárias (`TEMP-TABLE`), **não utilize** especificadores de lock (`NO-LOCK`, `EXCLUSIVE-LOCK`, etc.), pois temp-tables não possuem suporte/necessidade de gerenciamento de locks concorrentes.

*   **Correto:**
    ```progress
    /* Banco de Dados */
    FOR EACH emitente NO-LOCK:
    END.

    /* Temp-Table */
    FOR EACH tt-emitente:
    END.
    ```
*   **Incorreto:**
    ```progress
    /* Banco de Dados */
    FOR EACH emitente: /* Falta especificar lock */
    END.

    /* Temp-Table */
    FOR EACH tt-emitente NO-LOCK: /* NO-LOCK desnecessário em temp-table */
    END.
    ```

### 10. Uso Obrigatório de `NO-UNDO`
Todas as variáveis e definições de tabelas temporárias (`TEMP-TABLE`) devem ser declaradas utilizando a cláusula `NO-UNDO`. Isso evita overhead desnecessário de log de transação e rollback para objetos em memória.

*   **Correto:**
    ```progress
    DEFINE VARIABLE i-codigo AS INTEGER NO-UNDO.

    DEFINE TEMP-TABLE tt-dados NO-UNDO
        FIELD cod AS INTEGER.
    ```
*   **Incorreto:**
    ```progress
    DEFINE VARIABLE i-codigo AS INTEGER.

    DEFINE TEMP-TABLE tt-dados
        FIELD cod AS INTEGER.
    ```

### 11. Não Abreviar Comandos Progress
Nunca use abreviações de palavras reservadas, comandos ou tipos de dados do Progress. Escreva-os sempre por extenso.
Exemplos comuns:
- Use `TRANSACTION` ao invés de `TRANS`
- Use `CHARACTER` ao invés de `CHAR`
- Use `VARIABLE` ao invés de `VAR`
- Use `DEFINE` ao invés de `DEF`
- Use `INITIAL` ao invés de `INIT`
- Use `NO-UNDO` ao invés de `NO-UN`
- Use `EACH` ao invés de `EA`
- Use `LOGICAL` ao invés de `LOG`
- Use `AVAILABLE` ao invés de `AVAIL`

*   **Correto:**
    ```progress
    DEFINE VARIABLE c-nome AS CHARACTER NO-UNDO.
    DO TRANSACTION:
    END.
    ```
*   **Incorreto:**
    ```progress
    DEF VAR c-nome AS CHAR NO-UNDO.
    DO TRANS:
    END.
    ```

### 12. Alinhamento de Definições de Variáveis por Coluna
Todas as declarações de variáveis (`DEFINE VARIABLE ...`) dentro de um mesmo bloco/código devem ter seus componentes alinhados por coluna (o nome da variável, o modificador de tipo `AS` ou `LIKE`, o tipo de dado, e a cláusula `NO-UNDO`).
A coluna de alinhamento do modificador `AS`/`LIKE` e da cláusula `NO-UNDO` deve ser determinada de forma dinâmica baseada no maior comprimento de nome de variável declarada e no maior comprimento de tipo de dado.

*   **Correto:**
    ```progress
    DEFINE VARIABLE i-prazo-entrega      LIKE es_loc_entr.prazo-entrega NO-UNDO.
    DEFINE VARIABLE h-api                AS HANDLE                      NO-UNDO.
    DEFINE VARIABLE c-cidade             AS CHARACTER                   NO-UNDO.
    DEFINE VARIABLE l-es-ped-ent-found   AS LOGICAL                     NO-UNDO.
    ```
*   **Incorreto:**
    ```progress
    DEFINE VARIABLE i-prazo-entrega   LIKE es_loc_entr.prazo-entrega NO-UNDO.
    DEFINE VARIABLE h-api AS HANDLE      NO-UNDO.
    DEFINE VARIABLE c-cidade AS CHARACTER   NO-UNDO.
    DEFINE VARIABLE l-es-ped-ent-found   AS LOGICAL                     NO-UNDO.
    ```

### 13. Substituição de `MESSAGE` de Erro por `utp/ut-msgs.p`
Sempre que for necessário apresentar uma mensagem de erro ou validação, substitua o comando nativo `MESSAGE` por uma chamada ao programa de tratamento de mensagens padrão `utp/ut-msgs.p`.
Se a mensagem original continha apenas um valor (como `RETURN-VALUE` ou o nome de uma única variável), adicione um título de erro explicativo antes dos caracteres delimitadores `~~` para compor o terceiro parâmetro da chamada.

*   **Correto:**
    ```progress
    RUN utp/ut-msgs.p (
        INPUT "Show",
        INPUT 17006,
        INPUT "A data informada é inválida!~~" + RETURN-VALUE
    ).
    ```
*   **Incorreto:**
    ```progress
    MESSAGE RETURN-VALUE
        VIEW-AS ALERT-BOX INFORMATION BUTTONS OK.
    ```

### 14. Correção e Clareza de Mensagens de Erro Fixas
Mensagens de erro de texto fixo devem ser revisadas para garantir correção gramatical, legibilidade, tom profissional e clareza. Corrija erros comuns de digitação (ex: "não atenden" -> "não atendem") e formate o título e a descrição separando-os de forma clara com `~~`.

*   **Correto:**
    ```progress
    INPUT "Erro de validação de entrega!~~A data de entrega não pode ser menor que a data de hoje."
    ```
*   **Incorreto:**
    ```progress
    INPUT "Data de entrega nao pode ser menor que hoje!~~"
    ```

---

## Como Aplicar
Sempre que for solicitado a criar, modificar ou refatorar um código em Progress ABL, certifique-se de validar se todas as regras acima estão sendo estritamente seguidas. Se encontrar desvios em códigos existentes, aplique as correções necessárias durante a edição.
