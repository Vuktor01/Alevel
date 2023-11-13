
namespace ElectricApartmentManager
{
    public class Television : ElectricDevice
    {
        public int ScreenSize { get; set; }

        public Television(string name, double power, int screenSize) : base(name, power)
        {
            ScreenSize = screenSize;
        }

        public override void TurnOn()
        {
            Console.WriteLine($"{Name} is now ON. Enjoy watching!");
        }

        public override void TurnOff()
        {
            Console.WriteLine($"{Name} is now OFF. Screen turned off.");
        }
    }
}
