using System.ComponentModel.DataAnnotations;

namespace Nathiel_Taveras_P2_PA1.Models
{
    public class Ciudades
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public double Monto { get; set; } = 0;
    }
}
