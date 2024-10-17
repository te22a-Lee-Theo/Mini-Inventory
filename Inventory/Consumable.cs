using System.Reflection.PortableExecutable;

public class Consumable : Item
{
    public int MaxUses = 5;
    public int CurrentUses = 0;
    public void Use (Character target)
    {
        if(CurrentUses<MaxUses)
        {
            target.Hp += 10;
            CurrentUses++;
        }
    }
}
