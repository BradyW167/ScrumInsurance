namespace WebBrowserApplication
{
    partial class Web
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
            btnExit = new Button();
            btnRefresh = new Button();
            btnHome = new Button();
            txtSearch = new TextBox();
            btnClear = new Button();
            lblWelcom = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(696, 14);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(74, 37);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(25, 14);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 38);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(438, 240);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(107, 40);
            btnHome.TabIndex = 2;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(268, 192);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(277, 27);
            txtSearch.TabIndex = 3;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(268, 240);
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
            lblWelcom.Location = new Point(215, 131);
            lblWelcom.Name = "lblWelcom";
            lblWelcom.Size = new Size(415, 41);
            lblWelcom.TabIndex = 5;
            lblWelcom.Text = "Welcome To the Web Browser";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(48, 23);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(65, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Click me";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Web
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(lblWelcom);
            Controls.Add(btnClear);
            Controls.Add(txtSearch);
            Controls.Add(btnHome);
            Controls.Add(btnRefresh);
            Controls.Add(btnExit);
            Name = "Web";
            Text = "Web";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnRefresh;
        private Button btnHome;
        private TextBox txtSearch;
        private Button btnClear;
        private Label lblWelcom;
        private System.Windows.Forms.Timer timer1;
        private LinkLabel linkLabel1;
    }
}
