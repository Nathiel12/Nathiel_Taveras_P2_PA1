using Microsoft.EntityFrameworkCore;
using Nathiel_Taveras_P2_PA1.Models;

namespace Nathiel_Taveras_P2_PA1.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        public DbSet<Modelo> Modelo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ciudades>().HasData(new List<Ciudades>()
            {
                new Ciudades(){Id = 1, Nombre = "Punta Cana", Monto = 0},
                new Ciudades(){Id = 2, Nombre = "Puerto Plata", Monto = 0},
                new Ciudades(){Id = 3, Nombre = "Santo Domingo", Monto = 0},
            
            });
        }

    }
}
