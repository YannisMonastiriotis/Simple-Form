using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Simple_Form.Services
{
    public class InsertDataLayer
    {
        public void InsertData(string connectionString, string username, string password
                   )
        {
            // define INSERT query with parameters

            var query = "INSERT INTO users (UserName,Password) VALUES(@Username,@Password)";
            // create connection and command
            using (SqlConnection cn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                // define parameters and their values
                cmd.Parameters.Add("@Username", SqlDbType.NVarChar, int.MaxValue).Value = username;
                cmd.Parameters.Add("@Password", SqlDbType.NVarChar, int.MaxValue).Value = password;
    
                // open connection, execute INSERT, close connection
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public void InsertThought(string connectionString, string username, string thought
                   )
        {
            // define UPDATE query with parameters
       
            var query = "UPDATE  users  SET thought=@Thought WHERE Username =@Username";
            // create connection and command
            using (SqlConnection cn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                // define parameters and their values
                cmd.Parameters.Add("@Username", SqlDbType.NVarChar, int.MaxValue).Value = username;
                cmd.Parameters.Add("@Thought", SqlDbType.NVarChar, int.MaxValue).Value = thought;

                // open connection, execute INSERT, close connection
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }
    }
}
