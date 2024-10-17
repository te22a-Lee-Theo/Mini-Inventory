public class Weapon : Item
{
    public int MinDmg = 5;
    public int MaxDmg = 10;
    public int Attack()
    {
        return Random.Shared.Next(MinDmg, MaxDmg);
    }
}
