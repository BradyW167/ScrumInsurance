using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowserGitHubDemo
{
    public static class Session
    {
        private static List<Account> accounts = new List<Account>();
        public static int UserID { get; set; }

        public static void AddAccount(string username, string password, string email, string securityQuestion, string securityQuestionAnswer)
        {
            accounts.Add(new Account(username, password, email, securityQuestion, securityQuestionAnswer));
        }

        public static int FindAccount(string username, string password)
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].validCreds(username, password))
                {
                    return i;
                }
            }
            return -1;
        }

        public static int FindAccount(string email)
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].validCreds(email))
                {
                    return i;
                }
            }
            return -1;
        }

        public static Account GetAccount(int index)
        {
            return accounts[index];
        }

        // Moved swapcontrol back to main form
        // It is part of the UI not part of the login system
        // So it should sit with the other UI code
    }
}
