using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace ScrumInsurance.Queries
{
    public enum OrderType
    {
        ASC,
        DESC
    }

    public class SelectQuery : Query
    {
        public List<string> RequestColumns { get; set; }
        public List<(string, string, string)> WhereConditions { get; set; }
        public string JoinTable {  get; set; }
        public string JoinColumn { get; set; }
        public string OrderColumn { get; set; }
        public OrderType OrderType { get; set; }
        public int RowLimit { get; set; }

        public SelectQuery(string column = null) : base(QueryType.Select, string.Empty)
        {
            RequestColumns = new List<string> { column == null ? "*" : column };
            WhereConditions = new List<(string, string, string)>();
            JoinTable = string.Empty;
            JoinColumn = string.Empty;
            OrderColumn = string.Empty;
            OrderType = OrderType.ASC;
            RowLimit = 0;
        }

        public SelectQuery(List<string> requestColumns) : base(QueryType.Select, string.Empty) {
            RequestColumns = requestColumns;
            WhereConditions = new List<(string, string, string)>();
            JoinTable = string.Empty;
            JoinColumn = string.Empty;
            OrderColumn = string.Empty;
            OrderType = OrderType.ASC;
            RowLimit = 0;
        }

        // Set the table to query
        public SelectQuery From(string tableName)
        {
            TableName = tableName;
            return this;
        }

        // Join the FROM table with another
        public SelectQuery Join(string joinTable, string joinColumn)
        {
            JoinTable = joinTable;

            JoinColumn = joinColumn;

            return this;
        }

        // Add one where condition
        public SelectQuery Where(string arg1, string operatr, string arg2) {
            WhereConditions.Add((arg1, operatr, arg2));
            return this;    
        }

        // Add a list of where conditions
        public SelectQuery Where(List<(string, string, string)> conditions) {
            WhereConditions = conditions;
            return this;
        }

        // Add a column to order by and set the order to ASC or DESC
        public SelectQuery OrderBy(string column, OrderType order = OrderType.ASC) {
            OrderColumn = column;
            OrderType = order;
            return this;
        }

        // Add a limit of rows returned
        public SelectQuery Limit(int limit) { 
            RowLimit = limit;
            return this;
        }

        // Convert this query to string ready for execution
        public override string ToString() {
            StringBuilder query = new StringBuilder("SELECT ");

            // Converts list to Enumerable
            var columns = RequestColumns.Select(rc => rc);

            // Creates string of requested columns
            string requestColumns = string.Join(", ", columns);

            // Append columns after SELECT
            query.Append(requestColumns);

            // Append FROM 'TableName'
            query.Append($"\nFROM {TableName}");

            // If there is a join condition
            if (JoinTable != string.Empty)
            {
                query.Append($"\nINNER JOIN {JoinTable} ON {TableName}.{JoinColumn} = {JoinTable}.{JoinColumn}");
            }

            // If there are any where conditions...
            if (WhereConditions.Count > 0)
            {
                var conditions = WhereConditions.Select((wc, index) => $"{wc.Item1} {wc.Item2} @param{index}");

                string whereConditions = string.Join(" AND ", conditions);
                
                query.Append("\nWHERE " + whereConditions);

            }

            // If there is an order condition, append it
            if (OrderColumn != string.Empty) { query.Append($"\nORDER BY {OrderColumn} {OrderType.ToString()}"); }

            // If there is a limit condition, append it
            if (RowLimit > 0) { query.Append($"\nLimit = {RowLimit.ToString()}"); }

            Console.WriteLine(query.ToString());

            return query.ToString();
        }

        // Insert actual values into parameterized select query stored in input 'cmd'
        public void InsertParameters(MySqlCommand cmd)
        {
            if (WhereConditions.Count > 0)
            {
                for (int i = 0; i < WhereConditions.Count; i++)
                {
                    var (column, op, value) = WhereConditions[i];
                    cmd.Parameters.AddWithValue($"@param{i}", value);
                }
            }
        }
    }
}
