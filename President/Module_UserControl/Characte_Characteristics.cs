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
    public partial class Characte_Characteristics : UserControl
    {
        public Characte_Characteristics()
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
        }

        #region Подписка на свойства

        //Получить значение денег
        private void GetValue_Money(object sender, PropertyChangedEventArgs even)
        {
            labelMoney.Text = "Деньги: " + even.PropertyName + " $";
        }

        //Получить значение дохода
        private void GetValue_Income(object sender, PropertyChangedEventArgs even)
        {
            labelIncome.Text = "Доход: " + even.PropertyName + " $";
        }

        //Получить значение налога
        private void GetValue_Tax(object sender, PropertyChangedEventArgs even)
        {
            labelTax.Text = "Налоги: " + even.PropertyName + " $";
        }

        //Получить значение еды
        private void GetValue_Food(object sender, PropertyChangedEventArgs even)
        {
            progressBarFood.Value = int.Parse(even.PropertyName);

            toolTipFood.SetToolTip(progressBarFood, "Еда: " + progressBarFood.Value + " %");
            //labelFood.Text = "Еда: " + even.PropertyName + " %";
        }

        //Получить значение настроения
        private void GetValue_Mood(object sender, PropertyChangedEventArgs even)
        {
            progressBarMood.Value = int.Parse(even.PropertyName);

            toolTipMood.SetToolTip(progressBarMood, "Настроение: " + progressBarMood.Value + " %");
            //labelMood.Text = "Здоровье: " + even.PropertyName + " %";
        }

        //Получить значение здоровья
        private void GetValue_Health(object sender, PropertyChangedEventArgs even)
        {
            progressBarHealth.Value = int.Parse(even.PropertyName);

            toolTipHealth.SetToolTip(progressBarHealth, "Здоровье: " + progressBarHealth.Value + " %");
            //labelHealth.Text = "Настроение: " + even.PropertyName + " %";
        }

        //Получить значение физической силы
        private void GetValue_PhysicalDevelopment(object sender, PropertyChangedEventArgs even)
        {
            labelPhysicalDevelopment.Text = "Физическая сила: " + even.PropertyName;
        }

        //Получить значение обаяния
        private void GetValue_Charm(object sender, PropertyChangedEventArgs even)
        {
            labelCharm.Text = "Обаяние: " + even.PropertyName;
        }

        //Получить значение интеллекта
        private void GetValue_Intelligence(object sender, PropertyChangedEventArgs even)
        {
            labelIntelligence.Text = "Интеллект: " + even.PropertyName;
        }

        #endregion
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

            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, rec);

            rec.Width = (int)((rec.Width * scaleFactor) - 4);
            rec.Height -= 4;
            brush = new LinearGradientBrush(rec, this.ForeColor, this.BackColor, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(brush, 2, 2, rec.Width, rec.Height);
        }
    }
}
