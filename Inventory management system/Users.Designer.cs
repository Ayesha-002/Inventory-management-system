namespace Inventory_management_system
{
    partial class Users
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Usernametxt = new System.Windows.Forms.TextBox();
            this.Passtxt = new System.Windows.Forms.TextBox();
            this.Phonetxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.NameErrorlabel = new System.Windows.Forms.Label();
            this.UsernameErrorlabel = new System.Windows.Forms.Label();
            this.PassErrorlabel = new System.Windows.Forms.Label();
            this.PhoneErrorlabel = new System.Windows.Forms.Label();
            this.EmailErrorlabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsernameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.StatusDropDown = new System.Windows.Forms.ComboBox();
            this.StatusErrorLable = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.StatusDropDown);
            this.LeftPanel.Controls.Add(this.label8);
            this.LeftPanel.Controls.Add(this.panel4);
            this.LeftPanel.Controls.Add(this.Emailtxt);
            this.LeftPanel.Controls.Add(this.label7);
            this.LeftPanel.Controls.Add(this.Phonetxt);
            this.LeftPanel.Controls.Add(this.Passtxt);
            this.LeftPanel.Controls.Add(this.Usernametxt);
            this.LeftPanel.Controls.Add(this.label6);
            this.LeftPanel.Controls.Add(this.label5);
            this.LeftPanel.Controls.Add(this.label4);
            this.LeftPanel.Controls.Add(this.Nametxt);
            this.LeftPanel.Controls.Add(this.label3);
            this.LeftPanel.Controls.Add(this.NameErrorlabel);
            this.LeftPanel.Controls.Add(this.UsernameErrorlabel);
            this.LeftPanel.Controls.Add(this.PassErrorlabel);
            this.LeftPanel.Controls.Add(this.PhoneErrorlabel);
            this.LeftPanel.Controls.Add(this.EmailErrorlabel);
            this.LeftPanel.Controls.Add(this.StatusErrorLable);
            this.LeftPanel.Size = new System.Drawing.Size(257, 624);
            this.LeftPanel.TabIndex = 1;
            this.LeftPanel.Controls.SetChildIndex(this.StatusErrorLable, 0);
            this.LeftPanel.Controls.SetChildIndex(this.EmailErrorlabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PhoneErrorlabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PassErrorlabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.UsernameErrorlabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.NameErrorlabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label3, 0);
            this.LeftPanel.Controls.SetChildIndex(this.Nametxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label4, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label5, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label6, 0);
            this.LeftPanel.Controls.SetChildIndex(this.Usernametxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.Passtxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.Phonetxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label7, 0);
            this.LeftPanel.Controls.SetChildIndex(this.Emailtxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.panel4, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label8, 0);
            this.LeftPanel.Controls.SetChildIndex(this.StatusDropDown, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.dataGridView1);
            this.RightPanel.Size = new System.Drawing.Size(1066, 624);
            this.RightPanel.TabIndex = 0;
            this.RightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.RightPanel_Paint);
            this.RightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(13, 140);
            this.Nametxt.MaxLength = 35;
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(238, 26);
            this.Nametxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Phone (03XX-XXXXXXX)";
            // 
            // Usernametxt
            // 
            this.Usernametxt.Location = new System.Drawing.Point(12, 193);
            this.Usernametxt.MaxLength = 20;
            this.Usernametxt.Name = "Usernametxt";
            this.Usernametxt.Size = new System.Drawing.Size(238, 26);
            this.Usernametxt.TabIndex = 8;
            // 
            // Passtxt
            // 
            this.Passtxt.Location = new System.Drawing.Point(12, 246);
            this.Passtxt.MaxLength = 20;
            this.Passtxt.Name = "Passtxt";
            this.Passtxt.Size = new System.Drawing.Size(238, 26);
            this.Passtxt.TabIndex = 9;
            this.Passtxt.UseSystemPasswordChar = true;
            // 
            // Phonetxt
            // 
            this.Phonetxt.Location = new System.Drawing.Point(12, 299);
            this.Phonetxt.MaxLength = 15;
            this.Phonetxt.Name = "Phonetxt";
            this.Phonetxt.Size = new System.Drawing.Size(238, 26);
            this.Phonetxt.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Email";
            // 
            // Emailtxt
            // 
            this.Emailtxt.Location = new System.Drawing.Point(12, 352);
            this.Emailtxt.MaxLength = 50;
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(238, 26);
            this.Emailtxt.TabIndex = 11;
            // 
            // NameErrorlabel
            // 
            this.NameErrorlabel.AutoSize = true;
            this.NameErrorlabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameErrorlabel.ForeColor = System.Drawing.Color.Tomato;
            this.NameErrorlabel.Location = new System.Drawing.Point(62, 110);
            this.NameErrorlabel.Name = "NameErrorlabel";
            this.NameErrorlabel.Size = new System.Drawing.Size(24, 29);
            this.NameErrorlabel.TabIndex = 12;
            this.NameErrorlabel.Text = "*";
            this.NameErrorlabel.Visible = false;
            // 
            // UsernameErrorlabel
            // 
            this.UsernameErrorlabel.AutoSize = true;
            this.UsernameErrorlabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameErrorlabel.ForeColor = System.Drawing.Color.Tomato;
            this.UsernameErrorlabel.Location = new System.Drawing.Point(85, 163);
            this.UsernameErrorlabel.Name = "UsernameErrorlabel";
            this.UsernameErrorlabel.Size = new System.Drawing.Size(24, 29);
            this.UsernameErrorlabel.TabIndex = 13;
            this.UsernameErrorlabel.Text = "*";
            this.UsernameErrorlabel.Visible = false;
            // 
            // PassErrorlabel
            // 
            this.PassErrorlabel.AutoSize = true;
            this.PassErrorlabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassErrorlabel.ForeColor = System.Drawing.Color.Tomato;
            this.PassErrorlabel.Location = new System.Drawing.Point(85, 216);
            this.PassErrorlabel.Name = "PassErrorlabel";
            this.PassErrorlabel.Size = new System.Drawing.Size(24, 29);
            this.PassErrorlabel.TabIndex = 14;
            this.PassErrorlabel.Text = "*";
            this.PassErrorlabel.Visible = false;
            // 
            // PhoneErrorlabel
            // 
            this.PhoneErrorlabel.AutoSize = true;
            this.PhoneErrorlabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneErrorlabel.ForeColor = System.Drawing.Color.Tomato;
            this.PhoneErrorlabel.Location = new System.Drawing.Point(185, 269);
            this.PhoneErrorlabel.Name = "PhoneErrorlabel";
            this.PhoneErrorlabel.Size = new System.Drawing.Size(24, 29);
            this.PhoneErrorlabel.TabIndex = 15;
            this.PhoneErrorlabel.Text = "*";
            this.PhoneErrorlabel.Visible = false;
            // 
            // EmailErrorlabel
            // 
            this.EmailErrorlabel.AutoSize = true;
            this.EmailErrorlabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailErrorlabel.ForeColor = System.Drawing.Color.Tomato;
            this.EmailErrorlabel.Location = new System.Drawing.Point(62, 322);
            this.EmailErrorlabel.Name = "EmailErrorlabel";
            this.EmailErrorlabel.Size = new System.Drawing.Size(24, 29);
            this.EmailErrorlabel.TabIndex = 16;
            this.EmailErrorlabel.Text = "*";
            this.EmailErrorlabel.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(3, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(251, 51);
            this.panel4.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDGV,
            this.NameGV,
            this.UsernameGV,
            this.PassGV,
            this.EmailGV,
            this.PhoneGV,
            this.StatusGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1066, 516);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // userIDGV
            // 
            this.userIDGV.HeaderText = "UserID";
            this.userIDGV.MinimumWidth = 6;
            this.userIDGV.Name = "userIDGV";
            this.userIDGV.ReadOnly = true;
            this.userIDGV.Visible = false;
            // 
            // NameGV
            // 
            this.NameGV.HeaderText = "Name";
            this.NameGV.MinimumWidth = 6;
            this.NameGV.Name = "NameGV";
            this.NameGV.ReadOnly = true;
            // 
            // UsernameGV
            // 
            this.UsernameGV.HeaderText = "Username";
            this.UsernameGV.MinimumWidth = 6;
            this.UsernameGV.Name = "UsernameGV";
            this.UsernameGV.ReadOnly = true;
            // 
            // PassGV
            // 
            this.PassGV.HeaderText = "Password";
            this.PassGV.MinimumWidth = 6;
            this.PassGV.Name = "PassGV";
            this.PassGV.ReadOnly = true;
            this.PassGV.Visible = false;
            // 
            // EmailGV
            // 
            this.EmailGV.HeaderText = "Email";
            this.EmailGV.MinimumWidth = 6;
            this.EmailGV.Name = "EmailGV";
            this.EmailGV.ReadOnly = true;
            // 
            // PhoneGV
            // 
            this.PhoneGV.HeaderText = "Phone #";
            this.PhoneGV.MinimumWidth = 6;
            this.PhoneGV.Name = "PhoneGV";
            this.PhoneGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "status";
            this.StatusGV.MinimumWidth = 6;
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Status";
            // 
            // StatusDropDown
            // 
            this.StatusDropDown.FormattingEnabled = true;
            this.StatusDropDown.Items.AddRange(new object[] {
            "Active",
            "In-active"});
            this.StatusDropDown.Location = new System.Drawing.Point(12, 405);
            this.StatusDropDown.Name = "StatusDropDown";
            this.StatusDropDown.Size = new System.Drawing.Size(237, 29);
            this.StatusDropDown.TabIndex = 19;
            // 
            // StatusErrorLable
            // 
            this.StatusErrorLable.AutoSize = true;
            this.StatusErrorLable.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusErrorLable.ForeColor = System.Drawing.Color.Tomato;
            this.StatusErrorLable.Location = new System.Drawing.Point(62, 375);
            this.StatusErrorLable.Name = "StatusErrorLable";
            this.StatusErrorLable.Size = new System.Drawing.Size(24, 29);
            this.StatusErrorLable.TabIndex = 20;
            this.StatusErrorLable.Text = "*";
            this.StatusErrorLable.Visible = false;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 624);
            this.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Phonetxt;
        private System.Windows.Forms.TextBox Passtxt;
        private System.Windows.Forms.TextBox Usernametxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label NameErrorlabel;
        private System.Windows.Forms.Label UsernameErrorlabel;
        private System.Windows.Forms.Label PassErrorlabel;
        private System.Windows.Forms.Label PhoneErrorlabel;
        private System.Windows.Forms.Label EmailErrorlabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsernameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
        private System.Windows.Forms.ComboBox StatusDropDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label StatusErrorLable;
    }
}