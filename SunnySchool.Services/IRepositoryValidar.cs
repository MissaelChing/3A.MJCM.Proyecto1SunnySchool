using System;
using System.Collections.Generic;
using System.Text;
using SunnySchool.Models;
using SunnySchool.Services.Controlador;

namespace SunnySchool.Services
{
    public interface IRepositoryValidar 
    {

        public int Validar(Users users);
       
    }
}
