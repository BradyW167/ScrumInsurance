using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumInsurance
{
    public enum QueryType
    {
        Select,
        Insert,
        Update,
        Delete
    }

    public class Query
    {
        public QueryType Type { get; set; }
        public string TableName { get; set; }
    }
}
