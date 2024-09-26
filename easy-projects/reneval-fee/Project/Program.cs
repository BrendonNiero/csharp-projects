Random random = new();

int dayUntilExpiration = random.Next(12);
int discountPercentage = 0;

if(discountPercentage <= 10){
    if(discountPercentage <= 5){
        Console.WriteLine($"Your subscription expires in {dayUntilExpiration} days.\nRenew now and save 10%!");
    } else if( discountPercentage == 1){
        Console.WriteLine("Your subscription expires within a day!\nRenew now and save 20%!");
    } else if(discountPercentage == 0){
        Console.WriteLine("Your subscription has expired.");
    }
    else {
        Console.WriteLine("Your subscription will expire soon. Renew now!");
    }
} 