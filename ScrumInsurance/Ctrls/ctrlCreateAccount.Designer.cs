namespace ScrumInsurance.Ctrls
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
            this.cmbSecurityQuestion = new System.Windows.Forms.ComboBox();
            this.lblBackLogin = new System.Windows.Forms.LinkLabel();
            this.errCreateAccount = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbxTopBorder = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCenterPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCreateAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTopBorder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCreateAccount
            // 
            this.lblCreateAccount.BackColor = System.Drawing.Color.Black;
            this.lblCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAccount.ForeColor = System.Drawing.Color.White;
            this.lblCreateAccount.Location = new System.Drawing.Point(390, 107);
            this.lblCreateAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreateAccount.Name = "lblCreateAccount";
            this.lblCreateAccount.Size = new System.Drawing.Size(300, 30);
            this.lblCreateAccount.TabIndex = 10;
            this.lblCreateAccount.Text = "Create Account";
            this.lblCreateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(180)))), ((int)(((byte)(247)))));
            this.btnCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCreateAccount.Location = new System.Drawing.Point(480, 465);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(120, 30);
            this.btnCreateAccount.TabIndex = 6;
            this.btnCreateAccount.Text = "Enter";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // txtCreateUsername
            // 
            this.txtCreateUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtCreateUsername.Location = new System.Drawing.Point(406, 183);
            this.txtCreateUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreateUsername.Name = "txtCreateUsername";
            this.txtCreateUsername.Size = new System.Drawing.Size(265, 30);
            this.txtCreateUsername.TabIndex = 1;
            this.txtCreateUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtCreateUsername_Validating);
            // 
            // lblCretaeUsername
            // 
            this.lblCretaeUsername.BackColor = System.Drawing.Color.Black;
            this.lblCretaeUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCretaeUsername.ForeColor = System.Drawing.Color.White;
            this.lblCretaeUsername.Location = new System.Drawing.Point(403, 161);
            this.lblCretaeUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCretaeUsername.Name = "lblCretaeUsername";
            this.lblCretaeUsername.Size = new System.Drawing.Size(268, 20);
            this.lblCretaeUsername.TabIndex = 7;
            this.lblCretaeUsername.Text = "Username";
            // 
            // txtCreatePassword
            // 
            this.txtCreatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtCreatePassword.Location = new System.Drawing.Point(406, 258);
            this.txtCreatePassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreatePassword.Name = "txtCreatePassword";
            this.txtCreatePassword.Size = new System.Drawing.Size(265, 30);
            this.txtCreatePassword.TabIndex = 2;
            this.txtCreatePassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtCreatePassword_Validating);
            // 
            // lblCreatePassword
            // 
            this.lblCreatePassword.BackColor = System.Drawing.Color.Black;
            this.lblCreatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCreatePassword.ForeColor = System.Drawing.Color.White;
            this.lblCreatePassword.Location = new System.Drawing.Point(403, 236);
            this.lblCreatePassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreatePassword.Name = "lblCreatePassword";
            this.lblCreatePassword.Size = new System.Drawing.Size(268, 20);
            this.lblCreatePassword.TabIndex = 11;
            this.lblCreatePassword.Text = "Password";
            // 
            // lblSecurityQuestion
            // 
            this.lblSecurityQuestion.BackColor = System.Drawing.Color.Black;
            this.lblSecurityQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSecurityQuestion.ForeColor = System.Drawing.Color.White;
            this.lblSecurityQuestion.Location = new System.Drawing.Point(403, 311);
            this.lblSecurityQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSecurityQuestion.Name = "lblSecurityQuestion";
            this.lblSecurityQuestion.Size = new System.Drawing.Size(268, 20);
            this.lblSecurityQuestion.TabIndex = 15;
            this.lblSecurityQuestion.Text = "Security Question";
            // 
            // txtCreateAnswer
            // 
            this.txtCreateAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtCreateAnswer.Location = new System.Drawing.Point(406, 408);
            this.txtCreateAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreateAnswer.Name = "txtCreateAnswer";
            this.txtCreateAnswer.Size = new System.Drawing.Size(265, 30);
            this.txtCreateAnswer.TabIndex = 5;
            // 
            // lblAnswer
            // 
            this.lblAnswer.BackColor = System.Drawing.Color.Black;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAnswer.ForeColor = System.Drawing.Color.White;
            this.lblAnswer.Location = new System.Drawing.Point(405, 386);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(266, 20);
            this.lblAnswer.TabIndex = 17;
            this.lblAnswer.Text = "Answer";
            // 
            // pbxCenterPanel
            // 
            this.pbxCenterPanel.BackColor = System.Drawing.Color.Black;
            this.pbxCenterPanel.Location = new System.Drawing.Point(390, 89);
            this.pbxCenterPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbxCenterPanel.Name = "pbxCenterPanel";
            this.pbxCenterPanel.Size = new System.Drawing.Size(300, 440);
            this.pbxCenterPanel.TabIndex = 21;
            this.pbxCenterPanel.TabStop = false;
            // 
            // cmbSecurityQuestion
            // 
            this.cmbSecurityQuestion.DropDownHeight = 80;
            this.cmbSecurityQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecurityQuestion.DropDownWidth = 365;
            this.cmbSecurityQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSecurityQuestion.FormattingEnabled = true;
            this.cmbSecurityQuestion.IntegralHeight = false;
            this.cmbSecurityQuestion.ItemHeight = 25;
            this.cmbSecurityQuestion.Items.AddRange(new object[] {
            "What was the name of your first pet?​",
            "In what city were you born?​",
            "What is your mother\'s maiden name?​",
            "What is your father\'s middle name?​",
            "What was your favorite food as a child?​",
            "What is your favorite movie?​",
            "AAAAAAAAAAAAAAAAAAAAAAAAAAAAA"});
            this.cmbSecurityQuestion.Location = new System.Drawing.Point(406, 333);
            this.cmbSecurityQuestion.Margin = new System.Windows.Forms.Padding(0);
            this.cmbSecurityQuestion.Name = "cmbSecurityQuestion";
            this.cmbSecurityQuestion.Size = new System.Drawing.Size(265, 33);
            this.cmbSecurityQuestion.TabIndex = 4;
            this.cmbSecurityQuestion.Enter += new System.EventHandler(this.cmbSecurityQuestion_Enter);
            // 
            // lblBackLogin
            // 
            this.lblBackLogin.AutoSize = true;
            this.lblBackLogin.BackColor = System.Drawing.Color.Black;
            this.lblBackLogin.ForeColor = System.Drawing.Color.White;
            this.lblBackLogin.LinkColor = System.Drawing.Color.LightSteelBlue;
            this.lblBackLogin.Location = new System.Drawing.Point(406, 503);
            this.lblBackLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBackLogin.Name = "lblBackLogin";
            this.lblBackLogin.Size = new System.Drawing.Size(73, 13);
            this.lblBackLogin.TabIndex = 7;
            this.lblBackLogin.TabStop = true;
            this.lblBackLogin.Text = "Back to Login";
            this.lblBackLogin.VisitedLinkColor = System.Drawing.Color.Thistle;
            this.lblBackLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBackLogin_LinkClicked);
            // 
            // errCreateAccount
            // 
            this.errCreateAccount.ContainerControl = this;
            // 
            // pbxTopBorder
            // 
            this.pbxTopBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pbxTopBorder.Location = new System.Drawing.Point(390, 79);
            this.pbxTopBorder.Name = "pbxTopBorder";
            this.pbxTopBorder.Size = new System.Drawing.Size(300, 10);
            this.pbxTopBorder.TabIndex = 64;
            this.pbxTopBorder.TabStop = false;
            // 
            // ctrlCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::ScrumInsurance.Properties.Resources.shape_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pbxTopBorder);
            this.Controls.Add(this.lblBackLogin);
            this.Controls.Add(this.cmbSecurityQuestion);
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
            this.Size = new System.Drawing.Size(1080, 607);
            this.Load += new System.EventHandler(this.ctrlCreateAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCenterPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCreateAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTopBorder)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbSecurityQuestion;
        private System.Windows.Forms.LinkLabel lblBackLogin;
        private System.Windows.Forms.ErrorProvider errCreateAccount;
        private System.Windows.Forms.PictureBox pbxTopBorder;
    }
}
