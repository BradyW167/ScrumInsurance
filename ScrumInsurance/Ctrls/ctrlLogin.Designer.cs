﻿using System.Windows.Forms;

namespace ScrumInsurance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlLogin));
            this.lbl_createAccount = new System.Windows.Forms.LinkLabel();
            this.lbl_ForgotPass = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLoginError = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pbxCenterPanel = new System.Windows.Forms.PictureBox();
            this.pbxTopBorder = new System.Windows.Forms.PictureBox();
            this.cbxShowPassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCenterPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTopBorder)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_createAccount
            // 
            this.lbl_createAccount.AutoSize = true;
            this.lbl_createAccount.BackColor = System.Drawing.Color.Black;
            this.lbl_createAccount.ForeColor = System.Drawing.Color.White;
            this.lbl_createAccount.LinkColor = System.Drawing.Color.LightSteelBlue;
            this.lbl_createAccount.Location = new System.Drawing.Point(599, 473);
            this.lbl_createAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_createAccount.Name = "lbl_createAccount";
            this.lbl_createAccount.Size = new System.Drawing.Size(81, 13);
            this.lbl_createAccount.TabIndex = 18;
            this.lbl_createAccount.TabStop = true;
            this.lbl_createAccount.Text = "Create Account";
            this.lbl_createAccount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_createAccount.VisitedLinkColor = System.Drawing.Color.Thistle;
            this.lbl_createAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_createAccount_LinkClicked);
            // 
            // lbl_ForgotPass
            // 
            this.lbl_ForgotPass.AutoSize = true;
            this.lbl_ForgotPass.BackColor = System.Drawing.Color.Black;
            this.lbl_ForgotPass.ForeColor = System.Drawing.Color.White;
            this.lbl_ForgotPass.LinkColor = System.Drawing.Color.LightSteelBlue;
            this.lbl_ForgotPass.Location = new System.Drawing.Point(409, 473);
            this.lbl_ForgotPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ForgotPass.Name = "lbl_ForgotPass";
            this.lbl_ForgotPass.Size = new System.Drawing.Size(92, 13);
            this.lbl_ForgotPass.TabIndex = 17;
            this.lbl_ForgotPass.TabStop = true;
            this.lbl_ForgotPass.Text = "Forgot Password?";
            this.lbl_ForgotPass.VisitedLinkColor = System.Drawing.Color.Thistle;
            this.lbl_ForgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_ForgotPass_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(180)))), ((int)(((byte)(247)))));
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(180)))), ((int)(((byte)(247)))));
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(180)))), ((int)(((byte)(247)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(180)))), ((int)(((byte)(247)))));
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogin.Location = new System.Drawing.Point(412, 441);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(265, 30);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.BackColor = System.Drawing.Color.Black;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(480, 147);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(200, 67);
            this.welcomeLabel.TabIndex = 14;
            this.welcomeLabel.Text = "SCRUM INSURANCE";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtUsername.Location = new System.Drawing.Point(412, 290);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(265, 30);
            this.txtUsername.TabIndex = 12;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPassword.Location = new System.Drawing.Point(412, 363);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(265, 30);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(405, 332);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(405, 267);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Username:";
            // 
            // lblLoginError
            // 
            this.lblLoginError.BackColor = System.Drawing.Color.Black;
            this.lblLoginError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblLoginError.ForeColor = System.Drawing.Color.LightCoral;
            this.lblLoginError.Location = new System.Drawing.Point(417, 397);
            this.lblLoginError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoginError.Name = "lblLoginError";
            this.lblLoginError.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLoginError.Size = new System.Drawing.Size(250, 34);
            this.lblLoginError.TabIndex = 19;
            this.lblLoginError.Text = "CLEAR ON INITIALIZE";
            this.lblLoginError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Black;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox9.Image = global::ScrumInsurance.Properties.Resources.scrum_logo;
            this.pictureBox9.Location = new System.Drawing.Point(419, 140);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(75, 77);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 61;
            this.pictureBox9.TabStop = false;
            // 
            // pbxCenterPanel
            // 
            this.pbxCenterPanel.BackColor = System.Drawing.Color.Black;
            this.pbxCenterPanel.Location = new System.Drawing.Point(394, 96);
            this.pbxCenterPanel.Name = "pbxCenterPanel";
            this.pbxCenterPanel.Size = new System.Drawing.Size(300, 400);
            this.pbxCenterPanel.TabIndex = 20;
            this.pbxCenterPanel.TabStop = false;
            // 
            // pbxTopBorder
            // 
            this.pbxTopBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pbxTopBorder.Location = new System.Drawing.Point(394, 86);
            this.pbxTopBorder.Name = "pbxTopBorder";
            this.pbxTopBorder.Size = new System.Drawing.Size(300, 10);
            this.pbxTopBorder.TabIndex = 63;
            this.pbxTopBorder.TabStop = false;
            // 
            // cbxShowPassword
            // 
            this.cbxShowPassword.AutoSize = true;
            this.cbxShowPassword.BackColor = System.Drawing.Color.Black;
            this.cbxShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxShowPassword.ForeColor = System.Drawing.Color.White;
            this.cbxShowPassword.Location = new System.Drawing.Point(491, 333);
            this.cbxShowPassword.Margin = new System.Windows.Forms.Padding(2);
            this.cbxShowPassword.Name = "cbxShowPassword";
            this.cbxShowPassword.Size = new System.Drawing.Size(141, 24);
            this.cbxShowPassword.TabIndex = 62;
            this.cbxShowPassword.Text = "Show Password";
            this.cbxShowPassword.UseVisualStyleBackColor = false;
            this.cbxShowPassword.CheckedChanged += new System.EventHandler(this.cbxShowPassword_CheckedChanged);
            // 
            // ctrlLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pbxTopBorder);
            this.Controls.Add(this.cbxShowPassword);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.lblLoginError);
            this.Controls.Add(this.lbl_createAccount);
            this.Controls.Add(this.lbl_ForgotPass);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxCenterPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ctrlLogin";
            this.Size = new System.Drawing.Size(1088, 582);
            this.Load += new System.EventHandler(this.ctrlLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCenterPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTopBorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lbl_createAccount;
        private System.Windows.Forms.LinkLabel lbl_ForgotPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLoginError;
        private System.Windows.Forms.PictureBox pbxCenterPanel;
        private System.Windows.Forms.PictureBox pictureBox9;
        private CheckBox cbxShowPassword;
        private PictureBox pbxTopBorder;
    }
}
