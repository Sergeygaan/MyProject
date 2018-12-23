namespace Module_Work
{
    partial class Module_Work_Form
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
            this.buttonFindJob = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelWorkPlan = new System.Windows.Forms.Label();
            this.labelPlan = new System.Windows.Forms.Label();
            this.labelLine = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelProfessionName = new System.Windows.Forms.Label();
            this.trackBarQualityWork = new System.Windows.Forms.TrackBar();
            this.labelTableWork = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarQualityWork)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFindJob
            // 
            this.buttonFindJob.Location = new System.Drawing.Point(217, 12);
            this.buttonFindJob.Name = "buttonFindJob";
            this.buttonFindJob.Size = new System.Drawing.Size(104, 23);
            this.buttonFindJob.TabIndex = 0;
            this.buttonFindJob.Text = "Найти работу";
            this.buttonFindJob.UseVisualStyleBackColor = true;
            this.buttonFindJob.Click += new System.EventHandler(this.ButtonFindJob_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Enabled = false;
            this.buttonQuit.Location = new System.Drawing.Point(217, 51);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(104, 23);
            this.buttonQuit.TabIndex = 1;
            this.buttonQuit.Text = "Уволиться";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.QuitWork_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelWorkPlan);
            this.groupBox1.Controls.Add(this.labelPlan);
            this.groupBox1.Controls.Add(this.labelLine);
            this.groupBox1.Controls.Add(this.labelSalary);
            this.groupBox1.Controls.Add(this.labelProfessionName);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 121);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Текущая работа";
            // 
            // labelWorkPlan
            // 
            this.labelWorkPlan.AutoSize = true;
            this.labelWorkPlan.Location = new System.Drawing.Point(6, 100);
            this.labelWorkPlan.Name = "labelWorkPlan";
            this.labelWorkPlan.Size = new System.Drawing.Size(123, 13);
            this.labelWorkPlan.TabIndex = 5;
            this.labelWorkPlan.Text = "Выполнение плана: 0%";
            // 
            // labelPlan
            // 
            this.labelPlan.AutoSize = true;
            this.labelPlan.Location = new System.Drawing.Point(6, 83);
            this.labelPlan.Name = "labelPlan";
            this.labelPlan.Size = new System.Drawing.Size(53, 13);
            this.labelPlan.TabIndex = 4;
            this.labelPlan.Text = "План: 0%";
            // 
            // labelLine
            // 
            this.labelLine.AutoSize = true;
            this.labelLine.Location = new System.Drawing.Point(6, 61);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(127, 13);
            this.labelLine.TabIndex = 3;
            this.labelLine.Text = "____________________";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(6, 48);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(57, 13);
            this.labelSalary.TabIndex = 1;
            this.labelSalary.Text = "Оклад: 0$";
            // 
            // labelProfessionName
            // 
            this.labelProfessionName.AutoSize = true;
            this.labelProfessionName.Location = new System.Drawing.Point(6, 29);
            this.labelProfessionName.Name = "labelProfessionName";
            this.labelProfessionName.Size = new System.Drawing.Size(139, 13);
            this.labelProfessionName.TabIndex = 0;
            this.labelProfessionName.Text = "Профессия: Безработный";
            // 
            // trackBarQualityWork
            // 
            this.trackBarQualityWork.LargeChange = 1;
            this.trackBarQualityWork.Location = new System.Drawing.Point(7, 139);
            this.trackBarQualityWork.Minimum = 1;
            this.trackBarQualityWork.Name = "trackBarQualityWork";
            this.trackBarQualityWork.Size = new System.Drawing.Size(149, 45);
            this.trackBarQualityWork.TabIndex = 1;
            this.trackBarQualityWork.Value = 5;
            this.trackBarQualityWork.ValueChanged += new System.EventHandler(this.trackBarQualityWork_ValueChanged);
            // 
            // labelTableWork
            // 
            this.labelTableWork.AutoSize = true;
            this.labelTableWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTableWork.Location = new System.Drawing.Point(162, 145);
            this.labelTableWork.Name = "labelTableWork";
            this.labelTableWork.Size = new System.Drawing.Size(49, 20);
            this.labelTableWork.TabIndex = 4;
            this.labelTableWork.Text = "50 %";
            // 
            // Module_Work_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 182);
            this.Controls.Add(this.labelTableWork);
            this.Controls.Add(this.trackBarQualityWork);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonFindJob);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Module_Work_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Работа";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarQualityWork)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFindJob;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelProfessionName;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelWorkPlan;
        private System.Windows.Forms.Label labelPlan;
        private System.Windows.Forms.Label labelLine;
        private System.Windows.Forms.TrackBar trackBarQualityWork;
        private System.Windows.Forms.Label labelTableWork;
    }
}