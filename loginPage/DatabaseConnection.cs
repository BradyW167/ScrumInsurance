using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPage
{
    {
        // Default Constructor
        public DatabaseConnection()
        {
            // We can move this to a property file later to avoid unncessary clutter and hardcoding.
            ServerName = "trevor.butler.edu";
            DatabaseName = "scrum_gang";
            DatabaseUsername = "scrumgang";
            DatabasePassword = "Z9wAabwUKeZy5pxvF5GE";

            string connString = string.Format("Server={0}; database={1}; UID={2}; password={3}", ServerName, DatabaseName, DatabaseUsername, DatabasePassword);
            Connection = new MySqlConnection(connString);
        }

        // Class Properties (Attributes)
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string DatabasePassword { get; set; }
        public string DatabaseUsername { get; set; }
        public MySqlConnection Connection { get; set; }
        public MySqlDataReader Reader { get; set; }
        public MySqlCommand Command { get; set; }

        public bool selectQuery(string tableName, string[] args)
        {
            // Try-Catch to catch exceptions...
            try
            {
                Connection.Open();
            }
            catch (Exception ex)
            {
                // Need to handle this.
            }

            Command = Connection.CreateCommand();

            Command.CommandText = "SELECT * from " + tableName + " WHERE username = @username and password = @password";
            Command.Parameters.AddWithValue("@username", args[0]);
            Command.Parameters.AddWithValue("@password", args[1]);

            Reader = Command.ExecuteReader();

            if (Reader.HasRows)
            {
                Connection.Close();
                return true;
            }
            else
            {
                Connection.Close();
                return false;
            }
        }
    }
}