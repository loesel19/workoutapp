using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorkoutApp.Api.Migrations
{
    /// <inheritdoc />
    public partial class addExerciseSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4071), new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4097) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4116), new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4118) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4125), new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4126) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4132), new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4133) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4140), new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4141) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4153), new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4154) });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "AddedBy", "CategoryId", "DateAdded", "DateUpdated", "IsDeleted", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, -1, 1, new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4164), new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4166), false, "Bench Press", -1 },
                    { 2, -1, 2, new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4175), new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4176), false, "Lateral Pull Down", -1 },
                    { 3, -1, 3, new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4183), new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4184), false, "Dumbbell Curls", -1 },
                    { 4, -1, 4, new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4191), new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4192), false, "Squat", -1 },
                    { 5, -1, 5, new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4198), new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4200), false, "Overhead Press", -1 },
                    { 6, -1, 6, new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4206), new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4208), false, "V-Ups", -1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 27, 11, 31, 25, 854, DateTimeKind.Local).AddTicks(5300), new DateTime(2023, 9, 27, 11, 31, 25, 854, DateTimeKind.Local).AddTicks(5326) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 27, 11, 31, 25, 854, DateTimeKind.Local).AddTicks(5343), new DateTime(2023, 9, 27, 11, 31, 25, 854, DateTimeKind.Local).AddTicks(5345) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 27, 11, 31, 25, 854, DateTimeKind.Local).AddTicks(5352), new DateTime(2023, 9, 27, 11, 31, 25, 854, DateTimeKind.Local).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 27, 11, 31, 25, 854, DateTimeKind.Local).AddTicks(5359), new DateTime(2023, 9, 27, 11, 31, 25, 854, DateTimeKind.Local).AddTicks(5361) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 27, 11, 31, 25, 854, DateTimeKind.Local).AddTicks(5367), new DateTime(2023, 9, 27, 11, 31, 25, 854, DateTimeKind.Local).AddTicks(5368) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 27, 11, 31, 25, 854, DateTimeKind.Local).AddTicks(5376), new DateTime(2023, 9, 27, 11, 31, 25, 854, DateTimeKind.Local).AddTicks(5378) });
        }
    }
}
