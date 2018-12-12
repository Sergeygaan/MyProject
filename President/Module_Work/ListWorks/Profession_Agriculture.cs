using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_Agriculture
    {
        /// <summary>
        /// Стаж работы в данной области
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        public string ProfessionMilitary = "Сельское хозяйство";

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        public List<Basic_Work> List_Profession;

        public Profession_Agriculture()
        {
            List_Profession = new List<Basic_Work>
            {
                new Basic_Work("Агроном", 1, 1, 8),
                new Basic_Work("Ветеринар", 1, 1, 8),
                new Basic_Work("Животновод", 1, 1, 8),
                new Basic_Work("Охотник", 1, 1, 8),
                new Basic_Work("Садовник", 1, 1, 8),
                new Basic_Work("Тракторист", 1, 1, 8),
                new Basic_Work("Фермер", 1, 1, 8),
            };
        }
    }
}