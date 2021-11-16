using Microsoft.EntityFrameworkCore.Migrations;

namespace AppSmartDoctor.Migrations
{
    public partial class dbsetcalificaciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calificacion_Medicos_medicoId",
                table: "Calificacion");

            migrationBuilder.DropForeignKey(
                name: "FK_Calificacion_Pacientes_pacienteId",
                table: "Calificacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Calificacion",
                table: "Calificacion");

            migrationBuilder.RenameTable(
                name: "Calificacion",
                newName: "Calificaciones");

            migrationBuilder.RenameIndex(
                name: "IX_Calificacion_pacienteId",
                table: "Calificaciones",
                newName: "IX_Calificaciones_pacienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Calificacion_medicoId",
                table: "Calificaciones",
                newName: "IX_Calificaciones_medicoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Calificaciones",
                table: "Calificaciones",
                column: "calificacionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Calificaciones_Medicos_medicoId",
                table: "Calificaciones",
                column: "medicoId",
                principalTable: "Medicos",
                principalColumn: "medicoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Calificaciones_Pacientes_pacienteId",
                table: "Calificaciones",
                column: "pacienteId",
                principalTable: "Pacientes",
                principalColumn: "pacienteId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calificaciones_Medicos_medicoId",
                table: "Calificaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Calificaciones_Pacientes_pacienteId",
                table: "Calificaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Calificaciones",
                table: "Calificaciones");

            migrationBuilder.RenameTable(
                name: "Calificaciones",
                newName: "Calificacion");

            migrationBuilder.RenameIndex(
                name: "IX_Calificaciones_pacienteId",
                table: "Calificacion",
                newName: "IX_Calificacion_pacienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Calificaciones_medicoId",
                table: "Calificacion",
                newName: "IX_Calificacion_medicoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Calificacion",
                table: "Calificacion",
                column: "calificacionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Calificacion_Medicos_medicoId",
                table: "Calificacion",
                column: "medicoId",
                principalTable: "Medicos",
                principalColumn: "medicoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Calificacion_Pacientes_pacienteId",
                table: "Calificacion",
                column: "pacienteId",
                principalTable: "Pacientes",
                principalColumn: "pacienteId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
