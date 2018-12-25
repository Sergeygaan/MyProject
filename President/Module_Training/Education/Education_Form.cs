using Module_Character;
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

            Close();
        }

        private void buttonBaccalaureate_Click(object sender, EventArgs e)
        {
            _myStudy(new CurrentStudy("Балакавриат", 48, 35, 2880));

            Close();
        }

        private void buttonMaster_Click(object sender, EventArgs e)
        {
            _myStudy(new CurrentStudy("Магистратура", 24, 60, 1680));

            Close();
        }

        private void buttonGraduateSchool_Click(object sender, EventArgs e)
        {
            _myStudy(new CurrentStudy("Аспирантура", 48, 90, 3840));

            Close();
        }

        private void buttonPhD_Click(object sender, EventArgs e)
        {
            _myStudy(new CurrentStudy("Доктор наук", 60, 100, 5100));

            Close();
        }

        private void LevelEducation(string level)
        {
            switch(level)
            {
                case "11 классов":

                    BlockButton(buttonCollege, true, "Откроет обучение в \"Бакалавриате\"");
                    BlockButton(buttonBaccalaureate, false, "");
                    BlockButton(buttonMaster, false, "");
                    BlockButton(buttonGraduateSchool, false, "");
                    BlockButton(buttonPhD, false, "");

                    break;

                case "Техникум":

                    BlockButton(buttonCollege, false, "");
                    BlockButton(buttonBaccalaureate, true, "Откроет обучение в \"Магистратуре\"");
                    BlockButton(buttonMaster, false, "");
                    BlockButton(buttonGraduateSchool, false, "");
                    BlockButton(buttonPhD, false, "");

                    break;

                case "Балакавриат":

                    BlockButton(buttonCollege, false, "");
                    BlockButton(buttonBaccalaureate, false, "");
                    BlockButton(buttonMaster, true, "Откроет обучение в \"Аспирантуре\"");
                    BlockButton(buttonGraduateSchool, false, "");
                    BlockButton(buttonPhD, false, "");

                    break;

                case "Магистратура":

                    BlockButton(buttonCollege, false, "");
                    BlockButton(buttonBaccalaureate, false, "");
                    BlockButton(buttonMaster, false, "");
                    BlockButton(buttonGraduateSchool, true, "Откроет степень \"Доктор наук\"");
                    BlockButton(buttonPhD, false, "");

                    break;

                case "Аспирантура":

                    BlockButton(buttonCollege, false, "");
                    BlockButton(buttonBaccalaureate, false, "");
                    BlockButton(buttonMaster, false, "");
                    BlockButton(buttonGraduateSchool, false, "");
                    BlockButton(buttonPhD, true, "Финальная стадия обучения");

                    break;

                case "Доктор наук":

                    BlockButton(buttonCollege, false, "");
                    BlockButton(buttonBaccalaureate, false, "");
                    BlockButton(buttonMaster, false, "");
                    BlockButton(buttonGraduateSchool, false, "");
                    BlockButton(buttonPhD, false, "");

                    break;
            }
        }


        private void BlockButton(Button button, bool flag, string text)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => {

                    button.Enabled = flag;

                    if (text != "")
                    {
                        //Подсказка при наведении мышка на кнопку
                        ToolTip toolTip = new ToolTip();
                        toolTip.SetToolTip(button, text);
                    }

                }));
            }
            else
            {
                button.Enabled = flag;

                if (text != "")
                {
                    //Подсказка при наведении мышка на кнопку
                    ToolTip toolTip = new ToolTip();
                    toolTip.SetToolTip(button, text);
                }
            }
        }

        private void Education_Form_Load(object sender, EventArgs e)
        {
            LevelEducation(GameCharacter.Study);
        }
    }
}
