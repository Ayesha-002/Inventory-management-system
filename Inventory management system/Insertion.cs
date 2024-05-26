using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_management_system
{
    internal class Insertion
    {
        public void insertUser(string name, string username, string password, string phone, string email)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertUsers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name",name);
                cmd.Parameters.AddWithValue("@username ",username);
                cmd.Parameters.AddWithValue("@password",password);
                cmd.Parameters.AddWithValue("@phone ",phone);
                cmd.Parameters.AddWithValue("@email ",email);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(name + "Added to the system successfully", "Success.....", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error.....", "Error");
            }
        }

    }
}
