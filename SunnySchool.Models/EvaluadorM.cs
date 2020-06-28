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
        [Key]
        public int IDevaluador { get; set; }
        public int IDUser { get; set; }
        public string Rolusuario { get; set; }
        public string NombreE { get; set; }

        //referencia 




    }
}
