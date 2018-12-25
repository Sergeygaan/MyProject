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

            ToolTipFoodText(progressBarFood, toolTipFood, progressBarFood.Value, "Еда: " + progressBarFood.Value + " %");
            ToolTipFoodText(progressBarMood, toolTipMood, progressBarMood.Value, "Настроение: " + progressBarMood.Value + " %");
            ToolTipFoodText(progressBarHealth, toolTipHealth, progressBarHealth.Value, "Здоровье: " + progressBarHealth.Value + " %");
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
            ToolTipFoodText(progressBarFood, toolTipFood, int.Parse(even.PropertyName), "Еда: " + (int.Parse(even.PropertyName) / 10.0) + " %");
        }

        /// <summary>
        /// Получить значение настроения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="even"></param>
        private void GetValue_Mood(object sender, PropertyChangedEventArgs even)
        {
            ToolTipFoodText(progressBarMood, toolTipMood, int.Parse(even.PropertyName), "Настроение: " + (int.Parse(even.PropertyName) / 10.0) + " %");
        }

        /// <summary>
        /// Получить значение здоровья
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="even"></param>
        private void GetValue_Health(object sender, PropertyChangedEventArgs even)
        {
            ToolTipFoodText(progressBarHealth, toolTipHealth, int.Parse(even.PropertyName), "Здоровье: " + (int.Parse(even.PropertyName) / 10.0) + " %");
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

        /// <summary>
        /// в 
        /// </summary>
        /// <param name="progressBarEx"></param>
        /// <param name="toolTip"></param>
        /// <param name="value"></param>
        /// <param name="text"></param>
        private void ToolTipFoodText(ProgressBarEx progressBarEx, ToolTip toolTip, int value, string text)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => progressBarEx.Value = value));
                Invoke(new Action(() => toolTip.SetToolTip(progressBarEx, text)));
            }
            else
            {
                progressBarEx.Value = value;
                toolTip.SetToolTip(progressBarEx, text);
            }
        }
    }

    public class ProgressBarEx : ProgressBar
    {
        public ProgressBarEx()
        {
            SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            // None... Helps control the flicker.
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            const int inset = 2; // A single inset value to control teh sizing of the inner rect.

            using (Image offscreenImage = new Bitmap(this.Width, this.Height))
            {
                using (Graphics offscreen = Graphics.FromImage(offscreenImage))
                {
                    Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

                    if (ProgressBarRenderer.IsSupported)
                        ProgressBarRenderer.DrawHorizontalBar(offscreen, rect);

                    rect.Inflate(new Size(-inset, -inset)); // Deflate inner rect.
                    rect.Width = (int)(rect.Width * ((double)Value / Maximum));
                    if (rect.Width == 0) rect.Width = 1; // Can't draw rec with width of 0.

                    LinearGradientBrush brush = new LinearGradientBrush(rect, BackColor, ForeColor, LinearGradientMode.Vertical);
                    offscreen.FillRectangle(brush, inset, inset, rect.Width, rect.Height);

                    e.Graphics.DrawImage(offscreenImage, 0, 0);
                    offscreenImage.Dispose();
                }
            }
        }
    }

    //public class ProgressBarEx : ProgressBar
    //{
    //    public ProgressBarEx()
    //    {
    //        SetStyle(ControlStyles.UserPaint, true);
    //    }

    //    protected override void OnPaint(PaintEventArgs e)
    //    {
    //        LinearGradientBrush brush = null;
    //        Rectangle rec = new Rectangle(0, 0, this.Width, this.Height);

    //        double scaleFactor = (((double)Value - (double)Minimum) / ((double)Maximum - (double)Minimum));

    //        if (scaleFactor < 0.04)
    //        {
    //            scaleFactor = 0.01;
    //        }

    //        if (ProgressBarRenderer.IsSupported)
    //            ProgressBarRenderer.DrawHorizontalBar(e.Graphics, rec);

    //        rec.Width = (int)(rec.Width * scaleFactor) - 4;
    //        rec.Height -= 4;
    //        brush = new LinearGradientBrush(rec, this.ForeColor, this.BackColor, LinearGradientMode.Vertical);
    //        e.Graphics.FillRectangle(brush, 2, 2, rec.Width, rec.Height);
    //    }
    //}
}
