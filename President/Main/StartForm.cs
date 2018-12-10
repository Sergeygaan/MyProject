using CharacterNamespace;
using Event;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();

            GameCharacter.PropertyChangedMoney +=  new PropertyChangedEventHandler(hero_HealthChanged);


        }

        private void hero_HealthChanged(object sender, PropertyChangedEventArgs even)
        {
           
            int i = int.Parse(even.PropertyName);
        }


        private void AddEvent()
        {
            var eventGenerator = new EventGenerator();

            eventGenerator.AddEvents("Главный текст событий.\n 11111111111111", 16);

            eventGenerator.AddCheckParameter("Money", 10);


            eventGenerator.AddListParameterСhange("Money", 5);


            eventGenerator.AddEventsStaticParameters("1", "1", 1);

            eventGenerator.ClearValue();

            eventGenerator.AddCheckParameter("Money", 10);
            eventGenerator.AddCheckParameter("Food", 20);


            eventGenerator.AddListParameterСhange("Money", 5);
            eventGenerator.AddListParameterСhange("Food", 6);


            eventGenerator.AddEventsStaticParameters("2", "2", 2);

            eventGenerator.ClearValue();

            eventGenerator.AddCheckParameter("Money", 10);
            eventGenerator.AddCheckParameter("Food", 20);
            eventGenerator.AddCheckParameter("Mood", 30);
            eventGenerator.AddCheckParameter("Health", 40);

            eventGenerator.AddListParameterСhange("Money", 5);
            eventGenerator.AddListParameterСhange("Food", 6);
            eventGenerator.AddListParameterСhange("Mood", 7);
            eventGenerator.AddListParameterСhange("Health", 8);

            eventGenerator.AddEventsStaticParameters("3", "3", 3);

            eventGenerator.ClearValue();

            eventGenerator.AddCheckParameter("Money", 10);
            eventGenerator.AddCheckParameter("Food", 20);
            eventGenerator.AddCheckParameter("Mood", 30);
            eventGenerator.AddCheckParameter("Health", 222);

            eventGenerator.AddListParameterСhange("Money", 5);
            eventGenerator.AddListParameterСhange("Food", 6);
            eventGenerator.AddListParameterСhange("Mood", 7);
            eventGenerator.AddListParameterСhange("Health", 8);

            eventGenerator.AddEventsStaticParameters("4", "4", 4);

            eventGenerator.ClearValue();

            eventGenerator.AddCheckParameter("Money", 10);
            eventGenerator.AddCheckParameter("Food", 20);
            eventGenerator.AddCheckParameter("Mood", 30);
            eventGenerator.AddCheckParameter("Health", 111);

            eventGenerator.AddListParameterСhange("Money", 5);
            eventGenerator.AddListParameterСhange("Food", 6);
            eventGenerator.AddListParameterСhange("Mood", 7);
            eventGenerator.AddListParameterСhange("Health", 11);

            eventGenerator.AddEventsStaticParameters("5", "5", 5);

            eventGenerator.ClearValue();

            eventGenerator.ShowEvent();

            eventGenerator.Dispose();
            eventGenerator = null;

            //eventGenerator.AddEventsStaticParameters("")
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEvent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //GameCharacter.Money = 125;
        }
    }
}
