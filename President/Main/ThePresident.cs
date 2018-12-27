using Module_Character;
using Module_Event;
using Module_GameTime;
using Module_Needs;
using Module_Training;
using Module_Work;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThePresident
{
    public partial class ThePresident : Form
    {
        /// <summary>
        /// Модуль "Работа"
        /// </summary>
        private Module_Work_Form _module_Work_Form;

        /// <summary>
        /// Модуль "Обучение"
        /// </summary>
        private Module_Training_Form _module_Training_Form;

        /// <summary>
        /// Модуль "Еда"
        /// </summary>
        private Module_Food_Form _module_Food_Form;

        /// <summary>
        /// Модуль "Настроение"
        /// </summary>
        private Module_Mood_Form _module_Mood_Form;

        /// <summary>
        /// Модуль "Здоровье"
        /// </summary>
        private Module_Health_Form _module_Health_Form;

        /// <summary>
        /// Таймер игрового времени. Добавляет 1 сек игрового времени раз в 2500 сек настояжего времени
        /// </summary>
        private Game_Timer _gameTimer;

        public ThePresident()
        {
            InitializeComponent();

            _gameTimer = new Game_Timer();
        }

     
        private void AddEvent()
        {
            var eventGenerator = new EventGenerator();

            eventGenerator.AddEvents("Главный текст событий.\n 11111111111111", 16);

            eventGenerator.AddCheckParameter("Income", 50);

            eventGenerator.AddListParameterСhange("Money", 10);
            eventGenerator.AddListParameterСhange("Food", 20);
            eventGenerator.AddListParameterСhange("Mood", 30);
            eventGenerator.AddListParameterСhange("Health", 40);

            eventGenerator.AddListParameterСhange("PhysicalDevelopment", 50);
            eventGenerator.AddListParameterСhange("Charm", 60);
            eventGenerator.AddListParameterСhange("Intelligence", 70);

            eventGenerator.AddEventsStaticParameters("1", "1", 1);

            eventGenerator.ClearValue();

            eventGenerator.AddListParameterСhange("Money", -10);
            eventGenerator.AddListParameterСhange("Food", -20);
            eventGenerator.AddListParameterСhange("Mood", -30);
            eventGenerator.AddListParameterСhange("Health", -40);

            eventGenerator.AddListParameterСhange("PhysicalDevelopment", -50);
            eventGenerator.AddListParameterСhange("Charm", -60);
            eventGenerator.AddListParameterСhange("Intelligence", -70);

            eventGenerator.AddEventsStaticParameters("2", "2", 2);

            eventGenerator.ClearValue();

            //eventGenerator.AddCheckParameter("Money", 10);
            //eventGenerator.AddCheckParameter("Food", 20);


            //eventGenerator.AddListParameterСhange("Money", 5);
            //eventGenerator.AddListParameterСhange("Food", 6);


            //eventGenerator.AddEventsStaticParameters("2", "2", 2);

            //eventGenerator.ClearValue();

            //eventGenerator.AddCheckParameter("Money", 10);
            //eventGenerator.AddCheckParameter("Food", 20);
            //eventGenerator.AddCheckParameter("Mood", 30);
            //eventGenerator.AddCheckParameter("Health", 40);

            //eventGenerator.AddListParameterСhange("Money", 51);
            //eventGenerator.AddListParameterСhange("Food", 6);
            //eventGenerator.AddListParameterСhange("Mood", 7);
            //eventGenerator.AddListParameterСhange("Health", 8);

            //eventGenerator.AddEventsStaticParameters("3", "3", 3);

            //eventGenerator.ClearValue();

            //eventGenerator.AddCheckParameter("Money", 10);
            //eventGenerator.AddCheckParameter("Food", 20);
            //eventGenerator.AddCheckParameter("Mood", 30);
            //eventGenerator.AddCheckParameter("Health", 222);

            //eventGenerator.AddListParameterСhange("Money", 5);
            //eventGenerator.AddListParameterСhange("Food", 6);
            //eventGenerator.AddListParameterСhange("Mood", 7);
            //eventGenerator.AddListParameterСhange("Health", 8);

            //eventGenerator.AddEventsStaticParameters("4", "4", 4);

            //eventGenerator.ClearValue();

            //eventGenerator.AddCheckParameter("Money", 10);
            //eventGenerator.AddCheckParameter("Food", 20);
            //eventGenerator.AddCheckParameter("Mood", 30);
            //eventGenerator.AddCheckParameter("Health", 111);

            //eventGenerator.AddListParameterСhange("Money", 5);
            //eventGenerator.AddListParameterСhange("Food", 6);
            //eventGenerator.AddListParameterСhange("Mood", 7);
            //eventGenerator.AddListParameterСhange("Health", 11);

            //eventGenerator.AddEventsStaticParameters("5", "5", 5);

            //eventGenerator.ClearValue();

            eventGenerator.ShowEvent();

            eventGenerator.Dispose();
            eventGenerator = null;

            GC.Collect();

            //eventGenerator.AddEventsStaticParameters("")
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEvent();
        }

        /// <summary>
        /// Открыть модуль "Работа"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModule_Work_Click(object sender, EventArgs e)
        {
            if(_module_Work_Form == null)
            {
                _module_Work_Form = new Module_Work_Form();
            }

            _module_Work_Form.ShowDialog();
        }

        /// <summary>
        /// Открыть модуль "Обучение"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTraining_Click(object sender, EventArgs e)
        {
            if (_module_Training_Form == null)
            {
                _module_Training_Form = new Module_Training_Form();
            }

            _module_Training_Form.ShowDialog();
        }

        /// <summary>
        /// Открыть форму "Еда"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFood_Click(object sender, EventArgs e)
        {
            if (_module_Food_Form == null)
            {
                _module_Food_Form = new Module_Food_Form();
            }

            _module_Food_Form.ShowDialog();
        }

        /// <summary>
        /// Открыть форму "Настроение"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMood_Click(object sender, EventArgs e)
        {
            if (_module_Mood_Form == null)
            {
                _module_Mood_Form = new Module_Mood_Form();
            }

            _module_Mood_Form.ShowDialog();
        }

        /// <summary>
        /// Открыть форму "Здоровье"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHealth_Click(object sender, EventArgs e)
        {
            if (_module_Health_Form == null)
            {
                _module_Health_Form = new Module_Health_Form();
            }

            _module_Health_Form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Game_Time.AddTime(2100);
        }
    }
}
