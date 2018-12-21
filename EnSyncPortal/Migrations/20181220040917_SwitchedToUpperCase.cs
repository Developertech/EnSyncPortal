using Microsoft.EntityFrameworkCore.Migrations;

namespace EnSyncPortal.Migrations
{
    public partial class SwitchedToUpperCase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Employee_ProfileId",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Employees",
                newName: "GENDER");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Employees",
                newName: "LAST_NAME");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Employees",
                newName: "FIRST_NAME");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "Employees",
                newName: "DOB");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Employees",
                newName: "EMPLOYEE_ID");

            migrationBuilder.AddColumn<string>(
                name: "CONTROL_ID",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CONTROL_ID",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "GENDER",
                table: "Employees",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "LAST_NAME",
                table: "Employees",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "FIRST_NAME",
                table: "Employees",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "DOB",
                table: "Employees",
                newName: "DateOfBirth");

            migrationBuilder.RenameColumn(
                name: "EMPLOYEE_ID",
                table: "Employees",
                newName: "EmployeeId");

            migrationBuilder.AddColumn<long>(
                name: "Employee_ProfileId",
                table: "Employees",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
