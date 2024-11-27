# Escrever o código que valida a entrada de inteiro

## Regras de implementação
- A solução deve incluir uma iteração do-while ou while.
- Antes do bloco de iteração: a solução deve usar uma instrução Console.WriteLine() para solicitar ao usuário um valor inteiro entre 5 e 10.
- Dentro do bloco de iteração:
 - A solução deve usar uma instrução Console.ReadLine() para obter uma entrada do usuário.
 - A solução deve garantir que a entrada seja uma representação válida de um inteiro.
 - Se o valor inteiro não estiver entre 5 e 10, o código deverá usar uma instrução Console.WriteLine() para solicitar ao usuário um valor inteiro entre 5 e 10.
 - a solução deve garantir que o valor inteiro esteja entre 5 e 10 antes de sair da iteração.
- Abaixo (depois) do bloco de código de iteração: a solução deve usar uma instrução Console.WriteLine() para informa ao usuário que o valor de entrada foi aceito.

### Output esperado:
``` bash
    Enter an integer value between 5 and 10
    two
    Sorry, you entered an invalid number, please try again
    2
    You entered 2. Please enter a number between 5 and 10.
    7
    Your input value (7) has been accepted.
```