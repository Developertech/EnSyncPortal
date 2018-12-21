using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EnSyncPortal.Migrations.EmployeeContact
{
    public partial class AddedNewDepartmentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeContacts",
                columns: table => new
                {
                    EMPLOYEE_CONTACT_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EMPLOYEE_ID = table.Column<long>(nullable: false),
                    CONTROL_ID = table.Column<string>(nullable: true),
                    EMAIL = table.Column<string>(nullable: true),
                    PHONE_NUMBER = table.Column<string>(nullable: true),
                    ADDRESS_1 = table.Column<string>(nullable: true),
                    ADDRESS_2 = table.Column<string>(nullable: true),
                    CITY = table.Column<string>(nullable: true),
                    STATE = table.Column<string>(nullable: true),
                    ZIP_CODE = table.Column<string>(nullable: true),
                    TIME_STAMP = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeContacts", x => x.EMPLOYEE_CONTACT_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeContacts");
        }
    }
}
