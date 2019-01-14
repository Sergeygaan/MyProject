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
                new Basic_Work(Lang.Coder, 100, 0, 0, 0),
                new Basic_Work(Lang.ChiefEditor, 100, 0, 0, 0),
                new Basic_Work(Lang.Publisher, 100, 0, 0, 0),
                new Basic_Work(Lang.Corrector, 100, 0, 0, 0),
                new Basic_Work(Lang.Bookbinder, 100, 0, 0, 0),
                new Basic_Work(Lang.Printer, 100, 0, 0, 0),
                new Basic_Work(Lang.Editor, 100, 0, 0, 0),
                new Basic_Work(Lang.Folder, 100, 0, 0, 0),
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
