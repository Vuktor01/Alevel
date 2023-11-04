public abstract class SweetBase : ISweet
{
    public string Name { get; set; }
    public double Weight { get; set; }
    public double SugarContent { get; set; }
    public double Price { get; set; }

    protected SweetBase(string name, double weight, double sugarContent, double price)
    {
        Name = name;
        Weight = weight;
        SugarContent = sugarContent;
        Price = price;
    }
}