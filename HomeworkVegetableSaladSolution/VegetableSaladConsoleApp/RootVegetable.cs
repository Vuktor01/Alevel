

namespace VegetableSaladConsoleApp
{
    public class RootVegetable : Vegetable
    {
        public bool HasEdibleRoots { get; set; }

        public RootVegetable(string name, double weight, double caloriesPer100g, bool hasEdibleRoots)
            : base(name, weight, caloriesPer100g)
        {
            HasEdibleRoots = hasEdibleRoots;
        }

        public override double CalculateCalories()
        {
            double baseCalories = base.CalculateCalories();
            return HasEdibleRoots ? baseCalories * 1.5 : baseCalories;
        }
    }
}