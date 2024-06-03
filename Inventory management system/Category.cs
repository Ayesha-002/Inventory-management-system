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
    public partial class Category : Sample2
    {
        int edit = 0; // This 0 is an indication to SAVE operation and 1 is an indication to UPDATE operation
        int catID;
        short stat;
        Retrieval r = new Retrieval();
        public Category()
        {
            InitializeComponent();
        }
        private void Category_Load(object sender, EventArgs e)
        {
            MainClass.disable(LeftPanel);
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
            if (CategoryTxt.Text == " ") { CategoryNErrorLabel.Visible = true; } else { CategoryNErrorLabel.Visible = false; }
            
            if (ActiveDropDown.SelectedIndex == -1) { ActiveErrorLable.Visible = true; } else { ActiveErrorLable.Visible = false; }

            if (CategoryNErrorLabel.Visible || ActiveErrorLable.Visible)
            {
                MainClass.ShowMSG("Fields with * are mandatory", "Stop", "Error"); // error is the type of msg
            }
            else
            {

                if (ActiveDropDown.SelectedIndex == 0)
                {
                    stat = 1; //Yes
                }
                else if (ActiveDropDown.SelectedIndex == 1)
                {
                    stat = 0; //No
                }
                if (edit == 0) // Code for SAVE operaion
                {

                    Insertion i = new Insertion();


                    i.insertCat(CategoryTxt.Text, stat);
                    r.showCategories(dataGridView1, catIDGV, NameGV, StatusGV);
                    MainClass.disable_reset(LeftPanel);
                }
                else if (edit == 1) // Code for UPDATE operaion
                {
                    DialogResult dr = MessageBox.Show("Are you sure  , you want to update record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updation u = new Updation();
                        if (ActiveDropDown.SelectedIndex == 0)
                        {
                            stat = 1;
                        }
                        else if (ActiveDropDown.SelectedIndex == 1)
                        {
                            stat = 0;
                        }

                        u.UpdateCat(catID,CategoryTxt.Text,stat);
                        r.showCategories(dataGridView1, catIDGV, NameGV, StatusGV);
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
                    d.delete(catID, "st_deleteCategory", "@id");
                    r.showCategories(dataGridView1, catIDGV, NameGV, StatusGV);
                }
            }
        }

        public override void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (Searchtxt.Text != null)
            {
                r.showCategories(dataGridView1, catIDGV, NameGV, StatusGV);
            }
            else
            {
                r.showCategories(dataGridView1, catIDGV, NameGV, StatusGV);
            }
        }

        public override void Viewbtn_Click(object sender, EventArgs e)
        {
            r.showCategories(dataGridView1, catIDGV, NameGV, StatusGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                catID = Convert.ToInt32(row.Cells["catIDGV"].Value.ToString());
                CategoryTxt.Text = row.Cells["NameGV"].Value.ToString();
                ActiveDropDown.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                MainClass.disable(LeftPanel);
            }
        }
    }
}
