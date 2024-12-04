int? readResult;
string? temporaryResult;


Console.WriteLine("Enter an integer value between 5 and 10");
do
{
    temporaryResult = Console.ReadLine();
    if(int.TryParse(temporaryResult), out readResult)
    {
        Console.WriteLine($"Your num is {rreadResult}");
    }
    
} while(readResult == null);