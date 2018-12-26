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
        /// <summary>
        /// Получение значения из разных потоках
        /// </summary>
        /// <returns></returns>
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

            _valueTableWork = 50;
        }

        /// <summary>
        /// Значение качества параметра
        /// </summary>
        int _valueTableWork;

        /// <summary>
        /// События изменения значения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBarQualityStudy_ValueChanged(object sender, EventArgs e)
        {
            _valueTableWork = TrackBar_Flow() * 10;
            labelTable.Text = _valueTableWork + " %";

            ValueChanged = "true";
        }

        public int ReturnValue()
        {
            return _valueTableWork;
        }

        #region Событие изменения значения 

        private string _valueChanged = "false";

        public void OnPropertyChangedValueChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedValueChanged?.Invoke(null, e);
        }

        public void OnPropertyChangedValueChanged(string propertyNameValueChanged)
        {
            OnPropertyChangedValueChanged(new PropertyChangedEventArgs(propertyNameValueChanged));
        }

        /// <summary>
        /// Переменная, которая отвечает за изменения дня. Подписываться на нее
        /// </summary>
        public string ValueChanged
        {
            get { return _valueChanged; }
            set
            {
                _valueChanged = value;
                OnPropertyChangedValueChanged(_valueChanged);
            }
        }

        public event PropertyChangedEventHandler PropertyChangedValueChanged;

        #endregion
    }
}
