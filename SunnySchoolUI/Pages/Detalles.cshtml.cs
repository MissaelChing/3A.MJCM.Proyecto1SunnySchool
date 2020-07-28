using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SunnySchool.Models;
using SunnySchool.Services;
using SunnySchool.Services.Controlador;

namespace SunnySchoolUI.Pages
{
    public class DetallesModel : PageModel
    {
        [BindProperty]
        public SolicitudM Solicitud { get; private set; }
        public SelectList Solicitudes { get; private set; }

        public IRepositorySolicitud repositorysolicitud;
        public DetallesModel(IRepositorySolicitud repositorysolicitud)
        {
            this.repositorysolicitud = repositorysolicitud;

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
    }
}