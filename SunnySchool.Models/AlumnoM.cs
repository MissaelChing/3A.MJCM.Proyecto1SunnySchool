using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace SunnySchool.Models
{
    [Table("Alumnos")]
    public class AlumnoM:BaseEntity
    {
        public string Nombre { get; set; }      

        // Definimos nuestra referencia
        [ForeignKey("Solicitudes")]
        public int SolicitudId{ get; set; }

    }
}
