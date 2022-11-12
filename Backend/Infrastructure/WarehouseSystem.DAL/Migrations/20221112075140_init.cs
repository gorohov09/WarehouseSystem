using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarehouseSystem.DAL.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductSKU = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityProd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateProd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumbOfCopies = table.Column<int>(type: "int", nullable: false),
                    PriceProd = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VendorNumber = table.Column<int>(type: "int", nullable: false),
                    IsCertificatePresent = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductSKU);
                });

            migrationBuilder.CreateTable(
                name: "ProductExemplars",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductSKU = table.Column<int>(type: "int", nullable: false),
                    RowNumber = table.Column<int>(type: "int", nullable: false),
                    CellNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductExemplars", x => x.Code);
                    table.ForeignKey(
                        name: "FK_ProductExemplars_Products_ProductSKU",
                        column: x => x.ProductSKU,
                        principalTable: "Products",
                        principalColumn: "ProductSKU",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductExemplars_ProductSKU",
                table: "ProductExemplars",
                column: "ProductSKU");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductExemplars");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
