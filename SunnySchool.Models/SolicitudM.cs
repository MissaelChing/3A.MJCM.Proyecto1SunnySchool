using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SunnySchool.Models
{
    [Table("Solicitudes")]
    public  class SolicitudM : BaseEntity
    {
        [Key]
        public int IDsolicitud { get; set; }
        public string IDalumno { get; set; }
        public string Nombrealumno { get; set; }
        public string Curp { get; set; }
        public string Genero { get; set; }
        public string Nacionalidad { get; set; }
        public string FechaNacimiento { get; set; }
        //referencias 
        public List<AlumnoM> Alumnos { get; set; }


    }
}
