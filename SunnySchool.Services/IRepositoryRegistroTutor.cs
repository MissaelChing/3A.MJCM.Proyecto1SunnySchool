using SunnySchool.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunnySchool.Services
{
    public interface IRepositoryRegistroTutor
    {
        public int InsertT(TutorM tutor);
        public int InsertE(EvaluadorM evaluador);


    }
}
