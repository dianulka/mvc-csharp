using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcGooodBoooks.Migrations
{
    /// <inheritdoc />
    public partial class AddEmailToReader : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StarsGiven",
                table: "Review",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "StarsGiven" },
                values: new object[] { new DateTime(2024, 5, 27, 18, 54, 36, 151, DateTimeKind.Local).AddTicks(904), 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StarsGiven",
                table: "Review");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 18, 35, 34, 106, DateTimeKind.Local).AddTicks(8194));
        }
    }
}
