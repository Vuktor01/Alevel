using System.Collections.Generic;
using System.Data.Entity;

public class PetContext : DbContext
{
    public DbSet<Pet> Pets { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Breed> Breeds { get; set; }
    public DbSet<Location> Locations { get; set; }
}
