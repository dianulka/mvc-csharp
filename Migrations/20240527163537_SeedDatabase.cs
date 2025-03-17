using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MvcGooodBoooks.Migrations
{
    /// <inheritdoc />
    public partial class SeedDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { 1, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Doe" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "Genre", "Title" },
                values: new object[] { 1, 1, "Romance", "Pride and Prejudice" });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "BookId", "CreatedDate", "ReaderId", "ReviewDescription" },
                values: new object[] { 1, 1, new DateTime(2024, 5, 27, 18, 35, 34, 106, DateTimeKind.Local).AddTicks(8194), 1, "Excellent book! I love this book." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Book",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reader",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
