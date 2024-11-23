using System.ComponentModel.Design.Serialization;

int heroHealth = 10;
int monsterHealth = 10;
Random random = new Random();
int num = 10;

while(heroHealth > 0 && monsterHealth > 0){
    int damage = random.Next(1, 11);
    monsterHealth = monsterHealth - damage;
    Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monsterHealth} health.");

    damage = random.Next(1, 11);
    heroHealth = heroHealth - damage;
    Console.WriteLine($"Hero was damaged and lost {damage} health and now has {heroHealth} health.");
}

Console.WriteLine(heroHealth > monsterHealth ? "Hero Win!" : "Monster Win!");