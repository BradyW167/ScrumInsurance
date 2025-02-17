using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowserGitHubDemo
{
    public static class Session
    {
        private static List<Account> accounts_ = new List<Account>();
        public static int userID { get; set; }

        public static void addAccount(string username, string password, string email, string securityQuestion, string securityQuestionAnswer)
        {
            accounts_.Add(new Account(username, password, email, securityQuestion, securityQuestionAnswer));
        }

        //Returns index of first account in list of accounts with specified username + password, returns -1 otherwise
        public static int findAccount(string username, string password)
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
        public static int findAccount(string email)
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
        public static string findQuestion(string email)
        {
            for (int i = 0; i < accounts_.Count; i++)
            {
                if (accounts_[i].validCreds(email))
                {
                    return accounts_[i].securityQuestion_;
                }
            }
            return null;
        }

        public static Account getAccount(int index)
        {
            return accounts_[index];
        }

        // Deletes the current user control in parent panel and load a new input control
        public static void swapControl(UserControl oldControl, UserControl newControl)
        {
            TableLayoutPanel parentPanel = oldControl.Parent as TableLayoutPanel;

            if (parentPanel != null)
            {
                int columnIndex = parentPanel.GetColumn(oldControl);
                int rowIndex = parentPanel.GetRow(oldControl);

                // Remove the current UserControl
                parentPanel.Controls.Remove(oldControl);
                oldControl.Dispose();

                // Load the new UserControl
                newControl.Dock = DockStyle.Fill;

                // Add new UserControl to the same cell
                parentPanel.Controls.Add(newControl, columnIndex, rowIndex);
            }
        }
    }
}
