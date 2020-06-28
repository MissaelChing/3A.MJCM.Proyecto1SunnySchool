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
        public IEnumerable<Users> GetWorkshops()
        {
            return context.Set<Users>().AsEnumerable();
        }

        public AlumnoM getusuarios(int id)
        {

            return context.Alumno.Include(x=>x.IDalumno).FirstOrDefault(x => x.IDalumno == id);

        }
        public EvaluadorM getusuariosE(int id)
        {

            return context.Evaluador.Include(x => x.IDevaluador).FirstOrDefault(x => x.IDevaluador == id);

        }
        public TutorM getusuariosT(int id)
        {

            return context.Tutor.Include(x => x.IDTutor).FirstOrDefault(x => x.IDTutor == id);

        }
        public int Validar(Users users )
        {
            var cuenta = context.Users.Include(x => x.AlumnoM).ToList();
            var cuenta1 = context.Users.Include(x => x.EvaluadorM).ToList();
            var cuenta2 = context.Users.Include(x => x.TutorM).ToList();
            int i = 0;
            foreach (var items in cuenta2)
            {
                if(users.Usuario == items.Usuario && users.Contraseña == items.Contraseña)
                {
                    i = items.Id;
                }
            }
            return i;
        }
    }
}
     
       
    

