class Program
{
    static void Main()
    {
        CRUDOperations.CreatePet(new Pet
        {
            Name = "Fluffy",
            CategoryId = 1,
            BreedId = 1,
            Age = 4,
            LocationId = 1,
            ImageUrl = "fluffy.jpg",
            Description = "A cute fluffy pet."
        });

        CRUDOperations.CreatePet(new Pet
        {
            Name = "Buddy",
            CategoryId = 2,
            BreedId = 2,
            Age = 2,
            LocationId = 2,
            ImageUrl = "buddy.jpg",
            Description = "A friendly pet."
        });

        var petsData = CRUDOperations.ReadPets();
        Console.WriteLine("All Pets:");
        foreach (var pet in petsData)
        {
            Console.WriteLine($"{pet.Name}, {pet.Age} years old, Breed: {pet.Breed.BreedName}, Category: {pet.Category.CategoryName}, Location: {pet.Location.LocationName}");
        }

        CRUDOperations.UpdatePet(1, new Pet
        {
            Name = "Fluffy",
            CategoryId = 1,
            BreedId = 1,
            Age = 5,
            LocationId = 1,
            ImageUrl = "fluffy.jpg",
            Description = "A cute fluffy pet."
        });

        CRUDOperations.DeletePet(2);

        var ageThreshold = 3;
        var locationName = "Ukraine";
        CRUDOperations.GroupByCategoryCountUniqueBreed(ageThreshold, locationName);
    }
}