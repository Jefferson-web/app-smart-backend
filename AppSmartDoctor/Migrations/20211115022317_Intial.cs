using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppSmartDoctor.Migrations
{
    public partial class Intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Especialidades",
                columns: table => new
                {
                    especialidadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidades", x => x.especialidadId);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    pacienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DNI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fecha_nacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    edad = table.Column<int>(type: "int", nullable: false),
                    sexo = table.Column<bool>(type: "bit", nullable: false),
                    distrito_colonia = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.pacienteId);
                });

            migrationBuilder.CreateTable(
                name: "Residencias",
                columns: table => new
                {
                    residenciaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pais = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residencias", x => x.residenciaId);
                });

            migrationBuilder.CreateTable(
                name: "TipoPago",
                columns: table => new
                {
                    tipoPagoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPago", x => x.tipoPagoId);
                });

            migrationBuilder.CreateTable(
                name: "FichaClinica",
                columns: table => new
                {
                    fichaClinicaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pacienteId = table.Column<int>(type: "int", nullable: false),
                    peso = table.Column<double>(type: "float", nullable: false),
                    talla = table.Column<double>(type: "float", nullable: false),
                    fecha_registro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FichaClinica", x => x.fichaClinicaId);
                    table.ForeignKey(
                        name: "FK_FichaClinica_Pacientes_pacienteId",
                        column: x => x.pacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "pacienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    medicoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    especialidadId = table.Column<int>(type: "int", nullable: false),
                    residenciaId = table.Column<int>(type: "int", nullable: false),
                    nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CMP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicos", x => x.medicoId);
                    table.ForeignKey(
                        name: "FK_Medicos_Especialidades_especialidadId",
                        column: x => x.especialidadId,
                        principalTable: "Especialidades",
                        principalColumn: "especialidadId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Medicos_Residencias_residenciaId",
                        column: x => x.residenciaId,
                        principalTable: "Residencias",
                        principalColumn: "residenciaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Citas",
                columns: table => new
                {
                    citaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    medicoId = table.Column<int>(type: "int", nullable: false),
                    pacienteId = table.Column<int>(type: "int", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    hora_inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    hora_fin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    motivo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    costo = table.Column<double>(type: "float", nullable: false),
                    pagado = table.Column<bool>(type: "bit", nullable: false),
                    atendido = table.Column<bool>(type: "bit", nullable: false),
                    fecha_registro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citas", x => x.citaId);
                    table.ForeignKey(
                        name: "FK_Citas_Medicos_medicoId",
                        column: x => x.medicoId,
                        principalTable: "Medicos",
                        principalColumn: "medicoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Citas_Pacientes_pacienteId",
                        column: x => x.pacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "pacienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Consultorios",
                columns: table => new
                {
                    consultorioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    medicoId = table.Column<int>(type: "int", nullable: false),
                    importe = table.Column<double>(type: "float", nullable: false),
                    duracion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultorios", x => x.consultorioId);
                    table.ForeignKey(
                        name: "FK_Consultorios_Medicos_medicoId",
                        column: x => x.medicoId,
                        principalTable: "Medicos",
                        principalColumn: "medicoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CuentaDoctor",
                columns: table => new
                {
                    cuentaDoctorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    medicoId = table.Column<int>(type: "int", nullable: false),
                    nombreBanco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nroCuenta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nroCuentaCCI = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuentaDoctor", x => x.cuentaDoctorId);
                    table.ForeignKey(
                        name: "FK_CuentaDoctor_Medicos_medicoId",
                        column: x => x.medicoId,
                        principalTable: "Medicos",
                        principalColumn: "medicoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Estudios",
                columns: table => new
                {
                    estudioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    medicoId = table.Column<int>(type: "int", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    anio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudios", x => x.estudioId);
                    table.ForeignKey(
                        name: "FK_Estudios_Medicos_medicoId",
                        column: x => x.medicoId,
                        principalTable: "Medicos",
                        principalColumn: "medicoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Experiencias",
                columns: table => new
                {
                    experienciaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    medicoId = table.Column<int>(type: "int", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    anio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiencias", x => x.experienciaId);
                    table.ForeignKey(
                        name: "FK_Experiencias_Medicos_medicoId",
                        column: x => x.medicoId,
                        principalTable: "Medicos",
                        principalColumn: "medicoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Horarios",
                columns: table => new
                {
                    horarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    medicoId = table.Column<int>(type: "int", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    hora_inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    hora_fin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    disponible = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horarios", x => x.horarioId);
                    table.ForeignKey(
                        name: "FK_Horarios_Medicos_medicoId",
                        column: x => x.medicoId,
                        principalTable: "Medicos",
                        principalColumn: "medicoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Archivos",
                columns: table => new
                {
                    archivoId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    citaId = table.Column<int>(type: "int", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    data = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    content_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tamano = table.Column<long>(type: "bigint", nullable: false),
                    extension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fecha_registro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Archivos", x => x.archivoId);
                    table.ForeignKey(
                        name: "FK_Archivos_Citas_citaId",
                        column: x => x.citaId,
                        principalTable: "Citas",
                        principalColumn: "citaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Diagnosticos",
                columns: table => new
                {
                    diagnosticoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    citaId = table.Column<int>(type: "int", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnosticos", x => x.diagnosticoId);
                    table.ForeignKey(
                        name: "FK_Diagnosticos_Citas_citaId",
                        column: x => x.citaId,
                        principalTable: "Citas",
                        principalColumn: "citaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Indicaciones",
                columns: table => new
                {
                    indicacionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    citaId = table.Column<int>(type: "int", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indicaciones", x => x.indicacionId);
                    table.ForeignKey(
                        name: "FK_Indicaciones_Citas_citaId",
                        column: x => x.citaId,
                        principalTable: "Citas",
                        principalColumn: "citaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    pagoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoPagoId = table.Column<int>(type: "int", nullable: false),
                    citaId = table.Column<int>(type: "int", nullable: false),
                    monto = table.Column<double>(type: "float", nullable: false),
                    nombreTarjeta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numeroTarjeta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    expiracion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cvv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fecha_pago = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.pagoId);
                    table.ForeignKey(
                        name: "FK_Pagos_Citas_citaId",
                        column: x => x.citaId,
                        principalTable: "Citas",
                        principalColumn: "citaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pagos_TipoPago_tipoPagoId",
                        column: x => x.tipoPagoId,
                        principalTable: "TipoPago",
                        principalColumn: "tipoPagoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recetas",
                columns: table => new
                {
                    recetaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    citaId = table.Column<int>(type: "int", nullable: false),
                    nombre_medicamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    frecuencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    horas = table.Column<int>(type: "int", nullable: false),
                    observacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recetas", x => x.recetaId);
                    table.ForeignKey(
                        name: "FK_Recetas_Citas_citaId",
                        column: x => x.citaId,
                        principalTable: "Citas",
                        principalColumn: "citaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Archivos_citaId",
                table: "Archivos",
                column: "citaId");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_medicoId",
                table: "Citas",
                column: "medicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_pacienteId",
                table: "Citas",
                column: "pacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Consultorios_medicoId",
                table: "Consultorios",
                column: "medicoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CuentaDoctor_medicoId",
                table: "CuentaDoctor",
                column: "medicoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Diagnosticos_citaId",
                table: "Diagnosticos",
                column: "citaId");

            migrationBuilder.CreateIndex(
                name: "IX_Estudios_medicoId",
                table: "Estudios",
                column: "medicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Experiencias_medicoId",
                table: "Experiencias",
                column: "medicoId");

            migrationBuilder.CreateIndex(
                name: "IX_FichaClinica_pacienteId",
                table: "FichaClinica",
                column: "pacienteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Horarios_medicoId",
                table: "Horarios",
                column: "medicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Indicaciones_citaId",
                table: "Indicaciones",
                column: "citaId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_especialidadId",
                table: "Medicos",
                column: "especialidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_residenciaId",
                table: "Medicos",
                column: "residenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_citaId",
                table: "Pagos",
                column: "citaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_tipoPagoId",
                table: "Pagos",
                column: "tipoPagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Recetas_citaId",
                table: "Recetas",
                column: "citaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Archivos");

            migrationBuilder.DropTable(
                name: "Consultorios");

            migrationBuilder.DropTable(
                name: "CuentaDoctor");

            migrationBuilder.DropTable(
                name: "Diagnosticos");

            migrationBuilder.DropTable(
                name: "Estudios");

            migrationBuilder.DropTable(
                name: "Experiencias");

            migrationBuilder.DropTable(
                name: "FichaClinica");

            migrationBuilder.DropTable(
                name: "Horarios");

            migrationBuilder.DropTable(
                name: "Indicaciones");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "Recetas");

            migrationBuilder.DropTable(
                name: "TipoPago");

            migrationBuilder.DropTable(
                name: "Citas");

            migrationBuilder.DropTable(
                name: "Medicos");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Especialidades");

            migrationBuilder.DropTable(
                name: "Residencias");
        }
    }
}
