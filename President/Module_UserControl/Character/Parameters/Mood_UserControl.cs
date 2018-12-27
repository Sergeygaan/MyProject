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
    public partial class Mood_UserControl : UserControl
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

        public Mood_UserControl()
        {
            InitializeComponent();

            GameCharacter.PropertyChangedMood += new PropertyChangedEventHandler(GetValue_Food);

            ToolTipFoodText(progressBar, toolTip, progressBar.Value, "Настроение: " + (progressBar.Value / 10.0) + " %");

        }

        /// <summary>
        /// Получить значение еды
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="even"></param>
        private void GetValue_Food(object sender, PropertyChangedEventArgs even)
        {
            ToolTipFoodText(progressBar, toolTip, int.Parse(even.PropertyName), "Настроение: " + (int.Parse(even.PropertyName) / 10.0) + " %");
        }
    }
}
