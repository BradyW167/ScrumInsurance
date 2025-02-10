using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace formMain
{
    public class DatabaseConnection
    {
        public DatabaseConnection() { }

        private string serverName_;
        private string databaseName_;
        private string databasePassword_;
        private string databaseUsername_;
        private MySqlConnection connection_;
    }
}
