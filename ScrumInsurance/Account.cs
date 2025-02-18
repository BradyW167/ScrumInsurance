using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumInsurance
{
    public class Account
    {
        public Account(string username, string password, string email, string securityQuestion, string securityAnswer)
        {
            Username = username;
            Password = password;
            Email = email;
            SecurityQuestion = securityQuestion;
            SecurityAnswer = securityAnswer;
        }

        public bool validCreds(string username, string password)
        {
            return Username.Equals(username) && Password.Equals(password);
        }

        public bool validCreds(string email)
        {
            return Email.Equals(email);
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string SecurityQuestion  {  get; set; }
        public string SecurityAnswer { get; set; }
    }
}
