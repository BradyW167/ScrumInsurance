namespace ScrumInsurance.Ctrls
{
    partial class ctrlEditProfile
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEditProfile = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNewUser = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtNewEmail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passCheckbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEditProfile
            // 
            this.lblEditProfile.AutoSize = true;
            this.lblEditProfile.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblEditProfile.Location = new System.Drawing.Point(27, 32);
            this.lblEditProfile.Name = "lblEditProfile";
            this.lblEditProfile.Size = new System.Drawing.Size(175, 39);
            this.lblEditProfile.TabIndex = 0;
            this.lblEditProfile.Text = "Edit Profile";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(230, 502);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(125, 47);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(93, 135);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(162, 25);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Set Username: ";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(93, 207);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(158, 25);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Set Password: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(93, 276);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(117, 25);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Set Email: ";
            // 
            // txtNewUser
            // 
            this.txtNewUser.Location = new System.Drawing.Point(98, 171);
            this.txtNewUser.Name = "txtNewUser";
            this.txtNewUser.Size = new System.Drawing.Size(255, 26);
            this.txtNewUser.TabIndex = 5;
            this.txtNewUser.Text = "Enter New Username: ";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(98, 239);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(255, 26);
            this.txtNewPass.TabIndex = 6;
            this.txtNewPass.Text = "Enter New Password: ";
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // txtNewEmail
            // 
            this.txtNewEmail.Location = new System.Drawing.Point(98, 309);
            this.txtNewEmail.Name = "txtNewEmail";
            this.txtNewEmail.Size = new System.Drawing.Size(255, 26);
            this.txtNewEmail.TabIndex = 7;
            this.txtNewEmail.Text = "Enter New Email: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox1.Location = new System.Drawing.Point(83, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 446);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // passCheckbox
            // 
            this.passCheckbox.AutoSize = true;
            this.passCheckbox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.passCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passCheckbox.Location = new System.Drawing.Point(357, 242);
            this.passCheckbox.Name = "passCheckbox";
            this.passCheckbox.Size = new System.Drawing.Size(146, 21);
            this.passCheckbox.TabIndex = 9;
            this.passCheckbox.Text = "Show Password";
            this.passCheckbox.UseVisualStyleBackColor = false;
            this.passCheckbox.CheckedChanged += new System.EventHandler(this.passCheckbox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 10;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblError.ForeColor = System.Drawing.Color.Crimson;
            this.lblError.Location = new System.Drawing.Point(226, 418);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(147, 20);
            this.lblError.TabIndex = 11;
            this.lblError.Text = "Cleared on Initialize";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ctrlEditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passCheckbox);
            this.Controls.Add(this.txtNewEmail);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtNewUser);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblEditProfile);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ctrlEditProfile";
            this.Size = new System.Drawing.Size(596, 586);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditProfile;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNewUser;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtNewEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox passCheckbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblError;
    }
}
