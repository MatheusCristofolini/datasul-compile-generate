---
name: error-handling-patterns
description: Constrói aplicações resilientes com estratégias robustas de tratamento de erros. Use ao implementar tratamento de erros em novas funcionalidades, projetar APIs, depurar problemas, melhorar a confiabilidade, criar mensagens de erro, lidar com erros concorrentes ou construir sistemas tolerantes a falhas usando padrões como circuit breakers ou degradação graciosa.
---

# Padrões de Tratamento de Erros

Construa aplicações resilientes com estratégias robustas de tratamento de erros que lidam com falhas graciosamente e fornecem excelentes experiências de depuração.

## Conceitos Fundamentais

### 1. Filosofias de Tratamento de Erros
**Exceções vs. Tipos Result:**

- **Exceções**: Tradicional try-catch, interrompe o fluxo de controle.
- **Tipos Result**: Sucesso/falha explícitos, abordagem funcional.
- **Códigos de Erro**: Estilo C, exige disciplina.
- **Tipos Option/Maybe**: Para valores que podem ser nulos.

**Quando usar cada um:**

- Exceções: Erros inesperados, condições excepcionais.
- Tipos Result: Erros esperados, falhas de validação.
- Panics/Crashes: Erros irrecuperáveis, bugs de programação.

### 2. Categorias de Erros
**Erros Recuperáveis:**

- Timeouts de rede.
- Arquivos ausentes.
- Entrada de usuário inválida.
- Limites de taxa (rate limits) de API.

**Erros Irrecuperáveis:**

- Sem memória (Out of memory).
- Estouro de pilha (Stack overflow).
- Bugs de programação (ponteiro nulo, etc.).

## Padrões Específicos por Linguagem

### Tratamento de Erros em Python
**Hierarquia de Exceções Customizadas:**

```python
class ApplicationError(Exception):
    """Exceção base para todos os erros da aplicação."""
    def __init__(self, message: str, code: str = None, details: dict = None):
        super().__init__(message)
        self.code = code
        self.details = details or {}
        self.timestamp = datetime.utcnow()

class ValidationError(ApplicationError):
    """Lançada quando a validação falha."""
    pass

class NotFoundError(ApplicationError):
    """Lançada quando um recurso não é encontrado."""
    pass

class ExternalServiceError(ApplicationError):
    """Lançada quando um serviço externo falha."""
    def __init__(self, message: str, service: str, **kwargs):
        super().__init__(message, **kwargs)
        self.service = service

# Uso
def get_user(user_id: str) -> User:
    user = db.query(User).filter_by(id=user_id).first()
    if not user:
        raise NotFoundError(
            f"Usuário não encontrado",
            code="USER_NOT_FOUND",
            details={"user_id": user_id}
        )
    return user
```

**Gerenciadores de Contexto para Limpeza:**

```python
from contextlib import contextmanager

@contextmanager
def database_transaction(session):
    """Garante que a transação seja efetivada (commit) ou revertida (rollback)."""
    try:
        yield session
        session.commit()
    except Exception as e:
        session.rollback()
        raise
    finally:
        session.close()

# Uso
with database_transaction(db.session) as session:
    user = User(name="Alice")
    session.add(user)
    # Commit ou rollback automático
```

**Retry com Exponential Backoff (Tentativa com Espera Exponencial):**

```python
import time
from functools import wraps
from typing import TypeVar, Callable

T = TypeVar('T')

def retry(
    max_attempts: int = 3,
    backoff_factor: float = 2.0,
    exceptions: tuple = (Exception,)
):
    """Decorador de retry com exponential backoff."""
    def decorator(func: Callable[..., T]) -> Callable[..., T]:
        @wraps(func)
        def wrapper(*args, **kwargs) -> T:
            last_exception = None
            for attempt in range(max_attempts):
                try:
                    return func(*args, **kwargs)
                except exceptions as e:
                    last_exception = e
                    if attempt < max_attempts - 1:
                        sleep_time = backoff_factor ** attempt
                        time.sleep(sleep_time)
                        continue
                    raise
            raise last_exception
        return wrapper
    return decorator

# Uso
@retry(max_attempts=3, exceptions=(NetworkError,))
def fetch_data(url: str) -> dict:
    response = requests.get(url, timeout=5)
    response.raise_for_status()
    return response.json()
```

### Tratamento de Erros em TypeScript/JavaScript
**Classes de Erro Customizadas:**

```typescript
// Classes de erro customizadas
class ApplicationError extends Error {
  constructor(
    message: string,
    public code: string,
    public statusCode: number = 500,
    public details?: Record<string, any>,
  ) {
    super(message);
    this.name = this.constructor.name;
    Error.captureStackTrace(this, this.constructor);
  }
}

class ValidationError extends ApplicationError {
  constructor(message: string, details?: Record<string, any>) {
    super(message, "VALIDATION_ERROR", 400, details);
  }
}

class NotFoundError extends ApplicationError {
  constructor(resource: string, id: string) {
    super(`${resource} não encontrado`, "NOT_FOUND", 404, { resource, id });
  }
}

// Uso
function getUser(id: string): User {
  const user = users.find((u) => u.id === id);
  if (!user) {
    throw new NotFoundError("Usuário", id);
  }
  return user;
}
```

**Padrão de Tipo Result:**

```typescript
// Tipo Result para tratamento de erro explícito
type Result<T, E = Error> = { ok: true; value: T } | { ok: false; error: E };

// Funções auxiliares
function Ok<T>(value: T): Result<T, never> {
  return { ok: true, value };
}

function Err<E>(error: E): Result<never, E> {
  return { ok: false, error };
}

// Uso
function parseJSON<T>(json: string): Result<T, SyntaxError> {
  try {
    const value = JSON.parse(json) as T;
    return Ok(value);
  } catch (error) {
    return Err(error as SyntaxError);
  }
}

// Consumindo Result
const result = parseJSON<User>(userJson);
if (result.ok) {
  console.log(result.value.name);
} else {
  console.error("Falha no parse:", result.error.message);
}

// Encadeando Results
function chain<T, U, E>(
  result: Result<T, E>,
  fn: (value: T) => Result<U, E>,
): Result<U, E> {
  return result.ok ? fn(result.value) : result;
}
```

**Tratamento de Erros Assíncronos:**

```typescript
// Async/await com tratamento de erro adequado
async function fetchUserOrders(userId: string): Promise<Order[]> {
  try {
    const user = await getUser(userId);
    const orders = await getOrders(user.id);
    return orders;
  } catch (error) {
    if (error instanceof NotFoundError) {
      return []; // Retorna array vazio se não encontrado
    }
    if (error instanceof NetworkError) {
      // Lógica de retry
      return retryFetchOrders(userId);
    }
    // Lança novamente erros inesperados
    throw error;
  }
}

// Tratamento de erros com Promise
function fetchData(url: string): Promise<Data> {
  return fetch(url)
    .then((response) => {
      if (!response.ok) {
        throw new NetworkError(`HTTP ${response.status}`);
      }
      return response.json();
    })
    .catch((error) => {
      console.error("Busca falhou:", error);
      throw error;
    });
}
```

### Tratamento de Erros em Rust
**Tipos Result e Option:**

```rust
use std::fs::File;
use std::io::{self, Read};

// Tipo Result para operações que podem falhar
fn read_file(path: &str) -> Result<String, io::Error> {
    let mut file = File::open(path)?;  // Operador ? propaga os erros
    let mut contents = String::new();
    file.read_to_string(&mut contents)?;
    Ok(contents)
}

// Tipos de erro customizados
#[derive(Debug)]
enum AppError {
    Io(io::Error),
    Parse(std::num::ParseIntError),
    NotFound(String),
    Validation(String),
}

impl From<io::Error> for AppError {
    fn from(error: io::Error) -> Self {
        AppError::Io(error)
    }
}

// Usando o tipo de erro customizado
fn read_number_from_file(path: &str) -> Result<i32, AppError> {
    let contents = read_file(path)?;  // Converte automaticamente io::Error
    let number = contents.trim().parse()
        .map_err(AppError::Parse)?;   // Converte explicitamente ParseIntError
    Ok(number)
}

// Option para valores anuláveis
fn find_user(id: &str) -> Option<User> {
    users.iter().find(|u| u.id == id).cloned()
}

// Combinando Option e Result
fn get_user_age(id: &str) -> Result<u32, AppError> {
    find_user(id)
        .ok_or_else(|| AppError::NotFound(id.to_string()))
        .map(|user| user.age)
}
```

### Tratamento de Erros em Go
**Retorno Explícito de Erros:**

```go
// Tratamento de erro básico
func getUser(id string) (*User, error) {
    user, err := db.QueryUser(id)
    if err != nil {
        return nil, fmt.Errorf("falha ao consultar usuário: %w", err)
    }
    if user == nil {
        return nil, errors.New("usuário não encontrado")
    }
    return user, nil
}

// Tipos de erro customizados
type ValidationError struct {
    Field   string
    Message string
}

func (e *ValidationError) Error() string {
    return fmt.Sprintf("validação falhou para %s: %s", e.Field, e.Message)
}

// Erros sentinelas para comparação
var (
    ErrNotFound     = errors.New("não encontrado")
    ErrUnauthorized = errors.New("não autorizado")
    ErrInvalidInput = errors.New("entrada inválida")
)

// Verificação de erro
user, err := getUser("123")
if err != nil {
    if errors.Is(err, ErrNotFound) {
        // Lidar com "não encontrado"
    } else {
        // Lidar com outros erros
    }
}

// Envolvimento (wrapping) e desenvolvimento (unwrapping) de erros
func processUser(id string) error {
    user, err := getUser(id)
    if err != nil {
        return fmt.Errorf("falha ao processar usuário: %w", err)
    }
    // Processar usuário
    return nil
}

// Desenvolver erros
err := processUser("123")
if err != nil {
    var valErr *ValidationError
    if errors.As(err, &valErr) {
        fmt.Printf("Erro de validação: %s\n", valErr.Field)
    }
}
```

## Padrões Universais

### Padrão 1: Circuit Breaker
Previne falhas em cascata em sistemas distribuídos.

```python
from enum import Enum
from datetime import datetime, timedelta
from typing import Callable, TypeVar

T = TypeVar('T')

class CircuitState(Enum):
    CLOSED = "closed"       # Operação normal
    OPEN = "open"          # Falhando, rejeitar requisições
    HALF_OPEN = "half_open"  # Testando se recuperou

class CircuitBreaker:
    def __init__(
        self,
        failure_threshold: int = 5,
        timeout: timedelta = timedelta(seconds=60),
        success_threshold: int = 2
    ):
        self.failure_threshold = failure_threshold
        self.timeout = timeout
        self.success_threshold = success_threshold
        self.failure_count = 0
        self.success_count = 0
        self.state = CircuitState.CLOSED
        self.last_failure_time = None

    def call(self, func: Callable[[], T]) -> T:
        if self.state == CircuitState.OPEN:
            if datetime.now() - self.last_failure_time > self.timeout:
                self.state = CircuitState.HALF_OPEN
                self.success_count = 0
            else:
                raise Exception("Circuit breaker está ABERTO (OPEN)")

        try:
            result = func()
            self.on_success()
            return result
        except Exception as e:
            self.on_failure()
            raise

    def on_success(self):
        self.failure_count = 0
        if self.state == CircuitState.HALF_OPEN:
            self.success_count += 1
            if self.success_count >= self.success_threshold:
                self.state = CircuitState.CLOSED
                self.success_count = 0

    def on_failure(self):
        self.failure_count += 1
        self.last_failure_time = datetime.now()
        if self.failure_count >= self.failure_threshold:
            self.state = CircuitState.OPEN

# Uso
circuit_breaker = CircuitBreaker()

def fetch_data():
    return circuit_breaker.call(lambda: external_api.get_data())
```

### Padrão 2: Agregação de Erros
Coleta múltiplos erros em vez de falhar no primeiro.

```typescript
class ErrorCollector {
  private errors: Error[] = [];

  add(error: Error): void {
    this.errors.push(error);
  }

  hasErrors(): boolean {
    return this.errors.length > 0;
  }

  getErrors(): Error[] {
    return [...this.errors];
  }

  throw(): never {
    if (this.errors.length === 1) {
      throw this.errors[0];
    }
    throw new AggregateError(
      this.errors,
      `${this.errors.length} erros ocorreram`,
    );
  }
}

// Uso: Validar múltiplos campos
function validateUser(data: any): User {
  const errors = new ErrorCollector();

  if (!data.email) {
    errors.add(new ValidationError("E-mail é obrigatório"));
  } else if (!isValidEmail(data.email)) {
    errors.add(new ValidationError("E-mail é inválido"));
  }

  if (!data.name || data.name.length < 2) {
    errors.add(new ValidationError("Nome deve ter pelo menos 2 caracteres"));
  }

  if (!data.age || data.age < 18) {
    errors.add(new ValidationError("Idade deve ser 18 ou mais"));
  }

  if (errors.hasErrors()) {
    errors.throw();
  }

  return data as User;
}
```

### Padrão 3: Degradação Graciosa (Graceful Degradation)
Fornece funcionalidade de fallback quando ocorrem erros.

```python
from typing import Optional, Callable, TypeVar

T = TypeVar('T')

def with_fallback(
    primary: Callable[[], T],
    fallback: Callable[[], T],
    log_error: bool = True
) -> T:
    """Tenta a função primária; em caso de erro, usa a função de fallback."""
    try:
        return primary()
    except Exception as e:
        if log_error:
            logger.error(f"Função primária falhou: {e}")
        return fallback()

# Uso
def get_user_profile(user_id: str) -> UserProfile:
    return with_fallback(
        primary=lambda: fetch_from_cache(user_id),
        fallback=lambda: fetch_from_database(user_id)
    )

# Múltiplos fallbacks
def get_exchange_rate(currency: str) -> float:
    return (
        try_function(lambda: api_provider_1.get_rate(currency))
        or try_function(lambda: api_provider_2.get_rate(currency))
        or try_function(lambda: cache.get_rate(currency))
        or DEFAULT_RATE
    )

def try_function(func: Callable[[], Optional[T]]) -> Optional[T]:
    try:
        return func()
    except Exception:
        return None
```

## Melhores Práticas
1. **Falhe Rápido (Fail Fast)**: Valide entradas cedo, falhe rapidamente.
2. **Preserve o Contexto**: Inclua stack traces, metadados, timestamps.
3. **Mensagens Significativas**: Explique o que aconteceu e como corrigir.
4. **Logue Apropriadamente**: Erro = log; falha esperada = não polua os logs.
5. **Trate no Nível Certo**: Capture onde você puder tratar de forma significativa.
6. **Limpe os Recursos**: Use try-finally, gerenciadores de contexto, defer.
7. **Não Engula Erros**: Logue ou lance novamente; não ignore silenciosamente.
8. **Erros Type-Safe**: Use erros tipados quando possível.

## Armadilhas Comuns
- **Captura Muito Abrangente**: `except Exception` oculta bugs.
- **Blocos Catch Vazios**: Engolir erros silenciosamente.
- **Logar e Lançar Novamente**: Cria entradas de log duplicadas.
- **Não Limpar Recursos**: Esquecer de fechar arquivos, conexões.
- **Mensagens de Erro Ruins**: "Ocorreu um erro" não ajuda em nada.
- **Retornar Códigos de Erro**: Use exceções ou tipos Result.
- **Ignorar Erros Assíncronos**: Rejeições de promises não tratadas.
