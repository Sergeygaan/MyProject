using Module_Work.Language;
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
        private string _professionName = Lang.Creative;

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        public List<Basic_Work> _list_Profession;

        public Profession_Creative()
        {
            _list_Profession = new List<Basic_Work>
            {
                new Basic_Work("Актер", 300, 0, 60, 0),
                new Basic_Work("Аниматор", 150, 0, 10, 0),
                new Basic_Work("Архитектор", 600, 75, 25, 0),
                new Basic_Work("Бренд-дизайнер", 520,  55, 0 ,0),
                new Basic_Work("Диджей", 100, 0, 5, 0),
                new Basic_Work("Дизайнер-модельер", 190, 0, 15, 0),
                new Basic_Work("Дирижер", 140, 0, 10, 0),
                new Basic_Work("Звукорежиссер", 170, 5, 10, 0),
                new Basic_Work("Иллюстратор", 300, 25, 0, 0),
                new Basic_Work("Каскадер", 600, 0, 10, 55),
                new Basic_Work("Киномеханик", 130, 0, 0, 0),
                new Basic_Work("Кинооператор", 510, 40, 20, 0),
                new Basic_Work("Критик", 100, 0, 0, 0),
                new Basic_Work("Дизайнер", 120, 10, 10 , 0),
                new Basic_Work("Мультипликатор", 150, 0, 10, 0),
                new Basic_Work("Переводчик", 450, 60, 25, 0),
                new Basic_Work("Писатель", 130, 10, 10, 0),
                new Basic_Work("Режиссер", 180, 15, 15, 0),
                new Basic_Work("Реставратор", 300, 40, 30, 0),
                new Basic_Work("Стилист", 350, 0, 60, 0),
                new Basic_Work("Сценарист", 250, 35, 25, 0),
                new Basic_Work("Татуировщик", 150, 0, 0, 0),
                new Basic_Work("Фотограф", 90, 0, 0, 0),
                new Basic_Work("Фотомодель", 120, 0, 15, 0),
                new Basic_Work("Ювелир", 340, 15, 35, 10),
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