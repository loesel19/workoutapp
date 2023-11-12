using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorkoutApp.Api.Migrations
{
    /// <inheritdoc />
    public partial class seeddb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "AddedBy", "DateAdded", "DateUpdated", "IsDeleted", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, -1, new DateTime(2023, 11, 12, 10, 26, 26, 15, DateTimeKind.Local).AddTicks(4337), new DateTime(2023, 11, 12, 10, 26, 26, 15, DateTimeKind.Local).AddTicks(4361), false, "Chest", -1 },
                    { 2, -1, new DateTime(2023, 11, 12, 10, 26, 26, 15, DateTimeKind.Local).AddTicks(4380), new DateTime(2023, 11, 12, 10, 26, 26, 15, DateTimeKind.Local).AddTicks(4382), false, "Back", -1 },
                    { 3, -1, new DateTime(2023, 11, 12, 10, 26, 26, 15, DateTimeKind.Local).AddTicks(4389), new DateTime(2023, 11, 12, 10, 26, 26, 15, DateTimeKind.Local).AddTicks(4390), false, "Arms", -1 },
                    { 4, -1, new DateTime(2023, 11, 12, 10, 26, 26, 15, DateTimeKind.Local).AddTicks(4396), new DateTime(2023, 11, 12, 10, 26, 26, 15, DateTimeKind.Local).AddTicks(4398), false, "Legs", -1 },
                    { 5, -1, new DateTime(2023, 11, 12, 10, 26, 26, 15, DateTimeKind.Local).AddTicks(4437), new DateTime(2023, 11, 12, 10, 26, 26, 15, DateTimeKind.Local).AddTicks(4438), false, "Shoulders", -1 },
                    { 6, -1, new DateTime(2023, 11, 12, 10, 26, 26, 15, DateTimeKind.Local).AddTicks(4448), new DateTime(2023, 11, 12, 10, 26, 26, 15, DateTimeKind.Local).AddTicks(4450), false, "Abs", -1 }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "AddedBy", "CategoryId", "DateAdded", "DateUpdated", "IsDeleted", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, -1, 1, new DateTime(2023, 11, 12, 10, 26, 26, 15, DateTimeKind.Local).AddTicks(4459), new DateTime(2023, 11, 12, 10, 26, 26, 15, DateTimeKind.Local).AddTicks(4461), false, "Bench Press", -1 },
                    { 2, -1, 2, new DateTime(2023, 11, 12, 10, 26, 26, 15, DateTimeKind.Local).AddTicks(4470), new DateTime(2023, 11, 12, 10, 26, 26, 15, DateTimeKind.Local).AddTicks(4471), false, "Lateral Pull Down", -1 },
                    { 3, -1, 3, new DateTime(2023, 11, 12, 10, 26, 26, 15, DateTimeKind.Local).AddTicks(4477), new DateTime(2023, 11, 12, 10, 26, 26, 15, DateTimeKind.Local).AddTicks(4479), false, "Dumbbell Curls", -1 },
                    { 4, -1, 4, new DateTime(2023, 11, 12, 10, 26, 26, 15, DateTimeKind.Local).AddTicks(4485), new DateTime(2023, 11, 12, 10, 26, 26, 15, DateTimeKind.Local).AddTicks(4486), false, "Squat", -1 },
                    { 5, -1, 5, new DateTime(2023, 11, 12, 10, 26, 26, 15, DateTimeKind.Local).AddTicks(4493), new DateTime(2023, 11, 12, 10, 26, 26, 15, DateTimeKind.Local).AddTicks(4494), false, "Overhead Press", -1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 5);

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
        }
    }
}
