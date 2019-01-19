using Module_Work.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_Food : IProfession
    {
        /// <summary>
        /// Стаж работы в данной
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        private string _professionName = Lang.Food;

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        private List<Basic_Work> _list_Profession;

        public Profession_Food()
        {
            _list_Profession = new List<Basic_Work>
            {
                new Basic_Work(Lang.Winemaker, 400, 15, 0, 35),
                new Basic_Work(Lang.Taster, 720, 60, 35, 0),
                new Basic_Work(Lang.Messenger, 220, 0, 0, 10),
                new Basic_Work(Lang.Butcher, 350, 5, 0, 15),
                new Basic_Work(Lang.Baker, 250, 5, 10, 5),
                new Basic_Work(Lang.Cook, 240, 15, 0, 0),
                new Basic_Work(Lang.PastryChef, 270, 15, 10, 0),
                new Basic_Work(Lang.Chef, 650, 50, 60, 10)
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
