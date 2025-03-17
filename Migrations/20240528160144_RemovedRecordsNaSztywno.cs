using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MvcGooodBoooks.Migrations
{
    /// <inheritdoc />
    public partial class RemovedRecordsNaSztywno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1);

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
                table: "Book",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reader",
                keyColumn: "Id",
                keyValue: 1);

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

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, "Jane", "Austen" },
                    { 2, "Anne", "Kowalski" }
                });

            migrationBuilder.InsertData(
                table: "Reader",
                columns: new[] { "Id", "BirthDate", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Doe" },
                    { 2, new DateTime(1993, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jessica", "Doe" },
                    { 3, new DateTime(1990, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emma", "XXXX" },
                    { 4, new DateTime(1995, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Danna", "Doe" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "Genre", "Title" },
                values: new object[] { 1, 1, "Romance", "Pride and Prejudice" });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "BookId", "CreatedDate", "ReaderId", "ReviewDescription", "StarsGiven" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 5, 27, 21, 27, 46, 271, DateTimeKind.Local).AddTicks(5945), 1, "Excellent book! I love this book.", 5 },
                    { 2, 1, new DateTime(2024, 5, 27, 21, 27, 46, 271, DateTimeKind.Local).AddTicks(6015), 2, "Not a fan.", 1 },
                    { 3, 1, new DateTime(2024, 5, 27, 21, 27, 46, 271, DateTimeKind.Local).AddTicks(6021), 3, "Goood.", 3 },
                    { 4, 1, new DateTime(2024, 5, 27, 21, 27, 46, 271, DateTimeKind.Local).AddTicks(6026), 4, "Not my cup of tea.", 5 }
                });
        }
    }
}
