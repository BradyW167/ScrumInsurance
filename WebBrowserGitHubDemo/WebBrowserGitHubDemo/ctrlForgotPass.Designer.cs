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
            this.SuspendLayout();
            // 
            // btn_confirmEmailForgotPassword
            // 
            this.btn_confirmEmailForgotPassword.Location = new System.Drawing.Point(150, 95);
            this.btn_confirmEmailForgotPassword.Margin = new System.Windows.Forms.Padding(4);
            this.btn_confirmEmailForgotPassword.Name = "btn_confirmEmailForgotPassword";
            this.btn_confirmEmailForgotPassword.Size = new System.Drawing.Size(100, 28);
            this.btn_confirmEmailForgotPassword.TabIndex = 5;
            this.btn_confirmEmailForgotPassword.Text = "Confirm";
            this.btn_confirmEmailForgotPassword.UseVisualStyleBackColor = true;
            // 
            // txtbx_emailForgotPassword
            // 
            this.txtbx_emailForgotPassword.Location = new System.Drawing.Point(53, 95);
            this.txtbx_emailForgotPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbx_emailForgotPassword.Name = "txtbx_emailForgotPassword";
            this.txtbx_emailForgotPassword.Size = new System.Drawing.Size(89, 22);
            this.txtbx_emailForgotPassword.TabIndex = 4;
            // 
            // lbl_enterEmailForgotPassword
            // 
            this.lbl_enterEmailForgotPassword.AutoSize = true;
            this.lbl_enterEmailForgotPassword.Location = new System.Drawing.Point(50, 77);
            this.lbl_enterEmailForgotPassword.Name = "lbl_enterEmailForgotPassword";
            this.lbl_enterEmailForgotPassword.Size = new System.Drawing.Size(75, 16);
            this.lbl_enterEmailForgotPassword.TabIndex = 3;
            this.lbl_enterEmailForgotPassword.Text = "Enter Email";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTitle.Location = new System.Drawing.Point(47, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(203, 29);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Forgot Password";
            // 
            // ctrlForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btn_confirmEmailForgotPassword);
            this.Controls.Add(this.txtbx_emailForgotPassword);
            this.Controls.Add(this.lbl_enterEmailForgotPassword);
            this.Name = "ctrlForgotPass";
            this.Size = new System.Drawing.Size(300, 200);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_confirmEmailForgotPassword;
        private System.Windows.Forms.TextBox txtbx_emailForgotPassword;
        private System.Windows.Forms.Label lbl_enterEmailForgotPassword;
        private System.Windows.Forms.Label lblTitle;
    }
}
