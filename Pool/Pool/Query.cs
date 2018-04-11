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
            query = "SELECT Name, Password FROM [dbo].[User] WHERE Name=@usr and Password=@pwd";
            cmd = new SqlCommand(query, conn);
            //Clear the Parameters
            cmd.Parameters.Clear();
            //Clear the Reader
            myReader = null;
            //Fill the Parameters with the right value
            cmd.Parameters.AddWithValue("@usr", Name);
            cmd.Parameters.AddWithValue("@pwd", Password);
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

        public void change_password(string Name,string Password)
        {

        
            
            query = "UPDATE [dbo].[User] SET Password=@Password where Name=@Name";
            cmd = new SqlCommand(query, conn);
     
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Password", Password);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public List<Class_regels> Inladen_regels(int gameid)
        {
            query = "SELECT a.Ruleid, a.Name, a.Description FROM dbo.[Rule] a inner join GameRule b on a.RuleId = b.RuleId" +
            " where b.GameId = @gameid";
            List<Class_regels> list_regels = new List<Class_regels>();
            cmd = new SqlCommand(query, conn);

            conn.Open();
            cmd.Parameters.AddWithValue("@gameid", gameid);
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                Class_regels class_regels = new Class_regels();
                class_regels.RuleId = (int)myReader["RuleId"];
                class_regels.Name = myReader["Name"].ToString();
                class_regels.Description = myReader["Description"].ToString();
                list_regels.Add(class_regels);
            }
            conn.Close();
            return list_regels;
        }
    }
}
