using System.Reflection.PortableExecutable;

public class Consumable : Item
{
    public int MaxUses;
    public int CurrentUses;
    public void Use (Character target)
    {
        if(CurrentUses<MaxUses)
        {
            target.Hp += 10;
        }
    }
}
