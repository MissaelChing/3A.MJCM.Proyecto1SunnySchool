using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SunnySchool.Services;
using SunnySchool.Models;

namespace SunnySchoolUI.Pages
{
    public class FormularioSocioeconomicoModel : PageModel
    {
        [BindProperty]

        public Socioeconomico Socieconomico { get; set; }


        public IRepositorySolicitudSocioe repositorySolicitudSocioe;
        public FormularioSocioeconomicoModel(IRepositorySolicitudSocioe repositorySolicitudSocioe)
        {
            this.repositorySolicitudSocioe = repositorySolicitudSocioe;

        }

        public IActionResult OnPost()
        {

            repositorySolicitudSocioe.InsertS(Socieconomico);
            return Redirect("/Index");

        }
    }
}