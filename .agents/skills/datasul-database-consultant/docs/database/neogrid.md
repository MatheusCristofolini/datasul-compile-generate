# Esquema do Banco: neogrid

## Tabela: NGAdapterParms
**Label**: ValidadeSenders
### Índices

---

## Tabela: NGMessageQueue
**Label**: Raw-1
### Chave Primária
- NGMessageQueueName, NGMessageQueueID, NGMessageQueueSequence

### Índices
- **DateTime**: GenerationDate, GenerationTime
- **processor**: Done, NGMessageQueueName, NGMessageQueueID, NGMessageQueueSequence

---

## Tabela: NGPartner
**Label**: Extension NeoGrid
### Chave Primária
- Code

### Índices

---

## Tabela: NGPartnerProcess
**Label**: NeoGrid Partner Process
### Chave Primária
- Code, ProgramType, DocType

### Índices

---

## Tabela: NGProcessMapping
**Label**: NeoGrid Process Mapping
### Chave Primária
- ProgramType, DocType

### Índices

---

## Tabela: NGRelationship
**Label**: Relationship Code
### Chave Primária
- RelationType, RelationCode

### Índices

---

