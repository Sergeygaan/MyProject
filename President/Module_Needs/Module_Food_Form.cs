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
    public partial class Module_Food_Form : Form
    {
        private Random rnd = new Random();

        public Module_Food_Form()
        {
          
            InitializeComponent();
        }

        /// <summary>
        /// Булочка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBun_Click(object sender, EventArgs e)
        {
            if (GameCharacter.Money >= 5)
            {
                GameCharacter.Set("Money", -5);

                ReducingNeeds_Food(10, 50);
            }
            else
            {
                TopMostMessageBox.Show("Недостаточно денег.", "Событие");
            }
        }

        /// <summary>
        /// Бич-пакет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBeachPackage_Click(object sender, EventArgs e)
        {
            if (GameCharacter.Money >= 20)
            {
                GameCharacter.Set("Money", -20);

                ReducingNeeds_Food(50, 100);
            }
            else
            {
                TopMostMessageBox.Show("Недостаточно денег.", "Событие");
            }
        }

        /// <summary>
        /// Столовая
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonСanteen_Click(object sender, EventArgs e)
        {
            if (GameCharacter.Money >= 50)
            {
                GameCharacter.Set("Money", -50);

                ReducingNeeds_Food(100, 250);
            }
            else
            {
                TopMostMessageBox.Show("Недостаточно денег.", "Событие");
            }
        }

        /// <summary>
        /// Кафе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCafe_Click(object sender, EventArgs e)
        {
            if (GameCharacter.Money >= 100)
            {
                GameCharacter.Set("Money", -100);

                ReducingNeeds_Food(250, 500);
            }
            else
            {
                TopMostMessageBox.Show("Недостаточно денег.", "Событие");
            }
        }

        /// <summary>
        /// Ресторан
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRestaurant_Click(object sender, EventArgs e)
        {
            if (GameCharacter.Money >= 250)
            {
                GameCharacter.Set("Money", -250);

                ReducingNeeds_Food(500, 1000);
            }
            else
            {
                TopMostMessageBox.Show("Недостаточно денег.", "Событие");
            }
        }

        /// <summary>
        /// Добавление еды
        /// </summary>
        /// <param name="fatigue">Максимальное количество уменьшения</param>
        private void ReducingNeeds_Food(int fatigueStart, int fatigueEnd)
        {
            int randomFood = rnd.Next(fatigueStart, fatigueEnd + 1);
            GameCharacter.Set("Food", randomFood);
        }
    }
}
