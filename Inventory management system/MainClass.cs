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
    }
}
