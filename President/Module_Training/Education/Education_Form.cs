using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Module_Training.Module_Training_Form;

namespace Module_Training
{
    public partial class Education_Form : Form
    {
        /// <summary>
        /// Метод для устройства на работу
        /// </summary>
        private MyDelegateStudy _myStudy;

        public Education_Form(MyDelegateStudy myStudy)
        {
            InitializeComponent();

            _myStudy = myStudy;
        }

        private void buttonCollege_Click(object sender, EventArgs e)
        {
            _myStudy(new CurrentStudy("Техникум", 36, 15, 1800));
        }

        private void buttonBaccalaureate_Click(object sender, EventArgs e)
        {
            _myStudy(new CurrentStudy("Балакавриат", 48, 35, 2880));
        }

        private void buttonMaster_Click(object sender, EventArgs e)
        {
            _myStudy(new CurrentStudy("Магистратура", 24, 60, 1680));
        }

        private void buttonGraduateSchool_Click(object sender, EventArgs e)
        {
            _myStudy(new CurrentStudy("Аспирантура", 48, 90, 3840));
        }

        private void buttonPhD_Click(object sender, EventArgs e)
        {
            _myStudy(new CurrentStudy("Доктор наук", 60, 100, 5100));
        }
    }
}
