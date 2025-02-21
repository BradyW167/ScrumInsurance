using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ScrumInsurance
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
                catch (MySqlException ex)
                {
                    Console.WriteLine($"MySQL Connection Error {ex.Message}");
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
    }
}