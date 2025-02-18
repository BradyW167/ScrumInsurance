using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumInsurance
{
    public partial class ctrlLogin : ScrumUserControl
    {
        DatabaseController dbController_;

        public ctrlLogin()
        {
            InitializeComponent();
            lblLoginError.Text = "";
            if (dbController_ == null)
            {
                dbController_ = new DatabaseController();
            }
        }

        public ctrlLogin(DatabaseController dbController)
        {
            InitializeComponent();
            lblLoginError.Text = "";
            dbController_ = dbController;
        }

        private void ctrlLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Load next page if database connection established & account with correct username & password is found
            session_.userID = session_.findAccount(txtUsername.Text, txtPassword.Text);
            if (session_.userID >= 0 && session_.isConnected())
            {
                this.swapControl(new ctrlLanding());
            }
            //Error if account with correct username & password isn't found
            else if (session_.userID < 0)
            {
                lblLoginError.Text = "Incorrect username or password";
            }
            else
            {
                lblLoginError.Text = "Failed to connect to database. Make sure you are connected to the Butler servers";
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
