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
        // Default constructor
        public Session() {
            UserAccount = new Account();
            CtrlMain = null;
            CtrlDashboard = null;
        }

        // Eventually, session should save an account, with all the current user's info from database
        public Account UserAccount;
        public ScrumUserControl CtrlMain { get; set; }
        public ScrumUserControl CtrlDashboard { get; set; }

        /*
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
        }*/
    }
}
