using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowserGitHubDemo
{
    public partial class ctrlLogin : UserControl
    {
        private DatabaseController dbController_;

        public ctrlLogin()
        {
            InitializeComponent();
            if (dbController_ == null)
            {
                dbController_ = new DatabaseController();
            }
        }

        public ctrlLogin(DatabaseController dbController)
        {
            InitializeComponent();
            dbController_ = dbController;
        }

        private void ctrlLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Load next page if database connection established & account with correct username & password is found
            Session.userID = Session.findAccount(txtUsername.Text, txtPassword.Text);
            if (Session.userID >= 0 && dbController_.openConnection())
            {
                ctrlLanding newControl = new ctrlLanding(dbController_);
                Session.swapControl(this, newControl);
            }
            //Error if account with correct username & password isn't found
            else if (Session.userID < 0)
            {
                lblLoginError.Text = "Incorrect username or password\nPlease make an account if you haven't already";
            }
            else
            {
                lblLoginError.Text = "Failed to connect to database. Make sure you are connected to the Butler servers";
            }
        }

        private void lbl_createAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ctrlCreateAccount c = new ctrlCreateAccount();
            Session.swapControl(this, c);
        }

        private void lbl_ForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ctrlForgotPass c = new ctrlForgotPass();
            Session.swapControl(this, c);
        }

    }
}
