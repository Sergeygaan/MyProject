namespace Module_Work
{
    partial class Find_Job
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
            this.components = new System.ComponentModel.Container();
            this.labelListWork = new System.Windows.Forms.Label();
            this.buttonOutside = new System.Windows.Forms.Button();
            this.buttonNewspaper = new System.Windows.Forms.Button();
            this.buttonInternet = new System.Windows.Forms.Button();
            this.buttonGetJob = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listWork = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDemand = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelListWork
            // 
            this.labelListWork.AutoSize = true;
            this.labelListWork.Location = new System.Drawing.Point(143, 15);
            this.labelListWork.Name = "labelListWork";
            this.labelListWork.Size = new System.Drawing.Size(79, 13);
            this.labelListWork.TabIndex = 1;
            this.labelListWork.Text = "Список работ:";
            // 
            // buttonOutside
            // 
            this.buttonOutside.Location = new System.Drawing.Point(7, 19);
            this.buttonOutside.Name = "buttonOutside";
            this.buttonOutside.Size = new System.Drawing.Size(118, 23);
            this.buttonOutside.TabIndex = 2;
            this.buttonOutside.Text = "На улице";
            this.buttonOutside.UseVisualStyleBackColor = true;
            this.buttonOutside.Click += new System.EventHandler(this.Outside_Click);
            // 
            // buttonNewspaper
            // 
            this.buttonNewspaper.Location = new System.Drawing.Point(6, 48);
            this.buttonNewspaper.Name = "buttonNewspaper";
            this.buttonNewspaper.Size = new System.Drawing.Size(119, 23);
            this.buttonNewspaper.TabIndex = 3;
            this.buttonNewspaper.Text = "В газете - 5$";
            this.buttonNewspaper.UseVisualStyleBackColor = true;
            this.buttonNewspaper.Click += new System.EventHandler(this.Newspaper_Click);
            // 
            // buttonInternet
            // 
            this.buttonInternet.Location = new System.Drawing.Point(6, 77);
            this.buttonInternet.Name = "buttonInternet";
            this.buttonInternet.Size = new System.Drawing.Size(119, 23);
            this.buttonInternet.TabIndex = 4;
            this.buttonInternet.Text = "В интернете";
            this.buttonInternet.UseVisualStyleBackColor = true;
            this.buttonInternet.Click += new System.EventHandler(this.Internet_Click);
            // 
            // buttonGetJob
            // 
            this.buttonGetJob.Location = new System.Drawing.Point(16, 189);
            this.buttonGetJob.Name = "buttonGetJob";
            this.buttonGetJob.Size = new System.Drawing.Size(118, 23);
            this.buttonGetJob.TabIndex = 5;
            this.buttonGetJob.Text = "Устроиться";
            this.buttonGetJob.UseVisualStyleBackColor = true;
            this.buttonGetJob.Click += new System.EventHandler(this.GetJob_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonOutside);
            this.groupBox1.Controls.Add(this.buttonNewspaper);
            this.groupBox1.Controls.Add(this.buttonInternet);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 109);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск работы";
            // 
            // listWork
            // 
            this.listWork.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listWork.FullRowSelect = true;
            this.listWork.Location = new System.Drawing.Point(146, 31);
            this.listWork.Name = "listWork";
            this.listWork.ShowItemToolTips = true;
            this.listWork.Size = new System.Drawing.Size(569, 183);
            this.listWork.TabIndex = 9;
            this.listWork.UseCompatibleStateImageBehavior = false;
            this.listWork.View = System.Windows.Forms.View.Details;
            this.listWork.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listWork_ColumnWidthChanging);
            this.listWork.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listWork_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Сфера деятельности";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Профессия";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Оклад";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Квалификация";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Востребованность";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 111;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "План";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonDemand
            // 
            this.buttonDemand.Location = new System.Drawing.Point(16, 127);
            this.buttonDemand.Name = "buttonDemand";
            this.buttonDemand.Size = new System.Drawing.Size(118, 23);
            this.buttonDemand.TabIndex = 5;
            this.buttonDemand.Text = "Востребованность";
            this.buttonDemand.UseVisualStyleBackColor = true;
            this.buttonDemand.Click += new System.EventHandler(this.buttonDemand_Click);
            // 
            // Find_Job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 224);
            this.Controls.Add(this.buttonDemand);
            this.Controls.Add(this.listWork);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonGetJob);
            this.Controls.Add(this.labelListWork);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Find_Job";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Найти работу";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelListWork;
        private System.Windows.Forms.Button buttonOutside;
        private System.Windows.Forms.Button buttonNewspaper;
        private System.Windows.Forms.Button buttonInternet;
        private System.Windows.Forms.Button buttonGetJob;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listWork;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buttonDemand;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}