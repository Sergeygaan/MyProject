using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_Military
    {
        /// <summary>
        /// Стаж работы в данной области
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        public string ProfessionMilitary = "Военные";

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        public List<Basic_Work> List_Profession;

        public Profession_Military()
        {
            List_Profession = new List<Basic_Work>
            {
                new Basic_Work("Военнослужащий", 1, 1, 8),
                new Basic_Work("Конвоир", 1, 1, 8),
                new Basic_Work("Пожарный", 1, 1, 8),
                new Basic_Work("Разведчик", 1, 1, 8),
                new Basic_Work("Спасатель", 1, 1, 8),
                new Basic_Work("Телохранитель", 1, 1, 8),
            };
        }
    }
}
