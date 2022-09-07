using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospiCasa.App.Persistencia.Migrations
{
    public partial class agregarclasePersona : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistoriasMedicas_Medicos_medicoid",
                table: "HistoriasMedicas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_HistoriasMedicas_historiaMedicaid",
                table: "Pacientes");

            migrationBuilder.DropForeignKey(
                name: "FK_SignosVitales_Enfermeros_emfermeraid",
                table: "SignosVitales");

            migrationBuilder.DropTable(
                name: "Auxiliares");

            migrationBuilder.DropTable(
                name: "Enfermeros");

            migrationBuilder.DropTable(
                name: "Familiares");

            migrationBuilder.DropTable(
                name: "Medicos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pacientes",
                table: "Pacientes");

            migrationBuilder.RenameTable(
                name: "Pacientes",
                newName: "Personas");

            migrationBuilder.RenameIndex(
                name: "IX_Pacientes_historiaMedicaid",
                table: "Personas",
                newName: "IX_Personas_historiaMedicaid");

            migrationBuilder.AlterColumn<int>(
                name: "pacienteid",
                table: "Personas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "historiaMedicaid",
                table: "Personas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "fechaNacimiento",
                table: "Personas",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "direccionGeorreferenciada",
                table: "Personas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "direccion",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ciudad",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Familiar_pacienteid",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "correo",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "especialidad",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "familiarid",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "horasLaboralesSemana",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "parentescoPaciente",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "registroReTHUS",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "targetaProfecional",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personas",
                table: "Personas",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Familiar_pacienteid",
                table: "Personas",
                column: "Familiar_pacienteid");

            migrationBuilder.AddForeignKey(
                name: "FK_HistoriasMedicas_Personas_medicoid",
                table: "HistoriasMedicas",
                column: "medicoid",
                principalTable: "Personas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_HistoriasMedicas_historiaMedicaid",
                table: "Personas",
                column: "historiaMedicaid",
                principalTable: "HistoriasMedicas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Personas_Familiar_pacienteid",
                table: "Personas",
                column: "Familiar_pacienteid",
                principalTable: "Personas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SignosVitales_Personas_emfermeraid",
                table: "SignosVitales",
                column: "emfermeraid",
                principalTable: "Personas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistoriasMedicas_Personas_medicoid",
                table: "HistoriasMedicas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_HistoriasMedicas_historiaMedicaid",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Personas_Familiar_pacienteid",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_SignosVitales_Personas_emfermeraid",
                table: "SignosVitales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personas",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_Familiar_pacienteid",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Familiar_pacienteid",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "correo",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "especialidad",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "familiarid",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "horasLaboralesSemana",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "parentescoPaciente",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "registroReTHUS",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "targetaProfecional",
                table: "Personas");

            migrationBuilder.RenameTable(
                name: "Personas",
                newName: "Pacientes");

            migrationBuilder.RenameIndex(
                name: "IX_Personas_historiaMedicaid",
                table: "Pacientes",
                newName: "IX_Pacientes_historiaMedicaid");

            migrationBuilder.AlterColumn<int>(
                name: "pacienteid",
                table: "Pacientes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "historiaMedicaid",
                table: "Pacientes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fechaNacimiento",
                table: "Pacientes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "direccionGeorreferenciada",
                table: "Pacientes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "direccion",
                table: "Pacientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ciudad",
                table: "Pacientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pacientes",
                table: "Pacientes",
                column: "id");

            migrationBuilder.CreateTable(
                name: "Auxiliares",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroTelefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroTelefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    horasLaboralesSemana = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    targetaProfecional = table.Column<int>(type: "int", nullable: false),
                    tipoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enfermeros", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Familiares",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pacienteid = table.Column<int>(type: "int", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroTelefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    familiarid = table.Column<int>(type: "int", nullable: false),
                    parentescoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroTelefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    especialidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    registroReTHUS = table.Column<int>(type: "int", nullable: false),
                    tipoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicos", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Familiares_pacienteid",
                table: "Familiares",
                column: "pacienteid");

            migrationBuilder.AddForeignKey(
                name: "FK_HistoriasMedicas_Medicos_medicoid",
                table: "HistoriasMedicas",
                column: "medicoid",
                principalTable: "Medicos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_HistoriasMedicas_historiaMedicaid",
                table: "Pacientes",
                column: "historiaMedicaid",
                principalTable: "HistoriasMedicas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SignosVitales_Enfermeros_emfermeraid",
                table: "SignosVitales",
                column: "emfermeraid",
                principalTable: "Enfermeros",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
