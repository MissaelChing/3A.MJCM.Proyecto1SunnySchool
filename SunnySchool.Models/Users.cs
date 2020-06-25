using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SunnySchool.Models
{
    [Table("Usuarios")]
    public class Users : BaseEntity
    { 
      [Key]
      public int IDUser { get; set; }
      public string Usuario { get; set; }
      public string Contraseña { get; set; }
      public string Rolusuario { get; set; }

        //Referencias 
        [ForeignKey("Alumno")]
        public int IDalumno { get; set; }
        public List <AlumnoM> AlumnoM { get; set; }
        [ForeignKey("Tutor")]
        public int IDTutor { get; set; }
        public List<TutorM> TutorM { get; set; }
        [ForeignKey("Evaluador")]
        public int IDevaluador { get; set; }
        public List<EvaluadorM> EvaluadorM { get; set; }
       


    }
}
