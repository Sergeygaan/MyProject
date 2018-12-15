using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_Legal : IProfession
    {
        /// <summary>
        /// Стаж работы в данной
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        private string _professionName = "Юридические";

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        private List<Basic_Work> _list_Profession;

        public Profession_Legal()
        {
            _list_Profession = new List<Basic_Work>
            {
                new Basic_Work("Адвокат", 100, 8, 0, 0, 0),
                new Basic_Work("Делопроизводитель", 100, 8, 0, 0, 0),
                new Basic_Work("Детектив", 100, 8, 0, 0, 0),
                new Basic_Work("Дипломат", 100, 8, 0, 0, 0),
                new Basic_Work("Нотариус", 100, 8, 0, 0, 0),
                new Basic_Work("Полицейский", 100, 8, 0, 0, 0),
                new Basic_Work("Правовед", 100, 8, 0, 0, 0),
                new Basic_Work("Прокурор", 100, 8, 0, 0, 0),
                new Basic_Work("Следователь", 100, 8, 0, 0, 0),
                new Basic_Work("Судебный пристав", 100, 8, 0, 0, 0),
                new Basic_Work("Судья", 100, 8, 0, 0, 0),
                new Basic_Work("Тюремный надзиратель", 100, 8, 0, 0, 0),
                new Basic_Work("Юрист", 100, 8, 0, 0, 0),
                new Basic_Work("Судья", 100, 8, 0, 0, 0),
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
