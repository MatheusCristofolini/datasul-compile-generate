# Relacionamento: ped-venda para item

Para chegar na tabela `item` a partir da tabela `ped-venda`, é necessário passar pela tabela intermediária `ped-item` (Itens do Pedido).

## Caminho
1. **ped-venda** para **ped-item**:
   - `ped-venda.nome-abrev` = `ped-item.nome-abrev`
   - `ped-venda.nr-pedcli` = `ped-item.nr-pedcli`
2. **ped-item** para **item**:
   - `ped-item.it-codigo` = `item.it-codigo`

## Índices Utilizados
- Em `ped-item`: O índice principal (`nome-abrev, nr-pedcli, nr-sequencia, it-codigo, cod-refer`) facilita a busca pelos campos de ligação com `ped-venda`.
- Em `item`: O índice primário (`it-codigo`) permite o acesso direto ao registro do item.

## Observações
- A tabela `ped-venda` representa o cabeçalho do pedido, enquanto a `ped-item` contém as linhas (produtos) do pedido.
- Cada `ped-item` está obrigatoriamente ligado a um `item` através do código do item (`it-codigo`).
