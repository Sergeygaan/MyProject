namespace Module_Business
{
    partial class Module_Business_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.demandSmall = new System.Windows.Forms.Button();
            this.sellSmall = new System.Windows.Forms.Button();
            this.buySmall = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.demandMedium = new System.Windows.Forms.Button();
            this.sellMedium = new System.Windows.Forms.Button();
            this.buyMedium = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.demandBig = new System.Windows.Forms.Button();
            this.buyBig = new System.Windows.Forms.Button();
            this.sellBig = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.demandSmall);
            this.groupBox1.Controls.Add(this.sellSmall);
            this.groupBox1.Controls.Add(this.buySmall);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Малый бизнес";
            // 
            // demandSmall
            // 
            this.demandSmall.Location = new System.Drawing.Point(6, 77);
            this.demandSmall.Name = "demandSmall";
            this.demandSmall.Size = new System.Drawing.Size(120, 23);
            this.demandSmall.TabIndex = 4;
            this.demandSmall.Text = "Востребованность";
            this.demandSmall.UseVisualStyleBackColor = true;
            this.demandSmall.Click += new System.EventHandler(this.demandSmall_Click);
            // 
            // sellSmall
            // 
            this.sellSmall.Enabled = false;
            this.sellSmall.Location = new System.Drawing.Point(6, 48);
            this.sellSmall.Name = "sellSmall";
            this.sellSmall.Size = new System.Drawing.Size(120, 23);
            this.sellSmall.TabIndex = 3;
            this.sellSmall.Text = "Продать";
            this.sellSmall.UseVisualStyleBackColor = true;
            this.sellSmall.Click += new System.EventHandler(this.sellSmall_Click);
            // 
            // buySmall
            // 
            this.buySmall.Location = new System.Drawing.Point(6, 19);
            this.buySmall.Name = "buySmall";
            this.buySmall.Size = new System.Drawing.Size(120, 23);
            this.buySmall.TabIndex = 2;
            this.buySmall.Text = "Купить";
            this.buySmall.UseVisualStyleBackColor = true;
            this.buySmall.Click += new System.EventHandler(this.buySmall_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.demandMedium);
            this.groupBox2.Controls.Add(this.sellMedium);
            this.groupBox2.Controls.Add(this.buyMedium);
            this.groupBox2.Location = new System.Drawing.Point(157, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 112);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Средний бизнес";
            // 
            // demandMedium
            // 
            this.demandMedium.Location = new System.Drawing.Point(6, 77);
            this.demandMedium.Name = "demandMedium";
            this.demandMedium.Size = new System.Drawing.Size(120, 23);
            this.demandMedium.TabIndex = 7;
            this.demandMedium.Text = "Востребованность";
            this.demandMedium.UseVisualStyleBackColor = true;
            this.demandMedium.Click += new System.EventHandler(this.demandMedium_Click);
            // 
            // sellMedium
            // 
            this.sellMedium.Enabled = false;
            this.sellMedium.Location = new System.Drawing.Point(6, 48);
            this.sellMedium.Name = "sellMedium";
            this.sellMedium.Size = new System.Drawing.Size(120, 23);
            this.sellMedium.TabIndex = 6;
            this.sellMedium.Text = "Продать";
            this.sellMedium.UseVisualStyleBackColor = true;
            this.sellMedium.Click += new System.EventHandler(this.SellMedium_Click);
            // 
            // buyMedium
            // 
            this.buyMedium.Location = new System.Drawing.Point(6, 19);
            this.buyMedium.Name = "buyMedium";
            this.buyMedium.Size = new System.Drawing.Size(120, 23);
            this.buyMedium.TabIndex = 5;
            this.buyMedium.Text = "Купить";
            this.buyMedium.UseVisualStyleBackColor = true;
            this.buyMedium.Click += new System.EventHandler(this.buyMedium_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.demandBig);
            this.groupBox3.Controls.Add(this.buyBig);
            this.groupBox3.Controls.Add(this.sellBig);
            this.groupBox3.Location = new System.Drawing.Point(302, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(139, 111);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Крупный бизнес";
            // 
            // demandBig
            // 
            this.demandBig.Location = new System.Drawing.Point(6, 76);
            this.demandBig.Name = "demandBig";
            this.demandBig.Size = new System.Drawing.Size(120, 23);
            this.demandBig.TabIndex = 10;
            this.demandBig.Text = "Востребованность";
            this.demandBig.UseVisualStyleBackColor = true;
            this.demandBig.Click += new System.EventHandler(this.demandBig_Click);
            // 
            // buyBig
            // 
            this.buyBig.Location = new System.Drawing.Point(6, 18);
            this.buyBig.Name = "buyBig";
            this.buyBig.Size = new System.Drawing.Size(120, 23);
            this.buyBig.TabIndex = 8;
            this.buyBig.Text = "Купить";
            this.buyBig.UseVisualStyleBackColor = true;
            this.buyBig.Click += new System.EventHandler(this.buyBig_Click);
            // 
            // sellBig
            // 
            this.sellBig.Enabled = false;
            this.sellBig.Location = new System.Drawing.Point(6, 47);
            this.sellBig.Name = "sellBig";
            this.sellBig.Size = new System.Drawing.Size(120, 23);
            this.sellBig.TabIndex = 9;
            this.sellBig.Text = "Продать";
            this.sellBig.UseVisualStyleBackColor = true;
            this.sellBig.Click += new System.EventHandler(this.sellBig_Click);
            // 
            // Module_Business_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 134);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Module_Business_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Module_Business_Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button demandSmall;
        private System.Windows.Forms.Button sellSmall;
        private System.Windows.Forms.Button buySmall;
        private System.Windows.Forms.Button demandMedium;
        private System.Windows.Forms.Button sellMedium;
        private System.Windows.Forms.Button buyMedium;
        private System.Windows.Forms.Button demandBig;
        private System.Windows.Forms.Button buyBig;
        private System.Windows.Forms.Button sellBig;
    }
}