using Microsoft.EntityFrameworkCore.Migrations;

namespace PracticeExercise.Data.Migrations
{
    public partial class DepartmentCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_AspNetUsers_ApplicationUserId",
                table: "Department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Department_ApplicationUserId",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Department");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "Departments");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentID",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DepartmentID",
                table: "AspNetUsers",
                column: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Departments_DepartmentID",
                table: "AspNetUsers",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "DepartmentID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Departments_DepartmentID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_DepartmentID",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "DepartmentID",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Department");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Department",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Department_ApplicationUserId",
                table: "Department",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_AspNetUsers_ApplicationUserId",
                table: "Department",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
