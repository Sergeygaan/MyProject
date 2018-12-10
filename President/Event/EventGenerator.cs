using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class EventGenerator : IDisposable
    {
        private ObjectEvent _objectEvent;

        //Список параметров которые испозьзуются для проверки
        private List<Tuple<string, int>> CheckParameter = new List<Tuple<string, int>>();

        //Список параметров которые необъодимо изменить после события
        private List<Tuple<string, int>> ListParameterСhange = new List<Tuple<string, int>>();

        public void AddEvents(string eventText, int sizeFont)
        {
            _objectEvent = new ObjectEvent(eventText, sizeFont);
        }

        //Добавление параметров проверки
        public void AddCheckParameter(string parameterName, int parameterValue)
        {
            CheckParameter.Add(new Tuple<string, int>(parameterName, parameterValue));
        }

        //Добавление параметров изменения значений
        public void AddListParameterСhange(string parameterName, int parameterValue)
        {
            ListParameterСhange.Add(new Tuple<string, int>(parameterName, parameterValue));
        }

        public void AddEventsStaticParameters(string nameOutcome, string textAfterEvent, float gainModifier)
        {
            _objectEvent.AddEventsStaticParameters(nameOutcome, textAfterEvent, gainModifier, CheckParameter, ListParameterСhange);
        }


        //Очистить значений от прошлых
        public void ClearValue()
        {
            CheckParameter.Clear();
            ListParameterСhange.Clear();
        }

        public void ShowEvent()
        {
            EventDisplayForm eventDisplayForm = new EventDisplayForm(_objectEvent);
            eventDisplayForm.ShowDialog();

            eventDisplayForm.Dispose();
            eventDisplayForm = null;
        }

        public void Dispose()
        {
            CheckParameter.Clear();
            CheckParameter = null;

            ListParameterСhange.Clear();
            ListParameterСhange = null;

            _objectEvent.Dispose();
            _objectEvent = null;
        }
    }
}
