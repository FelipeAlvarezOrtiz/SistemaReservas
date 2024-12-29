using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SistemaReservas.Core;

namespace SistemaReservas.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<AppUser> Usuarios { get; set; }
        public DbSet<Moneda> Monedas { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<ServicioDelProfesional> ServiciosDelProfesional { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
    }
}
