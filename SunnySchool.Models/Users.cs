﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SunnySchool.Models
{
    [Table("Users")]
    public class Users : BaseEntity
    { 
      public string Usuario { get; set; }
      public string Contraseña { get; set; }
      public string Rolusuario { get; set; }

        //Referencias 


        public  List <TutorM> TutorM{ get; set; }

    }
}
