using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_management_system
{
    public partial class Login : Sample
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (usernametxt.Text == " ") {usernameErrorLabel.Visible = true; } else { usernameErrorLabel.Visible = false; }
            if (passtxt.Text == " ") { PassErrorLable.Visible = true; } else { PassErrorLable.Visible = false; }
            if(usernameErrorLabel.Visible || PassErrorLable.Visible)
            {
                MainClass.ShowMSG("Fields with * are mandatory", "Stop", "Error"); // error is the type of msg
            }
            else
            {
                 
            }
            
                if (Retrieval.getUsersDetails(usernametxt.Text, passtxt.Text))
                {
                    HomeScreen hm = new HomeScreen();
                    MainClass.showWindow(hm, this, MDI.ActiveForm);

                }
                else
                {

                }
            
        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {
            if(usernametxt.Text == " ") { usernameErrorLabel.Visible = true; } else { usernameErrorLabel.Visible = false; }
        }

        private void passtxt_TextChanged(object sender, EventArgs e)
        {
            if (usernametxt.Text == " ") { usernameErrorLabel.Visible = true; } else { usernameErrorLabel.Visible = false; }
        }
    }
}
