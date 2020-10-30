using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
      : base(options)
    {
    }

    public DbSet<Cat> Cats { get; set; }
    public DbSet<Dog> Dogs { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Cat>()
      .HasData(
          new Cat { CatId = 1, Name = "Bijou", Breed = "Tortoiseshell", Color = "Black/Brown", Age = 7, Gender = "Female" },
          new Cat { CatId = 2, Name = "George", Breed = "Ragamuffin", Color = "Grey", Age = 10, Gender = "Male" },
          new Cat { CatId = 3, Name = "Ebe", Breed = "Short-Hair", Color = "Black", Age = 13,  Gender = "Female" },
          new Cat { CatId = 4, Name = "White Shoes", Breed = "Ragamuffin", Color = "Orange/White", Age = 4, Gender = "Female" },
          new Cat { CatId = 5, Name = "Peachy Cat", Breed = "Ragamuffin", Color = "Orange", Age = 1, Gender = "Female" }
      );

      builder.Entity<Dog>()
      .HasData(
          new Dog { DogId = 6, Name = "Comet", Breed = "Labrador", Color = "Yellow", Age = 7, Gender = "Male" },
          new Dog { DogId = 7, Name = "Lizzie", Breed = "Labrador", Color = "Yellow", Age = 10, Gender = "Female" },
          new Dog { DogId = 8, Name = "Georgia", Breed = "Pug", Color = "Black", Age = 4, Gender = "Female" },
          new Dog { DogId = 9, Name = "Ruffin", Breed = "Unknown", Color = "Black/Grey", Age = 10, Gender = "Male" },
          new Dog { DogId = 10, Name = "Sir", Breed = "Rottweiler", Color = "Black/Brown", Age = 6, Gender = "Male" }
      );
  
    }
  }
}