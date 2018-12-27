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

            _gameTimer?.Dispose();
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.buttonModule_Work = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonTraining = new System.Windows.Forms.Button();
            this.characte_Characteristics_UserControl1 = new Module_UserControl.Characte_Characteristics_UserControl();
            this.characte_Parameters_UserControl2 = new Module_UserControl.Characte_Parameters_UserControl();
            this.buttonFood = new System.Windows.Forms.Button();
            this.buttonMood = new System.Windows.Forms.Button();
            this.buttonHealth = new System.Windows.Forms.Button();
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
            // buttonModule_Work
            // 
            this.buttonModule_Work.Location = new System.Drawing.Point(12, 12);
            this.buttonModule_Work.Name = "buttonModule_Work";
            this.buttonModule_Work.Size = new System.Drawing.Size(87, 23);
            this.buttonModule_Work.TabIndex = 8;
            this.buttonModule_Work.Text = "Работа";
            this.buttonModule_Work.UseVisualStyleBackColor = true;
            this.buttonModule_Work.Click += new System.EventHandler(this.buttonModule_Work_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(268, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonTraining
            // 
            this.buttonTraining.Location = new System.Drawing.Point(12, 41);
            this.buttonTraining.Name = "buttonTraining";
            this.buttonTraining.Size = new System.Drawing.Size(87, 23);
            this.buttonTraining.TabIndex = 15;
            this.buttonTraining.Text = "Обучение";
            this.buttonTraining.UseVisualStyleBackColor = true;
            this.buttonTraining.Click += new System.EventHandler(this.buttonTraining_Click);
            // 
            // characte_Characteristics_UserControl1
            // 
            this.characte_Characteristics_UserControl1.Location = new System.Drawing.Point(506, 12);
            this.characte_Characteristics_UserControl1.Name = "characte_Characteristics_UserControl1";
            this.characte_Characteristics_UserControl1.Size = new System.Drawing.Size(282, 289);
            this.characte_Characteristics_UserControl1.TabIndex = 16;
            // 
            // characte_Parameters_UserControl2
            // 
            this.characte_Parameters_UserControl2.Location = new System.Drawing.Point(506, 307);
            this.characte_Parameters_UserControl2.Name = "characte_Parameters_UserControl2";
            this.characte_Parameters_UserControl2.Size = new System.Drawing.Size(204, 129);
            this.characte_Parameters_UserControl2.TabIndex = 17;
            // 
            // buttonFood
            // 
            this.buttonFood.Location = new System.Drawing.Point(12, 70);
            this.buttonFood.Name = "buttonFood";
            this.buttonFood.Size = new System.Drawing.Size(87, 23);
            this.buttonFood.TabIndex = 18;
            this.buttonFood.Text = "Еда";
            this.buttonFood.UseVisualStyleBackColor = true;
            this.buttonFood.Click += new System.EventHandler(this.buttonFood_Click);
            // 
            // buttonMood
            // 
            this.buttonMood.Location = new System.Drawing.Point(12, 99);
            this.buttonMood.Name = "buttonMood";
            this.buttonMood.Size = new System.Drawing.Size(87, 23);
            this.buttonMood.TabIndex = 19;
            this.buttonMood.Text = "Настроение";
            this.buttonMood.UseVisualStyleBackColor = true;
            this.buttonMood.Click += new System.EventHandler(this.buttonMood_Click);
            // 
            // buttonHealth
            // 
            this.buttonHealth.Location = new System.Drawing.Point(12, 128);
            this.buttonHealth.Name = "buttonHealth";
            this.buttonHealth.Size = new System.Drawing.Size(87, 23);
            this.buttonHealth.TabIndex = 20;
            this.buttonHealth.Text = "Здоровье";
            this.buttonHealth.UseVisualStyleBackColor = true;
            this.buttonHealth.Click += new System.EventHandler(this.buttonHealth_Click);
            // 
            // ThePresident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHealth);
            this.Controls.Add(this.buttonMood);
            this.Controls.Add(this.buttonFood);
            this.Controls.Add(this.characte_Parameters_UserControl2);
            this.Controls.Add(this.characte_Characteristics_UserControl1);
            this.Controls.Add(this.buttonTraining);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonModule_Work);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThePresident";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The President";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonModule_Work;
        private Module_UserControl.Characte_Characteristics_UserControl characte_Characteristics;
        private System.Windows.Forms.Button button2;
        private Module_UserControl.GameTimer_UserControl gameTimer_UserControl;
        private System.Windows.Forms.Button buttonTraining;
        private Module_UserControl.Characte_Parameters_UserControl characte_Parameters_UserControl1;
        private Module_UserControl.Characte_Characteristics_UserControl characte_Characteristics_UserControl1;
        private Module_UserControl.Characte_Parameters_UserControl characte_Parameters_UserControl2;
        private System.Windows.Forms.Button buttonFood;
        private System.Windows.Forms.Button buttonMood;
        private System.Windows.Forms.Button buttonHealth;
    }
}

