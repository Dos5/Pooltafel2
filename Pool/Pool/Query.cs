using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Pool
{
    class Query
    {
        private int UserId;
        private string Name;
        private string Password;
        private string Email;
        private string PhoneNumber;
        public Query()
        {

        }
        private SqlConnection conn = new SqlConnection
        {
            ConnectionString = @" Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\bstad\Source\Repos\Pooltafel23\Pool\Pool\Database\PoolData.mdf;Integrated Security = True"
        };
        public void registratie(string Name, string Password, string Email, int Phonenumber)
        {
                conn.Open();
                string query = "INSERT INTO  [User] VALUES (@Name, @Password, @Email, @PhoneNumber);";
                SqlCommand cmd = new SqlCommand(query,conn);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@PhoneNumber", Phonenumber);
                cmd.ExecuteNonQuery();  
                conn.Close();
        }
        public bool login(string Name, string Password)
        {
            bool inloggen = false;
            conn.Open();
            string query = "select * from [User] where Name=@Name and Password=@Password";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Password", Password);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                inloggen = true;
            }
            else
            {
                inloggen = false;
            }
            conn.Close();
            return inloggen;
        }
    }
}
