using Microsoft.EntityFrameworkCore;

namespace SistemaReservas.Core
{
    public sealed class Reserva
    {
        public required int Id { get; set; }
        public DateTime FechaReserva { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public required string UsuarioReservadorId { get; set; }
        public AppUser UsuarioReservador { get; set; }
        public required string ProfesionalAtendedorId { get; set; }
        public AppUser ProfesionalAtendedor { get; set; }
        public int ServicioId { get; set; }
        public Servicio Servicio { get; set; }
        public int MonedaId { get; set; }
        public Moneda Moneda { get; set; }
        public int TiempoEnMinutos { get; set; } = 15;
        [Precision(14,2)]
        public decimal Valor { get; set; }
        public bool Confirmada { get; set; }
        public bool Concretada { get; set; }
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
    }
}
