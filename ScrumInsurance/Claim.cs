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
         * Awaiting approval from claim manager
         * Awaiting approval from finance manager
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
