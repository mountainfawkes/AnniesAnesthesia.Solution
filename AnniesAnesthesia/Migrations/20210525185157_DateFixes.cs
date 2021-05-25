using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinic.Migrations
{
    public partial class DateFixes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HireDate",
                table: "Doctors");

            migrationBuilder.RenameColumn(
                name: "Birthdate",
                table: "Patients",
                newName: "RealBirthDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RealBirthDate",
                table: "Patients",
                newName: "Birthdate");

            migrationBuilder.AddColumn<string>(
                name: "HireDate",
                table: "Doctors",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
