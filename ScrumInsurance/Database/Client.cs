using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ScrumInsurance
{
    public class Client : Account
    {
        public List<Claim> Claims { get; set; }

        public Client() : base()
        {
            Claims = new List<Claim>();
        }

        public Client(string username, string password, string role, string securityQuestion, string securityAnswer, long id = 0) : base(username, password, role, securityQuestion, securityAnswer, id)
        {
            Claims = new List<Claim>();
        }

        public void AddClaim(Claim claim)
        {
            Claims.Add(claim);
        }

        public void RemoveClaim(int index)
        {
            Claims.Remove(Claims[index]);
        }
        /*
        public long ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public string PhoneNumber { get; set; }
        public string ProfilePicture { get; set; }

        // Default constructor
        public Client()
        {
            ID = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            DOB = string.Empty;
            PhoneNumber = string.Empty;
            ProfilePicture = string.Empty;
        }

        public Client(Row row)
        {
            if (row.Columns.TryGetValue("user_id", out var id)) ID = Convert.ToInt64(id);
            if (row.Columns.TryGetValue("first_name", out var username)) Username = username.ToString();
            if (row.Columns.TryGetValue("last_name", out var password)) Password = password.ToString();
            if (row.Columns.TryGetValue("dob", out var role)) Role = role.ToString();
            if (row.Columns.TryGetValue("phone_number", out var security_question)) SecurityQuestion = security_question.ToString();
            if (row.Columns.TryGetValue("profile_picture", out var security_answer)) SecurityAnswer = security_answer.ToString();
        }

        /* 
         * Create account from input account info parameters
         * ID is optional because account creation does not require an input userid
         */

        /*
        public Client(string first_name, string last_name, string dob, string phone_number, string profile_picture, long user_id = 0)
        {
            ID = user_id;
            FirstName = first_name; ;
            LastName = last_name;
            DOB = dob;
            PhoneNumber = phone_number;
            ProfilePicture = profile_picture;
        }

        */
    }
}
