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
                new Basic_Work("Воспитатель", 100, 8, 0, 0, 0),
                new Basic_Work("Дефектолог", 100, 8, 0, 0, 0),
                new Basic_Work("Кинолог", 100, 8, 0, 0, 0),
                new Basic_Work("Педагог", 100, 8, 0, 0, 0),
                new Basic_Work("Преподаватель", 100, 8, 0, 0, 0),
                new Basic_Work("Ректор", 100, 8, 0, 0, 0),
                new Basic_Work("Сурдопедагог", 100, 8, 0, 0, 0),
                new Basic_Work("Учитель", 100, 8, 0, 0, 0),
                new Basic_Work("Хореограф",100, 8, 0, 0, 0),
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
