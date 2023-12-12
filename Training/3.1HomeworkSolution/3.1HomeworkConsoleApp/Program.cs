var customCollection = new CustomCollection<string>();

customCollection.Add("Tiger");
customCollection.Add("Cat");
customCollection.Add("Dog");
customCollection.Add("Elephant");


foreach (var item in customCollection)
{
    Console.WriteLine(item);
}

customCollection.Sort();

Console.WriteLine("\nSorted Collection:");

foreach (var item in customCollection)
{
    Console.WriteLine(item);
}

customCollection.SetDefaultAt(1,"Zebra");
customCollection.Sort();

Console.WriteLine("\nCollection with Zebra");

foreach (var item in customCollection)
{
    Console.WriteLine(item);
}

Console.WriteLine("\nCollection items count: " + customCollection.Count());