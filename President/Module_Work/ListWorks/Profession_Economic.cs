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
                new Basic_Work(Lang.HRManager, 310, 25, 55, 0),
                new Basic_Work(Lang.Auditor, 580, 60, 40, 10),
                new Basic_Work(Lang.BrandManager, 500, 50, 60, 0),
                new Basic_Work(Lang.Broker, 390, 60, 0, 0),
                new Basic_Work(Lang.Accountant, 300, 30, 0, 0),
                new Basic_Work(Lang.Collector, 150, 0, 0, 5),
                new Basic_Work(Lang.CrisisManager, 810, 70, 40, 0),
                new Basic_Work(Lang.Lobbyist, 400, 15, 45, 5),
                new Basic_Work(Lang.Marketer, 610, 65, 0, 0),
                new Basic_Work(Lang.Manager, 215, 5, 20, 0),
                new Basic_Work(Lang.Merchandiser, 250, 0, 0, 5),
                new Basic_Work(Lang.TaxInspector, 180, 3, 5, 5),
                new Basic_Work(Lang.Statistician, 170, 0, 0, 0),
                new Basic_Work(Lang.Supervisor, 290, 25, 0, 0),
                new Basic_Work(Lang.MerchandiseSpecialist, 330, 35, 0, 0),
                new Basic_Work(Lang.Economist, 530, 55, 15, 0),
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