using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_PublishingAndTypography
    {
        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        public string ProfessionMilitary = "Издательство и типография";

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        public List<Basic_Work> List_ProfessionMilitary;

        public Profession_PublishingAndTypography()
        {
            List_ProfessionMilitary = new List<Basic_Work>
            {
                new Basic_Work("Верстальщик", 1, 1, 8),
                new Basic_Work("Выпускающий редактор", 1, 1, 8),
                new Basic_Work("Издатель", 1, 1, 8),
                new Basic_Work("Корректор", 1, 1, 8),
                new Basic_Work("Переплетчик", 1, 1, 8),
                new Basic_Work("Печатник", 1, 1, 8),
                new Basic_Work("Редактор", 1, 1, 8),
                new Basic_Work("Фальцовщик", 1, 1, 8)
            };
        }
    }
}
