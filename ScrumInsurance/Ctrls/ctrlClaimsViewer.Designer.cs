namespace ScrumInsurance.Ctrls
{
    partial class ctrlClaimViewer
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
            this.lblClaimViewer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnViewDocs = new System.Windows.Forms.Button();
            this.btnCProfile = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.lblClaimAmount = new System.Windows.Forms.Label();
            this.lblClaimStatus = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblStatusType = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.rtxDetails = new System.Windows.Forms.RichTextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblClaimDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClaimViewer
            // 
            this.lblClaimViewer.AutoSize = true;
            this.lblClaimViewer.BackColor = System.Drawing.Color.Transparent;
            this.lblClaimViewer.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblClaimViewer.Location = new System.Drawing.Point(418, 64);
            this.lblClaimViewer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClaimViewer.Name = "lblClaimViewer";
            this.lblClaimViewer.Size = new System.Drawing.Size(147, 26);
            this.lblClaimViewer.TabIndex = 0;
            this.lblClaimViewer.Text = "Viewing Claim";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox1.Location = new System.Drawing.Point(417, 91);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 332);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.Azure;
            this.btnReject.Location = new System.Drawing.Point(687, 393);
            this.btnReject.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(60, 23);
            this.btnReject.TabIndex = 2;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.Azure;
            this.btnApprove.Location = new System.Drawing.Point(623, 393);
            this.btnApprove.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(60, 23);
            this.btnApprove.TabIndex = 3;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnViewDocs
            // 
            this.btnViewDocs.BackColor = System.Drawing.Color.Azure;
            this.btnViewDocs.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewDocs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDocs.Font = new System.Drawing.Font("Microsoft Tai Le", 7F);
            this.btnViewDocs.Location = new System.Drawing.Point(432, 105);
            this.btnViewDocs.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnViewDocs.Name = "btnViewDocs";
            this.btnViewDocs.Size = new System.Drawing.Size(67, 25);
            this.btnViewDocs.TabIndex = 5;
            this.btnViewDocs.Text = "Client Forms";
            this.btnViewDocs.UseVisualStyleBackColor = false;
            // 
            // btnCProfile
            // 
            this.btnCProfile.BackColor = System.Drawing.Color.Azure;
            this.btnCProfile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCProfile.Font = new System.Drawing.Font("Microsoft Tai Le", 7F);
            this.btnCProfile.Location = new System.Drawing.Point(432, 133);
            this.btnCProfile.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCProfile.Name = "btnCProfile";
            this.btnCProfile.Size = new System.Drawing.Size(67, 25);
            this.btnCProfile.TabIndex = 6;
            this.btnCProfile.Text = "Client Profile";
            this.btnCProfile.UseVisualStyleBackColor = false;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Azure;
            this.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(432, 161);
            this.btnReport.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(67, 52);
            this.btnReport.TabIndex = 7;
            this.btnReport.Text = "Create Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // lblClaimAmount
            // 
            this.lblClaimAmount.AutoSize = true;
            this.lblClaimAmount.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClaimAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaimAmount.Location = new System.Drawing.Point(509, 179);
            this.lblClaimAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClaimAmount.Name = "lblClaimAmount";
            this.lblClaimAmount.Size = new System.Drawing.Size(111, 17);
            this.lblClaimAmount.TabIndex = 8;
            this.lblClaimAmount.Text = "Claim Amount:";
            this.lblClaimAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblClaimStatus
            // 
            this.lblClaimStatus.AutoSize = true;
            this.lblClaimStatus.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClaimStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaimStatus.Location = new System.Drawing.Point(515, 130);
            this.lblClaimStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClaimStatus.Name = "lblClaimStatus";
            this.lblClaimStatus.Size = new System.Drawing.Size(103, 17);
            this.lblClaimStatus.TabIndex = 9;
            this.lblClaimStatus.Text = "Claim Status:";
            this.lblClaimStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.Azure;
            this.btnTransfer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.Location = new System.Drawing.Point(432, 218);
            this.btnTransfer.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(67, 52);
            this.btnTransfer.TabIndex = 11;
            this.btnTransfer.Text = "Send to Finance";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(519, 105);
            this.lblClientName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(100, 17);
            this.lblClientName.TabIndex = 12;
            this.lblClientName.Text = "Client Name:";
            // 
            // lblStatusType
            // 
            this.lblStatusType.AutoSize = true;
            this.lblStatusType.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblStatusType.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusType.ForeColor = System.Drawing.Color.Olive;
            this.lblStatusType.Location = new System.Drawing.Point(615, 130);
            this.lblStatusType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatusType.Name = "lblStatusType";
            this.lblStatusType.Size = new System.Drawing.Size(58, 18);
            this.lblStatusType.TabIndex = 13;
            this.lblStatusType.Text = "Pending";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.Black;
            this.lblAmount.Location = new System.Drawing.Point(615, 179);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(96, 18);
            this.lblAmount.TabIndex = 14;
            this.lblAmount.Text = "Undetermined";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(615, 105);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 18);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "John Smith";
            // 
            // rtxDetails
            // 
            this.rtxDetails.BackColor = System.Drawing.Color.Azure;
            this.rtxDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxDetails.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxDetails.Location = new System.Drawing.Point(511, 205);
            this.rtxDetails.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rtxDetails.Name = "rtxDetails";
            this.rtxDetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxDetails.Size = new System.Drawing.Size(235, 129);
            this.rtxDetails.TabIndex = 16;
            this.rtxDetails.Text = "Here is some default text. This will be filled with the user given claim details." +
    " This cannot be edited by the CManager and is simply here to display text while " +
    "having a scroll option. ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(615, 155);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 18);
            this.lblDate.TabIndex = 116;
            this.lblDate.Text = "1/12/25";
            // 
            // lblClaimDate
            // 
            this.lblClaimDate.AutoSize = true;
            this.lblClaimDate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClaimDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaimDate.Location = new System.Drawing.Point(526, 155);
            this.lblClaimDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClaimDate.Name = "lblClaimDate";
            this.lblClaimDate.Size = new System.Drawing.Size(91, 17);
            this.lblClaimDate.TabIndex = 115;
            this.lblClaimDate.Text = "Claim Date:";
            // 
            // ctrlClaimViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblClaimDate);
            this.Controls.Add(this.rtxDetails);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblStatusType);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.lblClaimStatus);
            this.Controls.Add(this.lblClaimAmount);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnCProfile);
            this.Controls.Add(this.btnViewDocs);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.lblClaimViewer);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ctrlClaimViewer";
            this.Size = new System.Drawing.Size(1080, 607);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClaimViewer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnViewDocs;
        private System.Windows.Forms.Button btnCProfile;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label lblClaimAmount;
        private System.Windows.Forms.Label lblClaimStatus;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblStatusType;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RichTextBox rtxDetails;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblClaimDate;
    }
}
