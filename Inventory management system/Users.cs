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
    public partial class Users : Sample2
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            MainClass.disable(LeftPanel);
        }
        public override void Addbtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(LeftPanel);
        }

        public override void Editbtn_Click(object sender, EventArgs e)
        {

        }

        public override void Savebtn_Click(object sender, EventArgs e)
        {

        }

        public override void Deletebtn_Click(object sender, EventArgs e)
        {

        }

        public override void Searchtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
