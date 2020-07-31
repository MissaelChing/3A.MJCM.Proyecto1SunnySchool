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
        [DisplayName("Correo")]
        [Required(ErrorMessage = "El Correo es requerido.")]
        public string Correo { get; set; }
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
        public DateTime FechaNacimiento { get; set; }
        [DisplayName("Nombre del padre")]
        [Required(ErrorMessage = "El nombre es requerido.")]
        public string NamePadre { get; set; }
        [DisplayName("Fecha Nacimiento del padre")]
        [Required(ErrorMessage = "La fecha es requerida.")]
        public DateTime FechaNpadre { get; set; }
        [DisplayName("Nacionalidad del padre")]
        [Required(ErrorMessage = "La Nacionalidad es requerida.")]
        public string NacionalidadPadre { get; set; }
        [DisplayName("Ocupacion del padre")]
        [Required(ErrorMessage = "La Ocupacion es requerida.")]
        public string OcupacionPadre { get; set; }
        [DisplayName("Ingreso del padre $")]
        [Required(ErrorMessage = "La Ingreso es requerido.")]
        public int IngresoP { get; set; }
        [DisplayName("Nombre de la madre")]
        [Required(ErrorMessage = "La Nombre es requerido.")]
        public string NameMadre { get; set; }
        [DisplayName("Fecha de nacimiento de la madr")]
        [Required(ErrorMessage = "La Fecha es requerida.")]
        public DateTime FechaNmadre { get; set; }
        [DisplayName("Nacionalidad de la madre")]
        [Required(ErrorMessage = "La Nacionalidad es requerida.")]
        public string NacionalidadMadre { get; set; }
        [DisplayName("Ocupacion de la madre")]
        [Required(ErrorMessage = "La Ocupacion es requerida.")]
        public string OcupacionMadre { get; set; }
        [DisplayName("Ingreso del la madre $")]
        [Required(ErrorMessage = "La Ingreso es requerido.")]
        public int IngresoM { get; set; }
        [DisplayName("Colonia")]
        [Required(ErrorMessage = "La Colonia es requerida.")]
        public string Colonia { get; set; }
        [DisplayName("Municipio")]
        [Required(ErrorMessage = "El Municipio es requerido.")]
        public string Municipio { get; set; }
        [DisplayName("Localidad")]
        [Required(ErrorMessage = "La Localidad es requerida.")]
        public string Localidad { get; set; }
        public string StatusS { get; set; }

        //referencias 
        public List<AlumnoM> Alumnos { get; set; }

       
    }
}
