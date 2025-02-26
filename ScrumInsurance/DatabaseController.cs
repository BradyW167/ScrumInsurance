using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumInsurance
{
    // Login Controller Class
    //
    // By: Dr. Ryan Rybarczyk
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

            if (password_.Length < 8)
            {
                return false;
            }
            else
            {
                string[] args = new string[2];

                args[0] = username_;
                args[1] = password_;

                // Change first parameter to actual table name
                if (myConnection_.selectQuery("login", args))
                {
                    return true;
                }
            }

            return true;
        }

        // Trailing underscore to identify local member.
        private DatabaseConnection myConnection_;
        private string username_;
        private string password_;
    }
}
