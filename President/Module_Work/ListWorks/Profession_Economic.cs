using Module_Work.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_Economic : IProfession
    {
        /// <summary>
        /// Стаж работы в данной
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        private string _professionName = Lang.Economic;

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        private List<Basic_Work> _list_Profession;

        public Profession_Economic()
        {
            _list_Profession = new List<Basic_Work>
            {
                new Basic_Work(Lang.HRManager, 100, 0, 0, 0),
                new Basic_Work(Lang.Auditor, 100, 0, 0, 0),
                new Basic_Work(Lang.BrandManager, 100, 0, 0, 0),
                new Basic_Work(Lang.Broker, 100, 0, 0, 0),
                new Basic_Work(Lang.Accountant, 100, 0, 0, 0),
                new Basic_Work(Lang.Collector, 100, 0, 0, 0),
                new Basic_Work(Lang.CrisisManager, 100, 0, 0, 0),
                new Basic_Work(Lang.Lobbyist, 100, 0, 0, 0),
                new Basic_Work(Lang.Marketer, 100, 0, 0, 0),
                new Basic_Work(Lang.Manager, 100, 0, 0, 0),
                new Basic_Work(Lang.Merchandiser, 100, 0, 0, 0),
                new Basic_Work(Lang.TaxInspector, 100, 0, 0, 0),
                new Basic_Work(Lang.Statistician, 100, 0, 0, 0),
                new Basic_Work(Lang.Supervisor, 100, 0, 0, 0),
                new Basic_Work(Lang.MerchandiseSpecialist, 100, 0, 0, 0),
                new Basic_Work(Lang.Economist, 100, 0, 0, 0),
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