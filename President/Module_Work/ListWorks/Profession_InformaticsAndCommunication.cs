using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_InformaticsAndCommunication : IProfession
    {
        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        private string _professionName = "Информатика и связь";

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        private List<Basic_Work> _list_Profession;

        public Profession_InformaticsAndCommunication()
        {
            _list_Profession = new List<Basic_Work>
            {
                new Basic_Work("HTML-верстальщик", 1, 1, 8),
                new Basic_Work("Web-интегратор", 1, 1, 8),
                new Basic_Work("Администратор базы данных", 1, 1, 8),
                new Basic_Work("Администратор сайта", 1, 1, 8),
                new Basic_Work("Блогер", 1, 1, 8),
                new Basic_Work("Веб-дизайнер", 1, 1, 8),
                new Basic_Work("Диктор", 1, 1, 8),
                new Basic_Work("Контент-менеджер", 1, 1, 8),
                new Basic_Work("Копирайтер", 1, 1, 8),
                new Basic_Work("Радиоведущий", 1, 1, 8),
                new Basic_Work("Системный администратор", 1, 1, 8),
                new Basic_Work("Спичрайтер", 1, 1, 8),
                new Basic_Work("Тележурналист", 1, 1, 8),
                new Basic_Work("Тестировщик", 1, 1, 8)
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
