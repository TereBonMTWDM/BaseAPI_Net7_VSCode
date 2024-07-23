using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace INVERSERCobranzaAPI.Migrations
{
    /// <inheritdoc />
    public partial class CobranzaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cobranza",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Asegurado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdRamo = table.Column<int>(type: "int", nullable: false),
                    NumPoliza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InicioPoliza = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TerminoPoliza = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdPeriodicidad = table.Column<int>(type: "int", nullable: false),
                    IdConducto = table.Column<int>(type: "int", nullable: false),
                    IdEstatusCobro = table.Column<int>(type: "int", nullable: false),
                    IdCompania = table.Column<int>(type: "int", nullable: false),
                    Plan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdEstatusPlan = table.Column<int>(type: "int", nullable: false),
                    IdTipoPoliza = table.Column<int>(type: "int", nullable: false),
                    IdMoneda = table.Column<int>(type: "int", nullable: false),
                    PrimaTotal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimaNeta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Psfp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cobranza", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cobranza");
        }
    }
}
