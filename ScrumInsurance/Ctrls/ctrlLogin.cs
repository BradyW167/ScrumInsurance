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
using MySql.Data.MySqlClient;

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

            this.Anchor = AnchorStyles.None;
            this.Dock = DockStyle.None;
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
            lblLoginError.Text = "";

            // Attempt to login with input username and password, store returned data in session acccount
            Session.UserAccount = DBController.ValidateLogin(txtUsername.Text, txtPassword.Text);

            // If no valid, matching account was found...
            if (Session.UserAccount == null)
            {
                lblLoginError.Text = "Database connection failed";
            }
            else if (Session.UserAccount.ID == 0) {
                lblLoginError.Text = "Incorrect username or password";
            }
            // Else input username and password access a valid account
            else
            {
                LoginRedirect(Session.UserAccount.Role);
            }
        }

        private void LoginRedirect(string role)
        {
            PnlMain.BackColor = Color.SteelBlue;

            // Load 
            if (role.Equals("admin"))
            {
                LoadLandingPage(new ctrlLandingAdmin(this));
            }
            else if (role.Equals("claim_manager"))
            {
                LoadLandingPage(new ctrlLandingCManager(this));
            }
            else if (role.Equals("finance_manager"))
            {
                LoadLandingPage(new ctrlLandingFManager(this));
            }
            else
            {
                LoadLandingPage(new ctrlLandingClient(this));
            }
        }

        private void LoadLandingPage(ScrumUserControl landingPage)
        {
            SwapCtrlMain(landingPage);
            LoadCtrlDash();
            LoadCtrlFooter();
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
