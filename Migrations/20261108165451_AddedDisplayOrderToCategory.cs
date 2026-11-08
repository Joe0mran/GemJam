using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GemJam.Migrations;

/// <inheritdoc />
public partial class _20261108165451_AddedDisplayOrderToCategory : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<int>(
            name: "DisplayOrder",
            table: "Categories",
            type: "int",
            nullable: false,
            defaultValue: 0);

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

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "DisplayOrder",
            table: "Categories");
    }
}
