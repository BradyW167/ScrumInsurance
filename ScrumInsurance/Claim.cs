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
        public string Status { get; set; }

        public Claim(string title, string text, string status)
        {
            Title = title;
            Text = text;
            Status = status;
        }
    }
}
