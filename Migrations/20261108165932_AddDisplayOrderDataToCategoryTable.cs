using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GemJam.Migrations;

/// <inheritdoc />
public partial class _20261108165932_AddDisplayOrderDataToCategoryTable : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.UpdateData(
            table: "Categories",
            keyColumn: "CategoryId",
            keyValue: 1,
            column: "DisplayOrder",
            value: 1);

        migrationBuilder.UpdateData(
            table: "Categories",
            keyColumn: "CategoryId",
            keyValue: 2,
            column: "DisplayOrder",
            value: 3);

        migrationBuilder.UpdateData(
            table: "Categories",
            keyColumn: "CategoryId",
            keyValue: 3,
            column: "DisplayOrder",
            value: 2);

        migrationBuilder.UpdateData(
            table: "Categories",
            keyColumn: "CategoryId",
            keyValue: 4,
            column: "DisplayOrder",
            value: 4);

        migrationBuilder.UpdateData(
            table: "Categories",
            keyColumn: "CategoryId",
            keyValue: 5,
            column: "DisplayOrder",
            value: 5);

        migrationBuilder.UpdateData(
            table: "Categories",
            keyColumn: "CategoryId",
            keyValue: 6,
            column: "DisplayOrder",
            value: 7);

        migrationBuilder.UpdateData(
            table: "Categories",
            keyColumn: "CategoryId",
            keyValue: 7,
            column: "DisplayOrder",
            value: 6);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.UpdateData(
            table: "Categories",
            keyColumn: "CategoryId",
            keyValue: 1,
            column: "DisplayOrder",
            value: 0);

        migrationBuilder.UpdateData(
            table: "Categories",
            keyColumn: "CategoryId",
            keyValue: 2,
            column: "DisplayOrder",
            value: 0);

        migrationBuilder.UpdateData(
            table: "Categories",
            keyColumn: "CategoryId",
            keyValue: 3,
            column: "DisplayOrder",
            value: 0);

        migrationBuilder.UpdateData(
            table: "Categories",
            keyColumn: "CategoryId",
            keyValue: 4,
            column: "DisplayOrder",
            value: 0);

        migrationBuilder.UpdateData(
            table: "Categories",
            keyColumn: "CategoryId",
            keyValue: 5,
            column: "DisplayOrder",
            value: 0);

        migrationBuilder.UpdateData(
            table: "Categories",
            keyColumn: "CategoryId",
            keyValue: 6,
            column: "DisplayOrder",
            value: 0);

        migrationBuilder.UpdateData(
            table: "Categories",
            keyColumn: "CategoryId",
            keyValue: 7,
            column: "DisplayOrder",
            value: 0);
    }
}
