﻿using System;
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
    public partial class HomeScreen :Sample

    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void Userbtn_Click(object sender, EventArgs e)
        {
            Users u = new Users();  
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void catBtn_Click(object sender, EventArgs e)
        {
            Category u = new Category();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void ProBtn_Click(object sender, EventArgs e)
        {
            products u = new products();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {

            label1.Text = Retrieval.EMP_NAME; // Your code for HomeScreen load event
           
           MDI.logoutToolStripMenuItem.Enabled = true;

        }

        private void suppBtn_Click(object sender, EventArgs e)
        {
            Supplier u = new Supplier();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }
    }
}
