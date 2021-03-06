﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.Language;
using SunnySchool.Models;
using SunnySchool.Services;


namespace SunnySchoolUI.Pages
{
    public class TutorModel : PageModel
    {
        [BindProperty]
        public IEnumerable<SolicitudM> Solicitud { get; set; }
        [BindProperty]

        public SolicitudM Solicituds { get; set; }

        public SelectList Solicitudes { get; set; }

        public IRepositorySolicitud repositorysolicitud;
        public TutorModel(IRepositorySolicitud repositorysolicitud)
        {
            this.repositorysolicitud = repositorysolicitud;

        }
       public void OnGetId(int id)
        {
            Solicituds = repositorysolicitud.GetS(id);
            Solicitudes = new SelectList(repositorysolicitud.GetWorkshops(), nameof(Solicituds.Id),
            nameof(Solicituds.Nombrealumno));


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
        public IActionResult OnPostDelete(int Id)
        {
            repositorysolicitud.Deletes(Solicituds);
            return RedirectToPage("/Solicitudes");

            

        }
       


    }
}