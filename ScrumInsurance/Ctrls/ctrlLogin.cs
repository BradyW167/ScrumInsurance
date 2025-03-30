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
using ScrumInsurance.Ctrls;

namespace ScrumInsurance
{
    public partial class ctrlLogin : ScrumUserControl
    {
        public ctrlLogin()
        {
            InitializeComponent();
            lblLoginError.Text = "";
        }

        public ctrlLogin(Session session, TableLayoutPanel pnlMain)
        {
            InitializeComponent();
            lblLoginError.Text = "";
            Session = session;
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
            // Console.WriteLine("User (" + txtUsername.Text + ") Pass (" + txtPassword.Text + ")");
            // Store user info
            // Null on invalid login
            string[] user_info = Session.DBController.validateLogin(txtUsername.Text, txtPassword.Text);
            if (user_info != null)
            {
                Session.Username = user_info[0];
                Session.Role = user_info[1];
                // Load landing page, admins go to admin page, clients go to new client page, decided by role column in database
                if (Session.Role.Equals("admin"))
                {
                    swapCtrlMain(new adminLanding());
                    loadCtrlDash();
                }
                else
                {
                    swapCtrlMain(new ctrlLandingClient());
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

    }
}
