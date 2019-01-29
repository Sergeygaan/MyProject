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
        public DemandProfessions(string mode)
        {
            InitializeComponent();

            switch(mode)
            {
                case "work":

                    Text = "Работа";
                    LoadListDemand(Demand.ListProfessions());

                    break;

                case "small":

                    Text = "Малый бизнес";
                    LoadListDemand(Demand.ListSmallBusiness());

                    break;

                case "medium":

                    Text = "Средний бизнес";
                    LoadListDemand(Demand.ListMediumBusiness());

                    break;

                case "big":

                    Text = "Крупный бизнес";
                    LoadListDemand(Demand.ListBigBusiness());

                    break;
            }
        }

        private void LoadListDemand(List<DemandProfessionsClass> list)
        {
            foreach(var currentDemandProfessions in list)
            {
                ListViewItem item = new ListViewItem();

                //Заполнение списка;
                item.Text = currentDemandProfessions.IndustryName;
                item.SubItems.Add(currentDemandProfessions.PercentageDemand.ToString() + " %");

                //item.BackColor = Color.AliceBlue;

                ColorItem(item, currentDemandProfessions.PercentageDemand);

                listDemand.Items.Add(item);
            }
        }

        private void ColorItem(ListViewItem item, int value)
        {
            if (Enumerable.Range(-100, 50).Contains(value))
            {
                item.BackColor = Color.Tomato;

                return;
            }

            if (Enumerable.Range(-50, 40).Contains(value))
            {
                item.BackColor = Color.Orange;

                return;
            }

            if (Enumerable.Range(-10, 21).Contains(value))
            {
                item.BackColor = Color.AliceBlue;

                return;
            }

            if (Enumerable.Range(10, 40).Contains(value))
            {
                item.BackColor = Color.LightGreen;

                return;
            }

            if (Enumerable.Range(50, 50).Contains(value))
            {
                item.BackColor = Color.Green;

                return;
            }

        }

        private void listDemand_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listDemand.Columns[e.ColumnIndex].Width;
        }
    }
}
