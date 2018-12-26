using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_UserControl
{
    public partial class Effort_UserControl : UserControl
    {
        private int TrackBar_Flow()
        {
            int value = 0;

            if (InvokeRequired)
            {
                Invoke(new Action(() => value = trackBarQuality.Value));
            }
            else
            {
                value = trackBarQuality.Value;
            }

            return value;
        }

        public Effort_UserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Значение качества параметра
        /// </summary>
        int _valueTableWork = 0;

        private void trackBarQualityStudy_ValueChanged(object sender, EventArgs e)
        {
            _valueTableWork = TrackBar_Flow() * 10;
            labelTable.Text = _valueTableWork + " %";
        }

        public int ReturnValue()
        {
            return 0;
        }
    }
}
