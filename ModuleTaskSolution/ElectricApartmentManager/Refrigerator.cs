
namespace ElectricApartmentManager
{
    public class Refrigerator : ElectricDevice
    {
        public int Capacity { get; set; }

        public Refrigerator(string name, double power, int capacity) : base(name, power)
        {
            Capacity = capacity;
        }

        public override void TurnOn()
        {
            Console.WriteLine($"{Name} is now ON. Cooling started.");
        }

        public override void TurnOff()
        {
            Console.WriteLine($"{Name} is now OFF. Cooling stopped.");
        }
    }
}
