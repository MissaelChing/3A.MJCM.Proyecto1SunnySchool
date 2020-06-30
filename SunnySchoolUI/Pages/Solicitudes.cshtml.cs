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
    public class TutorModel : PageModel
    {
        [BindProperty]
        public IEnumerable<SolicitudM> Solicitud { get; set; }
        public IRepositorySolicitud repositorysolicitud;
        public TutorModel(IRepositorySolicitud repositorysolicitud)
        {
            this.repositorysolicitud = repositorysolicitud;

        }
        public IActionResult OnGet()
        {
            try
            {
                Solicitud = repositorysolicitud.GetAll();
                return Page();
            }
            catch (Exception ex)
            {
                return RedirectToPage($"/NotFount");
            }
        }

    }
}