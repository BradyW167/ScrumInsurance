using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowserGitHubDemo
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
            myConnection_.DatabaseName = "scrumgang";
            myConnection_.DatabaseUsername = "scrumgang";
            myConnection_.DatabasePassword = "Z9wAabwUKeZy5pxvF5GE";
        }

        public bool openConnection()
        {
            return myConnection_.openConnection();
        }

        // Trailing underscore to identify local member.
        private DatabaseConnection myConnection_;
    }
}
