﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Module_GameTime;
using Module_Character;

namespace Module_UserControl
{
    public partial class GameTimer_UserControl : UserControl
    {
        public GameTimer_UserControl()
        {
            InitializeComponent();

            Game_Time.PropertyChangedMinutesAndHour += new PropertyChangedEventHandler(GetValue_MinuteAndHour);
            Game_Time.PropertyChangedMonthAndYear += new PropertyChangedEventHandler(GetValue_MonthAndYear);
        }

        /// <summary>
        /// Получить значение минут и часов
        /// </summary>
        private void GetValue_MinuteAndHour(object sender, PropertyChangedEventArgs even)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => labelMinuteAndHour.Text = even.PropertyName));
            }
            else
            {
                labelMinuteAndHour.Text = even.PropertyName;
            }
        }

        /// <summary>
        /// Получить значение месяца и года
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="even"></param>
        private void GetValue_MonthAndYear(object sender, PropertyChangedEventArgs even)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => labelMouthAndYear.Text = even.PropertyName));
            }
            else
            {
                labelMouthAndYear.Text = even.PropertyName;
            }

            GC.Collect();
        }
    }
}
