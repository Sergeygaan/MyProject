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
                new Basic_Work("Актер", 100, 50, 8),
                new Basic_Work("Аниматор", 100, 50, 8),
                new Basic_Work("Архитектор", 100, 50, 8),
                new Basic_Work("Бренд-дизайнер", 100, 50, 8),
                new Basic_Work("Диджей", 100, 50, 8),
                new Basic_Work("Дизайнер-модельер", 100, 50, 8),
                new Basic_Work("Дирижер", 100, 50, 8),
                new Basic_Work("Звукорежиссер", 100, 50, 8),
                new Basic_Work("Иллюстратор", 100, 50, 8),
                new Basic_Work("Каскадер", 100, 50, 8),
                new Basic_Work("Киномеханик", 100, 50, 8),
                new Basic_Work("Кинооператор", 100, 50, 8),
                new Basic_Work("Критик", 100, 50, 8),
                new Basic_Work("Ландшафтный дизайнер", 100, 50, 8),
                new Basic_Work("Мультипликатор", 100, 50, 8),
                new Basic_Work("Переводчик", 100, 50, 8),
                new Basic_Work("Писатель", 100, 50, 8),
                new Basic_Work("Режиссер", 100, 50, 8),
                new Basic_Work("Реставратор", 100, 50, 8),
                new Basic_Work("Стилист", 100, 50, 8),
                new Basic_Work("Сценарист", 100, 50, 8),
                new Basic_Work("Татуировщик", 100, 50, 8),
                new Basic_Work("Технический писатель", 100, 50, 8),
                new Basic_Work("Фотограф", 100, 50, 8),
                new Basic_Work("Фотомодель", 100, 50, 8),
                new Basic_Work("Ювелир", 100, 50, 8),

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