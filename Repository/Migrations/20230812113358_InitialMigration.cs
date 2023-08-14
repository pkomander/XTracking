using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Placas",
                columns: table => new
                {
                    PlacaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlacaNumeroSerie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomePlaca = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Placas", x => x.PlacaId);
                });

            migrationBuilder.CreateTable(
                name: "HistoricoLocalizacaos",
                columns: table => new
                {
                    HistoricoLocalizacaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlacaId = table.Column<int>(type: "int", nullable: false),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Altitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoLocalizacaos", x => x.HistoricoLocalizacaoId);
                    table.ForeignKey(
                        name: "FK_HistoricoLocalizacaos_Placas_PlacaId",
                        column: x => x.PlacaId,
                        principalTable: "Placas",
                        principalColumn: "PlacaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoLocalizacaos_PlacaId",
                table: "HistoricoLocalizacaos",
                column: "PlacaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoricoLocalizacaos");

            migrationBuilder.DropTable(
                name: "Placas");
        }
    }
}
