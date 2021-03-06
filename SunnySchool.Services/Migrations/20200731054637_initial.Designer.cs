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
    [Migration("20200731054637_initial")]
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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SolicitudId")
                        .HasColumnType("int");

                    b.Property<int?>("SolicitudMId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("SolicitudMId");

                    b.ToTable("Alumnos");
                });

            modelBuilder.Entity("SunnySchool.Models.EvaluadorM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rolusuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsersId");

                    b.ToTable("Evaluador");
                });

            modelBuilder.Entity("SunnySchool.Models.Socioeconomico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Agenda")
                        .HasColumnType("datetime2");

                    b.Property<int>("Alimentacion")
                        .HasColumnType("int");

                    b.Property<int?>("AlumnoId")
                        .HasColumnType("int");

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Construccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<int>("Distribucion")
                        .HasColumnType("int");

                    b.Property<int>("EgresosM")
                        .HasColumnType("int");

                    b.Property<int>("Escolaridad")
                        .HasColumnType("int");

                    b.Property<int>("IngresosM")
                        .HasColumnType("int");

                    b.Property<string>("Mobiliario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observaciones")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Otros")
                        .HasColumnType("int");

                    b.Property<int>("Servicios")
                        .HasColumnType("int");

                    b.Property<string>("ServiciosV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SolicitudesId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("StatusV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.Property<int>("Transporte")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.Property<int>("Vivienda")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AlumnoId");

                    b.HasIndex("SolicitudesId");

                    b.ToTable("Socioeconomico");
                });

            modelBuilder.Entity("SunnySchool.Models.SolicitudM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Colonia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("Curp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaNmadre")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaNpadre")
                        .HasColumnType("datetime2");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IngresoM")
                        .HasColumnType("int");

                    b.Property<int>("IngresoP")
                        .HasColumnType("int");

                    b.Property<string>("Localidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Municipio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nacionalidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NacionalidadMadre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NacionalidadPadre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameMadre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NamePadre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombrealumno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OcupacionMadre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OcupacionPadre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("StatusS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Solicitudes");
                });

            modelBuilder.Entity("SunnySchool.Models.TutorM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rolusuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsersId");

                    b.ToTable("Tutor");
                });

            modelBuilder.Entity("SunnySchool.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("Rolusuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SunnySchool.Models.AlumnoM", b =>
                {
                    b.HasOne("SunnySchool.Models.SolicitudM", null)
                        .WithMany("Alumnos")
                        .HasForeignKey("SolicitudMId");
                });

            modelBuilder.Entity("SunnySchool.Models.EvaluadorM", b =>
                {
                    b.HasOne("SunnySchool.Models.Users", "Users")
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SunnySchool.Models.Socioeconomico", b =>
                {
                    b.HasOne("SunnySchool.Models.AlumnoM", "Alumnos")
                        .WithMany()
                        .HasForeignKey("AlumnoId");

                    b.HasOne("SunnySchool.Models.SolicitudM", "Solicitud")
                        .WithMany()
                        .HasForeignKey("SolicitudesId");
                });

            modelBuilder.Entity("SunnySchool.Models.TutorM", b =>
                {
                    b.HasOne("SunnySchool.Models.Users", "Users")
                        .WithMany("TutorM")
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
