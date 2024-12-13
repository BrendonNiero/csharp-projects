// the ourAnimals array will store the following: 
string animalSpecies = "gato";
string animalID = "1";
string animalAge = "2";
string animalPhysicalDescription = "Gato gordo pra karalho";
string animalPersonalityDescription = "Gato preguiçoso e chato";
string animalNickname = "Capetinha";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// Controle de animais

Console.WriteLine("Selecione nosso menu de listagem:");
Console.WriteLine("1: Listar Espécies");
Console.WriteLine("2: Nomes");
Console.WriteLine("3: Listar IDs");
Console.WriteLine("4: Sair");
readResult = Console.ReadLine();

while(readResult != "4")
{
    switch(readResult)
    {
        case "1":
        Console.WriteLine($"Espécie: {animalSpecies}");
        break;
        case "2":
        Console.WriteLine($"Nome: {animalNickname}");
        break;
        case "3":
        Console.WriteLine($"ID: {animalID}");
        break;
        default:
        Console.WriteLine("Digite um valor válido.");
        break;
    }
    Console.WriteLine("Selecione nosso menu de listagem:");
    Console.WriteLine("1: Listar Espécies");
    Console.WriteLine("2: Nomes");
    Console.WriteLine("3: Listar IDs");
    Console.WriteLine("4: Sair");
    readResult = Console.ReadLine();
}

if(readResult == "4")
    Console.WriteLine("Obrigado por visitar a Contoso Pets!");