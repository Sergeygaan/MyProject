namespace Module_UserControl.ToDoList
{
    partial class ToDoList_UserControl
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
            this.groupBoxToDoList = new System.Windows.Forms.GroupBox();
            this.listBox1 = new Netdev.Windows.Forms.ListBox();
            this.groupBoxToDoList.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxToDoList
            // 
            this.groupBoxToDoList.Controls.Add(this.listBox1);
            this.groupBoxToDoList.Location = new System.Drawing.Point(3, 3);
            this.groupBoxToDoList.Name = "groupBoxToDoList";
            this.groupBoxToDoList.Size = new System.Drawing.Size(200, 100);
            this.groupBoxToDoList.TabIndex = 0;
            this.groupBoxToDoList.TabStop = false;
            this.groupBoxToDoList.Text = "Список дел";
            // 
            // listBox1
            // 
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(187, 69);
            this.listBox1.TabIndex = 0;
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxToDoList);
            this.Name = "ToDoList";
            this.Size = new System.Drawing.Size(213, 110);
            this.groupBoxToDoList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxToDoList;
        private Netdev.Windows.Forms.ListBox listBox1;
    }
}
