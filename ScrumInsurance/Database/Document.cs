using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlX.XDevAPI.Relational;

namespace ScrumInsurance.Database
{
    public class Document
    {
        public long ID { get; set; }
        public string ClaimID { get; set; }
        public string FileName { get; set; }
        public byte[] FileData { get; set; }
        public DateTime UploadDate { get; set; }

        public Document(Row row)
        {
            if (row.Columns.TryGetValue("id", out var id)) 
                ID = Convert.ToInt64(id);
            if (row.Columns.TryGetValue("claim_id", out var claim_id)) 
                ClaimID = claim_id.ToString();
            if (row.Columns.TryGetValue("file_name", out var file_name)) 
                FileName = file_name.ToString();
            if (row.Columns.TryGetValue("file_data", out var file_data)) 
                FileData = (byte[])file_data;
            if (row.Columns.TryGetValue("upload_date", out var date)) 
                UploadDate = Convert.ToDateTime(date);
        }

        public override string ToString()
        {
            return $"ID: {ID}, ClaimID: {ClaimID}, FileName: {FileName}, UploadDate: {UploadDate}, ";
        }
    }
}
