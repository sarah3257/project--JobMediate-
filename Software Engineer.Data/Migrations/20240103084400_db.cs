using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Software_Engineer.Data.Migrations
{
    public partial class db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "_nameOffice",
                table: "Office",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "_nameAchievement",
                table: "Achievements",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Office",
                newName: "_nameOffice");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Achievements",
                newName: "_nameAchievement");
        }
    }
}
