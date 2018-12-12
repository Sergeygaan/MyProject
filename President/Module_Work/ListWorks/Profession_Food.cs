using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_Food
    {
        /// <summary>
        /// Стаж работы в данной
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        public string ProfessionMilitary = "Пищевые";

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        public List<Basic_Work> List_Profession;

        public Profession_Food()
        {
            List_Profession = new List<Basic_Work>
            {
                new Basic_Work("Булочник", 1, 1, 8),
                new Basic_Work("Винодел", 1, 1, 8),
                new Basic_Work("Дегустатор", 1, 1, 8),
                new Basic_Work("Месильщик", 1, 1, 8),
                new Basic_Work("Мясник", 1, 1, 8),
                new Basic_Work("Пекарь", 1, 1, 8),
                new Basic_Work("Повар", 1, 1, 8),
                new Basic_Work("Повар-кондитер", 1, 1, 8),
                new Basic_Work("Шеф-повар", 1, 1, 8)
            };
        }
    }
}
