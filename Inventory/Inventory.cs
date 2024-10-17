public class Inventory
{
    public List<Item> Items = new();
    public void Display()
    {
        for(int i = 0; i < Items.Count; i++)
        {
            System.Console.WriteLine($"{i+1} {Items[i].Name}");
        }
    }
}
