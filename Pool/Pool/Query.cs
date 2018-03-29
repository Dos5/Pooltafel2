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
        public Query()
        {
        }
        //Fields
        private SqlConnection conn = new SqlConnection
        {
            ConnectionString = @" Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename="+ Environment.CurrentDirectory + @"\Database\PoolData.mdf;Integrated Security = True"
        };
        private DataTable rules = new DataTable();
        private SqlDataReader myReader;
        private SqlCommand cmd = new SqlCommand();
        private string query;
        private bool inloggen;
        //Properties
        public DataTable Rules { get { return rules; } }
        public void RegistratieQuery(string Name, string Password, string Email, int Phonenumber)
        {
            //Set the Command
            query = "INSERT INTO [dbo].[User] VALUES (@Name, @Password, @Email, @PhoneNumber);";
            cmd = new SqlCommand(query, conn);
            //Clear the Parameters
            cmd.Parameters.Clear();
            //Fill the Parameters with the right value
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@PhoneNumber", Phonenumber);
            //Open the Connection
            conn.Open();
            //Preform the Command
            cmd.ExecuteNonQuery();
            //Close the Connection
            conn.Close();
        }
        public bool LoginQuery(string Name, string Password)
        {
            //Set the Bool False
            inloggen = false;
            //Set the Command
            query = "SELECT Name,Password FROM [dbo].[User] WHERE Name=@Name and Password=@Password";
            cmd = new SqlCommand(query, conn);
            //Clear the Parameters
            cmd.Parameters.Clear();
            //Clear the Reader
            myReader = null;
            //Fill the Parameters with the right value
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Password", Password);
            //Open the Connection
            conn.Open();
            //Preform the Command
            myReader = cmd.ExecuteReader();
            //If the User was found set True
            if (myReader.HasRows)
            {
                inloggen = true;
            }
            //Else stay False
            else
            {
                inloggen = false;
            }
            //Close the Connection
            conn.Close();
            return inloggen;
        }
        public void RegelsQuery()
        {   
            //Set the Command
            query = "SELECT * FROM [dbo].[Rule]";
            cmd = new SqlCommand(query, conn);
            //Clear the Reader
            myReader = null;
            //Open the Connection
            conn.Open();
            //Preform the Command
            using (myReader = cmd.ExecuteReader())
            {
                //Fill the DataTable with the Reader
                rules.Load(myReader);
            }
            //Close the Connection
            conn.Close();
            return;
        }
    }
}
