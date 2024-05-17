namespace Inventory_management_system
{
    partial class Sample2
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Editbtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Searchtxt = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Backbtn = new System.Windows.Forms.Button();
            this.bckbtn = new System.Windows.Forms.Button();
            this.LeftPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.panel4);
            this.LeftPanel.Size = new System.Drawing.Size(257, 613);
            this.LeftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.LeftPanel.Controls.SetChildIndex(this.panel4, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.panel3);
            this.RightPanel.Location = new System.Drawing.Point(257, 0);
            this.RightPanel.Size = new System.Drawing.Size(1033, 613);
//            this.RightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.RightPanel_Paint);
            this.RightPanel.Controls.SetChildIndex(this.panel3, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bckbtn);
            this.panel2.Controls.Add(this.Backbtn);
            this.panel2.Size = new System.Drawing.Size(257, 58);
            this.panel2.Controls.SetChildIndex(this.Backbtn, 0);
            this.panel2.Controls.SetChildIndex(this.bckbtn, 0);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1033, 50);
            this.panel3.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.65053F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.65053F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.Deletebtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Savebtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Editbtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Addbtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1033, 50);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Deletebtn
            // 
            this.Deletebtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Deletebtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Deletebtn.FlatAppearance.BorderSize = 3;
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Deletebtn.Location = new System.Drawing.Point(519, 3);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(166, 44);
            this.Deletebtn.TabIndex = 3;
            this.Deletebtn.Text = "DELETE";
            this.Deletebtn.UseVisualStyleBackColor = true;
            // 
            // Savebtn
            // 
            this.Savebtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Savebtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Savebtn.FlatAppearance.BorderSize = 3;
            this.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Savebtn.Location = new System.Drawing.Point(347, 3);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(166, 44);
            this.Savebtn.TabIndex = 2;
            this.Savebtn.Text = "SAVE";
            this.Savebtn.UseVisualStyleBackColor = true;
            // 
            // Editbtn
            // 
            this.Editbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Editbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Editbtn.FlatAppearance.BorderSize = 3;
            this.Editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Editbtn.Location = new System.Drawing.Point(175, 3);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(166, 44);
            this.Editbtn.TabIndex = 1;
            this.Editbtn.Text = "EDIT";
            this.Editbtn.UseVisualStyleBackColor = true;
            // 
            // Addbtn
            // 
            this.Addbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Addbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Addbtn.FlatAppearance.BorderSize = 3;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Addbtn.Location = new System.Drawing.Point(3, 3);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(166, 44);
            this.Addbtn.TabIndex = 0;
            this.Addbtn.Text = "ADD";
            this.Addbtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.Searchtxt);
            this.groupBox1.Location = new System.Drawing.Point(691, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 44);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEARCH";
            // 
            // Searchtxt
            // 
            this.Searchtxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Searchtxt.Location = new System.Drawing.Point(3, 22);
            this.Searchtxt.MaxLength = 100;
            this.Searchtxt.Name = "Searchtxt";
            this.Searchtxt.Size = new System.Drawing.Size(333, 26);
            this.Searchtxt.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(257, 50);
            this.panel4.TabIndex = 2;
            // 
            // Backbtn
            // 
            this.Backbtn.FlatAppearance.BorderSize = 0;
            this.Backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backbtn.Location = new System.Drawing.Point(3, 29);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(57, 23);
            this.Backbtn.TabIndex = 3;
            this.Backbtn.UseVisualStyleBackColor = true;
            // 
            // bckbtn
            // 
            this.bckbtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.bckbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bckbtn.Location = new System.Drawing.Point(0, 0);
            this.bckbtn.Name = "bckbtn";
            this.bckbtn.Size = new System.Drawing.Size(68, 58);
            this.bckbtn.TabIndex = 4;
            this.bckbtn.UseVisualStyleBackColor = true;
            this.bckbtn.Click += new System.EventHandler(this.bckbtn_Click);
            // 
            // Sample2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 613);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Sample2";
            this.Load += new System.EventHandler(this.Sample2_Load);
            this.LeftPanel.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button Editbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox Searchtxt;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Button bckbtn;
    }
}