Customer newCustomer = new Customer();
newCustomer.moneyOwned = newCustomer.GetRandomAmount(20.0, 200.0);

Console.WriteLine($"The customer has {newCustomer.moneyOwned}kr to spend.");