using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospiCasa.App.Persistencia.Migrations
{
    public partial class RelacionesCompletasCorregidas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "historiaMedicaid",
                table: "Pacientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_historiaMedicaid",
                table: "Pacientes",
                column: "historiaMedicaid");

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_HistoriasMedicas_historiaMedicaid",
                table: "Pacientes",
                column: "historiaMedicaid",
                principalTable: "HistoriasMedicas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_HistoriasMedicas_historiaMedicaid",
                table: "Pacientes");

            migrationBuilder.DropIndex(
                name: "IX_Pacientes_historiaMedicaid",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "historiaMedicaid",
                table: "Pacientes");
        }
    }
}
