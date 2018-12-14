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
using static Module_Work.Module_Work_Form;

namespace Module_Work
{
    public partial class Find_Job : Form
    {
        private List<IProfession> _professions;
        private List<FinalJob> _finalJobs;

        private List<Tuple<int, string>> ListIgnoreWork;

        private Random rnd = new Random();

        private MyDelegateWork _myWork;

        public Find_Job(List<IProfession> professions, MyDelegateWork myWork)
        {
            InitializeComponent();

            _professions = professions;
            _finalJobs = new List<FinalJob>();
            ListIgnoreWork = new List<Tuple<int, string>>();

            _myWork = myWork;
        }

        private void Outside_Click(object sender, EventArgs e)
        {
            ClearWorkList();

            RandomDrawingWorks(3);

            ShowWorkList();
        }

        private void Newspaper_Click(object sender, EventArgs e)
        {
            ClearWorkList();

            RandomDrawingWorks(6);

            ShowWorkList();
        }

        private void Internet_Click(object sender, EventArgs e)
        {
            ClearWorkList();
     
            RandomDrawingWorks(9);

            ShowWorkList();
        }

        private void GetJob_Click(object sender, EventArgs e)
        {
            if (listBoxWork.SelectedIndex != -1)
            {
                _myWork(_finalJobs[listBoxWork.SelectedIndex]);

                Close();
            }
        }

        private void RandomDrawingWorks(int numberSteps)
        {
            int indexRegion;
            int indexWork;
            Basic_Work basic_Work;

            for (int indexSteps = 0; indexSteps < numberSteps; indexSteps++)
            {
                basic_Work = null;

                indexRegion = rnd.Next(0, _professions.Count);

                indexWork = rnd.Next(0, _professions[indexRegion].ListProfession().Count);

                basic_Work = _professions[indexRegion].ListProfession()[indexWork];

                if (basic_Work != null)
                {
                    SalaryDetermination(basic_Work);
                }
            }
        }

        private void SalaryDetermination(Basic_Work basic_Work)
        {
            int finalSalary = basic_Work.Salary + rnd.Next(-(int)(basic_Work.Salary * 0.25), (int)(basic_Work.Salary * 0.25));

            int randomWorkPlan = rnd.Next(450, 600);

            int finalWorkingTime = basic_Work.WorkingTime + rnd.Next(-2, 4);
            int startWorkingTime = rnd.Next(0, 23 - finalWorkingTime);

            _finalJobs.Add(new FinalJob(basic_Work.ProfessionName, finalSalary, randomWorkPlan, finalWorkingTime, startWorkingTime, basic_Work.IntelligenceRequirement));
        }

        private void ShowWorkList()
        {
            foreach (var currentJobs in _finalJobs)
            {
                string wortTime = " Рабочее время: " + currentJobs.StartWorkingTime + ":00 - " + (currentJobs.StartWorkingTime + currentJobs.WorkingTime) + ":00";
                listBoxWork.Items.Add(currentJobs.ProfessionName + " - " + currentJobs.Salary + " $ План: " + currentJobs.Plan + " %" + wortTime);

                if (currentJobs.IntelligenceRequirement > GameCharacter.Intelligence)
                {
                    listBoxWork.DisableItem(listBoxWork.Items.Count - 1);
                    ListIgnoreWork.Add(new Tuple<int, string>(listBoxWork.Items.Count - 1, "Нехватает параметра интеллект. Необходимо " + currentJobs.IntelligenceRequirement + " у вас " + GameCharacter.Intelligence));
                }
            }
        }

        private void ClearWorkList()
        {
            _finalJobs.Clear();
            listBoxWork.Items.Clear();
            ListIgnoreWork.Clear();

            GC.Collect();
        }

        #region Подсказка List

        int flagIndex = 0;

        private void listBoxWork_MouseMove(object sender, MouseEventArgs e)
        {
            int index = listBoxWork.IndexFromPoint(e.Location);

            if (CheckIndex(index))
            {
                foreach (var currentIgnorWork in ListIgnoreWork)
                {
                    if (currentIgnorWork.Item1 == index)
                    {
                        if ((toolTip.GetToolTip(listBoxWork) != currentIgnorWork.Item2) || (flagIndex != index))
                        {
                            toolTip.SetToolTip(listBoxWork, currentIgnorWork.Item2);

                            flagIndex = index;

                            break;
                        }
                    }
                }
            }
            else
            {
                toolTip.SetToolTip(listBoxWork, string.Empty);
            }
        }

        private bool CheckIndex(int index)
        {
            if (index != -1 && index < listBoxWork.Items.Count)
            {
                foreach (var currentIgnorWork in ListIgnoreWork)
                {
                    if (currentIgnorWork.Item1 == index)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        #endregion
    }
}
