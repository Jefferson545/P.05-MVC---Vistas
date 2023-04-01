using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using webApipractica.Models;
namespace mvcpractica01.Models
{
    public class equiposDbcontext : DbContext
    {
        public equiposDbcontext(DbContextOptions<equiposDbcontext> options) : base(options)
        {
        }
        public DbSet<marcas> marcas { get; set; }
        public DbSet<webApipractica.Models.estados_equipo>? estados_equipo { get; set; }
        public DbSet<webApipractica.Models.estados_reserva>? estados_reserva { get; set; }
        public DbSet<webApipractica.Models.facultades>? facultades { get; set; }
        public DbSet<webApipractica.Models.tipo_equipo>? tipo_equipo { get; set; }
        public DbSet<webApipractica.Models.usuarios>? usuarios { get; set; }
        public DbSet<webApipractica.Models.carreras>? carreras { get; set; }

    }
}
