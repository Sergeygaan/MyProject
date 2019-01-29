using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Module_GameTime;

namespace Module_UserControl
{
    public partial class DemandParam : UserControl
    {
        public DemandParam()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Инициализация параметров для отображения
        /// </summary>
        /// <param name="mode"></param>
        public void StartParam(Form form, string mode)
        {
            switch (mode)
            {
                case "work":

                    form.Text = "Работа";
                    LoadListDemand(Demand.ListProfessions());

                    break;

                case "small":

                    form.Text = "Малый бизнес";
                    LoadListDemand(Demand.ListSmallBusiness());

                    break;

                case "medium":

                    form.Text = "Средний бизнес";
                    LoadListDemand(Demand.ListMediumBusiness());

                    break;

                case "big":

                    form.Text = "Крупный бизнес";
                    LoadListDemand(Demand.ListBigBusiness());

                    break;
            }
        }

        /// <summary>
        /// Вывод необходимого списка
        /// </summary>
        /// <param name="list">Список параметров</param>
        private void LoadListDemand(List<DemandProfessionsClass> list)
        {
            foreach (var currentDemandProfessions in list)
            {
                ListViewItem item = new ListViewItem();

                //Заполнение списка;
                item.Text = currentDemandProfessions.IndustryName;
                item.SubItems.Add(currentDemandProfessions.PercentageDemand.ToString() + " %");

                ColorItem(item, currentDemandProfessions.PercentageDemand);

                listDemand.Items.Add(item);
            }
        }

        /// <summary>
        /// Определение цвета текста
        /// </summary>
        /// <param name="item"></param>
        /// <param name="value"></param>
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

        /// <summary>
        /// Запрет изменения размера стобцов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listDemand_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listDemand.Columns[e.ColumnIndex].Width;
        }
    }
}
