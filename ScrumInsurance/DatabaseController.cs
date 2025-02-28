using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumInsurance
{
    public class DatabaseController
    {
        public DatabaseController()
        {
            myConnection_ = new DatabaseConnection();

            // We can move this to a property file later to avoid unncessary clutter and hardcoding.
            myConnection_.ServerName = "trevor.butler.edu";
            myConnection_.DatabaseName = "scrum_gang";
            myConnection_.DatabaseUsername = "scrumgang";
            myConnection_.DatabasePassword = "Z9wAabwUKeZy5pxvF5GE";

            username_ = "";
            password_ = "";
        }

        public bool validateLogin(string username, string password)
        {
            username_ = username;
            password_ = password;

            if (password_.Length > 8)
            {
                return false;
            }
            else
            {
                string[] args = new string[4];

                args[0] = "username";
                args[1] = username_;
                args[2] = "password";
                args[3] = password_;

                // Change first parameter to actual table name
                if (myConnection_.selectQuery("login", args))
                {
                    return true;
                } else
                {
                    return false;
                }
            }
        }

        public bool addAccount(string username, string password, string email, string question, string answer)
        {
            string[] args = new string[5];
            args[0] = username;
            args[1] = password;
            args[2] = email;
            args[3] = question;
            args[4] = answer;
            
            //will verify that it went through. if it doesnt go through, will return false. 
            if (myConnection_.insertQuery("login", args))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private DatabaseConnection myConnection_;
        private string username_;
        private string password_;
    }
}
