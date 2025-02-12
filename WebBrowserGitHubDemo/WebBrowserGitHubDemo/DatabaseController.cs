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
            myConnection_.databaseName_ = "jesibbitt";
            myConnection_.databasePassword_ = "jesibbitt";
            myConnection_.databaseUsername_ = "";

        }

        public bool isConnected()
        {
            return myConnection_.connectToDatabase();
        }

        private DatabaseConnection myConnection_;
    }
}
