using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GemJam.Migrations;

/// <inheritdoc />
public partial class _20261107155858_SeedCategoryTable1 : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.InsertData(
            table: "Categories",
            columns: new[] { "CategoryId", "Name" },
            values: new object[,]
            {
                { 1, "Ring" },
                { 2, "Earing" },
                { 3, "Bracelet" },
                { 4, "Necklaces" },
                { 5, "Bangles" },
                { 6, "Piercings" }
            });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DeleteData(
            table: "Categories",
            keyColumn: "CategoryId",
            keyValue: 1);

        migrationBuilder.DeleteData(
            table: "Categories",
            keyColumn: "CategoryId",
            keyValue: 2);

        migrationBuilder.DeleteData(
            table: "Categories",
            keyColumn: "CategoryId",
            keyValue: 3);

        migrationBuilder.DeleteData(
            table: "Categories",
            keyColumn: "CategoryId",
            keyValue: 4);

        migrationBuilder.DeleteData(
            table: "Categories",
            keyColumn: "CategoryId",
            keyValue: 5);

        migrationBuilder.DeleteData(
            table: "Categories",
            keyColumn: "CategoryId",
            keyValue: 6);
    }
}
