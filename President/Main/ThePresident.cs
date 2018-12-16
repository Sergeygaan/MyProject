using Module_Character;
using Module_Event;
using Module_GameTime;
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
        private Module_Work_Form _module_Work_Form;

        public ThePresident()
        {
            InitializeComponent();

            //Создание статического класса список действий
            ToDoList.ReturnActionList();
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

        private void buttonModule_Work_Click(object sender, EventArgs e)
        {
            if(_module_Work_Form == null)
            {
                _module_Work_Form = new Module_Work_Form();
            }

            _module_Work_Form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GameTime.AddTime(1300);
        }
    }
}
