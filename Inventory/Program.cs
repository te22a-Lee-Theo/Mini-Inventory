Character one = new();

one.Backpack.Display();

Armor FirstHelm = new()
{
    Name = "Wooden Helmet",
    Weight = 5
};
System.Console.WriteLine($"\nYou have spotted a {FirstHelm.Name} do you wish to pick it up?  [yes/no]");

string Choise = Console.ReadLine().ToLower();
while(Choise != "yes" && Choise != "no")
{
    System.Console.WriteLine("Invalid input.\nDo you wish to pick it up  [yes/no]");
    Choise = Console.ReadLine().ToLower();
}

if (Choise == "yes")
{
    System.Console.WriteLine($"You have chosen to pick up the {FirstHelm.Name}");
    one.Backpack.Items.Add(FirstHelm);
    System.Console.WriteLine("As you've chosen to pick up the helmet, this is now your current inventory.");
    one.Backpack.Display();
}
else
{
    System.Console.WriteLine("Well, you're probably better of without.");
}



Console.ReadLine();