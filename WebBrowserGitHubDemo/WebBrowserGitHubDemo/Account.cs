using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowserGitHubDemo
{
    public class Account
    {
        public Account(string username, string password, string email, string securityQuestion, string securityAnswer)
        {
            Username = username;
            Password = password;
            Email = email;
            SecurityQuestion = securityQuestion;
            SecurityQuestionAnswer = securityAnswer;
        }

        public bool ValidCreditials(string username, string password)
        {
            return Username.Equals(username) && Password.Equals(password);
        }

        public bool ValidCreditials(string email)
        {
            return Email.Equals(email);
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string SecurityQuestion  {  get; set; }
        public string SecurityQuestionAnswer { get; set; }
    }
}
