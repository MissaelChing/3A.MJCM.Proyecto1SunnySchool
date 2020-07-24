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
    public class RegistroEModel : PageModel
    {
        [BindProperty]
        public Users user { get; set; }
        [BindProperty]
        public EvaluadorM evaluador { get; set; }
        public IRepositoryRegistroTutor repositoryTutor;
        public IRepositoryUsuarios repositoryUsuario;
        public RegistroEModel(IRepositoryRegistroTutor repositoryTutor, IRepositoryUsuarios repositoryUsuario)
        {
            this.repositoryTutor = repositoryTutor;
            this.repositoryUsuario = repositoryUsuario;

        }

        public IActionResult OnPost()
        {
            evaluador.Rolusuario = "Evaluador";
            user.Rolusuario = "Evaluador";
            repositoryUsuario.InsertU(user);
            evaluador.UsersId = user.Id;
            repositoryTutor.InsertE(evaluador);
            return Redirect("/RegistroE");

        }
    }
}