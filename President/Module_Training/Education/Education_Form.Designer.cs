namespace Module_Training
{
    partial class Education_Form
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
            this.buttonCollege = new System.Windows.Forms.Button();
            this.buttonBaccalaureate = new System.Windows.Forms.Button();
            this.buttonMaster = new System.Windows.Forms.Button();
            this.buttonGraduateSchool = new System.Windows.Forms.Button();
            this.buttonPhD = new System.Windows.Forms.Button();
            this.labelCollege = new System.Windows.Forms.Label();
            this.labelBaccalaureate = new System.Windows.Forms.Label();
            this.labelPhD = new System.Windows.Forms.Label();
            this.labelGraduateSchool = new System.Windows.Forms.Label();
            this.labelMaster = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCollege
            // 
            this.buttonCollege.Location = new System.Drawing.Point(13, 12);
            this.buttonCollege.Name = "buttonCollege";
            this.buttonCollege.Size = new System.Drawing.Size(105, 23);
            this.buttonCollege.TabIndex = 0;
            this.buttonCollege.Text = "Техникум";
            this.buttonCollege.UseVisualStyleBackColor = true;
            this.buttonCollege.Click += new System.EventHandler(this.buttonCollege_Click);
            // 
            // buttonBaccalaureate
            // 
            this.buttonBaccalaureate.Location = new System.Drawing.Point(12, 41);
            this.buttonBaccalaureate.Name = "buttonBaccalaureate";
            this.buttonBaccalaureate.Size = new System.Drawing.Size(105, 23);
            this.buttonBaccalaureate.TabIndex = 1;
            this.buttonBaccalaureate.Text = "Бакалавриат";
            this.buttonBaccalaureate.UseVisualStyleBackColor = true;
            this.buttonBaccalaureate.Click += new System.EventHandler(this.buttonBaccalaureate_Click);
            // 
            // buttonMaster
            // 
            this.buttonMaster.Location = new System.Drawing.Point(12, 70);
            this.buttonMaster.Name = "buttonMaster";
            this.buttonMaster.Size = new System.Drawing.Size(105, 23);
            this.buttonMaster.TabIndex = 2;
            this.buttonMaster.Text = "Магистратура";
            this.buttonMaster.UseVisualStyleBackColor = true;
            this.buttonMaster.Click += new System.EventHandler(this.buttonMaster_Click);
            // 
            // buttonGraduateSchool
            // 
            this.buttonGraduateSchool.Location = new System.Drawing.Point(12, 99);
            this.buttonGraduateSchool.Name = "buttonGraduateSchool";
            this.buttonGraduateSchool.Size = new System.Drawing.Size(105, 23);
            this.buttonGraduateSchool.TabIndex = 3;
            this.buttonGraduateSchool.Text = "Аспирантура";
            this.buttonGraduateSchool.UseVisualStyleBackColor = true;
            this.buttonGraduateSchool.Click += new System.EventHandler(this.buttonGraduateSchool_Click);
            // 
            // buttonPhD
            // 
            this.buttonPhD.Location = new System.Drawing.Point(12, 128);
            this.buttonPhD.Name = "buttonPhD";
            this.buttonPhD.Size = new System.Drawing.Size(105, 23);
            this.buttonPhD.TabIndex = 4;
            this.buttonPhD.Text = "Доктор наук";
            this.buttonPhD.UseVisualStyleBackColor = true;
            this.buttonPhD.Click += new System.EventHandler(this.buttonPhD_Click);
            // 
            // labelCollege
            // 
            this.labelCollege.AutoSize = true;
            this.labelCollege.Location = new System.Drawing.Point(124, 17);
            this.labelCollege.Name = "labelCollege";
            this.labelCollege.Size = new System.Drawing.Size(176, 13);
            this.labelCollege.TabIndex = 5;
            this.labelCollege.Text = "Длительность обучения - 36 мес.";
            // 
            // labelBaccalaureate
            // 
            this.labelBaccalaureate.AutoSize = true;
            this.labelBaccalaureate.Location = new System.Drawing.Point(123, 46);
            this.labelBaccalaureate.Name = "labelBaccalaureate";
            this.labelBaccalaureate.Size = new System.Drawing.Size(176, 13);
            this.labelBaccalaureate.TabIndex = 6;
            this.labelBaccalaureate.Text = "Длительность обучения - 48 мес.";
            // 
            // labelPhD
            // 
            this.labelPhD.AutoSize = true;
            this.labelPhD.Location = new System.Drawing.Point(124, 133);
            this.labelPhD.Name = "labelPhD";
            this.labelPhD.Size = new System.Drawing.Size(176, 13);
            this.labelPhD.TabIndex = 7;
            this.labelPhD.Text = "Длительность обучения - 60 мес.";
            // 
            // labelGraduateSchool
            // 
            this.labelGraduateSchool.AutoSize = true;
            this.labelGraduateSchool.Location = new System.Drawing.Point(124, 104);
            this.labelGraduateSchool.Name = "labelGraduateSchool";
            this.labelGraduateSchool.Size = new System.Drawing.Size(176, 13);
            this.labelGraduateSchool.TabIndex = 8;
            this.labelGraduateSchool.Text = "Длительность обучения - 48 мес.";
            // 
            // labelMaster
            // 
            this.labelMaster.AutoSize = true;
            this.labelMaster.Location = new System.Drawing.Point(124, 75);
            this.labelMaster.Name = "labelMaster";
            this.labelMaster.Size = new System.Drawing.Size(176, 13);
            this.labelMaster.TabIndex = 9;
            this.labelMaster.Text = "Длительность обучения - 24 мес.";
            // 
            // Education_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 161);
            this.Controls.Add(this.labelMaster);
            this.Controls.Add(this.labelGraduateSchool);
            this.Controls.Add(this.labelPhD);
            this.Controls.Add(this.labelBaccalaureate);
            this.Controls.Add(this.labelCollege);
            this.Controls.Add(this.buttonPhD);
            this.Controls.Add(this.buttonGraduateSchool);
            this.Controls.Add(this.buttonMaster);
            this.Controls.Add(this.buttonBaccalaureate);
            this.Controls.Add(this.buttonCollege);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Education_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Образование";
            this.Load += new System.EventHandler(this.Education_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCollege;
        private System.Windows.Forms.Button buttonBaccalaureate;
        private System.Windows.Forms.Button buttonMaster;
        private System.Windows.Forms.Button buttonGraduateSchool;
        private System.Windows.Forms.Button buttonPhD;
        private System.Windows.Forms.Label labelCollege;
        private System.Windows.Forms.Label labelBaccalaureate;
        private System.Windows.Forms.Label labelPhD;
        private System.Windows.Forms.Label labelGraduateSchool;
        private System.Windows.Forms.Label labelMaster;
    }
}