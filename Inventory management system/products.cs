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
    public partial class products : Sample2
    {
        public products()
        {
            InitializeComponent();
        }
        Retrieval r = new Retrieval();  
        private void products_Load(object sender, EventArgs e)
        {

        }
        public override void Addbtn_Click(object sender, EventArgs e)
        {
            r.getCategoriesList("st_getCategoriesList", CategoryDropDown, "Category", "ID");
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

        public override void Viewbtn_Click(object sender, EventArgs e)
        {

        }

        private void RightPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
