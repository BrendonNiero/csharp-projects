# Explicação
A variavel currentAssignments se refere a quantidade de materias que temos. No total são 5.

Para cada matéria declaramos uma variável. Onde o valor é a nota final.

Somamos o resultado de todas as matérias e armazenamos dentro de uma variável. (No caso da aluna Sophia, armazenamos o total dentro da variavel sophiaSum).

Para calcularmos o score basta pegarmos o valor total das notas e dividir por currentAssignments. (convertemos o valor para decimal para ser mais especifico no resultado das notas. Como por exemplo um aluno que tira 9 e um aluno que tira 9,9. São notas completamentes diferentes e não conseguimos ter esse resultado apenas vendo o número inteiro).

Depois basta fazer a formatação desejada para exibir essas informações no console.


## Pontos para melhoria do código.
- Ao invés de declararmos uma váriavel para cada materia dizendo alunoA1, alunoA2...
Podemos simplesmente armazenar dentro de um array: "alunoA: [87, 90, 100, 78, 99]";
Dessa forma deixamos nosso código mais limpo e evitamos a repetição de código.

- Criar uma função para realizar o calculo. Ao invés de criar um calculo para cada aluno,
podemos simplesmente fazer uma função única e passar os devidos dados em seu parametro.

- Criar um função para exibir no console. Para reduzir ainda mais o código, podemos fazer
uma função para formatação de exibição do Console.WriteLine.