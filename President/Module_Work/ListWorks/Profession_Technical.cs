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
                new Basic_Work(Lang.Mechanic, 100, 0, 0, 0),
                new Basic_Work(Lang.Diver, 100, 0, 0, 0),
                new Basic_Work(Lang.Surveyor, 100, 0, 0, 0),
                new Basic_Work(Lang.SoundEngineer, 100, 0, 0, 0),
                new Basic_Work(Lang.Mason, 100, 0, 0, 0),
                new Basic_Work(Lang.Cartographer, 100, 0, 0, 0),
                new Basic_Work(Lang.CraneOperator, 100, 0, 0, 0),
                new Basic_Work(Lang.Cabinetmaker, 100, 0, 0, 0),
                new Basic_Work(Lang.Roofer, 100, 0, 0, 0),
                new Basic_Work(Lang.Caster, 100, 0, 0, 0),
                new Basic_Work(Lang.Painter, 100, 0, 0, 0),
                new Basic_Work(Lang.MineSurveyor, 100, 0, 0, 0),
                new Basic_Work(Lang.Metallurgist, 100, 0, 0, 0),
                new Basic_Work(Lang.Facing, 100, 0, 0, 0),
                new Basic_Work(Lang.Finisher, 100, 0, 0, 0),
                new Basic_Work(Lang.Carpenter, 100, 0, 0, 0),
                new Basic_Work(Lang.Foreman, 100, 0, 0, 0),
                new Basic_Work(Lang.Locksmith, 100, 0, 0, 0),
                new Basic_Work(Lang.Builder, 100, 0, 0, 0),
                new Basic_Work(Lang.Technologist, 100, 0, 0, 0),
                new Basic_Work(Lang.Watchmaker, 100, 0, 0, 0),
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
