using Module_Character;
using Module_Event;
using Module_GameTime;
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
        /// Конструктор класса
        /// </summary>
        public Module_Work_Form()
        {
            InitializeComponent();

            //Подписка на событие раз в пол года
            //GameTime.PropertyChangedHalfYear += new PropertyChangedEventHandler(GetValue_ImplementationPlan);

            //Подписка на события "Новый день" для начисления зарплаты
            GameTime.PropertyChangedNewDay += new PropertyChangedEventHandler(GetValue_Everyday);

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

        /// <summary>
        /// Генератор рандома
        /// </summary>
        private Random random = new Random();

        /// <summary>
        /// Текущая работа
        /// </summary>
        private FinalJob _finalJob;

        public delegate void MyDelegateWork(FinalJob finalJob);

        /// <summary>
        /// Открыть форму "Найти работу"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFindJob_Click(object sender, EventArgs e)
        {
            Find_Job find_Job = new Find_Job(_professions, new MyDelegateWork(MyWorkFunc));
            find_Job.ShowDialog();
        }

        #region Начисление зарплаты

        /// <summary>
        /// Начисление зарплаты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="even"></param>
        private void GetValue_Everyday(object sender, PropertyChangedEventArgs even)
        {
            if (_finalJob != null)
            {
                _finalJob.WorkPlan += trackBarQualityWork.Value * 10;
                labelWorkPlan.Text = "Выполнение плана: " + _finalJob.WorkPlan + " %";

                ReducingNeeds_Work();

                GameCharacter.Set("Money", _finalJob.Salary);

                numberMonthsWorked += 1;

                if (numberMonthsWorked >=6)
                {
                    GetValue_ImplementationPlan();

                    numberMonthsWorked = 0;
                }
            }
        }

        #endregion
        
        /// <summary>
        /// Количество отработанных месяцев. 
        /// Нужно для начисления премии.
        /// Сбрасываетс при увольнении
        /// </summary>
        private int numberMonthsWorked = 0;

        #region События происходящие раз в пол года "Получение премии"

        /// <summary>
        /// Событие происходящее раз в пол года
        /// Проверка выполнения плана
        /// </summary>
        private void GetValue_ImplementationPlan()
        {
            if (_finalJob.Plan <= _finalJob.WorkPlan)
            {
                GameCharacter.Set("Money", _finalJob.Salary * 2);

                _finalJob.WorkPlan = 0;
                TextOutput(labelWorkPlan, "Выполнение плана: 0%");

                MessageBoxEx.Show("Вы выполнили план. В качестве премии вам начислили " + (_finalJob.Salary * 2).ToString() + " $");
            }
            else
            {
                MessageBoxEx.Show("Вы не выполнили план");
            }
        }

        #endregion


        /// <summary>
        /// Устроиться на работу
        /// </summary>
        /// <param name="finalJob">Работа</param>
        public void MyWorkFunc(FinalJob finalJob)
        {
            _finalJob = finalJob;

            buttonQuit.Enabled = true;
            buttonFindJob.Enabled = false;

            CurrentWork();

            Income_AddWork(_finalJob.Salary);
        }

        /// <summary>
        /// Уволиться с работы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuitWork_Click(object sender, EventArgs e)
        {
            if (_finalJob != null)
            {
                Income_AddWork(-_finalJob.Salary);

                _finalJob = null;

                buttonQuit.Enabled = false;
                buttonFindJob.Enabled = true;

                CurrentWork();

                numberMonthsWorked = 0;
            }
        }

        /// <summary>
        /// Список всех профессий
        /// </summary>
        private List<IProfession> _professions;

        /// <summary>
        /// Вывод информации о текущей работе
        /// </summary>
        private void CurrentWork()
        {
            if (_finalJob != null)
            {
                TextOutput(labelProfessionName, "Профессия: " + _finalJob.ProfessionName);
                TextOutput(labelSalary, "Оклад: " + _finalJob.Salary + " $");
              
                TextOutput(labelPlan, "План: " + _finalJob.Plan + " %");
                TextOutput(labelWorkPlan, "Выполнение плана: " + _finalJob.WorkPlan + " %");
            }
            else
            {
                TextOutput(labelProfessionName, "Профессия: Безработный");
                TextOutput(labelSalary, "Оклад: 0$");
               
                TextOutput(labelPlan, "План: 0%");
                TextOutput(labelWorkPlan, "Выполнение плана: 0%");
            }
        }

        /// <summary>
        /// Метод для вывода текста на форму из любого потока
        /// </summary>
        /// <param name="currentLabel">Имя label</param>
        /// <param name="text">Текст для вывода</param>
        private void TextOutput(Label currentLabel, string text)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => currentLabel.Text = text));
            }
            else
            {
                currentLabel.Text = text;
            }
        }

        /// <summary>
        /// Значение качества работы
        /// </summary>
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
        /// Уменьшение параметров персонажа после работы
        /// </summary>
        private void ReducingNeeds_Work()
        {
            double qualityWork = (trackBarQualityWork.Value * 10 ) / 100.0;

            int randomFood = (int)(random.Next(10, 25) * qualityWork);
            int randomMood = (int)(random.Next(10, 25) * qualityWork);
            int randomHealth = (int)(random.Next(10, 25) * qualityWork);

            GameCharacter.ReducingNeeds(randomFood, randomMood, randomHealth);
        }
    }
}
