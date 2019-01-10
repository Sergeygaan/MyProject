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
        public void AddQualifications(int value)
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
    }

    public static class Demand
    {
        private static Random random = new Random();

        static Demand()
        {
            //Подписка на события "Новый день" для начисления зарплаты
            Game_Time.PropertyChangedNewDay += new PropertyChangedEventHandler(GetValue_Everyday);

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
        }

        #region Востребованность профессий

        /// <summary>
        /// Список хранящий в себе список всех профессий и их востребованность
        /// </summary>
        private static List<DemandProfessionsClass> _demandProfessions;

        /// <summary>
        /// Новый день
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="even"></param>
        private static void GetValue_Everyday(object sender, PropertyChangedEventArgs even)
        {
            foreach(var currentDemandProfessions in _demandProfessions)
            {
                currentDemandProfessions.AddQualifications(random.Next(-3, 4));
            }

            NewDemand = "true";
        }

        /// <summary>
        /// Вернуть значение для текущей работы по индексу
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public static int ReturnQualifications(int index)
        {
            return _demandProfessions[index].PercentageDemand;
        }

        /// <summary>
        /// Вернуть значение для текущей работы по названию отрасли
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public static int ReturnQualifications(string nameProfessions)
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

        public static List<DemandProfessionsClass> ReturnDemandProfessions()
        {
            return _demandProfessions;
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
