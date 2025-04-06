using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumInsurance
{
    public class Session
    {
        private List<Account> accounts_;

        public Session()
        {
            accounts_ = new List<Account>();
            //this will need to be taken out later, however it is here for now just for testing purposes. 
            accounts_.Add(new Account("admin", "admin", "adming@scrum.com", "Background Color?", "Steel Blue"));
            accounts_[0].isAdmin = true;

            // Stores path to config.json
            string filePath = Path.Combine(AppContext.BaseDirectory, "config.json"); ;

            // Read database info from input file path
            DatabaseConfig dbConfig = readDatabaseConfig(filePath);

            // Create database controller with input database config
            DBController = new DatabaseController(dbConfig);
        }

        // Eventually, session should save an account, with all the current user's info from database
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public DatabaseController DBController { get; set; }
        public ScrumUserControl CtrlMain { get; set; }
        public ScrumUserControl CtrlDashboard { get; set; }

        // Reads input database config file
        public DatabaseConfig readDatabaseConfig(string filePath)
        {
            DatabaseConfig config = new DatabaseConfig();
            try
            {
                // Read the JSON file into a string
                string jsonString = File.ReadAllText(filePath);

                Console.WriteLine(jsonString);

                // Deserialize the JSON string to the DatabaseConfig object
                config = JsonSerializer.Deserialize<DatabaseConfig>(jsonString);

                return config;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return config;
            }
        }

        public void addAccount(string username, string password, string email, string securityQuestion, string securityQuestionAnswer)
        {
            accounts_.Add(new Account(username, password, email, securityQuestion, securityQuestionAnswer));
        }

        //Returns index of first account in list of accounts with specified username + password, returns -1 otherwise
        public int findAccount(string username, string password)
        {
            for (int i = 0; i < accounts_.Count; i++)
            {
                if (accounts_[i].validCreds(username, password))
                {
                    return i;
                }
            }
            return -1;
        }

        //Returns index of first account in list of accounts with specified email, returns -1 otherwise
        public int findAccount(string email)
        {
            for (int i = 0; i < accounts_.Count; i++)
            {
                if (accounts_[i].validCreds(email))
                {
                    return i;
                }
            }
            return -1;
        }

        //Returns security question of first account with speciifed email, returns null otherwise
        public string findQuestion(string email)
        {
            for (int i = 0; i < accounts_.Count; i++)
            {
                if (accounts_[i].validCreds(email))
                {
                    return accounts_[i].SecurityQuestion;
                }
            }
            return null;
        }

        public Account getAccount(int index)
        {
            return accounts_[index];
        }
    }
}
