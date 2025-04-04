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

        public string[] validateLogin(string username, string password)
        {
            username_ = username;
            password_ = password;

            if (password_.Length < 8)
            {
                return null;
            }
            return RequestInformation(new Dictionary<string, string> { { "username", username_ }, { "password", password_ } }, new string[] { "username", "password", "role", "email" });
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
            if (myConnection_.insertQuery("login", args))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string[] RequestInformation(Dictionary<string, string> args, string[] columns)
        {
            return myConnection_.DataRequest("login", args, columns);
        }

        public bool UpdateAccount(string username, Dictionary<string, string> args)
        {
            return myConnection_.updateQuery("login", new Dictionary<string, string> { { "username", username } }, args);
        }

        public bool DeleteAccount(string username)
        {
            return myConnection_.DeleteQuery("login", new Dictionary<string, string> { { "username", username } });
        }

        //Client Upload Documents

        public bool UploadDocument(string filePath, string fileName, byte[] fileData)
        {
            string[] args = new string[3];
            args[0] = filePath;
            args[1] = fileName;
            //args[2] = fileData;
            //not sure how to insert with the array...
            if (myConnection_.insertQuery("Document", args))
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
