﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_GameTime
{
    public static class GameTime
    {
        /// <summary>
        /// Игровой год
        /// </summary>
        private static int _year = 2000;

        private static int _currentMonth = 0;
        private static List<string> _monthList = new List<string>();


        static GameTime()
        {
            _monthList = new List<string>
            {
                "янв",
                "фев",
                "мар",
                "апр",
                "май",
                "июн",
                "июл",
                "авг",
                "сен",
                "окт",
                "ноя",
                "дек"
            };
        }

        #region Минуты и часы

        private static string _minutesAndHour = "00:00";

        public static void OnPropertyChangedMinutesAndHour(PropertyChangedEventArgs e)
        {
            PropertyChangedMinutesAndHour?.Invoke(null, e);
        }

        public static void OnPropertyChangedMinutesAndHour(string propertyNameMinutesAndHour)
        {
            OnPropertyChangedMinutesAndHour(new PropertyChangedEventArgs(propertyNameMinutesAndHour));
        }

        /// <summary>
        /// Переменная, хранящая значение игровых минут и часов
        /// </summary>
        public static string MinutesAndHour
        {
            get { return _minutesAndHour; }
            set
            {
                if (value != _minutesAndHour)
                {
                    _minutesAndHour = value;
                    OnPropertyChangedMinutesAndHour(_minutesAndHour);
                }
            }
        }

        public static event PropertyChangedEventHandler PropertyChangedMinutesAndHour;


        #endregion

        #region Месяцы и года

        private static string _monthAndYear = "янв 2000";

        public static void OnPropertyChangedMonthAndYear(PropertyChangedEventArgs e)
        {
            PropertyChangedMonthAndYear?.Invoke(null, e);
        }

        public static void OnPropertyChangedMonthAndYear(string propertyNameMonthAndYear)
        {
            OnPropertyChangedMonthAndYear(new PropertyChangedEventArgs(propertyNameMonthAndYear));
        }

        /// <summary>
        /// Переменная, хранящая значение игровых минут и часов
        /// </summary>
        public static string MonthAndYear
        {
            get { return _monthAndYear; }
            set
            {
                if (value != _monthAndYear)
                {
                    _monthAndYear = value;
                    OnPropertyChangedMonthAndYear(_monthAndYear);
                }
            }
        }

        public static event PropertyChangedEventHandler PropertyChangedMonthAndYear;


        #endregion

        /// <summary>
        /// Переменная хранящая игровое время
        /// </summary>
        private static int _time = 0;

        private static Random random = new Random();

        /// <summary>
        /// Добавить рандомное время потраченное на действие
        /// </summary>
        /// <param name="start">Начальный параметр времени</param>
        /// <param name="end">Конечный параметр времени</param>
        public static void RandomAddTime(int start, int end)
        {
            AddTime(random.Next(start, end));
        }

        /// <summary>
        /// Добавить фиксированное вермя потраченное на действие
        /// </summary>
        /// <param name="addTime"></param>
        public static void AddTime(int addTime)
        {
            _time += addTime;

            if (_time >= 1440)
            {
                _time -= 1440;

                AddMonthAndYear();
            }

            FormingTimeBar_MinAndHour();
        }

        private static void AddMonthAndYear()
        {
            _currentMonth += 1;

            if(_currentMonth >= 12)
            {
                _currentMonth = 0;

                _year += 1;
            }

            FormingTimeBar_MonthAndYear();
        }

        private static void FormingTimeBar_MonthAndYear()
        {
            string stringMonth = _monthList[_currentMonth];
            string stringYear = _year.ToString();

            MonthAndYear = stringMonth + " " + stringYear;
        }


        private static void FormingTimeBar_MinAndHour()
        {
            string stringMin = "";
            string stringHour = "";

            int min = _time % 60;
            int hour = _time / 60;

            if(min < 10)
            {
                stringMin += "0" + min.ToString();
            }
            else
            {
                stringMin += min.ToString();
            }

            if (hour < 10)
            {
                stringHour += "0" + hour.ToString();
            }
            else
            {
                stringHour += hour.ToString();
            }

            MinutesAndHour = stringHour + ":" + stringMin;
        }


    }
}