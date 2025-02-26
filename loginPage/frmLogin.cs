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
            if (txtUsername.Text == String.Empty)
            {
                lblErrorUsername.Show();
            }

            if (txtPassword.Text == String.Empty)
            {
                lblErrorPassword.Show();
            }

            if (!loginController_.validateLogin(txtUsername.Text, txtPassword.Text))
            {
                lblErrorPassword.Show();
            }
            else
            {
                frmHome frmHome = new frmHome();
                frmHome.Show();
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
