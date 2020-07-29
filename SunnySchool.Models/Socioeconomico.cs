using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace SunnySchool.Models
{
    [Table("Socioeconomico")]

    public class Socioeconomico : BaseEntity
    {
        [DisplayName("Nombre del solicitante")]

        public string Nombre { get; set; }
        [DisplayName("Agenda")]
        public DateTime Agenda { get; set; }

        [DisplayName("Ingresos Mensuales")]
        [Required(ErrorMessage = "El nombre es requerido.")]
        public int IngresosM { get; set; }
        [DisplayName("Egresos Mensuales")]
        [Required(ErrorMessage = "La curp es requerida")]
        public int EgresosM { get; set; }
        [DisplayName("Alimentacion")]
        [Required(ErrorMessage = "El ingreso alimenticio es requerido")]
        public int Alimentacion { get; set; }
        [DisplayName("Escolaridad")]
        [Required(ErrorMessage = "El ingreso de Escolaridad es requerida.")]
        public int Escolaridad { get; set; }
        [DisplayName("Vivienda")]
        [Required(ErrorMessage = "ingreso de vivienda es requerida.")]
        public int Vivienda { get; set; }
        [DisplayName("Transporte")]
        [Required(ErrorMessage = "El ingreso de Transporte es requerido.")]
        public int Transporte { get; set; }
        [DisplayName("Servicios")]
        [Required(ErrorMessage = "El ingreso de los Servicios es requerida.")]
        public int Servicios { get; set; }
        [DisplayName("Otros")]
        [Required(ErrorMessage = "El ingreso de Otros es requerida.")]
        public int Otros { get; set; }
        [DisplayName("Total")]
        public int Total { get; set; }


        [DisplayName("Distribucion de la vivienda")]
        [Required(ErrorMessage = "La Distribucion de la vivienda es requerido.")]
        public int Distribucion { get; set; }

        [DisplayName("Area")]
        [Required(ErrorMessage = "El Area es requerido.")]
        public string Area { get; set; }

        [DisplayName("Servicios")]
        [Required(ErrorMessage = "Los Servicios son requeridos.")]
        public string ServiciosV { get; set; }

        [DisplayName("Construccion")]
        [Required(ErrorMessage = "La Construccion es requerida.")]
        public string Construccion { get; set; }


        [DisplayName("Status de la vivienda")]
        [Required(ErrorMessage = "El status es requerido.")]
        public string StatusV { get; set; }

        [DisplayName("Mobiliario")]
        [Required(ErrorMessage = "El Mobiliario es requerido.")]
        public string Mobiliario { get; set; }
        [DisplayName("Observaciones")]
        [Required(ErrorMessage = "Las Observaciones son requeridas.")] 
        public string Observaciones { get; set; }


        //referencias 
        [ForeignKey("AlumnoId")]

        public AlumnoM Alumnos { get; set; }
        [ForeignKey("SolicitudesId")]

        public SolicitudM Solicitud { get; set; }
    }
}
