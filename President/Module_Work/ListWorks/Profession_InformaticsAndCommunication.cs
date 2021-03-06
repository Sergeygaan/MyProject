﻿using Module_Work.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_InformaticsAndCommunication : IProfession
    {
        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        private string _professionName = Lang.Informational;

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        private List<Basic_Work> _list_Profession;

        public Profession_InformaticsAndCommunication()
        {
            _list_Profession = new List<Basic_Work>
            {
                new Basic_Work(Lang.HTMLCoder, 250, 15, 0, 0),
                new Basic_Work(Lang.WebIntegrator, 400, 35, 10, 0),
                new Basic_Work(Lang.Administrator, 300, 20, 45, 0),
                new Basic_Work(Lang.SiteAdministrator, 110, 5, 0, 0),
                new Basic_Work(Lang.Blogger, 750, 25, 85, 0),
                new Basic_Work(Lang.WebDesigner, 615, 50, 20, 0),
                new Basic_Work(Lang.Speaker, 725, 40, 80, 0),
                new Basic_Work(Lang.ContentManager, 320, 25, 15, 0),
                new Basic_Work(Lang.Copywriter, 325, 45, 10, 0),
                new Basic_Work(Lang.RadioHost, 300, 30, 55, 0),
                new Basic_Work(Lang.SisAdministrator, 350, 30, 5, 10),
                new Basic_Work(Lang.Speechwriter, 280, 20, 25, 0),
                new Basic_Work(Lang.TVReporter, 300, 20, 45, 0),
                new Basic_Work(Lang.Tester, 350, 40, 0, 0),
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
