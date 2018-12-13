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
                new Basic_Work("HTML-верстальщик", 100, 50, 8),
                new Basic_Work("Web-интегратор", 100, 50, 8),
                new Basic_Work("Администратор базы данных", 100, 50, 8),
                new Basic_Work("Администратор сайта", 100, 50, 8),
                new Basic_Work("Блогер", 100, 50, 8),
                new Basic_Work("Веб-дизайнер", 100, 50, 8),
                new Basic_Work("Диктор", 100, 50, 8),
                new Basic_Work("Контент-менеджер", 100, 50, 8),
                new Basic_Work("Копирайтер", 100, 50, 8),
                new Basic_Work("Радиоведущий", 100, 50, 8),
                new Basic_Work("Системный администратор", 100, 50, 8),
                new Basic_Work("Спичрайтер", 100, 50, 8),
                new Basic_Work("Тележурналист", 100, 50, 8),
                new Basic_Work("Тестировщик", 100, 1, 8)
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
