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
        public string Rolusuario { get; set; }
        public string NombreT { get; set; }
        //referencias

        [ForeignKey("Users")]
        public int UserId { get; set; }

    }
}
