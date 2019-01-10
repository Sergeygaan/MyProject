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

namespace Module_UserControl
{
    public partial class DemandProfessions : Form
    {
        public DemandProfessions()
        {
            InitializeComponent();

            LoadListDemand();
        }

        private void LoadListDemand()
        {
            foreach(var currentDemandProfessions in Demand.ReturnDemandProfessions())
            {
                ListViewItem item = new ListViewItem();

                //Заполнение списка;
                item.Text = currentDemandProfessions.IndustryName;
                item.SubItems.Add(currentDemandProfessions.PercentageDemand.ToString() + " %");

                item.BackColor = Color.AliceBlue;

                listDemand.Items.Add(item);
            }
        }

        private void listDemand_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listDemand.Columns[e.ColumnIndex].Width;
        }
    }
}
