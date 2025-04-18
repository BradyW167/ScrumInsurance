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
using Org.BouncyCastle.Asn1.Mozilla;

namespace ScrumInsurance
{
    public class DatabaseController
    {
        private DatabaseConnection Connection {  get; set; }

        public DatabaseController()
        {
            Connection = new DatabaseConnection();

            // Stores path to config.json
            string filePath = Path.Combine(AppContext.BaseDirectory, "Database", "config.json");

            // Read database info from input file path
            DatabaseConfig dbConfig = ReadDatabaseConfig(filePath);

            // Read database config values to Connection properties
            Connection.ServerName = dbConfig.Database.ServerName;
            Connection.DatabaseName = dbConfig.Database.Name;
            Connection.DatabaseUsername = dbConfig.Database.Username;
            Connection.DatabasePassword = dbConfig.Database.Password;  
        }

        // Reads input database config file
        public DatabaseConfig ReadDatabaseConfig(string filePath)
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
            // Get the account from input username
            Account found_account = GetAccountByUsername(username);

            // Return the found account if its password matches input password, null if not
            return found_account.Password.Equals(password) ? found_account : null;
        }

        public Account GetAccountByUsername(string username)
        {
            // Create parameter dictionary for username
            Dictionary<string, object> username_dictionary = new Dictionary<string, object>
            {
                { "username", (object)username }
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

            // Stores account that match the input username
            List<Row> account = Connection.SelectQuery("User", username_dictionary, account_columns);
            Row account_data = new Row();

            // If a matching account was found, store first matching row in account_data Row object
            if (account != null) {
                Console.WriteLine("User '" + username + "' found");
                account_data = account[0];
            }
            // Else no matching account was found, return null
            else { return null; }

            // Print account data row
            Console.WriteLine(account_data);

            // Create account object from found account data
            Account found_account = new Account((string)account_data.Columns["username"],
                                    (string)account_data.Columns["password"],
                                    (string)account_data.Columns["role"],
                                    (string)account_data.Columns["security_question"],
                                    (string)account_data.Columns["security_answer"],
                                    (int)account_data.Columns["user_id"]);

            return found_account;
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

        // Adds input account object data to database using insert query
        public bool AddAccount(Account new_account)
        {
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

        /**
         * Returns error string on invalid username with info about what is invalid
         * Returns empty string on valid username
         */
        public string ValidateUsername(string username)
        {
            StringBuilder errorMessages = new StringBuilder(string.Empty);

            if (username.Length < 3)
            {
                errorMessages.AppendLine("Username must be at least 3 characters long");
            }
            if (!Regex.IsMatch(username, @"^[a-zA-Z0-9]+$"))
            {
                errorMessages.AppendLine("Username must only contain letters and numbers");
            }
            if (CheckDuplicateUsername(username))
            {
                errorMessages.AppendLine("Choose a different Username");
            }
            
            return errorMessages.ToString();
        }

        // Checks if input username already exists in database
        public bool CheckDuplicateUsername(string username)
        {
            // If the new account has a duplicated username, return false
            List<Row> rows = Connection.SelectQuery("User", new Dictionary<string, object> { { "username", (object)username } }, new string[] { "username" });

            // Return true when a duplicate username is found, false when not
            return rows != null && rows.Count > 0;
        }

        /**
        * Returns error string on invalid username with info about what is invalid
        * Returns empty string on valid username
        * If username is input it returns an error if password and username are equal
        */
        public string ValidatePassword(string password, string username = "")
        {
            StringBuilder errorMessages = new StringBuilder(string.Empty);

            if (password.Length < 8)
            {
                errorMessages.AppendLine("Password must be at least 8 characters long");
            }
            if (!Regex.IsMatch(password, @"^[a-zA-Z0-9!@#$%^&*]+$"))
            {
                errorMessages.AppendLine("Password must only contain letters, numbers, and special characters ! @ # $ % ^ & *");
            }
            if (!Regex.IsMatch(password, @"[A-Z]"))
            {
                errorMessages.AppendLine("Password must contain at least one uppercase letter");
            }
            if (!Regex.IsMatch(password, @"[a-z]"))
            {
                errorMessages.AppendLine("Password must contain at least one lowercase letter");
            }
            if (!Regex.IsMatch(password, @"[0-9]"))
            {
                errorMessages.AppendLine("Password must contain at least one digit");
            }
            if (!Regex.IsMatch(password, @"[\W_]"))
            {
                errorMessages.AppendLine("Password must contain at least one special character");
            }
            if (username != "" && password.Equals(username, StringComparison.OrdinalIgnoreCase))
            {
                errorMessages.AppendLine("Password must be different from username");
            }
            if (CheckDuplicatePassword(password))
            {
                errorMessages.AppendLine("Choose a different password");
            }

            return errorMessages.ToString();
        }

        // Checks if input password already exists in database
        public bool CheckDuplicatePassword(string password)
        {
            // If the new account has a duplicated username, return false
            List<Row> rows = Connection.SelectQuery("User", new Dictionary<string, object> { { "password", (object)password } }, new string[] { "password" });

            // Return true when a duplicate username is found, false when not
            return rows != null && rows.Count > 0;
        }

        public Dictionary<int, object[]> MessageInformation(Dictionary<string, object> args, string[] columns)
        {
            return Connection.DataRequestAll("Message", args, columns);
        }

        public Dictionary<int, object[]> ClaimInformation(Dictionary<string, object> args, string[] columns)
        {
            return Connection.DataRequestAll("Claim", args, columns);
        }

        public bool UpdateAccount(string username, Dictionary<string, object> args)
        {
            return Connection.UpdateQuery("User", new Dictionary<string, object> { { "username", username } }, args);
        }

        public bool DeleteAccount(string username)
        {
            return Connection.DeleteQuery("User", new Dictionary<string, object> { { "username", username } });
        }

        public bool SubmitClaim(int userID, string title, string content, int amount)
        {
            return Connection.InsertQuery("Claim", new Dictionary<string, object> {
                { "Client_ID", userID },
                { "Claim_Title", title },
                { "Claim_Content", content },
                { "Claim_Amount", amount },
                { "Claim_Date", DateTime.Now },
                { "Claim_Status", "Validating" }
            });
        }

        public bool UpdateClaim(object claimID, string status)
        {
            return Connection.UpdateQuery("Claim", new Dictionary<string, object> { { "Claim_ID", claimID } }, new Dictionary<string, object> { { "Claim_Status", status } });
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
