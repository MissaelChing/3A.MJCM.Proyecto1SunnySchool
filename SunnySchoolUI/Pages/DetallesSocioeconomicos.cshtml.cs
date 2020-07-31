using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SunnySchool.Models;
using SunnySchool.Services;
using Syncfusion.HtmlConverter;
using Syncfusion.Pdf;

namespace SunnySchoolUI.Pages
{
    public class DetallesSocioeconomicosModel : PageModel
    {
        [Obsolete]
        private readonly IHostingEnvironment _hostingEnvironment;

        [BindProperty]
        public Socioeconomico Socioeconomico { get; private set; }
        public SelectList Solicitudes { get; private set; }

        public IRepositorySolicitudSocioe repositorySolicitudSocioe;
        [Obsolete]

        public DetallesSocioeconomicosModel(IRepositorySolicitudSocioe repositorySolicitudSocioe, IHostingEnvironment hostingEnvironment)
        {
            this.repositorySolicitudSocioe = repositorySolicitudSocioe;
            _hostingEnvironment = hostingEnvironment;


        }


        public void OnGet(int Id)
        {
            Socioeconomico = repositorySolicitudSocioe.GetS(Id);
            Solicitudes = new SelectList(repositorySolicitudSocioe.GetWorkshops(), nameof(Socioeconomico.Id),
            nameof(Socioeconomico.Nombre));

        }

        public IActionResult OnPost(Socioeconomico socioeconomico)
        {
            Socioeconomico = repositorySolicitudSocioe.Updates(socioeconomico);



            return Page();
        }
        [Obsolete]
        public IActionResult OnPostDetalles(string submit, int Id)
        {
            Socioeconomico = repositorySolicitudSocioe.GetS(Id);
            Solicitudes = new SelectList(repositorySolicitudSocioe.GetWorkshops(), nameof(Socioeconomico.Id),
            nameof(Socioeconomico.Nombre));

            HtmlToPdfConverter converter = new HtmlToPdfConverter();
            WebKitConverterSettings settings = new WebKitConverterSettings();
            settings.WebKitPath = Path.Combine(_hostingEnvironment.ContentRootPath, "QtBinariesWindows");
            converter.ConverterSettings = settings;
            PdfDocument document = converter.Convert("https://localhost:44367/detallessocioeconomicos/?id=" + Socioeconomico.Id);
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