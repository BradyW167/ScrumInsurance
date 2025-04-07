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

namespace ScrumInsurance
{
    public partial class ctrlForgotPass : ScrumUserControl
    {

        public ctrlForgotPass()
        {
            InitializeComponent();
            lblUsernameError.Text = "";
            lblQuestionError.Text = "";
            lblNewPasswordError.Text = "";
        }

        // Shows security question step if email is associated with account
        private void btnConfirmUsername_Click(object sender, EventArgs e)
        {
            // Get security info for input username and stores it in session account info
            string[] SecurityInfo = DBController.GetSecurityInfo(txtUsername.Text);

            // If the username was found in the database...
            if (SecurityInfo != null) {
                // Store user security info in session
                Session.UserAccount.Username = txtUsername.Text;
                Session.UserAccount.SecurityQuestion = SecurityInfo[0];
                Session.UserAccount.SecurityAnswer = SecurityInfo[1];

                // Show security question to user
                lblSecurityQuestion.Text = "Question: " + Session.UserAccount.SecurityQuestion;
                lblSecurityQuestion.Visible = true;
                txtQuestionAnswer.Visible = true;
                btnSubmitAnswer.Visible = true;
                lblUsernameError.Text = "";
            }
            else
            {
                lblUsernameError.Text = "Username not found";
            }
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            // If input answer is equal to database answer stored in session
            if (txtQuestionAnswer.Text.Equals(Session.UserAccount.SecurityAnswer))
            {
                // Show new password input fields
                lblNewPassword.Visible = true;
                txtNewPassword.Visible = true;
                btnConfirmNewPassword.Visible = true;
                lblNewPasswordError.Text = "";
            }
            else
            {
                lblNewPasswordError.Text = "Incorrect answer";
            }
        }

        private void btnConfirmNewPassword_Click(object sender, EventArgs e)
        {
            string new_password = txtNewPassword.Text;
            if (new_password.Length < 8)
            {
                lblNewPasswordError.Text = "Password must be atleast 8 characters long";
            }
            else
            {
                // Updates the user's password and takes the user back to the login page
                DBController.UpdateAccount(Session.UserAccount.Username, new Dictionary<string, string> { { "password", txtNewPassword.Text } });
                this.swapCtrlMain(new ctrlLogin());
            }
        }

        private void lblBackLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Takes the user back to the login page
            this.swapCtrlMain(new ctrlLogin());
        }
    }
}
