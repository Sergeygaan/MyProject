using Module_Character;
using Module_Event;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_Needs
{
    public partial class Module_Health_Form : Form
    {
        private Random rnd = new Random();

        public Module_Health_Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Выпить витамины
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (GameCharacter.Money >= 25)
            {
                GameCharacter.Set("Money", -25);

                ReducingNeeds_Health(10, 100);
            }
            else
            {
                TopMostMessageBox.Show("Недостаточно денег.", "Событие");
            }
        }

        /// <summary>
        /// Выпить аспирин
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (GameCharacter.Money >= 55)
            {
                GameCharacter.Set("Money", -55);

                ReducingNeeds_Health(100, 150);
            }
            else
            {
                TopMostMessageBox.Show("Недостаточно денег.", "Событие");
            }
        }

        /// <summary>
        /// Проставить уколы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (GameCharacter.Money >= 165)
            {
                GameCharacter.Set("Money", -165);

                ReducingNeeds_Health(150, 350);
            }
            else
            {
                TopMostMessageBox.Show("Недостаточно денег.", "Событие");
            }
        }

        /// <summary>
        /// Пройти обследование
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if (GameCharacter.Money >= 250)
            {
                GameCharacter.Set("Money", -250);

                ReducingNeeds_Health(350, 650);
            }
            else
            {
                TopMostMessageBox.Show("Недостаточно денег.", "Событие");
            }
        }

        /// <summary>
        /// Лечь в больницу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            if (GameCharacter.Money >= 375)
            {
                GameCharacter.Set("Money", -375);

                ReducingNeeds_Health(650, 1000);
            }
            else
            {
                TopMostMessageBox.Show("Недостаточно денег.", "Событие");
            }
        }

        /// <summary>
        /// Добавление здоровья
        /// </summary>
        /// <param name="fatigue">Максимальное количество уменьшения</param>
        private void ReducingNeeds_Health(int fatigueStart, int fatigueEnd)
        {
            int randomFood = rnd.Next(fatigueStart, fatigueEnd + 1);
            GameCharacter.Set("Health", randomFood);
        }
    }
}
