using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_management_system
{
    internal class MainClass
    {
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
            }
        }


    }
}
