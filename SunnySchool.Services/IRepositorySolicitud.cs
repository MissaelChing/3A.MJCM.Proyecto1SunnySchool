using SunnySchool.Models;
using SunnySchool.Services.Controlador;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunnySchool.Services
{
   public  interface IRepositorySolicitud 
    {
          
            public int InsertS(SolicitudM solicitudM);
            public IEnumerable<SolicitudM> GetAll();



    }
}
