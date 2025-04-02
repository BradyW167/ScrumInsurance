namespace ScrumInsurance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlForgotPass));
            this.btn_confirmEmailForgotPassword = new System.Windows.Forms.Button();
            this.txtbx_emailForgotPassword = new System.Windows.Forms.TextBox();
            this.lbl_enterEmailForgotPassword = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtForgotPasswordAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblForgotPasswordQuestion = new System.Windows.Forms.Label();
            this.lblForgotPasswordQuestionError = new System.Windows.Forms.Label();
            this.btnForgotPasswordSubmit = new System.Windows.Forms.Button();
            this.lblForgotPasswordEmailError = new System.Windows.Forms.Label();
            this.lblForgotPasswordNewPassword = new System.Windows.Forms.Label();
            this.txtForgotPasswordNewPassword = new System.Windows.Forms.TextBox();
            this.btnForgotPasswordNewPassword = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pbxCenterPanel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCenterPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_confirmEmailForgotPassword
            // 
            this.btn_confirmEmailForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_confirmEmailForgotPassword.Location = new System.Drawing.Point(552, 213);
            this.btn_confirmEmailForgotPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_confirmEmailForgotPassword.Name = "btn_confirmEmailForgotPassword";
            this.btn_confirmEmailForgotPassword.Size = new System.Drawing.Size(335, 37);
            this.btn_confirmEmailForgotPassword.TabIndex = 5;
            this.btn_confirmEmailForgotPassword.Text = "Confirm";
            this.btn_confirmEmailForgotPassword.UseVisualStyleBackColor = true;
            this.btn_confirmEmailForgotPassword.Click += new System.EventHandler(this.btn_confirmEmailForgotPassword_Click);
            // 
            // txtbx_emailForgotPassword
            // 
            this.txtbx_emailForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtbx_emailForgotPassword.Location = new System.Drawing.Point(552, 170);
            this.txtbx_emailForgotPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbx_emailForgotPassword.Name = "txtbx_emailForgotPassword";
            this.txtbx_emailForgotPassword.Size = new System.Drawing.Size(333, 36);
            this.txtbx_emailForgotPassword.TabIndex = 4;
            // 
            // lbl_enterEmailForgotPassword
            // 
            this.lbl_enterEmailForgotPassword.BackColor = System.Drawing.Color.Black;
            this.lbl_enterEmailForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_enterEmailForgotPassword.ForeColor = System.Drawing.Color.White;
            this.lbl_enterEmailForgotPassword.Location = new System.Drawing.Point(520, 133);
            this.lbl_enterEmailForgotPassword.Name = "lbl_enterEmailForgotPassword";
            this.lbl_enterEmailForgotPassword.Size = new System.Drawing.Size(400, 43);
            this.lbl_enterEmailForgotPassword.TabIndex = 3;
            this.lbl_enterEmailForgotPassword.Text = "Enter Email:";
            this.lbl_enterEmailForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(520, 59);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 43);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Forgot Password";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtForgotPasswordAnswer
            // 
            this.txtForgotPasswordAnswer.Location = new System.Drawing.Point(552, 379);
            this.txtForgotPasswordAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtForgotPasswordAnswer.Multiline = true;
            this.txtForgotPasswordAnswer.Name = "txtForgotPasswordAnswer";
            this.txtForgotPasswordAnswer.Size = new System.Drawing.Size(333, 36);
            this.txtForgotPasswordAnswer.TabIndex = 8;
            this.txtForgotPasswordAnswer.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 7;
            // 
            // lblForgotPasswordQuestion
            // 
            this.lblForgotPasswordQuestion.BackColor = System.Drawing.Color.Black;
            this.lblForgotPasswordQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblForgotPasswordQuestion.ForeColor = System.Drawing.Color.White;
            this.lblForgotPasswordQuestion.Location = new System.Drawing.Point(520, 305);
            this.lblForgotPasswordQuestion.Name = "lblForgotPasswordQuestion";
            this.lblForgotPasswordQuestion.Size = new System.Drawing.Size(400, 43);
            this.lblForgotPasswordQuestion.TabIndex = 9;
            this.lblForgotPasswordQuestion.Text = "Question";
            this.lblForgotPasswordQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblForgotPasswordQuestion.Visible = false;
            // 
            // lblForgotPasswordQuestionError
            // 
            this.lblForgotPasswordQuestionError.BackColor = System.Drawing.Color.Black;
            this.lblForgotPasswordQuestionError.ForeColor = System.Drawing.Color.LightCoral;
            this.lblForgotPasswordQuestionError.Location = new System.Drawing.Point(520, 471);
            this.lblForgotPasswordQuestionError.Name = "lblForgotPasswordQuestionError";
            this.lblForgotPasswordQuestionError.Size = new System.Drawing.Size(400, 43);
            this.lblForgotPasswordQuestionError.TabIndex = 10;
            this.lblForgotPasswordQuestionError.Text = "CLEAR ON INITIALIZE";
            this.lblForgotPasswordQuestionError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnForgotPasswordSubmit
            // 
            this.btnForgotPasswordSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnForgotPasswordSubmit.Location = new System.Drawing.Point(552, 422);
            this.btnForgotPasswordSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnForgotPasswordSubmit.Name = "btnForgotPasswordSubmit";
            this.btnForgotPasswordSubmit.Size = new System.Drawing.Size(335, 37);
            this.btnForgotPasswordSubmit.TabIndex = 11;
            this.btnForgotPasswordSubmit.Text = "Submit";
            this.btnForgotPasswordSubmit.UseVisualStyleBackColor = true;
            this.btnForgotPasswordSubmit.Visible = false;
            this.btnForgotPasswordSubmit.Click += new System.EventHandler(this.btnForgotPasswordSubmit_Click);
            // 
            // lblForgotPasswordEmailError
            // 
            this.lblForgotPasswordEmailError.BackColor = System.Drawing.Color.Black;
            this.lblForgotPasswordEmailError.ForeColor = System.Drawing.Color.LightCoral;
            this.lblForgotPasswordEmailError.Location = new System.Drawing.Point(520, 262);
            this.lblForgotPasswordEmailError.Name = "lblForgotPasswordEmailError";
            this.lblForgotPasswordEmailError.Size = new System.Drawing.Size(400, 43);
            this.lblForgotPasswordEmailError.TabIndex = 12;
            this.lblForgotPasswordEmailError.Text = "CLEAR ON INITIALIZE";
            this.lblForgotPasswordEmailError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblForgotPasswordNewPassword
            // 
            this.lblForgotPasswordNewPassword.BackColor = System.Drawing.Color.Black;
            this.lblForgotPasswordNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblForgotPasswordNewPassword.ForeColor = System.Drawing.Color.White;
            this.lblForgotPasswordNewPassword.Location = new System.Drawing.Point(520, 515);
            this.lblForgotPasswordNewPassword.Name = "lblForgotPasswordNewPassword";
            this.lblForgotPasswordNewPassword.Size = new System.Drawing.Size(400, 43);
            this.lblForgotPasswordNewPassword.TabIndex = 14;
            this.lblForgotPasswordNewPassword.Text = "New Password:";
            this.lblForgotPasswordNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblForgotPasswordNewPassword.Visible = false;
            // 
            // txtForgotPasswordNewPassword
            // 
            this.txtForgotPasswordNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtForgotPasswordNewPassword.Location = new System.Drawing.Point(552, 551);
            this.txtForgotPasswordNewPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtForgotPasswordNewPassword.Name = "txtForgotPasswordNewPassword";
            this.txtForgotPasswordNewPassword.Size = new System.Drawing.Size(333, 36);
            this.txtForgotPasswordNewPassword.TabIndex = 13;
            this.txtForgotPasswordNewPassword.Visible = false;
            // 
            // btnForgotPasswordNewPassword
            // 
            this.btnForgotPasswordNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnForgotPasswordNewPassword.Location = new System.Drawing.Point(552, 595);
            this.btnForgotPasswordNewPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnForgotPasswordNewPassword.Name = "btnForgotPasswordNewPassword";
            this.btnForgotPasswordNewPassword.Size = new System.Drawing.Size(335, 37);
            this.btnForgotPasswordNewPassword.TabIndex = 15;
            this.btnForgotPasswordNewPassword.Text = "Confirm";
            this.btnForgotPasswordNewPassword.UseVisualStyleBackColor = true;
            this.btnForgotPasswordNewPassword.Visible = false;
            this.btnForgotPasswordNewPassword.Click += new System.EventHandler(this.btnForgotPasswordNewPassword_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBack.Location = new System.Drawing.Point(552, 638);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(335, 37);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Return";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbxCenterPanel
            // 
            this.pbxCenterPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbxCenterPanel.BackColor = System.Drawing.Color.Black;
            this.pbxCenterPanel.Location = new System.Drawing.Point(520, 38);
            this.pbxCenterPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxCenterPanel.Name = "pbxCenterPanel";
            this.pbxCenterPanel.Size = new System.Drawing.Size(400, 677);
            this.pbxCenterPanel.TabIndex = 22;
            this.pbxCenterPanel.TabStop = false;
            // 
            // ctrlForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.txtForgotPasswordNewPassword);
            this.Controls.Add(this.txtForgotPasswordAnswer);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnForgotPasswordNewPassword);
            this.Controls.Add(this.lblForgotPasswordNewPassword);
            this.Controls.Add(this.lblForgotPasswordEmailError);
            this.Controls.Add(this.btnForgotPasswordSubmit);
            this.Controls.Add(this.lblForgotPasswordQuestionError);
            this.Controls.Add(this.lblForgotPasswordQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btn_confirmEmailForgotPassword);
            this.Controls.Add(this.txtbx_emailForgotPassword);
            this.Controls.Add(this.lbl_enterEmailForgotPassword);
            this.Controls.Add(this.pbxCenterPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ctrlForgotPass";
            this.Size = new System.Drawing.Size(1440, 747);
            this.Load += new System.EventHandler(this.ctrlForgotPass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCenterPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_confirmEmailForgotPassword;
        private System.Windows.Forms.TextBox txtbx_emailForgotPassword;
        private System.Windows.Forms.Label lbl_enterEmailForgotPassword;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtForgotPasswordAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblForgotPasswordQuestion;
        private System.Windows.Forms.Label lblForgotPasswordQuestionError;
        private System.Windows.Forms.Button btnForgotPasswordSubmit;
        private System.Windows.Forms.Label lblForgotPasswordEmailError;
        private System.Windows.Forms.Label lblForgotPasswordNewPassword;
        private System.Windows.Forms.TextBox txtForgotPasswordNewPassword;
        private System.Windows.Forms.Button btnForgotPasswordNewPassword;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pbxCenterPanel;
    }
}
