using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BOL;

namespace DAL1
{
    public static class AdminDAL
    {
        public static bool ValidateAdmin(string Email, string Password)
        {
            bool status = false;
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\nam adjava\dot_net\first_project\WPFEcomm\App_Data\Admin.mdf;Integrated Security=True";
            con.ConnectionString = conString;
            string cmdString = "select *from Admin where Email=@Email and Password=@Password ";
            cmd.CommandText = cmdString;

            cmd.Parameters.Add(new SqlParameter("@Email", Email));
            cmd.Parameters.Add(new SqlParameter("@Password", Password));
            cmd.Connection = con;
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    status = true;
                }
                reader.Close();
            }
            catch (SqlException exp)
            {
                Console.WriteLine(exp.Message);
            }
            finally
            {
                con.Close();
            }
            return status;
        }
        public static bool Register(AdminBOL admin)
        {
            bool status = false;

            SqlConnection con = new SqlConnection();
              SqlCommand cmd = new SqlCommand("AddAdminDetails",con);
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\nam adjava\dot_net\first_project\WPFEcomm\App_Data\Admin.mdf;Integrated Security=True";
            con.ConnectionString = conString;
            string cmdString = "insert into Admin(Email,Password) values(@Email,@Password)";
           cmd.CommandText = cmdString;
            
            
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("@Email", admin.Email);
                cmd.Parameters.AddWithValue("@Password", admin.Password);
                con.Close();
                status = true;
                return status;

            
        }
    }
}
