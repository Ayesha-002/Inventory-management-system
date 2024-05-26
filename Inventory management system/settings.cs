using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_management_system
{
    public partial class settings : Sample
    {
        public settings()
        {
            InitializeComponent();
        }

        private void settings_Load(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string s;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (isCB.Checked)
            {
                if (ServerTxt.Text != "" && databaseTxt.Text != "")
                {
                    s = "Data Source = " + ServerTxt.Text + ";Initial Catalog = " + databaseTxt.Text + ";Integrated Security = true;";
                    File.WriteAllText(path + "\\connect", s);
                    DialogResult dr = MessageBox.Show("Settings Saved Succesfully . . .", "Information . . .", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login login = new Login();
                        MainClass.showWindow(login, this, MDI.ActiveForm);
                    }

                }
                else
                {
                    MessageBox.Show("Please give complete data to continue. . .");
                }

            }
            else
            {
                if (ServerTxt.Text != "" && databaseTxt.Text != "" && UserTxt.Text != "" && PassTxt.Text != "")
                {
                    s = "Data Source = " + ServerTxt.Text + ";Initial Catalog = " + databaseTxt.Text + ";User ID =" + UserTxt.Text + ";Password=" + PassTxt.Text + ";";
                    File.WriteAllText(path + "\\connect", s);
                    DialogResult dr = MessageBox.Show("Settings Saved Succesfully . . .", "Information . . .", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login login = new Login();
                        MainClass.showWindow(login, this, MDI.ActiveForm);
                    }

                }
            }
            


        }

        private void isCB_CheckedChanged(object sender, EventArgs e)
        {
            if (isCB.Checked)
            {
                UserTxt.Enabled = false;
                PassTxt.Enabled = false;
                UserTxt.Text = " ";
                PassTxt.Text = " ";
            }
            else
            {
                UserTxt.Enabled = true;
                PassTxt.Enabled = true;

            }
        }
    }
}
