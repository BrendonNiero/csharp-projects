using System;
using System.Dynamic;

public class Animal
{
    public int Id { get; set; }
    public string? Name { get; set; } = null!;
    public string? Specie { get; set; } = null!;
    public int? Age { get; set; }
    public string? Personality { get; set; } = null!;
}

public class Program
{
    public static void Main()
    {
        List<Animal> ourAnimals = new List<Animal>();

        string? animalNickname = "";
        string? animalSpecies = "";
        string? animalAge = "";
        string? animalPersonalityDescription = "";
        string? readResult;

        Console.WriteLine("------------------------ 🎉 Sejá bem vindo ao Contoso Pets 🎉 ------------------------");
        Console.WriteLine("1: Listar animais");
        Console.WriteLine("2: Cadastrar novos animais");
        Console.WriteLine("3: Deletar cadastro");
        Console.WriteLine("4: Sair");
        readResult = Console.ReadLine();

        while(readResult != "4")
        {
            switch(readResult)
            {
                case "1":
                    if(ourAnimals.Count == 0)
                    {
                        Console.WriteLine("Não há nenhum cadastrado 😔");
                    } else 
                    {
                        foreach(var animal in ourAnimals)
                        {
                            Console.WriteLine($"------------------------ 🐾 {animal.Name} 🐾 ------------------------");
                            Console.WriteLine($"ID Cadastro: {animal.Id}");
                            Console.WriteLine($"Nome: {animal.Name}");
                            Console.WriteLine($"Espécie: {animal.Specie}");
                            Console.WriteLine($"Idade: {animal.Age}");
                            Console.WriteLine($"Personalidade: {animal.Personality}");
                        }
                    }
                break;
                case "2":
                    Console.WriteLine("Digite o nome do animal 🎀");
                    animalNickname = Console.ReadLine();
                    Console.WriteLine("Digite a espécie do animal. (Cão, Gato...) 🐱");
                    animalSpecies = Console.ReadLine();
                    Console.WriteLine("Digite a idade do animal em anos 🔞");
                    animalAge = Console.ReadLine();
                    Console.WriteLine("Descreva a personalidade do seu animal 🍂");
                    animalPersonalityDescription = Console.ReadLine();
                    Console.WriteLine("------------------------ Confira suas informações ------------------------");
                    Console.WriteLine($"• {animalNickname}\n• {animalSpecies}\n• {animalAge}\n• {animalPersonalityDescription}");
                    Console.WriteLine("------------------------ Suas informações estão corretas? ------------------------");
                    Console.WriteLine("1: Sim");
                    Console.WriteLine("2: Não");
                    string ?response = Console.ReadLine();
                    if(response == "1" && animalNickname != null && animalAge != null)
                    {
                        Random random = new Random();
                        Animal newAnimal = new Animal
                        {
                            Id = ourAnimals.Count + random.Next(1, 99),
                            Name = animalNickname,
                            Specie = animalSpecies,
                            Age = int.Parse(animalAge),
                            Personality = animalPersonalityDescription
                        };

                        ourAnimals.Add(newAnimal);
                        Console.WriteLine("Animal cadastrado com sucesso! ✅");
                    } else
                    {
                        Console.WriteLine("Digite o nome do animal 🎀");
                        animalNickname = Console.ReadLine();
                        Console.WriteLine("Digite a espécie do animal. (Cão, Gato...) 🐱");
                        animalSpecies = Console.ReadLine();
                        Console.WriteLine("Digite a idade do animal em anos 🔞");
                        animalAge = Console.ReadLine();
                        Console.WriteLine("Descreva a personalidade do seu animal 🍂");
                        animalPersonalityDescription = Console.ReadLine();
                        Console.WriteLine("------------------------ Confira suas informações ------------------------");
                        Console.WriteLine($"• {animalNickname}\n• {animalSpecies}\n• {animalAge}\n• {animalPersonalityDescription}");
                        Console.WriteLine("------------------------ Suas informações estão corretas? ------------------------");
                        Console.WriteLine("1: Sim");
                        Console.WriteLine("2: Não");
                        response = Console.ReadLine();
                    }
                break;
                case "3":
                    Console.WriteLine("Insira o número ID de Cadastro do Animal:");
                    string result = Console.ReadLine()!;
                    if(result != null)
                    {
                        ourAnimals = ourAnimals.Where(animal => animal.Id != int.Parse(result)).ToList();
                    }
                    Console.WriteLine("Operação concluida com sucesso! 🎯");
                break;
                case "4":
                Console.WriteLine("Tchau!");
                break;
            }

            Console.WriteLine("------------------------ 🎉 Sejá bem vindo ao Contoso Pets 🎉 ------------------------");
            Console.WriteLine("1: Listar animais");
            Console.WriteLine("2: Cadastrar novos animais");
            Console.WriteLine("3: Deletar cadastro");
            Console.WriteLine("4: Sair");
            readResult = Console.ReadLine();
        }

        if(readResult == "4")
            Console.WriteLine("Obrigado por visitar a Contoso Pets!😊");
    }
}