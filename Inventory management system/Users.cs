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

namespace Inventory_management_system
{
    public partial class Users : Sample2
    {
        int edit = 0; // This 0 is an indication to SAVE operation and 1 is an indication to UPDATE operation
        public Users()
        {
            InitializeComponent();
        }
        Retrieval r = new Retrieval();
        private void Users_Load(object sender, EventArgs e)
        {
            MainClass.disable(LeftPanel);
            r.showUsers(dataGridView1, userIDGV, NameGV, UsernameGV, PassGV, PhoneGV, EmailGV, StatusGV);
        }
        public override void Addbtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(LeftPanel);
            edit = 0;
        }

        public override void Editbtn_Click(object sender, EventArgs e)
        {
            edit = 1;

        }

        public override void Savebtn_Click(object sender, EventArgs e)
        {
            if (Nametxt.Text == " ") { NameErrorlabel.Visible = true; } else { NameErrorlabel.Visible = false; }
            if (Usernametxt.Text == " ") { UsernameErrorlabel.Visible = true; } else { UsernameErrorlabel.Visible = false; }
            if (Passtxt.Text == " ") { PassErrorlabel.Visible = true; } else { PassErrorlabel.Visible = false; }
            if (Phonetxt.Text == " ") { PhoneErrorlabel.Visible = true; } else { PhoneErrorlabel.Visible = false; }
            if (Emailtxt.Text == " ") { EmailErrorlabel.Visible = true; } else { EmailErrorlabel.Visible = false; }

            if (NameErrorlabel.Visible || UsernameErrorlabel.Visible || PassErrorlabel.Visible || PhoneErrorlabel.Visible || EmailErrorlabel.Visible)
            {
                MainClass.ShowMSG("Fields with * are mandatory", "Stop","Error"); // error is the type of msg
            }
            else
            {
                if (edit == 0) // Code for SAVE operaion
                {
                    Insertion i = new Insertion();
                    
                    i.insertUser(Nametxt.Text,Usernametxt.Text,Passtxt.Text,Phonetxt.Text,Emailtxt.Text);
                    r.showUsers(dataGridView1,userIDGV,NameGV,UsernameGV,PassGV,PhoneGV,EmailGV,StatusGV);
                    MainClass.disable_reset(LeftPanel);
                } 
                else if (edit == 1) // Code for UPDATE operaion
                {
                    Updation u = new Updation();
                    u.updateUser(0,Nametxt.Text, Usernametxt.Text, Passtxt.Text, Phonetxt.Text, Emailtxt.Text);
                    r.showUsers(dataGridView1, userIDGV, NameGV, UsernameGV, PassGV, PhoneGV, EmailGV, StatusGV);
                    MainClass.disable_reset(LeftPanel);
                }
            }
        }

        public override void Deletebtn_Click(object sender, EventArgs e)
        {


        }

        public override void Searchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void RightPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
