using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_Transport : IProfession
    {
        /// <summary>
        /// Стаж работы в данной
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        private string _professionName = "Транспортные";

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        private List<Basic_Work> _list_Profession;

        public Profession_Transport()
        {
            _list_Profession = new List<Basic_Work>
            {
                new Basic_Work("Авиадиспетчер", 1, 1, 8),
                new Basic_Work("Автогонщик", 1, 1, 8),
                new Basic_Work("Бортинженер", 1, 1, 8),
                new Basic_Work("Бортпроводник", 1, 1, 8),
                new Basic_Work("Космонавт", 1, 1, 8),
                new Basic_Work("Летчик", 1, 1, 8),
                new Basic_Work("Логист", 1, 1, 8),
                new Basic_Work("Лоцман", 1, 1, 8),
                new Basic_Work("Машинист", 1, 1, 8),
                new Basic_Work("Штурман", 1, 1, 8),
                new Basic_Work("Экспедитор", 1, 1, 8),
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