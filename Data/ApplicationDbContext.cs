using Microsoft.EntityFrameworkCore;
using PetRegistryApp.Models;

namespace PetRegistryApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Pet> Pets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Dog", Description = "Domesticated canines" },
                new Category { Id = 2, Name = "Cat", Description = "Domesticated felines" }
            );

            modelBuilder.Entity<Pet>().HasData(
                new Pet
                {
                    Id = 1,
                    Name = "Buddy",
                    Gender = "Male",
                    Age = 3,
                    Weight = 20.5,
                    PhotoUrl = "https://example.com/images/buddy.jpg",
                    CategoryId = 1
                },
                new Pet
                {
                    Id = 2,
                    Name = "Whiskers",
                    Gender = "Female",
                    Age = 2,
                    Weight = 4.2,
                    PhotoUrl = "https://example.com/images/whiskers.jpg",
                    CategoryId = 2
                }
            );
        }
    }
}
