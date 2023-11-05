public class Candy : SweetBase
{
    public string Flavor { get; set; }

    public Candy(string name, double weight, double sugarContent, double price, string flavor)
        : base(name, weight, sugarContent, price)
    {
        Flavor = flavor;
    }
}