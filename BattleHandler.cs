class BattleHandler
{
    public int encounterNum { get; private set; } = 1;

    public bool SimulateBattle(Hero hero, Villain villain)
    {

        int villainLevel = villain.GetLevel();
        int heroLevel = hero.GetLevel();
        string heroName = hero.GetName();
        bool playedDirty = villain.PlayDirty();

        Console.WriteLine($"Battle {encounterNum} for {heroName} is about to commence \n");

        if (villainLevel >= 9000)
        {
            Console.WriteLine($"THE VILLAINS POWER LEVEL IS OVER 9000!!!!!\n");
            Thread.Sleep(3000);
            Console.WriteLine("EVERYONE RUN, ITS THE BOSS!!!!!\n");
            return false;
        }
        else
        {
            Console.WriteLine($"His opponent has a power level of {villainLevel}\n");
            Thread.Sleep(3000);
            Console.WriteLine("Will he win?\n");
        }

        if (playedDirty)
        {
            Console.WriteLine($"ON NO....\n");
            Thread.Sleep(3000);
            Console.WriteLine("The villain played a dirty trick and there for the power of the hero was cut in half\n");
            heroLevel = heroLevel / 2;
        }

        Thread.Sleep(3000);

        bool heroWon = hero.WonFight(villainLevel);

        if (heroWon && playedDirty)
        {
            Console.WriteLine($"Against all odds {heroName} still won even after them playing dirty tricks!!!\n");
            hero.IncrementLevel();
            return true;
        }
        else if (heroWon)
        {
            Console.WriteLine($"{heroName} is the winner! They are simply stronger.\n");
            hero.IncrementLevel();
            return true;
        }
        else
        {
            Console.WriteLine($"I am sadden to have to report this but our beloved hero {heroName} has fallen in battle.\n");
            return false;
        }

    }

    public void IncrementEncounterNum()
    {
        encounterNum += 1;
    }
}