
namespace ElectricApartmentManager
{
    public class Apartment
    {
        private readonly ElectricDevice[] devices;
        private int deviceCount;

        public Apartment(int maxDevices)
        {
            devices = new ElectricDevice[maxDevices];
            deviceCount = 0;
        }

        public void AddDevice(ElectricDevice device)
        {
            try
            {
                if (deviceCount < devices.Length)
                {
                    devices[deviceCount] = device;
                    deviceCount++;
                }
                else
                {
                    throw new InvalidOperationException("Cannot add more devices. Apartment is full.");
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }

        public double CalculateTotalPowerConsumption()
        {
            double totalPower = 0;
            for (int i = 0; i < deviceCount; i++)
            {
                totalPower += devices[i].CalculatePowerConsumption();
            }
            return totalPower;
        }

        public ElectricDevice FindDeviceByPowerRange(double minPower, double maxPower)
        {
            for (int i = 0; i < deviceCount; i++)
            {
                double devicePower = devices[i].CalculatePowerConsumption();
                if (devicePower >= minPower && devicePower <= maxPower)
                {
                    return devices[i];
                }
            }
            return null;
        }
    }
}
