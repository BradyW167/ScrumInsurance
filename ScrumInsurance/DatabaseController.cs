using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ScrumInsurance
{
    public class DatabaseController
    {
        private DatabaseConnection Connection {  get; set; }

        public DatabaseController()
        {
            Connection = new DatabaseConnection();

            // Stores path to config.json
            string filePath = Path.Combine(AppContext.BaseDirectory, "config.json"); ;

            // Read database info from input file path
            DatabaseConfig dbConfig = readDatabaseConfig(filePath);

            // Create database controller with input database config

            // Read database config values to class properties
            Connection.ServerName = dbConfig.Database.ServerName;
            Connection.DatabaseName = dbConfig.Database.Name;
            Connection.DatabaseUsername = dbConfig.Database.Username;
            Connection.DatabasePassword = dbConfig.Database.Password;  
        }

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

        public Account ValidateLogin(string username, string password)
        {
            if (password.Length < 8)
            {
                return null;
            }

            // Create parameter dictionary for login query
            Dictionary<string, object> login_info = new Dictionary<string, object>
            {
                { "username", (object)username },
                { "password", (object)password }
            };

            // Create string array of necessary column names for account info
            string[] account_columns =
            {
                "user_id",
                "username",
                "password",
                "role",
                "security_question",
                "security_answer"
            };

            // Store query results
            object[] account_data = Connection.SelectQuery("User", login_info, account_columns);

            // Return null if a matching account was not found
            if (account_data == null) { return null; }

            // Create account object from account_data object array
            Account found_account = new Account((string)account_data[1], 
                                                (string)account_data[2], 
                                                (string)account_data[3], 
                                                (string)account_data[4], 
                                                (string)account_data[5],
                                                (int)account_data[0]);

            return found_account;
        }

        // Attempts to find a security question and answer info from database for input username
        public string[] GetSecurityInfo(string username)
        {
            // Create parameter dictionary for question query
            Dictionary<string, object> user_info = new Dictionary<string, object>
            {
                { "username", (object)username }
            };

            // Create string array for security question column name
            string[] question_column = { "security_question", "security_answer" };

            // Store query results
            object[] question_data = Connection.SelectQuery("User", user_info, question_column);

            // Return null if a matching username was not found
            if (question_data == null) { return null; }



            string[] security_info = { (string)question_data[0], (string)question_data[1] };

            return security_info;
        }

        public bool AddAccount(Account new_account)
        {
            // If the new account has a duplicated username, return false
            if (Connection.CheckDuplicateUsername(new_account.Username)) { return false; }

            // Create parameter dictionary for new account
            Dictionary<string, object> account_info = new Dictionary<string, object>
            {
                { "username", (object)new_account.Username },
                { "password", (object)new_account.Password },
                { "role", (object)new_account.Role },
                { "security_question", (object)new_account.SecurityQuestion },
                { "security_answer", (object)new_account.SecurityAnswer }
            };

            // Insert new account into database, return bool for success or failure
            return Connection.InsertQuery("User", account_info);
        }

        public bool UpdateAccount(string username, Dictionary<string, string> args)
        {
            return Connection.UpdateQuery("login", new Dictionary<string, string> { { "username", username } }, args);
        }

        public bool DeleteAccount(string username)
        {
            return Connection.DeleteQuery("login", new Dictionary<string, string> { { "username", username } });
        }

        public bool UploadDocument(string file_name, byte[] file_data)
        {
            // Create parameter dictionary for document upload
            Dictionary<string, object> document_info = new Dictionary<string, object>
            {
                { "file_name", (object)file_name },
                { "file_data", (object)file_data }
            };

            // Upload document
            return Connection.InsertQuery("Document", document_info);
        }
    }
}
