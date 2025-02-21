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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCreateAccountError = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCreateAccount
            // 
            this.lblCreateAccount.AutoSize = true;
            this.lblCreateAccount.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblCreateAccount.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAccount.Location = new System.Drawing.Point(93, 43);
            this.lblCreateAccount.Name = "lblCreateAccount";
            this.lblCreateAccount.Size = new System.Drawing.Size(196, 33);
            this.lblCreateAccount.TabIndex = 10;
            this.lblCreateAccount.Text = "Create Account";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(110, 639);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(501, 57);
            this.btnCreateAccount.TabIndex = 9;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // txtCreateUsername
            // 
            this.txtCreateUsername.Location = new System.Drawing.Point(112, 165);
            this.txtCreateUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreateUsername.Name = "txtCreateUsername";
            this.txtCreateUsername.Size = new System.Drawing.Size(497, 22);
            this.txtCreateUsername.TabIndex = 8;
            // 
            // lblCretaeUsername
            // 
            this.lblCretaeUsername.AutoSize = true;
            this.lblCretaeUsername.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblCretaeUsername.Location = new System.Drawing.Point(104, 126);
            this.lblCretaeUsername.Name = "lblCretaeUsername";
            this.lblCretaeUsername.Size = new System.Drawing.Size(70, 16);
            this.lblCretaeUsername.TabIndex = 7;
            this.lblCretaeUsername.Text = "Username";
            // 
            // txtCreatePassword
            // 
            this.txtCreatePassword.Location = new System.Drawing.Point(112, 267);
            this.txtCreatePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreatePassword.Name = "txtCreatePassword";
            this.txtCreatePassword.Size = new System.Drawing.Size(497, 22);
            this.txtCreatePassword.TabIndex = 12;
            // 
            // lblCreatePassword
            // 
            this.lblCreatePassword.AutoSize = true;
            this.lblCreatePassword.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblCreatePassword.Location = new System.Drawing.Point(107, 228);
            this.lblCreatePassword.Name = "lblCreatePassword";
            this.lblCreatePassword.Size = new System.Drawing.Size(67, 16);
            this.lblCreatePassword.TabIndex = 11;
            this.lblCreatePassword.Text = "Password";
            // 
            // txtCreateEmail
            // 
            this.txtCreateEmail.Location = new System.Drawing.Point(112, 372);
            this.txtCreateEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreateEmail.Name = "txtCreateEmail";
            this.txtCreateEmail.Size = new System.Drawing.Size(497, 22);
            this.txtCreateEmail.TabIndex = 14;
            // 
            // lblCreateEmail
            // 
            this.lblCreateEmail.AutoSize = true;
            this.lblCreateEmail.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblCreateEmail.Location = new System.Drawing.Point(104, 330);
            this.lblCreateEmail.Name = "lblCreateEmail";
            this.lblCreateEmail.Size = new System.Drawing.Size(41, 16);
            this.lblCreateEmail.TabIndex = 13;
            this.lblCreateEmail.Text = "Email";
            // 
            // txtCreateQuestion
            // 
            this.txtCreateQuestion.Location = new System.Drawing.Point(110, 467);
            this.txtCreateQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreateQuestion.Multiline = true;
            this.txtCreateQuestion.Name = "txtCreateQuestion";
            this.txtCreateQuestion.Size = new System.Drawing.Size(497, 53);
            this.txtCreateQuestion.TabIndex = 16;
            // 
            // lblSecurityQuestion
            // 
            this.lblSecurityQuestion.AutoSize = true;
            this.lblSecurityQuestion.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblSecurityQuestion.Location = new System.Drawing.Point(107, 430);
            this.lblSecurityQuestion.Name = "lblSecurityQuestion";
            this.lblSecurityQuestion.Size = new System.Drawing.Size(111, 16);
            this.lblSecurityQuestion.TabIndex = 15;
            this.lblSecurityQuestion.Text = "Security Question";
            // 
            // txtCreateAnswer
            // 
            this.txtCreateAnswer.Location = new System.Drawing.Point(107, 560);
            this.txtCreateAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreateAnswer.Multiline = true;
            this.txtCreateAnswer.Name = "txtCreateAnswer";
            this.txtCreateAnswer.Size = new System.Drawing.Size(497, 53);
            this.txtCreateAnswer.TabIndex = 18;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblAnswer.Location = new System.Drawing.Point(104, 530);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(51, 16);
            this.lblAnswer.TabIndex = 17;
            this.lblAnswer.Text = "Answer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Location = new System.Drawing.Point(195, 63);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 457);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // lblCreateAccountError
            // 
            this.lblCreateAccountError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCreateAccountError.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblCreateAccountError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblCreateAccountError.Location = new System.Drawing.Point(110, 728);
            this.lblCreateAccountError.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCreateAccountError.Name = "lblCreateAccountError";
            this.lblCreateAccountError.Size = new System.Drawing.Size(501, 64);
            this.lblCreateAccountError.TabIndex = 22;
            this.lblCreateAccountError.Text = "CLEAR ON INITIALIZE";
            this.lblCreateAccountError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(603, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 46);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ctrlCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblCreateAccountError);
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
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ctrlCreateAccount";
            this.Size = new System.Drawing.Size(755, 832);
            this.Load += new System.EventHandler(this.ctrlCreateAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCreateAccountError;
        private System.Windows.Forms.Button btnBack;
    }
}
