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
        public void showUsers(DataGridView Gv, DataGridViewColumn userIDGV, DataGridViewColumn NameGV, DataGridViewColumn UsernameGV, DataGridViewColumn PassGV, DataGridViewColumn PhoneGV, DataGridViewColumn EmailGV, DataGridViewColumn StatusGV, string data = null)
            // (string)optional arrgument shoul be written in last, (int? a = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                     cmd = new SqlCommand("st_getUsersData", MainClass.con);
                }
                else
                {
                     cmd = new SqlCommand("st_getUsersDataLIKE", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }
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

        public void showCategories(DataGridView Gv, DataGridViewColumn catIDGV, DataGridViewColumn catNameGV, DataGridViewColumn StatusGV)
      
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getCategoriesData", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter AD = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                AD.Fill(dt);
                catIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                catNameGV.DataPropertyName = dt.Columns["Category"].ToString();
                StatusGV.DataPropertyName = dt.Columns["Status"].ToString();

                Gv.DataSource = dt;

            }
            catch (Exception ex) { }
            {
                MainClass.ShowMSG("Unable to load categories data.", "Error", "Error");
            }
        }
        
        public void getCategoriesList(string proc, ComboBox cb, string displayMember, string valueMember)
        {
            try
            {
                cb.Items.Clear();
                cb.DataSource = null;
                cb.Items.Insert(0, "Select ...");
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType= CommandType.StoredProcedure;
                SqlDataAdapter AD = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                AD.Fill(dt);
                cb.DataSource = dt;
                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;
                          }
            catch (Exception) 
            {
                throw;            
            }
        }
    }
}
