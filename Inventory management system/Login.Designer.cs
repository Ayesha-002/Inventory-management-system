namespace Inventory_management_system
{
    partial class Login
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
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.lable3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.button1);
            this.LeftPanel.Controls.Add(this.label4);
            this.LeftPanel.Controls.Add(this.lable3);
            this.LeftPanel.Controls.Add(this.passtxt);
            this.LeftPanel.Controls.Add(this.usernametxt);
            this.LeftPanel.Size = new System.Drawing.Size(278, 642);
            this.LeftPanel.Controls.SetChildIndex(this.usernametxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.passtxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.lable3, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label4, 0);
            this.LeftPanel.Controls.SetChildIndex(this.button1, 0);
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(12, 325);
            this.usernametxt.MaxLength = 30;
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(241, 26);
            this.usernametxt.TabIndex = 2;
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(12, 393);
            this.passtxt.MaxLength = 30;
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(241, 26);
            this.passtxt.TabIndex = 3;
            this.passtxt.UseSystemPasswordChar = true;
            // 
            // lable3
            // 
            this.lable3.AutoSize = true;
            this.lable3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lable3.Location = new System.Drawing.Point(12, 301);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(83, 21);
            this.lable3.TabIndex = 4;
            this.lable3.Text = "UserName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(11, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(29, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 642);
            this.Name = "Login";
            this.Text = "Login";
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lable3;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.Button button1;
    }
}