using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_Military : IProfession
    {
        /// <summary>
        /// Стаж работы в данной области
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        private string _professionName = "Военные";

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        private List<Basic_Work> _list_Profession;

        public Profession_Military()
        {
            _list_Profession = new List<Basic_Work>
            {
                new Basic_Work("Военнослужащий", 1, 1, 8),
                new Basic_Work("Конвоир", 1, 1, 8),
                new Basic_Work("Пожарный", 1, 1, 8),
                new Basic_Work("Разведчик", 1, 1, 8),
                new Basic_Work("Спасатель", 1, 1, 8),
                new Basic_Work("Телохранитель", 1, 1, 8),
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
