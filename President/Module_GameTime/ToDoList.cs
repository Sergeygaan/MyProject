using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using static Module_GameTime.ToDoList;

namespace Module_GameTime
{
    public static class ToDoList
    {
        public delegate void Delegate_ActionSkipMethod(int index);
        public delegate bool Delegate_ActionСheck();

        private static List<ActionList> _toDoList;

        static ToDoList()
        {
            _toDoList = new List<ActionList>();

            //Подписка на изменение времени
            GameTime.PropertyChangedTime += new PropertyChangedEventHandler(GetValue_Time);
            GameTime.PropertyChangedNewDay += new PropertyChangedEventHandler(EnduringAction_NewDay);
        }

        #region Работа со списком

        /// <summary>
        /// Обновление всех действий в начале нового дня
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="even"></param>
        private static void EnduringAction_NewDay(object sender, PropertyChangedEventArgs even)
        {
            foreach (var currentToDo in _toDoList)
            {
                currentToDo.ActionActivity = true;
            }

            ChangeToDoList = "true";
        }

        /// <summary>
        /// Добавление дела в список
        /// </summary>
        /// <param name="actionName"></param>
        /// <param name="startTime"></param>
        /// <param name="scatterMinutes"></param>
        public static void AddToDo(string actionName, int startTime, Delegate_ActionSkipMethod delegate_ActionSkipMethod, Delegate_ActionСheck  delegate_ActionСheck, int scatterMinutes = 30)
        {
            int timeMinutes = startTime * 60;

            string formatTime = Forming_MinAndHour(timeMinutes, -scatterMinutes) + " - " + Forming_MinAndHour(timeMinutes, scatterMinutes);

            _toDoList.Add(new ActionList(actionName, timeMinutes - 30, timeMinutes + 30, formatTime, delegate_ActionSkipMethod, delegate_ActionСheck));

            ChangeToDoList = "true";
        }

        /// <summary>
        /// Удаление из списка дела по имени
        /// </summary>
        /// <param name="actionName"></param>
        public static void RemoveToDo(string actionName)
        {
            var obj = (_toDoList.FirstOrDefault(o => o.ActionName == actionName));

            if (obj != null)
            {
                obj.Delegate_ActionSkipMethod = null;
                obj.Delegate_ActionСheck = null;

                int index = _toDoList.IndexOf(obj);
                _toDoList.RemoveAt(index);
            }

            ChangeToDoList = "true";
        }

        /// <summary>
        /// Сортировка списка дел
        /// </summary>
        public static void SortToDo()
        {
            _toDoList.Sort((x, y) => x.EndTime.CompareTo(y.EndTime));
        }

        public static List<ActionList> ReturnActionList()
        {
            SortToDo();

            return _toDoList;
        }

        private static string Forming_MinAndHour(int minutes, int scatterMinutes)
        {
            minutes += scatterMinutes;

            if(minutes < 0)
            {
                minutes = 1440 + scatterMinutes;
            }

            if(minutes > 1440)
            {
                minutes = 0 + scatterMinutes;
            }

            string stringMin = "";
            string stringHour = "";

            int min = minutes % 60;
            int hour = minutes / 60;

            if (min < 10)
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

            return stringHour + ":" + stringMin;
        }

        #endregion


        /// <summary>
        /// Получить значение минут и часов
        /// </summary>
        private static void GetValue_Time(object sender, PropertyChangedEventArgs even)
        {
            int checkTime = int.Parse(even.PropertyName);

            foreach(var currentToDo in _toDoList)
            {
                currentToDo.Delegate_ActionSkipMethod(1);

                bool a = currentToDo.Delegate_ActionСheck();

                //currentToDo.ActionActivity = false;

                //ChangeToDoList = "true";
                if (currentToDo.EndTime > checkTime)
                {

                    //int i = 0;

                    // проверяем было ли совершено даннок дкйствие
                    //Выполняем метод переданный делегатом
                }
            }
            //labelMinuteAndHour.Text = even.PropertyName;

            //GC.Collect();
        }

        #region Изменение списка

        private static string _changeToDoList = "false";

        public static void OnPropertyChangedChangeToDoList(PropertyChangedEventArgs e)
        {
            PropertyChangedChangeToDoList?.Invoke(null, e);
        }

        public static void OnPropertyChangedChangeToDoList(string propertyNameChangeToDoList)
        {
            OnPropertyChangedChangeToDoList(new PropertyChangedEventArgs(propertyNameChangeToDoList));
        }

        /// <summary>
        /// Переменная, которая отвечает за изменения дня. Подписываться на нее
        /// </summary>
        public static string ChangeToDoList
        {
            get { return _changeToDoList; }
            set
            {
                _changeToDoList = value;
                OnPropertyChangedChangeToDoList(_changeToDoList);
            }
        }

        public static event PropertyChangedEventHandler PropertyChangedChangeToDoList;

        #endregion
    }

    public class ActionList
    {
        /// <summary>
        /// Название действия
        /// </summary>
        public string ActionName;

        /// <summary>
        /// Время проверки выполнения действия
        /// </summary>
        public int StartTime;

        /// <summary>
        /// Время проверки выполнения действия
        /// </summary>
        public int EndTime;

        /// <summary>
        /// Отформотированная строка со временем
        /// </summary>
        public string FormatTime;

        /// <summary>
        /// Отформотированная строка со временем
        /// </summary>
        public bool ActionActivity = true;

        /// <summary>
        /// Метод выполняемый для определенного действия
        /// </summary>
        public Delegate_ActionSkipMethod Delegate_ActionSkipMethod;

        /// <summary>
        /// Метод служащий для проверки выполнения действия
        /// </summary>
        public Delegate_ActionСheck Delegate_ActionСheck;

        public ActionList(string actionName, int startTime, int endTime, string formatTime, Delegate_ActionSkipMethod delegate_ActionSkipMethod, Delegate_ActionСheck delegate_ActionСheck)
        {
            ActionName = actionName;

            StartTime = startTime;
            EndTime = endTime;
            FormatTime = formatTime;

            Delegate_ActionSkipMethod = delegate_ActionSkipMethod;
            Delegate_ActionСheck = delegate_ActionСheck;
        }
    }
}
