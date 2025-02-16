namespace WebBrowserGitHubDemo
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
            this.lblCreateAccount = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.txtCreateUsername = new System.Windows.Forms.TextBox();
            this.lblCretaeUsername = new System.Windows.Forms.Label();
            this.txtCreatePassword = new System.Windows.Forms.TextBox();
            this.lblCreatePassword = new System.Windows.Forms.Label();
            this.txtCreateEmail = new System.Windows.Forms.TextBox();
            this.lblCreateEmail = new System.Windows.Forms.Label();
            this.txtCreateQuestion = new System.Windows.Forms.TextBox();
            this.lblSecurityQuestion = new System.Windows.Forms.Label();
            this.txtCreateAnswer = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCreateAccount
            // 
            this.lblCreateAccount.AutoSize = true;
            this.lblCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCreateAccount.Location = new System.Drawing.Point(-4, 35);
            this.lblCreateAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreateAccount.Name = "lblCreateAccount";
            this.lblCreateAccount.Size = new System.Drawing.Size(148, 25);
            this.lblCreateAccount.TabIndex = 10;
            this.lblCreateAccount.Text = "Create Account";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(121, 264);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(101, 23);
            this.btnCreateAccount.TabIndex = 9;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // txtCreateUsername
            // 
            this.txtCreateUsername.Location = new System.Drawing.Point(1, 92);
            this.txtCreateUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreateUsername.Name = "txtCreateUsername";
            this.txtCreateUsername.Size = new System.Drawing.Size(68, 20);
            this.txtCreateUsername.TabIndex = 8;
            // 
            // lblCretaeUsername
            // 
            this.lblCretaeUsername.AutoSize = true;
            this.lblCretaeUsername.Location = new System.Drawing.Point(-1, 78);
            this.lblCretaeUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCretaeUsername.Name = "lblCretaeUsername";
            this.lblCretaeUsername.Size = new System.Drawing.Size(55, 13);
            this.lblCretaeUsername.TabIndex = 7;
            this.lblCretaeUsername.Text = "Username";
            // 
            // txtCreatePassword
            // 
            this.txtCreatePassword.Location = new System.Drawing.Point(75, 92);
            this.txtCreatePassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreatePassword.Name = "txtCreatePassword";
            this.txtCreatePassword.Size = new System.Drawing.Size(68, 20);
            this.txtCreatePassword.TabIndex = 12;
            // 
            // lblCreatePassword
            // 
            this.lblCreatePassword.AutoSize = true;
            this.lblCreatePassword.Location = new System.Drawing.Point(73, 78);
            this.lblCreatePassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreatePassword.Name = "lblCreatePassword";
            this.lblCreatePassword.Size = new System.Drawing.Size(53, 13);
            this.lblCreatePassword.TabIndex = 11;
            this.lblCreatePassword.Text = "Password";
            // 
            // txtCreateEmail
            // 
            this.txtCreateEmail.Location = new System.Drawing.Point(157, 92);
            this.txtCreateEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreateEmail.Name = "txtCreateEmail";
            this.txtCreateEmail.Size = new System.Drawing.Size(127, 20);
            this.txtCreateEmail.TabIndex = 14;
            // 
            // lblCreateEmail
            // 
            this.lblCreateEmail.AutoSize = true;
            this.lblCreateEmail.Location = new System.Drawing.Point(155, 78);
            this.lblCreateEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreateEmail.Name = "lblCreateEmail";
            this.lblCreateEmail.Size = new System.Drawing.Size(32, 13);
            this.lblCreateEmail.TabIndex = 13;
            this.lblCreateEmail.Text = "Email";
            // 
            // txtCreateQuestion
            // 
            this.txtCreateQuestion.Location = new System.Drawing.Point(4, 139);
            this.txtCreateQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreateQuestion.Name = "txtCreateQuestion";
            this.txtCreateQuestion.Size = new System.Drawing.Size(326, 20);
            this.txtCreateQuestion.TabIndex = 16;
            // 
            // lblSecurityQuestion
            // 
            this.lblSecurityQuestion.AutoSize = true;
            this.lblSecurityQuestion.Location = new System.Drawing.Point(2, 125);
            this.lblSecurityQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSecurityQuestion.Name = "lblSecurityQuestion";
            this.lblSecurityQuestion.Size = new System.Drawing.Size(90, 13);
            this.lblSecurityQuestion.TabIndex = 15;
            this.lblSecurityQuestion.Text = "Security Question";
            // 
            // txtCreateAnswer
            // 
            this.txtCreateAnswer.Location = new System.Drawing.Point(4, 189);
            this.txtCreateAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreateAnswer.Name = "txtCreateAnswer";
            this.txtCreateAnswer.Size = new System.Drawing.Size(326, 20);
            this.txtCreateAnswer.TabIndex = 18;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(2, 175);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(42, 13);
            this.lblAnswer.TabIndex = 17;
            this.lblAnswer.Text = "Answer";
            // 
            // ctrlCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCreateAnswer);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtCreateQuestion);
            this.Controls.Add(this.lblSecurityQuestion);
            this.Controls.Add(this.txtCreateEmail);
            this.Controls.Add(this.lblCreateEmail);
            this.Controls.Add(this.txtCreatePassword);
            this.Controls.Add(this.lblCreatePassword);
            this.Controls.Add(this.lblCreateAccount);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.txtCreateUsername);
            this.Controls.Add(this.lblCretaeUsername);
            this.Name = "ctrlCreateAccount";
            this.Size = new System.Drawing.Size(362, 290);
            this.Load += new System.EventHandler(this.ctrlCreateAccount_Load);
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
        private System.Windows.Forms.TextBox txtCreateEmail;
        private System.Windows.Forms.Label lblCreateEmail;
        private System.Windows.Forms.TextBox txtCreateQuestion;
        private System.Windows.Forms.Label lblSecurityQuestion;
        private System.Windows.Forms.TextBox txtCreateAnswer;
        private System.Windows.Forms.Label lblAnswer;
    }
}
