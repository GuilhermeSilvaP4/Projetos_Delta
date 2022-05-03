using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projetos_Delta.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Departamento = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Projeto",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projeto", x => x.ID);
                });

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

            migrationBuilder.CreateTable(
                name: "Request",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestNuber = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    projetoID = table.Column<int>(type: "int", nullable: true),
                    EmployeeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Request", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Request_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Request_Projeto_projetoID",
                        column: x => x.projetoID,
                        principalTable: "Projeto",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProjeto_ProjetosID",
                table: "EmployeeProjeto",
                column: "ProjetosID");

            migrationBuilder.CreateIndex(
                name: "IX_Request_EmployeeID",
                table: "Request",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Request_projetoID",
                table: "Request",
                column: "projetoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeProjeto");

            migrationBuilder.DropTable(
                name: "Request");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Projeto");
        }
    }
}
