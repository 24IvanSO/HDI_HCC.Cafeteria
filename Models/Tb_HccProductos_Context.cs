using Microsoft.EntityFrameworkCore;

namespace HDI_HCC.Cafeteria.Models
{
    public class Tb_HccProductos_Context : DbContext
    {
        public Tb_HccProductos_Context(DbContextOptions<Tb_HccProductos_Context> options) : base(options) { }
        
        public DbSet<Tb_HccProductos> Tb_HccProductos { get; set; }

    }
}
