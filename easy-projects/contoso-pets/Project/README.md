# Contoso Pets
### Tema
Contoso pets é um projeto onde você pode cadastrar novos animais e ter um controle de animais em petshops ongs, sítios e outros. 
### Sobre
Vamos estar utilizando o ReadLine para pegar a entrada do usuário e vamos trabalhar em cima disso construindo menus interativos com funções de listagem, cadastro e exclusão de cadastro.

# Objetivo
Treinar funcionamento da instrução while, capturar entrada do usuário e trabalhar com arrays.

## Classe Animal
Vamos criar uma classe animal que vai conter um id, nome, espécie, idade e personalidade. 

Com isso podemos já criar o nosso array que vai conter nossos animais cadastrados:

``` bash
    List<Animal> ourAnimals = new List<Animal>();
```

## Cadastrando um novo animal
Após pegar a entrada do usuário e armazenar ela dentro de uma variável temporária. Vamos jogar ela dentro de um objeto:
``` bash
    Animal newAnima = new Animal
    {
    	Id = ourAnimals.Count + random.Next(1, 99),
    	Name = animalNickName,
    	Specie = animalSpecies,
    	Age = int.Parse(animalAge),
    	Personality = animalPersonalityDescription
    };
```
Após isso vamos jogar essa dentro do nosso array:
``` bash
    ourAnimals.Add(newAnimal);
```

## Deletar por ID
Para isso vamos capturar o id selecionado pelo usuário e utilizar o método WHERE para buscar o ID selecionado:

``` bash
    ourAnimals = ourAnimals.Where(animal => animal.Id != int.Parse(result)).ToList();
```
Aqui estamos criando um novo array que contém todos os itens, menos (≠) o que teve o ID selecionado.

## Listagem de cadastro
Para isso vamos utilizar uma estrutura de repetição foreach. Bem simples.