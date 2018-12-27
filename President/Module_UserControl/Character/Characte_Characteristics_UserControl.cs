using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Module_Character;
using System.Drawing.Drawing2D;

namespace Module_UserControl
{
    public partial class Characte_Characteristics_UserControl : UserControl
    {
        public Characte_Characteristics_UserControl()
        {
            InitializeComponent();

            //Подписка на свойства
            GameCharacter.PropertyChangedMoney += new PropertyChangedEventHandler(GetValue_Money);
            GameCharacter.PropertyChangedIncome += new PropertyChangedEventHandler(GetValue_Income);
            GameCharacter.PropertyChangedTax += new PropertyChangedEventHandler(GetValue_Tax);

            GameCharacter.PropertyChangedPhysicalDevelopment += new PropertyChangedEventHandler(GetValue_PhysicalDevelopment);
            GameCharacter.PropertyChangedCharm += new PropertyChangedEventHandler(GetValue_Charm);
            GameCharacter.PropertyChangedIntelligence += new PropertyChangedEventHandler(GetValue_Intelligence);
        }

        #region Подписка на свойства

        /// <summary>
        /// Получить значение денег
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="even"></param>
        private void GetValue_Money(object sender, PropertyChangedEventArgs even)
        {
            TextOutput(labelMoney, "Деньги: " + even.PropertyName + " $");
        }

        /// <summary>
        /// Получить значение дохода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="even"></param>
        private void GetValue_Income(object sender, PropertyChangedEventArgs even)
        {
            TextOutput(labelIncome, "Доход: " + even.PropertyName + " $");
        }

        /// <summary>
        /// Получить значение налога
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="even"></param>
        private void GetValue_Tax(object sender, PropertyChangedEventArgs even)
        {
            TextOutput(labelTax, "Налоги: " + even.PropertyName + " $");
        }

        /// <summary>
        /// Получить значение физической силы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="even"></param>
        private void GetValue_PhysicalDevelopment(object sender, PropertyChangedEventArgs even)
        {
            TextOutput(labelPhysicalDevelopment, "Сила: " + even.PropertyName);
        }

        /// <summary>
        /// Получить значение обаяния
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="even"></param>
        private void GetValue_Charm(object sender, PropertyChangedEventArgs even)
        {
            TextOutput(labelCharm, "Обаяние: " + even.PropertyName);
        }

        /// <summary>
        /// Получить значение интеллекта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="even"></param>
        private void GetValue_Intelligence(object sender, PropertyChangedEventArgs even)
        {
            TextOutput(labelIntelligence, "Интеллект: " + even.PropertyName);
        }

        #endregion

        /// <summary>
        /// Метод для вывода текста на форму из любого потока
        /// </summary>
        /// <param name="currentLabel">Имя label</param>
        /// <param name="text">Текст для вывода</param>
        private void TextOutput(Label currentLabel, string text)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => currentLabel.Text = text));
            }
            else
            {
                currentLabel.Text = text;
            }
        }

    }
}
