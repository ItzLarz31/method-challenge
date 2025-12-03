class Villain : Character
{
    public Villain(int level) : base("Unknown", level)
    {
    }

    public bool PlayDirty()
    {
        Random random = new Random();
        int randomChance = random.Next(0, 5);
        if (randomChance == 4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}