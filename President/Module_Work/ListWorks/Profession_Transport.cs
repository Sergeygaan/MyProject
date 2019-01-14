using Module_Work.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_Transport : IProfession
    {
        /// <summary>
        /// Стаж работы в данной
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        private string _professionName = Lang.Transport;

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        private List<Basic_Work> _list_Profession;

        public Profession_Transport()
        {
            _list_Profession = new List<Basic_Work>
            {
                new Basic_Work(Lang.AirTrafficController, 100, 0, 0, 0),
                new Basic_Work(Lang.RaceDriver, 100, 0, 0, 0),
                new Basic_Work(Lang.FlightEngineer, 100, 0, 0, 0),
                new Basic_Work(Lang.FlightAttendant, 100, 0, 0, 0),
                new Basic_Work(Lang.Cosmonaut, 100, 0, 0, 0),
                new Basic_Work(Lang.Pilot, 100, 0, 0, 0),
                new Basic_Work(Lang.Logist, 100, 0, 0, 0),
                new Basic_Work(Lang.Machinist, 100, 0, 0, 0),
                new Basic_Work(Lang.Navigator, 100, 0, 0, 0),
                new Basic_Work(Lang.Forwarder, 100, 0, 0, 0),
            };
        }

        public List<Basic_Work> ListProfession()
        {
            return _list_Profession;
        }

        public string ProfessionName()
        {
            return _professionName;
        }
    }
}