using Module_Work.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_Sports : IProfession
    {
        /// <summary>
        /// Стаж работы в данной
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        private string _professionName = Lang.Sport;

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        private List<Basic_Work> _list_Profession;

        public Profession_Sports()
        {
            _list_Profession = new List<Basic_Work>
            {
                new Basic_Work(Lang.SportsInstructor, 100, 0, 0, 0),
                new Basic_Work(Lang.SportsCoach, 100, 0, 0, 0),
                new Basic_Work(Lang.Athlete, 100, 0, 0, 0),
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