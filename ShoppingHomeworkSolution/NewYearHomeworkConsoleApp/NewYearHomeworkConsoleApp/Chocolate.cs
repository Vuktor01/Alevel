
public class Chocolate : SweetBase
{
    public string ChocolateType { get; set; }

    public Chocolate(string name, double weight, double sugarContent, double price, string chocolateType)
        : base(name, weight, sugarContent, price)
    {
        ChocolateType = chocolateType;
    }
}