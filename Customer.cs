public class Customer
{

    public double moneyOwned;
    public double moneyInserted;

    public List<Drinks> drinksCart;
    public List<Snacks> snacksCart;

    public Customer()
    {
        drinksCart = new List<Drinks>();
        snacksCart = new List<Snacks>();
    }

    public double GetRandomAmount(double min, double max)
    {
        double moneyAmount;
        Random random = new Random();
        moneyAmount = random.NextDouble() * (max - min) + min;
        moneyAmount = Math.Round(moneyAmount, 0);
        return moneyAmount;
    }

    public void AddDrink(Drinks drinkItem)
    {
        if (drinkItem == null)
        {
            return;
        }

        drinksCart.Add(drinkItem);
    }
    public void AddSnack(Snacks snackItem)
    {
        if (snackItem == null)
        {
            return;
        }

        snacksCart.Add(snackItem);
    }

    public void CheckReceipt()
    {
        if (drinksCart.Count == 0 && snacksCart.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nYou haven't bought anything... yet.");
            Console.ResetColor();
            return;
        }

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n**** RECEIPT ****");
        Console.ResetColor();

        foreach (var drink in drinksCart)
        {
            Console.WriteLine($"1x {drink.Name} - {drink.Price}kr.");
        }
        foreach (var snack in snacksCart)
        {
            Console.WriteLine($"1x {snack.Name} - {snack.Price}kr.");
        }

        var drinkCost = drinksCart.Sum(p => p.Price);
        var snackCost = snacksCart.Sum(p => p.Price);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n**** TOTAL ****");
        Console.ResetColor();
        Console.WriteLine($"{drinkCost + snackCost}kr");
    }
}