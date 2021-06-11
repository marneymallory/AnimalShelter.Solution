using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
      : base(options)
    {   
    }

    public DbSet<Animal> Animals { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "Suzie Cream Cheese", Species = "Cat", Age = 7, Breed = "Calico", Description = "Very timid, very beautiful scareddy-cat. Aloofness is result of a bad psychedilic experience. Please be gentle" , Gender = "Female" },
          new Animal { AnimalId = 2, Name = "Jerry", Species = "Dog", Age = 3, Breed = "Irish Wolfhound", Description = "A gentle, giant, good boy. Loves snuggles and laying in fields of flowers.", Gender = "Male" },
          new Animal { AnimalId = 3, Name = "King Friday", Species = "Cat", Age = 2, Breed = "Maine Coon", Description = "One cool customer, doesn't give a flying fig. Has lots of floofs.", Gender = "Male" },
          new Animal { AnimalId = 4, Name = "Pancake", Species = "Dog", Age = 4, Breed = "Pomeranian", Description = "Tough and tiny, this little fuzzball has lots of spunk and sass. Enjoys treats, bellyrubs, and squeaky toys.", Gender = "Female" },
          new Animal { AnimalId = 5, Name = "Milk Cow", Species = "Cat", Age = 7, Breed = "Tuxedo", Description = "Very vocal, very affectionate mama cat just wants all of your love", Gender = "Female" },
          new Animal { AnimalId = 6, Name = "Butterfly", Species = "Dog", Age = 5, Breed = "Husky", Description = "This sweet, magical creature will accompany you through the forest, over mountains, and love you unconditionally.", Gender = "Female" }
        );
    }
  }
}