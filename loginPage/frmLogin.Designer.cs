namespace LoginPage
{
    partial class frmLogin : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnLogin = new Button();
            txtUsername = new TextBox();
            btnClear = new Button();
            lblWelcom = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lblUsername = new Label();
            lblPassword = new Label();
            btnExit = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtPassword = new TextBox();
            lblErrorUsername = new Label();
            lblErrorPassword = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(350, 277);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(107, 40);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnHome_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(264, 133);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(277, 27);
            txtUsername.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(350, 323);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(107, 40);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblWelcom
            // 
            lblWelcom.AutoSize = true;
            lblWelcom.Font = new Font("Segoe UI", 18F);
            lblWelcom.ForeColor = Color.PaleVioletRed;
            lblWelcom.Location = new Point(208, 9);
            lblWelcom.Name = "lblWelcom";
            lblWelcom.Size = new Size(384, 41);
            lblWelcom.TabIndex = 5;
            lblWelcom.Text = "Welcome to the Login Page";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(264, 110);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(264, 187);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(350, 369);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(107, 40);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(264, 210);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(277, 27);
            txtPassword.TabIndex = 2;
            // 
            // lblErrorUsername
            // 
            lblErrorUsername.AutoSize = true;
            lblErrorUsername.ForeColor = Color.Red;
            lblErrorUsername.Location = new Point(547, 133);
            lblErrorUsername.Name = "lblErrorUsername";
            lblErrorUsername.Size = new Size(15, 20);
            lblErrorUsername.TabIndex = 10;
            lblErrorUsername.Text = "*";
            lblErrorUsername.Click += label1_Click;
            // 
            // lblErrorPassword
            // 
            lblErrorPassword.AutoSize = true;
            lblErrorPassword.ForeColor = Color.Red;
            lblErrorPassword.Location = new Point(547, 210);
            lblErrorPassword.Name = "lblErrorPassword";
            lblErrorPassword.Size = new Size(15, 20);
            lblErrorPassword.TabIndex = 11;
            lblErrorPassword.Text = "*";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblErrorPassword);
            Controls.Add(lblErrorUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnExit);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblWelcom);
            Controls.Add(btnClear);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            Name = "frmLogin";
            Text = "Login Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLogin;
        private TextBox txtUsername;
        private Button btnClear;
        private Label lblWelcom;
        private System.Windows.Forms.Timer timer1;
        private Label lblUsername;
        private Label lblPassword;
        private Button btnExit;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtPassword;
        private Label lblErrorUsername;
        private Label lblErrorPassword;
    }
}
