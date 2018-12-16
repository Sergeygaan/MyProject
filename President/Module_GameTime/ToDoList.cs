using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_GameTime
{
    public static class ToDoList
    {
        private static List<ActionList> _toDoList;

        static ToDoList()
        {
            _toDoList = new List<ActionList>();

            //Подписка на изменение времени
            GameTime.PropertyChangedTime += new PropertyChangedEventHandler(GetValue_Time);
        }

        #region Работа со списком

        /// <summary>
        /// Добавление дела в список
        /// </summary>
        /// <param name="actionName"></param>
        /// <param name="startTime"></param>
        /// <param name="scatterMinutes"></param>
        public static void AddToDo(string actionName, int startTime, int scatterMinutes = 30)
        {
            int timeMinutes = startTime * 60;

            string formatTime = Forming_MinAndHour(timeMinutes, -scatterMinutes) + " - " + Forming_MinAndHour(timeMinutes, scatterMinutes);

            _toDoList.Add(new ActionList(actionName, timeMinutes, formatTime));
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
                int index = _toDoList.IndexOf(obj);
                _toDoList.RemoveAt(index);
            }
        }

        /// <summary>
        /// Сортировка списка дел
        /// </summary>
        public static void SortToDo()
        {
            _toDoList.Sort((x, y) => x.StartTime.CompareTo(y.StartTime));
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
            int var = int.Parse(even.PropertyName);

            //labelMinuteAndHour.Text = even.PropertyName;

            //GC.Collect();
        }
    }

    public class ActionList
    {
        public string ActionName;

        public int StartTime;

        public string FormatTime;

        public ActionList(string actionName, int startTime, string formatTime)
        {
            ActionName = actionName;
            StartTime = startTime;
            FormatTime = formatTime;
        }
    }
}
