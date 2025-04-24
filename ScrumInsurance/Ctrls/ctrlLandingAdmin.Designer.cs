namespace ScrumInsurance.Ctrls
{
    partial class ctrlLandingAdmin
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
            this.txtInputUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.dgvUserinfo = new System.Windows.Forms.DataGridView();
            this.cmbSelectRole = new System.Windows.Forms.ComboBox();
            this.lblSelectRole = new System.Windows.Forms.Label();
            this.pbxPillar2 = new System.Windows.Forms.PictureBox();
            this.btnCommit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPillar2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInputUser
            // 
            this.txtInputUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputUser.Location = new System.Drawing.Point(283, 81);
            this.txtInputUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtInputUser.Name = "txtInputUser";
            this.txtInputUser.Size = new System.Drawing.Size(200, 30);
            this.txtInputUser.TabIndex = 1;
            this.txtInputUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInputUser_KeyDown);
            this.txtInputUser.Leave += new System.EventHandler(this.txtInputUser_Leave);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUser.Location = new System.Drawing.Point(281, 60);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(111, 17);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Enter Username";
            // 
            // dgvUserinfo
            // 
            this.dgvUserinfo.AllowUserToAddRows = false;
            this.dgvUserinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserinfo.Location = new System.Drawing.Point(133, 135);
            this.dgvUserinfo.Margin = new System.Windows.Forms.Padding(0);
            this.dgvUserinfo.Name = "dgvUserinfo";
            this.dgvUserinfo.RowHeadersWidth = 62;
            this.dgvUserinfo.RowTemplate.Height = 28;
            this.dgvUserinfo.Size = new System.Drawing.Size(814, 377);
            this.dgvUserinfo.TabIndex = 3;
            this.dgvUserinfo.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserinfo_CellValueChanged);
            // 
            // cmbSelectRole
            // 
            this.cmbSelectRole.DropDownHeight = 100;
            this.cmbSelectRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectRole.DropDownWidth = 200;
            this.cmbSelectRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectRole.FormattingEnabled = true;
            this.cmbSelectRole.IntegralHeight = false;
            this.cmbSelectRole.ItemHeight = 25;
            this.cmbSelectRole.Location = new System.Drawing.Point(586, 79);
            this.cmbSelectRole.Margin = new System.Windows.Forms.Padding(0);
            this.cmbSelectRole.Name = "cmbSelectRole";
            this.cmbSelectRole.Size = new System.Drawing.Size(200, 33);
            this.cmbSelectRole.TabIndex = 83;
            this.cmbSelectRole.SelectionChangeCommitted += new System.EventHandler(this.cmbSelectRole_SelectionChangeCommitted);
            // 
            // lblSelectRole
            // 
            this.lblSelectRole.AutoSize = true;
            this.lblSelectRole.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblSelectRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSelectRole.Location = new System.Drawing.Point(583, 60);
            this.lblSelectRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectRole.Name = "lblSelectRole";
            this.lblSelectRole.Size = new System.Drawing.Size(80, 17);
            this.lblSelectRole.TabIndex = 84;
            this.lblSelectRole.Text = "Select Role";
            // 
            // pbxPillar2
            // 
            this.pbxPillar2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pbxPillar2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxPillar2.Location = new System.Drawing.Point(30, 30);
            this.pbxPillar2.Margin = new System.Windows.Forms.Padding(2);
            this.pbxPillar2.Name = "pbxPillar2";
            this.pbxPillar2.Size = new System.Drawing.Size(1020, 547);
            this.pbxPillar2.TabIndex = 82;
            this.pbxPillar2.TabStop = false;
            // 
            // btnCommit
            // 
            this.btnCommit.AutoSize = true;
            this.btnCommit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCommit.Location = new System.Drawing.Point(453, 527);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(174, 35);
            this.btnCommit.TabIndex = 85;
            this.btnCommit.Text = "Commit Changes";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // ctrlLandingAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.lblSelectRole);
            this.Controls.Add(this.cmbSelectRole);
            this.Controls.Add(this.dgvUserinfo);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtInputUser);
            this.Controls.Add(this.pbxPillar2);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ctrlLandingAdmin";
            this.Size = new System.Drawing.Size(1080, 607);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPillar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtInputUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.DataGridView dgvUserinfo;
        private System.Windows.Forms.PictureBox pbxPillar2;
        private System.Windows.Forms.ComboBox cmbSelectRole;
        private System.Windows.Forms.Label lblSelectRole;
        private System.Windows.Forms.Button btnCommit;
    }
}
