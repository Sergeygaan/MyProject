namespace Module_UserControl
{
    partial class Effort_UserControl
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
            this.trackBarQuality = new System.Windows.Forms.TrackBar();
            this.groupBoxEffort = new System.Windows.Forms.GroupBox();
            this.labelTable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarQuality)).BeginInit();
            this.groupBoxEffort.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBarQuality
            // 
            this.trackBarQuality.LargeChange = 1;
            this.trackBarQuality.Location = new System.Drawing.Point(6, 19);
            this.trackBarQuality.Maximum = 20;
            this.trackBarQuality.Minimum = 1;
            this.trackBarQuality.Name = "trackBarQuality";
            this.trackBarQuality.Size = new System.Drawing.Size(149, 45);
            this.trackBarQuality.TabIndex = 6;
            this.trackBarQuality.Value = 10;
            this.trackBarQuality.ValueChanged += new System.EventHandler(this.trackBarQualityStudy_ValueChanged);
            // 
            // groupBoxEffort
            // 
            this.groupBoxEffort.Controls.Add(this.labelTable);
            this.groupBoxEffort.Controls.Add(this.trackBarQuality);
            this.groupBoxEffort.Location = new System.Drawing.Point(3, 3);
            this.groupBoxEffort.Name = "groupBoxEffort";
            this.groupBoxEffort.Size = new System.Drawing.Size(210, 70);
            this.groupBoxEffort.TabIndex = 7;
            this.groupBoxEffort.TabStop = false;
            this.groupBoxEffort.Text = "Затраты усилий";
            // 
            // labelTable
            // 
            this.labelTable.AutoSize = true;
            this.labelTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTable.Location = new System.Drawing.Point(150, 28);
            this.labelTable.Name = "labelTable";
            this.labelTable.Size = new System.Drawing.Size(49, 20);
            this.labelTable.TabIndex = 7;
            this.labelTable.Text = "50 %";
            // 
            // Effort_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxEffort);
            this.Name = "Effort_UserControl";
            this.Size = new System.Drawing.Size(248, 77);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarQuality)).EndInit();
            this.groupBoxEffort.ResumeLayout(false);
            this.groupBoxEffort.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarQuality;
        private System.Windows.Forms.GroupBox groupBoxEffort;
        private System.Windows.Forms.Label labelTable;
    }
}
