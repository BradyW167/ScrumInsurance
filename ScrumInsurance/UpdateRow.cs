using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumInsurance.src
{
    public class UpdateRow
    {
        public string IndexColumn { get; set; }
        public string IndexColumnValue { get; set; }
        public string[] ChangeColumns { get; set; }
        public string[] ChangeColumnsValues { get; set; }

        public UpdateRow(string indexColumn, string indexColumnValue, string[] changeColumns, string[] changeColumnsValues)
        {
            this.IndexColumn = indexColumn;
            this.IndexColumnValue = indexColumnValue;
            this.ChangeColumns = changeColumns;
            this.ChangeColumnsValues = changeColumnsValues;
        }
    }
}
