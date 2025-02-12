using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowserGitHubDemo
{
    public class DatabaseController
    {
        public DatabaseController()
        {
            myConnection_ = new DatabaseConnection();
            myConnection_.serverName_ = "trevor.butler.edu";
            myConnection_.databaseName_ = "scrumgang";
            myConnection_.databasePassword_ = "scrumgang";
            myConnection_.databaseUsername_ = "Z9wAabwUKeZy5pxvF5GE";

        }

        public bool isConnected()
        {
            return myConnection_.connectToDatabase();
        }

        private DatabaseConnection myConnection_;
    }
}
