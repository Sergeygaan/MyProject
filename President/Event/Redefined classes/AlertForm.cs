using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_Event
{
    public partial class AlertForm : Form
    {
        public AlertForm(string mainText, int size = 10)
        {
            InitializeComponent();

            buttonOk.BringToFront();

            MainText.SelectionFont = new Font("Tahoma", size, FontStyle.Regular);
            MainText.AppendText(mainText + "\r\n");
            MainText.ScrollToCaret();
            MainText.SelectAll();
            MainText.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void AlertForm_Load(object sender, EventArgs e)
        {
            if (Owner != null)
            {
                Location = new Point(Owner.Location.X + Owner.Width / 2 - Width / 2, Owner.Location.Y + Owner.Height / 2 - Height / 2);
            }
        }
    }
}
