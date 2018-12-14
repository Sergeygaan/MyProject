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
            this.listBoxWork = new Netdev.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelListWork
            // 
            this.labelListWork.AutoSize = true;
            this.labelListWork.Location = new System.Drawing.Point(13, 13);
            this.labelListWork.Name = "labelListWork";
            this.labelListWork.Size = new System.Drawing.Size(79, 13);
            this.labelListWork.TabIndex = 1;
            this.labelListWork.Text = "Список работ:";
            // 
            // buttonOutside
            // 
            this.buttonOutside.Location = new System.Drawing.Point(12, 163);
            this.buttonOutside.Name = "buttonOutside";
            this.buttonOutside.Size = new System.Drawing.Size(86, 23);
            this.buttonOutside.TabIndex = 2;
            this.buttonOutside.Text = "На улице";
            this.buttonOutside.UseVisualStyleBackColor = true;
            this.buttonOutside.Click += new System.EventHandler(this.Outside_Click);
            // 
            // buttonNewspaper
            // 
            this.buttonNewspaper.Location = new System.Drawing.Point(12, 192);
            this.buttonNewspaper.Name = "buttonNewspaper";
            this.buttonNewspaper.Size = new System.Drawing.Size(86, 23);
            this.buttonNewspaper.TabIndex = 3;
            this.buttonNewspaper.Text = "В газете";
            this.buttonNewspaper.UseVisualStyleBackColor = true;
            this.buttonNewspaper.Click += new System.EventHandler(this.Newspaper_Click);
            // 
            // buttonInternet
            // 
            this.buttonInternet.Location = new System.Drawing.Point(12, 221);
            this.buttonInternet.Name = "buttonInternet";
            this.buttonInternet.Size = new System.Drawing.Size(86, 23);
            this.buttonInternet.TabIndex = 4;
            this.buttonInternet.Text = "В интернете";
            this.buttonInternet.UseVisualStyleBackColor = true;
            this.buttonInternet.Click += new System.EventHandler(this.Internet_Click);
            // 
            // buttonGetJob
            // 
            this.buttonGetJob.Location = new System.Drawing.Point(114, 163);
            this.buttonGetJob.Name = "buttonGetJob";
            this.buttonGetJob.Size = new System.Drawing.Size(86, 23);
            this.buttonGetJob.TabIndex = 5;
            this.buttonGetJob.Text = "Устроиться";
            this.buttonGetJob.UseVisualStyleBackColor = true;
            this.buttonGetJob.Click += new System.EventHandler(this.GetJob_Click);
            // 
            // listBoxWork
            // 
            this.listBoxWork.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxWork.FormattingEnabled = true;
            this.listBoxWork.Location = new System.Drawing.Point(16, 29);
            this.listBoxWork.Name = "listBoxWork";
            this.listBoxWork.Size = new System.Drawing.Size(433, 121);
            this.listBoxWork.TabIndex = 6;
            this.listBoxWork.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBoxWork_MouseMove);
            // 
            // Find_Job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 297);
            this.Controls.Add(this.listBoxWork);
            this.Controls.Add(this.buttonGetJob);
            this.Controls.Add(this.buttonInternet);
            this.Controls.Add(this.buttonNewspaper);
            this.Controls.Add(this.buttonOutside);
            this.Controls.Add(this.labelListWork);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Find_Job";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Найти работу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelListWork;
        private System.Windows.Forms.Button buttonOutside;
        private System.Windows.Forms.Button buttonNewspaper;
        private System.Windows.Forms.Button buttonInternet;
        private System.Windows.Forms.Button buttonGetJob;
        private Netdev.Windows.Forms.ListBox listBoxWork;
        private System.Windows.Forms.ToolTip toolTip;
    }
}