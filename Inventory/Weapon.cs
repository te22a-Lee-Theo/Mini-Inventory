public class Weapon : Item
{
    public int MinDmg;
    public int MaxDmg;
    public int Attack()
    {
        return Random.Shared.Next(MinDmg, MaxDmg);
    }
}
