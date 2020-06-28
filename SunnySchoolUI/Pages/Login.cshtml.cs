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
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Users Users { get; set; }

        public IRepositoryValidar  repositorycuentas;
        
        public int i;
        public LoginModel(IRepositoryValidar  repositorycuentas)
        {
            this.repositorycuentas = repositorycuentas;

        }

        public IActionResult OnPost()
        {
            i = repositorycuentas.Validar(Users);
            return Redirect("/Home");

        }
    }
}