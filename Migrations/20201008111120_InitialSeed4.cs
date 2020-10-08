using Microsoft.EntityFrameworkCore.Migrations;

namespace BussinessManager3.Migrations
{
    public partial class InitialSeed4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Groups_GroupId",
                table: "Todos");

            migrationBuilder.DropIndex(
                name: "IX_Todos_GroupId",
                table: "Todos");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Todos_TodoId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Groups_TodoId",
                table: "Groups");

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
    }
}
