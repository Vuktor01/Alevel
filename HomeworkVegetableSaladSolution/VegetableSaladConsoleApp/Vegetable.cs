
namespace VegetableSaladConsoleApp
{
    public class Vegetable
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double CaloriesPer100g { get; set; }

        public Vegetable(string name, double weight, double caloriesPer100g)
        {
            Name = name;
            Weight = weight;
            CaloriesPer100g = caloriesPer100g;
        }

        public virtual double CalculateCalories()
        {
            return (Weight / 100) * CaloriesPer100g;
        }
    }
}