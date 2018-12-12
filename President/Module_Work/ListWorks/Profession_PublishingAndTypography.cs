using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_PublishingAndTypography : IProfession
    {
        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        private string _professionName = "Издательство и типография";

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        private List<Basic_Work> _list_Profession;

        public Profession_PublishingAndTypography()
        {
            _list_Profession = new List<Basic_Work>
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
