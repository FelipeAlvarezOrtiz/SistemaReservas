using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace SistemaReservas.Core
{
    public class AppUser : IdentityUser
    {
        [MaxLength(125),Required]
        public required string Nombres { get; set; }
        [Required,MaxLength(125)]
        public required string PrimerApellido { get; set; }
        [MaxLength(125)]
        public string? SegundoApellido { get; set; }
        [MaxLength(35)]
        public string? IdentificadorTributario { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        [Required]
        public required DateTime FechaCreacion { get; set; } = DateTime.Now;
        public bool Activo { get; set; }

        public required int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
    }
}
