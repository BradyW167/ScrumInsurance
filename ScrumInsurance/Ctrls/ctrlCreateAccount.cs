using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Text.RegularExpressions;

namespace ScrumInsurance
{
    public partial class ctrlCreateAccount : ScrumUserControl
    {
        public ctrlCreateAccount(ScrumUserControl oldCtrl) : base(oldCtrl)
        {
            InitializeComponent();
        }

        private void ctrlCreateAccount_Load(object sender, EventArgs e) {}

        //Check if username, password and email are valid (not blank, classic password requirements)
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            // If input account info is invalid, return
            if(!ValidateChildren()) { return; }
            // Else input account info is valid
            else
            {
                Account new_account = new Account(txtCreateUsername.Text, txtCreatePassword.Text, "client", cmbSecurityQuestion.Text, txtCreateAnswer.Text);

                // If account is sucessfully added...
                if (DBController.AddAccount(new_account)) {
                    SwapCtrlMain(new ctrlLogin(this));
                }
                // Else account creation failed due to database error
                else
                {
                    errCreateAccount.SetError(btnCreateAccount, "Database Error: Cannot create account");
                }
            }
        }

        private void lblBackLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Takes the user back to the login page
            SwapCtrlMain(new ctrlLogin(this));
        }

        private void txtCreateUsername_Validating(object sender, CancelEventArgs e)
        {
            // Stores errors if input password is invalid
            string errors = DBController.ValidateUsername(txtCreateUsername.Text);

            // If any errors were found, set the error message in error provider
            if (errors.Length > 0) { e.Cancel = true; }

            // Show the error text to user
            else { errCreateAccount.SetError(txtCreateUsername, errors); }
        }

        private void txtCreatePassword_Validating(object sender, CancelEventArgs e)
        {
            // Stores errors if input password is invalid
            string errors = DBController.ValidatePassword(txtCreatePassword.Text);

            // If any errors were found, set the error message in error provider
            if (errors.Length > 0) { e.Cancel = true; }

            // Show the error text to user
            errCreateAccount.SetError(txtCreatePassword, errors);
        }

        private void cmbSecurityQuestion_Enter(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() => cmbSecurityQuestion.DroppedDown = true));
        }
    }
}
