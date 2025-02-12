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
            // Load next page if database connection established
            Session.UserID = Session.FindAccount(txtUsername.Text, txtPassword.Text);
            if (Session.UserID >= 0 && dbController_.openConnection())
            {
                ctrlLanding newControl = new ctrlLanding();
                Session.swapControl(this, newControl);
            }
            else if (Session.UserID < 0)
            {
                lblLoginError.Text = "Incorrect username or password\nPlease make an account if you haven't already";
            }
            else
            {
                lblLoginError.Text = "Failed";
            }
        }

        private void lbl_createAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ctrlCreateAccount c = new ctrlCreateAccount();
            Session.swapControl(this, c);
            TableLayoutPanel parentPanel = this.Parent as TableLayoutPanel;

            if (parentPanel != null)
            {
                int columnIndex = parentPanel.GetColumn(this);
                int rowIndex = parentPanel.GetRow(this);

                // Remove the current UserControl
                parentPanel.Controls.Remove(this);
                this.Dispose();

                // Load the new UserControl
                c.AutoSize = true;
                c.Dock = DockStyle.Fill;

                // Add new UserControl to the same cell
                parentPanel.Controls.Add(c, columnIndex, rowIndex);
            }
        }

        private void lbl_ForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ctrlForgotPass c = new ctrlForgotPass();
            Session.swapControl(this, c);
        }
    }
}
