using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projetos_Delta.Migrations
{
    public partial class fifty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeProject_Projeto_ProjectsID",
                table: "EmployeeProject");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Projeto",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ProjectsID",
                table: "EmployeeProject",
                newName: "ProjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeProject_ProjectsID",
                table: "EmployeeProject",
                newName: "IX_EmployeeProject_ProjectsId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeProject_Projeto_ProjectsId",
                table: "EmployeeProject",
                column: "ProjectsId",
                principalTable: "Projeto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeProject_Projeto_ProjectsId",
                table: "EmployeeProject");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Projeto",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "ProjectsId",
                table: "EmployeeProject",
                newName: "ProjectsID");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeProject_ProjectsId",
                table: "EmployeeProject",
                newName: "IX_EmployeeProject_ProjectsID");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeProject_Projeto_ProjectsID",
                table: "EmployeeProject",
                column: "ProjectsID",
                principalTable: "Projeto",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
