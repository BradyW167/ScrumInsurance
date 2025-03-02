using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Diagnostics;

namespace ScrumInsurance
{
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

        public string[] selectQuery(string tableName, string[] args)
        {
            // Open SQL connection for queries
            if (!openConnection())
            {
                // Return false when connection fails
                return null;
            }

            if ((args.Length % 2) == 1) //because function is now abstract, this means it NEEDS an even num of args to work. 
            {
                return null;
            }

            // Initialize command to query database
            Command = Connection.CreateCommand();

            // Assign query to command and insert args as parameters
            Command.CommandText = "SELECT * FROM " + tableName + " WHERE ";
            for (int i = 0; i < args.Length; i+=2)
            {
                Command.CommandText += "@" + i + "= @" + (i+1);
                if ((i+2) < args.Length) 
                {
                    Command.CommandText += " and ";
                }
            }

            for (int i = 0; i < args.Length; i++)
            {
                string paramString = "@" + i;
                Command.Parameters.AddWithValue(paramString, args[0]);
            }
                
  

            Console.WriteLine(Command.CommandText);

            // Execute command and store returned data
            Reader = Command.ExecuteReader();

            // If reader has data (matching user and password were found)
            if (Reader.HasRows)
            {
                //Reads every matching row
                while (Reader.Read())
                {
                    //Returns username (0th column) and role (5th column) to be used by login and session
                    //Uses password (1st column) temporarily find into correct account
                    string[] usernamePasswordRole = new string[] { Reader.GetString(0), Reader.GetString(1), Reader.GetString(5) };
                    if (usernamePasswordRole[0].Equals(args[1]) && usernamePasswordRole[1].Equals(args[3]))
                    {
                        printData(Reader);
                        closeConnection();
                        return new string[] { usernamePasswordRole[0], usernamePasswordRole[2] };
                    }
                }
                Console.WriteLine("Reader has no matching rows, this should never happen");
                closeConnection();
                return null;
            }
            // Else no matching data was found (invalid username or password)
            else
            {
                Console.WriteLine("No matching data");
                closeConnection();
                return null;
            }
        }

        public bool insertQuery(string tableName, string[] args)
        {
            // Open SQL connection for queries
            if (!openConnection())
            {
                // Return false when connection fails
                return false;
            }

            // Initialize command to query database
            Command = Connection.CreateCommand();
            // INSERT INTO login VALUES("admin", "admin1234");
            // Assign query to command and insert args as parameters
            Command.CommandText = "INSERT INTO " + tableName + " VALUES( " ;
            for (int i = 0; i<args.Length; i++)
            {
                //set up this way to make it as abstract as possible. 
                Command.CommandText = Command.CommandText + "@" + i; // we have to do @i, because text can contain @'s (for emails)
                                                                // and to pass it in as a string we need to add it via the parameter function.
                if (i < args.Length - 1)
                {
                    Command.CommandText = Command.CommandText + ", " ;
                }
                
            }
            Command.CommandText = Command.CommandText + ")";

            for (int i = 0; i < args.Length; i++)
            {
                string paramNum = "@" + i;
                Command.Parameters.AddWithValue(paramNum, args[i]);
            }

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