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
            username_ = username;
            password_ = password;
            email_ = email;
            securityQuestion_ = securityQuestion;
            securityAnswer_ = securityAnswer;
        }

        public bool validCreds(string username, string password)
        {
            return username_.Equals(username) && password_.Equals(password);
        }

        public bool validCreds(string email)
        {
            return email_.Equals(email);
        }

        public string username_ { get; set; }
        public string password_ { get; set; }
        public string email_ { get; set; }
        public string securityQuestion_  {  get; set; }
        public string securityAnswer_ { get; set; }
    }
}
