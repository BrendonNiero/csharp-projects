int saleAmount = 1010;
int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"You have to pay: {(saleAmount - discount)}");
Console.WriteLine($"Sala value: {saleAmount}. Discount: {discount}");