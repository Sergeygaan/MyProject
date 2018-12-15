using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_Food : IProfession
    {
        /// <summary>
        /// Стаж работы в данной
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        private string _professionName = "Пищевые";

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        private List<Basic_Work> _list_Profession;

        public Profession_Food()
        {
            _list_Profession = new List<Basic_Work>
            {
                new Basic_Work("Булочник", 100, 8, 0, 0, 0),
                new Basic_Work("Винодел", 100, 8, 0, 0, 0),
                new Basic_Work("Дегустатор", 100, 8, 0, 0, 0),
                new Basic_Work("Месильщик", 100, 8, 0, 0, 0),
                new Basic_Work("Мясник", 100, 8, 0, 0, 0),
                new Basic_Work("Пекарь", 100, 8, 0, 0, 0),
                new Basic_Work("Повар", 100, 8, 0, 0, 0),
                new Basic_Work("Повар-кондитер", 100, 8, 0, 0, 0),
                new Basic_Work("Шеф-повар", 100, 8, 0, 0, 0),
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
