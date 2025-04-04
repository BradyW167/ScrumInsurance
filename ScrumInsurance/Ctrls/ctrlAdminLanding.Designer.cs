namespace ScrumInsurance
{
    partial class ctrlAdminLanding
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
            this.lblClaim4 = new System.Windows.Forms.Label();
            this.lblClaim3 = new System.Windows.Forms.Label();
            this.lblClaim2 = new System.Windows.Forms.Label();
            this.lblMyClaims = new System.Windows.Forms.Label();
            this.lblClaim1 = new System.Windows.Forms.Label();
            this.pbxSidePanel = new System.Windows.Forms.PictureBox();
            this.pbxBottomPanel = new System.Windows.Forms.PictureBox();
            this.btnLogo = new System.Windows.Forms.PictureBox();
            this.lblTrademark = new System.Windows.Forms.Label();
            this.lblBottomInformation = new System.Windows.Forms.Label();
            this.pbxPillar2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSidePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBottomPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPillar2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(695, 135);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(252, 31);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Admin Landing Page";
            // 
            // txtUserToView
            // 
            this.txtUserToView.Location = new System.Drawing.Point(607, 235);
            this.txtUserToView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserToView.Name = "txtUserToView";
            this.txtUserToView.Size = new System.Drawing.Size(163, 22);
            this.txtUserToView.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblUser.Location = new System.Drawing.Point(609, 217);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(131, 16);
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
            this.dgUserinfo.Location = new System.Drawing.Point(521, 327);
            this.dgUserinfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgUserinfo.Name = "dgUserinfo";
            this.dgUserinfo.RowHeadersWidth = 62;
            this.dgUserinfo.RowTemplate.Height = 28;
            this.dgUserinfo.Size = new System.Drawing.Size(575, 90);
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
            this.btnSubmitUser.Location = new System.Drawing.Point(775, 228);
            this.btnSubmitUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmitUser.Name = "btnSubmitUser";
            this.btnSubmitUser.Size = new System.Drawing.Size(67, 36);
            this.btnSubmitUser.TabIndex = 4;
            this.btnSubmitUser.Text = "Enter";
            this.btnSubmitUser.UseVisualStyleBackColor = true;
            this.btnSubmitUser.Click += new System.EventHandler(this.btnSubmitUser_Click);
            // 
            // lblClaim4
            // 
            this.lblClaim4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblClaim4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClaim4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblClaim4.ForeColor = System.Drawing.Color.Black;
            this.lblClaim4.Location = new System.Drawing.Point(4, 246);
            this.lblClaim4.Name = "lblClaim4";
            this.lblClaim4.Size = new System.Drawing.Size(127, 37);
            this.lblClaim4.TabIndex = 79;
            this.lblClaim4.Text = "Unnamed Claim\r\nStatus: Incomplete";
            // 
            // lblClaim3
            // 
            this.lblClaim3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblClaim3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClaim3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblClaim3.ForeColor = System.Drawing.Color.Black;
            this.lblClaim3.Location = new System.Drawing.Point(4, 197);
            this.lblClaim3.Name = "lblClaim3";
            this.lblClaim3.Size = new System.Drawing.Size(127, 37);
            this.lblClaim3.TabIndex = 78;
            this.lblClaim3.Text = "Unnamed Claim\r\nStatus: Incomplete";
            // 
            // lblClaim2
            // 
            this.lblClaim2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblClaim2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClaim2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblClaim2.ForeColor = System.Drawing.Color.Black;
            this.lblClaim2.Location = new System.Drawing.Point(4, 148);
            this.lblClaim2.Name = "lblClaim2";
            this.lblClaim2.Size = new System.Drawing.Size(127, 37);
            this.lblClaim2.TabIndex = 77;
            this.lblClaim2.Text = "Unnamed Claim\r\nStatus: Incomplete";
            // 
            // lblMyClaims
            // 
            this.lblMyClaims.AutoSize = true;
            this.lblMyClaims.BackColor = System.Drawing.Color.Black;
            this.lblMyClaims.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblMyClaims.ForeColor = System.Drawing.Color.White;
            this.lblMyClaims.Location = new System.Drawing.Point(3, 64);
            this.lblMyClaims.Name = "lblMyClaims";
            this.lblMyClaims.Size = new System.Drawing.Size(71, 25);
            this.lblMyClaims.TabIndex = 76;
            this.lblMyClaims.Text = "To Do";
            // 
            // lblClaim1
            // 
            this.lblClaim1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblClaim1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClaim1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblClaim1.ForeColor = System.Drawing.Color.Black;
            this.lblClaim1.Location = new System.Drawing.Point(4, 98);
            this.lblClaim1.Name = "lblClaim1";
            this.lblClaim1.Size = new System.Drawing.Size(127, 37);
            this.lblClaim1.TabIndex = 75;
            this.lblClaim1.Text = "Unnamed Claim\r\nStatus: Incomplete";
            // 
            // pbxSidePanel
            // 
            this.pbxSidePanel.BackColor = System.Drawing.Color.Black;
            this.pbxSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxSidePanel.Location = new System.Drawing.Point(0, 0);
            this.pbxSidePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxSidePanel.Name = "pbxSidePanel";
            this.pbxSidePanel.Size = new System.Drawing.Size(133, 562);
            this.pbxSidePanel.TabIndex = 74;
            this.pbxSidePanel.TabStop = false;
            // 
            // pbxBottomPanel
            // 
            this.pbxBottomPanel.BackColor = System.Drawing.Color.Black;
            this.pbxBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbxBottomPanel.Location = new System.Drawing.Point(0, 562);
            this.pbxBottomPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxBottomPanel.Name = "pbxBottomPanel";
            this.pbxBottomPanel.Size = new System.Drawing.Size(1440, 185);
            this.pbxBottomPanel.TabIndex = 73;
            this.pbxBottomPanel.TabStop = false;
            // 
            // btnLogo
            // 
            this.btnLogo.BackColor = System.Drawing.Color.Black;
            this.btnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogo.Image = global::ScrumInsurance.Properties.Resources.scrum_logo;
            this.btnLogo.Location = new System.Drawing.Point(0, 0);
            this.btnLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(87, 49);
            this.btnLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogo.TabIndex = 72;
            this.btnLogo.TabStop = false;
            // 
            // lblTrademark
            // 
            this.lblTrademark.AutoSize = true;
            this.lblTrademark.BackColor = System.Drawing.Color.Black;
            this.lblTrademark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrademark.ForeColor = System.Drawing.Color.White;
            this.lblTrademark.Location = new System.Drawing.Point(656, 677);
            this.lblTrademark.Name = "lblTrademark";
            this.lblTrademark.Size = new System.Drawing.Size(124, 17);
            this.lblTrademark.TabIndex = 81;
            this.lblTrademark.Text = "Scrum Insurance®";
            // 
            // lblBottomInformation
            // 
            this.lblBottomInformation.AutoSize = true;
            this.lblBottomInformation.BackColor = System.Drawing.Color.Black;
            this.lblBottomInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBottomInformation.ForeColor = System.Drawing.Color.White;
            this.lblBottomInformation.Location = new System.Drawing.Point(147, 634);
            this.lblBottomInformation.Name = "lblBottomInformation";
            this.lblBottomInformation.Size = new System.Drawing.Size(1161, 17);
            this.lblBottomInformation.TabIndex = 80;
            this.lblBottomInformation.Text = "Here is where you put all the random links and information that is at the bottom " +
    "of the web page like privacy, terms, about, sponsors, maybe also a disclaimer or" +
    " maintenence message.";
            // 
            // pbxPillar2
            // 
            this.pbxPillar2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pbxPillar2.Location = new System.Drawing.Point(396, 111);
            this.pbxPillar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxPillar2.Name = "pbxPillar2";
            this.pbxPillar2.Size = new System.Drawing.Size(820, 366);
            this.pbxPillar2.TabIndex = 82;
            this.pbxPillar2.TabStop = false;
            // 
            // ctrlAdminLanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.lblTrademark);
            this.Controls.Add(this.lblBottomInformation);
            this.Controls.Add(this.lblClaim4);
            this.Controls.Add(this.lblClaim3);
            this.Controls.Add(this.lblClaim2);
            this.Controls.Add(this.lblMyClaims);
            this.Controls.Add(this.lblClaim1);
            this.Controls.Add(this.pbxSidePanel);
            this.Controls.Add(this.pbxBottomPanel);
            this.Controls.Add(this.btnLogo);
            this.Controls.Add(this.btnSubmitUser);
            this.Controls.Add(this.dgUserinfo);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtUserToView);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pbxPillar2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ctrlAdminLanding";
            this.Size = new System.Drawing.Size(1440, 747);
            ((System.ComponentModel.ISupportInitialize)(this.dgUserinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSidePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBottomPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPillar2)).EndInit();
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
        private System.Windows.Forms.Label lblClaim4;
        private System.Windows.Forms.Label lblClaim3;
        private System.Windows.Forms.Label lblClaim2;
        private System.Windows.Forms.Label lblMyClaims;
        private System.Windows.Forms.Label lblClaim1;
        private System.Windows.Forms.PictureBox pbxSidePanel;
        private System.Windows.Forms.PictureBox pbxBottomPanel;
        private System.Windows.Forms.PictureBox btnLogo;
        private System.Windows.Forms.Label lblTrademark;
        private System.Windows.Forms.Label lblBottomInformation;
        private System.Windows.Forms.PictureBox pbxPillar2;
    }
}
