using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace SistemaReservas.Core
{
    public sealed class Feedback
    {
        public Guid Id { get; set; }
        public required string ProfesionalAtendedorId { get; set; }
        public AppUser ProfesionalAtendedor { get; set; }
        public required string UsuarioReviewerId { get; set; }
        public AppUser UsuarioReviewer { get; set;}
        [MaxLength(800)]
        public required string Comentario { get; set; }
        [Precision(14,2)]
        public decimal Estrellas { get; set; }
        public DateTime Fecha { get; set; }
        public int AtencionId { get; set; }
        public Reserva Atencion { get; set; }
    }
}
