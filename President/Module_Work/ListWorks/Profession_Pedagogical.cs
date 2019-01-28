using Module_Work.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_Pedagogical : IProfession
    {
        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в области
        /// </summary>
        public string _professionName = Lang.Pedagogical;

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        public List<Basic_Work> _list_Profession;

        public Profession_Pedagogical()
        {
            _list_Profession = new List<Basic_Work>
            {
                new Basic_Work(Lang.Educator, 180, 5, 5, 0),
                new Basic_Work(Lang.Defectologist, 225, 15, 0, 0),
                new Basic_Work(Lang.Cynologist, 400, 25, 0, 0),
                new Basic_Work(Lang.Teacher, 270, 35, 0, 0),
                new Basic_Work(Lang.Rector, 700, 75, 10, 0),
                new Basic_Work(Lang.Dean, 500, 55, 0, 0),
                new Basic_Work(Lang.TeacherDeaf, 375, 35, 0, 0),
                new Basic_Work(Lang.Choreographer,300, 15, 45, 0),
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
