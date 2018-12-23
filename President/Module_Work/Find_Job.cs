using Module_Character;
using Module_Event;
using Module_GameTime;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Module_Work.Module_Work_Form;

namespace Module_Work
{
    public partial class Find_Job : Form
    {
        /// <summary>
        /// Список профессий
        /// </summary>
        private List<IProfession> _professions;

        /// <summary>
        /// Список случайно сгенерированных работ
        /// </summary>
        private List<FinalJob> _finalJobs;

        /// <summary>
        /// Список хранящий в себе текст если нехватает параметров для устройства на работу
        /// </summary>
        private List<Tuple<int, string>> ListIgnoreWork;

        private Random rnd = new Random();

        /// <summary>
        /// Метод для устройства на работу
        /// </summary>
        private MyDelegateWork _myWork;

        public Find_Job(List<IProfession> professions, MyDelegateWork myWork)
        {
            InitializeComponent();

            _professions = professions;
            _finalJobs = new List<FinalJob>();
            ListIgnoreWork = new List<Tuple<int, string>>();

            _myWork = myWork;
        }

        /// <summary>
        /// Искать работу на улице
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Outside_Click(object sender, EventArgs e)
        {
            ReducingNeeds_Job(4);

            ClearWorkList();

            RandomDrawingWorks(3);

            ShowWorkList();
        }

        /// <summary>
        /// Искать работу в газете
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Newspaper_Click(object sender, EventArgs e)
        {
            if (GameCharacter.Money >= 5)
            {
                GameCharacter.Set("Money", -5);

                ReducingNeeds_Job(2);

                ClearWorkList();

                RandomDrawingWorks(6);

                ShowWorkList();
            }
            else
            {
                TopMostMessageBox.Show("Недостаточно денег.", "Событие");
            }
        }

        /// <summary>
        /// Искать работу в интернете
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Internet_Click(object sender, EventArgs e)
        {
            ClearWorkList();
     
            RandomDrawingWorks(9);

            ShowWorkList();
        }

        /// <summary>
        /// Устроиться на работу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetJob_Click(object sender, EventArgs e)
        {
            if (listBoxWork.SelectedIndex != -1)
            {
                _myWork(_finalJobs[listBoxWork.SelectedIndex]);

                Close();
            }
            else
            {
                TopMostMessageBox.Show("Необходимо выбрать работу из списка.", "Событие");
            }
        }

        /// <summary>
        /// Генерация рандомных профессий
        /// </summary>
        /// <param name="numberSteps">Количество профессий</param>
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

                //получение названия индустрии
                string industryName = _professions[indexRegion].ProfessionName();

                if (basic_Work != null)
                {
                    SalaryDetermination(basic_Work, industryName);
                }
            }
        }

        private void SalaryDetermination(Basic_Work basic_Work, string industryName)
        {
            int finalSalary = basic_Work.Salary + rnd.Next(-(int)(basic_Work.Salary * 0.35), (int)(basic_Work.Salary * 0.35));

            int randomWorkPlan = rnd.Next(450, 600);

            _finalJobs.Add(new FinalJob(industryName, basic_Work.ProfessionName, finalSalary, randomWorkPlan, 
                                        basic_Work.Req_Intelligence, basic_Work.Req_Charm, basic_Work.Req_PhysicalDevelopment));
        }

        /// <summary>
        /// Отображение списка работ
        /// </summary>
        private void ShowWorkList()
        {
            foreach (var currentJobs in _finalJobs)
            {
                listBoxWork.Items.Add(currentJobs.IndustryName + " - " + currentJobs.ProfessionName + ": " + currentJobs.Salary + " $ План: " + currentJobs.Plan + " %");

                bool flagCheck = true;
                string textParam = "";

                if (currentJobs.Req_Intelligence > GameCharacter.Intelligence)
                {
                    flagCheck = false;

                    textParam += "Нехватает параметра \"Интеллект\". Необходимо " + currentJobs.Req_Intelligence + " у вас " + GameCharacter.Intelligence + "\n";
                }

                if (currentJobs.Req_Charm > GameCharacter.Charm)
                {
                    flagCheck = false;

                    textParam += "Нехватает параметра \"Обаяние\". Необходимо " + currentJobs.Req_Charm + " у вас " + GameCharacter.Charm + "\n";
                }

                if (currentJobs.Req_PhysicalDevelopment > GameCharacter.PhysicalDevelopment)
                {
                    flagCheck = false;

                    textParam += "Нехватает параметра \"Физическая сила\". Необходимо " + currentJobs.Req_PhysicalDevelopment + " у вас " + GameCharacter.PhysicalDevelopment + "\n";
                }

                if (!flagCheck)
                {
                    listBoxWork.DisableItem(listBoxWork.Items.Count - 1);
                    ListIgnoreWork.Add(new Tuple<int, string>(listBoxWork.Items.Count - 1, textParam));
                }
            }
        }

        /// <summary>
        /// Очистить список работ
        /// </summary>
        private void ClearWorkList()
        {
            _finalJobs.Clear();

            EnableItem();
            listBoxWork.Items.Clear();

            ListIgnoreWork.Clear();

            GC.Collect();
        }

        /// <summary>
        /// Снятие блокировки со списка
        /// </summary>
        private void EnableItem()
        {
            for (int index = 0; index < listBoxWork.Items.Count; index++)
            {
                listBoxWork.EnableItem(index);
            }
        }

        #region Подсказка List

        int flagIndex = 0;

        /// <summary>
        /// Вывод сообщения о нехватке параметров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Уменьшает характеристики персонажа
        /// </summary>
        /// <param name="fatigue">Максимальное количество уменьшения</param>
        private void ReducingNeeds_Job(int fatigue)
        {
            int randomFood = rnd.Next(0, fatigue);
            int randomMood = rnd.Next(0, fatigue);
            int randomHealth = rnd.Next(0, fatigue);
       
            GameCharacter.ReducingNeeds(randomFood, randomMood, randomHealth);
        }
    }
}
