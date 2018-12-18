using Module_Character;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Module_Event
{
    public partial class EventDisplayForm : Form
    {
        //Список всех событий
        private ObjectEvent _objectEvent;

        private bool _actionSelectionFlag;

        public EventDisplayForm(ObjectEvent objectEvent)
        {
            InitializeComponent();

            _actionSelectionFlag = false;

            TopMost = true;
            ShowInTaskbar = false;

            _objectEvent = objectEvent;

            MainText.SelectionFont = new Font("Tahoma", _objectEvent._sizeFont, FontStyle.Regular);
            MainText.AppendText(_objectEvent._eventText + "\r\n");
            MainText.ScrollToCaret();
            MainText.SelectAll();
            MainText.SelectionAlignment = HorizontalAlignment.Center;

            //MainText.Text = _objectEvent._eventText;

            for (int index = 0; index < _objectEvent._outcomeOptions.Count; index++)
            {
                AddEvents(_objectEvent._outcomeOptions[index], index);
            }
        }

        /// <summary>
        /// Добавление варианта ответа в контекстное меню
        /// </summary>
        /// <param name="outcomeOptions"></param>
        /// <param name="index"></param>
        private void AddEvents(OutcomeOptions outcomeOptions, int index)
        {
            var toolStripMenuItem = new ToolStripMenuItem(outcomeOptions.NameOutcome);

            EventSelectionContextMenu.Items.AddRange(new[] { toolStripMenuItem });

            foreach (var currentCheckParameter in outcomeOptions.CheckParameter)
            {
                if (GameCharacter.Get(currentCheckParameter.Item1) <= currentCheckParameter.Item2)
                {
                    toolStripMenuItem.Enabled = false;

                    toolStripMenuItem.ToolTipText = "Не прошла проверка параметра " + currentCheckParameter.Item1;

                    break;
                }
            }

            EventHandlerClick(toolStripMenuItem, index);
        }

        /// <summary>
        /// Подписка на определенное событие
        /// </summary>
        /// <param name="toolStripMenuItem"></param>
        /// <param name="index"></param>
        private void EventHandlerClick(ToolStripMenuItem toolStripMenuItem, int index)
        {
            switch(index)
            {
                case 0:

                    toolStripMenuItem.Click += EventNumber_One;

                    break;

                case 1:

                    toolStripMenuItem.Click += EventNumber_Two;

                    break;

                case 2:

                    toolStripMenuItem.Click += EventNumber_Three;

                    break;

                case 3:

                    toolStripMenuItem.Click += EventNumber_Four;

                    break;

                case 4:

                    toolStripMenuItem.Click += EventNumber_Five;

                    break;
            }
        }

        private void EventNumber_One(object sender, EventArgs e)
        {
            HandleMouseEventHandling(_objectEvent._outcomeOptions[0]);
        }

        private void EventNumber_Two(object sender, EventArgs e)
        {
            HandleMouseEventHandling(_objectEvent._outcomeOptions[1]);
        }

        private void EventNumber_Three(object sender, EventArgs e)
        {
            HandleMouseEventHandling(_objectEvent._outcomeOptions[2]);
        }

        private void EventNumber_Four(object sender, EventArgs e)
        {
            HandleMouseEventHandling(_objectEvent._outcomeOptions[3]);
        }

        private void EventNumber_Five(object sender, EventArgs e)
        {
            HandleMouseEventHandling(_objectEvent._outcomeOptions[4]);
        }

        /// <summary>
        /// Метод по обработке события клик
        /// </summary>
        /// <param name="outcomeOptionsLocal">Выбранный объект события</param>
        private void HandleMouseEventHandling(OutcomeOptions outcomeOptionsLocal)
        {
            _actionSelectionFlag = true;

            foreach (var currentListParameterСhange in outcomeOptionsLocal.ListParameterСhange)
            {
                GameCharacter.Set(currentListParameterСhange.Item1, currentListParameterСhange.Item2);
            }

            if (outcomeOptionsLocal.TextAfterEvent != "")
            {
                MessageBoxEx.Show(outcomeOptionsLocal.TextAfterEvent, "Событие");
            }

            IDisposable();
        }

        /// <summary>
        /// Вызов контектсного меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EventDisplayForm_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:

                    EventSelectionContextMenu.Show(this, new Point(e.X, e.Y));

                    break;
            }
        }

        public void IDisposable()
        {
            _objectEvent.Dispose();
            EventSelectionContextMenu.Dispose();
            Close();
            Dispose();
        }

        /// <summary>
        /// Если окно было закрыто, а событие небыло выбрано то отнимаем параметры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EventDisplayForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!_actionSelectionFlag)
            {
                GameCharacter.Set("Food", -25);
                GameCharacter.Set("Mood", -25);
                GameCharacter.Set("Health", -25);
            }
        }
    }
}
