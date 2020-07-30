using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SunnySchool.Models;
using SunnySchool.Services;
using SunnySchool.Services.Controlador;
using Syncfusion.HtmlConverter;
using Syncfusion.Pdf;

namespace SunnySchoolUI.Pages
{
    public class DetallesModel : PageModel
    {
        [Obsolete]
        private readonly IHostingEnvironment _hostingEnvironment;
        
        
        [BindProperty]
        public SolicitudM Solicitud { get; private set; }
        public SelectList Solicitudes { get; private set; }

        public IRepositorySolicitud repositorysolicitud;
        [Obsolete]

        public DetallesModel(IRepositorySolicitud repositorysolicitud, IHostingEnvironment hostingEnvironment)
        {
            this.repositorysolicitud = repositorysolicitud;
            _hostingEnvironment = hostingEnvironment;


        }
  
        public void OnGet(int Id)
        {
            Solicitud = repositorysolicitud.GetS(Id);
            Solicitudes = new SelectList(repositorysolicitud.GetWorkshops(), nameof(Solicitud.Id),
            nameof(Solicitud.Nombrealumno));
           
        }

        public IActionResult OnPost(SolicitudM solicitud)
        {
            Solicitud = repositorysolicitud.Updates(solicitud);
            
            return Page();
        }

        [Obsolete]
        public IActionResult OnPostDetalles(string submit,int Id)
        {
            Solicitud = repositorysolicitud.GetS(Id);
            Solicitudes = new SelectList(repositorysolicitud.GetWorkshops(), nameof(Solicitud.Id),
            nameof(Solicitud.Nombrealumno));

            HtmlToPdfConverter converter = new HtmlToPdfConverter();
            WebKitConverterSettings settings = new WebKitConverterSettings();
            settings.WebKitPath = Path.Combine(_hostingEnvironment.ContentRootPath, "QtBinariesWindows");
            converter.ConverterSettings = settings;
            PdfDocument document = converter.Convert("https://localhost:44367/detalles/?id="+ Solicitud.Id);
            MemoryStream ms = new MemoryStream();
            document.Save(ms);
            document.Close(true);
            ms.Position = 0;
            FileStreamResult fileStreamResult = new FileStreamResult(ms, "application/pdf");
            fileStreamResult.FileDownloadName = "Reporte.pdf";
            return fileStreamResult;
        }
    }
}