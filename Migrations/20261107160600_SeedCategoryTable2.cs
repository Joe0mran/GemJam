using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GemJam.Migrations;

/// <inheritdoc />
public partial class _20261107160600_SeedCategoryTable2 : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.UpdateData(
            table: "Categories",
            keyColumn: "CategoryId",
            keyValue: 1,
            column: "Name",
            value: "Rings");

        migrationBuilder.UpdateData(
            table: "Categories",
            keyColumn: "CategoryId",
            keyValue: 2,
            column: "Name",
            value: "Earings");

        migrationBuilder.UpdateData(
            table: "Categories",
            keyColumn: "CategoryId",
            keyValue: 3,
            column: "Name",
            value: "Bracelets");

        migrationBuilder.InsertData(
            table: "Categories",
            columns: new[] { "CategoryId", "Name" },
            values: new object[] { 7, "Colliers" });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DeleteData(
            table: "Categories",
            keyColumn: "CategoryId",
            keyValue: 7);

        migrationBuilder.UpdateData(
            table: "Categories",
            keyColumn: "CategoryId",
            keyValue: 1,
            column: "Name",
            value: "Ring");

        migrationBuilder.UpdateData(
            table: "Categories",
            keyColumn: "CategoryId",
            keyValue: 2,
            column: "Name",
            value: "Earing");

        migrationBuilder.UpdateData(
            table: "Categories",
            keyColumn: "CategoryId",
            keyValue: 3,
            column: "Name",
            value: "Bracelet");
    }
}
