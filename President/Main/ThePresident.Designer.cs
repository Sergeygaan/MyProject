namespace ThePresident
{
    partial class ThePresident
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.labelMoney = new System.Windows.Forms.Label();
            this.labelFood = new System.Windows.Forms.Label();
            this.labelMood = new System.Windows.Forms.Label();
            this.labelHealth = new System.Windows.Forms.Label();
            this.labelPhysicalDevelopment = new System.Windows.Forms.Label();
            this.labelCharm = new System.Windows.Forms.Label();
            this.labelIntelligence = new System.Windows.Forms.Label();
            this.buttonModule_Work = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(614, 9);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(48, 13);
            this.labelMoney.TabIndex = 1;
            this.labelMoney.Text = "Деньги:";
            // 
            // labelFood
            // 
            this.labelFood.AutoSize = true;
            this.labelFood.Location = new System.Drawing.Point(614, 32);
            this.labelFood.Name = "labelFood";
            this.labelFood.Size = new System.Drawing.Size(26, 13);
            this.labelFood.TabIndex = 2;
            this.labelFood.Text = "Еда";
            // 
            // labelMood
            // 
            this.labelMood.AutoSize = true;
            this.labelMood.Location = new System.Drawing.Point(614, 56);
            this.labelMood.Name = "labelMood";
            this.labelMood.Size = new System.Drawing.Size(68, 13);
            this.labelMood.TabIndex = 3;
            this.labelMood.Text = "Настроение";
            // 
            // labelHealth
            // 
            this.labelHealth.AutoSize = true;
            this.labelHealth.Location = new System.Drawing.Point(614, 80);
            this.labelHealth.Name = "labelHealth";
            this.labelHealth.Size = new System.Drawing.Size(56, 13);
            this.labelHealth.TabIndex = 4;
            this.labelHealth.Text = "Здоровье";
            // 
            // labelPhysicalDevelopment
            // 
            this.labelPhysicalDevelopment.AutoSize = true;
            this.labelPhysicalDevelopment.Location = new System.Drawing.Point(614, 104);
            this.labelPhysicalDevelopment.Name = "labelPhysicalDevelopment";
            this.labelPhysicalDevelopment.Size = new System.Drawing.Size(98, 13);
            this.labelPhysicalDevelopment.TabIndex = 5;
            this.labelPhysicalDevelopment.Text = "Физическая сила";
            // 
            // labelCharm
            // 
            this.labelCharm.AutoSize = true;
            this.labelCharm.Location = new System.Drawing.Point(614, 127);
            this.labelCharm.Name = "labelCharm";
            this.labelCharm.Size = new System.Drawing.Size(51, 13);
            this.labelCharm.TabIndex = 6;
            this.labelCharm.Text = "Обаяние";
            // 
            // labelIntelligence
            // 
            this.labelIntelligence.AutoSize = true;
            this.labelIntelligence.Location = new System.Drawing.Point(614, 149);
            this.labelIntelligence.Name = "labelIntelligence";
            this.labelIntelligence.Size = new System.Drawing.Size(61, 13);
            this.labelIntelligence.TabIndex = 7;
            this.labelIntelligence.Text = "Интеллект";
            // 
            // buttonModule_Work
            // 
            this.buttonModule_Work.Location = new System.Drawing.Point(12, 12);
            this.buttonModule_Work.Name = "buttonModule_Work";
            this.buttonModule_Work.Size = new System.Drawing.Size(75, 23);
            this.buttonModule_Work.TabIndex = 8;
            this.buttonModule_Work.Text = "Работа";
            this.buttonModule_Work.UseVisualStyleBackColor = true;
            this.buttonModule_Work.Click += new System.EventHandler(this.buttonModule_Work_Click);
            // 
            // ThePresident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonModule_Work);
            this.Controls.Add(this.labelIntelligence);
            this.Controls.Add(this.labelCharm);
            this.Controls.Add(this.labelPhysicalDevelopment);
            this.Controls.Add(this.labelHealth);
            this.Controls.Add(this.labelMood);
            this.Controls.Add(this.labelFood);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThePresident";
            this.Text = "The President";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Label labelFood;
        private System.Windows.Forms.Label labelMood;
        private System.Windows.Forms.Label labelHealth;
        private System.Windows.Forms.Label labelPhysicalDevelopment;
        private System.Windows.Forms.Label labelCharm;
        private System.Windows.Forms.Label labelIntelligence;
        private System.Windows.Forms.Button buttonModule_Work;
    }
}

