using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SunnySchool.Models
{
    [Table("Tutor")]
    public class TutorM : BaseEntity
    {
        [Key]
        public int IDTutor { get; set; }
        public int IDUser { get; set; }
        public string Rolusuario { get; set; }
        public string NombreT { get; set; }
        //referencias


    }
}
