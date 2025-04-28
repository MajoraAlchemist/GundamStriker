class Character
{
    public string Name;
    public int Health;
    public int MaxHealth;
    public int Attack;
    public int Defense;
    public Character(string name, int health, int attack, int defense)
    {
        Name = name;
        MaxHealth = health;
        Health = health;
        Attack = attack;
        Defense = defense;
    }

    public int CalculateDamage()
    {
        return Attack + new Random().Next(0, 3);
    }

    public void ResetStats()
    {
        Health = MaxHealth;
    }
}
