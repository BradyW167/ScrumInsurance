﻿using System;
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
        private Account LoadedAccount {  get; set; }

        // Default constructor, used when editing own account
        public ctrlEditProfile(ScrumUserControl oldCtrl) : base(oldCtrl)
        {
            InitializeComponent();

            LoadedAccount = Session.UserAccount;

            txtUsername.Text = Session.UserAccount.Username;
            txtPassword.Text = Session.UserAccount.Password;

            lblError.Text = "";

            // Hide role selection if editing own account
            cmbSelectRole.Visible = false;
            lblSelectRole.Visible = false;
        }

        // Constructor for editing another user's account
        public ctrlEditProfile(ScrumUserControl oldCtrl, Account userAccount) : base(oldCtrl)
        {
            InitializeComponent();

            LoadedAccount = userAccount;

            txtUsername.Text = userAccount.Username;
            txtPassword.Text = userAccount.Password;

            lblError.Text = "";

            // Show role selection if editing another user's account
            cmbSelectRole.Visible = true;
            lblSelectRole.Visible = true;

            Dictionary<string, string> role_pairs = new Dictionary<string, string>()
            {
                {"Admin", "admin" },
                {"Claim Manager", "claim_manager" },
                {"Finance Manager", "finance_manager" },
                {"Client", "client" }
            };

            cmbSelectRole.DataSource = new BindingSource(role_pairs, null);
            cmbSelectRole.DisplayMember = "Key";
            cmbSelectRole.ValueMember = "Value";

            cmbSelectRole.DropDownHeight = cmbSelectRole.ItemHeight * (cmbSelectRole.Items.Count + 1);

            cmbSelectRole.SelectedValue = userAccount.Role;
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
            string errors = DBController.ValidateUsername(txtUsername.Text, false);

            // If any errors were found, set the error message in error provider
            if (errors.Length > 0) { e.Cancel = true; }

            // Show the error text to user
            errEditProfile.SetError(txtUsername, errors);
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            // Stores errors if input password is invalid
            string errors = DBController.ValidatePassword(txtPassword.Text, txtUsername.Text, false);

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
                bool? result = null;

                if (cmbSelectRole.Visible)
                {
                    // Store the selected role in the combobox dropdown
                    string selected_role = ((KeyValuePair<string, string>)cmbSelectRole.SelectedItem).Value;

    

                    // Updates this user's database info with the new username, password, and role
                    result = DBController.UpdateAccount(LoadedAccount.ID, 
                                                              txtUsername.Text, 
                                                              txtPassword.Text, 
                                                              selected_role);

                }
                else
                {
                    // Updates this user's database info with the new username and password
                    result = DBController.UpdateAccount(LoadedAccount.ID, txtUsername.Text, txtPassword.Text);
                }

                if (result == null) { lblError.Text = "Database error";  }
                else if (result == false ) { lblError.Text = "Nothing changed"; }
                else { lblError.Text = "Account updated";}
            }
        }
    }
}
