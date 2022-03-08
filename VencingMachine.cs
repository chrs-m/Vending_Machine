public class VendingMachine
{
    private readonly List<Drinks> DrinkList = new List<Drinks>
        {
            new Drinks("Faxe kondi", 10),
            new Drinks("Vira blåtira", 12),
            new Drinks("Sockerdricka", 15),
            new Drinks("Zingo", 15),
            new Drinks("Pommac", 15),
            new Drinks("Jolt cola", 18),
        };

    private readonly List<Snacks> SnackList = new List<Snacks>
        {
            new Snacks("Nötcreme", 5),
            new Snacks("Banana skids", 5),
            new Snacks("Refreshers (5 pack)", 10),
            new Snacks("Flipper", 8),
            new Snacks("Snickers", 10),
            new Snacks("Hockey pulver", 8),

        };

    public void DrinksMenu()
    {
        var index = 1;
        foreach (var item in DrinkList)
        {
            Console.WriteLine($"{index++}. {item.Name}, {item.Price} SEK.");
        }
    }
    public void SnacksMenu()
    {
        var index = 1;
        foreach (var item in SnackList)
        {
            Console.WriteLine($"{index++}. {item.Name}, {item.Price} SEK.");
        }
    }
}