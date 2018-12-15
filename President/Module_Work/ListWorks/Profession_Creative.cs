using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_Creative : IProfession
    {
        /// <summary>
        /// Стаж работы в данной
        /// </summary>
        private int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        private string _professionName = "Творческие";

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        public List<Basic_Work> _list_Profession;

        public Profession_Creative()
        {
            _list_Profession = new List<Basic_Work>
            {
                new Basic_Work("Актер", 300, 8, 0, 60, 0),
                new Basic_Work("Аниматор", 150, 9, 0, 10, 0),
                new Basic_Work("Архитектор", 600, 8, 75, 25, 0),
                new Basic_Work("Бренд-дизайнер", 520, 9, 55, 0 ,0),
                new Basic_Work("Диджей", 100, 4, 0, 5, 0),
                new Basic_Work("Дизайнер-модельер", 190, 8, 0, 15, 0),
                new Basic_Work("Дирижер", 140, 7, 0, 10, 0),
                new Basic_Work("Звукорежиссер", 170, 7, 5, 10, 0),
                new Basic_Work("Иллюстратор", 300, 8, 25, 0, 0),
                new Basic_Work("Каскадер", 600, 9, 0, 0, 55),
                new Basic_Work("Киномеханик", 130, 8, 0, 0, 0),
                new Basic_Work("Кинооператор", 510, 9, 40, 20, 0),
                new Basic_Work("Критик", 100, 6, 0, 0, 0),
                new Basic_Work("Дизайнер", 120, 8, 10, 10 , 0),
                new Basic_Work("Мультипликатор", 150, 7, 0, 10, 0),
                new Basic_Work("Переводчик", 450, 8, 60, 25, 0),
                new Basic_Work("Писатель", 130, 6, 10, 10, 0),
                new Basic_Work("Режиссер", 180, 8, 15, 15, 0),
                new Basic_Work("Реставратор", 300, 8, 40, 30, 0),
                new Basic_Work("Стилист", 350, 8, 0, 60, 0),
                new Basic_Work("Сценарист", 250, 9, 35, 25, 0),
                new Basic_Work("Татуировщик", 150, 7, 0, 0, 0),
                new Basic_Work("Фотограф", 90, 6, 0, 0, 0),
                new Basic_Work("Фотомодель", 120, 7, 0, 15, 0),
                new Basic_Work("Ювелир", 340, 9, 15, 35, 10),
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