using Microsoft.EntityFrameworkCore;

namespace Gimnasio.Models
{
    public class GimnasioContext : DbContext
    {
        public GimnasioContext(DbContextOptions<GimnasioContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
