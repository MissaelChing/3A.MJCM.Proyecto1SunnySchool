using SunnySchool.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunnySchool.Services.Controlador
{
    public class AlumnoS : SQLRepository<AlumnoM>, IRepositoryAlumno
    {
        public AlumnoS(AppDBContext context) : base(context) { }

        public int InsertA(AlumnoM alumno)
        {
         if (alumno == null) throw new ArgumentNullException("Entity");
         entities.Add(alumno);
         context.SaveChanges();
         return alumno.Id;
        }
    }
}
