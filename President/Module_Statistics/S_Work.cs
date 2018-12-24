using System.Collections.Generic;

namespace Module_Statistics
{
    public static class S_Work
    {
        /// <summary>
        /// Список всех свойств статистики
        /// </summary>
        private static List<Main_Statistics> _listStatistic_Work = new List<Main_Statistics>();

        static S_Work()
        {
            _listStatistic_Work.Add(new Main_Statistics("Количество устройст на работу", 0)); //0
            _listStatistic_Work.Add(new Main_Statistics("Количество увольнений с работы", 0)); //1

            //Зарплата
            _listStatistic_Work.Add(new Main_Statistics("Всего заработано денег", 0)); //2
            _listStatistic_Work.Add(new Main_Statistics("Количество полученных зарплат", 0)); //3
            _listStatistic_Work.Add(new Main_Statistics("Количество полученных премий", 0)); //4

            _listStatistic_Work.Add(new Main_Statistics("Количество выполненых планой", 0)); //5
            _listStatistic_Work.Add(new Main_Statistics("Количество не выполненых планой", 0)); //6

            //Поиск работы
            _listStatistic_Work.Add(new Main_Statistics("Поиск работы на улице", 0)); //7
            _listStatistic_Work.Add(new Main_Statistics("Поиск работы в газете", 0)); //8
            _listStatistic_Work.Add(new Main_Statistics("Поиск работы в интернете", 0)); //9
        }

        public static void AddValue(int index, int value)
        {
            _listStatistic_Work[index].Value += value;
        }

        /// <summary>
        /// Метод возвращающий список свойств статистики
        /// </summary>
        /// <returns></returns>
        public static List<Main_Statistics> ReturnList()
        {
            return _listStatistic_Work;
        }
    }
}
