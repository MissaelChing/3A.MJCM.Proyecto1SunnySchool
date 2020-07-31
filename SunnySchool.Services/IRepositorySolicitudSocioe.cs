using SunnySchool.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunnySchool.Services
{
    public interface IRepositorySolicitudSocioe
    {
        public int InsertS(Socioeconomico socioeconomico);
        public IEnumerable<Socioeconomico> GetAll();
        public Socioeconomico GetS(int id);
        public IEnumerable<Socioeconomico> GetWorkshops();
        public Socioeconomico Updates(Socioeconomico socioeconomico);
        public Socioeconomico Deletes(Socioeconomico socioeconomico);

    }
}
