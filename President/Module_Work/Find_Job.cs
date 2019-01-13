using Module_Character;
using Module_Event;
using Module_GameTime;
using Module_UserControl;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        private List<int> _listIgnoreWork;

        private Random rnd = new Random();

        /// <summary>
        /// Метод для устройства на работу
        /// </summary>
        private MyDelegateWork _myWork;

        /// <summary>
        /// Переменная в которой содержится индекс выбранной професии
        /// </summary>
        private int _selectIndex = -1;

        public Find_Job(List<IProfession> professions, MyDelegateWork myWork)
        {
            InitializeComponent();

            _professions = professions;
            _finalJobs = new List<FinalJob>();
            _listIgnoreWork = new List<int>();

            _myWork = myWork;
        }

        /// <summary>
        /// Искать работу на улице
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Outside_Click(object sender, EventArgs e)
        {
            ReducingNeeds_Job(30);

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

                ReducingNeeds_Job(15);

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
            if (_selectIndex != -1)
            {
                //Проверка того что професии нет в списке игнорированных 
                foreach (var currentIndex in _listIgnoreWork)
                {
                    if(currentIndex == _selectIndex)
                    {
                        return;
                    }
                }

                _myWork(_finalJobs[_selectIndex]);

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
            int indexCategory;
            int indexWork;
            Basic_Work basic_Work;

            for (int indexSteps = 0; indexSteps < numberSteps; indexSteps++)
            {
                basic_Work = null;

                indexCategory = rnd.Next(0, _professions.Count);

                indexWork = rnd.Next(0, _professions[indexCategory].ListProfession().Count);

                basic_Work = _professions[indexCategory].ListProfession()[indexWork];

                //получение названия индустрии
                string industryName = _professions[indexCategory].ProfessionName();

                //Повышающие коэфицент для выбранной категории с учетом обучения
                int coefficient = GameCharacter.ReturnQualifications(indexCategory);

                if (basic_Work != null)
                {
                    SalaryDetermination(indexCategory, basic_Work, industryName, coefficient);
                }
            }
        }

        private void SalaryDetermination(int indexCategory, Basic_Work basic_Work, string industryName, int coefficient)
        {
            //Начальный оклад
            int salary_Start = basic_Work.Salary + rnd.Next(-(int)(basic_Work.Salary * 0.35), (int)(basic_Work.Salary * 0.35));

            //Повышение квалификации
            int salary_Coefficient = (int)(salary_Start * coefficient / 100.0);

            //Восстребовательность
            int salary_Demand = (int)(salary_Start * Demand.ReturnQualifications(industryName) / 100.0);

            //Расчет финальной зарплаты
            int salary_End = salary_Start + salary_Coefficient + salary_Demand;

            //Расчет плана
            int randomWorkPlan = rnd.Next(450, 600);

            //Создание класса текущей работы
            _finalJobs.Add(new FinalJob(indexCategory, industryName, basic_Work.ProfessionName, salary_Start, salary_Coefficient, salary_Demand, salary_End, randomWorkPlan, 
                                        basic_Work.Req_Intelligence, basic_Work.Req_Charm, basic_Work.Req_PhysicalDevelopment));
        }

        /// <summary>
        /// Отображение списка работ
        /// </summary>
        private void ShowWorkList()
        {
            foreach (var currentJobs in _finalJobs)
            {
                Application.DoEvents();

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

                ListViewItem item = new ListViewItem();
                //Заполнение списка;
                item.Text = currentJobs.IndustryName;
                item.SubItems.Add(currentJobs.ProfessionName);
                item.SubItems.Add(currentJobs.Salary_Start.ToString() + " $");
                item.SubItems.Add(currentJobs.Salary_Coefficient.ToString() + " $");
                item.SubItems.Add(currentJobs.Salary_Demand.ToString() + " $");
                item.SubItems.Add(currentJobs.Plan.ToString() + " %");

                if (!flagCheck)
                {
                    _listIgnoreWork.Add(listWork.Items.Count);

                    item.ToolTipText = textParam;
                    item.BackColor = Color.LightCoral;
                }
                else
                {
                    item.BackColor = Color.AliceBlue;
                }

                listWork.Items.Add(item);
            }
        }

        /// <summary>
        /// Очистить список работ
        /// </summary>
        private void ClearWorkList()
        {
            _finalJobs.Clear();

            listWork.Items.Clear();

            _listIgnoreWork.Clear();

            _selectIndex = -1;

            GC.Collect();
        }

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

        #region ListView

        /// <summary>
        /// Метод для выбора элемента из списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listWork_MouseUp(object sender, MouseEventArgs e)
        {
            for (int itemIndex = 0; itemIndex < listWork.Items.Count; itemIndex++)
            {
                ListViewItem item = listWork.Items[itemIndex];
                Rectangle itemRect = item.GetBounds(ItemBoundsPortion.Label);
                if (itemRect.Contains(e.Location))
                {
                    _selectIndex = itemIndex;

                    break;
                }
            }
        }

        /// <summary>
        /// Метод для блокировки изменения ширины столбца
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listWork_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listWork.Columns[e.ColumnIndex].Width;
        }

        #endregion

        /// <summary>
        /// Открытия окна востребовательнось профессий
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDemand_Click(object sender, EventArgs e)
        {
            DemandProfessions demandProfessionsForm = new DemandProfessions();
            demandProfessionsForm.ShowDialog();
        }
    }
}
