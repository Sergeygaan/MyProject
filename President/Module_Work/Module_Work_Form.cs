using Module_Character;
using Module_Event;
using Module_GameTime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Module_Work
{
    public partial class Module_Work_Form : Form
    {
        #region Выбор вызова потока

        /// <summary>
        /// Метод для блокирования кнопок из разных потоков
        /// </summary>
        private void EnableButtom(Button button, bool flag)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => button.Enabled = flag));
            }
            else
            {
                button.Enabled = flag;
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

        private int TrackBar_Flow()
        {
            int value = 0;

            if (InvokeRequired)
            {
                Invoke(new Action(() => value = trackBarQualityWork.Value));
            }
            else
            {
                value = trackBarQualityWork.Value;
            }

            return value;
        }

        #endregion

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
        /// Генератор рандомных значений
        /// </summary>
        private Random random = new Random();

        /// <summary>
        /// Текущая работа
        /// </summary>
        private FinalJob _currentJob;

        public delegate void MyDelegateWork(FinalJob _currentJob);

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

        #region Конец месяца

        /// <summary>
        /// Начисление зарплаты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="even"></param>
        private void GetValue_Everyday(object sender, PropertyChangedEventArgs even)
        {
            if (_currentJob != null)
            {
                Event_Work();

                _currentJob.WorkPlan += TrackBar_Flow() * 10;
                TextOutput(labelWorkPlan, "Выполнение плана: " + _currentJob.WorkPlan + " %");

                GameCharacter.Set("Money", _currentJob.Salary);

                numberMonthsWorked += 1;

                if (numberMonthsWorked == 6)
                {
                    numberMonthsWorked = 0;

                    ImplementationPlan();
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
        private void ImplementationPlan()
        {
            if (_currentJob.Plan <= _currentJob.WorkPlan)
            {
                GameCharacter.Set("Money", _currentJob.Salary * 2);

                TopMostMessageBox.Show("Вы выполнили план. В качестве премии вам начислили " + (_currentJob.Salary * 2).ToString() + " $", "Событие");
            }
            else
            {
                _currentJob.WorkPlan = 0;
                TextOutput(labelWorkPlan, "Выполнение плана: 0%");

                var randomValue = random.Next(0, 4);

                if (randomValue == 0)
                {
                    QuitWork_Click(new object(), new EventArgs());
                    TopMostMessageBox.Show("Вы не выполнили план и поэтому вас уволили с работы", "Событие");
                }
                else
                {
                    TopMostMessageBox.Show("Вы не выполнили план", "Событие");
                }
            }
        }

        #endregion

        /// <summary>
        /// Устроиться на работу
        /// </summary>
        /// <param name="finalJob">Работа</param>
        public void MyWorkFunc(FinalJob finalJob)
        {
            _currentJob = finalJob;

            EnableButtom(buttonQuit, true);
            EnableButtom(buttonFindJob, false);

            CurrentWork();

            Income_AddWork(_currentJob.Salary);
        }

        /// <summary>
        /// Уволиться с работы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuitWork_Click(object sender, EventArgs e)
        {
            if (_currentJob != null)
            {
                Income_AddWork(-_currentJob.Salary);

                _currentJob = null;

                EnableButtom(buttonQuit, false);
                EnableButtom(buttonFindJob, true);

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
            if (_currentJob != null)
            {
                TextOutput(labelProfessionName, "Профессия: " + _currentJob.ProfessionName);
                TextOutput(labelSalary, "Оклад: " + _currentJob.Salary + " $");
              
                TextOutput(labelPlan, "План: " + _currentJob.Plan + " %");
                TextOutput(labelWorkPlan, "Выполнение плана: " + _currentJob.WorkPlan + " %");

                ChangeCharacteristics(true);
            }
            else
            {
                TextOutput(labelProfessionName, "Профессия: Безработный");
                TextOutput(labelSalary, "Оклад: 0$");
               
                TextOutput(labelPlan, "План: 0%");
                TextOutput(labelWorkPlan, "Выполнение плана: 0%");

                ChangeCharacteristics(false);
            }
        }

        /// <summary>
        /// Изменение характеристик игрока
        /// </summary>
        /// <param name="flag"></param>
        private void ChangeCharacteristics(bool flag)
        {
            if (!flag)
            {
                GameCharacter.NeedsWork = 0;
            }
            else
            {
                GameCharacter.NeedsWork = (int)(25 * TrackBar_Flow() * 10 / 100.0);
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
            _valueTableWork = TrackBar_Flow() * 10;
            labelTableWork.Text = _valueTableWork + " %";

            if (_currentJob != null)
            {
                ChangeCharacteristics(true);
            }
        }

        /// <summary>
        /// Добавление дохода с работы
        /// </summary>
        private void Income_AddWork(int income)
        {
            GameCharacter.Income += income;
        }

        /// <summary>
        /// События происходящие на работе
        /// </summary>
        private void Event_Work()
        {

        }
    }
}
