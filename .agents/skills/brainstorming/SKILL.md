---
name: brainstorming
description: Explora a intenção do usuário, requisitos e design antes da implementação. Use antes de trabalhos criativos, criação de funcionalidades, construção de componentes, adição de funcionalidades ou modificação de comportamento.
---

# Transformando Ideias em Designs (Brainstorming)

## Visão Geral

Ajude a transformar ideias em designs e especificações completas por meio de um diálogo colaborativo natural. Comece entendendo o contexto atual do projeto e, em seguida, faça perguntas uma de cada vez para refinar a ideia. Assim que entender o que está sendo construído, apresente o design e obtenha a aprovação do usuário.

**REGRA CRÍTICA:** NÃO invoque nenhuma skill de implementação, não escreva código, não crie andaimes (scaffolding) de projeto ou tome qualquer ação de implementação até que tenha apresentado um design e o usuário o tenha aprovado. Isso se aplica a TODO projeto, independentemente da simplicidade percebida.

## O Checklist

Você DEVE concluir estes itens em ordem:

1. **Explorar o contexto do projeto:** Verifique arquivos, documentos e commits recentes para entender o cenário.
2. **Fazer perguntas de esclarecimento:** Uma de cada vez. Entenda o propósito, as restrições e os critérios de sucesso.
3. **Propor 2-3 abordagens:** Discuta as compensações (trade-offs) e forneça sua recomendação.
4. **Apresentar o design:** Em seções proporcionais à sua complexidade. Obtenha aprovação do usuário após cada seção.
5. **Escrever o documento de design:** Formule o design final acordado em um documento de resumo.
6. **Transição para implementação:** Invoque a skill `planning` para criar um plano de implementação detalhado.

## O Processo

### 1. Entendendo a Ideia
- Faça perguntas uma de cada vez para refinar a ideia.
- Prefira questões de múltipla escolha quando possível, mas perguntas abertas também são aceitáveis.
- Apenas uma pergunta por mensagem — se um tópico precisar de mais exploração, divida-o em várias perguntas.

### 2. Explorando Abordagens
- Proponha 2-3 abordagens diferentes com suas respectivas vantagens e desvantagens.
- Apresente as opções de forma conversacional com sua recomendação e raciocínio.
- Comece com sua opção recomendada e explique o porquê.

### 3. Apresentando o Design
- Assim que acreditar que entendeu o que está construindo, apresente o design.
- Dimensione cada seção conforme sua complexidade: algumas frases se for simples, até 200-300 palavras se for detalhado.
- Pergunte após cada seção se o que foi apresentado faz sentido até agora.
- Aborde: arquitetura, componentes, fluxo de dados, tratamento de erros, testes.
- Esteja pronto para retroceder e esclarecer se algo não estiver claro.

### 4. Após o Design
- Escreva o design validado em um documento markdown ou resumo.
- Invoque a skill `planning` para criar um plano de implementação detalhado. NÃO comece a escrever código diretamente.

## Princípios Chave
- **Uma pergunta de cada vez:** Não sobrecarregue o usuário com várias perguntas.
- **Múltipla escolha preferencial:** Mais fácil de responder do que perguntas abertas quando possível.
- **YAGNI implacável (You Ain't Gonna Need It):** Remova recursos desnecessários de todos os designs.
- **Validação incremental:** Apresente o design e obtenha aprovação antes de prosseguir.
