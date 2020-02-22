using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Routine.Api.Migrations
{
    public partial class AddColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Companies",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Industry",
                table: "Companies",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Product",
                table: "Companies",
                maxLength: 100,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("5efc910b-2f45-43df-afae-620d40542800"),
                columns: new[] { "Country", "Industry", "Product" },
                values: new object[] { "USA", "Software", "Software" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("5efc910b-2f45-43df-afae-620d40542811"),
                columns: new[] { "Country", "Industry", "Product" },
                values: new object[] { "China", "ECommerce", "Goods" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("5efc910b-2f45-43df-afae-620d40542822"),
                columns: new[] { "Country", "Industry", "Product" },
                values: new object[] { "China", "Security", "Security Product" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("5efc910b-2f45-43df-afae-620d40542833"),
                columns: new[] { "Country", "Industry", "Product" },
                values: new object[] { "USA", "ECommerce", "Books" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("5efc910b-2f45-43df-afae-620d40542844"),
                columns: new[] { "Country", "Industry", "Product" },
                values: new object[] { "USA", "Internet", "Browser" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("5efc910b-2f45-43df-afae-620d40542853"),
                columns: new[] { "Country", "Industry", "Product" },
                values: new object[] { "China", "Internet", "Software" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("6fb600c1-9011-4fd7-9234-881379716400"),
                columns: new[] { "Country", "Industry", "Product" },
                values: new object[] { "China", "Internet", "Software" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("6fb600c1-9011-4fd7-9234-881379716411"),
                columns: new[] { "Country", "Industry", "Product" },
                values: new object[] { "Italy", "Football", "Football Match" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("6fb600c1-9011-4fd7-9234-881379716422"),
                columns: new[] { "Country", "Industry", "Product" },
                values: new object[] { "USA", "Internet", "Videos" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("6fb600c1-9011-4fd7-9234-881379716433"),
                columns: new[] { "Country", "Industry", "Product" },
                values: new object[] { "China", "Internet", "Songs" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("6fb600c1-9011-4fd7-9234-881379716440"),
                columns: new[] { "Country", "Industry", "Product" },
                values: new object[] { "USA", "Internet", "Software" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("6fb600c1-9011-4fd7-9234-881379716444"),
                columns: new[] { "Country", "Industry", "Product" },
                values: new object[] { "USA", "Internet", "Mail" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("bbdee09c-089b-4d30-bece-44df59237100"),
                columns: new[] { "Country", "Industry", "Product" },
                values: new object[] { "China", "ECommerce", "Software" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("bbdee09c-089b-4d30-bece-44df59237111"),
                columns: new[] { "Country", "Industry", "Product" },
                values: new object[] { "USA", "Technology", "Rocket" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("bbdee09c-089b-4d30-bece-44df59237122"),
                columns: new[] { "Country", "Industry", "Product" },
                values: new object[] { "USA", "Internet", "Tweets" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("bbdee09c-089b-4d30-bece-44df59237133"),
                columns: new[] { "Country", "Industry", "Product" },
                values: new object[] { "China", "ECommerce", "Goods" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("bbdee09c-089b-4d30-bece-44df59237144"),
                columns: new[] { "Country", "Industry", "Product" },
                values: new object[] { "USA", "Internet", "Website" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("bbdee09c-089b-4d30-bece-44df5923716c"),
                columns: new[] { "Country", "Industry", "Product" },
                values: new object[] { "USA", "Software", "Software" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Industry",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Product",
                table: "Companies");
        }
    }
}
