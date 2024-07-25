using Microsoft.EntityFrameworkCore;

namespace HDI_HCC.Cafeteria.Models
{
    public class Tb_HccOrdenes_Context : DbContext
    {
        public Tb_HccOrdenes_Context(DbContextOptions<Tb_HccOrdenes_Context> options) : base(options) { }

        public DbSet<Tb_HccOrdenes> Tb_HccOrdenes { get; set; }
    }
}
