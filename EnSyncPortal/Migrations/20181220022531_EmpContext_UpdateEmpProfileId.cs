using Microsoft.EntityFrameworkCore.Migrations;

namespace EnSyncPortal.Migrations
{
    public partial class EmpContext_UpdateEmpProfileId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfileId",
                table: "Employees",
                newName: "Employee_ProfileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Employee_ProfileId",
                table: "Employees",
                newName: "ProfileId");
        }
    }
}
