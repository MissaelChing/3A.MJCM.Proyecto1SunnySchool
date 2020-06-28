﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SunnySchool.Services;

namespace SunnySchool.Services.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20200627021321_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-preview.5.20278.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SunnySchool.Models.AlumnoM", b =>
                {
                    b.Property<int>("IDalumno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Colonia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("Curp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaN")
                        .HasColumnType("datetime2");

                    b.Property<string>("FechaNmadre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaNpadre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IDUser")
                        .HasColumnType("int");

                    b.Property<int>("IDsolicitud")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("IngresoM")
                        .HasColumnType("int");

                    b.Property<int>("IngresoP")
                        .HasColumnType("int");

                    b.Property<string>("Localidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Municipio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nacionalidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NacionalidadMadre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NacionalidadPadre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameMadre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NamePadre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OcupacionMadre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OcupacionPadre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rolusuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SolicitudMIDsolicitud")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UsersIDUser")
                        .HasColumnType("int");

                    b.HasKey("IDalumno");

                    b.HasIndex("SolicitudMIDsolicitud");

                    b.HasIndex("UsersIDUser");

                    b.ToTable("Alumnos");
                });

            modelBuilder.Entity("SunnySchool.Models.EvaluadorM", b =>
                {
                    b.Property<int>("IDevaluador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<int>("IDUser")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("NombreE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rolusuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UsersIDUser")
                        .HasColumnType("int");

                    b.HasKey("IDevaluador");

                    b.HasIndex("UsersIDUser");

                    b.ToTable("Evaluador");
                });

            modelBuilder.Entity("SunnySchool.Models.SolicitudM", b =>
                {
                    b.Property<int>("IDsolicitud")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("Curp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaNacimiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IDalumno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Nacionalidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombrealumno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.HasKey("IDsolicitud");

                    b.ToTable("Solicitudes");
                });

            modelBuilder.Entity("SunnySchool.Models.TutorM", b =>
                {
                    b.Property<int>("IDTutor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<int>("IDUser")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("NombreT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rolusuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UsersIDUser")
                        .HasColumnType("int");

                    b.HasKey("IDTutor");

                    b.HasIndex("UsersIDUser");

                    b.ToTable("Tutor");
                });

            modelBuilder.Entity("SunnySchool.Models.Users", b =>
                {
                    b.Property<int>("IDUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<int>("IDTutor")
                        .HasColumnType("int");

                    b.Property<int>("IDalumno")
                        .HasColumnType("int");

                    b.Property<int>("IDevaluador")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Rolusuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDUser");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("SunnySchool.Models.AlumnoM", b =>
                {
                    b.HasOne("SunnySchool.Models.SolicitudM", null)
                        .WithMany("Alumnos")
                        .HasForeignKey("SolicitudMIDsolicitud");

                    b.HasOne("SunnySchool.Models.Users", null)
                        .WithMany("AlumnoM")
                        .HasForeignKey("UsersIDUser");
                });

            modelBuilder.Entity("SunnySchool.Models.EvaluadorM", b =>
                {
                    b.HasOne("SunnySchool.Models.Users", null)
                        .WithMany("EvaluadorM")
                        .HasForeignKey("UsersIDUser");
                });

            modelBuilder.Entity("SunnySchool.Models.TutorM", b =>
                {
                    b.HasOne("SunnySchool.Models.Users", null)
                        .WithMany("TutorM")
                        .HasForeignKey("UsersIDUser");
                });
#pragma warning restore 612, 618
        }
    }
}
