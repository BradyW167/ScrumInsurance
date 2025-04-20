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
using System.Windows.Forms;
using System.Security.Claims;
using SelectQuery = ScrumInsurance.Queries.SelectQuery;
using ScrumInsurance.Queries;

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

            if (found_account == null) return null;

            // Return the found account if its password matches input password, null if not
            return found_account.Password.Equals(password) ? found_account : null;
        }

        public Account GetAccountByUsername(string username)
        {
            List<string> account_columns = new List<string> {
                "id",
                "username",
                "password",
                "role",
                "security_question",
                "security_answer"
            };

            Connection.Query = new SelectQuery(account_columns).From("users").Where("username", "=", username);

            Row account_row = Connection.ExecuteSingleSelect();

            // Return null, if no account with input username was found
            if (account_row == null) return null;

            // Create account object from found account data
            Account found_account = new Account(account_row);

            return found_account;
        }

        // Stores claims into input Client object using data from account_data Row
        public void GetClaims(Client client_account, Row account_data)
        {
            Dictionary<string, object> client_id = new Dictionary<string, object> {
                { "Client_ID", account_data.Columns["user_id"] } 
            };

            List<string> claim_columns = new List<string> {
                "title",
                "content",
                "status",
                "amount"
            };

            string user_id = account_data.Columns["user_id"].ToString();

            Connection.Query = new SelectQuery(claim_columns).From("claims").Where("user_id", "=", user_id);

            List<Row> claims = Connection.ExecuteSelect();

            // If the input client had any claims
            if (claims != null)
            {
                // Loop through each claim row
                foreach (Row row in claims)
                {
                    // Create a claim object from the row of data
                    Claim claim = new Claim(row);
                    
                    // Add claim to client accounts Claim Property
                    client_account.AddClaim(claim);
                }
            }
        }

        /**
         * Inserts input account into users table in database
         * Returns boolean from success of insertion
         */
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

            Connection.Query = new InsertQuery(account_info).Into("users");

            return Connection.ExecuteNonQuery();
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
            Connection.Query = new SelectQuery("username").From("users").Where("username", "=", username);

            // If the new account has a duplicated username, return false
            List<Row> rows = Connection.ExecuteSelect();

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
            Connection.Query = new SelectQuery("password").From("users").Where("password", "=", password);

            // If the new account has a duplicated username, return false
            List<Row> rows = Connection.ExecuteSelect();

            // Return true when a duplicate username is found, false when not
            return rows != null && rows.Count > 0;
        }

        // Returns messages for input user id as a List of Message objects
        public List<Message> GetMessageList(long user_id)
        {
            Connection.Query = new SelectQuery(new List<string> { "id", "subject", "sender_id", "date" }).From("messages").Where("recipient_id", "=", user_id.ToString());

            // If the new account has a duplicated username, return false
            List<Row> rows = Connection.ExecuteSelect();

            if (rows == null) return null;

            // Stores messages to return in list
            List<Message> messages = new List<Message>();

            foreach (Row row in rows)
            {
                Message msg = new Message(row);

                messages.Add(msg);
            }

            return messages;
        }

        public List<Claim> GetClaimList(int user_id)
        {
            Console.WriteLine("2222");
            Connection.Query = new SelectQuery(new List<string> { "id", "title", "status", "date" }).From("claims").Where("claim_manager_id", "=", user_id.ToString());
            Console.WriteLine("1111");
            List<Row> rows = Connection.ExecuteSelect();

            List<Claim> empty = new List<Claim>();

            if (rows == null)
            {
                Console.WriteLine("emptylist");
                return empty;
            }
            // Stores messages to return in list
            List<Claim> claims = new List<Claim>();

            foreach (Row row in rows)
            {
                Claim clm = new Claim(row);

                claims.Add(clm);
            }
            Console.WriteLine("notemptylist");
            return claims;
        }


        // Get message data from input message ID
        public Message GetMessage(long message_id)
        {
            Connection.Query = new SelectQuery(new List<string> { "id", "sender_id", "recipient_id", "subject", "content", "date" }).From("messages").Where("id", "=", message_id.ToString());

            // Store select query results
            List<Row> rows = Connection.ExecuteSelect();

            // If a matching row was found, create a message object with it and return it
            if (rows != null) { return new Message(rows[0]); }
            // Else return null
            else { return null; }
        }

        // Returns claims for input user id as a List of Claim objects
        public List<Claim> GetClaimList(Account userAccount)
        {
            string cType = "client_id";

            if (userAccount.Role == "claim_manager")
            {
                cType = "claim_manager_id";
            }
            else if (userAccount.Role == "finance_manager")
            {
                cType = "finance_manager_id";
            }

            Connection.Query = new SelectQuery().From("claims").Where(cType, "=", userAccount.ID.ToString());

            // If the new account has a duplicated username, return false
            List<Row> rows = Connection.ExecuteSelect();

            List<Claim> empty = new List<Claim>();

            if (rows == null)
            {
                Console.WriteLine("emptylist");
                return empty;
            }

            // Stores claims to return in list
            List<Claim> claims = new List<Claim>();

            foreach (Row row in rows)
            {
                Console.WriteLine("Row columns: " + string.Join(", ", row.Columns.Keys));

                Claim claim = new Claim(row);

                claims.Add(claim);
            }

            return claims;
        }

        // Get claim data from input claim ID
        public Claim GetClaim(long claim_id)
        {
            Connection.Query = new SelectQuery().From("claims").Where("id", "=", claim_id.ToString());

            // Store select query results
            List<Row> rows = Connection.ExecuteSelect();

            // If a matching row was found, create a message object with it and return it
            if (rows != null) { return new Claim(rows[0]); }
            // Else return null
            else { return null; }
        }

        public Account getFinanceManager()
        {
            Connection.Query = new SelectQuery().From("users").Where("role", "=", "finance_manager");
            List<Row> rows = Connection.ExecuteSelect();

            // If a matching row was found, create an object with it and return it
            if (rows != null) { return new Account(rows[0]); }
            // Else return null
            else { return null; }
        }

        public bool UpdateAccount(string username, Dictionary<string, object> args)
        {
            return Connection.UpdateQuery("users", new Dictionary<string, object> { { "username", username } }, args);
        }

        public bool DeleteAccount(string username)
        {
            return Connection.DeleteQuery("users", new Dictionary<string, object> { { "username", username } });
        }

        public bool SubmitClaim(long userID, string content)
        {
            Dictionary<string, object> claim_columns = new Dictionary<string, object> {
                { "client_id", userID },
                { "status", "Pending" },
                { "amount", DBNull.Value },
                { "content", content },
                { "date", DateTime.Now },
            };

            Connection.Query = new InsertQuery(claim_columns).Into("claims");

            return Connection.ExecuteNonQuery();
        }

        public bool SubmitClaim(long userID, string title, string content, double amount)
        {
            return Connection.InsertQuery("claims", new Dictionary<string, object> {
                { "client_id", userID },
                { "status", "Pending" },
                { "amount", amount },
                { "content", content },
                { "date", DateTime.Now },
            });
        }

        public bool UpdateClaim(object claimID, string column, string value)
        {
            return Connection.UpdateQuery("claims", new Dictionary<string, object> { { "id", claimID } }, new Dictionary<string, object> { { column, value } });
        }

        public bool UploadDocument(string file_name, byte[] file_data)
        {
            // Create parameter dictionary for document upload
            Dictionary<string, object> document_info = new Dictionary<string, object>
            {
                { "file_name", (object)file_name },
                { "file_data", (object)file_data }
            };

            // Create insertion query and store it in Connection.Query property
            Connection.Query = new InsertQuery(document_info).Into("documents");

            // Upload document
            return Connection.ExecuteNonQuery();
        }

    }

}
