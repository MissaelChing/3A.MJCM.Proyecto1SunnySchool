using SunnySchool.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunnySchool.Services.Controlador
{
    public class Tutor : SQLRepository<TutorM>, IRepositoryRegistroTutor
    {
        public Tutor(AppDBContext context) : base(context) { }

        public int InsertT(TutorM tutor)
        {
            if (tutor == null) throw new ArgumentNullException("Entity");
            entities.Add(tutor);
            context.SaveChanges();
            return tutor.Id;
        }
    }
}
