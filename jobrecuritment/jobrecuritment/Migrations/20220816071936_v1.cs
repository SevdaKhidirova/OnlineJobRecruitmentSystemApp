using Microsoft.EntityFrameworkCore.Migrations;

namespace jobrecuritment.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "userToVacancies",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JobVacancyId",
                table: "userToVacancies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_userToVacancies_AppUserId",
                table: "userToVacancies",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_userToVacancies_JobVacancyId",
                table: "userToVacancies",
                column: "JobVacancyId");

            migrationBuilder.AddForeignKey(
                name: "FK_userToVacancies_AspNetUsers_AppUserId",
                table: "userToVacancies",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_userToVacancies_JobVacancies_JobVacancyId",
                table: "userToVacancies",
                column: "JobVacancyId",
                principalTable: "JobVacancies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userToVacancies_AspNetUsers_AppUserId",
                table: "userToVacancies");

            migrationBuilder.DropForeignKey(
                name: "FK_userToVacancies_JobVacancies_JobVacancyId",
                table: "userToVacancies");

            migrationBuilder.DropIndex(
                name: "IX_userToVacancies_AppUserId",
                table: "userToVacancies");

            migrationBuilder.DropIndex(
                name: "IX_userToVacancies_JobVacancyId",
                table: "userToVacancies");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "userToVacancies");

            migrationBuilder.DropColumn(
                name: "JobVacancyId",
                table: "userToVacancies");
        }
    }
}
