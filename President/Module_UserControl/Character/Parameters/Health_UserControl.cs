﻿using System;
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
    public partial class Health_UserControl : UserControl
    {
        /// <summary>
        /// Отображение параметров в progressBar
        /// </summary>
        /// <param name="progressBarEx"></param>
        /// <param name="toolTip"></param>
        /// <param name="value"></param>
        /// <param name="text"></param>
        private void ToolTipFoodText(ProgressBar progressBarEx, ToolTip toolTip, int value, string text)
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

        public Health_UserControl()
        {
            InitializeComponent();

            ToolTipFoodText(progressBar, toolTip, GameCharacter.Health, "Здоровье: " + GameCharacter.Health + " %");

            GameCharacter.PropertyChangedHealth += new PropertyChangedEventHandler(GetValue_Health);
        }

        /// <summary>
        /// Получить значение здоровья
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="even"></param>
        private void GetValue_Health(object sender, PropertyChangedEventArgs even)
        {
            ToolTipFoodText(progressBar, toolTip, int.Parse(even.PropertyName), "Здоровье: " + (int.Parse(even.PropertyName) / 10.0) + " %");
        }
    }
}
