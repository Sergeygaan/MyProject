using Module_Work.Language;
using System.Collections.Generic;

namespace Module_Work
{
    class Profession_Technical : IProfession
    {
        /// <summary>
        /// Стаж работы в данной
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        private string _professionName = Lang.Technical;

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        private List<Basic_Work> _list_Profession;

        public Profession_Technical()
        {
            _list_Profession = new List<Basic_Work>
            {
                new Basic_Work(Lang.Mechanic, 400, 0, 0, 55),
                new Basic_Work(Lang.Diver, 400, 0, 0, 60),
                new Basic_Work(Lang.Surveyor, 300, 0, 0, 50),
                new Basic_Work(Lang.SoundEngineer, 380, 0, 50, 0),
                new Basic_Work(Lang.Mason, 200, 0, 0, 25),
                new Basic_Work(Lang.Cartographer, 250, 20, 0, 0),
                new Basic_Work(Lang.CraneOperator, 300, 0, 0, 30),
                new Basic_Work(Lang.Cabinetmaker, 270, 0, 0, 25),
                new Basic_Work(Lang.Roofer, 250, 0, 0, 20),
                new Basic_Work(Lang.Caster, 470, 0, 0, 60),
                new Basic_Work(Lang.Painter, 160, 0, 0, 0),
                new Basic_Work(Lang.MineSurveyor, 600, 55, 0, 45),
                new Basic_Work(Lang.Metallurgist, 400, 0, 0, 55),
                new Basic_Work(Lang.Facing, 250, 0, 0, 25),
                new Basic_Work(Lang.Finisher, 260, 0, 0, 20),
                new Basic_Work(Lang.Carpenter, 270, 0, 0, 30),
                new Basic_Work(Lang.Foreman, 500, 45, 0, 60),
                new Basic_Work(Lang.Locksmith, 220, 0, 0, 45),
                new Basic_Work(Lang.Builder, 245, 0, 0, 35),
                new Basic_Work(Lang.Technologist, 430, 45, 0, 25),
                new Basic_Work(Lang.Watchmaker, 350, 50, 0, 20),
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
