using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumInsurance
{
    public class Claim
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public int Amount { get; set; }
        public string Status { get; set; }
        /* Incomplete (Not submitted)
         * Validating (awaiting claim manager approval)
         * Financing (awaiting finance manager approval)
         * Approved (waiting for client to accept funds)
         * Closed (Hidden/Deleted)
         * Rejected (same as not submitted)
         */

        public Claim(string title, string text, string status, int amount)
        {
            Title = title;
            Text = text;
            Status = status;
            Amount = amount;
        }
    }
}
