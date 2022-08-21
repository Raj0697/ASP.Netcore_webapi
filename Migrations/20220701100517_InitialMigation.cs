using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeRegister.Migrations
{
    public partial class InitialMigation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "department",
                columns: table => new
                {
                    Department_ID = table.Column<Guid>(nullable: false),
                    Department_name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_department", x => x.Department_ID);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    Employee_ID = table.Column<Guid>(nullable: false),
                    Firstname = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: false),
                    Lastname = table.Column<string>(maxLength: 10, nullable: false),
                    EmailId = table.Column<string>(nullable: false),
                    Department_ID = table.Column<Guid>(nullable: false),
                    Manager_ID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.Employee_ID);
                    table.ForeignKey(
                        name: "FK_employees_department_Department_ID",
                        column: x => x.Department_ID,
                        principalTable: "department",
                        principalColumn: "Department_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_employees_Department_ID",
                table: "employees",
                column: "Department_ID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "department");
        }
    }
}
