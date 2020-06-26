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
        public SolicitudM solicitudM{ get; set; }
        public readonly IRepository<SolicitudM> repositorysolicitar;
        public FormularioBecaModel(IRepository<SolicitudM> repositorysolicitar)
        {
            this.repositorysolicitar = repositorysolicitar;

        }
        
        public IActionResult OnPost()
        {
            repositorysolicitar.Insert(solicitudM);
            return Redirect("/Pages/Index?id=" + solicitudM);
        }
    }
}