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
                new Basic_Work("Актер", 1, 1, 8),
                new Basic_Work("Аниматор", 1, 1, 8),
                new Basic_Work("Архитектор", 1, 1, 8),
                new Basic_Work("Бренд-дизайнер", 1, 1, 8),
                new Basic_Work("Диджей", 1, 1, 8),
                new Basic_Work("Дизайнер-модельер", 1, 1, 8),
                new Basic_Work("Дирижер", 1, 1, 8),
                new Basic_Work("Звукорежиссер", 1, 1, 8),
                new Basic_Work("Иллюстратор", 1, 1, 8),
                new Basic_Work("Каскадер", 1, 1, 8),
                new Basic_Work("Киномеханик", 1, 1, 8),
                new Basic_Work("Кинооператор", 1, 1, 8),
                new Basic_Work("Критик", 1, 1, 8),
                new Basic_Work("Ландшафтный дизайнер", 1, 1, 8),
                new Basic_Work("Мультипликатор", 1, 1, 8),
                new Basic_Work("Переводчик", 1, 1, 8),
                new Basic_Work("Писатель", 1, 1, 8),
                new Basic_Work("Режиссер", 1, 1, 8),
                new Basic_Work("Реставратор", 1, 1, 8),
                new Basic_Work("Стилист", 1, 1, 8),
                new Basic_Work("Сценарист", 1, 1, 8),
                new Basic_Work("Татуировщик", 1, 1, 8),
                new Basic_Work("Технический писатель", 1, 1, 8),
                new Basic_Work("Фотограф", 1, 1, 8),
                new Basic_Work("Фотомодель", 1, 1, 8),
                new Basic_Work("Ювелир", 1, 1, 8),

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