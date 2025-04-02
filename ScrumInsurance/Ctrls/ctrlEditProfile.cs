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
        public ctrlEditProfile(Session session)
        {
            InitializeComponent();
            txtNewUser.Text = session.Username;
            txtNewPass.Text = session.Password;
            txtNewEmail.Text = session.Email;
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
    }
}
