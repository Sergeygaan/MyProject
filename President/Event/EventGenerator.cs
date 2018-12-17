using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Event
{
    public class EventGenerator : IDisposable
    {
        /// <summary>
        /// Переменная хранащая объект с событиями
        /// </summary>
        private ObjectEvent _objectEvent;

        //Список параметров которые испозьзуются для проверки
        private List<Tuple<string, int>> CheckParameter = new List<Tuple<string, int>>();

        //Список параметров которые необъодимо изменить после события
        private List<Tuple<string, int>> ListParameterСhange = new List<Tuple<string, int>>();

        /// <summary>
        /// Создание нового события
        /// </summary>
        /// <param name="eventText">Главный текст события</param>
        /// <param name="sizeFont">Размер текста</param>
        public void AddEvents(string eventText, int sizeFont)
        {
            _objectEvent = new ObjectEvent(eventText, sizeFont);
        }

        /// <summary>
        /// Добавление параметров проверки
        /// </summary>
        /// <param name="parameterName">Имя параметра</param>
        /// <param name="parameterValue">Значение параметра</param>
        public void AddCheckParameter(string parameterName, int parameterValue)
        {
            CheckParameter.Add(new Tuple<string, int>(parameterName, parameterValue));
        }

        /// <summary>
        /// Добавление параметров изменения значений
        /// </summary>
        /// <param name="parameterName">Имя параметра</param>
        /// <param name="parameterValue">Значение параметра</param>
        public void AddListParameterСhange(string parameterName, int parameterValue)
        {
            ListParameterСhange.Add(new Tuple<string, int>(parameterName, parameterValue));
        }

        /// <summary>
        ///  Добавление событий выбора в окно события при правом клике мышкой
        /// </summary>
        /// <param name="nameOutcome">Имя события в контекстном меню</param>
        /// <param name="textAfterEvent">Текст после выбора события</param>
        /// <param name="gainModifier">Модификатор для корректировка параметров</param>
        public void AddEventsStaticParameters(string nameOutcome, string textAfterEvent, float gainModifier)
        {
            _objectEvent.AddEventsStaticParameters(nameOutcome, textAfterEvent, gainModifier, CheckParameter, ListParameterСhange);
        }


        /// <summary>
        /// Очистить значений от прошлых
        /// </summary>
        public void ClearValue()
        {
            CheckParameter.Clear();
            ListParameterСhange.Clear();
        }

        /// <summary>
        /// Показать окно события
        /// </summary>
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
