using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorkoutApp.Api.Migrations
{
    /// <inheritdoc />
    public partial class seededCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "AddedBy", "DateAdded", "DateUpdated", "IsDeleted", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, -1, new DateTime(2023, 9, 26, 11, 40, 37, 188, DateTimeKind.Local).AddTicks(2862), new DateTime(2023, 9, 26, 11, 40, 37, 188, DateTimeKind.Local).AddTicks(2889), false, "Chest", -1 },
                    { 2, -1, new DateTime(2023, 9, 26, 11, 40, 37, 188, DateTimeKind.Local).AddTicks(2912), new DateTime(2023, 9, 26, 11, 40, 37, 188, DateTimeKind.Local).AddTicks(2915), false, "Back", -1 },
                    { 3, -1, new DateTime(2023, 9, 26, 11, 40, 37, 188, DateTimeKind.Local).AddTicks(2922), new DateTime(2023, 9, 26, 11, 40, 37, 188, DateTimeKind.Local).AddTicks(2924), false, "Arms", -1 },
                    { 4, -1, new DateTime(2023, 9, 26, 11, 40, 37, 188, DateTimeKind.Local).AddTicks(2931), new DateTime(2023, 9, 26, 11, 40, 37, 188, DateTimeKind.Local).AddTicks(2932), false, "Legs", -1 },
                    { 5, -1, new DateTime(2023, 9, 26, 11, 40, 37, 188, DateTimeKind.Local).AddTicks(2939), new DateTime(2023, 9, 26, 11, 40, 37, 188, DateTimeKind.Local).AddTicks(2941), false, "Shoulders", -1 },
                    { 6, -1, new DateTime(2023, 9, 26, 11, 40, 37, 188, DateTimeKind.Local).AddTicks(2949), new DateTime(2023, 9, 26, 11, 40, 37, 188, DateTimeKind.Local).AddTicks(2951), false, "Abs", -1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
