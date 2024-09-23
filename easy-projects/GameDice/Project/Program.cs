Random dice = new();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

if(roll1 == roll2){
    Console.WriteLine("BONUS: Prémio em dobro!");
    total = total * 2;
}

if(roll2 == roll3){
    Console.WriteLine("BONUS: Prémio em dobro!");
    total = total * 2;
}

if(roll1 == roll3){
    Console.WriteLine("BONUS: Prémio em dobro!");
    total = total * 2;
}

if(roll1 == roll2 & roll2 == roll3 & roll1 == roll3){
    Console.WriteLine("BONUS: Todos os dados são iguais! Ganhou +6!");
    total += 6;
}

if(total >= 15){
    Console.WriteLine($"Você venceu o jogo! Pontuação: | {total} |");
}else{
    Console.WriteLine($"Você perdeu! Pontuação | {total} |");
}