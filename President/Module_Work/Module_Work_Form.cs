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

        /// <summary>
        /// Метод подсказки для оклада
        /// </summary>
        private void ToolTipAdvice(string text)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    if (toolTipAdvice != null)
                    {
                        toolTipAdvice.RemoveAll();
                        toolTipAdvice.Dispose();
                        toolTipAdvice = null;
                    }
                }));
            }
            else
            {
                if (toolTipAdvice != null)
                {
                    toolTipAdvice.RemoveAll();
                    toolTipAdvice.Dispose();
                    toolTipAdvice = null;
                }
            }

            if (_currentJob != null)
            {
                toolTipAdvice = new ToolTip();

                if (InvokeRequired)
                {
                    Invoke(new Action(() => toolTipAdvice.SetToolTip(labelSalary, text)));
                }
                else
                {
                    toolTipAdvice.SetToolTip(labelSalary, text);
                }
            }
        }

        #endregion
        
        /// <summary>
        /// Подсказка для оклада 
        /// </summary>
        ToolTip toolTipAdvice;
        
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public Module_Work_Form()
        {
            InitializeComponent();

            //Подписка на событие повышение квалификации
            GameCharacter.PropertyChangedNewQualifications += new PropertyChangedEventHandler(NewQualifications);

            //Подписка на событие повышение востребованность
            Demand.PropertyChangedNewDemand += new PropertyChangedEventHandler(NewDemand);

            //Подписка на события "Новый день" для начисления зарплаты
            Game_Time.PropertyChangedNewDay += new PropertyChangedEventHandler(GetValue_Everyday);

            Effort_Work.PropertyChangedValueChanged += new PropertyChangedEventHandler(ValueChanged);

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

                _currentJob.WorkPlan += Effort_Work.ReturnValue();
                TextOutput(labelWorkPlan, "Выполнение плана: " + _currentJob.WorkPlan + " %");

                GameCharacter.Set("Money", _currentJob.Salary_End);

                _numberMonthsWorked += 1;

                if (_numberMonthsWorked == 6)
                {
                    _numberMonthsWorked = 0;

                    ImplementationPlan();
                }
            }
        }

        #endregion

        #region Перерасчет зарплаты

        /// <summary>
        /// Перерасчет из за изменения квалификации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="even"></param>
        private void NewQualifications(object sender, PropertyChangedEventArgs even)
        {
            if (_currentJob != null)
            {
                //Сохранение старой зарплаты
                int Salary_Old = _currentJob.Salary_End;

                //Повышение квалификации
                _currentJob.Salary_Coefficient = (int)(_currentJob.Salary_Start * GameCharacter.ReturnQualifications(_currentJob.IndexCategory) / 100.0);

                _currentJob.Salary_End = _currentJob.Salary_Start + _currentJob.Salary_Coefficient + _currentJob.Salary_Demand;

                CurrentWork();

                Income_AddWork(_currentJob.Salary_End - Salary_Old);
            }
        }

        /// <summary>
        /// Перерасчет из за изменения востребованности
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="even"></param>
        private void NewDemand(object sender, PropertyChangedEventArgs even)
        {
            if (_currentJob != null)
            {
                //Сохранение старой зарплаты
                int Salary_Old = _currentJob.Salary_End;

                //Востребованность
                _currentJob.Salary_Demand = (int)(_currentJob.Salary_Start * Demand.Professions(_currentJob.IndustryName) / 100.0);

                _currentJob.Salary_End = _currentJob.Salary_Start + _currentJob.Salary_Coefficient + _currentJob.Salary_Demand;

                CurrentWork();

                Income_AddWork(_currentJob.Salary_End - Salary_Old);
            }
        }

        #endregion

        /// <summary>
        /// Количество отработанных месяцев. 
        /// Нужно для начисления премии.
        /// Сбрасываетс при увольнении
        /// </summary>
        private int _numberMonthsWorked = 0;

        #region События происходящие раз в пол года "Получение премии"

        /// <summary>
        /// Событие происходящее раз в пол года
        /// Проверка выполнения плана
        /// </summary>
        private void ImplementationPlan()
        {
            if (_currentJob.Plan <= _currentJob.WorkPlan)
            {
                GameCharacter.Set("Money", _currentJob.Salary_End * 2);

                TopMostMessageBox.Show("Вы выполнили план. В качестве премии вам начислили " + (_currentJob.Salary_End * 2).ToString() + " $", "Событие");
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

            Income_AddWork(_currentJob.Salary_End);
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
                Income_AddWork(-_currentJob.Salary_End);

                _currentJob = null;

                EnableButtom(buttonQuit, false);
                EnableButtom(buttonFindJob, true);

                CurrentWork();

                _numberMonthsWorked = 0;
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
                TextOutput(labelCategoria, "Категория: " + _currentJob.IndustryName);
                TextOutput(labelProfessionName, "Профессия: " + _currentJob.ProfessionName);

                TextOutput(labelSalary, "Оклад: " + _currentJob.Salary_End + " $");
                ToolTipAdvice(_currentJob.Salary_Start + "$ + " + _currentJob.Salary_Coefficient + "$ + " + _currentJob.Salary_Demand + "$");

                TextOutput(labelPlan, "План: " + _currentJob.Plan + " %");
                TextOutput(labelWorkPlan, "Выполнение плана: " + _currentJob.WorkPlan + " %");

                ChangeCharacteristics(true);
            }
            else
            {
                TextOutput(labelCategoria, "Категория: Отсутствует");
                TextOutput(labelProfessionName, "Профессия: Безработный");

                TextOutput(labelSalary, "Оклад: 0$");
                ToolTipAdvice("");

                TextOutput(labelPlan, "План: 0%");
                TextOutput(labelWorkPlan, "Выполнение плана: 0%");

                ChangeCharacteristics(false);
            }
        }

        //Понежение характеристик
        int needsWork = 25;

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
                GameCharacter.NeedsWork = (int)(needsWork * Effort_Work.ReturnValue() / 100.0);
            }
        }

        /// <summary>
        /// Масштабирование прокрутки
        /// </summary>
        private void ValueChanged(object sender, PropertyChangedEventArgs even)
        {
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
