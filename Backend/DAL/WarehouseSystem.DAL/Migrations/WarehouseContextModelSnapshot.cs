﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WarehouseSystem.DAL;

#nullable disable

namespace WarehouseSystem.DAL.Migrations
{
    [DbContext(typeof(WarehouseContext))]
    partial class WarehouseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WarehouseSystem.DAL.Models.Product", b =>
                {
                    b.Property<int>("ProductSKU")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductSKU"), 1L, 1);

                    b.Property<bool>("IsCertificatePresent")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("PriceProd")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductSKU");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("WarehouseSystem.DAL.Models.ProductExemplar", b =>
                {
                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Code"), 1L, 1);

                    b.Property<int>("CellNumber")
                        .HasColumnType("int");

                    b.Property<string>("CityProd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateProd")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductSKU")
                        .HasColumnType("int");

                    b.Property<int>("RowNumber")
                        .HasColumnType("int");

                    b.HasKey("Code");

                    b.HasIndex("ProductSKU");

                    b.ToTable("ProductExemplars");
                });

            modelBuilder.Entity("WarehouseSystem.DAL.Models.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("WarehouseSystem.DAL.Models.Supply", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductId", "SupplierId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Deliveries", (string)null);
                });

            modelBuilder.Entity("WarehouseSystem.DAL.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WarehouseSystem.DAL.Models.ProductExemplar", b =>
                {
                    b.HasOne("WarehouseSystem.DAL.Models.Product", "Product")
                        .WithMany("Exemplars")
                        .HasForeignKey("ProductSKU")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WarehouseSystem.DAL.Models.Supply", b =>
                {
                    b.HasOne("WarehouseSystem.DAL.Models.Product", "Product")
                        .WithMany("Deliveries")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WarehouseSystem.DAL.Models.Supplier", "Supplier")
                        .WithMany("Deliveries")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("WarehouseSystem.DAL.Models.Product", b =>
                {
                    b.Navigation("Deliveries");

                    b.Navigation("Exemplars");
                });

            modelBuilder.Entity("WarehouseSystem.DAL.Models.Supplier", b =>
                {
                    b.Navigation("Deliveries");
                });
#pragma warning restore 612, 618
        }
    }
}
