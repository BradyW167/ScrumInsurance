using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ScrumInsurance
{
    public enum Status
    {
        Pending,
        Financing,
        Approved,
        Rejected
    }
    public class Claim
    {
        public long ID { get; set; }
        public long ClientID { get; set; }
        public long ClaimManagerID { get; set; }
        public long FinanceManagerID { get; set; }
        public Status Status { get; set; }
        public long Amount { get; set; }
        public string Content { get; set; }

        public string Title { get; set; }
        public DateTime Date {  get; set; }
        /* Incomplete (Not submitted)
         * Validating (awaiting claim manager approval)
         * Financing (awaiting finance manager approval)
         * Approved (waiting for client to accept funds)
         * Closed (Hidden/Deleted)
         * Rejected (same as not submitted)
         */

        public Claim(long client_id, DateTime date)
        {
            ClientID = client_id;
            Status = Status.Pending;
            Date = date;
        }

        // Constructs claim object from row object
        public Claim(Row row)
        {
            if (row.Columns.TryGetValue("id", out var id)) ID = Convert.ToInt64(id);
            if (row.Columns.TryGetValue("client_id", out var client_id) && client_id != DBNull.Value) ClientID = Convert.ToInt64(client_id);
            if (row.Columns.TryGetValue("claim_manager_id", out var claim_manager_id) && claim_manager_id != DBNull.Value) ClaimManagerID = Convert.ToInt64(claim_manager_id);
            if (row.Columns.TryGetValue("finance_manager_id", out var finance_manager_id) && finance_manager_id != DBNull.Value) FinanceManagerID = Convert.ToInt64(finance_manager_id);
            if (row.Columns.TryGetValue("status", out var status) && status != DBNull.Value)
            {
                if (Status.TryParse<Status>(status.ToString(), out var stat))
                {
                    Status = stat;
                }
            }
            if (row.Columns.TryGetValue("amount", out var amount) && amount != DBNull.Value) Amount = Convert.ToInt64(amount);
            if (row.Columns.TryGetValue("content", out var content) && content != DBNull.Value) Content = content.ToString();
            if (row.Columns.TryGetValue("date", out var date) && date != DBNull.Value) Date = Convert.ToDateTime(date);
        }

        public Claim(string title, string text, string status, long amount)
        {
            Status.TryParse("Active", out Status tempStatus);
            Title = title;
            Content = text;
            Status = tempStatus;
            Amount = amount; 
            
        }
    }
}
