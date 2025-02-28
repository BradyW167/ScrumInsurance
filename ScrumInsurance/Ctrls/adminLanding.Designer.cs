namespace ScrumInsurance.Ctrls
{
    partial class adminLanding
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtUserToView = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.dgUserinfo = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSubmitUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(185, 25);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(288, 35);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Admin Landing Page";
            // 
            // txtUserToView
            // 
            this.txtUserToView.Location = new System.Drawing.Point(35, 108);
            this.txtUserToView.Name = "txtUserToView";
            this.txtUserToView.Size = new System.Drawing.Size(182, 26);
            this.txtUserToView.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(37, 85);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(157, 20);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Enter user to display:";
            // 
            // dgUserinfo
            // 
            this.dgUserinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUserinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Password,
            this.Email,
            this.Question,
            this.Answer});
            this.dgUserinfo.Location = new System.Drawing.Point(3, 212);
            this.dgUserinfo.Name = "dgUserinfo";
            this.dgUserinfo.RowHeadersWidth = 62;
            this.dgUserinfo.RowTemplate.Height = 28;
            this.dgUserinfo.Size = new System.Drawing.Size(647, 113);
            this.dgUserinfo.TabIndex = 3;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 8;
            this.Username.Name = "Username";
            this.Username.Width = 150;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 8;
            this.Password.Name = "Password";
            this.Password.Width = 150;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.Width = 150;
            // 
            // Question
            // 
            this.Question.HeaderText = "Question";
            this.Question.MinimumWidth = 8;
            this.Question.Name = "Question";
            this.Question.Width = 150;
            // 
            // Answer
            // 
            this.Answer.HeaderText = "Answer";
            this.Answer.MinimumWidth = 8;
            this.Answer.Name = "Answer";
            this.Answer.Width = 150;
            // 
            // btnSubmitUser
            // 
            this.btnSubmitUser.Location = new System.Drawing.Point(223, 99);
            this.btnSubmitUser.Name = "btnSubmitUser";
            this.btnSubmitUser.Size = new System.Drawing.Size(75, 45);
            this.btnSubmitUser.TabIndex = 4;
            this.btnSubmitUser.Text = "Enter";
            this.btnSubmitUser.UseVisualStyleBackColor = true;
            this.btnSubmitUser.Click += new System.EventHandler(this.btnSubmitUser_Click);
            // 
            // adminLanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.btnSubmitUser);
            this.Controls.Add(this.dgUserinfo);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtUserToView);
            this.Controls.Add(this.lblHeader);
            this.Name = "adminLanding";
            this.Size = new System.Drawing.Size(653, 582);
            ((System.ComponentModel.ISupportInitialize)(this.dgUserinfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtUserToView;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.DataGridView dgUserinfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
        private System.Windows.Forms.Button btnSubmitUser;
    }
}
