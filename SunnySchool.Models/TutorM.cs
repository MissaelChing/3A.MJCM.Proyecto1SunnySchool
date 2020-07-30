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
        public int UsersId { get; set; }
        [ForeignKey("UsersId")]
        public virtual Users Users { get; set; }

    }
}
