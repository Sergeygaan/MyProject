using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_Scientific : IProfession
    {
        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        private string _professionName = "Медицинские";

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        private List<Basic_Work> _list_Profession;

        public Profession_Scientific()
        {
            _list_Profession = new List<Basic_Work>
            {
                new Basic_Work("Археолог", 100, 0, 0, 0),
                new Basic_Work("Архивариус", 100, 0, 0, 0),
                new Basic_Work("Астроном", 100, 0, 0, 0),
                new Basic_Work("Библиограф", 100, 0, 0, 0),
                new Basic_Work("Биоинженер", 100, 0, 0, 0),
                new Basic_Work("Биолог", 100, 0, 0, 0),
                new Basic_Work("Биохимик", 100, 0, 0, 0),
                new Basic_Work("Востоковед", 100, 0, 0, 0),
                new Basic_Work("Геолог", 100, 0, 0, 0),
                new Basic_Work("Логопед", 100, 0, 0, 0),
                new Basic_Work("Египтолог", 100, 0, 0, 0),
                new Basic_Work("Искусствовед", 100, 0, 0, 0),
                new Basic_Work("Историк", 100, 0, 0, 0),
                new Basic_Work("Ихтиолог", 100, 0, 0, 0),
                new Basic_Work("Конструктор", 100, 0, 0, 0),
                new Basic_Work("Культуролог", 100, 0, 0, 0),
                new Basic_Work("Математик", 100, 0, 0, 0),
                new Basic_Work("Метеоролог", 100, 0, 0, 0),
                new Basic_Work("Орнитолог", 100, 0, 0, 0),
                new Basic_Work("Лингвист", 100, 0, 0, 0),
                new Basic_Work("Палеонтолог", 100, 0, 0, 0),
                new Basic_Work("Политолог", 100, 0, 0, 0),
                new Basic_Work("Почвовед", 100, 0, 0, 0),
                new Basic_Work("Религиовед", 100, 0, 0, 0),
                new Basic_Work("Социолог", 100, 0, 0, 0),
                new Basic_Work("Философ", 100, 0, 0, 0),
                new Basic_Work("Эколог", 100, 0, 0, 0),
                new Basic_Work("Этнограф", 100, 0, 0, 0),
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
