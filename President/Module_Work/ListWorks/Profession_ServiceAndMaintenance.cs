using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_ServiceAndMaintenance
    {
        /// <summary>
        /// Стаж работы в данной
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        public string ProfessionMilitary = "Сервис и обслуживание";

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        public List<Basic_Work> List_Profession;

        public Profession_ServiceAndMaintenance()
        {
            List_Profession = new List<Basic_Work>
            {
                new Basic_Work("Агент по туризму", 1, 1, 8),
                new Basic_Work("Администратор ресторана", 1, 1, 8),
                new Basic_Work("Бармен", 1, 1, 8),
                new Basic_Work("Библиотекарь", 1, 1, 8),
                new Basic_Work("Визажист", 1, 1, 8),
                new Basic_Work("Гид-переводчик", 1, 1, 8),
                new Basic_Work("Грузчик", 1, 1, 8),
                new Basic_Work("Дворник", 1, 1, 8),
                new Basic_Work("Кладовщик", 1, 1, 8),
                new Basic_Work("Мастер маникюра", 1, 1, 8),
                new Basic_Work("Мусорщик", 1, 1, 8),
                new Basic_Work("Оператор call-центра", 1, 1, 8),
                new Basic_Work("Официант", 1, 1, 8),
                new Basic_Work("Парикмахер", 1, 1, 8),
                new Basic_Work("Портье", 1, 1, 8),
                new Basic_Work("Почтальон", 1, 1, 8),
                new Basic_Work("Риелтор", 1, 1, 8),
                new Basic_Work("Страховой агент", 1, 1, 8),
                new Basic_Work("Флорист", 1, 1, 8),
                new Basic_Work("Экскурсовод", 1, 1, 8),
                new Basic_Work("Риелтор", 1, 1, 8),
                new Basic_Work("Страховой агент", 1, 1, 8),
            };
        }
    }
}
