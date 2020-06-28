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
    public class IndexModel : PageModel
    {
            [BindProperty]
            public Users Users { get; set; }

            public IRepositoryValidar repositorycuentas;

            public int i;
            public IndexModel(IRepositoryValidar repositorycuentas)
            {
                this.repositorycuentas = repositorycuentas;

            }

            public IActionResult OnPost()
            {
                i = repositorycuentas.Validar(Users);
                return Redirect("/Pages/Index" + Users.Id);

            }
        
    }
}