class Character
{
    protected string _name;
    protected int _level;

    public Character(string name = "Unknown", int level = 1)
    {
        this._name = name;
        this._level = level;
    }

    public int GetLevel()
    {
        return _level;
    }

    public string GetName()
    {
        return _name;
    }

}