using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Management;

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

            // Read database config values to Connection properties
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
            /* might be able to get rid of
            if (!Regex.IsMatch(password, @"[A-Z]"))
            {
                return null;
            }
            if (!Regex.IsMatch(password, @"[a-z]"))
            {
                return null;
            }
            if (!Regex.IsMatch(password, @"[0-9]"))
            {
                return null;
            }
            if (!Regex.IsMatch(password, @"[\W_]"))
            {
                return null;
            }
            */

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
            List<Row> accounts = Connection.SelectQuery("User", login_info, account_columns);
            Row account_data = new Row();

            // If a matching account was found...
            if (accounts != null) {
                // Store first matching row in account_data Row object
                account_data = accounts[0];
            }
            // Else no matching account was found, return null
            else { return null; }

            // Create account object from account_data object array
            if (((string)account_data.Columns["role"]).Equals("client"))
            {
                Client found_account = new Client((string)account_data.Columns["username"],
                                                  (string)account_data.Columns["password"],
                                                  (string)account_data.Columns["role"],
                                                  (string)account_data.Columns["security_question"],
                                                  (string)account_data.Columns["security_answer"],
                                                  (int)account_data.Columns["user_id"]);

                GetClaims(found_account, account_data);

                return found_account;
            }
            else
            {
                Account found_account = new Account((string)account_data.Columns["username"],
                                                    (string)account_data.Columns["password"],
                                                    (string)account_data.Columns["role"],
                                                    (string)account_data.Columns["security_question"],
                                                    (string)account_data.Columns["security_answer"],
                                                    (int)account_data.Columns["user_id"]);

                return found_account;
            }
        }

        // Stores claims into input Client object using data from account_data Row
        public void GetClaims(Client client_account, Row account_data)
        {
            Dictionary<string, object> client_id = new Dictionary<string, object> {
                { "Client_ID", account_data.Columns["user_id"] } 
            };

            string[] claim_info =
            {
                "Claim_Title",
                "Claim_Content",
                "Claim_Status",
                "Claim_Amount"
            };

            List<Row> claims = Connection.SelectQuery("Claim", client_id, claim_info);
            if (claims != null)
            {
                foreach (Row claim in claims)
                {
                    client_account.AddClaim(claim.Columns["Claim_Title"] + "", claim.Columns["Claim_Content"] + "", claim.Columns["Claim_Status"] + "", (int)claim.Columns["Claim_Amount"]);
                }
            }

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
            Row question_data = Connection.SelectQuery("User", user_info, question_column)[0];

            // Return null if a matching username was not found
            if (question_data == null) { return null; }

            string[] security_info = { (string)question_data.Columns["security_question"], (string)question_data.Columns["security_answer"] };

            return security_info;
        }

        // Adds input account object data to database using insert query
        public bool AddAccount(Account new_account)
        {
            // If the new account has a duplicated username, return false
            List<Row> rows = Connection.SelectQuery("User", new Dictionary<string, object> { { "username", (object)new_account.Username } }, new string[] { "username" });
            if (rows != null && rows.Count > 0)
            {
                return false;
            }

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

        public Dictionary<int, object[]> MessageInformation(Dictionary<string, object> args, string[] columns)
        {
            return Connection.DataRequestAll("Message", args, columns);
        }

        public Dictionary<int, object[]> ClaimInformation(Dictionary<string, object> args, string[] columns)
        {
            return Connection.DataRequestAll("Claim", args, columns);
        }

        public bool UpdateAccount(string username, Dictionary<string, string> args)
        {
            return Connection.UpdateQuery("User", new Dictionary<string, string> { { "username", username } }, args);
        }

        public bool DeleteAccount(string username)
        {
            return Connection.DeleteQuery("User", new Dictionary<string, string> { { "username", username } });
        }

        public bool SubmitClaim(int userID, string title, string content, int amount)
        {
            return Connection.InsertQuery("Claim", new Dictionary<string, object>() { { "Client_ID", userID }, { "Claim_Title", title }, { "Claim_Content", content }, { "Claim_Amount", amount }, { "Claim_Date", DateTime.Now }, { "Claim_Status", "Under Review" } });
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
