using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospiCasa.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auxiliares",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idAuxiliar = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroTelefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    tipoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auxiliares", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Enfermeros",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idEnfermera = table.Column<int>(type: "int", nullable: false),
                    targetaProfecional = table.Column<int>(type: "int", nullable: false),
                    horasLaboralesSemana = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroTelefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    tipoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enfermeros", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idMedico = table.Column<int>(type: "int", nullable: false),
                    registroReTHUS = table.Column<int>(type: "int", nullable: false),
                    especialidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroTelefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    tipoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HistoriasMedicas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    diagnostico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    entornoHospitalizacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idMedico = table.Column<int>(type: "int", nullable: false),
                    medicoid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriasMedicas", x => x.id);
                    table.ForeignKey(
                        name: "FK_HistoriasMedicas_Medicos_medicoid",
                        column: x => x.medicoid,
                        principalTable: "Medicos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idPaciente = table.Column<int>(type: "int", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direccionGeorreferenciada = table.Column<int>(type: "int", nullable: false),
                    ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    historiaMedicaid = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroTelefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    tipoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.id);
                    table.ForeignKey(
                        name: "FK_Pacientes_HistoriasMedicas_historiaMedicaid",
                        column: x => x.historiaMedicaid,
                        principalTable: "HistoriasMedicas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SignosVitales",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    estadoGeneralPaciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaYHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    oximetria = table.Column<int>(type: "int", nullable: false),
                    frecuenciaRespiratoria = table.Column<int>(type: "int", nullable: false),
                    frecuenciaCardiaca = table.Column<int>(type: "int", nullable: false),
                    temperatura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    presionArterial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    glicemias = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idEnfermera = table.Column<int>(type: "int", nullable: false),
                    emfermeraid = table.Column<int>(type: "int", nullable: false),
                    idHistoriaMedica = table.Column<int>(type: "int", nullable: false),
                    historiaMedicaid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignosVitales", x => x.id);
                    table.ForeignKey(
                        name: "FK_SignosVitales_Enfermeros_emfermeraid",
                        column: x => x.emfermeraid,
                        principalTable: "Enfermeros",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SignosVitales_HistoriasMedicas_historiaMedicaid",
                        column: x => x.historiaMedicaid,
                        principalTable: "HistoriasMedicas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SugerenciasCuidados",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sugerencias = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idHistoriaMedica = table.Column<int>(type: "int", nullable: false),
                    historiaMedicaid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SugerenciasCuidados", x => x.id);
                    table.ForeignKey(
                        name: "FK_SugerenciasCuidados_HistoriasMedicas_historiaMedicaid",
                        column: x => x.historiaMedicaid,
                        principalTable: "HistoriasMedicas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Familiares",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idFamiliar = table.Column<int>(type: "int", nullable: false),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    parentescoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pacienteid = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroTelefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    tipoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Familiares", x => x.id);
                    table.ForeignKey(
                        name: "FK_Familiares_Pacientes_pacienteid",
                        column: x => x.pacienteid,
                        principalTable: "Pacientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Familiares_pacienteid",
                table: "Familiares",
                column: "pacienteid");

            migrationBuilder.CreateIndex(
                name: "IX_HistoriasMedicas_medicoid",
                table: "HistoriasMedicas",
                column: "medicoid");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_historiaMedicaid",
                table: "Pacientes",
                column: "historiaMedicaid");

            migrationBuilder.CreateIndex(
                name: "IX_SignosVitales_emfermeraid",
                table: "SignosVitales",
                column: "emfermeraid");

            migrationBuilder.CreateIndex(
                name: "IX_SignosVitales_historiaMedicaid",
                table: "SignosVitales",
                column: "historiaMedicaid");

            migrationBuilder.CreateIndex(
                name: "IX_SugerenciasCuidados_historiaMedicaid",
                table: "SugerenciasCuidados",
                column: "historiaMedicaid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auxiliares");

            migrationBuilder.DropTable(
                name: "Familiares");

            migrationBuilder.DropTable(
                name: "SignosVitales");

            migrationBuilder.DropTable(
                name: "SugerenciasCuidados");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Enfermeros");

            migrationBuilder.DropTable(
                name: "HistoriasMedicas");

            migrationBuilder.DropTable(
                name: "Medicos");
        }
    }
}
