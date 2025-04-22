using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ScrumInsurance.Queries
{
    public class InsertQuery : Query
    {
        public Dictionary<string, object> Data { get; set; }

        public InsertQuery(Dictionary<string, object> data) : base(string.Empty)
        {
            Data = data;
        }

        // Set the table to insert into
        public InsertQuery Into(string tableName)
        {
            TableName = tableName;
            return this;
        }

        // Convert this query to string ready for execution
        public override string ToString()
        {
            // Stores insert query string to build
            StringBuilder query = new StringBuilder();
            
            // Join keys with commas in a string
            var columns = string.Join(", ", Data.Keys);

            // Join @keys as parameters with commas for later insertion
            var parameters = string.Join(", ", Data.Keys.Select(k => "@" + k));

            // Creates string of requested columns
            query.Append($"INSERT INTO {TableName} ({columns})\nVALUES ({parameters})");

            // Print query to console
            Console.WriteLine(query.ToString());

            return query.ToString();
        }

        // Insert actual values into parameterized select query stored in input 'cmd'
        public override void InsertParameters(MySqlCommand cmd)
        {
            // Loop through each column in Data Dictionary
            foreach (var pair in Data)
            {
                // Insert actual value into the @ parameters
                cmd.Parameters.AddWithValue("@" + pair.Key, pair.Value);
            }
        }
    }
}