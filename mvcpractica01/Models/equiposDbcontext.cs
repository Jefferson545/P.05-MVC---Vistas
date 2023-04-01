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

    }
}
