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
    public partial class Module_Mood_Form : Form
    {
        private Random rnd = new Random();

        public Module_Mood_Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Гулять по улице
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOutside_Click(object sender, EventArgs e)
        {
            ReducingNeeds_Mood(0, 50);
        }

        /// <summary>
        /// Кататься на машине
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            ReducingNeeds_Mood(50, 100);
        }

        /// <summary>
        /// Сходить в клуб
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (GameCharacter.Money >= 150)
            {
                GameCharacter.Set("Money", -150);

                ReducingNeeds_Mood(150, 300);
            }
            else
            {
                TopMostMessageBox.Show("Недостаточно денег.", "Событие");
            }
        }

        /// <summary>
        /// Сходить на концерт
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (GameCharacter.Money >= 300)
            {
                GameCharacter.Set("Money", -300);

                ReducingNeeds_Mood(300, 600);
            }
            else
            {
                TopMostMessageBox.Show("Недостаточно денег.", "Событие");
            }
        }

        /// <summary>
        /// Сходить в ресторан
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if (GameCharacter.Money >= 450)
            {
                GameCharacter.Set("Money", -450);

                ReducingNeeds_Mood(600, 1000);
            }
            else
            {
                TopMostMessageBox.Show("Недостаточно денег.", "Событие");
            }
        }

        /// <summary>
        /// Добавление настроения
        /// </summary>
        /// <param name="fatigue">Максимальное количество уменьшения</param>
        private void ReducingNeeds_Mood(int fatigueStart, int fatigueEnd)
        {
            int randomFood = rnd.Next(fatigueStart, fatigueEnd + 1);
            GameCharacter.Set("Mood", randomFood);
        }
    }
}
