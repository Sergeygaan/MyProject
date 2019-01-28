using Module_Work.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_ServiceAndMaintenance : IProfession
    {
        /// <summary>
        /// Стаж работы в данной
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        private string _professionName = Lang.Service;

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        private List<Basic_Work> _list_Profession;

        public Profession_ServiceAndMaintenance()
        {
            _list_Profession = new List<Basic_Work>
            {
                new Basic_Work(Lang.TravelAgent, 300, 5, 25, 0),
                new Basic_Work(Lang.Bartender, 200, 0, 20, 0),
                new Basic_Work(Lang.Librarian, 150, 5, 0, 0),
                new Basic_Work(Lang.Visagiste, 250, 0, 30, 0),
                new Basic_Work(Lang.GuideTranslator, 280, 10, 20, 0),
                new Basic_Work(Lang.Janitor, 150, 0, 0, 0),
                new Basic_Work(Lang.Storekeeper, 150, 0, 0, 0),
                new Basic_Work(Lang.Manicurist, 140, 0, 0, 0),
                new Basic_Work(Lang.GarbageMan, 150, 0, 0, 0),
                new Basic_Work(Lang.Operator, 200, 0, 0, 0),
                new Basic_Work(Lang.Waiter, 130, 0, 0, 0),
                new Basic_Work(Lang.Hairdresser, 150, 0, 0, 0),
                new Basic_Work(Lang.Receptionist, 180, 0, 10, 0),
                new Basic_Work(Lang.Postman, 150, 0, 0, 0),
                new Basic_Work(Lang.Realtor, 250, 0, 20, 0),
                new Basic_Work(Lang.InsuranceAgent, 350, 0, 25, 0),
                new Basic_Work(Lang.Florist, 150, 0, 0, 0),
                new Basic_Work(Lang.Guide, 150, 0, 0, 0)
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
