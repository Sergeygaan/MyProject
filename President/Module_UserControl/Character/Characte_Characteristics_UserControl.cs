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

            GameCharacter.PropertyChangedFood += new PropertyChangedEventHandler(GetValue_Food);
            GameCharacter.PropertyChangedMood += new PropertyChangedEventHandler(GetValue_Mood);
            GameCharacter.PropertyChangedHealth += new PropertyChangedEventHandler(GetValue_Health);

            GameCharacter.PropertyChangedPhysicalDevelopment += new PropertyChangedEventHandler(GetValue_PhysicalDevelopment);
            GameCharacter.PropertyChangedCharm += new PropertyChangedEventHandler(GetValue_Charm);
            GameCharacter.PropertyChangedIntelligence += new PropertyChangedEventHandler(GetValue_Intelligence);

            if (InvokeRequired)
            {
                Invoke(new Action(() => toolTipFood.SetToolTip(progressBarFood, "Еда: " + progressBarFood.Value + " %")));
                Invoke(new Action(() => toolTipMood.SetToolTip(progressBarMood, "Настроение: " + progressBarMood.Value + " %")));
                Invoke(new Action(() => toolTipHealth.SetToolTip(progressBarHealth, "Здоровье: " + progressBarHealth.Value + " %")));
            }
            else
            {
                toolTipFood.SetToolTip(progressBarFood, "Еда: " + progressBarFood.Value + " %");
                toolTipMood.SetToolTip(progressBarMood, "Настроение: " + progressBarMood.Value + " %");
                toolTipHealth.SetToolTip(progressBarHealth, "Здоровье: " + progressBarHealth.Value + " %");
            }
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
        /// Получить значение еды
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="even"></param>
        private void GetValue_Food(object sender, PropertyChangedEventArgs even)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => progressBarFood.Value = int.Parse(even.PropertyName)));
                Invoke(new Action(() => toolTipFood.SetToolTip(progressBarFood, "Еда: " + progressBarFood.Value + " %")));
            }
            else
            {
                progressBarFood.Value = int.Parse(even.PropertyName);
                toolTipFood.SetToolTip(progressBarFood, "Еда: " + progressBarFood.Value + " %");
            }
        }

        /// <summary>
        /// Получить значение настроения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="even"></param>
        private void GetValue_Mood(object sender, PropertyChangedEventArgs even)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => progressBarMood.Value = int.Parse(even.PropertyName)));
                Invoke(new Action(() => toolTipMood.SetToolTip(progressBarMood, "Настроение: " + progressBarMood.Value + " %")));
            }
            else
            {
                progressBarMood.Value = int.Parse(even.PropertyName);
                toolTipMood.SetToolTip(progressBarMood, "Настроение: " + progressBarMood.Value + " %");
            }
        }

        /// <summary>
        /// Получить значение здоровья
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="even"></param>
        private void GetValue_Health(object sender, PropertyChangedEventArgs even)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => progressBarHealth.Value = int.Parse(even.PropertyName)));
                Invoke(new Action(() => toolTipHealth.SetToolTip(progressBarHealth, "Здоровье: " + progressBarHealth.Value + " %")));
            }
            else
            {
                progressBarHealth.Value = int.Parse(even.PropertyName);
                toolTipHealth.SetToolTip(progressBarHealth, "Здоровье: " + progressBarHealth.Value + " %");
            }
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

    public class ProgressBarEx : ProgressBar
    {
        public ProgressBarEx()
        {
            SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush brush = null;
            Rectangle rec = new Rectangle(0, 0, this.Width, this.Height);

            double scaleFactor = (((double)Value - (double)Minimum) / ((double)Maximum - (double)Minimum));

            if (scaleFactor == 0)
            {
                scaleFactor = 0.01;
            }

            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, rec);

            rec.Width = (int)(rec.Width * scaleFactor);
            rec.Height -= 4;
            brush = new LinearGradientBrush(rec, this.ForeColor, this.BackColor, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(brush, 2, 2, rec.Width, rec.Height);
        }
    }
}
