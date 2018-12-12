using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_Legal
    {
        /// <summary>
        /// Стаж работы в данной
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        public string ProfessionMilitary = "Юридические";

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        public List<Basic_Work> List_Profession;

        public Profession_Legal()
        {
            List_Profession = new List<Basic_Work>
            {
                new Basic_Work("Адвокат", 1, 1, 8),
                new Basic_Work("Делопроизводитель", 1, 1, 8),
                new Basic_Work("Детектив", 1, 1, 8),
                new Basic_Work("Дипломат", 1, 1, 8),
                new Basic_Work("Нотариус", 1, 1, 8),
                new Basic_Work("Полицейский", 1, 1, 8),
                new Basic_Work("Правовед", 1, 1, 8),
                new Basic_Work("Прокурор", 1, 1, 8),
                new Basic_Work("Следователь", 1, 1, 8),
                new Basic_Work("Судебный пристав", 1, 1, 8),
                new Basic_Work("Судья", 1, 1, 8),
                new Basic_Work("Тюремный надзиратель", 1, 1, 8),
                new Basic_Work("Юрист", 1, 1, 8),
                new Basic_Work("Судья", 1, 1, 8),
            };
        }
    }
}
