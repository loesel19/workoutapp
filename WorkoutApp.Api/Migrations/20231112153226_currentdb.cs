using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorkoutApp.Api.Migrations
{
    /// <inheritdoc />
    public partial class currentdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "AddedBy", "DateAdded", "DateUpdated", "IsDeleted", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, -1, new DateTime(2023, 11, 12, 10, 32, 26, 867, DateTimeKind.Local).AddTicks(7503), new DateTime(2023, 11, 12, 10, 32, 26, 867, DateTimeKind.Local).AddTicks(7525), false, "Chest", -1 },
                    { 2, -1, new DateTime(2023, 11, 12, 10, 32, 26, 867, DateTimeKind.Local).AddTicks(7543), new DateTime(2023, 11, 12, 10, 32, 26, 867, DateTimeKind.Local).AddTicks(7544), false, "Back", -1 },
                    { 3, -1, new DateTime(2023, 11, 12, 10, 32, 26, 867, DateTimeKind.Local).AddTicks(7551), new DateTime(2023, 11, 12, 10, 32, 26, 867, DateTimeKind.Local).AddTicks(7552), false, "Arms", -1 },
                    { 4, -1, new DateTime(2023, 11, 12, 10, 32, 26, 867, DateTimeKind.Local).AddTicks(7559), new DateTime(2023, 11, 12, 10, 32, 26, 867, DateTimeKind.Local).AddTicks(7560), false, "Legs", -1 },
                    { 5, -1, new DateTime(2023, 11, 12, 10, 32, 26, 867, DateTimeKind.Local).AddTicks(7566), new DateTime(2023, 11, 12, 10, 32, 26, 867, DateTimeKind.Local).AddTicks(7567), false, "Shoulders", -1 },
                    { 6, -1, new DateTime(2023, 11, 12, 10, 32, 26, 867, DateTimeKind.Local).AddTicks(7575), new DateTime(2023, 11, 12, 10, 32, 26, 867, DateTimeKind.Local).AddTicks(7576), false, "Abs", -1 }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "AddedBy", "CategoryId", "DateAdded", "DateUpdated", "IsDeleted", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, -1, 1, new DateTime(2023, 11, 12, 10, 32, 26, 867, DateTimeKind.Local).AddTicks(7586), new DateTime(2023, 11, 12, 10, 32, 26, 867, DateTimeKind.Local).AddTicks(7587), false, "Bench Press", -1 },
                    { 2, -1, 2, new DateTime(2023, 11, 12, 10, 32, 26, 867, DateTimeKind.Local).AddTicks(7596), new DateTime(2023, 11, 12, 10, 32, 26, 867, DateTimeKind.Local).AddTicks(7598), false, "Lateral Pull Down", -1 },
                    { 3, -1, 3, new DateTime(2023, 11, 12, 10, 32, 26, 867, DateTimeKind.Local).AddTicks(7604), new DateTime(2023, 11, 12, 10, 32, 26, 867, DateTimeKind.Local).AddTicks(7605), false, "Dumbbell Curls", -1 },
                    { 4, -1, 4, new DateTime(2023, 11, 12, 10, 32, 26, 867, DateTimeKind.Local).AddTicks(7611), new DateTime(2023, 11, 12, 10, 32, 26, 867, DateTimeKind.Local).AddTicks(7613), false, "Squat", -1 },
                    { 5, -1, 5, new DateTime(2023, 11, 12, 10, 32, 26, 867, DateTimeKind.Local).AddTicks(7619), new DateTime(2023, 11, 12, 10, 32, 26, 867, DateTimeKind.Local).AddTicks(7620), false, "Overhead Press", -1 }
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
