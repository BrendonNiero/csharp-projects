# Contoso Pets
Você está trabalhando no aplicativo Contoso Pets, um aplicativo que ajuda a colocar animais de estimação em novas casas.

### Especificações do aplicativo:
- Armazene dados do aplicativo em uma matriz de cadeia de caracteres multidimensional chamada ourAnimals.
- A matriz ourAnimals incrui as seguintes "características de animais de estimação" para cada animal:
 - Número de ID do animal de estimação.
 - Espécie do animal de estimação (gato ou cachorro).
 - Idade do animal de estimação (em anos).
 - Descrição das condições/características físicas do animal de estimação.
 - Descrição da personalidade do animal de estimação.
 - Apelido do animal de estimação.
 - Implemente um conjunto de dados de exemplo que represente os cães e gatos atualmente sob seus cuidados.
 - Exiba opções de menu para acessar os principais recursos do aplicativo.
 - Os principais recursos habilitam as seguintes tarefas
 listar as informações de animais de estimação para todos os animais da matriz ourAnimals.
 Adicionar novos animais à matriz ourAnimals. As seguintes condições se aplicam:
    - A espécie do animal de estimação (cão ou gato) deve ser informada quando um novo animal é adicionado à matriz ourAnimals.
    - Uma ID de animal de estimação deve ser gerada programaticamente quando um novo animal é adicionado à matriz ourAnimals.
    Algumas características físicas do animal de estimação podem ser desconhecidas até o exame de um veterinário. Por exemplo: didade, raça e status de castração.
    - O apelido e a personalidade do animal de estimação podem ser desconhecidos logo que ele chega.
- Verificar se os dados de idade e descrição física dos animais estão completos. Isso pode exigir o exame de um veterinário.
- Verificar se os dados de apelido e descrição da personalidade dos animais estão completos (isso pode exigir que a equipe conheça melhor o animal de estimação).
- Alterar a idade do animal (se a data de nascimento dele for conhecida e ele fizer aniversário enquanto estiver sob cuidados).
- Exibir todos os gatos e cães que atendem às características físicas especificadas pelo usuário.
- O código exibe as seguintes opções principais de menu para seleção pelo usuário:

1 Listar todas as nossas informações atuais sobre os animais de estimação.
2 Atribuir valores aos campos da matriz ourAnimals.
3 Verificar se os dados de idade e descrição física dos animais estão completos.
4 Verificar se os dados de apelido e descrição de personalidade dos animais estão completos.
5 Editar a idade do animal.
6 Editar a descrição de personalidade do animal.
7 Exibir todos os gatos com uma característica especificada.
8 Exibir todos os cães com uma característica especificada.

- Insira o item de menu desejado ou digite "Exit" para sair do programa.

Código inicial
``` bash
// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];
```