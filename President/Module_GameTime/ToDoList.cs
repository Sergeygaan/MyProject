using System;
using System.Collections.Generic;
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
        }

        public static void AddToDo(string actionName, int startTime, int scatterMinutes = 30)
        {
            int timeMinutes = startTime * 60;

            string formatTime = Forming_MinAndHour(timeMinutes, -scatterMinutes) + " - " + Forming_MinAndHour(timeMinutes, scatterMinutes);

            _toDoList.Add(new ActionList(actionName, timeMinutes, formatTime));
        }

        public static void RemoveToDo(string actionName)
        {
            var obj = (_toDoList.FirstOrDefault(o => o.ActionName == actionName));

            if (obj != null)
            {
                int index = _toDoList.IndexOf(obj);
                _toDoList.RemoveAt(index);
            }
        }

        public static void SortToDo()
        {
            _toDoList.Sort((x, y) => x.StartTime.CompareTo(y.StartTime));
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
    }

    class ActionList
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
