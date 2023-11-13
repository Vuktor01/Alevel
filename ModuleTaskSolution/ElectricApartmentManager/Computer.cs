
namespace ElectricApartmentManager
{
    public class Computer : ElectricDevice
    {
        public string CPU { get; set; }

        public Computer(string name, double power, string cpu) : base(name, power)
        {
            CPU = cpu;
        }

        public override void TurnOn()
        {
            Console.WriteLine($"{Name} is now ON. Ready for work.");
        }

        public override void TurnOff()
        {
            Console.WriteLine($"{Name} is now OFF. Shutting down.");
        }
    }
}
