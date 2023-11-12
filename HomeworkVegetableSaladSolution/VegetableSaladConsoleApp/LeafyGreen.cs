
namespace VegetableSaladConsoleApp
{
    public class LeafyGreen : Vegetable
    {
        public bool IsDarkGreen { get; set; }

        public LeafyGreen(string name, double weight, double caloriesPer100g, bool isDarkGreen)
            : base(name, weight, caloriesPer100g)
        {
            IsDarkGreen = isDarkGreen;
        }

        public override double CalculateCalories()
        {
            double baseCalories = base.CalculateCalories();
            return IsDarkGreen ? baseCalories * 1.2 : baseCalories;
        }
    }
}