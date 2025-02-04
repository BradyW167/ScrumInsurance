namespace WebBrowserGitHubDemo
{
    partial class ForgotPassword
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_verify = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_verify = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_Registration = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(38, 24);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(221, 29);
            this.lbl_user.TabIndex = 0;
            this.lbl_user.Text = "Create a Username";
            this.lbl_user.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(38, 90);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(217, 29);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Create a Password";
            this.lbl_password.Click += new System.EventHandler(this.lbl_password_Click);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(38, 220);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(137, 29);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "Enter Email";
            this.lbl_email.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lbl_verify
            // 
            this.lbl_verify.AutoSize = true;
            this.lbl_verify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_verify.Location = new System.Drawing.Point(38, 159);
            this.lbl_verify.Name = "lbl_verify";
            this.lbl_verify.Size = new System.Drawing.Size(220, 29);
            this.lbl_verify.TabIndex = 3;
            this.lbl_verify.Text = "Re-enter Password";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(43, 56);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(269, 26);
            this.txt_user.TabIndex = 4;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(43, 130);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(269, 26);
            this.txt_pass.TabIndex = 5;
            // 
            // txt_verify
            // 
            this.txt_verify.Location = new System.Drawing.Point(43, 191);
            this.txt_verify.Name = "txt_verify";
            this.txt_verify.Size = new System.Drawing.Size(269, 26);
            this.txt_verify.TabIndex = 6;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(43, 262);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(269, 26);
            this.txt_email.TabIndex = 7;
            // 
            // lbl_Registration
            // 
            this.lbl_Registration.AutoSize = true;
            this.lbl_Registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Registration.Location = new System.Drawing.Point(372, 24);
            this.lbl_Registration.Name = "lbl_Registration";
            this.lbl_Registration.Size = new System.Drawing.Size(489, 164);
            this.lbl_Registration.TabIndex = 8;
            this.lbl_Registration.Text = "New Account \r\nRegistration";
            this.lbl_Registration.Click += new System.EventHandler(this.lbl_Registration_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(43, 346);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(187, 69);
            this.btn_submit.TabIndex = 9;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            // 
            // ForgotPassword
            // 
            this.ClientSize = new System.Drawing.Size(873, 470);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.lbl_Registration);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_verify);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lbl_verify);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_user);
            this.Name = "ForgotPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_verify;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_verify;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_Registration;
        private System.Windows.Forms.Button btn_submit;
    }
}