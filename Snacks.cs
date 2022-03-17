public class Snacks
{
    public string Name { get; }
    public int Price { get; }
    public int Quantity { get; set; }

    public Snacks(string name, int price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }
}