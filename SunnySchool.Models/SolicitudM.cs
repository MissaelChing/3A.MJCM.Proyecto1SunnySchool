using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SunnySchool.Models
{
    [Table("Solicitudes")]
    public  class SolicitudM : BaseEntity
    {
        [DisplayName("Nombre del Alumno")]
        [Required(ErrorMessage = "El nombre es requerido.")]
        public string Nombrealumno { get; set; }
        [DisplayName("Curp")]
        [Required(ErrorMessage = "La curp es requerida")]
        public string Curp { get; set; }
        [DisplayName("Genero")]
        [Required(ErrorMessage = "El genero es requerido")]
        public string Genero { get; set; }
        [DisplayName("Nacionalidad")]
        [Required(ErrorMessage = "La Nacionalidad es requerida.")]
        public string Nacionalidad { get; set; }
        [DisplayName("Fecha Nacimiento")]
        [Required(ErrorMessage = "La fecha es requerida.")]
        public string FechaNacimiento { get; set; }
        //referencias 
        public List<AlumnoM> Alumnos { get; set; }


    }
}
