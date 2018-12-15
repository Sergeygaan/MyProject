﻿using Module_Character;
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
    public partial class Module_Work_Form : Form
    {
        /// <summary>
        /// Генератор рандома
        /// </summary>
        private Random random = new Random();

        private FinalJob _finalJob;

        public delegate void MyDelegateWork(FinalJob finalJob);

        public void MyWorkFunc(FinalJob finalJob)
        {
            _finalJob = finalJob;

            buttonQuit.Enabled = true;
            buttonGoWork.Enabled = true;
            buttonFindJob.Enabled = false;

            CurrentWork();

            Income_AddWork(_finalJob.Salary);
        }

        private List<IProfession> _professions;

        public Module_Work_Form()
        {
            InitializeComponent();

            CreateListWork();
        }

        public void CreateListWork()
        {
            _professions = new List<IProfession>
            {
                new Profession_Agriculture(),
                new Profession_Creative(),
                new Profession_Economic(),
                new Profession_Food(),
                new Profession_InformaticsAndCommunication(),
                new Profession_Legal(),
                new Profession_Medical(),
                new Profession_Military(),
                new Profession_Pedagogical(),
                new Profession_PublishingAndTypography(),
                new Profession_Scientific(),
                new Profession_ServiceAndMaintenance(),
                new Profession_Sports(),
                new Profession_Technical(),
                new Profession_Transport(),
            };
        }

        private void ButtonFindJob_Click(object sender, EventArgs e)
        {
            Find_Job find_Job = new Find_Job(_professions, new MyDelegateWork(MyWorkFunc));
            find_Job.ShowDialog();
        }

        private void QuitWork_Click(object sender, EventArgs e)
        {
            if(_finalJob != null)
            {
                Income_AddWork(-_finalJob.Salary);

                _finalJob = null;

                buttonQuit.Enabled = false;
                buttonGoWork.Enabled = false;
                buttonFindJob.Enabled = true;

                CurrentWork();
            }
        }

        private void CurrentWork()
        {
            if (_finalJob != null)
            {
                labelProfessionName.Text = "Профессия: " + _finalJob.ProfessionName;
                labelSalary.Text = "Оклад: " + _finalJob.Salary + " $";
                labelWorkTime.Text = "Рабочее время: " + _finalJob.StartWorkingTime + ":00-" + (_finalJob.StartWorkingTime + _finalJob.WorkingTime) + ":00";

                labelPlan.Text = "План: " + _finalJob.Plan + " %";
                labelWorkPlan.Text = "Выполнение плана: " + _finalJob.WorkPlan + " %";
            }
            else
            {
                labelProfessionName.Text = "Профессия: Безработный";
                labelSalary.Text = "Оклад: 0$";
                labelWorkTime.Text = "Рабочее время: ";

                labelPlan.Text = "План: 0%";
                labelWorkPlan.Text = "Выполнение плана: 0%";
            }


        }

        int _valueTableWork = 0;

        /// <summary>
        /// Масштабирование прокрутки
        /// </summary>
        private void trackBarQualityWork_ValueChanged(object sender, EventArgs e)
        {
            _valueTableWork = trackBarQualityWork.Value * 10;
            labelTableWork.Text = _valueTableWork + " %";
        }

        /// <summary>
        /// Добавление дохода с работы
        /// </summary>
        private void Income_AddWork(int income)
        {
            GameCharacter.Income += income;
        }

        /// <summary>
        /// Пойти на работу
        /// </summary>
        private void GoWork_Click(object sender, EventArgs e)
        {
            _finalJob.WorkPlan += trackBarQualityWork.Value * 10;
            labelWorkPlan.Text = "Выполнение плана: " + _finalJob.WorkPlan + " %";

            ReducingNeeds_Work();
        }

        private void ReducingNeeds_Work()
        {
            double qualityWork = (trackBarQualityWork.Value * 10 ) / 100.0;

            int randomFood = (int)(random.Next(5, 20) * qualityWork);
            int randomMood = (int)(random.Next(5, 20) * qualityWork);
            int randomHealth = (int)(random.Next(5, 20) * qualityWork);

            GameCharacter.ReducingNeeds(randomFood, randomMood, randomHealth);
        }
    }
}
