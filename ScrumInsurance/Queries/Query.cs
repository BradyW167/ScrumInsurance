using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ScrumInsurance.Queries
{
    public abstract class Query
    {
        public string TableName { get; set; }

        public Query (string tableName)
        {
            TableName = tableName;
        }

        public override abstract string ToString();

        public abstract void InsertParameters(MySqlCommand cmd);
    }
}
