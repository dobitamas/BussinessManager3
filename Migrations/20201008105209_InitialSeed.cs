using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BussinessManager3.Migrations
{
    public partial class InitialSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: false),
                    Field = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    GroupId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: false),
                    TodoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.GroupId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false),
                    DepartmenId = table.Column<int>(nullable: true),
                    GroupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmenId",
                        column: x => x.DepartmenId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Todos",
                columns: table => new
                {
                    ProblemId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(nullable: false),
                    Descrpition = table.Column<string>(nullable: false),
                    IsDone = table.Column<bool>(nullable: false),
                    GroupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todos", x => x.ProblemId);
                    table.ForeignKey(
                        name: "FK_Todos_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "GroupId", "Name", "TodoId" },
                values: new object[] { -1, "Cleaner", -99 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DepartmenId", "DepartmentId", "Email", "GroupId", "Name" },
                values: new object[,]
                {
                    { -99, null, -99, "mary@gmail.com", -1, "Mary" },
                    { -98, null, -99, "stan@gmail.com", -1, "Stan" },
                    { -97, null, -99, "mike@gmail.com", -1, "Mike" }
                });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "ProblemId", "Descrpition", "GroupId", "IsDone", "Title" },
                values: new object[] { -99, "Someone spilled drink all over the place in the basement", -1, false, "Spilled drink in basement" });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmenId",
                table: "Employees",
                column: "DepartmenId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_GroupId",
                table: "Employees",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Todos_GroupId",
                table: "Todos",
                column: "GroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Todos");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Groups");
        }
    }
}
