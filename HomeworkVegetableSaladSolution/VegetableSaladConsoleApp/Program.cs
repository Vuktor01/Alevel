namespace VegetableSaladConsoleApp
{
    class Program
    {
        static void Main()
        {

            LeafyGreen spinach = new LeafyGreen("Spinach", 200, 23, true);
            RootVegetable carrot = new RootVegetable("Carrot", 150, 41, true);


            Salad mySalad = new Salad();

   
            mySalad.AddVegetable(spinach);
            mySalad.AddVegetable(carrot);

            double totalCalories = mySalad.GetTotalCalories();

            Console.WriteLine($"Total calories of the salad: {totalCalories} calories");
        }
    }