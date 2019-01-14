using Module_Work.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_Scientific : IProfession
    {
        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        private string _professionName = Lang.Scientific;

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        private List<Basic_Work> _list_Profession;

        public Profession_Scientific()
        {
            _list_Profession = new List<Basic_Work>
            {
                new Basic_Work(Lang.Archaeologist, 100, 0, 0, 0),
                new Basic_Work(Lang.Archivist, 100, 0, 0, 0),
                new Basic_Work(Lang.Astronomer, 100, 0, 0, 0),
                new Basic_Work(Lang.Bibliographer, 100, 0, 0, 0),
                new Basic_Work(Lang.Bioengineer, 100, 0, 0, 0),
                new Basic_Work(Lang.Biologist, 100, 0, 0, 0),
                new Basic_Work(Lang.Biochemist, 100, 0, 0, 0),
                new Basic_Work(Lang.Orientalist, 100, 0, 0, 0),
                new Basic_Work(Lang.Geologist, 100, 0, 0, 0),
                new Basic_Work(Lang.Egyptologist, 100, 0, 0, 0),
                new Basic_Work(Lang.ArtCritic, 100, 0, 0, 0),
                new Basic_Work(Lang.Historian, 100, 0, 0, 0),
                new Basic_Work(Lang.Ichthyologist, 100, 0, 0, 0),
                new Basic_Work(Lang.Constructor, 100, 0, 0, 0),
                new Basic_Work(Lang.CulturalScientist, 100, 0, 0, 0),
                new Basic_Work(Lang.Mathematician, 100, 0, 0, 0),
                new Basic_Work(Lang.Meteorologist, 100, 0, 0, 0),
                new Basic_Work(Lang.Ornithologist, 100, 0, 0, 0),
                new Basic_Work(Lang.Linguist, 100, 0, 0, 0),
                new Basic_Work(Lang.Paleontologist, 100, 0, 0, 0),
                new Basic_Work(Lang.PoliticalScientist, 100, 0, 0, 0),
                new Basic_Work(Lang.SoilScientist, 100, 0, 0, 0),
                new Basic_Work(Lang.Religious, 100, 0, 0, 0),
                new Basic_Work(Lang.Sociologist, 100, 0, 0, 0),
                new Basic_Work(Lang.Philosopher, 100, 0, 0, 0),
                new Basic_Work(Lang.Ecologist, 100, 0, 0, 0),
                new Basic_Work(Lang.Ethnographer, 100, 0, 0, 0),
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
