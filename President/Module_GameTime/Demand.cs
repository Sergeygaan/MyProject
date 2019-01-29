using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Module_GameTime
{
    public class DemandProfessionsClass
    {
        /// <summary>
        /// Название профессии
        /// </summary>
        public string IndustryName;

        /// <summary>
        /// Процент востребованности
        /// </summary>
        public int PercentageDemand;

        public DemandProfessionsClass(string industryName, int percentageDemand)
        {
            IndustryName = industryName;
            PercentageDemand = percentageDemand;
        }

        /// <summary>
        /// Добавить значение востребованности к нужному полю
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        public void Add(int value)
        {
            PercentageDemand += value;

            if (PercentageDemand > 100)
            {
                PercentageDemand = 100;
            }
            else if (PercentageDemand < -100)
            {
                PercentageDemand = -100;
            }
        }

        /// <summary>
        /// Добавить значение востребованности к нужному полю
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        public void Set(int value)
        {
            PercentageDemand = value;
        }
    }

    public static class Demand
    {
        /// <summary>
        /// Параметр рандома
        /// </summary>
        private static Random random = new Random();

        /// <summary>
        /// Список хранящий в себе список всех профессий и их востребованность
        /// </summary>
        private static List<DemandProfessionsClass> _demandProfessions;

        /// <summary>
        /// Список хранящий в себе список востребованности малого бизнеса
        /// </summary>
        private static List<DemandProfessionsClass> _smallBusiness;

        /// <summary>
        /// Список хранящий в себе список востребованности среднего бизнеса
        /// </summary>
        private static List<DemandProfessionsClass> _mediumBusiness;

        /// <summary>
        /// Список хранящий в себе список востребованности среднего бизнеса
        /// </summary>
        private static List<DemandProfessionsClass> _bigBusiness;

        static Demand()
        {
            //Подписка на события "Новый день" для начисления зарплаты
            Game_Time.PropertyChangedNewDay += new PropertyChangedEventHandler(GetValue_Everyday);

            //Работа
            _demandProfessions = new List<DemandProfessionsClass>
            {
                new DemandProfessionsClass("Сельское хозяйство", random.Next(-10, 11)),
                new DemandProfessionsClass("Творческие", random.Next(-10, 11)),
                new DemandProfessionsClass("Экономические", random.Next(-10, 11)),
                new DemandProfessionsClass("Пищевые", random.Next(-10, 11)),
                new DemandProfessionsClass("Информационные", random.Next(-10, 11)),
                new DemandProfessionsClass("Юридические", random.Next(-10, 11)),
                new DemandProfessionsClass("Медицинские", random.Next(-10, 11)),
                new DemandProfessionsClass("Военные", random.Next(-10, 11)),
                new DemandProfessionsClass("Педагогические", random.Next(-10, 11)),
                new DemandProfessionsClass("Типография", random.Next(-10, 11)),
                new DemandProfessionsClass("Научные", random.Next(-10, 11)),
                new DemandProfessionsClass("Сервисные", random.Next(-10, 11)),
                new DemandProfessionsClass("Спортивные", random.Next(-10, 11)),
                new DemandProfessionsClass("Технические", random.Next(-10, 11)),
                new DemandProfessionsClass("Транспортные", random.Next(-10, 11))
            };

            //Малый бизнес
            _smallBusiness = new List<DemandProfessionsClass>
            {
                new DemandProfessionsClass("Сельское хозяйство", random.Next(-10, 11)),
                new DemandProfessionsClass("Творческие", random.Next(-10, 11)),
                new DemandProfessionsClass("Экономические", random.Next(-10, 11)),
                new DemandProfessionsClass("Пищевые", random.Next(-10, 11)),
                new DemandProfessionsClass("Информационные", random.Next(-10, 11)),
                new DemandProfessionsClass("Юридические", random.Next(-10, 11)),
                new DemandProfessionsClass("Медицинские", random.Next(-10, 11)),
                new DemandProfessionsClass("Военные", random.Next(-10, 11)),
                new DemandProfessionsClass("Педагогические", random.Next(-10, 11)),
                new DemandProfessionsClass("Типография", random.Next(-10, 11)),
                new DemandProfessionsClass("Научные", random.Next(-10, 11)),
                new DemandProfessionsClass("Сервисные", random.Next(-10, 11)),
                new DemandProfessionsClass("Спортивные", random.Next(-10, 11)),
                new DemandProfessionsClass("Технические", random.Next(-10, 11)),
                new DemandProfessionsClass("Транспортные", random.Next(-10, 11))
            };

            //Средний бизнес
            _mediumBusiness = new List<DemandProfessionsClass>
            {
                new DemandProfessionsClass("Сельское хозяйство", random.Next(-10, 11)),
                new DemandProfessionsClass("Творческие", random.Next(-10, 11)),
                new DemandProfessionsClass("Экономические", random.Next(-10, 11)),
                new DemandProfessionsClass("Пищевые", random.Next(-10, 11)),
                new DemandProfessionsClass("Информационные", random.Next(-10, 11)),
                new DemandProfessionsClass("Юридические", random.Next(-10, 11)),
                new DemandProfessionsClass("Медицинские", random.Next(-10, 11)),
                new DemandProfessionsClass("Военные", random.Next(-10, 11)),
                new DemandProfessionsClass("Педагогические", random.Next(-10, 11)),
                new DemandProfessionsClass("Типография", random.Next(-10, 11)),
                new DemandProfessionsClass("Научные", random.Next(-10, 11)),
                new DemandProfessionsClass("Сервисные", random.Next(-10, 11)),
                new DemandProfessionsClass("Спортивные", random.Next(-10, 11)),
                new DemandProfessionsClass("Технические", random.Next(-10, 11)),
                new DemandProfessionsClass("Транспортные", random.Next(-10, 11))
            };

            //Крупный бизнес
            _bigBusiness = new List<DemandProfessionsClass>
            {
                new DemandProfessionsClass("Сельское хозяйство", random.Next(-10, 11)),
                new DemandProfessionsClass("Творческие", random.Next(-10, 11)),
                new DemandProfessionsClass("Экономические", random.Next(-10, 11)),
                new DemandProfessionsClass("Пищевые", random.Next(-10, 11)),
                new DemandProfessionsClass("Информационные", random.Next(-10, 11)),
                new DemandProfessionsClass("Юридические", random.Next(-10, 11)),
                new DemandProfessionsClass("Медицинские", random.Next(-10, 11)),
                new DemandProfessionsClass("Военные", random.Next(-10, 11)),
                new DemandProfessionsClass("Педагогические", random.Next(-10, 11)),
                new DemandProfessionsClass("Типография", random.Next(-10, 11)),
                new DemandProfessionsClass("Научные", random.Next(-10, 11)),
                new DemandProfessionsClass("Сервисные", random.Next(-10, 11)),
                new DemandProfessionsClass("Спортивные", random.Next(-10, 11)),
                new DemandProfessionsClass("Технические", random.Next(-10, 11)),
                new DemandProfessionsClass("Транспортные", random.Next(-10, 11))
            };
        }

        #region Востребованность профессий

        /// <summary>
        /// Счетчик определяющий через сколько измениться рынок. Обнуление рынка
        /// </summary>
        private static int _counter = random.Next(10, 20);

        /// <summary>
        /// Новый день
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="even"></param>
        private static void GetValue_Everyday(object sender, PropertyChangedEventArgs even)
        {
            _counter -= 1;

            if (_counter > 0)
            {
                //работа
                foreach (var currentProfessions in _demandProfessions)
                {
                    currentProfessions.Add(random.Next(-15, 16));
                }

                //малый бизнес
                foreach (var currentSmall in _smallBusiness)
                {
                    currentSmall.Add(random.Next(-15, 16));
                }

                //средний бизнес
                foreach (var currentMedium in _mediumBusiness)
                {
                    currentMedium.Add(random.Next(-15, 16));
                }

                //крупный бизнес
                foreach (var currentBig in _bigBusiness)
                {
                    currentBig.Add(random.Next(-15, 16));
                }
            }
            else
            {
                _counter = random.Next(10, 20);

                //работа
                foreach (var currentProfessions in _demandProfessions)
                {
                    currentProfessions.Set(random.Next(-30, 31));
                }

                //малый бизнес
                foreach (var currentSmall in _smallBusiness)
                {
                    currentSmall.Set(random.Next(-30, 31));
                }

                //средний бизнес
                foreach (var currentMedium in _mediumBusiness)
                {
                    currentMedium.Set(random.Next(-30, 31));
                }

                //крупный бизнес
                foreach (var currentBig in _bigBusiness)
                {
                    currentBig.Set(random.Next(-30, 31));
                }
            }

            NewDemand = "true";
        }

        /// <summary>
        /// Вернуть значение для текущей работы по названию отрасли
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public static int Professions(string nameProfessions)
        {
            foreach(var currentProfessions in _demandProfessions)
            {
                if(currentProfessions.IndustryName == nameProfessions)
                {
                    return currentProfessions.PercentageDemand;
                }
            }

            return 0;
        }

        //Список востребованности работы
        public static List<DemandProfessionsClass> ListProfessions()
        {
            return _demandProfessions;
        }

        /// <summary>
        /// Вернуть значение для малого бизнеса по названию отрасли
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public static int SmallBusiness(string nameProfessions)
        {
            foreach (var currentProfessions in _smallBusiness)
            {
                if (currentProfessions.IndustryName == nameProfessions)
                {
                    return currentProfessions.PercentageDemand;
                }
            }

            return 0;
        }

        //Список востребованности малого бизнеса
        public static List<DemandProfessionsClass> ListSmallBusiness()
        {
            return _smallBusiness;
        }

        /// <summary>
        /// Вернуть значение для среднего бизнеса по названию отрасли
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public static int MediumBusiness(string nameProfessions)
        {
            foreach (var currentProfessions in _mediumBusiness)
            {
                if (currentProfessions.IndustryName == nameProfessions)
                {
                    return currentProfessions.PercentageDemand;
                }
            }

            return 0;
        }

        //Список востребованности среднего бизнеса
        public static List<DemandProfessionsClass> ListMediumBusiness()
        {
            return _mediumBusiness;
        }

        /// <summary>
        /// Вернуть значение для среднего бизнеса по названию отрасли
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public static int BigBusiness(string nameProfessions)
        {
            foreach (var currentProfessions in _bigBusiness)
            {
                if (currentProfessions.IndustryName == nameProfessions)
                {
                    return currentProfessions.PercentageDemand;
                }
            }

            return 0;
        }

        //Список востребованности среднего бизнеса
        public static List<DemandProfessionsClass> ListBigBusiness()
        {
            return _bigBusiness;
        }

        #endregion

        #region Перерасчет зарплаты из за востребованности

        private static string _newDemand = "false";

        public static void OnPropertyChangedNewDemand(PropertyChangedEventArgs e)
        {
            PropertyChangedNewDemand?.Invoke(null, e);
        }

        public static void OnPropertyChangedNewDemand(string propertyNameNewDemand)
        {
            OnPropertyChangedNewDemand(new PropertyChangedEventArgs(propertyNameNewDemand));
        }

        /// <summary>
        /// Переменная, которая отвечает за изменения дня. Подписываться на нее
        /// </summary>
        public static string NewDemand
        {
            get { return _newDemand; }
            set
            {
                _newDemand = value;
                OnPropertyChangedNewDemand(_newDemand);
            }
        }

        public static event PropertyChangedEventHandler PropertyChangedNewDemand;

        #endregion
    }
}
