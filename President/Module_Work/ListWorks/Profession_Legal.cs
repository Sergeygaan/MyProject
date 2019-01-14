using Module_Work.Language;
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
                new Basic_Work(Lang.Lawyer, 100, 0, 0, 0),
                new Basic_Work(Lang.Clerk, 100, 0, 0, 0),
                new Basic_Work(Lang.Detective, 100, 0, 0, 0),
                new Basic_Work(Lang.Diplomat, 100, 0, 0, 0),
                new Basic_Work(Lang.Notary, 100, 0, 0, 0),
                new Basic_Work(Lang.Policeman, 100, 0, 0, 0),
                new Basic_Work(Lang.Jurist, 100, 0, 0, 0),
                new Basic_Work(Lang.Prosecutor, 100, 0, 0, 0),
                new Basic_Work(Lang.Investigator, 100, 0, 0, 0),
                new Basic_Work(Lang.Bailiff, 100, 0, 0, 0),
                new Basic_Work(Lang.Judge, 100, 0, 0, 0),
                new Basic_Work(Lang.Warden, 100, 0, 0, 0)
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
