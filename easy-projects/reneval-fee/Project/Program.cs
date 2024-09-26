Random random = new();

int dayUntilExpiration = random.Next(12);
int discountPercentage = 0;

if(dayUntilExpiration <= 10){
    if(dayUntilExpiration <= 5){
        dayUntilExpiration = 10;
        Console.WriteLine($"Your subscription expires in {dayUntilExpiration} days.\nRenew now and save {discountPercentage}%!");
    } else if( dayUntilExpiration == 1){
        discountPercentage = 20;
        Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!");
    } else if(dayUntilExpiration == 0){
        Console.WriteLine("Your subscription has expired.");
    }
    else {
        Console.WriteLine("Your subscription will expire soon. Renew now!");
    }
} 