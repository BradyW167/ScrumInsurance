using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ScrumInsurance.Ctrls
{
    public partial class ctrlEditProfile : ScrumUserControl
    {
        public ctrlEditProfile(ScrumUserControl oldCtrl) : base(oldCtrl)
        {
            InitializeComponent();

            txtUsername.Text = Session.UserAccount.Username;
            txtPassword.Text = Session.UserAccount.Password;
        }

        private void passCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
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

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            // Stores errors if input password is invalid
            string errors = DBController.ValidateUsername(txtUsername.Text);

            // If any errors were found, set the error message in error provider
            if (errors.Length > 0) { e.Cancel = true; }

            // Show the error text to user
            else { errEditProfile.SetError(txtUsername, errors); }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            // Stores errors if input password is invalid
            string errors = DBController.ValidatePassword(txtPassword.Text);

            // If any errors were found, set the error message in error provider
            if (errors.Length > 0) { e.Cancel = true; }

            // Show the error text to user
            errEditProfile.SetError(txtPassword, errors);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // If input account info is invalid, return
            if (!ValidateChildren()) { return; }
            // Else input account info is valid
            else
            {
                // Updates this user's database info with the new username and password
                DBController.UpdateAccount(Session.UserAccount.ID, txtUsername.Text, txtPassword.Text);
            }
        }
    }
}
