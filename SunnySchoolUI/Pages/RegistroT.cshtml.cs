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
    public class RegistroTModel : PageModel
    {
        [BindProperty]
        public Users user { get; set; }
        [BindProperty]
        public TutorM tutor { get; set; }
        public IRepositoryRegistroTutor repositoryTutor;
        public IRepositoryUsuarios repositoryUsuario;
        public RegistroTModel(IRepositoryRegistroTutor repositoryTutor, IRepositoryUsuarios repositoryUsuario)
        {
            this.repositoryTutor = repositoryTutor;
            this.repositoryUsuario = repositoryUsuario;

        }
        
        public IActionResult OnPost()
        {
            tutor.Rolusuario = "Tutor";
            user.Rolusuario = "Tutor";
            repositoryUsuario.InsertU(user);
            tutor.UsersId = user.Id ;
            repositoryTutor.InsertT(tutor);
            return Redirect("/RegistroT");

        }
    }
}