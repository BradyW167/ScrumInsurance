using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumInsurance
{
    public class Session
    {
        private List<Account> accounts_;
        private DatabaseController dbController_;

        public Session()
        {
            accounts_ = new List<Account>();
            //this will need to be taken out later, however it is here for now just for testing purposes. 
            accounts_.Add(new Account("admin", "admin", "adming@scrum.com", "Background Color?", "Steel Blue"));
            accounts_[0].isAdmin = true;

            dbController_ = new DatabaseController();
        }

        public DatabaseController getDbController() { return dbController_; }

        public int userID { get; set; }

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
