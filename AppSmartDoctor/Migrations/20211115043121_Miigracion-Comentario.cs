using Microsoft.EntityFrameworkCore.Migrations;

namespace AppSmartDoctor.Migrations
{
    public partial class MiigracionComentario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "motivo",
                table: "Calificaciones",
                newName: "comentario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "comentario",
                table: "Calificaciones",
                newName: "motivo");
        }
    }
}
