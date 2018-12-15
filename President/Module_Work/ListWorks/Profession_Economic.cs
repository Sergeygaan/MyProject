using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_Economic : IProfession
    {
        /// <summary>
        /// Стаж работы в данной
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        private string _professionName = "Экономические";

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        private List<Basic_Work> _list_Profession;

        public Profession_Economic()
        {
            _list_Profession = new List<Basic_Work>
            {
                new Basic_Work("PR-менеджер", 100, 8, 0, 0, 0),
                new Basic_Work("Аудитор", 100, 8, 0, 0, 0),
                new Basic_Work("Бренд-менеджер", 100, 8, 0, 0, 0),
                new Basic_Work("Брокер", 100, 8, 0, 0, 0),
                new Basic_Work("Бухгалтер", 100, 8, 0, 0, 0),
                new Basic_Work("Инкассатор", 100, 8, 0, 0, 0),
                new Basic_Work("Кризис-менеджер", 100, 8, 0, 0, 0),
                new Basic_Work("Лоббист", 100, 8, 0, 0, 0),
                new Basic_Work("Маркетолог", 100, 8, 0, 0, 0),
                new Basic_Work("Менеджер", 100, 8, 0, 0, 0),
                new Basic_Work("Мерчендайзер", 100, 8, 0, 0, 0),
                new Basic_Work("Налоговый инспектор", 100, 8, 0, 0, 0),
                new Basic_Work("Статистик", 100, 8, 0, 0, 0),
                new Basic_Work("Супервайзер", 100, 8, 0, 0, 0),
                new Basic_Work("Товаровед", 100, 8, 0, 0, 0),
                new Basic_Work("Экономист", 100, 8, 0, 0, 0),
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