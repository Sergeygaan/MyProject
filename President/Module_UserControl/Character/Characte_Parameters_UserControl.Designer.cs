namespace Module_UserControl
{
    partial class Characte_Parameters_UserControl
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
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelStudy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Controls.Add(this.label2);
            this.groupBoxParameters.Controls.Add(this.label1);
            this.groupBoxParameters.Controls.Add(this.labelStudy);
            this.groupBoxParameters.Controls.Add(this.labelAge);
            this.groupBoxParameters.Location = new System.Drawing.Point(3, 3);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(198, 123);
            this.groupBoxParameters.TabIndex = 0;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Параметры";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(6, 16);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(87, 13);
            this.labelAge.TabIndex = 0;
            this.labelAge.Text = "Возраст: 18 лет";
            // 
            // labelStudy
            // 
            this.labelStudy.AutoSize = true;
            this.labelStudy.Location = new System.Drawing.Point(6, 31);
            this.labelStudy.Name = "labelStudy";
            this.labelStudy.Size = new System.Drawing.Size(138, 13);
            this.labelStudy.TabIndex = 1;
            this.labelStudy.Text = "Образование: 11 классов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Автомабиль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Квартира";
            // 
            // Characte_Parameters_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxParameters);
            this.Name = "Characte_Parameters_UserControl";
            this.Size = new System.Drawing.Size(204, 129);
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelStudy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
