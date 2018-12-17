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

            ToDoList.PropertyChangedChangeToDoList += new PropertyChangedEventHandler(GetValue_NewDay);
        }

        /// <summary>
        /// Получить значение минут и часов и вывести их на таймер
        /// </summary>
        private void GetValue_NewDay(object sender, PropertyChangedEventArgs even)
        {
            //labelMinuteAndHour.Text = even.PropertyName;

            if (InvokeRequired)
            {
                Invoke(new Action(() => listBoxActionList.Items.Clear()));
            }
            else
            {
                listBoxActionList.Items.Clear();
            }

            foreach (var currentAction in ToDoList.ReturnActionList())
            {
                if (currentAction.ActionActivity)
                {
                    string stroka = currentAction.ActionName + ": " + currentAction.FormatTime;

                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => listBoxActionList.Items.Add(stroka)));
                    }
                    else
                    {
                        listBoxActionList.Items.Add(stroka);
                    }
                }
            }

            GC.Collect();
        }
    }
}
