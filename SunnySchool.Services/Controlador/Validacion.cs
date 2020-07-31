using Microsoft.EntityFrameworkCore;
using SunnySchool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SunnySchool.Services.Controlador
{
    public class Validacion : SQLRepository<Users>, IRepositoryValidar
    {
        
        public Validacion(AppDBContext context) : base (context) { }
        public IEnumerable<Users> GetUsers()
        {
            return context.Set<Users>().AsEnumerable();
        }

        public AlumnoM getusuarios(int id)
        {

            return context.Alumno.Include(x=>x.Id).FirstOrDefault(x => x.Id == id);

        }
        public EvaluadorM getusuariosE(int id)
        {

            return context.Evaluador.Include(x => x.Id).FirstOrDefault(x => x.Id == id);

        }
       
        public int Validar(Users users)
        {
            var cuenta2 = context.Users.ToList();
            int i = 0;
            foreach (var items in cuenta2)
            {
                if(users.Usuario == items.Usuario && users.Contraseña == items.Contraseña)
                {
                    users.Rolusuario = items.Rolusuario;
                    i = items.Id;
                    break;
                }
               
            }
            return i;
        }
        
    }
}
     
       
    

