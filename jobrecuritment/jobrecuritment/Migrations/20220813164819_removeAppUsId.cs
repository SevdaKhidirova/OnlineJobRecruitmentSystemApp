using Microsoft.EntityFrameworkCore.Migrations;

namespace jobrecuritment.Migrations
{
    public partial class removeAppUsId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_AspNetUsers_AppUserId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Educations_AspNetUsers_AppUserId",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_Experience_AspNetUsers_AppUserId",
                table: "Experience");

            migrationBuilder.DropForeignKey(
                name: "FK_Interests_AspNetUsers_AppUserId",
                table: "Interests");

            migrationBuilder.DropForeignKey(
                name: "FK_Languages_AspNetUsers_AppUserId",
                table: "Languages");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_AspNetUsers_AppUserId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalInfos_AspNetUsers_AppUserId",
                table: "PersonalInfos");

            migrationBuilder.DropIndex(
                name: "IX_PersonalInfos_AppUserId",
                table: "PersonalInfos");

            migrationBuilder.DropIndex(
                name: "IX_Links_AppUserId",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Languages_AppUserId",
                table: "Languages");

            migrationBuilder.DropIndex(
                name: "IX_Interests_AppUserId",
                table: "Interests");

            migrationBuilder.DropIndex(
                name: "IX_Experience_AppUserId",
                table: "Experience");

            migrationBuilder.DropIndex(
                name: "IX_Educations_AppUserId",
                table: "Educations");

            migrationBuilder.DropIndex(
                name: "IX_Documents_AppUserId",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "PersonalInfos");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Interests");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Experience");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Documents");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Links",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Languages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Interests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Experience",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Educations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Documents",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Interests");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Experience");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Documents");

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "PersonalInfos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Links",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Languages",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Interests",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Experience",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Educations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Documents",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonalInfos_AppUserId",
                table: "PersonalInfos",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_AppUserId",
                table: "Links",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_AppUserId",
                table: "Languages",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Interests_AppUserId",
                table: "Interests",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Experience_AppUserId",
                table: "Experience",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_AppUserId",
                table: "Educations",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_AppUserId",
                table: "Documents",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_AspNetUsers_AppUserId",
                table: "Documents",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_AspNetUsers_AppUserId",
                table: "Educations",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Experience_AspNetUsers_AppUserId",
                table: "Experience",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Interests_AspNetUsers_AppUserId",
                table: "Interests",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_AspNetUsers_AppUserId",
                table: "Languages",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_AspNetUsers_AppUserId",
                table: "Links",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalInfos_AspNetUsers_AppUserId",
                table: "PersonalInfos",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
