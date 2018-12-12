namespace Module_Event
{
    partial class EventDisplayForm
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
            this.components = new System.ComponentModel.Container();
            this.EventSelectionContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MainText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // EventSelectionContextMenu
            // 
            this.EventSelectionContextMenu.Name = "EventSelectionContextMenu";
            this.EventSelectionContextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // MainText
            // 
            this.MainText.Enabled = false;
            this.MainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainText.Location = new System.Drawing.Point(-2, -2);
            this.MainText.Name = "MainText";
            this.MainText.Size = new System.Drawing.Size(376, 132);
            this.MainText.TabIndex = 1;
            this.MainText.Text = "";
            // 
            // EventDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 126);
            this.ControlBox = false;
            this.Controls.Add(this.MainText);
            this.MaximizeBox = false;
            this.Name = "EventDisplayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Событие";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EventDisplayForm_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip EventSelectionContextMenu;
        private System.Windows.Forms.RichTextBox MainText;
    }
}