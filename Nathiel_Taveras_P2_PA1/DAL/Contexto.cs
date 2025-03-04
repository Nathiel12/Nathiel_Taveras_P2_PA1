using Microsoft.EntityFrameworkCore;
using Nathiel_Taveras_P2_PA1.Models;

namespace Nathiel_Taveras_P2_PA1.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        public DbSet<Modelo> Modelo { get; set; }
    }
}
