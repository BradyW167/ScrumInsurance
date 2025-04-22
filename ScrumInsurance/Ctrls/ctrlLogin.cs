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

namespace ScrumInsurance.Ctrls
{
    public partial class ctrlLogin : ScrumUserControl
    {
        // Constructor for first control loaded in (Login control is always loaded first)
        public ctrlLogin(Session session, DatabaseController controller, TableLayoutPanel pnlMain, Form frmMain)
        {
            InitializeComponent();
            lblLoginError.Text = "";
            Session = session;
            DBController = controller;
            PnlMain = pnlMain;
            FrmMain = frmMain;
            Session.CtrlMain = this;
        }

        // Constructer for swapping controls
        public ctrlLogin(ScrumUserControl oldCtrl) : base(oldCtrl)
        {
            InitializeComponent();
            lblLoginError.Text = "";
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
                    SwapCtrlMain(new ctrlAdminLanding(this));
                    LoadCtrlDash();
                }
                else if (Session.UserAccount.Role.Equals("client"))
                {
                    SwapCtrlMain(new ctrlLandingClient(this));
                    LoadCtrlDash();
                    LoadCtrlFooter();
                }
                else if (Session.UserAccount.Role.Equals("claim_manager"))
                {
                    SwapCtrlMain(new ctrlLandingCManager(this));
                    LoadCtrlDash();
                }
                else if (Session.UserAccount.Role.Equals("finance_manager"))
                {
                    SwapCtrlMain(new ctrlLandingFManager());
                    LoadCtrlDash();
                }
                else
                {
                    SwapCtrlMain(new ctrlLandingClient(this));
                    LoadCtrlDash();
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
            SwapCtrlMain(new ctrlCreateAccount(this));
        }

        private void lbl_ForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SwapCtrlMain(new ctrlForgotPass(this));
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
