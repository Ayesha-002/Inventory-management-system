namespace Inventory_management_system
{
    partial class products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductTxt = new System.Windows.Forms.TextBox();
            this.ProErrorLabel = new System.Windows.Forms.Label();
            this.BarcodeTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BarcodeErrorLable = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Expirypicker = new System.Windows.Forms.DateTimePicker();
            this.ExpiryErrorLable = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PriceErrorLable = new System.Windows.Forms.Label();
            this.PriceTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CategoryDropDown = new System.Windows.Forms.ComboBox();
            this.CategoryErrorLable = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Searchtxt
            // 
            this.Searchtxt.Size = new System.Drawing.Size(148, 26);
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.CategoryDropDown);
            this.LeftPanel.Controls.Add(this.label6);
            this.LeftPanel.Controls.Add(this.PriceTxt);
            this.LeftPanel.Controls.Add(this.label7);
            this.LeftPanel.Controls.Add(this.Expirypicker);
            this.LeftPanel.Controls.Add(this.label5);
            this.LeftPanel.Controls.Add(this.BarcodeTxt);
            this.LeftPanel.Controls.Add(this.label4);
            this.LeftPanel.Controls.Add(this.ProductTxt);
            this.LeftPanel.Controls.Add(this.label3);
            this.LeftPanel.Controls.Add(this.ProErrorLabel);
            this.LeftPanel.Controls.Add(this.BarcodeErrorLable);
            this.LeftPanel.Controls.Add(this.ExpiryErrorLable);
            this.LeftPanel.Controls.Add(this.PriceErrorLable);
            this.LeftPanel.Controls.Add(this.CategoryErrorLable);
            this.LeftPanel.Size = new System.Drawing.Size(257, 509);
            this.LeftPanel.Controls.SetChildIndex(this.CategoryErrorLable, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PriceErrorLable, 0);
            this.LeftPanel.Controls.SetChildIndex(this.ExpiryErrorLable, 0);
            this.LeftPanel.Controls.SetChildIndex(this.BarcodeErrorLable, 0);
            this.LeftPanel.Controls.SetChildIndex(this.ProErrorLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label3, 0);
            this.LeftPanel.Controls.SetChildIndex(this.ProductTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label4, 0);
            this.LeftPanel.Controls.SetChildIndex(this.BarcodeTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label5, 0);
            this.LeftPanel.Controls.SetChildIndex(this.Expirypicker, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label7, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PriceTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label6, 0);
            this.LeftPanel.Controls.SetChildIndex(this.CategoryDropDown, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.dataGridView1);
            this.RightPanel.Size = new System.Drawing.Size(940, 509);
            this.RightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.RightPanel_Paint);
            this.RightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Name";
            // 
            // ProductTxt
            // 
            this.ProductTxt.Location = new System.Drawing.Point(7, 122);
            this.ProductTxt.Name = "ProductTxt";
            this.ProductTxt.Size = new System.Drawing.Size(234, 26);
            this.ProductTxt.TabIndex = 3;
            // 
            // ProErrorLabel
            // 
            this.ProErrorLabel.AutoSize = true;
            this.ProErrorLabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProErrorLabel.ForeColor = System.Drawing.Color.Tomato;
            this.ProErrorLabel.Location = new System.Drawing.Point(106, 92);
            this.ProErrorLabel.Name = "ProErrorLabel";
            this.ProErrorLabel.Size = new System.Drawing.Size(24, 29);
            this.ProErrorLabel.TabIndex = 13;
            this.ProErrorLabel.Text = "*";
            this.ProErrorLabel.Visible = false;
            // 
            // BarcodeTxt
            // 
            this.BarcodeTxt.Location = new System.Drawing.Point(8, 178);
            this.BarcodeTxt.Name = "BarcodeTxt";
            this.BarcodeTxt.Size = new System.Drawing.Size(234, 26);
            this.BarcodeTxt.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Barcode";
            // 
            // BarcodeErrorLable
            // 
            this.BarcodeErrorLable.AutoSize = true;
            this.BarcodeErrorLable.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeErrorLable.ForeColor = System.Drawing.Color.Tomato;
            this.BarcodeErrorLable.Location = new System.Drawing.Point(65, 146);
            this.BarcodeErrorLable.Name = "BarcodeErrorLable";
            this.BarcodeErrorLable.Size = new System.Drawing.Size(24, 29);
            this.BarcodeErrorLable.TabIndex = 16;
            this.BarcodeErrorLable.Text = "*";
            this.BarcodeErrorLable.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Expiry Date";
            // 
            // Expirypicker
            // 
            this.Expirypicker.CustomFormat = "dd-MMM-yyyy";
            this.Expirypicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Expirypicker.Location = new System.Drawing.Point(8, 232);
            this.Expirypicker.Name = "Expirypicker";
            this.Expirypicker.Size = new System.Drawing.Size(234, 26);
            this.Expirypicker.TabIndex = 18;
            // 
            // ExpiryErrorLable
            // 
            this.ExpiryErrorLable.AutoSize = true;
            this.ExpiryErrorLable.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiryErrorLable.ForeColor = System.Drawing.Color.Tomato;
            this.ExpiryErrorLable.Location = new System.Drawing.Point(103, 200);
            this.ExpiryErrorLable.Name = "ExpiryErrorLable";
            this.ExpiryErrorLable.Size = new System.Drawing.Size(24, 29);
            this.ExpiryErrorLable.TabIndex = 19;
            this.ExpiryErrorLable.Text = "*";
            this.ExpiryErrorLable.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Price";
            // 
            // PriceErrorLable
            // 
            this.PriceErrorLable.AutoSize = true;
            this.PriceErrorLable.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceErrorLable.ForeColor = System.Drawing.Color.Tomato;
            this.PriceErrorLable.Location = new System.Drawing.Point(46, 255);
            this.PriceErrorLable.Name = "PriceErrorLable";
            this.PriceErrorLable.Size = new System.Drawing.Size(24, 29);
            this.PriceErrorLable.TabIndex = 21;
            this.PriceErrorLable.Text = "*";
            this.PriceErrorLable.Visible = false;
            // 
            // PriceTxt
            // 
            this.PriceTxt.Location = new System.Drawing.Point(8, 285);
            this.PriceTxt.Name = "PriceTxt";
            this.PriceTxt.Size = new System.Drawing.Size(234, 26);
            this.PriceTxt.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 23;
            this.label6.Text = "Category";
            // 
            // CategoryDropDown
            // 
            this.CategoryDropDown.FormattingEnabled = true;
            this.CategoryDropDown.Location = new System.Drawing.Point(8, 338);
            this.CategoryDropDown.Name = "CategoryDropDown";
            this.CategoryDropDown.Size = new System.Drawing.Size(233, 29);
            this.CategoryDropDown.TabIndex = 24;
            // 
            // CategoryErrorLable
            // 
            this.CategoryErrorLable.AutoSize = true;
            this.CategoryErrorLable.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryErrorLable.ForeColor = System.Drawing.Color.Tomato;
            this.CategoryErrorLable.Location = new System.Drawing.Point(73, 310);
            this.CategoryErrorLable.Name = "CategoryErrorLable";
            this.CategoryErrorLable.Size = new System.Drawing.Size(24, 29);
            this.CategoryErrorLable.TabIndex = 25;
            this.CategoryErrorLable.Text = "*";
            this.CategoryErrorLable.Visible = false;
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
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proIDGV,
            this.proGV,
            this.barcodeGV,
            this.expiryGV,
            this.priceGV,
            this.catIDGV,
            this.catGV});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(940, 401);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // proIDGV
            // 
            this.proIDGV.HeaderText = "proID";
            this.proIDGV.MinimumWidth = 6;
            this.proIDGV.Name = "proIDGV";
            this.proIDGV.ReadOnly = true;
            this.proIDGV.Visible = false;
            // 
            // proGV
            // 
            this.proGV.HeaderText = "Product";
            this.proGV.MinimumWidth = 6;
            this.proGV.Name = "proGV";
            this.proGV.ReadOnly = true;
            // 
            // barcodeGV
            // 
            this.barcodeGV.HeaderText = "Barcode";
            this.barcodeGV.MinimumWidth = 6;
            this.barcodeGV.Name = "barcodeGV";
            this.barcodeGV.ReadOnly = true;
            // 
            // expiryGV
            // 
            this.expiryGV.HeaderText = "Expiry Date";
            this.expiryGV.MinimumWidth = 6;
            this.expiryGV.Name = "expiryGV";
            this.expiryGV.ReadOnly = true;
            // 
            // priceGV
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.priceGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.priceGV.HeaderText = "Price";
            this.priceGV.MinimumWidth = 6;
            this.priceGV.Name = "priceGV";
            this.priceGV.ReadOnly = true;
            // 
            // catIDGV
            // 
            this.catIDGV.HeaderText = "catID";
            this.catIDGV.MinimumWidth = 6;
            this.catIDGV.Name = "catIDGV";
            this.catIDGV.ReadOnly = true;
            this.catIDGV.Visible = false;
            // 
            // catGV
            // 
            this.catGV.HeaderText = "Category";
            this.catGV.MinimumWidth = 6;
            this.catGV.Name = "catGV";
            this.catGV.ReadOnly = true;
            // 
            // products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 509);
            this.Name = "products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.products_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProductTxt;
        private System.Windows.Forms.TextBox BarcodeTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label BarcodeErrorLable;
        private System.Windows.Forms.Label ProErrorLabel;
        private System.Windows.Forms.DateTimePicker Expirypicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PriceTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ExpiryErrorLable;
        private System.Windows.Forms.Label PriceErrorLable;
        private System.Windows.Forms.ComboBox CategoryDropDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CategoryErrorLable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn proGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn catGV;
    }
}