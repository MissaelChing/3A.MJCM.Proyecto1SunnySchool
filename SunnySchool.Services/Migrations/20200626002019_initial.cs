using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SunnySchool.Services.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alumnos",
                columns: table => new
                {
                    IDalumno = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedAT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IDUser = table.Column<int>(type: "int", nullable: false),
                    Rolusuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Curp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nacionalidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaN = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NamePadre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNpadre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NacionalidadPadre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OcupacionPadre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IngresoP = table.Column<int>(type: "int", nullable: false),
                    NameMadre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNmadre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NacionalidadMadre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OcupacionMadre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IngresoM = table.Column<int>(type: "int", nullable: false),
                    Colonia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Municipio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Localidad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumnos", x => x.IDalumno);
                });

            migrationBuilder.CreateTable(
                name: "Solicitudes",
                columns: table => new
                {
                    IDsolicitud = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedAT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IDalumno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombrealumno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Curp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nacionalidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitudes", x => x.IDsolicitud);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alumnos");

            migrationBuilder.DropTable(
                name: "Solicitudes");
        }
    }
}
