using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_Medical
    {
        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        public string ProfessionMilitary = "Научные";

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        public List<Basic_Work> List_ProfessionMilitary;

        public Profession_Medical()
        {
            List_ProfessionMilitary = new List<Basic_Work>
            {
                new Basic_Work("Акушер", 1, 1, 8),
                new Basic_Work("Врач скорой помощи", 1, 1, 8),
                new Basic_Work("Генетик", 1, 1, 8),
                new Basic_Work("Дерматолог", 1, 1, 8),
                new Basic_Work("Диетолог", 1, 1, 8),
                new Basic_Work("Иммунолог", 1, 1, 8),
                new Basic_Work("Кардиолог", 1, 1, 8),
                new Basic_Work("Кардиохирург", 1, 1, 8),
                new Basic_Work("Косметолог", 1, 1, 8),
                new Basic_Work("Логопед", 1, 1, 8),
                new Basic_Work("Массажист", 1, 1, 8),
                new Basic_Work("Невропатолог", 1, 1, 8),
                new Basic_Work("Офтальмолог", 1, 1, 8),
                new Basic_Work("Педиатр", 1, 1, 8)        ,
                new Basic_Work("Психолог", 1, 1, 8),
                new Basic_Work("Стоматолог", 1, 1, 8),
                new Basic_Work("Терапевт", 1, 1, 8),
                new Basic_Work("Фармацевт", 1, 1, 8),
                new Basic_Work("Фельдшер", 1, 1, 8)
            };
        }
    }
}