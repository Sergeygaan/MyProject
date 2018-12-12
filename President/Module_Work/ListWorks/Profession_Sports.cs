using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_Sports
    {
        /// <summary>
        /// Стаж работы в данной
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        public string ProfessionMilitary = "Спортивные";

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        public List<Basic_Work> List_Profession;

        public Profession_Sports()
        {
            List_Profession = new List<Basic_Work>
            {
                new Basic_Work("Спортивный инструктор", 1, 1, 8),
                new Basic_Work("Спортивный тренер", 1, 1, 8),
                new Basic_Work("Спортсмен", 1, 1, 8),
            };
        }
    }
}