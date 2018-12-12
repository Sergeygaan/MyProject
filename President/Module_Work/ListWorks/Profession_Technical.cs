using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_Technical
    {
        /// <summary>
        /// Стаж работы в данной
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        public string ProfessionMilitary = "Технические";

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        public List<Basic_Work> List_Profession;

        public Profession_Technical()
        {
            List_Profession = new List<Basic_Work>
            {
                new Basic_Work("Автомеханик", 1, 1, 8),
                new Basic_Work("Водолаз", 1, 1, 8),
                new Basic_Work("Геодезист", 1, 1, 8),
                new Basic_Work("Звукооператор", 1, 1, 8),
                new Basic_Work("Каменщик", 1, 1, 8),
                new Basic_Work("Картограф", 1, 1, 8),
                new Basic_Work("Крановщик", 1, 1, 8),
                new Basic_Work("Краснодеревщик", 1, 1, 8),
                new Basic_Work("Кровельщик", 1, 1, 8),
                new Basic_Work("Литейщик", 1, 1, 8),
                new Basic_Work("Маляр", 1, 1, 8),
                new Basic_Work("Маркшейдер", 1, 1, 8),
                new Basic_Work("Металлург", 1, 1, 8),
                new Basic_Work("Облицовщик", 1, 1, 8),
                new Basic_Work("Отделочник", 1, 1, 8),
                new Basic_Work("Плотник", 1, 1, 8),
                new Basic_Work("Прораб", 1, 1, 8),
                new Basic_Work("Слесарь", 1, 1, 8),
                new Basic_Work("Строитель", 1, 1, 8),
                new Basic_Work("Технолог", 1, 1, 8),
                new Basic_Work("Прораб", 1, 1, 8),
                new Basic_Work("Часовщик", 1, 1, 8),
            };
        }
    }
}
