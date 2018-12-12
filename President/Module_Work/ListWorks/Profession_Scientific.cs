using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_Scientific
    {
        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        public string ProfessionMilitary = "Медицинские";

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        public List<Basic_Work> List_ProfessionMilitary;

        public Profession_Scientific()
        {
            List_ProfessionMilitary = new List<Basic_Work>
            {
                new Basic_Work("Археолог", 1, 1, 8),
                new Basic_Work("Архивариус", 1, 1, 8),
                new Basic_Work("Астроном", 1, 1, 8),
                new Basic_Work("Библиограф", 1, 1, 8),
                new Basic_Work("Биоинженер", 1, 1, 8),
                new Basic_Work("Биолог", 1, 1, 8),
                new Basic_Work("Биохимик", 1, 1, 8),
                new Basic_Work("Востоковед", 1, 1, 8),
                new Basic_Work("Геолог", 1, 1, 8),
                new Basic_Work("Логопед", 1, 1, 8),
                new Basic_Work("Египтолог", 1, 1, 8),
                new Basic_Work("Искусствовед", 1, 1, 8),
                new Basic_Work("Историк", 1, 1, 8),
                new Basic_Work("Ихтиолог", 1, 1, 8),
                new Basic_Work("Конструктор", 1, 1, 8),
                new Basic_Work("Культуролог", 1, 1, 8),
                new Basic_Work("Математик", 1, 1, 8),
                new Basic_Work("Метеоролог", 1, 1, 8),
                new Basic_Work("Орнитолог", 1, 1, 8),
                new Basic_Work("Лингвист", 1, 1, 8),
                new Basic_Work("Палеонтолог", 1, 1, 8),
                new Basic_Work("Политолог", 1, 1, 8),
                new Basic_Work("Почвовед", 1, 1, 8),
                new Basic_Work("Религиовед", 1, 1, 8),
                new Basic_Work("Социолог", 1, 1, 8),
                new Basic_Work("Философ", 1, 1, 8),
                new Basic_Work("Эколог", 1, 1, 8),
                new Basic_Work("Этнограф", 1, 1, 8)
            };
        }
    }
}
