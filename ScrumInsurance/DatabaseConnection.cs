using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Windows.Forms.VisualStyles;
using System.Collections;

namespace ScrumInsurance
{
    public class DatabaseConnection
    {
        // Default Constructor
        public DatabaseConnection() { }

        // Database connection string properties
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string DatabasePassword { get; set; }
        public string DatabaseUsername { get; set; }

        // Database data accessproperties
        public MySqlConnection Connection { get; set; }
        public MySqlDataReader Reader { get; set; }
        public MySqlCommand Command { get; set; }

        // Attempts to open a connection to a MySQL database.
        // Returns true on successful connection, false on failure
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

        //Returns a row of specified columns from a specified table, containing all matching arguments
        //Currently only returns last matching row's information
        public string[] DataRequest(string tableName, Dictionary<string, string> args, string[] columns)
        {
            string[] row = new string[columns.Length];
            if (selectQuery(tableName, args) && Reader.HasRows)
            {
                while (Reader.Read())
                {
                    for (int i = 0; i < row.Length; i++)
                    {
                        row[i] = Reader[columns[i]].ToString();
                    }
                }
                closeConnection();
                return row;
            }
            Console.WriteLine("Select found no matching rows.");
            closeConnection();
            return null;
        }

        /* 
         * Executes a select query using the args Dicionary as WHERE conditions
         * Results are stored in the Reader attribute
         * Returns true on succesful query, false on failed connection
         */
        public bool selectQuery(string tableName, Dictionary<string, string> args)
        {
            // Open SQL connection for queries
            if (!openConnection())
            {
                // Return false when connection fails
                return false;
            }

            // Initialize command to query database
            Command = Connection.CreateCommand();

            // Initialize string to build query
            StringBuilder query = new StringBuilder("SELECT * FROM " + tableName + " WHERE ");

            // Handles the AND placement for first condition
            bool firstCondition = true;

            // Add each condition to the WHERE clause
            foreach (var kvp in args)
            {
                if (!firstCondition)
                {
                    query.Append(" AND ");
                }
                query.Append($"{kvp.Key} = @{kvp.Key}");
                firstCondition = false;
            }

            // Read query string into Command object
            Command.CommandText = query.ToString();

            // Input actual values into the query string
            foreach (var kvp in args)
            {
                Command.Parameters.AddWithValue("@" + kvp.Key, kvp.Value);
            }

            // Write command to console for debugging
            Console.WriteLine(Command.CommandText);

            // Execute command and store returned data
            Reader = Command.ExecuteReader();

            // Return true on successful query
            return true;
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
            if (Reader != null && Reader.HasRows)
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

        public bool updateQuery(string tableName, Dictionary<string, string> matchingArgs, Dictionary<string, string> altArgs)
        {
            return NonQuery("UPDATE " + tableName +
                " SET " + ConstructMatchingColumnQuery(", ", altArgs) +
                " WHERE " + ConstructMatchingColumnQuery(" AND ", matchingArgs));
        }
        
        public bool DeleteQuery(string tableName, Dictionary<string, string> args)
        {
            return NonQuery("DELETE FROM " + tableName +
                " WHERE " + ConstructMatchingColumnQuery(" AND ", args));
        }

        //Adds to query "specified column name" = "specifed column vlaue" with delimiter inbetween each set
        private string ConstructMatchingColumnQuery(string delimiter, Dictionary<string, string> args)
        {
            string query = "";
            for (int i = 0; i < args.Count; i++)
            {
                if (i > 0)
                {
                    query += delimiter;
                }
                query += args.ElementAt(i).Key + " = '" + args.ElementAt(i).Value + "'";
            }
            return query;
        }

        private  bool NonQuery(string nonquery)
        {
            if (!openConnection())
            {
                // Return false when connection fails
                return false;
            }

            Command = Connection.CreateCommand();
            Command.CommandText = nonquery;

            int result = 0;

            try
            {
                result = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Print error to console
                Console.WriteLine("Non Query Error: " + ex.Message);

                // Return false on failed query
                closeConnection();
                return false;
            }
            closeConnection();
            // If any number of columns were altered...
            // Return true for successful update, return false on no changes
            return result > 0;
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