using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SunnySchool.Models;
using SunnySchool.Services;

namespace SunnySchoolUI.Pages
{
    public class FormularioBecaModel : PageModel
    {
        [BindProperty]
        public SolicitudM solicitudM { get; set; }
        public IRepositorySolicitud repositorysolicitud;
        public FormularioBecaModel(IRepositorySolicitud repositorysolicitud)
        {
            this.repositorysolicitud = repositorysolicitud;

        }
        public IActionResult OnPost()
        {
            repositorysolicitud.InsertS(solicitudM); 
            return Redirect("/FormularioBeca");

        }

    }

}
