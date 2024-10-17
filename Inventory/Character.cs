public class Character
{
    public int Hp;
    public string Name;
    public Inventory Backpack;

    public Character()
    {
        Hp = 100;
        Name = "";

        Backpack = new();

        Weapon s = new()
        {
            Name = "Sword",
            Weight = 10
        };
        Consumable p = new()
        {
            Name = "Health potion",
            Weight = 3
        };

        Backpack.Items.Add(s);
        Backpack.Items.Add(p);
    }
}
