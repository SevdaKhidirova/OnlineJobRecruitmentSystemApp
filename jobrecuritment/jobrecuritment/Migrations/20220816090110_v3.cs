using Microsoft.EntityFrameworkCore.Migrations;

namespace jobrecuritment.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DesiredSkills",
                table: "JobVacancies",
                newName: "WorkTime");

            migrationBuilder.AddColumn<string>(
                name: "JobTitle",
                table: "JobVacancies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RequiredAge",
                table: "JobVacancies",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobTitle",
                table: "JobVacancies");

            migrationBuilder.DropColumn(
                name: "RequiredAge",
                table: "JobVacancies");

            migrationBuilder.RenameColumn(
                name: "WorkTime",
                table: "JobVacancies",
                newName: "DesiredSkills");
        }
    }
}
