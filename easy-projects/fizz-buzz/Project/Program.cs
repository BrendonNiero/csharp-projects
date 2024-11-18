for(int count = 1; count <= 100; count++)
{
    if(count % 5 == 0 && count % 3 ==0)
        Console.WriteLine($"{count} - FizzBuzz");
    else if(count % 3 == 0)
        Console.WriteLine($"{count} - Fizz");
    else if(count % 5 == 0)
        Console.WriteLine($"{count} - Buzz");
    else
        Console.WriteLine(count);
}