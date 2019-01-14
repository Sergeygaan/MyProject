using Module_Work.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_Military : IProfession
    {
        /// <summary>
        /// Стаж работы в данной области
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        private string _professionName = Lang.Military;

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        private List<Basic_Work> _list_Profession;

        public Profession_Military()
        {
            _list_Profession = new List<Basic_Work>
            {
                new Basic_Work(Lang.Serviceman, 100, 0, 0, 0),
                new Basic_Work(Lang.Guard, 100, 0, 0, 0),
                new Basic_Work(Lang.Fireman, 100, 0, 0, 0),
                new Basic_Work(Lang.Scout, 100, 0, 0, 0),
                new Basic_Work(Lang.Rescuer, 100, 0, 0, 0),
                new Basic_Work(Lang.Bodyguard, 100, 0, 0, 0),
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
