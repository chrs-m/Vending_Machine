void snacksAndStuff(VendingMachine vendingMachine, Customer newCustomer)
{

    Console.Clear();

    while (true)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("\n**** MENU ****");
        Console.ResetColor();

        Console.WriteLine("1. Drinks");
        Console.WriteLine("2. Snacks");
        Console.WriteLine("9. Back");


        var menuInput = Console.ReadLine();

        if (menuInput == "1")
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n**** DRINKS ****");
            Console.ResetColor();
            vendingMachine.DrinksMenu();
            Console.WriteLine("9. Go back.");
            var drinkChoice = Console.ReadLine();
            var drinkItem = vendingMachine.BuyDrink(drinkChoice, newCustomer.moneyOwned);

            if (drinkChoice == "9")
            {
                Console.Clear();
                return;

            }

            if (drinkChoice == null)
            {
                continue;
            }

            Console.WriteLine("\nDo you want anything else?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            var answer = Console.ReadLine();

            if (answer == "1")
            {
                Console.Clear();
                continue;
            }

            if (answer == "2")
            {
                Console.Clear();
                break;
            }
        }

        if (menuInput == "2")
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n**** SNACKS ****");
            Console.ResetColor();

            vendingMachine.SnacksMenu();
            Console.WriteLine("9. Go back");
            var snacksChoice = Console.ReadLine();

            if (snacksChoice == "9")
            {
                Console.Clear();
                continue;
            }

            if (snacksChoice == null)
            {
                continue;
            }

            Console.WriteLine("\nDo you want anything else?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            var answer = Console.ReadLine();

            if (answer == "1")
            {
                Console.Clear();
                continue;
            }

            if (answer == "2")
            {
                Console.Clear();
                break;
            }
        }
    }

}

var vendingMachine = new VendingMachine();
Customer newCustomer = new Customer();
newCustomer.moneyOwned = newCustomer.GetRandomAmount(5.0, 100.0);

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n**** Vending machine 1.0 ****");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Green;


while (true)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("\n***** PLEASE CHOOSE A NUMBER BELOW ***** ");

    Console.ResetColor();
    Console.WriteLine("1. Snacks & Drinks");
    Console.WriteLine("2. Check amount");
    Console.WriteLine("3. See receipt");
    Console.WriteLine("9. Exit");


    var input = Console.ReadLine();

    switch (input)
    {
        case "1":
 //           vendingMachine.sanaksandstuff(newcustomer);
            snacksAndStuff(vendingMachine, newCustomer);
            break;

        case "2":
            if (newCustomer.moneyOwned == 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nYour wallet is empty.");
                Console.ResetColor();
                continue;
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nYou currently have {newCustomer.moneyOwned}kr for your disposal.");
            Console.ResetColor();
            continue;

        case "3":
            Console.Clear();
            newCustomer.CheckReceipt();
            continue;

        case "9":
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Good bye!");
            break;
    }
}