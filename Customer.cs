public class Customer
{

    public double moneyOwned;
    public double moneyInserted;

    public double GetRandomAmount(double min, double max)
    {
        double moneyAmount;
        Random random = new Random();
        moneyAmount = random.NextDouble() * (max - min) + min;
        moneyAmount = Math.Round(moneyAmount, 0);
        return moneyAmount;
    }
}