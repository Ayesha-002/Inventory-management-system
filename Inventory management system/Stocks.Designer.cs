namespace Inventory_management_system
{
    partial class Stocks
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
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Searchtxt
            // 
            this.Searchtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Searchtxt.Size = new System.Drawing.Size(163, 26);
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(257, 604);
            // 
            // RightPanel
            // 
            this.RightPanel.Size = new System.Drawing.Size(1040, 604);
            // 
            // Stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 604);
            this.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.Name = "Stocks";
            this.Text = "Stocks";
            this.Load += new System.EventHandler(this.Stocks_Load);
            this.LeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}