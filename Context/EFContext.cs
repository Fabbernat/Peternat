using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using PetRegistryApp.Models;

namespace PetRegistryApp.Context
{
    public class EFContext : DbContext
    {
        public EFContext(DbContextOptions<EFContext> options) : base(options)
        { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Pet> Pets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=.//DB//pets.db");
        }
        public DbSet<PetRegistryApp.Models.Owner> Owner { get; set; } = default!;
    }
}
