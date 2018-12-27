using System.Windows.Forms;

namespace Module_UserControl
{
    partial class Mood_UserControl
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
            this.groupBoxMood = new System.Windows.Forms.GroupBox();
            this.groupBoxMood.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Green;
            this.progressBar.ForeColor = System.Drawing.Color.Green;
            this.progressBar.Location = new System.Drawing.Point(6, 19);
            this.progressBar.Maximum = 1000;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(230, 23);
            this.progressBar.TabIndex = 10;
            this.progressBar.Value = 1000;
            // 
            // groupBoxMood
            // 
            this.groupBoxMood.Controls.Add(this.progressBar);
            this.groupBoxMood.ForeColor = System.Drawing.Color.Green;
            this.groupBoxMood.Location = new System.Drawing.Point(3, 3);
            this.groupBoxMood.Name = "groupBoxMood";
            this.groupBoxMood.Size = new System.Drawing.Size(240, 48);
            this.groupBoxMood.TabIndex = 12;
            this.groupBoxMood.TabStop = false;
            this.groupBoxMood.Text = "Настроение";
            // 
            // Mood_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxMood);
            this.Name = "Mood_UserControl";
            this.Size = new System.Drawing.Size(250, 55);
            this.groupBoxMood.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ProgressBar progressBar;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupBoxMood;
    }
}
