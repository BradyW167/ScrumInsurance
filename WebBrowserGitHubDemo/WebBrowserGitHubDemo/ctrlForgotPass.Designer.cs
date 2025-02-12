namespace WebBrowserGitHubDemo
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
            this.btn_confirmEmailForgotPassword = new System.Windows.Forms.Button();
            this.txtbx_emailForgotPassword = new System.Windows.Forms.TextBox();
            this.lbl_enterEmailForgotPassword = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtForgotPasswordAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblForgotPasswordQuestion = new System.Windows.Forms.Label();
            this.lblForgotPasswordError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_confirmEmailForgotPassword
            // 
            this.btn_confirmEmailForgotPassword.Location = new System.Drawing.Point(232, 77);
            this.btn_confirmEmailForgotPassword.Name = "btn_confirmEmailForgotPassword";
            this.btn_confirmEmailForgotPassword.Size = new System.Drawing.Size(75, 23);
            this.btn_confirmEmailForgotPassword.TabIndex = 5;
            this.btn_confirmEmailForgotPassword.Text = "Confirm";
            this.btn_confirmEmailForgotPassword.UseVisualStyleBackColor = true;
            // 
            // txtbx_emailForgotPassword
            // 
            this.txtbx_emailForgotPassword.Location = new System.Drawing.Point(40, 77);
            this.txtbx_emailForgotPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_emailForgotPassword.Name = "txtbx_emailForgotPassword";
            this.txtbx_emailForgotPassword.Size = new System.Drawing.Size(176, 20);
            this.txtbx_emailForgotPassword.TabIndex = 4;
            // 
            // lbl_enterEmailForgotPassword
            // 
            this.lbl_enterEmailForgotPassword.AutoSize = true;
            this.lbl_enterEmailForgotPassword.Location = new System.Drawing.Point(38, 63);
            this.lbl_enterEmailForgotPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_enterEmailForgotPassword.Name = "lbl_enterEmailForgotPassword";
            this.lbl_enterEmailForgotPassword.Size = new System.Drawing.Size(60, 13);
            this.lbl_enterEmailForgotPassword.TabIndex = 3;
            this.lbl_enterEmailForgotPassword.Text = "Enter Email";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTitle.Location = new System.Drawing.Point(35, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(159, 25);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Forgot Password";
            // 
            // txtForgotPasswordAnswer
            // 
            this.txtForgotPasswordAnswer.Location = new System.Drawing.Point(39, 131);
            this.txtForgotPasswordAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.txtForgotPasswordAnswer.Name = "txtForgotPasswordAnswer";
            this.txtForgotPasswordAnswer.Size = new System.Drawing.Size(268, 20);
            this.txtForgotPasswordAnswer.TabIndex = 8;
            this.txtForgotPasswordAnswer.Visible = false;
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
            // lblForgotPasswordQuestion
            // 
            this.lblForgotPasswordQuestion.Location = new System.Drawing.Point(36, 116);
            this.lblForgotPasswordQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForgotPasswordQuestion.Name = "lblForgotPasswordQuestion";
            this.lblForgotPasswordQuestion.Size = new System.Drawing.Size(271, 13);
            this.lblForgotPasswordQuestion.TabIndex = 9;
            this.lblForgotPasswordQuestion.Text = "Question";
            // 
            // lblForgotPasswordError
            // 
            this.lblForgotPasswordError.ForeColor = System.Drawing.Color.Crimson;
            this.lblForgotPasswordError.Location = new System.Drawing.Point(38, 164);
            this.lblForgotPasswordError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForgotPasswordError.Name = "lblForgotPasswordError";
            this.lblForgotPasswordError.Size = new System.Drawing.Size(271, 13);
            this.lblForgotPasswordError.TabIndex = 10;
            // 
            // ctrlForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblForgotPasswordError);
            this.Controls.Add(this.lblForgotPasswordQuestion);
            this.Controls.Add(this.txtForgotPasswordAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btn_confirmEmailForgotPassword);
            this.Controls.Add(this.txtbx_emailForgotPassword);
            this.Controls.Add(this.lbl_enterEmailForgotPassword);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ctrlForgotPass";
            this.Size = new System.Drawing.Size(372, 196);
            this.Load += new System.EventHandler(this.ctrlForgotPass_Load);
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
        private System.Windows.Forms.Label lblForgotPasswordError;
    }
}
