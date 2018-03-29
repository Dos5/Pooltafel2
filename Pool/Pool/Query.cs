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
        private SqlConnection conn = new SqlConnection
        {
            ConnectionString = @" Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\bstad\Source\Repos\Pooltafel23\Pool\Pool\Database\PoolData.mdf;Integrated Security = True"
        };
        private DataTable rules = new DataTable();
        private SqlDataReader myReader;
        private SqlCommand cmd = new SqlCommand();
        private string query;
        public DataTable Rules { get { return rules; } }
        public Query()
        {

        }
        public void RegistratieQuery(string Name, string Password, string Email, int Phonenumber)
        {
            conn.Open();
            query = "INSERT INTO  [User] VALUES (@Name, @Password, @Email, @PhoneNumber);";
            cmd = new SqlCommand(query,conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@PhoneNumber", Phonenumber);
            cmd.ExecuteNonQuery();  
            conn.Close();
        }
        public bool LoginQuery(string Name, string Password)
        {
            bool inloggen = false;
            conn.Open();
            query = "SELECT (*) FROM [User] WHERE Name=@Name and Password=@Password";
            cmd = new SqlCommand(query, conn);
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
        public void RegelsQuery()
        {   
            query = "SELECT (*) FROM [dbo].[Rule]";
            cmd = new SqlCommand(query, conn);
            myReader = null;
            conn.Open();
            using (myReader = cmd.ExecuteReader())
            {
                rules.Load(myReader);
            }
            conn.Close();
            return;
        }
    }
}
