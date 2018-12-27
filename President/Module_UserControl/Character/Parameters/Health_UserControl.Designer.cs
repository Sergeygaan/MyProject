using System.Windows.Forms;

namespace Module_UserControl
{
    partial class Health_UserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressBar = new ProgressBarEx();

            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxHealth = new System.Windows.Forms.GroupBox();
            this.groupBoxHealth.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.RoyalBlue;
            this.progressBar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.progressBar.Location = new System.Drawing.Point(6, 19);
            this.progressBar.Maximum = 1000;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(230, 23);
            this.progressBar.TabIndex = 10;
            this.progressBar.Value = 1000;
            // 
            // groupBoxHealth
            // 
            this.groupBoxHealth.Controls.Add(this.progressBar);
            this.groupBoxHealth.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBoxHealth.Location = new System.Drawing.Point(3, 3);
            this.groupBoxHealth.Name = "groupBoxHealth";
            this.groupBoxHealth.Size = new System.Drawing.Size(240, 48);
            this.groupBoxHealth.TabIndex = 12;
            this.groupBoxHealth.TabStop = false;
            this.groupBoxHealth.Text = "Здоровье";
            // 
            // Health_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxHealth);
            this.Name = "Health_UserControl";
            this.Size = new System.Drawing.Size(250, 55);
            this.groupBoxHealth.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ProgressBar progressBar;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupBoxHealth;
    }
}
