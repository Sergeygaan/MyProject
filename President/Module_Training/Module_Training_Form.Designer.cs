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
            this.labelTableStudy = new System.Windows.Forms.Label();
            this.trackBarQualityStudy = new System.Windows.Forms.TrackBar();
            this.buttonQualifications = new System.Windows.Forms.Button();
            this.buttonEducation = new System.Windows.Forms.Button();
            this.buttonDeduct = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSelfDevelopment = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarQualityStudy)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(200, 96);
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
            // labelTableStudy
            // 
            this.labelTableStudy.AutoSize = true;
            this.labelTableStudy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTableStudy.Location = new System.Drawing.Point(163, 123);
            this.labelTableStudy.Name = "labelTableStudy";
            this.labelTableStudy.Size = new System.Drawing.Size(49, 20);
            this.labelTableStudy.TabIndex = 6;
            this.labelTableStudy.Text = "50 %";
            // 
            // trackBarQualityStudy
            // 
            this.trackBarQualityStudy.LargeChange = 1;
            this.trackBarQualityStudy.Location = new System.Drawing.Point(12, 120);
            this.trackBarQualityStudy.Minimum = 1;
            this.trackBarQualityStudy.Name = "trackBarQualityStudy";
            this.trackBarQualityStudy.Size = new System.Drawing.Size(149, 45);
            this.trackBarQualityStudy.TabIndex = 5;
            this.trackBarQualityStudy.Value = 5;
            this.trackBarQualityStudy.ValueChanged += new System.EventHandler(this.trackBarQualityStudy_ValueChanged);
            // 
            // buttonQualifications
            // 
            this.buttonQualifications.Location = new System.Drawing.Point(6, 19);
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
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 83);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Учеба";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonSelfDevelopment);
            this.groupBox3.Controls.Add(this.buttonQualifications);
            this.groupBox3.Location = new System.Drawing.Point(218, 101);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(173, 79);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Развитие";
            // 
            // buttonSelfDevelopment
            // 
            this.buttonSelfDevelopment.Location = new System.Drawing.Point(6, 48);
            this.buttonSelfDevelopment.Name = "buttonSelfDevelopment";
            this.buttonSelfDevelopment.Size = new System.Drawing.Size(157, 23);
            this.buttonSelfDevelopment.TabIndex = 8;
            this.buttonSelfDevelopment.Text = "Саморазвитие";
            this.buttonSelfDevelopment.UseVisualStyleBackColor = true;
            this.buttonSelfDevelopment.Click += new System.EventHandler(this.buttonSelfDevelopment_Click);
            // 
            // Module_Training_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 187);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelTableStudy);
            this.Controls.Add(this.trackBarQualityStudy);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Module_Training_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Обучение";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarQualityStudy)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelStudyPlan;
        private System.Windows.Forms.Label labelPlan;
        private System.Windows.Forms.Label labelNameStudy;
        private System.Windows.Forms.Label labelTableStudy;
        private System.Windows.Forms.TrackBar trackBarQualityStudy;
        private System.Windows.Forms.Button buttonQualifications;
        private System.Windows.Forms.Button buttonEducation;
        private System.Windows.Forms.Label labelMonthsLeft;
        private System.Windows.Forms.Button buttonDeduct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonSelfDevelopment;
    }
}