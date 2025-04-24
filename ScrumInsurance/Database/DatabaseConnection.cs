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

        // Stores query objects for exectution here
        public Query Query { get; set; }

        // Attempts to open a connection to a MySQL database.
        // Returns true on successful connection, false on failure
        public bool OpenConnection()
        {
            // If connection is not instantiated or connection has been closed
            if (Connection == null || Connection.State == ConnectionState.Closed)
            {
                // Format connection string
                string connString = string.Format("Server={0};Database={1};Uid={2};Pwd={3};Connection Timeout={4}", 
                                                  ServerName, DatabaseName, DatabaseUsername, DatabasePassword, TimeoutWait);
                Connection = new MySqlConnection(connString);

                try
                {
                    Connection.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());

                    // Returns false on connection error
                    return false;
                }
            }

            // Returns true on already open connection or successful connection
            return true;
        }

        // Closes a MySQL database connection.
        public void CloseConnection()
        {
            Connection.Close();
        }

        // Returns a list of rows from executing a SelectQuery stored in Query
        public List<Row> ExecuteSelect()
        {
            // If Query was not a SelectQuery object, return null
            if (!(Query is SelectQuery))
            {
                Console.WriteLine("DatabaseConnection.Query not of type SelectQuery");
                return null;
            }

            // Cast query as a SelectQuery for class-specific methods
            SelectQuery sq = (SelectQuery)Query;

            if (!OpenConnection()) { return null; }

            // Initialize command to query database
            Command = Connection.CreateCommand();

            // Store parameterized SelectQuery converted to string in Command
            Command.CommandText = Query.ToString();

            // Passes the actual values into the command
            Query.InsertParameters(Command);

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
                            // If column i is null
                            if (Reader.IsDBNull(Reader.GetOrdinal(columns[i])))
                            {
                                // Set it to DBNull
                                row.AddColumn(columns[i], DBNull.Value);
                            }
                            else
                            {
                                // Store each requested column of data
                                row.AddColumn(columns[i], Reader[columns[i]]);
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

        //Returns an entire table as a data set for a data grid view
        //Failure returns an empty data set
        public DataSet GetTable(SelectQuery query)
        {
            if (!OpenConnection())
            {
                Console.WriteLine("Can't connect to database");
                return new DataSet();
            }
            
            //Creates a data adapter with a select query
            Adapter = new MySqlDataAdapter(new MySqlCommand(query.ToString()));
            query.InsertParameters(Adapter.SelectCommand);
            Adapter.SelectCommand.Connection = Connection;

            //Adds auto generated parameterized commands to data adapter
            Adapter.UpdateCommand = new MySqlCommandBuilder(Adapter).GetUpdateCommand();
            Adapter.InsertCommand = new MySqlCommandBuilder(Adapter).GetInsertCommand();
            Adapter.DeleteCommand = new MySqlCommandBuilder(Adapter).GetDeleteCommand();

            //Creates and fills a data set with the table (all rows and columns) from the select query
            DataSet dataSet = new DataSet();
            try
            {
                Adapter.Fill(dataSet);
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

        //Changes a table in the database to match a table of altered data
        public bool? UpdateTable(SelectQuery query, DataSet newDataSet)
        {
            // Return null on failed connection
            if (!OpenConnection()) { return null; }

            //Puts unaltered data from database into a data set and changes values to match altered data
            DataSet oldDataSet = GetTable(query);
            for (int i = 0; i < oldDataSet.Tables[0].Columns.Count; i++)
            {
                for (int j = 0; j < oldDataSet.Tables[0].Rows.Count; j++)
                {
                    oldDataSet.Tables[0].Rows[j][oldDataSet.Tables[0].Columns[i].ColumnName] = newDataSet.Tables[0].Rows[j][newDataSet.Tables[0].Columns[i].ColumnName];
                }
            }

            //Updates the database
            int result = 0;
            try
            {
                //In theory passing newDataSet into MySqlDataAdapter.Update() should work
                //This would make previous step unnessesary, but it will not work for me
                result = Adapter.Update(oldDataSet);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Adapter error: " + ex.Message);
                CloseConnection();
                return false;
            }
            CloseConnection();
            return result > 0;
        }

        public bool? UpdateQuery(string tableName, Dictionary<string, object> matchingArgs, Dictionary<string, object> altArgs)
        {
            OpenConnection();

            Command = Connection.CreateCommand();
            string cmd = "UPDATE " + tableName +
                " SET " + ConstructMatchingColumnQuery(", ", altArgs) +
                " WHERE " + ConstructMatchingColumnQuery(" AND ", matchingArgs);
            Console.WriteLine(Command.CommandText = cmd);
            try
            {
                int numRows  = Command.ExecuteNonQuery();
                return numRows > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Update failed: " + ex.Message);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool? DeleteQuery(string tableName, Dictionary<string, object> args)
        {
            if (!OpenConnection())
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
    }
}
