using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TeBank.Migrations
{
    public partial class initalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cuenta",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cedula = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    Nombrecuenta = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: true),
                    Balanceactual = table.Column<decimal>(nullable: false),
                    Tipocuenta = table.Column<int>(nullable: false),
                    Numerocuenta = table.Column<string>(nullable: true),
                    Pinhash = table.Column<byte[]>(nullable: true),
                    Pinsalt = table.Column<byte>(nullable: false),
                    Fechacrear = table.Column<DateTime>(nullable: false),
                    Fechaactualizar = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuenta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transaccion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransaccionUnico = table.Column<string>(nullable: true),
                    Montotransaccion = table.Column<decimal>(nullable: false),
                    TransactionStatus = table.Column<int>(nullable: false),
                    Cuentaemisor = table.Column<string>(nullable: true),
                    Cuentareceptor = table.Column<string>(nullable: true),
                    Comentariotransaccion = table.Column<string>(nullable: true),
                    TipoTransaccion = table.Column<int>(nullable: false),
                    Fechatransaccion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaccion", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cuenta");

            migrationBuilder.DropTable(
                name: "Transaccion");
        }
    }
}
