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

        public Client(string username, string password, string role, string securityQuestion, string securityAnswer, string id = "") : base(username, password, role, securityQuestion, securityAnswer, id)
        {
            Claims = new List<Claim>();
        }

        public void AddClaim(string title, string text, string status, int amount)
        {
            Claims.Add(new Claim(title, text, status, amount));
        }

        public void RemoveClaim(int index)
        {
            Claims.Remove(Claims[index]);
        }
    }
}
