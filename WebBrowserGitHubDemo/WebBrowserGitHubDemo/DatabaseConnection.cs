using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using Org.BouncyCastle.Tls;

namespace WebBrowserGitHubDemo
{
    public class DatabaseConnection
    {
        public DatabaseConnection() { }

        public string serverName_;
        public string databaseName_;
        public string databasePassword_;
        public string databaseUsername_;
        public MySqlConnection connection_;

        /*connection_.ServerName = "trevor.butler.edu";
        connection_.DatabaseName = "scrumgang";
        connection_.DatabaseUsername = "scrumgang";
        connection_.DatabasePassword = "Z9wAabwUKeZy5pxvF5GE";*/


        public bool connectToDatabase()
        {
            if (connection_ == null)
            {
                string connString = string.Format("Server={0}; database={1}; UID = {2}; password={3}", serverName_, databaseName_, databaseUsername_, databasePassword_);
                connection_ = new MySqlConnection(connString);
                connection_.Open();
            }
            return true;
        }
    }
}