using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospiCasa.App.Persistencia.Migrations
{
    public partial class relacionEnfermeraSigno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SignoVital",
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
                    emfermeraid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignoVital", x => x.id);
                    table.ForeignKey(
                        name: "FK_SignoVital_Enfermeros_emfermeraid",
                        column: x => x.emfermeraid,
                        principalTable: "Enfermeros",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SignoVital_emfermeraid",
                table: "SignoVital",
                column: "emfermeraid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SignoVital");
        }
    }
}
