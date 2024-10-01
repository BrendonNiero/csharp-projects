# Automação de cálculo de notas
Você está desenvolvendo um aplicativo de notas de alunos que automatiza o cálculo das notas de cada aluno em uma turma.

- Comece com quatro alunos. Cada aluno tem cinco pontuações de exame.
- Cada pontuação de exame é um valor inteiro, de 0 a 100, em que 100 representa 100% de acerto.
- A pontuação de exame geral de um aluno é a média de suas cinco pontuações de exame.
- Sistema de crédito extra:
- - Inclua as pontuações de tarefas de crédito extra na matriz de pontuações do aluno.
- - As tarefas de crédito extra valem 10% da pontuação do exame (ao calcular a nota numérica final).
- - Adicione as pontuações de tarefas de crédito extra à pontuação de exame total do aluno antes de calcular a nota numérica final.

- O aplicativo precisa atribuir notas com o formato da letra automaticamente com base na pontuação final calculada de cada aluno.

- Gerar/Exibir o nome de cada aluno e a nota formatada.

## Objetivo
Atualizar o [código existente](https://github.com/BrendonNiero/csharp-projects/blob/main/easy-projects/calculate-print-student-grades/project/main.cs) para incluir os seguintes recursos:

Use matrizes para armazenar os nomes dos alunos e as pontuações das tarefas.

- Use uma instrução foreach para fazer a iteração pelos nomes dos alunos como um loop de programa externo.

- Use uma instrução if dentro do loop externo para identificar o nome do aluno atual e acessar as pontuações das tarefas dele.

- Use uma instrução foreach dentro do loop externo para fazer a iteração pela matriz de pontuações de tarefas e somar os valores.

- Use um algoritmo atualizado dentro do loop externo para calcular a pontuação de exame média de cada aluno.

- Use um constructo if-elseif-else dentro do loop externo para avaliar a pontuação de exame média e atribuir automaticamente uma nota em formato de letra.

- Integre as pontuações de crédito extra ao calcular a pontuação final do aluno e a nota em formato de letra da seguinte forma:

- O código precisa detectar tarefas de crédito extra com base no número de elementos na matriz de pontuações do aluno.
O código precisa aplicar o fator de ponderação de 10% às tarefas de crédito extra antes de adicionar as pontuações de crédito extra à soma das pontuações de exames.

## Saída esperada:
Student         Grade

| Sophia: | 92.2 | A- |
| --- | --- | --- |
| Andrew: | 89.6 | B+ |
| Emma: | 85.6 | B |
| Logan: | 91.2 | A- |

