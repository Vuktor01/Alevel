using System;
using System.Collections.Generic;
using System.Linq;

public class CRUDOperations
{
    public static void CreatePet(Pet pet)
    {
        using (var context = new PetContext())
        {
            context.Pets.Add(pet);
            context.SaveChanges();
        }
    }

    public static List<Pet> ReadPets()
    {
        using (var context = new PetContext())
        {
            return context.Pets.ToList();
        }
    }

    public static void UpdatePet(int petId, Pet updatedPet)
    {
        using (var context = new PetContext())
        {
            var petToUpdate = context.Pets.Find(petId);
            if (petToUpdate != null)
            {
                petToUpdate.Name = updatedPet.Name;
                petToUpdate.CategoryId = updatedPet.CategoryId;
                petToUpdate.BreedId = updatedPet.BreedId;
                petToUpdate.Age = updatedPet.Age;
                petToUpdate.LocationId = updatedPet.LocationId;
                petToUpdate.ImageUrl = updatedPet.ImageUrl;
                petToUpdate.Description = updatedPet.Description;

                context.SaveChanges();
            }
        }
    }

    public static void DeletePet(int petId)
    {
        using (var context = new PetContext())
        {
            var petToDelete = context.Pets.Find(petId);
            if (petToDelete != null)
            {
                context.Pets.Remove(petToDelete);
                context.SaveChanges();
            }
        }
    }

    public static void GroupByCategoryCountUniqueBreed(int ageThreshold, string locationName)
    {
        using (var context = new PetContext())
        {
            var result = context.Pets
                .Where(p => p.Age > ageThreshold && p.Location.LocationName == locationName)
                .GroupBy(p => p.Category.CategoryName)
                .Select(g => new
                {
                    CategoryName = g.Key,
                    UniqueBreedsCount = g.Select(p => p.Breed.BreedName).Distinct().Count()
                })
                .ToList();

            Console.WriteLine($"Group By Category and Count Unique Breeds in {locationName} with Age more than {ageThreshold}:");

            foreach (var item in result)
            {
                Console.WriteLine($"{item.CategoryName}: {item.UniqueBreedsCount} unique breeds");
            }
        }
    }
}