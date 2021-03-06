﻿using Module_Work.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_Legal : IProfession
    {
        /// <summary>
        /// Стаж работы в данной
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        private string _professionName = Lang.Legal;

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        private List<Basic_Work> _list_Profession;

        public Profession_Legal()
        {
            _list_Profession = new List<Basic_Work>
            {
                new Basic_Work(Lang.Lawyer, 250, 35, 20, 0),
                new Basic_Work(Lang.Clerk, 380, 40, 0, 0),
                new Basic_Work(Lang.Detective, 550, 60, 10, 20),
                new Basic_Work(Lang.Diplomat, 900, 90, 50, 0),
                new Basic_Work(Lang.Notary, 250, 35, 10, 0),
                new Basic_Work(Lang.Policeman, 450, 35, 0, 65),
                new Basic_Work(Lang.Jurist, 170, 5, 10, 0),
                new Basic_Work(Lang.Prosecutor, 700, 60, 60, 0),
                new Basic_Work(Lang.Investigator, 450, 50, 10, 0),
                new Basic_Work(Lang.Bailiff, 105, 0, 0, 0),
                new Basic_Work(Lang.Judge, 1000, 95, 0, 0),
                new Basic_Work(Lang.Warden, 220, 0, 0, 35)
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
