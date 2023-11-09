

namespace VegetableSaladConsoleApp
{
    public class Salad
    {
        private Vegetable[] vegetables = new Vegetable[0];
        private int count = 0;

        public void AddVegetable(Vegetable vegetable)
        {
            Array.Resize(ref vegetables, count + 1);
            vegetables[count] = vegetable;
            count++;
        }

        public double GetTotalCalories()
        {
            double totalCalories = 0;
            foreach (var vegetable in vegetables)
            {
                totalCalories += vegetable.CalculateCalories();
            }
            return totalCalories;
        }
    }
}