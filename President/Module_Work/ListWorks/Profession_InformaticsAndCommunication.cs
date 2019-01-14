using Module_Work.Language;
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
                new Basic_Work(Lang.HTMLCoder, 100, 0, 0, 0),
                new Basic_Work(Lang.WebIntegrator, 100, 0, 0, 0),
                new Basic_Work(Lang.Administrator, 100, 0, 0, 0),
                new Basic_Work(Lang.SiteAdministrator, 100, 0, 0, 0),
                new Basic_Work(Lang.Blogger, 100, 0, 0, 0),
                new Basic_Work(Lang.WebDesigner, 100, 0, 0, 0),
                new Basic_Work(Lang.Speaker, 100, 0, 0, 0),
                new Basic_Work(Lang.ContentManager, 100, 0, 0, 0),
                new Basic_Work(Lang.Copywriter, 100, 0, 0, 0),
                new Basic_Work(Lang.RadioHost, 100, 0, 0, 0),
                new Basic_Work(Lang.SisAdministrator, 100, 0, 0, 0),
                new Basic_Work(Lang.Speechwriter, 100, 0, 0, 0),
                new Basic_Work(Lang.TVReporter, 100, 0, 0, 0),
                new Basic_Work(Lang.Tester, 100, 0, 0, 0),
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
