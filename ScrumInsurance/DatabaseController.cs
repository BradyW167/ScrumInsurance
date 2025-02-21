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

            myConnection_.openConnection();
            username_ = "";
            password_ = "";

        }

        public bool openConnection()
        {
            return myConnection_.openConnection();
        }

   
        // Trailing underscore to identify local member.
        //private DatabaseConnection myConnection_;
        public bool validateLogin(string username, string password)
        {
            username_ = username;
            password_ = password;

            if (password_.Length < 1)
            {
                return false;
            }
            return true;
        }
        public bool selectQuery(string username, string password)
        {
            string queryString = "SELECT * FROM account WHERE username='" + username + "' AND password='" + password + "'";

            if (openConnection())
            {
                myConnection_.Connection.BeginTransaction();
            }

            return false;
        }
        
        private string username_;
        private string password_;


        // Trailing underscore to identify local member.
        private DatabaseConnection myConnection_;
    }
}

    }
}
