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

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-IGE01LPP\\SQLEXPRESS;Initial Catalog=CompanyDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //}
    }
}
