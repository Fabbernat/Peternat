using Microsoft.EntityFrameworkCore;
using PetRegistryApp.Models;

namespace PetRegistryApp.Data;


public class PetContext : DbContext
{
    public PetContext(DbContextOptions<PetContext> options) : base(options) { }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Pet> Pets { get; set; }
}

