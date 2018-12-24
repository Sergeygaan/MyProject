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

namespace Module_Training
{
    public partial class Qualifications_Form : Form
    {
        private int _startValue = 50;

        #region Изменение параметров в разных потоках

        private void ChangesButton(Button button, string text, int value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => {

                    button.Text = text + value.ToString() + " $";

                }));
            }
            else
            {
                button.Text = text + value.ToString() + " $";
            }
        }

        private void ChangesLabel(Label label, int value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => {

                    label.Text = " + " + value.ToString() + " %";

                }));
            }
            else
            {
                label.Text = " + " + value.ToString() + " %";
            }
        }

        #endregion

        private void CalculationParameters(Button button, Label label, int indexParameter, string text)
        {
            int currentCoefficient = GameCharacter.ReturnQualifications(indexParameter);
            int necessaryMoney = _startValue + 10 * currentCoefficient;

            if (GameCharacter.Money >= necessaryMoney)
            {
                GameCharacter.Set("Money", -necessaryMoney);

                GameCharacter.AddQualifications(indexParameter, 5);

                ChangesButton(button, text, _startValue + 10 * GameCharacter.ReturnQualifications(indexParameter));

                ChangesLabel(label, GameCharacter.ReturnQualifications(indexParameter));
            }
            else
            {
                TopMostMessageBox.Show("Недостаточно денег.", "Событие");
            }
        }

        public Qualifications_Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Сельское хозяйство
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAgriculture_Click(object sender, EventArgs e)
        {
            int index = 0;
      
            string currentTextButton = "Сельское хозяйство - ";

            CalculationParameters(buttonAgriculture, labelAgriculture, index, currentTextButton);
        }

        /// <summary>
        /// Творческие
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreative_Click(object sender, EventArgs e)
        {
            int index = 1;

            string currentTextButton = "Творческие - ";

            CalculationParameters(buttonCreative, labelCreative, index, currentTextButton);
        }

        /// <summary>
        /// Экономические
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEconomic_Click(object sender, EventArgs e)
        {
            int index = 2;

            string currentTextButton = "Экономические - ";

            CalculationParameters(buttonEconomic, labelEconomic, index, currentTextButton);
        }

        /// <summary>
        /// Пищевые
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFood_Click(object sender, EventArgs e)
        {
            int index = 3;

            string currentTextButton = "Пищевые - ";

            CalculationParameters(buttonFood, labelFood, index, currentTextButton);
        }

        /// <summary>
        /// Информационные
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInformaticsAndCommunication_Click(object sender, EventArgs e)
        {
            int index = 4;

            string currentTextButton = "Информационные - ";

            CalculationParameters(buttonInformaticsAndCommunication, labelInformaticsAndCommunication, index, currentTextButton);
        }

        /// <summary>
        /// Юридические 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLegal_Click(object sender, EventArgs e)
        {
            int index = 5;

            string currentTextButton = "Юридические - ";

            CalculationParameters(buttonLegal, labelLegal, index, currentTextButton);
        }

        /// <summary>
        /// Медицинские
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMedical_Click(object sender, EventArgs e)
        {
            int index = 6;

            string currentTextButton = "Медицинские - ";

            CalculationParameters(buttonMedical, labelMedical, index, currentTextButton);
        }

        /// <summary>
        /// Военные
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMilitary_Click(object sender, EventArgs e)
        {
            int index = 7;

            string currentTextButton = "Военные - ";

            CalculationParameters(buttonMilitary, labelMilitary, index, currentTextButton);
        }

        /// <summary>
        /// Педагогические
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPedagogical_Click(object sender, EventArgs e)
        {
            int index = 8;

            string currentTextButton = "Педагогические - ";

            CalculationParameters(buttonPedagogical, labelPedagogical, index, currentTextButton);
        }

        /// <summary>
        /// Типография
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPublishingAndTypography_Click(object sender, EventArgs e)
        {
            int index = 9;

            string currentTextButton = "Типография - ";

            CalculationParameters(buttonPublishingAndTypography, labelPublishingAndTypography, index, currentTextButton);
        }

        /// <summary>
        /// Научные
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonScientific_Click(object sender, EventArgs e)
        {
            int index = 10;

            string currentTextButton = "Научные - ";

            CalculationParameters(buttonScientific, labelScientific, index, currentTextButton);
        }

        /// <summary>
        /// Сервис
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonServiceAndMaintenance_Click(object sender, EventArgs e)
        {
            int index = 11;

            string currentTextButton = "Сервис - ";

            CalculationParameters(buttonServiceAndMaintenance, labelServiceAndMaintenance, index, currentTextButton);
        }

        /// <summary>
        /// Спортивные
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSport_Click(object sender, EventArgs e)
        {
            int index = 12;

            string currentTextButton = "Спортивные - ";

            CalculationParameters(buttonSport, labelSport, index, currentTextButton);
        }

        /// <summary>
        /// Технические
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTechnical_Click(object sender, EventArgs e)
        {
            int index = 13;

            string currentTextButton = "Технические - ";

            CalculationParameters(buttonTechnical, labelTechnical, index, currentTextButton);
        }

        /// <summary>
        /// Транспортные
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTransport_Click(object sender, EventArgs e)
        {
            int index = 14;

            string currentTextButton = "Транспортные - ";

            CalculationParameters(buttonTransport, labelTransport, index, currentTextButton);
        }
    }
}
