using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Registro_Con_Login.Migrations
{
    public partial class Migracionconroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RolID", "DescripcionRol", "EsActivo", "FechaCreacion" },
                values: new object[] { 1, "Con este permiso es posible modificar el precio", false, new DateTime(2021, 11, 7, 16, 53, 46, 70, DateTimeKind.Local).AddTicks(2436) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RolID",
                keyValue: 1);
        }
    }
}
