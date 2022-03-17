public class Drinks
{
    public string Name { get; }
    public int Price { get; }
    public int Quantity { get; set; }

    public Drinks(string name, int price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }
}