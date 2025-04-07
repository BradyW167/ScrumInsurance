using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumInsurance
{
    public class Account
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }

        // Default constructor
        public Account()
        {
            UserID = 0;
            Username = string.Empty;
            Password = string.Empty;
            Role = string.Empty;
            SecurityQuestion = string.Empty;
            SecurityAnswer = string.Empty;
        }

        /* 
         * Create account from input account info parameters
         * UserID is optional because account creation does not require an input userid
         */
        public Account(string username, string password, string role, string securityQuestion, string securityAnswer, int userid = 0)
        {
            UserID = userid;
            Username = username;
            Password = password;
            Role = role;
            SecurityQuestion = securityQuestion;
            SecurityAnswer = securityAnswer;
        }

        public bool validCreds(string username, string password)
        {
            return Username.Equals(username) && Password.Equals(password);
        }

        public bool validCreds(string username)
        {
            return Username.Equals(username);
        }
    }
}
