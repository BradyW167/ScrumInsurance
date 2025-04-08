using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ScrumInsurance
{
    public class Client : Account
    {
        public List<Claim> Claims { get; set; }

        public Client() : base()
        {
            Claims = new List<Claim>();
        }

        public Client(string username, string password, string role, string securityQuestion, string securityAnswer, int userid = 0) : base(username, password, role, securityQuestion, securityAnswer, userid)
        {
            Claims = new List<Claim>();
        }

        public void AddClaim(string title, string text, string status)
        {
            Claims.Add(new Claim(title, text, status));
        }

        public void RemoveClaim(int index)
        {
            Claims.Remove(Claims[index]);
        }
    }
}
