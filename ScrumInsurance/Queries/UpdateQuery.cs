using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ScrumInsurance.Queries
{
    public class UpdateQuery : Query
    {
        public Dictionary<string, object> SetColumns { get; set; }
        public List<(string, string, object)> WhereConditions { get; set; }


        public UpdateQuery(string tableName) : base(tableName)
        {
            WhereConditions = new List<(string, string, object)>();
        }

        // Add one column and value to update
        public UpdateQuery Set(string column, string value)
        {
            SetColumns.Add(column, value);
            return this;
        }

        // Set the columns to update
        public UpdateQuery Set(Dictionary<string, object> setColumns)
        {
            SetColumns = setColumns;
            return this;
        }

        // Add one where condition
        public UpdateQuery Where(string column, string operatr, object value)
        {
            WhereConditions.Add((column, operatr, value));
            return this;
        }

        // Add a list of where conditions
        public UpdateQuery Where(List<(string, string, object)> conditions)
        {
            WhereConditions = conditions;
            return this;
        }

        // Convert this query to string ready for execution
        public override string ToString()
        {
            // Stores insert query string to build
            StringBuilder query = new StringBuilder($"UPDATE {TableName}");

            var columns = SetColumns.Select(kvp => $"{kvp.Key} = @{kvp.Key}");

            string setColumns = string.Join(", ", columns);

            query.Append("\nSET " + setColumns);

            // If there are any where conditions...
            if (WhereConditions.Count > 0)
            {
                var conditions = WhereConditions.Select((wc, index) => $"{wc.Item1} {wc.Item2} @param{index}");

                string whereConditions = string.Join(" AND ", conditions);

                query.Append("\nWHERE " + whereConditions);

            }

            // Print query to console
            Console.WriteLine(query.ToString());

            return query.ToString();
        }

        // Insert actual values into parameterized select query stored in input 'cmd'
        public override void InsertParameters(MySqlCommand cmd)
        {
            // Loop through each column in the Set Columns Dictionary
            foreach (var pair in SetColumns)
            {
                // Insert actual value into the @ parameters
                cmd.Parameters.AddWithValue("@" + pair.Key, pair.Value);
            }

            // If there are any where conditions...
            if (WhereConditions.Count > 0)
            {
                for (int i = 0; i < WhereConditions.Count; i++)
                {
                    // Store each condition as its three parts
                    var (column, op, value) = WhereConditions[i];
                    // Add the actual value into the paramaterized query string
                    cmd.Parameters.AddWithValue($"@param{i}", value);
                }
            }
        }
    }
}