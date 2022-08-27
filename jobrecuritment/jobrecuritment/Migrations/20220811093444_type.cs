using Microsoft.EntityFrameworkCore.Migrations;

namespace jobrecuritment.Migrations
{
    public partial class type : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobVacancies_Categories_CategoryId",
                table: "JobVacancies");

            migrationBuilder.DropForeignKey(
                name: "FK_JobVacancies_JobTypes_JobTypeId",
                table: "JobVacancies");

            migrationBuilder.DropForeignKey(
                name: "FK_JobVacancies_Levels_LevelId",
                table: "JobVacancies");

            migrationBuilder.AlterColumn<int>(
                name: "LevelId",
                table: "JobVacancies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "JobTypeId",
                table: "JobVacancies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "JobVacancies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_JobVacancies_Categories_CategoryId",
                table: "JobVacancies",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobVacancies_JobTypes_JobTypeId",
                table: "JobVacancies",
                column: "JobTypeId",
                principalTable: "JobTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobVacancies_Levels_LevelId",
                table: "JobVacancies",
                column: "LevelId",
                principalTable: "Levels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobVacancies_Categories_CategoryId",
                table: "JobVacancies");

            migrationBuilder.DropForeignKey(
                name: "FK_JobVacancies_JobTypes_JobTypeId",
                table: "JobVacancies");

            migrationBuilder.DropForeignKey(
                name: "FK_JobVacancies_Levels_LevelId",
                table: "JobVacancies");

            migrationBuilder.AlterColumn<int>(
                name: "LevelId",
                table: "JobVacancies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "JobTypeId",
                table: "JobVacancies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "JobVacancies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_JobVacancies_Categories_CategoryId",
                table: "JobVacancies",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobVacancies_JobTypes_JobTypeId",
                table: "JobVacancies",
                column: "JobTypeId",
                principalTable: "JobTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobVacancies_Levels_LevelId",
                table: "JobVacancies",
                column: "LevelId",
                principalTable: "Levels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
