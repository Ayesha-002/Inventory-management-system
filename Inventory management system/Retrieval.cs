using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_management_system
{
    internal class Retrieval
    {
        public void showUsers(DataGridView Gv, DataGridViewColumn userIDGV, DataGridViewColumn NameGV, DataGridViewColumn UsernameGV, DataGridViewColumn PassGV, DataGridViewColumn PhoneGV, DataGridViewColumn EmailGV, DataGridViewColumn StatusGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getUsersData", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter AD  = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                AD.Fill(dt);
                userIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                NameGV.DataPropertyName = dt.Columns["Name"].ToString();
                UsernameGV.DataPropertyName = dt.Columns["Username"].ToString();
                PassGV.DataPropertyName = dt.Columns["Password"].ToString();
                PhoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                EmailGV.DataPropertyName = dt.Columns["Email"].ToString();
                StatusGV.DataPropertyName = dt.Columns["Status"].ToString();

                Gv.DataSource = dt;

            }
            catch (Exception ex) { } 
            {

            }
        }
    }
}
