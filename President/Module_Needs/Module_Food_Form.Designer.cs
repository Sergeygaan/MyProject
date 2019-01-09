namespace Module_Needs
{
    partial class Module_Food_Form
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
            this.food_UserControl1 = new Module_UserControl.Food_UserControl();
            this.buttonBun = new System.Windows.Forms.Button();
            this.buttonBeachPackage = new System.Windows.Forms.Button();
            this.buttonСanteen = new System.Windows.Forms.Button();
            this.buttonCafe = new System.Windows.Forms.Button();
            this.buttonRestaurant = new System.Windows.Forms.Button();
            this.labelBun = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // food_UserControl1
            // 
            this.food_UserControl1.Location = new System.Drawing.Point(5, 155);
            this.food_UserControl1.Name = "food_UserControl1";
            this.food_UserControl1.Size = new System.Drawing.Size(250, 55);
            this.food_UserControl1.TabIndex = 0;
            // 
            // buttonBun
            // 
            this.buttonBun.Location = new System.Drawing.Point(12, 12);
            this.buttonBun.Name = "buttonBun";
            this.buttonBun.Size = new System.Drawing.Size(163, 23);
            this.buttonBun.TabIndex = 1;
            this.buttonBun.Text = "Булочка - 5 $";
            this.buttonBun.UseVisualStyleBackColor = true;
            this.buttonBun.Click += new System.EventHandler(this.buttonBun_Click);
            // 
            // buttonBeachPackage
            // 
            this.buttonBeachPackage.Location = new System.Drawing.Point(12, 41);
            this.buttonBeachPackage.Name = "buttonBeachPackage";
            this.buttonBeachPackage.Size = new System.Drawing.Size(163, 23);
            this.buttonBeachPackage.TabIndex = 2;
            this.buttonBeachPackage.Text = "Бич-пакет - 20 $";
            this.buttonBeachPackage.UseVisualStyleBackColor = true;
            this.buttonBeachPackage.Click += new System.EventHandler(this.buttonBeachPackage_Click);
            // 
            // buttonСanteen
            // 
            this.buttonСanteen.Location = new System.Drawing.Point(12, 70);
            this.buttonСanteen.Name = "buttonСanteen";
            this.buttonСanteen.Size = new System.Drawing.Size(163, 23);
            this.buttonСanteen.TabIndex = 3;
            this.buttonСanteen.Text = "Поесть в столовой - 50 $";
            this.buttonСanteen.UseVisualStyleBackColor = true;
            this.buttonСanteen.Click += new System.EventHandler(this.buttonСanteen_Click);
            // 
            // buttonCafe
            // 
            this.buttonCafe.Location = new System.Drawing.Point(12, 99);
            this.buttonCafe.Name = "buttonCafe";
            this.buttonCafe.Size = new System.Drawing.Size(163, 23);
            this.buttonCafe.TabIndex = 4;
            this.buttonCafe.Text = "Поесть в кафе - 100 $";
            this.buttonCafe.UseVisualStyleBackColor = true;
            this.buttonCafe.Click += new System.EventHandler(this.buttonCafe_Click);
            // 
            // buttonRestaurant
            // 
            this.buttonRestaurant.Location = new System.Drawing.Point(12, 128);
            this.buttonRestaurant.Name = "buttonRestaurant";
            this.buttonRestaurant.Size = new System.Drawing.Size(163, 23);
            this.buttonRestaurant.TabIndex = 5;
            this.buttonRestaurant.Text = "Поесть в ресторане - 250 $";
            this.buttonRestaurant.UseVisualStyleBackColor = true;
            this.buttonRestaurant.Click += new System.EventHandler(this.buttonRestaurant_Click);
            // 
            // labelBun
            // 
            this.labelBun.AutoSize = true;
            this.labelBun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBun.ForeColor = System.Drawing.Color.Red;
            this.labelBun.Location = new System.Drawing.Point(181, 15);
            this.labelBun.Name = "labelBun";
            this.labelBun.Size = new System.Drawing.Size(53, 16);
            this.labelBun.TabIndex = 6;
            this.labelBun.Text = "+ 1...5%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(181, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "+ 5...10%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(181, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "+ 10...25%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(181, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "+ 25...50%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(181, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "+ 50...100%";
            // 
            // Module_Food_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 217);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBun);
            this.Controls.Add(this.buttonRestaurant);
            this.Controls.Add(this.buttonCafe);
            this.Controls.Add(this.buttonСanteen);
            this.Controls.Add(this.buttonBeachPackage);
            this.Controls.Add(this.buttonBun);
            this.Controls.Add(this.food_UserControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Module_Food_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Еда";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Module_UserControl.Food_UserControl food_UserControl1;
        private System.Windows.Forms.Button buttonBun;
        private System.Windows.Forms.Button buttonBeachPackage;
        private System.Windows.Forms.Button buttonСanteen;
        private System.Windows.Forms.Button buttonCafe;
        private System.Windows.Forms.Button buttonRestaurant;
        private System.Windows.Forms.Label labelBun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}