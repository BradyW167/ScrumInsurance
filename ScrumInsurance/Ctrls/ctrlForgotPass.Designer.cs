﻿namespace ScrumInsurance
{
    partial class ctrlForgotPass
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
            this.btnConfirmUsername = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtQuestionAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSecurityQuestion = new System.Windows.Forms.Label();
            this.lblUsernameError = new System.Windows.Forms.Label();
            this.pbxCenterPanel = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.lblQuestionError = new System.Windows.Forms.Label();
            this.lblNewPasswordError = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnConfirmNewPassword = new System.Windows.Forms.Button();
            this.lblBackLogin = new System.Windows.Forms.LinkLabel();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCenterPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmUsername
            // 
            this.btnConfirmUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConfirmUsername.Location = new System.Drawing.Point(362, 175);
            this.btnConfirmUsername.Name = "btnConfirmUsername";
            this.btnConfirmUsername.Size = new System.Drawing.Size(365, 30);
            this.btnConfirmUsername.TabIndex = 5;
            this.btnConfirmUsername.Text = "Confirm";
            this.btnConfirmUsername.UseVisualStyleBackColor = true;
            this.btnConfirmUsername.Click += new System.EventHandler(this.btnConfirmUsername_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtUsername.Location = new System.Drawing.Point(362, 138);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(0);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(365, 30);
            this.txtUsername.TabIndex = 4;
            // 
            // txtQuestionAnswer
            // 
            this.txtQuestionAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtQuestionAnswer.Location = new System.Drawing.Point(362, 262);
            this.txtQuestionAnswer.Margin = new System.Windows.Forms.Padding(0);
            this.txtQuestionAnswer.Multiline = true;
            this.txtQuestionAnswer.Name = "txtQuestionAnswer";
            this.txtQuestionAnswer.Size = new System.Drawing.Size(365, 30);
            this.txtQuestionAnswer.TabIndex = 8;
            this.txtQuestionAnswer.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // lblSecurityQuestion
            // 
            this.lblSecurityQuestion.BackColor = System.Drawing.Color.Black;
            this.lblSecurityQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSecurityQuestion.ForeColor = System.Drawing.Color.White;
            this.lblSecurityQuestion.Location = new System.Drawing.Point(359, 240);
            this.lblSecurityQuestion.Margin = new System.Windows.Forms.Padding(0);
            this.lblSecurityQuestion.Name = "lblSecurityQuestion";
            this.lblSecurityQuestion.Size = new System.Drawing.Size(365, 20);
            this.lblSecurityQuestion.TabIndex = 9;
            this.lblSecurityQuestion.Text = "Question";
            this.lblSecurityQuestion.Visible = false;
            // 
            // lblUsernameError
            // 
            this.lblUsernameError.BackColor = System.Drawing.Color.Black;
            this.lblUsernameError.ForeColor = System.Drawing.Color.LightCoral;
            this.lblUsernameError.Location = new System.Drawing.Point(394, 211);
            this.lblUsernameError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsernameError.Name = "lblUsernameError";
            this.lblUsernameError.Size = new System.Drawing.Size(300, 24);
            this.lblUsernameError.TabIndex = 12;
            this.lblUsernameError.Text = "CLEAR ON INITIALIZE";
            this.lblUsernameError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxCenterPanel
            // 
            this.pbxCenterPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbxCenterPanel.BackColor = System.Drawing.Color.Black;
            this.pbxCenterPanel.Location = new System.Drawing.Point(344, 61);
            this.pbxCenterPanel.Name = "pbxCenterPanel";
            this.pbxCenterPanel.Size = new System.Drawing.Size(400, 460);
            this.pbxCenterPanel.TabIndex = 22;
            this.pbxCenterPanel.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.Black;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(359, 115);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(365, 20);
            this.lblUsername.TabIndex = 23;
            this.lblUsername.Text = "Username";
            // 
            // btnSubmitAnswer
            // 
            this.btnSubmitAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSubmitAnswer.Location = new System.Drawing.Point(362, 299);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(365, 30);
            this.btnSubmitAnswer.TabIndex = 24;
            this.btnSubmitAnswer.Text = "Submit";
            this.btnSubmitAnswer.UseVisualStyleBackColor = true;
            this.btnSubmitAnswer.Visible = false;
            this.btnSubmitAnswer.Click += new System.EventHandler(this.btnSubmitAnswer_Click);
            // 
            // lblQuestionError
            // 
            this.lblQuestionError.BackColor = System.Drawing.Color.Black;
            this.lblQuestionError.ForeColor = System.Drawing.Color.LightCoral;
            this.lblQuestionError.Location = new System.Drawing.Point(395, 335);
            this.lblQuestionError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuestionError.Name = "lblQuestionError";
            this.lblQuestionError.Size = new System.Drawing.Size(300, 24);
            this.lblQuestionError.TabIndex = 25;
            this.lblQuestionError.Text = "CLEAR ON INITIALIZE";
            this.lblQuestionError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNewPasswordError
            // 
            this.lblNewPasswordError.BackColor = System.Drawing.Color.Black;
            this.lblNewPasswordError.ForeColor = System.Drawing.Color.LightCoral;
            this.lblNewPasswordError.Location = new System.Drawing.Point(395, 454);
            this.lblNewPasswordError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewPasswordError.Name = "lblNewPasswordError";
            this.lblNewPasswordError.Size = new System.Drawing.Size(300, 35);
            this.lblNewPasswordError.TabIndex = 10;
            this.lblNewPasswordError.Text = "CLEAR ON INITIALIZE";
            this.lblNewPasswordError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.BackColor = System.Drawing.Color.Black;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNewPassword.ForeColor = System.Drawing.Color.White;
            this.lblNewPassword.Location = new System.Drawing.Point(359, 365);
            this.lblNewPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(365, 20);
            this.lblNewPassword.TabIndex = 26;
            this.lblNewPassword.Text = "New Password";
            this.lblNewPassword.Visible = false;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtNewPassword.Location = new System.Drawing.Point(362, 386);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewPassword.Multiline = true;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(365, 30);
            this.txtNewPassword.TabIndex = 27;
            this.txtNewPassword.Visible = false;
            // 
            // btnConfirmNewPassword
            // 
            this.btnConfirmNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConfirmNewPassword.Location = new System.Drawing.Point(362, 421);
            this.btnConfirmNewPassword.Name = "btnConfirmNewPassword";
            this.btnConfirmNewPassword.Size = new System.Drawing.Size(365, 30);
            this.btnConfirmNewPassword.TabIndex = 28;
            this.btnConfirmNewPassword.Text = "Confirm";
            this.btnConfirmNewPassword.UseVisualStyleBackColor = true;
            this.btnConfirmNewPassword.Visible = false;
            this.btnConfirmNewPassword.Click += new System.EventHandler(this.btnConfirmNewPassword_Click);
            // 
            // lblBackLogin
            // 
            this.lblBackLogin.AutoSize = true;
            this.lblBackLogin.BackColor = System.Drawing.Color.Black;
            this.lblBackLogin.ForeColor = System.Drawing.Color.White;
            this.lblBackLogin.LinkColor = System.Drawing.Color.LightSteelBlue;
            this.lblBackLogin.Location = new System.Drawing.Point(360, 489);
            this.lblBackLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBackLogin.Name = "lblBackLogin";
            this.lblBackLogin.Size = new System.Drawing.Size(73, 13);
            this.lblBackLogin.TabIndex = 29;
            this.lblBackLogin.TabStop = true;
            this.lblBackLogin.Text = "Back to Login";
            this.lblBackLogin.VisitedLinkColor = System.Drawing.Color.Thistle;
            this.lblBackLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBackLogin_LinkClicked);
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.BackColor = System.Drawing.Color.Black;
            this.lblForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPassword.ForeColor = System.Drawing.Color.White;
            this.lblForgotPassword.Location = new System.Drawing.Point(344, 80);
            this.lblForgotPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(400, 30);
            this.lblForgotPassword.TabIndex = 30;
            this.lblForgotPassword.Text = "Forgot Password";
            this.lblForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::ScrumInsurance.Properties.Resources.shape_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblForgotPassword);
            this.Controls.Add(this.lblBackLogin);
            this.Controls.Add(this.btnConfirmNewPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblQuestionError);
            this.Controls.Add(this.btnSubmitAnswer);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtQuestionAnswer);
            this.Controls.Add(this.lblUsernameError);
            this.Controls.Add(this.lblNewPasswordError);
            this.Controls.Add(this.lblSecurityQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pbxCenterPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ctrlForgotPass";
            this.Size = new System.Drawing.Size(1088, 582);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCenterPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtQuestionAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSecurityQuestion;
        private System.Windows.Forms.Label lblUsernameError;
        private System.Windows.Forms.PictureBox pbxCenterPanel;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnSubmitAnswer;
        private System.Windows.Forms.Label lblQuestionError;
        private System.Windows.Forms.Label lblNewPasswordError;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnConfirmNewPassword;
        private System.Windows.Forms.LinkLabel lblBackLogin;
        private System.Windows.Forms.Label lblForgotPassword;
    }
}
