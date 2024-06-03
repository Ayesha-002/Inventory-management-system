using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory_management_system
{
    public partial class Supplier : Sample2
    {
        public Supplier()
        {
            InitializeComponent();
        }
        int edit = 0; // This 0 is an indication to SAVE operation and 1 is an indication to UPDATE operation
        int SupplierID;
        short stat;
        Retrieval r = new Retrieval();
        private void Supplier_Load(object sender, EventArgs e)
        {

            MainClass.disable_reset(LeftPanel);
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
            {
                if (supplierCompanyTxt.Text == " ") { SNErrorLabel.Visible = true; } else { SNErrorLabel.Visible = false; }
                if (contactPersonTxt.Text == " ") { CPErrorLable.Visible = true; } else { CPErrorLable.Visible = false; }
                if (Phone1Txt.Text == " ") { PhoneErrorLable.Visible = true; } else { PhoneErrorLable.Visible = false; }
                if (addressTxt.Text == " ") { AddressErrorLable.Visible = true; } else { AddressErrorLable.Visible = false; }
                if (statusDD.SelectedIndex == -1) { StatusErrorLable.Visible = true; } else { StatusErrorLable.Visible = false; }

                if (SNErrorLabel.Visible || CPErrorLable.Visible || PhoneErrorLable.Visible || AddressErrorLable.Visible || StatusErrorLable.Visible)
                {
                    MainClass.ShowMSG("Fields with * are mandatory", "Stop", "Error"); // error is the type of msg
                }
                else
                {

                    if (statusDD.SelectedIndex == 0)
                    {
                        stat = 1;
                    }
                    else if (statusDD.SelectedIndex == 1)
                    {
                        stat = 0;
                    }
                    if (edit == 0) // Code for SAVE operaion
                    {

                        Insertion i = new Insertion();
                        if (PhoneTxt2.Text == " " && ntnTxt.Text != "")
                        {
                            i.insertSupplier(supplierCompanyTxt.Text, contactPersonTxt.Text, Phone1Txt.Text, addressTxt.Text, stat, null, ntnTxt.Text);
                        }
                        else if (PhoneTxt2.Text != "" && ntnTxt.Text == "")
                        {
                            i.insertSupplier(supplierCompanyTxt.Text, contactPersonTxt.Text, Phone1Txt.Text, addressTxt.Text, stat, PhoneTxt2.Text, null);
                        }
                        else if (PhoneTxt2.Text == "" && ntnTxt.Text == "")
                        {
                            i.insertSupplier(supplierCompanyTxt.Text, contactPersonTxt.Text, Phone1Txt.Text, addressTxt.Text, stat, null, null);
                        }
                        else
                        {
                            i.insertSupplier(supplierCompanyTxt.Text, contactPersonTxt.Text, Phone1Txt.Text, addressTxt.Text, stat, PhoneTxt2.Text, ntnTxt.Text);
                        }

                        r.showSuppliers(dataGridView1, suppIDGV, companyGV, personGV, phone1GV, phone2GV, addressGV, ntnGV, StatusGV);
                        MainClass.disable_reset(LeftPanel);
                    }
                    else if (edit == 1) // Code for UPDATE operaion
                    {
                        DialogResult dr = MessageBox.Show("Are you sure  , you want to update record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            Updation u = new Updation();

                            if (statusDD.SelectedIndex == 0)
                            {
                                stat = 1;
                            }
                            else if (statusDD.SelectedIndex == 1)
                            {
                                stat = 0;
                            }

                            if (PhoneTxt2.Text == " " && ntnTxt.Text != "")
                            {
                                u.updateSupplier(SupplierID, supplierCompanyTxt.Text, contactPersonTxt.Text, Phone1Txt.Text, addressTxt.Text, stat, null, ntnTxt.Text);
                            }
                            else if (PhoneTxt2.Text != "" && ntnTxt.Text == "")
                            {
                                u.updateSupplier(SupplierID, supplierCompanyTxt.Text, contactPersonTxt.Text, Phone1Txt.Text, addressTxt.Text, stat, PhoneTxt2.Text, null);
                            }
                            else if (PhoneTxt2.Text == "" && ntnTxt.Text == "")
                            {
                                u.updateSupplier(SupplierID, supplierCompanyTxt.Text, contactPersonTxt.Text, Phone1Txt.Text, addressTxt.Text, stat, null, null);
                            }
                            else
                            {
                                u.updateSupplier(SupplierID, supplierCompanyTxt.Text, contactPersonTxt.Text, Phone1Txt.Text, addressTxt.Text, stat, PhoneTxt2.Text, ntnTxt.Text);
                            }
                            r.showSuppliers(dataGridView1, suppIDGV, companyGV, personGV, phone1GV, phone2GV, addressGV, ntnGV, StatusGV);
                            MainClass.disable_reset(LeftPanel);
                        }
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
                    d.delete(SupplierID, "st_deleteSupplier", "@suppID");
                    r.showSuppliers(dataGridView1, suppIDGV, companyGV, personGV, phone1GV, phone2GV, addressGV, ntnGV, StatusGV);
                }
            }
        }
        public override void Viewbtn_Click(object sender, EventArgs e)
        {
            r.showSuppliers(dataGridView1, suppIDGV, companyGV, personGV, phone1GV, phone2GV, addressGV, ntnGV, StatusGV);
        }

        public override void Searchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                SupplierID = Convert.ToInt32(row.Cells["suppIDGV"].Value.ToString());
                supplierCompanyTxt.Text = row.Cells["cpmpanyGV"].Value.ToString();
                contactPersonTxt.Text = row.Cells["personGV"].Value.ToString();
                Phone1Txt.Text = row.Cells["phone1GV"].Value.ToString();
                PhoneTxt2.Text = row.Cells["phone2GV"].Value.ToString();
                addressTxt.Text = row.Cells["addressGV"].Value.ToString();
                ntnTxt.Text = row.Cells["ntnGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                MainClass.disable(LeftPanel);
            }
        }
    }
}
