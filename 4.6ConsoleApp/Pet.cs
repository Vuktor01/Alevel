using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Pet
{
    public int Id { get; set; }
    public string Name { get; set; }

    [ForeignKey("Category")]
    public int CategoryId { get; set; }
    public Category Category { get; set; }

    [ForeignKey("Breed")]
    public int BreedId { get; set; }
    public Breed Breed { get; set; }

    public int Age { get; set; }

    [ForeignKey("Location")]
    public int LocationId { get; set; }
    public Location Location { get; set; }

    public string ImageUrl { get; set; }
    public string Description { get; set; }
}