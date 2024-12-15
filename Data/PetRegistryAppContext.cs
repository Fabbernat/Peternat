using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetRegistryApp.Models;

namespace PetRegistryApp.Data
{
    public class PetRegistryAppContext : DbContext
    {
        public PetRegistryAppContext (DbContextOptions<PetRegistryAppContext> options)
            : base(options)
        {
        }

        public DbSet<PetRegistryApp.Models.Category> Category { get; set; } = default!;
    }
}
