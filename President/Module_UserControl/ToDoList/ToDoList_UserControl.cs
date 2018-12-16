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
    public partial class ToDoList_UserControl : UserControl
    {
        public ToDoList_UserControl()
        {
            InitializeComponent();

            //GameTime.PropertyChangedNewDay += new PropertyChangedEventHandler(GetValue_NewDay);
        }

        /// <summary>
        /// Получить значение минут и часов
        /// </summary>
        private void GetValue_NewDay(object sender, PropertyChangedEventArgs even)
        {
            //labelMinuteAndHour.Text = even.PropertyName;

            var ActionList = ToDoList.ReturnActionList();

            foreach (var currentAction in ActionList)
            {
                string stroka = currentAction.ActionName + ": " + currentAction.FormatTime;

                listBoxActionList.Items.Add(stroka);
            }

            GC.Collect();
        }
    }
}
