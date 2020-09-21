using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SheClean.Infra.Data.Migrations
{
    public partial class AufenthaltsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aufenthalte",
                columns: table => new
                {
                    AufenthaltId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(nullable: false),
                    FallNr = table.Column<string>(nullable: true),
                    Datum = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aufenthalte", x => x.AufenthaltId);
                    table.ForeignKey(
                        name: "FK_Aufenthalte_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aufenthalte_PatientId",
                table: "Aufenthalte",
                column: "PatientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aufenthalte");
        }
    }
}
