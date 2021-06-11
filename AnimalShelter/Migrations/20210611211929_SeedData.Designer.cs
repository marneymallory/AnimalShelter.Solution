﻿// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    [Migration("20210611211929_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AnimalShelter.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 7,
                            Breed = "Calico",
                            Description = "Very timid, very beautiful scareddy-cat. Aloofness is result of a bad psychedilic experience. Please be gentle",
                            Gender = "Female",
                            Name = "Suzie Cream Cheese",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 3,
                            Breed = "Irish Wolfhound",
                            Description = "A gentle, giant, good boy. Loves snuggles and laying in fields of flowers.",
                            Gender = "Male",
                            Name = "Jerry",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 2,
                            Breed = "Maine Coon",
                            Description = "One cool customer, doesn't give a flying fig. Has lots of floofs.",
                            Gender = "Male",
                            Name = "King Friday",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 4,
                            Breed = "Pomeranian",
                            Description = "Tough and tiny, this little fuzzball has lots of spunk and sass. Enjoys treats, bellyrubs, and squeaky toys.",
                            Gender = "Female",
                            Name = "Pancake",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 7,
                            Breed = "Tuxedo",
                            Description = "Very vocal, very affectionate mama cat just wants all of your love",
                            Gender = "Female",
                            Name = "Milk Cow",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 6,
                            Age = 5,
                            Breed = "Husky",
                            Description = "This sweet, magical creature will accompany you through the forest, over mountains, and love you unconditionally.",
                            Gender = "Female",
                            Name = "Butterfly",
                            Species = "Dog"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}