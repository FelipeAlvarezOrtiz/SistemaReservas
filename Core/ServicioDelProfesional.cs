using Microsoft.EntityFrameworkCore;

namespace SistemaReservas.Core
{
    public class ServicioDelProfesional
    {
        public required string ProfesionalId { get; set; }
        public AppUser Profesional { get; set; }
        public required int ServicioId { get; set; }
        public Servicio Servicio { get; set; }
        public required int MonedaId { get; set; }
        public Moneda Moneda { get; set; }
        public required int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }

        public int TiempoEnMinutos { get; set; } = 0;
        [Precision(14, 2)] 
        public decimal Valor { get; set; } = 0;
    }
}
