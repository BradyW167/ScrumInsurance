namespace ScrumInsurance
{
    partial class ctrlLanding
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
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.tblQueryOutput = new System.Windows.Forms.DataGridView();
            this.rtxtQuery = new System.Windows.Forms.RichTextBox();
            this.lblEnterQuery = new System.Windows.Forms.Label();
            this.btnSubmitQuery = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblQueryOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.Location = new System.Drawing.Point(567, 33);
            this.lblLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(66, 20);
            this.lblLogout.TabIndex = 0;
            this.lblLogout.Text = "Log Out";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(154, 58);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(343, 82);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome";
            // 
            // lblUser
            // 
            this.lblUser.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblUser.Location = new System.Drawing.Point(550, 13);
            this.lblUser.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblUser.MaximumSize = new System.Drawing.Size(100, 20);
            this.lblUser.MinimumSize = new System.Drawing.Size(100, 20);
            this.lblUser.Name = "lblUser";
            this.lblUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUser.Size = new System.Drawing.Size(100, 20);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "testing";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tblQueryOutput
            // 
            this.tblQueryOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblQueryOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.tblQueryOutput.Location = new System.Drawing.Point(37, 316);
            this.tblQueryOutput.Name = "tblQueryOutput";
            this.tblQueryOutput.RowHeadersWidth = 62;
            this.tblQueryOutput.RowTemplate.Height = 28;
            this.tblQueryOutput.Size = new System.Drawing.Size(596, 259);
            this.tblQueryOutput.TabIndex = 3;
            // 
            // rtxtQuery
            // 
            this.rtxtQuery.Location = new System.Drawing.Point(168, 179);
            this.rtxtQuery.Name = "rtxtQuery";
            this.rtxtQuery.Size = new System.Drawing.Size(329, 110);
            this.rtxtQuery.TabIndex = 4;
            this.rtxtQuery.Text = "";
            // 
            // lblEnterQuery
            // 
            this.lblEnterQuery.AutoSize = true;
            this.lblEnterQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterQuery.Location = new System.Drawing.Point(167, 154);
            this.lblEnterQuery.Name = "lblEnterQuery";
            this.lblEnterQuery.Size = new System.Drawing.Size(324, 22);
            this.lblEnterQuery.TabIndex = 5;
            this.lblEnterQuery.Text = "Please Enter your database Query:";
            // 
            // btnSubmitQuery
            // 
            this.btnSubmitQuery.Location = new System.Drawing.Point(503, 213);
            this.btnSubmitQuery.Name = "btnSubmitQuery";
            this.btnSubmitQuery.Size = new System.Drawing.Size(82, 37);
            this.btnSubmitQuery.TabIndex = 6;
            this.btnSubmitQuery.Text = "Submit";
            this.btnSubmitQuery.UseVisualStyleBackColor = true;
            this.btnSubmitQuery.Click += new System.EventHandler(this.button1_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // ctrlLanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnSubmitQuery);
            this.Controls.Add(this.lblEnterQuery);
            this.Controls.Add(this.rtxtQuery);
            this.Controls.Add(this.tblQueryOutput);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblLogout);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ctrlLanding";
            this.Size = new System.Drawing.Size(675, 692);
            ((System.ComponentModel.ISupportInitialize)(this.tblQueryOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.DataGridView tblQueryOutput;
        private System.Windows.Forms.RichTextBox rtxtQuery;
        private System.Windows.Forms.Label lblEnterQuery;
        private System.Windows.Forms.Button btnSubmitQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
