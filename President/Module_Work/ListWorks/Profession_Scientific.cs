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
                new Basic_Work(Lang.Archaeologist, 350, 10, 10, 25),
                new Basic_Work(Lang.Archivist, 290, 25, 0, 0),
                new Basic_Work(Lang.Astronomer, 266, 15, 0, 0),
                new Basic_Work(Lang.Bibliographer, 135, 5, 0, 0),
                new Basic_Work(Lang.Bioengineer, 500, 60, 0, 0),
                new Basic_Work(Lang.Biologist, 220, 35, 0, 0),
                new Basic_Work(Lang.Biochemist, 380, 45, 0, 0),
                new Basic_Work(Lang.Orientalist, 230, 10, 15, 0),
                new Basic_Work(Lang.Geologist, 200, 10, 0, 10),
                new Basic_Work(Lang.Egyptologist, 250, 10, 0, 0),
                new Basic_Work(Lang.ArtCritic, 330, 20, 0, 0),
                new Basic_Work(Lang.Historian, 280, 15, 5, 0),
                new Basic_Work(Lang.Ichthyologist, 250, 24, 0, 0),
                new Basic_Work(Lang.Constructor, 560, 60, 0, 0),
                new Basic_Work(Lang.CulturalScientist, 315, 45, 0, 0),
                new Basic_Work(Lang.Mathematician, 250, 15, 0, 0),
                new Basic_Work(Lang.Meteorologist, 160, 5, 0, 0),
                new Basic_Work(Lang.Ornithologist, 240, 15, 0, 0),
                new Basic_Work(Lang.Linguist, 400, 35, 25, 0),
                new Basic_Work(Lang.Paleontologist, 220, 15, 0, 0),
                new Basic_Work(Lang.PoliticalScientist, 450, 55, 45, 0),
                new Basic_Work(Lang.SoilScientist, 150, 5, 0, 5),
                new Basic_Work(Lang.Religious, 200, 0, 0, 0),
                new Basic_Work(Lang.Sociologist, 520, 45, 10, 0),
                new Basic_Work(Lang.Philosopher, 250, 45, 0, 0),
                new Basic_Work(Lang.Ecologist, 270, 25, 0, 0),
                new Basic_Work(Lang.Ethnographer, 230, 5, 5, 0),
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
