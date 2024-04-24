using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Software_Engineer.Data.Migrations
{
    public partial class try4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "achievementId",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_achievementId",
                table: "Projects",
                column: "achievementId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Achievements_achievementId",
                table: "Projects",
                column: "achievementId",
                principalTable: "Achievements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Achievements_achievementId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_achievementId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "achievementId",
                table: "Projects");
        }
    }
}
