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

        public ctrlLogin(DatabaseController dbController)
        {
            InitializeComponent();
            lblLoginError.Text = "";
        }

        private void ctrlLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Console.WriteLine("User (" + txtUsername.Text + ") Pass (" + txtPassword.Text + ")");
            // If username and password text is found in database (valid login)
            // if it is not found null was returned, not a string array
            string[] usernameAndRole = session_.getDbController().validateLogin(txtUsername.Text, txtPassword.Text);
            if (usernameAndRole != null)
            {
                session_.Username = usernameAndRole[0];
                session_.Role = usernameAndRole[1];
                // Load landing page, admins go to admin page, clients go to new client page, decided by role coloumn in database
                if (session_.Role.Equals("admin"))
                {
                    this.swapControl(new ctrlLanding(session_));
                }
                else
                {
                    this.swapControl(new ctrlLandingClient(session_));
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
            this.swapControl(new ctrlCreateAccount());
        }

        private void lbl_ForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.swapControl(new ctrlForgotPass());
        }

    }
}
