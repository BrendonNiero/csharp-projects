using System;

public class Program
{
    public static void Main()
    {
        string animalNickname = "";
        string animalSpecies = "";
        int animalId = 0;
        string animalAge = "";
        string animalPhysicalDescription = "";
        string animalPersonalityDescription = "";

        int maxPets = 8;

        string? readResult;

        string[,] ourAnimals = new string[maxPets, 6];

        string? listAnimals;

        Console.WriteLine(ourAnimals);


        Console.WriteLine("------------------------ Sejá bem vindo ao Contoso Pets!🎉------------------------");
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
                Console.WriteLine("------------------------ Selecione nosso menu de listagem 📚 ------------------------");
                Console.WriteLine("1: Listar Espécies");
                Console.WriteLine("2: Nomes");
                Console.WriteLine("3: Listar IDs");
                Console.WriteLine("4: Sair");
                listAnimals = Console.ReadLine();
                while(listAnimals != "4")
                {
                    switch(listAnimals)
                    {
                        case "1":
                        Console.WriteLine($"Espécie: {animalSpecies}");
                        break;
                        case "2":
                        Console.WriteLine($"Nome: {animalNickname}");
                        break;
                        case "3":
                        Console.WriteLine($"ID: {animalId}");
                        break;
                        default:
                        Console.WriteLine("Digite um valor válido.");
                        break;
                    }
                        Console.WriteLine("------------------------ Selecione nosso menu de listagem 📚 ------------------------");
                        Console.WriteLine("1: Listar Espécies");
                        Console.WriteLine("2: Nomes");
                        Console.WriteLine("3: Listar IDs");
                        Console.WriteLine("4: Sair");
                        listAnimals = Console.ReadLine();
                }
                break;
                case "2":
                    Console.WriteLine("Digite o nome do animal.");
                    animalNickname = Console.ReadLine();
                    Console.WriteLine("Digite a espécie do animal. (Cão, Gato...)");
                    animalSpecies = Console.ReadLine();
                    Console.WriteLine("Digite a idade do animal em anos.");
                    animalAge = Console.ReadLine();
                    Console.WriteLine("Descreva o físico do seu animal.");
                    animalPhysicalDescription = Console.ReadLine();
                    Console.WriteLine("Descreva a personalidade do seu animal.");
                    animalPersonalityDescription = Console.ReadLine();
                    Console.WriteLine("Confira se suas informações estão corretas:");
                    Console.WriteLine($"• {animalNickname}\n• {animalSpecies}\n• {animalAge}\n• {animalPhysicalDescription}\n• {animalPersonalityDescription}");
                break;
                case "3":
                Console.WriteLine("Ainda não conseguimos deletar cadastros");
                break;
                case "4":
                Console.WriteLine("Tchau!");
                break;
            }

            Console.WriteLine("------------------------ Sejá bem vindo ao Contoso Pets!🎉------------------------");
            Console.WriteLine("1: Listar animais");
            Console.WriteLine("2: Cadastrar novos animais");
            Console.WriteLine("3: Deletar cadastro");
            Console.WriteLine("4: Sair");
            readResult = Console.ReadLine();
        }

        if(readResult == "4")
            Console.WriteLine("Obrigado por visitar a Contoso Pets!");
    }
}

public class Animal 
{
    public int Id { get; set; }
    public string NickName { get; set; }
    public string Specie { get; set; }
    public int Age  { get; set; }
    public string PhysicalDescription { get; set; }
    public string PersonalityDescription { get; set; }
}