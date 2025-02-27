using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPage
{
    public class DatabaseConnection
    {
        // Default Constructor
        public DatabaseConnection() {}

        // Class Properties (Attributes)
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string DatabaseUsername { get; set; }
        public string DatabasePassword { get; set; }

        public MySqlConnection Connection { get; set; }
        public MySqlDataReader Reader { get; set; }
        public MySqlCommand Command { get; set; }

        // Attempts to open a connection to a MySQL database.
        //
        // Returns TRUE if successful and FALSE if unsuccessful.
        public bool openConnection()
        {
            // If connection is not instantiated or connection has been closed
            if (Connection == null || Connection.State == System.Data.ConnectionState.Closed)
            {
                // Format connection string
                string connString = string.Format("Server={0};Database={1};Uid={2};Pwd={3}", ServerName, DatabaseName, DatabaseUsername, DatabasePassword);
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

        public bool selectQuery(string tableName, string[] args)
        {
            // Open SQL connection for queries
            if (!openConnection())
            {
                // Return false when connection fails
                return false;
            }

            // Initialize command to query database
            Command = Connection.CreateCommand();

            // Assign query to command and insert args as parameters
            Command.CommandText = "SELECT * FROM " + tableName + " WHERE username = @username and password = @password";
            Command.Parameters.AddWithValue("@username", args[0]);
            Command.Parameters.AddWithValue("@password", args[1]);

            Console.WriteLine(Command.CommandText);

            // Execute command and store returned data
            Reader = Command.ExecuteReader();

            // If reader has data (matching user and password were found)
            if (Reader.HasRows)
            {
                printData(Reader);
                closeConnection();
                return true;
            }
            // Else no matching data was found (invalid username or password)
            else
            {
                Console.WriteLine("No matching data");
                closeConnection();
                return false;
            }

        }

        public void printData(MySqlDataReader dr)
        {
            while (Reader.Read()) // Iterate through each row
            {
                object[] values = new object[Reader.FieldCount]; // Create array to hold all field values
                Reader.GetValues(values); // Get all values

                for (int i = 0; i < values.Length; i++)
                {
                    Console.WriteLine($"{Reader.GetName(i)}: {values[i]}");
                }

                Console.WriteLine("-------------");
            }
        }


    }
}