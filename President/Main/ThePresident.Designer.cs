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
            this.characte_Characteristics = new Module_UserControl.Characte_Characteristics_UserControl();
            this.button2 = new System.Windows.Forms.Button();
            this.toDoList = new Module_UserControl.ToDoList_UserControl();
            this.gameTimer_UserControl = new Module_UserControl.GameTimer_UserControl();
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
            this.buttonModule_Work.Size = new System.Drawing.Size(75, 23);
            this.buttonModule_Work.TabIndex = 8;
            this.buttonModule_Work.Text = "Работа";
            this.buttonModule_Work.UseVisualStyleBackColor = true;
            this.buttonModule_Work.Click += new System.EventHandler(this.buttonModule_Work_Click);
            // 
            // characte_Characteristics
            // 
            this.characte_Characteristics.Location = new System.Drawing.Point(502, 12);
            this.characte_Characteristics.Name = "characte_Characteristics";
            this.characte_Characteristics.Size = new System.Drawing.Size(286, 241);
            this.characte_Characteristics.TabIndex = 9;
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
            // toDoList
            // 
            this.toDoList.Location = new System.Drawing.Point(125, 328);
            this.toDoList.Name = "toDoList";
            this.toDoList.Size = new System.Drawing.Size(213, 110);
            this.toDoList.TabIndex = 12;
            // 
            // gameTimer_UserControl
            // 
            this.gameTimer_UserControl.Location = new System.Drawing.Point(12, 352);
            this.gameTimer_UserControl.Name = "gameTimer_UserControl";
            this.gameTimer_UserControl.Size = new System.Drawing.Size(107, 71);
            this.gameTimer_UserControl.TabIndex = 13;
            // 
            // ThePresident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gameTimer_UserControl);
            this.Controls.Add(this.toDoList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.characte_Characteristics);
            this.Controls.Add(this.buttonModule_Work);
            this.Controls.Add(this.button1);
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
        private Module_UserControl.ToDoList_UserControl toDoList;
        private Module_UserControl.GameTimer_UserControl gameTimer_UserControl;
    }
}

