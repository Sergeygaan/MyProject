namespace Module_Training
{
    partial class Module_Training_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelMonthsLeft = new System.Windows.Forms.Label();
            this.labelStudyPlan = new System.Windows.Forms.Label();
            this.labelPlan = new System.Windows.Forms.Label();
            this.labelNameStudy = new System.Windows.Forms.Label();
            this.buttonQualifications = new System.Windows.Forms.Button();
            this.buttonEducation = new System.Windows.Forms.Button();
            this.buttonDeduct = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Effort_Study = new Module_UserControl.Effort_UserControl();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelMonthsLeft);
            this.groupBox1.Controls.Add(this.labelStudyPlan);
            this.groupBox1.Controls.Add(this.labelPlan);
            this.groupBox1.Controls.Add(this.labelNameStudy);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 96);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Текущее образование";
            // 
            // labelMonthsLeft
            // 
            this.labelMonthsLeft.AutoSize = true;
            this.labelMonthsLeft.Location = new System.Drawing.Point(6, 51);
            this.labelMonthsLeft.Name = "labelMonthsLeft";
            this.labelMonthsLeft.Size = new System.Drawing.Size(140, 13);
            this.labelMonthsLeft.TabIndex = 6;
            this.labelMonthsLeft.Text = "Месяцев осталось: 0 мес.";
            // 
            // labelStudyPlan
            // 
            this.labelStudyPlan.AutoSize = true;
            this.labelStudyPlan.Location = new System.Drawing.Point(6, 77);
            this.labelStudyPlan.Name = "labelStudyPlan";
            this.labelStudyPlan.Size = new System.Drawing.Size(123, 13);
            this.labelStudyPlan.TabIndex = 5;
            this.labelStudyPlan.Text = "Выполнение плана: 0%";
            // 
            // labelPlan
            // 
            this.labelPlan.AutoSize = true;
            this.labelPlan.Location = new System.Drawing.Point(6, 64);
            this.labelPlan.Name = "labelPlan";
            this.labelPlan.Size = new System.Drawing.Size(53, 13);
            this.labelPlan.TabIndex = 4;
            this.labelPlan.Text = "План: 0%";
            // 
            // labelNameStudy
            // 
            this.labelNameStudy.AutoSize = true;
            this.labelNameStudy.Location = new System.Drawing.Point(6, 20);
            this.labelNameStudy.Name = "labelNameStudy";
            this.labelNameStudy.Size = new System.Drawing.Size(138, 13);
            this.labelNameStudy.TabIndex = 0;
            this.labelNameStudy.Text = "Образование: 11 классов";
            // 
            // buttonQualifications
            // 
            this.buttonQualifications.Location = new System.Drawing.Point(228, 101);
            this.buttonQualifications.Name = "buttonQualifications";
            this.buttonQualifications.Size = new System.Drawing.Size(157, 23);
            this.buttonQualifications.TabIndex = 7;
            this.buttonQualifications.Text = "Повышение квалификации";
            this.buttonQualifications.UseVisualStyleBackColor = true;
            this.buttonQualifications.Click += new System.EventHandler(this.buttonQualifications_Click);
            // 
            // buttonEducation
            // 
            this.buttonEducation.Location = new System.Drawing.Point(6, 19);
            this.buttonEducation.Name = "buttonEducation";
            this.buttonEducation.Size = new System.Drawing.Size(157, 23);
            this.buttonEducation.TabIndex = 8;
            this.buttonEducation.Text = "Образование";
            this.buttonEducation.UseVisualStyleBackColor = true;
            this.buttonEducation.Click += new System.EventHandler(this.buttonEducation_Click);
            // 
            // buttonDeduct
            // 
            this.buttonDeduct.Enabled = false;
            this.buttonDeduct.Location = new System.Drawing.Point(6, 48);
            this.buttonDeduct.Name = "buttonDeduct";
            this.buttonDeduct.Size = new System.Drawing.Size(157, 23);
            this.buttonDeduct.TabIndex = 9;
            this.buttonDeduct.Text = "Отчислиться";
            this.buttonDeduct.UseVisualStyleBackColor = true;
            this.buttonDeduct.Click += new System.EventHandler(this.buttonDeduct_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonEducation);
            this.groupBox2.Controls.Add(this.buttonDeduct);
            this.groupBox2.Location = new System.Drawing.Point(222, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 83);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Учеба";
            // 
            // Effort_Study
            // 
            this.Effort_Study.Location = new System.Drawing.Point(3, 114);
            this.Effort_Study.Name = "Effort_Study";
            this.Effort_Study.Size = new System.Drawing.Size(220, 77);
            this.Effort_Study.TabIndex = 12;
            this.Effort_Study.ValueChanged = "false";
            // 
            // Module_Training_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 198);
            this.Controls.Add(this.buttonQualifications);
            this.Controls.Add(this.Effort_Study);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Module_Training_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Обучение";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelStudyPlan;
        private System.Windows.Forms.Label labelPlan;
        private System.Windows.Forms.Label labelNameStudy;
        private System.Windows.Forms.Button buttonQualifications;
        private System.Windows.Forms.Button buttonEducation;
        private System.Windows.Forms.Label labelMonthsLeft;
        private System.Windows.Forms.Button buttonDeduct;
        private System.Windows.Forms.GroupBox groupBox2;
        private Module_UserControl.Effort_UserControl Effort_Study;
    }
}