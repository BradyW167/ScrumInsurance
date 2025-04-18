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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MySqlX.XDevAPI.Common;

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

        //attempt at making a datarequest function that passes back a library
        public Dictionary<int, object[]> DataRequestAll(string tableName, Dictionary<string, object> args, string[] columns)
        {
            Dictionary<int, object[]> rows = new Dictionary<int, object[]>();
            if (SelectQuery(tableName, args) != null)
            {
                Reader = Command.ExecuteReader();
                int rowNum = 0;
                while (Reader.Read())
                {
                    string[] rowData = new string[columns.Length];
                    for (int i = 0; i < rowData.Length; i++)
                    {
                        rowData[i] = Reader[columns[i]].ToString();
                    }
                    rows.Add(rowNum, rowData);
                    rowNum++;
                }
                closeConnection();
                return rows;
            }
            Console.WriteLine("Select found no matching rows.");
            closeConnection();
            return rows;
        }

        /* 
         * Executes a select query using the 'args' Dictionary as WHERE conditions
         * 'columns' paramater indicates which column values to return if found
         * Results are stored in the Reader attribute
         * Returns a list of valid rows on succesful query, null on not found or failed connection
         */
        public List<Row> SelectQuery(string tableName, Dictionary<string, object> args, string[] columns = null)
        {
            // Open SQL connection for queries
            if (!openConnection())
            {
                Console.WriteLine("Select Query: Connection failed, returning null");
                // Return false when connection fails
                return null;
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

            // Execute command and input results into reader
            using (Reader = Command.ExecuteReader())
            {
                // If matching data was not found in the database...
                if (!Reader.HasRows)
                {
                    Console.WriteLine("Select Query: Reader has no rows, returning null");
                    return null;
                }
                // Else matching data was found
                else
                {
                    // If no data is to be returned, return an empty object for truthiness
                    if ( columns == null ) {
                        Console.WriteLine("Select Query: Matching data found, but no rows to return");
                        return new List<Row>(); }

                    // Stores return data
                    List<Row> rows = new List<Row>();

                    // Read through the found database entries
                    while (Reader.Read())
                    {
                        Row row = new Row();
                        // Loop for each column of data needed
                        for (int i = 0; i < columns.Length; i++)
                        {
                            // Store each requested column of data
                            row.AddColumn(columns[i], Reader[columns[i]]);
                        }
                        rows.Add(row);
                    }

                    return rows;
                }
            }
        }

        public bool InsertQuery(string tableName, Dictionary<string, object> args)
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
            StringBuilder query = new StringBuilder("INSERT INTO " + tableName + " ( ");

            // Handles the AND placement for first condition
            bool firstCondition = true;

            // Add each column name to the INSERT parameters
            foreach (var kvp in args)
            {
                if (!firstCondition)
                {
                    query.Append(", ");
                }
                query.Append($"{kvp.Key}");
                firstCondition = false;
            }

            // Append closing parenthesis, VALUES keyword and next parenthesis
            query.Append(") VALUES (");

            firstCondition = true;

            // Add values to the VALUES parameters
            foreach (var kvp in args)
            {
                if (!firstCondition)
                {
                    query.Append(", ");
                }
                query.Append($"@{kvp.Key}");
                firstCondition = false;
            }

            // Append closing parenthesis
            query.Append(')');

            // Read query string into Command object
            Command.CommandText = query.ToString();

            // Input actual values into the query string
            foreach (var kvp in args)
            {
                Command.Parameters.AddWithValue("@" + kvp.Key, kvp.Value);
            }

            Console.WriteLine("Inserting: " + query.ToString());

            return ExecuteNonQuery();
        }

        public bool UpdateQuery(string tableName, Dictionary<string, object> matchingArgs, Dictionary<string, object> altArgs)
        {
            if (!openConnection())
            {
                // Return false when connection fails
                return false;
            }
            Command = Connection.CreateCommand();
            string cmd = "UPDATE " + tableName +
                " SET " + ConstructMatchingColumnQuery(", ", altArgs) +
                " WHERE " + ConstructMatchingColumnQuery(" AND ", matchingArgs);
            Console.WriteLine(Command.CommandText = cmd);
            return ExecuteNonQuery();
        }

        public bool DeleteQuery(string tableName, Dictionary<string, object> args)
        {
            if (!openConnection())
            {
                // Return false when connection fails
                return false;
            }
            Command = Connection.CreateCommand();
            string cmd = "DELETE FROM " + tableName +
                " WHERE " + ConstructMatchingColumnQuery(" AND ", args);
            Console.WriteLine(Command.CommandText = cmd);
            return ExecuteNonQuery();
        }

        //Adds to query "specified column name" = "specifed column vlaue" with delimiter inbetween each set
        private string ConstructMatchingColumnQuery(string delimiter, Dictionary<string, object> args)
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

        private bool ExecuteNonQuery()
        {
            // Stores executed command result
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
    }
}
