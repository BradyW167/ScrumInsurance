using System.Windows.Forms;

namespace ScrumInsurance.Ctrls
{
    partial class ctrlLogin
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
            this.llbCreateAccount = new System.Windows.Forms.LinkLabel();
            this.llbForgotPass = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblLoginError = new System.Windows.Forms.Label();
            this.pbxLoginLogo = new System.Windows.Forms.PictureBox();
            this.pbxCenterBackground = new System.Windows.Forms.PictureBox();
            this.pbxTopBorder = new System.Windows.Forms.PictureBox();
            this.pbxShowPassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoginLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCenterBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTopBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShowPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // llbCreateAccount
            // 
            this.llbCreateAccount.AutoSize = true;
            this.llbCreateAccount.BackColor = System.Drawing.Color.Black;
            this.llbCreateAccount.ForeColor = System.Drawing.Color.White;
            this.llbCreateAccount.LinkColor = System.Drawing.Color.LightSteelBlue;
            this.llbCreateAccount.Location = new System.Drawing.Point(595, 486);
            this.llbCreateAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llbCreateAccount.Name = "llbCreateAccount";
            this.llbCreateAccount.Size = new System.Drawing.Size(81, 13);
            this.llbCreateAccount.TabIndex = 18;
            this.llbCreateAccount.TabStop = true;
            this.llbCreateAccount.Text = "Create Account";
            this.llbCreateAccount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.llbCreateAccount.VisitedLinkColor = System.Drawing.Color.Thistle;
            this.llbCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_createAccount_LinkClicked);
            // 
            // llbForgotPass
            // 
            this.llbForgotPass.AutoSize = true;
            this.llbForgotPass.BackColor = System.Drawing.Color.Black;
            this.llbForgotPass.ForeColor = System.Drawing.Color.White;
            this.llbForgotPass.LinkColor = System.Drawing.Color.LightSteelBlue;
            this.llbForgotPass.Location = new System.Drawing.Point(405, 486);
            this.llbForgotPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llbForgotPass.Name = "llbForgotPass";
            this.llbForgotPass.Size = new System.Drawing.Size(92, 13);
            this.llbForgotPass.TabIndex = 17;
            this.llbForgotPass.TabStop = true;
            this.llbForgotPass.Text = "Forgot Password?";
            this.llbForgotPass.VisitedLinkColor = System.Drawing.Color.Thistle;
            this.llbForgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_ForgotPass_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(180)))), ((int)(((byte)(247)))));
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(180)))), ((int)(((byte)(247)))));
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(180)))), ((int)(((byte)(247)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(180)))), ((int)(((byte)(247)))));
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogin.Location = new System.Drawing.Point(408, 454);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(265, 30);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.BackColor = System.Drawing.Color.Black;
            this.lblLoginTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginTitle.ForeColor = System.Drawing.Color.White;
            this.lblLoginTitle.Location = new System.Drawing.Point(476, 160);
            this.lblLoginTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(200, 67);
            this.lblLoginTitle.TabIndex = 14;
            this.lblLoginTitle.Text = "SCRUM INSURANCE";
            this.lblLoginTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtUsername.Location = new System.Drawing.Point(408, 303);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(265, 30);
            this.txtUsername.TabIndex = 12;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPassword.Location = new System.Drawing.Point(408, 373);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(265, 30);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Black;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(406, 348);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password";
            this.lblPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Black;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(406, 278);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 20);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Username";
            // 
            // lblLoginError
            // 
            this.lblLoginError.BackColor = System.Drawing.Color.Black;
            this.lblLoginError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblLoginError.ForeColor = System.Drawing.Color.LightCoral;
            this.lblLoginError.Location = new System.Drawing.Point(413, 410);
            this.lblLoginError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoginError.Name = "lblLoginError";
            this.lblLoginError.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLoginError.Size = new System.Drawing.Size(250, 34);
            this.lblLoginError.TabIndex = 19;
            this.lblLoginError.Text = "CLEAR ON INITIALIZE";
            this.lblLoginError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxLoginLogo
            // 
            this.pbxLoginLogo.BackColor = System.Drawing.Color.Black;
            this.pbxLoginLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxLoginLogo.Image = global::ScrumInsurance.Properties.Resources.scrum_logo;
            this.pbxLoginLogo.Location = new System.Drawing.Point(415, 153);
            this.pbxLoginLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbxLoginLogo.Name = "pbxLoginLogo";
            this.pbxLoginLogo.Size = new System.Drawing.Size(75, 77);
            this.pbxLoginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLoginLogo.TabIndex = 61;
            this.pbxLoginLogo.TabStop = false;
            // 
            // pbxCenterBackground
            // 
            this.pbxCenterBackground.BackColor = System.Drawing.Color.Black;
            this.pbxCenterBackground.Location = new System.Drawing.Point(390, 109);
            this.pbxCenterBackground.Name = "pbxCenterBackground";
            this.pbxCenterBackground.Size = new System.Drawing.Size(300, 400);
            this.pbxCenterBackground.TabIndex = 20;
            this.pbxCenterBackground.TabStop = false;
            // 
            // pbxTopBorder
            // 
            this.pbxTopBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pbxTopBorder.Location = new System.Drawing.Point(390, 99);
            this.pbxTopBorder.Name = "pbxTopBorder";
            this.pbxTopBorder.Size = new System.Drawing.Size(300, 10);
            this.pbxTopBorder.TabIndex = 63;
            this.pbxTopBorder.TabStop = false;
            // 
            // pbxShowPassword
            // 
            this.pbxShowPassword.BackColor = System.Drawing.Color.White;
            this.pbxShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxShowPassword.Image = global::ScrumInsurance.Properties.Resources.password_hide_eye;
            this.pbxShowPassword.Location = new System.Drawing.Point(644, 375);
            this.pbxShowPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbxShowPassword.Name = "pbxShowPassword";
            this.pbxShowPassword.Size = new System.Drawing.Size(26, 26);
            this.pbxShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxShowPassword.TabIndex = 64;
            this.pbxShowPassword.TabStop = false;
            this.pbxShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxShowPassword_MouseDown);
            this.pbxShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxShowPassword_MouseUp);
            // 
            // ctrlLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(16)))), ((int)(((byte)(66)))));
            this.BackgroundImage = global::ScrumInsurance.Properties.Resources.shape_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.pbxShowPassword);
            this.Controls.Add(this.pbxTopBorder);
            this.Controls.Add(this.pbxLoginLogo);
            this.Controls.Add(this.lblLoginError);
            this.Controls.Add(this.llbCreateAccount);
            this.Controls.Add(this.llbForgotPass);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblLoginTitle);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pbxCenterBackground);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ctrlLogin";
            this.Size = new System.Drawing.Size(1080, 607);
            this.Load += new System.EventHandler(this.ctrlLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoginLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCenterBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTopBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShowPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llbCreateAccount;
        private System.Windows.Forms.LinkLabel llbForgotPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblLoginError;
        private System.Windows.Forms.PictureBox pbxCenterBackground;
        private System.Windows.Forms.PictureBox pbxLoginLogo;
        private PictureBox pbxTopBorder;
        private PictureBox pbxShowPassword;
    }
}
