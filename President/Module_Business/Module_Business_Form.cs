using Module_UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_Business
{
    public partial class Module_Business_Form : Form
    {
        /// <summary>
        /// Класс, для малого бизнеса
        /// </summary>
        private SmallBusiness _smallBusiness;

        /// <summary>
        /// Класс, для среднего бизнеса
        /// </summary>
        private MediumBusiness _mediumBusiness;

        /// <summary>
        /// Класс, для крупного бизнеса
        /// </summary>
        private BigBusiness _bigBusiness;

        public Module_Business_Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Купить малый бизнес
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buySmall_Click(object sender, EventArgs e)
        {
            if (_smallBusiness == null)
            {
                _smallBusiness = new SmallBusiness();

                Button_Text(buySmall, "Параметры");
                Button_Enable(sellSmall, true);
            }
            else
            {
                var demandProfessionsForm = new Demand_Business("small");
                demandProfessionsForm.ShowDialog();
            }
        }

        /// <summary>
        /// Продать малый бизнес
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sellSmall_Click(object sender, EventArgs e)
        {
            if (_smallBusiness != null)
            {
                _smallBusiness = null;

                Button_Text(buySmall, "Купить");
                Button_Enable(sellSmall, false);
            }
        }

        /// <summary>
        /// Востребованность малого бизнеса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void demandSmall_Click(object sender, EventArgs e)
        {
            //var demandProfessionsForm = new DemandProfessions("small");
            //demandProfessionsForm.ShowDialog();
        }

        /// <summary>
        /// Купить средний бизнес
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buyMedium_Click(object sender, EventArgs e)
        {
            if (_mediumBusiness == null)
            {
                _mediumBusiness = new MediumBusiness();

                Button_Text(buyMedium, "Параметры");
                Button_Enable(sellMedium, true);
            }
            else
            {
                var demandProfessionsForm = new Demand_Business("medium");
                demandProfessionsForm.ShowDialog();
            }
        }

        /// <summary>
        /// Продать средний бизнес
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SellMedium_Click(object sender, EventArgs e)
        {
            if (_mediumBusiness != null)
            {
                _mediumBusiness = null;

                Button_Text(buyMedium, "Купить");
                Button_Enable(sellMedium, false);
            }
        }

        /// <summary>
        /// Востребованность среднего бизнеса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void demandMedium_Click(object sender, EventArgs e)
        {
            //var demandProfessionsForm = new DemandProfessions("medium");
            //demandProfessionsForm.ShowDialog();
        }

        /// <summary>
        /// Купить крупный бизнес
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buyBig_Click(object sender, EventArgs e)
        {
            if (_bigBusiness == null)
            {
                _bigBusiness = new BigBusiness();

                Button_Text(buyBig, "Параметры");
                Button_Enable(sellBig, true);
            }
            else
            {
                var demandProfessionsForm = new Demand_Business("big");
                demandProfessionsForm.ShowDialog();
            }
        }

        /// <summary>
        /// Продать крупный бизнес
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sellBig_Click(object sender, EventArgs e)
        {
            if (_bigBusiness != null)
            {
                _bigBusiness = null;

                Button_Text(buyBig, "Купить");
                Button_Enable(sellBig, false);
            }
        }

        /// <summary>
        /// Востребованность крупного бизнеса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void demandBig_Click(object sender, EventArgs e)
        {
            //var demandProfessionsForm = new DemandProfessions("big");
            //demandProfessionsForm.ShowDialog();
        }

        #region Работа с кнопками

        /// <summary>
        /// Работа с доступностью кнопок
        /// </summary>
        /// <param name="button">Кнопка</param>
        /// <param name="flag">Доступность</param>
        /// <param name="text">Имя кнопки</param>
        private void Button_Enable(Button button, bool flag)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => button.Enabled = flag ));
            }
            else
            {
                button.Enabled = flag;
            }
        }

        /// <summary>
        /// Работа с текстом кнопок
        /// </summary>
        /// <param name="button">Кнопка</param>
        /// <param name="flag">Доступность</param>
        /// <param name="text">Имя кнопки</param>
        private void Button_Text(Button button, string text )
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => button.Text = text ));
            }
            else
            {
                button.Text = text;
            }
        }

    #endregion

    }
}
