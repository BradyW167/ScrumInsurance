﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        }

        // Trigger validation of txtUsername on Enter key down
        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Call validation method for this control
                this.Validate();
                e.SuppressKeyPress = true; // Prevent ding sound
            }
        }

        /**
         * Validate input username in txtUsername
         * Show security question prompt if username is valid
         * Else show error
         */
        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            // Store account info for input username in session
            Session.UserAccount = DBController.GetAccountByUsername(txtUsername.Text);

            // If the username was found in the database...
            if (Session.UserAccount != null)
            {
                // Clear errors
                errForgotPass.SetError(txtUsername, "");

                // Show security question to user
                lblSecurityQuestion.Text = Session.UserAccount.SecurityQuestion;
                lblSecurityQuestion.Visible = true;
                txtQuestionAnswer.Visible = true;
            }
            else
            {
                errForgotPass.SetError(txtUsername, "User not found");
            }
        }

        // Trigger validation of txtQuestionAnswer on Enter key down
        private void txtQuestionAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Call validation method for this control
                this.Validate();
                e.SuppressKeyPress = true; // Prevent ding sound
            }
        }

        /**
         * Validate input answer in txtQuestionAnswer
         * Show new password prompt if answer is valid
         * Else show error
         * Closes entire form if input answer is invalid 3 times
         */
        private void txtQuestionAnswer_Validating(object sender, CancelEventArgs e)
        {
            // If input answer is equal to database answer stored in session...
            if (txtQuestionAnswer.Text.Equals(Session.UserAccount.SecurityAnswer))
            {
                // Clear errors
                errForgotPass.SetError(txtConfirmNewPassword, "");

                // Show new password input fields
                lblNewPassword.Visible = true;
                txtNewPassword.Visible = true;
                lblConfirmNewPassword.Visible = true;
                txtConfirmNewPassword.Visible = true;
                btnConfirmNewPassword.Visible = true;
            }
            // Else input answer is invalid
            else
            {
                errForgotPass.SetError(txtQuestionAnswer, "Incorrect answer" + Session.ForgotPassFailCount);

                // Increment fail counter for erroneous answers
                Session.ForgotPassFailCount++;

                // If three or more fails have occurred, alert the user and close the form
                if (Session.ForgotPassFailCount >= 3) {
                    MessageBox.Show("Too many incorrect answers, closing application", "Scrum Insurance");
                    Application.Exit();
                }
            }
        }

        // Trigger validation of txtNewPassword on Enter key down
        private void txtNewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Call validation method for txtNewPassword
                this.Validate();
                e.SuppressKeyPress = true; // Prevent ding sound
            }
        }

        /**
         * Validate input password in txtNewPassword
         * Show error if invalid
         */
        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            // Stores errors if input password is invalid
            string errors = DBController.ValidatePassword(txtNewPassword.Text, txtUsername.Text);

            // If any errors were found, set the error message in error provider
            if (errors.Length > 0) { e.Cancel = true; }

            // Show errors to user
            errForgotPass.SetError(txtNewPassword, errors);
        }

        // Trigger validation of txtConfirmNewPassword on Enter key down
        private void txtConfirmNewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Call validation method for this control
                this.Validate();
                e.SuppressKeyPress = true; // Prevent ding sound
            }
        }

        /**
         * Validate if txtConfirmNewPassword is equal to txtNewPassword
         * Show error if not
         */
        private void txtConfirmNewPassword_Validating(object sender, CancelEventArgs e)
        {
            // Store password input in previous field
            string password = txtNewPassword.Text;

            // If password in this field does not match previous field...
            if (!txtConfirmNewPassword.Text.Equals(password))
            {
                e.Cancel = true;
                errForgotPass.SetError(txtConfirmNewPassword, "Passwords must match");
            }
            // Else clear error 
            else { errForgotPass.SetError(txtConfirmNewPassword, ""); }
        }

        /**
         * Sets new password for input username's account
         * Swaps back to login screen if valid
         * Does nothing if any above input is invalid
         */
        private void btnConfirmNewPassword_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren()) { return; }
            else
            {
                // Updates the user's password and takes the user back to the login page
                DBController.UpdateAccount(Session.UserAccount.Username, new Dictionary<string, object> { { "password", txtNewPassword.Text } });
                this.SwapCtrlMain(new ctrlLogin());
            }
        }

        // Returns user to login page
        private void lblBackLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.SwapCtrlMain(new ctrlLogin());
        }
    }
}
