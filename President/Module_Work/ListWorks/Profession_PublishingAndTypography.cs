using Module_Work.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_PublishingAndTypography : IProfession
    {
        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        private string _professionName = Lang.Typography;

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        private List<Basic_Work> _list_Profession;

        public Profession_PublishingAndTypography()
        {
            _list_Profession = new List<Basic_Work>
            {
                new Basic_Work(Lang.Coder, 380, 40, 0, 0),
                new Basic_Work(Lang.ChiefEditor, 650, 55, 25, 0),
                new Basic_Work(Lang.Publisher, 900, 55, 45, 0),
                new Basic_Work(Lang.Corrector, 285, 15, 15, 0),
                new Basic_Work(Lang.Bookbinder, 150, 0, 0, 0),
                new Basic_Work(Lang.Printer, 180, 0, 0, 0),
                new Basic_Work(Lang.Editor, 450, 40, 35, 0),
                new Basic_Work(Lang.Folder, 400, 55, 0, 0)
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
