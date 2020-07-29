using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SunnySchool.Models
{
    [Table("Evaluador")]
    public  class EvaluadorM : BaseEntity 
    {
        public string Rolusuario { get; set; }
        public string NombreE { get; set; }

        //referencia 
        public int UsersId { get; set; }
        [ForeignKey("UsersId")]
        public virtual Users Users { get; set; }

    }
}
