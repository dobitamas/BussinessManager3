using Microsoft.EntityFrameworkCore.Migrations;

namespace BussinessManager3.Migrations
{
    public partial class InitialSeed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmenId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmenId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DepartmenId",
                table: "Employees");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "DepartmenId",
                table: "Employees",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmenId",
                table: "Employees",
                column: "DepartmenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmenId",
                table: "Employees",
                column: "DepartmenId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
