using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcGooodBoooks.Migrations
{
    /// <inheritdoc />
    public partial class AddStarsReview : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "StarsGiven" },
                values: new object[] { new DateTime(2024, 5, 27, 19, 2, 14, 243, DateTimeKind.Local).AddTicks(5902), 4 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "StarsGiven" },
                values: new object[] { new DateTime(2024, 5, 27, 18, 54, 36, 151, DateTimeKind.Local).AddTicks(904), 0 });
        }
    }
}
