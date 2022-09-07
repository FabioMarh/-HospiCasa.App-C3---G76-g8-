using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospiCasa.App.Persistencia.Migrations
{
    public partial class relacionHistoriaMedico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "pacienteid",
                table: "Familiares",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Familiares_pacienteid",
                table: "Familiares",
                column: "pacienteid");

            migrationBuilder.AddForeignKey(
                name: "FK_Familiares_Pacientes_pacienteid",
                table: "Familiares",
                column: "pacienteid",
                principalTable: "Pacientes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Familiares_Pacientes_pacienteid",
                table: "Familiares");

            migrationBuilder.DropIndex(
                name: "IX_Familiares_pacienteid",
                table: "Familiares");

            migrationBuilder.DropColumn(
                name: "pacienteid",
                table: "Familiares");
        }
    }
}
