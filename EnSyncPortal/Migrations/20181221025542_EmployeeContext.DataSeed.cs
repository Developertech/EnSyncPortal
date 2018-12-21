using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EnSyncPortal.Migrations
{
    public partial class EmployeeContextDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EMPLOYEE_ID", "CONTROL_ID", "DOB", "FIRST_NAME", "GENDER", "LAST_NAME", "SSN" },
                values: new object[] { 1L, "DEV", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tzain", "M", "Adebola", "100101000" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EMPLOYEE_ID", "CONTROL_ID", "DOB", "FIRST_NAME", "GENDER", "LAST_NAME", "SSN" },
                values: new object[] { 2L, "DEV", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zelie", "F", "Adebola", "100101001" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EMPLOYEE_ID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EMPLOYEE_ID",
                keyValue: 2L);
        }
    }
}
