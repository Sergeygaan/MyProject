﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_Agriculture : IProfession
    {
        /// <summary>
        /// Стаж работы в данной области
        /// </summary>
        public int workExperience = 0;

        /// <summary>
        /// Название области
        /// </summary>
        private string _professionName = "Сельское хозяйство";

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        private List<Basic_Work> _list_Profession;

        public Profession_Agriculture()
        {
            _list_Profession = new List<Basic_Work>
            {
                new Basic_Work("Агроном", 100, 50, 8),
                new Basic_Work("Ветеринар", 100, 50, 8),
                new Basic_Work("Животновод", 100, 50, 8),
                new Basic_Work("Охотник", 100, 50, 8),
                new Basic_Work("Садовник", 100, 50, 8),
                new Basic_Work("Тракторист", 100, 50, 8),
                new Basic_Work("Фермер", 100, 50, 8),
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