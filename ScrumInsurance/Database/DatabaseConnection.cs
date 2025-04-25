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
using ScrumInsurance.Queries;
using MySqlX.XDevAPI.Relational;
using System.Data;
using Org.BouncyCastle.Asn1.Mozilla;

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

        // Time, in seconds, to attempt connection until an error is thrown
        public uint TimeoutWait { get; set; }

        // Database data accessproperties
        public MySqlConnection Connection { get; set; }
        public MySqlDataReader Reader { get; set; }
        public MySqlCommand Command { get; set; }
        public MySqlDataAdapter Adapter { get; set; }
        public MySqlCommandBuilder CommandBuilder { get; set; }

        // Stores query objects for exectution here
        public Query Query { get; set; }

        // Attempts to open a connection to a MySQL database.
        // Returns true on successful opening of connection, false on failure
        public bool OpenConnection()
        {
            try
            {
                if (Connection != null)
                {
                    // Check if it's marked open but is actually unusable
                    if (Connection.State == ConnectionState.Open)
                    {
                        // Throws if connection is dead
                        Connection.Ping();
                        return true;
                    }
                    else
                    {
                        Connection.Dispose();
                        Connection = null;
                    }
                }

                // Recreate and try to connect
                string connString = string.Format("Server={0};Database={1};Uid={2};Pwd={3};Connection Timeout={4}", 
                                                  ServerName, DatabaseName, DatabaseUsername, DatabasePassword, TimeoutWait);
                Connection = new MySqlConnection(connString);

                    Connection.Open();
                return true;
                }
            catch (MySqlException ex)
            {
                Console.WriteLine("Returning false, MySQL connection error: " + ex.Message);
                return false;
            }
                catch (Exception ex)
                {
                Console.WriteLine("Returning false, Unexpected error: " + ex.Message);
                    return false;
                }
            }

        // Closes a MySQL database connection.
        public void CloseConnection()
        {
            Connection.Close();
        }

        // Returns a list of rows from executing a SelectQuery stored in Query
        public List<Row> ExecuteSelect()
        {
            // Test for open connection
            if (!OpenConnection()) { return null; }

            // If Query was not a SelectQuery object, return null
            if (!(Query is SelectQuery))
            {
                Console.WriteLine("DatabaseConnection.Query not of type SelectQuery");
                return null;
            }

            // Cast query as a SelectQuery for class-specific methods
            SelectQuery sq = (SelectQuery)Query;

            // Initialize command to query database
            Command = Connection.CreateCommand();

            // Store parameterized SelectQuery converted to string in Command
            Command.CommandText = Query.ToString();

            // Passes the actual values into the command
            Query.InsertParameters(Command);

            // Test for open connection
            if (!OpenConnection()) { return null; }

            // Execute command and input results into reader
            using (Reader = Command.ExecuteReader())
            {
                // If matching data was not found in the database..+.
                if (!Reader.HasRows)
                {
                    Console.WriteLine("Select Query: Reader has no rows, returning empty list");
                    return new List<Row>();
                }
                // Else matching data was found
                else
                {
                    // Stores return data
                    List<Row> rows = new List<Row>();

                    // Stores the names of the requested columns
                    List<string> columns = sq.RequestColumns;

                    // If requesting all columns...
                    if (columns.Count == 1 && columns[0] == "*")
                    {
                        columns = new List<string>();

                        // Add column names from Reader
                        for (int i = 0; i < Reader.FieldCount; i++)
                        {
                            columns.Add(Reader.GetName(i));
                        }
                    }

                    // Read through the found database entries
                    while (Reader.Read())
                    {
                        Row row = new Row();

                        for (int i = 0; i < columns.Count; i++)
                        {
                            string column = columns[i];

                            // If column i is null
                            if (Reader.IsDBNull(Reader.GetOrdinal(column)))
                            {
                                // Set it to DBNull
                                row.AddColumn(column, DBNull.Value);
                            }
                            else
                            {
                                // Store each requested column of data
                                row.AddColumn(column, Reader[column]);
                            }
                        }

                        rows.Add(row);
                    }

                    return rows;
                }
            }
        }

        // Returns the first row from executing a SelectQuery stored in Query
        public Row ExecuteSingleSelect()
        {
            List<Row> rows = ExecuteSelect();

            Row account_data = new Row();

            // If the select query returned any rows, return the first one
            if (rows != null) { return rows[0]; }
            // If the list of rows is empty, return an empty row
            else if (rows.Count == 0) { return new Row(); }
            // Else return null
            else { return null; }
        }

        // Returns a boolean for success of executing a NonQuery (Insert,Update,Delete) stored in Query
        public bool? ExecuteNonQuery()
        {
            if (Query is SelectQuery)
            {
                Console.WriteLine("DatabaseConnection.Query is not a NonQuery, check function calls");
                return false;
            }

            // Return null on failed connection
            if (!OpenConnection()) { return null; }

            // Stores executed command result
            int result = 0;

            // Initialize command to query database
            Command = Connection.CreateCommand();

            // Store parameterized SelectQuery converted to string in Command
            Command.CommandText = Query.ToString();

            // Passes the actual values into the command
            Query.InsertParameters(Command);

            try
            {
                result = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Print error to console
                Console.WriteLine("Non Query Error: " + ex.Message);

                // Return false on failed query
                return null;
            }
            
            // Returns true if any columns were altered
            return result > 0;
        }

        /**
         * Returns a DataSet filled by an Adapter with the results of the input Select Query
         * Returns empty DataSet on error
         */
        public DataSet GetTable(SelectQuery query)
        {
            if (!OpenConnection())
            {
                Console.WriteLine("Can't connect to database");
                return new DataSet();
            }
            
            // Creates a data adapter with a select query
            Adapter = new MySqlDataAdapter(new MySqlCommand(query.ToString()));

            query.InsertParameters(Adapter.SelectCommand);

            Adapter.SelectCommand.Connection = Connection;

            // Creates a command builder for the data retreived in the adapter
            CommandBuilder = new MySqlCommandBuilder(Adapter);

            // Creates and fills a data set with the table (all rows and columns) from the select query
            DataSet dataSet = new DataSet();

            // Add the 'Accounts' data set table if it does not already exist
            if (!dataSet.Tables.Contains("Accounts")) { dataSet.Tables.Add("Accounts"); }

            try
            {
                // Fill the dataSet tabel 'Accounts' with the select query results 
                Adapter.Fill(dataSet, "Accounts");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Adapter error: " + ex.Message);
                CloseConnection();
                return new DataSet();
            }

            CloseConnection();

            return dataSet;
        }
    }
}
