namespace Module_UserControl
{
    partial class GameTimer_UserControl
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
            this.labelMinuteAndHour = new System.Windows.Forms.Label();
            this.labelMouthAndYear = new System.Windows.Forms.Label();
            this.groupBoxGameTimer = new System.Windows.Forms.GroupBox();
            this.groupBoxGameTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMinuteAndHour
            // 
            this.labelMinuteAndHour.AutoSize = true;
            this.labelMinuteAndHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMinuteAndHour.Location = new System.Drawing.Point(6, 16);
            this.labelMinuteAndHour.Name = "labelMinuteAndHour";
            this.labelMinuteAndHour.Size = new System.Drawing.Size(87, 31);
            this.labelMinuteAndHour.TabIndex = 0;
            this.labelMinuteAndHour.Text = "00:00";
            // 
            // labelMouthAndYear
            // 
            this.labelMouthAndYear.AutoSize = true;
            this.labelMouthAndYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMouthAndYear.Location = new System.Drawing.Point(18, 47);
            this.labelMouthAndYear.Name = "labelMouthAndYear";
            this.labelMouthAndYear.Size = new System.Drawing.Size(62, 16);
            this.labelMouthAndYear.TabIndex = 1;
            this.labelMouthAndYear.Text = "янв 2000";
            // 
            // groupBoxGameTimer
            // 
            this.groupBoxGameTimer.Controls.Add(this.labelMinuteAndHour);
            this.groupBoxGameTimer.Controls.Add(this.labelMouthAndYear);
            this.groupBoxGameTimer.Location = new System.Drawing.Point(3, 0);
            this.groupBoxGameTimer.Name = "groupBoxGameTimer";
            this.groupBoxGameTimer.Size = new System.Drawing.Size(99, 65);
            this.groupBoxGameTimer.TabIndex = 2;
            this.groupBoxGameTimer.TabStop = false;
            this.groupBoxGameTimer.Text = "Игровое время";
            // 
            // GameTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxGameTimer);
            this.Name = "GameTimer";
            this.Size = new System.Drawing.Size(107, 71);
            this.groupBoxGameTimer.ResumeLayout(false);
            this.groupBoxGameTimer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMinuteAndHour;
        private System.Windows.Forms.Label labelMouthAndYear;
        private System.Windows.Forms.GroupBox groupBoxGameTimer;
    }
}
