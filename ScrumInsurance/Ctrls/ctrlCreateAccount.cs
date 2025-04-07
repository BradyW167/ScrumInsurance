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
    }
}
