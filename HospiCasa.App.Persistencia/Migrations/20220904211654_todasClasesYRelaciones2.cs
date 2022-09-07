using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospiCasa.App.Persistencia.Migrations
{
    public partial class todasClasesYRelaciones2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "historiaMedicaid",
                table: "SugerenciasCuidados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idHistoriaMedica",
                table: "SugerenciasCuidados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "historiaMedicaid",
                table: "SignosVitales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idHistoriaMedica",
                table: "SignosVitales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SugerenciasCuidados_historiaMedicaid",
                table: "SugerenciasCuidados",
                column: "historiaMedicaid");

            migrationBuilder.CreateIndex(
                name: "IX_SignosVitales_historiaMedicaid",
                table: "SignosVitales",
                column: "historiaMedicaid");

            migrationBuilder.AddForeignKey(
                name: "FK_SignosVitales_HistoriasMedicas_historiaMedicaid",
                table: "SignosVitales",
                column: "historiaMedicaid",
                principalTable: "HistoriasMedicas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SugerenciasCuidados_HistoriasMedicas_historiaMedicaid",
                table: "SugerenciasCuidados",
                column: "historiaMedicaid",
                principalTable: "HistoriasMedicas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SignosVitales_HistoriasMedicas_historiaMedicaid",
                table: "SignosVitales");

            migrationBuilder.DropForeignKey(
                name: "FK_SugerenciasCuidados_HistoriasMedicas_historiaMedicaid",
                table: "SugerenciasCuidados");

            migrationBuilder.DropIndex(
                name: "IX_SugerenciasCuidados_historiaMedicaid",
                table: "SugerenciasCuidados");

            migrationBuilder.DropIndex(
                name: "IX_SignosVitales_historiaMedicaid",
                table: "SignosVitales");

            migrationBuilder.DropColumn(
                name: "historiaMedicaid",
                table: "SugerenciasCuidados");

            migrationBuilder.DropColumn(
                name: "idHistoriaMedica",
                table: "SugerenciasCuidados");

            migrationBuilder.DropColumn(
                name: "historiaMedicaid",
                table: "SignosVitales");

            migrationBuilder.DropColumn(
                name: "idHistoriaMedica",
                table: "SignosVitales");
        }
    }
}
