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
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select..."};
                dt.Rows.InsertAt(dr, 0);
                cb.DataSource = dt;
                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;
                          }
            catch (Exception) 
            {
                throw;            
            }
        }

        public void showProducts(DataGridView Gv, DataGridViewColumn proIDGV, DataGridViewColumn proNameGV, DataGridViewColumn barGV, DataGridViewColumn priceGV, DataGridViewColumn expiryGV, DataGridViewColumn catIDGV, DataGridViewColumn catGV)

        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductData", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter AD = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                AD.Fill(dt);
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                proNameGV.DataPropertyName = dt.Columns["Product"].ToString();
                barGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                expiryGV.DataPropertyName = dt.Columns["Expiry"].ToString();
                priceGV.DataPropertyName = dt.Columns["Price"].ToString();
                catGV.DataPropertyName = dt.Columns["Category"].ToString();
                catIDGV.DataPropertyName = dt.Columns["Category ID"].ToString();
                Gv.DataSource = dt;

            }
            catch (Exception ex) { }
            {
                MainClass.ShowMSG("Unable to load categories data.", "Error", "Error");
            }
        }
        
        public static int USER_ID
        {
            get;
            private set;
        }

        public static string EMP_NAME
        {
            get;
            private set;
        }
        private static string user_name = null, pass_word = null;
        private static bool checkLogin;
        public static bool getUsersDetails(string username, string password)
        {
           
            try
            {
                SqlCommand cmd = new SqlCommand("st_getUsersDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    checkLogin = true;
                    while(dr.Read())
                    {
                        USER_ID = Convert.ToInt32(dr["ID"].ToString());
                        EMP_NAME = dr["Name"].ToString();
                        user_name = dr["Username"].ToString();
                        pass_word = dr["Password"].ToString();
                    }
                }
                else
                {
                    checkLogin = false;
                    if(username != null && password != null)
                    {
                        if (user_name != username && pass_word == password)
                        {
                            MainClass.ShowMSG("Invalid Username", "Error", "Error");
                        }
                        if (user_name == username && pass_word != password)
                        {
                            MainClass.ShowMSG("Invalid Password", "Error", "Error");
                        }
                        if (user_name != username && pass_word != password)
                        {
                            MainClass.ShowMSG("Invalid Username and Password", "Error", "Error");
                        }
                    }
                }
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.ShowMSG("Unable to login...", "Error", "Error");
            }
            return checkLogin;
        }

        public void showSuppliers(DataGridView Gv, DataGridViewColumn SuppIDGV, DataGridViewColumn comNameGV, DataGridViewColumn PersonGV, DataGridViewColumn Phone1GV, DataGridViewColumn Phone2GV, DataGridViewColumn addressGV, DataGridViewColumn ntnGV, DataGridViewColumn statusGV)

        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getSuppplierData", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter AD = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                AD.Fill(dt);
                SuppIDGV.DataPropertyName  = dt.Columns["ID"].ToString();
                comNameGV.DataPropertyName = dt.Columns["Company"].ToString();
                PersonGV.DataPropertyName  = dt.Columns["Contact Person"].ToString();
                Phone1GV.DataPropertyName  = dt.Columns["Phone1"].ToString();
                Phone2GV.DataPropertyName  = dt.Columns["Phone2"].ToString();
                addressGV.DataPropertyName = dt.Columns["Address"].ToString();
                ntnGV.DataPropertyName = dt.Columns["NTN #"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                Gv.DataSource = dt;

            }
            catch (Exception ex) { }
            {
                MainClass.ShowMSG("Unable to load Suppliers data.", "Error", "Error");
            }
        }
    }
}
