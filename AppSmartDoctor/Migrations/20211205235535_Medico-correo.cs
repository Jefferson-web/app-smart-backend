using Microsoft.EntityFrameworkCore.Migrations;

namespace AppSmartDoctor.Migrations
{
    public partial class Medicocorreo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "correo",
                table: "Medicos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "correo",
                table: "Medicos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
