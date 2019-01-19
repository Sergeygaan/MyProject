using Module_Work.Language;
using System;
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
        private string _professionName = Lang.Agriculture;

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        private List<Basic_Work> _list_Profession;

        public Profession_Agriculture()
        {
            _list_Profession = new List<Basic_Work>
            {
                new Basic_Work(Lang.Agronomist, 300, 20, 0, 25),
                new Basic_Work(Lang.Veterinarian, 330, 35, 0, 0),
                new Basic_Work(Lang.Breeder, 150, 0, 0, 0),
                new Basic_Work(Lang.Hunter, 400, 0, 0, 75),
                new Basic_Work(Lang.Gardener, 160, 0, 0, 5),
                new Basic_Work(Lang.TractorDriver, 200, 0, 0, 23),
                new Basic_Work(Lang.Farmer, 210, 0, 0, 38),
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