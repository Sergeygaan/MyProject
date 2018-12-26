﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_ServiceAndMaintenance : IProfession
    {
        /// <summary>
        /// Стаж работы в данной
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        private string _professionName = "Сервис";

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        private List<Basic_Work> _list_Profession;

        public Profession_ServiceAndMaintenance()
        {
            _list_Profession = new List<Basic_Work>
            {
                new Basic_Work("Агент по туризму", 100, 0, 0, 0),
                new Basic_Work("Администратор", 100, 0, 0, 0),
                new Basic_Work("Бармен", 100, 0, 0, 0),
                new Basic_Work("Библиотекарь", 100, 0, 0, 0),
                new Basic_Work("Визажист", 100, 0, 0, 0),
                new Basic_Work("Гид-переводчик", 100, 0, 0, 0),
                new Basic_Work("Грузчик", 100, 0, 0, 0),
                new Basic_Work("Дворник", 100, 0, 0, 0),
                new Basic_Work("Кладовщик", 100, 0, 0, 0),
                new Basic_Work("Мастер маникюра", 100, 0, 0, 0),
                new Basic_Work("Мусорщик", 100, 0, 0, 0),
                new Basic_Work("Оператор", 100, 0, 0, 0),
                new Basic_Work("Официант", 100, 0, 0, 0),
                new Basic_Work("Парикмахер", 100, 0, 0, 0),
                new Basic_Work("Портье", 100, 0, 0, 0),
                new Basic_Work("Почтальон", 100, 0, 0, 0),
                new Basic_Work("Риелтор", 100, 0, 0, 0),
                new Basic_Work("Страховой агент", 100, 0, 0, 0),
                new Basic_Work("Флорист", 100, 0, 0, 0),
                new Basic_Work("Экскурсовод", 100, 0, 0, 0),
                new Basic_Work("Риелтор", 100, 0, 0, 0)
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
