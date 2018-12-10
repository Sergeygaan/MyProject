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

namespace ThePresident
{
    public partial class ThePresident : Form
    {
        public ThePresident()
        {
            InitializeComponent();

            //Подписка на свойства
            GameCharacter.PropertyChangedMoney += new PropertyChangedEventHandler(GetValue_Money);
            GameCharacter.PropertyChangedFood += new PropertyChangedEventHandler(GetValue_Food);
            GameCharacter.PropertyChangedMood += new PropertyChangedEventHandler(GetValue_Mood);
            GameCharacter.PropertyChangedHealth += new PropertyChangedEventHandler(GetValue_Health);

            GameCharacter.PropertyChangedPhysicalDevelopment += new PropertyChangedEventHandler(GetValue_PhysicalDevelopment);
            GameCharacter.PropertyChangedCharm += new PropertyChangedEventHandler(GetValue_Charm);
            GameCharacter.PropertyChangedIntelligence += new PropertyChangedEventHandler(GetValue_Intelligence);
        }

        #region Подписка на свойства

        //Получить значение денег
        private void GetValue_Money(object sender, PropertyChangedEventArgs even)
        {
            labelMoney.Text = "Деньги: " + even.PropertyName + " $";
            //int i = int.Parse(even.PropertyName);
        }

        //Получить значение еды
        private void GetValue_Food(object sender, PropertyChangedEventArgs even)
        {
            labelFood.Text = "Еда: " + even.PropertyName + " %";
            //int i = int.Parse(even.PropertyName);
        }

        //Получить значение настроения
        private void GetValue_Mood(object sender, PropertyChangedEventArgs even)
        {
            labelMood.Text = "Здоровье: " + even.PropertyName + " %";
            //int i = int.Parse(even.PropertyName);
        }

        //Получить значение здоровья
        private void GetValue_Health(object sender, PropertyChangedEventArgs even)
        {
            labelHealth.Text = "Настроение: " + even.PropertyName + " %";
            //int i = int.Parse(even.PropertyName);
        }

        //Получить значение физической силы
        private void GetValue_PhysicalDevelopment(object sender, PropertyChangedEventArgs even)
        {
            labelPhysicalDevelopment.Text = "Физическая сила: " + even.PropertyName + " %";
            //int i = int.Parse(even.PropertyName);
        }

        //Получить значение обаяния
        private void GetValue_Charm(object sender, PropertyChangedEventArgs even)
        {
            labelCharm.Text = "Обаяние: " + even.PropertyName + " %";
            //int i = int.Parse(even.PropertyName);
        }

        //Получить значение интеллекта
        private void GetValue_Intelligence(object sender, PropertyChangedEventArgs even)
        {
            labelIntelligence.Text = "Интеллект: " + even.PropertyName + " %";
            //int i = int.Parse(even.PropertyName);
        }

        #endregion

        private void AddEvent()
        {
            var eventGenerator = new EventGenerator();

            eventGenerator.AddEvents("Главный текст событий.\n 11111111111111", 16);

            //eventGenerator.AddCheckParameter("Money", 10);

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
    }
}
