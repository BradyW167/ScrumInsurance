using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumInsurance
{
    public partial class ctrlLogin : ScrumUserControl
    {
        public ctrlLogin()
        {
            InitializeComponent();
            lblLoginError.Text = "";
        }

        public ctrlLogin(Session session, DatabaseController controller, TableLayoutPanel pnlMain)
        {
            InitializeComponent();
            lblLoginError.Text = "";
            Session = session;
            DBController = controller;
            PnlMain = pnlMain;
            Session.CtrlMain = this;
        }

        private void ctrlLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the Enter key was pressed
            if (e.KeyCode == Keys.Enter)
            {
                // Call the login button's click event or method
                btnLogin.PerformClick();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Attempt to login with input username and password, store returned data in session acccount
            Session.UserAccount = DBController.ValidateLogin(txtUsername.Text, txtPassword.Text);

            // If an account was returned from above...
            if (Session.UserAccount != null)
            {
                // Load landing page, admins go to admin page, clients go to new client page, decided by role column in database
                if (Session.UserAccount.Role.Equals("admin"))
                {
                    swapCtrlMain(new ctrlAdminLanding());
                    loadCtrlDash();
                }
                else if (Session.UserAccount.Role.Equals("client"))
                {
                    swapCtrlMain(new ctrlLandingClient(Session));
                    loadCtrlDash();
                }
                else if (Session.UserAccount.Role.Equals("claim_manager"))
                {
                    swapCtrlMain(new ctrlLandingCManager());
                    loadCtrlDash();
                }
                else if (Session.UserAccount.Role.Equals("finance_manager"))
                {
                    swapCtrlMain(new ctrlLandingFManager());
                    loadCtrlDash();
                }
                else
                {
                    swapCtrlMain(new ctrlLandingClient(Session));
                    loadCtrlDash();
                }
            }
            // Error if account with correct username & password isn't found
            else
            {
                lblLoginError.Text = "Incorrect username or password";
            }
        }

        private void lbl_createAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            swapCtrlMain(new ctrlCreateAccount());
        }

        private void lbl_ForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            swapCtrlMain(new ctrlForgotPass());
        }

        private void pbxShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            // Disable hidden password characters
            txtPassword.PasswordChar = new char();

            // Change picture box to display password shown eye
            pbxShowPassword.Image = Properties.Resources.password_show_eye;

        }

        private void pbxShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            // Enable hidden password characters
            txtPassword.PasswordChar = '●';

            // Change picture box to display password shown eye
            pbxShowPassword.Image = Properties.Resources.password_hide_eye;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
