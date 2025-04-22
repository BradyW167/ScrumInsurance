namespace ScrumInsurance.Ctrls
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
            this.txtInputUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.dgvUserinfo = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbxPillar2 = new System.Windows.Forms.PictureBox();
            this.cmbSelectRole = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPillar2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(400, 59);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(281, 34);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Admin Landing Page";
            // 
            // txtInputUser
            // 
            this.txtInputUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputUser.Location = new System.Drawing.Point(360, 116);
            this.txtInputUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtInputUser.Name = "txtInputUser";
            this.txtInputUser.Size = new System.Drawing.Size(123, 30);
            this.txtInputUser.TabIndex = 1;
            this.txtInputUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInputUser_KeyDown);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUser.Location = new System.Drawing.Point(358, 97);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(111, 17);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Enter Username";
            // 
            // dgvUserinfo
            // 
            this.dgvUserinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Password,
            this.Email,
            this.Question,
            this.Answer});
            this.dgvUserinfo.Location = new System.Drawing.Point(133, 171);
            this.dgvUserinfo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUserinfo.Name = "dgvUserinfo";
            this.dgvUserinfo.RowHeadersWidth = 62;
            this.dgvUserinfo.RowTemplate.Height = 28;
            this.dgvUserinfo.Size = new System.Drawing.Size(814, 377);
            this.dgvUserinfo.TabIndex = 3;
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
            // pbxPillar2
            // 
            this.pbxPillar2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pbxPillar2.Location = new System.Drawing.Point(30, 30);
            this.pbxPillar2.Margin = new System.Windows.Forms.Padding(2);
            this.pbxPillar2.Name = "pbxPillar2";
            this.pbxPillar2.Size = new System.Drawing.Size(1020, 547);
            this.pbxPillar2.TabIndex = 82;
            this.pbxPillar2.TabStop = false;
            // 
            // cmbSelectRole
            // 
            this.cmbSelectRole.DropDownHeight = 80;
            this.cmbSelectRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectRole.DropDownWidth = 365;
            this.cmbSelectRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectRole.FormattingEnabled = true;
            this.cmbSelectRole.IntegralHeight = false;
            this.cmbSelectRole.ItemHeight = 25;
            this.cmbSelectRole.Location = new System.Drawing.Point(533, 113);
            this.cmbSelectRole.Margin = new System.Windows.Forms.Padding(0);
            this.cmbSelectRole.Name = "cmbSelectRole";
            this.cmbSelectRole.Size = new System.Drawing.Size(265, 33);
            this.cmbSelectRole.TabIndex = 83;
            this.cmbSelectRole.SelectionChangeCommitted += new System.EventHandler(this.cmbSelectRole_SelectionChangeCommitted);
            // 
            // ctrlAdminLanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.cmbSelectRole);
            this.Controls.Add(this.dgvUserinfo);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtInputUser);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pbxPillar2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ctrlAdminLanding";
            this.Size = new System.Drawing.Size(1080, 607);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPillar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtInputUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.DataGridView dgvUserinfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
        private System.Windows.Forms.PictureBox pbxPillar2;
        private System.Windows.Forms.ComboBox cmbSelectRole;
    }
}
