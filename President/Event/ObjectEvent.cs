using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Event
{
    public class ObjectEvent : IDisposable
    {
        /// <summary>
        /// Текст события
        /// </summary>
        public string _eventText;

        /// <summary>
        /// /Размер шрифта для события
        /// </summary>
        public int _sizeFont;

        /// <summary>
        /// Список кнопок с различными вариантами ответов
        /// </summary>
        public List<OutcomeOptions> _outcomeOptions;

        /// <summary>
        /// Добавление события 
        /// </summary>
        /// <param name="eventText">Главный текст события</param>
        /// <param name="sizeFont">Размер главного текста</param>
        public ObjectEvent(string eventText, int sizeFont)
        {
            _eventText = eventText;
            _sizeFont = sizeFont;

            _outcomeOptions = new List<OutcomeOptions>();
        }

        /// <summary>
        /// Добавление событий выбора в окно события при правом клике мышкой
        /// </summary>
        /// <param name="nameOutcome">Имя события в меню</param>
        /// <param name="textAfterEvent">Текст после события выбора действия</param>
        /// <param name="gainModifier">Используется для корректировки параметров</param>
        /// <param name="checkParameter">Список параметров которые испозьзуются для проверки</param>
        /// <param name="listParameterСhange">Список параметров которые необходимо изменить после события</param>
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
        /// <summary>
        /// Имя события в меню
        /// </summary>
        public string NameOutcome;

        /// <summary>
        /// Текст после события выбора действия
        /// </summary>
        public string TextAfterEvent;

        /// <summary>
        /// Используется для корректировки параметров
        /// </summary>
        public float GainModifier = 1;

        /// <summary>
        /// Список параметров которые испозьзуются для проверки
        /// </summary>
        public List<Tuple<string, int>> CheckParameter = new List<Tuple<string, int>>();

        /// <summary>
        /// Список параметров которые необходимо изменить после события
        /// </summary>
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
