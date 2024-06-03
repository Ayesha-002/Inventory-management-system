namespace Inventory_management_system
{
    partial class Supplier
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
            this.supplierCompanyTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contactPersonTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Phone1Txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PhoneTxt2 = new System.Windows.Forms.TextBox();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ntnTxt = new System.Windows.Forms.TextBox();
            this.SNErrorLabel = new System.Windows.Forms.Label();
            this.CPErrorLable = new System.Windows.Forms.Label();
            this.PhoneErrorLable = new System.Windows.Forms.Label();
            this.AddressErrorLable = new System.Windows.Forms.Label();
            this.StatusErrorLable = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.statusDD = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.suppIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone1GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone2GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ntnGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Searchtxt
            // 
            this.Searchtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Searchtxt.Size = new System.Drawing.Size(223, 26);
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.statusDD);
            this.LeftPanel.Controls.Add(this.label13);
            this.LeftPanel.Controls.Add(this.SNErrorLabel);
            this.LeftPanel.Controls.Add(this.ntnTxt);
            this.LeftPanel.Controls.Add(this.label8);
            this.LeftPanel.Controls.Add(this.addressTxt);
            this.LeftPanel.Controls.Add(this.PhoneTxt2);
            this.LeftPanel.Controls.Add(this.label7);
            this.LeftPanel.Controls.Add(this.label6);
            this.LeftPanel.Controls.Add(this.Phone1Txt);
            this.LeftPanel.Controls.Add(this.label5);
            this.LeftPanel.Controls.Add(this.contactPersonTxt);
            this.LeftPanel.Controls.Add(this.label4);
            this.LeftPanel.Controls.Add(this.supplierCompanyTxt);
            this.LeftPanel.Controls.Add(this.label3);
            this.LeftPanel.Controls.Add(this.CPErrorLable);
            this.LeftPanel.Controls.Add(this.PhoneErrorLable);
            this.LeftPanel.Controls.Add(this.AddressErrorLable);
            this.LeftPanel.Controls.Add(this.StatusErrorLable);
            this.LeftPanel.Size = new System.Drawing.Size(257, 680);
            this.LeftPanel.Controls.SetChildIndex(this.StatusErrorLable, 0);
            this.LeftPanel.Controls.SetChildIndex(this.AddressErrorLable, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PhoneErrorLable, 0);
            this.LeftPanel.Controls.SetChildIndex(this.CPErrorLable, 0);
            this.LeftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label3, 0);
            this.LeftPanel.Controls.SetChildIndex(this.supplierCompanyTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label4, 0);
            this.LeftPanel.Controls.SetChildIndex(this.contactPersonTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label5, 0);
            this.LeftPanel.Controls.SetChildIndex(this.Phone1Txt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label6, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label7, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PhoneTxt2, 0);
            this.LeftPanel.Controls.SetChildIndex(this.addressTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label8, 0);
            this.LeftPanel.Controls.SetChildIndex(this.ntnTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.SNErrorLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label13, 0);
            this.LeftPanel.Controls.SetChildIndex(this.statusDD, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.dataGridView1);
            this.RightPanel.Size = new System.Drawing.Size(1400, 680);
            this.RightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Supplier Name/Company";
            // 
            // supplierCompanyTxt
            // 
            this.supplierCompanyTxt.Location = new System.Drawing.Point(11, 142);
            this.supplierCompanyTxt.MaxLength = 100;
            this.supplierCompanyTxt.Name = "supplierCompanyTxt";
            this.supplierCompanyTxt.Size = new System.Drawing.Size(220, 26);
            this.supplierCompanyTxt.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contact Person";
            // 
            // contactPersonTxt
            // 
            this.contactPersonTxt.Location = new System.Drawing.Point(11, 195);
            this.contactPersonTxt.MaxLength = 100;
            this.contactPersonTxt.Name = "contactPersonTxt";
            this.contactPersonTxt.Size = new System.Drawing.Size(220, 26);
            this.contactPersonTxt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phone 1:";
            // 
            // Phone1Txt
            // 
            this.Phone1Txt.Location = new System.Drawing.Point(14, 248);
            this.Phone1Txt.MaxLength = 15;
            this.Phone1Txt.Name = "Phone1Txt";
            this.Phone1Txt.Size = new System.Drawing.Size(220, 26);
            this.Phone1Txt.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Phone 2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Address:";
            // 
            // PhoneTxt2
            // 
            this.PhoneTxt2.Location = new System.Drawing.Point(13, 301);
            this.PhoneTxt2.MaxLength = 15;
            this.PhoneTxt2.Name = "PhoneTxt2";
            this.PhoneTxt2.Size = new System.Drawing.Size(220, 26);
            this.PhoneTxt2.TabIndex = 10;
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(13, 354);
            this.addressTxt.MaxLength = 100;
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(220, 26);
            this.addressTxt.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "NTN #";
            // 
            // ntnTxt
            // 
            this.ntnTxt.Location = new System.Drawing.Point(13, 407);
            this.ntnTxt.MaxLength = 50;
            this.ntnTxt.Name = "ntnTxt";
            this.ntnTxt.Size = new System.Drawing.Size(220, 26);
            this.ntnTxt.TabIndex = 13;
            // 
            // SNErrorLabel
            // 
            this.SNErrorLabel.AutoSize = true;
            this.SNErrorLabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SNErrorLabel.ForeColor = System.Drawing.Color.Tomato;
            this.SNErrorLabel.Location = new System.Drawing.Point(190, 110);
            this.SNErrorLabel.Name = "SNErrorLabel";
            this.SNErrorLabel.Size = new System.Drawing.Size(24, 29);
            this.SNErrorLabel.TabIndex = 24;
            this.SNErrorLabel.Text = "*";
            this.SNErrorLabel.Visible = false;
            // 
            // CPErrorLable
            // 
            this.CPErrorLable.AutoSize = true;
            this.CPErrorLable.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPErrorLable.ForeColor = System.Drawing.Color.Tomato;
            this.CPErrorLable.Location = new System.Drawing.Point(121, 165);
            this.CPErrorLable.Name = "CPErrorLable";
            this.CPErrorLable.Size = new System.Drawing.Size(24, 29);
            this.CPErrorLable.TabIndex = 25;
            this.CPErrorLable.Text = "*";
            this.CPErrorLable.Visible = false;
            // 
            // PhoneErrorLable
            // 
            this.PhoneErrorLable.AutoSize = true;
            this.PhoneErrorLable.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneErrorLable.ForeColor = System.Drawing.Color.Tomato;
            this.PhoneErrorLable.Location = new System.Drawing.Point(76, 218);
            this.PhoneErrorLable.Name = "PhoneErrorLable";
            this.PhoneErrorLable.Size = new System.Drawing.Size(24, 29);
            this.PhoneErrorLable.TabIndex = 26;
            this.PhoneErrorLable.Text = "*";
            this.PhoneErrorLable.Visible = false;
            // 
            // AddressErrorLable
            // 
            this.AddressErrorLable.AutoSize = true;
            this.AddressErrorLable.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressErrorLable.ForeColor = System.Drawing.Color.Tomato;
            this.AddressErrorLable.Location = new System.Drawing.Point(78, 324);
            this.AddressErrorLable.Name = "AddressErrorLable";
            this.AddressErrorLable.Size = new System.Drawing.Size(24, 29);
            this.AddressErrorLable.TabIndex = 27;
            this.AddressErrorLable.Text = "*";
            this.AddressErrorLable.Visible = false;
            // 
            // StatusErrorLable
            // 
            this.StatusErrorLable.AutoSize = true;
            this.StatusErrorLable.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusErrorLable.ForeColor = System.Drawing.Color.Tomato;
            this.StatusErrorLable.Location = new System.Drawing.Point(61, 430);
            this.StatusErrorLable.Name = "StatusErrorLable";
            this.StatusErrorLable.Size = new System.Drawing.Size(24, 29);
            this.StatusErrorLable.TabIndex = 28;
            this.StatusErrorLable.Text = "*";
            this.StatusErrorLable.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 436);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 21);
            this.label13.TabIndex = 29;
            this.label13.Text = "Status";
            // 
            // statusDD
            // 
            this.statusDD.FormattingEnabled = true;
            this.statusDD.Items.AddRange(new object[] {
            "Active",
            "In-active"});
            this.statusDD.Location = new System.Drawing.Point(13, 461);
            this.statusDD.Name = "statusDD";
            this.statusDD.Size = new System.Drawing.Size(221, 29);
            this.statusDD.TabIndex = 30;
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
            this.suppIDGV,
            this.companyGV,
            this.personGV,
            this.phone1GV,
            this.phone2GV,
            this.addressGV,
            this.ntnGV,
            this.StatusGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.dataGridView1.Size = new System.Drawing.Size(1400, 572);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // suppIDGV
            // 
            this.suppIDGV.HeaderText = "SuppID";
            this.suppIDGV.MinimumWidth = 6;
            this.suppIDGV.Name = "suppIDGV";
            this.suppIDGV.ReadOnly = true;
            this.suppIDGV.Visible = false;
            // 
            // companyGV
            // 
            this.companyGV.HeaderText = "Company";
            this.companyGV.MinimumWidth = 6;
            this.companyGV.Name = "companyGV";
            this.companyGV.ReadOnly = true;
            // 
            // personGV
            // 
            this.personGV.HeaderText = "Conatct Person";
            this.personGV.MinimumWidth = 6;
            this.personGV.Name = "personGV";
            this.personGV.ReadOnly = true;
            // 
            // phone1GV
            // 
            this.phone1GV.HeaderText = "Phone1";
            this.phone1GV.MinimumWidth = 6;
            this.phone1GV.Name = "phone1GV";
            this.phone1GV.ReadOnly = true;
            // 
            // phone2GV
            // 
            this.phone2GV.HeaderText = "Phone2";
            this.phone2GV.MinimumWidth = 6;
            this.phone2GV.Name = "phone2GV";
            this.phone2GV.ReadOnly = true;
            // 
            // addressGV
            // 
            this.addressGV.HeaderText = "Address";
            this.addressGV.MinimumWidth = 6;
            this.addressGV.Name = "addressGV";
            this.addressGV.ReadOnly = true;
            // 
            // ntnGV
            // 
            this.ntnGV.HeaderText = "NTN #";
            this.ntnGV.MinimumWidth = 6;
            this.ntnGV.Name = "ntnGV";
            this.ntnGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "status";
            this.StatusGV.MinimumWidth = 6;
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1657, 680);
            this.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox supplierCompanyTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.TextBox PhoneTxt2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Phone1Txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox contactPersonTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ntnTxt;
        private System.Windows.Forms.ComboBox statusDD;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label SNErrorLabel;
        private System.Windows.Forms.Label CPErrorLable;
        private System.Windows.Forms.Label PhoneErrorLable;
        private System.Windows.Forms.Label AddressErrorLable;
        private System.Windows.Forms.Label StatusErrorLable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn personGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone1GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone2GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ntnGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
    }
}