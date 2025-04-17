namespace ScrumInsurance
{
    partial class ctrlCreateAccount
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
            this.lblCreateAccount = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.txtCreateUsername = new System.Windows.Forms.TextBox();
            this.lblCretaeUsername = new System.Windows.Forms.Label();
            this.txtCreatePassword = new System.Windows.Forms.TextBox();
            this.lblCreatePassword = new System.Windows.Forms.Label();
            this.lblSecurityQuestion = new System.Windows.Forms.Label();
            this.txtCreateAnswer = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.pbxCenterPanel = new System.Windows.Forms.PictureBox();
            this.lblCreateAccountError = new System.Windows.Forms.Label();
            this.cmbSecurityQuestion = new System.Windows.Forms.ComboBox();
            this.lblBackLogin = new System.Windows.Forms.LinkLabel();
            this.errCreateAccount = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCenterPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCreateAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCreateAccount
            // 
            this.lblCreateAccount.BackColor = System.Drawing.Color.Black;
            this.lblCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAccount.ForeColor = System.Drawing.Color.White;
            this.lblCreateAccount.Location = new System.Drawing.Point(313, 90);
            this.lblCreateAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreateAccount.Name = "lblCreateAccount";
            this.lblCreateAccount.Size = new System.Drawing.Size(400, 30);
            this.lblCreateAccount.TabIndex = 10;
            this.lblCreateAccount.Text = "Create Account";
            this.lblCreateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCreateAccount.Location = new System.Drawing.Point(330, 500);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(365, 30);
            this.btnCreateAccount.TabIndex = 7;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // txtCreateUsername
            // 
            this.txtCreateUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtCreateUsername.Location = new System.Drawing.Point(329, 166);
            this.txtCreateUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCreateUsername.Name = "txtCreateUsername";
            this.txtCreateUsername.Size = new System.Drawing.Size(365, 30);
            this.txtCreateUsername.TabIndex = 1;
            // 
            // lblCretaeUsername
            // 
            this.lblCretaeUsername.BackColor = System.Drawing.Color.Black;
            this.lblCretaeUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCretaeUsername.ForeColor = System.Drawing.Color.White;
            this.lblCretaeUsername.Location = new System.Drawing.Point(326, 144);
            this.lblCretaeUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCretaeUsername.Name = "lblCretaeUsername";
            this.lblCretaeUsername.Size = new System.Drawing.Size(365, 20);
            this.lblCretaeUsername.TabIndex = 7;
            this.lblCretaeUsername.Text = "Username";
            // 
            // txtCreatePassword
            // 
            this.txtCreatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtCreatePassword.Location = new System.Drawing.Point(329, 241);
            this.txtCreatePassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCreatePassword.Name = "txtCreatePassword";
            this.txtCreatePassword.Size = new System.Drawing.Size(365, 30);
            this.txtCreatePassword.TabIndex = 2;
            this.txtCreatePassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtCreatePassword_Validating);
            // 
            // lblCreatePassword
            // 
            this.lblCreatePassword.BackColor = System.Drawing.Color.Black;
            this.lblCreatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCreatePassword.ForeColor = System.Drawing.Color.White;
            this.lblCreatePassword.Location = new System.Drawing.Point(326, 219);
            this.lblCreatePassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreatePassword.Name = "lblCreatePassword";
            this.lblCreatePassword.Size = new System.Drawing.Size(365, 20);
            this.lblCreatePassword.TabIndex = 11;
            this.lblCreatePassword.Text = "Password";
            // 
            // lblSecurityQuestion
            // 
            this.lblSecurityQuestion.BackColor = System.Drawing.Color.Black;
            this.lblSecurityQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSecurityQuestion.ForeColor = System.Drawing.Color.White;
            this.lblSecurityQuestion.Location = new System.Drawing.Point(326, 294);
            this.lblSecurityQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSecurityQuestion.Name = "lblSecurityQuestion";
            this.lblSecurityQuestion.Size = new System.Drawing.Size(365, 20);
            this.lblSecurityQuestion.TabIndex = 15;
            this.lblSecurityQuestion.Text = "Security Question";
            // 
            // txtCreateAnswer
            // 
            this.txtCreateAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtCreateAnswer.Location = new System.Drawing.Point(329, 391);
            this.txtCreateAnswer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCreateAnswer.Name = "txtCreateAnswer";
            this.txtCreateAnswer.Size = new System.Drawing.Size(365, 30);
            this.txtCreateAnswer.TabIndex = 5;
            // 
            // lblAnswer
            // 
            this.lblAnswer.BackColor = System.Drawing.Color.Black;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAnswer.ForeColor = System.Drawing.Color.White;
            this.lblAnswer.Location = new System.Drawing.Point(328, 369);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(365, 20);
            this.lblAnswer.TabIndex = 17;
            this.lblAnswer.Text = "Answer";
            // 
            // pbxCenterPanel
            // 
            this.pbxCenterPanel.BackColor = System.Drawing.Color.Black;
            this.pbxCenterPanel.Location = new System.Drawing.Point(313, 72);
            this.pbxCenterPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbxCenterPanel.Name = "pbxCenterPanel";
            this.pbxCenterPanel.Size = new System.Drawing.Size(400, 480);
            this.pbxCenterPanel.TabIndex = 21;
            this.pbxCenterPanel.TabStop = false;
            // 
            // lblCreateAccountError
            // 
            this.lblCreateAccountError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCreateAccountError.BackColor = System.Drawing.Color.Black;
            this.lblCreateAccountError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblCreateAccountError.ForeColor = System.Drawing.Color.LightCoral;
            this.lblCreateAccountError.Location = new System.Drawing.Point(315, 441);
            this.lblCreateAccountError.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCreateAccountError.Name = "lblCreateAccountError";
            this.lblCreateAccountError.Size = new System.Drawing.Size(396, 30);
            this.lblCreateAccountError.TabIndex = 22;
            this.lblCreateAccountError.Text = "CLEAR ON INITIALIZE";
            this.lblCreateAccountError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbSecurityQuestion
            // 
            this.cmbSecurityQuestion.DropDownHeight = 80;
            this.cmbSecurityQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecurityQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSecurityQuestion.FormattingEnabled = true;
            this.cmbSecurityQuestion.IntegralHeight = false;
            this.cmbSecurityQuestion.Items.AddRange(new object[] {
            "What was the name of your first pet?​",
            "In what city were you born?​",
            "What is your mother\'s maiden name?​",
            "What is your father\'s middle name?​",
            "What was your favorite food as a child?​",
            "What is your favorite movie?​"});
            this.cmbSecurityQuestion.Location = new System.Drawing.Point(329, 316);
            this.cmbSecurityQuestion.Margin = new System.Windows.Forms.Padding(0);
            this.cmbSecurityQuestion.Name = "cmbSecurityQuestion";
            this.cmbSecurityQuestion.Size = new System.Drawing.Size(365, 33);
            this.cmbSecurityQuestion.TabIndex = 4;
            // 
            // lblBackLogin
            // 
            this.lblBackLogin.AutoSize = true;
            this.lblBackLogin.BackColor = System.Drawing.Color.Black;
            this.lblBackLogin.ForeColor = System.Drawing.Color.White;
            this.lblBackLogin.LinkColor = System.Drawing.Color.LightSteelBlue;
            this.lblBackLogin.Location = new System.Drawing.Point(329, 473);
            this.lblBackLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBackLogin.Name = "lblBackLogin";
            this.lblBackLogin.Size = new System.Drawing.Size(73, 13);
            this.lblBackLogin.TabIndex = 6;
            this.lblBackLogin.TabStop = true;
            this.lblBackLogin.Text = "Back to Login";
            this.lblBackLogin.VisitedLinkColor = System.Drawing.Color.Thistle;
            this.lblBackLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBackLogin_LinkClicked);
            // 
            // errCreateAccount
            // 
            this.errCreateAccount.ContainerControl = this;
            // 
            // ctrlCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::ScrumInsurance.Properties.Resources.shape_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblBackLogin);
            this.Controls.Add(this.cmbSecurityQuestion);
            this.Controls.Add(this.lblCreateAccountError);
            this.Controls.Add(this.txtCreateAnswer);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblSecurityQuestion);
            this.Controls.Add(this.txtCreatePassword);
            this.Controls.Add(this.lblCreatePassword);
            this.Controls.Add(this.lblCreateAccount);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.txtCreateUsername);
            this.Controls.Add(this.lblCretaeUsername);
            this.Controls.Add(this.pbxCenterPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ctrlCreateAccount";
            this.Size = new System.Drawing.Size(1088, 625);
            this.Load += new System.EventHandler(this.ctrlCreateAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCenterPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCreateAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateAccount;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.TextBox txtCreateUsername;
        private System.Windows.Forms.Label lblCretaeUsername;
        private System.Windows.Forms.TextBox txtCreatePassword;
        private System.Windows.Forms.Label lblCreatePassword;
        private System.Windows.Forms.Label lblSecurityQuestion;
        private System.Windows.Forms.TextBox txtCreateAnswer;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.PictureBox pbxCenterPanel;
        private System.Windows.Forms.Label lblCreateAccountError;
        private System.Windows.Forms.ComboBox cmbSecurityQuestion;
        private System.Windows.Forms.LinkLabel lblBackLogin;
        private System.Windows.Forms.ErrorProvider errCreateAccount;
    }
}
