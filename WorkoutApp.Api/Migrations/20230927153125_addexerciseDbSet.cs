using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkoutApp.Api.Migrations
{
    /// <inheritdoc />
    public partial class addexerciseDbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercise_Categories_CategoryId",
                table: "Exercise");

            migrationBuilder.DropForeignKey(
                name: "FK_Sets_Exercise_ExerciseId",
                table: "Sets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Exercise",
                table: "Exercise");

            migrationBuilder.RenameTable(
                name: "Exercise",
                newName: "Exercises");

            migrationBuilder.RenameIndex(
                name: "IX_Exercise_CategoryId",
                table: "Exercises",
                newName: "IX_Exercises_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Exercises",
                table: "Exercises",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_Categories_CategoryId",
                table: "Exercises",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sets_Exercises_ExerciseId",
                table: "Sets",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_Categories_CategoryId",
                table: "Exercises");

            migrationBuilder.DropForeignKey(
                name: "FK_Sets_Exercises_ExerciseId",
                table: "Sets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Exercises",
                table: "Exercises");

            migrationBuilder.RenameTable(
                name: "Exercises",
                newName: "Exercise");

            migrationBuilder.RenameIndex(
                name: "IX_Exercises_CategoryId",
                table: "Exercise",
                newName: "IX_Exercise_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Exercise",
                table: "Exercise",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 26, 11, 40, 37, 188, DateTimeKind.Local).AddTicks(2862), new DateTime(2023, 9, 26, 11, 40, 37, 188, DateTimeKind.Local).AddTicks(2889) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 26, 11, 40, 37, 188, DateTimeKind.Local).AddTicks(2912), new DateTime(2023, 9, 26, 11, 40, 37, 188, DateTimeKind.Local).AddTicks(2915) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 26, 11, 40, 37, 188, DateTimeKind.Local).AddTicks(2922), new DateTime(2023, 9, 26, 11, 40, 37, 188, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 26, 11, 40, 37, 188, DateTimeKind.Local).AddTicks(2931), new DateTime(2023, 9, 26, 11, 40, 37, 188, DateTimeKind.Local).AddTicks(2932) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 26, 11, 40, 37, 188, DateTimeKind.Local).AddTicks(2939), new DateTime(2023, 9, 26, 11, 40, 37, 188, DateTimeKind.Local).AddTicks(2941) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 26, 11, 40, 37, 188, DateTimeKind.Local).AddTicks(2949), new DateTime(2023, 9, 26, 11, 40, 37, 188, DateTimeKind.Local).AddTicks(2951) });

            migrationBuilder.AddForeignKey(
                name: "FK_Exercise_Categories_CategoryId",
                table: "Exercise",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sets_Exercise_ExerciseId",
                table: "Sets",
                column: "ExerciseId",
                principalTable: "Exercise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
