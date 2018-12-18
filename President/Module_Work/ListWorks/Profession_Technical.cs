using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_Technical : IProfession
    {
        /// <summary>
        /// Стаж работы в данной
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        private string _professionName = "Технические";

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        private List<Basic_Work> _list_Profession;

        public Profession_Technical()
        {
            _list_Profession = new List<Basic_Work>
            {
                new Basic_Work("Автомеханик", 100, 0, 0, 0),
                new Basic_Work("Водолаз", 100, 0, 0, 0),
                new Basic_Work("Геодезист", 100, 0, 0, 0),
                new Basic_Work("Звукооператор", 100, 0, 0, 0),
                new Basic_Work("Каменщик", 100, 0, 0, 0),
                new Basic_Work("Картограф", 100, 0, 0, 0),
                new Basic_Work("Крановщик", 100, 0, 0, 0),
                new Basic_Work("Краснодеревщик", 100, 0, 0, 0),
                new Basic_Work("Кровельщик", 100, 0, 0, 0),
                new Basic_Work("Литейщик", 100, 0, 0, 0),
                new Basic_Work("Маляр", 100, 0, 0, 0),
                new Basic_Work("Маркшейдер", 100, 0, 0, 0),
                new Basic_Work("Металлург", 100, 0, 0, 0),
                new Basic_Work("Облицовщик", 100, 0, 0, 0),
                new Basic_Work("Отделочник", 100, 0, 0, 0),
                new Basic_Work("Плотник", 100, 0, 0, 0),
                new Basic_Work("Прораб", 100, 0, 0, 0),
                new Basic_Work("Слесарь", 100, 0, 0, 0),
                new Basic_Work("Строитель", 100, 0, 0, 0),
                new Basic_Work("Технолог", 100, 0, 0, 0),
                new Basic_Work("Прораб", 100, 0, 0, 0),
                new Basic_Work("Часовщик", 100, 0, 0, 0),
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
