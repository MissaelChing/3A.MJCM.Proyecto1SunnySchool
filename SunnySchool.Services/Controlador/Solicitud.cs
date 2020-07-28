using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SunnySchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
        public SolicitudM Updates(SolicitudM Solicitud)
        {
            var temp = context.Solicitud.FirstOrDefault(x => x.Id == Solicitud.Id)
?? new SolicitudM();
            if (temp.Id == 0)
                return temp;
            temp.Id = Solicitud.Id;
            temp.Nombrealumno = Solicitud.Nombrealumno;
            temp.Curp = Solicitud.Curp;
            temp.Nacionalidad = Solicitud.Nacionalidad;
            temp.FechaNacimiento = Solicitud.FechaNacimiento;
            temp.Genero = Solicitud.Genero;
            temp.NamePadre = Solicitud.NamePadre;
            temp.FechaNpadre = Solicitud.FechaNpadre;
            temp.NacionalidadPadre = Solicitud.NacionalidadPadre;
            temp.OcupacionPadre = Solicitud.OcupacionPadre;
            temp.IngresoP = Solicitud.IngresoP;
            temp.NameMadre = Solicitud.NameMadre;
            temp.FechaNmadre = Solicitud.FechaNmadre;
            temp.NacionalidadMadre = Solicitud.NacionalidadMadre;
            temp.OcupacionMadre = Solicitud.OcupacionMadre;
            temp.IngresoM = Solicitud.IngresoM;
            temp.Municipio = Solicitud.Municipio;
            temp.Localidad = Solicitud.Localidad;
            temp.Colonia = Solicitud.Colonia;
            temp.StatusS = Solicitud.StatusS;
            if (temp == null) throw new ArgumentNullException("Entity");
            if (temp.Id <= 0) throw new ArgumentNullException("Entity");
            var entity = entities.Attach(temp);
            entity.State = EntityState.Modified;
            context.SaveChanges();
            return temp;
        }
        public SolicitudM Deletes(SolicitudM solicitud)
        {
            if (solicitud == null) throw new ArgumentNullException("Entity");
            if (solicitud.Id <= 0) throw new ArgumentNullException("Entity");
            solicitud.UpdatedAT = DateTime.Now;
            solicitud.Status = false;
            var entity = entities.Attach(solicitud);
            entity.State = EntityState.Modified;
            context.SaveChanges();
            return solicitud;
        }

        public SolicitudM GetS(int Id)
        {
            return context.Solicitud.FirstOrDefault(x => x.Id == Id);
        }
        public IEnumerable<SolicitudM> GetWorkshops()
        {
            return context.Solicitud.ToList() ?? new List<SolicitudM>();
        }
    }
}
