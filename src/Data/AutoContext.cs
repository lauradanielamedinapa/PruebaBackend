using Microsoft.EntityFrameworkCore;
using PruebaTecnica_Backend_CSharp.Models;

namespace PruebaTecnica_Backend_CSharp.Data
{
    public class AutoContext : DbContext
    {
        public AutoContext(DbContextOptions<AutoContext> options) : base(options) { }

        public DbSet<MarcaAuto> MarcasAutos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MarcaAuto>().HasData(
                new MarcaAuto { Id = 1, Nombre = "Toyota" },
                new MarcaAuto { Id = 2, Nombre = "Ford" },
                new MarcaAuto { Id = 3, Nombre = "Honda" }
            );
        }
    }
}
