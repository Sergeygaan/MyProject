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
            this.SuspendLayout();
            // 
            // buttonFindJob
            // 
            this.buttonFindJob.Location = new System.Drawing.Point(13, 13);
            this.buttonFindJob.Name = "buttonFindJob";
            this.buttonFindJob.Size = new System.Drawing.Size(90, 23);
            this.buttonFindJob.TabIndex = 0;
            this.buttonFindJob.Text = "Найти работу";
            this.buttonFindJob.UseVisualStyleBackColor = true;
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(12, 75);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(90, 23);
            this.buttonQuit.TabIndex = 1;
            this.buttonQuit.Text = "Уволиться";
            this.buttonQuit.UseVisualStyleBackColor = true;
            // 
            // Module_Work_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 286);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonFindJob);
            this.Name = "Module_Work_Form";
            this.Text = "Module_Work_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFindJob;
        private System.Windows.Forms.Button buttonQuit;
    }
}