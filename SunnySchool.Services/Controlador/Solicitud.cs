using SunnySchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SunnySchool.Services.Controlador
{
   public class Solicitud : SQLRepository<SolicitudM>, IRepositorySolicitud
    {
        public Solicitud(AppDBContext context) : base(context) { }

        public int InsertS(SolicitudM solicitudM)
        {
            if (solicitudM == null) throw new ArgumentNullException("Entity");
            entities.Add(solicitudM);
            context.SaveChanges();
            return solicitudM.Id;
        }
        public IEnumerable<Solicitud> GetSolicitud()
        {
            return context.Set<Solicitud>().AsEnumerable();
        }


    }
}
