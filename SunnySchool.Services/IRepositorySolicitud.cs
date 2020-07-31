using Microsoft.AspNetCore.Mvc;
using SunnySchool.Models;
using SunnySchool.Services.Controlador;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SunnySchool.Services
{
   public  interface IRepositorySolicitud 
    {
          
            public int InsertS(SolicitudM solicitudM);
            public IEnumerable<SolicitudM> GetAll();
        public IActionResult Detalles();
        public Task SendEmailAsync(SolicitudM solicitud);
        public Task SendEmailAsync2(SolicitudM solicitud);

        public SolicitudM GetS(int id);
        public IEnumerable<SolicitudM> GetWorkshops();
        public SolicitudM Updates(SolicitudM solicitud);
        public SolicitudM Deletes(SolicitudM solicitud);


    }
}
