using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospiCasa.App.Persistencia.Migrations
{
    public partial class todasClasesYRelaciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SignoVital_Enfermeros_emfermeraid",
                table: "SignoVital");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SignoVital",
                table: "SignoVital");

            migrationBuilder.RenameTable(
                name: "SignoVital",
                newName: "SignosVitales");

            migrationBuilder.RenameIndex(
                name: "IX_SignoVital_emfermeraid",
                table: "SignosVitales",
                newName: "IX_SignosVitales_emfermeraid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SignosVitales",
                table: "SignosVitales",
                column: "id");

            migrationBuilder.CreateTable(
                name: "SugerenciasCuidados",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sugerencias = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SugerenciasCuidados", x => x.id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_SignosVitales_Enfermeros_emfermeraid",
                table: "SignosVitales",
                column: "emfermeraid",
                principalTable: "Enfermeros",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SignosVitales_Enfermeros_emfermeraid",
                table: "SignosVitales");

            migrationBuilder.DropTable(
                name: "SugerenciasCuidados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SignosVitales",
                table: "SignosVitales");

            migrationBuilder.RenameTable(
                name: "SignosVitales",
                newName: "SignoVital");

            migrationBuilder.RenameIndex(
                name: "IX_SignosVitales_emfermeraid",
                table: "SignoVital",
                newName: "IX_SignoVital_emfermeraid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SignoVital",
                table: "SignoVital",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_SignoVital_Enfermeros_emfermeraid",
                table: "SignoVital",
                column: "emfermeraid",
                principalTable: "Enfermeros",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
