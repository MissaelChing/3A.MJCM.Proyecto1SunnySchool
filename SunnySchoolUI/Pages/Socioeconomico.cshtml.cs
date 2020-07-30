using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SunnySchool.Models;
using SunnySchool.Services;

namespace SunnySchoolUI.Pages
{
    public class SocioeconomicoModel : PageModel
    {
        [BindProperty]
        public IEnumerable<Socioeconomico> Solicitud { get; set; }
        [BindProperty]
        public Socioeconomico Solicituds { get; set; }

        public SelectList Solicitudes { get; set; }

        public IRepositorySolicitudSocioe repositorySolicitudSocioe;
        public SocioeconomicoModel(IRepositorySolicitudSocioe repositorySolicitudSocioe)
        {
            this.repositorySolicitudSocioe = repositorySolicitudSocioe;

        }
        public void OnGetId(int id)
        {
            Solicituds = repositorySolicitudSocioe.GetS(id);
            Solicitudes = new SelectList(repositorySolicitudSocioe.GetWorkshops(), nameof(Solicituds.Id),
            nameof(Solicituds.Nombre));


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
        public IActionResult OnPostDelete(int Id)
        {
            repositorySolicitudSocioe.Deletes(Solicituds);
            return RedirectToPage("/Socioeconomico");



        }

    }
}