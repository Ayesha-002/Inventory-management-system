using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;



namespace Inventory_management_system
{
    internal class MainClass
    {
        
        private static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private static string s = File.ReadAllText(path + "\\connect");
        public static SqlConnection con = new SqlConnection(s);
        public  static DialogResult ShowMSG(string msg, string heading, string type)
        {
            if (type == "Success")
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void showWindow(Form openWin , Form closeWin , Form MDIWin)
        {
            closeWin.Close();
            openWin.MdiParent = MDIWin;
            openWin.WindowState = FormWindowState.Maximized;
            openWin.Show(); 
        }

        //Method overloading
        public static void showWindow(Form openWin, Form MDIWin)
        {
            openWin.MdiParent = MDIWin;
            openWin.WindowState = FormWindowState.Maximized;
            openWin.Show();
        }
        public static void disable_reset(Panel p)
        {   
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox txt = (TextBox)c;
                    txt.Enabled = false;
                    txt.Text = " ";
                }
                if (c is ComboBox)
                {
                    ComboBox cmb = (ComboBox)c;
                    cmb.Enabled = false;
                    cmb.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton radio = (RadioButton)c;
                    radio.Enabled = false;
                    radio.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox chk = (CheckBox)c;
                    chk.Enabled = false;
                    chk.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = false;
                    dtp.Value = DateTime.Now;
                }
            }
        }

        public static void disable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox txt = (TextBox)c;
                    txt.Enabled = false;
                   
                }
                if (c is ComboBox)
                {
                    ComboBox cmb = (ComboBox)c;
                    cmb.Enabled = false;
                    
                }
                if (c is RadioButton)
                {
                    RadioButton radio = (RadioButton)c;
                    radio.Enabled = false;
                   
                }
                if (c is CheckBox)
                {
                    CheckBox chk = (CheckBox)c;
                    chk.Enabled = false;
                    
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = false;
                }
            }
        }

        public static void enable_reset(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox txt = (TextBox)c;
                    txt.Enabled = true;
                    txt.Text = " ";
                }
                if (c is ComboBox)
                {
                    ComboBox cmb = (ComboBox)c;
                    cmb.Enabled = true;
                    cmb.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton radio = (RadioButton)c;
                    radio.Enabled = true;
                    radio.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox chk = (CheckBox)c;
                    chk.Enabled = true;
                    chk.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = true;
                    dtp.Value = DateTime.Now;
                }
            }
        }

        public static void enable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox txt = (TextBox)c;
                    txt.Enabled = true;
                    
                }
                if (c is ComboBox)
                {
                    ComboBox cmb = (ComboBox)c;
                    cmb.Enabled = true;
                    
                }
                if (c is RadioButton)
                {
                    RadioButton radio = (RadioButton)c;
                    radio.Enabled = true;
                    
                }
                if (c is CheckBox)
                {
                    CheckBox chk = (CheckBox)c;
                    chk.Enabled = true;
                    
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = true;
                }
            }
        }

        public static void test()
        {

        }
    }
}
