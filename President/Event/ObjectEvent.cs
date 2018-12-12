using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Event
{
    public class ObjectEvent : IDisposable
    {
        //Текст события
        public string _eventText;
        
        //Размер шрифта для события
        public int _sizeFont;

        public List<OutcomeOptions> _outcomeOptions;

        public ObjectEvent(string eventText, int sizeFont)
        {
            _eventText = eventText;
            _sizeFont = sizeFont;

            _outcomeOptions = new List<OutcomeOptions>();
        }

        public void AddEventsStaticParameters(string nameOutcome, string textAfterEvent, float gainModifier, List<Tuple<string, int>> checkParameter, List<Tuple<string, int>> listParameterСhange)
        {
            var outcomeOptions = new OutcomeOptions
            {
                NameOutcome = nameOutcome,
                TextAfterEvent = textAfterEvent,
                GainModifier = gainModifier,
            };

            outcomeOptions.CheckParameter = checkParameter.GetRange(0, checkParameter.Count);
            outcomeOptions.ListParameterСhange = listParameterСhange.GetRange(0, listParameterСhange.Count);

            _outcomeOptions.Add(outcomeOptions);
        }

        public void Dispose()
        {
            foreach(var currentOutcomeOptions in _outcomeOptions)
            {
                currentOutcomeOptions?.Dispose();
            }
        }
    }

    public class OutcomeOptions : IDisposable
    {
        //Имя события в меню
        public string NameOutcome;

        //Текст после события выбора действия
        public string TextAfterEvent;

        //Используется для корректировки параметров
        public float GainModifier = 1;

        //Список параметров которые испозьзуются для проверки
        public List<Tuple<string, int>> CheckParameter = new List<Tuple<string, int>>();

        //Список параметров которые необходимо изменить после события
        public List<Tuple<string, int>> ListParameterСhange = new List<Tuple<string, int>>();

        public void Dispose()
        {
            CheckParameter?.Clear();
            CheckParameter = null;

            ListParameterСhange?.Clear();
            ListParameterСhange = null;
        }
    }
}
