﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
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
        public Users users { get; set; }

        public IRepositoryValidar  repositorycuentas;
        
        public int i;
        public string Rol;
        public LoginModel(IRepositoryValidar  repositorycuentas)
        {
            this.repositorycuentas = repositorycuentas;

        }

        public IActionResult OnPost()
        {
            i = repositorycuentas.Validar(users);


            if (i >= 1 & users.Rolusuario =="Evaluador")
            {

                return Redirect("/Home");

            }
            else
            {
                if(i >= 1 & users.Rolusuario == "Tutor")
                {
                    return Redirect("/Home2");
                }
               
            }
            return Redirect("/Index");
        }
    }
}