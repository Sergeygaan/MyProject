using Module_Character;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_GameTime
{
    public static class GameTime
    {
        private static Random random = new Random();

        /// <summary>
        /// Игровой год
        /// </summary>
        private static int _year = 2000;

        private static int _currentMonth = 0;
        private static List<string> _monthList = new List<string>();

        /// <summary>
        /// Предыдущая метка времени
        /// </summary>
        private static int _previousTime = 0;

        /// <summary>
        /// Конструктор класса "Таймер"
        /// </summary>
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

        private static string _minutesAndHour;

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

        #region Время в минутах

        private static int _time = 0;

        public static void OnPropertyChangedTime(PropertyChangedEventArgs e)
        {
            PropertyChangedTime?.Invoke(null, e);
        }

        public static void OnPropertyChangedTime(int propertyNameTime)
        {
            OnPropertyChangedTime(new PropertyChangedEventArgs(propertyNameTime.ToString()));
        }

        /// <summary>
        /// Переменная хранящая игровое время
        /// </summary>
        public static int Time
        {
            get { return _time; }
            set
            {
                if (value != _time)
                {
                    _time = value;
                    OnPropertyChangedTime(_time);
                }
            }
        }

        public static event PropertyChangedEventHandler PropertyChangedTime;

        #endregion


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
        /// <param name="time">Время которое необходимо дабовить</param>
        public static void AddTime(int time)
        {
            int localTime = Time;
            localTime += time;

            if (localTime >= 1440)
            {
                localTime -= 1440;

                AddMonthAndYear();

                NewDay = "true";
            }

            _previousTime = Time;
            Time = localTime;

            FormingTimeBar_MinAndHour();
        }

        /// <summary>
        /// Метод откатывает время на прошлую метку времени
        /// </summary>
        public static int TakeAwayTime()
        {
            return _previousTime;
        }

        private static void AddMonthAndYear()
        {
            _currentMonth += 1;

            //Прошло пол года
            if((_currentMonth == 5) || (_currentMonth == 11))
            {
                HalfYear = "true";
            }

            if(_currentMonth >= 12)
            {
                _currentMonth = 0;

                _year += 1;

                GameCharacter.Set("Age", 1);
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

            int min = Time % 60;
            int hour = Time / 60;

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

        #region Событие новый день

        private static string _newDay = "false";

        public static void OnPropertyChangedNewDay(PropertyChangedEventArgs e)
        {
            PropertyChangedNewDay?.Invoke(null, e);
        }

        public static void OnPropertyChangedNewDay(string propertyNameNewDay)
        {
            OnPropertyChangedNewDay(new PropertyChangedEventArgs(propertyNameNewDay));
        }

        /// <summary>
        /// Переменная, которая отвечает за изменения дня. Подписываться на нее
        /// </summary>
        public static string NewDay
        {
            get { return _newDay; }
            set
            {
                _newDay = value;
                OnPropertyChangedNewDay(_newDay);
            }
        }

        public static event PropertyChangedEventHandler PropertyChangedNewDay;

        #endregion

        #region Событие пол года

        private static string _halfYear = "false";

        public static void OnPropertyChangedHalfYear(PropertyChangedEventArgs e)
        {
            PropertyChangedHalfYear?.Invoke(null, e);
        }

        public static void OnPropertyChangedHalfYear(string propertyNameHalfYear)
        {
            OnPropertyChangedHalfYear(new PropertyChangedEventArgs(propertyNameHalfYear));
        }

        /// <summary>
        /// Переменная, которая отвечает за изменения дня. Подписываться на нее
        /// </summary>
        public static string HalfYear
        {
            get { return _halfYear; }
            set
            {
                _halfYear = value;
                OnPropertyChangedHalfYear(_halfYear);
            }
        }

        public static event PropertyChangedEventHandler PropertyChangedHalfYear;

        #endregion
    }
}
