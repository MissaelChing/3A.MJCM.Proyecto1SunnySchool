using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace SunnySchool.Models
{
    [Table("Alumnos")]
    public class AlumnoM:BaseEntity
    {
        public string Genero { get; set; }
        public string Curp { get; set; }
        public string Nacionalidad { get; set; }
        public DateTime FechaN { get; set; }
        public string NamePadre { get; set; }
        public string FechaNpadre { get; set; }
        public string NacionalidadPadre { get; set; }
        public string OcupacionPadre { get; set; }
        public int IngresoP { get; set; }
        public string NameMadre { get; set; }
        public string FechaNmadre { get; set; }
        public string NacionalidadMadre { get; set; }
        public string OcupacionMadre { get; set; }
        public int IngresoM { get; set; }
        public string Colonia { get; set; }
        public string Municipio { get; set; }
        public string Localidad { get; set; }



        // Definimos nuestra referencia
        [ForeignKey("Solicitudes")]
        public int SolicitudId{ get; set; }
        [ForeignKey("Alumnos")]
        public int UserId { get; set; }
    }
}
