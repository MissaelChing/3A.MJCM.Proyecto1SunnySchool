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
        [BindProperty]
        public AlumnoM alumnoM { get; set; }
        public IRepositorySolicitud repositorysolicitud;
        public IRepositoryAlumno repositoryalumno;

        public FormularioBecaModel(IRepositorySolicitud repositorysolicitud, IRepositoryAlumno repositoryalumno)
        {
            this.repositorysolicitud = repositorysolicitud;
            this.repositoryalumno = repositoryalumno;

        }
        public IActionResult OnPost()
        {
            int a ;
          a =  repositorysolicitud.InsertS(solicitudM);
            if(a==1)
            {
                alumnoM.Nombre = solicitudM.Nombrealumno;
                alumnoM.SolicitudId = solicitudM.Id;
                repositoryalumno.InsertA(alumnoM);
            }
            return Redirect("/FormularioBeca");


        }

    }

}
