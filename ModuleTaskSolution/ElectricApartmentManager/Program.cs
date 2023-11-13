
using ElectricApartmentManager;

Apartment myApartment = new Apartment(5);

ElectricDevice fridge = new Refrigerator("Samsung Fridge", 150, 200);
ElectricDevice tv = new Television("Sony TV", 100, 55);
ElectricDevice computer = new Computer("Custom PC", 500, "Intel i7");

fridge.PlugIn();
tv.PlugIn();
computer.PlugIn();

myApartment.AddDevice(fridge);
myApartment.AddDevice(tv);
myApartment.AddDevice(computer);

fridge.TurnOn();
tv.TurnOn();
computer.TurnOn();

double totalPower = myApartment.CalculateTotalPowerConsumption();
Console.WriteLine($"Total Power Consumption: {totalPower} Watts");

double minPower = 100;
double maxPower = 300;
ElectricDevice deviceInRange = myApartment.FindDeviceByPowerRange(minPower, maxPower);

if (deviceInRange != null)
{
    Console.WriteLine($"Device in Range ({minPower} - {maxPower} Watts): {deviceInRange.Name} - {deviceInRange.CalculatePowerConsumption()} Watts");
}
else
{
    Console.WriteLine("No device found in the specified power range.");
}

fridge.TurnOff();
tv.TurnOff();
computer.TurnOff();
fridge.Unplug();
tv.Unplug();
computer.Unplug();

