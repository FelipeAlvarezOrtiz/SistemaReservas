using System.ComponentModel.DataAnnotations;

namespace SistemaReservas.Core
{
    public sealed class Servicio
    {
        public int Id { get; set; }
        [MaxLength(150),Required]
        public required string Nombre { get; set; }
        public bool Activo { get; set; }
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
    }
}
