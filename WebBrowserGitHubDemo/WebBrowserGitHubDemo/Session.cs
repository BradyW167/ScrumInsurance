using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowserGitHubDemo
{
    public class Session
    {
        private List<Account> accounts;

        public Session()
        {
            accounts = new List<Account>();
        }

        public void AddAccount(string username, string password, string email, string securityQuestion, string securityQuestionAnswer)
        {
            accounts.Add(new Account(username, password, email, securityQuestion, securityQuestionAnswer));
        }

        public bool ValidAccount(string username, string password)
        {
            foreach (Account account in accounts)
            {
                if (account.ValidCreditials(username, password))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
