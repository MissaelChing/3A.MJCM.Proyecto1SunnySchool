using Microsoft.EntityFrameworkCore;
using SunnySchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SunnySchool.Services.Controlador
{
    public class Socioeconomicos : SQLRepository<Socioeconomico>, IRepositorySolicitudSocioe
    {
        public Socioeconomicos(AppDBContext context) : base(context) { }
        public int InsertS(Socioeconomico socioeconomico)
        {
            if (socioeconomico == null) throw new ArgumentNullException("Entity");
            entities.Add(socioeconomico);
            context.SaveChanges();
            return socioeconomico.Id;

        }
        public Socioeconomico Updates(Socioeconomico socioeconomico)
        {
            var temp = context.Socioeconomicos.FirstOrDefault(x => x.Id == socioeconomico.Id)
?? new Socioeconomico();
            if (temp.Id == 0)
                return temp;
            temp.Id = socioeconomico.Id;
            temp.Nombre = socioeconomico.Nombre;
            temp.Agenda = socioeconomico.Agenda;
            temp.IngresosM = socioeconomico.IngresosM;
            temp.EgresosM = socioeconomico.EgresosM;
            temp.Alimentacion = socioeconomico.Alimentacion;
            temp.Escolaridad = socioeconomico.Escolaridad;
            temp.Vivienda = socioeconomico.Vivienda;
            temp.Transporte = socioeconomico.Transporte;
            temp.Servicios = socioeconomico.Servicios;
            temp.Otros = socioeconomico.Otros;
            temp.Total = socioeconomico.Total;
            temp.Distribucion = socioeconomico.Distribucion;
            temp.Area = socioeconomico.Area;
            temp.ServiciosV = socioeconomico.ServiciosV;
            temp.Construccion = socioeconomico.Construccion;
            temp.StatusV = socioeconomico.StatusV;
            temp.Mobiliario = socioeconomico.Mobiliario;
            temp.Observaciones = socioeconomico.Observaciones;

            if (temp == null) throw new ArgumentNullException("Entity");
            if (temp.Id <= 0) throw new ArgumentNullException("Entity");
            var entity = entities.Attach(temp);
            entity.State = EntityState.Modified;
            context.SaveChanges();
            return temp;
        }
        public Socioeconomico Deletes(Socioeconomico socioeconomico)
        {
            var temp = context.Socioeconomicos.FirstOrDefault(x => x.Id == socioeconomico.Id)
?? new Socioeconomico();
            if (temp.Id == 0)
                return temp;
            temp.Id = socioeconomico.Id;
            temp.Nombre = socioeconomico.Nombre;
            temp.Agenda = socioeconomico.Agenda;
            temp.IngresosM = socioeconomico.IngresosM;
            temp.EgresosM = socioeconomico.EgresosM;
            temp.Alimentacion = socioeconomico.Alimentacion;
            temp.Escolaridad = socioeconomico.Escolaridad;
            temp.Vivienda = socioeconomico.Vivienda;
            temp.Transporte = socioeconomico.Transporte;
            temp.Servicios = socioeconomico.Servicios;
            temp.Otros = socioeconomico.Otros;
            temp.Total = socioeconomico.Total;
            temp.Distribucion = socioeconomico.Distribucion;
            temp.Area = socioeconomico.Area;
            temp.ServiciosV = socioeconomico.ServiciosV;
            temp.Construccion = socioeconomico.Construccion;
            temp.StatusV = socioeconomico.StatusV;
            temp.Mobiliario = socioeconomico.Mobiliario;
            temp.Observaciones = socioeconomico.Observaciones;
            if (temp == null) throw new ArgumentNullException("Entity");
            if (temp.Id <= 0) throw new ArgumentNullException("Entity");
            temp.UpdatedAT = DateTime.Now;
            temp.Status = false;
            var entity = entities.Attach(temp);
            entity.State = EntityState.Modified;
            context.Remove(temp);
            context.SaveChanges();
            return temp;
        }

        public Socioeconomico GetS(int Id)
        {
            return context.Socioeconomicos.FirstOrDefault(x => x.Id == Id);
        }
        public IEnumerable<Socioeconomico> GetWorkshops()
        {
            return context.Socioeconomicos.ToList() ?? new List<Socioeconomico>();
        }

    }
}
