using Module_GameTime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_Work
{
    public partial class Demand_Work : Form
    {
        public Demand_Work(string mode)
        {
            InitializeComponent();

            demandParam.StartParam(this, mode);
        }
    }
}
