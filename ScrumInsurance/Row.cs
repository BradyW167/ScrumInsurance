using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Bcpg.OpenPgp;

namespace ScrumInsurance
{
    public class Row
    {
        public Dictionary<string, object> Columns { get; set; }

        public Row()
        {
            Columns = new Dictionary<string, object>();
        }

        public void AddColumn(string name, object value)
        {
            Columns.Add(name, value);
        }
    }
}
