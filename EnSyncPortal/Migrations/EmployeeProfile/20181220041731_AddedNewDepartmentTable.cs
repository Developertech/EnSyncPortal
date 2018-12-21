using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EnSyncPortal.Migrations.EmployeeProfile
{
    public partial class AddedNewDepartmentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeProfiles",
                columns: table => new
                {
                    EMPLOYEE_PROFILE_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CONTROL_ID = table.Column<string>(nullable: true),
                    EMPLOYEE_ID = table.Column<long>(nullable: false),
                    DEPARTMENT_ID = table.Column<long>(nullable: false),
                    PROJECT_ID = table.Column<long>(nullable: false),
                    HIRE_DATE = table.Column<DateTime>(nullable: false),
                    SALARY_AMOUNT = table.Column<float>(nullable: false),
                    COUNTRY = table.Column<string>(nullable: true),
                    EMPLOYMENT_TYPE = table.Column<string>(nullable: true),
                    TIME_STAMP = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProfiles", x => x.EMPLOYEE_PROFILE_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeProfiles");
        }
    }
}
