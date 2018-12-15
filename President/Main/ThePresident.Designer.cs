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
            this.buttonModule_Work = new System.Windows.Forms.Button();
            this.characte_Characteristics1 = new Module_UserControl.Characte_Characteristics();
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
            // characte_Characteristics1
            // 
            this.characte_Characteristics1.Location = new System.Drawing.Point(502, 12);
            this.characte_Characteristics1.Name = "characte_Characteristics1";
            this.characte_Characteristics1.Size = new System.Drawing.Size(286, 241);
            this.characte_Characteristics1.TabIndex = 9;
            // 
            // ThePresident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.characte_Characteristics1);
            this.Controls.Add(this.buttonModule_Work);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThePresident";
            this.Text = "The President";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonModule_Work;
        private Module_UserControl.Characte_Characteristics characte_Characteristics1;
    }
}

