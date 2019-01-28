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
                new Basic_Work(Lang.SportsInstructor, 600, 0, 0, 60),
                new Basic_Work(Lang.SportsCoach, 400, 0, 0, 40),
                new Basic_Work(Lang.Athlete, 200, 0, 0, 20),
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