using Module_Character;
using Module_Event;
using Module_GameTime;
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
    public partial class Module_SelfDevelopment_Form : Form
    {
        private Random rnd = new Random();


        public Module_SelfDevelopment_Form()
        {
            InitializeComponent();

            //Подписка на события "Новый день" 
            Game_Time.PropertyChangedNewDay += new PropertyChangedEventHandler(GetValue_Everyday);
        }

        #region Интеллект 

        /// <summary>
        /// Почитать книгу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Book_Click(object sender, EventArgs e)
        {
            AddFeature("Intelligence", 0, 10);
        }

        /// <summary>
        /// Сходить в библиотеку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Library_Click(object sender, EventArgs e)
        {
            if (GameCharacter.Money >= 40)
            {
                GameCharacter.Set("Money", -40);

                AddFeature("Intelligence", 10, 15);
            }
            else
            {
                TopMostMessageBox.Show("Недостаточно денег.", "Событие");
            }
        }

        /// <summary>
        /// Пройти обучение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Education_Click(object sender, EventArgs e)
        {
            if (GameCharacter.Money >= 120)
            {
                GameCharacter.Set("Money", -120);

                AddFeature("Intelligence", 15, 25);
            }
            else
            {
                TopMostMessageBox.Show("Недостаточно денег.", "Событие");
            }
        }

        #endregion

        #region Обаяние 

        /// <summary>
        /// Пообщаться с людьми
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Communication_Click(object sender, EventArgs e)
        {
            AddFeature("Charm", 0, 10);
        }

        /// <summary>
        /// Посетить тренинг
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Training_Click(object sender, EventArgs e)
        {
            if (GameCharacter.Money >= 30)
            {
                GameCharacter.Set("Money", -30);

                AddFeature("Charm", 10, 15);
            }
            else
            {
                TopMostMessageBox.Show("Недостаточно денег.", "Событие");
            }
        }

        /// <summary>
        /// Посетить курсы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Courses_Click(object sender, EventArgs e)
        {
            if (GameCharacter.Money >= 100)
            {
                GameCharacter.Set("Money", -100);

                AddFeature("Charm", 15, 25);
            }
            else
            {
                TopMostMessageBox.Show("Недостаточно денег.", "Событие");
            }
        }


        #endregion

        #region Сила

        private void button_Exercise_Click(object sender, EventArgs e)
        {
            AddFeature("PhysicalDevelopment", 0, 10);
        }

        private void button_Gym_Click(object sender, EventArgs e)
        {
            if (GameCharacter.Money >= 50)
            {
                GameCharacter.Set("Money", -50);

                AddFeature("PhysicalDevelopment", 10, 15);
            }
            else
            {
                TopMostMessageBox.Show("Недостаточно денег.", "Событие");
            }
        }

        private void button_Trainer_Click(object sender, EventArgs e)
        {
            if (GameCharacter.Money >= 150)
            {
                GameCharacter.Set("Money", -150);

                AddFeature("PhysicalDevelopment", 15, 25);
            }
            else
            {
                TopMostMessageBox.Show("Недостаточно денег.", "Событие");
            }
        }

        #endregion

        private void Button(bool flag)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => {

                    button_Book.Enabled = flag;
                    button_Library.Enabled = flag;
                    button_Education.Enabled = flag;

                    button_Communication.Enabled = flag;
                    button_Training.Enabled = flag;
                    button_Courses.Enabled = flag;

                    button_Exercise.Enabled = flag;
                    button_Gym.Enabled = flag;
                    button_Trainer.Enabled = flag;

                }));
            }
            else
            {
                button_Book.Enabled = flag;
                button_Library.Enabled = flag;
                button_Education.Enabled = flag;

                button_Communication.Enabled = flag;
                button_Training.Enabled = flag;
                button_Courses.Enabled = flag;

                button_Exercise.Enabled = flag;
                button_Gym.Enabled = flag;
                button_Trainer.Enabled = flag;
            }
        }

        /// <summary>
        /// Уменьшает характеристики персонажа
        /// </summary>
        /// <param name="fatigue">Максимальное количество уменьшения</param>
        private void ReducingNeeds(int fatigue)
        {
            int randomFood = rnd.Next(0, fatigue);
            int randomMood = rnd.Next(0, fatigue);
            int randomHealth = rnd.Next(0, fatigue);

            GameCharacter.ReducingNeeds(randomFood, randomMood, randomHealth);
        }

        /// <summary>
        /// Добавление характеристики
        /// </summary>
        /// <param name="fatigue">Максимальное количество уменьшения</param>
        private void AddFeature(string param, int fatigueStart, int fatigueEnd)
        {
            int randomParam= rnd.Next(fatigueStart, fatigueEnd + 1);

            GameCharacter.Set(param, randomParam);

            ReducingNeeds(50);

            Button(false);
        }

        /// <summary>
        /// Новый день
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="even"></param>
        private void GetValue_Everyday(object sender, PropertyChangedEventArgs even)
        {
            Button(true);
        }
    }
}
