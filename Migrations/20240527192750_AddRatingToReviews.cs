using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcGooodBoooks.Migrations
{
    /// <inheritdoc />
    public partial class AddRatingToReviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 21, 27, 46, 271, DateTimeKind.Local).AddTicks(5945));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 21, 27, 46, 271, DateTimeKind.Local).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 21, 27, 46, 271, DateTimeKind.Local).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 21, 27, 46, 271, DateTimeKind.Local).AddTicks(6026));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 21, 13, 37, 299, DateTimeKind.Local).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 21, 13, 37, 299, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 21, 13, 37, 299, DateTimeKind.Local).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 21, 13, 37, 299, DateTimeKind.Local).AddTicks(6790));
        }
    }
}
