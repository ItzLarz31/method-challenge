

BattleHandler battleHandler = new BattleHandler();
int totalWonFights = 0;
Console.Write("What is your name: ");
string heroName = Console.ReadLine() ?? "Superman";
Console.WriteLine();
Console.Write("How old are you: ");
string heroLevel = Console.ReadLine() ?? "20";
Console.WriteLine();
Hero hero = new Hero(heroName, int.Parse(heroLevel));
Console.WriteLine("You get a call about multiple villains in the area\n");
Random random = new Random();
int randomVillainCount = random.Next(2, 7);
Console.WriteLine($"Upon arriving you notice there is {randomVillainCount} enemies you have to take down.\n");
Thread.Sleep(2000);


for (int i = 0; i < randomVillainCount; i++)
{
    int randomBossChance = random.Next(0, 11);
    int randomVillainLevel = random.Next(1, int.Parse(heroLevel) + 10);
    bool victory;
    if (randomBossChance == 10)
    {
        Villain bossVillain = new Villain(9999);

        battleHandler.SimulateBattle(hero, bossVillain);
        Console.WriteLine($"The hero {heroName} stood no chance against the boss and has fallen in battle\n");
        Thread.Sleep(3000);
        Console.WriteLine("The end");
        break;
    }

    Villain villain = new Villain(randomVillainLevel);

    victory = battleHandler.SimulateBattle(hero, villain);
    Thread.Sleep(3000);

    if (victory)
    {
        battleHandler.IncrementEncounterNum();
        totalWonFights += 1;
        continue;
    }
    else
    {
        Console.WriteLine("The end");
        break;
    }

}

if (totalWonFights == randomVillainCount)
{
    Console.WriteLine($"{heroName} beat all villains and restored order once again.\n");
    Thread.Sleep(3000);
    Console.WriteLine("The end");
}