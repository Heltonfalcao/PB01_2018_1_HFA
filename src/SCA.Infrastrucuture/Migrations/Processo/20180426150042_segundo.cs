using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SCA.Infrastrucuture.Migrations.Processo
{
    public partial class segundo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Audiencia",
                table: "Audiencia");

            migrationBuilder.RenameTable(
                name: "Audiencia",
                newName: "Processo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Processo",
                table: "Processo",
                column: "ProcessoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Processo",
                table: "Processo");

            migrationBuilder.RenameTable(
                name: "Processo",
                newName: "Audiencia");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Audiencia",
                table: "Audiencia",
                column: "ProcessoId");
        }
    }
}
