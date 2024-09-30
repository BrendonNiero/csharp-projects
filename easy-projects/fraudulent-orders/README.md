# Reportar as IDs de pedido que precisam ded uma investigação mais aprofundada.
Sua equipe encontrou um padrão. Pedidos que começam com a letra "B" têm uma tax a de incidência de fraude 25 vezes maior que o normal. Você excreverá um novo código para imprimir na saída a ID de novos pedidos que comecem com a letra "B". Isso será usado pela nossa equipe anti-fraude para investigar mais a fundo.

- Declare uma matriz e inicialize-a com os seguintes elementos:
  
| B123 | C234 | A345 | C15 | B177 | G3003 | C235 | B179 |
| --- | --- | --- | --- | --- | --- | --- | --- |

- Cria uma instrução **foreach** para percorrer cada elemento da sua matriz.

- Reporte as IDs de pedido que começam com a letra "B". Para determinar se um elemento começa ou não com a letra "B", use o método **String.StartsWith()**.

Saída esperada:

| B123 |
| --- | 
| B177 |
| B179 |


