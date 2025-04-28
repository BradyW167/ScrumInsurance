namespace ScrumInsurance.Ctrls
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
            this.components = new System.ComponentModel.Container();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtQuestionAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSecurityQuestion = new System.Windows.Forms.Label();
            this.pbxCenterBackground = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnConfirmNewPassword = new System.Windows.Forms.Button();
            this.lblBackLogin = new System.Windows.Forms.LinkLabel();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.txtConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmNewPassword = new System.Windows.Forms.Label();
            this.errForgotPass = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbxTopBorder = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCenterBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errForgotPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTopBorder)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtUsername.Location = new System.Drawing.Point(410, 193);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(0);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(265, 30);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // txtQuestionAnswer
            // 
            this.txtQuestionAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtQuestionAnswer.Location = new System.Drawing.Point(410, 268);
            this.txtQuestionAnswer.Margin = new System.Windows.Forms.Padding(0);
            this.txtQuestionAnswer.Multiline = true;
            this.txtQuestionAnswer.Name = "txtQuestionAnswer";
            this.txtQuestionAnswer.Size = new System.Drawing.Size(265, 30);
            this.txtQuestionAnswer.TabIndex = 3;
            this.txtQuestionAnswer.Visible = false;
            this.txtQuestionAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuestionAnswer_KeyDown);
            this.txtQuestionAnswer.Validating += new System.ComponentModel.CancelEventHandler(this.txtQuestionAnswer_Validating);
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
            this.lblSecurityQuestion.Location = new System.Drawing.Point(407, 248);
            this.lblSecurityQuestion.Margin = new System.Windows.Forms.Padding(0);
            this.lblSecurityQuestion.Name = "lblSecurityQuestion";
            this.lblSecurityQuestion.Size = new System.Drawing.Size(283, 20);
            this.lblSecurityQuestion.TabIndex = 9;
            this.lblSecurityQuestion.Text = "Question";
            this.lblSecurityQuestion.Visible = false;
            // 
            // pbxCenterBackground
            // 
            this.pbxCenterBackground.BackColor = System.Drawing.Color.Black;
            this.pbxCenterBackground.Location = new System.Drawing.Point(390, 89);
            this.pbxCenterBackground.Name = "pbxCenterBackground";
            this.pbxCenterBackground.Size = new System.Drawing.Size(300, 440);
            this.pbxCenterBackground.TabIndex = 22;
            this.pbxCenterBackground.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.Black;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(407, 173);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(268, 20);
            this.lblUsername.TabIndex = 23;
            this.lblUsername.Text = "Username";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.BackColor = System.Drawing.Color.Black;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNewPassword.ForeColor = System.Drawing.Color.White;
            this.lblNewPassword.Location = new System.Drawing.Point(407, 323);
            this.lblNewPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(268, 20);
            this.lblNewPassword.TabIndex = 26;
            this.lblNewPassword.Text = "New Password";
            this.lblNewPassword.Visible = false;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtNewPassword.Location = new System.Drawing.Point(410, 343);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewPassword.Multiline = true;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(265, 30);
            this.txtNewPassword.TabIndex = 5;
            this.txtNewPassword.Visible = false;
            this.txtNewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewPassword_KeyDown);
            this.txtNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewPassword_Validating);
            // 
            // btnConfirmNewPassword
            // 
            this.btnConfirmNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(180)))), ((int)(((byte)(247)))));
            this.btnConfirmNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConfirmNewPassword.Location = new System.Drawing.Point(480, 465);
            this.btnConfirmNewPassword.Name = "btnConfirmNewPassword";
            this.btnConfirmNewPassword.Size = new System.Drawing.Size(120, 30);
            this.btnConfirmNewPassword.TabIndex = 7;
            this.btnConfirmNewPassword.Text = "Enter";
            this.btnConfirmNewPassword.UseVisualStyleBackColor = false;
            this.btnConfirmNewPassword.Visible = false;
            this.btnConfirmNewPassword.Click += new System.EventHandler(this.btnConfirmNewPassword_Click);
            // 
            // lblBackLogin
            // 
            this.lblBackLogin.AutoSize = true;
            this.lblBackLogin.BackColor = System.Drawing.Color.Black;
            this.lblBackLogin.ForeColor = System.Drawing.Color.White;
            this.lblBackLogin.LinkColor = System.Drawing.Color.LightSteelBlue;
            this.lblBackLogin.Location = new System.Drawing.Point(400, 505);
            this.lblBackLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBackLogin.Name = "lblBackLogin";
            this.lblBackLogin.Size = new System.Drawing.Size(73, 13);
            this.lblBackLogin.TabIndex = 8;
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
            this.lblForgotPassword.Location = new System.Drawing.Point(390, 107);
            this.lblForgotPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(300, 30);
            this.lblForgotPassword.TabIndex = 30;
            this.lblForgotPassword.Text = "Forgot Password";
            this.lblForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtConfirmNewPassword
            // 
            this.txtConfirmNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(410, 401);
            this.txtConfirmNewPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmNewPassword.Multiline = true;
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(265, 30);
            this.txtConfirmNewPassword.TabIndex = 6;
            this.txtConfirmNewPassword.Visible = false;
            this.txtConfirmNewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConfirmNewPassword_KeyDown);
            this.txtConfirmNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmNewPassword_Validating);
            // 
            // lblConfirmNewPassword
            // 
            this.lblConfirmNewPassword.BackColor = System.Drawing.Color.Black;
            this.lblConfirmNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblConfirmNewPassword.ForeColor = System.Drawing.Color.White;
            this.lblConfirmNewPassword.Location = new System.Drawing.Point(407, 381);
            this.lblConfirmNewPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            this.lblConfirmNewPassword.Size = new System.Drawing.Size(268, 20);
            this.lblConfirmNewPassword.TabIndex = 32;
            this.lblConfirmNewPassword.Text = "Confirm Password";
            this.lblConfirmNewPassword.Visible = false;
            // 
            // errForgotPass
            // 
            this.errForgotPass.ContainerControl = this;
            // 
            // pbxTopBorder
            // 
            this.pbxTopBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pbxTopBorder.Location = new System.Drawing.Point(390, 79);
            this.pbxTopBorder.Name = "pbxTopBorder";
            this.pbxTopBorder.Size = new System.Drawing.Size(300, 10);
            this.pbxTopBorder.TabIndex = 65;
            this.pbxTopBorder.TabStop = false;
            // 
            // ctrlForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::ScrumInsurance.Properties.Resources.shape_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.pbxTopBorder);
            this.Controls.Add(this.lblConfirmNewPassword);
            this.Controls.Add(this.txtConfirmNewPassword);
            this.Controls.Add(this.lblForgotPassword);
            this.Controls.Add(this.lblBackLogin);
            this.Controls.Add(this.btnConfirmNewPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtQuestionAnswer);
            this.Controls.Add(this.lblSecurityQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pbxCenterBackground);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ctrlForgotPass";
            this.Size = new System.Drawing.Size(1080, 607);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCenterBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errForgotPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTopBorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtQuestionAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSecurityQuestion;
        private System.Windows.Forms.PictureBox pbxCenterBackground;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnConfirmNewPassword;
        private System.Windows.Forms.LinkLabel lblBackLogin;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.TextBox txtConfirmNewPassword;
        private System.Windows.Forms.Label lblConfirmNewPassword;
        private System.Windows.Forms.ErrorProvider errForgotPass;
        private System.Windows.Forms.PictureBox pbxTopBorder;
    }
}
