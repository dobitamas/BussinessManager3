using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BussinessManager3.Migrations
{
    public partial class InitialSeed5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Todos_TodoId",
                table: "Groups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Todos",
                table: "Todos");

            migrationBuilder.DropIndex(
                name: "IX_Groups_TodoId",
                table: "Groups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -99);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -98);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: -97);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "ProblemId",
                keyValue: -99);

            migrationBuilder.DropColumn(
                name: "ProblemId",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "TodoId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "TodoId",
                table: "Todos",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Employees",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Todos",
                table: "Todos",
                column: "TodoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "EmployeeId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Todos_GroupId",
                table: "Todos",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Groups_GroupId",
                table: "Todos",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Groups_GroupId",
                table: "Todos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Todos",
                table: "Todos");

            migrationBuilder.DropIndex(
                name: "IX_Todos_GroupId",
                table: "Todos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

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

            migrationBuilder.DropColumn(
                name: "TodoId",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "ProblemId",
                table: "Todos",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "TodoId",
                table: "Groups",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Employees",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Todos",
                table: "Todos",
                column: "ProblemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DepartmentId", "Email", "GroupId", "Name" },
                values: new object[,]
                {
                    { -99, -99, "mary@gmail.com", -1, "Mary" },
                    { -98, -99, "stan@gmail.com", -1, "Stan" },
                    { -97, -99, "mike@gmail.com", -1, "Mike" }
                });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "ProblemId", "Descrpition", "GroupId", "IsDone", "Title" },
                values: new object[] { -99, "Someone spilled drink all over the place in the basement", -1, false, "Spilled drink in basement" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: -1,
                column: "TodoId",
                value: -99);

            migrationBuilder.CreateIndex(
                name: "IX_Groups_TodoId",
                table: "Groups",
                column: "TodoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Todos_TodoId",
                table: "Groups",
                column: "TodoId",
                principalTable: "Todos",
                principalColumn: "ProblemId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
