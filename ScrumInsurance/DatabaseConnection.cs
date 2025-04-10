﻿using MySql.Data.MySqlClient;
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

        public bool CheckDuplicateUsername(string username)
        {
            // Create parameter dictionary for login query
            Dictionary<string, object> user_info = new Dictionary<string, object>
            {
                { "username", (object)username }
            };

            SelectQuery("User", user_info);

            // Returns true on matching username found, false if not found
            return Reader.HasRows;
        }

        //Returns a row of specified columns from a specified table, containing all matching arguments
        //Currently only returns last matching row's information
        public string[] DataRequest(string tableName, Dictionary<string, object> args, string[] columns)
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


        //attempt at making a datarequest function that passes back a library
        public Dictionary<int, object[]> DataRequestAll(string tableName, Dictionary<string, object> args, string[] columns)
        {
            Dictionary<int, object[]> rows = new Dictionary<int, object[]>();
            if (selectQuery(tableName, args) && Reader.HasRows)
            {
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
            return null;
        }

        /* 
         * Executes a select query using the 'args' Dictionary as WHERE conditions
         * 'columns' paramater indicates which column values to return if found
         * Results are stored in the Reader attribute
         * Returns an object on succesful query, null on not found or failed connection
         */
        public object[] SelectQuery(string tableName, Dictionary<string, object> args, string[] columns = null)
        {
            // Open SQL connection for queries
            if (!openConnection())
            {
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

            // Write command to console for debugging
            Console.WriteLine("Select Query: " + Command.CommandText);

            using (Reader = Command.ExecuteReader())
            {
                // If matching data was not found in the database...
                if (!Reader.HasRows)
                {
                    return null;
                }
                // Else matching data was found
                else
                {
                    // If no data is to be returned, return an empty object for truthiness
                    if ( columns == null ) { return new object[0]; }

                    // Stores return data
                    object[] data = new object[columns.Length];

                    // Read through the found database entries
                    while (Reader.Read())
                    {
                        // Loop for each column of data needed
                        for (int i = 0; i < columns.Length; i++)
                        {
                            // Store each requested column of data into the data array
                            data[i] = Reader[columns[i]];
                        }
                    }

                    return data;
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

        public bool UpdateQuery(string tableName, Dictionary<string, string> matchingArgs, Dictionary<string, string> altArgs)
        {
            Command = Connection.CreateCommand();
            Command.CommandText = "UPDATE " + tableName +
                " SET " + ConstructMatchingColumnQuery(", ", altArgs) +
                " WHERE " + ConstructMatchingColumnQuery(" AND ", matchingArgs);

            return ExecuteNonQuery();
        }

        public bool DeleteQuery(string tableName, Dictionary<string, string> args)
        {
            Command = Connection.CreateCommand();
            Command.CommandText = "DELETE FROM " + tableName +
                " WHERE " + ConstructMatchingColumnQuery(" AND ", args);

            return ExecuteNonQuery();
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

        private bool ExecuteNonQuery()
        {
            if (!openConnection())
            {
                // Return false when connection fails
                return false;
            }

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
