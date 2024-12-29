using System.ComponentModel.DataAnnotations;

namespace SistemaReservas.Core
{
    public sealed class Moneda
    {
        public int Id { get; set; }
        [MaxLength(100),Required]
        public required string Nombre { get; set; }
    }
}
