using System.ComponentModel.DataAnnotations;

namespace SistemaReservas.Core
{
    public sealed class Empresa
    {
        public int Id { get; set; }
        [MaxLength(150)]
        public required string Nombre { get; set; }
    }
}
