using System.Security.Cryptography;

class Hero : Character
{
    public bool isAlive { get; private set; } = true;

    public Hero(string name, int level) : base(name, level)
    {
    }

    public void IncrementLevel()
    {
        _level += 1;
    }


    public bool WonFight(int enemyLevel)
    {
        if (_level > enemyLevel)
        {
            IncrementLevel();
            return true;
        }
        else if (_level == enemyLevel)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 2);
            if (randomNumber == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    public void Died()
    {
        this.isAlive = false;
    }

}