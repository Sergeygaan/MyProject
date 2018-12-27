namespace Module_UserControl
{
    partial class Characte_Characteristics_UserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxCharacteristics = new System.Windows.Forms.GroupBox();
            this.groupBoxNeeds = new System.Windows.Forms.GroupBox();
            this.groupBoxQualities = new System.Windows.Forms.GroupBox();
            this.labelPhysicalDevelopment = new System.Windows.Forms.Label();
            this.labelCharm = new System.Windows.Forms.Label();
            this.labelIntelligence = new System.Windows.Forms.Label();
            this.groupBoxFinance = new System.Windows.Forms.GroupBox();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelIncome = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.toolTipFood = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipMood = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipHealth = new System.Windows.Forms.ToolTip(this.components);
            this.health_UserControl1 = new Module_UserControl.Health_UserControl();
            this.mood_UserControl1 = new Module_UserControl.Mood_UserControl();
            this.food_UserControl1 = new Module_UserControl.Food_UserControl();
            this.groupBoxCharacteristics.SuspendLayout();
            this.groupBoxNeeds.SuspendLayout();
            this.groupBoxQualities.SuspendLayout();
            this.groupBoxFinance.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCharacteristics
            // 
            this.groupBoxCharacteristics.Controls.Add(this.groupBoxNeeds);
            this.groupBoxCharacteristics.Controls.Add(this.groupBoxQualities);
            this.groupBoxCharacteristics.Controls.Add(this.groupBoxFinance);
            this.groupBoxCharacteristics.Location = new System.Drawing.Point(5, 3);
            this.groupBoxCharacteristics.Name = "groupBoxCharacteristics";
            this.groupBoxCharacteristics.Size = new System.Drawing.Size(270, 286);
            this.groupBoxCharacteristics.TabIndex = 0;
            this.groupBoxCharacteristics.TabStop = false;
            this.groupBoxCharacteristics.Text = "Характеристики";
            // 
            // groupBoxNeeds
            // 
            this.groupBoxNeeds.Controls.Add(this.health_UserControl1);
            this.groupBoxNeeds.Controls.Add(this.mood_UserControl1);
            this.groupBoxNeeds.Controls.Add(this.food_UserControl1);
            this.groupBoxNeeds.Location = new System.Drawing.Point(7, 104);
            this.groupBoxNeeds.Name = "groupBoxNeeds";
            this.groupBoxNeeds.Size = new System.Drawing.Size(257, 173);
            this.groupBoxNeeds.TabIndex = 18;
            this.groupBoxNeeds.TabStop = false;
            this.groupBoxNeeds.Text = "Потребности";
            // 
            // groupBoxQualities
            // 
            this.groupBoxQualities.Controls.Add(this.labelPhysicalDevelopment);
            this.groupBoxQualities.Controls.Add(this.labelCharm);
            this.groupBoxQualities.Controls.Add(this.labelIntelligence);
            this.groupBoxQualities.Location = new System.Drawing.Point(165, 20);
            this.groupBoxQualities.Name = "groupBoxQualities";
            this.groupBoxQualities.Size = new System.Drawing.Size(99, 78);
            this.groupBoxQualities.TabIndex = 17;
            this.groupBoxQualities.TabStop = false;
            this.groupBoxQualities.Text = "Качества";
            // 
            // labelPhysicalDevelopment
            // 
            this.labelPhysicalDevelopment.AutoSize = true;
            this.labelPhysicalDevelopment.Location = new System.Drawing.Point(6, 58);
            this.labelPhysicalDevelopment.Name = "labelPhysicalDevelopment";
            this.labelPhysicalDevelopment.Size = new System.Drawing.Size(44, 13);
            this.labelPhysicalDevelopment.TabIndex = 12;
            this.labelPhysicalDevelopment.Text = "Сила: 0";
            // 
            // labelCharm
            // 
            this.labelCharm.AutoSize = true;
            this.labelCharm.Location = new System.Drawing.Point(6, 38);
            this.labelCharm.Name = "labelCharm";
            this.labelCharm.Size = new System.Drawing.Size(63, 13);
            this.labelCharm.TabIndex = 13;
            this.labelCharm.Text = "Обаяние: 0";
            // 
            // labelIntelligence
            // 
            this.labelIntelligence.AutoSize = true;
            this.labelIntelligence.Location = new System.Drawing.Point(6, 18);
            this.labelIntelligence.Name = "labelIntelligence";
            this.labelIntelligence.Size = new System.Drawing.Size(73, 13);
            this.labelIntelligence.TabIndex = 14;
            this.labelIntelligence.Text = "Интеллект: 0";
            // 
            // groupBoxFinance
            // 
            this.groupBoxFinance.Controls.Add(this.labelTax);
            this.groupBoxFinance.Controls.Add(this.labelIncome);
            this.groupBoxFinance.Controls.Add(this.labelMoney);
            this.groupBoxFinance.Location = new System.Drawing.Point(7, 20);
            this.groupBoxFinance.Name = "groupBoxFinance";
            this.groupBoxFinance.Size = new System.Drawing.Size(152, 78);
            this.groupBoxFinance.TabIndex = 16;
            this.groupBoxFinance.TabStop = false;
            this.groupBoxFinance.Text = "Финансы";
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Location = new System.Drawing.Point(6, 60);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(65, 13);
            this.labelTax.TabIndex = 10;
            this.labelTax.Text = "Налоги: 0 $";
            // 
            // labelIncome
            // 
            this.labelIncome.AutoSize = true;
            this.labelIncome.Location = new System.Drawing.Point(6, 43);
            this.labelIncome.Name = "labelIncome";
            this.labelIncome.Size = new System.Drawing.Size(60, 13);
            this.labelIncome.TabIndex = 9;
            this.labelIncome.Text = "Доход: 0 $";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(6, 16);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(78, 13);
            this.labelMoney.TabIndex = 8;
            this.labelMoney.Text = "Деньги: 100 $";
            // 
            // health_UserControl1
            // 
            this.health_UserControl1.Location = new System.Drawing.Point(6, 115);
            this.health_UserControl1.Name = "health_UserControl1";
            this.health_UserControl1.Size = new System.Drawing.Size(245, 55);
            this.health_UserControl1.TabIndex = 19;
            // 
            // mood_UserControl1
            // 
            this.mood_UserControl1.Location = new System.Drawing.Point(6, 66);
            this.mood_UserControl1.Name = "mood_UserControl1";
            this.mood_UserControl1.Size = new System.Drawing.Size(243, 55);
            this.mood_UserControl1.TabIndex = 19;
            // 
            // food_UserControl1
            // 
            this.food_UserControl1.Location = new System.Drawing.Point(6, 15);
            this.food_UserControl1.Name = "food_UserControl1";
            this.food_UserControl1.Size = new System.Drawing.Size(245, 55);
            this.food_UserControl1.TabIndex = 0;
            // 
            // Characte_Characteristics_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxCharacteristics);
            this.DoubleBuffered = true;
            this.Name = "Characte_Characteristics_UserControl";
            this.Size = new System.Drawing.Size(282, 289);
            this.groupBoxCharacteristics.ResumeLayout(false);
            this.groupBoxNeeds.ResumeLayout(false);
            this.groupBoxQualities.ResumeLayout(false);
            this.groupBoxQualities.PerformLayout();
            this.groupBoxFinance.ResumeLayout(false);
            this.groupBoxFinance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCharacteristics;
        private System.Windows.Forms.Label labelIntelligence;
        private System.Windows.Forms.Label labelCharm;
        private System.Windows.Forms.Label labelPhysicalDevelopment;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.GroupBox groupBoxFinance;
        private System.Windows.Forms.Label labelIncome;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.GroupBox groupBoxQualities;
        private System.Windows.Forms.GroupBox groupBoxNeeds;
        private System.Windows.Forms.ToolTip toolTipFood;
        private System.Windows.Forms.ToolTip toolTipMood;
        private System.Windows.Forms.ToolTip toolTipHealth;
        private Food_UserControl food_UserControl1;
        private Mood_UserControl mood_UserControl1;
        private Health_UserControl health_UserControl1;
    }
}
