using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ScrumInsurance
{
    public class DatabaseController
    {
        private DatabaseConnection Connection {  get; set; }

        public DatabaseController(DatabaseConfig dbConfig)
        {
            Connection = new DatabaseConnection();

            // Read database config values to class properties
            Connection.ServerName = dbConfig.Database.ServerName;
            Connection.DatabaseName = dbConfig.Database.Name;
            Connection.DatabaseUsername = dbConfig.Database.Username;
            Connection.DatabasePassword = dbConfig.Database.Password;  
        }

        public string[] validateLogin(string username, string password)
        {
            if (password.Length < 8)
            {
                return null;
            }
            return Connection.loginQuery(username, password);
        }

        public bool addAccount(string username, string password, string email, string question, string answer, string role)
        {
            string[] args = new string[6];
            args[0] = username;
            args[1] = password;
            args[2] = email;
            args[3] = question;
            args[4] = answer;
            args[5] = role;
            
            //will verify that it went through. if it doesnt go through, will return false. 
            if (Connection.insertQuery("login", args))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string[] RequestInformation(Dictionary<string, object> args, string[] columns)
        {
            return Connection.DataRequest("login", args, columns);
        }

        public Dictionary<int, object[]> MessageInformation(Dictionary<string, object> args, string[] columns)
        {
            return Connection.DataRequestAll("Message", args, columns);
        }

        public bool UpdateAccount(string username, Dictionary<string, string> args)
        {
            return Connection.updateQuery("login", new Dictionary<string, string> { { "username", username } }, args);
        }

        public bool DeleteAccount(string username)
        {
            return Connection.DeleteQuery("login", new Dictionary<string, string> { { "username", username } });
        }

        //Client Upload Documents

        public bool UploadDocument(string filePath, string fileName, byte[] fileData)
        {
            string[] args = new string[3];
            args[0] = filePath;
            args[1] = fileName;
            //args[2] = fileData;
            //not sure how to insert with the array...
            if (Connection.insertQuery("Document", args))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
