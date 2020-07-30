using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SunnySchool.Services.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Solicitudes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Nombrealumno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Curp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nacionalidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NamePadre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNpadre = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NacionalidadPadre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OcupacionPadre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IngresoP = table.Column<int>(type: "int", nullable: false),
                    NameMadre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNmadre = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NacionalidadMadre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OcupacionMadre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IngresoM = table.Column<int>(type: "int", nullable: false),
                    Colonia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Municipio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Localidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusS = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitudes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rolusuario = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Alumnos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolicitudId = table.Column<int>(type: "int", nullable: false),
                    SolicitudMId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumnos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alumnos_Solicitudes_SolicitudMId",
                        column: x => x.SolicitudMId,
                        principalTable: "Solicitudes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Evaluador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Rolusuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evaluador_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tutor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Rolusuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tutor_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Socioeconomico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Agenda = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IngresosM = table.Column<int>(type: "int", nullable: false),
                    EgresosM = table.Column<int>(type: "int", nullable: false),
                    Alimentacion = table.Column<int>(type: "int", nullable: false),
                    Escolaridad = table.Column<int>(type: "int", nullable: false),
                    Vivienda = table.Column<int>(type: "int", nullable: false),
                    Transporte = table.Column<int>(type: "int", nullable: false),
                    Servicios = table.Column<int>(type: "int", nullable: false),
                    Otros = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    Distribucion = table.Column<int>(type: "int", nullable: false),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiciosV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Construccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobiliario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlumnoId = table.Column<int>(type: "int", nullable: true),
                    SolicitudesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Socioeconomico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Socioeconomico_Alumnos_AlumnoId",
                        column: x => x.AlumnoId,
                        principalTable: "Alumnos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Socioeconomico_Solicitudes_SolicitudesId",
                        column: x => x.SolicitudesId,
                        principalTable: "Solicitudes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alumnos_SolicitudMId",
                table: "Alumnos",
                column: "SolicitudMId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluador_UsersId",
                table: "Evaluador",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Socioeconomico_AlumnoId",
                table: "Socioeconomico",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_Socioeconomico_SolicitudesId",
                table: "Socioeconomico",
                column: "SolicitudesId");

            migrationBuilder.CreateIndex(
                name: "IX_Tutor_UsersId",
                table: "Tutor",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evaluador");

            migrationBuilder.DropTable(
                name: "Socioeconomico");

            migrationBuilder.DropTable(
                name: "Tutor");

            migrationBuilder.DropTable(
                name: "Alumnos");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Solicitudes");
        }
    }
}
