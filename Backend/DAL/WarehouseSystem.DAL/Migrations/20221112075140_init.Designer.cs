﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WarehouseSystem.DAL;

#nullable disable

namespace WarehouseSystem.DAL.Migrations
{
    [DbContext(typeof(WarehouseContext))]
    [Migration("20221112075140_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WarehouseSystem.Domain.Product", b =>
                {
                    b.Property<int>("ProductSKU")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductSKU"), 1L, 1);

                    b.Property<string>("CityProd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateProd")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsCertificatePresent")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumbOfCopies")
                        .HasColumnType("int");

                    b.Property<decimal>("PriceProd")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("VendorNumber")
                        .HasColumnType("int");

                    b.HasKey("ProductSKU");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("WarehouseSystem.Domain.ProductExemplar", b =>
                {
                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Code"), 1L, 1);

                    b.Property<int>("CellNumber")
                        .HasColumnType("int");

                    b.Property<int>("ProductSKU")
                        .HasColumnType("int");

                    b.Property<int>("RowNumber")
                        .HasColumnType("int");

                    b.HasKey("Code");

                    b.HasIndex("ProductSKU");

                    b.ToTable("ProductExemplars");
                });

            modelBuilder.Entity("WarehouseSystem.Domain.ProductExemplar", b =>
                {
                    b.HasOne("WarehouseSystem.Domain.Product", "Product")
                        .WithMany("Exemplars")
                        .HasForeignKey("ProductSKU")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WarehouseSystem.Domain.Product", b =>
                {
                    b.Navigation("Exemplars");
                });
#pragma warning restore 612, 618
        }
    }
}