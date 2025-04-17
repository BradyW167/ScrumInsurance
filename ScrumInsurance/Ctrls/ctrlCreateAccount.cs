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
        public ctrlCreateAccount()
        {
            InitializeComponent();
            lblCreateAccountError.Text = "";
        }

        private void ctrlCreateAccount_Load(object sender, EventArgs e) {}

        //Check if username, password and email are valid (not blank, classic password requirements)
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            
            if (txtCreatePassword.Text.Length < 8)
            {
                lblCreateAccountError.Text = "Password must be atleast 8 characters";
            }
            
            

            else if (txtCreateUsername.Text.Length < 8)
            {
                lblCreateAccountError.Text = "Username must be atleast 8 characters";
            }
            else
            {
                Account new_account = new Account(txtCreateUsername.Text, txtCreatePassword.Text, "client", cmbSecurityQuestion.Text, txtCreateAnswer.Text);

                // If account is sucessfully added...
                if (DBController.AddAccount(new_account)) {
                    this.swapCtrlMain(new ctrlLogin());
                }
                // Else account creation failed due to duplicate info
                else
                {
                    lblCreateAccountError.Text = "Username or password already exists";
                }

            }
        }

        private void lblBackLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Takes the user back to the login page
            this.swapCtrlMain(new ctrlLogin());
        }

        private void txtCreatePassword_Validating(object sender, CancelEventArgs e)
        {
            StringBuilder errorMessages = new StringBuilder(); //allows different + multiple error messages to be sent

            if (txtCreatePassword.Text.Length < 8)
            {
                errorMessages.AppendLine("Password must be at least 8 characters long");
            }
            if (!Regex.IsMatch(txtCreatePassword.Text, @"[A-Z]"))
            {
                errorMessages.AppendLine("Password must contain at least one uppercase letter");
            }
            if (!Regex.IsMatch(txtCreatePassword.Text, @"[a-z]"))
            {
                errorMessages.AppendLine("Password must contain at least one lowercase letter");
            }
            if (!Regex.IsMatch(txtCreatePassword.Text, @"[0-9]"))
            {
                errorMessages.AppendLine("Password must contain at least one digit");
            }
            if (!Regex.IsMatch(txtCreatePassword.Text, @"[\W_]"))
            {
                errorMessages.AppendLine("Password must contain at least one special character");
            }
            if (txtCreatePassword.Text.Contains(" "))
            {
                errorMessages.AppendLine("Password must not contain spaces");
            }

            if (errorMessages.Length > 0) //goes through errors
            {
                errCreateAccount.SetError(this, errorMessages.ToString());
            }
        }
    }
}
