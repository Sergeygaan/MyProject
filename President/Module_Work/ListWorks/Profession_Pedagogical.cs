using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_Pedagogical : IProfession
    {
        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в области
        /// </summary>
        public string _professionName = "Педагогические";

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        public List<Basic_Work> _list_Profession;

        public Profession_Pedagogical()
        {
            _list_Profession = new List<Basic_Work>
            {
                new Basic_Work("Воспитатель", 1, 1, 8),
                new Basic_Work("Дефектолог", 1, 1, 8),
                new Basic_Work("Кинолог", 1, 1, 8),
                new Basic_Work("Педагог", 1, 1, 8),
                new Basic_Work("Преподаватель", 1, 1, 8),
                new Basic_Work("Ректор", 1, 1, 8),
                new Basic_Work("Сурдопедагог", 1, 1, 8),
                new Basic_Work("Учитель", 1, 1, 8),
                new Basic_Work("Хореограф", 1, 1, 8)
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
