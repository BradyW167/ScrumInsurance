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

namespace ScrumInsurance
{
    public partial class ctrlEditProfile : ScrumUserControl
    {
        public ctrlEditProfile(Session session)
        {
            InitializeComponent();
            txtNewUser.Text = session.UserAccount.Username;
            txtNewPass.Text = session.UserAccount.Password;

        //needs to be added
            //pbxProfile.Image = session.Profile
            //txtFirstName.Text = session.FirstName;
            //txtLastName.Text = session.LastName;
            //txtDOB.Text = session.DOB
        }

        private void passCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            txtNewPass.UseSystemPasswordChar = !txtNewPass.UseSystemPasswordChar;
        }

        private void btnChangeProfilePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select a Profile Picture",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            };

            // Show dialog + check a file was selected
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load the image 
                pbxProfile.ImageLocation = openFileDialog.FileName;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Add check for if new password and email are valid
            if (DBController.UpdateAccount(Session.UserAccount.Username, new Dictionary<string, object> { { "password", txtNewPass.Text }/*, { "email", txtNewEmail.Text }*/ }))
            {
                lblError.Text = "Profile successfully updated";
            }
            else
            {
                lblError.Text = "Failed to update profile";
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (DBController.DeleteAccount(Session.UserAccount.Username))
            {
                this.swapCtrlMain(new ctrlLogin());
            }
            else
            {
                lblError.Text = "Failed to delete account";
            }
        }
    }
}
