using SunnySchool.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunnySchool.Services.Controlador
{
    public class Usuarios :SQLRepository<Users>,IRepositoryUsuarios
    {
        public Usuarios(AppDBContext context) : base(context) { }

        public int InsertU(Users users)
        {
            if (users == null) throw new ArgumentNullException("Entity");
            entities.Add(users);
            context.SaveChanges();
            return users.Id;
        }
    }
}
