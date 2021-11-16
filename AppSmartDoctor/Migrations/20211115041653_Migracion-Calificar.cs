using Microsoft.EntityFrameworkCore.Migrations;

namespace AppSmartDoctor.Migrations
{
    public partial class MigracionCalificar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calificacion",
                columns: table => new
                {
                    calificacionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    medicoId = table.Column<int>(type: "int", nullable: false),
                    pacienteId = table.Column<int>(type: "int", nullable: false),
                    puntuacion = table.Column<double>(type: "float", nullable: false),
                    motivo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calificacion", x => x.calificacionId);
                    table.ForeignKey(
                        name: "FK_Calificacion_Medicos_medicoId",
                        column: x => x.medicoId,
                        principalTable: "Medicos",
                        principalColumn: "medicoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Calificacion_Pacientes_pacienteId",
                        column: x => x.pacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "pacienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calificacion_medicoId",
                table: "Calificacion",
                column: "medicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Calificacion_pacienteId",
                table: "Calificacion",
                column: "pacienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calificacion");
        }
    }
}
