
namespace ElectricApartmentManager
{
    public abstract class ElectricDevice : IPluggable
    {
        public string Name { get; set; }
        public double Power { get; set; }

        public ElectricDevice(string name, double power)
        {
            Name = name;
            Power = power;
        }

        public void PlugIn()
        {
            Console.WriteLine($"{Name} is plugged in.");
        }

        public void Unplug()
        {
            Console.WriteLine($"{Name} is unplugged.");
        }

        public abstract void TurnOn();
        public abstract void TurnOff();

        public double CalculatePowerConsumption()
        {
            return Power;
        }
    }
}
