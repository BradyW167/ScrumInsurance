using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using System.Security.Cryptography.X509Certificates;

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
        public List<(string, string, object)> WhereConditions { get; set; }
        public List<(string, string, string, object)> JoinConditions { get; set; }
        public string JoinType { get; set; }
        public string GroupColumn { get; set; }
        public string OrderColumn { get; set; }
        public OrderType OrderType { get; set; }
        public int RowLimit { get; set; }

        // Default constructor, selects all columns or one input column
        public SelectQuery(string column = "*") : base(string.Empty)
        {
            RequestColumns = new List<string> { column };
            WhereConditions = new List<(string, string, object)>();
            JoinConditions = new List<(string, string, string, object)>();
            JoinType = string.Empty;
            GroupColumn = string.Empty;
            OrderColumn = string.Empty;
            OrderType = OrderType.ASC;
            RowLimit = 0;
        }

        // Selects a list of input request columns
        public SelectQuery(List<string> requestColumns) : base(string.Empty) {
            RequestColumns = requestColumns;
            WhereConditions = new List<(string, string, object)>();
            JoinConditions = new List<(string, string, string, object)>();
            JoinType = string.Empty;
            GroupColumn = string.Empty;
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
        // Join type defaults to INNER
        public SelectQuery Join(string joinTable, string fromTableColumn, string joinTableColumn, string joinType = "INNER")
        {
            JoinConditions.Add((joinType, joinTable, fromTableColumn, joinTableColumn));

            return this;
        }

        // Add one where condition
        public SelectQuery Where(string column, string operatr, object value) {
            WhereConditions.Add((column, operatr, value));
            return this;    
        }

        // Add a list of where conditions
        public SelectQuery Where(List<(string, string, object)> conditions) {
            WhereConditions = conditions;
            return this;
        }

        public SelectQuery GroupBy(string groupColumn)
        {
            GroupColumn = groupColumn;
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
            var columns = RequestColumns.Select(rc =>
                rc.Contains(".") ? $"{rc} AS `{rc}`" : rc
            );

            // Creates string of requested columns
            string requestColumns = string.Join(", ", columns);

            // Append columns after SELECT
            query.Append(requestColumns);

            // Append FROM 'TableName'
            query.Append($"\nFROM {TableName}");

            // If there are any join conditions...
            if (JoinConditions.Count > 0)
            {
                var conditions = JoinConditions.Select((jc, index) => $"{jc.Item1} JOIN {jc.Item2} ON {TableName}.{jc.Item3} = {jc.Item2}.{jc.Item4}");

                string joinConditions = string.Join("\n", conditions);

                query.Append("\n" + joinConditions);

            }

            // If there are any where conditions...
            if (WhereConditions.Count > 0)
            {
                var conditions = WhereConditions.Select((wc, index) => $"{wc.Item1} {wc.Item2} @param{index}");

                string whereConditions = string.Join(" AND ", conditions);
                
                query.Append("\nWHERE " + whereConditions);

            }

            // If there is a group by condition, append it
            if (GroupColumn != string.Empty) { query.Append($"\nGROUP BY {GroupColumn}"); }

            // If there is an order condition, append it
            if (OrderColumn != string.Empty) { query.Append($"\nORDER BY {OrderColumn} {OrderType.ToString()}"); }

            // If there is a limit condition, append it
            if (RowLimit > 0) { query.Append($"\nLIMIT {RowLimit.ToString()}"); }

            // Console.WriteLine(query.ToString());

            return query.ToString();
        }

        // Insert actual values into parameterized select query stored in input 'cmd'
        public override void InsertParameters(MySqlCommand cmd)
        {
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
