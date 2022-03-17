public class VendingMachine
{
    private readonly List<Drinks> DrinkList = new List<Drinks>
        {
            new Drinks("Vira blåtira", 12, 2),
            new Drinks("Sockerdricka", 15, 2),
            new Drinks("Zingo", 15, 2),
            new Drinks("Pommac", 15, 2),
            new Drinks("Jolt cola", 18, 2),
        };

    private readonly List<Snacks> SnackList = new List<Snacks>
        {
            new Snacks("Nötcreme", 5, 2),
            new Snacks("Banana skids", 5, 2),
            new Snacks("Refreshers (5 pack)", 10, 2),
            new Snacks("Flipper", 8, 2),
            new Snacks("Snickers", 10, 2),
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

    public Drinks BuyDrink(string input, Customer customer)
    {
        int.TryParse(input, out int number);

        if (number > DrinkList.Count || number < 1)
        {
            return null;
        }
        
        var selectedDrink = DrinkList[number - 1];
        
        if (selectedDrink.Quantity <= 0)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nSorry, end of inventory.");
            Console.ResetColor();
            return null;
        }

        if (selectedDrink.Price > customer.moneyOwned)
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
        Console.WriteLine($"\nThis will be added to your receipt.");
        Console.ResetColor();
        customer.moneyOwned -= selectedDrink.Price;
        customer.drinksCart.Add(selectedDrink);
        selectedDrink.Quantity--;
        return selectedDrink;
    }

    public Snacks BuySnacks(string input, Customer customer)
    {
        int.TryParse(input, out int number);

        if (number > SnackList.Count || number < 1)
        {
            return null;
        }
        

        var selectedSnacks = SnackList[number - 1];
        if (selectedSnacks.Quantity <= 0)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nSorry, end of inventory.");
            Console.ResetColor();
            return null;
        }

        if (selectedSnacks.Price > customer.moneyOwned)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nYou don't have enough money to buy this.");
            Console.ResetColor();
            return null;
        }


        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nYou have selected {selectedSnacks.Name}, that'll be {selectedSnacks.Price}kr.");
        Console.WriteLine($"\nThis will be added to your receipt.");
        Console.ResetColor();
        customer.moneyOwned -= selectedSnacks.Price;
        customer.snacksCart.Add(selectedSnacks);
        selectedSnacks.Quantity--;
        return selectedSnacks;
    }

}