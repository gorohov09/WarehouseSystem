using Microsoft.EntityFrameworkCore;
using WarehouseSystem.Domain;

namespace WarehouseSystem.DAL
{
    public class WarehouseContext : DbContext
    {
        public WarehouseContext(DbContextOptions<WarehouseContext> options )
            : base( options ) {}

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductExemplar> ProductExemplars { get; set; }
    }
}
