using SunnySchool.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunnySchool.Services.Controlador
{
    public class Evaluador : SQLRepository<EvaluadorM>, IRepositoryRegistroEvaluador

    {
        public Evaluador(AppDBContext context) : base(context) { }

        public int InsertE(EvaluadorM evaluador)
        {
            if (evaluador == null) throw new ArgumentNullException("Entity");
            entities.Add(evaluador);
            context.SaveChanges();
            return evaluador.Id;
        }
    }
}
