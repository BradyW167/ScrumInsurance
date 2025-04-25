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
using System.Data;
using Google.Protobuf.WellKnownTypes;
using MySqlX.XDevAPI.Relational;
using System.Data.Common;

namespace ScrumInsurance
{
    public class DatabaseController
    {
        // Stores the back-end Connection for directly querying the database
        private DatabaseConnection Connection {  get; set; }

        // Stores data for loading into front-end tables
        public DataSet AccountDataSet { get; set; }

        // Stores the last inserted ID for follow-up inserts
        public long? LastInsertedID { get; set; }

        public DatabaseController(uint timeoutWait = 3)
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

            // Set time to wait for connection failure
            Connection.TimeoutWait = timeoutWait;
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

        // Gets an account Data Set using input where conditions
        public DataSet GetAccountDataSet(Dictionary<string, string> whereConditions = null)
        {
            // Select all users
            SelectQuery query = new SelectQuery().From("users");

            if (whereConditions != null)
            {
                foreach (var item in whereConditions)
                {
                    query.Where(item.Key, "=", item.Value);
                }
            }

            // Stores data set in this layer for communication
            AccountDataSet = Connection.GetTable(query);

            // Sends data set to front end
            return AccountDataSet;
        }

        // Updates the database using the altered DataSet
        public void CommitAccountChanges()
        {
            // Update the 'Accounts' table in the AccountsDataSet
            Connection.Adapter.Update(AccountDataSet, "Accounts");
        }

        // Returns list of all accounts matching the input role
        public List<Account> GetAccountsByRole(string role)
        {
            Console.WriteLine(role);

            Connection.Query = new SelectQuery().From("users").Where("role", "=", role);

            List<Row> account_rows = Connection.ExecuteSelect();

            foreach (Row row in account_rows)
            {
                Console.WriteLine(row.ToString());
            }

            // Return null, if no account with input username was found
            if (account_rows == null) return null;

            // Stores list of accounts created from row objects
            List<Account> account_list = account_rows.Select(a => new Account(a)).ToList();

            foreach (Account account in account_list)
            {
                Console.WriteLine(account.ToString());
            }

            return account_list;
        }

        public Account GetAccountByID(string id)
        {
            Connection.Query = new SelectQuery().From("users").Where("id", "=", id);

            Row account_row = Connection.ExecuteSingleSelect();

            // Return null, if no account with input username was found
            if (account_row == null) return null;

            // Create account object from found account data
            Account found_account = new Account(account_row);

            return found_account;
        }

        /**
         * Inserts input account into users table in database
         * Returns boolean from success of insertion
         */
        public bool? AddAccount(Account new_account)
        {
            // Create parameter dictionary for new account
            Dictionary<string, object> account_info = new Dictionary<string, object>
            {
                { "username", new_account.Username },
                { "password", new_account.Password },
                { "role", new_account.Role },
                { "security_question", new_account.SecurityQuestion },
                { "security_answer", new_account.SecurityAnswer }
            };

            Connection.Query = new InsertQuery(account_info).Into("users");

            bool? userInserted = Connection.ExecuteNonQuery();

            // Return false if insert failed
            if (userInserted != true) return false;

            // Inserts this user's id into their role specific table
            return AddRoleSpecificAccount(new_account.Role);
        }

        // Inserts an entry into a role specific subtype table
        public bool? AddRoleSpecificAccount(string role)
        {
            LastInsertedID = Connection.GetLastInsertedID();

            // Return null on database error
            if (LastInsertedID == null) return null;

            string role_table = "";

            // Gets the name of the input role's database table
            if (role == "client") {role_table = "clients"; }
            else if (role == "claim_manager") { role_table = "claim_managers"; }
            else if (role == "finance_manager") { role_table = "finance_managers"; }
            else if (role == "admin") { role_table = "admins"; }
            else
            {
                Console.WriteLine("Unknown role: " + role);
                return false;
            }

            Connection.Query = new InsertQuery("user_id", LastInsertedID).Into(role_table);

            return Connection.ExecuteNonQuery();
        }

        // Updates user of 'user_id' with new input username and password
        public bool? UpdateAccount(long user_id, string new_username, string new_password)
        {
            Dictionary<string, object> credential_columns = new Dictionary<string, object>
            {
                { "username", new_username },
                { "password", new_password }
            };

            Connection.Query = new UpdateQuery("users").Set(credential_columns).Where("id", "=", user_id.ToString());

            return Connection.ExecuteNonQuery();
        }

        // Deletes account matching input user ID
        public bool? DeleteAccount(long user_id)
        {
            Connection.Query = new DeleteQuery().From("users").Where("id", "=", user_id);

            return Connection.ExecuteNonQuery();
        }

        public Account GetAccountByUsername(string username)
        {
            Connection.Query = new SelectQuery().From("users").Where("username", "=", username);

            Row account_row = Connection.ExecuteSingleSelect();

            // Return null, if no account with input username was found
            if (account_row == null) return null;

            // Create account object from found account data
            Account found_account = new Account(account_row);

            return found_account;
        }

        public Account ValidateLogin(string username, string password)
        {
            // Get the account from input username
            Account found_account = GetAccountByUsername(username);

            // If no account was found with input username, return null
            if (found_account == null) return null;
            // If the account is empty, or the password is not equal return an empty account
            else if (found_account.Password == null || !found_account.Password.Equals(password)) return new Account();
            // Else account is valid
            else {return found_account;}
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
            else if (username.Length > 20)
            {
                errorMessages.AppendLine("Username must be at most 20 characters long");
            }
            if (!Regex.IsMatch(username, @"^[a-zA-Z0-9]+$"))
            {
                errorMessages.AppendLine("Username must only contain letters and numbers");
            }
            if (CheckDuplicateUsername(username) == true)
            {
                errorMessages.AppendLine("Choose a different Username");
            }
            
            return errorMessages.ToString();
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
            else if (password.Length > 20)
            {
                errorMessages.AppendLine("Password must be at most 20 characters long");
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

        // Checks if input username already exists in database
        public bool? CheckDuplicateUsername(string username)
        {
            // Return true when a duplicate username is found, false when not
            return (GetAccountByUsername(username).ID != 0);
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
            List<string> message_columns = new List<string>()
            {
                "messages.id", "sender_id", "recipient_id", "username", "subject", "date"
            };

            Connection.Query = new SelectQuery(message_columns).From("messages")
                .Join("message_recipients" , "id", "message_id")
                .Join("users", "id", "id")
                .Where("recipient_id", "=", user_id);

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

        // Get message data from input message ID
        public Message GetMessage(long message_id)
        {
            Connection.Query = new SelectQuery(new List<string> { "message.id", "sender_id", "subject", "content", "date" }).From("messages").Where("id", "=", message_id.ToString());

            // Store select query results
            List<Row> rows = Connection.ExecuteSelect();

            // If a matching row was found, create a message object with it and return it
            if (rows != null) { return new Message(rows[0]); }
            // Else return null
            else { return null; }
        }

        // Gets a message's content from input message ID
        public string GetMessageContent(long message_id)
        {
            Connection.Query = new SelectQuery("content").From("messages").Where("id", "=", message_id);

            // Store select query results
            Row row = Connection.ExecuteSingleSelect();

            // If a matching row was found, return its content column
            if (row != null) { return (string)row.GetValue("content"); }
            // Else return null
            else { return null; }
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

        // Returns a list of Claim objects that are assigned to to the input account
        public List<Claim> GetClaimList(Account userAccount)
        {
            // Stores the id column for the input user's role
            string id_column_name = string.Empty;

            if (userAccount.Role == "claim_manager")
            {
                id_column_name = "claim_manager_id";
            }
            else if (userAccount.Role == "finance_manager")
            {
                id_column_name = "finance_manager_id";
            }
            else
            {
                id_column_name = "client_id";
            }

            Connection.Query = new SelectQuery().From("claims").Where(id_column_name, "=", userAccount.ID.ToString());

            // Executes and stores query results as a list of row objects
            List<Row> claim_rows = Connection.ExecuteSelect();

            // Stores messages to return in list
            List<Claim> claims = new List<Claim>();

            // If there was a query error, return null
            if (claim_rows == null)
            {
                return null;
            }
            // Else the query returned claims
            else
            {
                // Loop through each claim row
                foreach (Row row in claim_rows)
                {
                    // Create a claim object from the row of data
                    Claim claim = new Claim(row);

                    // Add claim to client accounts Claim Property
                    claims.Add(claim);
                }

                // Returns the claim list
                return claims;
            }
        }

        // Inserts claim into database under input user_id with input content
        // Automatically assigns claim to claim manager with least claims
        public bool? SubmitClaim(long userID, string content, List<string> documentPaths)
        {
            long claimManagerID = GetLeastClaimsManagerID(true);

            if (claimManagerID == 0) { return false; }

            Dictionary<string, object> claim_columns = new Dictionary<string, object> {
                { "client_id", userID },
                { "claim_manager_id", claimManagerID },
                { "finance_manager_id", DBNull.Value },
                { "status", "Pending" },
                { "amount", DBNull.Value },
                { "content", content },
                { "date", DateTime.Now },
            };

            Connection.Query = new InsertQuery(claim_columns).Into("claims");

            Connection.ExecuteNonQuery();

            // Proceed to uploading documents and return the result
            return UploadDocuments(documentPaths);
        }



        // Updates claim of input claimID's input column with input value
        public bool? UpdateClaim(long claimID, string column, object value)
        {
            Connection.Query = new UpdateQuery("claims").Set(column, value).Where(column, "=", value);

            return Connection.ExecuteNonQuery();
        }

        // Returns ID of input manager type with the least number of assigned claims
        public long GetLeastClaimsManagerID (bool isClaimManager)
        {
            // Stores the type of manager input from boolean
            string role = isClaimManager ? "claim_manager" : "finance_manager";

            // Gets the IDs of chosen role's manager ordered by number of claims assigned
            Connection.Query = new SelectQuery("user_id").From($"{role}s")
                .Join("claims", "user_id", $"{role}_id", "LEFT")
                .GroupBy("user_id").OrderBy("COUNT(id)");

            List<Row> rows = Connection.ExecuteSelect();

            // If a matching row was found, create an object with it and return it
            if (rows != null)
            {
                // If a user_id is found in the first row
                if (rows[0].Columns.TryGetValue("user_id", out var id))
                {
                    Console.WriteLine("Manager ID: " + id.ToString());

                    return Convert.ToInt64(id);
                }
                // Return 0 on no managers found
                else { return 0; }
            }
            // Return 0 on no managers found
            else { return 0; }
        }

        public bool? UploadDocuments(List<string> documentPaths)
        {
            LastInsertedID = Connection.GetLastInsertedID();

            // Return null on failed ID get
            if (LastInsertedID == null) return null;

            // Loop through each document in the List
            foreach (string document_path in documentPaths)
            {
                // Stores file name from path
                string file_name = Path.GetFileName(document_path);

                // Stores file data as byte array
                byte[] file_data = File.ReadAllBytes(document_path);

                // Upload document info to database
                bool? result = UploadDocument((long)LastInsertedID, file_name, file_data);

                // Return result if upload was unseccssful
                if (result != true) return result;
            }

            // Return true on successful upload of all documents
            return true;
        }

        public bool? UploadDocument(long claim_id, string file_name, byte[] file_data)
        {
            // Create parameter dictionary for document upload
            Dictionary<string, object> document_info = new Dictionary<string, object>
            {
                { "claim_id", claim_id },
                { "file_name", file_name },
                { "file_data", file_data },
                { "upload_date", DateTime.Now }
            };

            // Create insertion query and store it in Connection.Query property
            Connection.Query = new InsertQuery(document_info).Into("documents");

            // Upload document and return success state
            return Connection.ExecuteNonQuery();
        }
    }

}
