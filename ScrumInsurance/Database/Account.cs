using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Cms;
using System.Xml.Linq;
using MySqlX.XDevAPI.Relational;

namespace ScrumInsurance
{
    public class Account
    {
        public long ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }

        // Default constructor
        public Account()
        {
            ID = 0;
            Username = string.Empty;
            Password = string.Empty;
            Role = string.Empty;
            SecurityQuestion = string.Empty;
            SecurityAnswer = string.Empty;
        }

        public Account(Row row)
        {
            if (row.Columns.TryGetValue("id", out var id)) ID = Convert.ToInt64(id);
            if (row.Columns.TryGetValue("username", out var username)) Username = username.ToString();
            if (row.Columns.TryGetValue("password", out var password)) Password = password.ToString();
            if (row.Columns.TryGetValue("role", out var role)) Role = role.ToString();
            if (row.Columns.TryGetValue("security_question", out var security_question)) SecurityQuestion = security_question.ToString();
            if (row.Columns.TryGetValue("security_answer", out var security_answer)) SecurityAnswer = security_answer.ToString();
        }

        /* 
         * Create account from input account info parameters
         * ID is optional because account creation does not require an input userid
         */
        public Account(string username, string password, string role, string securityQuestion, string securityAnswer, long userid = 0)
        {
            ID = userid;
            Username = username;
            Password = password;
            Role = role;
            SecurityQuestion = securityQuestion;
            SecurityAnswer = securityAnswer;
        }

        public override string ToString()
        {
            var properties = GetType().GetProperties(); // Get all properties of the class
            string result = "";

            foreach (var prop in properties)
            {
                // Get the value of each property
                var value = prop.GetValue(this);
                result += $"{prop.Name}: {value}, ";
            }

            // Remove the trailing comma and space
            return result.TrimEnd(',', ' ');
        }
    }
}
