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

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IDUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedAT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rolusuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDalumno = table.Column<int>(type: "int", nullable: false),
                    IDTutor = table.Column<int>(type: "int", nullable: false),
                    IDevaluador = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IDUser);
                });

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
                    Localidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDsolicitud = table.Column<int>(type: "int", nullable: false),
                    SolicitudMIDsolicitud = table.Column<int>(type: "int", nullable: true),
                    UsersIDUser = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumnos", x => x.IDalumno);
                    table.ForeignKey(
                        name: "FK_Alumnos_Solicitudes_SolicitudMIDsolicitud",
                        column: x => x.SolicitudMIDsolicitud,
                        principalTable: "Solicitudes",
                        principalColumn: "IDsolicitud",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alumnos_Usuarios_UsersIDUser",
                        column: x => x.UsersIDUser,
                        principalTable: "Usuarios",
                        principalColumn: "IDUser",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Evaluador",
                columns: table => new
                {
                    IDevaluador = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedAT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IDUser = table.Column<int>(type: "int", nullable: false),
                    Rolusuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsersIDUser = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluador", x => x.IDevaluador);
                    table.ForeignKey(
                        name: "FK_Evaluador_Usuarios_UsersIDUser",
                        column: x => x.UsersIDUser,
                        principalTable: "Usuarios",
                        principalColumn: "IDUser",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tutor",
                columns: table => new
                {
                    IDTutor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedAT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IDUser = table.Column<int>(type: "int", nullable: false),
                    Rolusuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsersIDUser = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutor", x => x.IDTutor);
                    table.ForeignKey(
                        name: "FK_Tutor_Usuarios_UsersIDUser",
                        column: x => x.UsersIDUser,
                        principalTable: "Usuarios",
                        principalColumn: "IDUser",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alumnos_SolicitudMIDsolicitud",
                table: "Alumnos",
                column: "SolicitudMIDsolicitud");

            migrationBuilder.CreateIndex(
                name: "IX_Alumnos_UsersIDUser",
                table: "Alumnos",
                column: "UsersIDUser");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluador_UsersIDUser",
                table: "Evaluador",
                column: "UsersIDUser");

            migrationBuilder.CreateIndex(
                name: "IX_Tutor_UsersIDUser",
                table: "Tutor",
                column: "UsersIDUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alumnos");

            migrationBuilder.DropTable(
                name: "Evaluador");

            migrationBuilder.DropTable(
                name: "Tutor");

            migrationBuilder.DropTable(
                name: "Solicitudes");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
