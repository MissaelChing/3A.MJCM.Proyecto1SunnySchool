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
    public class AgendaModel : PageModel
    {
        [BindProperty]
        public IEnumerable<Socioeconomico> Solicitud { get; set; }

        public IRepositorySolicitudSocioe repositorySolicitudSocioe;
        public AgendaModel(IRepositorySolicitudSocioe repositorySolicitudSocioe)
        {
            this.repositorySolicitudSocioe = repositorySolicitudSocioe;

        }
 

        public IActionResult OnGet()
        {
            try
            {
                Solicitud = repositorySolicitudSocioe.GetAll();
                return Page();
            }
            catch (Exception ex)
            {
                return RedirectToPage($"/NotFount");
            }
        }
    }
}