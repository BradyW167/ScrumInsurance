using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class frmLogin : Form
    {
        private LoginController loginController_;

        public frmLogin()
        {
            InitializeComponent();
            loginController_ = new LoginController();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";

            lblErrorPassword.Hide();
            lblErrorUsername.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // If username input box is empty...
            if (txtUsername.Text == String.Empty)
            {
                // Show the username error label
                lblErrorUsername.Show();
                return;
            }
            // If password input box is empty...
            else if (txtPassword.Text == String.Empty)
            {
                // Show the password error label
                lblErrorPassword.Show();
                return;
            }
            // If login is invalid...
            if (!loginController_.validateLogin(txtUsername.Text, txtPassword.Text))
            {
                // Show the password error label
                lblErrorPassword.Show();
            }
            // Else login is valid
            else
            {
                // Create and show home form
                frmHome frmHome = new frmHome();
                frmHome.Show();

                // Hide this form
                this.Hide();
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
