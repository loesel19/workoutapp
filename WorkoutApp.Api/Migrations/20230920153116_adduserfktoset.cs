using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkoutApp.Api.Migrations
{
    /// <inheritdoc />
    public partial class adduserfktoset : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Sets_UserId",
                table: "Sets",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sets_AppUsers_UserId",
                table: "Sets",
                column: "UserId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sets_AppUsers_UserId",
                table: "Sets");

            migrationBuilder.DropIndex(
                name: "IX_Sets_UserId",
                table: "Sets");
        }
    }
}
