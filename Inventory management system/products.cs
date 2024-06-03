using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory_management_system
{
    public partial class products : Sample2
    {
        int edit = 0; // This 0 is an indication to SAVE operation and 1 is an indication to UPDATE operation
        int ProID;
        public products()
        {
            InitializeComponent();
        }
        Retrieval r = new Retrieval();  
        private void products_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(LeftPanel);
            r.getCategoriesList("st_getCategoriesList", CategoryDropDown, "Category", "ID");
        }
        public override void Addbtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(LeftPanel);
            edit = 0;
            
        }

        public override void Editbtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(LeftPanel);
        }

        public override void Savebtn_Click(object sender, EventArgs e)
        {
            if (ProductTxt.Text == " ") { ProErrorLabel.Visible = true; } else { ProErrorLabel.Visible = false; }
            if (BarcodeTxt.Text == " ") { BarcodeErrorLable.Visible = true; } else { BarcodeErrorLable.Visible = false; }
            if (Expirypicker.Value < DateTime.Now) { ExpiryErrorLable.Visible = true; ExpiryErrorLable.Text = "Invalid Date"; } else { ExpiryErrorLable.Visible = false; }
            if (Expirypicker.Value.Date == DateTime.Now.Date) { ExpiryErrorLable.Visible = false; }
            if (PriceTxt.Text == " ") { PriceErrorLable.Visible = true; } else { PriceErrorLable.Visible = false; }
            if (CategoryDropDown.SelectedIndex == -1 || CategoryDropDown.SelectedIndex == 0) { CategoryErrorLable.Visible = true; } else { CategoryErrorLable.Visible = false; }
            if (ProErrorLabel.Visible || BarcodeErrorLable.Visible || ExpiryErrorLable.Visible || PriceErrorLable.Visible || CategoryErrorLable.Visible)
            {
                MainClass.ShowMSG("Fields with * are mandatory", "Stop", "Error"); // error is the type of msg
            }
            else
            {

                if (edit == 0) // Code for SAVE operaion
                {
                    Insertion i = new Insertion();

                    if(Expirypicker.Value.Date == DateTime.Now.Date)
                    {
                        i.insertProduct(ProductTxt.Text, BarcodeTxt.Text, Convert.ToSingle(PriceTxt.Text), Convert.ToInt32(CategoryDropDown.SelectedValue));
                    }
                    else
                    {
                        i.insertProduct(ProductTxt.Text, BarcodeTxt.Text, Convert.ToSingle(PriceTxt.Text), Convert.ToInt32(CategoryDropDown.SelectedValue), Expirypicker.Value);
                    }
                    r.showProducts(dataGridView1, proIDGV, proGV, barcodeGV, priceGV, expiryGV, catIDGV, catGV);
                    MainClass.disable_reset(LeftPanel);
                }
                else if (edit == 1) // Code for UPDATE operaion
                {
                    DialogResult dr = MessageBox.Show("Are you sure  , you want to update record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updation u = new Updation();
                        if (Expirypicker.Value.Date == DateTime.Now.Date)
                        {
                            u.updateProduct(ProID,ProductTxt.Text, BarcodeTxt.Text, Convert.ToSingle(PriceTxt.Text), Convert.ToInt32(CategoryDropDown.SelectedValue));
                        }
                        else
                        {
                            u.updateProduct(ProID,ProductTxt.Text, BarcodeTxt.Text, Convert.ToSingle(PriceTxt.Text), Convert.ToInt32(CategoryDropDown.SelectedValue), Expirypicker.Value);
                        }
                        r.showProducts(dataGridView1, proIDGV, proGV, barcodeGV, priceGV, expiryGV, catIDGV, catGV);
                        MainClass.disable_reset(LeftPanel);
                    }
                }
            }
        }

        public override void Deletebtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure  , you want to update record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                if (edit == 1)
                {
                    Deletion d = new Deletion();
                    d.delete(ProID, "st_productDelete", "@proID");
                    r.showProducts(dataGridView1, proIDGV, proGV, barcodeGV, priceGV, expiryGV, catIDGV, catGV);
                }
            }
        }

        public override void Searchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        public override void Viewbtn_Click(object sender, EventArgs e)
        {
            r.showProducts(dataGridView1, proIDGV, proGV, barcodeGV, priceGV, expiryGV, catIDGV, catGV);
        }

        private void RightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                ProID = Convert.ToInt32(row.Cells["ProIDGV"].Value.ToString());
                ProductTxt.Text = row.Cells["proGV"].Value.ToString();
                BarcodeTxt.Text = row.Cells["barcodeGV"].Value.ToString();
                PriceTxt.Text = row.Cells["priceGV"].Value.ToString();
                if(row.Cells["expiryGV"].FormattedValue.ToString() == "")
                {
                    Expirypicker.Value = DateTime.Now;
                }
                else
                {
                    Expirypicker.Value = Convert.ToDateTime(row.Cells["expiryGV"].Value.ToString());
                }
              
                CategoryDropDown.SelectedValue = row.Cells["catIDGV"].Value.ToString();
                MainClass.disable(LeftPanel);
            }
        }
    }
}
