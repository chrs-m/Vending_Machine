public class VendingMachine
{
    private readonly List<Drinks> DrinkList = new List<Drinks>
        {
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

    public Drinks BuyDrink(string input, int money)
    {
        int.TryParse(input, out int number);

        if (number > 5 || number < 1)
        {
            return null;
        }

        var selectedDrink = DrinkList[number - 1];

        if (selectedDrink.Price > money)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nYou don't have enough money to buy this.");
            Console.ResetColor();
            return null;
        }

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nYou have selected {selectedDrink.Name}, that'll be {selectedDrink.Price}kr.");
        Console.ResetColor();
        return selectedDrink;
    }
}