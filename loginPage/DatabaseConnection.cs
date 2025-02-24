using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPage
{
    // Database Connection Class
    //
    // By: Dr. Ryan Rybarczyk
    public class DatabaseConnection
    {
        // Default Constructor
        public DatabaseConnection() { }

        // Class Properties (Attributes)
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string DatabasePassword { get; set; }
        public string DatabaseUsername { get; set; }

        public MySqlConnection Connection { get; set; }
        public MySqlDataReader Reader { get; set; }
        public MySqlCommand Command { get; set; }

        // Attempts to open a connection to a MySQL database.
        //
        // Returns TRUE if successful and FALSE if unsuccessful.
        public bool openConnection()
        {
            if (Connection == null)
            {
                string connString = string.Format("Server={0}; database={1}; UID={2}; password={3}", ServerName, DatabaseName, DatabaseUsername, DatabasePassword);
                Connection = new MySqlConnection(connString);

                // Try-Catch to catch exceptions...
                try
                {
                    Connection.Open();
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return true;
        }

        // Closes a MySQL database connection.
        public void closeConnection()
        {
            Connection.Close();
        }

        public bool selectQuery(string tableName, string[] args)
        {
            Command = Connection.CreateCommand();

            Command.CommandText = "SELECT * FROM " + tableName + " WHERE username = @username and password = @password";
            Command.Parameters.AddWithValue("@username", args[0]);
            Command.Parameters.AddWithValue("@password", args[1]);

            Reader = Command.ExecuteReader();

            if (Reader.HasRows)
            {
                closeConnection();
                return true;
            }
            else
            {
                closeConnection();
                return false;
            }

        }
    }
}