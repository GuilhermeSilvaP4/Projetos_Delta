using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projetos_Delta.Migrations
{
    public partial class forty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeProject_Employee_EmployeesID",
                table: "EmployeeProject");

            migrationBuilder.DropForeignKey(
                name: "FK_Request_Employee_EmployeeID",
                table: "Request");

            migrationBuilder.DropForeignKey(
                name: "FK_Request_Projeto_projectID",
                table: "Request");

            migrationBuilder.DropIndex(
                name: "IX_Request_projectID",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "projectID",
                table: "Request");

            migrationBuilder.RenameColumn(
                name: "EmployeeID",
                table: "Request",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Request",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RequestNuber",
                table: "Request",
                newName: "RequestNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Request_EmployeeID",
                table: "Request",
                newName: "IX_Request_EmployeeId");

            migrationBuilder.RenameColumn(
                name: "EmployeesID",
                table: "EmployeeProject",
                newName: "EmployeesId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Employee",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "RequestId",
                table: "Projeto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projeto_RequestId",
                table: "Projeto",
                column: "RequestId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeProject_Employee_EmployeesId",
                table: "EmployeeProject",
                column: "EmployeesId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projeto_Request_RequestId",
                table: "Projeto",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Request_Employee_EmployeeId",
                table: "Request",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeProject_Employee_EmployeesId",
                table: "EmployeeProject");

            migrationBuilder.DropForeignKey(
                name: "FK_Projeto_Request_RequestId",
                table: "Projeto");

            migrationBuilder.DropForeignKey(
                name: "FK_Request_Employee_EmployeeId",
                table: "Request");

            migrationBuilder.DropIndex(
                name: "IX_Projeto_RequestId",
                table: "Projeto");

            migrationBuilder.DropColumn(
                name: "RequestId",
                table: "Projeto");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Request",
                newName: "EmployeeID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Request",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "RequestNumber",
                table: "Request",
                newName: "RequestNuber");

            migrationBuilder.RenameIndex(
                name: "IX_Request_EmployeeId",
                table: "Request",
                newName: "IX_Request_EmployeeID");

            migrationBuilder.RenameColumn(
                name: "EmployeesId",
                table: "EmployeeProject",
                newName: "EmployeesID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Employee",
                newName: "ID");

            migrationBuilder.AddColumn<int>(
                name: "projectID",
                table: "Request",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Request_projectID",
                table: "Request",
                column: "projectID");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeProject_Employee_EmployeesID",
                table: "EmployeeProject",
                column: "EmployeesID",
                principalTable: "Employee",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Request_Employee_EmployeeID",
                table: "Request",
                column: "EmployeeID",
                principalTable: "Employee",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Request_Projeto_projectID",
                table: "Request",
                column: "projectID",
                principalTable: "Projeto",
                principalColumn: "ID");
        }
    }
}
