using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projetos_Delta.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Request_Projeto_projetoID",
                table: "Request");

            migrationBuilder.DropTable(
                name: "EmployeeProjeto");

            migrationBuilder.RenameColumn(
                name: "projetoID",
                table: "Request",
                newName: "projectID");

            migrationBuilder.RenameIndex(
                name: "IX_Request_projetoID",
                table: "Request",
                newName: "IX_Request_projectID");

            migrationBuilder.CreateTable(
                name: "EmployeeProject",
                columns: table => new
                {
                    EmployeesID = table.Column<int>(type: "int", nullable: false),
                    ProjectsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProject", x => new { x.EmployeesID, x.ProjectsID });
                    table.ForeignKey(
                        name: "FK_EmployeeProject_Employee_EmployeesID",
                        column: x => x.EmployeesID,
                        principalTable: "Employee",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeProject_Projeto_ProjectsID",
                        column: x => x.ProjectsID,
                        principalTable: "Projeto",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProject_ProjectsID",
                table: "EmployeeProject",
                column: "ProjectsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Request_Projeto_projectID",
                table: "Request",
                column: "projectID",
                principalTable: "Projeto",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Request_Projeto_projectID",
                table: "Request");

            migrationBuilder.DropTable(
                name: "EmployeeProject");

            migrationBuilder.RenameColumn(
                name: "projectID",
                table: "Request",
                newName: "projetoID");

            migrationBuilder.RenameIndex(
                name: "IX_Request_projectID",
                table: "Request",
                newName: "IX_Request_projetoID");

            migrationBuilder.CreateTable(
                name: "EmployeeProjeto",
                columns: table => new
                {
                    EmployeesID = table.Column<int>(type: "int", nullable: false),
                    ProjetosID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProjeto", x => new { x.EmployeesID, x.ProjetosID });
                    table.ForeignKey(
                        name: "FK_EmployeeProjeto_Employee_EmployeesID",
                        column: x => x.EmployeesID,
                        principalTable: "Employee",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeProjeto_Projeto_ProjetosID",
                        column: x => x.ProjetosID,
                        principalTable: "Projeto",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProjeto_ProjetosID",
                table: "EmployeeProjeto",
                column: "ProjetosID");

            migrationBuilder.AddForeignKey(
                name: "FK_Request_Projeto_projetoID",
                table: "Request",
                column: "projetoID",
                principalTable: "Projeto",
                principalColumn: "ID");
        }
    }
}
