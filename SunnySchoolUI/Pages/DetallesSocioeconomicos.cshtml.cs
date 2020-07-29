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
    public class DetallesSocioeconomicosModel : PageModel
    {
        [BindProperty]
        public Socioeconomico Socioeconomico { get; private set; }
        public SelectList Solicitudes { get; private set; }



        public IRepositorySolicitudSocioe repositorySolicitudSocioe;
        public DetallesSocioeconomicosModel(IRepositorySolicitudSocioe repositorySolicitudSocioe)
        {
            this.repositorySolicitudSocioe = repositorySolicitudSocioe;

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
    }
}