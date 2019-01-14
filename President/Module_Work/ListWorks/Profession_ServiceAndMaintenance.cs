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
                new Basic_Work(Lang.TravelAgent, 100, 0, 0, 0),
                new Basic_Work(Lang.Bartender, 100, 0, 0, 0),
                new Basic_Work(Lang.Librarian, 100, 0, 0, 0),
                new Basic_Work(Lang.Visagiste, 100, 0, 0, 0),
                new Basic_Work(Lang.GuideTranslator, 100, 0, 0, 0),
                new Basic_Work(Lang.Janitor, 100, 0, 0, 0),
                new Basic_Work(Lang.Janitor, 100, 0, 0, 0),
                new Basic_Work(Lang.Storekeeper, 100, 0, 0, 0),
                new Basic_Work(Lang.Manicurist, 100, 0, 0, 0),
                new Basic_Work(Lang.GarbageMan, 100, 0, 0, 0),
                new Basic_Work(Lang.Operator, 100, 0, 0, 0),
                new Basic_Work(Lang.Waiter, 100, 0, 0, 0),
                new Basic_Work(Lang.Hairdresser, 100, 0, 0, 0),
                new Basic_Work(Lang.Receptionist, 100, 0, 0, 0),
                new Basic_Work(Lang.Postman, 100, 0, 0, 0),
                new Basic_Work(Lang.Realtor, 100, 0, 0, 0),
                new Basic_Work(Lang.InsuranceAgent, 100, 0, 0, 0),
                new Basic_Work(Lang.Florist, 100, 0, 0, 0),
                new Basic_Work(Lang.Guide, 100, 0, 0, 0),
                new Basic_Work(Lang.Realtor, 100, 0, 0, 0)
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
