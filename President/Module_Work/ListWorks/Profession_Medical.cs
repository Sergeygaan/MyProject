﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_Medical : IProfession
    {
        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        private string _professionName = "Научные";

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        private List<Basic_Work> _list_Profession;

        public Profession_Medical()
        {
            _list_Profession = new List<Basic_Work>
            {
                new Basic_Work("Акушер", 100, 50, 8),
                new Basic_Work("Врач скорой помощи", 100, 50, 8),
                new Basic_Work("Генетик", 100, 50, 8),
                new Basic_Work("Дерматолог", 100, 50, 8),
                new Basic_Work("Диетолог", 100, 50, 8),
                new Basic_Work("Иммунолог", 100, 50, 8),
                new Basic_Work("Кардиолог", 100, 50, 8),
                new Basic_Work("Кардиохирург", 100, 50, 8),
                new Basic_Work("Косметолог", 100, 50, 8),
                new Basic_Work("Логопед", 100, 50, 8),
                new Basic_Work("Массажист", 100, 50, 8),
                new Basic_Work("Невропатолог", 100, 50, 8),
                new Basic_Work("Офтальмолог", 100, 50, 8),
                new Basic_Work("Педиатр", 1, 1, 8)        ,
                new Basic_Work("Психолог", 100, 50, 8),
                new Basic_Work("Стоматолог", 100, 50, 8),
                new Basic_Work("Терапевт", 100, 50, 8),
                new Basic_Work("Фармацевт", 100, 50, 8),
                new Basic_Work("Фельдшер", 1, 1, 8)
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