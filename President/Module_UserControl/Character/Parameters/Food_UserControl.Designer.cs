using System.Windows.Forms;

namespace Module_UserControl
{
    partial class Food_UserControl
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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxFood = new System.Windows.Forms.GroupBox();
            this.progressBar = new ProgressBarEx();

            this.groupBoxFood.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFood
            // 
            this.groupBoxFood.Controls.Add(this.progressBar);
            this.groupBoxFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBoxFood.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFood.Name = "groupBoxFood";
            this.groupBoxFood.Size = new System.Drawing.Size(240, 48);
            this.groupBoxFood.TabIndex = 12;
            this.groupBoxFood.TabStop = false;
            this.groupBoxFood.Text = "Еда";
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.progressBar.Location = new System.Drawing.Point(6, 19);
            this.progressBar.Maximum = 1000;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(230, 23);
            this.progressBar.TabIndex = 10;
            this.progressBar.Value = 1000;
            // 
            // Food_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxFood);
            this.Name = "Food_UserControl";
            this.Size = new System.Drawing.Size(250, 55);
            this.groupBoxFood.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ProgressBar progressBar;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupBoxFood;
    }
}
