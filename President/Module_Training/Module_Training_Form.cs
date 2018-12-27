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

namespace Module_Training
{
    public partial class Module_Training_Form : Form
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

        #endregion

        /// <summary>
        /// Генератор рандомных значений
        /// </summary>
        private Random random = new Random();

        /// <summary>
        /// Повышение квалификации
        /// </summary>
        private Qualifications_Form _qualifications_Form;

        /// <summary>
        /// Образование
        /// </summary>
        private Education_Form _education_Form;

        public Module_Training_Form()
        {
            InitializeComponent();
    
            Game_Time.PropertyChangedNewDay += new PropertyChangedEventHandler(GetValue_Everyday);

            Effort_Study.PropertyChangedValueChanged += new PropertyChangedEventHandler(ValueChanged);
        }

        #region Конец месяца

        /// <summary>
        /// Подсчет пройденных месяцев
        /// </summary>
        private int countMonth = 0;

        /// <summary>
        /// Событие происходящие в конце дня
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="even"></param>
        private void GetValue_Everyday(object sender, PropertyChangedEventArgs even)
        {
            if (_currentStudy != null)
            {
                countMonth += 1;

                Event_Study();

                _currentStudy.StudyPlan += Effort_Study.ReturnValue();
                TextOutput(labelStudyPlan, "Выполнение плана: " + _currentStudy.StudyPlan + " %");

                _currentStudy.PeriodStudy -= 1;
                TextOutput(labelMonthsLeft, "Месяцев осталось: " + _currentStudy.PeriodStudy + " мес.");

                if(countMonth >= 1)
                {
                    countMonth = 0;

                    GameCharacter.Set("Intelligence", 1);
                }

                if (_currentStudy.PeriodStudy == 0)
                {
                    ImplementationPlan();
                }
            }
        }

        /// <summary>
        /// Событие происходящее раз в пол года
        /// Проверка выполнения плана
        /// </summary>
        private void ImplementationPlan()
        {
            if (_currentStudy.Plan <= _currentStudy.StudyPlan)
            {
                //GameCharacter.Set("Money", _currentJob.Salary * 2);
                GameCharacter.Study = _currentStudy.NameStudy;

                TopMostMessageBox.Show("Вы выполнили план. В качестве премии вам начислили ", "Событие");
            }
            else
            {
                TopMostMessageBox.Show("Вы не смогли закончить обучение. Вас отчислили", "Событие");
            }

            buttonDeduct_Click(new object(), new EventArgs());
        }

        #endregion

        /// <summary>
        /// Метод открытия формы "Повышение квалификации"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonQualifications_Click(object sender, EventArgs e)
        {
            if (_qualifications_Form == null)
            {
                _qualifications_Form = new Qualifications_Form();
            }

            _qualifications_Form.ShowDialog();
        }

        /// <summary>
        /// Метод для открытия формы "Образование"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEducation_Click(object sender, EventArgs e)
        {
            if (_education_Form == null)
            {
                _education_Form = new Education_Form(new MyDelegateStudy(MyStudyFunc));
            }

            _education_Form.ShowDialog();
        }

        #region Текущее обучение 

        /// <summary>
        /// Текущая учеба
        /// </summary>
        private CurrentStudy _currentStudy;

        public delegate void MyDelegateStudy(CurrentStudy _currentStudy);

        /// <summary>
        /// Устроиться на работу
        /// </summary>
        /// <param name="finalJob">Работа</param>
        public void MyStudyFunc(CurrentStudy finalStudy)
        {
            _currentStudy = finalStudy;

            EnableButtom(buttonDeduct, true);
            EnableButtom(buttonEducation, false);

            CurrentWork();

            GameCharacter.Restrictions_Intelligence = _currentStudy.RestrictionsIntellect;
        }

        /// <summary>
        /// Вывод информации о текущей обучении
        /// </summary>
        private void CurrentWork()
        {
            if (_currentStudy != null)
            {
                TextOutput(labelNameStudy, "Образование: " + _currentStudy.NameStudy);

                TextOutput(labelMonthsLeft, "Месяцев осталось: " + _currentStudy.PeriodStudy + " мес.");
                TextOutput(labelPlan, "План: " + _currentStudy.Plan + " %");
                TextOutput(labelStudyPlan, "Выполнение плана: 0%");

                ChangeCharacteristics(true);
            }
            else
            {
                TextOutput(labelNameStudy, "Образование: " + GameCharacter.Study);

                TextOutput(labelMonthsLeft, "Месяцев осталось: 0 мес.");
                TextOutput(labelPlan, "План: 0%");
                TextOutput(labelStudyPlan, "Выполнение плана: 0%");

                ChangeCharacteristics(false);
            }
        }

        //Понежение характеристик
        int needsStudy = 15;

        /// <summary>
        /// Изменение характеристик игрока
        /// </summary>
        private void ChangeCharacteristics(bool flag)
        {
            if(!flag)
            {
                GameCharacter.NeedsStudy = 0;
            }
            else
            {
                GameCharacter.NeedsStudy = (int)(needsStudy * Effort_Study.ReturnValue() / 100.0);
            }
        }

        /// <summary>
        /// Отчислиться
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeduct_Click(object sender, EventArgs e)
        {
            if (_currentStudy != null)
            {
                _currentStudy = null;

                EnableButtom(buttonDeduct, false);
                EnableButtom(buttonEducation, true);

                CurrentWork();
            }
        }

        #endregion

        /// <summary>
        /// Значение качества учебы
        /// </summary>
        int _valueTableWork = 0;

        /// <summary>
        /// Масштабирование прокрутки
        /// </summary>
        private void ValueChanged(object sender, PropertyChangedEventArgs even)
        {
            if (_currentStudy != null)
            {
                ChangeCharacteristics(true);
            }
        }

        /// <summary>
        /// События происходящие на учебе
        /// </summary>
        private void Event_Study()
        {

        }

        private void buttonSelfDevelopment_Click(object sender, EventArgs e)
        {

        }
    }
}
