using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MvcGooodBoooks.Migrations
{
    /// <inheritdoc />
    public partial class SeedDatabaseALittle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reader",
                columns: new[] { "Id", "BirthDate", "Name", "Surname" },
                values: new object[,]
                {
                    { 2, new DateTime(1993, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jessica", "Doe" },
                    { 3, new DateTime(1990, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emma", "XXXX" },
                    { 4, new DateTime(1995, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Danna", "Doe" }
                });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 21, 13, 37, 299, DateTimeKind.Local).AddTicks(6673));

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "BookId", "CreatedDate", "ReaderId", "ReviewDescription", "StarsGiven" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2024, 5, 27, 21, 13, 37, 299, DateTimeKind.Local).AddTicks(6781), 2, "Not a fan.", 1 },
                    { 3, 1, new DateTime(2024, 5, 27, 21, 13, 37, 299, DateTimeKind.Local).AddTicks(6786), 3, "Goood.", 3 },
                    { 4, 1, new DateTime(2024, 5, 27, 21, 13, 37, 299, DateTimeKind.Local).AddTicks(6790), 4, "Not my cup of tea.", 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reader",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reader",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reader",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 19, 6, 0, 674, DateTimeKind.Local).AddTicks(3872));
        }
    }
}
