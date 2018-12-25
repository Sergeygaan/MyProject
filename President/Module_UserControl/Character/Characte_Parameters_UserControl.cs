using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Module_Character;

namespace Module_UserControl
{
    public partial class Characte_Parameters_UserControl : UserControl
    {
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

        public Characte_Parameters_UserControl()
        {
            InitializeComponent();

            GameCharacter.PropertyChangedAge += new PropertyChangedEventHandler(GetValue_Age);
            GameCharacter.PropertyChangedStudy += new PropertyChangedEventHandler(GetValue_Study);
        }

        /// <summary>
        /// Получить возраст
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="even"></param>
        private void GetValue_Age(object sender, PropertyChangedEventArgs even)
        {
            TextOutput(labelAge, "Возраст: " + even.PropertyName + " " + AgeText(int.Parse(even.PropertyName)));
        }

        #region Определить "Лет" или "Года"

        //функция для опеределения двух последних цифр в возрасте (для распознавания 11 - 14)
        //определяется остатком от деления числа на 100
        int LastTwoDigits(int ages) { return ages % 100; }

        //функция для определения последней цифры в возрасте
        //определяется остатком от деления числа на 10
        int LastDigit(int ages) { return ages % 10; }

        private string AgeText(int ages)
        {
            //определяем нужное слово:
            int last_two = LastTwoDigits(ages);

            if ((last_two >= 11) && (last_two <= 14))
            {
                return "лет";
            }
            else
            {
                int last = LastDigit(ages);

                if (last == 1)
                {
                    return "год";
                }
                else if ((last >= 2) && (last <= 4))
                {
                    return "года";
                }
                else
                {
                    return "лет";
                }
            }
        }

        #endregion

        /// <summary>
        /// Получить значение переменной "образование"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="even"></param>
        private void GetValue_Study(object sender, PropertyChangedEventArgs even)
        {
            TextOutput(labelStudy, "Образование: " + even.PropertyName);
        }

    }
}
