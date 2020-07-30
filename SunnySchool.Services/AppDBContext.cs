using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SunnySchool.Models;
namespace SunnySchool.Services
{
    public class AppDBContext : DbContext
    {
        // Propiedades y métodos de la clase.
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<AlumnoM> Alumno { get; set; }
        public DbSet<SolicitudM> Solicitud { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<TutorM> Tutor { get; set; }
        public DbSet<EvaluadorM> Evaluador { get; set; }
        public DbSet<Socioeconomico> Socioeconomicos { get; set; }


    }

}


   

