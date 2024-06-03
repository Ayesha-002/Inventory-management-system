using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory_management_system
{
    public partial class Users : Sample2
    {
        int edit = 0; // This 0 is an indication to SAVE operation and 1 is an indication to UPDATE operation
        int UserID;
        short stat;
        public Users()
        {
            InitializeComponent();
        }
        Retrieval r = new Retrieval();
        private void Users_Load(object sender, EventArgs e)
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
            if (Nametxt.Text == " ") { NameErrorlabel.Visible = true; } else { NameErrorlabel.Visible = false; }
            if (Usernametxt.Text == " ") { UsernameErrorlabel.Visible = true; } else { UsernameErrorlabel.Visible = false; }
            if (Passtxt.Text == " ") { PassErrorlabel.Visible = true; } else { PassErrorlabel.Visible = false; }
            if (Phonetxt.Text == " ") { PhoneErrorlabel.Visible = true; } else { PhoneErrorlabel.Visible = false; }
            if (Emailtxt.Text == " ") { EmailErrorlabel.Visible = true; } else { EmailErrorlabel.Visible = false; }
            if (StatusDropDown.SelectedIndex == -1) {StatusErrorLable.Visible = true; } else { StatusErrorLable.Visible = false; }

            if (NameErrorlabel.Visible || UsernameErrorlabel.Visible || PassErrorlabel.Visible || PhoneErrorlabel.Visible || EmailErrorlabel.Visible || StatusErrorLable.Visible)
            {
                MainClass.ShowMSG("Fields with * are mandatory", "Stop","Error"); // error is the type of msg
            }
            else
            {
                
                if (StatusDropDown.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (StatusDropDown.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (edit == 0) // Code for SAVE operaion
                {
                    
                    Insertion i = new Insertion();
                   
                    
                    i.insertUser(Nametxt.Text, Usernametxt.Text, Passtxt.Text, Phonetxt.Text, Emailtxt.Text, stat);
                    r.showUsers(dataGridView1, userIDGV, NameGV, UsernameGV, PassGV, PhoneGV, EmailGV, StatusGV);
                    MainClass.disable_reset(LeftPanel);
                } 
                else if (edit == 1) // Code for UPDATE operaion
                {
                    DialogResult dr = MessageBox.Show("Are you sure  , you want to update record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dr == DialogResult.Yes)
                    {
                        Updation u = new Updation();

                        if (StatusDropDown.SelectedIndex == 0)
                        {
                            stat = 1;
                        }
                        else if (StatusDropDown.SelectedIndex == 1)
                        {
                            stat = 0;
                        }

                        u.updateUser(UserID,Nametxt.Text, Usernametxt.Text, Passtxt.Text, Phonetxt.Text, Emailtxt.Text, stat);
                    r.showUsers(dataGridView1, userIDGV, NameGV, UsernameGV, PassGV, PhoneGV, EmailGV, StatusGV);
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
                    d.delete(UserID, "st_deleteUsers", "@id");
                    r.showUsers(dataGridView1, userIDGV, NameGV, UsernameGV, PassGV, PhoneGV, EmailGV, StatusGV);
                }
            }
        }

        public override void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (Searchtxt.Text != null)
            {
                r.showUsers(dataGridView1, userIDGV, NameGV, UsernameGV, PassGV, PhoneGV, EmailGV, StatusGV, Searchtxt.Text);
            }
            else
            {
                r.showUsers(dataGridView1, userIDGV, NameGV, UsernameGV, PassGV, PhoneGV, EmailGV, StatusGV);
            }
        }

        private void RightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public override void Viewbtn_Click(object sender, EventArgs e)
        {
            r.showUsers(dataGridView1, userIDGV, NameGV, UsernameGV, PassGV, PhoneGV, EmailGV, StatusGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) 
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                UserID = Convert.ToInt32 (row.Cells["userIDGV"].Value.ToString());
                Nametxt.Text = row.Cells["NameGV"].Value.ToString();
                Usernametxt.Text = row.Cells["UsernameGV"].Value.ToString();
                Passtxt.Text = row.Cells["PassGV"].Value.ToString();
                Phonetxt.Text = row.Cells["PhoneGV"].Value.ToString();
                Emailtxt.Text = row.Cells["EmailGV"].Value.ToString();
                StatusDropDown.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                MainClass.disable(LeftPanel);
            }
        }
    }
}
