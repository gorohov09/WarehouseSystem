using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarehouseSystem.DAL.Migrations
{
    public partial class AddEx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CityProd",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DateProd",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "CityProd",
                table: "ProductExemplars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateProd",
                table: "ProductExemplars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CityProd",
                table: "ProductExemplars");

            migrationBuilder.DropColumn(
                name: "DateProd",
                table: "ProductExemplars");

            migrationBuilder.AddColumn<string>(
                name: "CityProd",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateProd",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
