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
                new Basic_Work(Lang.AirTrafficController, 650, 70, 0, 0),
                new Basic_Work(Lang.RaceDriver, 500, 0, 45, 55),
                new Basic_Work(Lang.FlightEngineer, 450, 45, 0, 0),
                new Basic_Work(Lang.FlightAttendant, 350, 0, 45, 0),
                new Basic_Work(Lang.Cosmonaut, 600, 70, 0, 0),
                new Basic_Work(Lang.Pilot, 800, 80, 0, 45),
                new Basic_Work(Lang.Logist, 450, 55, 35, 0),
                new Basic_Work(Lang.Machinist, 550, 35, 0, 65),
                new Basic_Work(Lang.Navigator, 570, 45, 0, 55),
                new Basic_Work(Lang.Forwarder, 390, 40, 20, 0),
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