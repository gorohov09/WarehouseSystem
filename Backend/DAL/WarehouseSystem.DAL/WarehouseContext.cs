using Microsoft.EntityFrameworkCore;
using WarehouseSystem.DAL.Models;

namespace WarehouseSystem.DAL
{
    public class WarehouseContext : DbContext
    {
        public WarehouseContext(DbContextOptions<WarehouseContext> options )
            : base( options ) {}

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductExemplar> ProductExemplars { get; set; }

        public DbSet<Supply> Supplies { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<BooksAuthorsEntity>().HasKey(u => new { u.AuthorID, u.ISBN });

            //Настройка связи многие-ко-многим между авторами и книгами
            modelBuilder
            .Entity<Product>()
            .HasMany(c => c.Suppliers)
            .WithMany(s => s.Products)
            .UsingEntity<Supply>(
               j => j
                .HasOne(pt => pt.Supplier)
                .WithMany(t => t.Deliveries)
                .HasForeignKey(pt => pt.SupplierId),
            j => j
                .HasOne(pt => pt.Product)
                .WithMany(p => p.Deliveries)
                .HasForeignKey(pt => pt.ProductId),
            j =>
            {
                j.HasKey(t => new { t.ProductId, t.SupplierId });
                j.ToTable("Deliveries");
            });

        }
    }
}
