﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SunnySchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Rotativa.AspNetCore;
using System.Diagnostics;
using System.IO;
using Syncfusion.HtmlConverter;
using System.Dynamic;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Syncfusion.Pdf;
using System.Net.Mail;
using System.Net;

namespace SunnySchool.Services.Controlador
{
   public class Solicitud : SQLRepository<SolicitudM>, IRepositorySolicitud
    {
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment _hostingEnvironment;
        public Solicitud(AppDBContext context, Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment) : base(context) 
        {
            _hostingEnvironment = hostingEnvironment;
        }


        public int InsertS(SolicitudM solicitudM)
        {
            if (solicitudM == null) throw new ArgumentNullException("Entity");
            entities.Add(solicitudM);
            context.SaveChanges();
            return solicitudM.Id;
        }

        public Task SendEmailAsync2(SolicitudM solicitud)
        {
            try
            {
                // Credentials
                var credentials = new NetworkCredential("SunnySchool012@gmail.com", "mdjcm0021");
                // Mail message
                var mail = new MailMessage()
                {
                    From = new MailAddress("sunnyschool012@gmail.com", "Coordinacion De Becas"),
                    Subject = "SOLICITUD DE BECA",
                    Body = "Tu Solicitud ha sido Rechazada",
                    IsBodyHtml = true
                };

                mail.To.Add(new MailAddress(solicitud.Correo));

                // Smtp client
                var client = new SmtpClient()
                {
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Host = "smtp.gmail.com",
                    EnableSsl = true,
                    Credentials = credentials
                };

                // Send it...         
                client.Send(mail);
            }
            catch (Exception ex)
            {
                // TODO: handle exception
                throw new InvalidOperationException(ex.Message);
            }

            return Task.CompletedTask;
        }
        public Task SendEmailAsync(SolicitudM solicitud)
        {
            try
            {
                // Credentials
                var credentials = new NetworkCredential("SunnySchool012@gmail.com", "mdjcm0021");
                // Mail message
                var mail = new MailMessage()
                {
                    From = new MailAddress("sunnyschool012@gmail.com", "Coordinacion De Becas"),
                    Subject = "SOLICITUD DE BECA",
                    Body = "Tu Solicitud ha sido revisada favor de rellenar el formulario socioeconomico para poder proceder a agendar una cita",
                    IsBodyHtml = true
                };

                mail.To.Add(new MailAddress(solicitud.Correo));

                // Smtp client
                var client = new SmtpClient()
                {
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Host = "smtp.gmail.com",
                    EnableSsl = true,
                    Credentials = credentials
                };

                // Send it...         
                client.Send(mail);
            }
            catch (Exception ex)
            {
                // TODO: handle exception
                throw new InvalidOperationException(ex.Message);
            }

            return Task.CompletedTask;
        }
        public IActionResult Detalles()
        {
            HtmlToPdfConverter converter = new HtmlToPdfConverter();
            WebKitConverterSettings settings = new WebKitConverterSettings();
            settings.WebKitPath = Path.Combine(_hostingEnvironment.ContentRootPath, "QtBinariesWindows");
            converter.ConverterSettings = settings;
            PdfDocument document = converter.Convert("https://localhost:44367/detalles/");
                MemoryStream ms = new MemoryStream();
            document.Save(ms);
            document.Close(true);
            ms.Position = 0;
            FileStreamResult fileStreamResult = new FileStreamResult(ms, "application/pdf");
            fileStreamResult.FileDownloadName = "Reporte";
            return fileStreamResult;
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
        public SolicitudM Deletes(SolicitudM Solicitud)
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
            temp.UpdatedAT = DateTime.Now;
            temp.Status = false;
            var entity = entities.Attach(temp);
            entity.State = EntityState.Modified;
            context.Remove(temp);
            context.SaveChanges();
            return temp;
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
