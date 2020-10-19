using Microsoft.EntityFrameworkCore.Migrations;

namespace BussinessManager3.Migrations
{
    public partial class Remake : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: -98);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: -97);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: -99);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: -98);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: -97);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "TodoId",
                keyValue: -99);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: -99);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: -1);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId1",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId2",
                table: "Employees",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId1",
                table: "Employees",
                column: "DepartmentId1");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId2",
                table: "Employees",
                column: "DepartmentId2");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentId1",
                table: "Employees",
                column: "DepartmentId1",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentId2",
                table: "Employees",
                column: "DepartmentId2",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentId1",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentId2",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmentId1",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmentId2",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DepartmentId1",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DepartmentId2",
                table: "Employees");

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "Field", "Name" },
                values: new object[,]
                {
                    { -99, "IT", "Programming Department" },
                    { -98, "HR", "Human Resorcues" },
                    { -97, "AD", "Advertisement Department" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "Name" },
                values: new object[] { -1, "Cleaner" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DepartmentId", "Email", "GroupId", "Name" },
                values: new object[,]
                {
                    { -99, -99, "mary@gmail.com", -1, "Mary" },
                    { -98, -99, "stan@gmail.com", -1, "Stan" },
                    { -97, -99, "mike@gmail.com", -1, "Mike" }
                });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "TodoId", "Descrpition", "GroupId", "IsDone", "Title" },
                values: new object[] { -99, "Someone spilled drink all over the place in the basement", -1, false, "Spilled drink in basement" });
        }
    }
}
