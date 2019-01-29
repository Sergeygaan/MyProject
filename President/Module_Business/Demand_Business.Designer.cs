namespace Module_Business
{
    partial class Demand_Business
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
            this.demandParam = new Module_UserControl.DemandParam();
            this.SuspendLayout();
            // 
            // demandParam
            // 
            this.demandParam.Location = new System.Drawing.Point(254, 12);
            this.demandParam.Name = "demandParam";
            this.demandParam.Size = new System.Drawing.Size(252, 291);
            this.demandParam.TabIndex = 0;
            // 
            // Demand_Business
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 307);
            this.Controls.Add(this.demandParam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Demand_Business";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Востребованность отраслей";
            this.ResumeLayout(false);

        }

        #endregion

        private Module_UserControl.DemandParam demandParam;
    }
}