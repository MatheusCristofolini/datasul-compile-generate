---
name: subreddit-scraper
description: Coleta os principais posts de um subreddit especificado. Use quando o usuário pedir para obter os posts principais, tópicos em alta ou conteúdo popular recente de qualquer comunidade do Reddit.
---

# Skill de Coleta de Subreddit (Subreddit Scraper)

Esta skill permite que você recupere os principais posts diários de qualquer subreddit sem a necessidade de uma chave de API.

## Uso

Quando o usuário pedir para coletar ou visualizar os principais posts de um subreddit (ex: `r/n8n`, `r/javascript`), use a ferramenta `run_command` para executar o script Node.js incluído.

```bash
node c:\Projetos\Macritec\macritec-easy-maker\.agents\skills\subreddit-scraper\scripts\scrape.js <nome_do_subreddit>
```

### Parâmetros
*   **`<nome_do_subreddit>`**: O nome do subreddit sem o prefixo `r/` (ex: `n8n`, `reactjs`, `news`).

### Exemplo
Se o usuário perguntar: "Quais são os 3 principais posts no r/n8n agora?"
Você deve executar:
```bash
node c:\Projetos\Macritec\macritec-easy-maker\.agents\skills\subreddit-scraper\scripts\scrape.js n8n
```

## Detalhes Técnicos
- O script usa o módulo nativo `https` do Node.js para interagir com a API JSON pública do Reddit (`https://www.reddit.com/r/<subreddit>/top.json?limit=3&t=day`).
- Não requer dependências externas como `axios`, `cheerio` ou `puppeteer`, portanto, roda perfeitamente em qualquer ambiente com Node.js instalado.
- Lida graciosamente com limites de taxa (rate limits) e subreddits inexistentes.
