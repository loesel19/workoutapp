using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkoutApp.Api.Migrations
{
    /// <inheritdoc />
    public partial class fixedRepetition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Repitions",
                table: "Sets",
                newName: "Repetitions");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 27, 18, 8, 42, 484, DateTimeKind.Local).AddTicks(8011), new DateTime(2023, 9, 27, 18, 8, 42, 484, DateTimeKind.Local).AddTicks(8039) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 27, 18, 8, 42, 484, DateTimeKind.Local).AddTicks(8097), new DateTime(2023, 9, 27, 18, 8, 42, 484, DateTimeKind.Local).AddTicks(8099) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 27, 18, 8, 42, 484, DateTimeKind.Local).AddTicks(8107), new DateTime(2023, 9, 27, 18, 8, 42, 484, DateTimeKind.Local).AddTicks(8108) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 27, 18, 8, 42, 484, DateTimeKind.Local).AddTicks(8114), new DateTime(2023, 9, 27, 18, 8, 42, 484, DateTimeKind.Local).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 27, 18, 8, 42, 484, DateTimeKind.Local).AddTicks(8121), new DateTime(2023, 9, 27, 18, 8, 42, 484, DateTimeKind.Local).AddTicks(8123) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 27, 18, 8, 42, 484, DateTimeKind.Local).AddTicks(8131), new DateTime(2023, 9, 27, 18, 8, 42, 484, DateTimeKind.Local).AddTicks(8132) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 27, 18, 8, 42, 484, DateTimeKind.Local).AddTicks(8141), new DateTime(2023, 9, 27, 18, 8, 42, 484, DateTimeKind.Local).AddTicks(8143) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 27, 18, 8, 42, 484, DateTimeKind.Local).AddTicks(8151), new DateTime(2023, 9, 27, 18, 8, 42, 484, DateTimeKind.Local).AddTicks(8152) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 27, 18, 8, 42, 484, DateTimeKind.Local).AddTicks(8159), new DateTime(2023, 9, 27, 18, 8, 42, 484, DateTimeKind.Local).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 27, 18, 8, 42, 484, DateTimeKind.Local).AddTicks(8217), new DateTime(2023, 9, 27, 18, 8, 42, 484, DateTimeKind.Local).AddTicks(8219) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 27, 18, 8, 42, 484, DateTimeKind.Local).AddTicks(8226), new DateTime(2023, 9, 27, 18, 8, 42, 484, DateTimeKind.Local).AddTicks(8228) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 27, 18, 8, 42, 484, DateTimeKind.Local).AddTicks(8235), new DateTime(2023, 9, 27, 18, 8, 42, 484, DateTimeKind.Local).AddTicks(8236) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Repetitions",
                table: "Sets",
                newName: "Repitions");

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

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4164), new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4166) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4175), new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4183), new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4184) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4191), new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4198), new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4206), new DateTime(2023, 9, 27, 12, 8, 22, 803, DateTimeKind.Local).AddTicks(4208) });
        }
    }
}
